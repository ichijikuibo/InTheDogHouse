
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
            this.ssDogs = new InTheDogHouse.SlideShow();
            this.tabDogHouse = new System.Windows.Forms.TabControl();
            this.tabDisplay = new System.Windows.Forms.TabPage();
            this.btnDisplayExit = new System.Windows.Forms.Button();
            this.btnDisplayDelete = new System.Windows.Forms.Button();
            this.btnDisplayEdit = new System.Windows.Forms.Button();
            this.btnDisplayAdd = new System.Windows.Forms.Button();
            this.imgAddDog = new System.Windows.Forms.PictureBox();
            this.dgvDisplay = new System.Windows.Forms.DataGridView();
            this.tabAdd = new System.Windows.Forms.TabPage();
            this.cmbAddBreed = new System.Windows.Forms.ComboBox();
            this.txtAddColour = new System.Windows.Forms.TextBox();
            this.txtAddName = new System.Windows.Forms.TextBox();
            this.lblAddColour = new System.Windows.Forms.Label();
            this.lblAddBreedNo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddCancel = new System.Windows.Forms.Button();
            this.btnAddAdd = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblAddDogNumber = new System.Windows.Forms.Label();
            this.lblAddDogNo = new System.Windows.Forms.Label();
            this.tabEdit = new System.Windows.Forms.TabPage();
            this.btnEditEdit = new System.Windows.Forms.Button();
            this.btnEditCancel = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lblAddDOB = new System.Windows.Forms.Label();
            this.dtAddDOB = new System.Windows.Forms.DateTimePicker();
            this.lblAddGender = new System.Windows.Forms.Label();
            this.cmbAddCustomerNo = new System.Windows.Forms.ComboBox();
            this.lblAddCustomerNo = new System.Windows.Forms.Label();
            this.cmbEditCustomerNo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtEditDOB = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbEditBreed = new System.Windows.Forms.ComboBox();
            this.txtEditColour = new System.Windows.Forms.TextBox();
            this.txtEditName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblEditDogNumber = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbAddGender = new System.Windows.Forms.ComboBox();
            this.cmbEditGender = new System.Windows.Forms.ComboBox();
            this.errP = new System.Windows.Forms.ErrorProvider(this.components);
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
            this.tabDogHouse.Size = new System.Drawing.Size(760, 518);
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
            this.tabDisplay.Size = new System.Drawing.Size(752, 480);
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
            this.imgAddDog.Location = new System.Drawing.Point(587, 276);
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
            this.dgvDisplay.Size = new System.Drawing.Size(575, 468);
            this.dgvDisplay.TabIndex = 0;
            // 
            // tabAdd
            // 
            this.tabAdd.BackColor = System.Drawing.Color.Transparent;
            this.tabAdd.Controls.Add(this.cmbAddGender);
            this.tabAdd.Controls.Add(this.cmbAddCustomerNo);
            this.tabAdd.Controls.Add(this.lblAddCustomerNo);
            this.tabAdd.Controls.Add(this.lblAddGender);
            this.tabAdd.Controls.Add(this.dtAddDOB);
            this.tabAdd.Controls.Add(this.lblAddDOB);
            this.tabAdd.Controls.Add(this.cmbAddBreed);
            this.tabAdd.Controls.Add(this.txtAddColour);
            this.tabAdd.Controls.Add(this.txtAddName);
            this.tabAdd.Controls.Add(this.lblAddColour);
            this.tabAdd.Controls.Add(this.lblAddBreedNo);
            this.tabAdd.Controls.Add(this.label3);
            this.tabAdd.Controls.Add(this.btnAddCancel);
            this.tabAdd.Controls.Add(this.btnAddAdd);
            this.tabAdd.Controls.Add(this.pictureBox2);
            this.tabAdd.Controls.Add(this.lblAddDogNumber);
            this.tabAdd.Controls.Add(this.lblAddDogNo);
            this.tabAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabAdd.Location = new System.Drawing.Point(4, 34);
            this.tabAdd.Name = "tabAdd";
            this.tabAdd.Padding = new System.Windows.Forms.Padding(3);
            this.tabAdd.Size = new System.Drawing.Size(752, 480);
            this.tabAdd.TabIndex = 1;
            this.tabAdd.Text = "Add";
            // 
            // cmbAddBreed
            // 
            this.cmbAddBreed.FormattingEnabled = true;
            this.cmbAddBreed.Location = new System.Drawing.Point(175, 169);
            this.cmbAddBreed.Name = "cmbAddBreed";
            this.cmbAddBreed.Size = new System.Drawing.Size(339, 28);
            this.cmbAddBreed.TabIndex = 43;
            // 
            // txtAddColour
            // 
            this.txtAddColour.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAddColour.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddColour.Location = new System.Drawing.Point(175, 225);
            this.txtAddColour.Name = "txtAddColour";
            this.txtAddColour.Size = new System.Drawing.Size(339, 31);
            this.txtAddColour.TabIndex = 42;
            // 
            // txtAddName
            // 
            this.txtAddName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAddName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddName.Location = new System.Drawing.Point(175, 116);
            this.txtAddName.Name = "txtAddName";
            this.txtAddName.Size = new System.Drawing.Size(339, 31);
            this.txtAddName.TabIndex = 41;
            // 
            // lblAddColour
            // 
            this.lblAddColour.AutoSize = true;
            this.lblAddColour.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddColour.Location = new System.Drawing.Point(28, 225);
            this.lblAddColour.Name = "lblAddColour";
            this.lblAddColour.Size = new System.Drawing.Size(75, 25);
            this.lblAddColour.TabIndex = 40;
            this.lblAddColour.Text = "Colour";
            // 
            // lblAddBreedNo
            // 
            this.lblAddBreedNo.AutoSize = true;
            this.lblAddBreedNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddBreedNo.Location = new System.Drawing.Point(28, 168);
            this.lblAddBreedNo.Name = "lblAddBreedNo";
            this.lblAddBreedNo.Size = new System.Drawing.Size(102, 25);
            this.lblAddBreedNo.TabIndex = 39;
            this.lblAddBreedNo.Text = "Breed No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 25);
            this.label3.TabIndex = 38;
            this.label3.Text = "Name";
            // 
            // btnAddCancel
            // 
            this.btnAddCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddCancel.FlatAppearance.BorderSize = 0;
            this.btnAddCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCancel.Image = global::InTheDogHouse.Properties.Resources._2DogsIcon;
            this.btnAddCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddCancel.Location = new System.Drawing.Point(565, 113);
            this.btnAddCancel.Name = "btnAddCancel";
            this.btnAddCancel.Size = new System.Drawing.Size(181, 55);
            this.btnAddCancel.TabIndex = 20;
            this.btnAddCancel.Text = "Cancel";
            this.btnAddCancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddCancel.UseVisualStyleBackColor = true;
            // 
            // btnAddAdd
            // 
            this.btnAddAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddAdd.FlatAppearance.BorderSize = 0;
            this.btnAddAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAddAdd.Image")));
            this.btnAddAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddAdd.Location = new System.Drawing.Point(565, 51);
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
            this.pictureBox2.Location = new System.Drawing.Point(565, 284);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(181, 193);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // lblAddDogNumber
            // 
            this.lblAddDogNumber.AutoSize = true;
            this.lblAddDogNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddDogNumber.Location = new System.Drawing.Point(175, 66);
            this.lblAddDogNumber.Name = "lblAddDogNumber";
            this.lblAddDogNumber.Size = new System.Drawing.Size(96, 25);
            this.lblAddDogNumber.TabIndex = 9;
            this.lblAddDogNumber.Text = "9999999";
            // 
            // lblAddDogNo
            // 
            this.lblAddDogNo.AutoSize = true;
            this.lblAddDogNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddDogNo.Location = new System.Drawing.Point(28, 66);
            this.lblAddDogNo.Name = "lblAddDogNo";
            this.lblAddDogNo.Size = new System.Drawing.Size(84, 25);
            this.lblAddDogNo.TabIndex = 0;
            this.lblAddDogNo.Text = "Dog No";
            // 
            // tabEdit
            // 
            this.tabEdit.BackColor = System.Drawing.Color.Transparent;
            this.tabEdit.Controls.Add(this.cmbEditGender);
            this.tabEdit.Controls.Add(this.cmbEditCustomerNo);
            this.tabEdit.Controls.Add(this.label1);
            this.tabEdit.Controls.Add(this.label2);
            this.tabEdit.Controls.Add(this.dtEditDOB);
            this.tabEdit.Controls.Add(this.label4);
            this.tabEdit.Controls.Add(this.cmbEditBreed);
            this.tabEdit.Controls.Add(this.txtEditColour);
            this.tabEdit.Controls.Add(this.txtEditName);
            this.tabEdit.Controls.Add(this.label5);
            this.tabEdit.Controls.Add(this.label6);
            this.tabEdit.Controls.Add(this.label7);
            this.tabEdit.Controls.Add(this.lblEditDogNumber);
            this.tabEdit.Controls.Add(this.label9);
            this.tabEdit.Controls.Add(this.btnEditEdit);
            this.tabEdit.Controls.Add(this.btnEditCancel);
            this.tabEdit.Controls.Add(this.pictureBox3);
            this.tabEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabEdit.Location = new System.Drawing.Point(4, 34);
            this.tabEdit.Name = "tabEdit";
            this.tabEdit.Size = new System.Drawing.Size(752, 480);
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
            this.pictureBox3.Location = new System.Drawing.Point(563, 306);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(181, 171);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 39;
            this.pictureBox3.TabStop = false;
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
            // lblAddDOB
            // 
            this.lblAddDOB.AutoSize = true;
            this.lblAddDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddDOB.Location = new System.Drawing.Point(28, 277);
            this.lblAddDOB.Name = "lblAddDOB";
            this.lblAddDOB.Size = new System.Drawing.Size(57, 25);
            this.lblAddDOB.TabIndex = 44;
            this.lblAddDOB.Text = "DOB";
            // 
            // dtAddDOB
            // 
            this.dtAddDOB.Location = new System.Drawing.Point(175, 277);
            this.dtAddDOB.Name = "dtAddDOB";
            this.dtAddDOB.Size = new System.Drawing.Size(339, 26);
            this.dtAddDOB.TabIndex = 45;
            // 
            // lblAddGender
            // 
            this.lblAddGender.AutoSize = true;
            this.lblAddGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddGender.Location = new System.Drawing.Point(28, 333);
            this.lblAddGender.Name = "lblAddGender";
            this.lblAddGender.Size = new System.Drawing.Size(83, 25);
            this.lblAddGender.TabIndex = 46;
            this.lblAddGender.Text = "Gender";
            // 
            // cmbAddCustomerNo
            // 
            this.cmbAddCustomerNo.FormattingEnabled = true;
            this.cmbAddCustomerNo.Location = new System.Drawing.Point(175, 397);
            this.cmbAddCustomerNo.Name = "cmbAddCustomerNo";
            this.cmbAddCustomerNo.Size = new System.Drawing.Size(339, 28);
            this.cmbAddCustomerNo.TabIndex = 49;
            // 
            // lblAddCustomerNo
            // 
            this.lblAddCustomerNo.AutoSize = true;
            this.lblAddCustomerNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddCustomerNo.Location = new System.Drawing.Point(28, 397);
            this.lblAddCustomerNo.Name = "lblAddCustomerNo";
            this.lblAddCustomerNo.Size = new System.Drawing.Size(137, 25);
            this.lblAddCustomerNo.TabIndex = 48;
            this.lblAddCustomerNo.Text = "Customer No";
            // 
            // cmbEditCustomerNo
            // 
            this.cmbEditCustomerNo.Enabled = false;
            this.cmbEditCustomerNo.FormattingEnabled = true;
            this.cmbEditCustomerNo.Location = new System.Drawing.Point(180, 389);
            this.cmbEditCustomerNo.Name = "cmbEditCustomerNo";
            this.cmbEditCustomerNo.Size = new System.Drawing.Size(339, 28);
            this.cmbEditCustomerNo.TabIndex = 63;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 389);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 25);
            this.label1.TabIndex = 62;
            this.label1.Text = "Customer No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 325);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 25);
            this.label2.TabIndex = 60;
            this.label2.Text = "Gender";
            // 
            // dtEditDOB
            // 
            this.dtEditDOB.Enabled = false;
            this.dtEditDOB.Location = new System.Drawing.Point(180, 269);
            this.dtEditDOB.Name = "dtEditDOB";
            this.dtEditDOB.Size = new System.Drawing.Size(339, 26);
            this.dtEditDOB.TabIndex = 59;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 25);
            this.label4.TabIndex = 58;
            this.label4.Text = "DOB";
            // 
            // cmbEditBreed
            // 
            this.cmbEditBreed.Enabled = false;
            this.cmbEditBreed.FormattingEnabled = true;
            this.cmbEditBreed.Location = new System.Drawing.Point(180, 161);
            this.cmbEditBreed.Name = "cmbEditBreed";
            this.cmbEditBreed.Size = new System.Drawing.Size(339, 28);
            this.cmbEditBreed.TabIndex = 57;
            // 
            // txtEditColour
            // 
            this.txtEditColour.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEditColour.Enabled = false;
            this.txtEditColour.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditColour.Location = new System.Drawing.Point(180, 217);
            this.txtEditColour.Name = "txtEditColour";
            this.txtEditColour.Size = new System.Drawing.Size(339, 31);
            this.txtEditColour.TabIndex = 56;
            // 
            // txtEditName
            // 
            this.txtEditName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEditName.Enabled = false;
            this.txtEditName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditName.Location = new System.Drawing.Point(180, 108);
            this.txtEditName.Name = "txtEditName";
            this.txtEditName.Size = new System.Drawing.Size(339, 31);
            this.txtEditName.TabIndex = 55;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 25);
            this.label5.TabIndex = 54;
            this.label5.Text = "Colour";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(33, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 25);
            this.label6.TabIndex = 53;
            this.label6.Text = "Breed No";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(33, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 25);
            this.label7.TabIndex = 52;
            this.label7.Text = "Name";
            // 
            // lblEditDogNumber
            // 
            this.lblEditDogNumber.AutoSize = true;
            this.lblEditDogNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditDogNumber.Location = new System.Drawing.Point(180, 58);
            this.lblEditDogNumber.Name = "lblEditDogNumber";
            this.lblEditDogNumber.Size = new System.Drawing.Size(96, 25);
            this.lblEditDogNumber.TabIndex = 51;
            this.lblEditDogNumber.Text = "9999999";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(33, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 25);
            this.label9.TabIndex = 50;
            this.label9.Text = "Dog No";
            // 
            // cmbAddGender
            // 
            this.cmbAddGender.FormattingEnabled = true;
            this.cmbAddGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbAddGender.Location = new System.Drawing.Point(175, 334);
            this.cmbAddGender.Name = "cmbAddGender";
            this.cmbAddGender.Size = new System.Drawing.Size(339, 28);
            this.cmbAddGender.TabIndex = 50;
            // 
            // cmbEditGender
            // 
            this.cmbEditGender.FormattingEnabled = true;
            this.cmbEditGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbEditGender.Location = new System.Drawing.Point(180, 326);
            this.cmbEditGender.Name = "cmbEditGender";
            this.cmbEditGender.Size = new System.Drawing.Size(339, 28);
            this.cmbEditGender.TabIndex = 64;
            // 
            // errP
            // 
            this.errP.ContainerControl = this;
            // 
            // frmDog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 721);
            this.Controls.Add(this.ssDogs);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.tabDogHouse);
            this.Name = "frmDog";
            this.Text = "Dogs";
            this.Load += new System.EventHandler(this.frmDog_Load);
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
        private System.Windows.Forms.TabPage tabAdd;
        private System.Windows.Forms.Button btnAddCancel;
        private System.Windows.Forms.Button btnAddAdd;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblAddDogNumber;
        private System.Windows.Forms.Label lblAddDogNo;
        private System.Windows.Forms.ComboBox cmbAddBreed;
        private System.Windows.Forms.TextBox txtAddColour;
        private System.Windows.Forms.TextBox txtAddName;
        private System.Windows.Forms.Label lblAddColour;
        private System.Windows.Forms.Label lblAddBreedNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbAddCustomerNo;
        private System.Windows.Forms.Label lblAddCustomerNo;
        private System.Windows.Forms.Label lblAddGender;
        private System.Windows.Forms.DateTimePicker dtAddDOB;
        private System.Windows.Forms.Label lblAddDOB;
        private System.Windows.Forms.ComboBox cmbEditCustomerNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtEditDOB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbEditBreed;
        private System.Windows.Forms.TextBox txtEditColour;
        private System.Windows.Forms.TextBox txtEditName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblEditDogNumber;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbAddGender;
        private System.Windows.Forms.ComboBox cmbEditGender;
        private System.Windows.Forms.ErrorProvider errP;
    }
}