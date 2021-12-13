
namespace InTheDogHouse
{
    partial class frmSize
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSize));
            this.dgvDisplay = new System.Windows.Forms.DataGridView();
            this.lblSizeID = new System.Windows.Forms.Label();
            this.lblCharge = new System.Windows.Forms.Label();
            this.lblSizeNo = new System.Windows.Forms.Label();
            this.errP = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnDisplayExit = new System.Windows.Forms.Button();
            this.btnDisplayDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEditEdit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.numCharge = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCharge)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDisplay
            // 
            this.dgvDisplay.AllowUserToAddRows = false;
            this.dgvDisplay.AllowUserToDeleteRows = false;
            this.dgvDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDisplay.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisplay.Location = new System.Drawing.Point(12, 12);
            this.dgvDisplay.MultiSelect = false;
            this.dgvDisplay.Name = "dgvDisplay";
            this.dgvDisplay.ReadOnly = true;
            this.dgvDisplay.RowTemplate.Height = 25;
            this.dgvDisplay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDisplay.Size = new System.Drawing.Size(330, 236);
            this.dgvDisplay.TabIndex = 22;
            this.dgvDisplay.SelectionChanged += new System.EventHandler(this.dgvDisplay_SelectionChanged);
            // 
            // lblSizeID
            // 
            this.lblSizeID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSizeID.AutoSize = true;
            this.lblSizeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSizeID.Location = new System.Drawing.Point(521, 17);
            this.lblSizeID.Name = "lblSizeID";
            this.lblSizeID.Size = new System.Drawing.Size(96, 25);
            this.lblSizeID.TabIndex = 26;
            this.lblSizeID.Text = "9999999";
            // 
            // lblCharge
            // 
            this.lblCharge.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCharge.AutoSize = true;
            this.lblCharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCharge.Location = new System.Drawing.Point(348, 67);
            this.lblCharge.Name = "lblCharge";
            this.lblCharge.Size = new System.Drawing.Size(165, 25);
            this.lblCharge.TabIndex = 24;
            this.lblCharge.Text = "Charge Per Day";
            // 
            // lblSizeNo
            // 
            this.lblSizeNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSizeNo.AutoSize = true;
            this.lblSizeNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSizeNo.Location = new System.Drawing.Point(348, 17);
            this.lblSizeNo.Name = "lblSizeNo";
            this.lblSizeNo.Size = new System.Drawing.Size(87, 25);
            this.lblSizeNo.TabIndex = 23;
            this.lblSizeNo.Text = "Size No";
            // 
            // errP
            // 
            this.errP.ContainerControl = this;
            // 
            // btnDisplayExit
            // 
            this.btnDisplayExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDisplayExit.FlatAppearance.BorderSize = 0;
            this.btnDisplayExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisplayExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplayExit.Image = global::InTheDogHouse.Properties.Resources._2DogsIcon;
            this.btnDisplayExit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDisplayExit.Location = new System.Drawing.Point(543, 193);
            this.btnDisplayExit.Name = "btnDisplayExit";
            this.btnDisplayExit.Size = new System.Drawing.Size(176, 55);
            this.btnDisplayExit.TabIndex = 46;
            this.btnDisplayExit.Text = "Exit";
            this.btnDisplayExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDisplayExit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnDisplayExit.UseVisualStyleBackColor = true;
            this.btnDisplayExit.Click += new System.EventHandler(this.btnDisplayExit_Click);
            // 
            // btnDisplayDelete
            // 
            this.btnDisplayDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDisplayDelete.FlatAppearance.BorderSize = 0;
            this.btnDisplayDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisplayDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplayDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDisplayDelete.Image")));
            this.btnDisplayDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDisplayDelete.Location = new System.Drawing.Point(348, 193);
            this.btnDisplayDelete.Name = "btnDisplayDelete";
            this.btnDisplayDelete.Size = new System.Drawing.Size(164, 55);
            this.btnDisplayDelete.TabIndex = 45;
            this.btnDisplayDelete.Text = "Delete";
            this.btnDisplayDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDisplayDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnDisplayDelete.UseVisualStyleBackColor = true;
            this.btnDisplayDelete.Click += new System.EventHandler(this.btnDisplayDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = global::InTheDogHouse.Properties.Resources.pepsiIcon;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.Location = new System.Drawing.Point(540, 121);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(179, 55);
            this.btnSave.TabIndex = 44;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEditEdit
            // 
            this.btnEditEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditEdit.FlatAppearance.BorderSize = 0;
            this.btnEditEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditEdit.Image = global::InTheDogHouse.Properties.Resources.keanoIcon;
            this.btnEditEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditEdit.Location = new System.Drawing.Point(353, 121);
            this.btnEditEdit.Name = "btnEditEdit";
            this.btnEditEdit.Size = new System.Drawing.Size(159, 55);
            this.btnEditEdit.TabIndex = 43;
            this.btnEditEdit.Text = "Edit";
            this.btnEditEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnEditEdit.UseVisualStyleBackColor = true;
            this.btnEditEdit.Visible = false;
            this.btnEditEdit.Click += new System.EventHandler(this.btnEditEdit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Image = global::InTheDogHouse.Properties.Resources.pepsiIcon2;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.Location = new System.Drawing.Point(348, 121);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(164, 55);
            this.btnCancel.TabIndex = 32;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnNew
            // 
            this.btnNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNew.FlatAppearance.BorderSize = 0;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.Image")));
            this.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNew.Location = new System.Drawing.Point(526, 121);
            this.btnNew.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(193, 55);
            this.btnNew.TabIndex = 31;
            this.btnNew.Text = "New Size";
            this.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNew.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // numCharge
            // 
            this.numCharge.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numCharge.DecimalPlaces = 2;
            this.numCharge.Enabled = false;
            this.numCharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numCharge.Location = new System.Drawing.Point(526, 67);
            this.numCharge.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numCharge.Name = "numCharge";
            this.numCharge.Size = new System.Drawing.Size(204, 31);
            this.numCharge.TabIndex = 49;
            // 
            // frmSize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 260);
            this.Controls.Add(this.numCharge);
            this.Controls.Add(this.btnDisplayExit);
            this.Controls.Add(this.btnDisplayDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnEditEdit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.lblSizeID);
            this.Controls.Add(this.lblCharge);
            this.Controls.Add(this.lblSizeNo);
            this.Controls.Add(this.dgvDisplay);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSize";
            this.Text = "Dog Breeds";
            this.Load += new System.EventHandler(this.frmBreed_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCharge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvDisplay;
        private System.Windows.Forms.Label lblSizeID;
        private System.Windows.Forms.Label lblCharge;
        private System.Windows.Forms.Label lblSizeNo;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnEditEdit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ErrorProvider errP;
        private System.Windows.Forms.Button btnDisplayExit;
        private System.Windows.Forms.Button btnDisplayDelete;
        private System.Windows.Forms.NumericUpDown numCharge;
    }
}