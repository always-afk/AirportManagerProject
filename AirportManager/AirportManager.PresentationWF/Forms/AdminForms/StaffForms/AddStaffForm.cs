using AirportManager.BusinessLogic.Services.Interfaces;
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
    public partial class AddStaffForm : Form
    {
        private readonly Form _form;
        private readonly IViewService _viewService;

        public AddStaffForm(Form form, IViewService viewService)
        {
            _form = form;
            _viewService = viewService;

            InitializeComponent();
        }

        private void AddStaffForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _form.Visible = true;
        }

        private void BackButtonClick(object sender, EventArgs e)
        {
            Close();
        }

        private void AddStaffForm_Load(object sender, EventArgs e)
        {
            var positions = _viewService.GetPositions();
        }
    }
}
