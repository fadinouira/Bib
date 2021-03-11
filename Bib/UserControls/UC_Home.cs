﻿using Bib.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bib.UserControls
{
    public partial class UC_Home : UserControl
    {
        public UC_Home()
        {
            InitializeComponent();
        }

        private void home_Click(object sender, EventArgs e)
        {
            using (AddBook ac = new AddBook())
            {
                ac.ShowDialog();
            }
        }
    }
}
