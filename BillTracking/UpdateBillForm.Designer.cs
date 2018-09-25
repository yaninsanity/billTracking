namespace BillTracking
{
    partial class UpdateBillForm
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
            this.AmountTextBox = new System.Windows.Forms.TextBox();
            this.AmountLabel = new System.Windows.Forms.Label();
            this.BillDateTime = new System.Windows.Forms.DateTimePicker();
            this.recurrenceComboBox = new System.Windows.Forms.ComboBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.BillRecurrencelabel = new System.Windows.Forms.Label();
            this.BillDateDateTimelabel = new System.Windows.Forms.Label();
            this.namelabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.UpdateBillLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AmountTextBox
            // 
            this.AmountTextBox.Location = new System.Drawing.Point(117, 211);
            this.AmountTextBox.Name = "AmountTextBox";
            this.AmountTextBox.Size = new System.Drawing.Size(100, 20);
            this.AmountTextBox.TabIndex = 24;
            // 
            // AmountLabel
            // 
            this.AmountLabel.AutoSize = true;
            this.AmountLabel.Location = new System.Drawing.Point(23, 218);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(43, 13);
            this.AmountLabel.TabIndex = 23;
            this.AmountLabel.Text = "Amount";
            // 
            // BillDateTime
            // 
            this.BillDateTime.Location = new System.Drawing.Point(117, 120);
            this.BillDateTime.Name = "BillDateTime";
            this.BillDateTime.Size = new System.Drawing.Size(200, 20);
            this.BillDateTime.TabIndex = 22;
            // 
            // recurrenceComboBox
            // 
            this.recurrenceComboBox.FormattingEnabled = true;
            this.recurrenceComboBox.Items.AddRange(new object[] {
            "Daily",
            "Weekly",
            "Monthly",
            "Yearly"});
            this.recurrenceComboBox.Location = new System.Drawing.Point(117, 165);
            this.recurrenceComboBox.Name = "recurrenceComboBox";
            this.recurrenceComboBox.Size = new System.Drawing.Size(121, 21);
            this.recurrenceComboBox.TabIndex = 21;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(196, 260);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 20;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // BillRecurrencelabel
            // 
            this.BillRecurrencelabel.AutoSize = true;
            this.BillRecurrencelabel.Location = new System.Drawing.Point(19, 174);
            this.BillRecurrencelabel.Name = "BillRecurrencelabel";
            this.BillRecurrencelabel.Size = new System.Drawing.Size(63, 13);
            this.BillRecurrencelabel.TabIndex = 19;
            this.BillRecurrencelabel.Text = "Recurrence";
            // 
            // BillDateDateTimelabel
            // 
            this.BillDateDateTimelabel.AutoSize = true;
            this.BillDateDateTimelabel.Location = new System.Drawing.Point(20, 128);
            this.BillDateDateTimelabel.Name = "BillDateDateTimelabel";
            this.BillDateDateTimelabel.Size = new System.Drawing.Size(46, 13);
            this.BillDateDateTimelabel.TabIndex = 18;
            this.BillDateDateTimelabel.Text = "Bill Date";
            // 
            // namelabel
            // 
            this.namelabel.AutoSize = true;
            this.namelabel.Location = new System.Drawing.Point(20, 84);
            this.namelabel.Name = "namelabel";
            this.namelabel.Size = new System.Drawing.Size(51, 13);
            this.namelabel.TabIndex = 17;
            this.namelabel.Text = "Bill Name";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(117, 77);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.NameTextBox.TabIndex = 16;
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.ConfirmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmButton.ForeColor = System.Drawing.Color.White;
            this.ConfirmButton.Location = new System.Drawing.Point(286, 260);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(75, 23);
            this.ConfirmButton.TabIndex = 15;
            this.ConfirmButton.Text = "Confirm!";
            this.ConfirmButton.UseVisualStyleBackColor = false;
            // 
            // UpdateBillLabel
            // 
            this.UpdateBillLabel.AutoSize = true;
            this.UpdateBillLabel.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateBillLabel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.UpdateBillLabel.Location = new System.Drawing.Point(21, 22);
            this.UpdateBillLabel.Name = "UpdateBillLabel";
            this.UpdateBillLabel.Size = new System.Drawing.Size(172, 27);
            this.UpdateBillLabel.TabIndex = 25;
            this.UpdateBillLabel.Text = "Update a Bill";
            // 
            // UpdateBillForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 298);
            this.Controls.Add(this.UpdateBillLabel);
            this.Controls.Add(this.AmountTextBox);
            this.Controls.Add(this.AmountLabel);
            this.Controls.Add(this.BillDateTime);
            this.Controls.Add(this.recurrenceComboBox);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.BillRecurrencelabel);
            this.Controls.Add(this.BillDateDateTimelabel);
            this.Controls.Add(this.namelabel);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.ConfirmButton);
            this.Name = "UpdateBillForm";
            this.Text = "Update Bill!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox AmountTextBox;
        private System.Windows.Forms.Label AmountLabel;
        private System.Windows.Forms.DateTimePicker BillDateTime;
        private System.Windows.Forms.ComboBox recurrenceComboBox;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label BillRecurrencelabel;
        private System.Windows.Forms.Label BillDateDateTimelabel;
        private System.Windows.Forms.Label namelabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.Label UpdateBillLabel;
    }
}