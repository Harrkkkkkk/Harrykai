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
    public partial class Form1 : Form
    {
        private OrderService orderService;
        private BindingSource orderBindingSource;

        public Form1()
        {
            InitializeComponent();
            orderService = new OrderService();
            orderBindingSource = new BindingSource();
            orderBindingSource.DataSource = orderService.GetAllOrders();
            dataGridView1.DataSource = orderBindingSource;
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            using (var addOrderForm = new AddOrEditOrderForm(null))
            {
                if (addOrderForm.ShowDialog() == DialogResult.OK)
                {
                    orderService.AddOrder(addOrderForm.Order);
                    orderBindingSource.DataSource = orderService.GetAllOrders();
                }
            }
        }

        private void btnDeleteOrder_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedOrder = (Order)dataGridView1.SelectedRows[0].DataBoundItem;
                try
                {
                    orderService.DeleteOrder(selectedOrder.OrderId);
                    orderBindingSource.DataSource = orderService.GetAllOrders();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnEditOrder_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedOrder = (Order)dataGridView1.SelectedRows[0].DataBoundItem;
                using (var editOrderForm = new AddOrEditOrderForm(selectedOrder))
                {
                    if (editOrderForm.ShowDialog() == DialogResult.OK)
                    {
                        orderService.UpdateOrder(editOrderForm.Order);
                        orderBindingSource.DataSource = orderService.GetAllOrders();
                    }
                }
            }
        }

        private void btnQueryOrder_Click(object sender, EventArgs e)
        {
            string queryType = comboBoxQueryType.SelectedItem.ToString();
            string queryValue = textBoxQueryValue.Text;

            List<Order> queryResult = new List<Order>();
            switch (queryType)
            {
                case "按订单号查询":
                    if (int.TryParse(queryValue, out int orderId))
                    {
                        queryResult = orderService.QueryByOrderId(orderId);
                    }
                    break;
                case "按商品名称查询":
                    queryResult = orderService.QueryByProductName(queryValue);
                    break;
                case "按客户查询":
                    queryResult = orderService.QueryByCustomer(queryValue);
                    break;
                case "按订单金额查询":
                    if (double.TryParse(queryValue, out double amount))
                    {
                        queryResult = orderService.QueryByTotalAmount(amount);
                    }
                    break;
            }

            orderBindingSource.DataSource = queryResult;
        }
    }
}