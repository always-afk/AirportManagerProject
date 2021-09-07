using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AirportManager.Common.Entites;
using AirportManager.BusinessLogic.Services.Interfaces;

namespace AirportManager.PresentationWF.Forms.AdminForms.FlightsForms
{
    public partial class AddFlightForm : Form
    {
        private readonly IAddFlightsService _addFlightsService;
        private readonly List<Plane> _planes;
        public AddFlightForm(IAddFlightsService addFlightsService)
        {
            InitializeComponent();

            _addFlightsService = addFlightsService;
            _planes = _addFlightsService.GetPlanes().ToList();
        }

        private void BackButtonClick(object sender, EventArgs e)
        {
            Close();
        }

        private void AddButtonClick(object sender, EventArgs e)
        {
            _addFlightsService.Save(new Flight()
            {
                Destination = _destTextBox.Text,
                Date = _dateTimePicker.Value,
                Plane = _planes[_planesComboBox.SelectedIndex]
            });
        }

        private void AddFlightForm_Load(object sender, EventArgs e)
        {
            foreach(var plane in _planes)
            {
                _planesComboBox.Items.Add(plane.Name);
            }
        }
    }
}
