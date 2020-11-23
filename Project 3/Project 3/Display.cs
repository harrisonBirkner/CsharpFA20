using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_3
{
    public partial class Display : Form
    {
        private List<Order> orderList = new List<Order>();
        public List<Order> OrderList { get => orderList; set => orderList = value; }
        public Display()
        {
            InitializeComponent();
        }

        private void Display_Load(object sender, EventArgs e)
        {
            OrderList.Sort();
            foreach (Order order in OrderList)
                {
                    txbDisplay.AppendText(String.Format("{0}  {1}  {2}  {3}  {4}  {5}  {6} \r\n", order.OrderNum, order.CustomerName, 
                        order.PhoneNumber, order.CookieType, order.Quantity, order.OrderDate.Date.ToShortDateString(), order.DeliveryDate.Date.ToShortDateString()));
            }
        }
    }
}
