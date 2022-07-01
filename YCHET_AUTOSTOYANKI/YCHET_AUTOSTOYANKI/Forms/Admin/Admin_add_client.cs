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
    public partial class Admin_add_client : Form
    {
        public Admin_add_client()
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
            using (Database db = new Database())
            {
                var client = new Client();
                client.Id = db.Clients.ToList().Count + 1;
                client.Lastname = textBox1.Text;
                client.Firstname = textBox2.Text;
                client.Midname = textBox3.Text;
                client.Gosnumber = textBox4.Text;
                client.Autos = db.Autos.ToList()[comboBox1.SelectedIndex];
                client.Numberphone = maskedTextBox1.Text;
                client.SeriaNumberDoc = maskedTextBox2.Text;
                client.Roles = db.Roles.ToList()[2];
                db.Clients.Add(client);
                db.SaveChanges();
            }
            MessageBox.Show("Добавление прошло успешно", "Добавить");
        }
    }
}
