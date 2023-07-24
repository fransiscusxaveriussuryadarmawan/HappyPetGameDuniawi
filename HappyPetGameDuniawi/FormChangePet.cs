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
    public partial class FormChangePet : Form
    {
        FormGame frmGame;
        public FormChangePet()
        {
            InitializeComponent();
        }
        private void radioButtonFish_CheckedChanged(object sender, EventArgs e)
        {
            labelEnv.Visible = true;
            comboBoxEnv.Visible = true;
        }

        private void radioButtonCat_CheckedChanged(object sender, EventArgs e)
        {
            labelEnv.Visible = false;
            comboBoxEnv.Visible = false;
        }

        private void radioButtonChameleon_CheckedChanged(object sender, EventArgs e)
        {
            labelEnv.Visible = false;
            comboBoxEnv.Visible = false;
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioButtonCat.Checked)
                {
                    frmGame.myPet = new Cat(textBoxPetName.Text,
                                            radioButtonCat.BackgroundImage,
                                            frmGame.myPlayer);
                }
                else if (radioButtonFish.Checked)
                {
                    frmGame.myPet = new Fish(textBoxPetName.Text,
                                             radioButtonFish.BackgroundImage,
                                             frmGame.myPlayer,
                                             comboBoxEnv.Text);
                }
                else if (radioButtonChameleon.Checked)
                {
                    frmGame.myPet = new Chameleon(textBoxPetName.Text,
                                                  radioButtonChameleon.BackgroundImage,
                                                  frmGame.myPlayer,
                                                  Color.Green);
                }

                for(int i = 0; i < frmGame.listPet.Count; i++)
                {
                    if(frmGame.listPet[i].Owner.Name == frmGame.myPlayer.Name)
                    {
                        frmGame.listPet[i] = frmGame.myPet;
                    }
                }

                frmGame.StartGame();
                this.Close();
            }
            catch(Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void FormChangePet_Load(object sender, EventArgs e)
        {
            frmGame = (FormGame)this.Owner;

            radioButtonCat.Checked = true;
            radioButtonChameleon.Checked = false;
            radioButtonFish.Checked = false;

            textBoxPlayer.Text = frmGame.myPlayer.Name;
            textBoxPlayer.Enabled = false;
        }

        private void radioButtonCat_CheckedChanged_1(object sender, EventArgs e)
        {
            comboBoxEnv.Enabled = false;
            comboBoxEnv.Visible = false;
            textBoxPetName.Focus();
        }

        private void radioButtonFish_CheckedChanged_1(object sender, EventArgs e)
        {
            comboBoxEnv.Enabled = true;
            comboBoxEnv.Visible = true;
            comboBoxEnv.Items.Clear();
            comboBoxEnv.Items.Add("River");
            comboBoxEnv.Items.Add("Sea");
            comboBoxEnv.Items.Add("Pond");
            comboBoxEnv.SelectedIndex = 0;
            textBoxPetName.Focus();
        }

        private void radioButtonChameleon_CheckedChanged_1(object sender, EventArgs e)
        {
            comboBoxEnv.Enabled = false;
            comboBoxEnv.Visible = false;
            textBoxPetName.Focus();
        }

        private void radioButtonPenguin_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxEnv.Enabled = true;
            comboBoxEnv.Visible = true;
            comboBoxEnv.Items.Clear();
            comboBoxEnv.Items.Add("Polar");
            comboBoxEnv.Items.Add("Tropical");
            comboBoxEnv.SelectedIndex = 0;
            textBoxPetName.Focus();
        }

        private void radioButtonCrocodile_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxEnv.Enabled = false;
            comboBoxEnv.Visible = false;
            textBoxPetName.Focus();
        }

        private void radioButtonMonkey_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxEnv.Enabled = false;
            comboBoxEnv.Visible = false;
            textBoxPetName.Focus();
        }
    }
}
