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
            ((System.ComponentModel.ISupportInitialize)dgvProviders).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvProviders
            // 
            dgvProviders.AllowUserToAddRows = false;
            dgvProviders.AllowUserToDeleteRows = false;
            dgvProviders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProviders.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvProviders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProviders.Dock = DockStyle.Top;
            dgvProviders.Location = new Point(0, 0);
            dgvProviders.Name = "dgvProviders";
            dgvProviders.ReadOnly = true;
            dgvProviders.RowTemplate.Height = 25;
            dgvProviders.Size = new Size(666, 313);
            dgvProviders.TabIndex = 0;
            dgvProviders.CellContentClick += dgvProviders_CellContentClick;
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
            txtAddress.Location = new Point(74, 45);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(290, 23);
            txtAddress.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(74, 74);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(290, 23);
            txtEmail.TabIndex = 1;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(74, 103);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(290, 23);
            txtPhone.TabIndex = 1;
            // 
            // txt_Description
            // 
            txt_Description.Location = new Point(74, 132);
            txt_Description.Name = "txt_Description";
            txt_Description.Size = new Size(290, 23);
            txt_Description.TabIndex = 1;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(419, 45);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Оновити";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(419, 103);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Видалити";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(419, 74);
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
            label1.Size = new Size(39, 15);
            label1.TabIndex = 6;
            label1.Text = "Назва";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 78);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 6;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 107);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 6;
            label4.Text = "Телефон";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 49);
            label5.Name = "label5";
            label5.Size = new Size(46, 15);
            label5.TabIndex = 6;
            label5.Text = "Адреса";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(30, 135);
            label6.Name = "label6";
            label6.Size = new Size(36, 15);
            label6.TabIndex = 6;
            label6.Text = "Опис";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txt_Description);
            groupBox1.Controls.Add(btnUpdate);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(btnCreate);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtAddress);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtPhone);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 313);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(666, 183);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            // 
            // ProviderForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(666, 496);
            Controls.Add(groupBox1);
            Controls.Add(dgvProviders);
            Name = "ProviderForm";
            Text = "ProviderForm";
            Load += ProviderForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProviders).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
    }
}