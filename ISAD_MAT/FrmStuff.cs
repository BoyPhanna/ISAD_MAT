using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISAD_MAT
{
    public partial class FrmStuff : Form
    {
        public static string conStr = MatDatabase.conStr;
        public static SqlConnection con;
        public static SqlDataAdapter dap;
        public static DataTable dt;
        public static SqlCommand com;

        private static bool isEdit = false;
        public FrmStuff()
        {
            InitializeComponent();
            SqlDependency.Stop(conStr);
            SqlDependency.Start(conStr);
            LoadData();
        }
        private void LoadData()
        {
            gridStuffs.DataSource = null;
            con = new SqlConnection(conStr);
            con.Open();

            com = new SqlCommand("GetStuffs", con);
            com.CommandType = CommandType.StoredProcedure;

            SqlDependency dep = new SqlDependency(com);
            dep.OnChange += new OnChangeEventHandler(OnChange);

            dap = new SqlDataAdapter(com);
            dt = new DataTable();
            dap.Fill(dt);
            gridStuffs.DataSource = dt;

        }
        public void OnChange(Object caller, SqlNotificationEventArgs e)
        {
            if (this.InvokeRequired)
            {
                gridStuffs.BeginInvoke(new MethodInvoker(LoadData));
            }
            else
            {
                LoadData();
            }
        }


        private void txbProname_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbId_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void gridStuffs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx;
            if (gridStuffs.RowCount > 0)
            {
                idx = e.RowIndex;
                if (idx < 0)
                {
                    return;
                }

                DataGridViewRow row = gridStuffs.Rows[idx];
                lbId.Text = row.Cells[0].Value.ToString();
                txbFullName.Text = row.Cells[1].Value.ToString();
                rdoM.Checked = row.Cells[2].Value.ToString() == "M" ? true : false;
                rdoF.Checked = !rdoM.Checked;
                dtpDob.Value = DateTime.Parse(row.Cells[3].Value.ToString());
                txbPosition.Text = row.Cells[4].Value.ToString();
                txbSalary.Text = row.Cells[5].Value.ToString();
                chbStopwork.Checked = bool.Parse(row.Cells[6].Value.ToString());
                btnAddORSave.Text = "កែរ";
                isEdit = true;
                btnDelete.Visible = true;
                btnReject.Visible = true;
            }
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            ClearTBX();
        }
        private void ClearTBX()
        {
            isEdit = false;
            btnAddORSave.Text = "ថែម";
            btnDelete.Visible = false;
            btnReject.Visible = false;
            lbId.Text = "";
            txbFullName.Text = "";
            dtpDob.Text = "";
            txbPosition.Text = "";
            txbSalary.Text = "";
            chbStopwork.Checked = false;
        }

        private void btnAddORSave_Click(object sender, EventArgs e)
        {

            if (!isEdit)
            {
                AddProduct();
            }
            else
            {
                UpdateProduct();
            }
        }
        private void UpdateProduct()
        {
            com = new SqlCommand("UpdateStuff", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@id", int.Parse(lbId.Text));
            com.Parameters.AddWithValue("@n", txbFullName.Text);
            com.Parameters.AddWithValue("@g", rdoM.Checked ? 'M': 'F');
            com.Parameters.AddWithValue("@dob", dtpDob.Value);
            com.Parameters.AddWithValue("@pos", txbPosition.Text);
            com.Parameters.AddWithValue("@sa", float.Parse(txbSalary.Text));
            com.Parameters.AddWithValue("@stop", chbStopwork.Checked);

            com.ExecuteNonQuery();
            com.Dispose();



            ClearTBX();

        }
        private void AddProduct()
        {
            if (txbFullName.Text.Length > 0)
            {
                com = new SqlCommand("InsStuff", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@n", txbFullName.Text);
                com.Parameters.AddWithValue("@g", rdoM.Checked ? "M" : "F");
                com.Parameters.AddWithValue("@dob", dtpDob.Value);
                com.Parameters.AddWithValue("@pos", txbPosition.Text);
                com.Parameters.AddWithValue("@sa", float.Parse(txbSalary.Text));
                com.Parameters.AddWithValue("@stop", chbStopwork.Checked);
                com.ExecuteNonQuery();
                com.Dispose();
                ClearTBX();
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("តើអ្នកប្រាកដទេថាចង់លុប?", "ការលុបនឹងមិនអាចយកមកវិញបានពេលក្រោយទេ", MessageBoxButtons.YesNo);
            if (answer == DialogResult.Yes)
            {
                com = new SqlCommand("DeleteStuff", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@id", int.Parse(lbId.Text));
                com.ExecuteNonQuery();
                com.Dispose();
                MessageBox.Show("ព័ត៏មានត្រូវបានលុបដោយជោគជ័យ");
                ClearTBX();

            }
            else
            {
                MessageBox.Show("ទិន្នន័យមិនត្រូវបានលុប");
            }
        }
    }
}
