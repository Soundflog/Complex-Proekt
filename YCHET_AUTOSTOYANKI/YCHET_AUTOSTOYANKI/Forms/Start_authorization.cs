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
    public partial class Start_authorization : Form
    {
        public static int id_client;
        public Start_authorization()
        {
            InitializeComponent();
            textBox2.UseSystemPasswordChar = true;
        }
        private void Start_authorization_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            string login = textBox1.Text;
            string passw = textBox2.Text;
            using (Database db = new Database())
            {
                if (db.Authorizations.Any(u => u.Login == login && u.Password == passw))
                {
                    if (login == "admin" && passw == "admin")
                    {
                        Admin_menu admin_Main = new Admin_menu();
                        admin_Main.Show();
                    }
                    else
                    {
                        Client_main client_Main = new Client_main();
                        Authorization authorization = db.Authorizations.FirstOrDefault(u => u.Login == login && u.Password == passw);
                        id_client = authorization.Id;
                        client_Main.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Неправильный логин или пароль");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Authorization_registration().Show();
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                textBox2.UseSystemPasswordChar = false;
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
            }
        }
    }
}
