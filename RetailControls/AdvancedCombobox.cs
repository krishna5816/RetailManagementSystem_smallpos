using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace RetailControls
{
    public class AdvancedCombobox:ComboBox
    {
        public  class ComboBoxItem
        {
            public dynamic data { get; set; }
            public dynamic value { get; set; }
            public override string ToString()
            {
                return data.ToString();
            }

            public dynamic getdata<T>()
            {
                return (T)data;
            }

            public dynamic getvalue<T>()
            {
                return (T)value;
            }
        }

        public void addItem(dynamic data, dynamic value)
        {
            var k = new ComboBoxItem()
            {
                data = data,
                value = value
            };
            this.Items.Add(k);
        }

        public ComboBoxItem getSelectedItem()
        {
            return (ComboBoxItem)this.SelectedItem;
        }

        public void selectByValue(dynamic value)
        {
            foreach (var item in this.Items)
            {
                var i = (ComboBoxItem)item;
                if (i.value == value)
                {
                    this.SelectedItem = item;
                }
            }
        }

        public void selectBydata(dynamic data)
        {
            foreach (var item in this.Items)
            {
                var i = (ComboBoxItem)item;

          if (i.data == data)
                {
                    this.SelectedItem = item;
                }
            }
        }

    }
}
