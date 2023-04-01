namespace UI
{
    partial class CategoryForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            dgvCategories = new DataGridView();
            txtName = new TextBox();
            txtDescription = new TextBox();
            btnCreate = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            groupBox1 = new GroupBox();
            button2 = new Button();
            button1 = new Button();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCategories).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvCategories
            // 
            dgvCategories.AllowUserToAddRows = false;
            dgvCategories.AllowUserToDeleteRows = false;
            dgvCategories.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvCategories.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvCategories.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.BlueViolet;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvCategories.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = Color.MediumPurple;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvCategories.DefaultCellStyle = dataGridViewCellStyle2;
            dgvCategories.Dock = DockStyle.Top;
            dgvCategories.GridColor = Color.MediumPurple;
            dgvCategories.Location = new Point(0, 0);
            dgvCategories.Margin = new Padding(3, 4, 3, 4);
            dgvCategories.Name = "dgvCategories";
            dgvCategories.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.BlueViolet;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvCategories.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvCategories.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dgvCategories.RowTemplate.Height = 35;
            dgvCategories.Size = new Size(738, 682);
            dgvCategories.TabIndex = 0;
            dgvCategories.CellClick += dgvCategories_CellClick;
            dgvCategories.SelectionChanged += dgvCategories_SelectionChanged;
            // 
            // txtName
            // 
            txtName.BorderStyle = BorderStyle.None;
            txtName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.ForeColor = Color.BlueViolet;
            txtName.Location = new Point(74, 51);
            txtName.Margin = new Padding(3, 4, 3, 4);
            txtName.MaxLength = 255;
            txtName.Name = "txtName";
            txtName.Size = new Size(248, 27);
            txtName.TabIndex = 1;
            // 
            // txtDescription
            // 
            txtDescription.BorderStyle = BorderStyle.None;
            txtDescription.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDescription.ForeColor = Color.BlueViolet;
            txtDescription.Location = new Point(74, 97);
            txtDescription.Margin = new Padding(3, 4, 3, 4);
            txtDescription.MaxLength = 1024;
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(248, 72);
            txtDescription.TabIndex = 1;
            // 
            // btnCreate
            // 
            btnCreate.FlatAppearance.BorderSize = 0;
            btnCreate.FlatAppearance.MouseDownBackColor = Color.BlueViolet;
            btnCreate.FlatAppearance.MouseOverBackColor = Color.MediumPurple;
            btnCreate.FlatStyle = FlatStyle.Flat;
            btnCreate.Location = new Point(373, 92);
            btnCreate.Margin = new Padding(3, 4, 3, 4);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(158, 46);
            btnCreate.TabIndex = 2;
            btnCreate.Text = "Створити";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnDelete
            // 
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatAppearance.MouseDownBackColor = Color.BlueViolet;
            btnDelete.FlatAppearance.MouseOverBackColor = Color.MediumPurple;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Location = new Point(373, 146);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(158, 46);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Видалити";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatAppearance.MouseDownBackColor = Color.BlueViolet;
            btnUpdate.FlatAppearance.MouseOverBackColor = Color.MediumPurple;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Location = new Point(373, 38);
            btnUpdate.Margin = new Padding(3, 4, 3, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(158, 46);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Оновити";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtDescription);
            groupBox1.Controls.Add(btnUpdate);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(btnCreate);
            groupBox1.Dock = DockStyle.Bottom;
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Location = new Point(0, 466);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(738, 216);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.BlueViolet;
            button2.FlatAppearance.MouseOverBackColor = Color.MediumPurple;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(590, 104);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(43, 48);
            button2.TabIndex = 11;
            button2.Text = "↓";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.BlueViolet;
            button1.FlatAppearance.MouseOverBackColor = Color.MediumPurple;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(590, 44);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(43, 47);
            button1.TabIndex = 12;
            button1.Text = "↑";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 104);
            label2.Name = "label2";
            label2.Size = new Size(45, 20);
            label2.TabIndex = 3;
            label2.Text = "Опис";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 51);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 3;
            label1.Text = "Назва";
            // 
            // CategoryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(738, 682);
            Controls.Add(groupBox1);
            Controls.Add(dgvCategories);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CategoryForm";
            Text = "Категорії";
            Load += CategoryForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCategories).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvCategories;
        private TextBox txtName;
        private TextBox txtDescription;
        private Button btnCreate;
        private Button btnDelete;
        private Button btnUpdate;
        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private Button button2;
        private Button button1;
    }
}