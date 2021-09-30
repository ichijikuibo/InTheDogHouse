
namespace InTheDogHouse
{
    partial class frmMenu
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
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnKennel = new System.Windows.Forms.Button();
            this.btnSize = new System.Windows.Forms.Button();
            this.btnBreed = new System.Windows.Forms.Button();
            this.btnDog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCustomer
            // 
            this.btnCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomer.Location = new System.Drawing.Point(83, 82);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(123, 50);
            this.btnCustomer.TabIndex = 0;
            this.btnCustomer.Text = "Customer";
            this.btnCustomer.UseVisualStyleBackColor = true;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnKennel
            // 
            this.btnKennel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKennel.Location = new System.Drawing.Point(348, 82);
            this.btnKennel.Name = "btnKennel";
            this.btnKennel.Size = new System.Drawing.Size(123, 50);
            this.btnKennel.TabIndex = 1;
            this.btnKennel.Text = "Kennel";
            this.btnKennel.UseVisualStyleBackColor = true;
            this.btnKennel.Click += new System.EventHandler(this.btnKennel_Click);
            // 
            // btnSize
            // 
            this.btnSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSize.Location = new System.Drawing.Point(95, 279);
            this.btnSize.Name = "btnSize";
            this.btnSize.Size = new System.Drawing.Size(123, 50);
            this.btnSize.TabIndex = 2;
            this.btnSize.Text = "Size";
            this.btnSize.UseVisualStyleBackColor = true;
            this.btnSize.Click += new System.EventHandler(this.btnSize_Click);
            // 
            // btnBreed
            // 
            this.btnBreed.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBreed.Location = new System.Drawing.Point(348, 279);
            this.btnBreed.Name = "btnBreed";
            this.btnBreed.Size = new System.Drawing.Size(123, 50);
            this.btnBreed.TabIndex = 3;
            this.btnBreed.Text = "Breed";
            this.btnBreed.UseVisualStyleBackColor = true;
            this.btnBreed.Click += new System.EventHandler(this.btnBreed_Click);
            // 
            // btnDog
            // 
            this.btnDog.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDog.Location = new System.Drawing.Point(590, 82);
            this.btnDog.Name = "btnDog";
            this.btnDog.Size = new System.Drawing.Size(123, 50);
            this.btnDog.TabIndex = 4;
            this.btnDog.Text = "Dog";
            this.btnDog.UseVisualStyleBackColor = true;
            this.btnDog.Click += new System.EventHandler(this.btnDog_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDog);
            this.Controls.Add(this.btnBreed);
            this.Controls.Add(this.btnSize);
            this.Controls.Add(this.btnKennel);
            this.Controls.Add(this.btnCustomer);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMenu";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "frmMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Button btnKennel;
        private System.Windows.Forms.Button btnSize;
        private System.Windows.Forms.Button btnBreed;
        private System.Windows.Forms.Button btnDog;
    }
}