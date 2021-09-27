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

        private bool changed = false;

        [
            Category("Radio Button"),
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
                changed = true;
                lblRadioButton.Text = value;
                picturePanel.Invalidate();
            }
        }
        private Image picture;
        [
           Category("Radio Button"),
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
                changed = true;
                picture = value;
                picturePanel.Invalidate();
            }
        }

        private bool selected;
        [
   Category("Radio Button"),
   Description("Is this radio button selected")
]
        public bool Selected
        {
            get { return selected; }
            set
            {
                selected = value;
                changed = true;
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
                picturePanel.Invalidate();
            }
        }
        private Color selectedColour = Color.Black;
        [
            Category("Radio Button"),
            Description("The colour of the picture border")
        ]

        public Color SelectedColour
        {
            get { return selectedColour; }
            set
            {
                changed = true;
                selectedColour = value;
                picturePanel.Invalidate();
            }
        }
        private Color tempBackground;
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
            //if (changed)
            //{
                if (picture != null)
                {
                    e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                    if (selected)
                    {
                        e.Graphics.DrawImage(picture, new Rectangle(4, 4, picturePanel.Width - 8, picturePanel.Height - 8));
                    }
                    else
                    {
                        e.Graphics.DrawImage(picture, new Rectangle(1, 1, picturePanel.Width - 2, picturePanel.Height - 2));
                    }
                }
                if (selected)
                {
                    e.Graphics.DrawEllipse(new Pen(SelectedColour, 4), new Rectangle(4, 4, picturePanel.Width - 8, picturePanel.Height - 8));
                }
                changed = false;
           // }
        }

        private void lblRadioButton_Click(object sender, EventArgs e)
        {
            Selected = true;
        }

        private void PictureRadioButton_Paint(object sender, PaintEventArgs e)
        {
           // picturePanel.Invalidate();
        }

        private void PictureRadioButton_MouseEnter(object sender, EventArgs e)
        {
            changed = true;
            tempBackground = BackColor;
            BackColor = Color.LightGray;
            lblRadioButton.BackColor = BackColor;
            picturePanel.BackColor = BackColor;
        }

        private void PictureRadioButton_MouseLeave(object sender, EventArgs e)
        {
            changed = true;
            BackColor = tempBackground;
            lblRadioButton.BackColor = BackColor;
            picturePanel.BackColor = BackColor;
        }
    }
}
