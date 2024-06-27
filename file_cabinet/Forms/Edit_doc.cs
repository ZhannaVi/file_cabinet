using file_cabinet.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace file_cabinet.Forms
{
    public partial class Edit_doc : Form
    {
        public Edit_doc()
        {
            InitializeComponent();
            LoadAndInitiData();
            var Add = file_cabinetEntities1.GetContext().Document.OrderBy(p => p.name).ToList();
            Add.Insert(0, new Document
            {
                name = ""
            });
            cmbName.DataSource = Add;
            cmbName.DisplayMember = "name";
            cmbName.ValueMember = "doc_id";
        }
        private void LoadAndInitiData()
        {
            var ED = file_cabinetEntities1.GetContext().Document.Join
                (file_cabinetEntities1.GetContext().Document, p => p.doc_id, t => t.doc_id,
                (p, t) => new { p.name, p.author, p.categ, p.date_create }).ToList();
            dgvEdDoc.DataSource = ED;
            dgvEdDoc.Columns[0].HeaderText = "Название";
            dgvEdDoc.Columns[1].HeaderText = "Автор";
            dgvEdDoc.Columns[2].HeaderText = "Категория";
            dgvEdDoc.Columns[3].HeaderText = "Дата";


        }

        private void Edit_doc_Load(object sender, EventArgs e)
        {

        }
        int r = 0;
        private void btnDel_Click(object sender, EventArgs e)
        {
            string dock = dgvEdDoc[0, r].Value.ToString();
            var data = file_cabinetEntities1.GetContext();

            var ED = file_cabinetEntities1.GetContext().Document.Join
                (file_cabinetEntities1.GetContext().Document, p => p.doc_id, t => t.doc_id,
                (p, t) => new { p.name, p.author, p.categ, p.date_create }).ToList();
            //int indexDoc = dgvEdDoc[0, r].Value.ToString();

            //int indexDoc = dock.id;


            data.Document.Remove(data.Document.Where(p => p.name == dock).FirstOrDefault());

          //int  indexDoc = data.Document.Find(data.Document.Where(p => p.name == dock).FirstOrDefault()).doc_id;

            data.SaveChanges();
            MessageBox.Show("Документ удален");
            UpName();
            LoadAndInitiData();
            //try
            //{
            //    file_cabinetEntities1 file_CabinetEntities = new file_cabinetEntities1();

            //    UserAct user = new UserAct();
            //    user.id_doc = indexDoc;
            //    user.id_user = Authorization.id_user;
            //    user.action = "Delete";



            //    file_CabinetEntities.UserAct.Add(user);
            //    file_CabinetEntities.SaveChanges();

            //}
            //catch (Exception test)
            //{
            //    MessageBox.Show(test.Message.ToString());

            //}
        }

        private void dgvEdDoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            r = e.RowIndex;

        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                file_cabinetEntities1 file_CabinetEntities1 = new file_cabinetEntities1();
                Document document = new Document();
                document.name = txbName.Text;
                document.author = txbAuthor.Text;
                document.categ = txbCateg.Text;
                document.date_create = dtp.Value;



                file_CabinetEntities1.Document.Add(document);

              



                file_CabinetEntities1.SaveChanges();
               

                LoadAndInitiData();
                try
                {
                    file_cabinetEntities1 file_CabinetEntities = new file_cabinetEntities1();
                    
                    UserAct user = new UserAct();
                    user.id_doc = document.doc_id ;
                    user.id_user = Authorization.id_user;
                    user.action = "Add";



                    file_CabinetEntities.UserAct.Add(user);
                    file_CabinetEntities.SaveChanges();

                }
                catch (Exception test)
                {
                    MessageBox.Show(test.Message.ToString());

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        private void UpName()
        {
            file_cabinetEntities1 file_CabinetEntities1 = new file_cabinetEntities1();
            Document document1 = new Document();
            document1.name = txbName.Text;
            document1.author = txbAuthor.Text;
            document1.categ = txbCateg.Text;
            document1.date_create = dtp.Value;
            document1.doc_id = (int)cmbName.SelectedValue;
            file_CabinetEntities1.Document.AddOrUpdate(document1);
            file_CabinetEntities1.SaveChanges();
            MessageBox.Show("Обновленно");
        }
        private void btnEdDoc_Click(object sender, EventArgs e)
        {
            UpName();
        }

        private void dgvEdDoc_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {



        }
    }
}
