namespace softer
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Exit = new Bunifu.Framework.UI.BunifuTileButton();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.pass = new Guna.UI2.WinForms.Guna2TextBox();
            this.username = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 25;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 25;
            this.bunifuElipse2.TargetControl = this;
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 25;
            this.bunifuElipse3.TargetControl = this;
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Transparent;
            this.Exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Exit.BackgroundImage")));
            this.Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Exit.color = System.Drawing.Color.Transparent;
            this.Exit.colorActive = System.Drawing.Color.Transparent;
            this.Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.Exit.ForeColor = System.Drawing.Color.White;
            this.Exit.Image = null;
            this.Exit.ImagePosition = 20;
            this.Exit.ImageZoom = 50;
            this.Exit.LabelPosition = 41;
            this.Exit.LabelText = "";
            this.Exit.Location = new System.Drawing.Point(-2, -1);
            this.Exit.Margin = new System.Windows.Forms.Padding(6);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(45, 43);
            this.Exit.TabIndex = 12;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.AutoRoundedCorners = true;
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderRadius = 21;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.Silver;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.ForeColor = System.Drawing.Color.Black;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(363, 250);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(155, 45);
            this.guna2Button1.TabIndex = 15;
            this.guna2Button1.Text = "الدخول";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // pass
            // 
            this.pass.AutoRoundedCorners = true;
            this.pass.BackColor = System.Drawing.Color.Transparent;
            this.pass.BorderRadius = 17;
            this.pass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pass.DefaultText = "";
            this.pass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.pass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.pass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.pass.DisabledState.Parent = this.pass;
            this.pass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.pass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.pass.FocusedState.Parent = this.pass;
            this.pass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass.ForeColor = System.Drawing.Color.Black;
            this.pass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.pass.HoverState.Parent = this.pass;
            this.pass.IconRight = ((System.Drawing.Image)(resources.GetObject("pass.IconRight")));
            this.pass.IconRightOffset = new System.Drawing.Point(5, 0);
            this.pass.Location = new System.Drawing.Point(336, 165);
            this.pass.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pass.Name = "pass";
            this.pass.PasswordChar = '\0';
            this.pass.PlaceholderText = "كلمة المرور";
            this.pass.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pass.SelectedText = "";
            this.pass.ShadowDecoration.Parent = this.pass;
            this.pass.Size = new System.Drawing.Size(200, 36);
            this.pass.TabIndex = 14;
            this.pass.TextOffset = new System.Drawing.Point(5, 0);
            // 
            // username
            // 
            this.username.AutoRoundedCorners = true;
            this.username.BackColor = System.Drawing.Color.Transparent;
            this.username.BorderRadius = 17;
            this.username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.username.DefaultText = "";
            this.username.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.username.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.username.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.username.DisabledState.Parent = this.username;
            this.username.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.username.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.username.FocusedState.Parent = this.username;
            this.username.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.ForeColor = System.Drawing.Color.Black;
            this.username.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.username.HoverState.Parent = this.username;
            this.username.IconRight = ((System.Drawing.Image)(resources.GetObject("username.IconRight")));
            this.username.IconRightOffset = new System.Drawing.Point(5, 0);
            this.username.Location = new System.Drawing.Point(336, 96);
            this.username.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.username.Name = "username";
            this.username.PasswordChar = '\0';
            this.username.PlaceholderText = "اسم المستخدم";
            this.username.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.username.SelectedText = "";
            this.username.ShadowDecoration.Parent = this.username;
            this.username.Size = new System.Drawing.Size(200, 36);
            this.username.TabIndex = 13;
            this.username.TextOffset = new System.Drawing.Point(5, 0);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::softer.Properties.Resources._8879;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(580, 384);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.username);
            this.Controls.Add(this.Exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
        private Bunifu.Framework.UI.BunifuTileButton Exit;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2TextBox pass;
        private Guna.UI2.WinForms.Guna2TextBox username;
    }
}