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
        SqlCommand cmdKennelDetails, cmdDogs;
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

            sqlDog = @"select * from Dog Where CustomerNo = @CustomerNo";
            cmdDogs = new SqlCommand(sqlDog, conn);
            cmdDogs.Parameters.Add("@CustomerNo", SqlDbType.Int);
            daDog = new SqlDataAdapter(cmdDogs);
            daDog.FillSchema(dsInTheDogHouse, SchemaType.Source, "Dog");

            dsInTheDogHouse.Tables["Dog"].Columns.Add("ComboDisplay", typeof(string), "DogNo + ' - ' + Name");


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

            sqlKennelDetails = "SELECT distinct kennelNo, sizeK, sizeNo, sizeB, dog.breedNo, chargePerDay FROM kennel " +
"Join size on sizeK = sizeNo " +
"join breed on sizeNo = sizeB " +
"join dog on dog.breedNo = breed.breedNo " +
"WHERE dog.breedNo = @BreedNo order by kennelNo ";
            cmdKennelDetails = new SqlCommand(sqlKennelDetails, conn);
            cmdKennelDetails.Parameters.Add("@BreedNo", SqlDbType.Int);
            daKennels = new SqlDataAdapter(cmdKennelDetails);
            daKennels.FillSchema(dsInTheDogHouse, SchemaType.Source, "Kennel");

            dsInTheDogHouse.Tables["Kennel"].Columns.Add("ComboDisplay", typeof(string), "KennelNo + ' - ' + SizeK");


            sqlBookedKennels = @"SELECT booking.bookingNo, dateStart, noDays, dogNo, kennelNo FROM booking JOIN bookingDetail on booking.bookingNo = bookingDetail.bookingNO order by bookingNo";
            daBookedKennels = new SqlDataAdapter(sqlBookedKennels, conn);
            cmdBBookedKennels = new SqlCommandBuilder(daBookedKennels);
            daBookedKennels.FillSchema(dsInTheDogHouse, SchemaType.Source, "BookedKennels");
            daBookedKennels.Fill(dsInTheDogHouse, "BookedKennels");

        }
        private void txtCustomer_TextChanged(object sender, EventArgs e)
        {
            dsInTheDogHouse.Tables["Customer"].DefaultView.RowFilter = "ComboDisplay LIKE '%" + txtCustomer.Text + "%'";
            lstCustomer.SelectedIndex = 0;
            updateCustomerDetails();
        }

        private void numDays_ValueChanged(object sender, EventArgs e)
        {
            dtpStartDate.SelectionEnd = dtpStartDate.SelectionStart.AddDays((int)numDays.Value);
        }

        private void dtpStartDate_DateSelected(object sender, DateRangeEventArgs e)
        {
            numDays.Value = (dtpStartDate.SelectionEnd - dtpStartDate.SelectionStart).Days;
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
        private void btnNext_Click(object sender, EventArgs e)
        {
            bool ok = true;

            if (lstCustomer.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a customer first", "Select Customer");
                return;
            }
            if (numDays.Value == 0)
            {
                MessageBox.Show("Please select the numer of days the dogs will be staying for first", "Number of days");
                return;
            }

            updateDogList();





            if (filterDogs() == 0)
            {
                if (MessageBox.Show("This customer has no dogs avaliable to book do you want to add a new dog?", "Add Dog?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    frmDog dogForm = new frmDog(container);
                    dogForm.FormClosed += DogForm_FormClosed;
                    container.changeForm(dogForm);
                }

                return;
            }

            ;




            if (ok)
            {
                tabBooking.SelectedIndex = 1;
            }

        }
        private int filterDogs()
        {
            int numDogs = lstDog.Items.Count;
            DateTime start = dtpStartDate.SelectionStart;
            foreach (DataRow dr in dsInTheDogHouse.Tables["BookedKennels"].Rows)
            {
                DateTime bookedDate = DateTime.Parse(dr["dateStart"].ToString());
                if (start >= bookedDate && start <= bookedDate.AddDays((int)numDays.Value))
                {
                    foreach (DataRow dog in dsInTheDogHouse.Tables["dog"].Rows)
                    {
                        if (dog["DogNo"].ToString() == (dr["DogNo"]).ToString())
                        {
                            dsInTheDogHouse.Tables["dog"].Rows.Remove(dog);

                            numDogs--;
                            break;
                        }
                    }
                    //if (dr["kennelNo"].ToString() == lstKennel.SelectedValue.ToString())
                    //{
                    //}
                }
            }
            return numDogs;
        }
        private void DogForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            btnNext_Click(sender, new EventArgs());
        }
        private void lstDog_Click(object sender, EventArgs e)
        {
            if (lstDog.Items.Count != 0)
            {
                dsInTheDogHouse.Tables["Kennel"].Clear();

                DataRow dog = dsInTheDogHouse.Tables["Dog"].Rows.Find(lstDog.SelectedValue);
                cmdKennelDetails.Parameters["@BreedNo"].Value = dog["breedNo"];

                daKennels.Fill(dsInTheDogHouse, "Kennel");

                lstKennel.DataSource = dsInTheDogHouse.Tables["Kennel"];
                lstKennel.DisplayMember = "ComboDisplay";
                lstKennel.ValueMember = "KennelNo";
                lstKennel.SelectedIndex = -1;
            }
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            tabBooking.SelectedIndex = 0;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            DataRow drBooking, drBookingDets;
            int bookingNo;
            int noRows = dsInTheDogHouse.Tables["Booking"].Rows.Count;
            drBooking = dsInTheDogHouse.Tables["Booking"].Rows[noRows - 1];
            bookingNo = int.Parse(drBooking["BookingNo"].ToString()) + 1;
            if (lstCustomer.SelectedIndex == -1)
                MessageBox.Show("Please select a customer", "customer");
            //else if (lstDog.SelectedIndex == -1)
            //    MessageBox.Show("Please select a dog", "Dog");
            //else if(lstKennel.SelectedIndex == -1)
            //    MessageBox.Show("Please select a kennel", "Kennel");
            else if (numDays.Value < 0)
            {
                MessageBox.Show("Please input number of days required", "Number of Days");
                numDays.Focus();
            }
            else if (lvBooking.Items.Count == 0)
            {
                MessageBox.Show("Please add a dog/Kennel to the booking", "Booking Details");
            }
            else
            {
                drBooking = dsInTheDogHouse.Tables["Booking"].NewRow();
                drBooking["bookingNo"] = bookingNo;
                drBooking["customerNo"] = int.Parse(lblCustomerNumber.Text);
                drBooking["dateBooked"] = DateTime.Parse(lblBookingRange.Text.Trim());
                drBooking["dateStart"] = dtpStartDate.SelectionStart;
                drBooking["noDays"] = (int)numDays.Value;
                dsInTheDogHouse.Tables["Booking"].Rows.Add(drBooking);
                daBooking.Update(dsInTheDogHouse, "Booking");
                foreach (ListViewItem item in lvBooking.Items)
                {
                    drBookingDets = dsInTheDogHouse.Tables["BookingDetail"].NewRow();
                    drBookingDets["bookingNo"] = drBooking["bookingNo"];
                    drBookingDets["dogNo"] = int.Parse(item.SubItems[0].Text);
                    drBookingDets["kennelNo"] = int.Parse(item.SubItems[2].Text);
                    dsInTheDogHouse.Tables["BookingDetail"].Rows.Add(drBookingDets);
                    daBookingDet.Update(dsInTheDogHouse, "BookingDetail");

                }
                MessageBox.Show("Booking No: " + drBooking["bookingNo"].ToString() + " added to system");
                resetForm();
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool ok = true;
            bool exists = false;
            if (lstCustomer.SelectedIndex == -1)
                MessageBox.Show("Please select a customer", "customer");
            else if (lstDog.SelectedIndex == -1)
                MessageBox.Show("Please select a dog", "Dog");
            else if (lstKennel.SelectedIndex == -1)
                MessageBox.Show("Please select a kennel", "Kennel");
            //else if (numDays.Value < 0)
            //{
            //    MessageBox.Show("Please input number of days required", "Number of Days");
            //    numDays.Focus();
            //}
            else
            {
                foreach (ListViewItem item in lvBooking.Items)
                {
                    if (item.SubItems[1].Text == lstDog.SelectedValue.ToString() || item.SubItems[2].Text == lstKennel.SelectedValue.ToString())
                    {
                        MessageBox.Show("Dog or kennel already selected for this booking.", "Booking");
                        exists = true;
                        break;
                    }
                }

                if (!exists)
                {
                    DateTime start = dtpStartDate.SelectionStart;
                    foreach (DataRow dr in dsInTheDogHouse.Tables["BookedKennels"].Rows)
                    {
                        DateTime bookedDate = DateTime.Parse(dr["dateStart"].ToString());
                        if (start >= bookedDate && start <= bookedDate.AddDays((int)numDays.Value))
                        {
                            if ((dr["dogNo"] == lstDog.SelectedValue))
                            {
                                MessageBox.Show("Dog is already included in a booking for this date range. Please re-select.", "Booking");
                                ok = false;
                                break;
                            }
                            if (dr["kennelNo"].ToString() == lstKennel.SelectedValue.ToString())
                            {
                                MessageBox.Show("Kennel is already included in a booking for this date range. Please re-select.", "Booking");
                                ok = false;
                                break;
                            }
                        }
                    }
                    if (ok)
                    {
                        DataRow dog = dsInTheDogHouse.Tables["Dog"].Rows.Find(lstDog.SelectedValue);
                        //foreach (DataRow dr in dsInTheDogHouse.Tables["dog"].Rows)
                        //{
                        //if (dr["dogNo"].ToString() == lstDog.SelectedValue.ToString())
                        //{
                        ListViewItem item = new ListViewItem(dog["dogNo"].ToString());
                        item.SubItems.Add(dog["name"].ToString());
                        item.SubItems.Add(lstKennel.SelectedValue.ToString());
                        lvBooking.Items.Add(item);
                        lstCustomer.Enabled = false;
                        txtCustomer.Enabled = false;
                        //}
                        //}
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lvBooking.SelectedItems.Count != 0)
            {
                lvBooking.Items.Remove(lvBooking.SelectedItems[0]);
            }
        }

        private void btnNewDog_Click(object sender, EventArgs e)
        {
            frmDog dogForm = new frmDog(container);
            dogForm.FormClosed += DogForm_FormClosed1; ;
            container.changeForm(dogForm);
        }

        private void DogForm_FormClosed1(object sender, FormClosedEventArgs e)
        {
            updateDogList();
        }
        private void updateDogList()
        {
            cmdDogs.Parameters["@CustomerNo"].Value = lstCustomer.SelectedValue;
            dsInTheDogHouse.Tables["Dog"].Clear();
            daDog.Fill(dsInTheDogHouse, "Dog");

            lstDog.DisplayMember = "ComboDisplay";
            lstDog.ValueMember = "dogNo";
            lstDog.DataSource = dsInTheDogHouse.Tables["Dog"];
        }
        private void resetForm()
        {
            dsInTheDogHouse.Tables["Kennel"].Clear();
            lstCustomer.SelectedIndex = -1;
            lstKennel.SelectedIndex = -1;
            lstDog.SelectedIndex = -1;
            lvBooking.Items.Clear();
            lstCustomer.Enabled = true;
            txtCustomer.Enabled = true;
            rtbCustomerDetails.Clear();
            numDays.Value = 1;
            dtpStartDate.SelectionStart = DateTime.Now;
            dtpStartDate.SelectionEnd = DateTime.Now;
            numDays.Value = 0;
            lblCustomerNumber.Text = "-";
        }
    }
}
