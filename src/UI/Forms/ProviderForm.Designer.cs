namespace UI.Forms
{
    partial class ProviderForm
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
            dgvProviders = new DataGridView();
            txtName = new TextBox();
            txtAddress = new TextBox();
            txtEmail = new TextBox();
            txtPhone = new TextBox();
            txt_Description = new TextBox();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnCreate = new Button();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            button3 = new Button();
            button4 = new Button();
            button2 = new Button();
            button1 = new Button();
            txtSurname = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvProviders).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dgvProviders
            // 
            dgvProviders.AllowUserToAddRows = false;
            dgvProviders.AllowUserToDeleteRows = false;
            dgvProviders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvProviders.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvProviders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProviders.Dock = DockStyle.Top;
            dgvProviders.Location = new Point(0, 0);
            dgvProviders.Name = "dgvProviders";
            dgvProviders.ReadOnly = true;
            dgvProviders.RowTemplate.Height = 25;
            dgvProviders.Size = new Size(685, 313);
            dgvProviders.TabIndex = 0;
            dgvProviders.CellContentClick += dgvProviders_CellContentClick;
            dgvProviders.SelectionChanged += dgvProviders_SelectionChanged;
            // 
            // txtName
            // 
            txtName.Location = new Point(74, 16);
            txtName.Name = "txtName";
            txtName.Size = new Size(290, 23);
            txtName.TabIndex = 1;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(74, 83);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(290, 23);
            txtAddress.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(74, 112);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(290, 23);
            txtEmail.TabIndex = 1;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(74, 141);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(290, 23);
            txtPhone.TabIndex = 1;
            // 
            // txt_Description
            // 
            txt_Description.Location = new Point(74, 170);
            txt_Description.Name = "txt_Description";
            txt_Description.Size = new Size(290, 23);
            txt_Description.TabIndex = 1;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(370, 111);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Оновити";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(370, 169);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Видалити";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(370, 140);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(75, 23);
            btnCreate.TabIndex = 5;
            btnCreate.Text = "Створити";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 19);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 6;
            label1.Text = "Ім'я";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 116);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 6;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 145);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 6;
            label4.Text = "Телефон";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 87);
            label5.Name = "label5";
            label5.Size = new Size(46, 15);
            label5.TabIndex = 6;
            label5.Text = "Адреса";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(30, 173);
            label6.Name = "label6";
            label6.Size = new Size(36, 15);
            label6.TabIndex = 6;
            label6.Text = "Опис";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(txt_Description);
            groupBox1.Controls.Add(btnUpdate);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(btnCreate);
            groupBox1.Controls.Add(txtSurname);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtAddress);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtPhone);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 313);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(685, 228);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(button4);
            groupBox2.Location = new Point(526, 22);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(103, 100);
            groupBox2.TabIndex = 16;
            groupBox2.TabStop = false;
            groupBox2.Text = "Сортування";
            // 
            // button3
            // 
            button3.Location = new Point(6, 32);
            button3.Name = "button3";
            button3.Size = new Size(91, 23);
            button3.TabIndex = 15;
            button3.Text = "По імені";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(6, 60);
            button4.Name = "button4";
            button4.Size = new Size(91, 23);
            button4.TabIndex = 15;
            button4.Text = "По призвіщу";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(635, 66);
            button2.Name = "button2";
            button2.Size = new Size(38, 36);
            button2.TabIndex = 13;
            button2.Text = "↓";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(635, 21);
            button1.Name = "button1";
            button1.Size = new Size(38, 35);
            button1.TabIndex = 14;
            button1.Text = "↑";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(74, 45);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(290, 23);
            txtSurname.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 48);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 6;
            label2.Text = "Призвіще";
            // 
            // ProviderForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(685, 541);
            Controls.Add(groupBox1);
            Controls.Add(dgvProviders);
            Name = "ProviderForm";
            Text = "ProviderForm";
            Load += ProviderForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProviders).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvProviders;
        private TextBox txtName;
        private TextBox txtAddress;
        private TextBox txtEmail;
        private TextBox txtPhone;
        private TextBox txt_Description;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnCreate;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private GroupBox groupBox1;
        private TextBox txtSurname;
        private Label label2;
        private Button button2;
        private Button button1;
        private GroupBox groupBox2;
        private Button button3;
        private Button button4;
    }
}