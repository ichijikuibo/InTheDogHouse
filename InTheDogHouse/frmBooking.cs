using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    public partial class frmBooking : Form
    {
        SqlDataAdapter daCustomer, daDog, daKennel;
        DataSet dsInTheDogHouse = new DataSet();
        SqlCommandBuilder sqlBCustomer;
        string sqlCustomer, sqlDog, sqlKennel;
        int selectedTab = 0;
        bool custSelected = false;
        int custNoSelected = 0;
        frmContainer container;

        public frmBooking(frmContainer container)
        {
            this.container = container;
            InitializeComponent();
        }

        private void frmBooking_Load(object sender, EventArgs e)
        {

            sqlCustomer = @"select * from Customer";
            daCustomer = new SqlDataAdapter(sqlCustomer, container.connStr);
            daCustomer.FillSchema(dsInTheDogHouse, SchemaType.Source, "Customer");
            daCustomer.Fill(dsInTheDogHouse, "Customer");


            sqlDog = @"select * from Dog";
            daDog = new SqlDataAdapter(sqlDog, container.connStr);
            daDog.FillSchema(dsInTheDogHouse, SchemaType.Source, "Dog");
            daDog.Fill(dsInTheDogHouse, "Dog");

            sqlKennel = @"select * from Kennel";
            daKennel = new SqlDataAdapter(sqlKennel, container.connStr);
            daKennel.FillSchema(dsInTheDogHouse, SchemaType.Source, "Kennel");
            daKennel.Fill(dsInTheDogHouse, "Kennel");


            dsInTheDogHouse.Tables["Customer"].Columns.Add("ComboDisplay", typeof(string), "CustomerNo + ' - ' + Forename + ' ' + Surname");
            dsInTheDogHouse.Tables["Kennel"].Columns.Add("ComboDisplay", typeof(string), "KennelNo + ' - ' + SizeK");
            dsInTheDogHouse.Tables["Dog"].Columns.Add("ComboDisplay", typeof(string), "DogNo + ' - ' + Name");

            lstCustomer.DisplayMember = "ComboDisplay";
            lstCustomer.ValueMember = "CustomerNo";
            lstCustomer.DataSource = dsInTheDogHouse.Tables["Customer"].DefaultView;

        }
        private void txtCustomer_TextChanged(object sender, EventArgs e)
        {

            dsInTheDogHouse.Tables["Customer"].DefaultView.RowFilter = "ComboDisplay LIKE '%" + txtCustomer.Text + "%'";
            lstCustomer.SelectedIndex = 0;
            updateDogList();
        }

        private void txtDog_TextChanged(object sender, EventArgs e)
        {
            dsInTheDogHouse.Tables["Dog"].DefaultView.RowFilter = "ComboDisplay LIKE '%" + txtDog.Text + "%'";
            lstCustomer.SelectedIndex = 0;
            updateKennelList();
        }

        private void btnNewDog_Click(object sender, EventArgs e)
        {

        }

        private void lstCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateDogList();
        }
        private void updateDogList()
        {
            if (lstDog.DataSource == null)
            {
                lstDog.DisplayMember = "ComboDisplay";
                lstDog.ValueMember = "DogNo";
                lstDog.DataSource = dsInTheDogHouse.Tables["Dog"].DefaultView;
            }
            if (lstCustomer.SelectedIndex > -1)
            {
                dsInTheDogHouse.Tables["Dog"].DefaultView.RowFilter = "CustomerNo = " + lstCustomer.SelectedValue;
            }
            else
            {
                lstDog.DataSource = null;
            }
        }
        private void updateKennelList()
        {
            if (lstDog.DataSource == null)
            {
                lstKennel.DisplayMember = "ComboDisplay";
                lstKennel.ValueMember = "KennelNo";
                lstKennel.DataSource = dsInTheDogHouse.Tables["Kennel"].DefaultView;
            }
            if (lstCustomer.SelectedIndex > -1)
            {
                dsInTheDogHouse.Tables["Dog"].DefaultView.RowFilter = "CustomerNo = " + lstCustomer.SelectedValue;
            }
            else
            {
                lstDog.DataSource = null;
            }
        }


        private void btnNew_Click(object sender, EventArgs e)
        {
            frmCustomer customer = new frmCustomer(container, 1);
            customer.FormClosed += Customer_FormClosed;
            container.changeForm(customer);
        }

        private void Customer_FormClosed(object sender, FormClosedEventArgs e)
        {
            dsInTheDogHouse.Tables["Customer"].Clear();
            daCustomer.Fill(dsInTheDogHouse, "Customer");





            //lstCustomer.DisplayMember = "ComboDisplay";
            //lstCustomer.ValueMember = "CustomerNo";
            //lstCustomer.DataSource = dsInTheDogHouse.Tables["Customer"].DefaultView;
        }
    }
}
