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
    public partial class frmKennel : Form
    {

        bool editing = false;
        bool adding = false;
        DataRow drSelected;
        DataSet dsInTheDogHouse = new DataSet();
        SqlCommandBuilder sqlBKennel;
        SqlDataAdapter daKennel,daSize;
        DataRow drKennel;
        string connStr, sqlKennel, sqlSize;
        public frmKennel()
        {
            InitializeComponent();
        }
        private void frmBreed_Load(object sender, EventArgs e)
        {
            connStr = @"Data Source = .\SQLEXPRESS; Initial Catalog = InTheDogHouse; Integrated Security = true";
            sqlKennel = @"select * from Kennel";
            daKennel = new SqlDataAdapter(sqlKennel, connStr);
            sqlBKennel = new SqlCommandBuilder(daKennel);
            daKennel.FillSchema(dsInTheDogHouse, SchemaType.Source, "Kennel");
            daKennel.Fill(dsInTheDogHouse, "Kennel");

            sqlSize = @"select * from Size";
            daSize = new SqlDataAdapter(sqlSize, connStr);
            daSize.FillSchema(dsInTheDogHouse, SchemaType.Source, "Size");
            daSize.Fill(dsInTheDogHouse, "Size");


            dsInTheDogHouse.Tables["Size"].Columns.Add("ComboDisplay", typeof(string), "SizeNo + ' - £' + ChargePerDay");

            cmbBreedSize.DataSource = dsInTheDogHouse.Tables["Size"];
            cmbBreedSize.ValueMember = "SizeNo";
            cmbBreedSize.DisplayMember = "ComboDisplay";

            dgvDisplay.DataSource = dsInTheDogHouse.Tables["Kennel"];
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
            lblKennelID.Text = "-";
        }
        private void fillForm(string selectedID)
        {
            lblKennelID.Text = selectedID;
            drSelected = dsInTheDogHouse.Tables["Kennel"].Rows.Find(selectedID);
            cmbBreedSize.SelectedValue = drSelected["SizeK"];

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
                cmbBreedSize.Enabled = true;
                btnDisplayExit.Visible = false;
                btnDisplayDelete.Visible = false;
                getNumber(dsInTheDogHouse.Tables["Kennel"].Rows.Count);
            }
        }
        private void getNumber(int noRows)
        {
            drKennel = dsInTheDogHouse.Tables["Kennel"].Rows[noRows - 1];
            lblKennelID.Text = (int.Parse(drKennel["KennelNo"].ToString()) + 1).ToString();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!adding && !editing) return;
            KennelModel kennel = new KennelModel();
            bool ok = true;
            errP.Clear();

            if (!assignProperty(lblKennelID, () => kennel.KennelNo = int.Parse(lblKennelID.Text))) ok = false;
            if (cmbBreedSize.SelectedIndex < 0)
            {
                errP.SetError(cmbBreedSize, "Please select a size");
                ok = false;
            }
            else if (!assignProperty(cmbBreedSize, () => kennel.KennelSize = (int)cmbBreedSize.SelectedValue)) ok = false;

            if (ok)
            {
                try
                {
                    if ((adding))
                    {

                        drKennel = dsInTheDogHouse.Tables["Kennel"].NewRow();
                        breedToDataRow(drKennel, kennel);
                        dsInTheDogHouse.Tables["Kennel"].Rows.Add(drKennel);
                        daKennel.Update(dsInTheDogHouse, "Kennel");
                        clearForm();
                        if (MessageBox.Show("Kennel Added - Do you wish to add another kennel?", "Add Kennel", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            getNumber(dsInTheDogHouse.Tables["Kennel"].Rows.Count);
                        }
                        else
                        {
                            btnSave.Visible = false;
                            btnEditEdit.Visible = false;
                            btnCancel.Visible = false;
                            btnNew.Visible = true;
                            btnDisplayExit.Visible = true;
                            cmbBreedSize.Enabled = false;

                            adding = false;
                            dgvDisplay_SelectionChanged(dgvDisplay, e);
                        }
                    }
                    else
                    {
                        drSelected.BeginEdit();
                        breedToDataRow(drSelected, kennel);

                        drSelected.EndEdit();
                        daKennel.Update(dsInTheDogHouse, "Kennel");
                        MessageBox.Show("Kennel Details Updated", "Kennel");
                        btnSave.Visible = false;
                        btnEditEdit.Visible = false;
                        btnCancel.Visible = false;
                        btnNew.Visible = true;
                        btnDisplayExit.Visible = true;
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
        private void breedToDataRow(DataRow row, KennelModel Kennel)
        {
            row["KennelNo"] = Kennel.KennelNo;
            row["SizeK"] = Kennel.KennelSize;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            bool cancel = false;
            if(adding)
            {
                if(MessageBox.Show("Are you sure you want to cancel adding the Kennel " + lblKennelID.Text + "?", "Cancel Adding Kennel", MessageBoxButtons.YesNo)==DialogResult.Yes)
                {
                    cancel = true;
                    adding = false;
                }
            }
            if (editing)
            {
                if (MessageBox.Show("Are you sure you want to cancel editing the Kennel " + lblKennelID.Text + "?", "Cancel Editing Kennel", MessageBoxButtons.YesNo) == DialogResult.Yes)
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


                drKennel = dsInTheDogHouse.Tables["Kennel"].Rows.Find(dgvDisplay.SelectedRows[0].Cells[0].Value);

                //bool inUse = false;
                //foreach (DataRow dr in dsInTheDogHouse.Tables["Dog"].Rows)
                //{
                //    if (dr["KennelNo"].Equals(drKennel["KennelNo"])) inUse = true;
                //}
                //if (inUse)
                //{
                //    MessageBox.Show("Unable to delete breed it is in use by a dog", "Breed in Use ", MessageBoxButtons.OK);
                //}
                //else
                //{
                    if (MessageBox.Show("Are you sure you want to delete " + drKennel["KennelName"].ToString() + " details", "Delete Kennel", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                    drKennel.Delete();
                    daKennel.Update(dsInTheDogHouse, "Kennel");
                    }
               // }
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
