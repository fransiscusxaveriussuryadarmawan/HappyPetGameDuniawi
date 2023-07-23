using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace HappyPetGameDuniawi
{
    [Serializable]
    public abstract class Pet
    {
        #region fields
        private string name;
        private int health;
        private int energy;
        private int happiness;
        private Image picture;
        private Player owner; //1 pet only has one owner
        private List<Toy> listToys; //1 pet can own many toys
        #endregion

        #region constructors
        protected Pet(string name, Image picture, Player owner)
        {
            this.Name = name;
            this.Health = 100;
            this.Energy = 100;
            this.Happiness = 100;
            this.Picture = picture;
            this.Owner = owner;
            this.ListToys = new List<Toy>();
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
                    throw new Exception("Please enter your pet's name");
                }
            }
        }
        public int Health 
        { 
            get => health;
            set
            {
                if(value >= 10 && value <= 100)
                {
                    health = value;
                }
                else if(value < 10)
                {
                    health = 10;
                }
                else
                {
                    health = 100;
                }
            }
        }
        public int Energy 
        { 
            get => energy;
            set
            {
                if (value >= 10 && value <= 100)
                {
                    energy = value;
                }
                else if (value < 10)
                {
                    energy = 10;
                }
                else
                {
                    energy = 100;
                }
            }
        }
        public int Happiness 
        { 
            get => happiness;
            set
            {
                if (value >= 10 && value <= 100)
                {
                    happiness = value;
                }
                else if (value < 10)
                {
                    happiness = 10;
                }
                else
                {
                    happiness = 100;
                }
            }
        }
        public Image Picture
        { 
            get => picture; 
            set => picture = value;
        }
        public Player Owner 
        {
            get => owner; set => owner = value;
        }
        public List<Toy> ListToys 
        { 
            get => listToys; set => listToys = value;
        }
        #endregion

        #region method
        public abstract string DisplayData();

        protected virtual string DisplayPet()
        {
            string data = this.Name +
                        "\nHealth : " + this.Health + "% Energy : " + this.Energy +
                        "% Happiness : " + this.Happiness + "%";
            return data;
        }
        //semua child punya -> abstract
        public abstract void Feed();
        public virtual void Play(Toy toy)
        {
            
        }
        public virtual void Sleep()
        {

        }

        public void BuyToy(Toy newToy)
        {
            if(this.Owner.Coins >= newToy.Price)
            {
                bool toyOwnedStatus = false;
                foreach(Toy t in this.ListToys)
                {
                    //checking IF toy is already in the list
                    if(t.Name == newToy.Name)
                    {
                        toyOwnedStatus = true;
                        break;
                    }
                }

                if(toyOwnedStatus== false)
                {
                    this.ListToys.Add(newToy);
                    this.Owner.Coins -= newToy.Price;
                }
                else
                {
                    throw new Exception("You already own this toy");
                }
            }
            else
            {
                throw new Exception("You do not have enough coins to buy the toy");
            }
        }

        public string CheckHealth()
        {
            string condition;
            if(this.Health >= 10 && this.Health <= 25)
            {
                condition = "Very Poor";
            }
            else if(this.Health >= 26 && this.Health <= 60)
            {
                condition = "Poor";
            }
            else if (this.Health >= 61 && this.Health <= 80)
            {
                condition = "Good";
            }
            else
            {
                condition = "Very Good";
            }
            return condition;
        }

        public string CheckEnergy()
        {
            string condition;
            if (this.Energy >= 10 && this.Energy <= 50)
            {
                condition = "Weak";
            }
            else if (this.Energy >= 51 && this.Energy <= 75)
            {
                condition = "Moderate";
            }
            else
            {
                condition = "Strong";
            }
            return condition;
        }

        public string CheckHappiness()
        {
            string condition;
            if (this.Happiness >= 10 && this.Happiness <= 60)
            {
                condition = "Unhappy";
            }
            else
            {
                condition = "Happy";
            }
            return condition;
        }
        #endregion
    }
}