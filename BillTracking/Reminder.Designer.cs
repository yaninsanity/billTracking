namespace BillTracking
{
    partial class Reminder
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
            this.sendButton = new System.Windows.Forms.Button();
            this.reminderTextBox = new System.Windows.Forms.TextBox();
            this.reminderLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(68, 360);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(206, 38);
            this.sendButton.TabIndex = 0;
            this.sendButton.Text = "Send To My Email";
            this.sendButton.UseVisualStyleBackColor = true;
            // 
            // reminderTextBox
            // 
            this.reminderTextBox.Location = new System.Drawing.Point(68, 105);
            this.reminderTextBox.Multiline = true;
            this.reminderTextBox.Name = "reminderTextBox";
            this.reminderTextBox.Size = new System.Drawing.Size(206, 202);
            this.reminderTextBox.TabIndex = 1;
            // 
            // reminderLabel
            // 
            this.reminderLabel.AutoSize = true;
            this.reminderLabel.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reminderLabel.Location = new System.Drawing.Point(79, 59);
            this.reminderLabel.Name = "reminderLabel";
            this.reminderLabel.Size = new System.Drawing.Size(143, 43);
            this.reminderLabel.TabIndex = 2;
            this.reminderLabel.Text = "Reminder";
            // 
            // Reminder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 488);
            this.Controls.Add(this.reminderLabel);
            this.Controls.Add(this.reminderTextBox);
            this.Controls.Add(this.sendButton);
            this.Name = "Reminder";
            this.Text = "Reminder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.TextBox reminderTextBox;
        private System.Windows.Forms.Label reminderLabel;
    }
}