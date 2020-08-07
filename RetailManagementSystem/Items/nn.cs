using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RetailManagementSystem.Custom;

namespace RetailManagementSystem.ITEMS
{
    class nn:Advanceform
    {
        private RetailControls.AdvancedCombobox advancedCombobox1;
    
        void ad()
        {
            
        }

        private void InitializeComponent()
        {
            this.advancedCombobox1 = new RetailControls.AdvancedCombobox();
            this.SuspendLayout();
            // 
            // advancedCombobox1
            // 
            this.advancedCombobox1.FormattingEnabled = true;
            this.advancedCombobox1.Location = new System.Drawing.Point(42, 34);
            this.advancedCombobox1.Name = "advancedCombobox1";
            this.advancedCombobox1.Size = new System.Drawing.Size(121, 21);
            this.advancedCombobox1.TabIndex = 0;
            // 
            // nn
            // 
            this.ClientSize = new System.Drawing.Size(720, 503);
            this.Controls.Add(this.advancedCombobox1);
            this.Name = "nn";
         
            this.ResumeLayout(false);

        }

        
    }
}
