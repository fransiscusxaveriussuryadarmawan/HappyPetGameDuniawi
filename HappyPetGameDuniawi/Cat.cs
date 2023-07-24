using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace HappyPetGameDuniawi
{
    [Serializable] //For Serialization
    public class Cat : Pet
    {
        #region fields
        private bool vaccinationStatus;
        #endregion

        #region constructors
        public Cat(string name, Image picture, Player owner) : base(name, picture,owner)
        {
            this.VaccinationStatus = false;
        }
        #endregion

        #region properties
        public bool VaccinationStatus { get => vaccinationStatus; set => vaccinationStatus = value; }
        #endregion

        #region method
        public override string DisplayData()
        {
            string status = "No";
            if(this.VaccinationStatus == true)
            {
                status = "Yes";
            }
            return base.DisplayPet() + 
                   "\nVaccination Status : " + status;
        }
        public override void Feed()
        {
            base.Health += 30;
            base.Energy += 50;
            this.Owner.Coins += (int)((0.3 + 0.5) / 2 * 100.0);
        }
        public override void Sleep()
        {
            base.Health += 20;
            base.Energy += 70;
            this.Owner.Coins += (int)((0.2 + 0.7) / 2.0 * 100.0); //+1
        }
        public override void Play(Toy toy)
        {
            base.Energy -= 30;
            base.Happiness += 50;

            //using toy
            if (toy!= null)
            {
                base.Happiness += toy.Benefit;
            }
        }

        public void Bath()
        {
            this.Owner.Coins += (int)(0.3 / 2 * 100.0);
            base.Health += 30;
        }
        public void Vaccinate()
        {
            if (base.Owner.Coins >= 1000 && this.VaccinationStatus == false)
            {
                this.VaccinationStatus = true;
                base.Health += 40;
                base.Happiness -= 10;
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