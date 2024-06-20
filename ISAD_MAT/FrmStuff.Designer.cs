namespace ISAD_MAT
{
    partial class FrmStuff
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
            this.gridStuffs = new System.Windows.Forms.DataGridView();
            this.btnReject = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAddORSave = new System.Windows.Forms.Button();
            this.txbFullName = new System.Windows.Forms.TextBox();
            this.lbId = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rdoM = new System.Windows.Forms.RadioButton();
            this.rdoF = new System.Windows.Forms.RadioButton();
            this.dtpDob = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txbPosition = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txbSalary = new System.Windows.Forms.TextBox();
            this.chbStopwork = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridStuffs)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Khmer OS Moul Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(312, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 62);
            this.label1.TabIndex = 4;
            this.label1.Text = "បុគ្គលិកទាំងអស់";
            // 
            // gridStuffs
            // 
            this.gridStuffs.AllowUserToAddRows = false;
            this.gridStuffs.AllowUserToDeleteRows = false;
            this.gridStuffs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridStuffs.ColumnHeadersHeight = 29;
            this.gridStuffs.Location = new System.Drawing.Point(51, 263);
            this.gridStuffs.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridStuffs.Name = "gridStuffs";
            this.gridStuffs.ReadOnly = true;
            this.gridStuffs.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.gridStuffs.RowTemplate.Height = 24;
            this.gridStuffs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridStuffs.Size = new System.Drawing.Size(865, 208);
            this.gridStuffs.TabIndex = 3;
            this.gridStuffs.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridStuffs_CellClick);
            // 
            // btnReject
            // 
            this.btnReject.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnReject.Font = new System.Drawing.Font("Khmer OS Siemreap", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReject.Location = new System.Drawing.Point(631, 222);
            this.btnReject.Name = "btnReject";
            this.btnReject.Size = new System.Drawing.Size(75, 34);
            this.btnReject.TabIndex = 7;
            this.btnReject.Text = "បដិសេដ";
            this.btnReject.UseVisualStyleBackColor = false;
            this.btnReject.Visible = false;
            this.btnReject.Click += new System.EventHandler(this.btnReject_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDelete.Font = new System.Drawing.Font("Khmer OS Siemreap", 7.8F);
            this.btnDelete.Location = new System.Drawing.Point(733, 222);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 34);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "លុប";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAddORSave
            // 
            this.btnAddORSave.Font = new System.Drawing.Font("Khmer OS Siemreap", 7.8F);
            this.btnAddORSave.Location = new System.Drawing.Point(841, 222);
            this.btnAddORSave.Name = "btnAddORSave";
            this.btnAddORSave.Size = new System.Drawing.Size(75, 34);
            this.btnAddORSave.TabIndex = 9;
            this.btnAddORSave.Text = "ថែម";
            this.btnAddORSave.UseVisualStyleBackColor = true;
            this.btnAddORSave.Click += new System.EventHandler(this.btnAddORSave_Click);
            // 
            // txbFullName
            // 
            this.txbFullName.Location = new System.Drawing.Point(175, 122);
            this.txbFullName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbFullName.Multiline = true;
            this.txbFullName.Name = "txbFullName";
            this.txbFullName.Size = new System.Drawing.Size(168, 40);
            this.txbFullName.TabIndex = 1;
            this.txbFullName.TextChanged += new System.EventHandler(this.txbProname_TextChanged);
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.BackColor = System.Drawing.Color.White;
            this.lbId.Font = new System.Drawing.Font("Khmer OS Siemreap", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbId.Location = new System.Drawing.Point(79, 122);
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
            this.label2.Location = new System.Drawing.Point(70, 89);
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
            this.label3.Location = new System.Drawing.Point(171, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "ឈ្មោះពេញ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // rdoM
            // 
            this.rdoM.AutoSize = true;
            this.rdoM.Checked = true;
            this.rdoM.Font = new System.Drawing.Font("Khmer Muol", 7.8F, System.Drawing.FontStyle.Bold);
            this.rdoM.Location = new System.Drawing.Point(175, 222);
            this.rdoM.Name = "rdoM";
            this.rdoM.Size = new System.Drawing.Size(65, 28);
            this.rdoM.TabIndex = 10;
            this.rdoM.TabStop = true;
            this.rdoM.Text = "ប្រុស";
            this.rdoM.UseVisualStyleBackColor = true;
            // 
            // rdoF
            // 
            this.rdoF.AutoSize = true;
            this.rdoF.Font = new System.Drawing.Font("Khmer Muol", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoF.Location = new System.Drawing.Point(246, 222);
            this.rdoF.Name = "rdoF";
            this.rdoF.Size = new System.Drawing.Size(51, 28);
            this.rdoF.TabIndex = 11;
            this.rdoF.TabStop = true;
            this.rdoF.Text = "ស្រី";
            this.rdoF.UseVisualStyleBackColor = true;
            // 
            // dtpDob
            // 
            this.dtpDob.CustomFormat = "dd-MM-yyyy";
            this.dtpDob.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDob.Location = new System.Drawing.Point(398, 122);
            this.dtpDob.Name = "dtpDob";
            this.dtpDob.Size = new System.Drawing.Size(200, 22);
            this.dtpDob.TabIndex = 12;
            this.dtpDob.Value = new System.DateTime(2000, 8, 16, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Khmer OS Moul Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(411, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 24);
            this.label4.TabIndex = 13;
            this.label4.Text = "ថ្ងៃខែឆ្នាំកំណើត";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Khmer OS Moul Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(638, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 24);
            this.label5.TabIndex = 14;
            this.label5.Text = "តួនាទី";
            // 
            // txbPosition
            // 
            this.txbPosition.Location = new System.Drawing.Point(631, 117);
            this.txbPosition.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbPosition.Multiline = true;
            this.txbPosition.Name = "txbPosition";
            this.txbPosition.Size = new System.Drawing.Size(168, 40);
            this.txbPosition.TabIndex = 1;
            this.txbPosition.TextChanged += new System.EventHandler(this.txbProname_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Khmer OS Moul Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(827, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 24);
            this.label6.TabIndex = 16;
            this.label6.Text = "ប្រាក់ខែ";
            // 
            // txbSalary
            // 
            this.txbSalary.Location = new System.Drawing.Point(831, 117);
            this.txbSalary.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbSalary.Multiline = true;
            this.txbSalary.Name = "txbSalary";
            this.txbSalary.Size = new System.Drawing.Size(85, 40);
            this.txbSalary.TabIndex = 15;
            // 
            // chbStopwork
            // 
            this.chbStopwork.AutoSize = true;
            this.chbStopwork.Font = new System.Drawing.Font("Khmer Moul", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbStopwork.Location = new System.Drawing.Point(323, 222);
            this.chbStopwork.Name = "chbStopwork";
            this.chbStopwork.Size = new System.Drawing.Size(105, 33);
            this.chbStopwork.TabIndex = 17;
            this.chbStopwork.Text = "ឈប់ធ្វើការ";
            this.chbStopwork.UseVisualStyleBackColor = true;
            // 
            // FrmStuff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(928, 595);
            this.Controls.Add(this.chbStopwork);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txbSalary);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpDob);
            this.Controls.Add(this.rdoF);
            this.Controls.Add(this.rdoM);
            this.Controls.Add(this.btnReject);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAddORSave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gridStuffs);
            this.Controls.Add(this.lbId);
            this.Controls.Add(this.txbPosition);
            this.Controls.Add(this.txbFullName);
            this.Name = "FrmStuff";
            this.Text = "FrmStuff";
            ((System.ComponentModel.ISupportInitialize)(this.gridStuffs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridStuffs;
        private System.Windows.Forms.Button btnReject;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAddORSave;
        private System.Windows.Forms.TextBox txbFullName;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdoM;
        private System.Windows.Forms.RadioButton rdoF;
        private System.Windows.Forms.DateTimePicker dtpDob;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbPosition;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbSalary;
        private System.Windows.Forms.CheckBox chbStopwork;
    }
}