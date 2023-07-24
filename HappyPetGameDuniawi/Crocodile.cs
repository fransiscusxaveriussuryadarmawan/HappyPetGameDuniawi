using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace HappyPetGameDuniawi
{
    [Serializable]
    public class Crocodile : Pet
    {
        #region data members
        private bool vaccinationStatus;
        #endregion

        #region constructors
        public Crocodile(string name, Image picture, Player owner) : base(name, picture, owner)
        {
            this.VaccinationStatus = false;
        }
        #endregion

        #region properties
        public bool VaccinationStatus { get => vaccinationStatus; set => vaccinationStatus = value; }
        #endregion

        #region methods
        public override string DisplayData()
        {
            string status = "No";
            if (this.VaccinationStatus == true)
            {
                status = "Yes";
            }
            return base.DisplayPet() +
                   "\nVaccination Status : " + status;
        }
        public override void Feed()
        {
            base.Health += 30;
            base.Energy += 20;
            this.Owner.Coins += (int)((0.3 + 0.2) / 2 * 100.0);
        }

        public override void Sleep()
        {
            base.Health += 30;
            base.Energy += 70;
            this.Owner.Coins += (int)(Math.Round((0.3 + 0.7) / 2.0, 2) * 100.0);
        }

        public override void Clean()
        {
            if (base.Owner.Coins >= 500)
            {
                base.Happiness += 40;
                base.Health += 55;
                base.Owner.Coins -= 500;
            }
            else
            {
                throw new Exception("You don't have enough coins");
            }
        }

        public override void Vaccinate()
        {
            if (base.Owner.Coins >= 1000 && this.VaccinationStatus == false)
            {
                this.VaccinationStatus = true;
                base.Health += 35;
                base.Happiness -= 20;
                base.Owner.Coins -= 1000;
            }
            else if (base.Owner.Coins < 1000)
            {
                throw new Exception("You don't have enough coins");
            }
            else if (this.VaccinationStatus == true)
            {
                throw new Exception("Your cat has already been vaccinated");
            }
        }
        #endregion
    }
}