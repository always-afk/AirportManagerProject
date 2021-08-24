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
        private readonly Form _form;

        private readonly BusinessLogic.Services.Interfaces.IViewService _viewService;
        private readonly IEnumerable<DataAccess.Models.LogicModels.Staff> _staff;

        public StaffForm(Form form, BusinessLogic.Services.Interfaces.IViewService viewService)
        {
            _form = form;
            _viewService = viewService;


            InitializeComponent();
        }

        private void BackButtonClick(object sender, EventArgs e)
        {
            Close();
        }

        private void StaffForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _form.Visible = true;
        }

        private void StaffForm_Load(object sender, EventArgs e)
        {
            _staffTable.DataSource = _viewService.GetStaff().Select(e => new 
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
            Form form = new AddStaffForm(this, _viewService);
            form.Show();
            Visible = false;
        }
    }
}
