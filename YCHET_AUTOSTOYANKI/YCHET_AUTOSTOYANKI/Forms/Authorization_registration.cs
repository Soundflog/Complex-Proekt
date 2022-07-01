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
    public partial class Authorization_registration : Form
    {
        public Authorization_registration()
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

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (Database db = new Database())
                {
                    var client = new Client();
                    int id = db.Clients.ToList().Count + 1;
                    client.Id = id;
                    client.Lastname = textBox1.Text;
                    client.Firstname = textBox2.Text;
                    client.Midname = textBox3.Text;
                    client.Gosnumber = textBox4.Text;
                    client.Autos = db.Autos.ToList()[comboBox1.SelectedIndex];
                    client.Numberphone = textBox6.Text;
                    client.SeriaNumberDoc = textBox5.Text;
                    client.Roles = db.Roles.ToList()[2];
                    db.Clients.Add(client);
                    db.SaveChanges();
                    var registration = new Authorization();
                    registration.Id = id;
                    String login = textBox7.Text;
                    var authorizations = db.Authorizations.ToList();
                    foreach (var a in authorizations)
                    {
                        if (a.Login != login)
                        {
                            registration.Login = login;
                            break;
                        }
                        else MessageBox.Show("Аккаунт с таким же логином уже существует");
                    }
                    registration.Password = textBox8.Text;
                    db.Authorizations.Add(registration);
                    db.SaveChanges();
                    MessageBox.Show("Вы зарегистрированы", "Регистрация");
                    this.Close();
                    new Start_authorization().Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка:\n" + ex.Message);
            }
        }
    }
}
