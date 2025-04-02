namespace OrderManagementWinForm
{
    partial class AddOrEditOrderForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBoxOrderId = new System.Windows.Forms.TextBox();
            this.textBoxCustomer = new System.Windows.Forms.TextBox();
            this.dataGridViewOrderDetails = new System.Windows.Forms.DataGridView();
            this.textBoxDetailId = new System.Windows.Forms.TextBox();
            this.textBoxProductName = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.btnAddDetail = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxOrderId
            // 
            this.textBoxOrderId.Location = new System.Drawing.Point(12, 70);
            this.textBoxOrderId.Name = "textBoxOrderId";
            this.textBoxOrderId.Size = new System.Drawing.Size(200, 23);
            this.textBoxOrderId.TabIndex = 0;
            this.textBoxOrderId.Text = "请输入订单号";
            this.textBoxOrderId.ForeColor = System.Drawing.Color.Gray;
            this.textBoxOrderId.GotFocus += new System.EventHandler(this.TextBox_GotFocus);
            this.textBoxOrderId.LostFocus += new System.EventHandler(this.TextBox_LostFocus);
            // 
            // textBoxCustomer
            // 
            this.textBoxCustomer.Location = new System.Drawing.Point(12, 100);
            this.textBoxCustomer.Name = "textBoxCustomer";
            this.textBoxCustomer.Size = new System.Drawing.Size(200, 23);
            this.textBoxCustomer.TabIndex = 1;
            this.textBoxCustomer.Text = "请输入客户名称";
            this.textBoxCustomer.ForeColor = System.Drawing.Color.Gray;
            this.textBoxCustomer.GotFocus += new System.EventHandler(this.TextBox_GotFocus);
            this.textBoxCustomer.LostFocus += new System.EventHandler(this.TextBox_LostFocus);
            // 
            // dataGridViewOrderDetails
            // 
            this.dataGridViewOrderDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrderDetails.Location = new System.Drawing.Point(12, 130);
            this.dataGridViewOrderDetails.Name = "dataGridViewOrderDetails";
            this.dataGridViewOrderDetails.Size = new System.Drawing.Size(600, 200);
            this.dataGridViewOrderDetails.TabIndex = 2;
            // 
            // textBoxDetailId
            // 
            this.textBoxDetailId.Location = new System.Drawing.Point(12, 340);
            this.textBoxDetailId.Name = "textBoxDetailId";
            this.textBoxDetailId.Size = new System.Drawing.Size(100, 23);
            this.textBoxDetailId.TabIndex = 3;
            this.textBoxDetailId.Text = "请输入明细ID";
            this.textBoxDetailId.ForeColor = System.Drawing.Color.Gray;
            this.textBoxDetailId.GotFocus += new System.EventHandler(this.TextBox_GotFocus);
            this.textBoxDetailId.LostFocus += new System.EventHandler(this.TextBox_LostFocus);
            // 
            // textBoxProductName
            // 
            this.textBoxProductName.Location = new System.Drawing.Point(120, 340);
            this.textBoxProductName.Name = "textBoxProductName";
            this.textBoxProductName.Size = new System.Drawing.Size(100, 23);
            this.textBoxProductName.TabIndex = 4;
            this.textBoxProductName.Text = "请输入商品名称";
            this.textBoxProductName.ForeColor = System.Drawing.Color.Gray;
            this.textBoxProductName.GotFocus += new System.EventHandler(this.TextBox_GotFocus);
            this.textBoxProductName.LostFocus += new System.EventHandler(this.TextBox_LostFocus);
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(228, 340);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(100, 23);
            this.textBoxPrice.TabIndex = 5;
            this.textBoxPrice.Text = "请输入商品价格";
            this.textBoxPrice.ForeColor = System.Drawing.Color.Gray;
            this.textBoxPrice.GotFocus += new System.EventHandler(this.TextBox_GotFocus);
            this.textBoxPrice.LostFocus += new System.EventHandler(this.TextBox_LostFocus);
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Location = new System.Drawing.Point(336, 340);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(100, 23);
            this.textBoxQuantity.TabIndex = 6;
            this.textBoxQuantity.Text = "请输入商品数量";
            this.textBoxQuantity.ForeColor = System.Drawing.Color.Gray;
            this.textBoxQuantity.GotFocus += new System.EventHandler(this.TextBox_GotFocus);
            this.textBoxQuantity.LostFocus += new System.EventHandler(this.TextBox_LostFocus);
            // 
            // btnAddDetail
            // 
            this.btnAddDetail.Location = new System.Drawing.Point(444, 340);
            this.btnAddDetail.Name = "btnAddDetail";
            this.btnAddDetail.Size = new System.Drawing.Size(75, 23);
            this.btnAddDetail.TabIndex = 7;
            this.btnAddDetail.Text = "添加明细";
            this.btnAddDetail.UseVisualStyleBackColor = true;
            this.btnAddDetail.Click += new System.EventHandler(this.btnAddDetail_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(525, 340);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // AddOrEditOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 375);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAddDetail);
            this.Controls.Add(this.textBoxQuantity);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxProductName);
            this.Controls.Add(this.textBoxDetailId);
            this.Controls.Add(this.dataGridViewOrderDetails);
            this.Controls.Add(this.textBoxCustomer);
            this.Controls.Add(this.textBoxOrderId);
            this.Name = "AddOrEditOrderForm";
            this.Text = "添加或编辑订单";
            this.Load += new System.EventHandler(this.AddOrEditOrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxOrderId;
        private System.Windows.Forms.TextBox textBoxCustomer;
        private System.Windows.Forms.DataGridView dataGridViewOrderDetails;
        private System.Windows.Forms.TextBox textBoxDetailId;
        private System.Windows.Forms.TextBox textBoxProductName;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.Button btnAddDetail;
        private System.Windows.Forms.Button btnSave;
    }
}