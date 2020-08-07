namespace RetailManagementSystem.EMPLOYEES
{
    partial class Employees_Add
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
            this.components = new System.ComponentModel.Container();
            RetailControls.NepDate nepDate1 = new RetailControls.NepDate();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.EmpDocument = new RetailControls.DocumentsLoader();
            this.nepaliCalender2EmpsrtDate = new RetailControls.NepaliCalender();
            this.label12 = new System.Windows.Forms.Label();
            this.EmpSalary = new cmscontrols.floattb();
            this.EmpEmail = new cmscontrols.bettertextbox();
            this.EmpPhn = new cmscontrols.inttb();
            this.EmpAdr = new cmscontrols.bettertextbox();
            this.EmpName = new cmscontrols.bettertextbox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.EmpImage = new RetailControls.ImageLoader();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.panel2 = new System.Windows.Forms.Panel();
            this.empsavebtn = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.notificationMAnager1 = new RetailControls.NotificationMAnager(this.components);
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(396, 396);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.AutoScroll = true;
            this.panel3.Controls.Add(this.EmpDocument);
            this.panel3.Controls.Add(this.nepaliCalender2EmpsrtDate);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.EmpSalary);
            this.panel3.Controls.Add(this.EmpEmail);
            this.panel3.Controls.Add(this.EmpPhn);
            this.panel3.Controls.Add(this.EmpAdr);
            this.panel3.Controls.Add(this.EmpName);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.EmpImage);
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(166)))));
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(393, 382);
            this.panel3.TabIndex = 0;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // EmpDocument
            // 
            this.EmpDocument.BackColor = System.Drawing.Color.White;
            this.EmpDocument.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(166)))));
            this.EmpDocument.Location = new System.Drawing.Point(6, 675);
            this.EmpDocument.Margin = new System.Windows.Forms.Padding(4);
            this.EmpDocument.MinimumSize = new System.Drawing.Size(320, 322);
            this.EmpDocument.Name = "EmpDocument";
            this.EmpDocument.Size = new System.Drawing.Size(355, 322);
            this.EmpDocument.TabIndex = 24;
            this.EmpDocument.Load += new System.EventHandler(this.documentsLoader1_Load);
            // 
            // nepaliCalender2EmpsrtDate
            // 
            nepDate1.Day = 25;
            nepDate1.Month = 9;
            nepDate1.MonthName = "Poush";
            nepDate1.WeekDay = 6;
            nepDate1.WeekDayName = "Friday";
            nepDate1.Year = 2076;
            this.nepaliCalender2EmpsrtDate.date = nepDate1;
            this.nepaliCalender2EmpsrtDate.DATESTAMP = 20760925;
            this.nepaliCalender2EmpsrtDate.engdate = new System.DateTime(2020, 1, 10, 0, 0, 0, 0);
            this.nepaliCalender2EmpsrtDate.Location = new System.Drawing.Point(4, 259);
            this.nepaliCalender2EmpsrtDate.Margin = new System.Windows.Forms.Padding(5);
            this.nepaliCalender2EmpsrtDate.Name = "nepaliCalender2EmpsrtDate";
            this.nepaliCalender2EmpsrtDate.Size = new System.Drawing.Size(277, 27);
            this.nepaliCalender2EmpsrtDate.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(2, 237);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 17);
            this.label12.TabIndex = 17;
            this.label12.Text = "START DATE";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // EmpSalary
            // 
            this.EmpSalary.Location = new System.Drawing.Point(3, 211);
            this.EmpSalary.Name = "EmpSalary";
            this.EmpSalary.Size = new System.Drawing.Size(356, 23);
            this.EmpSalary.TabIndex = 16;
            // 
            // EmpEmail
            // 
            this.EmpEmail.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.EmpEmail.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.EmpEmail.Location = new System.Drawing.Point(3, 165);
            this.EmpEmail.Name = "EmpEmail";
            this.EmpEmail.Size = new System.Drawing.Size(356, 23);
            this.EmpEmail.TabIndex = 12;
            // 
            // EmpPhn
            // 
            this.EmpPhn.Location = new System.Drawing.Point(3, 118);
            this.EmpPhn.MaxLength = 10;
            this.EmpPhn.Name = "EmpPhn";
            this.EmpPhn.Size = new System.Drawing.Size(356, 23);
            this.EmpPhn.TabIndex = 10;
            // 
            // EmpAdr
            // 
            this.EmpAdr.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.EmpAdr.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.EmpAdr.Location = new System.Drawing.Point(3, 68);
            this.EmpAdr.Name = "EmpAdr";
            this.EmpAdr.Size = new System.Drawing.Size(356, 23);
            this.EmpAdr.TabIndex = 9;
            // 
            // EmpName
            // 
            this.EmpName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.EmpName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.EmpName.Location = new System.Drawing.Point(3, 22);
            this.EmpName.Name = "EmpName";
            this.EmpName.Size = new System.Drawing.Size(356, 23);
            this.EmpName.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 191);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 17);
            this.label9.TabIndex = 6;
            this.label9.Text = "SALARY";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 654);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 17);
            this.label8.TabIndex = 5;
            this.label8.Text = "DOCUMENTS";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 295);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 17);
            this.label7.TabIndex = 4;
            this.label7.Text = "PHOTO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "EMAIL";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "PHONE NO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "ADDRESS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "NAME";
            // 
            // EmpImage
            // 
            this.EmpImage.BackColor = System.Drawing.Color.White;
            this.EmpImage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(166)))));
            this.EmpImage.image = null;
            this.EmpImage.ImageLoc = null;
            this.EmpImage.Location = new System.Drawing.Point(6, 318);
            this.EmpImage.Margin = new System.Windows.Forms.Padding(4);
            this.EmpImage.MinimumSize = new System.Drawing.Size(319, 322);
            this.EmpImage.Name = "EmpImage";
            this.EmpImage.Size = new System.Drawing.Size(363, 322);
            this.EmpImage.TabIndex = 23;
            this.EmpImage.Load += new System.EventHandler(this.imageLoader1_Load);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.empsavebtn);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(2, 399);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(393, 58);
            this.panel2.TabIndex = 1;
            // 
            // empsavebtn
            // 
            this.empsavebtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.empsavebtn.AutoSize = true;
            this.empsavebtn.BackColor = System.Drawing.Color.Teal;
            this.empsavebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.empsavebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empsavebtn.Location = new System.Drawing.Point(216, 14);
            this.empsavebtn.Margin = new System.Windows.Forms.Padding(5);
            this.empsavebtn.Name = "empsavebtn";
            this.empsavebtn.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.empsavebtn.Size = new System.Drawing.Size(65, 30);
            this.empsavebtn.TabIndex = 1;
            this.empsavebtn.Text = "Save";
            this.empsavebtn.Click += new System.EventHandler(this.label2_Click_1);
            this.empsavebtn.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            this.empsavebtn.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Teal;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(300, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(5);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.label1.Size = new System.Drawing.Size(78, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cancel";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            this.label1.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            this.label1.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
            // 
            // Employees_Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 458);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Employees_Add";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add";
            this.Load += new System.EventHandler(this.Add_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label empsavebtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private cmscontrols.bettertextbox EmpEmail;
        private cmscontrols.inttb EmpPhn;
        private cmscontrols.bettertextbox EmpAdr;
        private cmscontrols.bettertextbox EmpName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private cmscontrols.floattb EmpSalary;
        private RetailControls.NepaliCalender nepaliCalender2EmpsrtDate;
        private System.Windows.Forms.Label label8;
        private RetailControls.ImageLoader EmpImage;
        private RetailControls.DocumentsLoader EmpDocument;
        private RetailControls.NotificationMAnager notificationMAnager1;
    }
}