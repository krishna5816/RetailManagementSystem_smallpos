using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RetailManagementSystem.Models;
namespace RetailManagementSystem.VENDORS
{ 
    public class VenViwer : ListViewItem
    {
        HamroSuperMarketEntities db = new HamroSuperMarketEntities();
        private int _id { get; set; }
        private string _name { get; set; }
        private string _address { get; set; }
        private string _phone { get; set; }
        private string _email { get; set; }
        private string _pan { get; set; }
        private decimal _due { get; set; }
        private decimal _advance { set; get; }




        public int id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value; SubItems[0].Text = value.ToString();
            }
        }
        public string name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value; SubItems[1].Text = value.ToString();
            }
        }
        public string address
        {
            get
            {
                return _address;
            }
            set
            {
                _address = value; SubItems[2].Text = value.ToString();
            }
        }
        public string phone
        {
            get
            {
                return _phone;
            }
            set
            {
                _phone = value; SubItems[3].Text = value.ToString();
            }
        }
        public string email
        {
            get
            {
                return _email;
            }
            set
            {
                _email = value; SubItems[4].Text = value.ToString();
            }
        }
        public string pannumber
        {
            get
            {
                return _pan;
            }
            set
            {
                _pan = value; SubItems[5].Text = value.ToString();
            }
        }
        public decimal due
        {
            get
            {
                return _due;
            }
            set
            {
                _due = value; SubItems[6].Text = value.ToString();
            }
        }
        public decimal advance
        {
            get
            {
                return _advance;
            }
            set
            {
                _advance = value; SubItems[7].Text = value.ToString();
            }
        }


        public VenViwer(vendor vendor)
        {
            for(int i=0;i<=10; i++)
            {
                SubItems.Add(new ListViewSubItem());
            }
            id = vendor.id;
            name = vendor.name;
            address = vendor.adress;
            email = vendor.email;
            phone = vendor.phoneno;
            pannumber = vendor.panno;
            due = vendor.due.Value;
            advance = vendor.advance.Value;

        }
        public void update(vendor ven)
        {
            id = ven.id;
            name = ven.name;
            address = ven.adress;
            email = ven.email;
            phone = ven.phoneno;
            pannumber = ven.panno;
            due = ven.due.Value;
            advance = ven.advance.Value;
        }
    }
}