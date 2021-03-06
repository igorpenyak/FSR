﻿using FSR.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FSR.DesktopUI.Forms
{
    public partial class FlightInfoForm : Form
    {
        #region Constructors

        public FlightInfoForm()
        {
            InitializeComponent();
            this.ActiveControl = btnClose;
        }

        #endregion

        #region Methods

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion
    }
}
