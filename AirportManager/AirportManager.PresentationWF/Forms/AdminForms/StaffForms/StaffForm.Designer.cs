
namespace AirportManager.PresentationWF.Forms.AdminForms.StaffForms
{
    partial class StaffForm
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
            this._staffTable = new System.Windows.Forms.DataGridView();
            this._addButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._staffTable)).BeginInit();
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
            // _staffTable
            // 
            this._staffTable.AllowUserToAddRows = false;
            this._staffTable.AllowUserToDeleteRows = false;
            this._staffTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._staffTable.Location = new System.Drawing.Point(12, 12);
            this._staffTable.Name = "_staffTable";
            this._staffTable.ReadOnly = true;
            this._staffTable.RowTemplate.Height = 25;
            this._staffTable.Size = new System.Drawing.Size(676, 397);
            this._staffTable.TabIndex = 1;
            // 
            // _addButton
            // 
            this._addButton.Location = new System.Drawing.Point(253, 415);
            this._addButton.Name = "_addButton";
            this._addButton.Size = new System.Drawing.Size(75, 23);
            this._addButton.TabIndex = 2;
            this._addButton.Text = "Add";
            this._addButton.UseVisualStyleBackColor = true;
            this._addButton.Click += new System.EventHandler(this.AddButtonClick);
            // 
            // StaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 450);
            this.Controls.Add(this._addButton);
            this.Controls.Add(this._staffTable);
            this.Controls.Add(this._backButton);
            this.Name = "StaffForm";
            this.Text = "StaffForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StaffForm_FormClosed);
            this.Load += new System.EventHandler(this.StaffForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this._staffTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button _backButton;
        private System.Windows.Forms.DataGridView _staffTable;
        private System.Windows.Forms.Button _addButton;
    }
}