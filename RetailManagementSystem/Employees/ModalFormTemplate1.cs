using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4.Item
{
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
        }

        private void Add_Load(object sender, EventArgs e)
        {
            this.Top = 50;
            this.Left = Convert.ToInt32(Screen.PrimaryScreen.Bounds.Width * 0.20);
            this.Height = Screen.PrimaryScreen.Bounds.Height - 100;
            this.Width = Convert.ToInt32(Screen.PrimaryScreen.Bounds.Width * 0.6);
            //for (int i = 0; i < 100; i++)
            //{
            //    var p = new Panel();
            //    p.Location = new Point(100, i * 100 +50);
            //    p.Width = 100;
            //    p.Height = 100;
            //    p.Name = "Panel_" + i.ToString();
            //    p.BorderStyle = BorderStyle.FixedSingle;
            //    panel1.Controls.Add(p);
            //    p.Show();
            //}
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Pen pp = new Pen(new SolidBrush(Color.Teal), 1);
            pp.Alignment = System.Drawing.Drawing2D.PenAlignment.Center;
            Panel p = (Panel)sender;
            var rect = new Rectangle(1, 1, p.Width - 2, p.Height - 2);
            e.Graphics.DrawRectangle(pp, rect);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            Label l = (Label)sender;
            l.BackColor = Color.FromArgb(0, 150, 150);
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            Label l = (Label)sender;
            l.BackColor = Color.FromArgb(0, 128, 128);
        }
    }
}
