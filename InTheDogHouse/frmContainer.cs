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
        Form openForm;
        public string connStr = @"Data Source = .\SQLExpress; Initial Catalog = InTheDogHouse; Integrated Security = true";
        List<Form> openForms;
        bool fullScreen = false;
        public frmContainer()
        {
            InitializeComponent();
            openForms = new List<Form>();
        }

        private void frmContainer_Load(object sender, EventArgs e)
        {
            frmMenu menu =  new frmMenu(this);
            openForm = menu;
            openForms.Add(menu);
            menu.TopLevel = false;
            menu.ShowInTaskbar = false;
            menu.Show();
            menu.Dock = DockStyle.Fill;
            pSubForm.Controls.Add(menu);
            
        }
        public void changeForm(Form form)
        {
            hideOpen();

            form.FormBorderStyle = FormBorderStyle.None;
            form.TopLevel = false;
            form.ShowInTaskbar = false;
            form.Show();
            form.Dock = DockStyle.Fill;
            form.FormClosing += Form_FormClosing; ;
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

            }
            else
            {
                fullScreen = true;
                FormBorderStyle = FormBorderStyle.FixedToolWindow;
                ControlBox = false;
                TopMost = true;
                Text = "";
                Left = 0;
                Top = 0;
                Height = Screen.PrimaryScreen.Bounds.Height - 1;
                Width = Screen.PrimaryScreen.Bounds.Width;
            }
        }
    }
}
