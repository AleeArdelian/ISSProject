﻿using Common.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class ChairMainWindow : Form
    {
        private IService service;

        public ChairMainWindow(IService service)
        {
            this.service = service;
            InitializeComponent();
        }
    }
}
