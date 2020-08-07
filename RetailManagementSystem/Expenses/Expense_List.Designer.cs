namespace RetailManagementSystem.Expenses
{
    partial class Expense_List
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
            this.SearchBtn = new RetailControls.MaterialButton();
            this.materialButton5 = new RetailControls.MaterialButton();
            this.materialButton2 = new RetailControls.MaterialButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.search_txt = new System.Windows.Forms.TextBox();
            this.employee_name = new RetailControls.MaterialButton();
            this.cat_loader = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(166)))));
            this.panel1.Controls.Add(this.SearchBtn);
            this.panel1.Controls.Add(this.materialButton5);
            this.panel1.Controls.Add(this.materialButton2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.employee_name);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(926, 100);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // SearchBtn
            // 
            this.SearchBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(166)))));
            this.SearchBtn.BackgroundImage = global::RetailManagementSystem.Properties.Resources.search_grey;
            this.SearchBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SearchBtn.FlatAppearance.BorderSize = 0;
            this.SearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchBtn.ForeColor = System.Drawing.Color.Black;
            this.SearchBtn.HoverColor = System.Drawing.Color.Empty;
            this.SearchBtn.HoverTextColor = System.Drawing.Color.Empty;
            this.SearchBtn.Location = new System.Drawing.Point(889, 51);
            this.SearchBtn.Margin = new System.Windows.Forms.Padding(0);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(32, 32);
            this.SearchBtn.TabIndex = 13;
            this.SearchBtn.UseVisualStyleBackColor = false;
            // 
            // materialButton5
            // 
            this.materialButton5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialButton5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(166)))));
            this.materialButton5.FlatAppearance.BorderSize = 0;
            this.materialButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialButton5.ForeColor = System.Drawing.Color.White;
            this.materialButton5.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(150)))));
            this.materialButton5.HoverTextColor = System.Drawing.Color.Empty;
            this.materialButton5.Location = new System.Drawing.Point(896, 7);
            this.materialButton5.Margin = new System.Windows.Forms.Padding(0);
            this.materialButton5.Name = "materialButton5";
            this.materialButton5.Size = new System.Drawing.Size(29, 26);
            this.materialButton5.TabIndex = 12;
            this.materialButton5.Text = "X";
            this.materialButton5.UseVisualStyleBackColor = false;
            this.materialButton5.Click += new System.EventHandler(this.materialButton5_Click);
            // 
            // materialButton2
            // 
            this.materialButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButton2.FlatAppearance.BorderSize = 0;
            this.materialButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialButton2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialButton2.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(150)))));
            this.materialButton2.HoverTextColor = System.Drawing.Color.Empty;
            this.materialButton2.Location = new System.Drawing.Point(174, 57);
            this.materialButton2.Margin = new System.Windows.Forms.Padding(0);
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.Size = new System.Drawing.Size(90, 26);
            this.materialButton2.TabIndex = 10;
            this.materialButton2.Text = "EXPENCES VIWER";
            this.materialButton2.UseVisualStyleBackColor = true;
            this.materialButton2.Click += new System.EventHandler(this.materialButton2_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.search_txt);
            this.panel3.ForeColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(489, 56);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(396, 25);
            this.panel3.TabIndex = 9;
            // 
            // search_txt
            // 
            this.search_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.search_txt.BackColor = System.Drawing.Color.White;
            this.search_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.search_txt.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_txt.ForeColor = System.Drawing.Color.Gray;
            this.search_txt.Location = new System.Drawing.Point(6, 3);
            this.search_txt.Name = "search_txt";
            this.search_txt.Size = new System.Drawing.Size(383, 22);
            this.search_txt.TabIndex = 0;
            this.search_txt.TextChanged += new System.EventHandler(this.search_txt_TextChanged);
            // 
            // employee_name
            // 
            this.employee_name.Cursor = System.Windows.Forms.Cursors.Hand;
            this.employee_name.FlatAppearance.BorderSize = 0;
            this.employee_name.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.employee_name.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employee_name.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(150)))));
            this.employee_name.HoverTextColor = System.Drawing.Color.Empty;
            this.employee_name.Location = new System.Drawing.Point(6, 57);
            this.employee_name.Margin = new System.Windows.Forms.Padding(0);
            this.employee_name.Name = "employee_name";
            this.employee_name.Size = new System.Drawing.Size(168, 26);
            this.employee_name.TabIndex = 8;
            this.employee_name.Text = "ADD CATEGORY";
            this.employee_name.UseVisualStyleBackColor = true;
            this.employee_name.Click += new System.EventHandler(this.employee_name_Click);
            // 
            // cat_loader
            // 
            this.cat_loader.AutoScroll = true;
            this.cat_loader.BackColor = System.Drawing.Color.Transparent;
            this.cat_loader.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cat_loader.Location = new System.Drawing.Point(1, 106);
            this.cat_loader.Name = "cat_loader";
            this.cat_loader.Size = new System.Drawing.Size(925, 396);
            this.cat_loader.TabIndex = 6;
            this.cat_loader.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.cat_loader_ControlAdded);
            this.cat_loader.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.cat_loader_ControlRemoved);
            this.cat_loader.Paint += new System.Windows.Forms.PaintEventHandler(this.cat_loader_Paint);
            // 
            // Expense_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 505);
            this.Controls.Add(this.cat_loader);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Expense_List";
            this.Text = "Expense_List";
            this.Load += new System.EventHandler(this.Expense_List_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private RetailControls.MaterialButton materialButton5;
        private RetailControls.MaterialButton materialButton2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox search_txt;
        private RetailControls.MaterialButton employee_name;
        private System.Windows.Forms.Panel cat_loader;
        private RetailControls.MaterialButton SearchBtn;
    }
}