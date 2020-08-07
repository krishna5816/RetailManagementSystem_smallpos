using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Data.Entity.Core.EntityClient;
namespace RetailManagementSystem.SETTING
{
    public partial class DatabaseSetup : Form
    {
        public DatabaseSetup()
        {
            InitializeComponent();
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            var constr = new SqlConnectionStringBuilder()
            {
                UserID = user_txt.Text,
                Password = password_txt.Text,
                DataSource = server_txt.Text,
                InitialCatalog = database_txt.Text
            };
            var str = "data source=" + server_txt.Text + ";User Id=" + user_txt.Text + ";Password=" + password_txt.Text + ";initial catalog=" + database_txt.Text + ";MultipleActiveResultSets=True;App=EntityFramework";
            try
            {
                using (var con = new SqlConnection(constr.ToString()))
                {
                    con.Open();
                    
                    var connstr1 = new EntityConnectionStringBuilder()
                    {
                        Metadata = "res://*/Models.Model1.csdl|res://*/Models.Model1.ssdl|res://*/Models.Model1.msl",
                        Provider = "System.Data.SqlClient",
                        ProviderConnectionString = str

                    };
                    if (createnewadmin.Checked)
                    {
                        var query = "insert into admins(name,pass,role) values('" + admin_txt.Text + "','" + adminpassword_txt.Text + "',1)";
                        var cmd = new SqlCommand(query, con);
                        cmd.ExecuteNonQuery();
                    }

                    var c = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                    var cs = c.ConnectionStrings.ConnectionStrings["HamroSuperMarketEntities"];
                    cs.ConnectionString = connstr1.ToString();
                    c.Save(ConfigurationSaveMode.Full);
                    ConfigurationManager.RefreshSection("connectionStrings");
                    Properties.Settings.Default.isdatabasesetup = true;
                    Properties.Settings.Default.Save();
                    con.Close();
                    this.Close();

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Failed to connect, \n" + ex.Message);
            }
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}