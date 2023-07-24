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
    public partial class FormSelectPlayer : Form
    {
        FormGame frmGame;
        public FormSelectPlayer()
        {
            InitializeComponent();
        }

        private void linkLabelClickHere_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormSelectPet frmSelPet = new FormSelectPet();
            frmSelPet.Owner = this;
            frmSelPet.ShowDialog();
        }

        private void FormSelectPlayer_Load(object sender, EventArgs e)
        {
            frmGame = this.Owner as FormGame;
            comboBoxPlayer.DataSource = frmGame.listPlayer;
            comboBoxPlayer.DisplayMember = "Name";
            comboBoxPlayer.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void buttonLetsPlay_Click(object sender, EventArgs e)
        {
            if(frmGame.listPlayer.Count == 0)
            {
                MessageBox.Show("There are no saved players");
                return;
            }
            frmGame.myPlayer = (Player)comboBoxPlayer.SelectedItem;

            foreach (Pet pa in frmGame.listPet)
            {
                if (pa.Owner.Name == frmGame.myPlayer.Name)
                {
                    frmGame.myPet.Owner = frmGame.myPlayer;
                }
            }


            frmGame.StartGame();
            this.Close();
        }
    }
}
