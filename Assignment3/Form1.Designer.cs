
namespace Assignment3
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.countsBox = new System.Windows.Forms.GroupBox();
            this.submitCountsButton = new System.Windows.Forms.Button();
            this.noAssignInput = new System.Windows.Forms.TextBox();
            this.noStudInput = new System.Windows.Forms.TextBox();
            this.noAssignLabel = new System.Windows.Forms.Label();
            this.noStudentsLabel = new System.Windows.Forms.Label();
            this.testLabel = new System.Windows.Forms.Label();
            this.testButton = new System.Windows.Forms.Button();
            this.testLabel2 = new System.Windows.Forms.Label();
            this.studentInfoBox = new System.Windows.Forms.GroupBox();
            this.saveNameButton = new System.Windows.Forms.Button();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.studentNameLabel = new System.Windows.Forms.Label();
            this.navBox = new System.Windows.Forms.GroupBox();
            this.lastStudButton = new System.Windows.Forms.Button();
            this.nextStudButton = new System.Windows.Forms.Button();
            this.prevStudButton = new System.Windows.Forms.Button();
            this.firstStudButton = new System.Windows.Forms.Button();
            this.emptyNameError = new System.Windows.Forms.Label();
            this.enterAssignBox = new System.Windows.Forms.GroupBox();
            this.enterAssignmentNoLbl = new System.Windows.Forms.Label();
            this.assignmentScoreLbl = new System.Windows.Forms.Label();
            this.assignmentNoInput = new System.Windows.Forms.TextBox();
            this.assignmentScoreInput = new System.Windows.Forms.TextBox();
            this.saveScoreButton = new System.Windows.Forms.Button();
            this.assignmentNoLbl = new System.Windows.Forms.Label();
            this.enterScoreError = new System.Windows.Forms.Label();
            this.enterAssignmentNoError = new System.Windows.Forms.Label();
            this.testAssignmentScore = new System.Windows.Forms.Label();
            this.testStudentName = new System.Windows.Forms.Label();
            this.countsErrorLbl = new System.Windows.Forms.Label();
            this.countsBox.SuspendLayout();
            this.studentInfoBox.SuspendLayout();
            this.navBox.SuspendLayout();
            this.enterAssignBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // countsBox
            // 
            this.countsBox.Controls.Add(this.countsErrorLbl);
            this.countsBox.Controls.Add(this.submitCountsButton);
            this.countsBox.Controls.Add(this.noAssignInput);
            this.countsBox.Controls.Add(this.noStudInput);
            this.countsBox.Controls.Add(this.noAssignLabel);
            this.countsBox.Controls.Add(this.noStudentsLabel);
            this.countsBox.Location = new System.Drawing.Point(13, 13);
            this.countsBox.Name = "countsBox";
            this.countsBox.Size = new System.Drawing.Size(580, 158);
            this.countsBox.TabIndex = 0;
            this.countsBox.TabStop = false;
            this.countsBox.Text = "Counts";
            // 
            // submitCountsButton
            // 
            this.submitCountsButton.Location = new System.Drawing.Point(350, 58);
            this.submitCountsButton.Name = "submitCountsButton";
            this.submitCountsButton.Size = new System.Drawing.Size(143, 51);
            this.submitCountsButton.TabIndex = 4;
            this.submitCountsButton.Text = "Submit Counts";
            this.submitCountsButton.UseVisualStyleBackColor = true;
            this.submitCountsButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // noAssignInput
            // 
            this.noAssignInput.Location = new System.Drawing.Point(224, 95);
            this.noAssignInput.Name = "noAssignInput";
            this.noAssignInput.Size = new System.Drawing.Size(100, 26);
            this.noAssignInput.TabIndex = 3;
            // 
            // noStudInput
            // 
            this.noStudInput.Location = new System.Drawing.Point(224, 52);
            this.noStudInput.Name = "noStudInput";
            this.noStudInput.Size = new System.Drawing.Size(100, 26);
            this.noStudInput.TabIndex = 2;
            // 
            // noAssignLabel
            // 
            this.noAssignLabel.AutoSize = true;
            this.noAssignLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noAssignLabel.Location = new System.Drawing.Point(15, 101);
            this.noAssignLabel.Name = "noAssignLabel";
            this.noAssignLabel.Size = new System.Drawing.Size(203, 20);
            this.noAssignLabel.TabIndex = 1;
            this.noAssignLabel.Text = "Number of assignments:";
            // 
            // noStudentsLabel
            // 
            this.noStudentsLabel.AutoSize = true;
            this.noStudentsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noStudentsLabel.Location = new System.Drawing.Point(46, 58);
            this.noStudentsLabel.Name = "noStudentsLabel";
            this.noStudentsLabel.Size = new System.Drawing.Size(172, 20);
            this.noStudentsLabel.TabIndex = 0;
            this.noStudentsLabel.Text = "Number of students:";
            // 
            // testLabel
            // 
            this.testLabel.AutoSize = true;
            this.testLabel.Location = new System.Drawing.Point(648, 386);
            this.testLabel.Name = "testLabel";
            this.testLabel.Size = new System.Drawing.Size(14, 20);
            this.testLabel.TabIndex = 1;
            this.testLabel.Text = "-";
            // 
            // testButton
            // 
            this.testButton.Location = new System.Drawing.Point(652, 516);
            this.testButton.Name = "testButton";
            this.testButton.Size = new System.Drawing.Size(104, 35);
            this.testButton.TabIndex = 2;
            this.testButton.Text = "Test";
            this.testButton.UseVisualStyleBackColor = true;
            this.testButton.Click += new System.EventHandler(this.testButton_Click);
            // 
            // testLabel2
            // 
            this.testLabel2.AutoSize = true;
            this.testLabel2.Location = new System.Drawing.Point(742, 386);
            this.testLabel2.Name = "testLabel2";
            this.testLabel2.Size = new System.Drawing.Size(14, 20);
            this.testLabel2.TabIndex = 3;
            this.testLabel2.Text = "-";
            // 
            // studentInfoBox
            // 
            this.studentInfoBox.Controls.Add(this.saveNameButton);
            this.studentInfoBox.Controls.Add(this.nameInput);
            this.studentInfoBox.Controls.Add(this.studentNameLabel);
            this.studentInfoBox.Location = new System.Drawing.Point(13, 255);
            this.studentInfoBox.Name = "studentInfoBox";
            this.studentInfoBox.Size = new System.Drawing.Size(580, 75);
            this.studentInfoBox.TabIndex = 4;
            this.studentInfoBox.TabStop = false;
            this.studentInfoBox.Text = "Student Info";
            // 
            // saveNameButton
            // 
            this.saveNameButton.Location = new System.Drawing.Point(458, 24);
            this.saveNameButton.Name = "saveNameButton";
            this.saveNameButton.Size = new System.Drawing.Size(116, 43);
            this.saveNameButton.TabIndex = 2;
            this.saveNameButton.Text = "Save Name";
            this.saveNameButton.UseVisualStyleBackColor = true;
            this.saveNameButton.Click += new System.EventHandler(this.saveNameButton_Click);
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(199, 32);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(253, 26);
            this.nameInput.TabIndex = 1;
            // 
            // studentNameLabel
            // 
            this.studentNameLabel.AutoSize = true;
            this.studentNameLabel.Location = new System.Drawing.Point(6, 35);
            this.studentNameLabel.Name = "studentNameLabel";
            this.studentNameLabel.Size = new System.Drawing.Size(14, 20);
            this.studentNameLabel.TabIndex = 0;
            this.studentNameLabel.Text = "-";
            // 
            // navBox
            // 
            this.navBox.Controls.Add(this.lastStudButton);
            this.navBox.Controls.Add(this.nextStudButton);
            this.navBox.Controls.Add(this.prevStudButton);
            this.navBox.Controls.Add(this.firstStudButton);
            this.navBox.Location = new System.Drawing.Point(13, 177);
            this.navBox.Name = "navBox";
            this.navBox.Size = new System.Drawing.Size(580, 72);
            this.navBox.TabIndex = 5;
            this.navBox.TabStop = false;
            this.navBox.Text = "Navigate";
            // 
            // lastStudButton
            // 
            this.lastStudButton.Location = new System.Drawing.Point(437, 26);
            this.lastStudButton.Name = "lastStudButton";
            this.lastStudButton.Size = new System.Drawing.Size(137, 40);
            this.lastStudButton.TabIndex = 3;
            this.lastStudButton.Text = "Last Student>>";
            this.lastStudButton.UseVisualStyleBackColor = true;
            this.lastStudButton.Click += new System.EventHandler(this.lastStudButton_Click);
            // 
            // nextStudButton
            // 
            this.nextStudButton.Location = new System.Drawing.Point(292, 25);
            this.nextStudButton.Name = "nextStudButton";
            this.nextStudButton.Size = new System.Drawing.Size(139, 40);
            this.nextStudButton.TabIndex = 2;
            this.nextStudButton.Text = "Next Student >";
            this.nextStudButton.UseVisualStyleBackColor = true;
            this.nextStudButton.Click += new System.EventHandler(this.nextStudButton_Click);
            // 
            // prevStudButton
            // 
            this.prevStudButton.Location = new System.Drawing.Point(148, 25);
            this.prevStudButton.Name = "prevStudButton";
            this.prevStudButton.Size = new System.Drawing.Size(138, 40);
            this.prevStudButton.TabIndex = 1;
            this.prevStudButton.Text = "< Prev Student";
            this.prevStudButton.UseVisualStyleBackColor = true;
            this.prevStudButton.Click += new System.EventHandler(this.prevStudButton_Click);
            // 
            // firstStudButton
            // 
            this.firstStudButton.Location = new System.Drawing.Point(7, 26);
            this.firstStudButton.Name = "firstStudButton";
            this.firstStudButton.Size = new System.Drawing.Size(134, 40);
            this.firstStudButton.TabIndex = 0;
            this.firstStudButton.Text = "<<First Student";
            this.firstStudButton.UseVisualStyleBackColor = true;
            this.firstStudButton.Click += new System.EventHandler(this.firstStudButton_Click);
            // 
            // emptyNameError
            // 
            this.emptyNameError.AutoSize = true;
            this.emptyNameError.Location = new System.Drawing.Point(597, 291);
            this.emptyNameError.Name = "emptyNameError";
            this.emptyNameError.Size = new System.Drawing.Size(159, 20);
            this.emptyNameError.TabIndex = 6;
            this.emptyNameError.Text = "Please enter a name!";
            this.emptyNameError.Visible = false;
            // 
            // enterAssignBox
            // 
            this.enterAssignBox.Controls.Add(this.enterAssignmentNoError);
            this.enterAssignBox.Controls.Add(this.enterScoreError);
            this.enterAssignBox.Controls.Add(this.assignmentNoLbl);
            this.enterAssignBox.Controls.Add(this.saveScoreButton);
            this.enterAssignBox.Controls.Add(this.assignmentScoreInput);
            this.enterAssignBox.Controls.Add(this.assignmentNoInput);
            this.enterAssignBox.Controls.Add(this.assignmentScoreLbl);
            this.enterAssignBox.Controls.Add(this.enterAssignmentNoLbl);
            this.enterAssignBox.Location = new System.Drawing.Point(13, 336);
            this.enterAssignBox.Name = "enterAssignBox";
            this.enterAssignBox.Size = new System.Drawing.Size(580, 201);
            this.enterAssignBox.TabIndex = 7;
            this.enterAssignBox.TabStop = false;
            this.enterAssignBox.Text = "Student Info";
            // 
            // enterAssignmentNoLbl
            // 
            this.enterAssignmentNoLbl.AutoSize = true;
            this.enterAssignmentNoLbl.Location = new System.Drawing.Point(86, 50);
            this.enterAssignmentNoLbl.Name = "enterAssignmentNoLbl";
            this.enterAssignmentNoLbl.Size = new System.Drawing.Size(196, 20);
            this.enterAssignmentNoLbl.TabIndex = 0;
            this.enterAssignmentNoLbl.Text = "Enter Assignment Number";
            // 
            // assignmentScoreLbl
            // 
            this.assignmentScoreLbl.AutoSize = true;
            this.assignmentScoreLbl.Location = new System.Drawing.Point(203, 122);
            this.assignmentScoreLbl.Name = "assignmentScoreLbl";
            this.assignmentScoreLbl.Size = new System.Drawing.Size(143, 20);
            this.assignmentScoreLbl.TabIndex = 1;
            this.assignmentScoreLbl.Text = "Assignment Score:";
            // 
            // assignmentNoInput
            // 
            this.assignmentNoInput.Location = new System.Drawing.Point(352, 50);
            this.assignmentNoInput.Name = "assignmentNoInput";
            this.assignmentNoInput.Size = new System.Drawing.Size(100, 26);
            this.assignmentNoInput.TabIndex = 2;
            // 
            // assignmentScoreInput
            // 
            this.assignmentScoreInput.Location = new System.Drawing.Point(352, 119);
            this.assignmentScoreInput.Name = "assignmentScoreInput";
            this.assignmentScoreInput.Size = new System.Drawing.Size(100, 26);
            this.assignmentScoreInput.TabIndex = 3;
            // 
            // saveScoreButton
            // 
            this.saveScoreButton.Location = new System.Drawing.Point(458, 76);
            this.saveScoreButton.Name = "saveScoreButton";
            this.saveScoreButton.Size = new System.Drawing.Size(116, 46);
            this.saveScoreButton.TabIndex = 4;
            this.saveScoreButton.Text = "Save Score";
            this.saveScoreButton.UseVisualStyleBackColor = true;
            this.saveScoreButton.Click += new System.EventHandler(this.saveScoreButton_Click);
            // 
            // assignmentNoLbl
            // 
            this.assignmentNoLbl.AutoSize = true;
            this.assignmentNoLbl.Location = new System.Drawing.Point(288, 50);
            this.assignmentNoLbl.Name = "assignmentNoLbl";
            this.assignmentNoLbl.Size = new System.Drawing.Size(14, 20);
            this.assignmentNoLbl.TabIndex = 5;
            this.assignmentNoLbl.Text = "-";
            // 
            // enterScoreError
            // 
            this.enterScoreError.AutoSize = true;
            this.enterScoreError.Location = new System.Drawing.Point(348, 160);
            this.enterScoreError.Name = "enterScoreError";
            this.enterScoreError.Size = new System.Drawing.Size(193, 20);
            this.enterScoreError.TabIndex = 6;
            this.enterScoreError.Text = "Please enter a valid score!";
            this.enterScoreError.Visible = false;
            // 
            // enterAssignmentNoError
            // 
            this.enterAssignmentNoError.AutoSize = true;
            this.enterAssignmentNoError.Location = new System.Drawing.Point(259, 160);
            this.enterAssignmentNoError.Name = "enterAssignmentNoError";
            this.enterAssignmentNoError.Size = new System.Drawing.Size(315, 20);
            this.enterAssignmentNoError.TabIndex = 7;
            this.enterAssignmentNoError.Text = "Please enter a score for a valid assignment!";
            this.enterAssignmentNoError.Visible = false;
            // 
            // testAssignmentScore
            // 
            this.testAssignmentScore.AutoSize = true;
            this.testAssignmentScore.Location = new System.Drawing.Point(648, 455);
            this.testAssignmentScore.Name = "testAssignmentScore";
            this.testAssignmentScore.Size = new System.Drawing.Size(14, 20);
            this.testAssignmentScore.TabIndex = 8;
            this.testAssignmentScore.Text = "-";
            // 
            // testStudentName
            // 
            this.testStudentName.AutoSize = true;
            this.testStudentName.Location = new System.Drawing.Point(742, 455);
            this.testStudentName.Name = "testStudentName";
            this.testStudentName.Size = new System.Drawing.Size(14, 20);
            this.testStudentName.TabIndex = 9;
            this.testStudentName.Text = "-";
            // 
            // countsErrorLbl
            // 
            this.countsErrorLbl.AutoSize = true;
            this.countsErrorLbl.Location = new System.Drawing.Point(346, 123);
            this.countsErrorLbl.Name = "countsErrorLbl";
            this.countsErrorLbl.Size = new System.Drawing.Size(176, 20);
            this.countsErrorLbl.TabIndex = 5;
            this.countsErrorLbl.Text = "Please enter valid input!";
            this.countsErrorLbl.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 780);
            this.Controls.Add(this.testStudentName);
            this.Controls.Add(this.testAssignmentScore);
            this.Controls.Add(this.enterAssignBox);
            this.Controls.Add(this.emptyNameError);
            this.Controls.Add(this.navBox);
            this.Controls.Add(this.studentInfoBox);
            this.Controls.Add(this.testLabel2);
            this.Controls.Add(this.testButton);
            this.Controls.Add(this.testLabel);
            this.Controls.Add(this.countsBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.countsBox.ResumeLayout(false);
            this.countsBox.PerformLayout();
            this.studentInfoBox.ResumeLayout(false);
            this.studentInfoBox.PerformLayout();
            this.navBox.ResumeLayout(false);
            this.enterAssignBox.ResumeLayout(false);
            this.enterAssignBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox countsBox;
        private System.Windows.Forms.Button submitCountsButton;
        private System.Windows.Forms.TextBox noAssignInput;
        private System.Windows.Forms.TextBox noStudInput;
        private System.Windows.Forms.Label noAssignLabel;
        private System.Windows.Forms.Label noStudentsLabel;
        private System.Windows.Forms.Label testLabel;
        private System.Windows.Forms.Button testButton;
        private System.Windows.Forms.Label testLabel2;
        private System.Windows.Forms.GroupBox studentInfoBox;
        private System.Windows.Forms.Label studentNameLabel;
        private System.Windows.Forms.Button saveNameButton;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.GroupBox navBox;
        private System.Windows.Forms.Button lastStudButton;
        private System.Windows.Forms.Button nextStudButton;
        private System.Windows.Forms.Button prevStudButton;
        private System.Windows.Forms.Button firstStudButton;
        private System.Windows.Forms.Label emptyNameError;
        private System.Windows.Forms.GroupBox enterAssignBox;
        private System.Windows.Forms.Button saveScoreButton;
        private System.Windows.Forms.TextBox assignmentScoreInput;
        private System.Windows.Forms.TextBox assignmentNoInput;
        private System.Windows.Forms.Label assignmentScoreLbl;
        private System.Windows.Forms.Label enterAssignmentNoLbl;
        private System.Windows.Forms.Label assignmentNoLbl;
        private System.Windows.Forms.Label enterScoreError;
        private System.Windows.Forms.Label enterAssignmentNoError;
        private System.Windows.Forms.Label testAssignmentScore;
        private System.Windows.Forms.Label testStudentName;
        private System.Windows.Forms.Label countsErrorLbl;
    }
}

