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
    public partial class frmLogin : Form
    {
        String strConn = ConfigurationManager.ConnectionStrings["MyConn"].ConnectionString;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(strConn);
            //conn.ConnectionString = @"Data Source=(local)\SQLEXPRESS; Initial Catalog=finalCNPM;Integrated Security=True";
            conn.Open();
            String sSQL = "SELECT AccountantID, AgentID FROM Account WHERE " +
            "AccountName='" + txtUserID.Text + "' and AccountPassword='" + txtPassword.Text + "'";
            SqlCommand cmd = new SqlCommand(sSQL, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Login Successful!");
                MainForm mf = new MainForm(dt);
                mf.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Login. Please check userID or Password!");
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
