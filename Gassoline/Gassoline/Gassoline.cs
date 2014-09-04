using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gassoline
{
    public partial class Gassoline : Form
    {
        public Gassoline()
        {
            InitializeComponent();
        }
        double l = 0, mil = 0,mask=2.82236;
        private void b1_Click(object sender, EventArgs e)
        {
            mil =double.Parse(mile.Text);
            lit.Text = Convert.ToString(mil/mask);
        }

        private void b2_Click(object sender, EventArgs e)
        {
            l =double.Parse(lit.Text);
            mile.Text = Convert.ToString(l * mask);
        }
    }
}
