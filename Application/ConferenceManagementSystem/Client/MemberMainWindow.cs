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
    public partial class MemberMainWindow : Form
    {
        private IService service;
        private String cnp;

        public MemberMainWindow(IService service, String cnp)
        {
            this.cnp = cnp;
            this.service = service;
            InitializeComponent();
            this.tbaCnpLabel.Text = cnp;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
