using Common.Service;
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
    public partial class AuthorMainWindow : Form
    {
        IService service;

        public AuthorMainWindow(IService service)
        {
            this.service = service;
            InitializeComponent();
        }


    }
}
