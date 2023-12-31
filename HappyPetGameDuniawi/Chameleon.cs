﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace HappyPetGameDuniawi
{
    [Serializable]
    public class Chameleon : Pet
    {
        #region fields
        private Color currentColor;
        #endregion

        #region constructors
        public Chameleon(string name, Image picture, Player owner, Color currentColor) : base(name, picture, owner)
        {
            this.CurrentColor = currentColor;
        }
        #endregion

        #region properties
        public Color CurrentColor 
        { 
            get => currentColor;
            set => currentColor = value; 
        }
        #endregion

        #region method
        public override string DisplayData()
        {
            return base.DisplayPet() +
                   "\nColor : " + this.CurrentColor;
        }
        public override void Feed()
        {
            base.Health += 30;
            base.Energy += 50;
            this.Owner.Coins += (int)((0.3 + 0.5) / 2 * 100.0);
        }
        public override void Sleep()
        {
            base.Health += 60;
            base.Energy += 60;
            this.Owner.Coins += (int)((0.6 + 0.6) / 2 * 100.0);
        }

        public void CheckChangeColor() //ada delay karena frmGame.TimerGame
        {
            if (base.Health >= 70 && base.Energy >= 70)
            {
                this.CurrentColor = Color.Green;
            }
            if (base.Health < 70 && base.Energy < 70)
            {
                this.CurrentColor = Color.Yellow;
            }
            if(base.Health <=40 && base.Energy <= 65)
            {
                this.CurrentColor = Color.Red;
            }
        }

        public void PictureChangeChameleon()
        {
            if(CurrentColor == Color.Green)
            {
                base.Picture = Properties.Resources.chameleonG_def;
            }
            else if (CurrentColor == Color.Yellow)
            {
                base.Picture = Properties.Resources.chameleonY_def;
            }
            else if(CurrentColor == Color.Red)
            {
                base.Picture = Properties.Resources.chameleonR_def;
            }
        }
        #endregion
    }
}