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
using System.Xml.Linq;

namespace ISAD_MAT
{
    public partial class FrmProduct : Form

    {
        public static string conStr = MatDatabase.conStr;
        public static SqlConnection con;
        public static SqlDataAdapter dap;
        public static DataTable dt;
        public static SqlCommand com;

        private static bool isEdit = false;
        public FrmProduct()
        {
            InitializeComponent();
            SqlDependency.Stop(conStr);
            SqlDependency.Start(conStr);
            LoadData();
        }
        private void LoadData()
        {
            gridProducts.DataSource = null;
            con = new SqlConnection(conStr);
            con.Open();

            com = new SqlCommand("GetProducts", con);
            com.CommandType = CommandType.StoredProcedure;

            SqlDependency dep = new SqlDependency(com);
            dep.OnChange += new OnChangeEventHandler(OnChange);

            dap = new SqlDataAdapter(com);
            dt = new DataTable();
            dap.Fill(dt);
            gridProducts.DataSource = dt;

        }
        public void OnChange(Object caller, SqlNotificationEventArgs e)
        {
            if (this.InvokeRequired)
            {
                gridProducts.BeginInvoke(new MethodInvoker(LoadData));
            }
            else
            {
                LoadData();
            }
        }
        

private void FrmProduct_Load(object sender, EventArgs e)
        {

        }

        private void gridProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx;
            if (gridProducts.RowCount > 0)
            {
                idx = e.RowIndex;
                if (idx < 0)
                {
                    return;
                }

                DataGridViewRow row = gridProducts.Rows[idx];
                lbId.Text = row.Cells[0].Value.ToString();
                txbProname.Text = row.Cells[1].Value.ToString();
                
                btnAddORSave.Text = "កែរ";
                isEdit = true;
                btnDelete.Visible = true;
                btnReject.Visible = true;
            }

        }
        private void AddProduct()
        {
            if(txbProname.Text.Length>0 )
            {
                com = new SqlCommand("InsProduct", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@n", txbProname.Text);
                com.ExecuteNonQuery();
                com.Dispose();
                ClearTBX();
            }

        }
        private void ClearTBX()
        {
            txbProname.Text = "";
            lbId.Text = "";
            btnAddORSave.Text = "ថែម";
            btnDelete.Visible = false;
            btnReject.Visible = false;
            isEdit = false;
        }

        private void btnAddORSave_Click(object sender, EventArgs e)
        {
            if (!isEdit)
            {
                AddProduct();  
            }
            else{
                UpdateProduct();
            }
        }
        private void UpdateProduct()
        {
            com = new SqlCommand("UpdateProduct", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@id", int.Parse(lbId.Text));
            com.Parameters.AddWithValue("@n", txbProname.Text);
           
            com.ExecuteNonQuery();
            com.Dispose();


           
            ClearTBX();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("តើអ្នកប្រាកដទេថាចង់លុប?", "ការលុបនឹងមិនអាចយកមកវិញបានពេលក្រោយទេ", MessageBoxButtons.YesNo);
            if (answer == DialogResult.Yes)
            {
                com = new SqlCommand("DeleteProduct", con);
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

        private void btnReject_Click(object sender, EventArgs e)
        {
            ClearTBX();
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lbId_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txbProname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
