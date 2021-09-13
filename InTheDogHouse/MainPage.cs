using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InTheDogHouse
{
    public partial class MainPage : Form
    {
        private int previousWidth = 0;
        public MainPage()
        {
            InitializeComponent();
        }


        private void MainPage_SizeChanged(object sender, EventArgs e)
        {
            tabDogHouse.ItemSize = new Size((tabDogHouse.Width-5) / 3, tabDogHouse.ItemSize.Height);
        }
    }
}
