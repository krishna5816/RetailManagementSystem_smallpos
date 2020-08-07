using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RetailManagementSystem.Models;
namespace RetailManagementSystem.Expenses
{
    public partial class Expencesview : Form
    {
        HamroSuperMarketEntities db = new HamroSuperMarketEntities();

        public Expencesview()
        {
            InitializeComponent();
            exenses_combobox.Items.Add("All");
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        int count;
        private void Expencesview_Load(object sender, EventArgs e)
        {
            List<expencecategory> expenses = db.expencecategories.ToList();
            foreach (var expense in expenses)
            {
                exenses_combobox.addItem(expense, expense.id); 
            }
            
        }
        private void load_btn_Click(object sender, EventArgs e)
        {
            if (exenses_combobox.SelectedIndex > -1)
            {
                panel1.Controls.Clear();
                count = 0;
                var from =nepaliCalender1.engdate;
                var to=nepaliCalender2.engdate;
                List<expence> expenses;
                if (exenses_combobox.SelectedIndex == 0)
                {
                    expenses = db.expences.Where(o => o.dates >= from && o.dates <= to).ToList();
                }
                else
                {

                    var exp = (expencecategory)exenses_combobox.getSelectedItem().getdata<expencecategory>();
                    expenses = db.expences.Where(o => o.expencecategory_id == exp.id && (o.dates >= from && o.dates <= to)).ToList();
                }
                  decimal a=0;
                foreach (expence n in expenses)
                {
                    expenses_viwer expviwer = new expenses_viwer();
                    expviwer.id = n.id;
                    expviwer.namecategory = n.name;
                    expviwer.date = Convert.ToDateTime(n.dates.ToString());

                    expviwer.amount = Convert.ToDecimal(n.amount);
                    a +=Convert.ToDecimal( n.amount);

                    expviwer.Location = new Point(5, count * 65 + 5);
                    count += 1;
                    panel1.Controls.Add(expviwer);
                    expviwer.Show();
                    
                }
                exptotal_txt.Text = a.ToString();
            }
           
            }

        private void exenses_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

       
    }
}
