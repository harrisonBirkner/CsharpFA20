using System;
using System.Windows.Forms;
using GamesClasses;

namespace UsingGameClassLibrary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Game g = new Game();
        }
    }
}
