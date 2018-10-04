namespace BillTracking
{
    partial class LoginSignupForm
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
            this.orLabel = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.signUpButton = new System.Windows.Forms.Button();
            this.appTitleLabel = new System.Windows.Forms.Label();
            this.dashLineLabel1 = new System.Windows.Forms.Label();
            this.dashLineLabel2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // orLabel
            // 
            this.orLabel.AutoSize = true;
            this.orLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orLabel.Location = new System.Drawing.Point(326, 385);
            this.orLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.orLabel.Name = "orLabel";
            this.orLabel.Size = new System.Drawing.Size(61, 36);
            this.orLabel.TabIndex = 0;
            this.orLabel.Text = "OR";
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.ForeColor = System.Drawing.Color.White;
            this.loginButton.Location = new System.Drawing.Point(250, 256);
            this.loginButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(216, 71);
            this.loginButton.TabIndex = 1;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // signUpButton
            // 
            this.signUpButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.signUpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpButton.ForeColor = System.Drawing.Color.White;
            this.signUpButton.Location = new System.Drawing.Point(250, 485);
            this.signUpButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.Size = new System.Drawing.Size(216, 77);
            this.signUpButton.TabIndex = 2;
            this.signUpButton.Text = "Sign Up";
            this.signUpButton.UseVisualStyleBackColor = false;
            this.signUpButton.Click += new System.EventHandler(this.signUpButton_Click);
            // 
            // appTitleLabel
            // 
            this.appTitleLabel.AutoSize = true;
            this.appTitleLabel.Font = new System.Drawing.Font("Eras Bold ITC", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appTitleLabel.Location = new System.Drawing.Point(164, 62);
            this.appTitleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.appTitleLabel.Name = "appTitleLabel";
            this.appTitleLabel.Size = new System.Drawing.Size(431, 78);
            this.appTitleLabel.TabIndex = 3;
            this.appTitleLabel.Text = "Bill Tracker";
            // 
            // dashLineLabel1
            // 
            this.dashLineLabel1.AutoSize = true;
            this.dashLineLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashLineLabel1.Location = new System.Drawing.Point(208, 375);
            this.dashLineLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dashLineLabel1.Name = "dashLineLabel1";
            this.dashLineLabel1.Size = new System.Drawing.Size(111, 29);
            this.dashLineLabel1.TabIndex = 4;
            this.dashLineLabel1.Text = "_______";
            // 
            // dashLineLabel2
            // 
            this.dashLineLabel2.AutoSize = true;
            this.dashLineLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashLineLabel2.Location = new System.Drawing.Point(394, 375);
            this.dashLineLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dashLineLabel2.Name = "dashLineLabel2";
            this.dashLineLabel2.Size = new System.Drawing.Size(111, 29);
            this.dashLineLabel2.TabIndex = 5;
            this.dashLineLabel2.Text = "_______";
            // 
            // LoginSignupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(738, 715);
            this.Controls.Add(this.dashLineLabel2);
            this.Controls.Add(this.dashLineLabel1);
            this.Controls.Add(this.appTitleLabel);
            this.Controls.Add(this.signUpButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.orLabel);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "LoginSignupForm";
            this.Text = "Bill Tracker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label orLabel;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button signUpButton;
        private System.Windows.Forms.Label appTitleLabel;
        private System.Windows.Forms.Label dashLineLabel1;
        private System.Windows.Forms.Label dashLineLabel2;
    }
}

