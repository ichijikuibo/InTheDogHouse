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
    public partial class frmBooking2 : Form
    {
        SqlDataAdapter daCustomer, daDog, daKennels, daBookedKennels, daBooking, daBookingDet;
        DataSet dsInTheDogHouse = new DataSet();
        SqlCommandBuilder cmdBBookedKennels, cmdBBooking, cmdBBookingDet;
        SqlCommand cmdKennelDetails;
        string sqlCustomer, sqlDog, sqlKennel, sqlKennelDetails, sqlBookedKennels, sqlBooking, sqlBookingDet;
        int selectedTab = 0;
        bool custSelected = false;
        int custNoSelected = 0;
        SqlConnection conn;
        frmContainer container;
        DataRow drCustomer;
        public frmBooking2(frmContainer container)
        {
            InitializeComponent();
            this.container = container;
        }

        private void frmBooking2_Load(object sender, EventArgs e)
        {
            lblBookingRange.Text = DateTime.Now.ToShortDateString();
            dtpStartDate.MinDate = DateTime.Now;
            conn = new SqlConnection(container.connStr);
            sqlCustomer = @"select * from Customer";
            daCustomer = new SqlDataAdapter(sqlCustomer, conn);
            daCustomer.FillSchema(dsInTheDogHouse, SchemaType.Source, "Customer");
            daCustomer.Fill(dsInTheDogHouse, "Customer");


            //sqlDog = @"select * from Dog";
            //daDog = new SqlDataAdapter(sqlDog, conn);
            //daDog.FillSchema(dsInTheDogHouse, SchemaType.Source, "Dog");
            //daDog.Fill(dsInTheDogHouse, "Dog");
            //dsInTheDogHouse.Tables["Dog"].Columns.Add("ComboDisplay", typeof(string), "DogNo + ' - ' + Name");



            dsInTheDogHouse.Tables["Customer"].Columns.Add("ComboDisplay", typeof(string), "CustomerNo + ' - ' + Forename + ' ' + Surname");

            lstCustomer.DisplayMember = "ComboDisplay";
            lstCustomer.ValueMember = "CustomerNo";
            lstCustomer.DataSource = dsInTheDogHouse.Tables["Customer"].DefaultView;


        }
        private void txtCustomer_TextChanged(object sender, EventArgs e)
        {
            dsInTheDogHouse.Tables["Customer"].DefaultView.RowFilter = "ComboDisplay LIKE '%" + txtCustomer.Text + "%'";
            lstCustomer.SelectedIndex = 0;
            updateCustomerDetails();
        }

        private void lstCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateCustomerDetails();
        }
        private void updateCustomerDetails()
        {

            rtbCustomerDetails.Text = "";
            if (lstCustomer.SelectedIndex > -1)
            {
                drCustomer = dsInTheDogHouse.Tables["Customer"].Rows.Find(lstCustomer.SelectedValue);
                lblCustomerNumber.Text = lstCustomer.SelectedValue.ToString();
                rtbCustomerDetails.AppendText(string.Format("{0} {1} {2}\n", drCustomer["Title"], drCustomer["Forename"], drCustomer["Surname"]));
                rtbCustomerDetails.AppendText(drCustomer["Street"].ToString() + "\n");
                rtbCustomerDetails.AppendText(drCustomer["Town"].ToString() + "\n");
                rtbCustomerDetails.AppendText(drCustomer["County"].ToString() + "\n");
                rtbCustomerDetails.AppendText(drCustomer["Postcode"].ToString() + "\n");

            }
        }
    }
}
