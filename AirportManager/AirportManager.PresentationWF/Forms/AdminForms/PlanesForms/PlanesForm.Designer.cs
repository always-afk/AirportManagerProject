
namespace AirportManager.PresentationWF.Forms.AdminForms.PlanesForms
{
    partial class PlanesForm
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
            this._addButton = new System.Windows.Forms.Button();
            this._backButton = new System.Windows.Forms.Button();
            this._deleteButton = new System.Windows.Forms.Button();
            this._planesTable = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this._planesTable)).BeginInit();
            this.SuspendLayout();
            // 
            // _addButton
            // 
            this._addButton.Location = new System.Drawing.Point(289, 553);
            this._addButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._addButton.Name = "_addButton";
            this._addButton.Size = new System.Drawing.Size(86, 31);
            this._addButton.TabIndex = 5;
            this._addButton.Text = "Add";
            this._addButton.UseVisualStyleBackColor = true;
            this._addButton.Click += new System.EventHandler(this.AddButtonClick);
            // 
            // _backButton
            // 
            this._backButton.Location = new System.Drawing.Point(14, 553);
            this._backButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._backButton.Name = "_backButton";
            this._backButton.Size = new System.Drawing.Size(86, 31);
            this._backButton.TabIndex = 3;
            this._backButton.Text = "Back";
            this._backButton.UseVisualStyleBackColor = true;
            this._backButton.Click += new System.EventHandler(this.BackButtonClick);
            // 
            // _deleteButton
            // 
            this._deleteButton.Location = new System.Drawing.Point(381, 553);
            this._deleteButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._deleteButton.Name = "_deleteButton";
            this._deleteButton.Size = new System.Drawing.Size(86, 31);
            this._deleteButton.TabIndex = 6;
            this._deleteButton.Text = "Delete";
            this._deleteButton.UseVisualStyleBackColor = true;
            this._deleteButton.Click += new System.EventHandler(this.DeleteButtonClick);
            // 
            // _planesTable
            // 
            this._planesTable.AllowUserToAddRows = false;
            this._planesTable.AllowUserToDeleteRows = false;
            this._planesTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._planesTable.Location = new System.Drawing.Point(14, 12);
            this._planesTable.Name = "_planesTable";
            this._planesTable.ReadOnly = true;
            this._planesTable.RowHeadersWidth = 51;
            this._planesTable.RowTemplate.Height = 29;
            this._planesTable.Size = new System.Drawing.Size(675, 520);
            this._planesTable.TabIndex = 7;
            // 
            // PlanesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 591);
            this.Controls.Add(this._planesTable);
            this.Controls.Add(this._deleteButton);
            this.Controls.Add(this._addButton);
            this.Controls.Add(this._backButton);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PlanesForm";
            this.Text = "PlanesForm";
            this.Activated += new System.EventHandler(this.PlanesForm_Load);
            this.Load += new System.EventHandler(this.PlanesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this._planesTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button _addButton;
        private System.Windows.Forms.Button _backButton;
        private System.Windows.Forms.Button _deleteButton;
        private System.Windows.Forms.DataGridView _planesTable;
    }
}