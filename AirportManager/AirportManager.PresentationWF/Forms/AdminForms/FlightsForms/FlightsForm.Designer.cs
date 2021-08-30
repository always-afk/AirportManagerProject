
namespace AirportManager.PresentationWF.Forms.AdminForms.FlightsForms
{
    partial class FlightsForm
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
            this._addButton = new System.Windows.Forms.Button();
            this._flightsTable = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this._flightsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // _backButton
            // 
            this._backButton.Location = new System.Drawing.Point(12, 409);
            this._backButton.Name = "_backButton";
            this._backButton.Size = new System.Drawing.Size(94, 29);
            this._backButton.TabIndex = 0;
            this._backButton.Text = "Back";
            this._backButton.UseVisualStyleBackColor = true;
            this._backButton.Click += new System.EventHandler(this.BackButtonClick);
            // 
            // _addButton
            // 
            this._addButton.Location = new System.Drawing.Point(506, 409);
            this._addButton.Name = "_addButton";
            this._addButton.Size = new System.Drawing.Size(94, 29);
            this._addButton.TabIndex = 1;
            this._addButton.Text = "Add";
            this._addButton.UseVisualStyleBackColor = true;
            this._addButton.Click += new System.EventHandler(this.AddButtonClick);
            // 
            // _flightsTable
            // 
            this._flightsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._flightsTable.Location = new System.Drawing.Point(12, 12);
            this._flightsTable.Name = "_flightsTable";
            this._flightsTable.RowHeadersWidth = 51;
            this._flightsTable.RowTemplate.Height = 29;
            this._flightsTable.Size = new System.Drawing.Size(776, 391);
            this._flightsTable.TabIndex = 2;
            // 
            // FlightsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._flightsTable);
            this.Controls.Add(this._addButton);
            this.Controls.Add(this._backButton);
            this.Name = "FlightsForm";
            this.Text = "FlightsForm";
            this.Load += new System.EventHandler(this.FlightsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this._flightsTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button _backButton;
        private System.Windows.Forms.Button _addButton;
        private System.Windows.Forms.DataGridView _flightsTable;
    }
}