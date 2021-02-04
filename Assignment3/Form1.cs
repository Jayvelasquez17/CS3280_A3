using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment3
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Variables used in program
        /// </summary>
        //array that holds student names 
        string[] students;
        //array that holds assignment scores
        int[,] assignments;
        //used to point to position in array
        int p = 0;
        //holds input assignment number
        int assignIn = 0;
        //number of total assignments
        int assignmentNo;


        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Sets the size of students and assignments arrays
        /// Named button1_Click because it was created before renaming of button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            //Checks to make sure student and assignment textboxes are not empty
            //Also checks to make sure max students is 10 and max assignments is 99
            if (string.IsNullOrEmpty(noStudInput.Text) || string.IsNullOrEmpty(noAssignInput.Text) || Convert.ToInt32(noStudInput.Text) > 10 || Convert.ToInt32(noAssignInput.Text) > 99 || Convert.ToInt32(noStudInput.Text) == 0 || Convert.ToInt32(noAssignInput.Text) == 0)
            {
                //Shows error label
                countsErrorLbl.Show();
            }
            else
            {
                //Hide error lablel and initializes student and assignment arrays
                countsErrorLbl.Hide();
                students = new string[Convert.ToInt32(noStudInput.Text)];
                assignments = new int[Convert.ToInt32(noStudInput.Text), Convert.ToInt32(noAssignInput.Text)];

                //Fills student array with default Student # name
                for (int i = 0; i < students.Length; i++)
                {
                    students[i] = "Student #" + (i + 1);
                }

                //Prints default student name and assignment range to respective labels
                validCountError.Hide();
                assignmentNo = (assignments.Length / students.Length);
                studentNameLabel.Text = students[p];
                assignmentNoLbl.Text = "(1 - " + assignmentNo + "):";
            }
        }

        /// <summary>
        /// Sets selected student to next student in array
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nextStudButton_Click(object sender, EventArgs e)
        {
            //Checks to make sure student array is not empty
            if (students == null)
            {
                validCountError.Show();
            }
            else
            {
                //Checks if p is pointing to the last student and prints name if so
                //or increments then prints if not
                if (p == students.Length - 1)
                {
                    studentNameLabel.Text = students[p];
                }
                else
                {
                    //Increments and prints the student name it's pointing to
                    p++;
                    studentNameLabel.Text = students[p];
                }
            }
        }

        /// <summary>
        /// Sets selected student to the previous student in array
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void prevStudButton_Click(object sender, EventArgs e)
        {
            //Checks to make sure student array is not empty
            if (students == null)
            {
                validCountError.Show();
            }
            else
            {
                //Decrements p and prints student name it's pointing to
                if (p > 0)
                {
                    p--;
                    studentNameLabel.Text = students[p];
                }
            }
        }

        /// <summary>
        /// Sets selected student to first student
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void firstStudButton_Click(object sender, EventArgs e)
        {
            //Checks to make sure student array is not empty
            if (students == null)
            {
                validCountError.Show();
            }
            else
            {
                //Sets p to point to first student in array and prints
                p = 0;
                studentNameLabel.Text = students[p];
            }
        }

        /// <summary>
        /// Sets selected student to last student
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lastStudButton_Click(object sender, EventArgs e)
        {
            //Checks to make sure student array is not empty
            if (students == null)
            {
                validCountError.Show();
            }
            else
            {
                //Sets p to point to last student in array and prints
                p = students.Length - 1;
                studentNameLabel.Text = students[p];
            }
        }

        /// <summary>
        /// Saves student name to array
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveNameButton_Click(object sender, EventArgs e)
        {
            if (students == null)
            {
                validCountError.Show();
            }
            else
            {
                //Checks if name input textbox is empty
                if (string.IsNullOrEmpty(nameInput.Text))
                {
                    emptyNameError.Show();
                }
                else
                {
                    //Sets currently selected student name to inputted text and prints to label
                    emptyNameError.Hide();
                    students[p] = nameInput.Text;
                    studentNameLabel.Text = students[p];
                    nameInput.Clear();
                }
            }
        }

        /// <summary>
        /// Saves input score to appropriate location in assignments array
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveScoreButton_Click(object sender, EventArgs e)
        {
            if (students == null)
            {
                validCountError.Show();
            }
            else
            { 
                //Checks if assignment number input textbox is empty
                if (string.IsNullOrEmpty(assignmentNoInput.Text) || (Convert.ToInt32(assignmentNoInput.Text) > (assignments.Length / students.Length)))
                {
                    enterAssignmentNoError.Show();
                }
                else
                {
                    //Checks if assignment score textbox is empty
                    if (string.IsNullOrEmpty(assignmentScoreInput.Text))
                    {
                        enterAssignmentNoError.Hide();
                        enterScoreError.Show();
                    }
                    else
                    {
                        enterScoreError.Hide();
                        enterAssignmentNoError.Hide();

                        //Sets assignIn to assignment number input and
                        //sets assignment score to assignment score input
                        assignIn = Convert.ToInt32(assignmentNoInput.Text);
                        assignments[p, assignIn - 1] = Convert.ToInt32(assignmentScoreInput.Text);
                    }
                }
            }
        }

        /// <summary>
        /// Clears entire form and sets variables to 0
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void resetButton_Click(object sender, EventArgs e)
        {
            if (students == null)
            {
                validCountError.Show();
                noStudInput.Clear();
                noAssignInput.Clear();
                countsErrorLbl.Hide();
                enterAssignmentNoError.Hide();
                enterScoreError.Hide();
                emptyNameError.Hide();
                noStudInput.Clear();
                noAssignInput.Clear();
                assignmentNoInput.Clear();
                assignmentScoreInput.Clear();
            }
            else
            {
                Array.Clear(students, 0, students.Length);
                Array.Clear(assignments, 0, assignments.Length);
                students = null;
                assignments = null; 
                p = 0;
                assignIn = 0;
                noStudInput.Clear();
                noAssignInput.Clear();
                assignmentNoLbl.Text = "-";
                studentNameLabel.Text = "-";
                countsErrorLbl.Hide();
                validCountError.Hide();
                enterAssignmentNoError.Hide();
                enterScoreError.Hide();
                emptyNameError.Hide();
                noStudInput.Clear();
                noAssignInput.Clear();
                assignmentNoInput.Clear();
                assignmentScoreInput.Clear();
                scoreBox.Clear();
            }
        }

        /// <summary>
        /// Prints richtextbox content with student names and scores 
        /// and formats into columns
        /// </summary>
        private void printBox()
        {
            //Sets tab stops for richtextbox
            scoreBox.SelectionTabs = new int[] { 150, 25, 25};
            //Sets size of array that prints column headers
            string[] top = new string[assignmentNo + 3];

            //Sets first value of array to "Student"
            top[0] = "Student";

            //Initializes variable that will hold sum of a student's assignments
            double sum= 0;

            //Sets assignment number column headers in array
            for (int i = 1; i < assignmentNo + 3; i++)
            {
                top[i] = "\t#" + i;

            }

            //Adds AVG and GRADE column headers to array
            top[assignmentNo + 1] = "\tAVG";
            top[assignmentNo + 2] = "\tGRADE";

            //Prints column headers to richtextbox
            for (int j = 0; j < top.Length; j++)
            {
                scoreBox.AppendText(top[j]);
            }

            scoreBox.AppendText(Environment.NewLine);

            //Iterates through students and assignments and prints them to richtextbox
            for (int l = 0; l < students.Length; l++)
            {
                scoreBox.AppendText(students[l] + "\t");
                sum = 0;

                for (int k = 0; k < assignmentNo; k++)
                {
                    scoreBox.AppendText(assignments[l, k].ToString() + "\t");

                    sum += assignments[l, k];
                }

                //Prints student grade average
                scoreBox.AppendText((sum / Convert.ToDouble(assignmentNo)).ToString("00.00") + "\t");

                //Prints student letter grade
                scoreBox.AppendText(findLetter(sum / Convert.ToDouble(assignmentNo)));

                scoreBox.AppendText(Environment.NewLine);
            }
        }

        /// <summary>
        /// Takes student grade average and returns letter grade
        /// </summary>
        /// <param name="g"></param>
        /// <returns></returns>
        string findLetter(double g)
        {
            if (g >= 93.00)
            {
                return "A";
            }
            if(g >= 90.00 && g < 92.90)
            {
                return "A-";
            }
            if (g >= 87.00 && g < 89.90)
            {
                return "B+";
            }
            if (g >= 83.00 && g < 86.90)
            {
                return "B";
            }
            if (g >= 80.00 && g < 82.90)
            {
                return "B-";
            }
            if (g >= 77.00 && g < 79.90)
            {
                return "C+";
            }
            if (g >= 73.00 && g < 76.90)
            {
                return "C";
            }
            if (g >= 70.00 && g < 72.90)
            {
                return "C-";
            }
            if (g >= 67.00 && g < 69.90)
            {
                return "D+";
            }
            if (g >= 63.00 && g < 66.90)
            {
                return "D";
            }
            if (g >= 60.00 && g < 62.90)
            {
                return "D-";
            }
            if (g < 60.00)
            {
                return "E";
            }
            else
            {
                return "NG";
            }
        }

        /// <summary>
        /// Clears scoreBox richtextbox and prints updated info
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void displayButton_Click(object sender, EventArgs e)
        {
            if (students == null)
            {
                validCountError.Show();
            }
            else
            {
                scoreBox.Clear();
                printBox();
            }
        }
    }
}
