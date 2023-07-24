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
    public partial class FormHelp : Form
    {
        FormGame frmGame;
        public FormHelp()
        {
            InitializeComponent();
        }

        private void FormHelp_Load(object sender, EventArgs e)
        {
            frmGame = this.Owner as FormGame;
            labelHelp1.Text = DisplayHelpHowToPlay();
            labelHelpPet.Text = DisplayHelpPet();
            frmGame.timerGame.Stop();
        }

        private string DisplayHelpHowToPlay()
        {
            return "How To Play:\n" +
                    "1. Pick your desired pet" +
                    "\n2. Your pet has three different stats:\n    Health, Energy, and Happiness\n" +
                    "3. Each type of animals have different sets of activities to maintain their stats" +
                    "\n4. The game will end when your pet reaches below 25% Health, 50% Energy, and          60% Happiness\n" +
                    "5. Don't forget to enjoy the game";
        }

        private string DisplayHelpPet()
        {
            return "Pet Activities:\n" +
                "1. Cat\n   (Feed, Sleep, Play, Bath, Vaccinate)" +
                "\n2. Fish\n   (Feed, Clean)" +
                "\n3. Chameleon\n   (Feed, Sleep)" +
                "\n4. Penguin\n   (Feed, Sleep, Play)" +
                "\n5. Crocodile\n   (Feed, Sleep, Clean, Vaccinate)" +
                "\n6. Monkey\n   (Feed, Sleep, Play, Bath, Vaccinate)";
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormHelp_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(frmGame.myPet != null)
            {
                frmGame.timerGame.Start();
            }
        }
    }
}
