
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
            this.timPictureChange = new System.Windows.Forms.Timer(this.components);
            this.picDogs = new System.Windows.Forms.PictureBox();
            this.btnDisplayExit = new System.Windows.Forms.Button();
            this.btnDisplayDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEditEdit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.gbBreedSize = new System.Windows.Forms.GroupBox();
            this.prbGiant = new InTheDogHouse.PictureRadioButton();
            this.prbMedium = new InTheDogHouse.PictureRadioButton();
            this.prbLarge = new InTheDogHouse.PictureRadioButton();
            this.prbSmall = new InTheDogHouse.PictureRadioButton();
            this.ssDogs = new InTheDogHouse.SlideShow();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDogs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.gbBreedSize.SuspendLayout();
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
            this.dgvDisplay.Location = new System.Drawing.Point(12, 147);
            this.dgvDisplay.MultiSelect = false;
            this.dgvDisplay.Name = "dgvDisplay";
            this.dgvDisplay.ReadOnly = true;
            this.dgvDisplay.RowTemplate.Height = 25;
            this.dgvDisplay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDisplay.Size = new System.Drawing.Size(330, 406);
            this.dgvDisplay.TabIndex = 22;
            this.dgvDisplay.SelectionChanged += new System.EventHandler(this.dgvDisplay_SelectionChanged);
            // 
            // txtBreedName
            // 
            this.txtBreedName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBreedName.Enabled = false;
            this.txtBreedName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBreedName.Location = new System.Drawing.Point(500, 185);
            this.txtBreedName.Name = "txtBreedName";
            this.txtBreedName.Size = new System.Drawing.Size(219, 31);
            this.txtBreedName.TabIndex = 28;
            // 
            // lblBreedID
            // 
            this.lblBreedID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBreedID.AutoSize = true;
            this.lblBreedID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBreedID.Location = new System.Drawing.Point(495, 147);
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
            this.lblBreedName.Location = new System.Drawing.Point(348, 185);
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
            this.lblAddCustomerNo.Location = new System.Drawing.Point(348, 147);
            this.lblAddCustomerNo.Name = "lblAddCustomerNo";
            this.lblAddCustomerNo.Size = new System.Drawing.Size(102, 25);
            this.lblAddCustomerNo.TabIndex = 23;
            this.lblAddCustomerNo.Text = "Breed No";
            // 
            // errP
            // 
            this.errP.ContainerControl = this;
            // 
            // timPictureChange
            // 
            this.timPictureChange.Enabled = true;
            this.timPictureChange.Interval = 2000;
            this.timPictureChange.Tick += new System.EventHandler(this.timPictureChange_Tick);
            // 
            // picDogs
            // 
            this.picDogs.ImageLocation = "Images\\Slideshow\\dogs.jpg";
            this.picDogs.Location = new System.Drawing.Point(541, 13);
            this.picDogs.Name = "picDogs";
            this.picDogs.Size = new System.Drawing.Size(189, 128);
            this.picDogs.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDogs.TabIndex = 47;
            this.picDogs.TabStop = false;
            // 
            // btnDisplayExit
            // 
            this.btnDisplayExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDisplayExit.FlatAppearance.BorderSize = 0;
            this.btnDisplayExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisplayExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplayExit.Image = global::InTheDogHouse.Properties.Resources._2DogsIcon;
            this.btnDisplayExit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDisplayExit.Location = new System.Drawing.Point(543, 498);
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
            this.btnDisplayDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDisplayDelete.FlatAppearance.BorderSize = 0;
            this.btnDisplayDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisplayDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplayDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDisplayDelete.Image")));
            this.btnDisplayDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDisplayDelete.Location = new System.Drawing.Point(348, 498);
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
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = global::InTheDogHouse.Properties.Resources.pepsiIcon;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.Location = new System.Drawing.Point(540, 426);
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
            this.btnEditEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditEdit.FlatAppearance.BorderSize = 0;
            this.btnEditEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditEdit.Image = global::InTheDogHouse.Properties.Resources.keanoIcon;
            this.btnEditEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditEdit.Location = new System.Drawing.Point(353, 426);
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
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Image = global::InTheDogHouse.Properties.Resources.pepsiIcon2;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.Location = new System.Drawing.Point(348, 426);
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
            this.btnNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNew.FlatAppearance.BorderSize = 0;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.Image")));
            this.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNew.Location = new System.Drawing.Point(526, 426);
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
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.ImageLocation = "";
            this.pictureBox4.Location = new System.Drawing.Point(12, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(522, 129);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 21;
            this.pictureBox4.TabStop = false;
            // 
            // gbBreedSize
            // 
            this.gbBreedSize.Controls.Add(this.prbGiant);
            this.gbBreedSize.Controls.Add(this.prbMedium);
            this.gbBreedSize.Controls.Add(this.prbLarge);
            this.gbBreedSize.Controls.Add(this.prbSmall);
            this.gbBreedSize.Enabled = false;
            this.gbBreedSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbBreedSize.Location = new System.Drawing.Point(353, 222);
            this.gbBreedSize.Name = "gbBreedSize";
            this.gbBreedSize.Size = new System.Drawing.Size(366, 179);
            this.gbBreedSize.TabIndex = 50;
            this.gbBreedSize.TabStop = false;
            this.gbBreedSize.Text = "Breed Size";
            // 
            // prbGiant
            // 
            this.prbGiant.ButtonText = "Giant";
            this.prbGiant.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prbGiant.Location = new System.Drawing.Point(173, 96);
            this.prbGiant.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.prbGiant.Name = "prbGiant";
            this.prbGiant.Picture = global::InTheDogHouse.Properties.Resources.huge;
            this.prbGiant.Selected = false;
            this.prbGiant.SelectedColour = System.Drawing.Color.Red;
            this.prbGiant.Size = new System.Drawing.Size(180, 74);
            this.prbGiant.TabIndex = 52;
            // 
            // prbMedium
            // 
            this.prbMedium.ButtonText = "Medium";
            this.prbMedium.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prbMedium.Location = new System.Drawing.Point(173, 23);
            this.prbMedium.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.prbMedium.Name = "prbMedium";
            this.prbMedium.Picture = global::InTheDogHouse.Properties.Resources.medium;
            this.prbMedium.Selected = false;
            this.prbMedium.SelectedColour = System.Drawing.Color.Red;
            this.prbMedium.Size = new System.Drawing.Size(180, 74);
            this.prbMedium.TabIndex = 51;
            // 
            // prbLarge
            // 
            this.prbLarge.ButtonText = "Large";
            this.prbLarge.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prbLarge.Location = new System.Drawing.Point(7, 97);
            this.prbLarge.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.prbLarge.Name = "prbLarge";
            this.prbLarge.Picture = global::InTheDogHouse.Properties.Resources.large;
            this.prbLarge.Selected = false;
            this.prbLarge.SelectedColour = System.Drawing.Color.Red;
            this.prbLarge.Size = new System.Drawing.Size(164, 74);
            this.prbLarge.TabIndex = 50;
            // 
            // prbSmall
            // 
            this.prbSmall.ButtonText = "Small";
            this.prbSmall.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prbSmall.Location = new System.Drawing.Point(7, 24);
            this.prbSmall.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.prbSmall.Name = "prbSmall";
            this.prbSmall.Picture = global::InTheDogHouse.Properties.Resources.toy;
            this.prbSmall.Selected = true;
            this.prbSmall.SelectedColour = System.Drawing.Color.Red;
            this.prbSmall.Size = new System.Drawing.Size(164, 74);
            this.prbSmall.TabIndex = 49;
            // 
            // ssDogs
            // 
            this.ssDogs.BackColor = System.Drawing.SystemColors.Control;
            this.ssDogs.BorderColour = System.Drawing.Color.SaddleBrown;
            this.ssDogs.BorderSize = 5;
            this.ssDogs.ChangeRate = 5000;
            this.ssDogs.Location = new System.Drawing.Point(540, 13);
            this.ssDogs.Name = "ssDogs";
            this.ssDogs.Pictures = new string[] {
        "Images\\Slideshow\\dogs.jpg",
        "Images\\Slideshow\\dogs2.jpg",
        "Images\\Slideshow\\dogs3.jpg",
        "Images\\Slideshow\\dogs4.jpg",
        "Images\\Slideshow\\dogs5.jpg",
        "Images\\Slideshow\\dogs6.jpg",
        "Images\\Slideshow\\dogs7.jpg",
        "Images\\Slideshow\\dogs8.jpg"};
            this.ssDogs.Size = new System.Drawing.Size(190, 128);
            this.ssDogs.TabIndex = 48;
            // 
            // frmBreed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 565);
            this.Controls.Add(this.gbBreedSize);
            this.Controls.Add(this.ssDogs);
            this.Controls.Add(this.picDogs);
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
            this.Controls.Add(this.pictureBox4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBreed";
            this.Text = "Dog Breeds";
            this.Load += new System.EventHandler(this.frmBreed_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDogs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.gbBreedSize.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox4;
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
        private System.Windows.Forms.PictureBox picDogs;
        private System.Windows.Forms.Timer timPictureChange;
        private SlideShow ssDogs;
        private PictureRadioButton prbSmall;
        private System.Windows.Forms.GroupBox gbBreedSize;
        private PictureRadioButton prbGiant;
        private PictureRadioButton prbMedium;
        private PictureRadioButton prbLarge;
    }
}