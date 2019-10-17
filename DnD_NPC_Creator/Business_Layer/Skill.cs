using System;
using System.Collections.Generic;
using System.Text;

namespace Business_Layer
{
    class Skill
    {
        private int _bonus;
        private int _proficiencyBonus;

        public string Name;
        private bool _hasProficiency;
        private bool _hasExpertice;
        public string RelatedStat;

        public int getBonus()
        {
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
