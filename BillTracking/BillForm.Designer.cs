﻿namespace BillTracking
{
    partial class BillForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillForm));
            this.logoutLinkLabel = new System.Windows.Forms.LinkLabel();
            this.addButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.billListBox = new System.Windows.Forms.ListBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.yourAccountLabel = new System.Windows.Forms.Label();
            this.homeLinkLabel = new System.Windows.Forms.LinkLabel();
            this.archiveButton = new System.Windows.Forms.Button();
            this.viewArchivesLinkLabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // logoutLinkLabel
            // 
            this.logoutLinkLabel.Location = new System.Drawing.Point(0, 0);
            this.logoutLinkLabel.Name = "logoutLinkLabel";
            this.logoutLinkLabel.Size = new System.Drawing.Size(100, 23);
            this.logoutLinkLabel.TabIndex = 7;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.ForeColor = System.Drawing.Color.White;
            this.addButton.Location = new System.Drawing.Point(46, 139);
            this.addButton.Margin = new System.Windows.Forms.Padding(4);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(150, 74);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "ADD";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.ForeColor = System.Drawing.Color.White;
            this.deleteButton.Location = new System.Drawing.Point(578, 139);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(4);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(150, 74);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "DELETE";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // billListBox
            // 
            this.billListBox.FormattingEnabled = true;
            this.billListBox.ItemHeight = 15;
            this.billListBox.Location = new System.Drawing.Point(46, 236);
            this.billListBox.Name = "billListBox";
            this.billListBox.Size = new System.Drawing.Size(682, 349);
            this.billListBox.TabIndex = 4;
            this.billListBox.SelectedIndexChanged += new System.EventHandler(this.billListBox_SelectedIndexChanged);
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.updateButton.ForeColor = System.Drawing.Color.White;
            this.updateButton.Location = new System.Drawing.Point(219, 139);
            this.updateButton.Margin = new System.Windows.Forms.Padding(4);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(150, 74);
            this.updateButton.TabIndex = 2;
            this.updateButton.Text = "UPDATE";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // yourAccountLabel
            // 
            this.yourAccountLabel.AutoSize = true;
            this.yourAccountLabel.Font = new System.Drawing.Font("Eras Bold ITC", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yourAccountLabel.Location = new System.Drawing.Point(33, 47);
            this.yourAccountLabel.Name = "yourAccountLabel";
            this.yourAccountLabel.Size = new System.Drawing.Size(95, 40);
            this.yourAccountLabel.TabIndex = 5;
            this.yourAccountLabel.Text = "Bills";
            // 
            // homeLinkLabel
            // 
            this.homeLinkLabel.AutoSize = true;
            this.homeLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeLinkLabel.Location = new System.Drawing.Point(660, 9);
            this.homeLinkLabel.Name = "homeLinkLabel";
            this.homeLinkLabel.Size = new System.Drawing.Size(56, 20);
            this.homeLinkLabel.TabIndex = 6;
            this.homeLinkLabel.TabStop = true;
            this.homeLinkLabel.Text = "Home";
            this.homeLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.homeLinkLabel_LinkClicked);
            // 
            // archiveButton
            // 
            this.archiveButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.archiveButton.ForeColor = System.Drawing.Color.White;
            this.archiveButton.Location = new System.Drawing.Point(398, 139);
            this.archiveButton.Margin = new System.Windows.Forms.Padding(4);
            this.archiveButton.Name = "archiveButton";
            this.archiveButton.Size = new System.Drawing.Size(150, 74);
            this.archiveButton.TabIndex = 8;
            this.archiveButton.Text = "ARCHIVE";
            this.archiveButton.UseVisualStyleBackColor = false;
            this.archiveButton.Click += new System.EventHandler(this.archiveButton_Click);
            // 
            // viewArchivesLinkLabel
            // 
            this.viewArchivesLinkLabel.AutoSize = true;
            this.viewArchivesLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewArchivesLinkLabel.Location = new System.Drawing.Point(572, 611);
            this.viewArchivesLinkLabel.Name = "viewArchivesLinkLabel";
            this.viewArchivesLinkLabel.Size = new System.Drawing.Size(159, 20);
            this.viewArchivesLinkLabel.TabIndex = 9;
            this.viewArchivesLinkLabel.TabStop = true;
            this.viewArchivesLinkLabel.Text = "View Archived Bills";
            this.viewArchivesLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.viewArchivesLinkLabel_LinkClicked);
            // 
            // BillForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(789, 676);
            this.Controls.Add(this.viewArchivesLinkLabel);
            this.Controls.Add(this.archiveButton);
            this.Controls.Add(this.homeLinkLabel);
            this.Controls.Add(this.yourAccountLabel);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.billListBox);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.logoutLinkLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BillForm";
            this.Text = "Bills";
            this.Load += new System.EventHandler(this.SetEventHandlers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel logoutLinkLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.ListBox billListBox;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Label yourAccountLabel;
        private System.Windows.Forms.LinkLabel homeLinkLabel;
        private System.Windows.Forms.Button archiveButton;
        private System.Windows.Forms.LinkLabel viewArchivesLinkLabel;
    }
}