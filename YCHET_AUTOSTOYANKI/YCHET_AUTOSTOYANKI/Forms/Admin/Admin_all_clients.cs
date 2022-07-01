using Microsoft.EntityFrameworkCore;
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

namespace YCHET_AUTOSTOYANKI.Forms.Admin
{
    public partial class Admin_all_clients : Form
    {
        public Admin_all_clients()
        {
            InitializeComponent();
            using (Database db = new Database())
            {
                foreach (Auto cl in db.Autos)
                {
                    comboBox2.Items.Add(cl.Autoname);
                }
                var clients = db.Clients.ToList();
                db.SaveChanges();
                SetDataGridClients(clients);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            try
            {
                using (Database db = new Database())
                {
                    var staffs = db.Staffs.ToList();
                    var clients = db.Clients.ToList();
                    var contract = db.Contracts.ToList();
                    SetDataGridClients(clients);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка:\n" + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Admin_add_client().Show();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = int.Parse(dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[0].Value.ToString());
            MessageBoxButtons buttons = MessageBoxButtons.YesNoCancel;
            DialogResult result = MessageBox.Show("Чтобы удалить выбранную строчку - нажмите Да.\n " +
                "Чтобы редактировать выбранную строчку - нажмите Нет", "Выберите действие", buttons);
            if (result == DialogResult.Yes)
            {
                using (Database db = new Database())
                {
                    var client = SearchByIdclient(db.Clients.ToList(), id);
                    db.Remove(client);
                    db.SaveChanges();
                }
                MessageBox.Show("Удаление прошло успешно", "Удаление");
            }
            else if (result == DialogResult.No)
            {
                Admin_update_client f_admin_update_client = new Admin_update_client();
                var surname = dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[1].Value;
                var name = dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[2].Value;
                var midname = dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[3].Value;
                var gosnumber = dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[4].Value;
                var numberphone = dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[5].Value;
                var serianumber = dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[6].Value;
                f_admin_update_client.label2.Text = id.ToString();
                f_admin_update_client.textLastname.Text = surname.ToString();
                f_admin_update_client.textFirstname.Text = name.ToString();
                f_admin_update_client.textMidname.Text = midname.ToString();
                f_admin_update_client.textGosnumber.Text = gosnumber.ToString();
                f_admin_update_client.textNumberphone.Text = numberphone.ToString();
                f_admin_update_client.textSeriaNumber.Text = serianumber.ToString();
                f_admin_update_client.Show();
            }
            else
            {
                return;
            }
        }
        private void SetDataGridClients(List<Client> clients)
        {
            dataGridView2.RowCount = clients.Count;
            for (int i = 0; i < clients.Count; i++)
            {
                var c = clients[i];
                dataGridView2.Rows[i].Cells[0].Value = c.Id;
                dataGridView2.Rows[i].Cells[1].Value = c.Lastname;
                dataGridView2.Rows[i].Cells[2].Value = c.Firstname;
                dataGridView2.Rows[i].Cells[3].Value = c.Midname;
                dataGridView2.Rows[i].Cells[4].Value = c.Gosnumber;
                dataGridView2.Rows[i].Cells[5].Value = c.Autos.Autoname;
                dataGridView2.Rows[i].Cells[6].Value = c.Numberphone;
                dataGridView2.Rows[i].Cells[7].Value = c.SeriaNumberDoc;
            }
        }
        private Client SearchByIdclient(List<Client> clients, int id)
        {
            Client client = null;
            foreach (Client e in clients)
            {
                if (e.Id == id) client = e;
            }

            return client;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                String lastname = textBox2.Text;
                dataGridView2.Rows.Clear();
                using (Database db = new Database())
                {
                    var clients = db.Clients.ToList();
                    if (lastname != null && !(comboBox2.Text == "" || comboBox2.Text == "Авто"))
                    {
                        var clients1 = db.Clients.Where(p => EF.Functions.Like(p.Lastname, "%" + lastname + "%"))
                        .Where(p => EF.Functions.Like(p.Autos.Autoname, comboBox2.Text)).ToList();
                        SetDataGridClients(clients1);
                    }
                    else if (lastname != "" && (comboBox2.Text == "" || comboBox2.Text == "Авто"))
                    {
                        var clients2 = db.Clients
                        .Where(p => EF.Functions.Like(p.Autos.Autoname, comboBox2.Text)).ToList();
                        SetDataGridClients(clients2);
                    }
                    else
                    {
                        SetDataGridClients(clients);
                    }
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка:\nНайди такого клиента не удалось\n" + ex.Message);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin_all_vouchers admin_All_Vouchers = new Admin_all_vouchers();
            admin_All_Vouchers.Show();
            this.Close();
        }

        private void открытьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Admin_main admin_Main = new Admin_main();
            admin_Main.Show();
            this.Close();
        }

        private void Admin_all_clients_FormClosed(object sender, FormClosedEventArgs e)
        {
            Admin_menu menu = new Admin_menu();
            menu.Show();
        }
    }
}
