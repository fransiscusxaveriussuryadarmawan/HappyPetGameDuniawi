using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace HappyPetGameDuniawi
{
    public class Penguin : Pet
    {
        #region data members
        private string environment;
        #endregion

        #region constructors
        public Penguin(string name, Image picture, Player owner, string environment) : base(name, picture, owner)
        {
            this.Environment = environment;
        }
        #endregion

        #region properties
        public string Environment { get => environment; set => environment = value; }
        #endregion

        #region methods
        public override string DisplayData()
        {
            return base.DisplayPet() +
                   "\nEnvironment : " + this.Environment;
        }
        public override void Feed()
        {
            base.Health += 30;
            base.Energy += 35;
            this.Owner.Coins += (int)((0.2 + 0.4) / 2 * 100.0);
        }

        public override void Sleep()
        {
            base.Health += 25;
            base.Energy += 70;
            this.Owner.Coins += (int)(Math.Round((0.2 + 0.7) / 2.0, 2) * 100.0);
        }
        public override void Play(Toy toy)
        {
            base.Energy -= 40;
            base.Happiness += 55;

            //using toy
            if (toy != null)
            {
                base.Happiness += toy.Benefit;
            }
        }
        #endregion
    }
}