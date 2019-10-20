using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Layer.FeaturesFolder
{
    class Abilities
    {
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Constitution { get; set; }
        public int Intelligence { get; set; }
        public int Wisdom { get; set; }
        public int Charisma { get; set; }

        public Abilities()
        {
            this.Strength = 0;
            this.Dexterity = 0;
            this.Constitution = 0;
            this.Intelligence = 0;
            this.Wisdom = 0;
            this.Charisma = 0;
        }
    }
}
