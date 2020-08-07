namespace RetailManagementSystem.EMPLOYEES
{
    partial class AdvanceViwer
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
            this.AdvanceAmount = new System.Windows.Forms.Label();
            this.advancepaiddate = new System.Windows.Forms.Label();
            this.materialButton1 = new RetailControls.MaterialButton();
            this.SuspendLayout();
            // 
            // AdvanceAmount
            // 
            this.AdvanceAmount.AutoSize = true;
            this.AdvanceAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(166)))));
            this.AdvanceAmount.Location = new System.Drawing.Point(12, 14);
            this.AdvanceAmount.Name = "AdvanceAmount";
            this.AdvanceAmount.Size = new System.Drawing.Size(79, 13);
            this.AdvanceAmount.TabIndex = 0;
            this.AdvanceAmount.Text = "aaaaaaaaaaaa";
            // 
            // advancepaiddate
            // 
            this.advancepaiddate.AutoSize = true;
            this.advancepaiddate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(166)))));
            this.advancepaiddate.Location = new System.Drawing.Point(120, 13);
            this.advancepaiddate.Name = "advancepaiddate";
            this.advancepaiddate.Size = new System.Drawing.Size(79, 13);
            this.advancepaiddate.TabIndex = 1;
            this.advancepaiddate.Text = "aaaaaaaaaaaa";
            // 
            // materialButton1
            // 
            this.materialButton1.BackgroundImage = global::RetailManagementSystem.Properties.Resources.delete;
            this.materialButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.materialButton1.FlatAppearance.BorderSize = 0;
            this.materialButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialButton1.HoverColor = System.Drawing.Color.Empty;
            this.materialButton1.HoverTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Location = new System.Drawing.Point(266, 7);
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.Size = new System.Drawing.Size(28, 30);
            this.materialButton1.TabIndex = 2;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // AdvanceViwer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.materialButton1);
            this.Controls.Add(this.advancepaiddate);
            this.Controls.Add(this.AdvanceAmount);
            this.Name = "AdvanceViwer";
            this.Size = new System.Drawing.Size(328, 40);
            this.Load += new System.EventHandler(this.AdvanceViwer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AdvanceAmount;
        private System.Windows.Forms.Label advancepaiddate;
        private RetailControls.MaterialButton materialButton1;
    }
}
