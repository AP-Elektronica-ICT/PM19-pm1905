using System;
using System.Collections.Generic;
using System.Text;
using Data_Layer.FeaturesFolder;

namespace Data_Layer.RacesFolder
{
    class RacesClass
    {
        public enum Genders { Male, Female }

        public string Name { get; set; }
        public Genders Gender { get; set; }
        public string Clan { get; set; }
        public Traits MyTraits { get; set; }
        public Abilities MyAbilities { get; set; }
        public HitPoints HP { get; set; }
        public int Level { get; set; }

        public RacesClass(string _name, Genders _gender, string _clan, Traits _myTraits, Abilities _abilities, HitPoints _hP, int _level)
        {
            this.Name = _name;
            this.Gender = _gender;
            this.Clan = _clan;
            this.MyTraits = _myTraits;
            this.MyAbilities = _abilities;
            this.HP = _hP;
            this.Level = _level;
        }
    }
}
