using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace HappyPetGameDuniawi
{
    [Serializable]
    public class Monkey : Pet
    {
        #region data members
        private bool vaccinationStatus;
        #endregion

        #region constructors
        public Monkey(string name, Image picture, Player owner) : base(name, picture, owner)
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
            this.Owner.Coins += (int)(Math.Round((0.3 + 0.2) / 2.0,2) * 100.0);
        }

        public override void Sleep()
        {
            base.Health += 30;
            base.Energy += 60;
            this.Owner.Coins += (int)(Math.Round((0.3 + 0.6) / 2.0, 2) * 100.0);
        }

        public override void Play(Toy toy)
        {
            base.Energy -= 50;
            base.Happiness += 60;

            //using toy
            if (toy != null)
            {
                base.Happiness += toy.Benefit;
            }
        }

        public override void Bath()
        {
            this.Owner.Coins += (int)(0.3 / 2 * 100.0);
            base.Health += 25;
        }

        public override void Vaccinate()
        {
            if (base.Owner.Coins >= 1000 && this.VaccinationStatus == false)
            {
                this.VaccinationStatus = true;
                base.Health += 45;
                base.Happiness -= 15;
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