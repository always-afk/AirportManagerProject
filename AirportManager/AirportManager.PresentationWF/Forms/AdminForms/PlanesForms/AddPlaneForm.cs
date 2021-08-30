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
            if (_numOfSeatsTextBox.Text.All(Char.IsDigit))
            {
                if (_staffComboBox.Text == "None")
                {
                    _addPlanesService.Add(new DataAccess.Models.LogicModels.Plane()
                    {
                        Name = _nameTextBox.Text,
                        Code = _codeTextBox.Text,
                        NumOfSeats = Convert.ToInt32(_numOfSeatsTextBox.Text)
                    });
                }
                else
                {
                    _addPlanesService.Add(new DataAccess.Models.LogicModels.Plane()
                    {
                        Name = _nameTextBox.Text,
                        Code = _codeTextBox.Text,
                        NumOfSeats = Convert.ToInt32(_numOfSeatsTextBox.Text),
                        Staff = _staffComboBox.Text
                    });
                }
                Close();
            }
            
        }

        private void AddPlaneForm_Load(object sender, EventArgs e)
        {
            _staffComboBox.Items.Add("None");
            var staff = _addPlanesService.GetStaff();
            foreach(var s in staff)
            {
                _staffComboBox.Items.Add(s.Name);
            }
        }
    }
}
