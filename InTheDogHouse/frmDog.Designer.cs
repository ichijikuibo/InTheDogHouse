
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDog));
            this.tabDogHouse = new System.Windows.Forms.TabControl();
            this.tabDisplay = new System.Windows.Forms.TabPage();
            this.btnDisplayExit = new System.Windows.Forms.Button();
            this.btnDisplayDelete = new System.Windows.Forms.Button();
            this.btnDisplayEdit = new System.Windows.Forms.Button();
            this.btnDisplayAdd = new System.Windows.Forms.Button();
            this.imgAddDog = new System.Windows.Forms.PictureBox();
            this.dgvDisplay = new System.Windows.Forms.DataGridView();
            this.tabAdd = new System.Windows.Forms.TabPage();
            this.cmbAddGender = new System.Windows.Forms.ComboBox();
            this.dtpAddDOB = new System.Windows.Forms.DateTimePicker();
            this.txtAddColour = new System.Windows.Forms.TextBox();
            this.cmbAddCustomer = new System.Windows.Forms.ComboBox();
            this.cmbAddBreedNo = new System.Windows.Forms.ComboBox();
            this.lblAddBreed = new System.Windows.Forms.Label();
            this.lblAddCustomer = new System.Windows.Forms.Label();
            this.lblAddColour = new System.Windows.Forms.Label();
            this.lblAddGender = new System.Windows.Forms.Label();
            this.lblAddDOB = new System.Windows.Forms.Label();
            this.txtAddName = new System.Windows.Forms.TextBox();
            this.lblAddDogNumber = new System.Windows.Forms.Label();
            this.lblAddName = new System.Windows.Forms.Label();
            this.lblAddDogNo = new System.Windows.Forms.Label();
            this.btnAddCancel = new System.Windows.Forms.Button();
            this.btnAddAdd = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tabEdit = new System.Windows.Forms.TabPage();
            this.cmbEditGender = new System.Windows.Forms.ComboBox();
            this.dtpEditDOB = new System.Windows.Forms.DateTimePicker();
            this.txtEditColour = new System.Windows.Forms.TextBox();
            this.cmbEditCustomer = new System.Windows.Forms.ComboBox();
            this.cmbEditBreedNo = new System.Windows.Forms.ComboBox();
            this.lblEditBreed = new System.Windows.Forms.Label();
            this.lblEditCustomer = new System.Windows.Forms.Label();
            this.lblEditColour = new System.Windows.Forms.Label();
            this.lblEditGender = new System.Windows.Forms.Label();
            this.lblEditDOB = new System.Windows.Forms.Label();
            this.btnEditEdit = new System.Windows.Forms.Button();
            this.btnEditCancel = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.txtEditName = new System.Windows.Forms.TextBox();
            this.lblEditDogNumber = new System.Windows.Forms.Label();
            this.lblEditName = new System.Windows.Forms.Label();
            this.lblEditDogNo = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.errP = new System.Windows.Forms.ErrorProvider(this.components);
            this.ssDogs = new InTheDogHouse.SlideShow();
            this.tabDogHouse.SuspendLayout();
            this.tabDisplay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgAddDog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplay)).BeginInit();
            this.tabAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errP)).BeginInit();
            this.SuspendLayout();
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
            this.tabDogHouse.Size = new System.Drawing.Size(760, 489);
            this.tabDogHouse.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabDogHouse.TabIndex = 50;
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
            this.tabDisplay.Location = new System.Drawing.Point(4, 34);
            this.tabDisplay.Name = "tabDisplay";
            this.tabDisplay.Padding = new System.Windows.Forms.Padding(3);
            this.tabDisplay.Size = new System.Drawing.Size(752, 451);
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
            this.btnDisplayExit.Location = new System.Drawing.Point(587, 186);
            this.btnDisplayExit.Name = "btnDisplayExit";
            this.btnDisplayExit.Size = new System.Drawing.Size(159, 55);
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
            this.btnDisplayDelete.Location = new System.Drawing.Point(587, 126);
            this.btnDisplayDelete.Name = "btnDisplayDelete";
            this.btnDisplayDelete.Size = new System.Drawing.Size(159, 55);
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
            this.btnDisplayEdit.Location = new System.Drawing.Point(587, 66);
            this.btnDisplayEdit.Name = "btnDisplayEdit";
            this.btnDisplayEdit.Size = new System.Drawing.Size(159, 55);
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
            this.btnDisplayAdd.Location = new System.Drawing.Point(587, 6);
            this.btnDisplayAdd.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnDisplayAdd.Name = "btnDisplayAdd";
            this.btnDisplayAdd.Size = new System.Drawing.Size(159, 55);
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
            this.imgAddDog.Location = new System.Drawing.Point(587, 247);
            this.imgAddDog.Name = "imgAddDog";
            this.imgAddDog.Size = new System.Drawing.Size(159, 201);
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
            this.dgvDisplay.Size = new System.Drawing.Size(575, 439);
            this.dgvDisplay.TabIndex = 0;
            // 
            // tabAdd
            // 
            this.tabAdd.BackColor = System.Drawing.Color.Transparent;
            this.tabAdd.Controls.Add(this.cmbAddGender);
            this.tabAdd.Controls.Add(this.dtpAddDOB);
            this.tabAdd.Controls.Add(this.txtAddColour);
            this.tabAdd.Controls.Add(this.cmbAddCustomer);
            this.tabAdd.Controls.Add(this.cmbAddBreedNo);
            this.tabAdd.Controls.Add(this.lblAddBreed);
            this.tabAdd.Controls.Add(this.lblAddCustomer);
            this.tabAdd.Controls.Add(this.lblAddColour);
            this.tabAdd.Controls.Add(this.lblAddGender);
            this.tabAdd.Controls.Add(this.lblAddDOB);
            this.tabAdd.Controls.Add(this.txtAddName);
            this.tabAdd.Controls.Add(this.lblAddDogNumber);
            this.tabAdd.Controls.Add(this.lblAddName);
            this.tabAdd.Controls.Add(this.lblAddDogNo);
            this.tabAdd.Controls.Add(this.btnAddCancel);
            this.tabAdd.Controls.Add(this.btnAddAdd);
            this.tabAdd.Controls.Add(this.pictureBox2);
            this.tabAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabAdd.Location = new System.Drawing.Point(4, 34);
            this.tabAdd.Name = "tabAdd";
            this.tabAdd.Padding = new System.Windows.Forms.Padding(3);
            this.tabAdd.Size = new System.Drawing.Size(752, 451);
            this.tabAdd.TabIndex = 1;
            this.tabAdd.Text = "Add";
            // 
            // cmbAddGender
            // 
            this.cmbAddGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAddGender.FormattingEnabled = true;
            this.cmbAddGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbAddGender.Location = new System.Drawing.Point(199, 280);
            this.cmbAddGender.Name = "cmbAddGender";
            this.cmbAddGender.Size = new System.Drawing.Size(308, 28);
            this.cmbAddGender.TabIndex = 67;
            // 
            // dtpAddDOB
            // 
            this.dtpAddDOB.Location = new System.Drawing.Point(199, 215);
            this.dtpAddDOB.Name = "dtpAddDOB";
            this.dtpAddDOB.Size = new System.Drawing.Size(308, 26);
            this.dtpAddDOB.TabIndex = 66;
            this.dtpAddDOB.Value = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            // 
            // txtAddColour
            // 
            this.txtAddColour.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAddColour.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddColour.Location = new System.Drawing.Point(199, 337);
            this.txtAddColour.Name = "txtAddColour";
            this.txtAddColour.Size = new System.Drawing.Size(308, 31);
            this.txtAddColour.TabIndex = 65;
            // 
            // cmbAddCustomer
            // 
            this.cmbAddCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAddCustomer.FormattingEnabled = true;
            this.cmbAddCustomer.Location = new System.Drawing.Point(199, 404);
            this.cmbAddCustomer.Name = "cmbAddCustomer";
            this.cmbAddCustomer.Size = new System.Drawing.Size(308, 28);
            this.cmbAddCustomer.TabIndex = 64;
            // 
            // cmbAddBreedNo
            // 
            this.cmbAddBreedNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAddBreedNo.FormattingEnabled = true;
            this.cmbAddBreedNo.Location = new System.Drawing.Point(199, 152);
            this.cmbAddBreedNo.Name = "cmbAddBreedNo";
            this.cmbAddBreedNo.Size = new System.Drawing.Size(308, 28);
            this.cmbAddBreedNo.TabIndex = 63;
            // 
            // lblAddBreed
            // 
            this.lblAddBreed.AutoSize = true;
            this.lblAddBreed.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddBreed.Location = new System.Drawing.Point(23, 151);
            this.lblAddBreed.Name = "lblAddBreed";
            this.lblAddBreed.Size = new System.Drawing.Size(102, 25);
            this.lblAddBreed.TabIndex = 62;
            this.lblAddBreed.Text = "Breed No";
            // 
            // lblAddCustomer
            // 
            this.lblAddCustomer.AutoSize = true;
            this.lblAddCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddCustomer.Location = new System.Drawing.Point(23, 407);
            this.lblAddCustomer.Name = "lblAddCustomer";
            this.lblAddCustomer.Size = new System.Drawing.Size(104, 25);
            this.lblAddCustomer.TabIndex = 61;
            this.lblAddCustomer.Text = "Customer";
            // 
            // lblAddColour
            // 
            this.lblAddColour.AutoSize = true;
            this.lblAddColour.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddColour.Location = new System.Drawing.Point(23, 343);
            this.lblAddColour.Name = "lblAddColour";
            this.lblAddColour.Size = new System.Drawing.Size(75, 25);
            this.lblAddColour.TabIndex = 60;
            this.lblAddColour.Text = "Colour";
            // 
            // lblAddGender
            // 
            this.lblAddGender.AutoSize = true;
            this.lblAddGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddGender.Location = new System.Drawing.Point(23, 279);
            this.lblAddGender.Name = "lblAddGender";
            this.lblAddGender.Size = new System.Drawing.Size(83, 25);
            this.lblAddGender.TabIndex = 59;
            this.lblAddGender.Text = "Gender";
            // 
            // lblAddDOB
            // 
            this.lblAddDOB.AutoSize = true;
            this.lblAddDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddDOB.Location = new System.Drawing.Point(23, 215);
            this.lblAddDOB.Name = "lblAddDOB";
            this.lblAddDOB.Size = new System.Drawing.Size(57, 25);
            this.lblAddDOB.TabIndex = 58;
            this.lblAddDOB.Text = "DOB";
            // 
            // txtAddName
            // 
            this.txtAddName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAddName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddName.Location = new System.Drawing.Point(199, 87);
            this.txtAddName.Name = "txtAddName";
            this.txtAddName.Size = new System.Drawing.Size(308, 31);
            this.txtAddName.TabIndex = 57;
            // 
            // lblAddDogNumber
            // 
            this.lblAddDogNumber.AutoSize = true;
            this.lblAddDogNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddDogNumber.Location = new System.Drawing.Point(199, 23);
            this.lblAddDogNumber.Name = "lblAddDogNumber";
            this.lblAddDogNumber.Size = new System.Drawing.Size(19, 25);
            this.lblAddDogNumber.TabIndex = 56;
            this.lblAddDogNumber.Text = "-";
            // 
            // lblAddName
            // 
            this.lblAddName.AutoSize = true;
            this.lblAddName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddName.Location = new System.Drawing.Point(23, 87);
            this.lblAddName.Name = "lblAddName";
            this.lblAddName.Size = new System.Drawing.Size(68, 25);
            this.lblAddName.TabIndex = 55;
            this.lblAddName.Text = "Name";
            // 
            // lblAddDogNo
            // 
            this.lblAddDogNo.AutoSize = true;
            this.lblAddDogNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddDogNo.Location = new System.Drawing.Point(23, 23);
            this.lblAddDogNo.Name = "lblAddDogNo";
            this.lblAddDogNo.Size = new System.Drawing.Size(84, 25);
            this.lblAddDogNo.TabIndex = 54;
            this.lblAddDogNo.Text = "Dog No";
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
            this.pictureBox2.Location = new System.Drawing.Point(565, 252);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(181, 193);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // tabEdit
            // 
            this.tabEdit.BackColor = System.Drawing.Color.Transparent;
            this.tabEdit.Controls.Add(this.cmbEditGender);
            this.tabEdit.Controls.Add(this.dtpEditDOB);
            this.tabEdit.Controls.Add(this.txtEditColour);
            this.tabEdit.Controls.Add(this.cmbEditCustomer);
            this.tabEdit.Controls.Add(this.cmbEditBreedNo);
            this.tabEdit.Controls.Add(this.lblEditBreed);
            this.tabEdit.Controls.Add(this.lblEditCustomer);
            this.tabEdit.Controls.Add(this.lblEditColour);
            this.tabEdit.Controls.Add(this.lblEditGender);
            this.tabEdit.Controls.Add(this.lblEditDOB);
            this.tabEdit.Controls.Add(this.btnEditEdit);
            this.tabEdit.Controls.Add(this.btnEditCancel);
            this.tabEdit.Controls.Add(this.pictureBox3);
            this.tabEdit.Controls.Add(this.txtEditName);
            this.tabEdit.Controls.Add(this.lblEditDogNumber);
            this.tabEdit.Controls.Add(this.lblEditName);
            this.tabEdit.Controls.Add(this.lblEditDogNo);
            this.tabEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabEdit.Location = new System.Drawing.Point(4, 34);
            this.tabEdit.Name = "tabEdit";
            this.tabEdit.Size = new System.Drawing.Size(752, 451);
            this.tabEdit.TabIndex = 2;
            this.tabEdit.Text = "Edit";
            // 
            // cmbEditGender
            // 
            this.cmbEditGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEditGender.Enabled = false;
            this.cmbEditGender.FormattingEnabled = true;
            this.cmbEditGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbEditGender.Location = new System.Drawing.Point(199, 285);
            this.cmbEditGender.Name = "cmbEditGender";
            this.cmbEditGender.Size = new System.Drawing.Size(308, 28);
            this.cmbEditGender.TabIndex = 53;
            // 
            // dtpEditDOB
            // 
            this.dtpEditDOB.Enabled = false;
            this.dtpEditDOB.Location = new System.Drawing.Point(199, 220);
            this.dtpEditDOB.Name = "dtpEditDOB";
            this.dtpEditDOB.Size = new System.Drawing.Size(308, 26);
            this.dtpEditDOB.TabIndex = 52;
            // 
            // txtEditColour
            // 
            this.txtEditColour.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEditColour.Enabled = false;
            this.txtEditColour.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditColour.Location = new System.Drawing.Point(199, 342);
            this.txtEditColour.Name = "txtEditColour";
            this.txtEditColour.Size = new System.Drawing.Size(308, 31);
            this.txtEditColour.TabIndex = 51;
            // 
            // cmbEditCustomer
            // 
            this.cmbEditCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEditCustomer.Enabled = false;
            this.cmbEditCustomer.FormattingEnabled = true;
            this.cmbEditCustomer.Location = new System.Drawing.Point(199, 409);
            this.cmbEditCustomer.Name = "cmbEditCustomer";
            this.cmbEditCustomer.Size = new System.Drawing.Size(308, 28);
            this.cmbEditCustomer.TabIndex = 50;
            // 
            // cmbEditBreedNo
            // 
            this.cmbEditBreedNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEditBreedNo.Enabled = false;
            this.cmbEditBreedNo.FormattingEnabled = true;
            this.cmbEditBreedNo.Location = new System.Drawing.Point(199, 157);
            this.cmbEditBreedNo.Name = "cmbEditBreedNo";
            this.cmbEditBreedNo.Size = new System.Drawing.Size(308, 28);
            this.cmbEditBreedNo.TabIndex = 49;
            // 
            // lblEditBreed
            // 
            this.lblEditBreed.AutoSize = true;
            this.lblEditBreed.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditBreed.Location = new System.Drawing.Point(23, 156);
            this.lblEditBreed.Name = "lblEditBreed";
            this.lblEditBreed.Size = new System.Drawing.Size(102, 25);
            this.lblEditBreed.TabIndex = 48;
            this.lblEditBreed.Text = "Breed No";
            // 
            // lblEditCustomer
            // 
            this.lblEditCustomer.AutoSize = true;
            this.lblEditCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditCustomer.Location = new System.Drawing.Point(23, 412);
            this.lblEditCustomer.Name = "lblEditCustomer";
            this.lblEditCustomer.Size = new System.Drawing.Size(104, 25);
            this.lblEditCustomer.TabIndex = 46;
            this.lblEditCustomer.Text = "Customer";
            // 
            // lblEditColour
            // 
            this.lblEditColour.AutoSize = true;
            this.lblEditColour.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditColour.Location = new System.Drawing.Point(23, 348);
            this.lblEditColour.Name = "lblEditColour";
            this.lblEditColour.Size = new System.Drawing.Size(75, 25);
            this.lblEditColour.TabIndex = 45;
            this.lblEditColour.Text = "Colour";
            // 
            // lblEditGender
            // 
            this.lblEditGender.AutoSize = true;
            this.lblEditGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditGender.Location = new System.Drawing.Point(23, 284);
            this.lblEditGender.Name = "lblEditGender";
            this.lblEditGender.Size = new System.Drawing.Size(83, 25);
            this.lblEditGender.TabIndex = 44;
            this.lblEditGender.Text = "Gender";
            // 
            // lblEditDOB
            // 
            this.lblEditDOB.AutoSize = true;
            this.lblEditDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditDOB.Location = new System.Drawing.Point(23, 220);
            this.lblEditDOB.Name = "lblEditDOB";
            this.lblEditDOB.Size = new System.Drawing.Size(57, 25);
            this.lblEditDOB.TabIndex = 43;
            this.lblEditDOB.Text = "DOB";
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
            this.btnEditCancel.Location = new System.Drawing.Point(563, 100);
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
            this.pictureBox3.Location = new System.Drawing.Point(563, 266);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(181, 171);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 39;
            this.pictureBox3.TabStop = false;
            // 
            // txtEditName
            // 
            this.txtEditName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEditName.Enabled = false;
            this.txtEditName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditName.Location = new System.Drawing.Point(199, 92);
            this.txtEditName.Name = "txtEditName";
            this.txtEditName.Size = new System.Drawing.Size(308, 31);
            this.txtEditName.TabIndex = 32;
            // 
            // lblEditDogNumber
            // 
            this.lblEditDogNumber.AutoSize = true;
            this.lblEditDogNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditDogNumber.Location = new System.Drawing.Point(199, 28);
            this.lblEditDogNumber.Name = "lblEditDogNumber";
            this.lblEditDogNumber.Size = new System.Drawing.Size(19, 25);
            this.lblEditDogNumber.TabIndex = 30;
            this.lblEditDogNumber.Text = "-";
            // 
            // lblEditName
            // 
            this.lblEditName.AutoSize = true;
            this.lblEditName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditName.Location = new System.Drawing.Point(23, 92);
            this.lblEditName.Name = "lblEditName";
            this.lblEditName.Size = new System.Drawing.Size(68, 25);
            this.lblEditName.TabIndex = 23;
            this.lblEditName.Text = "Name";
            // 
            // lblEditDogNo
            // 
            this.lblEditDogNo.AutoSize = true;
            this.lblEditDogNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditDogNo.Location = new System.Drawing.Point(23, 28);
            this.lblEditDogNo.Name = "lblEditDogNo";
            this.lblEditDogNo.Size = new System.Drawing.Size(84, 25);
            this.lblEditDogNo.TabIndex = 21;
            this.lblEditDogNo.Text = "Dog No";
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
            // errP
            // 
            this.errP.ContainerControl = this;
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
            // frmDog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 692);
            this.Controls.Add(this.ssDogs);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.tabDogHouse);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDog";
            this.Text = "Dog";
            this.Load += new System.EventHandler(this.Dog_Load);
            this.Shown += new System.EventHandler(this.MainPage_Shown);
            this.Resize += new System.EventHandler(this.frmDog_ResizeEnd);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errP)).EndInit();
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
        private System.Windows.Forms.TextBox txtEditName;
        private System.Windows.Forms.Label lblEditDogNumber;
        private System.Windows.Forms.Label lblEditName;
        private System.Windows.Forms.Label lblEditDogNo;
        private System.Windows.Forms.DateTimePicker dtpEditDOB;
        private System.Windows.Forms.TextBox txtEditColour;
        private System.Windows.Forms.ComboBox cmbEditCustomer;
        private System.Windows.Forms.ComboBox cmbEditBreedNo;
        private System.Windows.Forms.Label lblEditBreed;
        private System.Windows.Forms.Label lblEditCustomer;
        private System.Windows.Forms.Label lblEditColour;
        private System.Windows.Forms.Label lblEditGender;
        private System.Windows.Forms.Label lblEditDOB;
        private System.Windows.Forms.ComboBox cmbEditGender;
        private System.Windows.Forms.TabPage tabAdd;
        private System.Windows.Forms.ComboBox cmbAddGender;
        private System.Windows.Forms.DateTimePicker dtpAddDOB;
        private System.Windows.Forms.TextBox txtAddColour;
        private System.Windows.Forms.ComboBox cmbAddCustomer;
        private System.Windows.Forms.ComboBox cmbAddBreedNo;
        private System.Windows.Forms.Label lblAddBreed;
        private System.Windows.Forms.Label lblAddCustomer;
        private System.Windows.Forms.Label lblAddColour;
        private System.Windows.Forms.Label lblAddGender;
        private System.Windows.Forms.Label lblAddDOB;
        private System.Windows.Forms.TextBox txtAddName;
        private System.Windows.Forms.Label lblAddDogNumber;
        private System.Windows.Forms.Label lblAddName;
        private System.Windows.Forms.Label lblAddDogNo;
        private System.Windows.Forms.Button btnAddCancel;
        private System.Windows.Forms.Button btnAddAdd;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ErrorProvider errP;
    }
}