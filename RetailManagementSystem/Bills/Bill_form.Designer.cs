namespace RetailManagementSystem.Bills_form
{
    partial class Bill_form
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.betterlistview1 = new cmscontrols.betterlistview();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.delToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.checkBox1_tax = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.return_fltb = new RetailControls.BetterTextBox();
            this.due_txt = new RetailControls.BetterTextBox();
            this.paid_txt = new RetailControls.BetterTextBox();
            this.nettotal_txt = new RetailControls.BetterTextBox();
            this.tax_txt = new RetailControls.BetterTextBox();
            this.Discount_txt = new RetailControls.BetterTextBox();
            this.Grosstotal_txt = new RetailControls.BetterTextBox();
            this.RETURN = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.materialButton2 = new RetailControls.MaterialButton();
            this.reset_btn = new RetailControls.MaterialButton();
            this.panel7 = new System.Windows.Forms.Panel();
            this.materialButton_SavenPrint = new RetailControls.MaterialButton();
            this.comboBox_item = new System.Windows.Forms.ComboBox();
            this.comboBox_customer = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.comboBox_barcode = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.floattb_wholesalerate = new RetailControls.floattb();
            this.retailrate_fltb = new RetailControls.floattb();
            this.stock_qty = new RetailControls.floattb();
            this.qty_fltb = new RetailControls.floattb();
            this.panel6 = new System.Windows.Forms.Panel();
            this.radioButton_wholesale = new System.Windows.Forms.RadioButton();
            this.materialButton1 = new RetailControls.MaterialButton();
            this.radioButton_retail = new System.Windows.Forms.RadioButton();
            this.panel9 = new System.Windows.Forms.Panel();
            this.customeradd_btn = new RetailControls.MaterialButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.notificationMAnager1 = new RetailControls.NotificationMAnager(this.components);
            this.contextMenuStrip1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Item List(F1)";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(499, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Wholesale Rate";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(392, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Sale Qty(F3)";
            // 
            // betterlistview1
            // 
            this.betterlistview1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.betterlistview1.ContextMenuStrip = this.contextMenuStrip1;
            this.betterlistview1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.betterlistview1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.betterlistview1.FullRowSelect = true;
            this.betterlistview1.GridLines = true;
            this.betterlistview1.HideSelection = false;
            this.betterlistview1.Location = new System.Drawing.Point(0, 112);
            this.betterlistview1.Name = "betterlistview1";
            this.betterlistview1.Size = new System.Drawing.Size(1101, 558);
            this.betterlistview1.TabIndex = 15;
            this.betterlistview1.UseCompatibleStateImageBehavior = false;
            this.betterlistview1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "SN";
            this.columnHeader1.Width = 48;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Particular";
            this.columnHeader2.Width = 305;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Rate";
            this.columnHeader3.Width = 82;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Discount";
            this.columnHeader4.Width = 89;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Quantity";
            this.columnHeader5.Width = 110;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Total";
            this.columnHeader6.Width = 125;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.delToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(116, 26);
            // 
            // delToolStripMenuItem
            // 
            this.delToolStripMenuItem.Name = "delToolStripMenuItem";
            this.delToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.delToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.delToolStripMenuItem.Text = "Del";
            this.delToolStripMenuItem.Click += new System.EventHandler(this.delToolStripMenuItem_Click);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(2, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 19);
            this.label7.TabIndex = 16;
            this.label7.Text = "Sub Total";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(2, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 19);
            this.label8.TabIndex = 0;
            this.label8.Text = "Flat Discount(F6)";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1, 184);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 19);
            this.label10.TabIndex = 19;
            this.label10.Text = "Net Total";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(7, 303);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 19);
            this.label11.TabIndex = 20;
            this.label11.Text = "Due";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(4, 244);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 19);
            this.label12.TabIndex = 21;
            this.label12.Text = "Paid(F7)";
            // 
            // checkBox1_tax
            // 
            this.checkBox1_tax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox1_tax.AutoSize = true;
            this.checkBox1_tax.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1_tax.Location = new System.Drawing.Point(6, 121);
            this.checkBox1_tax.Name = "checkBox1_tax";
            this.checkBox1_tax.Size = new System.Drawing.Size(55, 23);
            this.checkBox1_tax.TabIndex = 22;
            this.checkBox1_tax.Text = "Tax";
            this.checkBox1_tax.UseVisualStyleBackColor = true;
            this.checkBox1_tax.CheckedChanged += new System.EventHandler(this.checkBox1_tax_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(13, 7);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(130, 23);
            this.checkBox1.TabIndex = 31;
            this.checkBox1.Text = "Customer  List";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.return_fltb);
            this.panel3.Controls.Add(this.due_txt);
            this.panel3.Controls.Add(this.paid_txt);
            this.panel3.Controls.Add(this.nettotal_txt);
            this.panel3.Controls.Add(this.tax_txt);
            this.panel3.Controls.Add(this.Discount_txt);
            this.panel3.Controls.Add(this.Grosstotal_txt);
            this.panel3.Controls.Add(this.RETURN);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.checkBox1_tax);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(813, 112);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(288, 558);
            this.panel3.TabIndex = 0;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // return_fltb
            // 
            this.return_fltb.decVal = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.return_fltb.Enabled = false;
            this.return_fltb.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.return_fltb.intVal = 0;
            this.return_fltb.Location = new System.Drawing.Point(7, 391);
            this.return_fltb.Name = "return_fltb";
            this.return_fltb.Size = new System.Drawing.Size(269, 34);
            this.return_fltb.TabIndex = 48;
            this.return_fltb.Text = "0";
            this.return_fltb.textboxType = RetailControls.TextboxType.Decimal;
            // 
            // due_txt
            // 
            this.due_txt.decVal = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.due_txt.Enabled = false;
            this.due_txt.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.due_txt.intVal = 0;
            this.due_txt.Location = new System.Drawing.Point(6, 325);
            this.due_txt.Name = "due_txt";
            this.due_txt.Size = new System.Drawing.Size(269, 34);
            this.due_txt.TabIndex = 47;
            this.due_txt.Text = "0";
            this.due_txt.textboxType = RetailControls.TextboxType.Decimal;
            this.due_txt.TextChanged += new System.EventHandler(this.due_txt_TextChanged);
            // 
            // paid_txt
            // 
            this.paid_txt.decVal = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.paid_txt.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paid_txt.intVal = 0;
            this.paid_txt.Location = new System.Drawing.Point(6, 267);
            this.paid_txt.Name = "paid_txt";
            this.paid_txt.Size = new System.Drawing.Size(269, 34);
            this.paid_txt.TabIndex = 46;
            this.paid_txt.Text = "0";
            this.paid_txt.textboxType = RetailControls.TextboxType.Decimal;
            this.paid_txt.TextChanged += new System.EventHandler(this.paid_txt_TextChanged);
            // 
            // nettotal_txt
            // 
            this.nettotal_txt.decVal = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nettotal_txt.Enabled = false;
            this.nettotal_txt.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nettotal_txt.intVal = 0;
            this.nettotal_txt.Location = new System.Drawing.Point(6, 208);
            this.nettotal_txt.Name = "nettotal_txt";
            this.nettotal_txt.Size = new System.Drawing.Size(268, 34);
            this.nettotal_txt.TabIndex = 45;
            this.nettotal_txt.Text = "0";
            this.nettotal_txt.textboxType = RetailControls.TextboxType.Decimal;
            this.nettotal_txt.TextChanged += new System.EventHandler(this.nettotal_txt_TextChanged);
            // 
            // tax_txt
            // 
            this.tax_txt.decVal = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.tax_txt.Enabled = false;
            this.tax_txt.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tax_txt.intVal = 0;
            this.tax_txt.Location = new System.Drawing.Point(6, 148);
            this.tax_txt.Name = "tax_txt";
            this.tax_txt.Size = new System.Drawing.Size(269, 34);
            this.tax_txt.TabIndex = 44;
            this.tax_txt.Text = "0";
            this.tax_txt.textboxType = RetailControls.TextboxType.Decimal;
            this.tax_txt.TextChanged += new System.EventHandler(this.tax_txt_TextChanged);
            // 
            // Discount_txt
            // 
            this.Discount_txt.decVal = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.Discount_txt.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Discount_txt.intVal = 0;
            this.Discount_txt.Location = new System.Drawing.Point(6, 89);
            this.Discount_txt.Name = "Discount_txt";
            this.Discount_txt.Size = new System.Drawing.Size(270, 34);
            this.Discount_txt.TabIndex = 43;
            this.Discount_txt.Text = "0";
            this.Discount_txt.textboxType = RetailControls.TextboxType.Decimal;
            this.Discount_txt.TextChanged += new System.EventHandler(this.Discount_txt_TextChanged);
            // 
            // Grosstotal_txt
            // 
            this.Grosstotal_txt.decVal = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.Grosstotal_txt.Enabled = false;
            this.Grosstotal_txt.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grosstotal_txt.intVal = 0;
            this.Grosstotal_txt.Location = new System.Drawing.Point(6, 29);
            this.Grosstotal_txt.Name = "Grosstotal_txt";
            this.Grosstotal_txt.Size = new System.Drawing.Size(269, 34);
            this.Grosstotal_txt.TabIndex = 42;
            this.Grosstotal_txt.Text = "0";
            this.Grosstotal_txt.textboxType = RetailControls.TextboxType.Decimal;
            this.Grosstotal_txt.TextChanged += new System.EventHandler(this.Grosstotal_txt_TextChanged);
            // 
            // RETURN
            // 
            this.RETURN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RETURN.AutoSize = true;
            this.RETURN.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RETURN.Location = new System.Drawing.Point(5, 361);
            this.RETURN.Name = "RETURN";
            this.RETURN.Size = new System.Drawing.Size(57, 19);
            this.RETURN.TabIndex = 31;
            this.RETURN.Text = "Return";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.panel8);
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 431);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(286, 125);
            this.panel4.TabIndex = 41;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.materialButton2);
            this.panel8.Controls.Add(this.reset_btn);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(284, 52);
            this.panel8.TabIndex = 43;
            // 
            // materialButton2
            // 
            this.materialButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(166)))));
            this.materialButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButton2.Dock = System.Windows.Forms.DockStyle.Left;
            this.materialButton2.FlatAppearance.BorderSize = 0;
            this.materialButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialButton2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialButton2.ForeColor = System.Drawing.Color.White;
            this.materialButton2.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(150)))));
            this.materialButton2.HoverTextColor = System.Drawing.Color.White;
            this.materialButton2.Location = new System.Drawing.Point(0, 0);
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.Size = new System.Drawing.Size(128, 52);
            this.materialButton2.TabIndex = 4;
            this.materialButton2.Text = "Save(F8)";
            this.materialButton2.UseVisualStyleBackColor = false;
            this.materialButton2.Click += new System.EventHandler(this.materialButton2_Click);
            // 
            // reset_btn
            // 
            this.reset_btn.BackColor = System.Drawing.Color.Red;
            this.reset_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reset_btn.Dock = System.Windows.Forms.DockStyle.Right;
            this.reset_btn.FlatAppearance.BorderSize = 0;
            this.reset_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reset_btn.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset_btn.ForeColor = System.Drawing.Color.White;
            this.reset_btn.HoverColor = System.Drawing.Color.DimGray;
            this.reset_btn.HoverTextColor = System.Drawing.Color.White;
            this.reset_btn.Location = new System.Drawing.Point(155, 0);
            this.reset_btn.Name = "reset_btn";
            this.reset_btn.Size = new System.Drawing.Size(129, 52);
            this.reset_btn.TabIndex = 5;
            this.reset_btn.Text = "Reset(F10)";
            this.reset_btn.UseVisualStyleBackColor = false;
            this.reset_btn.Click += new System.EventHandler(this.materialButton3_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.materialButton_SavenPrint);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(0, 72);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(284, 51);
            this.panel7.TabIndex = 42;
            // 
            // materialButton_SavenPrint
            // 
            this.materialButton_SavenPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(166)))));
            this.materialButton_SavenPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButton_SavenPrint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialButton_SavenPrint.FlatAppearance.BorderSize = 0;
            this.materialButton_SavenPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialButton_SavenPrint.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialButton_SavenPrint.ForeColor = System.Drawing.Color.White;
            this.materialButton_SavenPrint.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(150)))));
            this.materialButton_SavenPrint.HoverTextColor = System.Drawing.Color.White;
            this.materialButton_SavenPrint.Location = new System.Drawing.Point(0, 0);
            this.materialButton_SavenPrint.Name = "materialButton_SavenPrint";
            this.materialButton_SavenPrint.Size = new System.Drawing.Size(284, 51);
            this.materialButton_SavenPrint.TabIndex = 3;
            this.materialButton_SavenPrint.Text = "Save And Print(F9)";
            this.materialButton_SavenPrint.UseVisualStyleBackColor = false;
            this.materialButton_SavenPrint.Click += new System.EventHandler(this.materialButton_SavenPrint_Click);
            // 
            // comboBox_item
            // 
            this.comboBox_item.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_item.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox_item.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_item.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_item.FormattingEnabled = true;
            this.comboBox_item.Location = new System.Drawing.Point(8, 28);
            this.comboBox_item.Name = "comboBox_item";
            this.comboBox_item.Size = new System.Drawing.Size(377, 25);
            this.comboBox_item.TabIndex = 0;
            this.comboBox_item.SelectedIndexChanged += new System.EventHandler(this.comboBox_item_SelectedIndexChanged);
            this.comboBox_item.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox_item_KeyPress);
            // 
            // comboBox_customer
            // 
            this.comboBox_customer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_customer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox_customer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_customer.Enabled = false;
            this.comboBox_customer.FormattingEnabled = true;
            this.comboBox_customer.Location = new System.Drawing.Point(8, 40);
            this.comboBox_customer.Name = "comboBox_customer";
            this.comboBox_customer.Size = new System.Drawing.Size(265, 25);
            this.comboBox_customer.TabIndex = 35;
            this.comboBox_customer.SelectedIndexChanged += new System.EventHandler(this.comboBox_customer_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(391, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 38;
            this.label1.Text = "Stock Qty";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1101, 112);
            this.panel1.TabIndex = 40;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.comboBox_barcode);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.floattb_wholesalerate);
            this.panel5.Controls.Add(this.retailrate_fltb);
            this.panel5.Controls.Add(this.stock_qty);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.qty_fltb);
            this.panel5.Controls.Add(this.comboBox_item);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.panel9);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1099, 112);
            this.panel5.TabIndex = 43;
            // 
            // comboBox_barcode
            // 
            this.comboBox_barcode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_barcode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox_barcode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_barcode.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_barcode.FormattingEnabled = true;
            this.comboBox_barcode.Location = new System.Drawing.Point(10, 76);
            this.comboBox_barcode.Name = "comboBox_barcode";
            this.comboBox_barcode.Size = new System.Drawing.Size(377, 25);
            this.comboBox_barcode.TabIndex = 1;
            this.comboBox_barcode.SelectedIndexChanged += new System.EventHandler(this.comboBox_barcode_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 17);
            this.label6.TabIndex = 42;
            this.label6.Text = "Barcode List(F2)";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(499, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 41;
            this.label2.Text = "Retail Rate";
            // 
            // floattb_wholesalerate
            // 
            this.floattb_wholesalerate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.floattb_wholesalerate.Enabled = false;
            this.floattb_wholesalerate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.floattb_wholesalerate.Location = new System.Drawing.Point(506, 74);
            this.floattb_wholesalerate.Name = "floattb_wholesalerate";
            this.floattb_wholesalerate.Size = new System.Drawing.Size(103, 27);
            this.floattb_wholesalerate.TabIndex = 42;
            this.floattb_wholesalerate.Text = "0";
            this.floattb_wholesalerate.value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // retailrate_fltb
            // 
            this.retailrate_fltb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.retailrate_fltb.Enabled = false;
            this.retailrate_fltb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retailrate_fltb.Location = new System.Drawing.Point(506, 26);
            this.retailrate_fltb.Name = "retailrate_fltb";
            this.retailrate_fltb.Size = new System.Drawing.Size(103, 27);
            this.retailrate_fltb.TabIndex = 37;
            this.retailrate_fltb.Text = "0";
            this.retailrate_fltb.value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // stock_qty
            // 
            this.stock_qty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.stock_qty.Enabled = false;
            this.stock_qty.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stock_qty.Location = new System.Drawing.Point(393, 26);
            this.stock_qty.Name = "stock_qty";
            this.stock_qty.Size = new System.Drawing.Size(107, 27);
            this.stock_qty.TabIndex = 39;
            this.stock_qty.Text = "0";
            this.stock_qty.value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // qty_fltb
            // 
            this.qty_fltb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.qty_fltb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qty_fltb.Location = new System.Drawing.Point(395, 74);
            this.qty_fltb.Name = "qty_fltb";
            this.qty_fltb.Size = new System.Drawing.Size(105, 27);
            this.qty_fltb.TabIndex = 2;
            this.qty_fltb.Text = "0";
            this.qty_fltb.value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.qty_fltb.TextChanged += new System.EventHandler(this.qty_fltb_TextChanged);
            this.qty_fltb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.qty_fltb_KeyDown);
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.radioButton_wholesale);
            this.panel6.Controls.Add(this.materialButton1);
            this.panel6.Controls.Add(this.radioButton_retail);
            this.panel6.Location = new System.Drawing.Point(618, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(199, 109);
            this.panel6.TabIndex = 43;
            // 
            // radioButton_wholesale
            // 
            this.radioButton_wholesale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton_wholesale.AutoSize = true;
            this.radioButton_wholesale.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_wholesale.Location = new System.Drawing.Point(8, 33);
            this.radioButton_wholesale.Name = "radioButton_wholesale";
            this.radioButton_wholesale.Size = new System.Drawing.Size(178, 21);
            this.radioButton_wholesale.TabIndex = 41;
            this.radioButton_wholesale.Text = "Paid Item Discount(F5)";
            this.radioButton_wholesale.UseVisualStyleBackColor = true;
            this.radioButton_wholesale.CheckedChanged += new System.EventHandler(this.radioButton_wholesale_CheckedChanged);
            // 
            // materialButton1
            // 
            this.materialButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(166)))));
            this.materialButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButton1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.materialButton1.FlatAppearance.BorderSize = 0;
            this.materialButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialButton1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialButton1.ForeColor = System.Drawing.Color.White;
            this.materialButton1.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(150)))));
            this.materialButton1.HoverTextColor = System.Drawing.Color.White;
            this.materialButton1.Location = new System.Drawing.Point(0, 70);
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.Size = new System.Drawing.Size(197, 37);
            this.materialButton1.TabIndex = 14;
            this.materialButton1.Text = "&Add To Cart";
            this.materialButton1.UseVisualStyleBackColor = false;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // radioButton_retail
            // 
            this.radioButton_retail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton_retail.AutoSize = true;
            this.radioButton_retail.Checked = true;
            this.radioButton_retail.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_retail.Location = new System.Drawing.Point(8, 3);
            this.radioButton_retail.Name = "radioButton_retail";
            this.radioButton_retail.Size = new System.Drawing.Size(123, 21);
            this.radioButton_retail.TabIndex = 0;
            this.radioButton_retail.TabStop = true;
            this.radioButton_retail.Text = "Retail Rate(F4)";
            this.radioButton_retail.UseVisualStyleBackColor = true;
            this.radioButton_retail.CheckedChanged += new System.EventHandler(this.radioButton_retail_CheckedChanged);
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.customeradd_btn);
            this.panel9.Controls.Add(this.comboBox_customer);
            this.panel9.Controls.Add(this.checkBox1);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel9.Location = new System.Drawing.Point(819, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(278, 110);
            this.panel9.TabIndex = 44;
            // 
            // customeradd_btn
            // 
            this.customeradd_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(166)))));
            this.customeradd_btn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.customeradd_btn.Enabled = false;
            this.customeradd_btn.FlatAppearance.BorderSize = 0;
            this.customeradd_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customeradd_btn.ForeColor = System.Drawing.Color.White;
            this.customeradd_btn.HoverColor = System.Drawing.Color.Empty;
            this.customeradd_btn.HoverTextColor = System.Drawing.Color.Empty;
            this.customeradd_btn.Location = new System.Drawing.Point(0, 71);
            this.customeradd_btn.Name = "customeradd_btn";
            this.customeradd_btn.Size = new System.Drawing.Size(278, 39);
            this.customeradd_btn.TabIndex = 32;
            this.customeradd_btn.Text = "Add New";
            this.customeradd_btn.UseVisualStyleBackColor = false;
            this.customeradd_btn.Click += new System.EventHandler(this.customeradd_btn_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(794, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(306, 111);
            this.panel2.TabIndex = 41;
            // 
            // Bill_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1101, 670);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.betterlistview1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(166)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Bill_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Bill_form";
            this.Load += new System.EventHandler(this.Bill_form_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private RetailControls.MaterialButton materialButton1;
        private cmscontrols.betterlistview betterlistview1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox checkBox1_tax;
        private System.Windows.Forms.CheckBox checkBox1;
        private RetailControls.MaterialButton customeradd_btn;
        private RetailControls.NotificationMAnager notificationMAnager1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label RETURN;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem delToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBox_item;
        private System.Windows.Forms.ComboBox comboBox_customer;
        private RetailControls.floattb qty_fltb;
        private RetailControls.floattb retailrate_fltb;
        private RetailControls.floattb stock_qty;
        private System.Windows.Forms.Label label1;
        private RetailControls.MaterialButton reset_btn;
        private RetailControls.MaterialButton materialButton2;
        private RetailControls.MaterialButton materialButton_SavenPrint;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private RetailControls.floattb floattb_wholesalerate;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.RadioButton radioButton_wholesale;
        private System.Windows.Forms.RadioButton radioButton_retail;
        private System.Windows.Forms.Panel panel6;
        private RetailControls.BetterTextBox return_fltb;
        private RetailControls.BetterTextBox due_txt;
        private RetailControls.BetterTextBox paid_txt;
        private RetailControls.BetterTextBox nettotal_txt;
        private RetailControls.BetterTextBox tax_txt;
        private RetailControls.BetterTextBox Discount_txt;
        private RetailControls.BetterTextBox Grosstotal_txt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox_barcode;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel9;
    }
}