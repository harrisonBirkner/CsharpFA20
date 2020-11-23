using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListExample

{
    public partial class LaptopForm : Form
    {
        public static List<Laptop> laptopList = new List<Laptop>();
        public LaptopForm()
        {
            InitializeComponent();
        }
    }
}
