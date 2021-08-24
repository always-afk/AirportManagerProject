
namespace AirportManager.PresentationWF.Forms.AdminForms.StaffForms
{
    partial class AddStaffForm
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
            this._backButton = new System.Windows.Forms.Button();
            this._nameLabel = new System.Windows.Forms.Label();
            this._ageLabel = new System.Windows.Forms.Label();
            this._positionLabel = new System.Windows.Forms.Label();
            this._loginLabel = new System.Windows.Forms.Label();
            this._passwordLabel = new System.Windows.Forms.Label();
            this._nameTextBox = new System.Windows.Forms.TextBox();
            this._ageTextBox = new System.Windows.Forms.TextBox();
            this._loginTextBox = new System.Windows.Forms.TextBox();
            this._passwordTextBox = new System.Windows.Forms.TextBox();
            this._positionComboBox = new System.Windows.Forms.ComboBox();
            this._addButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _backButton
            // 
            this._backButton.Location = new System.Drawing.Point(12, 276);
            this._backButton.Name = "_backButton";
            this._backButton.Size = new System.Drawing.Size(75, 23);
            this._backButton.TabIndex = 0;
            this._backButton.Text = "Back";
            this._backButton.UseVisualStyleBackColor = true;
            this._backButton.Click += new System.EventHandler(this.BackButtonClick);
            // 
            // _nameLabel
            // 
            this._nameLabel.AutoSize = true;
            this._nameLabel.Location = new System.Drawing.Point(57, 35);
            this._nameLabel.Name = "_nameLabel";
            this._nameLabel.Size = new System.Drawing.Size(39, 15);
            this._nameLabel.TabIndex = 1;
            this._nameLabel.Text = "Name";
            // 
            // _ageLabel
            // 
            this._ageLabel.AutoSize = true;
            this._ageLabel.Location = new System.Drawing.Point(68, 68);
            this._ageLabel.Name = "_ageLabel";
            this._ageLabel.Size = new System.Drawing.Size(28, 15);
            this._ageLabel.TabIndex = 2;
            this._ageLabel.Text = "Age";
            // 
            // _positionLabel
            // 
            this._positionLabel.AutoSize = true;
            this._positionLabel.Location = new System.Drawing.Point(46, 104);
            this._positionLabel.Name = "_positionLabel";
            this._positionLabel.Size = new System.Drawing.Size(50, 15);
            this._positionLabel.TabIndex = 3;
            this._positionLabel.Text = "Position";
            // 
            // _loginLabel
            // 
            this._loginLabel.AutoSize = true;
            this._loginLabel.Location = new System.Drawing.Point(59, 140);
            this._loginLabel.Name = "_loginLabel";
            this._loginLabel.Size = new System.Drawing.Size(37, 15);
            this._loginLabel.TabIndex = 4;
            this._loginLabel.Text = "Login";
            // 
            // _passwordLabel
            // 
            this._passwordLabel.AutoSize = true;
            this._passwordLabel.Location = new System.Drawing.Point(39, 179);
            this._passwordLabel.Name = "_passwordLabel";
            this._passwordLabel.Size = new System.Drawing.Size(57, 15);
            this._passwordLabel.TabIndex = 5;
            this._passwordLabel.Text = "Password";
            // 
            // _nameTextBox
            // 
            this._nameTextBox.Location = new System.Drawing.Point(102, 32);
            this._nameTextBox.Name = "_nameTextBox";
            this._nameTextBox.Size = new System.Drawing.Size(100, 23);
            this._nameTextBox.TabIndex = 6;
            // 
            // _ageTextBox
            // 
            this._ageTextBox.Location = new System.Drawing.Point(102, 65);
            this._ageTextBox.Name = "_ageTextBox";
            this._ageTextBox.Size = new System.Drawing.Size(100, 23);
            this._ageTextBox.TabIndex = 7;
            // 
            // _loginTextBox
            // 
            this._loginTextBox.Location = new System.Drawing.Point(102, 137);
            this._loginTextBox.Name = "_loginTextBox";
            this._loginTextBox.Size = new System.Drawing.Size(100, 23);
            this._loginTextBox.TabIndex = 8;
            // 
            // _passwordTextBox
            // 
            this._passwordTextBox.Location = new System.Drawing.Point(102, 176);
            this._passwordTextBox.Name = "_passwordTextBox";
            this._passwordTextBox.Size = new System.Drawing.Size(100, 23);
            this._passwordTextBox.TabIndex = 9;
            // 
            // _positionComboBox
            // 
            this._positionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._positionComboBox.FormattingEnabled = true;
            this._positionComboBox.Location = new System.Drawing.Point(102, 101);
            this._positionComboBox.Name = "_positionComboBox";
            this._positionComboBox.Size = new System.Drawing.Size(121, 23);
            this._positionComboBox.TabIndex = 10;
            // 
            // _addButton
            // 
            this._addButton.Location = new System.Drawing.Point(297, 276);
            this._addButton.Name = "_addButton";
            this._addButton.Size = new System.Drawing.Size(75, 23);
            this._addButton.TabIndex = 11;
            this._addButton.Text = "Add";
            this._addButton.UseVisualStyleBackColor = true;
            // 
            // AddStaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 311);
            this.Controls.Add(this._addButton);
            this.Controls.Add(this._positionComboBox);
            this.Controls.Add(this._passwordTextBox);
            this.Controls.Add(this._loginTextBox);
            this.Controls.Add(this._ageTextBox);
            this.Controls.Add(this._nameTextBox);
            this.Controls.Add(this._passwordLabel);
            this.Controls.Add(this._loginLabel);
            this.Controls.Add(this._positionLabel);
            this.Controls.Add(this._ageLabel);
            this.Controls.Add(this._nameLabel);
            this.Controls.Add(this._backButton);
            this.Name = "AddStaffForm";
            this.Text = "AddStaffForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddStaffForm_FormClosed);
            this.Load += new System.EventHandler(this.AddStaffForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _backButton;
        private System.Windows.Forms.Label _nameLabel;
        private System.Windows.Forms.Label _ageLabel;
        private System.Windows.Forms.Label _positionLabel;
        private System.Windows.Forms.Label _loginLabel;
        private System.Windows.Forms.Label _passwordLabel;
        private System.Windows.Forms.TextBox _nameTextBox;
        private System.Windows.Forms.TextBox _ageTextBox;
        private System.Windows.Forms.TextBox _loginTextBox;
        private System.Windows.Forms.TextBox _passwordTextBox;
        private System.Windows.Forms.ComboBox _positionComboBox;
        private System.Windows.Forms.Button _addButton;
    }
}