namespace RetailManagementSystem.SalesReturns
{
    partial class Salesreturn
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
            this.materialButton_load = new RetailControls.MaterialButton();
            this.betterListView1 = new RetailControls.BetterListView();
            this.f7 = new System.Windows.Forms.Panel();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.invoicenumber = new RetailControls.floattb();
            this.f7.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialButton_load
            // 
            this.materialButton_load.BackColor = System.Drawing.Color.Blue;
            this.materialButton_load.FlatAppearance.BorderSize = 0;
            this.materialButton_load.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialButton_load.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialButton_load.ForeColor = System.Drawing.Color.White;
            this.materialButton_load.HoverColor = System.Drawing.Color.Empty;
            this.materialButton_load.HoverTextColor = System.Drawing.Color.Empty;
            this.materialButton_load.Location = new System.Drawing.Point(265, 44);
            this.materialButton_load.Name = "materialButton_load";
            this.materialButton_load.Size = new System.Drawing.Size(75, 30);
            this.materialButton_load.TabIndex = 1;
            this.materialButton_load.Text = "Load";
            this.materialButton_load.UseVisualStyleBackColor = false;
            this.materialButton_load.Click += new System.EventHandler(this.materialButton_load_Click);
            // 
            // betterListView1
            // 
            this.betterListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.betterListView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.betterListView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.betterListView1.FullRowSelect = true;
            this.betterListView1.GridLines = true;
            this.betterListView1.HideSelection = false;
            this.betterListView1.Location = new System.Drawing.Point(0, 84);
            this.betterListView1.MultiSelect = false;
            this.betterListView1.Name = "betterListView1";
            this.betterListView1.Size = new System.Drawing.Size(808, 366);
            this.betterListView1.TabIndex = 2;
            this.betterListView1.UseCompatibleStateImageBehavior = false;
            this.betterListView1.View = System.Windows.Forms.View.Details;
            // 
            // f7
            // 
            this.f7.Controls.Add(this.invoicenumber);
            this.f7.Controls.Add(this.label1);
            this.f7.Controls.Add(this.materialButton_load);
            this.f7.Dock = System.Windows.Forms.DockStyle.Top;
            this.f7.Location = new System.Drawing.Point(0, 0);
            this.f7.Name = "f7";
            this.f7.Size = new System.Drawing.Size(808, 84);
            this.f7.TabIndex = 3;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "S.N.";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Date";
            this.columnHeader2.Width = 166;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Item Name";
            this.columnHeader3.Width = 164;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Qty";
            this.columnHeader4.Width = 102;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Rate";
            this.columnHeader5.Width = 87;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Discount";
            this.columnHeader6.Width = 79;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Invoice No.";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Total";
            this.columnHeader7.Width = 110;
            // 
            // invoicenumber
            // 
            this.invoicenumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invoicenumber.Location = new System.Drawing.Point(92, 49);
            this.invoicenumber.Name = "invoicenumber";
            this.invoicenumber.Size = new System.Drawing.Size(167, 23);
            this.invoicenumber.TabIndex = 10;
            this.invoicenumber.Text = "0";
            this.invoicenumber.value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // Salesreturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(808, 450);
            this.Controls.Add(this.betterListView1);
            this.Controls.Add(this.f7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Salesreturn";
            this.Text = "Salesreturn";
            this.Load += new System.EventHandler(this.Salesreturn_Load);
            this.f7.ResumeLayout(false);
            this.f7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private RetailControls.MaterialButton materialButton_load;
        private RetailControls.BetterListView betterListView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Panel f7;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Label label1;
        private RetailControls.floattb invoicenumber;
    }
}