namespace RetailManagementSystem
{
    partial class Dashboard
    {
        public static Dashboard Instance;
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Timer Clocktimer;
            RetailControls.NepDate nepDate1 = new RetailControls.NepDate();
            this.menu_panel = new System.Windows.Forms.Panel();
            this.materialButton_salesreturn = new RetailControls.MaterialButton();
            this.add_stock = new RetailControls.MaterialButton();
            this.materialButton1 = new RetailControls.MaterialButton();
            this.reports = new RetailControls.MaterialButton();
            this.vendors_nsme = new RetailControls.MaterialButton();
            this.customer_name = new RetailControls.MaterialButton();
            this.item_name = new RetailControls.MaterialButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.materialButton_close = new RetailControls.MaterialButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.materialButton2 = new RetailControls.MaterialButton();
            this.button2 = new System.Windows.Forms.Button();
            this.nepaliCalender1 = new RetailControls.NepaliCalender();
            this.name_lbl = new System.Windows.Forms.Label();
            this.ClockLabel = new System.Windows.Forms.Label();
            this.notificationMAnager1 = new RetailControls.NotificationMAnager(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            Clocktimer = new System.Windows.Forms.Timer(this.components);
            this.menu_panel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // Clocktimer
            // 
            Clocktimer.Enabled = true;
            Clocktimer.Interval = 1000;
            Clocktimer.Tick += new System.EventHandler(this.Clocktimer_Tick);
            // 
            // menu_panel
            // 
            this.menu_panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.menu_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.menu_panel.Controls.Add(this.materialButton_salesreturn);
            this.menu_panel.Controls.Add(this.add_stock);
            this.menu_panel.Controls.Add(this.materialButton1);
            this.menu_panel.Controls.Add(this.reports);
            this.menu_panel.Controls.Add(this.vendors_nsme);
            this.menu_panel.Controls.Add(this.customer_name);
            this.menu_panel.Controls.Add(this.item_name);
            this.menu_panel.Controls.Add(this.panel1);
            this.menu_panel.ForeColor = System.Drawing.Color.White;
            this.menu_panel.Location = new System.Drawing.Point(3, 0);
            this.menu_panel.Name = "menu_panel";
            this.menu_panel.Size = new System.Drawing.Size(356, 425);
            this.menu_panel.TabIndex = 0;
            this.menu_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // materialButton_salesreturn
            // 
            this.materialButton_salesreturn.BackColor = System.Drawing.Color.White;
            this.materialButton_salesreturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButton_salesreturn.FlatAppearance.BorderSize = 0;
            this.materialButton_salesreturn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.materialButton_salesreturn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialButton_salesreturn.ForeColor = System.Drawing.Color.Black;
            this.materialButton_salesreturn.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.materialButton_salesreturn.HoverTextColor = System.Drawing.Color.Empty;
            this.materialButton_salesreturn.Location = new System.Drawing.Point(0, 230);
            this.materialButton_salesreturn.Margin = new System.Windows.Forms.Padding(0);
            this.materialButton_salesreturn.Name = "materialButton_salesreturn";
            this.materialButton_salesreturn.Size = new System.Drawing.Size(356, 30);
            this.materialButton_salesreturn.TabIndex = 13;
            this.materialButton_salesreturn.Text = "Sales Return";
            this.materialButton_salesreturn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.materialButton_salesreturn.UseVisualStyleBackColor = false;
            this.materialButton_salesreturn.Click += new System.EventHandler(this.materialButton_salesreturn_Click);
            // 
            // add_stock
            // 
            this.add_stock.BackColor = System.Drawing.Color.White;
            this.add_stock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_stock.FlatAppearance.BorderSize = 0;
            this.add_stock.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.add_stock.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_stock.ForeColor = System.Drawing.Color.Black;
            this.add_stock.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.add_stock.HoverTextColor = System.Drawing.Color.Empty;
            this.add_stock.Location = new System.Drawing.Point(0, 200);
            this.add_stock.Margin = new System.Windows.Forms.Padding(0);
            this.add_stock.Name = "add_stock";
            this.add_stock.Size = new System.Drawing.Size(356, 30);
            this.add_stock.TabIndex = 11;
            this.add_stock.Text = "Manage Stock";
            this.add_stock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.add_stock.UseVisualStyleBackColor = false;
            this.add_stock.Click += new System.EventHandler(this.materialButton2_Click_1);
            // 
            // materialButton1
            // 
            this.materialButton1.BackColor = System.Drawing.Color.White;
            this.materialButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButton1.FlatAppearance.BorderSize = 0;
            this.materialButton1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.materialButton1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialButton1.ForeColor = System.Drawing.Color.Black;
            this.materialButton1.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.materialButton1.HoverTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Location = new System.Drawing.Point(0, 170);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(0);
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.Size = new System.Drawing.Size(356, 30);
            this.materialButton1.TabIndex = 10;
            this.materialButton1.Text = "Manage Expenses";
            this.materialButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.materialButton1.UseVisualStyleBackColor = false;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click_1);
            // 
            // reports
            // 
            this.reports.BackColor = System.Drawing.Color.White;
            this.reports.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reports.FlatAppearance.BorderSize = 0;
            this.reports.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.reports.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reports.ForeColor = System.Drawing.Color.Black;
            this.reports.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.reports.HoverTextColor = System.Drawing.Color.Empty;
            this.reports.Location = new System.Drawing.Point(0, 140);
            this.reports.Margin = new System.Windows.Forms.Padding(0);
            this.reports.Name = "reports";
            this.reports.Size = new System.Drawing.Size(356, 30);
            this.reports.TabIndex = 8;
            this.reports.Text = "Reports List";
            this.reports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reports.UseVisualStyleBackColor = false;
            this.reports.Click += new System.EventHandler(this.reports_Click);
            // 
            // vendors_nsme
            // 
            this.vendors_nsme.BackColor = System.Drawing.Color.White;
            this.vendors_nsme.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vendors_nsme.FlatAppearance.BorderSize = 0;
            this.vendors_nsme.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.vendors_nsme.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vendors_nsme.ForeColor = System.Drawing.Color.Black;
            this.vendors_nsme.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.vendors_nsme.HoverTextColor = System.Drawing.Color.Empty;
            this.vendors_nsme.Location = new System.Drawing.Point(0, 110);
            this.vendors_nsme.Margin = new System.Windows.Forms.Padding(0);
            this.vendors_nsme.Name = "vendors_nsme";
            this.vendors_nsme.Size = new System.Drawing.Size(356, 30);
            this.vendors_nsme.TabIndex = 6;
            this.vendors_nsme.Text = "Manage Parties";
            this.vendors_nsme.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.vendors_nsme.UseVisualStyleBackColor = false;
            this.vendors_nsme.Click += new System.EventHandler(this.vendors_nsme_Click);
            // 
            // customer_name
            // 
            this.customer_name.BackColor = System.Drawing.Color.White;
            this.customer_name.Cursor = System.Windows.Forms.Cursors.Hand;
            this.customer_name.FlatAppearance.BorderSize = 0;
            this.customer_name.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.customer_name.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer_name.ForeColor = System.Drawing.Color.Black;
            this.customer_name.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.customer_name.HoverTextColor = System.Drawing.Color.White;
            this.customer_name.Location = new System.Drawing.Point(0, 80);
            this.customer_name.Margin = new System.Windows.Forms.Padding(0);
            this.customer_name.Name = "customer_name";
            this.customer_name.Size = new System.Drawing.Size(356, 30);
            this.customer_name.TabIndex = 2;
            this.customer_name.Text = "Manage Customers";
            this.customer_name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customer_name.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.customer_name.UseVisualStyleBackColor = false;
            this.customer_name.Click += new System.EventHandler(this.materialButton2_Click);
            // 
            // item_name
            // 
            this.item_name.BackColor = System.Drawing.Color.White;
            this.item_name.Cursor = System.Windows.Forms.Cursors.Hand;
            this.item_name.FlatAppearance.BorderSize = 0;
            this.item_name.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.item_name.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_name.ForeColor = System.Drawing.Color.Black;
            this.item_name.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.item_name.HoverTextColor = System.Drawing.Color.White;
            this.item_name.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.item_name.Location = new System.Drawing.Point(0, 50);
            this.item_name.Margin = new System.Windows.Forms.Padding(0);
            this.item_name.Name = "item_name";
            this.item_name.Size = new System.Drawing.Size(356, 30);
            this.item_name.TabIndex = 0;
            this.item_name.Text = "Manage Product";
            this.item_name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.item_name.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.item_name.UseVisualStyleBackColor = false;
            this.item_name.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(166)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.materialButton_close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(356, 50);
            this.panel1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(86, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 28);
            this.label1.TabIndex = 8;
            this.label1.Text = "Dashboard";
            // 
            // materialButton_close
            // 
            this.materialButton_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialButton_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(166)))));
            this.materialButton_close.FlatAppearance.BorderSize = 0;
            this.materialButton_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialButton_close.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialButton_close.ForeColor = System.Drawing.Color.White;
            this.materialButton_close.HoverColor = System.Drawing.Color.Empty;
            this.materialButton_close.HoverTextColor = System.Drawing.Color.Empty;
            this.materialButton_close.Location = new System.Drawing.Point(318, 2);
            this.materialButton_close.Margin = new System.Windows.Forms.Padding(0);
            this.materialButton_close.Name = "materialButton_close";
            this.materialButton_close.Size = new System.Drawing.Size(38, 44);
            this.materialButton_close.TabIndex = 13;
            this.materialButton_close.Text = "X";
            this.materialButton_close.UseVisualStyleBackColor = false;
            this.materialButton_close.Click += new System.EventHandler(this.materialButton5_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(166)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.materialButton2);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.nepaliCalender1);
            this.panel3.Controls.Add(this.name_lbl);
            this.panel3.Controls.Add(this.ClockLabel);
            this.panel3.Location = new System.Drawing.Point(0, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1007, 50);
            this.panel3.TabIndex = 2;
            // 
            // materialButton2
            // 
            this.materialButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialButton2.BackColor = System.Drawing.Color.Transparent;
            this.materialButton2.BackgroundImage = global::RetailManagementSystem.Properties.Resources.log_out_grey;
            this.materialButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.materialButton2.FlatAppearance.BorderSize = 0;
            this.materialButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialButton2.HoverColor = System.Drawing.Color.Empty;
            this.materialButton2.HoverTextColor = System.Drawing.Color.Empty;
            this.materialButton2.Location = new System.Drawing.Point(965, 6);
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.Size = new System.Drawing.Size(31, 27);
            this.materialButton2.TabIndex = 7;
            this.materialButton2.UseVisualStyleBackColor = false;
            this.materialButton2.Click += new System.EventHandler(this.materialButton2_Click_2);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(170)))));
            this.button2.BackgroundImage = global::RetailManagementSystem.Properties.Resources.menu_white;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(11, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 40);
            this.button2.TabIndex = 6;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // nepaliCalender1
            // 
            this.nepaliCalender1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            nepDate1.Day = 15;
            nepDate1.Month = 10;
            nepDate1.MonthName = "Magh";
            nepDate1.WeekDay = 5;
            nepDate1.WeekDayName = "Thursday";
            nepDate1.Year = 2077;
            this.nepaliCalender1.date = nepDate1;
            this.nepaliCalender1.DATESTAMP = 20771015;
            this.nepaliCalender1.Enabled = false;
            this.nepaliCalender1.engdate = new System.DateTime(2021, 1, 28, 0, 0, 0, 0);
            this.nepaliCalender1.Location = new System.Drawing.Point(718, 16);
            this.nepaliCalender1.Margin = new System.Windows.Forms.Padding(4);
            this.nepaliCalender1.Name = "nepaliCalender1";
            this.nepaliCalender1.Size = new System.Drawing.Size(240, 27);
            this.nepaliCalender1.TabIndex = 5;
            // 
            // name_lbl
            // 
            this.name_lbl.AutoSize = true;
            this.name_lbl.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_lbl.ForeColor = System.Drawing.Color.White;
            this.name_lbl.Location = new System.Drawing.Point(67, 12);
            this.name_lbl.Name = "name_lbl";
            this.name_lbl.Size = new System.Drawing.Size(56, 28);
            this.name_lbl.TabIndex = 3;
            this.name_lbl.Text = "Title";
            // 
            // ClockLabel
            // 
            this.ClockLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ClockLabel.AutoSize = true;
            this.ClockLabel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClockLabel.ForeColor = System.Drawing.Color.White;
            this.ClockLabel.Location = new System.Drawing.Point(870, 47);
            this.ClockLabel.Name = "ClockLabel";
            this.ClockLabel.Size = new System.Drawing.Size(76, 17);
            this.ClockLabel.TabIndex = 4;
            this.ClockLabel.Text = "HH:MM:SS";
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.menu_panel);
            this.panel4.Location = new System.Drawing.Point(0, 52);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1008, 425);
            this.panel4.TabIndex = 5;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1008, 477);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.menu_panel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menu_panel;
        private System.Windows.Forms.Panel panel3;
        private RetailControls.MaterialButton item_name;
        private RetailControls.MaterialButton customer_name;
        private System.Windows.Forms.Label ClockLabel;
        private System.Windows.Forms.Label name_lbl;
        private RetailControls.NotificationMAnager notificationMAnager1;
        private RetailControls.MaterialButton reports;
        private RetailControls.MaterialButton vendors_nsme;
        private System.Windows.Forms.Panel panel4;
        public RetailControls.NepaliCalender nepaliCalender1;
        private RetailControls.MaterialButton materialButton1;
        private RetailControls.MaterialButton add_stock;
        private System.Windows.Forms.Button button2;
        private RetailControls.MaterialButton materialButton_close;
        private RetailControls.MaterialButton materialButton2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private RetailControls.MaterialButton materialButton_salesreturn;
    }
}

