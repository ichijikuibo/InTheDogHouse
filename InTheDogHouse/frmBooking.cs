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

        public frmBooking(frmContainer container)
        {
            this.container = container;
            InitializeComponent();
        }

        private void frmBooking_Load(object sender, EventArgs e)
        {
            lblBookingRange.Text = DateTime.Now.ToShortDateString();
            dtpStart.MinDate = DateTime.Now;
            conn = new SqlConnection(container.connStr);
            sqlCustomer = @"select * from Customer";
            daCustomer = new SqlDataAdapter(sqlCustomer, conn);
            daCustomer.FillSchema(dsInTheDogHouse, SchemaType.Source, "Customer");
            daCustomer.Fill(dsInTheDogHouse, "Customer");


            sqlDog = @"select * from Dog";
            daDog = new SqlDataAdapter(sqlDog, conn);
            daDog.FillSchema(dsInTheDogHouse, SchemaType.Source, "Dog");
            daDog.Fill(dsInTheDogHouse, "Dog");



            dsInTheDogHouse.Tables["Customer"].Columns.Add("ComboDisplay", typeof(string), "CustomerNo + ' - ' + Forename + ' ' + Surname");
            dsInTheDogHouse.Tables["Dog"].Columns.Add("ComboDisplay", typeof(string), "DogNo + ' - ' + Name");

            lstCustomer.DisplayMember = "ComboDisplay";
            lstCustomer.ValueMember = "CustomerNo";
            lstCustomer.DataSource = dsInTheDogHouse.Tables["Customer"].DefaultView;

            sqlKennelDetails = @"SELECT distinct kennelNo, sizeK, sizeNo, sizeB, dog.breedNo, chargePerDay FROM kennel Join size on sizeK = sizeNo join breed on sizeNo = sizeB join dog on dog.breedNo = breed.breedNo where dog.breedNo = @BreedNo order by kennelNo";
            cmdKennelDetails = new SqlCommand(sqlKennelDetails, conn);
            cmdKennelDetails.Parameters.Add("@BreedNo", SqlDbType.Int);
            daKennels = new SqlDataAdapter(cmdKennelDetails);
            daKennels.FillSchema(dsInTheDogHouse, SchemaType.Source, "Kennel");

            sqlBookedKennels = @"SELECT booking.bookingNo, dateStart, noDays, dogNo, kennelNo FROM booking JOIN bookingDetail on booking.bookingNo = bookingDetail.bookingNO order by bookingNo";
            daBookedKennels = new SqlDataAdapter(sqlBookedKennels, conn);
            cmdBBookedKennels = new SqlCommandBuilder(daBookedKennels);
            daBookedKennels.FillSchema(dsInTheDogHouse, SchemaType.Source, "BookedKennels");
            daBookedKennels.Fill(dsInTheDogHouse, "BookedKennels");

            sqlBooking = @"SELECT * from Booking";
            daBooking = new SqlDataAdapter(sqlBooking, conn);
            cmdBBooking = new SqlCommandBuilder(daBooking);
            daBooking.FillSchema(dsInTheDogHouse, SchemaType.Source, "Booking");
            daBooking.Fill(dsInTheDogHouse, "Booking");

            sqlBookingDet = @"SELECT * from bookingDetail";
            daBookingDet = new SqlDataAdapter(sqlBookingDet, conn);
            cmdBBookingDet = new SqlCommandBuilder(daBookingDet);
            daBookingDet.FillSchema(dsInTheDogHouse, SchemaType.Source, "bookingDetail");
            daBookingDet.Fill(dsInTheDogHouse, "bookingDetail");
        }
        private void txtCustomer_TextChanged(object sender, EventArgs e)
        {

            dsInTheDogHouse.Tables["Customer"].DefaultView.RowFilter = "ComboDisplay LIKE '%" + txtCustomer.Text + "%'";
            if (lstCustomer.Items.Count > 0)
            {
                lstCustomer.SelectedIndex = 0;                
            }
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
