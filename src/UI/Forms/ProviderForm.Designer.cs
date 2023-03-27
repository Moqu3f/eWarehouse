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
            ((System.ComponentModel.ISupportInitialize)dgvProviders).BeginInit();
            SuspendLayout();
            // 
            // dgvProviders
            // 
            dgvProviders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProviders.Location = new Point(12, 12);
            dgvProviders.Name = "dgvProviders";
            dgvProviders.RowTemplate.Height = 25;
            dgvProviders.Size = new Size(703, 233);
            dgvProviders.TabIndex = 0;
            dgvProviders.CellContentClick += dgvProviders_CellContentClick;
            // 
            // txtName
            // 
            txtName.Location = new Point(12, 259);
            txtName.Name = "txtName";
            txtName.Size = new Size(290, 23);
            txtName.TabIndex = 1;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(12, 288);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(290, 23);
            txtAddress.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(12, 317);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(290, 23);
            txtEmail.TabIndex = 1;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(12, 346);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(290, 23);
            txtPhone.TabIndex = 1;
            // 
            // txt_Description
            // 
            txt_Description.Location = new Point(12, 375);
            txt_Description.Name = "txt_Description";
            txt_Description.Size = new Size(290, 23);
            txt_Description.TabIndex = 1;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(389, 287);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "btnUpdate";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(389, 345);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "btnDelete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(389, 316);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(75, 23);
            btnCreate.TabIndex = 5;
            btnCreate.Text = "btnCreate";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // ProviderForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnCreate);
            Controls.Add(txt_Description);
            Controls.Add(txtPhone);
            Controls.Add(txtEmail);
            Controls.Add(txtAddress);
            Controls.Add(txtName);
            Controls.Add(dgvProviders);
            Name = "ProviderForm";
            Text = "ProviderForm";
            Load += ProviderForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProviders).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
    }
}