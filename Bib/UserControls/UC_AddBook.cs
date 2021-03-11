using Bib.Forms;
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
    public partial class UC_AddBook : UserControl
    {
        public UC_AddBook()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (AddCategory ac = new AddCategory())
            {
                ac.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (AddAuther ac = new AddAuther())
            {
                ac.ShowDialog();
            }
        }
    }
}
