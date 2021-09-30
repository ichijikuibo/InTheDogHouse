
namespace InTheDogHouse
{
    partial class frmContainer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmContainer));
            this.pSubForm = new System.Windows.Forms.Panel();
            this.btnFullScreen = new System.Windows.Forms.Button();
            this.splitPanel = new System.Windows.Forms.SplitContainer();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.ssDogs = new InTheDogHouse.SlideShow();
            this.flowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnKennels = new System.Windows.Forms.Button();
            this.btnBreeds = new System.Windows.Forms.Button();
            this.btnSizes = new System.Windows.Forms.Button();
            this.btnDogs = new System.Windows.Forms.Button();
            this.btnCustomer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel)).BeginInit();
            this.splitPanel.Panel1.SuspendLayout();
            this.splitPanel.Panel2.SuspendLayout();
            this.splitPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.flowLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // pSubForm
            // 
            this.pSubForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pSubForm.Location = new System.Drawing.Point(3, 174);
            this.pSubForm.Name = "pSubForm";
            this.pSubForm.Size = new System.Drawing.Size(699, 504);
            this.pSubForm.TabIndex = 52;
            // 
            // btnFullScreen
            // 
            this.btnFullScreen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFullScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFullScreen.Location = new System.Drawing.Point(8, 357);
            this.btnFullScreen.Name = "btnFullScreen";
            this.btnFullScreen.Size = new System.Drawing.Size(136, 47);
            this.btnFullScreen.TabIndex = 53;
            this.btnFullScreen.Text = "Full Screen";
            this.btnFullScreen.UseVisualStyleBackColor = true;
            this.btnFullScreen.Click += new System.EventHandler(this.btnFullScreen_Click);
            // 
            // splitPanel
            // 
            this.splitPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitPanel.IsSplitterFixed = true;
            this.splitPanel.Location = new System.Drawing.Point(0, 0);
            this.splitPanel.Name = "splitPanel";
            // 
            // splitPanel.Panel1
            // 
            this.splitPanel.Panel1.Controls.Add(this.flowLayout);
            this.splitPanel.Panel1MinSize = 0;
            // 
            // splitPanel.Panel2
            // 
            this.splitPanel.Panel2.Controls.Add(this.btnMenu);
            this.splitPanel.Panel2.Controls.Add(this.ssDogs);
            this.splitPanel.Panel2.Controls.Add(this.pSubForm);
            this.splitPanel.Panel2.Controls.Add(this.pictureBox4);
            this.splitPanel.Panel2MinSize = 0;
            this.splitPanel.Size = new System.Drawing.Size(859, 681);
            this.splitPanel.SplitterDistance = 150;
            this.splitPanel.TabIndex = 54;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(8, 410);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(136, 50);
            this.btnExit.TabIndex = 54;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.White;
            this.btnMenu.BackgroundImage = global::InTheDogHouse.Properties.Resources.menu;
            this.btnMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Location = new System.Drawing.Point(3, 3);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(47, 44);
            this.btnMenu.TabIndex = 53;
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.ImageLocation = "";
            this.pictureBox4.Location = new System.Drawing.Point(3, 53);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(505, 115);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 50;
            this.pictureBox4.TabStop = false;
            // 
            // ssDogs
            // 
            this.ssDogs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ssDogs.BackColor = System.Drawing.SystemColors.Control;
            this.ssDogs.BorderColour = System.Drawing.Color.SaddleBrown;
            this.ssDogs.BorderSize = 5;
            this.ssDogs.ChangeRate = 5000;
            this.ssDogs.Location = new System.Drawing.Point(514, 3);
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
            this.ssDogs.Size = new System.Drawing.Size(188, 165);
            this.ssDogs.TabIndex = 51;
            // 
            // flowLayout
            // 
            this.flowLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayout.Controls.Add(this.btnCustomer);
            this.flowLayout.Controls.Add(this.btnDogs);
            this.flowLayout.Controls.Add(this.btnSizes);
            this.flowLayout.Controls.Add(this.btnBreeds);
            this.flowLayout.Controls.Add(this.btnKennels);
            this.flowLayout.Controls.Add(this.panel1);
            this.flowLayout.Controls.Add(this.btnFullScreen);
            this.flowLayout.Controls.Add(this.btnExit);
            this.flowLayout.Location = new System.Drawing.Point(3, 0);
            this.flowLayout.Name = "flowLayout";
            this.flowLayout.Padding = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.flowLayout.Size = new System.Drawing.Size(144, 681);
            this.flowLayout.TabIndex = 55;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Location = new System.Drawing.Point(8, 278);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(159, 73);
            this.panel1.TabIndex = 55;
            // 
            // btnKennels
            // 
            this.btnKennels.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKennels.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKennels.Location = new System.Drawing.Point(8, 225);
            this.btnKennels.Name = "btnKennels";
            this.btnKennels.Size = new System.Drawing.Size(136, 47);
            this.btnKennels.TabIndex = 56;
            this.btnKennels.Text = "Kennels";
            this.btnKennels.UseVisualStyleBackColor = true;
            this.btnKennels.Click += new System.EventHandler(this.btnKennels_Click);
            // 
            // btnBreeds
            // 
            this.btnBreeds.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBreeds.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBreeds.Location = new System.Drawing.Point(8, 172);
            this.btnBreeds.Name = "btnBreeds";
            this.btnBreeds.Size = new System.Drawing.Size(136, 47);
            this.btnBreeds.TabIndex = 57;
            this.btnBreeds.Text = "Breeds";
            this.btnBreeds.UseVisualStyleBackColor = true;
            this.btnBreeds.Click += new System.EventHandler(this.btnBreeds_Click);
            // 
            // btnSizes
            // 
            this.btnSizes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSizes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSizes.Location = new System.Drawing.Point(8, 119);
            this.btnSizes.Name = "btnSizes";
            this.btnSizes.Size = new System.Drawing.Size(136, 47);
            this.btnSizes.TabIndex = 58;
            this.btnSizes.Text = "Sizes";
            this.btnSizes.UseVisualStyleBackColor = true;
            this.btnSizes.Click += new System.EventHandler(this.btnSizes_Click);
            // 
            // btnDogs
            // 
            this.btnDogs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDogs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDogs.Location = new System.Drawing.Point(8, 66);
            this.btnDogs.Name = "btnDogs";
            this.btnDogs.Size = new System.Drawing.Size(136, 47);
            this.btnDogs.TabIndex = 59;
            this.btnDogs.Text = "Dogs";
            this.btnDogs.UseVisualStyleBackColor = true;
            this.btnDogs.Click += new System.EventHandler(this.btnDogs_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomer.Location = new System.Drawing.Point(8, 13);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(136, 47);
            this.btnCustomer.TabIndex = 60;
            this.btnCustomer.Text = "Customers";
            this.btnCustomer.UseVisualStyleBackColor = true;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // frmContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 681);
            this.Controls.Add(this.splitPanel);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmContainer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "In the Dog House";
            this.Load += new System.EventHandler(this.frmContainer_Load);
            this.splitPanel.Panel1.ResumeLayout(false);
            this.splitPanel.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel)).EndInit();
            this.splitPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.flowLayout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private SlideShow ssDogs;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel pSubForm;
        private System.Windows.Forms.Button btnFullScreen;
        private System.Windows.Forms.SplitContainer splitPanel;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.FlowLayoutPanel flowLayout;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Button btnDogs;
        private System.Windows.Forms.Button btnSizes;
        private System.Windows.Forms.Button btnBreeds;
        private System.Windows.Forms.Button btnKennels;
        private System.Windows.Forms.Panel panel1;
    }
}