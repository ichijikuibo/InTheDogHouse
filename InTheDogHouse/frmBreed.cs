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
        string[] pictures = { "dogs.jpg", "dogs2.jpg", "dogs3.jpg", "dogs4.jpg", "dogs5.jpg", "dogs6.jpg", "dogs7.jpg", "dogs8.jpg" };
        int pictureIndex = 0;
        bool editing = false;
        bool adding = false;
        DataRow drSelected;
        DataSet dsInTheDogHouse = new DataSet();
        SqlCommandBuilder cmdBBreed;
        SqlDataAdapter daBreed;
        DataRow drBreed;
        string connStr, sqlBreed;
        public frmBreed()
        {
            InitializeComponent();
        }
        private void frmBreed_Load(object sender, EventArgs e)
        {
            picDogs.ImageLocation = @"Images\Slideshow\dogs.jpg";
            connStr = @"Data Source = .\SQLEXPRESS; Initial Catalog = InTheDogHouse; Integrated Security = true";
            sqlBreed = @"select * from Breed";
            daBreed = new SqlDataAdapter(sqlBreed, connStr);
            cmdBBreed = new SqlCommandBuilder(daBreed);
            daBreed.FillSchema(dsInTheDogHouse, SchemaType.Source, "Breed");
            daBreed.Fill(dsInTheDogHouse, "Breed");
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
            selectBreedSize(1);
            txtBreedName.Clear();
        }
        private void fillForm(string selectedID)
        {
            lblBreedID.Text = selectedID;
            drSelected = dsInTheDogHouse.Tables["Breed"].Rows.Find(selectedID);
            txtBreedName.Text = drSelected["BreedName"].ToString();
            selectBreedSize(int.Parse(drSelected["SizeB"].ToString()));

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
                gbBreedSize.Enabled = true;
                btnDisplayExit.Visible = false;
                btnDisplayDelete.Visible = false;
                selectBreedSize(1);
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
            if (!assignProperty(gbBreedSize, () => breed.BreedSize = getSelectedBreedSize())) ok = false;

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
                            gbBreedSize.Enabled = false;

                            adding = false;
                            selectBreedSize(1);
                            dgvDisplay_SelectionChanged(dgvDisplay, e);
                        }
                    }
                    else
                    {
                        drSelected.BeginEdit();
                        breedToDataRow(drSelected, breed);
                        drSelected.EndEdit();
                        MessageBox.Show("Breed Details Updated", "Breed");
                        btnSave.Visible = false;
                        btnEditEdit.Visible = false;
                        btnCancel.Visible = false;
                        btnNew.Visible = true;
                        btnDisplayExit.Visible = true;
                        txtBreedName.Enabled = false;
                        gbBreedSize.Enabled = false;

                        editing = false;
                        selectBreedSize(1);
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
                gbBreedSize.Enabled = false;
                btnDisplayExit.Visible = true;
                adding = false;
                selectBreedSize(1);
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
            gbBreedSize.Enabled = true;
            btnDisplayExit.Visible = false;
            btnDisplayDelete.Visible = false;
        }

        private void timPictureChange_Tick(object sender, EventArgs e)
        {
            if (pictureIndex == pictures.Length - 1) pictureIndex = 0;
            else pictureIndex++;
            picDogs.ImageLocation = @"Images\Slideshow\"+pictures[pictureIndex];
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
                if (MessageBox.Show("Are you sure you want to delete " + drBreed["BreedName"].ToString() + " details", "Delete Breed", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    drBreed.Delete();
                    daBreed.Update(dsInTheDogHouse, "Breed");
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
        private int getSelectedBreedSize()
        {
            if (prbSmall.Selected) return 1;
            if (prbMedium.Selected) return 2;
            if (prbLarge.Selected) return 3;
            if (prbGiant.Selected) return 4;
            return 0;
        }
        private void selectBreedSize(int size)
        {
            switch(size)
            {
                case 1: prbSmall.Selected = true; break;
                case 2: prbMedium.Selected = true; break;
                case 3: prbLarge.Selected = true; break;
                case 4: prbGiant.Selected = true; break;
            }
        }
    }
}
