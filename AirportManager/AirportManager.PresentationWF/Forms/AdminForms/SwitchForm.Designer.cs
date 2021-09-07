
namespace AirportManager.PresentationWF.Forms.AdminForms
{
    partial class SwitchForm
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
            this._StaffButton = new System.Windows.Forms.Button();
            this._planesButton = new System.Windows.Forms.Button();
            this._flightsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _backButton
            // 
            this._backButton.Location = new System.Drawing.Point(12, 415);
            this._backButton.Name = "_backButton";
            this._backButton.Size = new System.Drawing.Size(75, 23);
            this._backButton.TabIndex = 0;
            this._backButton.Text = "Back";
            this._backButton.UseVisualStyleBackColor = true;
            this._backButton.Click += new System.EventHandler(this.BackButtonClick);
            // 
            // _StaffButton
            // 
            this._StaffButton.Location = new System.Drawing.Point(188, 83);
            this._StaffButton.Name = "_StaffButton";
            this._StaffButton.Size = new System.Drawing.Size(75, 23);
            this._StaffButton.TabIndex = 1;
            this._StaffButton.Text = "Staff";
            this._StaffButton.UseVisualStyleBackColor = true;
            this._StaffButton.Click += new System.EventHandler(this.StaffButtonClick);
            // 
            // _planesButton
            // 
            this._planesButton.Location = new System.Drawing.Point(188, 155);
            this._planesButton.Name = "_planesButton";
            this._planesButton.Size = new System.Drawing.Size(75, 23);
            this._planesButton.TabIndex = 2;
            this._planesButton.Text = "Planes";
            this._planesButton.UseVisualStyleBackColor = true;
            this._planesButton.Click += new System.EventHandler(this.PlanesButtonClick);
            // 
            // _flightsButton
            // 
            this._flightsButton.Location = new System.Drawing.Point(188, 223);
            this._flightsButton.Name = "_flightsButton";
            this._flightsButton.Size = new System.Drawing.Size(75, 23);
            this._flightsButton.TabIndex = 3;
            this._flightsButton.Text = "Flights";
            this._flightsButton.UseVisualStyleBackColor = true;
            this._flightsButton.Click += new System.EventHandler(this.FlightsButtonClick);
            // 
            // SwitchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 450);
            this.Controls.Add(this._flightsButton);
            this.Controls.Add(this._planesButton);
            this.Controls.Add(this._StaffButton);
            this.Controls.Add(this._backButton);
            this.Name = "SwitchForm";
            this.Text = "SwitchForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button _backButton;
        private System.Windows.Forms.Button _StaffButton;
        private System.Windows.Forms.Button _planesButton;
        private System.Windows.Forms.Button _flightsButton;
    }
}