namespace YCHET_AUTOSTOYANKI.Forms
{
    partial class Client_profile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Client_profile));
            this.panel1 = new System.Windows.Forms.Panel();
            this.textSerianumber = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textGosnumber = new System.Windows.Forms.TextBox();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.textLogin = new System.Windows.Forms.TextBox();
            this.textNumberPhone = new System.Windows.Forms.TextBox();
            this.textMidname = new System.Windows.Forms.TextBox();
            this.textFirstname = new System.Windows.Forms.TextBox();
            this.textLastname = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Indate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Outdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Summ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textSerianumber);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.textGosnumber);
            this.panel1.Controls.Add(this.textPassword);
            this.panel1.Controls.Add(this.textLogin);
            this.panel1.Controls.Add(this.textNumberPhone);
            this.panel1.Controls.Add(this.textMidname);
            this.panel1.Controls.Add(this.textFirstname);
            this.panel1.Controls.Add(this.textLastname);
            this.panel1.Location = new System.Drawing.Point(31, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(472, 611);
            this.panel1.TabIndex = 0;
            // 
            // textSerianumber
            // 
            this.textSerianumber.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textSerianumber.Location = new System.Drawing.Point(256, 88);
            this.textSerianumber.Name = "textSerianumber";
            this.textSerianumber.PlaceholderText = "Phone";
            this.textSerianumber.ReadOnly = true;
            this.textSerianumber.Size = new System.Drawing.Size(196, 34);
            this.textSerianumber.TabIndex = 8;
            this.textSerianumber.Text = " ";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(256, 163);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(196, 34);
            this.comboBox1.TabIndex = 7;
            // 
            // textGosnumber
            // 
            this.textGosnumber.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textGosnumber.Location = new System.Drawing.Point(256, 11);
            this.textGosnumber.Name = "textGosnumber";
            this.textGosnumber.ReadOnly = true;
            this.textGosnumber.Size = new System.Drawing.Size(196, 34);
            this.textGosnumber.TabIndex = 6;
            // 
            // textPassword
            // 
            this.textPassword.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textPassword.Location = new System.Drawing.Point(119, 480);
            this.textPassword.Name = "textPassword";
            this.textPassword.PlaceholderText = "Password";
            this.textPassword.ReadOnly = true;
            this.textPassword.Size = new System.Drawing.Size(196, 34);
            this.textPassword.TabIndex = 5;
            // 
            // textLogin
            // 
            this.textLogin.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textLogin.Location = new System.Drawing.Point(119, 411);
            this.textLogin.Name = "textLogin";
            this.textLogin.PlaceholderText = "Login";
            this.textLogin.ReadOnly = true;
            this.textLogin.Size = new System.Drawing.Size(196, 34);
            this.textLogin.TabIndex = 4;
            // 
            // textNumberPhone
            // 
            this.textNumberPhone.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textNumberPhone.Location = new System.Drawing.Point(3, 237);
            this.textNumberPhone.Name = "textNumberPhone";
            this.textNumberPhone.PlaceholderText = "Phone";
            this.textNumberPhone.ReadOnly = true;
            this.textNumberPhone.Size = new System.Drawing.Size(196, 34);
            this.textNumberPhone.TabIndex = 3;
            this.textNumberPhone.Text = " ";
            // 
            // textMidname
            // 
            this.textMidname.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textMidname.Location = new System.Drawing.Point(3, 163);
            this.textMidname.Name = "textMidname";
            this.textMidname.ReadOnly = true;
            this.textMidname.Size = new System.Drawing.Size(196, 34);
            this.textMidname.TabIndex = 2;
            // 
            // textFirstname
            // 
            this.textFirstname.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textFirstname.Location = new System.Drawing.Point(3, 88);
            this.textFirstname.Name = "textFirstname";
            this.textFirstname.ReadOnly = true;
            this.textFirstname.Size = new System.Drawing.Size(196, 34);
            this.textFirstname.TabIndex = 1;
            // 
            // textLastname
            // 
            this.textLastname.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textLastname.Location = new System.Drawing.Point(3, 11);
            this.textLastname.Name = "textLastname";
            this.textLastname.ReadOnly = true;
            this.textLastname.Size = new System.Drawing.Size(196, 34);
            this.textLastname.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Status,
            this.Indate,
            this.Outdate,
            this.Summ,
            this.Discount});
            this.dataGridView1.Location = new System.Drawing.Point(546, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(868, 611);
            this.dataGridView1.TabIndex = 1;
            // 
            // Status
            // 
            this.Status.HeaderText = "Статус";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
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
            // Summ
            // 
            this.Summ.HeaderText = "Сумма";
            this.Summ.MinimumWidth = 6;
            this.Summ.Name = "Summ";
            this.Summ.ReadOnly = true;
            // 
            // Discount
            // 
            this.Discount.HeaderText = "Скидка";
            this.Discount.MinimumWidth = 6;
            this.Discount.Name = "Discount";
            this.Discount.ReadOnly = true;
            // 
            // Client_profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1426, 655);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Client_profile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Client_profile";
            this.Load += new System.EventHandler(this.Client_profile_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private TextBox textPassword;
        private TextBox textLogin;
        private TextBox textNumberPhone;
        private TextBox textMidname;
        private TextBox textFirstname;
        private TextBox textLastname;
        private DataGridView dataGridView1;
        private TextBox textSerianumber;
        private ComboBox comboBox1;
        private TextBox textGosnumber;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn Indate;
        private DataGridViewTextBoxColumn Outdate;
        private DataGridViewTextBoxColumn Summ;
        private DataGridViewTextBoxColumn Discount;
    }
}