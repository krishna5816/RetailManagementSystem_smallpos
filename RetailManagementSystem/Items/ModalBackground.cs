using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RetailManagementSystem.ITEMS
{
    public partial class ModalBackground : Form
    {
        public ModalBackground()
        {
            InitializeComponent();
        }
        public dynamic data;
        public Form emp1;
        public Form obj;
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled=true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            this.obj.FormClosed += obj_FormClosed;
            this.obj.ShowDialog();
            this.data = this.obj.DataBindings;
        }

        void obj_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            this.Close();
        }

        
    }
}
