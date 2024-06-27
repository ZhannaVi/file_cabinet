namespace file_cabinet.Forms
{
    partial class View_Users
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
            this.dgvUs = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUs)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUs
            // 
            this.dgvUs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUs.Location = new System.Drawing.Point(12, 58);
            this.dgvUs.Name = "dgvUs";
            this.dgvUs.RowHeadersWidth = 62;
            this.dgvUs.RowTemplate.Height = 28;
            this.dgvUs.Size = new System.Drawing.Size(573, 380);
            this.dgvUs.TabIndex = 0;
            // 
            // View_Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 452);
            this.Controls.Add(this.dgvUs);
            this.Name = "View_Users";
            this.Text = "View_Users";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUs;
    }
}