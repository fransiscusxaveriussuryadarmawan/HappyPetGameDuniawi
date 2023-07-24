using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Media;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HappyPetGameDuniawi
{
    public partial class FormGame : Form
    {
        public Player myPlayer;
        public Pet myPet;

        public List<Player> listPlayer = new List<Player>();
        public List<Pet> listPet = new List<Pet>();

        SoundPlayer amimir = new SoundPlayer(Properties.Resources.Amimir);
        SoundPlayer eat = new SoundPlayer(Properties.Resources.eat);
        SoundPlayer fail = new SoundPlayer(Properties.Resources.fail);
        SoundPlayer coin = new SoundPlayer(Properties.Resources.presentGet);

        private int detik;
        private int waktu;

        public FormGame()
        {
            InitializeComponent();
        }

        private void FormGame_Load(object sender, EventArgs e)
        {
            ReadDataPlayer("playerData.gm");
            ReadDataPet("petData.gm");
            //this.BackgroundImage = Properties.Resources.Room;
            //this.BackgroundImageLayout = ImageLayout.Stretch;
            panelData.Visible = false;
            panelActivity.Visible = false;
        }


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void playGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSelectPlayer frmSelPlayer = new FormSelectPlayer();
            frmSelPlayer.Owner = this;
            frmSelPlayer.ShowDialog();
        }

        public void StartGame()
        {
            //displaying data in label FormGame
            labelPlayerData.Text = myPlayer.DisplayData();
            labelPetData.Text = myPet.DisplayData();
            labelDateTime.Text = DateTime.Now.ToString();
            pictureBoxPresentCoins.Visible = true;
            PresentCoins();

            timerPresent.Start();

            pictureBoxCoins.Image = Properties.Resources.coins;
            panelData.Visible = true;
            labelTitle.Visible = false;
            panelActivity.Visible = true;
            pictureBoxPet.Visible = true;

            pictureBoxPet.Image = myPet.Picture;

            //activity buttons
            if(myPet is Cat)
            {
                buttonPlay.Enabled = true;
                buttonPlay.BackColor = Color.Lime;
                buttonClean.Enabled = false;
                buttonClean.BackColor = Color.Gray;
                buttonBath.Enabled = true;
                buttonBath.BackColor = Color.Yellow;
                buttonVaccinate.Enabled = true;
                buttonVaccinate.BackColor = Color.Violet;
                buttonFeed.Enabled = true;
                buttonFeed.BackColor = Color.Crimson;
                buttonSleep.Enabled = true;
                buttonSleep.BackColor = Color.DeepSkyBlue;
            }
            else if(myPet is Fish)
            {
                buttonPlay.Enabled = false;
                buttonPlay.BackColor = Color.Gray;
                buttonVaccinate.Enabled = false;
                buttonVaccinate.BackColor = Color.Gray;
                buttonBath.Enabled = false;
                buttonBath.BackColor = Color.Gray;
                buttonFeed.Enabled = true;
                buttonFeed.BackColor = Color.Crimson;
                buttonClean.Enabled = true;
                buttonClean.BackColor = Color.DarkOrange;
                buttonSleep.Enabled = false;
                buttonSleep.BackColor = Color.Gray;
            }
            else if(myPet is Chameleon)
            {
                buttonPlay.Enabled = false;
                buttonPlay.BackColor = Color.Gray;
                buttonVaccinate.Enabled = false;
                buttonVaccinate.BackColor = Color.Gray;
                buttonBath.Enabled = false;
                buttonBath.BackColor = Color.Gray;
                buttonClean.Enabled = false;
                buttonClean.BackColor = Color.Gray;
                buttonFeed.Enabled = true;
                buttonFeed.BackColor = Color.Crimson;
                buttonSleep.Enabled = true;
                buttonSleep.BackColor = Color.DeepSkyBlue;

                timerChameleonAfk.Start();
            }
            else if(myPet is Penguin)
            {
                buttonPlay.Enabled = true;
                buttonPlay.BackColor = Color.Lime;
                buttonVaccinate.Enabled = false;
                buttonVaccinate.BackColor = Color.Gray;
                buttonBath.Enabled = false;
                buttonBath.BackColor = Color.Gray;
                buttonClean.Enabled = false;
                buttonClean.BackColor = Color.Gray;
                buttonFeed.Enabled = true;
                buttonFeed.BackColor = Color.Crimson;
                buttonSleep.Enabled = true;
                buttonSleep.BackColor = Color.DeepSkyBlue;
            }
            else if(myPet is Crocodile)
            {
                buttonPlay.Enabled = false;
                buttonPlay.BackColor = Color.Gray;
                buttonVaccinate.Enabled = true;
                buttonVaccinate.BackColor = Color.Violet;
                buttonBath.Enabled = false;
                buttonBath.BackColor = Color.Gray;
                buttonClean.Enabled = true;
                buttonClean.BackColor = Color.DarkOrange;
                buttonFeed.Enabled = true;
                buttonFeed.BackColor = Color.Crimson;
                buttonSleep.Enabled = true;
                buttonSleep.BackColor = Color.DeepSkyBlue;
            }
            else if(myPet is Monkey)
            {
                buttonPlay.Enabled = true;
                buttonPlay.BackColor = Color.Lime;
                buttonClean.Enabled = false;
                buttonClean.BackColor = Color.Gray;
                buttonBath.Enabled = true;
                buttonBath.BackColor = Color.Yellow;
                buttonVaccinate.Enabled = true;
                buttonVaccinate.BackColor = Color.Violet;
                buttonFeed.Enabled = true;
                buttonFeed.BackColor = Color.Crimson;
                buttonSleep.Enabled = true;
                buttonSleep.BackColor = Color.DeepSkyBlue;
            }

            timerGame.Interval = 1000;
            timerGame.Start();
        }

        private void PresentCoins()
        {
            if (pictureBoxPresentCoins.Top != 0)
            {
                pictureBoxPresentCoins.Image = Properties.Resources.presentCoins;
            }
            else
            {
                return;
            }
        }

        //changing picture based on activity
        public void ChangeImageActivity(string activity)
        {
            if(myPet is Cat)
            {
                if(activity == "Feed")
                {
                    pictureBoxPet.Image = Properties.Resources.cat_feed1;
                }
                else if(activity == "Sleep")
                {
                    pictureBoxPet.Image = Properties.Resources.cat_sleep1;
                }
                else if(activity == "Bath")
                {
                    pictureBoxPet.Image = Properties.Resources.cat_bath1;
                }
                else if(activity == "Vaccinate")
                {
                    pictureBoxPet.Image = Properties.Resources.cat_vaccinate1;
                }
                else if(activity == "Ball")
                {
                     pictureBoxPet.Image = Properties.Resources.cat_play_ball1;
                }
                else if(activity == "Stick")
                {
                    pictureBoxPet.Image = Properties.Resources.cat_play_stick;
                }
                else if(activity == "Yarn")
                {
                    pictureBoxPet.Image = Properties.Resources.cat_play_yarn1;
                }
                else if(activity == "NoToy")
                {
                    return;
                }
                else if (activity == "-")
                {
                    pictureBoxPet.Image = myPet.Picture;
                }
            }
            else if(myPet is Fish)
            {
                if(activity == "Feed")
                {
                    pictureBoxPet.Image = Properties.Resources.fish_feed1;
                }
                else if (activity == "Clean")
                {
                    pictureBoxPet.Image = Properties.Resources.fish_clean;
                }
                else if (activity == "-")
                {
                    pictureBoxPet.Image = myPet.Picture;
                }
            }
            else if(myPet is Chameleon)
            {
                if (activity == "FeedG")
                {
                    pictureBoxPet.Image = Properties.Resources.chameleonG_feed;
                }
                else if (activity == "SleepG")
                {
                    pictureBoxPet.Image = Properties.Resources.chameleonG_sleep;
                }
                else if (activity == "FeedY")
                {
                    pictureBoxPet.Image = Properties.Resources.chameleonY_feed;
                }
                else if (activity == "SleepY")
                {
                    pictureBoxPet.Image = Properties.Resources.chameleonY_sleep;
                }
                else if (activity == "FeedR")
                {
                    pictureBoxPet.Image = Properties.Resources.chameleonR_feed;
                }
                else if (activity == "SleepR")
                {
                    pictureBoxPet.Image = Properties.Resources.chameleonR_sleep;
                }
                else if (activity == "-")
                {
                    pictureBoxPet.Image = myPet.Picture;
                }
            }
            else if (myPet is Penguin)
            {
                if (activity == "Feed")
                {
                    pictureBoxPet.Image = Properties.Resources.penguin_feed;
                }
                else if (activity == "Sleep")
                {
                    pictureBoxPet.Image = Properties.Resources.penguin_sleep;
                }
                else if (activity == "Ball")
                {
                    pictureBoxPet.Image = Properties.Resources.penguin_play_ball;
                }
                else if (activity == "Stick")
                {
                    pictureBoxPet.Image = Properties.Resources.penguin_play_stick;
                }
                else if (activity == "Yarn")
                {
                    pictureBoxPet.Image = Properties.Resources.penguin_play_yarn;
                }
                else if (activity == "NoToy")
                {
                    return;
                }
                else if (activity == "-")
                {
                    pictureBoxPet.Image = myPet.Picture;
                }
            }
            else if (myPet is Crocodile)
            {
                if (activity == "Feed")
                {
                    pictureBoxPet.Image = Properties.Resources.crocodile_feed;
                }
                else if (activity == "Sleep")
                {
                    pictureBoxPet.Image = Properties.Resources.crocodile_sleep;
                }
                else if (activity == "Clean")
                {
                    pictureBoxPet.Image = Properties.Resources.crocodile_clean;
                }
                else if (activity == "Vaccinate")
                {
                    pictureBoxPet.Image = Properties.Resources.crocodile_vaccinate;
                }
                else if (activity == "-")
                {
                    pictureBoxPet.Image = myPet.Picture;
                }
            }
            else if (myPet is Monkey)
            {
                if (activity == "Feed")
                {
                    //pictureBoxPet.Image = Properties.Resources.cat_feed1;
                }
                else if (activity == "Sleep")
                {
                    pictureBoxPet.Image = Properties.Resources.monkey_sleep;
                }
                else if (activity == "Bath")
                {
                    pictureBoxPet.Image = Properties.Resources.monkey_bath;
                }
                else if (activity == "Vaccinate")
                {
                    pictureBoxPet.Image = Properties.Resources.monkey_vaccinate;
                }
                else if (activity == "Ball")
                {
                    pictureBoxPet.Image = Properties.Resources.monkey_play_ball;
                }
                else if (activity == "Stick")
                {
                    pictureBoxPet.Image = Properties.Resources.monkey_play_stick;
                }
                else if (activity == "Yarn")
                {
                    pictureBoxPet.Image = Properties.Resources.monkey_play_yarn;
                }
                else if (activity == "NoToy")
                {
                    return;
                }
                else if (activity == "-")
                {
                    pictureBoxPet.Image = myPet.Picture;
                }
            }
            
            detik = 0;
            timerPictureActivity.Interval = 1000;
            timerPictureActivity.Start();
        }

        private void buttonFeed_Click(object sender, EventArgs e)
        {
            //method feed
            myPet.Feed();
            eat.Play();

            //display
            labelPetData.Text = myPet.DisplayData();
            labelPlayerData.Text = myPlayer.DisplayData();

            buttonFeed.Enabled = false;
            buttonFeed.BackColor = Color.WhiteSmoke;
            timerFeed.Start();

            if(myPet is Chameleon) //For Chameleon Color
            {
                timerChameleonAfk.Stop();
                if (((Chameleon)myPet).CurrentColor == Color.Green)
                {
                    ChangeImageActivity("FeedG");
                }
                else if (((Chameleon)myPet).CurrentColor == Color.Yellow)
                {
                    ChangeImageActivity("FeedY");
                }
                else if(((Chameleon)myPet).CurrentColor == Color.Red)
                {
                    ChangeImageActivity("FeedR");
                }
            }
            else //For other Pets
            {
                ChangeImageActivity("Feed");
            }
        }

        private void buttonSleep_Click(object sender, EventArgs e)
        {
            myPet.Sleep();

            labelPetData.Text = myPet.DisplayData();
            labelPlayerData.Text = myPlayer.DisplayData();
            amimir.Play();
            ChangeImageActivity("Sleep");

            buttonSleep.Enabled = false;
            buttonSleep.BackColor = Color.WhiteSmoke;
            this.BackgroundImage = Properties.Resources.room_dark;
            timerSleep.Start();

            if (myPet is Chameleon) //For Chameleon Color
            {
                timerChameleonAfk.Stop();
                if (((Chameleon)myPet).CurrentColor == Color.Green)
                {
                    ChangeImageActivity("SleepG");
                }
                else if (((Chameleon)myPet).CurrentColor == Color.Yellow)
                {
                    ChangeImageActivity("SleepY");
                }
                else if (((Chameleon)myPet).CurrentColor == Color.Red)
                {
                    ChangeImageActivity("SleepR");
                }
            }
            else //For other Pets
            {
                ChangeImageActivity("Sleep");
            }
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            labelPlayerData.Text = myPlayer.DisplayData();
            amimir.Stop();
            FormSelectToys frmSelToys = new FormSelectToys();
            frmSelToys.Owner = this;
            frmSelToys.ShowDialog();
        }

        private void buttonBath_Click(object sender, EventArgs e)
        {
            amimir.Stop();
            if (myPet is Cat)
            {
                labelPlayerData.Text = myPlayer.DisplayData();
                ((Cat)myPet).Bath();

                labelPetData.Text = myPet.DisplayData();
                labelPlayerData.Text = myPlayer.DisplayData();

                ChangeImageActivity("Bath");

                buttonBath.Enabled = false;
                buttonBath.BackColor = Color.WhiteSmoke;
                timerBath.Start();
            }
            else if(myPet is Monkey)
            {
                labelPlayerData.Text = myPlayer.DisplayData();
                ((Monkey)myPet).Bath();

                labelPetData.Text = myPet.DisplayData();
                labelPlayerData.Text = myPlayer.DisplayData();

                ChangeImageActivity("Bath");

                buttonBath.Enabled = false;
                buttonBath.BackColor = Color.WhiteSmoke;
                timerBath.Start();
            }
        }

        private void buttonVaccinate_Click(object sender, EventArgs e)
        {
            try
            {
                if (myPet is Cat)
                {
                    labelPlayerData.Text = myPlayer.DisplayData();
                    ((Cat)myPet).Vaccinate();

                    labelPetData.Text = myPet.DisplayData();
                    ChangeImageActivity("Vaccinate");
                }
                if (myPet is Monkey)
                {
                    labelPlayerData.Text = myPlayer.DisplayData();
                    ((Monkey)myPet).Vaccinate();

                    labelPetData.Text = myPet.DisplayData();
                    ChangeImageActivity("Vaccinate");
                }
                if(myPet is Crocodile)
                {
                    labelPlayerData.Text = myPlayer.DisplayData();
                    ((Crocodile)myPet).Vaccinate();

                    labelPetData.Text = myPet.DisplayData();
                    ChangeImageActivity("Vaccinate");
                }
            }
            catch(Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void buttonClean_Click(object sender, EventArgs e)
        {
            try
            {
                labelPlayerData.Text = myPlayer.DisplayData();
                if (myPet is Fish)
                {
                    ((Fish)myPet).Clean();
                    ChangeImageActivity("Clean");

                    labelPetData.Text = myPet.DisplayData();

                    buttonClean.Enabled = false;
                    buttonClean.BackColor = Color.WhiteSmoke;
                    timerClean.Start();
                }
                if (myPet is Crocodile)
                {
                    ((Crocodile)myPet).Clean();
                    ChangeImageActivity("Clean");

                    labelPetData.Text = myPet.DisplayData();

                    buttonClean.Enabled = false;
                    buttonClean.BackColor = Color.WhiteSmoke;
                    timerClean.Start();
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void timerFeed_Tick(object sender, EventArgs e)
        {
            timerFeed.Stop();
            buttonFeed.Enabled = true;
            buttonFeed.BackColor = Color.Red;
        }

        private void changePetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (myPlayer != null)
            {
                FormChangePet frmChngPet = new FormChangePet();
                frmChngPet.Owner = this;
                timerGame.Stop();
                frmChngPet.ShowDialog();
            }
            else
            {
                MessageBox.Show("You have to start the game first");
            }
        }

        private void timerPictureActivity_Tick(object sender, EventArgs e)
        {
            detik++;
            if(detik == 3)
            {
                ChangeImageActivity("-");
                timerPictureActivity.Stop();
                if(myPet is Chameleon)
                {
                    timerChameleonAfk.Start();
                }
            }
        }

        public void timerGame_Tick(object sender, EventArgs e)
        {
            if (myPet == null)
            {
                return;
            }

            else
            {
                myPet.Health -= 4;
                myPet.Energy -= 4;
                myPet.Happiness -= 4;

                labelPetData.Text = myPet.DisplayData();

                //Ubah CurrentColor Chameleon
                if (myPet is Chameleon)
                {
                    ((Chameleon)myPet).CheckChangeColor();
                }

                //cek kondisi pet
                if (myPet.CheckHealth() == "Very Poor"
                    && myPet.CheckEnergy() == "Weak"
                    && myPet.CheckHappiness() == "Unhappy")
                {
                    fail.Play();
                    //game over
                    timerGame.Stop();
                    timerPresent.Stop();
                    MessageBox.Show("You lost");
                    panelActivity.Visible = false;
                    pictureBoxPresentCoins.Visible = false;
                    panelData.Visible = false;
                    pictureBoxPet.Visible = false;
                    labelTitle.Visible = true;
                    listPlayer.Remove(myPlayer);
                    listPet.Remove(myPet);
                    myPet = null;
                }
            }
        }

        private void SaveDataPlayer(string fileName)
        {
            FileStream myFile = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(myFile, listPlayer);
            myFile.Close();
        }

        private void SaveDataPet(string fileName)
        {
            FileStream myFile = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(myFile, listPet);
            myFile.Close();
        }

        private void ReadDataPlayer(string fileName)
        {
            if (File.Exists(fileName))
            {
                FileStream myFile = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                BinaryFormatter formatter = new BinaryFormatter();
                listPlayer = (List<Player>)formatter.Deserialize(myFile);
                myFile.Close();
            }
        }

        private void ReadDataPet(string fileName)
        {
            if (File.Exists(fileName))
            {
                FileStream myFile = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                BinaryFormatter formatter = new BinaryFormatter();
                listPet = (List<Pet>)formatter.Deserialize(myFile);
                myFile.Close();
            }
        }

        private void FormGame_FormClosing(object sender, FormClosingEventArgs e)
        {
            //save
            SaveDataPlayer("playerData.gm");
            SaveDataPet("petData.gm");
        }

        private void timerSleep_Tick(object sender, EventArgs e)
        {
            timerSleep.Stop();
            amimir.Stop();
            buttonSleep.Enabled = true;
            buttonSleep.BackColor = Color.DeepSkyBlue;
            this.BackgroundImage = Properties.Resources.Room;
        }

        public void timerPlay_Tick(object sender, EventArgs e)
        {
            timerPlay.Stop();
            buttonPlay.Enabled = true;
            buttonPlay.BackColor = Color.Lime;
        }

        private void timerBath_Tick(object sender, EventArgs e)
        {
            timerBath.Stop();
            buttonBath.Enabled = true;
            buttonBath.BackColor = Color.Yellow;
        }

        private void timerClean_Tick(object sender, EventArgs e)
        {
            timerClean.Stop();
            buttonClean.Enabled = true;
            buttonClean.BackColor = Color.DarkOrange;
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHelp frmHelp = new FormHelp();
            frmHelp.Owner = this;
            frmHelp.ShowDialog();
        }

        private void timerChameleonAfk_Tick(object sender, EventArgs e)
        {
            if(myPet is Chameleon)
            {
                ((Chameleon)myPet).PictureChangeChameleon();
                pictureBoxPet.Image = myPet.Picture;
            }
        }

        private void resetGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Are you sure you want to delete all game data?",
                                            "Confirmation", MessageBoxButtons.YesNo);
            if(d == DialogResult.Yes)
            {
                listPet.Clear();
                listPlayer.Clear();
                panelData.Visible = false;
                panelActivity.Visible = false;
                pictureBoxPet.Visible = false;
                labelTitle.Visible = true;
                timerGame.Stop();
                MessageBox.Show("All data has been erased");
            }
            else
            {
                return;
            }
        }

        private void pictureBoxPresentCoins_Click(object sender, EventArgs e)
        {
            myPlayer.GetCoins();
            coin.Play();
            labelPlayerData.Text = myPlayer.DisplayData();
            pictureBoxPresentCoins.Visible = false;
            waktu = 0;
            if(myPet != null)
            {
                timerPresent.Start();
            }
        }

        private void timerPresent_Tick(object sender, EventArgs e)
        {
            awal:
            Random rnd = new Random();
            int presentX;
            int presentY;
            waktu++;

            if (waktu == 10)
            {
                presentX = rnd.Next(8, 720);
                presentY = rnd.Next(120, 300);

                if (presentX >= 220 && presentX <= 520)
                {
                    waktu = 1;
                    goto awal;
                }
                else
                {
                    pictureBoxPresentCoins.Visible = true;
                    pictureBoxPresentCoins.Location = new Point(presentX, presentY);
                }
            }
            else
            {
                return;
            }
        }
    }
}
