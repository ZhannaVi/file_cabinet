using file_cabinet.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace file_cabinet.Forms
{
    public partial class Edit_Users : Form
    {
        public Edit_Users()
        {
            InitializeComponent();
            LoadAndIntiData();
            var Add = file_cabinetEntities1.GetContext().Users.OrderBy(p => p.FIO).ToList();
            Add.Insert(0, new Users
            {
                FIO = ""
            });
            cmbEdit.DataSource = Add;
            cmbEdit.DisplayMember = "FIO";
            cmbEdit.ValueMember = "user_id";

        }
        private void LoadAndIntiData()
        {
            var EU = file_cabinetEntities1.GetContext().Users.Join
                (file_cabinetEntities1.GetContext().Users, p => p.user_id, t => t.user_id,
                (p, t) => new { p.FIO, p.Address }).ToList();
            dgvEdUs.DataSource = EU;
            dgvEdUs.Columns[0].HeaderText = "ФИО";
            dgvEdUs.Columns[1].HeaderText = "Адресс";

        }

        private void Edit_Users_Load(object sender, EventArgs e)
        {

        }
        int row = 0;
        private void btnDel_Click(object sender, EventArgs e)
        {
           string rename = dgvEdUs[0,row].Value.ToString();
            var data = file_cabinetEntities1.GetContext();
            data.Users.Remove(data.Users.Where(p => p.FIO == rename).FirstOrDefault());
            data.SaveChanges();
            MessageBox.Show("Сотрудник удален");
            NameUs();
            LoadAndIntiData();
        }

        private void dgvEdUs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            row = e.RowIndex;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                file_cabinetEntities1 file_CabinetEntities1 = new file_cabinetEntities1();
                Users users = new Users();
                users.FIO = txbFIO.Text;
                users.Address = txbAdr.Text;
                users.Login = txbLogin.Text;
                users.Password = txbPassw.Text;
                file_CabinetEntities1.Users.Add(users);
                file_CabinetEntities1.SaveChanges();
                LoadAndIntiData();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        private void NameUs()
        {
            file_cabinetEntities1 file_CabinetEntities1 = new file_cabinetEntities1();
            Users users1 = new Users();
            users1.FIO = txbFIO.Text;
            users1.Address = txbAdr.Text;
            users1.Login = txbLogin.Text;
            users1.Password = txbPassw.Text;
            users1.user_id = (int)cmbEdit.SelectedValue;
            file_CabinetEntities1.Users.AddOrUpdate(users1);
            file_CabinetEntities1.SaveChanges();
            MessageBox.Show("Обновленно");
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
           NameUs();
        }

        private void dgvEdUs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
