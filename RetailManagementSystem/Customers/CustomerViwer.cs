using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RetailManagementSystem.Models;
namespace RetailManagementSystem.CUSTOMERS
{
    public class CustomerViwer:ListViewItem
    {
        private int _id { get; set; }
        private string _name { get; set; }
        private string _adress { get; set; }
        private string _phone { get; set; }
        private string _email { get; set; }
        private decimal _due { get; set; }

        public int id { get { return _id; } set { _id = value; SubItems[0].Text = value.ToString(); } }
        public string name {
            get {
                return _name;
            }
            set {
                _name = value;
                SubItems[1].Text = value;
            }

        }
        public string adress {
            get
            {
                return _adress;
            }
            set
            {
                _adress = value;
                SubItems[2].Text = value;
            }
        }
        public string phone {

            get {
                return _phone;
            }
            set {
                _phone = value;
                SubItems[3].Text = value;
            }
        }

        public decimal due {
            get
            {
                return _due;
            }
            set
            {
                _due = value;
                SubItems[4].Text = value.ToString("0.00");
            }
        }

        public CustomerViwer(customer cus)
        {
            for (int i = 0; i < 6; i++)
            {
                SubItems.Add(new ListViewSubItem());
            }
            id = cus.id;
            name = cus.name;
            adress = cus.adress;
            phone = cus.phone;
            due = cus.due.Value;
        }

        public void update(customer cus)
        {
            

            id = cus.id;
            name = cus.name;
            adress = cus.adress;
            phone = cus.phone;
            due = cus.due.Value;
        }


    }
}

