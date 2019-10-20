using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Layer.RacesFolder
{
    class Traits
    {
        public enum AllLanguages { Common, Dwarvish }

        public int AbilityScoreIncrease { get; set; }
        public int Age { get; set; }
        public string Alignment { get; set; }
        public string Size { get; set; }
        public int Speed { get; set; }
        public string DarkVision { get; set; }
        public List<AllLanguages> Languages { get; set; }

        public Traits(int abilityScoreIncrease, int age, string alignment, string size, int speed, string darkVision, List<AllLanguages> languages)
        {
            this.AbilityScoreIncrease = abilityScoreIncrease;
            this.Age = age;
            this.Alignment = alignment;
            this.Size = size;
            this.Speed = speed;
            this.DarkVision = darkVision;
            this.Languages = languages;
        }
    }
}
