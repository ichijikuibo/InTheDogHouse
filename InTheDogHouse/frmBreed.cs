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
    public partial class frmBreed : Form
    {

        bool editing = false;
        bool adding = false;
        DataRow drSelected;
        DataSet dsInTheDogHouse = new DataSet();
        SqlCommandBuilder sqlBBreed;
        SqlDataAdapter daBreed,daSize,daDog;
        DataRow drBreed;
        string sqlBreed,sqlSize,sqlDog;

        frmContainer container;
        public frmBreed(frmContainer container)
        {
            this.container = container;
            InitializeComponent();
        }
        private void frmBreed_Load(object sender, EventArgs e)
        {
            sqlBreed = @"select * from Breed";
            daBreed = new SqlDataAdapter(sqlBreed, container.connStr);
            sqlBBreed = new SqlCommandBuilder(daBreed);
            daBreed.FillSchema(dsInTheDogHouse, SchemaType.Source, "Breed");
            daBreed.Fill(dsInTheDogHouse, "Breed");

            sqlSize = @"select * from Size";
            daSize = new SqlDataAdapter(sqlSize, container.connStr);
            daSize.FillSchema(dsInTheDogHouse, SchemaType.Source, "Size");
            daSize.Fill(dsInTheDogHouse, "Size");

            sqlDog= @"select * from Dog";
            daDog = new SqlDataAdapter(sqlDog, container.connStr);
            daDog.FillSchema(dsInTheDogHouse, SchemaType.Source, "Dog");
            daDog.Fill(dsInTheDogHouse, "Dog");

            dsInTheDogHouse.Tables["Size"].Columns.Add("ComboDisplay", typeof(string), "SizeNo + ' - £' + ChargePerDay");

            cmbBreedSize.DataSource = dsInTheDogHouse.Tables["Size"];
            cmbBreedSize.ValueMember = "SizeNo";
            cmbBreedSize.DisplayMember = "ComboDisplay";

            dgvDisplay.DataSource = dsInTheDogHouse.Tables["Breed"];
            dgvDisplay.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void dgvDisplay_SelectionChanged(object sender, EventArgs e)
        {
            if (!editing && !adding)
            {
                if (dgvDisplay.SelectedRows.Count > 0)
                {
                    btnEditEdit.Visible = true;
                    btnDisplayDelete.Visible = true;
                    fillForm(dgvDisplay.SelectedRows[0].Cells[0].Value.ToString());
                }
                else
                {
                    btnDisplayDelete.Visible = false;
                    btnEditEdit.Visible = false;
                    clearForm();
                }
            }
        }
        private void clearForm()
        {
            lblBreedID.Text = "-";
            txtBreedName.Clear();
        }
        private void fillForm(string selectedID)
        {
            lblBreedID.Text = selectedID;
            drSelected = dsInTheDogHouse.Tables["Breed"].Rows.Find(selectedID);
            txtBreedName.Text = drSelected["BreedName"].ToString();
            cmbBreedSize.SelectedValue = drSelected["SizeB"];

        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            if (!editing && !adding)
            {
                clearForm();
                adding = true;
                btnEditEdit.Visible = false;
                btnCancel.Visible = true;
                btnSave.Visible = true;
                btnNew.Visible = false;
                txtBreedName.Enabled = true;
                cmbBreedSize.Enabled = true;
                btnDisplayExit.Visible = false;
                btnDisplayDelete.Visible = false;
                getNumber(dsInTheDogHouse.Tables["Breed"].Rows.Count);
            }
        }
        private void getNumber(int noRows)
        {
            drBreed = dsInTheDogHouse.Tables["Breed"].Rows[noRows - 1];
            lblBreedID.Text = (int.Parse(drBreed["BreedNo"].ToString()) + 1).ToString();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!adding && !editing) return;
            BreedModel breed = new BreedModel();
            bool ok = true;
            errP.Clear();

            if (!assignProperty(lblBreedID, () => breed.BreedNo = int.Parse(lblBreedID.Text))) ok = false;
            if (!assignProperty(txtBreedName, () => breed.Breed = txtBreedName.Text)) ok = false;
            if (cmbBreedSize.SelectedIndex < 0)
            {
                errP.SetError(cmbBreedSize, "Please select a breed");
                ok = false;
            }
            else if (!assignProperty(cmbBreedSize, () => breed.BreedSize = (int)cmbBreedSize.SelectedValue)) ok = false;

            if (ok)
            {
                try
                {
                    if ((adding))
                    {

                        drBreed = dsInTheDogHouse.Tables["Breed"].NewRow();
                        breedToDataRow(drBreed, breed);
                        dsInTheDogHouse.Tables["Breed"].Rows.Add(drBreed);
                        daBreed.Update(dsInTheDogHouse, "Breed");
                        clearForm();
                        if (MessageBox.Show("Breed Added - Do you wish to add another breed?", "Add Breed", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            getNumber(dsInTheDogHouse.Tables["Breed"].Rows.Count);
                        }
                        else
                        {
                            btnSave.Visible = false;
                            btnEditEdit.Visible = false;
                            btnCancel.Visible = false;
                            btnNew.Visible = true;
                            btnDisplayExit.Visible = true;
                            txtBreedName.Enabled = false;
                            cmbBreedSize.Enabled = false;

                            adding = false;
                            dgvDisplay_SelectionChanged(dgvDisplay, e);
                        }
                    }
                    else
                    {
                        drSelected.BeginEdit();
                        breedToDataRow(drSelected, breed);

                        drSelected.EndEdit();
                        daBreed.Update(dsInTheDogHouse, "Breed");
                        MessageBox.Show("Breed Details Updated", "Breed");
                        btnSave.Visible = false;
                        btnEditEdit.Visible = false;
                        btnCancel.Visible = false;
                        btnNew.Visible = true;
                        btnDisplayExit.Visible = true;
                        txtBreedName.Enabled = false;
                        cmbBreedSize.Enabled = false;

                        editing = false;
                        dgvDisplay_SelectionChanged(dgvDisplay, e);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.TargetSite + " " + ex.Message, "Error", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
                }
            }
        }
        private void breedToDataRow(DataRow row, BreedModel breed)
        {
            row["BreedNo"] = breed.BreedNo;
            row["BreedName"] = breed.Breed;
            row["SizeB"] = breed.BreedSize;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            bool cancel = false;
            if(adding)
            {
                if(MessageBox.Show("Are you sure you want to cancel adding the breed "+txtBreedName.Text + "?","Cancel Adding Breed",MessageBoxButtons.YesNo)==DialogResult.Yes)
                {
                    cancel = true;
                    adding = false;
                }
            }
            if (editing)
            {
                if (MessageBox.Show("Are you sure you want to cancel editing the breed " + txtBreedName.Text + "?", "Cancel Editing Breed", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    editing = false;
                    cancel = true;
                }
            }
            if (cancel)
            {
                clearForm();
                btnSave.Visible = false;
                btnEditEdit.Visible = false;
                btnCancel.Visible = false;
                btnNew.Visible = true;
                txtBreedName.Enabled = false;
                cmbBreedSize.Enabled = false;
                btnDisplayExit.Visible = true;
                adding = false;
                dgvDisplay_SelectionChanged(dgvDisplay, e);
            }
        }



        private void btnEditEdit_Click(object sender, EventArgs e)
        {
            editing = true;
            btnEditEdit.Visible = false;
            btnCancel.Visible = true;
            btnSave.Visible = true;
            btnNew.Visible = false;
            txtBreedName.Enabled = true;
            cmbBreedSize.Enabled = true;
            btnDisplayExit.Visible = false;
            btnDisplayDelete.Visible = false;
        }

        private void btnDisplayExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDisplayDelete_Click(object sender, EventArgs e)
        {
            if (dgvDisplay.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a breed from the list.", "Select Breed");
            }
            else
            {


                drBreed = dsInTheDogHouse.Tables["Breed"].Rows.Find(dgvDisplay.SelectedRows[0].Cells[0].Value);

                bool inUse = false;
                foreach (DataRow dr in dsInTheDogHouse.Tables["Dog"].Rows)
                {
                    if (dr["BreedNo"].Equals(drBreed["BreedNo"])) inUse = true;
                }
                if (inUse)
                {
                    MessageBox.Show("Unable to delete breed it is in use by a dog", "Breed in Use ", MessageBoxButtons.OK);
                }
                else
                {
                    if (MessageBox.Show("Are you sure you want to delete " + drBreed["BreedName"].ToString() + " details", "Delete Breed", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        drBreed.Delete();
                        daBreed.Update(dsInTheDogHouse, "Breed");
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
    }
}
