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
    public partial class Admin_add_staff : Form
    {
        public Admin_add_staff()
        {
            InitializeComponent();
            using (Database db = new Database())
            {
                foreach (Role roles in db.Roles)
                {
                    comboBox1.Items.Add(roles.Namerole);
                }
                foreach (Auto auto in db.Autos)
                {
                    comboBox2.Items.Add(auto.Autoname);
                }
                db.SaveChanges();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            using (Database db = new Database())
            {
                var staff = new Staff();
                staff.Id = db.Staffs.ToList().Count + 1;
                staff.Lastname = textBox1.Text;
                staff.Firstname = textBox2.Text;
                staff.Midname = textBox3.Text;
                staff.Desription = textBox4.Text;
                staff.Roles = db.Roles.ToList()[comboBox1.SelectedIndex];
                db.Staffs.Add(staff);

                var clients = new Client();
                clients.Id = db.Clients.ToList().Count + 1;
                clients.Lastname = textBox1.Text;
                clients.Firstname = textBox2.Text;
                clients.Midname = textBox3.Text;
                clients.Gosnumber = txtgosnumber.Text;
                clients.Autos = db.Autos.ToList()[comboBox2.SelectedIndex];
                clients.Numberphone = maskedTextBox1.Text;
                clients.SeriaNumberDoc = maskedTextBox2.Text;
                clients.Roles = db.Roles.ToList()[comboBox1.SelectedIndex];

                db.Clients.Add(clients);
                db.SaveChanges();
            }
            MessageBox.Show("Добавление прошло успешно", "Добавить");
        }
    }
}
