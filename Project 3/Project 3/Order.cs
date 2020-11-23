using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_3
{
    [Serializable]
    public class Order : IComparable
    {
        private int orderNum;
        private string customerName;
        private string phoneNumber;
        private char cookieType;
        private int quantity;
        private DateTime orderDate;
        private DateTime deliveryDate;

        public int OrderNum { get => orderNum; set => orderNum = value; }
        public string CustomerName
        {
            get
            {
                return customerName;
            }
            set
            {
                if (value.Trim().Length > 0)
                {
                    customerName = value;
                }
                else
                {
                    throw new Exception("Customer Name field is empty");
                }
            }
        }
        public string PhoneNumber
        {
            get
            {
                return phoneNumber;
            }
            set
            {
                if (value.Trim().Length > 0)
                {
                    phoneNumber = value;
                }
                else
                {
                    throw new Exception("Phone Number field is empty");
                }
            }
        }
        public char CookieType { get => cookieType; set => cookieType = value; }
        public int Quantity
        {
            get
            {
                return quantity;
            }
            set
            {
                if (value > 0)
                {
                    quantity = value;
                }
                else
                {
                    throw new Exception("Quantity must be greater than zero");
                }
            }
        }
        public DateTime OrderDate { get => orderDate; set => orderDate = value; }
        public DateTime DeliveryDate { get => deliveryDate; set => deliveryDate = value; }

        public Order(int orderNum, string customerName, string phoneNumber, char cookieType, int quantity, DateTime orderDate, DateTime deliveryDate)
        {
            OrderNum = orderNum;
            CustomerName = customerName;
            PhoneNumber = phoneNumber;
            CookieType = cookieType;
            Quantity = quantity;
            OrderDate = orderDate;
            DeliveryDate = deliveryDate;
        }

        public int CompareTo(object obj)
        {
            Order temp = (Order)obj;

            if (this.DeliveryDate > temp.DeliveryDate)
            {
                return 1;
            }
            else if (this.DeliveryDate < temp.DeliveryDate)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
