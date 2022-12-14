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
    public partial class frmManageReceive : Form
    {
        DataTable accountantData;
        DataTable agentData;
        int AorderIDD;
        String strConn = ConfigurationManager.ConnectionStrings["MyConn"].ConnectionString;
        public frmManageReceive(DataTable dtAccountant, DataTable dtAgent)
        {
            accountantData = new DataTable();
            agentData = new DataTable();
            accountantData = dtAccountant;
            agentData = dtAgent;
            InitializeComponent();
        }

        public void reload()
        {
            SqlConnection conn = new SqlConnection(strConn);
            //conn.ConnectionString = @"Data Source=(local)\SQLEXPRESS; Initial Catalog=finalCNPM;Integrated Security=True";
            conn.Open();
            String sSQL = "SELECT * FROM GoodsReceive";
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
                MessageBox.Show("Chưa có đơn nhập kho nào!");
            }
        }

        private void frmManageUsers_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(strConn);
            //conn.ConnectionString = @"Data Source=(local)\SQLEXPRESS; Initial Catalog=finalCNPM;Integrated Security=True";
            conn.Open();
            String sSQL = "SELECT * FROM GoodsReceive";
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
                MessageBox.Show("Chưa có đơn nhập kho nào!");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(strConn);
            //conn.ConnectionString = @"Data Source=(local)\SQLEXPRESS; Initial Catalog=finalCNPM;Integrated Security=True";
            conn.Open();
            String sSQL = "INSERT INTO GoodsReceive (AccountantID, AorderPrice, AgentPayment, AgentDelivery, DateCreated) VALUES(@AccountantID, @AorderPrice, @AgentPayment, @AgentDelivery, @DateCreated)";
            SqlCommand cmd = new SqlCommand(sSQL, conn);
            cmd.Parameters.Add(new SqlParameter("@AccountantID", accountantData.Rows[0]["AccountantID"]));
            cmd.Parameters.Add(new SqlParameter("@AorderPrice", float.Parse("0")));
            cmd.Parameters.Add(new SqlParameter("@AgentPayment", int.Parse("0")));   //nếu chưa thanh toán thì còn edit dc, thanh toán rồi đồng nghĩa là tạo phiếu xuất kho
            cmd.Parameters.Add(new SqlParameter("@AgentDelivery", int.Parse("0")));
            DateTime DT = DateTime.Now;
            cmd.Parameters.Add(new SqlParameter("@DateCreated", DT));
            try
            {
               cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
               throw new Exception("Error:" + ex.Message);
            }
            MessageBox.Show("Tạo Đơn Nhập Hàng Thành Công!");
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
                int AorderID = int.Parse(Convert.ToString(row.Cells[0].Value), System.Globalization.NumberStyles.Any);
                //int AgentID = int.Parse(Convert.ToString(row.Cells[1].Value), System.Globalization.NumberStyles.Any);
                int AccountantID = int.Parse(Convert.ToString(row.Cells[1].Value), System.Globalization.NumberStyles.Any);             
                String AorderPrice = Convert.ToString(row.Cells[2].Value);
                int AgentPayment = int.Parse(Convert.ToString(row.Cells[3].Value), System.Globalization.NumberStyles.Any);
                int AgentDelivery = int.Parse(Convert.ToString(row.Cells[4].Value), System.Globalization.NumberStyles.Any);
                DateTime createDate = Convert.ToDateTime(row.Cells[5].Value);

                //lấy data từ database
                SqlConnection conn = new SqlConnection(strConn);
                //conn.ConnectionString = @"Data Source=(local)\SQLEXPRESS; Initial Catalog=finalCNPM;Integrated Security=True";
                conn.Open();
                String sSQL = "SELECT * FROM Accountant WHERE AccountantID=@AccountantID";
                SqlCommand cmd = new SqlCommand(sSQL, conn);
                cmd.Parameters.Add(new SqlParameter("@AccountantID", AccountantID));
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dtAccountant = new DataTable();
                da.Fill(dtAccountant);
                if (dtAccountant.Rows.Count != 0)
                {
                    txtAccountantName.Text = dtAccountant.Rows[0]["AccountantName"].ToString();
                    txtAccountantEmail.Text = dtAccountant.Rows[0]["AccountantEmail"].ToString();
                    txtAccountantPhone.Text = dtAccountant.Rows[0]["AccountantSdt"].ToString();
                }
                else
                {
                    MessageBox.Show("No Data!");
                }
                sSQL = "SELECT * FROM Goods_Receive WHERE AorderID=@AorderID";
                cmd = new SqlCommand(sSQL, conn);
                cmd.Parameters.Add(new SqlParameter("@AorderID", AorderID));
                da = new SqlDataAdapter(cmd);
                DataTable dtAorderGoods = new DataTable();
                da.Fill(dtAorderGoods);
                if (dtAorderGoods.Rows.Count != 0)
                {
                    int totalQuantity = 0;
                    for(int i=0; i<dtAorderGoods.Rows.Count; i++)
                    {
                       totalQuantity += int.Parse(dtAorderGoods.Rows[i]["Quantity"].ToString());
                    }
                    txtTotalGoods.Text = totalQuantity.ToString();
                }
                else
                {
                    MessageBox.Show("Đơn hàng này hiện chưa có hàng hóa!");
                    txtTotalGoods.Text = "0";
                }
                
                comboBoxPayment.SelectedIndex = AgentPayment;
                comboBoxDelivery.SelectedIndex = AgentDelivery;
                txtTotalPrice.Text = AorderPrice + " VNĐ";
                txtDateCreated.Text = createDate.ToString();
                AorderIDD = AorderID;
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
            //Xóa tất cả các mặt hàng trong agent order
            String sSQL = "DELETE FROM Goods_Receive WHERE AorderID=@AorderID";
            SqlCommand cmd = new SqlCommand(sSQL, conn);
            cmd.Parameters.Add(new SqlParameter("@AorderID", AorderIDD));
            try
            {
                cmd.ExecuteNonQuery();
                //Xóa order của agent
                sSQL = "DELETE FROM GoodsReceive WHERE AorderID=@AorderID";
                cmd = new SqlCommand(sSQL, conn);
                cmd.Parameters.Add(new SqlParameter("@AorderID", AorderIDD));
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error:" + ex.Message);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error:" + ex.Message);
            }
            MessageBox.Show("Xóa đơn nhập hàng thành công!");
            dataGridView1.Refresh();
            reload();
        }

      
        private void btnUpdate_Click(object sender, EventArgs e)    //Hiện form để add thêm goods và cập nhật tình trạng thanh toán (tạo phiếu xuất kho)
        {
            frmManageGoods_Receive fag = new frmManageGoods_Receive(AorderIDD);
            fag.Show();
        }

        private void btnUpdateOrder_Click(object sender, EventArgs e)   //Cập nhật thanh toán, tình trạng vận chuyển
        {
            SqlConnection conn = new SqlConnection(strConn);
            //conn.ConnectionString = @"Data Source=(local)\SQLEXPRESS; Initial Catalog=finalCNPM;Integrated Security=True";
            conn.Open();
            String sSQL = "UPDATE GoodsReceive SET AgentPayment=@AgentPayment, AgentDelivery=@AgentDelivery WHERE AorderID=@AID";
            SqlCommand cmd = new SqlCommand(sSQL, conn);
            cmd.Parameters.Add(new SqlParameter("@AgentPayment", comboBoxPayment.SelectedIndex));
            cmd.Parameters.Add(new SqlParameter("@AgentDelivery", comboBoxDelivery.SelectedIndex));
            cmd.Parameters.Add(new SqlParameter("@AID", AorderIDD));
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error:" + ex.Message);
            }
            MessageBox.Show("Cập nhật tình trạng đơn nhập hàng thành công!");
            dataGridView1.Refresh();
            reload();
        }

        private void btnCreatebill_Click(object sender, EventArgs e)
        {
            frmCreateDelivery frmb = new frmCreateDelivery(AorderIDD);
            frmb.Show();
        }
    }
}
