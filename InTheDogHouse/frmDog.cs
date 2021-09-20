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

        SqlDataAdapter daCustomer,daBreed,daDog;
        SqlCommandBuilder cmdBCustomer,cmdBDog,cmdBBreed;
        DataRow drCustomer,drBreed,drDog;
        string connStr, sqlCustomer,sqlDog,sqlBreed;
        DataSet dsInTheDogHouse = new DataSet();
        int selectedTab = 0;
        bool dogSelected = false;
        int dogNoSelected = 0;
        public frmDog()
        {
            InitializeComponent();
        }
        private void btnAddAdd_Click(object sender, EventArgs e)
        {
            Dog dog = new Dog();
            bool ok = true;
            errP.Clear();

            if (!assignProperty(lblEditDogNumber, () => dog.IdNo = int.Parse(lblEditDogNumber.Text))) ok = false;
            if (!assignProperty(txtAddName, () => dog.Name = txtAddName.Text)) ok = false;
            if (!assignProperty(cmbAddBreed, () => dog.BreedNo = int.Parse(cmbAddBreed.Text))) ok = false;
            if (!assignProperty(txtAddColour, () => dog.Colour = txtAddColour.Text)) ok = false;
            if (!assignProperty(dtAddDOB, () => dog.Dob = dtAddDOB.Value)) ok = false;
            if (!assignProperty(cmbAddGender, () => dog.Gender = cmbAddGender.Text)) ok = false;
            if (!assignProperty(cmbAddCustomerNo, () => dog.CustomerNo = int.Parse(cmbAddCustomerNo.Text))) ok = false;


            if (ok)
            {
                try
                {
                    drDog = dsInTheDogHouse.Tables["Dog"].NewRow();
                    dogToDataRow(drDog, dog);
                    dsInTheDogHouse.Tables["Dog"].Rows.Add(drCustomer);
                    daCustomer.Update(dsInTheDogHouse, "Dog");

                    if (MessageBox.Show("Dog Added - Do you wish to add another Dog", "Add Dog", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        //clearAddForm();
                        //getNumber(dsInTheDogHouse.Tables["Customer"].Rows.Count);
                    }
                    else
                    {
                        tabDogHouse.SelectedIndex = 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.TargetSite + " " + ex.Message, "Error", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
                    drCustomer.Delete();
                }
            }
        }
        private void dogToDataRow(DataRow row, Dog dog)
        {
            row["DogNo"] = dog.IdNo;
            row["BreedNo"] = dog.BreedNo;
            row["DOB"] = dog.Dob;
            row["Name"] = dog.Name;
            row["Gender"] = dog.Gender;
            row["Colour"] = dog.Colour;
            row["CustomerNo"] = dog.CustomerNo;

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


        private void frmDog_Load(object sender, EventArgs e)
        {
            connStr = @"Data Source = .; Initial Catalog = InTheDogHouse; Integrated Security = true";
            sqlCustomer = @"select * from Customer";
            daCustomer = new SqlDataAdapter(sqlCustomer, connStr);
            cmdBCustomer = new SqlCommandBuilder(daCustomer);
            daCustomer.FillSchema(dsInTheDogHouse, SchemaType.Source, "Customer");
            daCustomer.Fill(dsInTheDogHouse, "Customer");

            sqlDog = @"select * from Dog";
            daDog = new SqlDataAdapter(sqlDog, connStr);
            cmdBDog = new SqlCommandBuilder(daDog);
            daDog.FillSchema(dsInTheDogHouse, SchemaType.Source, "Dog");
            daDog.Fill(dsInTheDogHouse, "Dog");

            connStr = @"Data Source = .; Initial Catalog = InTheDogHouse; Integrated Security = true";
            sqlBreed = @"select * from Breed";
            daBreed = new SqlDataAdapter(sqlBreed, connStr);
            cmdBBreed = new SqlCommandBuilder(daBreed);
            daBreed.FillSchema(dsInTheDogHouse, SchemaType.Source, "Breed");
            daBreed.Fill(dsInTheDogHouse, "Breed");

            dgvDisplay.DataSource = dsInTheDogHouse.Tables["Dog"];

            cmbAddBreed.DataSource = dsInTheDogHouse.Tables["Breed"];
            cmbAddBreed.DisplayMember = "BreedName";
            cmbAddBreed.ValueMember = "BreedNo";
            cmbAddCustomerNo.DataSource = dsInTheDogHouse.Tables["Customer"];
            cmbAddCustomerNo.DisplayMember = "CustomerNo";
            cmbAddCustomerNo.ValueMember = "CustomerNo";

            cmbEditBreed.DataSource = dsInTheDogHouse.Tables["Breed"];
            cmbEditBreed.DisplayMember = "BreedName";
            cmbEditBreed.ValueMember = "BreedNo";
            cmbEditCustomerNo.DataSource = dsInTheDogHouse.Tables["Customer"];
            cmbEditCustomerNo.DisplayMember = "CustomerNo";
            cmbEditCustomerNo.ValueMember = "CustomerNo";
        }
    }
}
