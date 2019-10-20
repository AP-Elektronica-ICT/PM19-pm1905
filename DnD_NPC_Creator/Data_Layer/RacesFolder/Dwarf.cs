using System;
using System.Collections.Generic;
using System.Text;
using Data_Layer.FeaturesFolder;

namespace Data_Layer.RacesFolder
{
    class Dwarf : RacesClass
    {
        public List<Traits.AllLanguages> DwarfLanguages = new List<Traits.AllLanguages>();
        public List<Proficiencies.AllArmorProficiencies> DwarfArmorProficiencies = new List<Proficiencies.AllArmorProficiencies>();
        public List<Proficiencies.AllWeaponProficiencies> DwarfWeaponProficiencies = new List<Proficiencies.AllWeaponProficiencies>();
        public enum DwarfToolProficiencies { Smiths_Tools, Brewers_Supplies, Masons_Tools }
        enum ExtraDwarfTraits { }
        public enum DwarfSubraces { MountainDwarf, HillDwarf }

        public DwarfSubraces Subraces { get; set; }
        public DwarfToolProficiencies ToolProficiencies { get; set; }

        public Dwarf(string _name, Genders _gender, string _clan, Traits _myTraits, DwarfSubraces _subraces, Abilities _abilities, HitPoints _hP, int _level, DwarfToolProficiencies _toolProficiencies)
            : base (_name, _gender, _clan, _myTraits, _abilities, _hP, _level)
        {
            this.MyTraits.AbilityScoreIncrease = 2;
            this.MyTraits.Alignment = "Lawful";
            this.MyTraits.Size = "Medium";
            this.MyTraits.Speed = 25;
            this.MyTraits.DarkVision = "Superior";
            DwarfLanguages.Add(Traits.AllLanguages.Common);
            DwarfLanguages.Add(Traits.AllLanguages.Dwarvish);
            DwarfWeaponProficiencies.Add(Proficiencies.AllWeaponProficiencies.Battleaxe);
            DwarfWeaponProficiencies.Add(Proficiencies.AllWeaponProficiencies.Handaxe);
            DwarfWeaponProficiencies.Add(Proficiencies.AllWeaponProficiencies.ThrowingHammer);
            DwarfWeaponProficiencies.Add(Proficiencies.AllWeaponProficiencies.Warhammer);
            this.MyTraits.Languages = DwarfLanguages;
            this.Subraces = _subraces;
            this.ToolProficiencies = _toolProficiencies;
            this.MyAbilities.Constitution += 2;
            switch (this.Subraces)
            {
                case DwarfSubraces.MountainDwarf:
                    this.MyAbilities.Wisdom += 1;
                    this.HP.HPHigherLevel += (this.Level + 1);
                    break;
                case DwarfSubraces.HillDwarf:
                    this.MyAbilities.Strength += 2;
                    this.DwarfArmorProficiencies.Add(Proficiencies.AllArmorProficiencies.Light);
                    this.DwarfArmorProficiencies.Add(Proficiencies.AllArmorProficiencies.Medium);
                    break;
                default:
                    break;
            }
        }

    }
}
