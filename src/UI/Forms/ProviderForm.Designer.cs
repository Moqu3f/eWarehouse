using System.Windows.Forms;

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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
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
            button5 = new Button();
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
            dgvProviders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProviders.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvProviders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvProviders.DefaultCellStyle = dataGridViewCellStyle2;
            dgvProviders.Dock = DockStyle.Top;
            dgvProviders.Location = new Point(0, 0);
            dgvProviders.Margin = new Padding(3, 4, 3, 4);
            dgvProviders.Name = "dgvProviders";
            dgvProviders.ReadOnly = true;
            dgvProviders.RowHeadersWidth = 51;
            dgvProviders.RowTemplate.Height = 25;
            dgvProviders.Size = new Size(1334, 417);
            dgvProviders.TabIndex = 0;
            dgvProviders.CellContentClick += dgvProviders_CellContentClick;
            dgvProviders.SelectionChanged += dgvProviders_SelectionChanged;
            // 
            // txtName
            // 
            txtName.BorderStyle = BorderStyle.None;
            txtName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.ForeColor = Color.BlueViolet;
            txtName.Location = new Point(101, 21);
            txtName.Margin = new Padding(3, 4, 3, 4);
            txtName.Name = "txtName";
            txtName.Size = new Size(293, 27);
            txtName.TabIndex = 1;
            // 
            // txtAddress
            // 
            txtAddress.BorderStyle = BorderStyle.None;
            txtAddress.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtAddress.ForeColor = Color.BlueViolet;
            txtAddress.Location = new Point(101, 105);
            txtAddress.Margin = new Padding(3, 4, 3, 4);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(293, 27);
            txtAddress.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.ForeColor = Color.BlueViolet;
            txtEmail.Location = new Point(97, 146);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(297, 27);
            txtEmail.TabIndex = 1;
            // 
            // txtPhone
            // 
            txtPhone.BorderStyle = BorderStyle.None;
            txtPhone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPhone.ForeColor = Color.BlueViolet;
            txtPhone.Location = new Point(97, 188);
            txtPhone.Margin = new Padding(3, 4, 3, 4);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(297, 27);
            txtPhone.TabIndex = 1;
            // 
            // txt_Description
            // 
            txt_Description.BorderStyle = BorderStyle.None;
            txt_Description.ForeColor = Color.BlueViolet;
            txt_Description.Location = new Point(97, 230);
            txt_Description.Margin = new Padding(3, 4, 3, 4);
            txt_Description.Multiline = true;
            txt_Description.Name = "txt_Description";
            txt_Description.Size = new Size(297, 80);
            txt_Description.TabIndex = 1;
            // 
            // btnUpdate
            // 
            btnUpdate.Cursor = Cursors.Hand;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatAppearance.MouseDownBackColor = Color.BlueViolet;
            btnUpdate.FlatAppearance.MouseOverBackColor = Color.MediumPurple;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdate.Location = new Point(576, 261);
            btnUpdate.Margin = new Padding(3, 4, 3, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(158, 46);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Оновити";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatAppearance.MouseDownBackColor = Color.BlueViolet;
            btnDelete.FlatAppearance.MouseOverBackColor = Color.MediumPurple;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.Location = new Point(740, 261);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(158, 46);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Видалити";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnCreate
            // 
            btnCreate.Cursor = Cursors.Hand;
            btnCreate.FlatAppearance.BorderSize = 0;
            btnCreate.FlatAppearance.MouseDownBackColor = Color.BlueViolet;
            btnCreate.FlatAppearance.MouseOverBackColor = Color.MediumPurple;
            btnCreate.FlatStyle = FlatStyle.Flat;
            btnCreate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCreate.Location = new Point(412, 261);
            btnCreate.Margin = new Padding(3, 4, 3, 4);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(158, 46);
            btnCreate.TabIndex = 5;
            btnCreate.Text = "Створити";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ImageAlign = ContentAlignment.MiddleRight;
            label1.Location = new Point(42, 24);
            label1.Name = "label1";
            label1.Size = new Size(46, 28);
            label1.TabIndex = 6;
            label1.Text = "Ім'я";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ImageAlign = ContentAlignment.MiddleRight;
            label3.Location = new Point(31, 147);
            label3.Name = "label3";
            label3.Size = new Size(59, 28);
            label3.TabIndex = 6;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ImageAlign = ContentAlignment.MiddleRight;
            label4.Location = new Point(8, 188);
            label4.Name = "label4";
            label4.Size = new Size(91, 28);
            label4.TabIndex = 6;
            label4.Text = "Телефон";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ImageAlign = ContentAlignment.MiddleRight;
            label5.Location = new Point(18, 105);
            label5.Name = "label5";
            label5.Size = new Size(77, 28);
            label5.TabIndex = 6;
            label5.Text = "Адреса";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ImageAlign = ContentAlignment.MiddleRight;
            label6.Location = new Point(31, 230);
            label6.Name = "label6";
            label6.Size = new Size(60, 28);
            label6.TabIndex = 6;
            label6.Text = "Опис";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button5);
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
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Location = new Point(0, 417);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(1334, 320);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            // 
            // button5
            // 
            button5.Cursor = Cursors.Hand;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatAppearance.MouseDownBackColor = Color.BlueViolet;
            button5.FlatAppearance.MouseOverBackColor = Color.MediumPurple;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Location = new Point(904, 261);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Size = new Size(158, 46);
            button5.TabIndex = 17;
            button5.Text = "Очистити";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(button4);
            groupBox2.Dock = DockStyle.Right;
            groupBox2.FlatStyle = FlatStyle.Flat;
            groupBox2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(1072, 24);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(173, 292);
            groupBox2.TabIndex = 16;
            groupBox2.TabStop = false;
            groupBox2.Text = "Сортування";
            // 
            // button3
            // 
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseDownBackColor = Color.BlueViolet;
            button3.FlatAppearance.MouseOverBackColor = Color.MediumPurple;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(9, 40);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(158, 46);
            button3.TabIndex = 15;
            button3.Text = "По імені";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Cursor = Cursors.Hand;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.MouseDownBackColor = Color.BlueViolet;
            button4.FlatAppearance.MouseOverBackColor = Color.MediumPurple;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(9, 97);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(158, 46);
            button4.TabIndex = 15;
            button4.Text = "По прізвищу";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.Dock = DockStyle.Right;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.BlueViolet;
            button2.FlatAppearance.MouseOverBackColor = Color.MediumPurple;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(1245, 24);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(43, 292);
            button2.TabIndex = 13;
            button2.Text = "↓";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Dock = DockStyle.Right;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.BlueViolet;
            button1.FlatAppearance.MouseOverBackColor = Color.MediumPurple;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(1288, 24);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(43, 292);
            button1.TabIndex = 14;
            button1.Text = "↑";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtSurname
            // 
            txtSurname.BorderStyle = BorderStyle.None;
            txtSurname.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSurname.ForeColor = Color.BlueViolet;
            txtSurname.Location = new Point(101, 63);
            txtSurname.Margin = new Padding(3, 4, 3, 4);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(293, 27);
            txtSurname.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ImageAlign = ContentAlignment.MiddleRight;
            label2.Location = new Point(2, 63);
            label2.Name = "label2";
            label2.Size = new Size(101, 28);
            label2.TabIndex = 6;
            label2.Text = "Прізвище";
            // 
            // ProviderForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1334, 737);
            Controls.Add(groupBox1);
            Controls.Add(dgvProviders);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ProviderForm";
            Text = "Форма керування постачальників";
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
        private Button button5;
    }
}