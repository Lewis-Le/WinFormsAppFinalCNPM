using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2Login
{
    public partial class frmManageUsers : Form
    {
        String strConn = ConfigurationManager.ConnectionStrings["MyConn"].ConnectionString;
        public frmManageUsers()
        {
            InitializeComponent();
        }

        public void reload()
        {
            SqlConnection conn = new SqlConnection(strConn);
            //conn.ConnectionString = @"Data Source=(local)\SQLEXPRESS; Initial Catalog=finalCNPM;Integrated Security=True";
            conn.Open();
            String sSQL = "SELECT * FROM Goods ";
            SqlCommand cmd = new SqlCommand(sSQL, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                dataGridView1.DataSource = dt;
            }
            else
            {
                MessageBox.Show("No Data!");
            }
        }

        private void frmManageUsers_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(strConn);
            //conn.ConnectionString = @"Data Source=(local)\SQLEXPRESS; Initial Catalog=finalCNPM;Integrated Security=True";
            conn.Open();
            String sSQL = "SELECT * FROM Goods ";
            SqlCommand cmd = new SqlCommand(sSQL, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                dataGridView1.DataSource = dt;
            }
            else
            {
                MessageBox.Show("No Data!");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(strConn);
            //conn.ConnectionString = @"Data Source=(local)\SQLEXPRESS; Initial Catalog=finalCNPM;Integrated Security=True";
            conn.Open();
            String sSQL = "INSERT INTO Goods (GName, GDescription, GPrice) VALUES(@GName, @GDescription, @GPrice)";

            SqlCommand cmd = new SqlCommand(sSQL, conn);
            cmd.Parameters.Add(new SqlParameter("@GName", txtUserID.Text));
            cmd.Parameters.Add(new SqlParameter("@GDescription", txtUsername.Text));
            cmd.Parameters.Add(new SqlParameter("@GPrice", float.Parse(txtPassword.Text)));
            try
            {
               cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
               throw new Exception("Error:" + ex.Message);
            }
            MessageBox.Show("Save successfully!");
            dataGridView1.Refresh();
            reload();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index < 0 || index >= dataGridView1.RowCount)
                return;
            try
            {
                DataGridViewRow row = dataGridView1.Rows[index];
                int GID = int.Parse(Convert.ToString(row.Cells[0].Value), System.Globalization.NumberStyles.Any);
                String GName = Convert.ToString(row.Cells[1].Value);
                String GDescription = Convert.ToString(row.Cells[2].Value);
                String GPrice = Convert.ToString(row.Cells[3].Value);
                //DateTime createDate = Convert.ToDateTime(row.Cells[4].Value);

                //update UI
                txtGID.Text = GID.ToString();
                txtUserID.Text = GName;
                txtUsername.Text = GDescription;
                txtPassword.Text = GPrice.ToString();
                //dtCreateDate.Value = createDate;
            }
            catch (Exception ex)
            {
                throw new Exception("Error:" + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(strConn);
            //conn.ConnectionString = @"Data Source=(local)\SQLEXPRESS; Initial Catalog=finalCNPM;Integrated Security=True";
            conn.Open();
            String sSQL = "DELETE FROM Goods WHERE GID=@GID";

            SqlCommand cmd = new SqlCommand(sSQL, conn);
            cmd.Parameters.Add(new SqlParameter("@GID", int.Parse(txtGID.Text)));
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error:" + ex.Message);
            }
            MessageBox.Show("Delete successfully!");
            dataGridView1.Refresh();
            reload();
        }

      

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(strConn);
            //conn.ConnectionString = @"Data Source=(local)\SQLEXPRESS; Initial Catalog=finalCNPM;Integrated Security=True";
            conn.Open();
            String sSQL = "UPDATE Goods SET GName=@GName, GDescription=@GDescription, GPrice=@GPrice WHERE GID=@GID";

            SqlCommand cmd = new SqlCommand(sSQL, conn);
            cmd.Parameters.Add(new SqlParameter("@GID", int.Parse(txtGID.Text)));
            cmd.Parameters.Add(new SqlParameter("@GName", txtUserID.Text));
            cmd.Parameters.Add(new SqlParameter("@GDescription", txtUsername.Text));
            cmd.Parameters.Add(new SqlParameter("@GPrice", float.Parse(txtPassword.Text)));
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error:" + ex.Message);
            }
            MessageBox.Show("Update successfully!");
            dataGridView1.Refresh();
            reload();
        }
    }
}
