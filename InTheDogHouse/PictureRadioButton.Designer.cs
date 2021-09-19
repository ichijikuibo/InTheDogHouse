
namespace InTheDogHouse
{
    partial class PictureRadioButton
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblRadioButton = new System.Windows.Forms.Label();
            this.picturePanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lblRadioButton
            // 
            this.lblRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRadioButton.Location = new System.Drawing.Point(50, 3);
            this.lblRadioButton.Name = "lblRadioButton";
            this.lblRadioButton.Size = new System.Drawing.Size(88, 39);
            this.lblRadioButton.TabIndex = 1;
            this.lblRadioButton.Text = "text";
            this.lblRadioButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblRadioButton.Click += new System.EventHandler(this.lblRadioButton_Click);
            // 
            // picturePanel
            // 
            this.picturePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.picturePanel.Location = new System.Drawing.Point(3, 3);
            this.picturePanel.Name = "picturePanel";
            this.picturePanel.Size = new System.Drawing.Size(41, 39);
            this.picturePanel.TabIndex = 0;
            this.picturePanel.Click += new System.EventHandler(this.lblRadioButton_Click);
            this.picturePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.picturePanel_Paint);
            // 
            // PictureRadioButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.lblRadioButton);
            this.Controls.Add(this.picturePanel);
            this.Name = "PictureRadioButton";
            this.Size = new System.Drawing.Size(140, 46);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.PictureRadioButton_Paint);
            this.Resize += new System.EventHandler(this.PictureRadioButton_Resize);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblRadioButton;
        private System.Windows.Forms.Panel picturePanel;
    }
}
