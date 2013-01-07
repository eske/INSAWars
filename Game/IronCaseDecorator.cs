﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace INSAWars.Game
{
    [Serializable]
    public class IronCaseDecorator : CaseDecorator
    {
        public override int Food
        {
            get { return decoratedCase.Food; }
        }

        public override int Iron
        {
            get { return decoratedCase.Iron + 2; }
        }

        public override string Texture
        {
            get { return decoratedCase.Texture; }
        }

        public IronCaseDecorator(Case decoratedCase)
            : base(decoratedCase) {}

        public override string ToString()
        {
            return decoratedCase.ToString();
        }
    }
}
