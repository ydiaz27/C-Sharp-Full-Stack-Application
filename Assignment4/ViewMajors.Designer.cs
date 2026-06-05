namespace Assignment4
{
    partial class ViewMajors
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
            this.dgvViewMajors = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewMajors)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvViewMajors
            // 
            this.dgvViewMajors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewMajors.Location = new System.Drawing.Point(50, 40);
            this.dgvViewMajors.Name = "dgvViewMajors";
            this.dgvViewMajors.RowHeadersWidth = 51;
            this.dgvViewMajors.RowTemplate.Height = 24;
            this.dgvViewMajors.Size = new System.Drawing.Size(559, 359);
            this.dgvViewMajors.TabIndex = 1;
            // 
            // ViewMajors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 450);
            this.Controls.Add(this.dgvViewMajors);
            this.Name = "ViewMajors";
            this.Text = "ViewMajors";
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewMajors)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvViewMajors;
    }
}