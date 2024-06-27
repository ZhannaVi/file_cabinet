using file_cabinet.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace file_cabinet.Forms
{
    public partial class View_doc : Form
    {
        public View_doc()
        {
            InitializeComponent();
            LoadAndIntiData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void LoadAndIntiData()
        {
            var VD = file_cabinetEntities1.GetContext().Document.Join
                (file_cabinetEntities1.GetContext().Document, p => p.doc_id, t => t.doc_id,
                (p, t) => new { p.name, p.author, p.categ, p.date_create }).ToList();
            dgvDoc.DataSource = VD;
            dgvDoc.Columns[0].HeaderText = "Название";
            dgvDoc.Columns[1].HeaderText = "Автор";
            dgvDoc.Columns[2].HeaderText = "Категория";
            dgvDoc.Columns[3].HeaderText = "Дата";
        }
    }
}
