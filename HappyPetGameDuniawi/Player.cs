using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HappyPetGameDuniawi
{
    [Serializable]
    public class Player
    {
        #region fields
        private string name;
        private int coins;
        private DateTime lastPlay;
        #endregion

        #region constructor
        public Player(string name, int coins, DateTime lastPlay)
        {
            this.Name = name;
            this.Coins = coins;
            this.LastPlay = lastPlay;
        }
        #endregion

        #region properties
        public string Name 
        { 
            get => name;
            set
            {
                if(value != "")
                {
                    name = value;
                }
                else
                {
                    throw new Exception("Please input your name");
                }
            }
        }
        public int Coins
        { 
            get => coins;
            set
            {
                if(value >= 0)
                {
                    coins = value;
                }
                else
                {
                    coins = 0;
                }
            }
        }
        public DateTime LastPlay 
        {
            get => lastPlay;
            set => lastPlay = value; 
        }
        #endregion

        #region method
        public string DisplayData()
        {
            return this.Name +
                   "\nCoins : " + this.Coins;
        }

        public void GetCoins()
        {
            Random rnd = new Random();
            int randomCoin = rnd.Next(50, 101);
            this.Coins += randomCoin;
        }
        #endregion
    }
}