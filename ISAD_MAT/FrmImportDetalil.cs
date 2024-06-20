using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ISAD_MAT
{
    public partial class FrmImportDetalil : Form
    {

        MatDatabase matDatabase=new MatDatabase();
        SqlCommand com;
        SqlDataAdapter dap;
        DataTable dt;
        Decimal Total;

        public FrmImportDetalil()
        {
            matDatabase.Conn();
            InitializeComponent();
            LoadData();
        }

        public void LoadData()
        {
            dap = new SqlDataAdapter("SELECT stuffID FROM dbo.tbStuffs WHERE Stopwork=0", matDatabase.con);
            dt = new DataTable();
            dap.Fill(dt);
            cboStaffID.DataSource = null;
            cboStaffID.Items.Clear();
            cboStaffID.DataSource = dt;
            cboStaffID.DisplayMember = "stuffID";
            cboStaffID.ValueMember = "stuffID";
            cboStaffID.Text = null;

            com = new SqlCommand("SELECT supID FROM dbo.tbSuppliers", matDatabase.con);
            dap = new SqlDataAdapter(com);
            dt = new DataTable();
            dap.Fill(dt);
            cboSupID.DataSource = null;
            cboSupID.Items.Clear();
            cboSupID.DataSource = dt;
            cboSupID.DisplayMember = "supID";
            cboSupID.ValueMember = "supID";
            cboSupID.Text = null;

        }
        public void OnChange(object caller, SqlNotificationEventArgs e)
        {
            if (this.InvokeRequired)
            {
                //dgvStaff.BeginInvoke(new MethodInvoker(LoadData));
            }
            else
            {
                LoadData();
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            lstProduct.Clear();
            lstProduct.View = View.Details;
            lstProduct.Columns.Add("Product ID", 150);
            lstProduct.Columns.Add("Product Name", 200);
            lstProduct.Columns.Add("Quantity", 100);
            lstProduct.Columns.Add("Unit Price", 150);
            lstProduct.Columns.Add("Amount", 100);
        }

        private void cboStaffID_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int staffID;
            staffID = int.Parse(cboStaffID.SelectedValue.ToString());
            com = new SqlCommand("SELECT fullname FROM dbo.tbStuffs WHERE stuffID=" + staffID, matDatabase.con);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                txtStuffName.Text = dr[0].ToString();
            }
            dr.Dispose();
            com.Dispose();
        }

        private void cboSupID_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int supID;
            supID = int.Parse(cboSupID.SelectedValue.ToString());
            com = new SqlCommand("SELECT Supplier, SupCon FROM dbo.tbSuppliers WHERE supID=" + supID, matDatabase.con);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                txtSupplier.Text = dr[0].ToString();
                txtContact.Text = dr[1].ToString();
            }
            dr.Dispose();
            com.Dispose();
        }

        private void txtProID_Leave(object sender, EventArgs e)
        {
            int ProID;
            if (!txtProID.Text.Equals(""))
            {
                ProID = int.Parse(txtProID.Text);
                com = new SqlCommand("SELECT ProName FROM dbo.tbProducts WHERE ProCode=" + ProID, matDatabase.con);
                SqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    txtProName.Text = dr[0].ToString();
                }
                dr.Dispose();
                com.Dispose();
            }
            
        }

        private void txtQty_Leave(object sender, EventArgs e)
        {
            int qty;
            float price;
            float amount;
            qty = int.Parse(txtQty.Text);
            price = float.Parse(txtPrice.Text);
            amount = qty * price;
            txtAmount.Text = amount.ToString();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Decimal amount, s;
            ListViewItem lv = lstProduct.FindItemWithText(txtProID.Text);
            if (lv != null)
            {
                var qty = int.Parse(lv.SubItems[2].Text) + int.Parse(txtQty.Text);
                lv.SubItems[2].Text = qty.ToString();
                Total = Total - decimal.Parse(lv.SubItems[4].Text, System.Globalization.NumberStyles.Currency);
                var price = decimal.Parse(txtPrice.Text);
                amount = qty * price;
                lv.SubItems[4].Text = string.Format("{0:c}", amount);
                Total = Total + amount;
            }
            else
            {
                ListViewItem item;
                string[] arr = new string[5];
                arr[0] = txtProID.Text;
                arr[1] = txtProName.Text;
                arr[2] = txtQty.Text;
                s = decimal.Parse(txtPrice.Text);
                arr[3] = string.Format("{0:c}", s);
                amount = decimal.Parse(txtQty.Text) * s;
                arr[4] = string.Format("{0:c}", amount);
                item = new ListViewItem(arr);
                lstProduct.Items.Add(item);
                Total = Total + amount;

            }
            txtTotal.Text = Total.ToString();
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            DialogResult re;
            foreach (ListViewItem item in lstProduct.Items)
            {
                if (item.Selected)
                {
                    re = MessageBox.Show("Do you want to remove this item?",
                        "Remove", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (re == DialogResult.Yes)
                    {
                        ListViewItem it = lstProduct.SelectedItems[0];
                        lstProduct.Items.Remove(item);
                        var a = Decimal.Parse(it.SubItems[4].Text, NumberStyles.Currency);
                        Total = Total - a;
                        txtTotal.Text = string.Format("{0:c}", Total);
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DataTable dtMaster = new DataTable();

            dtMaster.Columns.Add("InDate", typeof(DateTime));
            dtMaster.Columns.Add("stID", typeof(int));
            dtMaster.Columns.Add("fname", typeof(string));
            dtMaster.Columns.Add("cusID", typeof(int));
            dtMaster.Columns.Add("cusName", typeof(string));
            dtMaster.Columns.Add("Total", typeof(float));

            string InDate = dtpDate.Value.ToString("yyyy-MM-dd HH:mm:ss");
            string eid = cboStaffID.Text;
            string en = txtStuffName.Text;
            int supID = int.Parse(cboSupID.Text);
            string sn = txtSupplier.Text;
            string sc = txtContact.Text;

            dtMaster.Rows.Add(DateTime.Parse(InDate), eid, en, supID, sn, Total);

            com = new SqlCommand("InsImportE1", matDatabase.con);
            com.CommandType = CommandType.StoredProcedure;
            SqlParameter p1 = new SqlParameter();
            p1.ParameterName = "@IM";
            p1.SqlDbType = SqlDbType.Structured;
            p1.Value = dtMaster;
            com.Parameters.Add(p1);
            com.Parameters.Add("@ImNo", SqlDbType.Int).Direction = ParameterDirection.Output;
            com.ExecuteNonQuery();

            var InNo = int.Parse(com.Parameters["@ImNo"].Value.ToString());
            MessageBox.Show(InNo.ToString());



            DataTable dtDetail = new DataTable();
            dtDetail.Columns.Add("impID",typeof(int));
            dtDetail.Columns.Add("procode", typeof(int));
            dtDetail.Columns.Add("proName", typeof(string));
            dtDetail.Columns.Add("price", typeof(float));
            dtDetail.Columns.Add("qty", typeof(int));
            dtDetail.Columns.Add("up", typeof(float));
            foreach (ListViewItem item in lstProduct.Items)
            {
                int pid = int.Parse(item.SubItems[0].Text);
                string pn = item.SubItems[1].Text;
                int q = int.Parse(item.SubItems[2].Text);
                var un = decimal.Parse(item.SubItems[3].Text, NumberStyles.Currency);
                var amount = decimal.Parse(item.SubItems[4].Text, NumberStyles.Currency);
                dtDetail.Rows.Add(InNo, pid, pn, q, un,amount);
            }

            com = new SqlCommand("InsImportDetailE1", matDatabase.con);
            com.CommandType = CommandType.StoredProcedure;
            SqlParameter p2 = new SqlParameter();
            p2.ParameterName = "@IMdetail";
            p2.SqlDbType = SqlDbType.Structured;
            p2.Value = dtDetail;
            com.Parameters.Add(p2);

            com.ExecuteNonQuery();
        }

    }
}
