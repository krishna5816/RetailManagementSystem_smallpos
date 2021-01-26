using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomControls
{
    public partial class Comformation : Form
    {
        public Comformation()
        {
            InitializeComponent();

            this.roundBorder();
            this.Left = 1;
            this.roundBorder();

        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
            this.Close();
        }

        public static DialogResult show(string title,string mgs)
        {
            var c = new Comformation();
            c.label_title.Text = title;
            c.label_message.Text = mgs;
            return c.ShowModal();
        }

        public static void show(string title, string mgs,int a=0)
        {
            var c = new Comformation();
            c.label_title.Text = title;
            c.label_message.Text = mgs;
            c.button_save.Hide();
            c.button_cancel.Text = "Close";
            c.ShowModal();
        }

        private void Comformation_Paint(object sender, PaintEventArgs e)
        {
          
        }
    }
}
