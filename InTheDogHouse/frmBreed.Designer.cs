
namespace InTheDogHouse
{
    partial class frmBreed
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBreed));
            this.dgvDisplay = new System.Windows.Forms.DataGridView();
            this.txtBreedName = new System.Windows.Forms.TextBox();
            this.lblBreedID = new System.Windows.Forms.Label();
            this.lblBreedName = new System.Windows.Forms.Label();
            this.lblAddCustomerNo = new System.Windows.Forms.Label();
            this.errP = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnDisplayExit = new System.Windows.Forms.Button();
            this.btnDisplayDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEditEdit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbBreedSize = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errP)).BeginInit();
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
            this.dgvDisplay.Size = new System.Drawing.Size(330, 351);
            this.dgvDisplay.TabIndex = 22;
            this.dgvDisplay.SelectionChanged += new System.EventHandler(this.dgvDisplay_SelectionChanged);
            // 
            // txtBreedName
            // 
            this.txtBreedName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBreedName.Enabled = false;
            this.txtBreedName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBreedName.Location = new System.Drawing.Point(500, 69);
            this.txtBreedName.Name = "txtBreedName";
            this.txtBreedName.Size = new System.Drawing.Size(219, 31);
            this.txtBreedName.TabIndex = 28;
            // 
            // lblBreedID
            // 
            this.lblBreedID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBreedID.AutoSize = true;
            this.lblBreedID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBreedID.Location = new System.Drawing.Point(495, 19);
            this.lblBreedID.Name = "lblBreedID";
            this.lblBreedID.Size = new System.Drawing.Size(96, 25);
            this.lblBreedID.TabIndex = 26;
            this.lblBreedID.Text = "9999999";
            // 
            // lblBreedName
            // 
            this.lblBreedName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBreedName.AutoSize = true;
            this.lblBreedName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBreedName.Location = new System.Drawing.Point(348, 75);
            this.lblBreedName.Name = "lblBreedName";
            this.lblBreedName.Size = new System.Drawing.Size(131, 25);
            this.lblBreedName.TabIndex = 24;
            this.lblBreedName.Text = "Breed Name";
            // 
            // lblAddCustomerNo
            // 
            this.lblAddCustomerNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAddCustomerNo.AutoSize = true;
            this.lblAddCustomerNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddCustomerNo.Location = new System.Drawing.Point(348, 19);
            this.lblAddCustomerNo.Name = "lblAddCustomerNo";
            this.lblAddCustomerNo.Size = new System.Drawing.Size(102, 25);
            this.lblAddCustomerNo.TabIndex = 23;
            this.lblAddCustomerNo.Text = "Breed No";
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
            this.btnDisplayExit.Location = new System.Drawing.Point(543, 302);
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
            this.btnDisplayDelete.Location = new System.Drawing.Point(348, 302);
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
            this.btnSave.Location = new System.Drawing.Point(540, 230);
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
            this.btnEditEdit.Location = new System.Drawing.Point(353, 230);
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
            this.btnCancel.Location = new System.Drawing.Point(348, 230);
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
            this.btnNew.Location = new System.Drawing.Point(526, 230);
            this.btnNew.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(193, 55);
            this.btnNew.TabIndex = 31;
            this.btnNew.Text = "New Breed";
            this.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNew.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(348, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 25);
            this.label1.TabIndex = 49;
            this.label1.Text = "Breed Size";
            // 
            // cmbBreedSize
            // 
            this.cmbBreedSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbBreedSize.Enabled = false;
            this.cmbBreedSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBreedSize.FormattingEnabled = true;
            this.cmbBreedSize.Location = new System.Drawing.Point(500, 128);
            this.cmbBreedSize.Name = "cmbBreedSize";
            this.cmbBreedSize.Size = new System.Drawing.Size(219, 33);
            this.cmbBreedSize.TabIndex = 50;
            // 
            // frmBreed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 375);
            this.Controls.Add(this.cmbBreedSize);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDisplayExit);
            this.Controls.Add(this.btnDisplayDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnEditEdit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.txtBreedName);
            this.Controls.Add(this.lblBreedID);
            this.Controls.Add(this.lblBreedName);
            this.Controls.Add(this.lblAddCustomerNo);
            this.Controls.Add(this.dgvDisplay);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBreed";
            this.Text = "Dog Breeds";
            this.Load += new System.EventHandler(this.frmBreed_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvDisplay;
        private System.Windows.Forms.TextBox txtBreedName;
        private System.Windows.Forms.Label lblBreedID;
        private System.Windows.Forms.Label lblBreedName;
        private System.Windows.Forms.Label lblAddCustomerNo;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnEditEdit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ErrorProvider errP;
        private System.Windows.Forms.Button btnDisplayExit;
        private System.Windows.Forms.Button btnDisplayDelete;
        private System.Windows.Forms.ComboBox cmbBreedSize;
        private System.Windows.Forms.Label label1;
    }
}