namespace CiscoEshop.UI
{
    partial class ItemDetail
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.detailNameTxtbox = new System.Windows.Forms.TextBox();
            this.detailCostTxtbox = new System.Windows.Forms.TextBox();
            this.detailFirewallTxtbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cost:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Firewall:";
            // 
            // detailNameTxtbox
            // 
            this.detailNameTxtbox.Location = new System.Drawing.Point(153, 100);
            this.detailNameTxtbox.Name = "detailNameTxtbox";
            this.detailNameTxtbox.ReadOnly = true;
            this.detailNameTxtbox.Size = new System.Drawing.Size(263, 26);
            this.detailNameTxtbox.TabIndex = 1;
            // 
            // detailCostTxtbox
            // 
            this.detailCostTxtbox.Location = new System.Drawing.Point(153, 132);
            this.detailCostTxtbox.Name = "detailCostTxtbox";
            this.detailCostTxtbox.ReadOnly = true;
            this.detailCostTxtbox.Size = new System.Drawing.Size(263, 26);
            this.detailCostTxtbox.TabIndex = 1;
            // 
            // detailFirewallTxtbox
            // 
            this.detailFirewallTxtbox.Location = new System.Drawing.Point(153, 163);
            this.detailFirewallTxtbox.Name = "detailFirewallTxtbox";
            this.detailFirewallTxtbox.ReadOnly = true;
            this.detailFirewallTxtbox.Size = new System.Drawing.Size(263, 26);
            this.detailFirewallTxtbox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(153, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(241, 36);
            this.label4.TabIndex = 2;
            this.label4.Text = "Router Details";
            // 
            // ItemDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 507);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.detailFirewallTxtbox);
            this.Controls.Add(this.detailCostTxtbox);
            this.Controls.Add(this.detailNameTxtbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ItemDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Item Detail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        public TextBox detailNameTxtbox;
        public TextBox detailCostTxtbox;
        public TextBox detailFirewallTxtbox;
        private Label label4;
    }
}