using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace HappyPetGameDuniawi
{
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
            base.Energy += 50;
            this.Owner.Coins += (int)((0.3 + 0.5) / 2 * 100.0);
        }
        #endregion
    }
}