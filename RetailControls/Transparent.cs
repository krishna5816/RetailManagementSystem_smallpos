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
    public partial class Transparent : Form
    {
        public Form form;
        public Transparent(Form obj)
        {
            InitializeComponent();
            this.form = obj;
        }

        private void Transparent_Load(object sender, EventArgs e)
        {
            pictureBox1.Left = (this.Width / 2) - 25;
            pictureBox1.Top = (this.Height / 2) - 125;
            form.Shown += Form_Shown;
            form.FormClosed += Form_FormClosed;
            form.ShowDialog();
        }

        private void Form_Shown(object sender, EventArgs e)
        {
            pictureBox1.Hide();
        }

        private void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
