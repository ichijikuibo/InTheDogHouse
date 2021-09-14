using InTheDogHouse.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        private BindingSource customers = new BindingSource();

        SqlDataAdapter daCustomer;
        DataSet dsInTheDogHouse = new DataSet();
        SqlCommandBuilder cmdBCustomer;
        DataRow drCustomer;
        string connStr, sqlCustomer;
        int selectedTab = 0;
        bool custSelected = false;
        int custNoSelected = 0;

        public MainPage()
        {
            InitializeComponent();
            customers = new BindingSource();
            customers.Add(new CustomerModel(0,"Mr","Canavan","Colm","41 Great James Street","Derry","Londonderry","BT48 7DF","1234567890") );
            customers.Add(new CustomerModel(1, "Mr", "Noone", "Colm", "Nowhere", "Derry", "Londonderry", "N/A", "1234567890"));
            //customerModelBindingSource.DataSource = customers;
            
        }


        private void MainPage_SizeChanged(object sender, EventArgs e)
        {
            tabDogHouse.ItemSize = new Size((tabDogHouse.Width-5) / 3, tabDogHouse.ItemSize.Height);
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            connStr = @"Data Source = .; Initial Catalog = InTheDogHouse; Integrated Security = true";
            sqlCustomer = @"select * from Customer";
            daCustomer = new SqlDataAdapter(sqlCustomer, connStr);
            cmdBCustomer = new SqlCommandBuilder(daCustomer);
            daCustomer.FillSchema(dsInTheDogHouse, SchemaType.Source, "Customer");
            daCustomer.Fill(dsInTheDogHouse, "Customer");

            customerModelBindingSource.DataSource = dsInTheDogHouse.Tables["Customer"];
            dgvDisplay.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            //tabDogHouse.SelectedIndex = 1;
            tabDogHouse.SelectedIndex = 0;
            //dgvDisplay.DataSource = dsInTheDogHouse.Tables["Customer"];
        }

        private void btnAddAdd_Click(object sender, EventArgs e)
        {
            DataRowView customer = customerModelBindingSource.Current as DataRowView;
            dsInTheDogHouse.Tables["Customer"].Rows.Add(customer.Row.ItemArray);
            daCustomer.Update(dsInTheDogHouse, "Customer");
            tabDogHouse.SelectedIndex = 0;
        }

        private void btnDisplayAdd_Click(object sender, EventArgs e)
        {

            customerModelBindingSource.AddNew();
            
            customerModelBindingSource.MoveLast();
            DataRowView customer = customerModelBindingSource.Current as DataRowView;
            customer[0] = 1233242;
            customer[1] = "Mr";
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
