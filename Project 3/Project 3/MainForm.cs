using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Drawing.Text;
using System.Globalization;

namespace Project_3
{
    
    public partial class MainForm : Form
    {
        private List<Order> orderList = new List<Order>();
        public List<Order> OrderList { get => orderList; set => orderList = value; }
        public int nextOrderNum = 1;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            { 
                FileStream inFile = new FileStream("orders.ser",
                        FileMode.Open, FileAccess.Read);
                BinaryFormatter bFormatter = new BinaryFormatter();

                while (inFile.Position < inFile.Length)
                {
                    Order order = (Order)bFormatter.Deserialize(inFile);
                    OrderList.Add(order);
                }
                inFile.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("There was a problem opening the file or no orders have been previously saved.", caption: "error");
            }

            if (OrderList == null || OrderList.Count == 0)
            {
                txbOrderNum.Text = nextOrderNum.ToString();
            }
            else
            {
                nextOrderNum = OrderList[OrderList.Count - 1].OrderNum + 1;
                txbOrderNum.Text = nextOrderNum.ToString();
            }
            dtpOrderDate.Value = DateTime.Now;
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (OrderList != null)
            {
                try
                {
                    FileStream outFile = new FileStream("orders.ser",
                         FileMode.Create, FileAccess.Write);
                    BinaryFormatter bf = new BinaryFormatter();

                    foreach (var item in OrderList)
                    {
                        bf.Serialize(outFile, item);
                    }
                    outFile.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error writing list to file " + ex.Message, caption: "error");
                }
            }
                
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string newName = txbName.Text;
                string newPhone = txbPhone.Text;
                char newCookieType = Convert.ToChar(txbCookie.Text.ToUpper());
                int newQuantity = Convert.ToInt32(txbQuantity.Text);
                DateTime newOrderDate = dtpOrderDate.Value;
                DateTime newDeliveryDate = dtpDeliveryDate.Value;

                if ((!(newCookieType.Equals('S'))) && (!(newCookieType.Equals('C'))) && (!(newCookieType.Equals('O'))))
                {
                    throw new InvalidCookieTypeException();
                }

                OrderList.Add(new Order(nextOrderNum, newName, newPhone, newCookieType, newQuantity, newOrderDate, newDeliveryDate));
                
                txbOrderNum.Text = (nextOrderNum += 1).ToString();
                txbName.Clear();
                txbPhone.Clear();
                txbCookie.Clear();
                txbQuantity.Clear();
                dtpDeliveryDate.Value = DateTime.Now;
            }
            catch (InvalidCookieTypeException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (FormatException)
            {
               MessageBox.Show("Input was incorrectly formatted", caption: "error"); 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, caption: "error");
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            Display display = new Display();
            display.OrderList = OrderList;
            display.ShowDialog();
        }
    }
}
