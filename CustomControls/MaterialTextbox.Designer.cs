namespace CustomControls
{
    partial class MaterialTextbox
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
            this.label_search = new System.Windows.Forms.Label();
            this.panel__Search = new System.Windows.Forms.Panel();
            this.betterTextBox_search = new CustomControls.BetterTextBox();
            this.SuspendLayout();
            // 
            // label_search
            // 
            this.label_search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_search.BackColor = System.Drawing.Color.Transparent;
            this.label_search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label_search.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.label_search.Location = new System.Drawing.Point(9, 34);
            this.label_search.Name = "label_search";
            this.label_search.Size = new System.Drawing.Size(284, 25);
            this.label_search.TabIndex = 18;
            this.label_search.Text = "Search Parties";
            this.label_search.Click += new System.EventHandler(this.label_search_Click);
            // 
            // panel__Search
            // 
            this.panel__Search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel__Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.panel__Search.Location = new System.Drawing.Point(-1, 60);
            this.panel__Search.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel__Search.Name = "panel__Search";
            this.panel__Search.Size = new System.Drawing.Size(304, 2);
            this.panel__Search.TabIndex = 17;
            // 
            // betterTextBox_search
            // 
            this.betterTextBox_search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.betterTextBox_search.append = "";
            this.betterTextBox_search.BackColor = System.Drawing.Color.White;
            this.betterTextBox_search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.betterTextBox_search.decVal = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.betterTextBox_search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            this.betterTextBox_search.intVal = 0;
            this.betterTextBox_search.Location = new System.Drawing.Point(9, 38);
            this.betterTextBox_search.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.betterTextBox_search.Name = "betterTextBox_search";
            this.betterTextBox_search.prepend = "";
            this.betterTextBox_search.Rules = null;
            this.betterTextBox_search.Size = new System.Drawing.Size(279, 18);
            this.betterTextBox_search.TabIndex = 16;
            this.betterTextBox_search.textboxType = CustomControls.TextboxType.Text;
            this.betterTextBox_search.Enter += new System.EventHandler(this.betterTextBox_search_Enter);
            this.betterTextBox_search.Leave += new System.EventHandler(this.betterTextBox_search_Leave);
            // 
            // MaterialTextbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label_search);
            this.Controls.Add(this.panel__Search);
            this.Controls.Add(this.betterTextBox_search);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MaterialTextbox";
            this.Size = new System.Drawing.Size(304, 63);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label_search;
        public System.Windows.Forms.Panel panel__Search;
        public BetterTextBox betterTextBox_search;
    }
}
