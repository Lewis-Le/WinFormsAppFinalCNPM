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
    public partial class frmManageAorderGoods : Form
    {
        int AorderID;
        int GID;
        int AGID;
        String strConn = ConfigurationManager.ConnectionStrings["MyConn"].ConnectionString;
        public frmManageAorderGoods(int AorderIDD)
        {
            //đổ data vào combobox
            SqlConnection conn = new SqlConnection(strConn);
            //conn.ConnectionString = @"Data Source=(local)\SQLEXPRESS; Initial Catalog=finalCNPM;Integrated Security=True";
            conn.Open();
            String sSQL = "SELECT * FROM Goods";
            SqlCommand cmd = new SqlCommand(sSQL, conn);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            //SqlDataReader myReader = cmd.ExecuteReader();
            //dt.Load(myReader);
            da.Fill(dt);
            InitializeComponent();
            if (dt.Rows.Count > 0)
            {
                comboBox1.ValueMember = "GID";
                comboBox1.DisplayMember = "GName";
                comboBox1.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Chưa có hàng hóa nào trong đại lý!");
            }
            AorderID = AorderIDD;
        }

        public void reload()
        {
            SqlConnection conn = new SqlConnection(strConn);
            //conn.ConnectionString = @"Data Source=(local)\SQLEXPRESS; Initial Catalog=finalCNPM;Integrated Security=True";
            conn.Open();
            String sSQL = "SELECT * FROM AorderGoods WHERE AorderID=@AorderID";
            SqlCommand cmd = new SqlCommand(sSQL, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            cmd.Parameters.Add(new SqlParameter("@AorderID", AorderID));
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count != 0)
            {
                dataGridView1.DataSource = dt;
            }
            else
            {
                //MessageBox.Show("No Data!");
            }
        }

        private void frmManageUsers_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(strConn);
            //conn.ConnectionString = @"Data Source=(local)\SQLEXPRESS; Initial Catalog=finalCNPM;Integrated Security=True";
            conn.Open();
            String sSQL = "SELECT * FROM AorderGoods WHERE AorderID=@AorderID";
            SqlCommand cmd = new SqlCommand(sSQL, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            cmd.Parameters.Add(new SqlParameter("@AorderID", AorderID));
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count != 0)
            {
                dataGridView1.DataSource = dt;
            }
            else
            {
                //MessageBox.Show("No Data!");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(strConn);
            //conn.ConnectionString = @"Data Source=(local)\SQLEXPRESS; Initial Catalog=finalCNPM;Integrated Security=True";
            conn.Open();
            String sSQL = "INSERT INTO AorderGoods (AorderID, GID, Quantity, GName) VALUES(@AorderID, @GID, @Quantity, @GName)";

            SqlCommand cmd = new SqlCommand(sSQL, conn);
            cmd.Parameters.Add(new SqlParameter("@AorderID", AorderID));
            cmd.Parameters.Add(new SqlParameter("@GID", GID));
            cmd.Parameters.Add(new SqlParameter("@Quantity", int.Parse(txtQuantity.Text)));
            cmd.Parameters.Add(new SqlParameter("@GName", comboBox1.Text));
            try
            {
               cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
               throw new Exception("Error:" + ex.Message);
            }
            MessageBox.Show("Thêm hàng hóa thành công!");
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
                int AorderGoodsID = int.Parse(Convert.ToString(row.Cells[0].Value), System.Globalization.NumberStyles.Any);
                int GID = int.Parse(Convert.ToString(row.Cells[2].Value), System.Globalization.NumberStyles.Any);
                int Quantity = int.Parse(Convert.ToString(row.Cells[3].Value), System.Globalization.NumberStyles.Any);

                //update UI
                txtQuantity.Text = Quantity.ToString();
                AGID = AorderGoodsID;
                //lấy data từ database
                SqlConnection conn = new SqlConnection(strConn);
                //conn.ConnectionString = @"Data Source=(local)\SQLEXPRESS; Initial Catalog=finalCNPM;Integrated Security=True";
                conn.Open();
                String sSQL = "SELECT * FROM Goods WHERE GID=@GID";
                SqlCommand cmd = new SqlCommand(sSQL, conn);
                cmd.Parameters.Add(new SqlParameter("@GID", GID));
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dtGoods = new DataTable();
                da.Fill(dtGoods);
                if (dtGoods.Rows.Count > 0)
                {
                    comboBox1.SelectedValue = GID;  //vì GID bắt đầu từ 1, SelectedIndex bắt đầu từ 0
                    txtGoodsDes.Text = dtGoods.Rows[0]["GDescription"].ToString();
                    txtPrice.Text = dtGoods.Rows[0]["GPrice"].ToString() + " VNĐ";
                    txtTotalPrice.Text = Convert.ToString(float.Parse(dtGoods.Rows[0]["GPrice"].ToString()) * (float)Quantity) + " VNĐ";
                    sSQL = "UPDATE AorderGoods SET TotalPrice=@TotalPrice WHERE AorderGoodsID=@AGID";   //update total price của mặt hàng này
                    cmd = new SqlCommand(sSQL, conn);
                    cmd.Parameters.Add(new SqlParameter("@TotalPrice", float.Parse(dtGoods.Rows[0]["GPrice"].ToString()) * (float)Quantity));
                    cmd.Parameters.Add(new SqlParameter("@AGID", AorderGoodsID));
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Error:" + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("No Data!");
                }

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
            String sSQL = "DELETE FROM AorderGoods WHERE AorderGoodsID=@AGID";

            SqlCommand cmd = new SqlCommand(sSQL, conn);
            cmd.Parameters.Add(new SqlParameter("@AGID", AGID));
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error:" + ex.Message);
            }
            MessageBox.Show("Xóa hàng hóa thành công!");
            dataGridView1.Refresh();
            reload();
        }

      
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(strConn);
            //conn.ConnectionString = @"Data Source=(local)\SQLEXPRESS; Initial Catalog=finalCNPM;Integrated Security=True";
            conn.Open();
            String sSQL = "UPDATE AorderGoods SET GID=@GID, Quantity=@Quantity, GName=@GName WHERE AorderGoodsID=@AGID";
            SqlCommand cmd = new SqlCommand(sSQL, conn);
            cmd.Parameters.Add(new SqlParameter("@GID", GID));
            cmd.Parameters.Add(new SqlParameter("@Quantity", int.Parse(txtQuantity.Text)));
            cmd.Parameters.Add(new SqlParameter("@GName", comboBox1.SelectedText));
            cmd.Parameters.Add(new SqlParameter("@AGID", AGID));
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error:" + ex.Message);
            }
            MessageBox.Show("Cập nhật hàng hóa thành công!");
            dataGridView1.Refresh();
            reload();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedValue != null)
            {
                //MessageBox.Show(comboBox1.SelectedValue.ToString());
                GID = Convert.ToInt32(comboBox1.SelectedValue);
            }
        }
    }
}
