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
    public partial class frmSize : Form
    { 
        bool editing = false;
        bool adding = false;
        DataRow drSelected;
        SqlCommandBuilder sqlBSize;
        DataSet dsInTheDogHouse = new DataSet();
        SqlDataAdapter daSize, daBreed;
        DataRow drSize;
        string sqlSize,sqlBreed;

        frmContainer container;
        public frmSize(frmContainer container)
        {
            this.container = container;
            InitializeComponent();
        }
        private void frmBreed_Load(object sender, EventArgs e)
        {
            sqlSize = @"select * from Size";
            daSize = new SqlDataAdapter(sqlSize, container.connStr);
            sqlBSize = new SqlCommandBuilder(daSize);
            daSize.FillSchema(dsInTheDogHouse, SchemaType.Source, "Size");
            daSize.Fill(dsInTheDogHouse, "Size");

            sqlBreed = @"select * from Breed";
            daBreed = new SqlDataAdapter(sqlBreed, container.connStr);
            daBreed.FillSchema(dsInTheDogHouse, SchemaType.Source, "Breed");
            daBreed.Fill(dsInTheDogHouse, "Breed");

            dgvDisplay.DataSource = dsInTheDogHouse.Tables["Size"];
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
            lblSizeID.Text = "-";
            numCharge.Value = 1;
        }
        private void fillForm(string selectedID)
        {
            lblSizeID.Text = selectedID;
            drSelected = dsInTheDogHouse.Tables["Size"].Rows.Find(selectedID);
            numCharge.Value = decimal.Parse(drSelected["ChargePerDay"].ToString());

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
                numCharge.Enabled = true;
                btnDisplayExit.Visible = false;
                btnDisplayDelete.Visible = false;
                getNumber(dsInTheDogHouse.Tables["Size"].Rows.Count);
            }
        }
        private void getNumber(int noRows)
        {
            drSize = dsInTheDogHouse.Tables["Size"].Rows[noRows - 1];
            lblSizeID.Text = (int.Parse(drSize["SizeNo"].ToString()) + 1).ToString();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!adding && !editing) return;
            SizeModel size = new SizeModel();
            bool ok = true;
            errP.Clear();

            if (!assignProperty(lblSizeID, () => size.SizeNo = int.Parse(lblSizeID.Text))) ok = false;
            if (!assignProperty(numCharge, () => size.Charge = (double)numCharge.Value)) ok = false;

            if (ok)
            {
                try
                {
                    if ((adding))
                    {

                        drSize = dsInTheDogHouse.Tables["Size"].NewRow();
                        sizeToDataRow(drSize, size);
                        dsInTheDogHouse.Tables["Size"].Rows.Add(drSize);
                        daSize.Update(dsInTheDogHouse, "Size");
                        clearForm();
                        if (MessageBox.Show("Size Added - Do you wish to add another Size?", "Add Size", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            getNumber(dsInTheDogHouse.Tables["Size"].Rows.Count);
                        }
                        else
                        {
                            btnSave.Visible = false;
                            btnEditEdit.Visible = false;
                            btnCancel.Visible = false;
                            btnNew.Visible = true;
                            btnDisplayExit.Visible = true;
                            numCharge.Enabled = false;

                            adding = false;
                            dgvDisplay_SelectionChanged(dgvDisplay, e);
                        }
                    }
                    else
                    {
                        drSelected.BeginEdit();
                        sizeToDataRow(drSelected, size);
                        drSelected.EndEdit();
                        daSize.Update(dsInTheDogHouse, "Size");

                        MessageBox.Show("Size Details Updated", "Size");
                        btnSave.Visible = false;
                        btnEditEdit.Visible = false;
                        btnCancel.Visible = false;
                        btnNew.Visible = true;
                        btnDisplayExit.Visible = true;
                        numCharge.Enabled = false;
  

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
        private void sizeToDataRow(DataRow row, SizeModel size)
        {
            row["SizeNo"] = size.SizeNo;
            row["ChargePerDay"] = size.Charge;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            bool cancel = false;
            if(adding)
            {
                if(MessageBox.Show("Are you sure you want to cancel adding the size "+lblSizeID.Text + "?","Cancel Adding Size",MessageBoxButtons.YesNo)==DialogResult.Yes)
                {
                    cancel = true;
                    adding = false;
                }
            }
            if (editing)
            {
                if (MessageBox.Show("Are you sure you want to cancel editing the size " + lblSizeID.Text + "?", "Cancel Editing Size", MessageBoxButtons.YesNo) == DialogResult.Yes)
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
                numCharge.Enabled = false;
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
            numCharge.Enabled = true;
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
                MessageBox.Show("Please select a size from the list.", "Select Size");
            }
            else
            {
                drSize = dsInTheDogHouse.Tables["Size"].Rows.Find(dgvDisplay.SelectedRows[0].Cells[0].Value);
                bool inUse = false;
                foreach(DataRow dr in dsInTheDogHouse.Tables["Breed"].Rows)
                {
                    if (dr["SizeB"].Equals(drSize["SizeNo"])) inUse = true;
                }
                if (inUse)
                {
                    MessageBox.Show("Unable to delete size it is in use by a breed", "Size in Use ", MessageBoxButtons.OK);
                }
                else
                {
                    if (MessageBox.Show("Are you sure you want to delete size no " + drSize["SizeNo"].ToString() + " details", "Delete Size", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        drSize.Delete();
                        daSize.Update(dsInTheDogHouse, "Breed");
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
