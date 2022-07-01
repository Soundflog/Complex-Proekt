using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YCHET_AUTOSTOYANKI.Forms.Admin;

namespace YCHET_AUTOSTOYANKI.Forms
{
    public partial class Admin_menu : Form
    {
        public Admin_menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin_main admin_main = new Admin_main();
            admin_main.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Admin_all_clients admin_clients = new Admin_all_clients();
            admin_clients.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Admin_all_vouchers admin_voucher = new Admin_all_vouchers();
            admin_voucher.Show();
            this.Hide();
        }
    }
}
