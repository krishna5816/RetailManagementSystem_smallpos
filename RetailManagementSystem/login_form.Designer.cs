namespace RetailManagementSystem
{
    partial class login_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login_form));
            this.materialButton3 = new RetailControls.MaterialButton();
            this.materialButton1 = new RetailControls.MaterialButton();
            this.username_txt = new cmscontrols.bettertextbox();
            this.password_txt = new cmscontrols.bettertextbox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel_login = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.linkLabel_link = new System.Windows.Forms.LinkLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel_image = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel_login.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialButton3
            // 
            this.materialButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialButton3.BackColor = System.Drawing.Color.Transparent;
            this.materialButton3.BackgroundImage = global::RetailManagementSystem.Properties.Resources.log_out;
            this.materialButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.materialButton3.FlatAppearance.BorderSize = 0;
            this.materialButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialButton3.HoverColor = System.Drawing.Color.Empty;
            this.materialButton3.HoverTextColor = System.Drawing.Color.Empty;
            this.materialButton3.Location = new System.Drawing.Point(1029, 4);
            this.materialButton3.Name = "materialButton3";
            this.materialButton3.Size = new System.Drawing.Size(31, 27);
            this.materialButton3.TabIndex = 6;
            this.materialButton3.UseVisualStyleBackColor = false;
            this.materialButton3.Click += new System.EventHandler(this.materialButton3_Click);
            // 
            // materialButton1
            // 
            this.materialButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.materialButton1.FlatAppearance.BorderSize = 0;
            this.materialButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialButton1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialButton1.ForeColor = System.Drawing.Color.White;
            this.materialButton1.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(200)))));
            this.materialButton1.HoverTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Location = new System.Drawing.Point(585, 281);
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.Size = new System.Drawing.Size(128, 34);
            this.materialButton1.TabIndex = 7;
            this.materialButton1.Text = "Sign In";
            this.materialButton1.UseVisualStyleBackColor = false;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // username_txt
            // 
            this.username_txt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.username_txt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.username_txt.BackColor = System.Drawing.Color.White;
            this.username_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.username_txt.Location = new System.Drawing.Point(534, 182);
            this.username_txt.Margin = new System.Windows.Forms.Padding(4);
            this.username_txt.Name = "username_txt";
            this.username_txt.Size = new System.Drawing.Size(237, 17);
            this.username_txt.TabIndex = 3;
            this.username_txt.TextChanged += new System.EventHandler(this.bettertextbox1_TextChanged);
            this.username_txt.Enter += new System.EventHandler(this.username_txt_Enter);
            this.username_txt.Leave += new System.EventHandler(this.username_txt_Leave);
            // 
            // password_txt
            // 
            this.password_txt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.password_txt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.password_txt.BackColor = System.Drawing.Color.White;
            this.password_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.password_txt.Location = new System.Drawing.Point(534, 241);
            this.password_txt.Margin = new System.Windows.Forms.Padding(4);
            this.password_txt.Name = "password_txt";
            this.password_txt.PasswordChar = '*';
            this.password_txt.Size = new System.Drawing.Size(237, 17);
            this.password_txt.TabIndex = 6;
            this.password_txt.Click += new System.EventHandler(this.password_txt_Click);
            this.password_txt.Enter += new System.EventHandler(this.password_txt_Enter);
            this.password_txt.Leave += new System.EventHandler(this.password_txt_Leave);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Green;
            this.panel3.Location = new System.Drawing.Point(25, 401);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(218, 1);
            this.panel3.TabIndex = 11;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Green;
            this.panel4.Location = new System.Drawing.Point(25, 348);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(218, 1);
            this.panel4.TabIndex = 12;
            // 
            // panel_login
            // 
            this.panel_login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_login.BackColor = System.Drawing.Color.White;
            this.panel_login.Controls.Add(this.label3);
            this.panel_login.Controls.Add(this.panel1);
            this.panel_login.Controls.Add(this.panel2);
            this.panel_login.Controls.Add(this.label2);
            this.panel_login.Controls.Add(this.materialButton1);
            this.panel_login.Controls.Add(this.password_txt);
            this.panel_login.Controls.Add(this.label1);
            this.panel_login.Controls.Add(this.panel6);
            this.panel_login.Controls.Add(this.username_txt);
            this.panel_login.Controls.Add(this.panel7);
            this.panel_login.Location = new System.Drawing.Point(122, 67);
            this.panel_login.Name = "panel_login";
            this.panel_login.Size = new System.Drawing.Size(821, 427);
            this.panel_login.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(624, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 19);
            this.label3.TabIndex = 14;
            this.label3.Text = "Login";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(609, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(80, 80);
            this.panel1.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.linkLabel_link);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.panel_image);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(484, 427);
            this.panel2.TabIndex = 12;
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel5.BackgroundImage")));
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel5.Location = new System.Drawing.Point(210, 385);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(15, 15);
            this.panel5.TabIndex = 7;
            // 
            // linkLabel_link
            // 
            this.linkLabel_link.AutoSize = true;
            this.linkLabel_link.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel_link.LinkColor = System.Drawing.Color.Navy;
            this.linkLabel_link.Location = new System.Drawing.Point(227, 383);
            this.linkLabel_link.Name = "linkLabel_link";
            this.linkLabel_link.Size = new System.Drawing.Size(126, 17);
            this.linkLabel_link.TabIndex = 6;
            this.linkLabel_link.TabStop = true;
            this.linkLabel_link.Text = "By NeedTechnoSoft";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(124, 383);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Crafted With";
            // 
            // panel_image
            // 
            this.panel_image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_image.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_image.Location = new System.Drawing.Point(19, 53);
            this.panel_image.Name = "panel_image";
            this.panel_image.Size = new System.Drawing.Size(446, 306);
            this.panel_image.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Corbel", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label5.Location = new System.Drawing.Point(44, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(395, 39);
            this.label5.TabIndex = 1;
            this.label5.Text = "Retail Management System";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(529, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(527, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(120)))), ((int)(((byte)(121)))));
            this.panel6.Location = new System.Drawing.Point(535, 261);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(236, 1);
            this.panel6.TabIndex = 11;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(120)))), ((int)(((byte)(121)))));
            this.panel7.Location = new System.Drawing.Point(535, 202);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(236, 1);
            this.panel7.TabIndex = 1;
            // 
            // login_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::RetailManagementSystem.Properties.Resources.retailbackgroud;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1065, 561);
            this.Controls.Add(this.panel_login);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.materialButton3);
            this.Controls.Add(this.panel3);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(166)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "login_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login_form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.login_form_Load);
            this.panel_login.ResumeLayout(false);
            this.panel_login.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private RetailControls.MaterialButton materialButton3;
        private RetailControls.MaterialButton materialButton1;
        private cmscontrols.bettertextbox username_txt;
        private cmscontrols.bettertextbox password_txt;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel_login;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.LinkLabel linkLabel_link;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel_image;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
    }
}