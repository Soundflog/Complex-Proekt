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
using YCHET_AUTOSTOYANKI.Forms.Admin;
using YCHET_AUTOSTOYANKI.Tables;
using Excel = Microsoft.Office.Interop.Excel;

namespace YCHET_AUTOSTOYANKI.Forms
{
    public partial class Admin_main : Form
    {
        static public int id_clien_for_update;
        public Admin_main()
        {
            InitializeComponent();

            using (Database db = new Database())
            {
                foreach (Role roles in db.Roles)
                {
                    comboBox1.Items.Add(roles.Namerole);
                }
                comboBox1.Items.Remove("Клиент");

                var staff = db.Staffs.ToList();
                db.SaveChanges();
                SetDataGridStaff(staff);
            }
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void SetDataGridStaff(List<Staff> staffs)
        {
            dataGridView1.RowCount = staffs.Count;
            for (int i = 0; i < staffs.Count; i++)
            {
                var s = staffs[i];
                dataGridView1.Rows[i].Cells[0].Value = s.Id;
                dataGridView1.Rows[i].Cells[1].Value = s.Lastname;
                dataGridView1.Rows[i].Cells[2].Value = s.Firstname;
                dataGridView1.Rows[i].Cells[3].Value = s.Midname;
                dataGridView1.Rows[i].Cells[4].Value = s.Desription;
                dataGridView1.Rows[i].Cells[5].Value = s.Roles.Namerole;
            }
        }
        
        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString());
            MessageBoxButtons buttons = MessageBoxButtons.YesNoCancel;
            DialogResult result = MessageBox.Show("Чтобы удалить выбранную строчку - нажмите Да.\n " +
                "Чтобы редактировать выбранную строчку - нажмите Нет", "Выберите действие", buttons);
            if (result == DialogResult.Yes)
            {
                using (Database db = new Database())
                {
                    var staff = SearchById(db.Staffs.ToList(), id);
                    db.Remove(staff);
                    db.SaveChanges();
                }
                MessageBox.Show("Удаление прошло успешно", "Удаление");
            }
            else if (result == DialogResult.No)
            {
                Admin_update_staff f_admin_update = new Admin_update_staff();
                var surname = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value;
                var name = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].Value;
                var midname = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[3].Value;
                var desription = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[4].Value;
                var role = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[5].Value;
                id_clien_for_update = id;
                f_admin_update.txtLastname.Text = surname.ToString();
                f_admin_update.txtFirstname.Text = name.ToString();
                f_admin_update.txtMidname.Text = midname.ToString();
                f_admin_update.txtDescription.Text = desription.ToString();
                f_admin_update.comboBox1.Text = role.ToString();
                f_admin_update.Show();
            }
            else
            {
                return;
            }
        }
        private Staff SearchById(List<Staff> staffs, int id)
        {
            Staff staff = null;
            foreach (Staff e in staffs)
            {
                if (e.Id == id) staff = e;
            }

            return staff;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            try
            {
                using (Database db = new Database())
                {
                    var staffs = db.Staffs.ToList();
                    SetDataGridStaff(staffs);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка:\nПри выводе сотрудников\n" + ex.Message);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            new Admin_add_staff().Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            try
            {
                var idRole = comboBox1.SelectedIndex + 1;
                dataGridView1.Rows.Clear();
                using (Database db = new Database())
                {
                    var staffs = db.Staffs.ToList();
                    db.Roles.ToList();
                    String description = textBox1.Text;
                    db.SaveChanges();
                    if (description != null && !(comboBox1.Text == "" || comboBox1.Text == "Роль"))
                    {
                        var staffs1 = db.Staffs.Where(p => EF.Functions.Like(p.Desription, "%" + description + "%"))
                        .Where(p => EF.Functions.Like(p.Roles.Namerole, comboBox1.Text)).ToList();
                        SetDataGridStaff(staffs1);
                    }
                    else if (description != null && (comboBox1.Text == "" || comboBox1.Text == "Роль"))
                    {
                        var staffs3 = db.Staffs.Where(p => EF.Functions.Like(p.Desription, "%" + description + "%")).ToList();
                        SetDataGridStaff(staffs3);
                    }
                    else
                    {
                        SetDataGridStaff(staffs);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка:\nНе удалось найти данные по поиску\n" + ex.Message);
            }
        }

        private void button6_Click_1(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            try
            {
                using (Database db = new Database())
                {
                    var staff = db.Staffs.ToList();
                    Excel.Application excel = new Excel.Application();
                    excel.Workbooks.Add(Type.Missing);
                    Excel.Workbook workbook = excel.Workbooks[1];
                    Excel.Worksheet worksheet = workbook.Worksheets.get_Item(1);
                    int count = 0;
                    for (int i = 1; i <= staff.Count; i++)
                    {
                        worksheet.Cells[i, 1].Value = staff[i - 1].Id;
                        worksheet.Cells[i, 2].Value = staff[i - 1].Lastname;
                        worksheet.Cells[i, 3].Value = staff[i - 1].Firstname;
                        worksheet.Cells[i, 4].Value = staff[i - 1].Midname;
                        worksheet.Cells[i, 5].Value = staff[i - 1].Desription;
                        worksheet.Cells[i, 6].Value = staff[i - 1].Roles.Namerole;
                        if (staff[i - 1].Roles.Namerole == "Сотрудник")
                        {
                            count++;
                        }
                    }
                    worksheet.Cells[1, 9].Value = "Кол-во сотрудников";
                    worksheet.Cells[1, 10].Value = count;
                    DialogResult res = MessageBox.Show("Экспорт завершен. При нажатии Да будет открыт сгенерированный файл," +
                        " при нажатии Нет будет предложено сохранить файл.", "Экспорт в Excel", MessageBoxButtons.YesNoCancel);
                    if (res == DialogResult.Yes)
                    { excel.Visible = true; }
                    if (res == DialogResult.No)
                    {
                        string fileName = String.Empty;
                        SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                        saveFileDialog1.Filter = "xls files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                        saveFileDialog1.FilterIndex = 1;
                        saveFileDialog1.RestoreDirectory = true;
                        if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                        {
                            fileName = saveFileDialog1.FileName;
                        }
                        else
                            return;

                        workbook.SaveAs(fileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                            Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive,
                            Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                        saveFileDialog1.Dispose();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Что-то пошло не так:\n" + ex.Message);
            }
        }
        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin_all_clients admin_All_Clients = new Admin_all_clients();
            admin_All_Clients.Show();
            this.Close();
        }

        private void открытьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Admin_all_vouchers admin_All_Vouchers = new Admin_all_vouchers();
            admin_All_Vouchers.Show();
            this.Close();
        }
        

        private void Admin_main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Admin_menu menu = new Admin_menu();
            menu.Show();
        }
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void клиентыToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
