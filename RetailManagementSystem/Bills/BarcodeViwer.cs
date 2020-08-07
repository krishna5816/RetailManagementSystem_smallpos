using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetailManagementSystem.Bills
{
  public class BarcodeViwer
    {
        public  Models.item Item { get; set; }
        public BarcodeViwer(Models.item _item)
        {
            Item = _item;
        }
        public override string ToString()
        {
            return this.Item.barcode;
        }
    }
}
