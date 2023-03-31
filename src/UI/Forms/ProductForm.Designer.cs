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
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Top;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(930, 260);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellFormatting += dataGridView1_CellFormatting;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // cmbCategory
            // 
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(385, 49);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(175, 23);
            cmbCategory.TabIndex = 1;
            cmbCategory.SelectedIndexChanged += cmbCategory_SelectedIndexChanged;
            // 
            // cmbProvider
            // 
            cmbProvider.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProvider.FormattingEnabled = true;
            cmbProvider.Location = new Point(385, 78);
            cmbProvider.Name = "cmbProvider";
            cmbProvider.Size = new Size(175, 23);
            cmbProvider.TabIndex = 1;
            cmbProvider.SelectedIndexChanged += cmbProvider_SelectedIndexChanged;
            // 
            // btnUpdate
            // 
            btnUpdate.AllowDrop = true;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Location = new Point(472, 115);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Оновити";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Location = new Point(472, 173);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Видалити";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnCreate
            // 
            btnCreate.FlatStyle = FlatStyle.Flat;
            btnCreate.Location = new Point(472, 144);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(75, 23);
            btnCreate.TabIndex = 5;
            btnCreate.Text = "Створити";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(69, 46);
            txtName.Name = "txtName";
            txtName.Size = new Size(231, 23);
            txtName.TabIndex = 6;
            // 
            // txtDescriprtion
            // 
            txtDescriprtion.Location = new Point(69, 75);
            txtDescriprtion.Name = "txtDescriprtion";
            txtDescriprtion.Size = new Size(231, 23);
            txtDescriprtion.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 49);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 7;
            label1.Text = "Назва";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 79);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
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
            label4.Location = new Point(320, 52);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 7;
            label4.Text = "Категорія";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(313, 81);
            label5.Name = "label5";
            label5.Size = new Size(66, 15);
            label5.TabIndex = 7;
            label5.Text = "Поставник";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(69, 191);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(92, 19);
            checkBox1.TabIndex = 8;
            checkBox1.Text = "Доступність";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // btn_Clear
            // 
            btn_Clear.Location = new Point(385, 173);
            btn_Clear.Name = "btn_Clear";
            btn_Clear.Size = new Size(75, 23);
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
            groupBox1.Location = new Point(0, 260);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(930, 228);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtFindClient);
            groupBox3.Controls.Add(txtFindKeyword);
            groupBox3.Controls.Add(btnClient);
            groupBox3.Controls.Add(btnFindKeyword);
            groupBox3.Location = new Point(714, 22);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(141, 194);
            groupBox3.TabIndex = 15;
            groupBox3.TabStop = false;
            groupBox3.Text = "Пошук";
            // 
            // txtFindClient
            // 
            txtFindClient.Location = new Point(6, 102);
            txtFindClient.Name = "txtFindClient";
            txtFindClient.Size = new Size(122, 23);
            txtFindClient.TabIndex = 13;
            // 
            // txtFindKeyword
            // 
            txtFindKeyword.Location = new Point(6, 15);
            txtFindKeyword.Name = "txtFindKeyword";
            txtFindKeyword.Size = new Size(122, 23);
            txtFindKeyword.TabIndex = 11;
            // 
            // btnClient
            // 
            btnClient.Location = new Point(6, 131);
            btnClient.Name = "btnClient";
            btnClient.Size = new Size(122, 49);
            btnClient.TabIndex = 12;
            btnClient.Text = "По клієнту";
            btnClient.UseVisualStyleBackColor = true;
            btnClient.Click += btnClient_Click;
            // 
            // btnFindKeyword
            // 
            btnFindKeyword.Location = new Point(6, 47);
            btnFindKeyword.Name = "btnFindKeyword";
            btnFindKeyword.Size = new Size(122, 49);
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
            groupBox2.Location = new Point(566, 17);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(142, 110);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            groupBox2.Text = "Сортування";
            // 
            // bntSortName
            // 
            bntSortName.Location = new Point(6, 22);
            bntSortName.Name = "bntSortName";
            bntSortName.Size = new Size(122, 23);
            bntSortName.TabIndex = 13;
            bntSortName.Tag = "";
            bntSortName.Text = "По імені";
            bntSortName.UseVisualStyleBackColor = true;
            bntSortName.Click += bntSortName_Click;
            // 
            // bntSortPrice
            // 
            bntSortPrice.Location = new Point(6, 80);
            bntSortPrice.Name = "bntSortPrice";
            bntSortPrice.Size = new Size(122, 23);
            bntSortPrice.TabIndex = 13;
            bntSortPrice.Text = "По ціні";
            bntSortPrice.UseVisualStyleBackColor = true;
            bntSortPrice.Click += bntSortPrice_Click;
            // 
            // bntSortBrand
            // 
            bntSortBrand.Location = new Point(6, 51);
            bntSortBrand.Name = "bntSortBrand";
            bntSortBrand.Size = new Size(122, 23);
            bntSortBrand.TabIndex = 13;
            bntSortBrand.Text = "По бренду";
            bntSortBrand.UseVisualStyleBackColor = true;
            bntSortBrand.Click += bntSortBrand_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(886, 58);
            button2.Name = "button2";
            button2.Size = new Size(38, 36);
            button2.TabIndex = 10;
            button2.Text = "↓";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(886, 13);
            button1.Name = "button1";
            button1.Size = new Size(38, 35);
            button1.TabIndex = 10;
            button1.Text = "↑";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 165);
            label8.Name = "label8";
            label8.Size = new Size(32, 15);
            label8.TabIndex = 7;
            label8.Text = "Ціна";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 136);
            label7.Name = "label7";
            label7.Size = new Size(40, 15);
            label7.TabIndex = 7;
            label7.Text = "Бренд";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 107);
            label6.Name = "label6";
            label6.Size = new Size(61, 15);
            label6.TabIndex = 7;
            label6.Text = "Покупець";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(69, 162);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(231, 23);
            txtPrice.TabIndex = 6;
            // 
            // txtBrand
            // 
            txtBrand.Location = new Point(69, 133);
            txtBrand.Name = "txtBrand";
            txtBrand.Size = new Size(231, 23);
            txtBrand.TabIndex = 6;
            // 
            // txtCustomer
            // 
            txtCustomer.Location = new Point(69, 104);
            txtCustomer.Name = "txtCustomer";
            txtCustomer.Size = new Size(231, 23);
            txtCustomer.TabIndex = 6;
            // 
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(930, 488);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Name = "ProductForm";
            Text = "ProductForm";
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