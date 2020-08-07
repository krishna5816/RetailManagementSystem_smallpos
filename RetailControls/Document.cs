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
    public partial class Document : UserControl
    {
        public Document()
        {
            InitializeComponent();
        }

        public int id { get; set; }
        public string name
        {
            get
            {
                return NameLabel.Text;
            }
            set
            {
                NameLabel.Text = value;
            }
        }
        private void Delete_btn_MouseEnter(object sender, EventArgs e)
        {
            Delete_btn.BackgroundImage = controlresource.deletehover;
            
        }

        private void Delete_btn_MouseLeave(object sender, EventArgs e)
        {
            Delete_btn.BackgroundImage = controlresource.delete ;

        }

        private void Delete_btn_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        private void NameLabel_TextChanged(object sender, EventArgs e)
        {
            var len = NameLabel.Text.Length;
            var rows = len / 20;
            var extra = len / 20;
            if (extra > 0)
            {
                rows++;
            }
            NameLabel.Height = 15 * rows;
            this.Height = NameLabel.Height + 5;
        }
    }
}
