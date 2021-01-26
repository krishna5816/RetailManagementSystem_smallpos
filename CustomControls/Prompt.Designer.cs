namespace CustomControls
{
    partial class Prompt
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
            this.materialButton_additems = new CustomControls.MaterialButton();
            this.textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // materialButton_close
            // 
            this.materialButton_close.FlatAppearance.BorderSize = 0;
            // 
            // materialButton_additems
            // 
            this.materialButton_additems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.materialButton_additems.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButton_additems.FlatAppearance.BorderSize = 0;
            this.materialButton_additems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialButton_additems.ForeColor = System.Drawing.Color.White;
            this.materialButton_additems.Location = new System.Drawing.Point(433, 165);
            this.materialButton_additems.Name = "materialButton_additems";
            this.materialButton_additems.role = 3;
            this.materialButton_additems.Size = new System.Drawing.Size(118, 28);
            this.materialButton_additems.TabIndex = 33;
            this.materialButton_additems.Text = "Ok";
            this.materialButton_additems.Totext = null;
            this.materialButton_additems.userole = true;
            this.materialButton_additems.UseVisualStyleBackColor = false;
            this.materialButton_additems.Click += new System.EventHandler(this.materialButton_additems_Click);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(6, 51);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(545, 108);
            this.textBox.TabIndex = 34;
            this.textBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Prompt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(559, 205);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.materialButton_additems);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Prompt";
            this.Text = "Prompt";
            this.Controls.SetChildIndex(this.materialButton_close, 0);
            this.Controls.SetChildIndex(this.label_title, 0);
            this.Controls.SetChildIndex(this.panel_Divider, 0);
            this.Controls.SetChildIndex(this.materialButton_additems, 0);
            this.Controls.SetChildIndex(this.textBox, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialButton materialButton_additems;
        public System.Windows.Forms.TextBox textBox;
    }
}