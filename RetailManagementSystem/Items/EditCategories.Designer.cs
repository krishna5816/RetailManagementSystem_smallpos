namespace RetailManagementSystem.ITEMS
{
    partial class EditCategories
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1_name = new System.Windows.Forms.TextBox();
            this.save_btn = new RetailControls.MaterialButton();
            this.cancel_btn = new RetailControls.MaterialButton();
            this.notificationMAnager1 = new RetailControls.NotificationMAnager(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "COMPANY NAME";
            // 
            // textBox1_name
            // 
            this.textBox1_name.Location = new System.Drawing.Point(7, 31);
            this.textBox1_name.Name = "textBox1_name";
            this.textBox1_name.Size = new System.Drawing.Size(416, 24);
            this.textBox1_name.TabIndex = 1;
            // 
            // save_btn
            // 
            this.save_btn.BackColor = System.Drawing.Color.Blue;
            this.save_btn.FlatAppearance.BorderSize = 0;
            this.save_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save_btn.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_btn.ForeColor = System.Drawing.Color.White;
            this.save_btn.HoverColor = System.Drawing.Color.Empty;
            this.save_btn.HoverTextColor = System.Drawing.Color.Empty;
            this.save_btn.Location = new System.Drawing.Point(258, 61);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(75, 30);
            this.save_btn.TabIndex = 2;
            this.save_btn.Text = "Save";
            this.save_btn.UseVisualStyleBackColor = false;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // cancel_btn
            // 
            this.cancel_btn.BackColor = System.Drawing.Color.Red;
            this.cancel_btn.FlatAppearance.BorderSize = 0;
            this.cancel_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel_btn.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_btn.ForeColor = System.Drawing.Color.White;
            this.cancel_btn.HoverColor = System.Drawing.Color.Empty;
            this.cancel_btn.HoverTextColor = System.Drawing.Color.Empty;
            this.cancel_btn.Location = new System.Drawing.Point(348, 61);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(75, 30);
            this.cancel_btn.TabIndex = 3;
            this.cancel_btn.Text = "Cancel";
            this.cancel_btn.UseVisualStyleBackColor = false;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // EditCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 105);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.textBox1_name);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "EditCategories";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditCategories";
            this.Load += new System.EventHandler(this.EditCategories_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1_name;
        private RetailControls.MaterialButton save_btn;
        private RetailControls.MaterialButton cancel_btn;
        private RetailControls.NotificationMAnager notificationMAnager1;
    }
}