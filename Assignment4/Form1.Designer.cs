namespace Assignment4
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
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.btnAddMajor = new System.Windows.Forms.Button();
            this.btnViewStudents = new System.Windows.Forms.Button();
            this.btnViewMajors = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(48, 49);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(200, 150);
            this.btnAddStudent.TabIndex = 1;
            this.btnAddStudent.Text = "Add Student";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // btnAddMajor
            // 
            this.btnAddMajor.Location = new System.Drawing.Point(374, 49);
            this.btnAddMajor.Name = "btnAddMajor";
            this.btnAddMajor.Size = new System.Drawing.Size(200, 150);
            this.btnAddMajor.TabIndex = 2;
            this.btnAddMajor.Text = "Add Major";
            this.btnAddMajor.UseVisualStyleBackColor = true;
            this.btnAddMajor.Click += new System.EventHandler(this.btnAddMajor_Click);
            // 
            // btnViewStudents
            // 
            this.btnViewStudents.Location = new System.Drawing.Point(48, 255);
            this.btnViewStudents.Name = "btnViewStudents";
            this.btnViewStudents.Size = new System.Drawing.Size(200, 150);
            this.btnViewStudents.TabIndex = 3;
            this.btnViewStudents.Text = "View Students";
            this.btnViewStudents.UseVisualStyleBackColor = true;
            this.btnViewStudents.Click += new System.EventHandler(this.btnViewStudents_Click);
            // 
            // btnViewMajors
            // 
            this.btnViewMajors.Location = new System.Drawing.Point(374, 255);
            this.btnViewMajors.Name = "btnViewMajors";
            this.btnViewMajors.Size = new System.Drawing.Size(200, 150);
            this.btnViewMajors.TabIndex = 4;
            this.btnViewMajors.Text = "View Majors";
            this.btnViewMajors.UseVisualStyleBackColor = true;
            this.btnViewMajors.Click += new System.EventHandler(this.btnViewMajors_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 450);
            this.Controls.Add(this.btnViewMajors);
            this.Controls.Add(this.btnViewStudents);
            this.Controls.Add(this.btnAddMajor);
            this.Controls.Add(this.btnAddStudent);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button btnAddMajor;
        private System.Windows.Forms.Button btnViewStudents;
        private System.Windows.Forms.Button btnViewMajors;
    }
}

