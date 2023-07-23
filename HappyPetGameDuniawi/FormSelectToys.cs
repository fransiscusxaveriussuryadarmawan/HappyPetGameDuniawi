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
    public partial class FormSelectToys : Form
    {
        FormGame frmGame;
        Toy selectedToy;
        Random rnd = new Random();
        public FormSelectToys()
        {
            InitializeComponent();
        }

        private void linkLabelBuyHere_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormToysShop frmToysShop = new FormToysShop();
            frmToysShop.Owner = this;
            frmToysShop.ShowDialog();
        }

        private void FormSelectToys_Load(object sender, EventArgs e)
        {
            frmGame = this.Owner as FormGame;

            comboBoxToys.DataSource = frmGame.myPet.ListToys;
            comboBoxToys.DisplayMember = "Name";
        }

        private void comboBoxToys_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxToys.SelectedIndex != -1)
            {
                selectedToy = (Toy)comboBoxToys.SelectedItem;

                pictureBoxToy.Image = selectedToy.Picture;
                labelToysData.Text = selectedToy.DisplayData();
            }
        }

        private void buttonUse_Click(object sender, EventArgs e)
        {
            frmGame.myPet.Play(selectedToy);

            frmGame.labelPetData.Text = frmGame.myPet.DisplayData();

            if(comboBoxToys.SelectedIndex != -1)
            {
                int toyBreakNum = rnd.Next(1, 6); //20% chance break
                if (toyBreakNum == 1)
                {
                    frmGame.myPet.ListToys.Remove(selectedToy);
                    MessageBox.Show("Oh no! Your pet broke the toy!");
                }
            }
            frmGame.ChangeImageActivity(ToyUsed());

            this.Close();

            frmGame.buttonPlay.Enabled = false;
            frmGame.buttonPlay.BackColor = Color.WhiteSmoke;
            frmGame.timerPlay.Start();
        }

        public string ToyUsed()
        {
            if (selectedToy.Name == "Ball")
            {
                return "Ball";
            }
            else if (selectedToy.Name == "Stick")
            {
                return "Stick";
            }
            else if(selectedToy.Name == "Yarn")
            {
                return "Yarn";
            }
            else
            {
                return "NoToy";
            }
        }
    }
}
