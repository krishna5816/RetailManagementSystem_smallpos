using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomControls
{
    public class MaterialButton : System.Windows.Forms.Button
    {
        public int role { get; set; }
        public Boolean userole { get; set; }

        private string temptext;
        private Color tempbgcolor;
        public string Totext{get;set;}
        public MaterialButton()
        {
            this.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.userole = false;
            this.role = 0;
            Cursor = System.Windows.Forms.Cursors.Hand;
        }

        public MaterialButton(bool _userole=false,int _role=0)
        {
            this.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.userole = _userole;
            this.role = _role;
        }

        protected override void OnClick(EventArgs e)
        {
            if (this.userole)
            {
                if(this.role< RoleManagement.CurrentRole.instance.roles.role)
                {
                    Alert.show("", "This User Account IS Not Authorized To " + Totext, 3000);
                    return;

                }

            }
            base.OnClick(e);
        }

        public void settempbg(Image i,Color c)
        {
            this.temptext = this.Text;
            this.tempbgcolor = this.BackColor;
            this.BackColor = c;
            this.BackgroundImage = i;
           
            this.Text = "";
        }

        public void removetempbg()
        {
            this.BackgroundImage = null;
            this.Text = this.temptext;
            this.BackColor = this.tempbgcolor;

        }

    }
}
