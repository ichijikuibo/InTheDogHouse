
namespace InTheDogHouse
{
    partial class frmDog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDog));
            this.ssDogs = new InTheDogHouse.SlideShow();
            this.tabDogHouse = new System.Windows.Forms.TabControl();
            this.tabDisplay = new System.Windows.Forms.TabPage();
            this.dgvDisplay = new System.Windows.Forms.DataGridView();
            this.tabEdit = new System.Windows.Forms.TabPage();
            this.txtEditTelephone = new System.Windows.Forms.TextBox();
            this.txtEditPostcode = new System.Windows.Forms.TextBox();
            this.txtEditCounty = new System.Windows.Forms.TextBox();
            this.txtEditTown = new System.Windows.Forms.TextBox();
            this.txtEditStreet = new System.Windows.Forms.TextBox();
            this.txtEditSurname = new System.Windows.Forms.TextBox();
            this.lblEditCustomerNumber = new System.Windows.Forms.Label();
            this.lblEditTelephone = new System.Windows.Forms.Label();
            this.lblEditPostcode = new System.Windows.Forms.Label();
            this.lblEditCounty = new System.Windows.Forms.Label();
            this.lblEditTown = new System.Windows.Forms.Label();
            this.lblEditStreet = new System.Windows.Forms.Label();
            this.lblEditForename = new System.Windows.Forms.Label();
            this.lblEditSurname = new System.Windows.Forms.Label();
            this.lblEditCustomerNo = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btnDisplayExit = new System.Windows.Forms.Button();
            this.btnDisplayDelete = new System.Windows.Forms.Button();
            this.btnDisplayEdit = new System.Windows.Forms.Button();
            this.btnDisplayAdd = new System.Windows.Forms.Button();
            this.imgAddDog = new System.Windows.Forms.PictureBox();
            this.btnEditEdit = new System.Windows.Forms.Button();
            this.btnEditCancel = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblAddCustomerNo = new System.Windows.Forms.Label();
            this.lblAddCustomerNumber = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnAddAdd = new System.Windows.Forms.Button();
            this.btnAddCancel = new System.Windows.Forms.Button();
            this.tabAdd = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtAddName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmdAddBreed = new System.Windows.Forms.ComboBox();
            this.tabDogHouse.SuspendLayout();
            this.tabDisplay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplay)).BeginInit();
            this.tabEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAddDog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // ssDogs
            // 
            this.ssDogs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ssDogs.BackColor = System.Drawing.SystemColors.Control;
            this.ssDogs.BorderColour = System.Drawing.Color.SaddleBrown;
            this.ssDogs.BorderSize = 5;
            this.ssDogs.ChangeRate = 5000;
            this.ssDogs.Location = new System.Drawing.Point(526, 12);
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
            this.ssDogs.Size = new System.Drawing.Size(233, 165);
            this.ssDogs.TabIndex = 52;
            // 
            // tabDogHouse
            // 
            this.tabDogHouse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabDogHouse.Controls.Add(this.tabDisplay);
            this.tabDogHouse.Controls.Add(this.tabAdd);
            this.tabDogHouse.Controls.Add(this.tabEdit);
            this.tabDogHouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabDogHouse.ItemSize = new System.Drawing.Size(250, 30);
            this.tabDogHouse.Location = new System.Drawing.Point(9, 194);
            this.tabDogHouse.Margin = new System.Windows.Forms.Padding(0);
            this.tabDogHouse.Multiline = true;
            this.tabDogHouse.Name = "tabDogHouse";
            this.tabDogHouse.Padding = new System.Drawing.Point(0, 0);
            this.tabDogHouse.SelectedIndex = 0;
            this.tabDogHouse.Size = new System.Drawing.Size(760, 532);
            this.tabDogHouse.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabDogHouse.TabIndex = 50;
            // 
            // tabDisplay
            // 
            this.tabDisplay.BackColor = System.Drawing.Color.Transparent;
            this.tabDisplay.Controls.Add(this.btnDisplayExit);
            this.tabDisplay.Controls.Add(this.btnDisplayDelete);
            this.tabDisplay.Controls.Add(this.btnDisplayEdit);
            this.tabDisplay.Controls.Add(this.btnDisplayAdd);
            this.tabDisplay.Controls.Add(this.imgAddDog);
            this.tabDisplay.Controls.Add(this.dgvDisplay);
            this.tabDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabDisplay.Location = new System.Drawing.Point(4, 34);
            this.tabDisplay.Name = "tabDisplay";
            this.tabDisplay.Padding = new System.Windows.Forms.Padding(3);
            this.tabDisplay.Size = new System.Drawing.Size(774, 494);
            this.tabDisplay.TabIndex = 0;
            this.tabDisplay.Text = "Display";
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
            this.dgvDisplay.Location = new System.Drawing.Point(6, 6);
            this.dgvDisplay.MultiSelect = false;
            this.dgvDisplay.Name = "dgvDisplay";
            this.dgvDisplay.ReadOnly = true;
            this.dgvDisplay.RowTemplate.Height = 25;
            this.dgvDisplay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDisplay.Size = new System.Drawing.Size(575, 482);
            this.dgvDisplay.TabIndex = 0;
            // 
            // tabEdit
            // 
            this.tabEdit.BackColor = System.Drawing.Color.Transparent;
            this.tabEdit.Controls.Add(this.btnEditEdit);
            this.tabEdit.Controls.Add(this.btnEditCancel);
            this.tabEdit.Controls.Add(this.pictureBox3);
            this.tabEdit.Controls.Add(this.txtEditTelephone);
            this.tabEdit.Controls.Add(this.txtEditPostcode);
            this.tabEdit.Controls.Add(this.txtEditCounty);
            this.tabEdit.Controls.Add(this.txtEditTown);
            this.tabEdit.Controls.Add(this.txtEditStreet);
            this.tabEdit.Controls.Add(this.txtEditSurname);
            this.tabEdit.Controls.Add(this.lblEditCustomerNumber);
            this.tabEdit.Controls.Add(this.lblEditTelephone);
            this.tabEdit.Controls.Add(this.lblEditPostcode);
            this.tabEdit.Controls.Add(this.lblEditCounty);
            this.tabEdit.Controls.Add(this.lblEditTown);
            this.tabEdit.Controls.Add(this.lblEditStreet);
            this.tabEdit.Controls.Add(this.lblEditForename);
            this.tabEdit.Controls.Add(this.lblEditSurname);
            this.tabEdit.Controls.Add(this.lblEditCustomerNo);
            this.tabEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabEdit.Location = new System.Drawing.Point(4, 34);
            this.tabEdit.Name = "tabEdit";
            this.tabEdit.Size = new System.Drawing.Size(774, 494);
            this.tabEdit.TabIndex = 2;
            this.tabEdit.Text = "Edit";
            // 
            // txtEditTelephone
            // 
            this.txtEditTelephone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEditTelephone.Enabled = false;
            this.txtEditTelephone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditTelephone.Location = new System.Drawing.Point(199, 440);
            this.txtEditTelephone.Name = "txtEditTelephone";
            this.txtEditTelephone.Size = new System.Drawing.Size(329, 31);
            this.txtEditTelephone.TabIndex = 38;
            // 
            // txtEditPostcode
            // 
            this.txtEditPostcode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEditPostcode.Enabled = false;
            this.txtEditPostcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditPostcode.Location = new System.Drawing.Point(199, 385);
            this.txtEditPostcode.Name = "txtEditPostcode";
            this.txtEditPostcode.Size = new System.Drawing.Size(329, 31);
            this.txtEditPostcode.TabIndex = 37;
            // 
            // txtEditCounty
            // 
            this.txtEditCounty.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEditCounty.Enabled = false;
            this.txtEditCounty.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditCounty.Location = new System.Drawing.Point(199, 334);
            this.txtEditCounty.Name = "txtEditCounty";
            this.txtEditCounty.Size = new System.Drawing.Size(329, 31);
            this.txtEditCounty.TabIndex = 36;
            // 
            // txtEditTown
            // 
            this.txtEditTown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEditTown.Enabled = false;
            this.txtEditTown.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditTown.Location = new System.Drawing.Point(199, 283);
            this.txtEditTown.Name = "txtEditTown";
            this.txtEditTown.Size = new System.Drawing.Size(329, 31);
            this.txtEditTown.TabIndex = 35;
            // 
            // txtEditStreet
            // 
            this.txtEditStreet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEditStreet.Enabled = false;
            this.txtEditStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditStreet.Location = new System.Drawing.Point(199, 232);
            this.txtEditStreet.Name = "txtEditStreet";
            this.txtEditStreet.Size = new System.Drawing.Size(329, 31);
            this.txtEditStreet.TabIndex = 34;
            // 
            // txtEditSurname
            // 
            this.txtEditSurname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEditSurname.Enabled = false;
            this.txtEditSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditSurname.Location = new System.Drawing.Point(199, 66);
            this.txtEditSurname.Name = "txtEditSurname";
            this.txtEditSurname.Size = new System.Drawing.Size(329, 31);
            this.txtEditSurname.TabIndex = 32;
            // 
            // lblEditCustomerNumber
            // 
            this.lblEditCustomerNumber.AutoSize = true;
            this.lblEditCustomerNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditCustomerNumber.Location = new System.Drawing.Point(194, 28);
            this.lblEditCustomerNumber.Name = "lblEditCustomerNumber";
            this.lblEditCustomerNumber.Size = new System.Drawing.Size(19, 25);
            this.lblEditCustomerNumber.TabIndex = 30;
            this.lblEditCustomerNumber.Text = "-";
            // 
            // lblEditTelephone
            // 
            this.lblEditTelephone.AutoSize = true;
            this.lblEditTelephone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditTelephone.Location = new System.Drawing.Point(22, 436);
            this.lblEditTelephone.Name = "lblEditTelephone";
            this.lblEditTelephone.Size = new System.Drawing.Size(75, 25);
            this.lblEditTelephone.TabIndex = 29;
            this.lblEditTelephone.Text = "Tel No";
            // 
            // lblEditPostcode
            // 
            this.lblEditPostcode.AutoSize = true;
            this.lblEditPostcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditPostcode.Location = new System.Drawing.Point(22, 385);
            this.lblEditPostcode.Name = "lblEditPostcode";
            this.lblEditPostcode.Size = new System.Drawing.Size(75, 25);
            this.lblEditPostcode.TabIndex = 28;
            this.lblEditPostcode.Text = "Colour";
            // 
            // lblEditCounty
            // 
            this.lblEditCounty.AutoSize = true;
            this.lblEditCounty.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditCounty.Location = new System.Drawing.Point(22, 334);
            this.lblEditCounty.Name = "lblEditCounty";
            this.lblEditCounty.Size = new System.Drawing.Size(80, 25);
            this.lblEditCounty.TabIndex = 27;
            this.lblEditCounty.Text = "County";
            // 
            // lblEditTown
            // 
            this.lblEditTown.AutoSize = true;
            this.lblEditTown.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditTown.Location = new System.Drawing.Point(22, 283);
            this.lblEditTown.Name = "lblEditTown";
            this.lblEditTown.Size = new System.Drawing.Size(64, 25);
            this.lblEditTown.TabIndex = 26;
            this.lblEditTown.Text = "Town";
            // 
            // lblEditStreet
            // 
            this.lblEditStreet.AutoSize = true;
            this.lblEditStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditStreet.Location = new System.Drawing.Point(22, 232);
            this.lblEditStreet.Name = "lblEditStreet";
            this.lblEditStreet.Size = new System.Drawing.Size(69, 25);
            this.lblEditStreet.TabIndex = 25;
            this.lblEditStreet.Text = "Street";
            // 
            // lblEditForename
            // 
            this.lblEditForename.AutoSize = true;
            this.lblEditForename.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditForename.Location = new System.Drawing.Point(23, 130);
            this.lblEditForename.Name = "lblEditForename";
            this.lblEditForename.Size = new System.Drawing.Size(99, 25);
            this.lblEditForename.TabIndex = 24;
            this.lblEditForename.Text = "Breed no";
            // 
            // lblEditSurname
            // 
            this.lblEditSurname.AutoSize = true;
            this.lblEditSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditSurname.Location = new System.Drawing.Point(23, 72);
            this.lblEditSurname.Name = "lblEditSurname";
            this.lblEditSurname.Size = new System.Drawing.Size(68, 25);
            this.lblEditSurname.TabIndex = 23;
            this.lblEditSurname.Text = "Name";
            // 
            // lblEditCustomerNo
            // 
            this.lblEditCustomerNo.AutoSize = true;
            this.lblEditCustomerNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditCustomerNo.Location = new System.Drawing.Point(22, 28);
            this.lblEditCustomerNo.Name = "lblEditCustomerNo";
            this.lblEditCustomerNo.Size = new System.Drawing.Size(84, 25);
            this.lblEditCustomerNo.TabIndex = 21;
            this.lblEditCustomerNo.Text = "Dog No";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.ImageLocation = "";
            this.pictureBox4.Location = new System.Drawing.Point(13, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(507, 160);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 51;
            this.pictureBox4.TabStop = false;
            // 
            // btnDisplayExit
            // 
            this.btnDisplayExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDisplayExit.FlatAppearance.BorderSize = 0;
            this.btnDisplayExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisplayExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplayExit.Image = global::InTheDogHouse.Properties.Resources.pepsiIcon2;
            this.btnDisplayExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDisplayExit.Location = new System.Drawing.Point(587, 186);
            this.btnDisplayExit.Name = "btnDisplayExit";
            this.btnDisplayExit.Size = new System.Drawing.Size(181, 55);
            this.btnDisplayExit.TabIndex = 5;
            this.btnDisplayExit.Text = "Exit";
            this.btnDisplayExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDisplayExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDisplayExit.UseVisualStyleBackColor = true;
            // 
            // btnDisplayDelete
            // 
            this.btnDisplayDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDisplayDelete.FlatAppearance.BorderSize = 0;
            this.btnDisplayDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisplayDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplayDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDisplayDelete.Image")));
            this.btnDisplayDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDisplayDelete.Location = new System.Drawing.Point(587, 126);
            this.btnDisplayDelete.Name = "btnDisplayDelete";
            this.btnDisplayDelete.Size = new System.Drawing.Size(181, 55);
            this.btnDisplayDelete.TabIndex = 4;
            this.btnDisplayDelete.Text = "Delete";
            this.btnDisplayDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDisplayDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDisplayDelete.UseVisualStyleBackColor = true;
            // 
            // btnDisplayEdit
            // 
            this.btnDisplayEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDisplayEdit.FlatAppearance.BorderSize = 0;
            this.btnDisplayEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisplayEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplayEdit.Image = global::InTheDogHouse.Properties.Resources.keanoIcon;
            this.btnDisplayEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDisplayEdit.Location = new System.Drawing.Point(587, 66);
            this.btnDisplayEdit.Name = "btnDisplayEdit";
            this.btnDisplayEdit.Size = new System.Drawing.Size(181, 55);
            this.btnDisplayEdit.TabIndex = 3;
            this.btnDisplayEdit.Text = "Edit";
            this.btnDisplayEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDisplayEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDisplayEdit.UseVisualStyleBackColor = true;
            // 
            // btnDisplayAdd
            // 
            this.btnDisplayAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDisplayAdd.FlatAppearance.BorderSize = 0;
            this.btnDisplayAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisplayAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplayAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnDisplayAdd.Image")));
            this.btnDisplayAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDisplayAdd.Location = new System.Drawing.Point(587, 6);
            this.btnDisplayAdd.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnDisplayAdd.Name = "btnDisplayAdd";
            this.btnDisplayAdd.Size = new System.Drawing.Size(181, 55);
            this.btnDisplayAdd.TabIndex = 2;
            this.btnDisplayAdd.Text = "Add";
            this.btnDisplayAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDisplayAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDisplayAdd.UseVisualStyleBackColor = true;
            // 
            // imgAddDog
            // 
            this.imgAddDog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.imgAddDog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.imgAddDog.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.imgAddDog.Image = global::InTheDogHouse.Properties.Resources.pepsi;
            this.imgAddDog.Location = new System.Drawing.Point(587, 253);
            this.imgAddDog.Name = "imgAddDog";
            this.imgAddDog.Size = new System.Drawing.Size(181, 238);
            this.imgAddDog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgAddDog.TabIndex = 1;
            this.imgAddDog.TabStop = false;
            // 
            // btnEditEdit
            // 
            this.btnEditEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditEdit.FlatAppearance.BorderSize = 0;
            this.btnEditEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditEdit.Image = global::InTheDogHouse.Properties.Resources.keanoIcon;
            this.btnEditEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditEdit.Location = new System.Drawing.Point(563, 28);
            this.btnEditEdit.Name = "btnEditEdit";
            this.btnEditEdit.Size = new System.Drawing.Size(181, 55);
            this.btnEditEdit.TabIndex = 42;
            this.btnEditEdit.Text = "Edit";
            this.btnEditEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditEdit.UseVisualStyleBackColor = true;
            // 
            // btnEditCancel
            // 
            this.btnEditCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditCancel.FlatAppearance.BorderSize = 0;
            this.btnEditCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditCancel.Image = global::InTheDogHouse.Properties.Resources._2DogsIcon;
            this.btnEditCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditCancel.Location = new System.Drawing.Point(563, 100);
            this.btnEditCancel.Name = "btnEditCancel";
            this.btnEditCancel.Size = new System.Drawing.Size(181, 55);
            this.btnEditCancel.TabIndex = 41;
            this.btnEditCancel.Text = "Cancel";
            this.btnEditCancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditCancel.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox3.Image = global::InTheDogHouse.Properties.Resources.coco;
            this.pictureBox3.Location = new System.Drawing.Point(577, 304);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(181, 171);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 39;
            this.pictureBox3.TabStop = false;
            // 
            // lblAddCustomerNo
            // 
            this.lblAddCustomerNo.AutoSize = true;
            this.lblAddCustomerNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddCustomerNo.Location = new System.Drawing.Point(22, 28);
            this.lblAddCustomerNo.Name = "lblAddCustomerNo";
            this.lblAddCustomerNo.Size = new System.Drawing.Size(84, 25);
            this.lblAddCustomerNo.TabIndex = 0;
            this.lblAddCustomerNo.Text = "Dog No";
            // 
            // lblAddCustomerNumber
            // 
            this.lblAddCustomerNumber.AutoSize = true;
            this.lblAddCustomerNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddCustomerNumber.Location = new System.Drawing.Point(157, 28);
            this.lblAddCustomerNumber.Name = "lblAddCustomerNumber";
            this.lblAddCustomerNumber.Size = new System.Drawing.Size(96, 25);
            this.lblAddCustomerNumber.TabIndex = 9;
            this.lblAddCustomerNumber.Text = "9999999";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Image = global::InTheDogHouse.Properties.Resources.keano;
            this.pictureBox2.Location = new System.Drawing.Point(565, 295);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(181, 193);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // btnAddAdd
            // 
            this.btnAddAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddAdd.FlatAppearance.BorderSize = 0;
            this.btnAddAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAddAdd.Image")));
            this.btnAddAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddAdd.Location = new System.Drawing.Point(565, 28);
            this.btnAddAdd.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnAddAdd.Name = "btnAddAdd";
            this.btnAddAdd.Size = new System.Drawing.Size(181, 55);
            this.btnAddAdd.TabIndex = 19;
            this.btnAddAdd.Text = "Add";
            this.btnAddAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddAdd.UseVisualStyleBackColor = true;
            // 
            // btnAddCancel
            // 
            this.btnAddCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddCancel.FlatAppearance.BorderSize = 0;
            this.btnAddCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCancel.Image = global::InTheDogHouse.Properties.Resources._2DogsIcon;
            this.btnAddCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddCancel.Location = new System.Drawing.Point(565, 100);
            this.btnAddCancel.Name = "btnAddCancel";
            this.btnAddCancel.Size = new System.Drawing.Size(181, 55);
            this.btnAddCancel.TabIndex = 20;
            this.btnAddCancel.Text = "Cancel";
            this.btnAddCancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddCancel.UseVisualStyleBackColor = true;
            // 
            // tabAdd
            // 
            this.tabAdd.BackColor = System.Drawing.Color.Transparent;
            this.tabAdd.Controls.Add(this.cmdAddBreed);
            this.tabAdd.Controls.Add(this.textBox1);
            this.tabAdd.Controls.Add(this.txtAddName);
            this.tabAdd.Controls.Add(this.label1);
            this.tabAdd.Controls.Add(this.label2);
            this.tabAdd.Controls.Add(this.label3);
            this.tabAdd.Controls.Add(this.btnAddCancel);
            this.tabAdd.Controls.Add(this.btnAddAdd);
            this.tabAdd.Controls.Add(this.pictureBox2);
            this.tabAdd.Controls.Add(this.lblAddCustomerNumber);
            this.tabAdd.Controls.Add(this.lblAddCustomerNo);
            this.tabAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabAdd.Location = new System.Drawing.Point(4, 34);
            this.tabAdd.Name = "tabAdd";
            this.tabAdd.Padding = new System.Windows.Forms.Padding(3);
            this.tabAdd.Size = new System.Drawing.Size(752, 494);
            this.tabAdd.TabIndex = 1;
            this.tabAdd.Text = "Add";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(162, 187);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(339, 31);
            this.textBox1.TabIndex = 42;
            // 
            // txtAddName
            // 
            this.txtAddName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAddName.Enabled = false;
            this.txtAddName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddName.Location = new System.Drawing.Point(162, 78);
            this.txtAddName.Name = "txtAddName";
            this.txtAddName.Size = new System.Drawing.Size(339, 31);
            this.txtAddName.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 25);
            this.label1.TabIndex = 40;
            this.label1.Text = "Colour";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 25);
            this.label2.TabIndex = 39;
            this.label2.Text = "Breed";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 25);
            this.label3.TabIndex = 38;
            this.label3.Text = "Name";
            // 
            // cmdAddBreed
            // 
            this.cmdAddBreed.FormattingEnabled = true;
            this.cmdAddBreed.Location = new System.Drawing.Point(162, 131);
            this.cmdAddBreed.Name = "cmdAddBreed";
            this.cmdAddBreed.Size = new System.Drawing.Size(339, 28);
            this.cmdAddBreed.TabIndex = 43;
            // 
            // frmDog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 735);
            this.Controls.Add(this.ssDogs);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.tabDogHouse);
            this.Name = "frmDog";
            this.Text = "frmDog";
            this.tabDogHouse.ResumeLayout(false);
            this.tabDisplay.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplay)).EndInit();
            this.tabEdit.ResumeLayout(false);
            this.tabEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAddDog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabAdd.ResumeLayout(false);
            this.tabAdd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private SlideShow ssDogs;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TabControl tabDogHouse;
        private System.Windows.Forms.TabPage tabDisplay;
        private System.Windows.Forms.Button btnDisplayExit;
        private System.Windows.Forms.Button btnDisplayDelete;
        private System.Windows.Forms.Button btnDisplayEdit;
        private System.Windows.Forms.Button btnDisplayAdd;
        private System.Windows.Forms.PictureBox imgAddDog;
        private System.Windows.Forms.DataGridView dgvDisplay;
        private System.Windows.Forms.TabPage tabEdit;
        private System.Windows.Forms.Button btnEditEdit;
        private System.Windows.Forms.Button btnEditCancel;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox txtEditTelephone;
        private System.Windows.Forms.TextBox txtEditPostcode;
        private System.Windows.Forms.TextBox txtEditCounty;
        private System.Windows.Forms.TextBox txtEditTown;
        private System.Windows.Forms.TextBox txtEditStreet;
        private System.Windows.Forms.TextBox txtEditSurname;
        private System.Windows.Forms.Label lblEditCustomerNumber;
        private System.Windows.Forms.Label lblEditTelephone;
        private System.Windows.Forms.Label lblEditPostcode;
        private System.Windows.Forms.Label lblEditCounty;
        private System.Windows.Forms.Label lblEditTown;
        private System.Windows.Forms.Label lblEditStreet;
        private System.Windows.Forms.Label lblEditForename;
        private System.Windows.Forms.Label lblEditSurname;
        private System.Windows.Forms.Label lblEditCustomerNo;
        private System.Windows.Forms.TabPage tabAdd;
        private System.Windows.Forms.Button btnAddCancel;
        private System.Windows.Forms.Button btnAddAdd;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblAddCustomerNumber;
        private System.Windows.Forms.Label lblAddCustomerNo;
        private System.Windows.Forms.ComboBox cmdAddBreed;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtAddName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}