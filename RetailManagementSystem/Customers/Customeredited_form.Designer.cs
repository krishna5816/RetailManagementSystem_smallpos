namespace RetailManagementSystem.CUSTOMERS
{
    partial class Customeredited_form
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cusdue_txt = new cmscontrols.inttb();
            this.label3 = new System.Windows.Forms.Label();
            this.customerphoneno = new cmscontrols.inttb();
            this.cusadr = new System.Windows.Forms.Label();
            this.customeremail = new cmscontrols.bettertextbox();
            this.cusname = new System.Windows.Forms.Label();
            this.customeradress = new cmscontrols.bettertextbox();
            this.cusphn = new System.Windows.Forms.Label();
            this.customername = new cmscontrols.bettertextbox();
            this.cusemail = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
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
            this.panel1.Size = new System.Drawing.Size(431, 268);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.AutoScroll = true;
            this.panel3.Controls.Add(this.cusdue_txt);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.customerphoneno);
            this.panel3.Controls.Add(this.cusadr);
            this.panel3.Controls.Add(this.customeremail);
            this.panel3.Controls.Add(this.cusname);
            this.panel3.Controls.Add(this.customeradress);
            this.panel3.Controls.Add(this.cusphn);
            this.panel3.Controls.Add(this.customername);
            this.panel3.Controls.Add(this.cusemail);
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(166)))));
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(417, 262);
            this.panel3.TabIndex = 0;
            // 
            // cusdue_txt
            // 
            this.cusdue_txt.Location = new System.Drawing.Point(7, 235);
            this.cusdue_txt.Name = "cusdue_txt";
            this.cusdue_txt.Size = new System.Drawing.Size(410, 23);
            this.cusdue_txt.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "DUE AMOUNT";
            // 
            // customerphoneno
            // 
            this.customerphoneno.Location = new System.Drawing.Point(7, 130);
            this.customerphoneno.MaxLength = 10;
            this.customerphoneno.Name = "customerphoneno";
            this.customerphoneno.Size = new System.Drawing.Size(410, 23);
            this.customerphoneno.TabIndex = 17;
            // 
            // cusadr
            // 
            this.cusadr.AutoSize = true;
            this.cusadr.Location = new System.Drawing.Point(3, 55);
            this.cusadr.Name = "cusadr";
            this.cusadr.Size = new System.Drawing.Size(74, 17);
            this.cusadr.TabIndex = 11;
            this.cusadr.Text = "ADDRESS";
            // 
            // customeremail
            // 
            this.customeremail.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.customeremail.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.customeremail.Location = new System.Drawing.Point(7, 182);
            this.customeremail.Name = "customeremail";
            this.customeremail.Size = new System.Drawing.Size(410, 23);
            this.customeremail.TabIndex = 16;
            // 
            // cusname
            // 
            this.cusname.AutoSize = true;
            this.cusname.Location = new System.Drawing.Point(7, 3);
            this.cusname.Name = "cusname";
            this.cusname.Size = new System.Drawing.Size(47, 17);
            this.cusname.TabIndex = 10;
            this.cusname.Text = "NAME";
            // 
            // customeradress
            // 
            this.customeradress.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.customeradress.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.customeradress.Location = new System.Drawing.Point(7, 78);
            this.customeradress.Name = "customeradress";
            this.customeradress.Size = new System.Drawing.Size(410, 23);
            this.customeradress.TabIndex = 15;
            // 
            // cusphn
            // 
            this.cusphn.AutoSize = true;
            this.cusphn.Location = new System.Drawing.Point(7, 107);
            this.cusphn.Name = "cusphn";
            this.cusphn.Size = new System.Drawing.Size(83, 17);
            this.cusphn.TabIndex = 12;
            this.cusphn.Text = "PHONE-NO";
            // 
            // customername
            // 
            this.customername.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.customername.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.customername.Location = new System.Drawing.Point(7, 26);
            this.customername.Name = "customername";
            this.customername.Size = new System.Drawing.Size(410, 23);
            this.customername.TabIndex = 14;
            // 
            // cusemail
            // 
            this.cusemail.AutoSize = true;
            this.cusemail.Location = new System.Drawing.Point(7, 159);
            this.cusemail.Name = "cusemail";
            this.cusemail.Size = new System.Drawing.Size(48, 17);
            this.cusemail.TabIndex = 13;
            this.cusemail.Text = "EMAIL";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(1, 267);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(434, 58);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Teal;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(257, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(5);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.label2.Size = new System.Drawing.Size(65, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Save";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            this.label2.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            this.label2.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Teal;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(341, 14);
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
            // Customeredited_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 327);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Customeredited_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add";
            this.Load += new System.EventHandler(this.Customeredited_form_Load);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private cmscontrols.inttb customerphoneno;
        private System.Windows.Forms.Label cusadr;
        private cmscontrols.bettertextbox customeremail;
        private System.Windows.Forms.Label cusname;
        private cmscontrols.bettertextbox customeradress;
        private System.Windows.Forms.Label cusphn;
        private cmscontrols.bettertextbox customername;
        private System.Windows.Forms.Label cusemail;
        private RetailControls.NotificationMAnager notificationMAnager1;
        private cmscontrols.inttb cusdue_txt;
        private System.Windows.Forms.Label label3;
    }
}