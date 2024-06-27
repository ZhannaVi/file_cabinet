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
    public partial class Authorization : Form
    {
       public static string username;
        public static string password;
        public static int id_user;
        public Authorization()
        {
            InitializeComponent();
        }

        private void btnAutho_Click(object sender, EventArgs e)
        {
            username = txtLogin.Text;
            password = txtPass.Text;
            try
            {
                List<Users> users = file_cabinetEntities1.GetContext().Users.ToList();
                Users users1 = users.FirstOrDefault(p => p.Login == username && p.Password == password);
                if (users1 != null)
                {

                    id_user = users1.user_id;

                    Form1 form1 = new Form1();
                    form1.Owner = this;
                    this.Hide();
                    form1.Show();
                   
                }
                else
                {
                    MessageBox.Show("Попробуйте снова");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
