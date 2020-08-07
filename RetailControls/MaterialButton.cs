using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace RetailControls
{
    public class MaterialButton:Button
    {
        public Color HoverColor { get; set; }
        private Color tempHoverColor;
        public Color HoverTextColor { get; set; }
        private Color tempHoverTextColor;

        public MaterialButton()
        {
            this.FlatAppearance.BorderSize = 0;
            this.FlatStyle = FlatStyle.Flat;
        }

        protected override void OnMouseEnter(EventArgs e)
        {
                tempHoverColor = this.BackColor;
                this.BackColor = HoverColor;
                tempHoverTextColor = this.ForeColor;
                this.ForeColor = HoverTextColor;  
            
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            
                this.BackColor = tempHoverColor;
                this.ForeColor = tempHoverTextColor;
          
        }
    }
}
