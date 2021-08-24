﻿using System;
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
        private readonly Form _form;
        private IViewService _viewService;

        public SwitchForm(Form form, IViewService viewService)
        {
            _form = form;
            _viewService = viewService;

            InitializeComponent();
        }

        private void SwitchForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _form.Visible = true;
        }

        private void BackButtonClick(object sender, EventArgs e)
        {
            Close();
        }

        private void StaffButtonClick(object sender, EventArgs e)
        {
            Form form = new StaffForms.StaffForm(this, _viewService);
            form.Show();
            Visible = false;
        }
    }
}
