using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Binairo
{
    public partial class Form2 : Form
    {
        public int N;
        public Form2()
        {
            InitializeComponent();
        }

        private void bOK_Click(object sender, EventArgs e)
        {
            if (rb8.Checked) N = 8;
            else if (rb10.Checked) N = 10;
            else N = 12;
            Close();
        }
    }
}
