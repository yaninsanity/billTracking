﻿namespace BillTracking
{
    partial class HomePage
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
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.logoutLinkLabel = new System.Windows.Forms.LinkLabel();
            this.questionLabel = new System.Windows.Forms.Label();
            this.billMgtLinkLabel = new System.Windows.Forms.LinkLabel();
            this.accountMgtLinkLabel = new System.Windows.Forms.LinkLabel();
            this.reportingLinkLabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Eras Bold ITC", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.Location = new System.Drawing.Point(39, 62);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(378, 78);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "Welcome!";
            // 
            // logoutLinkLabel
            // 
            this.logoutLinkLabel.AutoSize = true;
            this.logoutLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutLinkLabel.Location = new System.Drawing.Point(483, 9);
            this.logoutLinkLabel.Name = "logoutLinkLabel";
            this.logoutLinkLabel.Size = new System.Drawing.Size(122, 37);
            this.logoutLinkLabel.TabIndex = 1;
            this.logoutLinkLabel.TabStop = true;
            this.logoutLinkLabel.Text = "Logout";
            this.logoutLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.logoutLinkLabel_LinkClicked);
            // 
            // questionLabel
            // 
            this.questionLabel.AutoSize = true;
            this.questionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionLabel.Location = new System.Drawing.Point(53, 160);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(375, 36);
            this.questionLabel.TabIndex = 2;
            this.questionLabel.Text = "What would you like to do?";
            // 
            // billMgtLinkLabel
            // 
            this.billMgtLinkLabel.AutoSize = true;
            this.billMgtLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billMgtLinkLabel.Location = new System.Drawing.Point(53, 234);
            this.billMgtLinkLabel.Name = "billMgtLinkLabel";
            this.billMgtLinkLabel.Size = new System.Drawing.Size(235, 36);
            this.billMgtLinkLabel.TabIndex = 3;
            this.billMgtLinkLabel.TabStop = true;
            this.billMgtLinkLabel.Text = "Bill Management";
            this.billMgtLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.billMgtLinkLabel_LinkClicked);
            // 
            // accountMgtLinkLabel
            // 
            this.accountMgtLinkLabel.AutoSize = true;
            this.accountMgtLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountMgtLinkLabel.Location = new System.Drawing.Point(53, 310);
            this.accountMgtLinkLabel.Name = "accountMgtLinkLabel";
            this.accountMgtLinkLabel.Size = new System.Drawing.Size(304, 36);
            this.accountMgtLinkLabel.TabIndex = 4;
            this.accountMgtLinkLabel.TabStop = true;
            this.accountMgtLinkLabel.Text = "Account Management";
            // 
            // reportingLinkLabel
            // 
            this.reportingLinkLabel.AutoSize = true;
            this.reportingLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportingLinkLabel.Location = new System.Drawing.Point(53, 394);
            this.reportingLinkLabel.Name = "reportingLinkLabel";
            this.reportingLinkLabel.Size = new System.Drawing.Size(146, 36);
            this.reportingLinkLabel.TabIndex = 5;
            this.reportingLinkLabel.TabStop = true;
            this.reportingLinkLabel.Text = "Reporting";
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(632, 488);
            this.Controls.Add(this.reportingLinkLabel);
            this.Controls.Add(this.accountMgtLinkLabel);
            this.Controls.Add(this.billMgtLinkLabel);
            this.Controls.Add(this.questionLabel);
            this.Controls.Add(this.logoutLinkLabel);
            this.Controls.Add(this.welcomeLabel);
            this.Name = "HomePage";
            this.Text = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.LinkLabel logoutLinkLabel;
        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.LinkLabel billMgtLinkLabel;
        private System.Windows.Forms.LinkLabel accountMgtLinkLabel;
        private System.Windows.Forms.LinkLabel reportingLinkLabel;
    }
}