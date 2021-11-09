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
    public partial class frmBookingEdit : Form
    {
        SqlDataAdapter daCustomer, daDog, daKennels, daBookedKennels, daBooking, daBookingDet;
        DataRow drCustomer;
        DataSet dsInTheDogHouse = new DataSet();
        SqlCommandBuilder cmdBBookedKennels, cmdBBooking, cmdBBookingDet;
        SqlCommand cmdKennelDetails;
        string sqlCustomer, sqlDog, sqlKennel, sqlKennelDetails, sqlBookedKennels, sqlBooking, sqlBookingDet;
        int selectedTab = 0;
        bool custSelected = false;
        int custNoSelected = 0;
        SqlConnection conn;
        frmContainer container;

        public frmBookingEdit(frmContainer container)
        {
            this.container = container;
            InitializeComponent();
        }

        private void frmBookingEdit_Load(object sender, EventArgs e)
        {
            //lblBooked.Text = DateTime.Now.ToShortDateString();
            //dtpStart.MinDate = DateTime.Now;
            conn = new SqlConnection(container.connStr);
            sqlCustomer = @"select * from Customer";
            daCustomer = new SqlDataAdapter(sqlCustomer, conn);
            daCustomer.FillSchema(dsInTheDogHouse, SchemaType.Source, "Customer");
            daCustomer.Fill(dsInTheDogHouse, "Customer");


            sqlDog = @"select * from Dog";
            daDog = new SqlDataAdapter(sqlDog, conn);
            daDog.FillSchema(dsInTheDogHouse, SchemaType.Source, "Dog");
            daDog.Fill(dsInTheDogHouse, "Dog");

            //sqlKennel = @"select * from Kennel";
            //daKennel = new SqlDataAdapter(sqlKennel, container.connStr);
            //daKennel.FillSchema(dsInTheDogHouse, SchemaType.Source, "Kennel");
            //daKennel.Fill(dsInTheDogHouse, "Kennel");


            dsInTheDogHouse.Tables["Customer"].Columns.Add("ComboDisplay", typeof(string), "CustomerNo + ' - ' + Forename + ' ' + Surname");

            dsInTheDogHouse.Tables["Dog"].Columns.Add("ComboDisplay", typeof(string), "DogNo + ' - ' + Name");

            lstCustomer.DisplayMember = "ComboDisplay";
            lstCustomer.ValueMember = "CustomerNo";
            

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

            sqlBookedKennels = @"SELECT booking.bookingNo, dateStart, noDays, dogNo,kennelNo FROM booking JOIN bookingDetail on booking.bookingNo = bookingDetail.bookingNO order by bookingNo";
            daBookedKennels = new SqlDataAdapter(sqlBookedKennels, conn);
            cmdBBookedKennels = new SqlCommandBuilder(daBookedKennels);
            daBookedKennels.FillSchema(dsInTheDogHouse, SchemaType.Source, "BookedKennels");
            daBookedKennels.Fill(dsInTheDogHouse, "BookedKennels");

            sqlBooking = @"SELECT * from Booking";
            daBooking = new SqlDataAdapter(sqlBooking, conn);
            cmdBBooking = new SqlCommandBuilder(daBooking);
            daBooking.FillSchema(dsInTheDogHouse, SchemaType.Source, "Booking");
            daBooking.Fill(dsInTheDogHouse, "Booking");
            dsInTheDogHouse.Tables["Booking"].Columns.Add("DateOnly", typeof(string), "");
            foreach (DataRow row in dsInTheDogHouse.Tables["Booking"].Rows)
            {
                DateTime dt = DateTime.Parse(row["DateStart"].ToString());
                row["DateOnly"] = dt.ToShortDateString();
            }

            dsInTheDogHouse.Tables["Booking"].Columns.Add("ComboDisplay", typeof(string), "BookingNo + ' - ' + DateOnly  + ' - ' + NoDays + ' Days'");


            lstBookings.ValueMember = "bookingNo";
            lstBookings.DisplayMember = "ComboDisplay";


            sqlBookingDet = @"SELECT * from bookingDetail";
            daBookingDet = new SqlDataAdapter(sqlBookingDet, conn);
            cmdBBookingDet = new SqlCommandBuilder(daBookingDet);
            daBookingDet.FillSchema(dsInTheDogHouse, SchemaType.Source, "BookingDetail");
            daBookingDet.Fill(dsInTheDogHouse, "BookingDetail");



            lstCustomer.DataSource = dsInTheDogHouse.Tables["Customer"].DefaultView;
            
            lstBookings.DataSource = dsInTheDogHouse.Tables["Booking"].DefaultView;
            lstBookings.SelectedIndex = -1;
            lstCustomer.SelectedIndex = -1;
        }

        private void txtCustomer_TextChanged(object sender, EventArgs e)
        {
            dsInTheDogHouse.Tables["Customer"].DefaultView.RowFilter = "ComboDisplay LIKE '%" + txtCustomer.Text + "%'";
            lstCustomer.SelectedIndex = -1;
            lstBookings.SelectedIndex = -1;
        }
        private void updateDogList()
        {
            if (lstDog.DataSource == null)
            {
                lstDog.DisplayMember = "ComboDisplay";
                lstDog.ValueMember = "dogNo";
                lstDog.DataSource = dsInTheDogHouse.Tables["Dog"].DefaultView;
            }
            if (lstCustomer.SelectedIndex > -1)
            {
                string addedDogs = "(";
                foreach (ListViewItem item in lvBooking.Items)
                {
                    addedDogs += item.Text;
                }
                addedDogs = addedDogs.TrimEnd(',') + ")";
                if (lvBooking.Items.Count > 0)
                    dsInTheDogHouse.Tables["Dog"].DefaultView.RowFilter = "CustomerNo = " + lstCustomer.SelectedValue + " and dogNo NOT IN " + addedDogs;
                else
                    dsInTheDogHouse.Tables["Dog"].DefaultView.RowFilter = "CustomerNo = " + lstCustomer.SelectedValue;
            }
            else
            {
                lstDog.DataSource = null;
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
                    DateTime start = dtpStart.Value;
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
                        updateDogList();
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
                updateDogList();
            }

        }

        private void updateBookings()
        {
            if (lstCustomer.SelectedIndex > -1)
            {
                dsInTheDogHouse.Tables["Booking"].DefaultView.RowFilter = "CustomerNo = " + lstCustomer.SelectedValue;
            }
            else dsInTheDogHouse.Tables["Booking"].DefaultView.RowFilter = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DataRow drBooking, drBookingDets;
            int bookingNo;
            int noRows = dsInTheDogHouse.Tables["Booking"].Rows.Count;
            drBooking = dsInTheDogHouse.Tables["Booking"].Rows.Find(lstBookings.SelectedValue);
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
                drBooking.BeginEdit();
                //drBooking["bookingNo"] = bookingNo;
                //drBooking["customerNo"] = int.Parse(lblCustomerNumber.Text);
                drBooking["dateBooked"] = DateTime.Now;
                drBooking["dateStart"] = dtpStart.Value;
                drBooking["noDays"] = (int)numDays.Value;

                dsInTheDogHouse.Tables["BookingDetail"].DefaultView.RowFilter = "BookingNo = " + lstBookings.SelectedValue;
                foreach (DataRowView drv in dsInTheDogHouse.Tables["BookingDetail"].DefaultView)
                {
                    drv.Delete();
                }
                daBookingDet.Update(dsInTheDogHouse, "BookingDetail");
                if (lvBooking.Items.Count == 0)
                {
                    drBooking.Delete();
                }
                else
                {
                    foreach (ListViewItem item in lvBooking.Items)
                    {
                        drBookingDets = dsInTheDogHouse.Tables["BookingDetail"].NewRow();
                        drBookingDets["bookingNo"] = drBooking["bookingNo"];
                        drBookingDets["dogNo"] = int.Parse(item.SubItems[0].Text);
                        drBookingDets["kennelNo"] = int.Parse(item.SubItems[2].Text);
                        dsInTheDogHouse.Tables["BookingDetail"].Rows.Add(drBookingDets);
                        daBookingDet.Update(dsInTheDogHouse, "BookingDetail");
                    }
                }

                daBooking.Update(dsInTheDogHouse, "Booking");
                drBooking.EndEdit();
                dsInTheDogHouse.Tables["BookedKennels"].Clear();
                daBookedKennels.Fill(dsInTheDogHouse, "BookedKennels");
                MessageBox.Show("Booking No: " + drBooking["bookingNo"].ToString() + " added to system");
                resetForm();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            resetForm();
        }

        private void lstCustomer_Click(object sender, EventArgs e)
        {

        }
        private void updateCustomer()
        {
            drCustomer = dsInTheDogHouse.Tables["Customer"].Rows.Find(lstCustomer.SelectedValue);
            rtbCustomerDetails.Text = "";
            if (lstCustomer.SelectedIndex > -1)
            {
                lblCustomerNumber.Text = lstCustomer.SelectedValue.ToString();
                rtbCustomerDetails.AppendText(string.Format("{0} {1} {2}\n", drCustomer["Title"], drCustomer["Forename"], drCustomer["Surname"]));
                rtbCustomerDetails.AppendText(drCustomer["Street"].ToString() + "\n");
                rtbCustomerDetails.AppendText(drCustomer["Town"].ToString() + "\n");
                rtbCustomerDetails.AppendText(drCustomer["County"].ToString() + "\n");
                rtbCustomerDetails.AppendText(drCustomer["Postcode"].ToString() + "\n");

            }
            
            //updateBookings();
        }
        private void updateBooking()
        {
            lvBooking.Items.Clear();
            if (lstBookings.SelectedIndex > -1)
            {
                DataRow selectBooking = dsInTheDogHouse.Tables["Booking"].Rows.Find(lstBookings.SelectedValue);
                dsInTheDogHouse.Tables["BookedKennels"].DefaultView.RowFilter = "BookingNo = " + lstBookings.SelectedValue;
                foreach (DataRowView drv in dsInTheDogHouse.Tables["BookedKennels"].DefaultView)
                {
                    ListViewItem item = new ListViewItem(drv["dogNo"].ToString());
                    item.SubItems.Add(dsInTheDogHouse.Tables["Dog"].Rows.Find(drv["dogNo"])["Name"].ToString());
                    item.SubItems.Add(drv["kennelNo"].ToString());
                    lvBooking.Items.Add(item);
                }
                dtpStart.Value = DateTime.Parse(selectBooking["DateStart"].ToString());
                lblBooked.Text = DateTime.Parse(selectBooking["DateBooked"].ToString()).ToShortDateString();
                numDays.Value = int.Parse(selectBooking["NoDays"].ToString());


            }
        }
        private void updateKennels()
        {

                dsInTheDogHouse.Tables["Kennel"].Clear();
            if (lstDog.SelectedIndex > -1)
            {
                DataRow dog = dsInTheDogHouse.Tables["Dog"].Rows.Find(lstDog.SelectedValue);
                cmdKennelDetails.Parameters["@BreedNo"].Value = dog["breedNo"];

                daKennels.Fill(dsInTheDogHouse, "Kennel");

                lstKennel.DataSource = dsInTheDogHouse.Tables["Kennel"];
                lstKennel.DisplayMember = "ComboDisplay";
                lstKennel.ValueMember = "KennelNo";
                lstKennel.SelectedIndex = -1;
                //txtCustomer.Enabled = false;
                //lstCustomer.Enabled = false;
                canAdd();
            }

        }

        private void lstDog_Click(object sender, EventArgs e)
        {

        }
        bool dontUpdate = false;
        private void lstBookings_Click(object sender, EventArgs e)
        {
            if (lstBookings.SelectedIndex > -1)
            {
                DataRow selectBooking = dsInTheDogHouse.Tables["Booking"].Rows.Find(lstBookings.SelectedValue);
                if (lstCustomer.SelectedValue == null || lstCustomer.SelectedValue.ToString() != selectBooking["CustomerNo"].ToString())
                {
                    dontUpdate = true;
                    lstCustomer.SelectedValue = int.Parse(selectBooking["CustomerNo"].ToString());
                    dontUpdate = false;
                    //updateCustomer();
                }
            }
        }
        private void lstBookings_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateBooking();
        }

        private void lstCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateCustomer();
            if (!dontUpdate)
            {
                updateBookings();
                
            }

            updateBooking();
            updateDogList();
            updateKennels();
        }

        private void lvBooking_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lvBooking.SelectedItems.Count > 0)
            {
                btnDelete.Enabled = true;
            }
            else btnDelete.Enabled = false;
        }

        private void lstDog_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateKennels();
        }

        private void lstKennel_SelectedIndexChanged(object sender, EventArgs e)
        {
            canAdd();
        }
        private void canAdd()
        {
            if(lstKennel.SelectedIndex>-1 && lstDog.SelectedIndex>-1)
            {
                btnAdd.Enabled = true;
            }
            else btnAdd.Enabled = false;
        }
        private void resetForm()
        {
            dsInTheDogHouse.Tables["Booking"].DefaultView.RowFilter = "";
            dsInTheDogHouse.Tables["BookingDetail"].DefaultView.RowFilter = "";
            dsInTheDogHouse.Tables["BookedKennels"].DefaultView.RowFilter = "";
            dsInTheDogHouse.Tables["Customer"].DefaultView.RowFilter = "";
            dsInTheDogHouse.Tables["Kennel"].Clear();
            dsInTheDogHouse.Tables["Dog"].DefaultView.RowFilter = "";
            lstCustomer.SelectedIndex = -1;
            lstKennel.SelectedIndex = -1;
            lstDog.SelectedIndex = -1;
            updateDogList();
            lvBooking.Items.Clear();
            lstCustomer.Enabled = true;
            txtCustomer.Enabled = true;
            rtbCustomerDetails.Clear();
            numDays.Value = 1;
            dtpStart.Value = DateTime.Now;
            lblCustomerNumber.Text = "-";
        }
    }
}
