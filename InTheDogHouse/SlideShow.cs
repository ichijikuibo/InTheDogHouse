using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InTheDogHouse
{
    public partial class SlideShow : UserControl
    {
        private float currentPictureOpacity = 100;
        private float nextPictureOpacity = 0;
        private int currentPictureIndex;
        private Image currentPicture;
        private Image nextImage;
        private System.Timers.Timer transitionTimer;
        private System.Timers.Timer changeTimer;

        private string[] pictures;
        [
            Category("Slideshow"),
            Description("The pictures to be played in the slideshow")
        ]
        public string[] Pictures
        {
            get
            {
                return pictures;
            }
            set
            {
                pictures = value;
                Invalidate();
            }

        }
        private int changeRate = 2000;
        [
            Category("Slideshow"),
            Description("The time to display each picture in miliseconds")
        ]
        public int ChangeRate
        {
            get { return changeRate; }
            set
            {
                changeRate = value;
                Invalidate();
            }
        }
        private int borderSize = 0;
        [
            Category("Slideshow"),
            Description("The size of the image border in pixels")
        ]
        public int BorderSize
        {
            get { return borderSize; }
            set
            {
                borderSize = value;
                Invalidate();
            }
        }
        private Color borderColour = Color.Black;
        [
            Category("Slideshow"),
            Description("The colour of the picture border")
        ]

        public Color BorderColour
        {
            get { return borderColour; }
            set
            {
                borderColour = value;
                Invalidate();
            }
        }
        public SlideShow()
        {
            InitializeComponent();



        }
        private Stream downloadImage(string address)
        {
            using (WebClient client = new WebClient())
            {
                try
                {
                    Stream stream = client.OpenRead(address);
                    return stream;
                }
                catch
                {
                    return null;
                }
            }


        }
        private void ChangeTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {

            if (currentPictureIndex == pictures.Length - 1) currentPictureIndex = 0;
            else currentPictureIndex++;

            try
            {
                if (pictures[currentPictureIndex].ToLower().StartsWith("http"))
                {
                    nextImage = Image.FromStream(downloadImage(pictures[currentPictureIndex]));
                }
                else {
                    nextImage = Image.FromFile(pictures[currentPictureIndex]);
                }
                transitionTimer.Start();
            }
            catch
            {
                return;
            }
        }
        private void moveToNextImage()
        {

        }

        private void TransitionTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (nextPictureOpacity >= 100)
            {
                nextPictureOpacity = 0;
                currentPictureOpacity = 100;
                currentPicture = nextImage;
                nextImage = null;
                transitionTimer.Stop();
            }
            else
            {
                nextPictureOpacity += 2.5f;
                currentPictureOpacity -= 2.5f;
            }
            Invalidate();
        }

        private void SlideShow_Paint(object sender, PaintEventArgs e)
        {
            if (pictures == null || currentPicture == null)
            {
                Pen borderPen = new Pen(borderColour);
                borderPen.Width = borderSize;
                Point[] points = new Point[]
                {
                    new Point(0,0),
                    new Point(Width-1, 0),
                    new Point(Width-1, Height-1),
                    new Point(0, Height-1),
                    new Point(0, 0)
                };
                e.Graphics.DrawLines(borderPen, points);
                return;
            }
            e.Graphics.Clear(BackColor);
            if (currentPictureOpacity > 0)
            {
                float scale = calcScale(currentPicture);
                int x = (int)(Width / 2 - (currentPicture.Width * scale) / 2);
                int y = (int)(Height / 2 - (currentPicture.Height * scale) / 2);
                ColorMatrix colormatrix = new ColorMatrix();
                colormatrix.Matrix33 = currentPictureOpacity / 100;
                ImageAttributes imgAttribute = new ImageAttributes();

                imgAttribute.SetColorMatrix(colormatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
                Rectangle destination = new Rectangle(x + borderSize, y + borderSize, (int)(currentPicture.Width * scale) - borderSize, (int)(currentPicture.Height * scale) - borderSize);
                e.Graphics.DrawImage(currentPicture, destination, 0, 0, currentPicture.Width, currentPicture.Height, GraphicsUnit.Pixel, imgAttribute);
                if (borderSize > 0)
                {
                    Pen borderPen = new Pen(Color.FromArgb((int)(255f * (currentPictureOpacity / 100f)), borderColour));
                    borderPen.Width = borderSize;
                    int halfBorder = (int)Math.Ceiling((double)borderSize / 2.00);
                    bool odd = borderSize % 2 == 1;
                    Point[] points = new Point[]
                    {
                    new Point(destination.X-borderSize,destination.Y-halfBorder),
                    new Point(destination.Width+destination.X+halfBorder-halfBorder-(odd?1:0), destination.Y-halfBorder),
                    new Point(destination.Width+destination.X+halfBorder-halfBorder-(odd?1:0), destination.Height+destination.Y-halfBorder),
                    new Point(destination.X-halfBorder, destination.Height+destination.Y-halfBorder),
                    new Point(destination.X-halfBorder,destination.Y)
                    };
                    e.Graphics.DrawLines(borderPen, points);
                }

            }

            if (nextPictureOpacity > 0)
            {
                float scale = calcScale(nextImage);
                int x = (int)(Width / 2 - (nextImage.Width * scale) / 2);
                int y = (int)(Height / 2 - (nextImage.Height * scale) / 2);
                ColorMatrix colormatrix = new ColorMatrix();
                colormatrix.Matrix33 = nextPictureOpacity / 100;
                ImageAttributes imgAttribute = new ImageAttributes();
                imgAttribute.SetColorMatrix(colormatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
                Rectangle destination = new Rectangle(x + borderSize, y + borderSize, (int)(nextImage.Width * scale) - borderSize, (int)(nextImage.Height * scale) - borderSize);
                e.Graphics.DrawImage(nextImage, destination, 0, 0, nextImage.Width, nextImage.Height, GraphicsUnit.Pixel, imgAttribute);
                if (borderSize > 0)
                {
                    Pen borderPen = new Pen(Color.FromArgb((int)(255f * (nextPictureOpacity / 100f)), borderColour));

                    borderPen.Width = borderSize;
                    int halfBorder = (int)Math.Ceiling((double)borderSize / 2.00);
                    bool odd = borderSize % 2 == 1;
                    Point[] points = new Point[]
                    {
                    new Point(destination.X-borderSize,destination.Y-halfBorder),
                    new Point(destination.Width+destination.X+halfBorder-halfBorder-(odd?1:0), destination.Y-halfBorder),
                    new Point(destination.Width+destination.X+halfBorder-halfBorder-(odd?1:0), destination.Height+destination.Y-halfBorder),
                    new Point(destination.X-halfBorder, destination.Height+destination.Y-halfBorder),
                    new Point(destination.X-halfBorder,destination.Y)
                    };
                    e.Graphics.DrawLines(borderPen, points);
                }

            }
        }
        private float calcScale(Image image)
        {
            float scale = (float)Width / image.Width;
            if (image.Height*scale > Height) scale = (float)Height / image.Height;

            return scale;
        }

        private void SlideShow_Load(object sender, EventArgs e)
        {
            try
            {
                if (pictures.Length > 0) currentPicture = Bitmap.FromFile(pictures[0]);

            }
            catch
            {
                return;
            }
            changeTimer = new System.Timers.Timer(changeRate);
            transitionTimer = new System.Timers.Timer(1000 / 60);
            changeTimer.Elapsed += ChangeTimer_Elapsed;
            changeTimer.AutoReset = true;
            transitionTimer.AutoReset = true;
            transitionTimer.Elapsed += TransitionTimer_Elapsed;
            changeTimer.Start();

        }
    }
}
