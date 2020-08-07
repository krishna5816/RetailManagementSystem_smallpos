namespace RetailControls
{
    partial class Notification
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.materialButton1 = new RetailControls.MaterialButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.MaximumSize = new System.Drawing.Size(294, 69);
            this.label1.MinimumSize = new System.Drawing.Size(294, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 69);
            this.label1.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // materialButton1
            // 
            this.materialButton1.BackColor = System.Drawing.Color.Transparent;
            this.materialButton1.FlatAppearance.BorderSize = 0;
            this.materialButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialButton1.HoverColor = System.Drawing.Color.Empty;
            this.materialButton1.HoverTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Location = new System.Drawing.Point(264, 5);
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.Size = new System.Drawing.Size(30, 25);
            this.materialButton1.TabIndex = 0;
            this.materialButton1.Text = "X";
            this.materialButton1.UseVisualStyleBackColor = false;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // Notification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(300, 114);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.materialButton1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Notification";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "X";
            this.Load += new System.EventHandler(this.Notification_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Notification_Paint);
            this.MouseEnter += new System.EventHandler(this.Notification_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.Notification_MouseLeave);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialButton materialButton1;
        public System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Label label1;

    }
}