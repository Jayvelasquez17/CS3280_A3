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
        string[] students;
        int[,] assignments;
        int p = 0;
        int score = 0;
        int assignmentNo;


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(noStudInput.Text) || string.IsNullOrEmpty(noAssignInput.Text) || Convert.ToInt32(noStudInput.Text) > 10 || Convert.ToInt32(noAssignInput.Text) > 99)
            {
                countsErrorLbl.Show();
            }
            else
            {
                countsErrorLbl.Hide();
                students = new string[Convert.ToInt32(noStudInput.Text)];
                assignments = new int[Convert.ToInt32(noStudInput.Text), Convert.ToInt32(noAssignInput.Text)];

                for (int i = 0; i < students.Length; i++)
                {
                    students[i] = "Student #" + (i + 1);
                }

                assignmentNo = (assignments.Length / students.Length);
                studentNameLabel.Text = students[p];
                assignmentNoLbl.Text = "(1 - " + assignmentNo + "):";
            }
        }

        private void testButton_Click(object sender, EventArgs e)
        {
        //    testLabel.Text = students.Length.ToString();
        //    testLabel2.Text = assignments.Length.ToString();
        //    //testAssignmentScore.Text = assignments[p, Convert.ToInt32(assignmentNoInput.Text)].ToString();
        //    score = Convert.ToInt32(assignmentNoInput.Text);
        //    testAssignmentScore.Text = assignments[p, score - 1].ToString();
        //    testStudentName.Text = students[p].ToString();
        }

        private void nextStudButton_Click(object sender, EventArgs e)
        {
            if (p == students.Length-1)
            {
                studentNameLabel.Text = students[p];
            }
            else
            {
                p++;
                studentNameLabel.Text = students[p];
            }
         
        }

        private void prevStudButton_Click(object sender, EventArgs e)
        {
            if (p > 0)
            {
                p--;
                studentNameLabel.Text = students[p];
            }
        }

        private void firstStudButton_Click(object sender, EventArgs e)
        {
            p = 0;
            studentNameLabel.Text = students[p];
        }

        private void lastStudButton_Click(object sender, EventArgs e)
        {
            p = students.Length -1;
            studentNameLabel.Text = students[p];
        }

        private void saveNameButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nameInput.Text))
            {
                emptyNameError.Show();
            }
            else
            {
                emptyNameError.Hide();
                students[p] = nameInput.Text;
                studentNameLabel.Text = students[p];
                nameInput.Clear();
            }
        }

        private void saveScoreButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(assignmentNoInput.Text) || (Convert.ToInt32(assignmentNoInput.Text) > (assignments.Length / students.Length)) )
            {
                enterAssignmentNoError.Show();
            }
            else
            {
                if (string.IsNullOrEmpty(assignmentScoreInput.Text))
                {
                    enterAssignmentNoError.Hide();
                    enterScoreError.Show();
                }
                else
                {
                    enterScoreError.Hide();
                    enterAssignmentNoError.Hide();

                    score = Convert.ToInt32(assignmentNoInput.Text);

                    assignments[p, score - 1] = Convert.ToInt32(assignmentScoreInput.Text); 
                    //assignments[p, Convert.ToInt32(assignmentNoInput.Text)] = Convert.ToInt32(assignmentScoreInput.Text);
                    //assignmentNoInput.Clear();
                    //assignmentScoreInput.Clear();
                }
            }

        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            Array.Clear(students, 0, students.Length);
            Array.Clear(assignments, 0, assignments.Length);
            p = 0;
            score = 0;
            noStudInput.Clear();
            noAssignInput.Clear();
            assignmentNoInput.Clear();
            assignmentScoreInput.Clear();
            scoreBox.Clear();
        }

        private void printBox()
        {
            scoreBox.SelectionTabs = new int[] { 150, 25, 25};
            string[] top = new string[assignmentNo + 3];

            top[0] = "Student";

            double avg = 0;

            for (int i = 1; i < assignmentNo + 3; i++)
            {
                top[i] = "\t#" + i;

            }

            top[assignmentNo + 1] = "\tAVG";
            top[assignmentNo + 2] = "\tGRADE";


            for (int j = 0; j < top.Length; j++)
            {
                scoreBox.AppendText(top[j]);
            }

            scoreBox.AppendText(Environment.NewLine);

            for (int l = 0; l < students.Length; l++)
            {
                scoreBox.AppendText(students[l] + "\t");
                avg = 0;

                for (int k = 0; k < assignmentNo; k++)
                {
                    scoreBox.AppendText(assignments[l, k].ToString() + "\t");

                    avg += assignments[l, k];
                }

                
                scoreBox.AppendText((avg / Convert.ToDouble(assignmentNo)).ToString("00.00") + "\t");

                scoreBox.AppendText(findLetter(avg / Convert.ToDouble(assignmentNo)));

                scoreBox.AppendText(Environment.NewLine);
            }
        }

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

        private void displayButton_Click(object sender, EventArgs e)
        {
            scoreBox.Clear();
            printBox();
        }
    }
}
