
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // _dateLabel
            // 
            this._dateLabel.AutoSize = true;
            this._dateLabel.Location = new System.Drawing.Point(222, 139);
            this._dateLabel.Name = "_dateLabel";
            this._dateLabel.Size = new System.Drawing.Size(41, 20);
            this._dateLabel.TabIndex = 0;
            this._dateLabel.Text = "Date";
            // 
            // _destinationLabel
            // 
            this._destinationLabel.AutoSize = true;
            this._destinationLabel.Location = new System.Drawing.Point(178, 85);
            this._destinationLabel.Name = "_destinationLabel";
            this._destinationLabel.Size = new System.Drawing.Size(85, 20);
            this._destinationLabel.TabIndex = 1;
            this._destinationLabel.Text = "Destination";
            // 
            // _planeLabel
            // 
            this._planeLabel.AutoSize = true;
            this._planeLabel.Location = new System.Drawing.Point(218, 196);
            this._planeLabel.Name = "_planeLabel";
            this._planeLabel.Size = new System.Drawing.Size(45, 20);
            this._planeLabel.TabIndex = 2;
            this._planeLabel.Text = "Plane";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(269, 82);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 27);
            this.textBox1.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(269, 134);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(250, 27);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(269, 193);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 28);
            this.comboBox1.TabIndex = 5;
            // 
            // AddFlightForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this._planeLabel);
            this.Controls.Add(this._destinationLabel);
            this.Controls.Add(this._dateLabel);
            this.Name = "AddFlightForm";
            this.Text = "AddFlightForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _dateLabel;
        private System.Windows.Forms.Label _destinationLabel;
        private System.Windows.Forms.Label _planeLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}