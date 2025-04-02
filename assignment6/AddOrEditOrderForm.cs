using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderManagementWinForm
{
    public partial class AddOrEditOrderForm : Form
    {
        public Order Order { get; private set; }
        private BindingSource orderDetailsBindingSource;

        public AddOrEditOrderForm(Order existingOrder)
        {
            InitializeComponent();
            orderDetailsBindingSource = new BindingSource();

            // 设置窗口样式
            this.BackColor = Color.LightBlue;
            this.Font = new Font("微软雅黑", 10);

            if (existingOrder != null)
            {
                Order = existingOrder;
                textBoxOrderId.Text = existingOrder.OrderId.ToString();
                textBoxCustomer.Text = existingOrder.Customer;
                orderDetailsBindingSource.DataSource = existingOrder.OrderDetails;
            }
            else
            {
                Order = new Order(0, "", new List<OrderDetails>());
                textBoxOrderId.Text = "";
                textBoxCustomer.Text = "";
                orderDetailsBindingSource.DataSource = Order.OrderDetails;
            }

            dataGridViewOrderDetails.DataSource = orderDetailsBindingSource;

            // 设置输入框提示文本
            textBoxOrderId.ForeColor = Color.Gray;
            textBoxOrderId.Text = "请输入订单号";
            textBoxCustomer.ForeColor = Color.Gray;
            textBoxCustomer.Text = "请输入客户名称";
            textBoxDetailId.ForeColor = Color.Gray;
            textBoxDetailId.Text = "请输入明细ID";
            textBoxProductName.ForeColor = Color.Gray;
            textBoxProductName.Text = "请输入商品名称";
            textBoxPrice.ForeColor = Color.Gray;
            textBoxPrice.Text = "请输入商品价格";
            textBoxQuantity.ForeColor = Color.Gray;
            textBoxQuantity.Text = "请输入商品数量";

            // 为输入框添加焦点事件处理程序
            textBoxOrderId.GotFocus += TextBox_GotFocus;
            textBoxOrderId.LostFocus += TextBox_LostFocus;
            textBoxCustomer.GotFocus += TextBox_GotFocus;
            textBoxCustomer.LostFocus += TextBox_LostFocus;
            textBoxDetailId.GotFocus += TextBox_GotFocus;
            textBoxDetailId.LostFocus += TextBox_LostFocus;
            textBoxProductName.GotFocus += TextBox_GotFocus;
            textBoxProductName.LostFocus += TextBox_LostFocus;
            textBoxPrice.GotFocus += TextBox_GotFocus;
            textBoxPrice.LostFocus += TextBox_LostFocus;
            textBoxQuantity.GotFocus += TextBox_GotFocus;
            textBoxQuantity.LostFocus += TextBox_LostFocus;

            // 添加标题和说明
            Label titleLabel = new Label();
            titleLabel.Text = "订单信息管理";
            titleLabel.Font = new Font("微软雅黑", 16, FontStyle.Bold);
            titleLabel.ForeColor = Color.DarkBlue;
            titleLabel.Location = new Point(10, 10);
            this.Controls.Add(titleLabel);

            Label infoLabel = new Label();
            infoLabel.Text = "请输入或修改订单及明细信息，完成后点击保存。";
            infoLabel.Location = new Point(10, 40);
            this.Controls.Add(infoLabel);
        }

        private void btnAddDetail_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxDetailId.Text, out int detailId) &&
                double.TryParse(textBoxPrice.Text, out double price) &&
                int.TryParse(textBoxQuantity.Text, out int quantity))
            {
                string productName = textBoxProductName.Text;
                var newDetail = new OrderDetails(detailId, productName, price, quantity);
                ((List<OrderDetails>)orderDetailsBindingSource.DataSource).Add(newDetail);
                orderDetailsBindingSource.ResetBindings(false);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxOrderId.Text, out int orderId))
            {
                string customer = textBoxCustomer.Text;
                Order.OrderId = orderId;
                Order.Customer = customer;
                Order.OrderDetails = (List<OrderDetails>)orderDetailsBindingSource.DataSource;
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void AddOrEditOrderForm_Load(object sender, EventArgs e)
        {
            // 可以在这里添加一些初始化代码
        }

        private void TextBox_GotFocus(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (textBox.ForeColor == Color.Gray)
            {
                textBox.Text = "";
                textBox.ForeColor = Color.Black;
            }
        }

        private void TextBox_LostFocus(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (string.IsNullOrEmpty(textBox.Text))
            {
                switch (textBox.Name)
                {
                    case "textBoxOrderId":
                        textBox.Text = "请输入订单号";
                        break;
                    case "textBoxCustomer":
                        textBox.Text = "请输入客户名称";
                        break;
                    case "textBoxDetailId":
                        textBox.Text = "请输入明细ID";
                        break;
                    case "textBoxProductName":
                        textBox.Text = "请输入商品名称";
                        break;
                    case "textBoxPrice":
                        textBox.Text = "请输入商品价格";
                        break;
                    case "textBoxQuantity":
                        textBox.Text = "请输入商品数量";
                        break;
                }
                textBox.ForeColor = Color.Gray;
            }
        }
    }
}