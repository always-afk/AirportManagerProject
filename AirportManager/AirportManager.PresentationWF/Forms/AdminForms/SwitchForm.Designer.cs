
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
            this._staffButton = new System.Windows.Forms.Button();
            this._planesButton = new System.Windows.Forms.Button();
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
            // _staffButton
            // 
            this._staffButton.Location = new System.Drawing.Point(188, 83);
            this._staffButton.Name = "_staffButton";
            this._staffButton.Size = new System.Drawing.Size(75, 23);
            this._staffButton.TabIndex = 1;
            this._staffButton.Text = "Staff";
            this._staffButton.UseVisualStyleBackColor = true;
            this._staffButton.Click += new System.EventHandler(this.StaffButtonClick);
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
            // SwitchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 450);
            this.Controls.Add(this._planesButton);
            this.Controls.Add(this._staffButton);
            this.Controls.Add(this._backButton);
            this.Name = "SwitchForm";
            this.Text = "SwitchForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button _backButton;
        private System.Windows.Forms.Button _staffButton;
        private System.Windows.Forms.Button _planesButton;
    }
}