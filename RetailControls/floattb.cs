using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace RetailControls
{
    public class floattb : TextBox
    {
        public decimal value
        {
            get
            {
                if (this.Text.Trim() == "")
                {
                    return 0;
                }
                else
                {

                    return Convert.ToDecimal(this.Text);
                }
            }
            set
            {
                this.Text = value.ToString();
            }
        }
        protected override void OnLeave(EventArgs e)
        {
            if (this.Text.Trim() == "")
            {
                this.Text = "0";
            }
            base.OnLeave(e);
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            if ((e.KeyValue > 47 && e.KeyValue < 58) || (e.KeyValue == 190) || (e.KeyValue == 13) || (e.KeyValue == 8))
            {
                if (this.Text.Contains(".") && (e.KeyValue == 190))
                {
                    e.SuppressKeyPress = true;
                    return;
                }

                e.SuppressKeyPress = false;
            }
            else
            {
                e.SuppressKeyPress = true;
            }
            base.OnKeyDown(e);
        }
    }
}
   
