namespace YCHET_AUTOSTOYANKI.Forms
{
    partial class Admin_update_client
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_update_client));
            this.textSeriaNumber = new System.Windows.Forms.TextBox();
            this.textNumberphone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textGosnumber = new System.Windows.Forms.TextBox();
            this.textMidname = new System.Windows.Forms.TextBox();
            this.textFirstname = new System.Windows.Forms.TextBox();
            this.textLastname = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textSeriaNumber
            // 
            this.textSeriaNumber.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textSeriaNumber.Location = new System.Drawing.Point(42, 436);
            this.textSeriaNumber.Name = "textSeriaNumber";
            this.textSeriaNumber.PlaceholderText = "Серия номер документа";
            this.textSeriaNumber.Size = new System.Drawing.Size(227, 34);
            this.textSeriaNumber.TabIndex = 34;
            this.textSeriaNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textNumberphone
            // 
            this.textNumberphone.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textNumberphone.Location = new System.Drawing.Point(42, 372);
            this.textNumberphone.Name = "textNumberphone";
            this.textNumberphone.PlaceholderText = "Номер телефона";
            this.textNumberphone.Size = new System.Drawing.Size(227, 34);
            this.textNumberphone.TabIndex = 33;
            this.textNumberphone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(85, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 35);
            this.label1.TabIndex = 32;
            this.label1.Text = "Изменить";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(42, 312);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(227, 34);
            this.comboBox1.TabIndex = 31;
            this.comboBox1.Text = "Авто";
            // 
            // textGosnumber
            // 
            this.textGosnumber.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textGosnumber.Location = new System.Drawing.Point(42, 251);
            this.textGosnumber.Name = "textGosnumber";
            this.textGosnumber.PlaceholderText = "Гос. номер";
            this.textGosnumber.Size = new System.Drawing.Size(227, 34);
            this.textGosnumber.TabIndex = 30;
            this.textGosnumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textMidname
            // 
            this.textMidname.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textMidname.Location = new System.Drawing.Point(42, 187);
            this.textMidname.Name = "textMidname";
            this.textMidname.PlaceholderText = "Отчество";
            this.textMidname.Size = new System.Drawing.Size(227, 34);
            this.textMidname.TabIndex = 29;
            this.textMidname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textFirstname
            // 
            this.textFirstname.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textFirstname.Location = new System.Drawing.Point(42, 123);
            this.textFirstname.Name = "textFirstname";
            this.textFirstname.PlaceholderText = "Имя";
            this.textFirstname.Size = new System.Drawing.Size(227, 34);
            this.textFirstname.TabIndex = 28;
            this.textFirstname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textLastname
            // 
            this.textLastname.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textLastname.Location = new System.Drawing.Point(42, 59);
            this.textLastname.Name = "textLastname";
            this.textLastname.PlaceholderText = "Фамилия";
            this.textLastname.Size = new System.Drawing.Size(227, 34);
            this.textLastname.TabIndex = 27;
            this.textLastname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(42, 500);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(227, 48);
            this.button1.TabIndex = 26;
            this.button1.Text = "Изменить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 35;
            this.label2.Visible = false;
            // 
            // Admin_update_client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 560);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textSeriaNumber);
            this.Controls.Add(this.textNumberphone);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textGosnumber);
            this.Controls.Add(this.textMidname);
            this.Controls.Add(this.textFirstname);
            this.Controls.Add(this.textLastname);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Admin_update_client";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Изменение данных клиента";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public TextBox textSeriaNumber;
        public TextBox textNumberphone;
        private Label label1;
        private ComboBox comboBox1;
        public TextBox textGosnumber;
        public TextBox textMidname;
        public TextBox textFirstname;
        public TextBox textLastname;
        private Button button1;
        public Label label2;
    }
}