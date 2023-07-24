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
            base.Health += 20;
            base.Energy += 40;
            this.Owner.Coins += (int)((0.2 + 0.4) / 2 * 100.0);
        }
        #endregion
    }
}