using System;
using System.Collections.Generic;
using System.Text;

namespace Business_Layer.Model
{
    class Race
    {
        string Name;
        //0: Strength, 1: Dexterity, 2: Constitution, 3: Intellignece, 4: Wisdom, 5: Charisma
        int[] ABI = new int[6];
        int ABIchoise;
        bool HasDarkvision;
        string Darkvision;
        List<string> Features;
        List<string> FeatureNames;
        List<string> SkillProficiencies;
        List<string> Languages;
    }
}
