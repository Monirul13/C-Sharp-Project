namespace FInalProject.UILayer
{
    partial class UserAccount
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
            this.userNameLabel = new MetroFramework.Controls.MetroLabel();
            this.userNameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.UserPasswordLabel = new MetroFramework.Controls.MetroLabel();
            this.userPasswordTextBox = new MetroFramework.Controls.MetroTextBox();
            this.userLoginButton = new MetroFramework.Controls.MetroButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backButton = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.userNameLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.userNameLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.userNameLabel.Location = new System.Drawing.Point(408, 221);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(82, 25);
            this.userNameLabel.TabIndex = 0;
            this.userNameLabel.Text = " Name : ";
            this.userNameLabel.UseStyleColors = true;
            // 
            // userNameTextBox
            // 
            // 
            // 
            // 
            this.userNameTextBox.CustomButton.Image = null;
            this.userNameTextBox.CustomButton.Location = new System.Drawing.Point(114, 1);
            this.userNameTextBox.CustomButton.Name = "";
            this.userNameTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.userNameTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.userNameTextBox.CustomButton.TabIndex = 1;
            this.userNameTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.userNameTextBox.CustomButton.UseSelectable = true;
            this.userNameTextBox.CustomButton.Visible = false;
            this.userNameTextBox.Lines = new string[0];
            this.userNameTextBox.Location = new System.Drawing.Point(559, 221);
            this.userNameTextBox.MaxLength = 32767;
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.PasswordChar = '\0';
            this.userNameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.userNameTextBox.SelectedText = "";
            this.userNameTextBox.SelectionLength = 0;
            this.userNameTextBox.SelectionStart = 0;
            this.userNameTextBox.ShortcutsEnabled = true;
            this.userNameTextBox.Size = new System.Drawing.Size(136, 23);
            this.userNameTextBox.TabIndex = 1;
            this.userNameTextBox.UseSelectable = true;
            this.userNameTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.userNameTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // UserPasswordLabel
            // 
            this.UserPasswordLabel.AutoSize = true;
            this.UserPasswordLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.UserPasswordLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.UserPasswordLabel.Location = new System.Drawing.Point(374, 294);
            this.UserPasswordLabel.Name = "UserPasswordLabel";
            this.UserPasswordLabel.Size = new System.Drawing.Size(116, 25);
            this.UserPasswordLabel.TabIndex = 2;
            this.UserPasswordLabel.Text = " PassWord : ";
            this.UserPasswordLabel.UseStyleColors = true;
            // 
            // userPasswordTextBox
            // 
            // 
            // 
            // 
            this.userPasswordTextBox.CustomButton.Image = null;
            this.userPasswordTextBox.CustomButton.Location = new System.Drawing.Point(114, 1);
            this.userPasswordTextBox.CustomButton.Name = "";
            this.userPasswordTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.userPasswordTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.userPasswordTextBox.CustomButton.TabIndex = 1;
            this.userPasswordTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.userPasswordTextBox.CustomButton.UseSelectable = true;
            this.userPasswordTextBox.CustomButton.Visible = false;
            this.userPasswordTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.userPasswordTextBox.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.userPasswordTextBox.Lines = new string[0];
            this.userPasswordTextBox.Location = new System.Drawing.Point(559, 294);
            this.userPasswordTextBox.MaxLength = 32767;
            this.userPasswordTextBox.Name = "userPasswordTextBox";
            this.userPasswordTextBox.PasswordChar = '\0';
            this.userPasswordTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.userPasswordTextBox.SelectedText = "";
            this.userPasswordTextBox.SelectionLength = 0;
            this.userPasswordTextBox.SelectionStart = 0;
            this.userPasswordTextBox.ShortcutsEnabled = true;
            this.userPasswordTextBox.Size = new System.Drawing.Size(136, 23);
            this.userPasswordTextBox.TabIndex = 3;
            this.userPasswordTextBox.UseSelectable = true;
            this.userPasswordTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.userPasswordTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.userPasswordTextBox.Click += new System.EventHandler(this.userPasswordTextBox_Click);
            // 
            // userLoginButton
            // 
            this.userLoginButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.userLoginButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.userLoginButton.Location = new System.Drawing.Point(568, 370);
            this.userLoginButton.Name = "userLoginButton";
            this.userLoginButton.Size = new System.Drawing.Size(127, 45);
            this.userLoginButton.TabIndex = 4;
            this.userLoginButton.Text = "Log in";
            this.userLoginButton.UseSelectable = true;
            this.userLoginButton.UseStyleColors = true;
            this.userLoginButton.Click += new System.EventHandler(this.userLoginButton_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::FInalProject.UILayer.Properties.Resources.Blood_Organ_Donation_wallpapers1;
            this.pictureBox2.Location = new System.Drawing.Point(96, 52);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(574, 143);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FInalProject.UILayer.Properties.Resources.images;
            this.pictureBox1.Location = new System.Drawing.Point(60, 201);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 223);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Black;
            this.backButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.backButton.ForeColor = System.Drawing.Color.Red;
            this.backButton.Location = new System.Drawing.Point(70, 477);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(104, 42);
            this.backButton.TabIndex = 7;
            this.backButton.Text = " Back ";
            this.backButton.UseCustomBackColor = true;
            this.backButton.UseCustomForeColor = true;
            this.backButton.UseSelectable = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // UserAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 559);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.userLoginButton);
            this.Controls.Add(this.userPasswordTextBox);
            this.Controls.Add(this.UserPasswordLabel);
            this.Controls.Add(this.userNameTextBox);
            this.Controls.Add(this.userNameLabel);
            this.Name = "UserAccount";
            this.Text = "UserAccount";
            this.Load += new System.EventHandler(this.UserAccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel userNameLabel;
        private MetroFramework.Controls.MetroTextBox userNameTextBox;
        private MetroFramework.Controls.MetroLabel UserPasswordLabel;
        private MetroFramework.Controls.MetroTextBox userPasswordTextBox;
        private MetroFramework.Controls.MetroButton userLoginButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MetroFramework.Controls.MetroButton backButton;
    }
}