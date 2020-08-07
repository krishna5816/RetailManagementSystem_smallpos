using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace RetailControls
{
    public static class Helper
    {
        public static void showModal(Form form)
        {
            new Transparent(form).ShowDialog();
        }
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

        public static Rectangle getrect(double p1, double p2, float top, float width)
        {
            return new Rectangle(Convert.ToInt32(p1 * width) - 1, Convert.ToInt32(top) - 1, Convert.ToInt32(p2 * width) - 1, 15);
        }

        public static int drawtext(Graphics g, string[] list, Double[] pos, int top, int width, Font f, Brush b, int left = 10, StringAlignment sa = StringAlignment.Near)
        {
            int left2;
            int max = 15;
            for (int i = 0; i < list.Length; i++)
            {

                var s = list[i];

                var w = (int)(pos[i + 1] * width);
                var m = g.MeasureString(list[i], f, w).Height;


                var rect = new Rectangle(left, top, w, (int)m);
                if (rect.Height > max)
                {
                    max = rect.Height;
                }
                var sf = new StringFormat();
                sf.Alignment = sa;
                g.DrawString(list[i], f, b, rect, sf);
                left += w;
            }
            return max;
        }
        public static int  measuretext(Graphics g, string[] list, Double[] pos, int top, int width, Font f, Brush b)
        {
            int max = 0;
            for (int i = 0; i < list.Length; i++)
            {

                var s = list[i];
                var w = (int)(pos[i + 1] * width);
                var m = g.MeasureString(list[i], f, w).Height;


                if (m > max)
                {
                    max = (int)m;
                }
            }
            return max;
        }
        public static void drawlines(Graphics g, double[] list, int top, int width, int lineheight,int left=0)
        {
            var pen = new Pen(Color.Black);
            
            foreach (double item in list)
            {
                left += (int)(item * width);
                g.DrawLine(pen,
                    left, top,
                    left, top + lineheight
                    );
            }
        }

        public static int getlineheight(Font f, Graphics g, string s, int width, decimal p1, decimal p2, Brush b, int top, StringAlignment sa = StringAlignment.Center)
        {
            int total = Convert.ToInt32(g.MeasureString(s, f).Width);
            int perline = Convert.ToInt32((p2 - p1) * width);
            var count = s.Length;
            var lines = total / perline;
            if (total % perline > 0)
            {
                lines += 1;
            }
            var sf = new StringFormat()
            {
                Alignment = sa,

            };

            var h = g.MeasureString(s, f).Height;
            g.DrawString(s, f, b, new RectangleF(
                Convert.ToInt32(p1 * width),
                top,
                Convert.ToInt32((p2 - p1) * width),
                top + h * lines
                ), sf);
            return (int)h * lines;
        }


    }
}
