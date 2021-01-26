namespace CustomControls
{
    partial class RangeSelector
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
            this.panel_dateselect = new System.Windows.Forms.Panel();
            this.label_todate = new System.Windows.Forms.Label();
            this.label_fromdate = new System.Windows.Forms.Label();
            this.label_week = new System.Windows.Forms.Label();
            this.comboBox_week = new System.Windows.Forms.ComboBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel_fy = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_fy = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_duration = new System.Windows.Forms.ComboBox();
            this.nepaliCalender_to = new CustomControls.NepaliCalender();
            this.nepaliCalenderfrom = new CustomControls.NepaliCalender();
            this.panel_dateselect.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel_fy.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_dateselect
            // 
            this.panel_dateselect.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_dateselect.Controls.Add(this.label_todate);
            this.panel_dateselect.Controls.Add(this.nepaliCalender_to);
            this.panel_dateselect.Controls.Add(this.label_fromdate);
            this.panel_dateselect.Controls.Add(this.label_week);
            this.panel_dateselect.Controls.Add(this.nepaliCalenderfrom);
            this.panel_dateselect.Controls.Add(this.comboBox_week);
            this.panel_dateselect.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_dateselect.Location = new System.Drawing.Point(0, 67);
            this.panel_dateselect.Name = "panel_dateselect";
            this.panel_dateselect.Size = new System.Drawing.Size(391, 130);
            this.panel_dateselect.TabIndex = 3;
            // 
            // label_todate
            // 
            this.label_todate.AutoSize = true;
            this.label_todate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_todate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label_todate.Location = new System.Drawing.Point(11, 64);
            this.label_todate.Name = "label_todate";
            this.label_todate.Size = new System.Drawing.Size(25, 19);
            this.label_todate.TabIndex = 9;
            this.label_todate.Text = "To";
            // 
            // label_fromdate
            // 
            this.label_fromdate.AutoSize = true;
            this.label_fromdate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_fromdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label_fromdate.Location = new System.Drawing.Point(9, 11);
            this.label_fromdate.Name = "label_fromdate";
            this.label_fromdate.Size = new System.Drawing.Size(44, 19);
            this.label_fromdate.TabIndex = 7;
            this.label_fromdate.Text = "From";
            // 
            // label_week
            // 
            this.label_week.AutoSize = true;
            this.label_week.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_week.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label_week.Location = new System.Drawing.Point(235, 11);
            this.label_week.Name = "label_week";
            this.label_week.Size = new System.Drawing.Size(47, 19);
            this.label_week.TabIndex = 6;
            this.label_week.Text = "Week";
            // 
            // comboBox_week
            // 
            this.comboBox_week.FormattingEnabled = true;
            this.comboBox_week.Items.AddRange(new object[] {
            "Week-1",
            "Week-2",
            "Week-3",
            "Week-4",
            "Week-5"});
            this.comboBox_week.Location = new System.Drawing.Point(237, 35);
            this.comboBox_week.Name = "comboBox_week";
            this.comboBox_week.Size = new System.Drawing.Size(136, 25);
            this.comboBox_week.TabIndex = 5;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.panel_fy);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.comboBox_duration);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(391, 67);
            this.panel5.TabIndex = 2;
            // 
            // panel_fy
            // 
            this.panel_fy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_fy.Controls.Add(this.label4);
            this.panel_fy.Controls.Add(this.comboBox_fy);
            this.panel_fy.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_fy.Location = new System.Drawing.Point(236, 0);
            this.panel_fy.Name = "panel_fy";
            this.panel_fy.Size = new System.Drawing.Size(153, 65);
            this.panel_fy.TabIndex = 3;
            this.panel_fy.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label4.Location = new System.Drawing.Point(4, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Fiscal Year";
            // 
            // comboBox_fy
            // 
            this.comboBox_fy.FormattingEnabled = true;
            this.comboBox_fy.Location = new System.Drawing.Point(8, 32);
            this.comboBox_fy.Name = "comboBox_fy";
            this.comboBox_fy.Size = new System.Drawing.Size(133, 25);
            this.comboBox_fy.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label3.Location = new System.Drawing.Point(5, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Duration";
            // 
            // comboBox_duration
            // 
            this.comboBox_duration.FormattingEnabled = true;
            this.comboBox_duration.Items.AddRange(new object[] {
            "None",
            "Fiscal Year",
            "Year",
            "Month",
            "Week",
            "Day",
            "Custom"});
            this.comboBox_duration.Location = new System.Drawing.Point(7, 32);
            this.comboBox_duration.Name = "comboBox_duration";
            this.comboBox_duration.Size = new System.Drawing.Size(217, 25);
            this.comboBox_duration.TabIndex = 0;
            this.comboBox_duration.SelectedIndexChanged += new System.EventHandler(this.comboBox_duration_SelectedIndexChanged);
            // 
            // nepaliCalender_to
            // 
            this.nepaliCalender_to.BackColor = System.Drawing.Color.Transparent;
            this.nepaliCalender_to.Datestamp = 20761024;
            this.nepaliCalender_to.DateTime = new System.DateTime(2020, 2, 7, 0, 0, 0, 0);
            this.nepaliCalender_to.Location = new System.Drawing.Point(7, 92);
            this.nepaliCalender_to.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.nepaliCalender_to.Name = "nepaliCalender_to";
            this.nepaliCalender_to.Size = new System.Drawing.Size(261, 31);
            this.nepaliCalender_to.TabIndex = 8;
            // 
            // nepaliCalenderfrom
            // 
            this.nepaliCalenderfrom.BackColor = System.Drawing.Color.Transparent;
            this.nepaliCalenderfrom.Datestamp = 20761024;
            this.nepaliCalenderfrom.DateTime = new System.DateTime(2020, 2, 7, 0, 0, 0, 0);
            this.nepaliCalenderfrom.Location = new System.Drawing.Point(4, 30);
            this.nepaliCalenderfrom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nepaliCalenderfrom.Name = "nepaliCalenderfrom";
            this.nepaliCalenderfrom.Size = new System.Drawing.Size(224, 30);
            this.nepaliCalenderfrom.TabIndex = 0;
            // 
            // RangeSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_dateselect);
            this.Controls.Add(this.panel5);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "RangeSelector";
            this.Size = new System.Drawing.Size(391, 200);
            this.panel_dateselect.ResumeLayout(false);
            this.panel_dateselect.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel_fy.ResumeLayout(false);
            this.panel_fy.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label_todate;
        private System.Windows.Forms.Label label_fromdate;
        private System.Windows.Forms.Label label_week;
        public NepaliCalender nepaliCalenderfrom;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel_fy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox comboBox_duration;
        public System.Windows.Forms.Panel panel_dateselect;
        public NepaliCalender nepaliCalender_to;
        public System.Windows.Forms.ComboBox comboBox_week;
        public System.Windows.Forms.ComboBox comboBox_fy;
    }
}
