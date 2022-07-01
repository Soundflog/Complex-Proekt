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
    public partial class Admin_update_staff : Form
    {
        public Admin_update_staff()
        {
            InitializeComponent();
            using (Database db = new Database())
            {
                foreach (Role roles in db.Roles)
                {
                    comboBox1.Items.Add(roles.Namerole);
                }
                db.SaveChanges();
            }
        }
        
        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                Staff staffs = new Staff();
                Client client = new Client();
                int id = Admin_main.id_clien_for_update;
                if (label2.Text != null && txtLastname.Text != null && txtFirstname.Text != null &&
                    txtMidname != null && txtDescription.Text != null)
                {
                    using (Database db = new Database())
                    {
                        Client client1 = (Client)db.Clients.Where(c => c.Id == id);
                        staffs.Id = id;
                        staffs.Lastname = txtLastname.Text;
                        staffs.Firstname = txtFirstname.Text;
                        staffs.Midname = txtMidname.Text;
                        staffs.Roles = db.Roles.ToList()[comboBox1.SelectedIndex];
                        staffs.Desription = txtDescription.Text;
                        db.Staffs.Update(staffs);
                        client.Id = id;
                        client.Lastname = txtLastname.Text;
                        client.Firstname = txtFirstname.Text;
                        client.Midname = txtMidname.Text;
                        client.Gosnumber = client1.Gosnumber;
                        client.Autos = client1.Autos;
                        client.Numberphone = client1.Numberphone;
                        client.SeriaNumberDoc = client1.SeriaNumberDoc;
                        client.Roles = client1.Roles;
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
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка\nПри измении данных сотрудника\n" + ex);
            }
            
        }
    }
}
