using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HappyPetGameDuniawi
{
    public partial class SplashScreenGame : Form
    {
        public SplashScreenGame()
        {
            InitializeComponent();
        }

        private void timerLoading_Tick(object sender, EventArgs e)
        {
            timerLoading.Enabled = true;
            progressBarLoading.Increment(8);
            if (progressBarLoading.Value == 100)
            {
                timerLoading.Enabled = false;
                FormGame fgame = new FormGame();
                fgame.Show();

                this.Hide();
            }
        }
    }
}
