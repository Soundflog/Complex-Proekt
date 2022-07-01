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
    public partial class Client_profile : Form
    {
        public Client_profile()
        {
            InitializeComponent();
            using (Database db = new Database())
            {
                
                int id = Start_authorization.id_client;
                var client = db.Clients.SingleOrDefault(c => c.Id == id);
                comboBox1.Items.Add(client.Autos.Autoname.ToString());
                textLastname.Text = client.Lastname.ToString();
                textFirstname.Text = client.Firstname.ToString();
                textMidname.Text = client.Midname.ToString();
                textGosnumber.Text = client.Gosnumber.ToString();
                textNumberPhone.Text = client.Numberphone.ToString();
                textGosnumber.Text = client.Gosnumber.ToString();
                textSerianumber.Text = client.SeriaNumberDoc.ToString();
                var authozation_cl = db.Authorizations.SingleOrDefault(c => c.Id == id);
                textLogin.Text = authozation_cl.Login.ToString();
                textPassword.Text = authozation_cl.Password.ToString();
                comboBox1.Text = client.Autos.Autoname.ToString();
            }
        }

        private void Client_profile_Load(object sender, EventArgs e)
        {
            int id = Start_authorization.id_client;
            using (Database db = new Database())
            {
                var contract = db.Contracts.Where(c => c.Clients.Id == id);
                dataGridView1.Rows.Clear();
                var vouchers = db.Contracts.Where(c => c.Clients.Id == id).Join(db.Vouchers,
                    c => c.Vouchers.Id,
                    v => v.Id,
                    (c, v) => new Voucher
                    {
                        Indate = v.Indate,
                        Outdate = v.Outdate,
                        Summ = v.Summ,
                        Discounts = v.Discounts,
                    }).ToList();
                SetDataGrid(vouchers);
            }
        }
        private void SetDataGrid(List<Voucher> vouchers)
        {
            try
            {
                dataGridView1.RowCount = vouchers.Count;
                for (int i = 0; i < vouchers.Count; i++)
                {
                    var e = vouchers[i];
                    if (DateTime.Now >= e.Outdate) { dataGridView1.Rows[i].Cells[0].Value = "\U0001F5D9"; }
                    else { dataGridView1.Rows[i].Cells[0].Value = "\U0001F5F8"; }
                    dataGridView1.Rows[i].Cells[1].Value = e.Indate;
                    dataGridView1.Rows[i].Cells[2].Value = e.Outdate;
                    dataGridView1.Rows[i].Cells[3].Value = e.Summ;
                    dataGridView1.Rows[i].Cells[4].Value = e.Discounts.Sale;
                }
            }catch (Exception ex)
            {
                MessageBox.Show("\tОшибка при выводе в таблицу талонов\nВозможно данные отсутсвуют или еще в стадии обработки\n" +
                    "Подождите пожалуйста");
            }
            
        }
    }
}
