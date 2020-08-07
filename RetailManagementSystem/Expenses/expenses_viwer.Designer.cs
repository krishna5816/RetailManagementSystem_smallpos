namespace RetailManagementSystem.Expenses
{
    partial class expenses_viwer
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
            this.components = new System.ComponentModel.Container();
            this.expname_lbl = new System.Windows.Forms.Label();
            this.date_lbl = new System.Windows.Forms.Label();
            this.amount_lbl = new System.Windows.Forms.Label();
            this.view_detail = new RetailControls.MaterialButton();
            this.edit_btn = new RetailControls.MaterialButton();
            this.delete_btn = new RetailControls.MaterialButton();
            this.notificationMAnager1 = new RetailControls.NotificationMAnager(this.components);
            this.SuspendLayout();
            // 
            // expname_lbl
            // 
            this.expname_lbl.AutoSize = true;
            this.expname_lbl.Location = new System.Drawing.Point(22, 15);
            this.expname_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.expname_lbl.Name = "expname_lbl";
            this.expname_lbl.Size = new System.Drawing.Size(208, 17);
            this.expname_lbl.TabIndex = 0;
            this.expname_lbl.Text = "aaaaaaaaaaaaaaaaaaaaaaaaa";
            // 
            // date_lbl
            // 
            this.date_lbl.AutoSize = true;
            this.date_lbl.Location = new System.Drawing.Point(249, 16);
            this.date_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.date_lbl.Name = "date_lbl";
            this.date_lbl.Size = new System.Drawing.Size(104, 17);
            this.date_lbl.TabIndex = 1;
            this.date_lbl.Text = "aaaaaaaaaaaa";
            // 
            // amount_lbl
            // 
            this.amount_lbl.AutoSize = true;
            this.amount_lbl.Location = new System.Drawing.Point(371, 16);
            this.amount_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.amount_lbl.Name = "amount_lbl";
            this.amount_lbl.Size = new System.Drawing.Size(104, 17);
            this.amount_lbl.TabIndex = 2;
            this.amount_lbl.Text = "aaaaaaaaaaaa";
            // 
            // view_detail
            // 
            this.view_detail.BackColor = System.Drawing.Color.Blue;
            this.view_detail.FlatAppearance.BorderSize = 0;
            this.view_detail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.view_detail.ForeColor = System.Drawing.Color.White;
            this.view_detail.HoverColor = System.Drawing.Color.Lime;
            this.view_detail.HoverTextColor = System.Drawing.Color.Red;
            this.view_detail.Location = new System.Drawing.Point(517, 14);
            this.view_detail.Name = "view_detail";
            this.view_detail.Size = new System.Drawing.Size(119, 24);
            this.view_detail.TabIndex = 3;
            this.view_detail.Text = "VIEW DETAIL";
            this.view_detail.UseVisualStyleBackColor = false;
            this.view_detail.Click += new System.EventHandler(this.view_detail_Click);
            // 
            // edit_btn
            // 
            this.edit_btn.BackColor = System.Drawing.Color.Blue;
            this.edit_btn.FlatAppearance.BorderSize = 0;
            this.edit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edit_btn.ForeColor = System.Drawing.Color.White;
            this.edit_btn.HoverColor = System.Drawing.Color.Lime;
            this.edit_btn.HoverTextColor = System.Drawing.Color.Red;
            this.edit_btn.Location = new System.Drawing.Point(642, 14);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(78, 24);
            this.edit_btn.TabIndex = 4;
            this.edit_btn.Text = "EDIT";
            this.edit_btn.UseVisualStyleBackColor = false;
            this.edit_btn.Click += new System.EventHandler(this.edit_btn_Click);
            // 
            // delete_btn
            // 
            this.delete_btn.BackColor = System.Drawing.Color.Blue;
            this.delete_btn.FlatAppearance.BorderSize = 0;
            this.delete_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_btn.ForeColor = System.Drawing.Color.White;
            this.delete_btn.HoverColor = System.Drawing.Color.Lime;
            this.delete_btn.HoverTextColor = System.Drawing.Color.Red;
            this.delete_btn.Location = new System.Drawing.Point(726, 14);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(83, 24);
            this.delete_btn.TabIndex = 5;
            this.delete_btn.Text = "DELETE";
            this.delete_btn.UseVisualStyleBackColor = false;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // expenses_viwer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.edit_btn);
            this.Controls.Add(this.view_detail);
            this.Controls.Add(this.amount_lbl);
            this.Controls.Add(this.date_lbl);
            this.Controls.Add(this.expname_lbl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(166)))));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "expenses_viwer";
            this.Size = new System.Drawing.Size(821, 49);
            this.Load += new System.EventHandler(this.expenses_viwer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label expname_lbl;
        private System.Windows.Forms.Label date_lbl;
        private System.Windows.Forms.Label amount_lbl;
        private RetailControls.MaterialButton view_detail;
        private RetailControls.MaterialButton edit_btn;
        private RetailControls.MaterialButton delete_btn;
        private RetailControls.NotificationMAnager notificationMAnager1;
    }
}
