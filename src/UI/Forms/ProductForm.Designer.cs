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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Top;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(787, 260);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellFormatting += dataGridView1_CellFormatting;
            // 
            // cmbCategory
            // 
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(527, 46);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(175, 23);
            cmbCategory.TabIndex = 1;
            cmbCategory.SelectedIndexChanged += cmbCategory_SelectedIndexChanged;
            // 
            // cmbProvider
            // 
            cmbProvider.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProvider.FormattingEnabled = true;
            cmbProvider.Location = new Point(527, 75);
            cmbProvider.Name = "cmbProvider";
            cmbProvider.Size = new Size(175, 23);
            cmbProvider.TabIndex = 1;
            cmbProvider.SelectedIndexChanged += cmbProvider_SelectedIndexChanged;
            // 
            // btnUpdate
            // 
            btnUpdate.AllowDrop = true;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Location = new Point(614, 112);
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
            btnDelete.Location = new Point(614, 170);
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
            btnCreate.Location = new Point(614, 141);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(75, 23);
            btnCreate.TabIndex = 5;
            btnCreate.Text = "Створити";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(51, 46);
            txtName.Name = "txtName";
            txtName.Size = new Size(231, 23);
            txtName.TabIndex = 6;
            // 
            // txtDescriprtion
            // 
            txtDescriprtion.Location = new Point(51, 75);
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
            label2.Location = new Point(7, 75);
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
            label4.Location = new Point(462, 49);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 7;
            label4.Text = "Категорія";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(455, 78);
            label5.Name = "label5";
            label5.Size = new Size(66, 15);
            label5.TabIndex = 7;
            label5.Text = "Поставник";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(51, 104);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(92, 19);
            checkBox1.TabIndex = 8;
            checkBox1.Text = "Доступність";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // btn_Clear
            // 
            btn_Clear.Location = new Point(527, 170);
            btn_Clear.Name = "btn_Clear";
            btn_Clear.Size = new Size(75, 23);
            btn_Clear.TabIndex = 9;
            btn_Clear.Text = "Очистити";
            btn_Clear.UseVisualStyleBackColor = true;
            btn_Clear.Click += btn_Clear_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Controls.Add(btn_Clear);
            groupBox1.Controls.Add(cmbCategory);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(cmbProvider);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtDescriprtion);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(btnCreate);
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(btnUpdate);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 260);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(787, 228);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            // 
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(787, 488);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Name = "ProductForm";
            Text = "ProductForm";
            Load += ProductForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
    }
}