﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blockchain_Admin_App.Forms
{
    public partial class Work_Area : Form
    {
        public Work_Area(string mode, string name, string last)
        {
            InitializeComponent();
            Text = $"Hi - {name}  {last}";
        }

        private void Work_Area_Load(object sender, EventArgs e)
        {
            webBrowser1.Url = new Uri(@"http://www.decentralized-universe.com");
        }
    }
}
