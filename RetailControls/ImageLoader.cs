using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RetailControls
{
    public partial class ImageLoader : UserControl
    {
        public ImageLoader()
        {
            InitializeComponent();
        }

        public Image image
        {
            get
            {
                return pictureBox1.BackgroundImage;
            }
            set
            {
                pictureBox1.Image = value;
            }
        }

        private string templocation;
        public string ImageLoc
        {
            get
            {
                return templocation;
            }
            set
            {
                templocation = value;
                try
                {

                if (value != "" || value!=null)
                {
                pictureBox1.BackgroundImage = Image.FromFile(value);

                }
                }
                catch (Exception)
                {
                    
                    
                }
            }
        }

        public bool SaveImage(string destination)
        {
            try
            {
            pictureBox1.BackgroundImage.Save(destination, System.Drawing.Imaging.ImageFormat.Png);
            return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;

            }

        }

        private void ImageLoader_Paint(object sender, PaintEventArgs e)
        {
            var rect = new Rectangle(1, 1, this.Bounds.Width - 2, this.Bounds.Height - 2);
            Pen p = new Pen(new SolidBrush(Color.FromArgb(171, 173, 179)), 1);
            e.Graphics.DrawRectangle(p, rect);
        }

        protected override void OnResize(EventArgs e)
        {

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            if (FileBrowser.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.BackgroundImage = Image.FromFile(FileBrowser.FileName);
                templocation = FileBrowser.FileName;
            }
        }
    }
}
