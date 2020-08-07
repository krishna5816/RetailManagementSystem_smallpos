namespace RetailManagementSystem.CUSTOMERS
{
    partial class Duepaids
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.materialButton3 = new RetailControls.MaterialButton();
            this.betterListView1 = new RetailControls.BetterListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.materialButton3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(766, 37);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 19);
            this.label1.TabIndex = 13;
            this.label1.Text = "Due Paid Info";
            // 
            // materialButton3
            // 
            this.materialButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialButton3.FlatAppearance.BorderSize = 0;
            this.materialButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialButton3.ForeColor = System.Drawing.Color.White;
            this.materialButton3.HoverColor = System.Drawing.Color.Empty;
            this.materialButton3.HoverTextColor = System.Drawing.Color.Empty;
            this.materialButton3.Location = new System.Drawing.Point(735, 6);
            this.materialButton3.Name = "materialButton3";
            this.materialButton3.Size = new System.Drawing.Size(23, 23);
            this.materialButton3.TabIndex = 12;
            this.materialButton3.Text = "X";
            this.materialButton3.UseVisualStyleBackColor = true;
            this.materialButton3.Click += new System.EventHandler(this.materialButton3_Click);
            // 
            // betterListView1
            // 
            this.betterListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.betterListView1.FullRowSelect = true;
            this.betterListView1.GridLines = true;
            this.betterListView1.HideSelection = false;
            this.betterListView1.Location = new System.Drawing.Point(3, 40);
            this.betterListView1.MultiSelect = false;
            this.betterListView1.Name = "betterListView1";
            this.betterListView1.Size = new System.Drawing.Size(759, 415);
            this.betterListView1.TabIndex = 1;
            this.betterListView1.UseCompatibleStateImageBehavior = false;
            this.betterListView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Amount";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Date";
            this.columnHeader2.Width = 200;
            // 
            // Duepaids
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(766, 459);
            this.Controls.Add(this.betterListView1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Duepaids";
            this.Text = "Duepaids";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private RetailControls.MaterialButton materialButton3;
        private RetailControls.BetterListView betterListView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}