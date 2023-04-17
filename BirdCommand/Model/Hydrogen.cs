﻿using BirdCommand.Custom;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdCommand.Model
{
    internal class Hyrdogen : Ion
    {
        public Hyrdogen() : base()
        {
            this.Symbol = "H";
            this.Id = Guid.NewGuid();
            this.Color1 = Color.Purple;
            this.Color2 = Color.MediumPurple;
            this.Name = "Hyrdogen";
            this.Charge = +1;
            this.Radius = 30;
        }
    }
}