using System;
using System.Collections.Generic;
using System.Text;

namespace Business_Layer.Model
{
    class Skill
    {
        public Skill(string name, string relatedStat)
        {
            Name = name;
            RelatedStat = relatedStat;
        }

        private int _bonus;
        private int _proficiencyBonus;

        public string Name;
        private bool _hasProficiency;
        private bool _hasExpertice;
        public string RelatedStat;

        public int getBonus()
        {
            if (_hasExpertice)
                return _bonus + _proficiencyBonus * 2;
            else if (_hasProficiency)
                return _bonus + _proficiencyBonus;
            else
                return _bonus;
        } 
        public void setProficiencyBonus(int proficiencyBonus)
        {
            _proficiencyBonus = proficiencyBonus;
        }
        public void setExpertise(bool hasExpertise)
        {
            _hasExpertice = hasExpertise;
        }
    }
}
