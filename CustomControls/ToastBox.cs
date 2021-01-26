using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomControls
{
    public partial class ToastBox : Form
    {
        public static List<Toast> datas;
        public static ToastBox Instance;
        public ToastBox()
        {
            InitializeComponent();
            Instance = this;
            this.FormClosed += (o, e) =>
            {
                Instance = null;
            };
            this.Width = 300;
            this.Top = 0;
            this.Left = Screen.PrimaryScreen.WorkingArea.Width - 300;
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;
            datas = new List<Toast>();
            backgroundWorker1.RunWorkerAsync();
        }

        public void add(string text, int mode = 1, int time = 5000)
        {
            var n = new Toast(text, mode, time);
            
            datas.Add(n);
        }

       
        public static void init()
        {
            if (Instance == null)
            {
                new ToastBox().Show();
            }

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                if (datas.Count > 0)
                {
                    this.Invoke((MethodInvoker)delegate
                    {
                        flowLayoutPanel1.Controls.Add(datas[0]);
                        datas.RemoveAt(0);
                    });
                }
                else
                {
                    Thread.Sleep(5000);
                }
            }
           
        }
    }
}
