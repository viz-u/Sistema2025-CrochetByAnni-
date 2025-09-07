using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema2025
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            progressSplash.Minimum = 1;
            progressSplash.Maximum = 100;
            progressSplash.Step = 3;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressSplash.Value == progressSplash.Maximum)
            {
                progressSplash.Value = progressSplash.Minimum;
            }
            progressSplash.PerformStep();
            if (progressSplash.Value == progressSplash.Maximum)
            {
                this.Close();
            }
        }

        private void progressSplash_Click(object sender, EventArgs e)
        {

        }
    }
}
