using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2Login
{
    public partial class frmCreateBill : Form
    {
        int AorderID;
        public frmCreateBill(int AorderIDD)
        {
            InitializeComponent();
            AorderID = AorderIDD;
        }

        private void frmCreateBill_Load(object sender, EventArgs e)
        {
            AgentOrderContextRPT context = new AgentOrderContextRPT();
            List<AgentOrder> ListAgentOrder = context.AgentOrders.ToList();
            List<AorderGood> ListAgentOrderGoods = context.AorderGoods.ToList();
            List<AgentOrderReport> ListReport = new List<AgentOrderReport>();
            foreach (AorderGood j in ListAgentOrderGoods)
            {
                AgentOrderReport temp = new AgentOrderReport();
                if(AorderID == j.AgentOrder.AorderID)  //nếu mặt hàng này trong AgentOrder hiện tại thì show ra trong phiếu
                {
                    foreach (AgentOrder i in ListAgentOrder)
                    {
                        temp.ID = i.AorderID.ToString();
                        temp.GID = j.GID.ToString();
                        temp.GName = j.GName;
                        temp.Quantity = j.Quantity.ToString();
                        temp.TotalPrice = j.TotalPrice.ToString();
                        temp.AgentName = i.Agent.A_name;
                        temp.DateCreated = i.DateCreated.ToString();
                        temp.Price = j.Good.GPrice.ToString();
                        temp.Accountant = i.Accountant.AccountantName;
                    }
                    ListReport.Add(temp);
                }
            }
            this.reportViewer1.LocalReport.ReportPath = "rptAgentOrder.rdlc";
            var source = new ReportDataSource("AgentOrderDataset", ListReport);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(source);
            this.reportViewer1.RefreshReport();
        }
    }
}
