using System;
using System.Collections.Generic;
using System.Text;
using Data_Layer.FeaturesFolder;
using Data_Layer.RacesFolder;

namespace Data_Layer.ClassesFolder
{
    class CharacterClass
    {
        public string Description { get; set; }
        public RacesClass Race { get; set; }
        public int Level { get; set; }
        public Features Feature { get; set; }
        public string PrimaryAbility { get; set; }
        public string SavingThrowProficiencies { get; set; }


        //public List<string> GetFeatures(int level);

    }
}
