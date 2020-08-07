namespace RetailManagementSystem.Expenses
{
    partial class Expencesview
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            RetailControls.NepDate nepDate1 = new RetailControls.NepDate();
            RetailControls.NepDate nepDate2 = new RetailControls.NepDate();
            this.label1 = new System.Windows.Forms.Label();
            this.exenses_combobox = new RetailControls.AdvancedCombobox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nepaliCalender1 = new RetailControls.NepaliCalender();
            this.nepaliCalender2 = new RetailControls.NepaliCalender();
            this.load_btn = new RetailControls.MaterialButton();
            this.exptotal_txt = new cmscontrols.floattb();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "EXPENCES TYPE";
            // 
            // exenses_combobox
            // 
            this.exenses_combobox.FormattingEnabled = true;
            this.exenses_combobox.Location = new System.Drawing.Point(11, 41);
            this.exenses_combobox.Name = "exenses_combobox";
            this.exenses_combobox.Size = new System.Drawing.Size(282, 24);
            this.exenses_combobox.TabIndex = 1;
            this.exenses_combobox.SelectedIndexChanged += new System.EventHandler(this.exenses_combobox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(314, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "FROM";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(555, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "TO";
            // 
            // nepaliCalender1
            // 
            nepDate1.Day = 13;
            nepDate1.Month = 4;
            nepDate1.MonthName = "Shrawn";
            nepDate1.WeekDay = 2;
            nepDate1.WeekDayName = "Monday";
            nepDate1.Year = 2076;
            this.nepaliCalender1.date = nepDate1;
            this.nepaliCalender1.DATESTAMP = 20760413;
            this.nepaliCalender1.engdate = new System.DateTime(2019, 7, 29, 0, 0, 0, 0);
            this.nepaliCalender1.Location = new System.Drawing.Point(317, 41);
            this.nepaliCalender1.Margin = new System.Windows.Forms.Padding(4);
            this.nepaliCalender1.Name = "nepaliCalender1";
            this.nepaliCalender1.Size = new System.Drawing.Size(235, 30);
            this.nepaliCalender1.TabIndex = 4;
            // 
            // nepaliCalender2
            // 
            nepDate2.Day = 13;
            nepDate2.Month = 4;
            nepDate2.MonthName = "Shrawn";
            nepDate2.WeekDay = 2;
            nepDate2.WeekDayName = "Monday";
            nepDate2.Year = 2076;
            this.nepaliCalender2.date = nepDate2;
            this.nepaliCalender2.DATESTAMP = 20760413;
            this.nepaliCalender2.engdate = new System.DateTime(2019, 7, 29, 0, 0, 0, 0);
            this.nepaliCalender2.Location = new System.Drawing.Point(556, 41);
            this.nepaliCalender2.Margin = new System.Windows.Forms.Padding(5);
            this.nepaliCalender2.Name = "nepaliCalender2";
            this.nepaliCalender2.Size = new System.Drawing.Size(236, 30);
            this.nepaliCalender2.TabIndex = 5;
            // 
            // load_btn
            // 
            this.load_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.load_btn.FlatAppearance.BorderSize = 0;
            this.load_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.load_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.load_btn.HoverColor = System.Drawing.Color.Empty;
            this.load_btn.HoverTextColor = System.Drawing.Color.Empty;
            this.load_btn.Location = new System.Drawing.Point(707, 77);
            this.load_btn.Name = "load_btn";
            this.load_btn.Size = new System.Drawing.Size(75, 23);
            this.load_btn.TabIndex = 7;
            this.load_btn.Text = "LOAD";
            this.load_btn.UseVisualStyleBackColor = false;
            this.load_btn.Click += new System.EventHandler(this.load_btn_Click);
            // 
            // exptotal_txt
            // 
            this.exptotal_txt.Location = new System.Drawing.Point(72, 391);
            this.exptotal_txt.Name = "exptotal_txt";
            this.exptotal_txt.Size = new System.Drawing.Size(205, 23);
            this.exptotal_txt.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 396);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "TOTAL";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(768, 8);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 24);
            this.label6.TabIndex = 11;
            this.label6.Text = "X";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 85);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "EXPENCES VIWER";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(11, 106);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(789, 272);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Expencesview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(804, 427);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.exptotal_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.load_btn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.nepaliCalender2);
            this.Controls.Add(this.nepaliCalender1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.exenses_combobox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(166)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Expencesview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Expencesview";
            this.Load += new System.EventHandler(this.Expencesview_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private RetailControls.AdvancedCombobox exenses_combobox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private RetailControls.NepaliCalender nepaliCalender1;
        private RetailControls.NepaliCalender nepaliCalender2;
        private RetailControls.MaterialButton load_btn;
        private cmscontrols.floattb exptotal_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
    }
}