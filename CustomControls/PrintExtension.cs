using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomControls
{
    public static class PrintExtension
    {
        public static int printInBox(this Graphics g,int x, int y, int width, string text, Font f, StringAlignment sa = StringAlignment.Near, bool drawrect = false, Brush b = null)
        {
            var brush = new SolidBrush(Color.Black);
            if (b != null)
            {
                brush = (SolidBrush)b;
            }
            var height = (int)g.MeasureString(text, f, width).Height;
            var rect = new Rectangle(x, y, width, height);
            var stringformat = new StringFormat()
            {
                Alignment = sa
            };
            g.DrawString(text, f, brush, rect, stringformat);
            if (drawrect)
            {
                g.DrawRectangle(new Pen(brush), rect);
            }
            return height;
        }

        public static ColumnHeader[] arrayToHeaders(this string[] array)
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


        public static int drawtext(this Graphics g, string[] list, Double[] pos, int top, int width, Font f, Brush b, int left = 10, StringAlignment sa = StringAlignment.Near)
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

        public static int splitWord(this Graphics g, string[] list, int top, int width, Font f, Brush b, int left = 0)
        {
            int max = 0;
            var max1 = g.printInBox(left, top, width / 2, list[0], f, StringAlignment.Near);
            var max2 = g.printInBox(left + width / 2, top, width / 2, list[1], f, StringAlignment.Far);
            if (max1 < max2)
            {
                max = max2;
            }
            else
            {
                max = max1;
            }
            return max;
        }

        public static int splitWordReverse(this Graphics g, string[] list, int top, int width, Font f, Brush b, int left = 0)
        {
            int max = 0;
            var max1 = g.printInBox(left, top, width / 2,  list[0], f, StringAlignment.Far);
            var max2 = g.printInBox(left + width / 2, top, width / 2, list[1], f, StringAlignment.Near);
            if (max1 < max2)
            {
                max = max2;
            }
            else
            {
                max = max1;
            }
            return max;
        }
        public static int measuretext(this Graphics g, string[] list, Double[] pos, int top, int width, Font f, Brush b)
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
        public static void drawlines(this Graphics g, double[] list, int top, int width, int lineheight, int left = 0, Pen p = null)
        {
            if (p == null)
            {
                p = new Pen(Color.Black);
            }


            foreach (double item in list)
            {
                left += (int)(item * width);
                g.DrawLine(p,
                    left, top,
                    left, top + lineheight
                    );
            }
        }

        public static int getlineheight(this Graphics g, Font f, string s, int width, decimal p1, decimal p2, Brush b, int top, StringAlignment sa = StringAlignment.Center)
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

        public static void drawHorizantalLine(this Graphics g,int x,int y,int width,Brush brush=null)
        {
            if (brush == null)
            {
                brush = Brushes.Black;
            }
            g.DrawLine(new Pen(brush), x, y, x + width, y);
        }

        public static void drawVerticalLine(this Graphics g, int x, int y, int height, Brush brush = null)
        {
            if (brush == null)
            {
                brush = Brushes.Black;
            }
            g.DrawLine(new Pen(brush), x, y, x , y+height);
        }
    }
}
