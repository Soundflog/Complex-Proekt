using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YCHET_AUTOSTOYANKI.Tables;

namespace YCHET_AUTOSTOYANKI.Forms
{
    public partial class Admin_update_client : Form
    {
        public Admin_update_client()
        {
            InitializeComponent();
            using (Database db = new Database())
            {
                foreach (Auto auto in db.Autos)
                {
                    comboBox1.Items.Add(auto.Autoname);
                }
                db.SaveChanges();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Client client = new Client();
            if (label2.Text != null && textLastname.Text != null && textFirstname.Text != null &&
                textMidname != null && textGosnumber.Text != null && textNumberphone != null &&
                textSeriaNumber != null)
            {
                using (Database db = new Database())
                {
                    client.Id = int.Parse(label2.Text);
                    client.Lastname = textLastname.Text;
                    client.Firstname = textFirstname.Text;
                    client.Midname = textMidname.Text;
                    client.Gosnumber = textGosnumber.Text;
                    client.Autos = db.Autos.ToList()[comboBox1.SelectedIndex];
                    client.Numberphone = textNumberphone.Text;
                    client.SeriaNumberDoc = textSeriaNumber.Text;
                    client.Roles.Id = 3;
                    db.Clients.Update(client);
                    db.SaveChanges();
                }
                MessageBox.Show("Обновление прошло успешно", "Обновление");
            }
            else
            {
                MessageBox.Show("Не удалось изменить данные");
            }
        }
    }
}
