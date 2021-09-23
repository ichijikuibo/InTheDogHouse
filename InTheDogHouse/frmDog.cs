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
    public partial class frmDog : Form
    {
        SqlDataAdapter daCustomer,daDog,daBreed;
        DataSet dsInTheDogHouse = new DataSet();
        SqlCommandBuilder sqlBDog;
        DataRow drDog;
        string connStr, sqlCustomer,sqlDog,sqlBreed;
        int selectedTab = 0;
        bool dogSelected = false;
        int dogNoSelected = 0;
        public frmDog()
        {
            InitializeComponent();
        }

        private void Dog_Load(object sender, EventArgs e)
        {
            connStr = @"Data Source = .; Initial Catalog = InTheDogHouse; Integrated Security = true";
            sqlCustomer = @"select * from Customer";
            daCustomer = new SqlDataAdapter(sqlCustomer, connStr);

            daCustomer.FillSchema(dsInTheDogHouse, SchemaType.Source, "Customer");
            daCustomer.Fill(dsInTheDogHouse, "Customer");

            sqlDog = @"select * from Dog";
            daDog = new SqlDataAdapter(sqlDog, connStr);
            sqlBDog = new SqlCommandBuilder(daDog);
            daDog.FillSchema(dsInTheDogHouse, SchemaType.Source, "Dog");
            daDog.Fill(dsInTheDogHouse, "Dog");

            sqlBreed = @"select * from Breed";
            daBreed = new SqlDataAdapter(sqlBreed, connStr);
            daBreed.FillSchema(dsInTheDogHouse, SchemaType.Source, "Breed");
            daBreed.Fill(dsInTheDogHouse, "Breed");

            dsInTheDogHouse.Tables["Customer"].Columns.Add("ComboDisplay",typeof(string), "CustomerNo + ' - ' + Forename + ' ' + Surname");

            dsInTheDogHouse.Tables["Breed"].Columns.Add("ComboDisplay", typeof(string), "BreedNo + ' - ' + BreedName");

            dgvDisplay.DataSource = dsInTheDogHouse.Tables["Dog"];
            dgvDisplay.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);


            cmbAddBreedNo.DataSource = dsInTheDogHouse.Tables["Breed"];
            cmbAddBreedNo.DisplayMember = "ComboDisplay";
            cmbAddBreedNo.ValueMember = "BreedNo";

            cmbAddCustomer.DataSource = dsInTheDogHouse.Tables["Customer"];
            cmbAddCustomer.DisplayMember = "ComboDisplay";
            cmbAddCustomer.ValueMember = "CustomerNo";

            cmbEditBreedNo.DataSource = dsInTheDogHouse.Tables["Breed"];
            cmbEditBreedNo.DisplayMember = "ComboDisplay";
            cmbEditBreedNo.ValueMember = "BreedNo";

            cmbEditCustomer.DataSource = dsInTheDogHouse.Tables["Customer"];
            cmbEditCustomer.DisplayMember = "ComboDisplay";
            cmbEditCustomer.ValueMember = "CustomerNo";

            tabDogHouse.SelectedIndex = 0;
        }

        private void btnAddAdd_Click(object sender, EventArgs e)
        {
            DogModel dog = new DogModel();
            bool ok = true;
            errP.Clear();

            if (!assignProperty(lblAddDogNumber, () => dog.IdNo = int.Parse(lblAddDogNumber.Text))) ok = false;

            if (cmbAddBreedNo.SelectedIndex < 0)
            {
                errP.SetError(cmbAddBreedNo, "Please select a Breed");
                ok = false;
            }
            else if (!assignProperty(cmbAddBreedNo, () => dog.BreedNo = (int)cmbAddBreedNo.SelectedValue)) ok = false;

            if (cmbAddCustomer.SelectedIndex < 0)
            {
                errP.SetError(cmbAddCustomer, "Please select a Customer");
                ok = false;
            }
            else if (!assignProperty(cmbAddCustomer, () => dog.CustomerNo = (int)cmbAddCustomer.SelectedValue)) ok = false;

            if (cmbAddGender.SelectedIndex < 0)
            {
                errP.SetError(cmbAddGender, "Please select a Gendder");
                ok = false;
            }
            else if (!assignProperty(cmbAddGender, () => dog.Gender = cmbAddGender.Text[0])) ok = false;

            if (!assignProperty(txtAddColour, () => dog.Colour = txtAddColour.Text)) ok = false;
            if (!assignProperty(txtAddName, () => dog.Name = txtAddName.Text)) ok = false;
            if (!assignProperty(dtpAddDOB, () => dog.Dob = dtpAddDOB.Value)) ok = false;


            if (ok)
            {
                try
                {
                    drDog = dsInTheDogHouse.Tables["Dog"].NewRow();
                    dogToDataRow(drDog, dog);
                    dsInTheDogHouse.Tables["Dog"].Rows.Add(drDog);
                    daDog.Update(dsInTheDogHouse, "Dog");

                    if (MessageBox.Show("Dog Added - Do you wish to add another Dog", "Add Dog", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        clearAddForm();
                        getNumber(dsInTheDogHouse.Tables["Dog"].Rows.Count);
                    }
                    else
                    {
                        tabDogHouse.SelectedIndex = 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.TargetSite + " " + ex.Message, "Error", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
                    drDog.Delete();
                }
            }
        }

        private void tabDogHouse_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedTab = tabDogHouse.SelectedIndex;
            tabDogHouse.TabPages[selectedTab].Focus();
            tabDogHouse.TabPages[selectedTab].CausesValidation = true;

            switch (selectedTab)
            {
                case 0:
                    dsInTheDogHouse.Tables["Dog"].Clear();
                    daDog.Fill(dsInTheDogHouse, "Dog");
                    break;
                case 1:
                    int noRows = dsInTheDogHouse.Tables["Dog"].Rows.Count;
                    if (noRows == 0)
                        lblAddDogNumber.Text = "5000";
                    else
                    {
                        getNumber(noRows);
                    }
                    errP.Clear();
                    clearAddForm();
                    break;
                case 2:
                    if (dogNoSelected == 0)
                    {
                        tabDogHouse.SelectedIndex = 0;
                    }
                    else
                    {
                        lblEditDogNumber.Text = dogNoSelected.ToString();
                        drDog = dsInTheDogHouse.Tables["Dog"].Rows.Find(lblEditDogNumber.Text);

                        txtEditName.Text = drDog["Name"].ToString();
                        cmbEditBreedNo.SelectedValue = drDog["BreedNo"].ToString();
                        dtpEditDOB.Value = Convert.ToDateTime(drDog["DOB"]);
                        cmbEditGender.SelectedIndex = drDog["Gender"].ToString().ToLower()=="m"?0:1;
                        txtEditColour.Text = drDog["Colour"].ToString();
                        cmbEditCustomer.SelectedValue = drDog["CustomerNo"].ToString();
                    }
                    break;
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
        private void dogToDataRow(DataRow row, DogModel dog)
        {
            row["DogNo"] = dog.IdNo;
            row["Name"] = dog.Name;
            row["BreedNo"] = dog.BreedNo;
            row["DOB"] = string.Format("{0}-{1:D2}-{2:D2}", dog.Dob.Year,dog.Dob.Month,dog.Dob.Day);
            row["Gender"] = dog.Gender;
            row["Colour"] = dog.Colour;
            row["CustomerNo"] = dog.CustomerNo;
        }

        private void btnEditEdit_Click(object sender, EventArgs e)
        {
            if (btnEditEdit.Text == "Edit")
            {
                changeEditEnabled(true);
            }
            else
            {
                DogModel dog = new DogModel();
                bool ok = true;
                errP.Clear();

                if (!assignProperty(lblEditDogNumber, () => dog.IdNo = int.Parse(lblEditDogNumber.Text))) ok = false;

                if (cmbEditBreedNo.SelectedIndex < 0)
                {
                    errP.SetError(cmbEditBreedNo, "Please select a Breed");
                    ok = false;
                }
                else if (!assignProperty(cmbEditBreedNo, () => dog.BreedNo = (int)cmbEditBreedNo.SelectedValue)) ok = false;

                if (cmbEditCustomer.SelectedIndex < 0)
                {
                    errP.SetError(cmbEditCustomer, "Please select a Customer");
                    ok = false;
                }
                else if (!assignProperty(cmbEditCustomer, () => dog.CustomerNo = (int)cmbEditCustomer.SelectedValue)) ok = false;

                if (cmbEditGender.SelectedIndex < 0)
                {
                    errP.SetError(cmbEditGender, "Please select a Gender");
                    ok = false;
                }
                else if (!assignProperty(cmbEditGender, () => dog.Gender = cmbEditGender.Text[0])) ok = false;

                if (!assignProperty(txtEditColour, () => dog.Colour = txtEditColour.Text)) ok = false;
                if (!assignProperty(txtEditName, () => dog.Name = txtEditName.Text)) ok = false;
                if (!assignProperty(dtpEditDOB, () => dog.Dob = dtpEditDOB.Value)) ok = false;

                if (ok)
                {
                    drDog.BeginEdit();
                    dogToDataRow(drDog, dog);
                    drDog.EndEdit();
                    daDog.Update(dsInTheDogHouse, "Dog");

                    MessageBox.Show("Dog Details Updated", "Dog");

                    changeEditEnabled(false);
                    tabDogHouse.SelectedIndex = 0;
                }
            }
        }

        private void btnDisplayAdd_Click(object sender, EventArgs e)
        {
            tabDogHouse.SelectedIndex = 1;
        }

        private void btnDisplayEdit_Click(object sender, EventArgs e)
        {
            tabDogHouse.SelectedIndex = 2;
        }

        private void btnDisplayDelete_Click(object sender, EventArgs e)
        {
            if (dgvDisplay.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a dog from the list.", "Select Ddog");
            }
            else
            {
                drDog = dsInTheDogHouse.Tables["Dog"].Rows.Find(dgvDisplay.SelectedRows[0].Cells[0].Value);

                if (MessageBox.Show("Are you sure you want to delete " + drDog["Name"].ToString() + "'s details", "Delete Dog", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    drDog.Delete();
                    daCustomer.Update(dsInTheDogHouse, "Dog");
                }
            }
        }

        private void btnEditCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to cancel editing dog no: " + lblEditDogNumber + "?", "Cancel Edit Dog", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                tabDogHouse.SelectedIndex = 0;
            }
        }

        private void btnAddCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to cancel adding dog no: " + lblEditDogNumber.Text + "?", "Cancel Adding Dog", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                clearAddForm();
                tabDogHouse.SelectedIndex = 0;
            }
        }

        private void frmDog_ResizeEnd(object sender, EventArgs e)
        {
            tabDogHouse.ItemSize = new Size((tabDogHouse.Width - 5) / 3, tabDogHouse.ItemSize.Height);
        }

        private void changeEditEnabled(bool enabled)
        {
            cmbEditBreedNo.Enabled = enabled;
            cmbEditCustomer.Enabled = enabled;
            cmbEditGender.Enabled = enabled;
            txtEditColour.Enabled = enabled;
            txtEditName.Enabled = enabled;
            dtpEditDOB.Enabled = enabled;
            if (enabled) btnEditEdit.Text = "Save";
            else btnEditEdit.Text = "Edit";
        }
        private void clearAddForm()
        {
            cmbAddBreedNo.SelectedIndex = -1;
            cmbAddCustomer.SelectedIndex = -1;
            cmbAddGender.SelectedIndex = 0;
            txtAddColour.Clear();
            txtAddName.Clear();
            dtpAddDOB.Value = new DateTime(2000, 1, 1);
        }
        private void getNumber(int noRows)
        {
            drDog = dsInTheDogHouse.Tables["Dog"].Rows[noRows - 1];
            lblAddDogNumber.Text = (int.Parse(drDog["DogNo"].ToString()) + 1).ToString();
        }

        private void AddTabValidate(object sender, EventArgs e)
        {
            if (dgvDisplay.SelectedRows.Count == 0)
            {
                dogSelected = false;
                dogNoSelected = 0;
            }
            else if (dgvDisplay.SelectedRows.Count == 1)
            {
                dogSelected = true;
                dogNoSelected = int.Parse(dgvDisplay.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void EditTabValidate(object sender, EventArgs e)
        {
            if (dogSelected != false && dogNoSelected != 0)
            {
                dogSelected = false;
                dogNoSelected = 0;
            }
            else if (dgvDisplay.SelectedRows.Count == 1)
            {
                dogSelected = true;
                dogNoSelected = int.Parse(dgvDisplay.SelectedRows[0].Cells[0].Value.ToString());
            }
        }
        private void MainPage_Shown(object sender, EventArgs e)
        {
            tabDogHouse.TabPages[0].CausesValidation = true;
            tabDogHouse.TabPages[0].Validating += new CancelEventHandler(AddTabValidate);

            tabDogHouse.TabPages[2].CausesValidation = true;
            tabDogHouse.TabPages[2].Validating += new CancelEventHandler(EditTabValidate);
        }

        private void btnDisplayExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
