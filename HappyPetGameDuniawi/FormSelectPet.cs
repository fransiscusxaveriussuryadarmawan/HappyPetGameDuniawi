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
    public partial class FormSelectPet : Form
    {
        FormGame frmGame;
        public FormSelectPet()
        {
            InitializeComponent();
        }

        private void radioButtonFish_CheckedChanged(object sender, EventArgs e)
        {
            labelEnv.Visible = true;
            comboBoxEnv.Visible = true;
            comboBoxEnv.SelectedIndex = 0;
            textBoxPetName.Text = "Fishy";
        }

        private void radioButtonCat_CheckedChanged(object sender, EventArgs e)
        {
            labelEnv.Visible = false;
            comboBoxEnv.Visible = false;
            textBoxPetName.Text = "Kitty";
        }

        private void radioButtonChameleon_CheckedChanged(object sender, EventArgs e)
        {
            labelEnv.Visible = false;
            comboBoxEnv.Visible = false;
            textBoxPetName.Text = "Chamy";
        }

        private void FormSelectPet_Load(object sender, EventArgs e)
        {
            radioButtonCat.Checked = true;
            comboBoxEnv.DropDownStyle = ComboBoxStyle.DropDownList;
            frmGame = (FormGame)this.Owner.Owner;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //memastikan nama player tidak ada yang sama
            if(frmGame.listPlayer.Count != 0)
            {
                foreach (Player p in frmGame.listPlayer)
                {
                    if (textBox1.Text == p.Name)
                    {
                        MessageBox.Show("Player name already used. Please input another name");
                        return;
                    }
                    else
                    {
                        //make player
                        frmGame.myPlayer = new Player(textBox1.Text, 100,
                                    DateTime.Now);
                    }
                }
            }
            else
            {
                frmGame.myPlayer = new Player(textBox1.Text, 100,
                                    DateTime.Now);
            }

            //make pet
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
            frmGame.listPlayer.Add(frmGame.myPlayer);
            frmGame.listPet.Add(frmGame.myPet);

            //start game
            frmGame.StartGame();
            
            this.Close();
            this.Owner.Close();
        }
    }
}
