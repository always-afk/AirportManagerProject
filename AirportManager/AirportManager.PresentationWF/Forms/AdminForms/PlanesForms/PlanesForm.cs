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
    public partial class PlanesForm : Form
    {
        private readonly Services.Interfaces.INavigationService _navigation;
        private readonly IPlanesService _planesService; 

        public PlanesForm(Services.Interfaces.INavigationService navigation, IPlanesService planesService)
        {
            _navigation = navigation;
            _planesService = planesService;

            InitializeComponent();
        }

        private void AddButtonClick(object sender, EventArgs e)
        {
            Form form = _navigation.Navigate<AddPlaneForm>();
            form.Show();
        }

        private void PlanesForm_Load(object sender, EventArgs e)
        {
            _planesTable.DataSource = _planesService.LoadPlanes().Select(p => new
            {
                Name = p.Name,
                Code = p.Code,
                NumOfSeats = p.NumOfSeats,
                Pilot = p.Staff
            }).ToList();
        }
    }
}
