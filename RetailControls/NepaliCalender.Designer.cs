namespace RetailControls
{
    partial class NepaliCalender
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.day = new RetailControls.AdvancedCombobox();
            this.month = new RetailControls.AdvancedCombobox();
            this.year = new RetailControls.AdvancedCombobox();
            this.SuspendLayout();
            // 
            // day
            // 
            this.day.FormattingEnabled = true;
            this.day.Location = new System.Drawing.Point(125, 1);
            this.day.Name = "day";
            this.day.Size = new System.Drawing.Size(47, 21);
            this.day.TabIndex = 2;
            this.day.SelectedIndexChanged += new System.EventHandler(this.day_SelectedIndexChanged);
            // 
            // month
            // 
            this.month.FormattingEnabled = true;
            this.month.Location = new System.Drawing.Point(63, 1);
            this.month.Name = "month";
            this.month.Size = new System.Drawing.Size(61, 21);
            this.month.TabIndex = 1;
            this.month.SelectedIndexChanged += new System.EventHandler(this.year_SelectedIndexChanged);
            // 
            // year
            // 
            this.year.FormattingEnabled = true;
            this.year.Location = new System.Drawing.Point(1, 1);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(61, 21);
            this.year.TabIndex = 0;
            this.year.SelectedIndexChanged += new System.EventHandler(this.year_SelectedIndexChanged);
            // 
            // NepaliCalender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.day);
            this.Controls.Add(this.month);
            this.Controls.Add(this.year);
            this.Name = "NepaliCalender";
            this.Size = new System.Drawing.Size(179, 35);
            this.Load += new System.EventHandler(this.NepSel_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private AdvancedCombobox year;
        private AdvancedCombobox month;
        private AdvancedCombobox day;
    }
}
