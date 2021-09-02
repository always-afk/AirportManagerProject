using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AirportManager.BusinessLogic.Services.Interfaces;

namespace AirportManager.PresentationWF.Forms.AdminForms.PlanesForms
{
    public partial class AddPlaneForm : Form
    {
        private readonly IAddPlanesService _addPlanesService;

        public AddPlaneForm(IAddPlanesService addPlanesService)
        {
            InitializeComponent();

            _addPlanesService = addPlanesService;
        }

        private void AddButtonClick(object sender, EventArgs e)
        {
            if (_numOfSeatsTextBox.Text.All(Char.IsDigit) && _nameTextBox.Text.Length <= 64)
            {
                var Staff = "";
                var name = _nameTextBox.Text;
                var num = Convert.ToInt32(_numOfSeatsTextBox.Text);
                if(_staffComboBox.SelectedIndex != 0)
                {
                    Staff = _staffComboBox.Text;
                }
                _addPlanesService.Add(name, num, Staff);
                Close();
            }
            else
            {
                MessageBox.Show("Error");
            }            
        }

        private void AddPlaneForm_Load(object sender, EventArgs e)
        {
            _staffComboBox.Items.Add("None");
            var Staff = _addPlanesService.GetStaff();
            foreach(var s in Staff)
            {
                _staffComboBox.Items.Add(s.Name);
            }
            _staffComboBox.SelectedIndex = 0;
        }

        private void BackButtonClick(object sender, EventArgs e)
        {
            Close();
        }
    }
}
