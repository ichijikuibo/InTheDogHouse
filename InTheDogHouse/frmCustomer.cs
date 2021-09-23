using InTheDogHouse.Models;
using ProgrammingIII;
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
    public partial class frmCustomer : Form
    {

        SqlDataAdapter daCustomer,daDog;
        DataSet dsInTheDogHouse = new DataSet();
        DataRow drCustomer;
        SqlCommandBuilder sqlBCustomer;
        string connStr, sqlCustomer,sqlDog;
        int selectedTab = 0;
        bool custSelected = false;
        int custNoSelected = 0;

        public frmCustomer()
        {
            InitializeComponent();
            
        }


        private void MainPage_SizeChanged(object sender, EventArgs e)
        {
            tabDogHouse.ItemSize = new Size((tabDogHouse.Width-5) / 3, tabDogHouse.ItemSize.Height);
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            //this.customerTableAdapter.Fill(this.dsInTheDogHouse.Customer);

            connStr = @"Data Source = .; Initial Catalog = InTheDogHouse; Integrated Security = true";
            sqlCustomer = @"select * from Customer";
            daCustomer = new SqlDataAdapter(sqlCustomer, connStr);
            sqlBCustomer = new SqlCommandBuilder(daCustomer);
            daCustomer.FillSchema(dsInTheDogHouse, SchemaType.Source, "Customer");
            daCustomer.Fill(dsInTheDogHouse, "Customer");

            sqlDog = @"select * from Dog";
            daDog = new SqlDataAdapter(sqlDog, connStr);
            daDog.FillSchema(dsInTheDogHouse, SchemaType.Source, "Dog");
            daDog.Fill(dsInTheDogHouse, "Dog");


            dgvDisplay.DataSource = dsInTheDogHouse.Tables["Customer"];
            dgvDisplay.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            tabDogHouse.SelectedIndex = 0;
        }

        private void btnAddAdd_Click(object sender, EventArgs e)
        {

            Customer customer = new Customer();
            bool ok = true;
            errP.Clear();

            if (!assignProperty(lblAddCustomerNumber, () => customer.IDNo = int.Parse(lblAddCustomerNumber.Text))) ok = false;
            if (!assignProperty(cmbAddTitle, () => customer.Title = cmbAddTitle.Text)) ok = false;
            if (!assignProperty(txtAddSurname, () => customer.Surname = txtAddSurname.Text)) ok = false;
            if (!assignProperty(txtAddForename, () => customer.Forename = txtAddForename.Text)) ok = false;
            if (!assignProperty(txtAddStreet, () => customer.Address = txtAddStreet.Text)) ok = false;
            if (!assignProperty(txtAddTown, () => customer.Town = txtAddTown.Text)) ok = false;
            if (!assignProperty(txtAddPostcode, () => customer.Postcode = txtAddPostcode.Text)) ok = false;
            if (!assignProperty(txtAddCounty, () => customer.County = txtAddCounty.Text)) ok = false;
            if (!assignProperty(txtAddTelephone, () => customer.TelNo = txtAddTelephone.Text)) ok = false;

            if (ok)
            {
                try
                {
                    drCustomer = dsInTheDogHouse.Tables["Customer"].NewRow();
                    customerToDataRow(drCustomer, customer);
                    dsInTheDogHouse.Tables["Customer"].Rows.Add(drCustomer);
                    daCustomer.Update(dsInTheDogHouse, "Customer");

                    if(MessageBox.Show("Customer Added - Do you wish to add another customer", "Add Customer",MessageBoxButtons.YesNo)==DialogResult.Yes)
                    {
                        clearAddForm();
                        getNumber(dsInTheDogHouse.Tables["Customer"].Rows.Count);
                    }
                    else
                    {
                        tabDogHouse.SelectedIndex = 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.TargetSite + " " + ex.Message, "Error",MessageBoxButtons.AbortRetryIgnore,MessageBoxIcon.Error);
                    drCustomer.Delete();
                }
            }

        }


        private void btnDisplayAdd_Click(object sender, EventArgs e)
        {

            tabDogHouse.SelectedIndex = 1;
        }

        private void btnAddCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to cancel adding customer no: " + lblAddCustomerNumber.Text + "?", "Cancel Adding Customer", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                clearAddForm();
                tabDogHouse.SelectedIndex = 0;
            }
        }

        private void btnEditEdit_Click(object sender, EventArgs e)
        {
            if(btnEditEdit.Text == "Edit")
            {
                changeEditEnabled(true);
            }
            else
            {
                Customer customer = new Customer();
                bool ok = true;
                errP.Clear();

                if (!assignProperty(lblEditCustomerNumber, () => customer.IDNo = int.Parse(lblEditCustomerNumber.Text))) ok = false;
                if (!assignProperty(cmbEditTitle, () => customer.Title = cmbEditTitle.Text)) ok = false;
                if (!assignProperty(txtEditSurname, () => customer.Surname = txtEditSurname.Text)) ok = false;
                if (!assignProperty(txtEditForename, () => customer.Forename = txtEditForename.Text)) ok = false;
                if (!assignProperty(txtEditStreet, () => customer.Address = txtEditStreet.Text)) ok = false;
                if (!assignProperty(txtEditTown, () => customer.Town = txtEditTown.Text)) ok = false;
                if (!assignProperty(txtEditPostcode, () => customer.Postcode = txtEditPostcode.Text)) ok = false;
                if (!assignProperty(txtEditCounty, () => customer.County = txtEditCounty.Text)) ok = false;
                if (!assignProperty(txtEditTelephone, () => customer.TelNo = txtEditTelephone.Text)) ok = false;

                if (ok)
                {
                    try
                    {
                        drCustomer.BeginEdit();
                        customerToDataRow(drCustomer, customer);
                        drCustomer.EndEdit();
                        daCustomer.Update(dsInTheDogHouse, "Customer");

                        MessageBox.Show("Customer Details Updated", "Customer");

                        changeEditEnabled(false);
                        tabDogHouse.SelectedIndex = 0;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.TargetSite + " " + ex.Message, "Error", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
                        drCustomer.Delete();
                    }
                }
            }


        }
        private bool assignProperty(Control field, Action property)
        {
            try
            {
                property();
            }
            catch (MyException ex)
            {
                errP.SetError(field, ex.toString());
                return false;
            }
            return true;
        }
        private void customerToDataRow(DataRow row, Customer customer)
        {
            row["CustomerNo"] = customer.IDNo;
            row["Title"] = customer.Title;
            row["Forename"] = customer.Forename;
            row["Surname"] = customer.Surname;
            row["Street"] = customer.Address;
            row["Town"] = customer.Town;
            row["County"] = customer.County;
            row["Postcode"] = customer.Postcode;
            row["TelNo"] = customer.TelNo;
        }
        private void changeEditEnabled(bool enabled)
        {
            cmbEditTitle.Enabled = enabled;
            txtEditForename.Enabled = enabled;
            txtEditSurname.Enabled = enabled;
            txtEditStreet.Enabled = enabled;
            txtEditTown.Enabled = enabled;
            txtEditCounty.Enabled = enabled;
            txtEditPostcode.Enabled = enabled;
            txtEditTelephone.Enabled = enabled;
            if(enabled)btnEditEdit.Text = "Save";
            else btnEditEdit.Text = "Edit";
        }

        private void btnEditCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to cancel editing customer no: " + lblAddCustomerNumber.Text + "?", "Cancel Edit Customer", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                tabDogHouse.SelectedIndex = 0;
            }
        }

        private void btnDisplayEdit_Click(object sender, EventArgs e)
        {
            tabDogHouse.SelectedIndex = 2;
        }

        private void btnDisplayDelete_Click(object sender, EventArgs e)
        {
            if(dgvDisplay.SelectedRows.Count==0)
            {
                MessageBox.Show("Please select a customer from the list.", "Select Customer");
            }
            else
            {
                drCustomer = dsInTheDogHouse.Tables["Customer"].Rows.Find(dgvDisplay.SelectedRows[0].Cells[0].Value);

                string tempName = drCustomer["Forename"].ToString() + " " + drCustomer["Surname"].ToString() + "'s";
                bool inUse = false;
                foreach (DataRow dr in dsInTheDogHouse.Tables["Dog"].Rows)
                {
                    if (dr["CustomerNo"].Equals(drCustomer["CustomerNo"])) inUse = true;
                }
                if (inUse)
                {
                    MessageBox.Show("Unable to delete customer because they have a dog", "Customer in Use ", MessageBoxButtons.OK);
                }
                else
                {
                    if (MessageBox.Show("Are you sure you want to delete " + tempName + " details", "Delete Customer", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        drCustomer.Delete();
                        daCustomer.Update(dsInTheDogHouse, "Customer");
                    }
                }
            }
        }

        private void tabDogHouse_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedTab = tabDogHouse.SelectedIndex;
            tabDogHouse.TabPages[selectedTab].Focus();
            tabDogHouse.TabPages[selectedTab].CausesValidation=true;

            switch(selectedTab)
            {
                case 0:
                    dsInTheDogHouse.Tables["Customer"].Clear();
                    daCustomer.Fill(dsInTheDogHouse, "Customer");
                    break;
                case 1:
                    int noRows = dsInTheDogHouse.Tables["Customer"].Rows.Count;
                    if (noRows == 0)
                        lblAddCustomerNumber.Text = "10000";
                    else
                    {
                        getNumber(noRows);
                    }
                    errP.Clear();
                    clearAddForm();
                    break;
                case 2:
                    if(custNoSelected==0)
                    {
                        tabDogHouse.SelectedIndex = 0;
                    }
                    else
                    {
                        lblEditCustomerNumber.Text = custNoSelected.ToString();
                        drCustomer = dsInTheDogHouse.Tables["Customer"].Rows.Find(lblEditCustomerNumber.Text);

                        cmbEditTitle.SelectedItem = drCustomer["Title"].ToString();
                        txtEditForename.Text = drCustomer["Forename"].ToString();
                        txtEditSurname.Text = drCustomer["Surname"].ToString();
                        txtEditStreet.Text = drCustomer["Street"].ToString();
                        txtEditTown.Text = drCustomer["Town"].ToString();
                        txtEditCounty.Text = drCustomer["County"].ToString();
                        txtEditPostcode.Text = drCustomer["PostCode"].ToString();
                        txtEditTelephone.Text = drCustomer["TelNo"].ToString();
                    }
                    break;
            }

        }
        private void clearAddForm()
        {
            cmbAddTitle.SelectedIndex = -1;
            txtAddSurname.Clear();
            txtAddForename.Clear();
            txtAddStreet.Clear();
            txtAddTown.Clear();
            txtAddCounty.Clear();
            txtAddPostcode.Clear();
            txtAddTelephone.Clear();
        }
        private void getNumber(int noRows)
        {
            drCustomer = dsInTheDogHouse.Tables["Customer"].Rows[noRows - 1];
            lblAddCustomerNumber.Text = (int.Parse(drCustomer["CustomerNo"].ToString())+1).ToString();
        }

        private void AddTabValidate(object sender, EventArgs e)
        {
            if(dgvDisplay.SelectedRows.Count==0)
            {
                custSelected = false;
                custNoSelected = 0;
            }
            else if(dgvDisplay.SelectedRows.Count==1)
            {
                custSelected = true;
                custNoSelected = int.Parse(dgvDisplay.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void EditTabValidate(object sender, EventArgs e)
        {
            if(custSelected != false && custNoSelected != 0)
            {
                custSelected = false;
                custNoSelected = 0;
            }
            else if(dgvDisplay.SelectedRows.Count==1)
            {
                custSelected = true;
                custNoSelected = int.Parse(dgvDisplay.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void MainPage_Shown(object sender, EventArgs e)
        {
            tabDogHouse.TabPages[0].CausesValidation = true;
            tabDogHouse.TabPages[0].Validating += new CancelEventHandler(AddTabValidate);

            tabDogHouse.TabPages[1].CausesValidation = true;
            tabDogHouse.TabPages[1].Validating += new CancelEventHandler(EditTabValidate);
        }

        private void btnDisplayExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
