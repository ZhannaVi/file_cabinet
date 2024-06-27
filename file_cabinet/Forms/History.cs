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
    public partial class History : Form
    {
        public History()
        {
            InitializeComponent();
            LoadAndInitiData();
        }

        private void LoadAndInitiData()
        {
            var H = file_cabinetEntities1.GetContext().UserAct
         .Join(file_cabinetEntities1.GetContext().Users, p => p.id_user, t => t.user_id,
             (p, t) => new { p.id_user, p.id_doc, p.action, FIO = t.FIO })
         //.Where(x => x.id_user == CurrentUserId) // Фильтруем действия только для авторизованного пользователя
         .ToList();
            dgvHistory.DataSource = H;
            dgvHistory.Columns[0].HeaderText = "ФИО";
            dgvHistory.Columns[1].HeaderText = "Документ";
            dgvHistory.Columns[2].HeaderText = "Действия";

        }


        private void History_Load(object sender, EventArgs e)
        {

        }
    }
}
