using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using OfficeOpenXml;
using RetailControls;

namespace RetailControls
{
    public static class ExtensionMethods
    {

        public static string[] array(this string x,string y)
        {
            return new string[] { x, y };
        }

        public static double[] array(this double x, double y)
        {
            return new double[] { x, y };
        }
        public static void rearrangeSN(this BetterListView lv,int column = 0)
        {
            var i=1;
            foreach (var item in lv.Items.Cast<ListViewItem>().ToList())
            {
                item.SubItems[column].Text = i.ToString();
                i += 1;
            }
        }
        public static bool isNull(this string s)
        {
            s = s.Trim();
            return (s == null) || (s.Trim() == "");
        }
        public static void add(this ListViewItem item,string s)
        {
            item.SubItems.Add(s);
        }
        public static void add(this ListViewItem item, object[] s)
        {
            var c = item.SubItems.Count;
            for (int i = 0; i <s.Length- c; i++)
            {
                item.SubItems.Add(new ListViewItem.ListViewSubItem());

            }

            for (int i = 0; i < s.Length; i++)
            {
                item.SubItems[i].Text = s[i].ToString();
            }
        }

        public static void move(this ListViewItem item, ListView s)
        {
            var clone =(ListViewItem) item.Clone();
            s.Items.Add(clone);
            item.Remove();

        }
        public static int toInt(this string s)
        {
            return Convert.ToInt32(s);
        }

        public static decimal toDecimal(this string s)
        {
            return Convert.ToDecimal(s);
        }
        public static string ToNepaliDate(this int date)
        {
            var str = "";
            str = (date / 10000).ToString();
            date = date % 10000;
            str += "/" + (date / 100).ToString("00");
            date = date % 100;
            str += "/" + date.ToString("00");
            return str;
        }

        public static int[] ToNepaliDateArray(this int date)
        {
            var str = new int[] { 0, 0, 0 };
            str[0] = (date / 10000);
            date = date % 10000;
            str [1]=  (date / 100);
            date = date % 100;
            str[2]=date;
            return str;
        }
        public static bool ISNumber(this string s)
        {
            decimal n = 0;
            return decimal.TryParse(s, out n);
        }
        /// <summary>
        /// Export Data To Excel
        /// </summary>
        /// <param name="listView"></param>
        /// <param name="path"></param>
        public static void ToExcel(this ListView listView,string title, string path)
        {
            
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using (var package = new ExcelPackage())
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets.Add(title);
                var i = 1;
                var j = 1;
                foreach (ColumnHeader item in listView.Columns)
                {
                    worksheet.Cells[i, j].Value = item.Text;
                    j += 1;
                }
                i += 1;
                foreach (ListViewItem item in listView.Items)
                {
                    j = 1;
                    foreach (ListViewItem.ListViewSubItem itm in item.SubItems)
                    {
                        worksheet.Cells[i, j].Value = itm.Text;

                        j += 1;
                    }
                    i += 1;
                }
                var f = new FileInfo(path);
                package.SaveAs(f);
            }
        }

        public static void AddColumns(this ListView listView,string[] s)
        {
            foreach (var item in s)
            {
                listView.Columns.Add(new ColumnHeader()
                {
                    Text = item
                });
            }
        }

        public static void MakeMiddle(this Control c,bool vertical =true,bool horizontal=true)
        {
            if (c.Parent != null)
            {
                if (vertical )
                {

                c.Top = (c.Parent.Height - c.Height) / 2;
                }
                if (horizontal)
                {
                c.Left = (c.Parent.Width - c.Width) / 2;

                }

            }
        }

        public static void SetOtherBorder(this Control c,Color cc,float w=1)
        {
            c.Paint += (o, e) =>
            {
                e.Graphics.DrawRectangle(new Pen(new SolidBrush(cc), w), new Rectangle(0, 0, c.Width -(int) w - 1, c.Height- (int)w - 1));
            };
        }

        public static bool checkconn(this string connectionstring)
        {

            try
            {
                using (System.Data.SqlClient.SqlConnection connection = new System.Data.SqlClient.SqlConnection(connectionstring))
                {
                    connection.Open();
                    return true;
                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                Debug.WriteLine(ex.Message + Environment.NewLine +
                    "Error line: " + ex.LineNumber + Environment.NewLine +
                    "Procedure name: " + ex.Procedure);
                return false;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return false;
            }
        }

        public static T BinarySearch<T, TKey>(this IList<T> list, Func<T, TKey> keySelector, TKey key)
        where TKey : IComparable<TKey>
        {
            if (list.Count == 0)
                return default(T);

            int min = 0;
            int max = list.Count;
            while (min < max)
            {
                int mid = min + ((max - min) / 2);
                T midItem = list[mid];
                TKey midKey = keySelector(midItem);
                int comp = midKey.CompareTo(key);
                if (comp < 0)
                {
                    min = mid + 1;
                }
                else if (comp > 0)
                {
                    max = mid - 1;
                }
                else
                {
                    return midItem;
                }
            }
            if (min == max &&
                min < list.Count &&
                keySelector(list[min]).CompareTo(key) == 0)
            {
                return list[min];
            }
            return default(T);
        }

        public static string ToJson<T>(this T o)
        {
            return JsonConvert.SerializeObject(o);
        }

        public static T ToObject<T>(this string o)
        {
            return JsonConvert.DeserializeObject<T>(o);
        }

        public static int ToINT(this string s)
        {
            return Convert.ToInt32(s);
        }


        public static bool IsRecognisedImageFile(this string fileName)
        {
            string targetExtension = System.IO.Path.GetExtension(fileName);
            if (String.IsNullOrEmpty(targetExtension))
            {
                return false;
            }

            var recognisedImageExtensions = System.Drawing.Imaging.ImageCodecInfo.GetImageEncoders().SelectMany(codec => codec.FilenameExtension.ToLowerInvariant().Split(';'));

            targetExtension = "*" + targetExtension.ToLowerInvariant();
            return recognisedImageExtensions.Contains(targetExtension);
        }
    }
}
