using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CustomControls
{
    public enum HideMode
    {
        up,
        below
    }
    public partial class MaterialTextbox : UserControl
    {

        private Color _bgcolor = Color.White;
        public Color BGColor
        {
            get
            {
                return _bgcolor;
            }
            set
            {
                _bgcolor = value;
                label_search.BackColor = value; betterTextBox_search.BackColor = value;
            }
        }

        private Color _labelcolor = Color.FromArgb(176, 176, 176);
        public Color LabelColor
        {
            get
            {
                return _labelcolor;
            }
            set
            {
                _labelcolor = value;
                label_search.ForeColor = value; 
            }
        }

        private Color _textcolor = Color.FromArgb(96, 125, 139);
        public Color TextColor
        {
            get
            {
                return _textcolor;
            }
            set
            {
                _textcolor = value;
                betterTextBox_search.ForeColor = value;
            }
        }


        public string PlaceHolder
        {
            get
            {
                return label_search.Text;
            }
            set
            {
                label_search.Text = value;
            }
        }

        public override string Text
        {
            get
            {
                return betterTextBox_search.Text;
            }
            set
            {
                betterTextBox_search.Text = value;
            }
        }



        bool search_state = true;
        public HideMode hideMode { get; set; }

        private Color _unselected = Color.FromArgb(176, 176, 176);
        public Color selectcolor { get; set; } = Color.FromArgb(255, 168, 26);
        public Color unselectcolor { get { return _unselected; } set { panel__Search.BackColor = value; _unselected = value; } }
        public MaterialTextbox()
        {
            InitializeComponent();

        }

        private void label_search_Click(object sender, EventArgs e)
        {
            betterTextBox_search.Focus();

        }

        private void betterTextBox_search_Enter(object sender, EventArgs e)
        {
            if (search_state)
            {
                if (hideMode == HideMode.below)
                {

                    label_search.SendToBack();
                }
                else
                {
                    label_search.Top -= betterTextBox_search.Height + 5;
                }
                search_state = false;
            }
            panel__Search.BackColor = selectcolor;
        }

        private void betterTextBox_search_Leave(object sender, EventArgs e)
        {
            if (betterTextBox_search.isEmpty())
            {
                if (hideMode == HideMode.below)
                {

                    label_search.BringToFront();
                }
                else
                {

                    label_search.Top += betterTextBox_search.Height + 5;
                }
                search_state = true;

            }
            panel__Search.BackColor = unselectcolor;

        }
    }
}
