namespace FInalProject.UILayer
{
    partial class Home_Page
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
            this.sfbgLabel = new MetroFramework.Controls.MetroLabel();
            this.sbgLabel = new MetroFramework.Controls.MetroLabel();
            this.bgroupBox = new MetroFramework.Controls.MetroComboBox();
            this.divisionLabel = new MetroFramework.Controls.MetroLabel();
            this.selectDivisionBox = new MetroFramework.Controls.MetroComboBox();
            this.goButton = new MetroFramework.Controls.MetroButton();
            this.logInButton = new MetroFramework.Controls.MetroButton();
            this.newAccountButton = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // sfbgLabel
            // 
            this.sfbgLabel.AutoSize = true;
            this.sfbgLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.sfbgLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.sfbgLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.sfbgLabel.Location = new System.Drawing.Point(530, 96);
            this.sfbgLabel.Name = "sfbgLabel";
            this.sfbgLabel.Size = new System.Drawing.Size(229, 25);
            this.sfbgLabel.TabIndex = 0;
            this.sfbgLabel.Text = "Search For Blood Group : ";
            this.sfbgLabel.UseCustomBackColor = true;
            this.sfbgLabel.UseCustomForeColor = true;
            this.sfbgLabel.UseStyleColors = true;
            // 
            // sbgLabel
            // 
            this.sbgLabel.AutoSize = true;
            this.sbgLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.sbgLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.sbgLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.sbgLabel.Location = new System.Drawing.Point(530, 151);
            this.sbgLabel.Name = "sbgLabel";
            this.sbgLabel.Size = new System.Drawing.Size(196, 25);
            this.sbgLabel.TabIndex = 1;
            this.sbgLabel.Text = " Select Blood Group : ";
            this.sbgLabel.UseCustomBackColor = true;
            this.sbgLabel.UseCustomForeColor = true;
            this.sbgLabel.UseStyleColors = true;
            // 
            // bgroupBox
            // 
            this.bgroupBox.FormattingEnabled = true;
            this.bgroupBox.ItemHeight = 23;
            this.bgroupBox.Items.AddRange(new object[] {
            "A+",
            "A-",
            "B+",
            "B-",
            "O+",
            "O-",
            "AB+",
            "AB-"});
            this.bgroupBox.Location = new System.Drawing.Point(530, 203);
            this.bgroupBox.Name = "bgroupBox";
            this.bgroupBox.Size = new System.Drawing.Size(181, 29);
            this.bgroupBox.TabIndex = 2;
            this.bgroupBox.UseSelectable = true;
            // 
            // divisionLabel
            // 
            this.divisionLabel.AutoSize = true;
            this.divisionLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.divisionLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.divisionLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.divisionLabel.Location = new System.Drawing.Point(530, 252);
            this.divisionLabel.Name = "divisionLabel";
            this.divisionLabel.Size = new System.Drawing.Size(156, 25);
            this.divisionLabel.TabIndex = 3;
            this.divisionLabel.Text = " Select Division : ";
            this.divisionLabel.UseCustomBackColor = true;
            this.divisionLabel.UseCustomForeColor = true;
            this.divisionLabel.UseStyleColors = true;
            // 
            // selectDivisionBox
            // 
            this.selectDivisionBox.FormattingEnabled = true;
            this.selectDivisionBox.ItemHeight = 23;
            this.selectDivisionBox.Items.AddRange(new object[] {
            "Dhaka",
            "Chittagong",
            "Sylhet",
            "Rangpur",
            "Rajshahi",
            "Khulna",
            "Barisal"});
            this.selectDivisionBox.Location = new System.Drawing.Point(530, 310);
            this.selectDivisionBox.Name = "selectDivisionBox";
            this.selectDivisionBox.Size = new System.Drawing.Size(181, 29);
            this.selectDivisionBox.TabIndex = 4;
            this.selectDivisionBox.UseSelectable = true;
            // 
            // goButton
            // 
            this.goButton.BackColor = System.Drawing.Color.Gray;
            this.goButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.goButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.goButton.Location = new System.Drawing.Point(601, 374);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(110, 40);
            this.goButton.TabIndex = 5;
            this.goButton.Text = " Go ";
            this.goButton.UseCustomBackColor = true;
            this.goButton.UseCustomForeColor = true;
            this.goButton.UseSelectable = true;
            this.goButton.UseStyleColors = true;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // logInButton
            // 
            this.logInButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.logInButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.logInButton.Location = new System.Drawing.Point(653, 39);
            this.logInButton.Name = "logInButton";
            this.logInButton.Size = new System.Drawing.Size(106, 33);
            this.logInButton.TabIndex = 6;
            this.logInButton.Text = "Log In";
            this.logInButton.UseSelectable = true;
            this.logInButton.UseStyleColors = true;
            this.logInButton.Click += new System.EventHandler(this.logInButton_Click);
            // 
            // newAccountButton
            // 
            this.newAccountButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.newAccountButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.newAccountButton.Location = new System.Drawing.Point(400, 39);
            this.newAccountButton.Name = "newAccountButton";
            this.newAccountButton.Size = new System.Drawing.Size(204, 33);
            this.newAccountButton.TabIndex = 7;
            this.newAccountButton.Text = " Create New Account ";
            this.newAccountButton.UseSelectable = true;
            this.newAccountButton.UseStyleColors = true;
            this.newAccountButton.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FInalProject.UILayer.Properties.Resources.stock_vector_blood_donation_vector_illustration_blood_donor_day_save_a_life_414683437;
            this.pictureBox1.Location = new System.Drawing.Point(51, 108);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(433, 432);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Home_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 604);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.newAccountButton);
            this.Controls.Add(this.logInButton);
            this.Controls.Add(this.goButton);
            this.Controls.Add(this.selectDivisionBox);
            this.Controls.Add(this.divisionLabel);
            this.Controls.Add(this.bgroupBox);
            this.Controls.Add(this.sbgLabel);
            this.Controls.Add(this.sfbgLabel);
            this.Name = "Home_Page";
            this.Text = " Home_Page ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel sfbgLabel;
        private MetroFramework.Controls.MetroLabel sbgLabel;
        private MetroFramework.Controls.MetroComboBox bgroupBox;
        private MetroFramework.Controls.MetroLabel divisionLabel;
        private MetroFramework.Controls.MetroComboBox selectDivisionBox;
        private MetroFramework.Controls.MetroButton goButton;
        private MetroFramework.Controls.MetroButton logInButton;
        private MetroFramework.Controls.MetroButton newAccountButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

