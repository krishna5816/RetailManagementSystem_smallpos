using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RetailControls;
namespace RetailManagementSystem
{
    public partial class login_form : Form
    {
        public login_form()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void login_form_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.isdatabasesetup == false)
            {
                new SETTING.DatabaseSetup().ShowDialog();
            }
            if (Properties.Settings.Default.isdatabasesetup == false)
            {
                Application.Exit();
            }
            if (!Properties.Settings.Default.isuserregister)
            {
                var m = new AdminSetting.UserRegister();
                var trans = new RetailControls.Transparent(m);

                trans.ShowDialog();
            }
            if (!Properties.Settings.Default.isuserregister)
            {
                MessageBox.Show("Please Register User first");
                this.Close();
            }
            var keyold = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("5D41402ABC4B2A76B9719D911017C592");
            if (keyold != null)
            {
                var key = Convert.ToDateTime((string)keyold.GetValue("upto"));
                if (key < DateTime.Now)
                {
                    var m = new AdminSetting.AddKey();
                    var trans = new RetailControls.Transparent(m);

                    trans.ShowDialog();
                }
                key = Convert.ToDateTime((string)keyold.GetValue("upto"));
                if (key < DateTime.Now)
                {
                    MessageBox.Show("Your Key has expired");
                    this.Close();
                }
            }
        }

        private void bettertextbox1_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void materialButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            
            using (var db = new Models.HamroSuperMarketEntities())
            {
                if (db.admins.Count(o => o.name ==username_txt.Text && o.pass == password_txt.Text) > 0)
                {
                    Dashboard obj = new Dashboard();
                    if (Dashboard.Instance.nepaliCalender1.DATESTAMP > 20771115)
                    {
                        CustomControls.Alert.show("Expire", "your software date is expire please please contact with Needtechnosoft for renewable", 4000);
                        return;
                    }
                    obj.FormClosed += Obj_FormClosed;
                    obj.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("your user name and password is not match please try again");
                    return;

                }
            }
        }




        private void Obj_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void password_txt_Enter(object sender, EventArgs e)
        {
            label2.Top = 225;
        }

        private void password_txt_Leave(object sender, EventArgs e)
        {
            if (password_txt.Text.Trim() == "")
                label2.Top = 241;
        }

        private void password_txt_Click(object sender, EventArgs e)
        {
            label2.Top = 225;
            password_txt.Focus();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

            label1.Top = 100;
            username_txt.Focus();
        }

        private void username_txt_Enter(object sender, EventArgs e)
        {
            label1.Top = 165;
        }

        private void username_txt_Leave(object sender, EventArgs e)
        {
            if (username_txt.Text.Trim() == "")
            {
                label1.Top = 180;
            }
        }
    }
}

