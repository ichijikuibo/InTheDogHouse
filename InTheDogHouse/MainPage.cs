using InTheDogHouse.Models;
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
        protected CustomerModel dataModel;
        //protected List<CustomerModel> customers;
        private BindingSource customers = new BindingSource();
        public MainPage()
        {
            InitializeComponent();
            customers = new BindingSource();
            customers.Add(new CustomerModel(0,"Mr","Canavan","Colm","41 Great James Street","Derry","Londonderry","BT48 7DF","1234567890") );
            customers.Add(new CustomerModel(1, "Mr", "Noone", "Colm", "Nowhere", "Derry", "Londonderry", "N/A", "1234567890"));
            customerModelBindingSource.DataSource = customers;
        }


        private void MainPage_SizeChanged(object sender, EventArgs e)
        {
            tabDogHouse.ItemSize = new Size((tabDogHouse.Width-5) / 3, tabDogHouse.ItemSize.Height);
        }

        private void MainPage_Load(object sender, EventArgs e)
        {

        }

        private void btnAddAdd_Click(object sender, EventArgs e)
        {
            tabDogHouse.SelectedIndex = 0;
        }

        private void btnDisplayAdd_Click(object sender, EventArgs e)
        {
            customerModelBindingSource.Add(new CustomerModel(customers.Count));

            customerModelBindingSource.MoveLast();
            tabDogHouse.SelectedIndex = 1;
        }

        private void btnAddCancel_Click(object sender, EventArgs e)
        {
            customerModelBindingSource.RemoveCurrent();
            tabDogHouse.SelectedIndex = 0;
        }

        private void btnEditEdit_Click(object sender, EventArgs e)
        {
            tabDogHouse.SelectedIndex = 0;
        }

        private void btnEditCancel_Click(object sender, EventArgs e)
        {
            customerModelBindingSource.ResetCurrentItem();
            tabDogHouse.SelectedIndex = 0;
        }

        private void btnDisplayEdit_Click(object sender, EventArgs e)
        {
            tabDogHouse.SelectedIndex = 2;
        }

        private void btnDisplayDelete_Click(object sender, EventArgs e)
        {
            customerModelBindingSource.RemoveCurrent();
        }

        private void btnDisplayExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
