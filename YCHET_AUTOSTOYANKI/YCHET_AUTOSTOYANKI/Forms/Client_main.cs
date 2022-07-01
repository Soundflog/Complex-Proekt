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
    public partial class Client_main : Form
    {
        public Client_main()
        {
            InitializeComponent();
            using (Database db = new Database())
            {
                var autostops = db.Autostops.ToList();
                db.SaveChanges();
                SetDataGrid(autostops);
            }
        }
        private void SetDataGrid(List<Autostop> autostops)
        {
            dataGridView1.RowCount = autostops.Count;
            for (int i = 0; i < autostops.Count; i++)
            {
                var e = autostops[i];
                dataGridView1.Rows[i].Cells[0].Value = e.Name;
                dataGridView1.Rows[i].Cells[1].Value = e.Type;
                dataGridView1.Rows[i].Cells[2].Value = e.Seats + "/50";
                dataGridView1.Rows[i].Cells[3].Value = e.Address;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Client_add_voucher client_add = new Client_add_voucher();
            client_add.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            using (Database db = new Database())
            {
                var autostops = db.Autostops.ToList();
                db.SaveChanges();
                SetDataGrid(autostops);
            } 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Client_profile().Show();
        }

        private void Client_main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
