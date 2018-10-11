namespace BillTracking
{
    partial class EmailForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmailForm));
            this.emailLabel = new System.Windows.Forms.Label();
            this.sendButton = new System.Windows.Forms.Button();
            this.emailTextbox = new System.Windows.Forms.TextBox();
            this.referLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.emailLabel.Location = new System.Drawing.Point(44, 100);
            this.emailLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(107, 18);
            this.emailLabel.TabIndex = 0;
            this.emailLabel.Text = "Email Address:";
            // 
            // sendButton
            // 
            this.sendButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.sendButton.Font = new System.Drawing.Font("Eras Bold ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendButton.ForeColor = System.Drawing.Color.White;
            this.sendButton.Location = new System.Drawing.Point(47, 168);
            this.sendButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(218, 39);
            this.sendButton.TabIndex = 2;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = false;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // emailTextbox
            // 
            this.emailTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.emailTextbox.Location = new System.Drawing.Point(47, 121);
            this.emailTextbox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.emailTextbox.Name = "emailTextbox";
            this.emailTextbox.Size = new System.Drawing.Size(222, 24);
            this.emailTextbox.TabIndex = 3;
            this.emailTextbox.Text = "address@host.domain";
            this.emailTextbox.Click += new System.EventHandler(this.emailTextbox_Click);
            // 
            // referLabel
            // 
            this.referLabel.AutoSize = true;
            this.referLabel.Font = new System.Drawing.Font("Eras Bold ITC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.referLabel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.referLabel.Location = new System.Drawing.Point(69, 25);
            this.referLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.referLabel.Name = "referLabel";
            this.referLabel.Size = new System.Drawing.Size(187, 28);
            this.referLabel.TabIndex = 4;
            this.referLabel.Text = "Refer A Friend";
            // 
            // EmailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 277);
            this.Controls.Add(this.referLabel);
            this.Controls.Add(this.emailTextbox);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.emailLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "EmailForm";
            this.Text = "Email";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.TextBox emailTextbox;
        private System.Windows.Forms.Label referLabel;
    }
}