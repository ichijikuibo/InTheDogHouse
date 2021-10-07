using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InTheDogHouse
{
    public partial class frmContainer : Form
    {
        Timer menuTimer;
        Form openForm;
        bool menuOpen = false;
        public string connStr = @"Data Source = .; Initial Catalog = InTheDogHouse; Integrated Security = true";
        List<Form> openForms;
        bool fullScreen = false;
        public frmContainer()
        {

            InitializeComponent();
            menuTimer = new Timer();
            menuTimer.Interval = 1000 / 30;
            menuTimer.Enabled = false;
            menuTimer.Tick += MenuTimer_Tick;
            openForms = new List<Form>();
        }


        private void frmContainer_Load(object sender, EventArgs e)
        {
            frmMenu menu =  new frmMenu(this);
            changeForm(menu);
            splitPanel.SplitterDistance = 0;


        }
        public void changeForm(Form form)
        {
            hideOpen();

            form.FormBorderStyle = FormBorderStyle.None;
            form.TopLevel = false;
            form.ShowInTaskbar = false;
            form.Show();
            form.Dock = DockStyle.Fill;
            form.FormClosing += Form_FormClosing; 
            openForms.Add(form);
            openForm = form;
            pSubForm.Controls.Add(form);
        }

        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            openForms.Remove(sender as Form);
            openForms[openForms.Count - 1].Show();

        }



        public void hideOpen()
        {
            foreach(Form f in openForms)
            {
                f.Hide();
            }
        }

        private void btnFullScreen_Click(object sender, EventArgs e)
        {
            if(fullScreen)
            {
                fullScreen = false;
                FormBorderStyle = FormBorderStyle.Sizable;
                Height = 720;
                Width = 812;
                ControlBox = true;
                Text = "In The Dog House";
                TopMost = false;
                Left = Screen.PrimaryScreen.Bounds.Width / 2 - Width / 2;
                Top = Screen.PrimaryScreen.Bounds.Height/2-Height/2;
                ShowIcon = true;
                if (menuOpen) splitPanel.SplitterDistance = 150;

            }
            else
            {
                fullScreen = true;
                ShowIcon = false;
                FormBorderStyle = FormBorderStyle.FixedSingle;
                ControlBox = false;
                //TopMost = true;
                Text = "";
                Left = 0;
                Top = 0;
                Height = Screen.PrimaryScreen.Bounds.Height - 1;
                Width = Screen.PrimaryScreen.Bounds.Width;
                if (menuOpen) splitPanel.SplitterDistance = 150;
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (!menuTimer.Enabled)
            {
                menuTimer.Start();
            }
        }

        private void MenuTimer_Tick(object sender, EventArgs e)
        {
            if (menuOpen)
            {
                if (splitPanel.SplitterDistance == 0)
                {
                    menuTimer.Stop();
                    menuOpen = false;
                }
                else
                {
                    if (splitPanel.SplitterDistance < 15) splitPanel.SplitterDistance = 0;
                    else splitPanel.SplitterDistance -= 15;
                }
            }
            else
            {
                if (splitPanel.SplitterDistance == 150)
                {
                    menuTimer.Stop();
                    menuOpen = true;
                }
                else
                {
                    splitPanel.SplitterDistance += 15;
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            changeForm(new frmCustomer(this));
        }

        private void btnDogs_Click(object sender, EventArgs e)
        {
            changeForm(new frmDog(this));
        }

        private void btnSizes_Click(object sender, EventArgs e)
        {
            changeForm(new frmSize(this));
        }

        private void btnBreeds_Click(object sender, EventArgs e)
        {
            changeForm(new frmBreed(this));
        }

        private void btnKennels_Click(object sender, EventArgs e)
        {
            changeForm(new frmKennel(this));
        }
    }
}
