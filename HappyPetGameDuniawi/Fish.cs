using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace HappyPetGameDuniawi
{
    [Serializable]
    public class Fish : Pet
    {
        #region fields
        private string environment;
        #endregion

        #region constructors
        public Fish(string name, Image picture, Player owner, string environment) : base(name, picture, owner)
        {
            this.Environment = environment;
        }
        #endregion

        #region properties
        public string Environment 
        { 
            get => environment; set => environment = value; 
        }
        #endregion

        #region method
        public override string DisplayData()
        {
            return base.DisplayPet() +
                   "\nEnvironment : " + this.Environment;
        }
        public override void Feed()
        {
            base.Health += 20;
            base.Energy += 40;
        }
        public void Clean()
        {
            if(base.Owner.Coins >= 500)
            {
                base.Happiness += 50;
                base.Health += 60;
                base.Owner.Coins -= 500;
            }
            else
            {
                throw new Exception("You don't have enough coins");
            }
        }
        #endregion
    }
}