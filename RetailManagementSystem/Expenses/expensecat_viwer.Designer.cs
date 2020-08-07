namespace RetailManagementSystem.Expenses
{
    partial class expensecat_viwer
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
            this.label1 = new System.Windows.Forms.Label();
            this.materialButton1_delete = new RetailControls.MaterialButton();
            this.materialButton1 = new RetailControls.MaterialButton();
            this.materialButton2 = new RetailControls.MaterialButton();
            this.notificationMAnager1 = new RetailControls.NotificationMAnager(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(166)))));
            this.label1.Location = new System.Drawing.Point(15, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "mmmmmmmmmmmmmmmm";
            // 
            // materialButton1_delete
            // 
            this.materialButton1_delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialButton1_delete.BackgroundImage = global::RetailManagementSystem.Properties.Resources.delete;
            this.materialButton1_delete.FlatAppearance.BorderSize = 0;
            this.materialButton1_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialButton1_delete.HoverColor = System.Drawing.Color.Empty;
            this.materialButton1_delete.HoverTextColor = System.Drawing.Color.Empty;
            this.materialButton1_delete.Location = new System.Drawing.Point(557, 4);
            this.materialButton1_delete.Name = "materialButton1_delete";
            this.materialButton1_delete.Size = new System.Drawing.Size(30, 30);
            this.materialButton1_delete.TabIndex = 2;
            this.materialButton1_delete.UseVisualStyleBackColor = true;
            this.materialButton1_delete.Click += new System.EventHandler(this.materialButton1_delete_Click);
            // 
            // materialButton1
            // 
            this.materialButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(166)))));
            this.materialButton1.FlatAppearance.BorderSize = 0;
            this.materialButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialButton1.ForeColor = System.Drawing.Color.White;
            this.materialButton1.HoverColor = System.Drawing.Color.White;
            this.materialButton1.HoverTextColor = System.Drawing.Color.Black;
            this.materialButton1.Location = new System.Drawing.Point(476, 5);
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.Size = new System.Drawing.Size(75, 27);
            this.materialButton1.TabIndex = 3;
            this.materialButton1.Text = "Edit";
            this.materialButton1.UseVisualStyleBackColor = false;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // materialButton2
            // 
            this.materialButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(166)))));
            this.materialButton2.FlatAppearance.BorderSize = 0;
            this.materialButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialButton2.ForeColor = System.Drawing.Color.White;
            this.materialButton2.HoverColor = System.Drawing.Color.White;
            this.materialButton2.HoverTextColor = System.Drawing.Color.Black;
            this.materialButton2.Location = new System.Drawing.Point(351, 6);
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.Size = new System.Drawing.Size(119, 27);
            this.materialButton2.TabIndex = 4;
            this.materialButton2.Text = "Add Expences";
            this.materialButton2.UseVisualStyleBackColor = false;
            this.materialButton2.Click += new System.EventHandler(this.materialButton2_Click);
            // 
            // expensecat_viwer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.materialButton2);
            this.Controls.Add(this.materialButton1);
            this.Controls.Add(this.materialButton1_delete);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "expensecat_viwer";
            this.Size = new System.Drawing.Size(590, 40);
            this.Load += new System.EventHandler(this.expensecat_viwer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private RetailControls.MaterialButton materialButton1_delete;
        private RetailControls.MaterialButton materialButton1;
        private RetailControls.MaterialButton materialButton2;
        private RetailControls.NotificationMAnager notificationMAnager1;
    }
}
