
namespace Lab2Login
{
    partial class frmManageOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtAgentDes = new System.Windows.Forms.Label();
            this.txtAgentAddress = new System.Windows.Forms.Label();
            this.txtAccountantName = new System.Windows.Forms.Label();
            this.txtAccountantEmail = new System.Windows.Forms.Label();
            this.txtAccountantPhone = new System.Windows.Forms.Label();
            this.txtTotalGoods = new System.Windows.Forms.Label();
            this.txtTotalPrice = new System.Windows.Forms.Label();
            this.txtDateCreated = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBoxPayment = new System.Windows.Forms.ComboBox();
            this.comboBoxDelivery = new System.Windows.Forms.ComboBox();
            this.btnUpdateOrder = new System.Windows.Forms.Button();
            this.btnCreatebill = new System.Windows.Forms.Button();
            this.comboBoxAgentName = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(351, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(640, 396);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(407, 19);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(332, 32);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Tạo Order Mới";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tên Đại Lý";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Địa chỉ đại lý";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(103, 436);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(124, 23);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Xóa Order";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(39, 349);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(253, 41);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Chỉnh Sửa Thông Tin Order";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tên kế toán";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Email kế toán";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Số điện thoại kế toán";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Tổng số lượng hàng hóa";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 223);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Tổng giá trị đơn hàng";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(36, 249);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Ngày tạo đơn hàng";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(36, 276);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Tình trạng thanh toán";
            // 
            // txtAgentDes
            // 
            this.txtAgentDes.AutoSize = true;
            this.txtAgentDes.Location = new System.Drawing.Point(168, 54);
            this.txtAgentDes.Name = "txtAgentDes";
            this.txtAgentDes.Size = new System.Drawing.Size(59, 13);
            this.txtAgentDes.TabIndex = 2;
            this.txtAgentDes.Text = "Tên Đại Lý";
            // 
            // txtAgentAddress
            // 
            this.txtAgentAddress.AutoSize = true;
            this.txtAgentAddress.Location = new System.Drawing.Point(168, 78);
            this.txtAgentAddress.Name = "txtAgentAddress";
            this.txtAgentAddress.Size = new System.Drawing.Size(59, 13);
            this.txtAgentAddress.TabIndex = 2;
            this.txtAgentAddress.Text = "Tên Đại Lý";
            // 
            // txtAccountantName
            // 
            this.txtAccountantName.AutoSize = true;
            this.txtAccountantName.Location = new System.Drawing.Point(168, 124);
            this.txtAccountantName.Name = "txtAccountantName";
            this.txtAccountantName.Size = new System.Drawing.Size(59, 13);
            this.txtAccountantName.TabIndex = 2;
            this.txtAccountantName.Text = "Tên Đại Lý";
            // 
            // txtAccountantEmail
            // 
            this.txtAccountantEmail.AutoSize = true;
            this.txtAccountantEmail.Location = new System.Drawing.Point(168, 147);
            this.txtAccountantEmail.Name = "txtAccountantEmail";
            this.txtAccountantEmail.Size = new System.Drawing.Size(59, 13);
            this.txtAccountantEmail.TabIndex = 2;
            this.txtAccountantEmail.Text = "Tên Đại Lý";
            // 
            // txtAccountantPhone
            // 
            this.txtAccountantPhone.AutoSize = true;
            this.txtAccountantPhone.Location = new System.Drawing.Point(168, 173);
            this.txtAccountantPhone.Name = "txtAccountantPhone";
            this.txtAccountantPhone.Size = new System.Drawing.Size(59, 13);
            this.txtAccountantPhone.TabIndex = 2;
            this.txtAccountantPhone.Text = "Tên Đại Lý";
            // 
            // txtTotalGoods
            // 
            this.txtTotalGoods.AutoSize = true;
            this.txtTotalGoods.Location = new System.Drawing.Point(168, 201);
            this.txtTotalGoods.Name = "txtTotalGoods";
            this.txtTotalGoods.Size = new System.Drawing.Size(16, 13);
            this.txtTotalGoods.TabIndex = 2;
            this.txtTotalGoods.Text = "...";
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.AutoSize = true;
            this.txtTotalPrice.Location = new System.Drawing.Point(168, 223);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.Size = new System.Drawing.Size(16, 13);
            this.txtTotalPrice.TabIndex = 2;
            this.txtTotalPrice.Text = "...";
            // 
            // txtDateCreated
            // 
            this.txtDateCreated.AutoSize = true;
            this.txtDateCreated.Location = new System.Drawing.Point(168, 249);
            this.txtDateCreated.Name = "txtDateCreated";
            this.txtDateCreated.Size = new System.Drawing.Size(16, 13);
            this.txtDateCreated.TabIndex = 2;
            this.txtDateCreated.Text = "...";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(36, 304);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(114, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Tình trạng vận chuyển";
            // 
            // comboBoxPayment
            // 
            this.comboBoxPayment.FormattingEnabled = true;
            this.comboBoxPayment.Items.AddRange(new object[] {
            "Chưa thanh toán",
            "Đã thanh toán"});
            this.comboBoxPayment.Location = new System.Drawing.Point(171, 276);
            this.comboBoxPayment.Name = "comboBoxPayment";
            this.comboBoxPayment.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPayment.TabIndex = 9;
            // 
            // comboBoxDelivery
            // 
            this.comboBoxDelivery.FormattingEnabled = true;
            this.comboBoxDelivery.Items.AddRange(new object[] {
            "Chưa vận chuyển",
            "Đang vận chuyển",
            "Đã vận chuyển"});
            this.comboBoxDelivery.Location = new System.Drawing.Point(171, 304);
            this.comboBoxDelivery.Name = "comboBoxDelivery";
            this.comboBoxDelivery.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDelivery.TabIndex = 9;
            // 
            // btnUpdateOrder
            // 
            this.btnUpdateOrder.Location = new System.Drawing.Point(755, 19);
            this.btnUpdateOrder.Name = "btnUpdateOrder";
            this.btnUpdateOrder.Size = new System.Drawing.Size(160, 32);
            this.btnUpdateOrder.TabIndex = 1;
            this.btnUpdateOrder.Text = "Cập Nhật Order";
            this.btnUpdateOrder.UseVisualStyleBackColor = true;
            this.btnUpdateOrder.Click += new System.EventHandler(this.btnUpdateOrder_Click);
            // 
            // btnCreatebill
            // 
            this.btnCreatebill.Location = new System.Drawing.Point(87, 396);
            this.btnCreatebill.Name = "btnCreatebill";
            this.btnCreatebill.Size = new System.Drawing.Size(162, 34);
            this.btnCreatebill.TabIndex = 10;
            this.btnCreatebill.Text = "Tạo phiếu xuất kho";
            this.btnCreatebill.UseVisualStyleBackColor = true;
            this.btnCreatebill.Click += new System.EventHandler(this.btnCreatebill_Click);
            // 
            // comboBoxAgentName
            // 
            this.comboBoxAgentName.FormattingEnabled = true;
            this.comboBoxAgentName.Location = new System.Drawing.Point(171, 26);
            this.comboBoxAgentName.Name = "comboBoxAgentName";
            this.comboBoxAgentName.Size = new System.Drawing.Size(121, 21);
            this.comboBoxAgentName.TabIndex = 11;
            this.comboBoxAgentName.SelectedIndexChanged += new System.EventHandler(this.comboBoxAgentName_SelectedIndexChanged);
            // 
            // frmManageOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 476);
            this.Controls.Add(this.comboBoxAgentName);
            this.Controls.Add(this.btnCreatebill);
            this.Controls.Add(this.comboBoxDelivery);
            this.Controls.Add(this.comboBoxPayment);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDateCreated);
            this.Controls.Add(this.txtTotalPrice);
            this.Controls.Add(this.txtTotalGoods);
            this.Controls.Add(this.txtAccountantPhone);
            this.Controls.Add(this.txtAccountantEmail);
            this.Controls.Add(this.txtAccountantName);
            this.Controls.Add(this.txtAgentAddress);
            this.Controls.Add(this.txtAgentDes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUpdateOrder);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmManageOrder";
            this.Text = "Quản Lý Đơn Hàng Từ Đại Lý";
            this.Load += new System.EventHandler(this.frmManageUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label txtAgentDes;
        private System.Windows.Forms.Label txtAgentAddress;
        private System.Windows.Forms.Label txtAccountantName;
        private System.Windows.Forms.Label txtAccountantEmail;
        private System.Windows.Forms.Label txtAccountantPhone;
        private System.Windows.Forms.Label txtTotalGoods;
        private System.Windows.Forms.Label txtTotalPrice;
        private System.Windows.Forms.Label txtDateCreated;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBoxPayment;
        private System.Windows.Forms.ComboBox comboBoxDelivery;
        private System.Windows.Forms.Button btnUpdateOrder;
        private System.Windows.Forms.Button btnCreatebill;
        private System.Windows.Forms.ComboBox comboBoxAgentName;
    }
}