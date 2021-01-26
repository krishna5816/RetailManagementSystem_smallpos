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

    public enum CloseMode
    {
        close,
        hide
    }
    public partial class MaterialForm : Form
    {
        public delegate void Actions();
        public event Actions Save;
        public event Actions Edit;
        public event Actions Cancel;
        public CloseMode CloseMode { get; set; }


        public MaterialForm()
        {
            InitializeComponent();
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            if (CloseMode == CloseMode.close)
            {

                this.Close();
            }
            else
            {
                this.Hide();
            }
        }

        private void panel_Divider_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MaterialForm_Load(object sender, EventArgs e)
        {

        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                if (CloseMode == CloseMode.close)
                {

                    this.Close();
                }
                else
                {
                    this.Hide();
                }
            }
            else if (keyData == (Keys.Control | Keys.S))
            {
                Save?.Invoke();
            }
            else if (keyData == (Keys.Control | Keys.E))
            {
                Edit?.Invoke();
            }
            else if (keyData == (Keys.Control | Keys.X))
            {
                Cancel?.Invoke();
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
