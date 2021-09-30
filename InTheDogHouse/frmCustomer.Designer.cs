
namespace InTheDogHouse
{
    partial class frmCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomer));
            this.tabDogHouse = new System.Windows.Forms.TabControl();
            this.tabDisplay = new System.Windows.Forms.TabPage();
            this.btnDisplayExit = new System.Windows.Forms.Button();
            this.btnDisplayDelete = new System.Windows.Forms.Button();
            this.btnDisplayEdit = new System.Windows.Forms.Button();
            this.btnDisplayAdd = new System.Windows.Forms.Button();
            this.imgAddDog = new System.Windows.Forms.PictureBox();
            this.dgvDisplay = new System.Windows.Forms.DataGridView();
            this.tabAdd = new System.Windows.Forms.TabPage();
            this.btnAddCancel = new System.Windows.Forms.Button();
            this.btnAddAdd = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtAddTelephone = new System.Windows.Forms.TextBox();
            this.txtAddPostcode = new System.Windows.Forms.TextBox();
            this.txtAddCounty = new System.Windows.Forms.TextBox();
            this.txtAddTown = new System.Windows.Forms.TextBox();
            this.txtAddStreet = new System.Windows.Forms.TextBox();
            this.txtAddForename = new System.Windows.Forms.TextBox();
            this.txtAddSurname = new System.Windows.Forms.TextBox();
            this.cmbAddTitle = new System.Windows.Forms.ComboBox();
            this.lblAddCustomerNumber = new System.Windows.Forms.Label();
            this.lblAddTelephone = new System.Windows.Forms.Label();
            this.lblAddPostcode = new System.Windows.Forms.Label();
            this.lblAddCounty = new System.Windows.Forms.Label();
            this.lblAddTown = new System.Windows.Forms.Label();
            this.lblAddStreet = new System.Windows.Forms.Label();
            this.lblAddForename = new System.Windows.Forms.Label();
            this.lblAddSurname = new System.Windows.Forms.Label();
            this.lblAddTitle = new System.Windows.Forms.Label();
            this.lblAddCustomerNo = new System.Windows.Forms.Label();
            this.tabEdit = new System.Windows.Forms.TabPage();
            this.btnEditEdit = new System.Windows.Forms.Button();
            this.btnEditCancel = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.txtEditTelephone = new System.Windows.Forms.TextBox();
            this.txtEditPostcode = new System.Windows.Forms.TextBox();
            this.txtEditCounty = new System.Windows.Forms.TextBox();
            this.txtEditTown = new System.Windows.Forms.TextBox();
            this.txtEditStreet = new System.Windows.Forms.TextBox();
            this.txtEditForename = new System.Windows.Forms.TextBox();
            this.txtEditSurname = new System.Windows.Forms.TextBox();
            this.cmbEditTitle = new System.Windows.Forms.ComboBox();
            this.lblEditCustomerNumber = new System.Windows.Forms.Label();
            this.lblEditTelephone = new System.Windows.Forms.Label();
            this.lblEditPostcode = new System.Windows.Forms.Label();
            this.lblEditCounty = new System.Windows.Forms.Label();
            this.lblEditTown = new System.Windows.Forms.Label();
            this.lblEditStreet = new System.Windows.Forms.Label();
            this.lblEditForename = new System.Windows.Forms.Label();
            this.lblEditSurname = new System.Windows.Forms.Label();
            this.lblEditTitle = new System.Windows.Forms.Label();
            this.lblEditCustomerNo = new System.Windows.Forms.Label();
            this.errP = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabDogHouse.SuspendLayout();
            this.tabDisplay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgAddDog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplay)).BeginInit();
            this.tabAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errP)).BeginInit();
            this.SuspendLayout();
            // 
            // tabDogHouse
            // 
            this.tabDogHouse.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabDogHouse.Controls.Add(this.tabDisplay);
            this.tabDogHouse.Controls.Add(this.tabAdd);
            this.tabDogHouse.Controls.Add(this.tabEdit);
            this.tabDogHouse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabDogHouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabDogHouse.ItemSize = new System.Drawing.Size(1, 1);
            this.tabDogHouse.Location = new System.Drawing.Point(0, 0);
            this.tabDogHouse.Margin = new System.Windows.Forms.Padding(0);
            this.tabDogHouse.Multiline = true;
            this.tabDogHouse.Name = "tabDogHouse";
            this.tabDogHouse.Padding = new System.Drawing.Point(0, 0);
            this.tabDogHouse.SelectedIndex = 0;
            this.tabDogHouse.Size = new System.Drawing.Size(784, 518);
            this.tabDogHouse.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabDogHouse.TabIndex = 0;
            this.tabDogHouse.SelectedIndexChanged += new System.EventHandler(this.tabDogHouse_SelectedIndexChanged);
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
            this.tabDisplay.Location = new System.Drawing.Point(4, 5);
            this.tabDisplay.Name = "tabDisplay";
            this.tabDisplay.Padding = new System.Windows.Forms.Padding(3);
            this.tabDisplay.Size = new System.Drawing.Size(776, 509);
            this.tabDisplay.TabIndex = 0;
            this.tabDisplay.Text = "Display";
            // 
            // btnDisplayExit
            // 
            this.btnDisplayExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDisplayExit.FlatAppearance.BorderSize = 0;
            this.btnDisplayExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisplayExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplayExit.Image = global::InTheDogHouse.Properties.Resources.pepsiIcon2;
            this.btnDisplayExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDisplayExit.Location = new System.Drawing.Point(589, 186);
            this.btnDisplayExit.Name = "btnDisplayExit";
            this.btnDisplayExit.Size = new System.Drawing.Size(181, 55);
            this.btnDisplayExit.TabIndex = 5;
            this.btnDisplayExit.Text = "Exit";
            this.btnDisplayExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDisplayExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
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
            this.btnDisplayDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDisplayDelete.Location = new System.Drawing.Point(589, 126);
            this.btnDisplayDelete.Name = "btnDisplayDelete";
            this.btnDisplayDelete.Size = new System.Drawing.Size(181, 55);
            this.btnDisplayDelete.TabIndex = 4;
            this.btnDisplayDelete.Text = "Delete";
            this.btnDisplayDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDisplayDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDisplayDelete.UseVisualStyleBackColor = true;
            this.btnDisplayDelete.Click += new System.EventHandler(this.btnDisplayDelete_Click);
            // 
            // btnDisplayEdit
            // 
            this.btnDisplayEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDisplayEdit.FlatAppearance.BorderSize = 0;
            this.btnDisplayEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisplayEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplayEdit.Image = global::InTheDogHouse.Properties.Resources.keanoIcon;
            this.btnDisplayEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDisplayEdit.Location = new System.Drawing.Point(589, 66);
            this.btnDisplayEdit.Name = "btnDisplayEdit";
            this.btnDisplayEdit.Size = new System.Drawing.Size(181, 55);
            this.btnDisplayEdit.TabIndex = 3;
            this.btnDisplayEdit.Text = "Edit";
            this.btnDisplayEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDisplayEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDisplayEdit.UseVisualStyleBackColor = true;
            this.btnDisplayEdit.Click += new System.EventHandler(this.btnDisplayEdit_Click);
            // 
            // btnDisplayAdd
            // 
            this.btnDisplayAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDisplayAdd.FlatAppearance.BorderSize = 0;
            this.btnDisplayAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisplayAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplayAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnDisplayAdd.Image")));
            this.btnDisplayAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDisplayAdd.Location = new System.Drawing.Point(589, 6);
            this.btnDisplayAdd.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnDisplayAdd.Name = "btnDisplayAdd";
            this.btnDisplayAdd.Size = new System.Drawing.Size(181, 55);
            this.btnDisplayAdd.TabIndex = 2;
            this.btnDisplayAdd.Text = "Add";
            this.btnDisplayAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDisplayAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDisplayAdd.UseVisualStyleBackColor = true;
            this.btnDisplayAdd.Click += new System.EventHandler(this.btnDisplayAdd_Click);
            // 
            // imgAddDog
            // 
            this.imgAddDog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.imgAddDog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.imgAddDog.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.imgAddDog.Image = global::InTheDogHouse.Properties.Resources.pepsi;
            this.imgAddDog.Location = new System.Drawing.Point(589, 268);
            this.imgAddDog.Name = "imgAddDog";
            this.imgAddDog.Size = new System.Drawing.Size(181, 238);
            this.imgAddDog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgAddDog.TabIndex = 1;
            this.imgAddDog.TabStop = false;
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
            this.dgvDisplay.Size = new System.Drawing.Size(577, 497);
            this.dgvDisplay.TabIndex = 0;
            // 
            // tabAdd
            // 
            this.tabAdd.BackColor = System.Drawing.Color.Transparent;
            this.tabAdd.Controls.Add(this.btnAddCancel);
            this.tabAdd.Controls.Add(this.btnAddAdd);
            this.tabAdd.Controls.Add(this.pictureBox2);
            this.tabAdd.Controls.Add(this.txtAddTelephone);
            this.tabAdd.Controls.Add(this.txtAddPostcode);
            this.tabAdd.Controls.Add(this.txtAddCounty);
            this.tabAdd.Controls.Add(this.txtAddTown);
            this.tabAdd.Controls.Add(this.txtAddStreet);
            this.tabAdd.Controls.Add(this.txtAddForename);
            this.tabAdd.Controls.Add(this.txtAddSurname);
            this.tabAdd.Controls.Add(this.cmbAddTitle);
            this.tabAdd.Controls.Add(this.lblAddCustomerNumber);
            this.tabAdd.Controls.Add(this.lblAddTelephone);
            this.tabAdd.Controls.Add(this.lblAddPostcode);
            this.tabAdd.Controls.Add(this.lblAddCounty);
            this.tabAdd.Controls.Add(this.lblAddTown);
            this.tabAdd.Controls.Add(this.lblAddStreet);
            this.tabAdd.Controls.Add(this.lblAddForename);
            this.tabAdd.Controls.Add(this.lblAddSurname);
            this.tabAdd.Controls.Add(this.lblAddTitle);
            this.tabAdd.Controls.Add(this.lblAddCustomerNo);
            this.tabAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabAdd.Location = new System.Drawing.Point(4, 5);
            this.tabAdd.Name = "tabAdd";
            this.tabAdd.Padding = new System.Windows.Forms.Padding(3);
            this.tabAdd.Size = new System.Drawing.Size(776, 509);
            this.tabAdd.TabIndex = 1;
            this.tabAdd.Text = "Add";
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
            this.btnAddCancel.Click += new System.EventHandler(this.btnAddCancel_Click);
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
            this.btnAddAdd.Click += new System.EventHandler(this.btnAddAdd_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Image = global::InTheDogHouse.Properties.Resources.keano;
            this.pictureBox2.Location = new System.Drawing.Point(565, 288);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(181, 193);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // txtAddTelephone
            // 
            this.txtAddTelephone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAddTelephone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddTelephone.Location = new System.Drawing.Point(199, 440);
            this.txtAddTelephone.Name = "txtAddTelephone";
            this.txtAddTelephone.Size = new System.Drawing.Size(331, 31);
            this.txtAddTelephone.TabIndex = 17;
            // 
            // txtAddPostcode
            // 
            this.txtAddPostcode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAddPostcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddPostcode.Location = new System.Drawing.Point(199, 385);
            this.txtAddPostcode.Name = "txtAddPostcode";
            this.txtAddPostcode.Size = new System.Drawing.Size(331, 31);
            this.txtAddPostcode.TabIndex = 16;
            // 
            // txtAddCounty
            // 
            this.txtAddCounty.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAddCounty.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddCounty.Location = new System.Drawing.Point(199, 334);
            this.txtAddCounty.Name = "txtAddCounty";
            this.txtAddCounty.Size = new System.Drawing.Size(331, 31);
            this.txtAddCounty.TabIndex = 15;
            // 
            // txtAddTown
            // 
            this.txtAddTown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAddTown.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddTown.Location = new System.Drawing.Point(199, 283);
            this.txtAddTown.Name = "txtAddTown";
            this.txtAddTown.Size = new System.Drawing.Size(331, 31);
            this.txtAddTown.TabIndex = 14;
            // 
            // txtAddStreet
            // 
            this.txtAddStreet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAddStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddStreet.Location = new System.Drawing.Point(199, 232);
            this.txtAddStreet.Name = "txtAddStreet";
            this.txtAddStreet.Size = new System.Drawing.Size(331, 31);
            this.txtAddStreet.TabIndex = 13;
            // 
            // txtAddForename
            // 
            this.txtAddForename.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAddForename.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddForename.Location = new System.Drawing.Point(199, 181);
            this.txtAddForename.Name = "txtAddForename";
            this.txtAddForename.Size = new System.Drawing.Size(331, 31);
            this.txtAddForename.TabIndex = 12;
            // 
            // txtAddSurname
            // 
            this.txtAddSurname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAddSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddSurname.Location = new System.Drawing.Point(199, 130);
            this.txtAddSurname.Name = "txtAddSurname";
            this.txtAddSurname.Size = new System.Drawing.Size(331, 31);
            this.txtAddSurname.TabIndex = 11;
            // 
            // cmbAddTitle
            // 
            this.cmbAddTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAddTitle.FormattingEnabled = true;
            this.cmbAddTitle.Items.AddRange(new object[] {
            "Mr",
            "Mrs",
            "Miss",
            "Ms",
            "Dr"});
            this.cmbAddTitle.Location = new System.Drawing.Point(199, 79);
            this.cmbAddTitle.Name = "cmbAddTitle";
            this.cmbAddTitle.Size = new System.Drawing.Size(171, 33);
            this.cmbAddTitle.TabIndex = 10;
            this.cmbAddTitle.Text = "Mr";
            // 
            // lblAddCustomerNumber
            // 
            this.lblAddCustomerNumber.AutoSize = true;
            this.lblAddCustomerNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddCustomerNumber.Location = new System.Drawing.Point(194, 28);
            this.lblAddCustomerNumber.Name = "lblAddCustomerNumber";
            this.lblAddCustomerNumber.Size = new System.Drawing.Size(96, 25);
            this.lblAddCustomerNumber.TabIndex = 9;
            this.lblAddCustomerNumber.Text = "9999999";
            // 
            // lblAddTelephone
            // 
            this.lblAddTelephone.AutoSize = true;
            this.lblAddTelephone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddTelephone.Location = new System.Drawing.Point(22, 436);
            this.lblAddTelephone.Name = "lblAddTelephone";
            this.lblAddTelephone.Size = new System.Drawing.Size(75, 25);
            this.lblAddTelephone.TabIndex = 8;
            this.lblAddTelephone.Text = "Tel No";
            // 
            // lblAddPostcode
            // 
            this.lblAddPostcode.AutoSize = true;
            this.lblAddPostcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddPostcode.Location = new System.Drawing.Point(22, 385);
            this.lblAddPostcode.Name = "lblAddPostcode";
            this.lblAddPostcode.Size = new System.Drawing.Size(102, 25);
            this.lblAddPostcode.TabIndex = 7;
            this.lblAddPostcode.Text = "Postcode";
            // 
            // lblAddCounty
            // 
            this.lblAddCounty.AutoSize = true;
            this.lblAddCounty.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddCounty.Location = new System.Drawing.Point(22, 334);
            this.lblAddCounty.Name = "lblAddCounty";
            this.lblAddCounty.Size = new System.Drawing.Size(80, 25);
            this.lblAddCounty.TabIndex = 6;
            this.lblAddCounty.Text = "County";
            // 
            // lblAddTown
            // 
            this.lblAddTown.AutoSize = true;
            this.lblAddTown.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddTown.Location = new System.Drawing.Point(22, 283);
            this.lblAddTown.Name = "lblAddTown";
            this.lblAddTown.Size = new System.Drawing.Size(64, 25);
            this.lblAddTown.TabIndex = 5;
            this.lblAddTown.Text = "Town";
            // 
            // lblAddStreet
            // 
            this.lblAddStreet.AutoSize = true;
            this.lblAddStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddStreet.Location = new System.Drawing.Point(22, 232);
            this.lblAddStreet.Name = "lblAddStreet";
            this.lblAddStreet.Size = new System.Drawing.Size(69, 25);
            this.lblAddStreet.TabIndex = 4;
            this.lblAddStreet.Text = "Street";
            // 
            // lblAddForename
            // 
            this.lblAddForename.AutoSize = true;
            this.lblAddForename.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddForename.Location = new System.Drawing.Point(22, 181);
            this.lblAddForename.Name = "lblAddForename";
            this.lblAddForename.Size = new System.Drawing.Size(109, 25);
            this.lblAddForename.TabIndex = 3;
            this.lblAddForename.Text = "Forename";
            // 
            // lblAddSurname
            // 
            this.lblAddSurname.AutoSize = true;
            this.lblAddSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddSurname.Location = new System.Drawing.Point(22, 130);
            this.lblAddSurname.Name = "lblAddSurname";
            this.lblAddSurname.Size = new System.Drawing.Size(98, 25);
            this.lblAddSurname.TabIndex = 2;
            this.lblAddSurname.Text = "Surname";
            // 
            // lblAddTitle
            // 
            this.lblAddTitle.AutoSize = true;
            this.lblAddTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddTitle.Location = new System.Drawing.Point(22, 79);
            this.lblAddTitle.Name = "lblAddTitle";
            this.lblAddTitle.Size = new System.Drawing.Size(53, 25);
            this.lblAddTitle.TabIndex = 1;
            this.lblAddTitle.Text = "Title";
            // 
            // lblAddCustomerNo
            // 
            this.lblAddCustomerNo.AutoSize = true;
            this.lblAddCustomerNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddCustomerNo.Location = new System.Drawing.Point(22, 28);
            this.lblAddCustomerNo.Name = "lblAddCustomerNo";
            this.lblAddCustomerNo.Size = new System.Drawing.Size(137, 25);
            this.lblAddCustomerNo.TabIndex = 0;
            this.lblAddCustomerNo.Text = "Customer No";
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
            this.tabEdit.Controls.Add(this.txtEditForename);
            this.tabEdit.Controls.Add(this.txtEditSurname);
            this.tabEdit.Controls.Add(this.cmbEditTitle);
            this.tabEdit.Controls.Add(this.lblEditCustomerNumber);
            this.tabEdit.Controls.Add(this.lblEditTelephone);
            this.tabEdit.Controls.Add(this.lblEditPostcode);
            this.tabEdit.Controls.Add(this.lblEditCounty);
            this.tabEdit.Controls.Add(this.lblEditTown);
            this.tabEdit.Controls.Add(this.lblEditStreet);
            this.tabEdit.Controls.Add(this.lblEditForename);
            this.tabEdit.Controls.Add(this.lblEditSurname);
            this.tabEdit.Controls.Add(this.lblEditTitle);
            this.tabEdit.Controls.Add(this.lblEditCustomerNo);
            this.tabEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabEdit.Location = new System.Drawing.Point(4, 5);
            this.tabEdit.Name = "tabEdit";
            this.tabEdit.Size = new System.Drawing.Size(776, 509);
            this.tabEdit.TabIndex = 2;
            this.tabEdit.Text = "Edit";
            // 
            // btnEditEdit
            // 
            this.btnEditEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditEdit.FlatAppearance.BorderSize = 0;
            this.btnEditEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditEdit.Image = global::InTheDogHouse.Properties.Resources.keanoIcon;
            this.btnEditEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditEdit.Location = new System.Drawing.Point(565, 28);
            this.btnEditEdit.Name = "btnEditEdit";
            this.btnEditEdit.Size = new System.Drawing.Size(181, 55);
            this.btnEditEdit.TabIndex = 42;
            this.btnEditEdit.Text = "Edit";
            this.btnEditEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditEdit.UseVisualStyleBackColor = true;
            this.btnEditEdit.Click += new System.EventHandler(this.btnEditEdit_Click);
            // 
            // btnEditCancel
            // 
            this.btnEditCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditCancel.FlatAppearance.BorderSize = 0;
            this.btnEditCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditCancel.Image = global::InTheDogHouse.Properties.Resources._2DogsIcon;
            this.btnEditCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditCancel.Location = new System.Drawing.Point(565, 100);
            this.btnEditCancel.Name = "btnEditCancel";
            this.btnEditCancel.Size = new System.Drawing.Size(181, 55);
            this.btnEditCancel.TabIndex = 41;
            this.btnEditCancel.Text = "Cancel";
            this.btnEditCancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditCancel.UseVisualStyleBackColor = true;
            this.btnEditCancel.Click += new System.EventHandler(this.btnEditCancel_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox3.Image = global::InTheDogHouse.Properties.Resources.coco;
            this.pictureBox3.Location = new System.Drawing.Point(565, 310);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(181, 171);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 39;
            this.pictureBox3.TabStop = false;
            // 
            // txtEditTelephone
            // 
            this.txtEditTelephone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEditTelephone.Enabled = false;
            this.txtEditTelephone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditTelephone.Location = new System.Drawing.Point(199, 440);
            this.txtEditTelephone.Name = "txtEditTelephone";
            this.txtEditTelephone.Size = new System.Drawing.Size(331, 31);
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
            this.txtEditPostcode.Size = new System.Drawing.Size(331, 31);
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
            this.txtEditCounty.Size = new System.Drawing.Size(331, 31);
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
            this.txtEditTown.Size = new System.Drawing.Size(331, 31);
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
            this.txtEditStreet.Size = new System.Drawing.Size(331, 31);
            this.txtEditStreet.TabIndex = 34;
            // 
            // txtEditForename
            // 
            this.txtEditForename.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEditForename.Enabled = false;
            this.txtEditForename.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditForename.Location = new System.Drawing.Point(199, 181);
            this.txtEditForename.Name = "txtEditForename";
            this.txtEditForename.Size = new System.Drawing.Size(331, 31);
            this.txtEditForename.TabIndex = 33;
            // 
            // txtEditSurname
            // 
            this.txtEditSurname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEditSurname.Enabled = false;
            this.txtEditSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditSurname.Location = new System.Drawing.Point(199, 130);
            this.txtEditSurname.Name = "txtEditSurname";
            this.txtEditSurname.Size = new System.Drawing.Size(331, 31);
            this.txtEditSurname.TabIndex = 32;
            // 
            // cmbEditTitle
            // 
            this.cmbEditTitle.Enabled = false;
            this.cmbEditTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEditTitle.FormattingEnabled = true;
            this.cmbEditTitle.Items.AddRange(new object[] {
            "Mr",
            "Mrs",
            "Miss",
            "Ms",
            "Dr"});
            this.cmbEditTitle.Location = new System.Drawing.Point(199, 79);
            this.cmbEditTitle.Name = "cmbEditTitle";
            this.cmbEditTitle.Size = new System.Drawing.Size(171, 33);
            this.cmbEditTitle.TabIndex = 31;
            this.cmbEditTitle.Text = "Mr";
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
            this.lblEditPostcode.Size = new System.Drawing.Size(102, 25);
            this.lblEditPostcode.TabIndex = 28;
            this.lblEditPostcode.Text = "Postcode";
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
            this.lblEditForename.Location = new System.Drawing.Point(22, 181);
            this.lblEditForename.Name = "lblEditForename";
            this.lblEditForename.Size = new System.Drawing.Size(109, 25);
            this.lblEditForename.TabIndex = 24;
            this.lblEditForename.Text = "Forename";
            // 
            // lblEditSurname
            // 
            this.lblEditSurname.AutoSize = true;
            this.lblEditSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditSurname.Location = new System.Drawing.Point(22, 130);
            this.lblEditSurname.Name = "lblEditSurname";
            this.lblEditSurname.Size = new System.Drawing.Size(98, 25);
            this.lblEditSurname.TabIndex = 23;
            this.lblEditSurname.Text = "Surname";
            // 
            // lblEditTitle
            // 
            this.lblEditTitle.AutoSize = true;
            this.lblEditTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditTitle.Location = new System.Drawing.Point(22, 79);
            this.lblEditTitle.Name = "lblEditTitle";
            this.lblEditTitle.Size = new System.Drawing.Size(53, 25);
            this.lblEditTitle.TabIndex = 22;
            this.lblEditTitle.Text = "Title";
            // 
            // lblEditCustomerNo
            // 
            this.lblEditCustomerNo.AutoSize = true;
            this.lblEditCustomerNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditCustomerNo.Location = new System.Drawing.Point(22, 28);
            this.lblEditCustomerNo.Name = "lblEditCustomerNo";
            this.lblEditCustomerNo.Size = new System.Drawing.Size(137, 25);
            this.lblEditCustomerNo.TabIndex = 21;
            this.lblEditCustomerNo.Text = "Customer No";
            // 
            // errP
            // 
            this.errP.ContainerControl = this;
            // 
            // frmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 518);
            this.Controls.Add(this.tabDogHouse);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(100, 100);
            this.Name = "frmCustomer";
            this.Text = "In The Dog House - Customer ";
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.Shown += new System.EventHandler(this.MainPage_Shown);
            this.tabDogHouse.ResumeLayout(false);
            this.tabDisplay.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgAddDog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplay)).EndInit();
            this.tabAdd.ResumeLayout(false);
            this.tabAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabEdit.ResumeLayout(false);
            this.tabEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabDogHouse;
        private System.Windows.Forms.TabPage tabDisplay;
        private System.Windows.Forms.TabPage tabAdd;
        private System.Windows.Forms.TabPage tabEdit;
        private System.Windows.Forms.PictureBox imgAddDog;
        private System.Windows.Forms.DataGridView dgvDisplay;
        private System.Windows.Forms.Label lblAddTelephone;
        private System.Windows.Forms.Label lblAddPostcode;
        private System.Windows.Forms.Label lblAddCounty;
        private System.Windows.Forms.Label lblAddTown;
        private System.Windows.Forms.Label lblAddStreet;
        private System.Windows.Forms.Label lblAddForename;
        private System.Windows.Forms.Label lblAddSurname;
        private System.Windows.Forms.Label lblAddTitle;
        private System.Windows.Forms.Label lblAddCustomerNo;
        private System.Windows.Forms.TextBox txtAddSurname;
        private System.Windows.Forms.ComboBox cmbAddTitle;
        private System.Windows.Forms.Label lblAddCustomerNumber;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtAddTelephone;
        private System.Windows.Forms.TextBox txtAddPostcode;
        private System.Windows.Forms.TextBox txtAddCounty;
        private System.Windows.Forms.TextBox txtAddTown;
        private System.Windows.Forms.TextBox txtAddStreet;
        private System.Windows.Forms.TextBox txtAddForename;
        private System.Windows.Forms.Button btnDisplayExit;
        private System.Windows.Forms.Button btnDisplayDelete;
        private System.Windows.Forms.Button btnDisplayEdit;
        private System.Windows.Forms.Button btnDisplayAdd;
        private System.Windows.Forms.Button btnAddCancel;
        private System.Windows.Forms.Button btnAddAdd;
        private System.Windows.Forms.Button btnEditCancel;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox txtEditTelephone;
        private System.Windows.Forms.TextBox txtEditPostcode;
        private System.Windows.Forms.TextBox txtEditCounty;
        private System.Windows.Forms.TextBox txtEditTown;
        private System.Windows.Forms.TextBox txtEditStreet;
        private System.Windows.Forms.TextBox txtEditForename;
        private System.Windows.Forms.TextBox txtEditSurname;
        private System.Windows.Forms.ComboBox cmbEditTitle;
        private System.Windows.Forms.Label lblEditCustomerNumber;
        private System.Windows.Forms.Label lblEditTelephone;
        private System.Windows.Forms.Label lblEditPostcode;
        private System.Windows.Forms.Label lblEditCounty;
        private System.Windows.Forms.Label lblEditTown;
        private System.Windows.Forms.Label lblEditStreet;
        private System.Windows.Forms.Label lblEditForename;
        private System.Windows.Forms.Label lblEditSurname;
        private System.Windows.Forms.Label lblEditTitle;
        private System.Windows.Forms.Label lblEditCustomerNo;
        private System.Windows.Forms.Button btnEditEdit;
        private System.Windows.Forms.DataGridViewTextBoxColumn postcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.ErrorProvider errP;
    }
}

