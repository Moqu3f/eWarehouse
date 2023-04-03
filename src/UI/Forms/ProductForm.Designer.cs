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
            btn_Clear = new Button();
            groupBox1 = new GroupBox();
            numericUpDown1 = new NumericUpDown();
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
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            txtPrice = new TextBox();
            txtBrand = new TextBox();
            txtCustomer = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
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
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1208, 260);
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
            cmbCategory.Location = new Point(452, 44);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(232, 29);
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
            cmbProvider.Location = new Point(452, 82);
            cmbProvider.Name = "cmbProvider";
            cmbProvider.Size = new Size(232, 29);
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
            btnUpdate.Location = new Point(157, 276);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(138, 34);
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
            btnDelete.Location = new Point(300, 276);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(138, 34);
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
            btnCreate.Location = new Point(13, 276);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(138, 34);
            btnCreate.TabIndex = 5;
            btnCreate.Text = "Створити";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.ForeColor = Color.BlueViolet;
            txtName.Location = new Point(100, 41);
            txtName.Name = "txtName";
            txtName.Size = new Size(242, 29);
            txtName.TabIndex = 6;
            // 
            // txtDescriprtion
            // 
            txtDescriprtion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDescriprtion.ForeColor = Color.BlueViolet;
            txtDescriprtion.Location = new Point(100, 77);
            txtDescriprtion.Name = "txtDescriprtion";
            txtDescriprtion.Size = new Size(242, 29);
            txtDescriprtion.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(7, 44);
            label1.Name = "label1";
            label1.Size = new Size(52, 21);
            label1.TabIndex = 7;
            label1.Text = "Назва";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(5, 79);
            label2.Name = "label2";
            label2.Size = new Size(47, 21);
            label2.TabIndex = 7;
            label2.Text = "Опис";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 339);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(360, 46);
            label4.Name = "label4";
            label4.Size = new Size(78, 21);
            label4.TabIndex = 7;
            label4.Text = "Категорія";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(354, 82);
            label5.Name = "label5";
            label5.Size = new Size(86, 21);
            label5.TabIndex = 7;
            label5.Text = "Поставник";
            // 
            // btn_Clear
            // 
            btn_Clear.Cursor = Cursors.Hand;
            btn_Clear.FlatAppearance.BorderSize = 0;
            btn_Clear.FlatAppearance.MouseDownBackColor = Color.BlueViolet;
            btn_Clear.FlatAppearance.MouseOverBackColor = Color.MediumPurple;
            btn_Clear.FlatStyle = FlatStyle.Flat;
            btn_Clear.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Clear.Location = new Point(452, 276);
            btn_Clear.Name = "btn_Clear";
            btn_Clear.Size = new Size(138, 34);
            btn_Clear.TabIndex = 9;
            btn_Clear.Text = "Очистити";
            btn_Clear.UseVisualStyleBackColor = true;
            btn_Clear.Click += btn_Clear_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(numericUpDown1);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(btn_Clear);
            groupBox1.Controls.Add(cmbCategory);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(cmbProvider);
            groupBox1.Controls.Add(label9);
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
            groupBox1.Location = new Point(0, 260);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1208, 320);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDown1.ForeColor = Color.BlueViolet;
            numericUpDown1.Location = new Point(100, 230);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(242, 29);
            numericUpDown1.TabIndex = 16;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtFindClient);
            groupBox3.Controls.Add(txtFindKeyword);
            groupBox3.Controls.Add(btnClient);
            groupBox3.Controls.Add(btnFindKeyword);
            groupBox3.Location = new Point(916, 22);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(238, 179);
            groupBox3.TabIndex = 15;
            groupBox3.TabStop = false;
            groupBox3.Text = "Пошук";
            // 
            // txtFindClient
            // 
            txtFindClient.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtFindClient.Location = new Point(5, 92);
            txtFindClient.Name = "txtFindClient";
            txtFindClient.Size = new Size(227, 29);
            txtFindClient.TabIndex = 13;
            // 
            // txtFindKeyword
            // 
            txtFindKeyword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtFindKeyword.Location = new Point(6, 16);
            txtFindKeyword.Name = "txtFindKeyword";
            txtFindKeyword.Size = new Size(227, 29);
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
            btnClient.Location = new Point(6, 124);
            btnClient.Name = "btnClient";
            btnClient.Size = new Size(227, 34);
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
            btnFindKeyword.Location = new Point(6, 49);
            btnFindKeyword.Name = "btnFindKeyword";
            btnFindKeyword.Size = new Size(227, 34);
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
            groupBox2.Location = new Point(744, 26);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(154, 176);
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
            bntSortName.Location = new Point(6, 21);
            bntSortName.Name = "bntSortName";
            bntSortName.Size = new Size(138, 34);
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
            bntSortPrice.Location = new Point(6, 105);
            bntSortPrice.Name = "bntSortPrice";
            bntSortPrice.Size = new Size(138, 34);
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
            bntSortBrand.Location = new Point(6, 62);
            bntSortBrand.Name = "bntSortBrand";
            bntSortBrand.Size = new Size(138, 34);
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
            button2.Location = new Point(1159, 114);
            button2.Name = "button2";
            button2.Size = new Size(38, 87);
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
            button1.Location = new Point(1159, 22);
            button1.Name = "button1";
            button1.Size = new Size(38, 87);
            button1.TabIndex = 10;
            button1.Text = "↑";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(5, 238);
            label9.Name = "label9";
            label9.Size = new Size(43, 21);
            label9.TabIndex = 7;
            label9.Text = "Ціна";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(6, 194);
            label8.Name = "label8";
            label8.Size = new Size(43, 21);
            label8.TabIndex = 7;
            label8.Text = "Ціна";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(6, 154);
            label7.Name = "label7";
            label7.Size = new Size(54, 21);
            label7.TabIndex = 7;
            label7.Text = "Бренд";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(5, 114);
            label6.Name = "label6";
            label6.Size = new Size(81, 21);
            label6.TabIndex = 7;
            label6.Text = "Замовник";
            // 
            // txtPrice
            // 
            txtPrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPrice.ForeColor = Color.BlueViolet;
            txtPrice.Location = new Point(100, 194);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(242, 29);
            txtPrice.TabIndex = 6;
            // 
            // txtBrand
            // 
            txtBrand.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtBrand.ForeColor = Color.BlueViolet;
            txtBrand.Location = new Point(100, 154);
            txtBrand.Name = "txtBrand";
            txtBrand.Size = new Size(242, 29);
            txtBrand.TabIndex = 6;
            // 
            // txtCustomer
            // 
            txtCustomer.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCustomer.ForeColor = Color.BlueViolet;
            txtCustomer.Location = new Point(100, 114);
            txtCustomer.Name = "txtCustomer";
            txtCustomer.Size = new Size(242, 29);
            txtCustomer.TabIndex = 6;
            // 
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1208, 580);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Name = "ProductForm";
            Text = "Форма керування товарами";
            Load += ProductForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
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
        private NumericUpDown numericUpDown1;
        private Label label9;
    }
}