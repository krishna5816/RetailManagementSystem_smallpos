using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RetailManagementSystem.CUSTOMERS
{
    public partial class Billviwer : UserControl
    {
        public Billviwer()
        {
            InitializeComponent();
        }

        private void BillViwer_Paint(object sender, PaintEventArgs e)
        {
            this.Width = this.Parent.Width - 22;
            var rect = new Rectangle(1, 1, this.Bounds.Width - 2, this.Bounds.Height - 2);
            Pen p = new Pen(new SolidBrush(Color.FromArgb(0, 70, 166)), 2);
            this.CreateGraphics().DrawRectangle(p, rect);            
        }

        private void BillViwer_Load(object sender, EventArgs e)
        {

        }
    }
}
