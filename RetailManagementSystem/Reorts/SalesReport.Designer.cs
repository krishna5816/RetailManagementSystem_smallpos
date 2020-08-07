namespace RetailManagementSystem.REPORTS
{
    partial class SalesReport
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
            RetailControls.NepDate nepDate4 = new RetailControls.NepDate();
            RetailControls.NepDate nepDate5 = new RetailControls.NepDate();
            RetailControls.NepDate nepDate6 = new RetailControls.NepDate();
            this.label_totalamount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button_export = new System.Windows.Forms.Button();
            this.button_Reset = new System.Windows.Forms.Button();
            this.button_load = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.nepaliCalender_sales_end = new RetailControls.NepaliCalender();
            this.nepaliCalender2 = new RetailControls.NepaliCalender();
            this.nepaliCalender_sales_start = new RetailControls.NepaliCalender();
            this.radioButton_sales_billWise = new System.Windows.Forms.RadioButton();
            this.checkBox_types = new System.Windows.Forms.CheckBox();
            this.radioButton__sales_single = new System.Windows.Forms.RadioButton();
            this.radioButton_sales_group = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox_categories = new System.Windows.Forms.ListBox();
            this.comboBox_sales_week = new System.Windows.Forms.ComboBox();
            this.comboBox_sales = new System.Windows.Forms.ComboBox();
            this.label_totalmargin = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_totalamount
            // 
            this.label_totalamount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_totalamount.AutoSize = true;
            this.label_totalamount.Location = new System.Drawing.Point(110, 490);
            this.label_totalamount.Name = "label_totalamount";
            this.label_totalamount.Size = new System.Drawing.Size(17, 19);
            this.label_totalamount.TabIndex = 23;
            this.label_totalamount.Text = "0";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 490);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 19);
            this.label2.TabIndex = 22;
            this.label2.Text = "Total Amount:";
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 146);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(892, 335);
            this.listView1.TabIndex = 21;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.button_export);
            this.panel3.Controls.Add(this.button_Reset);
            this.panel3.Controls.Add(this.button_load);
            this.panel3.Location = new System.Drawing.Point(683, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(212, 138);
            this.panel3.TabIndex = 20;
            // 
            // button_export
            // 
            this.button_export.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_export.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button_export.Location = new System.Drawing.Point(5, 39);
            this.button_export.Name = "button_export";
            this.button_export.Size = new System.Drawing.Size(77, 30);
            this.button_export.TabIndex = 3;
            this.button_export.Text = "Export";
            this.button_export.UseVisualStyleBackColor = true;
            // 
            // button_Reset
            // 
            this.button_Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Reset.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button_Reset.Location = new System.Drawing.Point(88, 4);
            this.button_Reset.Name = "button_Reset";
            this.button_Reset.Size = new System.Drawing.Size(77, 30);
            this.button_Reset.TabIndex = 1;
            this.button_Reset.Text = "Reset";
            this.button_Reset.UseVisualStyleBackColor = true;
            // 
            // button_load
            // 
            this.button_load.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_load.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button_load.Location = new System.Drawing.Point(5, 4);
            this.button_load.Name = "button_load";
            this.button_load.Size = new System.Drawing.Size(77, 30);
            this.button_load.TabIndex = 0;
            this.button_load.Text = "Load";
            this.button_load.UseVisualStyleBackColor = true;
            this.button_load.Click += new System.EventHandler(this.button_load_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.nepaliCalender_sales_end);
            this.panel2.Controls.Add(this.nepaliCalender2);
            this.panel2.Controls.Add(this.nepaliCalender_sales_start);
            this.panel2.Controls.Add(this.radioButton_sales_billWise);
            this.panel2.Controls.Add(this.checkBox_types);
            this.panel2.Controls.Add(this.radioButton__sales_single);
            this.panel2.Controls.Add(this.radioButton_sales_group);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.listBox_categories);
            this.panel2.Controls.Add(this.comboBox_sales_week);
            this.panel2.Controls.Add(this.comboBox_sales);
            this.panel2.Location = new System.Drawing.Point(2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(677, 138);
            this.panel2.TabIndex = 19;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // nepaliCalender_sales_end
            // 
            nepDate4.Day = 5;
            nepDate4.Month = 12;
            nepDate4.MonthName = "Chaitra";
            nepDate4.WeekDay = 4;
            nepDate4.WeekDayName = "Wednesday";
            nepDate4.Year = 2076;
            this.nepaliCalender_sales_end.date = nepDate4;
            this.nepaliCalender_sales_end.DATESTAMP = 20761205;
            this.nepaliCalender_sales_end.engdate = new System.DateTime(2020, 3, 18, 0, 0, 0, 0);
            this.nepaliCalender_sales_end.Location = new System.Drawing.Point(43, 96);
            this.nepaliCalender_sales_end.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.nepaliCalender_sales_end.Name = "nepaliCalender_sales_end";
            this.nepaliCalender_sales_end.Size = new System.Drawing.Size(202, 26);
            this.nepaliCalender_sales_end.TabIndex = 14;
            // 
            // nepaliCalender2
            // 
            nepDate5.Day = 5;
            nepDate5.Month = 12;
            nepDate5.MonthName = "Chaitra";
            nepDate5.WeekDay = 4;
            nepDate5.WeekDayName = "Wednesday";
            nepDate5.Year = 2076;
            this.nepaliCalender2.date = nepDate5;
            this.nepaliCalender2.DATESTAMP = 20761205;
            this.nepaliCalender2.engdate = new System.DateTime(2020, 3, 18, 0, 0, 0, 0);
            this.nepaliCalender2.Location = new System.Drawing.Point(378, 381);
            this.nepaliCalender2.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.nepaliCalender2.Name = "nepaliCalender2";
            this.nepaliCalender2.Size = new System.Drawing.Size(276, 44);
            this.nepaliCalender2.TabIndex = 13;
            // 
            // nepaliCalender_sales_start
            // 
            nepDate6.Day = 5;
            nepDate6.Month = 12;
            nepDate6.MonthName = "Chaitra";
            nepDate6.WeekDay = 4;
            nepDate6.WeekDayName = "Wednesday";
            nepDate6.Year = 2076;
            this.nepaliCalender_sales_start.date = nepDate6;
            this.nepaliCalender_sales_start.DATESTAMP = 20761205;
            this.nepaliCalender_sales_start.engdate = new System.DateTime(2020, 3, 18, 0, 0, 0, 0);
            this.nepaliCalender_sales_start.Location = new System.Drawing.Point(43, 67);
            this.nepaliCalender_sales_start.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.nepaliCalender_sales_start.Name = "nepaliCalender_sales_start";
            this.nepaliCalender_sales_start.Size = new System.Drawing.Size(203, 29);
            this.nepaliCalender_sales_start.TabIndex = 12;
            // 
            // radioButton_sales_billWise
            // 
            this.radioButton_sales_billWise.AutoSize = true;
            this.radioButton_sales_billWise.Location = new System.Drawing.Point(214, 6);
            this.radioButton_sales_billWise.Name = "radioButton_sales_billWise";
            this.radioButton_sales_billWise.Size = new System.Drawing.Size(73, 23);
            this.radioButton_sales_billWise.TabIndex = 11;
            this.radioButton_sales_billWise.Text = "BillWise";
            this.radioButton_sales_billWise.UseVisualStyleBackColor = true;
            this.radioButton_sales_billWise.CheckedChanged += new System.EventHandler(this.radioButton_sales_billWise_CheckedChanged);
            // 
            // checkBox_types
            // 
            this.checkBox_types.AutoSize = true;
            this.checkBox_types.Location = new System.Drawing.Point(450, 8);
            this.checkBox_types.Name = "checkBox_types";
            this.checkBox_types.Size = new System.Drawing.Size(111, 23);
            this.checkBox_types.TabIndex = 10;
            this.checkBox_types.Text = "CustomSelect";
            this.checkBox_types.UseVisualStyleBackColor = true;
            // 
            // radioButton__sales_single
            // 
            this.radioButton__sales_single.AutoSize = true;
            this.radioButton__sales_single.Location = new System.Drawing.Point(129, 6);
            this.radioButton__sales_single.Name = "radioButton__sales_single";
            this.radioButton__sales_single.Size = new System.Drawing.Size(84, 23);
            this.radioButton__sales_single.TabIndex = 8;
            this.radioButton__sales_single.Text = "ItemWise";
            this.radioButton__sales_single.UseVisualStyleBackColor = true;
            // 
            // radioButton_sales_group
            // 
            this.radioButton_sales_group.AutoSize = true;
            this.radioButton_sales_group.Checked = true;
            this.radioButton_sales_group.Location = new System.Drawing.Point(12, 7);
            this.radioButton_sales_group.Name = "radioButton_sales_group";
            this.radioButton_sales_group.Size = new System.Drawing.Size(119, 23);
            this.radioButton_sales_group.TabIndex = 7;
            this.radioButton_sales_group.TabStop = true;
            this.radioButton_sales_group.Text = "Company Wise";
            this.radioButton_sales_group.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Report Type";
            // 
            // listBox_categories
            // 
            this.listBox_categories.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox_categories.Enabled = false;
            this.listBox_categories.FormattingEnabled = true;
            this.listBox_categories.ItemHeight = 17;
            this.listBox_categories.Location = new System.Drawing.Point(450, 39);
            this.listBox_categories.Name = "listBox_categories";
            this.listBox_categories.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox_categories.Size = new System.Drawing.Size(219, 89);
            this.listBox_categories.TabIndex = 6;
            // 
            // comboBox_sales_week
            // 
            this.comboBox_sales_week.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_sales_week.FormattingEnabled = true;
            this.comboBox_sales_week.Items.AddRange(new object[] {
            "First",
            "Second",
            "Third",
            "Fourth",
            "Fifth"});
            this.comboBox_sales_week.Location = new System.Drawing.Point(248, 68);
            this.comboBox_sales_week.Name = "comboBox_sales_week";
            this.comboBox_sales_week.Size = new System.Drawing.Size(192, 25);
            this.comboBox_sales_week.TabIndex = 5;
            this.comboBox_sales_week.Visible = false;
            // 
            // comboBox_sales
            // 
            this.comboBox_sales.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_sales.FormattingEnabled = true;
            this.comboBox_sales.Items.AddRange(new object[] {
            "Daily",
            "Weekly",
            "Monthly",
            "Yearly",
            "Custom"});
            this.comboBox_sales.Location = new System.Drawing.Point(102, 36);
            this.comboBox_sales.Name = "comboBox_sales";
            this.comboBox_sales.Size = new System.Drawing.Size(338, 25);
            this.comboBox_sales.TabIndex = 2;
            this.comboBox_sales.SelectedIndexChanged += new System.EventHandler(this.comboBox_sales_SelectedIndexChanged);
            // 
            // label_totalmargin
            // 
            this.label_totalmargin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_totalmargin.AutoSize = true;
            this.label_totalmargin.Location = new System.Drawing.Point(306, 490);
            this.label_totalmargin.Name = "label_totalmargin";
            this.label_totalmargin.Size = new System.Drawing.Size(17, 19);
            this.label_totalmargin.TabIndex = 25;
            this.label_totalmargin.Text = "0";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(204, 490);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 19);
            this.label4.TabIndex = 24;
            this.label4.Text = "Total Margin:";
            // 
            // SalesReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label_totalmargin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label_totalamount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SalesReport";
            this.Size = new System.Drawing.Size(900, 520);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_totalamount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button_export;
        private System.Windows.Forms.Button button_Reset;
        private System.Windows.Forms.Button button_load;
        private System.Windows.Forms.Panel panel2;
        private RetailControls.NepaliCalender nepaliCalender_sales_end;
        private RetailControls.NepaliCalender nepaliCalender2;
        private RetailControls.NepaliCalender nepaliCalender_sales_start;
        private System.Windows.Forms.RadioButton radioButton_sales_billWise;
        private System.Windows.Forms.CheckBox checkBox_types;
        private System.Windows.Forms.RadioButton radioButton__sales_single;
        private System.Windows.Forms.RadioButton radioButton_sales_group;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ListBox listBox_categories;
        private System.Windows.Forms.ComboBox comboBox_sales_week;
        private System.Windows.Forms.ComboBox comboBox_sales;
        private System.Windows.Forms.Label label_totalmargin;
        private System.Windows.Forms.Label label4;
    }
}
