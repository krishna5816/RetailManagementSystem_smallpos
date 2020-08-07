using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RetailManagementSystem.Custom
{
    
    public class Advanceform:Form
    {
        private Button button1;
    
        public delegate void AdvanceformclosedHandler(Object sender, Advanceformclosedargs args);
        public event AdvanceformclosedHandler Advanceformclosed;
        public Object obj;


        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
        }
        protected virtual void OnAdvanceformclosed()
        {
            if (Advanceformclosed != null)
            {
                Advanceformclosed(this, new Advanceformclosedargs() { data = this.obj });
            }
        }

        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(125, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button1_MouseDown);
            // 
            // Advanceform
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button1);
            this.Name = "Advanceform";
            this.Load += new System.EventHandler(this.Advanceform_Load);
            this.ResumeLayout(false);

        }

        private void Advanceform_Load(object sender, EventArgs e)
        {

        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {

        }
    }
}
