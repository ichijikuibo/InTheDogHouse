
namespace InTheDogHouse
{
    partial class frmBooking2
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
            this.tabBooking = new System.Windows.Forms.TabControl();
            this.tabCustomerDetails = new System.Windows.Forms.TabPage();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.numDays = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblBookingRange = new System.Windows.Forms.Label();
            this.lblBooking = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.MonthCalendar();
            this.rtbCustomerDetails = new System.Windows.Forms.RichTextBox();
            this.lblCustomerNo = new System.Windows.Forms.Label();
            this.lblCustomerNumber = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCustomer = new System.Windows.Forms.TextBox();
            this.lstCustomer = new System.Windows.Forms.ListBox();
            this.tabBookingDetails = new System.Windows.Forms.TabPage();
            this.btnNewDog = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lstKennel = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lstDog = new System.Windows.Forms.ListBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lvBooking = new System.Windows.Forms.ListView();
            this.clmDogNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmDogName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmKennel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSave = new System.Windows.Forms.Button();
            this.btnGoBack = new System.Windows.Forms.Button();
            this.tabBooking.SuspendLayout();
            this.tabCustomerDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDays)).BeginInit();
            this.tabBookingDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabBooking
            // 
            this.tabBooking.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabBooking.Controls.Add(this.tabCustomerDetails);
            this.tabBooking.Controls.Add(this.tabBookingDetails);
            this.tabBooking.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabBooking.ItemSize = new System.Drawing.Size(0, 1);
            this.tabBooking.Location = new System.Drawing.Point(0, 0);
            this.tabBooking.Name = "tabBooking";
            this.tabBooking.SelectedIndex = 0;
            this.tabBooking.Size = new System.Drawing.Size(770, 450);
            this.tabBooking.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabBooking.TabIndex = 0;
            // 
            // tabCustomerDetails
            // 
            this.tabCustomerDetails.BackColor = System.Drawing.SystemColors.Control;
            this.tabCustomerDetails.Controls.Add(this.btnNext);
            this.tabCustomerDetails.Controls.Add(this.btnCancel);
            this.tabCustomerDetails.Controls.Add(this.numDays);
            this.tabCustomerDetails.Controls.Add(this.label5);
            this.tabCustomerDetails.Controls.Add(this.label3);
            this.tabCustomerDetails.Controls.Add(this.lblBookingRange);
            this.tabCustomerDetails.Controls.Add(this.lblBooking);
            this.tabCustomerDetails.Controls.Add(this.label2);
            this.tabCustomerDetails.Controls.Add(this.dtpStartDate);
            this.tabCustomerDetails.Controls.Add(this.rtbCustomerDetails);
            this.tabCustomerDetails.Controls.Add(this.lblCustomerNo);
            this.tabCustomerDetails.Controls.Add(this.lblCustomerNumber);
            this.tabCustomerDetails.Controls.Add(this.btnNew);
            this.tabCustomerDetails.Controls.Add(this.label1);
            this.tabCustomerDetails.Controls.Add(this.txtCustomer);
            this.tabCustomerDetails.Controls.Add(this.lstCustomer);
            this.tabCustomerDetails.Location = new System.Drawing.Point(4, 5);
            this.tabCustomerDetails.Name = "tabCustomerDetails";
            this.tabCustomerDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tabCustomerDetails.Size = new System.Drawing.Size(762, 441);
            this.tabCustomerDetails.TabIndex = 0;
            this.tabCustomerDetails.Text = "tabPage1";
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Image = global::InTheDogHouse.Properties.Resources.pepsiIcon;
            this.btnNext.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNext.Location = new System.Drawing.Point(581, 368);
            this.btnNext.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(161, 55);
            this.btnNext.TabIndex = 48;
            this.btnNext.Text = "Next";
            this.btnNext.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNext.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Image = global::InTheDogHouse.Properties.Resources.pepsiIcon2;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.Location = new System.Drawing.Point(328, 368);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(159, 55);
            this.btnCancel.TabIndex = 47;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // numDays
            // 
            this.numDays.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numDays.Location = new System.Drawing.Point(515, 302);
            this.numDays.Maximum = new decimal(new int[] {
            28,
            0,
            0,
            0});
            this.numDays.Name = "numDays";
            this.numDays.Size = new System.Drawing.Size(227, 26);
            this.numDays.TabIndex = 33;
            this.numDays.ValueChanged += new System.EventHandler(this.numDays_ValueChanged);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(515, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(227, 27);
            this.label5.TabIndex = 32;
            this.label5.Text = "No of Days";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(521, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(227, 27);
            this.label3.TabIndex = 31;
            this.label3.Text = "Start Date";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBookingRange
            // 
            this.lblBookingRange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBookingRange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookingRange.Location = new System.Drawing.Point(375, 11);
            this.lblBookingRange.Name = "lblBookingRange";
            this.lblBookingRange.Size = new System.Drawing.Size(112, 24);
            this.lblBookingRange.TabIndex = 30;
            this.lblBookingRange.Text = "-";
            this.lblBookingRange.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBooking
            // 
            this.lblBooking.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBooking.Location = new System.Drawing.Point(257, 9);
            this.lblBooking.Name = "lblBooking";
            this.lblBooking.Size = new System.Drawing.Size(119, 27);
            this.lblBooking.TabIndex = 29;
            this.lblBooking.Text = "Booking Date";
            this.lblBooking.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(257, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 27);
            this.label2.TabIndex = 28;
            this.label2.Text = "Customer Details";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpStartDate.BackColor = System.Drawing.SystemColors.Control;
            this.dtpStartDate.Location = new System.Drawing.Point(515, 55);
            this.dtpStartDate.MaxSelectionCount = 28;
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.ShowToday = false;
            this.dtpStartDate.ShowTodayCircle = false;
            this.dtpStartDate.TabIndex = 27;
            this.dtpStartDate.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.dtpStartDate_DateSelected);
            // 
            // rtbCustomerDetails
            // 
            this.rtbCustomerDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbCustomerDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbCustomerDetails.Location = new System.Drawing.Point(257, 143);
            this.rtbCustomerDetails.Name = "rtbCustomerDetails";
            this.rtbCustomerDetails.ReadOnly = true;
            this.rtbCustomerDetails.Size = new System.Drawing.Size(235, 185);
            this.rtbCustomerDetails.TabIndex = 26;
            this.rtbCustomerDetails.Text = "";
            // 
            // lblCustomerNo
            // 
            this.lblCustomerNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCustomerNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerNo.Location = new System.Drawing.Point(253, 113);
            this.lblCustomerNo.Name = "lblCustomerNo";
            this.lblCustomerNo.Size = new System.Drawing.Size(119, 27);
            this.lblCustomerNo.TabIndex = 25;
            this.lblCustomerNo.Text = "Customer No";
            this.lblCustomerNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCustomerNumber
            // 
            this.lblCustomerNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCustomerNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerNumber.Location = new System.Drawing.Point(397, 116);
            this.lblCustomerNumber.Name = "lblCustomerNumber";
            this.lblCustomerNumber.Size = new System.Drawing.Size(95, 24);
            this.lblCustomerNumber.TabIndex = 24;
            this.lblCustomerNumber.Text = "10000";
            this.lblCustomerNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnNew
            // 
            this.btnNew.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(7, 390);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(217, 33);
            this.btnNew.TabIndex = 23;
            this.btnNew.Text = "New Customer";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 27);
            this.label1.TabIndex = 22;
            this.label1.Text = "Customer";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCustomer
            // 
            this.txtCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomer.Location = new System.Drawing.Point(7, 38);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Size = new System.Drawing.Size(225, 26);
            this.txtCustomer.TabIndex = 21;
            this.txtCustomer.TextChanged += new System.EventHandler(this.txtCustomer_TextChanged);
            // 
            // lstCustomer
            // 
            this.lstCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCustomer.FormattingEnabled = true;
            this.lstCustomer.ItemHeight = 20;
            this.lstCustomer.Location = new System.Drawing.Point(8, 70);
            this.lstCustomer.Name = "lstCustomer";
            this.lstCustomer.Size = new System.Drawing.Size(225, 304);
            this.lstCustomer.TabIndex = 20;
            this.lstCustomer.SelectedIndexChanged += new System.EventHandler(this.lstCustomer_SelectedIndexChanged);
            // 
            // tabBookingDetails
            // 
            this.tabBookingDetails.BackColor = System.Drawing.SystemColors.Control;
            this.tabBookingDetails.Controls.Add(this.btnNewDog);
            this.tabBookingDetails.Controls.Add(this.label4);
            this.tabBookingDetails.Controls.Add(this.lstKennel);
            this.tabBookingDetails.Controls.Add(this.label6);
            this.tabBookingDetails.Controls.Add(this.lstDog);
            this.tabBookingDetails.Controls.Add(this.btnDelete);
            this.tabBookingDetails.Controls.Add(this.btnAdd);
            this.tabBookingDetails.Controls.Add(this.lvBooking);
            this.tabBookingDetails.Controls.Add(this.btnSave);
            this.tabBookingDetails.Controls.Add(this.btnGoBack);
            this.tabBookingDetails.Location = new System.Drawing.Point(4, 5);
            this.tabBookingDetails.Name = "tabBookingDetails";
            this.tabBookingDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tabBookingDetails.Size = new System.Drawing.Size(762, 441);
            this.tabBookingDetails.TabIndex = 1;
            this.tabBookingDetails.Text = "tabPage2";
            // 
            // btnNewDog
            // 
            this.btnNewDog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewDog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewDog.Location = new System.Drawing.Point(25, 210);
            this.btnNewDog.Name = "btnNewDog";
            this.btnNewDog.Size = new System.Drawing.Size(246, 42);
            this.btnNewDog.TabIndex = 54;
            this.btnNewDog.Text = "New Dog";
            this.btnNewDog.UseVisualStyleBackColor = true;
            this.btnNewDog.Click += new System.EventHandler(this.btnNewDog_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(302, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(253, 27);
            this.label4.TabIndex = 50;
            this.label4.Text = "Kennel";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstKennel
            // 
            this.lstKennel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lstKennel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstKennel.FormattingEnabled = true;
            this.lstKennel.ItemHeight = 20;
            this.lstKennel.Location = new System.Drawing.Point(302, 48);
            this.lstKennel.Name = "lstKennel";
            this.lstKennel.Size = new System.Drawing.Size(253, 204);
            this.lstKennel.TabIndex = 49;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(246, 27);
            this.label6.TabIndex = 48;
            this.label6.Text = "Dog";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstDog
            // 
            this.lstDog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lstDog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstDog.FormattingEnabled = true;
            this.lstDog.ItemHeight = 20;
            this.lstDog.Location = new System.Drawing.Point(25, 48);
            this.lstDog.Name = "lstDog";
            this.lstDog.Size = new System.Drawing.Size(246, 144);
            this.lstDog.TabIndex = 47;
            this.lstDog.Click += new System.EventHandler(this.lstDog_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(480, 371);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 34);
            this.btnDelete.TabIndex = 53;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(480, 270);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 34);
            this.btnAdd.TabIndex = 52;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lvBooking
            // 
            this.lvBooking.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvBooking.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmDogNo,
            this.clmDogName,
            this.clmKennel});
            this.lvBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvBooking.FullRowSelect = true;
            this.lvBooking.HideSelection = false;
            this.lvBooking.Location = new System.Drawing.Point(12, 270);
            this.lvBooking.MultiSelect = false;
            this.lvBooking.Name = "lvBooking";
            this.lvBooking.Size = new System.Drawing.Size(462, 152);
            this.lvBooking.TabIndex = 51;
            this.lvBooking.UseCompatibleStateImageBehavior = false;
            this.lvBooking.View = System.Windows.Forms.View.Details;
            // 
            // clmDogNo
            // 
            this.clmDogNo.Text = "Dog No";
            this.clmDogNo.Width = 110;
            // 
            // clmDogName
            // 
            this.clmDogName.Text = "Name";
            this.clmDogName.Width = 102;
            // 
            // clmKennel
            // 
            this.clmKennel.Text = "Kennel";
            this.clmKennel.Width = 91;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = global::InTheDogHouse.Properties.Resources.pepsiIcon;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.Location = new System.Drawing.Point(584, 350);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(161, 55);
            this.btnSave.TabIndex = 56;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnGoBack
            // 
            this.btnGoBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGoBack.FlatAppearance.BorderSize = 0;
            this.btnGoBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoBack.Image = global::InTheDogHouse.Properties.Resources.pepsiIcon2;
            this.btnGoBack.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGoBack.Location = new System.Drawing.Point(586, 258);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(159, 55);
            this.btnGoBack.TabIndex = 55;
            this.btnGoBack.Text = "Go Back";
            this.btnGoBack.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGoBack.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnGoBack.UseVisualStyleBackColor = true;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // frmBooking2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 450);
            this.Controls.Add(this.tabBooking);
            this.Name = "frmBooking2";
            this.Text = "Booking";
            this.Load += new System.EventHandler(this.frmBooking2_Load);
            this.tabBooking.ResumeLayout(false);
            this.tabCustomerDetails.ResumeLayout(false);
            this.tabCustomerDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDays)).EndInit();
            this.tabBookingDetails.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabBooking;
        private System.Windows.Forms.TabPage tabCustomerDetails;
        private System.Windows.Forms.TabPage tabBookingDetails;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCustomer;
        private System.Windows.Forms.ListBox lstCustomer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MonthCalendar dtpStartDate;
        private System.Windows.Forms.RichTextBox rtbCustomerDetails;
        private System.Windows.Forms.Label lblCustomerNo;
        private System.Windows.Forms.Label lblCustomerNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblBookingRange;
        private System.Windows.Forms.Label lblBooking;
        private System.Windows.Forms.NumericUpDown numDays;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnNewDog;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListView lvBooking;
        private System.Windows.Forms.ColumnHeader clmDogNo;
        private System.Windows.Forms.ColumnHeader clmDogName;
        private System.Windows.Forms.ColumnHeader clmKennel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnGoBack;
        private System.Windows.Forms.ListBox lstKennel;
        private System.Windows.Forms.ListBox lstDog;
    }
}