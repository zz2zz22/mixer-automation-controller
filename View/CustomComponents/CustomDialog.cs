﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace htv5_mixer_control
{
    public partial class CustomDialog : Form
    {
        public CustomDialog(string txtAnounce)
        {
            InitializeComponent();
            rtbAnnounce.Text = txtAnounce;
        }
    }
}