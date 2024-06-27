using file_cabinet.Forms;
using file_cabinet.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Authorization = file_cabinet.Forms.Authorization;


namespace file_cabinet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы действительно хотите выйти из программы?", "Выход", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void авторизацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Authorization authorization = new Authorization();
            authorization.Show();
        }

        private void просмотрToolStripMenuItem_Click(object sender, EventArgs e)
        {
            View_doc view_Doc = new View_doc();
            view_Doc.Show();
        }

        private void редактированиеToolStripMenuItem_Click(object sender, EventArgs e)
        {

            using (var db = new file_cabinetEntities1())
            {
                var user = db.Users.FirstOrDefault(); 
                if (user != null)
                {
                    редактированиеToolStripMenuItem.Enabled = true;

                    Edit_doc edit_Doc = new Edit_doc();
                    edit_Doc.Show();
                }
                else
                {
                    //Скрыть доступ к заказам
                    редактированиеToolStripMenuItem.Enabled = false;
                }

            }
        }

        private void просмотрToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            View_Users view_Users = new View_Users();
            view_Users.Show();
        }

        private void редактированиеToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Edit_Users edit_Users = new Edit_Users();
            edit_Users.Show();


        }

        private void историяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            History history = new History();
            history.Show();
        }
    }
}
        
    
