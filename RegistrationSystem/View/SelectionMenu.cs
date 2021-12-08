﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistrationSystem.View
{
    public partial class SelectionMenu : Form
    {
        public bool CancelAct { get; private set; }

        public SelectionMenu(string message)
        {
            InitializeComponent();
            Message.Text = message;
        }

        private void YesButtonClick(object sender, EventArgs e)
        {
            CancelAct = false;
            Hide();
        }

        private void NoButtonClick(object sender, EventArgs e)
        {
            CancelAct = true;
            Hide();
        }
    }
}
