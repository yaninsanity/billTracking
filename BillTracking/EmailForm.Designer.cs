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
            this.emailLabel.Location = new System.Drawing.Point(133, 94);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(132, 24);
            this.emailLabel.TabIndex = 0;
            this.emailLabel.Text = "Email Address";
            // 
            // sendButton
            // 
            this.sendButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.sendButton.Location = new System.Drawing.Point(48, 196);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(291, 45);
            this.sendButton.TabIndex = 2;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // emailTextbox
            // 
            this.emailTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.emailTextbox.Location = new System.Drawing.Point(45, 140);
            this.emailTextbox.Name = "emailTextbox";
            this.emailTextbox.Size = new System.Drawing.Size(294, 28);
            this.emailTextbox.TabIndex = 3;
            this.emailTextbox.Text = "Example) hwoo11@asu.edu";
            this.emailTextbox.Click += new System.EventHandler(this.emailTextbox_Click);
            // 
            // referLabel
            // 
            this.referLabel.AutoSize = true;
            this.referLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.referLabel.Location = new System.Drawing.Point(44, 35);
            this.referLabel.Name = "referLabel";
            this.referLabel.Size = new System.Drawing.Size(115, 24);
            this.referLabel.TabIndex = 4;
            this.referLabel.Text = "Refer Friend";
            // 
            // EmailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 320);
            this.Controls.Add(this.referLabel);
            this.Controls.Add(this.emailTextbox);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.emailLabel);
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