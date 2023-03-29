namespace UI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnOpenCategories = new System.Windows.Forms.Button();
            this.btnOpenProviders = new System.Windows.Forms.Button();
            this.btnOpenProducts = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOpenCategories
            // 
            this.btnOpenCategories.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnOpenCategories.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.btnOpenCategories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenCategories.Location = new System.Drawing.Point(244, 86);
            this.btnOpenCategories.Name = "btnOpenCategories";
            this.btnOpenCategories.Size = new System.Drawing.Size(321, 48);
            this.btnOpenCategories.TabIndex = 0;
            this.btnOpenCategories.Text = "Категорії";
            this.btnOpenCategories.UseVisualStyleBackColor = true;
            this.btnOpenCategories.Click += new System.EventHandler(this.btnOpenCategories_Click_1);
            // 
            // btnOpenProviders
            // 
            this.btnOpenProviders.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnOpenProviders.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.btnOpenProviders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenProviders.Location = new System.Drawing.Point(244, 157);
            this.btnOpenProviders.Name = "btnOpenProviders";
            this.btnOpenProviders.Size = new System.Drawing.Size(321, 55);
            this.btnOpenProviders.TabIndex = 1;
            this.btnOpenProviders.Text = "Постачальники";
            this.btnOpenProviders.UseVisualStyleBackColor = true;
            this.btnOpenProviders.Click += new System.EventHandler(this.btnOpenProviders_Click);
            // 
            // btnOpenProducts
            // 
            this.btnOpenProducts.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnOpenProducts.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.btnOpenProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenProducts.Location = new System.Drawing.Point(244, 231);
            this.btnOpenProducts.Name = "btnOpenProducts";
            this.btnOpenProducts.Size = new System.Drawing.Size(321, 51);
            this.btnOpenProducts.TabIndex = 2;
            this.btnOpenProducts.Text = "Товари";
            this.btnOpenProducts.UseVisualStyleBackColor = true;
            this.btnOpenProducts.Click += new System.EventHandler(this.btnOpenProducts_Click);
            // 
            // label1
            // 
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(788, 63);
            this.label1.TabIndex = 3;
            this.label1.Text = "Склад: електронний облік товарів";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 387);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOpenProducts);
            this.Controls.Add(this.btnOpenProviders);
            this.Controls.Add(this.btnOpenCategories);
            this.Name = "Form1";
            this.Text = "Головне вікно";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnOpenCategories;
        private Button btnOpenProviders;
        private Button btnOpenProducts;
        private Label label1;
    }
}