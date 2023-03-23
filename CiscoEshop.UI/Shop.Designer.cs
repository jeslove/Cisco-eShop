namespace CiscoEshop.UI
{
    partial class Shop
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
            this.label1 = new System.Windows.Forms.Label();
            this.inventoryGrid = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.inventorySearchTxtbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.inventorySearchBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(405, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Shop Inventory";
            // 
            // inventoryGrid
            // 
            this.inventoryGrid.AllowUserToAddRows = false;
            this.inventoryGrid.AllowUserToDeleteRows = false;
            this.inventoryGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.inventoryGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inventoryGrid.Location = new System.Drawing.Point(80, 152);
            this.inventoryGrid.Name = "inventoryGrid";
            this.inventoryGrid.ReadOnly = true;
            this.inventoryGrid.RowTemplate.Height = 25;
            this.inventoryGrid.Size = new System.Drawing.Size(853, 362);
            this.inventoryGrid.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSalmon;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.inventorySearchBtn);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.inventorySearchTxtbox);
            this.panel1.Location = new System.Drawing.Point(74, 94);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(865, 54);
            this.panel1.TabIndex = 2;
            // 
            // inventorySearchTxtbox
            // 
            this.inventorySearchTxtbox.Location = new System.Drawing.Point(130, 10);
            this.inventorySearchTxtbox.Name = "inventorySearchTxtbox";
            this.inventorySearchTxtbox.Size = new System.Drawing.Size(192, 26);
            this.inventorySearchTxtbox.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Item name:";
            // 
            // inventorySearchBtn
            // 
            this.inventorySearchBtn.Location = new System.Drawing.Point(351, 10);
            this.inventorySearchBtn.Name = "inventorySearchBtn";
            this.inventorySearchBtn.Size = new System.Drawing.Size(75, 34);
            this.inventorySearchBtn.TabIndex = 2;
            this.inventorySearchBtn.Text = "Search";
            this.inventorySearchBtn.UseVisualStyleBackColor = true;
            this.inventorySearchBtn.Click += new System.EventHandler(this.inventorySearchBtn_Click);
            // 
            // Shop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 570);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.inventoryGrid);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Shop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shop";
            this.Load += new System.EventHandler(this.Shop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inventoryGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private DataGridView inventoryGrid;
        private Panel panel1;
        private Button inventorySearchBtn;
        private Label label2;
        private TextBox inventorySearchTxtbox;
    }
}