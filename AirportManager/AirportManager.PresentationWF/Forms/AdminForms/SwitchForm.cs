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

namespace AirportManager.PresentationWF.Forms.AdminForms
{
    public partial class SwitchForm : Form
    {
        private Services.Interfaces.INavigationService _navigationService;

        public SwitchForm(Services.Interfaces.INavigationService navigationService)
        {
            _navigationService = navigationService;

            InitializeComponent();
        }

        private void BackButtonClick(object sender, EventArgs e)
        {
            Close();
        }

        private void StaffButtonClick(object sender, EventArgs e)
        {
            Form form = _navigationService.Navigate<StaffForms.StaffForm>();
            form.Show();
        }
    }
}
