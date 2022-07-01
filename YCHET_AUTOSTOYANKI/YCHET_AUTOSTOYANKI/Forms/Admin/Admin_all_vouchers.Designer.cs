namespace YCHET_AUTOSTOYANKI.Forms.Admin
{
    partial class Admin_all_vouchers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_all_vouchers));
            this.button6 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.stat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Firstname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Midname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Indate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Outdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.клиентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сотрудникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.инфоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменениеДанныхВТаблицеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.дляИзмененияДанныхВТаблицахToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button6
            // 
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Location = new System.Drawing.Point(149, 87);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(163, 53);
            this.button6.TabIndex = 43;
            this.button6.Text = "Поиск";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox2.Location = new System.Drawing.Point(149, 24);
            this.textBox2.Name = "textBox2";
            this.textBox2.PlaceholderText = "Поиск по фамилии";
            this.textBox2.Size = new System.Drawing.Size(277, 34);
            this.textBox2.TabIndex = 42;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Location = new System.Drawing.Point(12, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 83);
            this.button2.TabIndex = 40;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stat,
            this.ID,
            this.Lastname,
            this.Firstname,
            this.Midname,
            this.Indate,
            this.Outdate,
            this.Column9,
            this.Column10});
            this.dataGridView3.Location = new System.Drawing.Point(12, 220);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 29;
            this.dataGridView3.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView3.Size = new System.Drawing.Size(1552, 553);
            this.dataGridView3.TabIndex = 44;
            this.dataGridView3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            // 
            // stat
            // 
            this.stat.HeaderText = "Статус";
            this.stat.MinimumWidth = 6;
            this.stat.Name = "stat";
            this.stat.ReadOnly = true;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Lastname
            // 
            this.Lastname.HeaderText = "Фамилия";
            this.Lastname.MinimumWidth = 6;
            this.Lastname.Name = "Lastname";
            this.Lastname.ReadOnly = true;
            // 
            // Firstname
            // 
            this.Firstname.HeaderText = "Имя";
            this.Firstname.MinimumWidth = 6;
            this.Firstname.Name = "Firstname";
            this.Firstname.ReadOnly = true;
            // 
            // Midname
            // 
            this.Midname.HeaderText = "Отчество";
            this.Midname.MinimumWidth = 6;
            this.Midname.Name = "Midname";
            this.Midname.ReadOnly = true;
            // 
            // Indate
            // 
            this.Indate.HeaderText = "Дата заезда";
            this.Indate.MinimumWidth = 6;
            this.Indate.Name = "Indate";
            this.Indate.ReadOnly = true;
            // 
            // Outdate
            // 
            this.Outdate.HeaderText = "Дата выезда";
            this.Outdate.MinimumWidth = 6;
            this.Outdate.Name = "Outdate";
            this.Outdate.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Гос номер";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Сумма";
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(451, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "Поиск по Сумме";
            this.textBox1.Size = new System.Drawing.Size(277, 34);
            this.textBox1.TabIndex = 46;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::YCHET_AUTOSTOYANKI.Properties.Resources.чел_;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(12, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 83);
            this.button1.TabIndex = 47;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem,
            this.инфоToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1573, 34);
            this.menuStrip1.TabIndex = 48;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.клиентыToolStripMenuItem,
            this.сотрудникиToolStripMenuItem});
            this.менюToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(84, 30);
            this.менюToolStripMenuItem.Text = "Меню";
            // 
            // клиентыToolStripMenuItem
            // 
            this.клиентыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem});
            this.клиентыToolStripMenuItem.Name = "клиентыToolStripMenuItem";
            this.клиентыToolStripMenuItem.Size = new System.Drawing.Size(216, 30);
            this.клиентыToolStripMenuItem.Text = "Клиенты";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(183, 30);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // сотрудникиToolStripMenuItem
            // 
            this.сотрудникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem1});
            this.сотрудникиToolStripMenuItem.Name = "сотрудникиToolStripMenuItem";
            this.сотрудникиToolStripMenuItem.Size = new System.Drawing.Size(216, 30);
            this.сотрудникиToolStripMenuItem.Text = "Сотрудники";
            // 
            // открытьToolStripMenuItem1
            // 
            this.открытьToolStripMenuItem1.Name = "открытьToolStripMenuItem1";
            this.открытьToolStripMenuItem1.Size = new System.Drawing.Size(183, 30);
            this.открытьToolStripMenuItem1.Text = "Открыть";
            this.открытьToolStripMenuItem1.Click += new System.EventHandler(this.открытьToolStripMenuItem1_Click);
            // 
            // инфоToolStripMenuItem
            // 
            this.инфоToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.изменениеДанныхВТаблицеToolStripMenuItem});
            this.инфоToolStripMenuItem.Name = "инфоToolStripMenuItem";
            this.инфоToolStripMenuItem.Size = new System.Drawing.Size(80, 30);
            this.инфоToolStripMenuItem.Text = "Инфо";
            // 
            // изменениеДанныхВТаблицеToolStripMenuItem
            // 
            this.изменениеДанныхВТаблицеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.дляИзмененияДанныхВТаблицахToolStripMenuItem});
            this.изменениеДанныхВТаблицеToolStripMenuItem.Name = "изменениеДанныхВТаблицеToolStripMenuItem";
            this.изменениеДанныхВТаблицеToolStripMenuItem.Size = new System.Drawing.Size(380, 30);
            this.изменениеДанныхВТаблицеToolStripMenuItem.Text = "Изменение данных в таблице";
            // 
            // дляИзмененияДанныхВТаблицахToolStripMenuItem
            // 
            this.дляИзмененияДанныхВТаблицахToolStripMenuItem.Name = "дляИзмененияДанныхВТаблицахToolStripMenuItem";
            this.дляИзмененияДанныхВТаблицахToolStripMenuItem.Size = new System.Drawing.Size(433, 30);
            this.дляИзмененияДанныхВТаблицахToolStripMenuItem.Text = "Для изменения данных в таблицах";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(156, 30);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Location = new System.Drawing.Point(12, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1552, 177);
            this.panel1.TabIndex = 49;
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::YCHET_AUTOSTOYANKI.Properties.Resources.excel;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button4.Location = new System.Drawing.Point(1475, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(74, 60);
            this.button4.TabIndex = 48;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Admin_all_vouchers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1573, 777);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dataGridView3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Admin_all_vouchers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Все талоны [админ]";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Admin_all_vouchers_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button6;
        private TextBox textBox2;
        private Button button2;
        private DataGridView dataGridView3;
        private TextBox textBox1;
        private Button button1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem менюToolStripMenuItem;
        private ToolStripMenuItem клиентыToolStripMenuItem;
        private ToolStripMenuItem сотрудникиToolStripMenuItem;
        private ToolStripMenuItem инфоToolStripMenuItem;
        private ToolStripMenuItem изменениеДанныхВТаблицеToolStripMenuItem;
        private ToolStripMenuItem дляИзмененияДанныхВТаблицахToolStripMenuItem;
        private ToolStripMenuItem оПрограммеToolStripMenuItem;
        private ToolStripMenuItem открытьToolStripMenuItem;
        private ToolStripMenuItem открытьToolStripMenuItem1;
        private Panel panel1;
        private Button button4;
        private DataGridViewTextBoxColumn stat;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Lastname;
        private DataGridViewTextBoxColumn Firstname;
        private DataGridViewTextBoxColumn Midname;
        private DataGridViewTextBoxColumn Indate;
        private DataGridViewTextBoxColumn Outdate;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
    }
}