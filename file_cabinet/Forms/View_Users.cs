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
    public partial class View_Users : Form
    {
        public View_Users()
        {
            InitializeComponent();
            LoadAndIntiData();

        }
        private void LoadAndIntiData()
        {
            var VU = file_cabinetEntities1.GetContext().Users.Join
                (file_cabinetEntities1.GetContext().Users, p => p.user_id, t => t.user_id,
                (p, t) => new { p.FIO, p.Address }).ToList();
            dgvUs.DataSource = VU;
            dgvUs.Columns[0].HeaderText = "ФИО";
            dgvUs.Columns[1].HeaderText = "Адресс";

        }

    }
}
