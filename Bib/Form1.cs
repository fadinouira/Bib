using Bib.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bib
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            UC_Home us = new UC_Home();
            AddControlsToPanel(us);
        }

        private void AddControlsToPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(c);
        }

        private void panelControls_Paint(object sender, PaintEventArgs e)
        {

        }

        private void moveSidePanel(Control btn)
        {
            selected.Left = btn.Left;
            selected.Width = btn.Width;
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void home_Click(object sender, EventArgs e)
        {
            moveSidePanel(home);
            UC_Home us = new UC_Home();
            AddControlsToPanel(us);
        }

        private void addBook_Click(object sender, EventArgs e)
        {
            moveSidePanel(addBook);
            UC_Students us = new UC_Students();
            AddControlsToPanel(us);
        }

      
       

    }
}
