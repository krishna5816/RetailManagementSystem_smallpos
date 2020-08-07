namespace RetailManagementSystem.EMPLOYEES
{
    partial class SalaryViwer
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
            this.materialButton1_delete = new RetailControls.MaterialButton();
            this.startdate = new System.Windows.Forms.Label();
            this.lastdate = new System.Windows.Forms.Label();
            this.amount = new System.Windows.Forms.Label();
            this.date1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // materialButton1_delete
            // 
            this.materialButton1_delete.BackgroundImage = global::RetailManagementSystem.Properties.Resources.delete;
            this.materialButton1_delete.FlatAppearance.BorderSize = 0;
            this.materialButton1_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialButton1_delete.HoverColor = System.Drawing.Color.Empty;
            this.materialButton1_delete.HoverTextColor = System.Drawing.Color.Empty;
            this.materialButton1_delete.Location = new System.Drawing.Point(477, 1);
            this.materialButton1_delete.Name = "materialButton1_delete";
            this.materialButton1_delete.Size = new System.Drawing.Size(30, 30);
            this.materialButton1_delete.TabIndex = 1;
            this.materialButton1_delete.UseVisualStyleBackColor = true;
            this.materialButton1_delete.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // startdate
            // 
            this.startdate.AutoSize = true;
            this.startdate.Location = new System.Drawing.Point(108, 8);
            this.startdate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.startdate.Name = "startdate";
            this.startdate.Size = new System.Drawing.Size(96, 17);
            this.startdate.TabIndex = 2;
            this.startdate.Text = "aaaaaaaaaaa";
            // 
            // lastdate
            // 
            this.lastdate.AutoSize = true;
            this.lastdate.Location = new System.Drawing.Point(230, 8);
            this.lastdate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lastdate.Name = "lastdate";
            this.lastdate.Size = new System.Drawing.Size(96, 17);
            this.lastdate.TabIndex = 3;
            this.lastdate.Text = "aaaaaaaaaaa";
            // 
            // amount
            // 
            this.amount.AutoSize = true;
            this.amount.Location = new System.Drawing.Point(334, 8);
            this.amount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(88, 17);
            this.amount.TabIndex = 4;
            this.amount.Text = "aaaaaaaaaa";
            // 
            // date1
            // 
            this.date1.AutoSize = true;
            this.date1.Location = new System.Drawing.Point(4, 8);
            this.date1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.date1.Name = "date1";
            this.date1.Size = new System.Drawing.Size(96, 17);
            this.date1.TabIndex = 5;
            this.date1.Text = "aaaaaaaaaaa";
            // 
            // SalaryViwer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.date1);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.lastdate);
            this.Controls.Add(this.startdate);
            this.Controls.Add(this.materialButton1_delete);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(166)))));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SalaryViwer";
            this.Size = new System.Drawing.Size(542, 41);
            this.Load += new System.EventHandler(this.SalaryViwer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RetailControls.MaterialButton materialButton1_delete;
        private System.Windows.Forms.Label startdate;
        private System.Windows.Forms.Label lastdate;
        private System.Windows.Forms.Label amount;
        private System.Windows.Forms.Label date1;
    }
}
