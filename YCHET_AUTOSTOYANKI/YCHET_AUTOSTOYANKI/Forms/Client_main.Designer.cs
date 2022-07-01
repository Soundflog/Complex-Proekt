namespace YCHET_AUTOSTOYANKI.Forms
{
    partial class Client_main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Client_main));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AutostopName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AutostopType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AutostopSeats = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AutostopAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AutostopName,
            this.AutostopType,
            this.AutostopSeats,
            this.AutostopAddress});
            this.dataGridView1.Location = new System.Drawing.Point(5, 134);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(932, 360);
            this.dataGridView1.TabIndex = 4;
            // 
            // AutostopName
            // 
            this.AutostopName.HeaderText = "Австоянка";
            this.AutostopName.MinimumWidth = 6;
            this.AutostopName.Name = "AutostopName";
            this.AutostopName.ReadOnly = true;
            // 
            // AutostopType
            // 
            this.AutostopType.HeaderText = "Тип";
            this.AutostopType.MinimumWidth = 6;
            this.AutostopType.Name = "AutostopType";
            this.AutostopType.ReadOnly = true;
            // 
            // AutostopSeats
            // 
            this.AutostopSeats.HeaderText = "Кол-во мест";
            this.AutostopSeats.MinimumWidth = 6;
            this.AutostopSeats.Name = "AutostopSeats";
            this.AutostopSeats.ReadOnly = true;
            // 
            // AutostopAddress
            // 
            this.AutostopAddress.HeaderText = "Адрес";
            this.AutostopAddress.MinimumWidth = 6;
            this.AutostopAddress.Name = "AutostopAddress";
            this.AutostopAddress.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(79, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(208, 81);
            this.button1.TabIndex = 3;
            this.button1.Text = "Купить билет";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(439, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 5;
            this.label1.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(315, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(208, 81);
            this.button2.TabIndex = 6;
            this.button2.Text = "Обновить данные";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(851, 11);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(86, 65);
            this.button3.TabIndex = 7;
            this.button3.Text = "Мой профиль";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Client_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 501);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Client_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Паркинг";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Client_main_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn AutostopName;
        private DataGridViewTextBoxColumn AutostopType;
        private DataGridViewTextBoxColumn AutostopSeats;
        private DataGridViewTextBoxColumn AutostopAddress;
        private Button button1;
        public Label label1;
        private Button button2;
        private Button button3;
    }
}