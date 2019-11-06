using System;
using System.Collections.Generic;
using System.Text;

namespace Business_Layer.Model
{
    class Skill
    {
        public Skill(string name, string relatedStat, int statBonus = 0)
        {
            Name = name;
            RelatedStat = relatedStat;
            Bonus = statBonus;
        }
    
        public string Name;
        public bool HasProficiency { get; set; }
        public bool HasExpertise { get; set; }
        public int ProficiencyBonus { get; set; }
        public string RelatedStat;
        public int Bonus { get; set; }

        public int GetBonus()
        {
            if (HasExpertise)
                return Bonus + ProficiencyBonus * 2;
            else if (HasProficiency)
                return Bonus + ProficiencyBonus;
            else
                return Bonus;
        } 
    }
}
