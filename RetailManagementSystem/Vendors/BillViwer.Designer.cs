namespace RetailManagementSystem.VENDORS
{
    partial class Billviwer
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
            this.bill_no_lbl = new System.Windows.Forms.Label();
            this.date_lbl = new System.Windows.Forms.Label();
            this.amount_lbl = new System.Windows.Forms.Label();
            this.due_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bill_no_lbl
            // 
            this.bill_no_lbl.AutoSize = true;
            this.bill_no_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bill_no_lbl.Location = new System.Drawing.Point(8, 10);
            this.bill_no_lbl.Name = "bill_no_lbl";
            this.bill_no_lbl.Size = new System.Drawing.Size(104, 17);
            this.bill_no_lbl.TabIndex = 0;
            this.bill_no_lbl.Text = "aaaaaaaaaaaa";
            // 
            // date_lbl
            // 
            this.date_lbl.AutoSize = true;
            this.date_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_lbl.Location = new System.Drawing.Point(120, 10);
            this.date_lbl.Name = "date_lbl";
            this.date_lbl.Size = new System.Drawing.Size(104, 17);
            this.date_lbl.TabIndex = 1;
            this.date_lbl.Text = "aaaaaaaaaaaa";
            // 
            // amount_lbl
            // 
            this.amount_lbl.AutoSize = true;
            this.amount_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amount_lbl.Location = new System.Drawing.Point(230, 10);
            this.amount_lbl.Name = "amount_lbl";
            this.amount_lbl.Size = new System.Drawing.Size(104, 17);
            this.amount_lbl.TabIndex = 2;
            this.amount_lbl.Text = "aaaaaaaaaaaa";
            // 
            // due_lbl
            // 
            this.due_lbl.AutoSize = true;
            this.due_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.due_lbl.Location = new System.Drawing.Point(341, 10);
            this.due_lbl.Name = "due_lbl";
            this.due_lbl.Size = new System.Drawing.Size(104, 17);
            this.due_lbl.TabIndex = 3;
            this.due_lbl.Text = "aaaaaaaaaaaa";
            // 
            // Billviwer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.due_lbl);
            this.Controls.Add(this.amount_lbl);
            this.Controls.Add(this.date_lbl);
            this.Controls.Add(this.bill_no_lbl);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(166)))));
            this.Name = "Billviwer";
            this.Size = new System.Drawing.Size(559, 40);
            this.Load += new System.EventHandler(this.Billviwer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label bill_no_lbl;
        public System.Windows.Forms.Label date_lbl;
        public System.Windows.Forms.Label amount_lbl;
        public System.Windows.Forms.Label due_lbl;

    }
}
