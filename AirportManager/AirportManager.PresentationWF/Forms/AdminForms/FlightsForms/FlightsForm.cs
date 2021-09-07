using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AirportManager.PresentationWF.Services.Interfaces;
using AirportManager.BusinessLogic.Services.Interfaces;

namespace AirportManager.PresentationWF.Forms.AdminForms.FlightsForms
{
    public partial class FlightsForm : Form
    {
        private readonly INavigationService _navigation;
        private readonly IFlightsService _flightsService;

        public FlightsForm(INavigationService navigation, IFlightsService flightsService)
        {
            InitializeComponent();

            _navigation = navigation;
            _flightsService = flightsService;
        }

        private void BackButtonClick(object sender, EventArgs e)
        {
            Close();
        }

        private void AddButtonClick(object sender, EventArgs e)
        {
            Form form = _navigation.Navigate<AddFlightForm>();
            form.Show();
        }

        private void FlightsForm_Load(object sender, EventArgs e)
        {
            _flightsTable.DataSource = _flightsService.GetFlights().ToList().Select(f => new 
            {
                Date = f.Date,
                Destination = f.Destination,
                PlaneName = f.Plane.Name
            });
        }

    }
}
