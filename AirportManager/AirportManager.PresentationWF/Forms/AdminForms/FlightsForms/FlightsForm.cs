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
        private DataTable _dataTable;

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
            _dataTable = new DataTable();
            _dataTable.Columns.Add("Destination", typeof(string));
            _dataTable.Columns.Add("Date", typeof(DateTime));
            _dataTable.Columns.Add("Plane", typeof(string));
            var flights = _flightsService.GetFlights().ToList().Select(f => new
            {
                Date = f.Date,
                Destination = f.Destination,
                PlaneName = f.Plane.Name
            });
            foreach(var fl in flights)
            {
                _dataTable.Rows.Add(fl.Destination, fl.Date, fl.PlaneName);
            }
            _flightsTable.DataSource = _dataTable;
        }

    }
}
