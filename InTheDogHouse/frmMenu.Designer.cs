
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCustomer
            // 
            this.btnCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomer.Location = new System.Drawing.Point(3, 3);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(260, 219);
            this.btnCustomer.TabIndex = 0;
            this.btnCustomer.Text = "Customer";
            this.btnCustomer.UseVisualStyleBackColor = true;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnKennel
            // 
            this.btnKennel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnKennel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKennel.Location = new System.Drawing.Point(269, 3);
            this.btnKennel.Name = "btnKennel";
            this.btnKennel.Size = new System.Drawing.Size(260, 219);
            this.btnKennel.TabIndex = 1;
            this.btnKennel.Text = "Kennel";
            this.btnKennel.UseVisualStyleBackColor = true;
            this.btnKennel.Click += new System.EventHandler(this.btnKennel_Click);
            // 
            // btnSize
            // 
            this.btnSize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSize.Location = new System.Drawing.Point(3, 228);
            this.btnSize.Name = "btnSize";
            this.btnSize.Size = new System.Drawing.Size(260, 219);
            this.btnSize.TabIndex = 2;
            this.btnSize.Text = "Size";
            this.btnSize.UseVisualStyleBackColor = true;
            this.btnSize.Click += new System.EventHandler(this.btnSize_Click);
            // 
            // btnBreed
            // 
            this.btnBreed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBreed.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBreed.Location = new System.Drawing.Point(269, 228);
            this.btnBreed.Name = "btnBreed";
            this.btnBreed.Size = new System.Drawing.Size(260, 219);
            this.btnBreed.TabIndex = 3;
            this.btnBreed.Text = "Breed";
            this.btnBreed.UseVisualStyleBackColor = true;
            this.btnBreed.Click += new System.EventHandler(this.btnBreed_Click);
            // 
            // btnDog
            // 
            this.btnDog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDog.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDog.Location = new System.Drawing.Point(535, 3);
            this.btnDog.Name = "btnDog";
            this.btnDog.Size = new System.Drawing.Size(262, 219);
            this.btnDog.TabIndex = 4;
            this.btnDog.Text = "Dog";
            this.btnDog.UseVisualStyleBackColor = true;
            this.btnDog.Click += new System.EventHandler(this.btnDog_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.btnCustomer, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnBreed, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnDog, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSize, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnKennel, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMenu";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "frmMenu";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Button btnKennel;
        private System.Windows.Forms.Button btnSize;
        private System.Windows.Forms.Button btnBreed;
        private System.Windows.Forms.Button btnDog;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}