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
    public partial class frmCreateDelivery : Form
    {
        int AorderID;
        public frmCreateDelivery(int AorderIDD)
        {
            InitializeComponent();
            AorderID = AorderIDD;
        }

        private void frmCreateBill_Load(object sender, EventArgs e)
        {
            AgentOrderContextRPT context = new AgentOrderContextRPT();
            List<GoodsReceive> ListAgentOrder = context.GoodsReceives.ToList();
            List<Goods_Receive> ListAgentOrderGoods = context.Goods_Receive.ToList();
            List<AgentOrderReport> ListReport = new List<AgentOrderReport>();
            foreach (Goods_Receive j in ListAgentOrderGoods)
            {
                AgentOrderReport temp = new AgentOrderReport();
                if (AorderID == j.GoodsReceive.AorderID)  //nếu mặt hàng này trong AgentOrder hiện tại thì show ra trong phiếu
                {
                    foreach (GoodsReceive i in ListAgentOrder)
                    {
                        temp.ID = i.AorderID.ToString();
                        temp.GID = j.GID.ToString();
                        temp.GName = j.GName;
                        temp.Quantity = j.Quantity.ToString();
                        temp.TotalPrice = j.TotalPrice.ToString();
                        temp.DateCreated = i.DateCreated.ToString();
                        temp.Price = j.Good.GPrice.ToString();
                        temp.Accountant = i.Accountant.AccountantName;
                    }
                    ListReport.Add(temp);
                }
            }
            this.reportViewer1.LocalReport.ReportPath = "rptGoodsDelivery.rdlc";
            var source = new ReportDataSource("AgentOrderDataset", ListReport);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(source);
            this.reportViewer1.RefreshReport();
        }
    }
}
