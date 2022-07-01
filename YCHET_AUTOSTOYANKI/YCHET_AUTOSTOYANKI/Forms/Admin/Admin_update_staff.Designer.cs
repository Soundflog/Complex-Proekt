namespace YCHET_AUTOSTOYANKI.Forms
{
    partial class Admin_update_staff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_update_staff));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtMidname = new System.Windows.Forms.TextBox();
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 22;
            this.label2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(94, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 35);
            this.label1.TabIndex = 21;
            this.label1.Text = "Изменить";
            // 
            // comboBox1
            // 
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(49, 318);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(227, 34);
            this.comboBox1.TabIndex = 20;
            this.comboBox1.Text = "Роль";
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDescription.Location = new System.Drawing.Point(49, 251);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.PlaceholderText = "Должность";
            this.txtDescription.Size = new System.Drawing.Size(227, 34);
            this.txtDescription.TabIndex = 19;
            this.txtDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMidname
            // 
            this.txtMidname.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMidname.Location = new System.Drawing.Point(49, 187);
            this.txtMidname.Name = "txtMidname";
            this.txtMidname.PlaceholderText = "Отчество";
            this.txtMidname.Size = new System.Drawing.Size(227, 34);
            this.txtMidname.TabIndex = 18;
            this.txtMidname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtFirstname
            // 
            this.txtFirstname.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFirstname.Location = new System.Drawing.Point(49, 123);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.PlaceholderText = "Имя";
            this.txtFirstname.Size = new System.Drawing.Size(227, 34);
            this.txtFirstname.TabIndex = 17;
            this.txtFirstname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLastname
            // 
            this.txtLastname.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtLastname.Location = new System.Drawing.Point(49, 59);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.PlaceholderText = "Фамилия";
            this.txtLastname.Size = new System.Drawing.Size(227, 34);
            this.txtLastname.TabIndex = 16;
            this.txtLastname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(105, 379);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 48);
            this.button1.TabIndex = 15;
            this.button1.Text = "Изменить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Admin_update_staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 443);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtMidname);
            this.Controls.Add(this.txtFirstname);
            this.Controls.Add(this.txtLastname);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Admin_update_staff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin_update_staff";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Label label2;
        private Label label1;
        public ComboBox comboBox1;
        public TextBox txtDescription;
        public TextBox txtMidname;
        public TextBox txtFirstname;
        public TextBox txtLastname;
        private Button button1;
    }
}