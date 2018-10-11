namespace BillTracking
{
    partial class ArchivesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ArchivesForm));
            this.label1 = new System.Windows.Forms.Label();
            this.archivesListBox = new System.Windows.Forms.ListBox();
            this.restoreButton = new System.Windows.Forms.Button();
            this.homeLinkLabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Eras Bold ITC", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Archived Bills";
            // 
            // archivesListBox
            // 
            this.archivesListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.archivesListBox.FormattingEnabled = true;
            this.archivesListBox.ItemHeight = 15;
            this.archivesListBox.Location = new System.Drawing.Point(19, 88);
            this.archivesListBox.Margin = new System.Windows.Forms.Padding(2);
            this.archivesListBox.Name = "archivesListBox";
            this.archivesListBox.Size = new System.Drawing.Size(385, 169);
            this.archivesListBox.TabIndex = 1;
            // 
            // restoreButton
            // 
            this.restoreButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.restoreButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restoreButton.ForeColor = System.Drawing.Color.White;
            this.restoreButton.Location = new System.Drawing.Point(314, 271);
            this.restoreButton.Margin = new System.Windows.Forms.Padding(2);
            this.restoreButton.Name = "restoreButton";
            this.restoreButton.Size = new System.Drawing.Size(88, 38);
            this.restoreButton.TabIndex = 2;
            this.restoreButton.Text = "RESTORE";
            this.restoreButton.UseVisualStyleBackColor = false;
            this.restoreButton.Click += new System.EventHandler(this.restoreButton_Click);
            // 
            // homeLinkLabel
            // 
            this.homeLinkLabel.AutoSize = true;
            this.homeLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeLinkLabel.Location = new System.Drawing.Point(346, 9);
            this.homeLinkLabel.Name = "homeLinkLabel";
            this.homeLinkLabel.Size = new System.Drawing.Size(56, 20);
            this.homeLinkLabel.TabIndex = 7;
            this.homeLinkLabel.TabStop = true;
            this.homeLinkLabel.Text = "Home";
            this.homeLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.homeLinkLabel_LinkClicked);
            // 
            // ArchivesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(434, 330);
            this.Controls.Add(this.homeLinkLabel);
            this.Controls.Add(this.restoreButton);
            this.Controls.Add(this.archivesListBox);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ArchivesForm";
            this.Text = "Archived Bills";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox archivesListBox;
        private System.Windows.Forms.Button restoreButton;
        private System.Windows.Forms.LinkLabel homeLinkLabel;
    }
}