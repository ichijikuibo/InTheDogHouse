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


    public partial class PictureRadioButton : UserControl
    {
        [
            Category("RadioButton"),
            Description("The text for the radio button")
        ]
        public string ButtonText
        {
            get
            {
                return lblRadioButton.Text;
            }
            set
            {
                lblRadioButton.Text = value;
                Invalidate();
            }
        }
        private Image picture;
        [
           Category("RadioButton"),
           Description("The picture for the radio button")
        ]
        public Image Picture
        {
            get
            {
                return picture;
            }
            set
            {
                picture = value;
                Invalidate();
            }
        }

        private bool selected;
        [
   Category("RadioButton"),
   Description("Is this radio button selected")
]
        public bool Selected
        {
            get { return selected; }
            set
            {
                selected = value;
                if (selected&& Parent!=null)
                {
                    foreach (Control c in Parent.Controls)
                    {
                        if (c is PictureRadioButton && c != this)
                        {
                            (c as PictureRadioButton).Selected = false;
                        }
                    }
                }
                Invalidate();
            }
        }
        private Color selectedColour = Color.Black;
        [
            Category("Slideshow"),
            Description("The colour of the picture border")
        ]

        public Color SelectedColour
        {
            get { return selectedColour; }
            set
            {
                selectedColour = value;
                Invalidate();
            }
        }

        public PictureRadioButton()
        {
            InitializeComponent();
        }

        private void PictureRadioButton_Resize(object sender, EventArgs e)
        {
            picturePanel.Width = picturePanel.Height;
            lblRadioButton.Location = new Point(10 + picturePanel.Width,lblRadioButton.Location.Y);
            lblRadioButton.Width = Width - picturePanel.Width - 12;
        }

        private void picturePanel_Paint(object sender, PaintEventArgs e)
        {
            if (picture != null)
            {
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                if (selected)
                {
                    e.Graphics.DrawImage(picture, new Rectangle(4, 4, picturePanel.Width - 8, picturePanel.Height - 8));
                }
                else
                {
                    e.Graphics.DrawImage(picture, new Rectangle(1, 1, picturePanel.Width-2, picturePanel.Height-2));
                }
            }
            if (selected)
            {
                e.Graphics.DrawEllipse(new Pen(SelectedColour, 4), new Rectangle(4, 4, picturePanel.Width - 8, picturePanel.Height - 8));
            }
        }

        private void lblRadioButton_Click(object sender, EventArgs e)
        {
            Selected = true;
        }

        private void PictureRadioButton_Paint(object sender, PaintEventArgs e)
        {
            picturePanel.Invalidate();
        }
    }
}
