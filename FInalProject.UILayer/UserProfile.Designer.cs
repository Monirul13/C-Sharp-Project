namespace FInalProject.UILayer
{
    partial class UserProfile
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
            this.userName = new MetroFramework.Controls.MetroLabel();
            this.contactLabel = new MetroFramework.Controls.MetroLabel();
            this.emailLabel = new MetroFramework.Controls.MetroLabel();
            this.bloodgroupLabel = new MetroFramework.Controls.MetroLabel();
            this.religionPanel = new MetroFramework.Controls.MetroLabel();
            this.genderLabel = new MetroFramework.Controls.MetroLabel();
            this.ldobdLabel = new MetroFramework.Controls.MetroLabel();
            this.userdivisionLabel = new MetroFramework.Controls.MetroLabel();
            this.laLabel = new MetroFramework.Controls.MetroLabel();
            this.eeeditButton = new MetroFramework.Controls.MetroButton();
            this.logoutButton = new MetroFramework.Controls.MetroButton();
            this.upnameLabel = new MetroFramework.Controls.MetroLabel();
            this.upcontactLabel = new MetroFramework.Controls.MetroLabel();
            this.upemailLabel = new MetroFramework.Controls.MetroLabel();
            this.upbgpanel = new MetroFramework.Controls.MetroLabel();
            this.upreligionLabel = new MetroFramework.Controls.MetroLabel();
            this.upgenderLabel = new MetroFramework.Controls.MetroLabel();
            this.uplastdateLabel = new MetroFramework.Controls.MetroLabel();
            this.updivisionLabel = new MetroFramework.Controls.MetroLabel();
            this.uplarealabel = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.userName.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.userName.ForeColor = System.Drawing.SystemColors.Highlight;
            this.userName.Location = new System.Drawing.Point(76, 105);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(82, 25);
            this.userName.TabIndex = 0;
            this.userName.Text = " Name : ";
            this.userName.UseStyleColors = true;
            // 
            // contactLabel
            // 
            this.contactLabel.AutoSize = true;
            this.contactLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.contactLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.contactLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.contactLabel.Location = new System.Drawing.Point(76, 162);
            this.contactLabel.Name = "contactLabel";
            this.contactLabel.Size = new System.Drawing.Size(98, 25);
            this.contactLabel.TabIndex = 1;
            this.contactLabel.Text = " Contact : ";
            this.contactLabel.UseStyleColors = true;
            this.contactLabel.Click += new System.EventHandler(this.contactLabel_Click);
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.emailLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.emailLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.emailLabel.Location = new System.Drawing.Point(73, 209);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(85, 25);
            this.emailLabel.TabIndex = 2;
            this.emailLabel.Text = " E-mail : ";
            this.emailLabel.UseStyleColors = true;
            // 
            // bloodgroupLabel
            // 
            this.bloodgroupLabel.AutoSize = true;
            this.bloodgroupLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.bloodgroupLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.bloodgroupLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.bloodgroupLabel.Location = new System.Drawing.Point(76, 261);
            this.bloodgroupLabel.Name = "bloodgroupLabel";
            this.bloodgroupLabel.Size = new System.Drawing.Size(135, 25);
            this.bloodgroupLabel.TabIndex = 3;
            this.bloodgroupLabel.Text = "Blood Group : ";
            this.bloodgroupLabel.UseStyleColors = true;
            this.bloodgroupLabel.Click += new System.EventHandler(this.bloodgroupLabel_Click);
            // 
            // religionPanel
            // 
            this.religionPanel.AutoSize = true;
            this.religionPanel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.religionPanel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.religionPanel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.religionPanel.Location = new System.Drawing.Point(77, 310);
            this.religionPanel.Name = "religionPanel";
            this.religionPanel.Size = new System.Drawing.Size(97, 25);
            this.religionPanel.TabIndex = 4;
            this.religionPanel.Text = "Religion : ";
            this.religionPanel.UseStyleColors = true;
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.genderLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.genderLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.genderLabel.Location = new System.Drawing.Point(77, 364);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(94, 25);
            this.genderLabel.TabIndex = 5;
            this.genderLabel.Text = " Gender : ";
            this.genderLabel.UseStyleColors = true;
            // 
            // ldobdLabel
            // 
            this.ldobdLabel.AutoSize = true;
            this.ldobdLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.ldobdLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.ldobdLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.ldobdLabel.Location = new System.Drawing.Point(73, 427);
            this.ldobdLabel.Name = "ldobdLabel";
            this.ldobdLabel.Size = new System.Drawing.Size(288, 25);
            this.ldobdLabel.TabIndex = 6;
            this.ldobdLabel.Text = "Last Date Of Blood Donatation : ";
            this.ldobdLabel.UseStyleColors = true;
            // 
            // userdivisionLabel
            // 
            this.userdivisionLabel.AutoSize = true;
            this.userdivisionLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.userdivisionLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.userdivisionLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.userdivisionLabel.Location = new System.Drawing.Point(73, 488);
            this.userdivisionLabel.Name = "userdivisionLabel";
            this.userdivisionLabel.Size = new System.Drawing.Size(95, 25);
            this.userdivisionLabel.TabIndex = 7;
            this.userdivisionLabel.Text = "Division : ";
            this.userdivisionLabel.UseStyleColors = true;
            // 
            // laLabel
            // 
            this.laLabel.AutoSize = true;
            this.laLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.laLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.laLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.laLabel.Location = new System.Drawing.Point(73, 549);
            this.laLabel.Name = "laLabel";
            this.laLabel.Size = new System.Drawing.Size(121, 25);
            this.laLabel.TabIndex = 8;
            this.laLabel.Text = " Local Area : ";
            this.laLabel.UseStyleColors = true;
            // 
            // eeeditButton
            // 
            this.eeeditButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.eeeditButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.eeeditButton.Location = new System.Drawing.Point(599, 105);
            this.eeeditButton.Name = "eeeditButton";
            this.eeeditButton.Size = new System.Drawing.Size(146, 38);
            this.eeeditButton.TabIndex = 9;
            this.eeeditButton.Text = "Edit User Profile ";
            this.eeeditButton.UseSelectable = true;
            this.eeeditButton.UseStyleColors = true;
            this.eeeditButton.Click += new System.EventHandler(this.eeeditButton_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.logoutButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.logoutButton.Location = new System.Drawing.Point(620, 593);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(88, 32);
            this.logoutButton.TabIndex = 10;
            this.logoutButton.Text = "Log Out ";
            this.logoutButton.UseSelectable = true;
            this.logoutButton.UseStyleColors = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // upnameLabel
            // 
            this.upnameLabel.AutoSize = true;
            this.upnameLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.upnameLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.upnameLabel.ForeColor = System.Drawing.Color.DeepPink;
            this.upnameLabel.Location = new System.Drawing.Point(225, 105);
            this.upnameLabel.Name = "upnameLabel";
            this.upnameLabel.Size = new System.Drawing.Size(118, 25);
            this.upnameLabel.TabIndex = 11;
            this.upnameLabel.Text = "metroLabel1";
            this.upnameLabel.UseCustomForeColor = true;
            // 
            // upcontactLabel
            // 
            this.upcontactLabel.AutoSize = true;
            this.upcontactLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.upcontactLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.upcontactLabel.ForeColor = System.Drawing.Color.DeepPink;
            this.upcontactLabel.Location = new System.Drawing.Point(225, 162);
            this.upcontactLabel.Name = "upcontactLabel";
            this.upcontactLabel.Size = new System.Drawing.Size(118, 25);
            this.upcontactLabel.TabIndex = 12;
            this.upcontactLabel.Text = "metroLabel1";
            this.upcontactLabel.UseCustomForeColor = true;
            // 
            // upemailLabel
            // 
            this.upemailLabel.AutoSize = true;
            this.upemailLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.upemailLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.upemailLabel.ForeColor = System.Drawing.Color.DeepPink;
            this.upemailLabel.Location = new System.Drawing.Point(225, 209);
            this.upemailLabel.Name = "upemailLabel";
            this.upemailLabel.Size = new System.Drawing.Size(118, 25);
            this.upemailLabel.TabIndex = 13;
            this.upemailLabel.Text = "metroLabel1";
            this.upemailLabel.UseCustomForeColor = true;
            // 
            // upbgpanel
            // 
            this.upbgpanel.AutoSize = true;
            this.upbgpanel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.upbgpanel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.upbgpanel.ForeColor = System.Drawing.Color.DeepPink;
            this.upbgpanel.Location = new System.Drawing.Point(225, 261);
            this.upbgpanel.Name = "upbgpanel";
            this.upbgpanel.Size = new System.Drawing.Size(118, 25);
            this.upbgpanel.TabIndex = 14;
            this.upbgpanel.Text = "metroLabel1";
            this.upbgpanel.UseCustomForeColor = true;
            // 
            // upreligionLabel
            // 
            this.upreligionLabel.AutoSize = true;
            this.upreligionLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.upreligionLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.upreligionLabel.ForeColor = System.Drawing.Color.DeepPink;
            this.upreligionLabel.Location = new System.Drawing.Point(225, 310);
            this.upreligionLabel.Name = "upreligionLabel";
            this.upreligionLabel.Size = new System.Drawing.Size(118, 25);
            this.upreligionLabel.TabIndex = 15;
            this.upreligionLabel.Text = "metroLabel1";
            this.upreligionLabel.UseCustomForeColor = true;
            // 
            // upgenderLabel
            // 
            this.upgenderLabel.AutoSize = true;
            this.upgenderLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.upgenderLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.upgenderLabel.ForeColor = System.Drawing.Color.DeepPink;
            this.upgenderLabel.Location = new System.Drawing.Point(225, 364);
            this.upgenderLabel.Name = "upgenderLabel";
            this.upgenderLabel.Size = new System.Drawing.Size(118, 25);
            this.upgenderLabel.TabIndex = 16;
            this.upgenderLabel.Text = "metroLabel1";
            this.upgenderLabel.UseCustomForeColor = true;
            // 
            // uplastdateLabel
            // 
            this.uplastdateLabel.AutoSize = true;
            this.uplastdateLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.uplastdateLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.uplastdateLabel.ForeColor = System.Drawing.Color.DeepPink;
            this.uplastdateLabel.Location = new System.Drawing.Point(378, 430);
            this.uplastdateLabel.Name = "uplastdateLabel";
            this.uplastdateLabel.Size = new System.Drawing.Size(118, 25);
            this.uplastdateLabel.TabIndex = 17;
            this.uplastdateLabel.Text = "metroLabel1";
            this.uplastdateLabel.UseCustomForeColor = true;
            // 
            // updivisionLabel
            // 
            this.updivisionLabel.AutoSize = true;
            this.updivisionLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.updivisionLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.updivisionLabel.ForeColor = System.Drawing.Color.DeepPink;
            this.updivisionLabel.Location = new System.Drawing.Point(225, 488);
            this.updivisionLabel.Name = "updivisionLabel";
            this.updivisionLabel.Size = new System.Drawing.Size(118, 25);
            this.updivisionLabel.TabIndex = 18;
            this.updivisionLabel.Text = "metroLabel1";
            this.updivisionLabel.UseCustomForeColor = true;
            // 
            // uplarealabel
            // 
            this.uplarealabel.AutoSize = true;
            this.uplarealabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.uplarealabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.uplarealabel.ForeColor = System.Drawing.Color.DeepPink;
            this.uplarealabel.Location = new System.Drawing.Point(225, 555);
            this.uplarealabel.Name = "uplarealabel";
            this.uplarealabel.Size = new System.Drawing.Size(118, 25);
            this.uplarealabel.TabIndex = 19;
            this.uplarealabel.Text = "metroLabel1";
            this.uplarealabel.UseCustomForeColor = true;
            // 
            // UserProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 665);
            this.Controls.Add(this.uplarealabel);
            this.Controls.Add(this.updivisionLabel);
            this.Controls.Add(this.uplastdateLabel);
            this.Controls.Add(this.upgenderLabel);
            this.Controls.Add(this.upreligionLabel);
            this.Controls.Add(this.upbgpanel);
            this.Controls.Add(this.upemailLabel);
            this.Controls.Add(this.upcontactLabel);
            this.Controls.Add(this.upnameLabel);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.eeeditButton);
            this.Controls.Add(this.laLabel);
            this.Controls.Add(this.userdivisionLabel);
            this.Controls.Add(this.ldobdLabel);
            this.Controls.Add(this.genderLabel);
            this.Controls.Add(this.religionPanel);
            this.Controls.Add(this.bloodgroupLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.contactLabel);
            this.Controls.Add(this.userName);
            this.Name = "UserProfile";
            this.Text = "UserProfile";
            this.Load += new System.EventHandler(this.UserProfile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel userName;
        private MetroFramework.Controls.MetroLabel contactLabel;
        private MetroFramework.Controls.MetroLabel emailLabel;
        private MetroFramework.Controls.MetroLabel bloodgroupLabel;
        private MetroFramework.Controls.MetroLabel religionPanel;
        private MetroFramework.Controls.MetroLabel genderLabel;
        private MetroFramework.Controls.MetroLabel ldobdLabel;
        private MetroFramework.Controls.MetroLabel userdivisionLabel;
        private MetroFramework.Controls.MetroLabel laLabel;
        private MetroFramework.Controls.MetroButton eeeditButton;
        private MetroFramework.Controls.MetroButton logoutButton;
        public MetroFramework.Controls.MetroLabel upnameLabel;
        public MetroFramework.Controls.MetroLabel upcontactLabel;
        public MetroFramework.Controls.MetroLabel upemailLabel;
        public MetroFramework.Controls.MetroLabel upbgpanel;
        public MetroFramework.Controls.MetroLabel upreligionLabel;
        public MetroFramework.Controls.MetroLabel upgenderLabel;
        public MetroFramework.Controls.MetroLabel uplastdateLabel;
        public MetroFramework.Controls.MetroLabel updivisionLabel;
        public MetroFramework.Controls.MetroLabel uplarealabel;
    }
}