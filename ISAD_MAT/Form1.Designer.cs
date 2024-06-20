namespace ISAD_MAT
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Stuff = new System.Windows.Forms.ToolStripMenuItem();
            this.Product = new System.Windows.Forms.ToolStripMenuItem();
            this.Supplier = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Stuff,
            this.Product,
            this.Supplier});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1086, 34);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Stuff
            // 
            this.Stuff.Font = new System.Drawing.Font("Khmer OS Battambang", 7.8F);
            this.Stuff.Name = "Stuff";
            this.Stuff.Size = new System.Drawing.Size(64, 28);
            this.Stuff.Text = "បុគ្គលិក";
            this.Stuff.Click += new System.EventHandler(this.Stuff_Click);
            // 
            // Product
            // 
            this.Product.Font = new System.Drawing.Font("Khmer OS Battambang", 7.8F);
            this.Product.Name = "Product";
            this.Product.Size = new System.Drawing.Size(55, 28);
            this.Product.Text = "ទំនិញ";
            this.Product.Click += new System.EventHandler(this.Product_Click);
            // 
            // Supplier
            // 
            this.Supplier.Font = new System.Drawing.Font("Khmer OS Battambang", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Supplier.Name = "Supplier";
            this.Supplier.Size = new System.Drawing.Size(78, 28);
            this.Supplier.Text = "អ្នកផ្គត់ផ្គង់";
            this.Supplier.Click += new System.EventHandler(this.Supplier_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1086, 951);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Khmer OS Siemreap", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Stuff;
        private System.Windows.Forms.ToolStripMenuItem Product;
        private System.Windows.Forms.ToolStripMenuItem Supplier;
    }
}

