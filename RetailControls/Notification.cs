using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RetailControls
{
    public partial class Notification : Form
    {
        public Notification(int interval)
        {

            InitializeComponent();
            timer1.Interval = interval;
        }

        private void Notification_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Notification_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(249, 249, 249);
        }

        private void Notification_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Notification_Paint(object sender, PaintEventArgs e)
        {
            var rect = new Rectangle(1, 1, this.Width - 1, this.Height - 1);
            Pen pen = new Pen(Color.FromArgb(0,60,170), 2);
            pen.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset; //<-- this
            e.Graphics.DrawRectangle(pen, rect);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
