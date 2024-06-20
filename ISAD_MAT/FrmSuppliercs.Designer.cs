namespace ISAD_MAT
{
    partial class FrmSuppliercs
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
            this.btnReject = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAddORSave = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbId = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbSupplier = new System.Windows.Forms.TextBox();
            this.gridProducts = new System.Windows.Forms.DataGridView();
            this.txbAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbContext = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReject
            // 
            this.btnReject.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnReject.Location = new System.Drawing.Point(405, 513);
            this.btnReject.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnReject.Name = "btnReject";
            this.btnReject.Size = new System.Drawing.Size(84, 51);
            this.btnReject.TabIndex = 13;
            this.btnReject.Text = "បដិសេដ";
            this.btnReject.UseVisualStyleBackColor = false;
            this.btnReject.Visible = false;
            this.btnReject.Click += new System.EventHandler(this.btnReject_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDelete.Font = new System.Drawing.Font("Khmer OS Battambang", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(535, 513);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(84, 51);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "លុប";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAddORSave
            // 
            this.btnAddORSave.Location = new System.Drawing.Point(666, 513);
            this.btnAddORSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddORSave.Name = "btnAddORSave";
            this.btnAddORSave.Size = new System.Drawing.Size(84, 51);
            this.btnAddORSave.TabIndex = 15;
            this.btnAddORSave.Text = "ថែម";
            this.btnAddORSave.UseVisualStyleBackColor = true;
            this.btnAddORSave.Click += new System.EventHandler(this.btnAddORSave_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Khmer OS Moul Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(143, 308);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 24);
            this.label3.TabIndex = 12;
            this.label3.Text = "អ្នកផ្គត់ផ្គង់";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Khmer OS Moul Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1, 308);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "អត្ដលេខ";
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.BackColor = System.Drawing.Color.Azure;
            this.lbId.Font = new System.Drawing.Font("Khmer OS Siemreap", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbId.Location = new System.Drawing.Point(12, 345);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(24, 31);
            this.lbId.TabIndex = 10;
            this.lbId.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Khmer OS Moul Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(243, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 62);
            this.label1.TabIndex = 9;
            this.label1.Text = "អ្នកផ្គត់ផ្គង់ទាំងអស់";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txbSupplier
            // 
            this.txbSupplier.Location = new System.Drawing.Point(138, 338);
            this.txbSupplier.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txbSupplier.Multiline = true;
            this.txbSupplier.Name = "txbSupplier";
            this.txbSupplier.Size = new System.Drawing.Size(273, 45);
            this.txbSupplier.TabIndex = 8;
            // 
            // gridProducts
            // 
            this.gridProducts.AllowUserToAddRows = false;
            this.gridProducts.AllowUserToDeleteRows = false;
            this.gridProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridProducts.ColumnHeadersHeight = 29;
            this.gridProducts.Location = new System.Drawing.Point(12, 93);
            this.gridProducts.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.gridProducts.Name = "gridProducts";
            this.gridProducts.ReadOnly = true;
            this.gridProducts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.gridProducts.RowTemplate.Height = 24;
            this.gridProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridProducts.Size = new System.Drawing.Size(774, 209);
            this.gridProducts.TabIndex = 7;
            this.gridProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridProducts_CellClick);
            // 
            // txbAddress
            // 
            this.txbAddress.Location = new System.Drawing.Point(454, 338);
            this.txbAddress.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txbAddress.Multiline = true;
            this.txbAddress.Name = "txbAddress";
            this.txbAddress.Size = new System.Drawing.Size(298, 134);
            this.txbAddress.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Khmer OS Moul Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(450, 308);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 24);
            this.label4.TabIndex = 12;
            this.label4.Text = "អាសយដ្ឋាន";
            // 
            // txbContext
            // 
            this.txbContext.Location = new System.Drawing.Point(138, 427);
            this.txbContext.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txbContext.Multiline = true;
            this.txbContext.Name = "txbContext";
            this.txbContext.Size = new System.Drawing.Size(265, 45);
            this.txbContext.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Khmer OS Moul Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(143, 397);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 24);
            this.label5.TabIndex = 12;
            this.label5.Text = "លេខទំនាក់ទំនង";
            // 
            // FrmSuppliercs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(820, 788);
            this.Controls.Add(this.btnReject);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAddORSave);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbContext);
            this.Controls.Add(this.txbAddress);
            this.Controls.Add(this.txbSupplier);
            this.Controls.Add(this.gridProducts);
            this.Font = new System.Drawing.Font("Khmer OS Battambang", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmSuppliercs";
            this.Text = "FrmSuppliercs";
            ((System.ComponentModel.ISupportInitialize)(this.gridProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReject;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAddORSave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbSupplier;
        private System.Windows.Forms.DataGridView gridProducts;
        private System.Windows.Forms.TextBox txbAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbContext;
        private System.Windows.Forms.Label label5;
    }
}