using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RetailControls
{
    public partial class DocumentsLoader : UserControl
    {
        public DocumentsLoader()
        {
            InitializeComponent();
        }
        private int filecount = 0;
        protected override void OnControlRemoved(ControlEventArgs e)
        {
            var c = (Document)e.Control;
            MessageBox.Show(c.name);
        }
        public Dictionary<int, string> documents = new Dictionary<int, string>()
        {

        };

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

            int i = 0;
        private void materialButton1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                foreach (string file in openFileDialog1.FileNames)
                {
                    var document = new Document()
                    {
                        name = file,
                        id=i
                    };

                    documents.Add(i, file);
                    i++;
                    panel1.Controls.Add(document);
                   
                }
            }
        }

        private void panel1_ControlAdded(object sender, ControlEventArgs e)
        {
            refreshDocuments();
        }

        private void panel1_ControlRemoved(object sender, ControlEventArgs e)
        {
            var c = (Document)e.Control;
            documents.Remove(c.id);
            refreshDocuments();
        }

        public void loadDocuments(string docs){
            var files = docs.Split('|');
            foreach (var file in files)
            {
                
            var document = new Document()
            {
                name = file,
                id = i
            };

            documents.Add(i, file);
            i++;
            panel1.Controls.Add(document);
            }
        }

        private void refreshDocuments()
        {
            var vpoint = 5;
            var hpoint = 5;
            foreach (Control c in panel1.Controls)
	        {
                c.Location=new Point(hpoint, vpoint);
                vpoint += c.Height + 2;
	        }
        }

        

      
    }
}
