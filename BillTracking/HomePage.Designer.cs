namespace BillTracking
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
            this.referLinkLabel = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Eras Bold ITC", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.Location = new System.Drawing.Point(20, 32);
            this.welcomeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(196, 40);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "Welcome!";
            // 
            // logoutLinkLabel
            // 
            this.logoutLinkLabel.AutoSize = true;
            this.logoutLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutLinkLabel.Location = new System.Drawing.Point(242, 5);
            this.logoutLinkLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.logoutLinkLabel.Name = "logoutLinkLabel";
            this.logoutLinkLabel.Size = new System.Drawing.Size(65, 20);
            this.logoutLinkLabel.TabIndex = 1;
            this.logoutLinkLabel.TabStop = true;
            this.logoutLinkLabel.Text = "Logout";
            this.logoutLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.logoutLinkLabel_LinkClicked);
            // 
            // questionLabel
            // 
            this.questionLabel.AutoSize = true;
            this.questionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionLabel.Location = new System.Drawing.Point(26, 83);
            this.questionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(186, 18);
            this.questionLabel.TabIndex = 2;
            this.questionLabel.Text = "What would you like to do?";
            // 
            // billMgtLinkLabel
            // 
            this.billMgtLinkLabel.AutoSize = true;
            this.billMgtLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billMgtLinkLabel.Location = new System.Drawing.Point(26, 122);
            this.billMgtLinkLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.billMgtLinkLabel.Name = "billMgtLinkLabel";
            this.billMgtLinkLabel.Size = new System.Drawing.Size(117, 18);
            this.billMgtLinkLabel.TabIndex = 3;
            this.billMgtLinkLabel.TabStop = true;
            this.billMgtLinkLabel.Text = "Bill Management";
            this.billMgtLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.billMgtLinkLabel_LinkClicked);
            // 
            // accountMgtLinkLabel
            // 
            this.accountMgtLinkLabel.AutoSize = true;
            this.accountMgtLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountMgtLinkLabel.Location = new System.Drawing.Point(26, 161);
            this.accountMgtLinkLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.accountMgtLinkLabel.Name = "accountMgtLinkLabel";
            this.accountMgtLinkLabel.Size = new System.Drawing.Size(152, 18);
            this.accountMgtLinkLabel.TabIndex = 4;
            this.accountMgtLinkLabel.TabStop = true;
            this.accountMgtLinkLabel.Text = "Account Management";
            this.accountMgtLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.accountMgtLinkLabel_LinkClicked);
            // 
            // referLinkLabel
            // 
            this.referLinkLabel.AutoSize = true;
            this.referLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.referLinkLabel.Location = new System.Drawing.Point(26, 202);
            this.referLinkLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.referLinkLabel.Name = "referLinkLabel";
            this.referLinkLabel.Size = new System.Drawing.Size(89, 18);
            this.referLinkLabel.TabIndex = 5;
            this.referLinkLabel.TabStop = true;
            this.referLinkLabel.Text = "Refer Friend";
            this.referLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.referLinkLabel_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(26, 244);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(72, 18);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Reporting";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(317, 295);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.referLinkLabel);
            this.Controls.Add(this.accountMgtLinkLabel);
            this.Controls.Add(this.billMgtLinkLabel);
            this.Controls.Add(this.questionLabel);
            this.Controls.Add(this.logoutLinkLabel);
            this.Controls.Add(this.welcomeLabel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "HomePage";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.SetEventHandlers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.LinkLabel logoutLinkLabel;
        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.LinkLabel billMgtLinkLabel;
        private System.Windows.Forms.LinkLabel accountMgtLinkLabel;
        private System.Windows.Forms.LinkLabel referLinkLabel;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}