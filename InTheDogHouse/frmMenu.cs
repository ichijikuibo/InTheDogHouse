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
    public partial class frmMenu : Form
    {
        frmContainer container;
        public frmMenu(frmContainer container)
        {
            this.container = container;
            InitializeComponent();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            container.changeForm(new frmCustomer(container));
        }

        private void btnKennel_Click(object sender, EventArgs e)
        {
            container.changeForm(new frmKennel(container));
        }

        private void btnDog_Click(object sender, EventArgs e)
        {
            container.changeForm(new frmDog(container));
        }

        private void btnSize_Click(object sender, EventArgs e)
        {
            container.changeForm(new frmSize(container));
        }

        private void btnBreed_Click(object sender, EventArgs e)
        {
            container.changeForm(new frmBreed(container));
        }

        private void btnBreed_Click_1(object sender, EventArgs e)
        {
            container.changeForm(new frmBooking(container));
        }
    }
}
