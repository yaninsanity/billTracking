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
            this.label1 = new System.Windows.Forms.Label();
            this.archivesListBox = new System.Windows.Forms.ListBox();
            this.restoreButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Eras Bold ITC", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(515, 78);
            this.label1.TabIndex = 0;
            this.label1.Text = "Archived Bills";
            // 
            // archivesListBox
            // 
            this.archivesListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.archivesListBox.FormattingEnabled = true;
            this.archivesListBox.ItemHeight = 29;
            this.archivesListBox.Location = new System.Drawing.Point(38, 170);
            this.archivesListBox.Name = "archivesListBox";
            this.archivesListBox.Size = new System.Drawing.Size(766, 323);
            this.archivesListBox.TabIndex = 1;
            // 
            // restoreButton
            // 
            this.restoreButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.restoreButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restoreButton.ForeColor = System.Drawing.Color.White;
            this.restoreButton.Location = new System.Drawing.Point(628, 521);
            this.restoreButton.Name = "restoreButton";
            this.restoreButton.Size = new System.Drawing.Size(176, 74);
            this.restoreButton.TabIndex = 2;
            this.restoreButton.Text = "RESTORE";
            this.restoreButton.UseVisualStyleBackColor = false;
            this.restoreButton.Click += new System.EventHandler(this.restoreButton_Click);
            // 
            // ArchivesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(868, 634);
            this.Controls.Add(this.restoreButton);
            this.Controls.Add(this.archivesListBox);
            this.Controls.Add(this.label1);
            this.Name = "ArchivesForm";
            this.Text = "Archived Bills";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox archivesListBox;
        private System.Windows.Forms.Button restoreButton;
    }
}