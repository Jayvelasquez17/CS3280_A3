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



        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(noStudInput.Text) || string.IsNullOrEmpty(noAssignInput.Text))
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


                studentNameLabel.Text = students[p];
                assignmentNoLbl.Text = "(1 - " + (assignments.Length / students.Length) + "):";
            }
        }

        private void testButton_Click(object sender, EventArgs e)
        {
            testLabel.Text = students.Length.ToString();
            testLabel2.Text = assignments.Length.ToString();
            testAssignmentScore.Text = assignments[p, Convert.ToInt32(assignmentNoInput.Text)].ToString();
            testStudentName.Text = students[p].ToString();

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

                    assignments[p, Convert.ToInt32(assignmentNoInput.Text)] = Convert.ToInt32(assignmentScoreInput.Text);
                }
            }

        }




    }
}
