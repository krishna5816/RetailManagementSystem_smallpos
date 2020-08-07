using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
namespace RetailControls
{
    public partial class NotificationMAnager : Component
    {
        public NotificationMAnager()
        {
            InitializeComponent();
        }

        public NotificationMAnager(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        public void show(string msg, int interval)
        {

            Task.Run(() =>
            {
            var f = new Notification(interval);
            f.label1.Text = msg;
            f.Location = getPoint();
            f.TopMost = true;
            System.IO.Stream str = RetailControls.controlresource.Alert_sound;
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
            snd.Play();
            f.ShowDialog();
            
            });
            

        }

        public Point getPoint()
        {
            var y = Screen.PrimaryScreen.Bounds.Height;
            var x = Screen.PrimaryScreen.Bounds.Width;
            var xx = 325;
            var yy = 150;
            var point = new Point(x - xx, y - yy);
            return point;
        }
    }
}
