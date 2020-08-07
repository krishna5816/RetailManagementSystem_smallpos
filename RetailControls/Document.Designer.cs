namespace RetailControls
{
    partial class Document
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
            this.Delete_btn = new RetailControls.MaterialButton();
            this.NameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Delete_btn
            // 
            this.Delete_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Delete_btn.BackgroundImage = global::RetailControls.controlresource.delete;
            this.Delete_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Delete_btn.FlatAppearance.BorderSize = 0;
            this.Delete_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete_btn.HoverColor = System.Drawing.Color.Empty;
            this.Delete_btn.HoverTextColor = System.Drawing.Color.Empty;
            this.Delete_btn.Location = new System.Drawing.Point(214, 3);
            this.Delete_btn.Name = "Delete_btn";
            this.Delete_btn.Size = new System.Drawing.Size(30, 30);
            this.Delete_btn.TabIndex = 0;
            this.Delete_btn.UseVisualStyleBackColor = true;
            this.Delete_btn.Click += new System.EventHandler(this.Delete_btn_Click);
            this.Delete_btn.MouseEnter += new System.EventHandler(this.Delete_btn_MouseEnter);
            this.Delete_btn.MouseLeave += new System.EventHandler(this.Delete_btn_MouseLeave);
            // 
            // NameLabel
            // 
            this.NameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NameLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(3, 5);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(206, 30);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "aaaaaaaaaaaaaaaaaaaaaaa";
            this.NameLabel.TextChanged += new System.EventHandler(this.NameLabel_TextChanged);
            // 
            // Document
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.Delete_btn);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(166)))));
            this.Name = "Document";
            this.Size = new System.Drawing.Size(247, 39);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialButton Delete_btn;
        private System.Windows.Forms.Label NameLabel;
    }
}
