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
            this.components = new System.ComponentModel.Container();
            this.f7 = new System.Windows.Forms.Panel();
            this.materialButton_load = new CustomControls.MaterialButton();
            this.invoicenumber_text = new CustomControls.BetterTextBox();
            this.close_btn = new RetailControls.MaterialButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.materialButton1 = new CustomControls.MaterialButton();
            this.betterTextBox_discount = new CustomControls.BetterTextBox();
            this.betterTextBox_total = new CustomControls.BetterTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.betterListView_salesreturn = new CustomControls.BetterListView();
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.f7.SuspendLayout();
            this.panel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // f7
            // 
            this.f7.Controls.Add(this.materialButton_load);
            this.f7.Controls.Add(this.invoicenumber_text);
            this.f7.Controls.Add(this.close_btn);
            this.f7.Controls.Add(this.label4);
            this.f7.Controls.Add(this.label1);
            this.f7.Dock = System.Windows.Forms.DockStyle.Top;
            this.f7.Location = new System.Drawing.Point(0, 0);
            this.f7.Name = "f7";
            this.f7.Size = new System.Drawing.Size(683, 84);
            this.f7.TabIndex = 3;
            // 
            // materialButton_load
            // 
            this.materialButton_load.BackColor = System.Drawing.Color.Blue;
            this.materialButton_load.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButton_load.FlatAppearance.BorderSize = 0;
            this.materialButton_load.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialButton_load.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialButton_load.ForeColor = System.Drawing.Color.White;
            this.materialButton_load.Location = new System.Drawing.Point(326, 43);
            this.materialButton_load.Name = "materialButton_load";
            this.materialButton_load.role = 0;
            this.materialButton_load.Size = new System.Drawing.Size(106, 31);
            this.materialButton_load.TabIndex = 57;
            this.materialButton_load.Text = "Load";
            this.materialButton_load.Totext = null;
            this.materialButton_load.userole = false;
            this.materialButton_load.UseVisualStyleBackColor = false;
            this.materialButton_load.Click += new System.EventHandler(this.materialButton2_Click);
            // 
            // invoicenumber_text
            // 
            this.invoicenumber_text.append = "";
            this.invoicenumber_text.decVal = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.invoicenumber_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invoicenumber_text.intVal = 0;
            this.invoicenumber_text.Location = new System.Drawing.Point(106, 45);
            this.invoicenumber_text.Name = "invoicenumber_text";
            this.invoicenumber_text.prepend = "";
            this.invoicenumber_text.Rules = null;
            this.invoicenumber_text.Size = new System.Drawing.Size(211, 30);
            this.invoicenumber_text.TabIndex = 56;
            this.invoicenumber_text.textboxType = CustomControls.TextboxType.Integer;
            // 
            // close_btn
            // 
            this.close_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.close_btn.BackgroundImage = global::RetailManagementSystem.Properties.Resources.close;
            this.close_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.close_btn.FlatAppearance.BorderSize = 0;
            this.close_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close_btn.HoverColor = System.Drawing.Color.Empty;
            this.close_btn.HoverTextColor = System.Drawing.Color.Empty;
            this.close_btn.Location = new System.Drawing.Point(638, 5);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(33, 34);
            this.close_btn.TabIndex = 55;
            this.close_btn.UseVisualStyleBackColor = true;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(242, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Sales Return";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Invoice No.";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.materialButton1);
            this.panel1.Controls.Add(this.betterTextBox_discount);
            this.panel1.Controls.Add(this.betterTextBox_total);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 374);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(683, 76);
            this.panel1.TabIndex = 4;
            // 
            // materialButton1
            // 
            this.materialButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialButton1.BackColor = System.Drawing.Color.Blue;
            this.materialButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButton1.FlatAppearance.BorderSize = 0;
            this.materialButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialButton1.ForeColor = System.Drawing.Color.White;
            this.materialButton1.Location = new System.Drawing.Point(517, 21);
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.role = 0;
            this.materialButton1.Size = new System.Drawing.Size(154, 40);
            this.materialButton1.TabIndex = 17;
            this.materialButton1.Text = " Save and Print";
            this.materialButton1.Totext = null;
            this.materialButton1.userole = false;
            this.materialButton1.UseVisualStyleBackColor = false;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click_1);
            // 
            // betterTextBox_discount
            // 
            this.betterTextBox_discount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.betterTextBox_discount.append = "";
            this.betterTextBox_discount.decVal = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.betterTextBox_discount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.betterTextBox_discount.intVal = 0;
            this.betterTextBox_discount.Location = new System.Drawing.Point(196, 31);
            this.betterTextBox_discount.Name = "betterTextBox_discount";
            this.betterTextBox_discount.prepend = "";
            this.betterTextBox_discount.Rules = null;
            this.betterTextBox_discount.Size = new System.Drawing.Size(160, 30);
            this.betterTextBox_discount.TabIndex = 16;
            this.betterTextBox_discount.Text = "0";
            this.betterTextBox_discount.textboxType = CustomControls.TextboxType.Decimal;
            // 
            // betterTextBox_total
            // 
            this.betterTextBox_total.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.betterTextBox_total.append = "";
            this.betterTextBox_total.decVal = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.betterTextBox_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.betterTextBox_total.intVal = 0;
            this.betterTextBox_total.Location = new System.Drawing.Point(369, 31);
            this.betterTextBox_total.Name = "betterTextBox_total";
            this.betterTextBox_total.prepend = "";
            this.betterTextBox_total.Rules = null;
            this.betterTextBox_total.Size = new System.Drawing.Size(144, 30);
            this.betterTextBox_total.TabIndex = 15;
            this.betterTextBox_total.Text = "0";
            this.betterTextBox_total.textboxType = CustomControls.TextboxType.Decimal;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(365, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Total";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(192, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Discount";
            // 
            // betterListView_salesreturn
            // 
            this.betterListView_salesreturn.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader15});
            this.betterListView_salesreturn.ContextMenuStrip = this.contextMenuStrip1;
            this.betterListView_salesreturn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.betterListView_salesreturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.betterListView_salesreturn.FullRowSelect = true;
            this.betterListView_salesreturn.GridLines = true;
            this.betterListView_salesreturn.HideSelection = false;
            this.betterListView_salesreturn.Location = new System.Drawing.Point(0, 84);
            this.betterListView_salesreturn.Name = "betterListView_salesreturn";
            this.betterListView_salesreturn.Size = new System.Drawing.Size(683, 290);
            this.betterListView_salesreturn.sortable = false;
            this.betterListView_salesreturn.TabIndex = 5;
            this.betterListView_salesreturn.UseCompatibleStateImageBehavior = false;
            this.betterListView_salesreturn.View = System.Windows.Forms.View.Details;
            this.betterListView_salesreturn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.betterListView_salesreturn_KeyDown);
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "S.N.";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Date";
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Item Name";
            this.columnHeader10.Width = 120;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Qty";
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Rate";
            this.columnHeader12.Width = 90;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Discount";
            this.columnHeader13.Width = 122;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Total";
            this.columnHeader15.Width = 208;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(108, 26);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // Salesreturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(683, 450);
            this.Controls.Add(this.betterListView_salesreturn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.f7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Salesreturn";
            this.Text = "Salesreturn";
            this.Load += new System.EventHandler(this.Salesreturn_Load);
            this.f7.ResumeLayout(false);
            this.f7.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel f7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private RetailControls.MaterialButton close_btn;
        private CustomControls.BetterTextBox betterTextBox_discount;
        private CustomControls.BetterTextBox betterTextBox_total;
        private CustomControls.MaterialButton materialButton1;
        private CustomControls.BetterTextBox invoicenumber_text;
        private CustomControls.BetterListView betterListView_salesreturn;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private CustomControls.MaterialButton materialButton_load;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}