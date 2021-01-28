namespace RetailManagementSystem.REPORTS
{
    partial class ReportsList
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
            this.lvl_close = new System.Windows.Forms.Label();
            this.tabControl_expense = new System.Windows.Forms.TabControl();
            this.tabPage_sales = new System.Windows.Forms.TabPage();
            this.tabPage_purchase = new System.Windows.Forms.TabPage();
            this.tabPage_Expense = new System.Windows.Forms.TabPage();
            this.tabControl_expense.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvl_close
            // 
            this.lvl_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lvl_close.AutoSize = true;
            this.lvl_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvl_close.Location = new System.Drawing.Point(948, 9);
            this.lvl_close.Name = "lvl_close";
            this.lvl_close.Size = new System.Drawing.Size(32, 31);
            this.lvl_close.TabIndex = 26;
            this.lvl_close.Text = "X";
            this.lvl_close.Click += new System.EventHandler(this.lvl_close_Click);
            // 
            // tabControl_expense
            // 
            this.tabControl_expense.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl_expense.Controls.Add(this.tabPage_sales);
            this.tabControl_expense.Controls.Add(this.tabPage_purchase);
            this.tabControl_expense.Controls.Add(this.tabPage_Expense);
            this.tabControl_expense.Location = new System.Drawing.Point(3, 48);
            this.tabControl_expense.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl_expense.Name = "tabControl_expense";
            this.tabControl_expense.SelectedIndex = 0;
            this.tabControl_expense.Size = new System.Drawing.Size(988, 635);
            this.tabControl_expense.TabIndex = 27;
            // 
            // tabPage_sales
            // 
            this.tabPage_sales.Location = new System.Drawing.Point(4, 26);
            this.tabPage_sales.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage_sales.Name = "tabPage_sales";
            this.tabPage_sales.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage_sales.Size = new System.Drawing.Size(980, 605);
            this.tabPage_sales.TabIndex = 0;
            this.tabPage_sales.Text = "Sales Report";
            this.tabPage_sales.UseVisualStyleBackColor = true;
            // 
            // tabPage_purchase
            // 
            this.tabPage_purchase.Location = new System.Drawing.Point(4, 26);
            this.tabPage_purchase.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage_purchase.Name = "tabPage_purchase";
            this.tabPage_purchase.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage_purchase.Size = new System.Drawing.Size(980, 605);
            this.tabPage_purchase.TabIndex = 1;
            this.tabPage_purchase.Text = "Purchase Report";
            this.tabPage_purchase.UseVisualStyleBackColor = true;
            // 
            // tabPage_Expense
            // 
            this.tabPage_Expense.Location = new System.Drawing.Point(4, 26);
            this.tabPage_Expense.Name = "tabPage_Expense";
            this.tabPage_Expense.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Expense.Size = new System.Drawing.Size(980, 605);
            this.tabPage_Expense.TabIndex = 2;
            this.tabPage_Expense.Text = "Expense Report";
            this.tabPage_Expense.UseVisualStyleBackColor = true;
            // 
            // ReportsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(993, 687);
            this.Controls.Add(this.tabControl_expense);
            this.Controls.Add(this.lvl_close);
            this.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(166)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ReportsList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ReportsList_Load);
            this.tabControl_expense.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lvl_close;
        private System.Windows.Forms.TabControl tabControl_expense;
        private System.Windows.Forms.TabPage tabPage_sales;
        private System.Windows.Forms.TabPage tabPage_purchase;
        private System.Windows.Forms.TabPage tabPage_Expense;
    }
}