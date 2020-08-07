namespace RetailManagementSystem.VENDORS
{
    partial class PaidViwer
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
            this.date_lbl = new System.Windows.Forms.Label();
            this.amount_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // date_lbl
            // 
            this.date_lbl.AutoSize = true;
            this.date_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(166)))));
            this.date_lbl.Location = new System.Drawing.Point(13, 8);
            this.date_lbl.Name = "date_lbl";
            this.date_lbl.Size = new System.Drawing.Size(117, 20);
            this.date_lbl.TabIndex = 0;
            this.date_lbl.Text = "aaaaaaaaaaaa";
            this.date_lbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // amount_lbl
            // 
            this.amount_lbl.AutoSize = true;
            this.amount_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amount_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(166)))));
            this.amount_lbl.Location = new System.Drawing.Point(149, 8);
            this.amount_lbl.Name = "amount_lbl";
            this.amount_lbl.Size = new System.Drawing.Size(126, 20);
            this.amount_lbl.TabIndex = 1;
            this.amount_lbl.Text = "aaaaaaaaaaaaa";
            this.amount_lbl.Click += new System.EventHandler(this.label2_Click);
            // 
            // PaidViwer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.amount_lbl);
            this.Controls.Add(this.date_lbl);
            this.Name = "PaidViwer";
            this.Size = new System.Drawing.Size(347, 40);
            this.Load += new System.EventHandler(this.paidvender_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label date_lbl;
        public System.Windows.Forms.Label amount_lbl;

    }
}
