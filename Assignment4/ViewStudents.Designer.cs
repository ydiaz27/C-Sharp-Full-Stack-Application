namespace Assignment4
{
    partial class ViewStudents
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
            this.dgvViewStudents = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvViewStudents
            // 
            this.dgvViewStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewStudents.Location = new System.Drawing.Point(49, 40);
            this.dgvViewStudents.Name = "dgvViewStudents";
            this.dgvViewStudents.RowHeadersWidth = 51;
            this.dgvViewStudents.RowTemplate.Height = 24;
            this.dgvViewStudents.Size = new System.Drawing.Size(559, 359);
            this.dgvViewStudents.TabIndex = 1;
            // 
            // ViewStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 450);
            this.Controls.Add(this.dgvViewStudents);
            this.Name = "ViewStudents";
            this.Text = "ViewStudents";
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewStudents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvViewStudents;
    }
}