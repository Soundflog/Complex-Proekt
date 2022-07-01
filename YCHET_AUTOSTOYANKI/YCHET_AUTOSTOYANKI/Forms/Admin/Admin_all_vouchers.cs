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
using Excel = Microsoft.Office.Interop.Excel;

namespace YCHET_AUTOSTOYANKI.Forms.Admin
{
    public partial class Admin_all_vouchers : Form
    {
        public Admin_all_vouchers()
        {
            InitializeComponent();
            using (Database db = new Database())
            {
                var contractr = db.Contracts.ToList();
                SetDataGridVoucher(contractr);
            }
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var id = int.Parse(dataGridView3.Rows[dataGridView3.CurrentRow.Index].Cells[0].Value.ToString());
                MessageBoxButtons buttons = MessageBoxButtons.YesNoCancel;
                DialogResult result = MessageBox.Show("Хотите удалить выбранную строчку?", "Выберите действие", buttons);
                if (result == DialogResult.Yes)
                {
                    using (Database db = new Database())
                    {
                        var contract = SearchById(db.Contracts.ToList(), id);
                        db.Remove(contract);
                        db.SaveChanges();
                    }
                    MessageBox.Show("Удаление прошло успешно", "Удаление");
                }
                else
                {
                    return;
                }
            }catch (Exception ex)
            {
                MessageBox.Show("Ошибка при удалении записи:\n"+ex);
            }
            
        }
        private Contract SearchById(List<Contract> contra, int id)
        {
            Contract newcontract = null;
            foreach (Contract c in contra)
            {
                if (c.Id == id) newcontract = c;
            }
            return newcontract;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView3.Rows.Clear();
                using (Database db = new Database())
                {
                    var contracts = db.Contracts.ToList();
                    String summ = textBox1.Text;
                    String lastname = textBox2.Text;

                    if (summ != "" && lastname != "")
                    {
                        var contracts1 = db.Contracts.Where(p => EF.Functions.Like(p.Clients.Lastname, "%" + lastname + "%"))
                        .Where(p => EF.Functions.Like(p.Vouchers.Summ.ToString(), summ)).ToList();
                        SetDataGridVoucher(contracts1);
                    }
                    else if (summ == "" && lastname != "")
                    {
                        var contracts2 = db.Contracts.Where(p => EF.Functions.Like(p.Clients.Lastname, "%" + lastname + "%"))
                        .ToList();
                        SetDataGridVoucher(contracts2);
                    }
                    else if (summ != "" && lastname == "")
                    {
                        var contracts3 = db.Contracts
                        .Where(p => EF.Functions.Like(p.Vouchers.Summ.ToString(), summ)).ToList();
                        SetDataGridVoucher(contracts3);
                    }
                    else
                    {
                        SetDataGridVoucher(contracts);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка:\nНе удалось найти данные по поиску\n" + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView3.Rows.Clear();
            using (Database db = new Database())
            {
                var contractr = db.Contracts.ToList();
                SetDataGridVoucher(contractr);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void SetDataGridVoucher(List<Contract> contracts)
        {
            dataGridView3.RowCount = contracts.Count;
            for (int i = 0; i < contracts.Count; i++)
            {
                var c = contracts[i];
                dataGridView3.Rows[i].Cells[1].Value = c.Id;
                if (DateTime.Now >= c.Vouchers.Outdate) { dataGridView3.Rows[i].Cells[0].Value = "\U0001F5D9"; }
                else { dataGridView3.Rows[i].Cells[0].Value = "\U0001F5F8"; }
                dataGridView3.Rows[i].Cells[2].Value = c.Clients.Lastname;
                dataGridView3.Rows[i].Cells[3].Value = c.Clients.Firstname;
                dataGridView3.Rows[i].Cells[4].Value = c.Clients.Midname;
                dataGridView3.Rows[i].Cells[5].Value = c.Vouchers.Indate;
                dataGridView3.Rows[i].Cells[6].Value = c.Vouchers.Outdate;
                dataGridView3.Rows[i].Cells[7].Value = c.Clients.Gosnumber;
                dataGridView3.Rows[i].Cells[8].Value = c.Vouchers.Summ;
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
            Admin_main admin_Main = new Admin_main();
            admin_Main.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                using (Database db = new Database())
                {
                    var contracts = db.Contracts.ToList();
                    Excel.Application excel = new Excel.Application();
                    excel.Workbooks.Add(Type.Missing);
                    Excel.Workbook workbook = excel.Workbooks[1];
                    Excel.Worksheet worksheet = workbook.Worksheets.get_Item(1);
                    int count = 0;
                    for (int i = 1; i <= contracts.Count; i++)
                    {
                        worksheet.Cells[i, 1].Value = contracts[i - 1].Id;
                        worksheet.Cells[i, 2].Value = contracts[i - 1].Clients.Lastname;
                        worksheet.Cells[i, 3].Value = contracts[i - 1].Clients.Firstname;
                        worksheet.Cells[i, 4].Value = contracts[i - 1].Clients.Midname;
                        worksheet.Cells[i, 5].Value = contracts[i - 1].Vouchers.Indate;
                        worksheet.Cells[i, 6].Value = contracts[i - 1].Vouchers.Outdate;
                        worksheet.Cells[i, 7].Value = contracts[i - 1].Clients.Gosnumber;
                        worksheet.Cells[i, 8].Value = contracts[i - 1].Vouchers.Summ;
                    }
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Admin_all_vouchers_FormClosed(object sender, FormClosedEventArgs e)
        {
            Admin_menu menu = new Admin_menu();
            menu.Show();
        }
    }
}
