using System;
using System.Collections.Generic;
using System.Text;

namespace Business_Layer.Model
{
    public class Skill
    {
        public Skill(string name, string relatedStat, int statBonus = 0)
        {
            Name = name;
            RelatedStat = relatedStat;
            StatModifier = statBonus;
        }
    
        public string Name;
        public bool HasProficiency { get; set; }
        public bool HasExpertise { get; set; }
        public int ProficiencyBonus { get; set; }
        public string RelatedStat;
        public int StatModifier { get; set; }

        public int GetSkillBonus()
        {
            if (HasExpertise & HasProficiency)
                return StatModifier + ProficiencyBonus * 2;
            else if (HasProficiency)
                return StatModifier + ProficiencyBonus;
            else
                return StatModifier;
        } 
    }
}
