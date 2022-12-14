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
    public partial class MainForm : Form
    {
        DataTable accountantData;
        DataTable agentData;
        String strConn = ConfigurationManager.ConnectionStrings["MyConn"].ConnectionString;
        public MainForm(DataTable dtAccount)
        {
            SqlConnection conn = new SqlConnection(strConn);
            //conn.ConnectionString = @"Data Source=(local)\SQLEXPRESS; Initial Catalog=finalCNPM;Integrated Security=True";
            conn.Open();
            String sSQL = "SELECT * FROM Accountant WHERE " +
            "AccountantID='" + dtAccount.Rows[0]["AccountantID"].ToString() + "'";  //khi login thành công thì chỉ có 1 accountant duy nhất nên chỉ có 1 row là row[0], trong row[0] sẽ có accountantID và AgentID
            SqlCommand cmd = new SqlCommand(sSQL, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            accountantData = new DataTable();
            da.Fill(accountantData);
            if (accountantData.Rows.Count != 0)
            {
                MessageBox.Show("Welcome "+accountantData.Rows[0]["AccountantName"]);
            }
            else
            {
                MessageBox.Show("Invalid Accountant. Please check!");
                this.Close();
            }
            //lấy thông tin Agent
            sSQL = "SELECT * FROM Agent WHERE " +
            "AID='" + dtAccount.Rows[0]["AgentID"].ToString() + "'";  //khi login thành công thì chỉ có 1 accountant duy nhất nên chỉ có 1 row là row[0], trong row[0] sẽ có accountantID và AgentID
            cmd = new SqlCommand(sSQL, conn);
            da = new SqlDataAdapter(cmd);
            agentData = new DataTable();
            da.Fill(agentData);
            if (agentData.Rows.Count != 0)
            {
                MessageBox.Show("Welcome " + agentData.Rows[0]["A_name"]);
            }
            else
            {
                MessageBox.Show("Invalid Agent. Please check!");
                this.Close();
            }
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //frmLogin f = new frmLogin();
            //f.ShowDialog();
        }

        private void manageUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageUsers f = new frmManageUsers();
            f.MdiParent = this;
            f.Show();
        }

        private void manageOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageOrder f = new frmManageOrder(accountantData, agentData);
            f.MdiParent = this;
            f.Show();
        }

        private void titleVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void titleHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmLogin f = new frmLogin();
            f.Show();
        }

        private void manageAgentReceiveAndCreateReceiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageReceive frmmgr = new frmManageReceive(accountantData, agentData);
            frmmgr.MdiParent = this;
            frmmgr.Show();
        }

        private void thốngKêDoanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Doanhthutheothang frmDT = new Doanhthutheothang();
            frmDT.Show();
        }
    }
}
