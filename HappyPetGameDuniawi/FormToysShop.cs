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
    public partial class FormToysShop : Form
    {
        List<Toy> listToys = new List<Toy>();
        FormGame frmGame;

        Toy toy1, toy2, toy3;
        public FormToysShop()
        {
            InitializeComponent();
        }

        private void FormToysShop_Load(object sender, EventArgs e)
        {
            frmGame = this.Owner.Owner as FormGame;
            CreateToys();
        }

        private void CreateToys()
        {
            toy1 = new Toy("Ball", 300, 10, Properties.Resources.cat_toys_ball);
            listToys.Add(toy1);
            labelToysData1.Text = toy1.DisplayData();

            toy2 = new Toy("Stick", 200, 5, Properties.Resources.cat_toys_stick);
            listToys.Add(toy2);
            labelToysData2.Text = toy2.DisplayData();

            toy3 = new Toy("Yarn", 500, 20, Properties.Resources.yarn);
            listToys.Add(toy3);
            labelToysData3.Text = toy3.DisplayData();
        }

        private void buttonBuy_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioButtonToy1.Checked)
                {
                    frmGame.myPet.BuyToy(toy1);
                }
                else if (radioButtonToy2.Checked)
                {
                    frmGame.myPet.BuyToy(toy2);
                }
                else if (radioButtonToy3.Checked)
                {
                    frmGame.myPet.BuyToy(toy3);
                }

                MessageBox.Show("The new toy has been added to your inventory");

                //closing forms
                this.Close();
                this.Owner.Close();
                frmGame.labelPlayerData.Text = frmGame.myPlayer.DisplayData();
            }
            catch(Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }
    }
}
