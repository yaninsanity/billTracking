namespace BillTracking
{
    partial class AccountManagementForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountManagementForm));
            this.actMgtLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.pinLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.incomeLabel = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.pinTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.monthlyIncomeTextbox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.homeLinkLabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // actMgtLabel
            // 
            this.actMgtLabel.AutoSize = true;
            this.actMgtLabel.Font = new System.Drawing.Font("Eras Bold ITC", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actMgtLabel.Location = new System.Drawing.Point(6, 26);
            this.actMgtLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.actMgtLabel.Name = "actMgtLabel";
            this.actMgtLabel.Size = new System.Drawing.Size(414, 40);
            this.actMgtLabel.TabIndex = 0;
            this.actMgtLabel.Text = "Account Management";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.usernameLabel.Location = new System.Drawing.Point(18, 88);
            this.usernameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(90, 22);
            this.usernameLabel.TabIndex = 1;
            this.usernameLabel.Text = "Username";
            // 
            // pinLabel
            // 
            this.pinLabel.AutoSize = true;
            this.pinLabel.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.pinLabel.Location = new System.Drawing.Point(18, 139);
            this.pinLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pinLabel.Name = "pinLabel";
            this.pinLabel.Size = new System.Drawing.Size(36, 22);
            this.pinLabel.TabIndex = 2;
            this.pinLabel.Text = "Pin";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.emailLabel.Location = new System.Drawing.Point(18, 198);
            this.emailLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(54, 22);
            this.emailLabel.TabIndex = 3;
            this.emailLabel.Text = "Email";
            // 
            // incomeLabel
            // 
            this.incomeLabel.AutoSize = true;
            this.incomeLabel.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.incomeLabel.Location = new System.Drawing.Point(18, 254);
            this.incomeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.incomeLabel.Name = "incomeLabel";
            this.incomeLabel.Size = new System.Drawing.Size(142, 22);
            this.incomeLabel.TabIndex = 4;
            this.incomeLabel.Text = "Monthly Income";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.usernameTextBox.Location = new System.Drawing.Point(178, 88);
            this.usernameTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.usernameTextBox.Multiline = true;
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(201, 33);
            this.usernameTextBox.TabIndex = 5;
            // 
            // pinTextBox
            // 
            this.pinTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pinTextBox.Location = new System.Drawing.Point(178, 139);
            this.pinTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pinTextBox.Multiline = true;
            this.pinTextBox.Name = "pinTextBox";
            this.pinTextBox.Size = new System.Drawing.Size(201, 33);
            this.pinTextBox.TabIndex = 6;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.emailTextBox.Location = new System.Drawing.Point(178, 198);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.emailTextBox.Multiline = true;
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(201, 33);
            this.emailTextBox.TabIndex = 7;
            // 
            // monthlyIncomeTextbox
            // 
            this.monthlyIncomeTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.monthlyIncomeTextbox.Location = new System.Drawing.Point(178, 254);
            this.monthlyIncomeTextbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.monthlyIncomeTextbox.Multiline = true;
            this.monthlyIncomeTextbox.Name = "monthlyIncomeTextbox";
            this.monthlyIncomeTextbox.Size = new System.Drawing.Size(201, 33);
            this.monthlyIncomeTextbox.TabIndex = 8;
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.saveButton.ForeColor = System.Drawing.Color.White;
            this.saveButton.Location = new System.Drawing.Point(270, 300);
            this.saveButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(108, 37);
            this.saveButton.TabIndex = 9;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // homeLinkLabel
            // 
            this.homeLinkLabel.AutoSize = true;
            this.homeLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.homeLinkLabel.Location = new System.Drawing.Point(338, 7);
            this.homeLinkLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.homeLinkLabel.Name = "homeLinkLabel";
            this.homeLinkLabel.Size = new System.Drawing.Size(56, 20);
            this.homeLinkLabel.TabIndex = 10;
            this.homeLinkLabel.TabStop = true;
            this.homeLinkLabel.Text = "Home";
            this.homeLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.homeLinkLabel_LinkClicked);
            // 
            // AccountManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(425, 352);
            this.Controls.Add(this.homeLinkLabel);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.monthlyIncomeTextbox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.pinTextBox);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.incomeLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.pinLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.actMgtLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AccountManagementForm";
            this.Text = "Account Management";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label actMgtLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label pinLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label incomeLabel;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox pinTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox monthlyIncomeTextbox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.LinkLabel homeLinkLabel;
    }
}