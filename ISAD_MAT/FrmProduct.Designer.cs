namespace ISAD_MAT
{
    partial class FrmProduct
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
            this.gridProducts = new System.Windows.Forms.DataGridView();
            this.txbProname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbId = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddORSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnReject = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // gridProducts
            // 
            this.gridProducts.AllowUserToAddRows = false;
            this.gridProducts.AllowUserToDeleteRows = false;
            this.gridProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridProducts.ColumnHeadersHeight = 29;
            this.gridProducts.Location = new System.Drawing.Point(25, 130);
            this.gridProducts.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridProducts.Name = "gridProducts";
            this.gridProducts.ReadOnly = true;
            this.gridProducts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.gridProducts.RowTemplate.Height = 24;
            this.gridProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridProducts.Size = new System.Drawing.Size(442, 144);
            this.gridProducts.TabIndex = 0;
            this.gridProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridProducts_CellClick);
            // 
            // txbProname
            // 
            this.txbProname.Location = new System.Drawing.Point(588, 152);
            this.txbProname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbProname.Multiline = true;
            this.txbProname.Name = "txbProname";
            this.txbProname.Size = new System.Drawing.Size(220, 31);
            this.txbProname.TabIndex = 1;
            this.txbProname.TextChanged += new System.EventHandler(this.txbProname_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Khmer OS Moul Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(263, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 62);
            this.label1.TabIndex = 2;
            this.label1.Text = "ទំនិញទាំងអស់";
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.BackColor = System.Drawing.Color.Azure;
            this.lbId.Font = new System.Drawing.Font("Khmer OS Siemreap", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbId.Location = new System.Drawing.Point(503, 150);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(24, 31);
            this.lbId.TabIndex = 3;
            this.lbId.Text = "0";
            this.lbId.Click += new System.EventHandler(this.lbId_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Khmer OS Moul Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(495, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "អត្ដលេខ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Khmer OS Moul Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(584, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "ឈ្មោះទំនិញ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnAddORSave
            // 
            this.btnAddORSave.Location = new System.Drawing.Point(733, 240);
            this.btnAddORSave.Name = "btnAddORSave";
            this.btnAddORSave.Size = new System.Drawing.Size(75, 34);
            this.btnAddORSave.TabIndex = 6;
            this.btnAddORSave.Text = "ថែម";
            this.btnAddORSave.UseVisualStyleBackColor = true;
            this.btnAddORSave.Click += new System.EventHandler(this.btnAddORSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDelete.Location = new System.Drawing.Point(641, 240);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 34);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "លុប";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnReject
            // 
            this.btnReject.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnReject.Location = new System.Drawing.Point(560, 240);
            this.btnReject.Name = "btnReject";
            this.btnReject.Size = new System.Drawing.Size(75, 34);
            this.btnReject.TabIndex = 6;
            this.btnReject.Text = "បដិសេដ";
            this.btnReject.UseVisualStyleBackColor = false;
            this.btnReject.Visible = false;
            this.btnReject.Click += new System.EventHandler(this.btnReject_Click);
            // 
            // FrmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(820, 437);
            this.Controls.Add(this.btnReject);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAddORSave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbProname);
            this.Controls.Add(this.gridProducts);
            this.Font = new System.Drawing.Font("Khmer OS Siemreap", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmProduct";
            this.Text = "FrmProduct";
            this.Load += new System.EventHandler(this.FrmProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridProducts;
        private System.Windows.Forms.TextBox txbProname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddORSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnReject;
    }
}