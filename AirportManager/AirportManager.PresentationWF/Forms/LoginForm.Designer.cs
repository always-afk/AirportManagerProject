
namespace AirportManager.PresentationWF.Forms
{
    partial class LoginForm
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
            this._loginLabel = new System.Windows.Forms.Label();
            this._passwordLabel = new System.Windows.Forms.Label();
            this._loginTextBox = new System.Windows.Forms.TextBox();
            this._passwordTextBox = new System.Windows.Forms.TextBox();
            this._signInButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _loginLabel
            // 
            this._loginLabel.AutoSize = true;
            this._loginLabel.Location = new System.Drawing.Point(93, 59);
            this._loginLabel.Name = "_loginLabel";
            this._loginLabel.Size = new System.Drawing.Size(37, 15);
            this._loginLabel.TabIndex = 0;
            this._loginLabel.Text = "Login";
            // 
            // _passwordLabel
            // 
            this._passwordLabel.AutoSize = true;
            this._passwordLabel.Location = new System.Drawing.Point(73, 113);
            this._passwordLabel.Name = "_passwordLabel";
            this._passwordLabel.Size = new System.Drawing.Size(57, 15);
            this._passwordLabel.TabIndex = 1;
            this._passwordLabel.Text = "Password";
            // 
            // _loginTextBox
            // 
            this._loginTextBox.Location = new System.Drawing.Point(136, 56);
            this._loginTextBox.Name = "_loginTextBox";
            this._loginTextBox.Size = new System.Drawing.Size(100, 23);
            this._loginTextBox.TabIndex = 2;
            // 
            // _passwordTextBox
            // 
            this._passwordTextBox.Location = new System.Drawing.Point(136, 110);
            this._passwordTextBox.Name = "_passwordTextBox";
            this._passwordTextBox.Size = new System.Drawing.Size(100, 23);
            this._passwordTextBox.TabIndex = 3;
            // 
            // _signInButton
            // 
            this._signInButton.Location = new System.Drawing.Point(112, 174);
            this._signInButton.Name = "_signInButton";
            this._signInButton.Size = new System.Drawing.Size(75, 23);
            this._signInButton.TabIndex = 4;
            this._signInButton.Text = "Sign In";
            this._signInButton.UseVisualStyleBackColor = true;
            this._signInButton.Click += new System.EventHandler(this._signInButton_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 260);
            this.Controls.Add(this._signInButton);
            this.Controls.Add(this._passwordTextBox);
            this.Controls.Add(this._loginTextBox);
            this.Controls.Add(this._passwordLabel);
            this.Controls.Add(this._loginLabel);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _loginLabel;
        private System.Windows.Forms.Label _passwordLabel;
        private System.Windows.Forms.TextBox _loginTextBox;
        private System.Windows.Forms.TextBox _passwordTextBox;
        private System.Windows.Forms.Button _signInButton;
    }
}