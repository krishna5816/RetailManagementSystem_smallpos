using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetailManagementSystem.Bills
{
   public class ItemNameViwer
    {
        public Models.item Item{get;set;}
        public ItemNameViwer(Models.item _item)
        {
            Item = _item;
        }
        public override string ToString()
        {
            return this.Item.name;
        }
    }
}
