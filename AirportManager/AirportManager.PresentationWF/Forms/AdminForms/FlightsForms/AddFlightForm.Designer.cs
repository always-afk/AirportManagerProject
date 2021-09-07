
namespace AirportManager.PresentationWF.Forms.AdminForms.FlightsForms
{
    partial class AddFlightForm
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
            this._dateLabel = new System.Windows.Forms.Label();
            this._destinationLabel = new System.Windows.Forms.Label();
            this._planeLabel = new System.Windows.Forms.Label();
            this._destTextBox = new System.Windows.Forms.TextBox();
            this._dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this._planesComboBox = new System.Windows.Forms.ComboBox();
            this._backButton = new System.Windows.Forms.Button();
            this._addButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _dateLabel
            // 
            this._dateLabel.AutoSize = true;
            this._dateLabel.Location = new System.Drawing.Point(170, 112);
            this._dateLabel.Name = "_dateLabel";
            this._dateLabel.Size = new System.Drawing.Size(31, 15);
            this._dateLabel.TabIndex = 0;
            this._dateLabel.Text = "Date";
            // 
            // _destinationLabel
            // 
            this._destinationLabel.AutoSize = true;
            this._destinationLabel.Location = new System.Drawing.Point(131, 72);
            this._destinationLabel.Name = "_destinationLabel";
            this._destinationLabel.Size = new System.Drawing.Size(67, 15);
            this._destinationLabel.TabIndex = 1;
            this._destinationLabel.Text = "Destination";
            // 
            // _planeLabel
            // 
            this._planeLabel.AutoSize = true;
            this._planeLabel.Location = new System.Drawing.Point(166, 155);
            this._planeLabel.Name = "_planeLabel";
            this._planeLabel.Size = new System.Drawing.Size(36, 15);
            this._planeLabel.TabIndex = 2;
            this._planeLabel.Text = "Plane";
            // 
            // _destTextBox
            // 
            this._destTextBox.Location = new System.Drawing.Point(211, 70);
            this._destTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._destTextBox.Name = "_destTextBox";
            this._destTextBox.Size = new System.Drawing.Size(133, 23);
            this._destTextBox.TabIndex = 3;
            // 
            // _dateTimePicker
            // 
            this._dateTimePicker.Location = new System.Drawing.Point(211, 109);
            this._dateTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._dateTimePicker.Name = "_dateTimePicker";
            this._dateTimePicker.Size = new System.Drawing.Size(219, 23);
            this._dateTimePicker.TabIndex = 4;
            // 
            // _planesComboBox
            // 
            this._planesComboBox.FormattingEnabled = true;
            this._planesComboBox.Location = new System.Drawing.Point(211, 153);
            this._planesComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._planesComboBox.Name = "_planesComboBox";
            this._planesComboBox.Size = new System.Drawing.Size(133, 23);
            this._planesComboBox.TabIndex = 5;
            // 
            // _backButton
            // 
            this._backButton.Location = new System.Drawing.Point(10, 307);
            this._backButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._backButton.Name = "_backButton";
            this._backButton.Size = new System.Drawing.Size(82, 22);
            this._backButton.TabIndex = 6;
            this._backButton.Text = "Back";
            this._backButton.UseVisualStyleBackColor = true;
            this._backButton.Click += new System.EventHandler(this.BackButtonClick);
            // 
            // _addButton
            // 
            this._addButton.Location = new System.Drawing.Point(468, 307);
            this._addButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._addButton.Name = "_addButton";
            this._addButton.Size = new System.Drawing.Size(82, 22);
            this._addButton.TabIndex = 7;
            this._addButton.Text = "Add";
            this._addButton.UseVisualStyleBackColor = true;
            this._addButton.Click += new System.EventHandler(this.AddButtonClick);
            // 
            // AddFlightForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 338);
            this.Controls.Add(this._addButton);
            this.Controls.Add(this._backButton);
            this.Controls.Add(this._planesComboBox);
            this.Controls.Add(this._dateTimePicker);
            this.Controls.Add(this._destTextBox);
            this.Controls.Add(this._planeLabel);
            this.Controls.Add(this._destinationLabel);
            this.Controls.Add(this._dateLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddFlightForm";
            this.Text = "AddFlightForm";
            this.Load += new System.EventHandler(this.AddFlightForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _dateLabel;
        private System.Windows.Forms.Label _destinationLabel;
        private System.Windows.Forms.Label _planeLabel;
        private System.Windows.Forms.TextBox _destTextBox;
        private System.Windows.Forms.DateTimePicker _dateTimePicker;
        private System.Windows.Forms.ComboBox _planesComboBox;
        private System.Windows.Forms.Button _backButton;
        private System.Windows.Forms.Button _addButton;
    }
}