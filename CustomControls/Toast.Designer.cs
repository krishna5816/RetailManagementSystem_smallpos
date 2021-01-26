using System;

namespace CustomControls
{
    partial class Toast
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
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.materialButtonClose = new CustomControls.MaterialButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 5);
            this.label1.MaximumSize = new System.Drawing.Size(260, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1 sadfasdf asdfasd  sadf asdf  asdfasdf  asdfasdfasdf sadfasdf asdfas";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // materialButtonClose
            // 
            this.materialButtonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialButtonClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButtonClose.FlatAppearance.BorderSize = 0;
            this.materialButtonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialButtonClose.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialButtonClose.ForeColor = System.Drawing.Color.White;
            this.materialButtonClose.Location = new System.Drawing.Point(253, 8);
            this.materialButtonClose.Name = "materialButtonClose";
            this.materialButtonClose.role = 0;
            this.materialButtonClose.Size = new System.Drawing.Size(30, 30);
            this.materialButtonClose.TabIndex = 1;
            this.materialButtonClose.Text = "X";
            this.materialButtonClose.Totext = null;
            this.materialButtonClose.userole = false;
            this.materialButtonClose.UseVisualStyleBackColor = true;
            this.materialButtonClose.Click += new System.EventHandler(this.materialButtonClose_Click);
            // 
            // Toast
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.materialButtonClose);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Toast";
            this.Size = new System.Drawing.Size(290, 50);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Toast_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

     

        #endregion

        private System.Windows.Forms.Label label1;
        private MaterialButton materialButtonClose;
        public System.Windows.Forms.Timer timer;
    }
}
