namespace file_cabinet.Forms
{
    partial class Edit_Users
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
            this.dgvEdUs = new System.Windows.Forms.DataGridView();
            this.txbFIO = new System.Windows.Forms.TextBox();
            this.txbAdr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txbLogin = new System.Windows.Forms.TextBox();
            this.txbPassw = new System.Windows.Forms.TextBox();
            this.cmbEdit = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEdUs)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEdUs
            // 
            this.dgvEdUs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEdUs.Location = new System.Drawing.Point(12, 61);
            this.dgvEdUs.Name = "dgvEdUs";
            this.dgvEdUs.RowHeadersWidth = 62;
            this.dgvEdUs.RowTemplate.Height = 28;
            this.dgvEdUs.Size = new System.Drawing.Size(415, 416);
            this.dgvEdUs.TabIndex = 0;
            this.dgvEdUs.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEdUs_CellClick);
            this.dgvEdUs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEdUs_CellContentClick);
            // 
            // txbFIO
            // 
            this.txbFIO.Location = new System.Drawing.Point(467, 61);
            this.txbFIO.Name = "txbFIO";
            this.txbFIO.Size = new System.Drawing.Size(248, 26);
            this.txbFIO.TabIndex = 1;
            // 
            // txbAdr
            // 
            this.txbAdr.Location = new System.Drawing.Point(467, 122);
            this.txbAdr.Name = "txbAdr";
            this.txbAdr.Size = new System.Drawing.Size(248, 26);
            this.txbAdr.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(467, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "ФИО";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(467, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Адресс";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(467, 314);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(248, 47);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(721, 430);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(248, 47);
            this.btnDel.TabIndex = 3;
            this.btnDel.Text = "Удалить";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(467, 430);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(248, 47);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Редактировать";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(467, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Логин";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(467, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Пароль";
            // 
            // txbLogin
            // 
            this.txbLogin.Location = new System.Drawing.Point(467, 189);
            this.txbLogin.Name = "txbLogin";
            this.txbLogin.Size = new System.Drawing.Size(248, 26);
            this.txbLogin.TabIndex = 1;
            // 
            // txbPassw
            // 
            this.txbPassw.Location = new System.Drawing.Point(467, 261);
            this.txbPassw.Name = "txbPassw";
            this.txbPassw.Size = new System.Drawing.Size(248, 26);
            this.txbPassw.TabIndex = 1;
            // 
            // cmbEdit
            // 
            this.cmbEdit.FormattingEnabled = true;
            this.cmbEdit.Location = new System.Drawing.Point(471, 387);
            this.cmbEdit.Name = "cmbEdit";
            this.cmbEdit.Size = new System.Drawing.Size(244, 28);
            this.cmbEdit.TabIndex = 4;
            // 
            // Edit_Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 489);
            this.Controls.Add(this.cmbEdit);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbPassw);
            this.Controls.Add(this.txbLogin);
            this.Controls.Add(this.txbAdr);
            this.Controls.Add(this.txbFIO);
            this.Controls.Add(this.dgvEdUs);
            this.Name = "Edit_Users";
            this.Text = "Edit_Users";
            this.Load += new System.EventHandler(this.Edit_Users_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEdUs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEdUs;
        private System.Windows.Forms.TextBox txbFIO;
        private System.Windows.Forms.TextBox txbAdr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbLogin;
        private System.Windows.Forms.TextBox txbPassw;
        private System.Windows.Forms.ComboBox cmbEdit;
    }
}