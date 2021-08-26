using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirportManager.PresentationWF.Forms.AdminForms.StaffForms
{
    public partial class StaffForm : Form
    {
        private readonly BusinessLogic.Services.Interfaces.IStaffService _staffService;
        private readonly Services.Interfaces.INavigationService _navigationService;

        public StaffForm(BusinessLogic.Services.Interfaces.IStaffService staffService,
            Services.Interfaces.INavigationService navigationService)
        {
            _navigationService = navigationService;
            _staffService = staffService;


            InitializeComponent();
        }

        private void BackButtonClick(object sender, EventArgs e)
        {
            Close();
        }

        private void StaffForm_Load(object sender, EventArgs e)
        {
            _staffTable.DataSource = _staffService.GetStaff().Select(e => new 
            {
                Name = e.Name,
                Age = e.Age,
                Position = e.Position.Name,
                Login = e.User.Login,
                Password = e.User.Password
            }).ToList();
            
        }

        private void AddButtonClick(object sender, EventArgs e)
        {
            Form form = _navigationService.Navigate<AddStaffForm>();
            form.Show();
        }
    }
}
