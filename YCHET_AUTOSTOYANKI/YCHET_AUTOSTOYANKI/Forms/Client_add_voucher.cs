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
    public partial class Client_add_voucher : Form
    {
        public Client_add_voucher()
        {
            InitializeComponent();
            using (Database db = new Database())
            {
                foreach (Autostop stop in db.Autostops.OrderBy(a=>a.Id))
                {
                    comboBox1.Items.Add(stop.Name);
                }
                db.SaveChanges();
            }
        }
        private void Client_add_voucher_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value < dateTimePicker2.Value)
            {
                int[] ints = new int[23];
                DateTime dt1 = dateTimePicker1.Value;
                DateTime dt2 = dateTimePicker2.Value;
                TimeSpan timeSpan = dt2 - dt1;
                int summ = 0;
                for (int i = 0; i < ints.Length; i++)
                {
                    if (timeSpan.Days < 1 && timeSpan.Hours == i)
                    {
                        textBox1.Text = summ.ToString();
                        break;
                    }
                    if (timeSpan.Days == i && timeSpan.Hours == i)
                    {
                        summ += i*2400;
                        textBox1.Text = summ.ToString();
                        break;
                    }
                    summ += 100;
                }
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                DialogResult result = MessageBox.Show($"Вы уверены\nСумма: {summ}",
                    "Выберите действие", buttons);
                if (result == DialogResult.OK)
                {
                    DateTime d_1 = ddtoString(dateTimePicker1.Value.Year.ToString(),
                        dateTimePicker1.Value.Month.ToString(),
                        dateTimePicker1.Value.Day.ToString(),
                        dateTimePicker1.Value.Hour.ToString(),
                        dateTimePicker1.Value.Minute.ToString(),
                        dateTimePicker1.Value.Second.ToString());
                    DateTime d_2 = ddtoString(dateTimePicker2.Value.Year.ToString(),
                        dateTimePicker2.Value.Month.ToString(),
                        dateTimePicker2.Value.Day.ToString(),
                        dateTimePicker2.Value.Hour.ToString(),
                        dateTimePicker2.Value.Minute.ToString(),
                        dateTimePicker2.Value.Second.ToString());
                    try
                    {
                        using (Database db = new Database())
                        {
                            var voucher = new Voucher();
                            voucher.Id = db.Vouchers.Count() + 1;
                            voucher.Indate = d_1;
                            voucher.Outdate = d_2;
                            voucher.Summ = summ;
                            voucher.Discounts = db.Discounts.ToList()[0];
                            db.Vouchers.Add(voucher);

                            var contract = new Contract();
                            contract.Id = db.Contracts.Count() + 1;
                            contract.ConclusionDate = d_1;
                            contract.Autostops = db.Autostops.ToList()[comboBox1.SelectedIndex];
                            contract.Staffs = db.Staffs.ToList()[0];
                            contract.Vouchers = voucher;
                            var id = Start_authorization.id_client - 1;
                            contract.Clients = db.Clients.ToList()[id];
                            db.Contracts.Add(contract);

                            var autostop = db.Autostops.SingleOrDefault(a => a.Id == comboBox1.SelectedIndex);
                            if (autostop != null && autostop.Seats != 0)
                            {
                                autostop.Seats -= 1;
                                db.Autostops.Update(autostop);
                            }
                            else MessageBox.Show("\tИзвините, все места заняты\nПожалуйста выберите другую парковку");
                            db.SaveChanges();
                        }                   
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка:\n" + ex);
                    }
                    this.Close(); 
                }
                else { return; }
            }
        }
        private DateTime ddtoString(string yy, string mm, string dd, string hh, string min, string sec)
        {
            string utc = "Z";
            string all = yy + "-" + mm + "-" + dd + " " + hh + ":" + min + ":" + sec + utc;
            return DateTime.Parse(all);
        }
    }
}
