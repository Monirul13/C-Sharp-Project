namespace FInalProject.UILayer
{
    partial class ResultUI
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
            this.backButton = new MetroFramework.Controls.MetroButton();
            this.resultdataGridView = new System.Windows.Forms.DataGridView();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.resultdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Gray;
            this.backButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.backButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.backButton.Location = new System.Drawing.Point(57, 426);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(93, 35);
            this.backButton.TabIndex = 0;
            this.backButton.Text = " Back ";
            this.backButton.UseCustomBackColor = true;
            this.backButton.UseCustomForeColor = true;
            this.backButton.UseSelectable = true;
            this.backButton.UseStyleColors = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // resultdataGridView
            // 
            this.resultdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultdataGridView.Location = new System.Drawing.Point(35, 126);
            this.resultdataGridView.Name = "resultdataGridView";
            this.resultdataGridView.Size = new System.Drawing.Size(707, 273);
            this.resultdataGridView.TabIndex = 1;
            this.resultdataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.resultdataGridView_CellContentClick);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.ForeColor = System.Drawing.Color.Red;
            this.metroLabel1.Location = new System.Drawing.Point(174, 33);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(414, 25);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "“ The blood is red gold in time of saving a life.”";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            this.metroLabel1.UseStyleColors = true;
            // 
            // ResultUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 507);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.resultdataGridView);
            this.Controls.Add(this.backButton);
            this.Name = "ResultUI";
            this.Text = "ResultUI";
            this.Load += new System.EventHandler(this.ResultUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.resultdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton backButton;
        public System.Windows.Forms.DataGridView resultdataGridView;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}