namespace CustomControls
{
    partial class MultiViwer
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
            this.betterListView1 = new CustomControls.BetterListView();
            this.materialButton_print = new CustomControls.MaterialButton();
            this.SuspendLayout();
            // 
            // panel_Divider
            // 
            this.panel_Divider.Size = new System.Drawing.Size(759, 2);
            // 
            // materialButton_close
            // 
            this.materialButton_close.FlatAppearance.BorderSize = 0;
            // 
            // betterListView1
            // 
            this.betterListView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.betterListView1.FullRowSelect = true;
            this.betterListView1.GridLines = true;
            this.betterListView1.HideSelection = false;
            this.betterListView1.Location = new System.Drawing.Point(4, 50);
            this.betterListView1.Name = "betterListView1";
            this.betterListView1.Size = new System.Drawing.Size(752, 296);
            this.betterListView1.sortable = false;
            this.betterListView1.TabIndex = 3;
            this.betterListView1.UseCompatibleStateImageBehavior = false;
            this.betterListView1.View = System.Windows.Forms.View.Details;
            // 
            // materialButton_print
            // 
            this.materialButton_print.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButton_print.FlatAppearance.BorderSize = 0;
            this.materialButton_print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialButton_print.Location = new System.Drawing.Point(673, 9);
            this.materialButton_print.Name = "materialButton_print";
            this.materialButton_print.role = 0;
            this.materialButton_print.Size = new System.Drawing.Size(75, 23);
            this.materialButton_print.TabIndex = 4;
            this.materialButton_print.Text = "Print";
            this.materialButton_print.Totext = null;
            this.materialButton_print.userole = false;
            this.materialButton_print.UseVisualStyleBackColor = true;
            // 
            // MultiViwer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.ClientSize = new System.Drawing.Size(760, 352);
            this.Controls.Add(this.materialButton_print);
            this.Controls.Add(this.betterListView1);
            this.Name = "MultiViwer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Controls.SetChildIndex(this.materialButton_close, 0);
            this.Controls.SetChildIndex(this.label_title, 0);
            this.Controls.SetChildIndex(this.panel_Divider, 0);
            this.Controls.SetChildIndex(this.betterListView1, 0);
            this.Controls.SetChildIndex(this.materialButton_print, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BetterListView betterListView1;
        private MaterialButton materialButton_print;
    }
}
