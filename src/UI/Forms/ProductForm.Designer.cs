namespace UI.Forms
{
    partial class ProductForm
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
            dataGridView1 = new DataGridView();
            cmbCategory = new ComboBox();
            cmbProvider = new ComboBox();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnCreate = new Button();
            txtName = new TextBox();
            txtDescriprtion = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            checkBox1 = new CheckBox();
            btn_Clear = new Button();
            groupBox1 = new GroupBox();
            groupBox3 = new GroupBox();
            txtFindClient = new TextBox();
            txtFindKeyword = new TextBox();
            btnClient = new Button();
            btnFindKeyword = new Button();
            groupBox2 = new GroupBox();
            bntSortName = new Button();
            bntSortPrice = new Button();
            bntSortBrand = new Button();
            button2 = new Button();
            button1 = new Button();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            txtPrice = new TextBox();
            txtBrand = new TextBox();
            txtCustomer = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Dock = DockStyle.Top;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1380, 347);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellFormatting += dataGridView1_CellFormatting;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // cmbCategory
            // 
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.FlatStyle = FlatStyle.Flat;
            cmbCategory.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbCategory.ForeColor = Color.BlueViolet;
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(517, 59);
            cmbCategory.Margin = new Padding(3, 4, 3, 4);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(265, 36);
            cmbCategory.TabIndex = 1;
            cmbCategory.SelectedIndexChanged += cmbCategory_SelectedIndexChanged;
            // 
            // cmbProvider
            // 
            cmbProvider.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProvider.FlatStyle = FlatStyle.Flat;
            cmbProvider.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbProvider.ForeColor = Color.BlueViolet;
            cmbProvider.FormattingEnabled = true;
            cmbProvider.Location = new Point(517, 109);
            cmbProvider.Margin = new Padding(3, 4, 3, 4);
            cmbProvider.Name = "cmbProvider";
            cmbProvider.Size = new Size(265, 36);
            cmbProvider.TabIndex = 1;
            cmbProvider.SelectedIndexChanged += cmbProvider_SelectedIndexChanged;
            // 
            // btnUpdate
            // 
            btnUpdate.AllowDrop = true;
            btnUpdate.Cursor = Cursors.Hand;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatAppearance.MouseDownBackColor = Color.BlueViolet;
            btnUpdate.FlatAppearance.MouseOverBackColor = Color.MediumPurple;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdate.Location = new Point(179, 368);
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
            btnDelete.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.Location = new Point(343, 368);
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
            btnCreate.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCreate.Location = new Point(15, 368);
            btnCreate.Margin = new Padding(3, 4, 3, 4);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(158, 46);
            btnCreate.TabIndex = 5;
            btnCreate.Text = "Створити";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.ForeColor = Color.BlueViolet;
            txtName.Location = new Point(114, 55);
            txtName.Margin = new Padding(3, 4, 3, 4);
            txtName.Name = "txtName";
            txtName.Size = new Size(276, 34);
            txtName.TabIndex = 6;
            // 
            // txtDescriprtion
            // 
            txtDescriprtion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDescriprtion.ForeColor = Color.BlueViolet;
            txtDescriprtion.Location = new Point(114, 103);
            txtDescriprtion.Margin = new Padding(3, 4, 3, 4);
            txtDescriprtion.Name = "txtDescriprtion";
            txtDescriprtion.Size = new Size(276, 34);
            txtDescriprtion.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(8, 59);
            label1.Name = "label1";
            label1.Size = new Size(66, 28);
            label1.TabIndex = 7;
            label1.Text = "Назва";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(6, 105);
            label2.Name = "label2";
            label2.Size = new Size(60, 28);
            label2.TabIndex = 7;
            label2.Text = "Опис";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 452);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(412, 61);
            label4.Name = "label4";
            label4.Size = new Size(99, 28);
            label4.TabIndex = 7;
            label4.Text = "Категорія";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(405, 109);
            label5.Name = "label5";
            label5.Size = new Size(110, 28);
            label5.TabIndex = 7;
            label5.Text = "Поставник";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox1.Location = new Point(15, 309);
            checkBox1.Margin = new Padding(3, 4, 3, 4);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(143, 32);
            checkBox1.TabIndex = 8;
            checkBox1.Text = "Доступність";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // btn_Clear
            // 
            btn_Clear.Cursor = Cursors.Hand;
            btn_Clear.FlatAppearance.BorderSize = 0;
            btn_Clear.FlatAppearance.MouseDownBackColor = Color.BlueViolet;
            btn_Clear.FlatAppearance.MouseOverBackColor = Color.MediumPurple;
            btn_Clear.FlatStyle = FlatStyle.Flat;
            btn_Clear.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Clear.Location = new Point(517, 368);
            btn_Clear.Margin = new Padding(3, 4, 3, 4);
            btn_Clear.Name = "btn_Clear";
            btn_Clear.Size = new Size(158, 46);
            btn_Clear.TabIndex = 9;
            btn_Clear.Text = "Очистити";
            btn_Clear.UseVisualStyleBackColor = true;
            btn_Clear.Click += btn_Clear_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Controls.Add(btn_Clear);
            groupBox1.Controls.Add(cmbCategory);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(cmbProvider);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtDescriprtion);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtPrice);
            groupBox1.Controls.Add(txtBrand);
            groupBox1.Controls.Add(txtCustomer);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(btnCreate);
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(btnUpdate);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Location = new Point(0, 347);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(1380, 427);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtFindClient);
            groupBox3.Controls.Add(txtFindKeyword);
            groupBox3.Controls.Add(btnClient);
            groupBox3.Controls.Add(btnFindKeyword);
            groupBox3.Location = new Point(1047, 29);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(272, 239);
            groupBox3.TabIndex = 15;
            groupBox3.TabStop = false;
            groupBox3.Text = "Пошук";
            // 
            // txtFindClient
            // 
            txtFindClient.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtFindClient.Location = new Point(6, 123);
            txtFindClient.Margin = new Padding(3, 4, 3, 4);
            txtFindClient.Name = "txtFindClient";
            txtFindClient.Size = new Size(259, 34);
            txtFindClient.TabIndex = 13;
            // 
            // txtFindKeyword
            // 
            txtFindKeyword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtFindKeyword.Location = new Point(7, 22);
            txtFindKeyword.Margin = new Padding(3, 4, 3, 4);
            txtFindKeyword.Name = "txtFindKeyword";
            txtFindKeyword.Size = new Size(259, 34);
            txtFindKeyword.TabIndex = 11;
            // 
            // btnClient
            // 
            btnClient.Cursor = Cursors.Hand;
            btnClient.FlatAppearance.BorderSize = 0;
            btnClient.FlatAppearance.MouseDownBackColor = Color.BlueViolet;
            btnClient.FlatAppearance.MouseOverBackColor = Color.MediumPurple;
            btnClient.FlatStyle = FlatStyle.Flat;
            btnClient.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnClient.Location = new Point(7, 165);
            btnClient.Margin = new Padding(3, 4, 3, 4);
            btnClient.Name = "btnClient";
            btnClient.Size = new Size(259, 46);
            btnClient.TabIndex = 12;
            btnClient.Text = "По клієнту";
            btnClient.UseVisualStyleBackColor = true;
            btnClient.Click += btnClient_Click;
            // 
            // btnFindKeyword
            // 
            btnFindKeyword.Cursor = Cursors.Hand;
            btnFindKeyword.FlatAppearance.BorderSize = 0;
            btnFindKeyword.FlatAppearance.MouseDownBackColor = Color.BlueViolet;
            btnFindKeyword.FlatAppearance.MouseOverBackColor = Color.MediumPurple;
            btnFindKeyword.FlatStyle = FlatStyle.Flat;
            btnFindKeyword.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnFindKeyword.Location = new Point(7, 65);
            btnFindKeyword.Margin = new Padding(3, 4, 3, 4);
            btnFindKeyword.Name = "btnFindKeyword";
            btnFindKeyword.Size = new Size(259, 46);
            btnFindKeyword.TabIndex = 12;
            btnFindKeyword.Text = "По ключовому слову";
            btnFindKeyword.UseVisualStyleBackColor = true;
            btnFindKeyword.Click += btnFindKeyword_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(bntSortName);
            groupBox2.Controls.Add(bntSortPrice);
            groupBox2.Controls.Add(bntSortBrand);
            groupBox2.Location = new Point(850, 34);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(176, 234);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            groupBox2.Text = "Сортування";
            // 
            // bntSortName
            // 
            bntSortName.Cursor = Cursors.Hand;
            bntSortName.FlatAppearance.BorderSize = 0;
            bntSortName.FlatAppearance.MouseDownBackColor = Color.BlueViolet;
            bntSortName.FlatAppearance.MouseOverBackColor = Color.MediumPurple;
            bntSortName.FlatStyle = FlatStyle.Flat;
            bntSortName.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            bntSortName.Location = new Point(7, 28);
            bntSortName.Margin = new Padding(3, 4, 3, 4);
            bntSortName.Name = "bntSortName";
            bntSortName.Size = new Size(158, 46);
            bntSortName.TabIndex = 13;
            bntSortName.Tag = "";
            bntSortName.Text = "По імені";
            bntSortName.UseVisualStyleBackColor = true;
            bntSortName.Click += bntSortName_Click;
            // 
            // bntSortPrice
            // 
            bntSortPrice.Cursor = Cursors.Hand;
            bntSortPrice.FlatAppearance.BorderSize = 0;
            bntSortPrice.FlatAppearance.MouseDownBackColor = Color.BlueViolet;
            bntSortPrice.FlatAppearance.MouseOverBackColor = Color.MediumPurple;
            bntSortPrice.FlatStyle = FlatStyle.Flat;
            bntSortPrice.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            bntSortPrice.Location = new Point(7, 140);
            bntSortPrice.Margin = new Padding(3, 4, 3, 4);
            bntSortPrice.Name = "bntSortPrice";
            bntSortPrice.Size = new Size(158, 46);
            bntSortPrice.TabIndex = 13;
            bntSortPrice.Text = "По ціні";
            bntSortPrice.UseVisualStyleBackColor = true;
            bntSortPrice.Click += bntSortPrice_Click;
            // 
            // bntSortBrand
            // 
            bntSortBrand.Cursor = Cursors.Hand;
            bntSortBrand.FlatAppearance.BorderSize = 0;
            bntSortBrand.FlatAppearance.MouseDownBackColor = Color.BlueViolet;
            bntSortBrand.FlatAppearance.MouseOverBackColor = Color.MediumPurple;
            bntSortBrand.FlatStyle = FlatStyle.Flat;
            bntSortBrand.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            bntSortBrand.Location = new Point(7, 83);
            bntSortBrand.Margin = new Padding(3, 4, 3, 4);
            bntSortBrand.Name = "bntSortBrand";
            bntSortBrand.Size = new Size(158, 46);
            bntSortBrand.TabIndex = 13;
            bntSortBrand.Text = "По бренду";
            bntSortBrand.UseVisualStyleBackColor = true;
            bntSortBrand.Click += bntSortBrand_Click;
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.BlueViolet;
            button2.FlatAppearance.MouseOverBackColor = Color.MediumPurple;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(1325, 152);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(43, 116);
            button2.TabIndex = 10;
            button2.Text = "↓";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.BlueViolet;
            button1.FlatAppearance.MouseOverBackColor = Color.MediumPurple;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(1325, 29);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(43, 116);
            button1.TabIndex = 10;
            button1.Text = "↑";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(7, 259);
            label8.Name = "label8";
            label8.Size = new Size(54, 28);
            label8.TabIndex = 7;
            label8.Text = "Ціна";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(7, 205);
            label7.Name = "label7";
            label7.Size = new Size(68, 28);
            label7.TabIndex = 7;
            label7.Text = "Бренд";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(6, 152);
            label6.Name = "label6";
            label6.Size = new Size(104, 28);
            label6.TabIndex = 7;
            label6.Text = "Замовник";
            // 
            // txtPrice
            // 
            txtPrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPrice.ForeColor = Color.BlueViolet;
            txtPrice.Location = new Point(114, 259);
            txtPrice.Margin = new Padding(3, 4, 3, 4);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(276, 34);
            txtPrice.TabIndex = 6;
            // 
            // txtBrand
            // 
            txtBrand.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtBrand.ForeColor = Color.BlueViolet;
            txtBrand.Location = new Point(114, 205);
            txtBrand.Margin = new Padding(3, 4, 3, 4);
            txtBrand.Name = "txtBrand";
            txtBrand.Size = new Size(276, 34);
            txtBrand.TabIndex = 6;
            // 
            // txtCustomer
            // 
            txtCustomer.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCustomer.ForeColor = Color.BlueViolet;
            txtCustomer.Location = new Point(114, 152);
            txtCustomer.Margin = new Padding(3, 4, 3, 4);
            txtCustomer.Name = "txtCustomer";
            txtCustomer.Size = new Size(276, 34);
            txtCustomer.TabIndex = 6;
            // 
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1380, 774);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ProductForm";
            Text = "Форма керування товарами";
            Load += ProductForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private ComboBox cmbCategory;
        private ComboBox cmbProvider;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnCreate;
        private TextBox txtName;
        private TextBox txtDescriprtion;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private CheckBox checkBox1;
        private Button btn_Clear;
        private GroupBox groupBox1;
        private Label label6;
        private TextBox txtCustomer;
        private Label label8;
        private Label label7;
        private TextBox txtPrice;
        private TextBox txtBrand;
        private Button button2;
        private Button button1;
        private Button btnFindKeyword;
        private TextBox txtFindKeyword;
        private GroupBox groupBox3;
        private GroupBox groupBox2;
        private Button bntSortName;
        private Button bntSortPrice;
        private Button bntSortBrand;
        private TextBox txtFindClient;
        private Button btnClient;
    }
}