﻿#region usings
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
#endregion

namespace INSAWars.Game
{
    public class Water : Case
    {
        public override int Food
        {
            get { return 0; }
        }

        public override int Iron
        {
            get { return 0; }
        }

        public Water(int x, int y) : base(x, y) { }

        public override string ToString()
        {
            return "Water (" + x + ", " + y + ")";
        }
    }
}