namespace CustomControls
{
    partial class ADBS
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.nepaliCalender1 = new CustomControls.NepaliCalender();
            this.materialButton_adbs = new CustomControls.MaterialButton();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy/MM/dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(0, 39);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(222, 25);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // nepaliCalender1
            // 
            this.nepaliCalender1.BackColor = System.Drawing.Color.White;
            this.nepaliCalender1.Datestamp = 20770410;
            this.nepaliCalender1.DateTime = new System.DateTime(2020, 7, 25, 0, 0, 0, 0);
            this.nepaliCalender1.Location = new System.Drawing.Point(0, 36);
            this.nepaliCalender1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nepaliCalender1.Name = "nepaliCalender1";
            this.nepaliCalender1.Size = new System.Drawing.Size(222, 28);
            this.nepaliCalender1.TabIndex = 1;
            this.nepaliCalender1.dateChange += new CustomControls.NepaliCalender.dateChangeHandler(this.nepaliCalender1_dateChange);
            this.nepaliCalender1.Load += new System.EventHandler(this.nepaliCalender1_Load);
            // 
            // materialButton_adbs
            // 
            this.materialButton_adbs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.materialButton_adbs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButton_adbs.FlatAppearance.BorderSize = 0;
            this.materialButton_adbs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialButton_adbs.ForeColor = System.Drawing.Color.White;
            this.materialButton_adbs.Location = new System.Drawing.Point(104, 5);
            this.materialButton_adbs.Name = "materialButton_adbs";
            this.materialButton_adbs.role = 3;
            this.materialButton_adbs.Size = new System.Drawing.Size(118, 28);
            this.materialButton_adbs.TabIndex = 25;
            this.materialButton_adbs.Text = "AD";
            this.materialButton_adbs.Totext = null;
            this.materialButton_adbs.userole = true;
            this.materialButton_adbs.UseVisualStyleBackColor = false;
            this.materialButton_adbs.Click += new System.EventHandler(this.materialButton_adbs_Click);
            // 
            // ADBS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.materialButton_adbs);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.nepaliCalender1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ADBS";
            this.Size = new System.Drawing.Size(227, 68);
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialButton materialButton_adbs;
        public System.Windows.Forms.DateTimePicker dateTimePicker1;
        public NepaliCalender nepaliCalender1;
    }
}
