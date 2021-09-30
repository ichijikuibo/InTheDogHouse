
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
            this.ssDogs = new InTheDogHouse.SlideShow();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pSubForm = new System.Windows.Forms.Panel();
            this.btnFullScreen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // ssDogs
            // 
            this.ssDogs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ssDogs.BackColor = System.Drawing.SystemColors.Control;
            this.ssDogs.BorderColour = System.Drawing.Color.SaddleBrown;
            this.ssDogs.BorderSize = 5;
            this.ssDogs.ChangeRate = 5000;
            this.ssDogs.Location = new System.Drawing.Point(551, 12);
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
            this.ssDogs.TabIndex = 51;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.ImageLocation = "";
            this.pictureBox4.Location = new System.Drawing.Point(12, 59);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(533, 118);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 50;
            this.pictureBox4.TabStop = false;
            // 
            // pSubForm
            // 
            this.pSubForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pSubForm.Location = new System.Drawing.Point(12, 183);
            this.pSubForm.Name = "pSubForm";
            this.pSubForm.Size = new System.Drawing.Size(776, 486);
            this.pSubForm.TabIndex = 52;
            // 
            // btnFullScreen
            // 
            this.btnFullScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFullScreen.Location = new System.Drawing.Point(12, 12);
            this.btnFullScreen.Name = "btnFullScreen";
            this.btnFullScreen.Size = new System.Drawing.Size(124, 41);
            this.btnFullScreen.TabIndex = 53;
            this.btnFullScreen.Text = "Full Screen";
            this.btnFullScreen.UseVisualStyleBackColor = true;
            this.btnFullScreen.Click += new System.EventHandler(this.btnFullScreen_Click);
            // 
            // frmContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 681);
            this.Controls.Add(this.btnFullScreen);
            this.Controls.Add(this.pSubForm);
            this.Controls.Add(this.ssDogs);
            this.Controls.Add(this.pictureBox4);
            this.Name = "frmContainer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "In the Dog House";
            this.Load += new System.EventHandler(this.frmContainer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SlideShow ssDogs;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel pSubForm;
        private System.Windows.Forms.Button btnFullScreen;
    }
}