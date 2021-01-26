using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomControls
{
    public partial class Toast : UserControl
    {
        public Color[] Colors = new Color[]
        {
            Color.FromArgb(66, 133, 244),
            Color.FromArgb(52, 168, 83),
            Color.FromArgb(251, 188, 5),
            Color.FromArgb(234, 67, 53),

        };
        public Toast(string text, int mode = 1, int time = 5000)
        {
            InitializeComponent();
            label1.Text = text;
            this.BackColor = Colors[mode];
            timer.Interval = time;
            timer.Enabled = true;
        }

        private void materialButtonClose_Click(object sender, EventArgs e)
        {
            try
            {
                //if (ToastBox.Instance.flowLayoutPanel1.InvokeRequired)
                //{
                //    ToastBox.Instance.flowLayoutPanel1.Invoke((MethodInvoker)delegate
                //    {

                //        ToastBox.Instance.flowLayoutPanel1.Controls.Remove(this);
                //    });
                //}
                //else
                //{

                    ToastBox.Instance.flowLayoutPanel1.Controls.Remove(this);
                //}


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        public static void show(string text, int mode = 1, int time = 5000)
        {
            var n = new Toast(text, mode, time);
            n.Width = 300;
            if (ToastBox.Instance == null)
            {
                ToastBox.init();
                ToastBox.Instance.flowLayoutPanel1.Controls.Add(n);
            }else
            {

                ToastBox.Instance.flowLayoutPanel1.Controls.Add(n);
            }
        }

        private void Toast_Paint(object sender, PaintEventArgs e)
        {
            if (label1.Height > 30)
            {
                this.Height = label1.Height + 20;
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            try
            {

                //if (ToastBox.Instance.flowLayoutPanel1.InvokeRequired)
                //{
                //    ToastBox.Instance.flowLayoutPanel1.Invoke((MethodInvoker)delegate
                //    {

                //        ToastBox.Instance.flowLayoutPanel1.Controls.Remove(this);
                //    });
                //}
                //else
                //{

                ToastBox.Instance.flowLayoutPanel1.Controls.Remove(this);
                this.timer.Stop();
                this.Dispose(true);
                //}

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
    }
}
