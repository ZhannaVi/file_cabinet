namespace file_cabinet.Forms
{
    partial class Edit_doc
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
            this.dgvEdDoc = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbName = new System.Windows.Forms.ComboBox();
            this.txbName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdDoc = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txbAuthor = new System.Windows.Forms.TextBox();
            this.txbCateg = new System.Windows.Forms.TextBox();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEdDoc)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEdDoc
            // 
            this.dgvEdDoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEdDoc.Location = new System.Drawing.Point(13, 13);
            this.dgvEdDoc.Name = "dgvEdDoc";
            this.dgvEdDoc.RowHeadersWidth = 62;
            this.dgvEdDoc.RowTemplate.Height = 28;
            this.dgvEdDoc.Size = new System.Drawing.Size(775, 265);
            this.dgvEdDoc.TabIndex = 0;
            this.dgvEdDoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEdDoc_CellClick);
            this.dgvEdDoc.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvEdDoc_RowHeaderMouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 307);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Название";
            // 
            // cmbName
            // 
            this.cmbName.FormattingEnabled = true;
            this.cmbName.Location = new System.Drawing.Point(232, 485);
            this.cmbName.Name = "cmbName";
            this.cmbName.Size = new System.Drawing.Size(233, 28);
            this.cmbName.TabIndex = 2;
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(12, 330);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(201, 26);
            this.txbName.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(15, 519);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(198, 48);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdDoc
            // 
            this.btnEdDoc.Location = new System.Drawing.Point(232, 519);
            this.btnEdDoc.Name = "btnEdDoc";
            this.btnEdDoc.Size = new System.Drawing.Size(233, 48);
            this.btnEdDoc.TabIndex = 4;
            this.btnEdDoc.Text = "Редактирование";
            this.btnEdDoc.UseVisualStyleBackColor = true;
            this.btnEdDoc.Click += new System.EventHandler(this.btnEdDoc_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(590, 284);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(198, 48);
            this.btnDel.TabIndex = 4;
            this.btnDel.Text = "Удалить";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 359);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Автор";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 411);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Категория";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 463);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Дата";
            // 
            // txbAuthor
            // 
            this.txbAuthor.Location = new System.Drawing.Point(12, 382);
            this.txbAuthor.Name = "txbAuthor";
            this.txbAuthor.Size = new System.Drawing.Size(201, 26);
            this.txbAuthor.TabIndex = 3;
            // 
            // txbCateg
            // 
            this.txbCateg.Location = new System.Drawing.Point(13, 434);
            this.txbCateg.Name = "txbCateg";
            this.txbCateg.Size = new System.Drawing.Size(201, 26);
            this.txbCateg.TabIndex = 3;
            // 
            // dtp
            // 
            this.dtp.Location = new System.Drawing.Point(16, 487);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(200, 26);
            this.dtp.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(228, 463);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Поиск по названию";
            // 
            // Edit_doc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 579);
            this.Controls.Add(this.dtp);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnEdDoc);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txbCateg);
            this.Controls.Add(this.txbAuthor);
            this.Controls.Add(this.txbName);
            this.Controls.Add(this.cmbName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvEdDoc);
            this.Name = "Edit_doc";
            this.Text = "Edit_doc";
            this.Load += new System.EventHandler(this.Edit_doc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEdDoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEdDoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbName;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdDoc;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbAuthor;
        private System.Windows.Forms.TextBox txbCateg;
        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.Label label5;
    }
}