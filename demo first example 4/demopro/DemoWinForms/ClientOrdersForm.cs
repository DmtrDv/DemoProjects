using DemoLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoProject
{
    public partial class ClientOrdersForm: Form
    {
        private User currentUser_ = null;
       
        public ClientOrdersForm(User user)
        {
            InitializeComponent();
            currentUser_ = user;

        }

        private bool isLowRoleUser()
        {
            /// currentUser_ == null - это гость
            return currentUser_.Role == UserRole.Manager;
        }
        public void AddAndRemoveOrders(Client obj)
        {
            if (obj == null)
            {
                return;
            }

            if (isLowRoleUser())
            {
                MessageBox.Show("У Вас не хватает прав, чтобы посмотреть заказы.\n" +
                                "Обратитесь, пожалуйста, к администратору",
                                "Сообщение",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
            else
            {
                ClientOrdersForm ordersForm = new ClientOrdersForm(currentUser_);
                ordersForm.Text = "Заказы клиента " + obj.Name;
                ordersForm.SetOrder(obj.order);
                ordersForm.ShowDialog();
            }
        }
        private void ClientOrdersForm_Load(object sender, EventArgs e)
        {
            
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (isLowRoleUser())
            {
                MessageBox.Show("У Вас не хватает прав, чтобы добавить заказы.\n" +
                                "Обратитесь, пожалуйста, к администратору",
                                "Сообщение",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (isLowRoleUser())
            {
                MessageBox.Show("У Вас не хватает прав, чтобы удалить заказы.\n" +
                                "Обратитесь, пожалуйста, к администратору",
                                "Сообщение",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
        }
        public void SetOrder(Order order)
        {
            /// Д.З. Сделать масштабирование колонок таблицы по размеру окна
            /// Добавить строку Итого
            /// По цене: средняя цена, по стоимости - общая сумма, остальные - прочерки

            OrdersTable.DataSource = null;
            List<OrderRecord> records = order.GetRecords();

            List<OrderRecord> FinishRecords = new List<OrderRecord>();

            if (records.Count > 0)
            {
                double totalCost = records.Sum(r => r.Cost);
                double averagePrice = records.Average(r => r.Price);

                FinishRecords.AddRange(records);

                OrderRecord orderRecord = new OrderRecord();
                orderRecord.NameProduct = "Итого";                
                orderRecord.Price = averagePrice;                
                orderRecord.Cost = totalCost;

                FinishRecords.Add(orderRecord);             
            }

            OrdersTable.DataSource = FinishRecords;
        }
    }    
}
