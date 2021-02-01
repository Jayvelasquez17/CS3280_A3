
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
            this.button1 = new System.Windows.Forms.Button();
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
            this.countsBox.SuspendLayout();
            this.studentInfoBox.SuspendLayout();
            this.navBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // countsBox
            // 
            this.countsBox.Controls.Add(this.button1);
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(350, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 51);
            this.button1.TabIndex = 4;
            this.button1.Text = "Submit Counts";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.testLabel.Location = new System.Drawing.Point(140, 174);
            this.testLabel.Name = "testLabel";
            this.testLabel.Size = new System.Drawing.Size(14, 20);
            this.testLabel.TabIndex = 1;
            this.testLabel.Text = "-";
            // 
            // testButton
            // 
            this.testButton.Location = new System.Drawing.Point(161, 170);
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
            this.testLabel2.Location = new System.Drawing.Point(140, 212);
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
            this.studentInfoBox.Location = new System.Drawing.Point(13, 321);
            this.studentInfoBox.Name = "studentInfoBox";
            this.studentInfoBox.Size = new System.Drawing.Size(529, 75);
            this.studentInfoBox.TabIndex = 4;
            this.studentInfoBox.TabStop = false;
            this.studentInfoBox.Text = "Student Info";
            // 
            // saveNameButton
            // 
            this.saveNameButton.Location = new System.Drawing.Point(407, 24);
            this.saveNameButton.Name = "saveNameButton";
            this.saveNameButton.Size = new System.Drawing.Size(116, 43);
            this.saveNameButton.TabIndex = 2;
            this.saveNameButton.Text = "Save Name";
            this.saveNameButton.UseVisualStyleBackColor = true;
            this.saveNameButton.Click += new System.EventHandler(this.saveNameButton_Click);
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(118, 32);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(283, 26);
            this.nameInput.TabIndex = 1;
            // 
            // studentNameLabel
            // 
            this.studentNameLabel.AutoSize = true;
            this.studentNameLabel.Location = new System.Drawing.Point(19, 35);
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
            this.navBox.Location = new System.Drawing.Point(13, 243);
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
            this.emptyNameError.Location = new System.Drawing.Point(549, 356);
            this.emptyNameError.Name = "emptyNameError";
            this.emptyNameError.Size = new System.Drawing.Size(159, 20);
            this.emptyNameError.TabIndex = 6;
            this.emptyNameError.Text = "Please enter a name!";
            this.emptyNameError.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 450);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox countsBox;
        private System.Windows.Forms.Button button1;
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
    }
}

