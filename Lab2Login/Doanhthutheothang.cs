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
    public partial class Doanhthutheothang : Form
    {
        String strConn = ConfigurationManager.ConnectionStrings["MyConn"].ConnectionString;
        public Doanhthutheothang()
        {
            InitializeComponent();
        }

        private void Doanhthutheothang_Load(object sender, EventArgs e)
        {
            dtpfrom.CustomFormat = "yyyy/MM";
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void btncheck_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(strConn);
            //conn.ConnectionString = @"Data Source=(local)\SQLEXPRESS; Initial Catalog=finalCNPM;Integrated Security=True";
            conn.Open();
            SqlCommand cmd = new SqlCommand("sp_getdoanhthutheothang", conn);
            cmd.Parameters.AddWithValue("@from", dtpfrom.Value.ToString());
            cmd.Parameters.AddWithValue("@to", dtpto.Value.ToString());
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                dataGridView1.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Không có dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
