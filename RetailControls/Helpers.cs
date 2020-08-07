using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace RetailControls
{
    public class Helpers
    {
        public static ColumnHeader[] arrayToHeaders(string[] array)
        { 
        
            List<ColumnHeader> columnHeaders = new List<ColumnHeader>();
            foreach (var item in array)
            {
                columnHeaders.Add(new ColumnHeader()
                {
                    Text = item
                });
            }
            return columnHeaders.ToArray();

        }

        public static string DateStampToString(int value)
        {
            var r = value;
            var year = value / 10000;
            r = r % 10000;
            var month = r / 100;
            r = r % 100;
            return year.ToString() + "/" + month.ToString() + "/" + r.ToString();
        }
    }
}
