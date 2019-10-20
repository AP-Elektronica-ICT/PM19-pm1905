using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Layer.FeaturesFolder
{
    public class Proficiencies
    {
        public enum AllArmorProficiencies { Light, Medium }
        public enum AllWeaponProficiencies { Battleaxe, Handaxe, ThrowingHammer, Warhammer }
        public string Armor { get; set; }
        public string Weapons { get; set; }
        public string Tools { get; set; }
        public string SavingThrows { get; set; }
        public string Skills { get; set; }

    }
}
