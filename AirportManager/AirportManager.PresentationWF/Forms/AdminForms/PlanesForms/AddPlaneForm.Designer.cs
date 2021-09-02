
namespace AirportManager.PresentationWF.Forms.AdminForms.PlanesForms
{
    partial class AddPlaneForm
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
            this._nameTextBox = new System.Windows.Forms.TextBox();
            this._numOfSeatsTextBox = new System.Windows.Forms.TextBox();
            this._staffComboBox = new System.Windows.Forms.ComboBox();
            this._nameLabel = new System.Windows.Forms.Label();
            this._pilotLabel = new System.Windows.Forms.Label();
            this._numOfSeatsLabel = new System.Windows.Forms.Label();
            this._addButton = new System.Windows.Forms.Button();
            this._backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _nameTextBox
            // 
            this._nameTextBox.Location = new System.Drawing.Point(293, 111);
            this._nameTextBox.Name = "_nameTextBox";
            this._nameTextBox.Size = new System.Drawing.Size(151, 27);
            this._nameTextBox.TabIndex = 0;
            // 
            // _numOfSeatsTextBox
            // 
            this._numOfSeatsTextBox.Location = new System.Drawing.Point(293, 144);
            this._numOfSeatsTextBox.Name = "_numOfSeatsTextBox";
            this._numOfSeatsTextBox.Size = new System.Drawing.Size(151, 27);
            this._numOfSeatsTextBox.TabIndex = 2;
            // 
            // _staffComboBox
            // 
            this._staffComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._staffComboBox.FormattingEnabled = true;
            this._staffComboBox.Location = new System.Drawing.Point(293, 177);
            this._staffComboBox.Name = "_staffComboBox";
            this._staffComboBox.Size = new System.Drawing.Size(151, 28);
            this._staffComboBox.TabIndex = 3;
            // 
            // _nameLabel
            // 
            this._nameLabel.AutoSize = true;
            this._nameLabel.Location = new System.Drawing.Point(238, 114);
            this._nameLabel.Name = "_nameLabel";
            this._nameLabel.Size = new System.Drawing.Size(49, 20);
            this._nameLabel.TabIndex = 4;
            this._nameLabel.Text = "Name";
            // 
            // _pilotLabel
            // 
            this._pilotLabel.AutoSize = true;
            this._pilotLabel.Location = new System.Drawing.Point(248, 180);
            this._pilotLabel.Name = "_pilotLabel";
            this._pilotLabel.Size = new System.Drawing.Size(39, 20);
            this._pilotLabel.TabIndex = 6;
            this._pilotLabel.Text = "Pilot";
            // 
            // _numOfSeatsLabel
            // 
            this._numOfSeatsLabel.AutoSize = true;
            this._numOfSeatsLabel.Location = new System.Drawing.Point(169, 147);
            this._numOfSeatsLabel.Name = "_numOfSeatsLabel";
            this._numOfSeatsLabel.Size = new System.Drawing.Size(118, 20);
            this._numOfSeatsLabel.TabIndex = 7;
            this._numOfSeatsLabel.Text = "Number of seats";
            // 
            // _addButton
            // 
            this._addButton.Location = new System.Drawing.Point(554, 368);
            this._addButton.Name = "_addButton";
            this._addButton.Size = new System.Drawing.Size(94, 29);
            this._addButton.TabIndex = 8;
            this._addButton.Text = "Add";
            this._addButton.UseVisualStyleBackColor = true;
            this._addButton.Click += new System.EventHandler(this.AddButtonClick);
            // 
            // _backButton
            // 
            this._backButton.Location = new System.Drawing.Point(12, 368);
            this._backButton.Name = "_backButton";
            this._backButton.Size = new System.Drawing.Size(94, 29);
            this._backButton.TabIndex = 9;
            this._backButton.Text = "Back";
            this._backButton.UseVisualStyleBackColor = true;
            this._backButton.Click += new System.EventHandler(this.BackButtonClick);
            // 
            // AddPlaneForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._backButton);
            this.Controls.Add(this._addButton);
            this.Controls.Add(this._numOfSeatsLabel);
            this.Controls.Add(this._pilotLabel);
            this.Controls.Add(this._nameLabel);
            this.Controls.Add(this._staffComboBox);
            this.Controls.Add(this._numOfSeatsTextBox);
            this.Controls.Add(this._nameTextBox);
            this.Name = "AddPlaneForm";
            this.Text = "AddPlaneForm";
            this.Load += new System.EventHandler(this.AddPlaneForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _nameTextBox;
        private System.Windows.Forms.TextBox _numOfSeatsTextBox;
        private System.Windows.Forms.ComboBox _staffComboBox;
        private System.Windows.Forms.Label _nameLabel;
        private System.Windows.Forms.Label _pilotLabel;
        private System.Windows.Forms.Label _numOfSeatsLabel;
        private System.Windows.Forms.Button _addButton;
        private System.Windows.Forms.Button _backButton;
    }
}