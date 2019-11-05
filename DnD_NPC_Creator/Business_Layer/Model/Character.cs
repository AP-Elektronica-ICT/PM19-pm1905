using System;
using System.Collections.Generic;
using System.Text;

namespace Business_Layer.Model
{
    public class Character
    {
        public Character()
        {
            Class = new List<Class>();
            Inventory = new List<Item>();
            SpellList = new List<Spell>();
            Stats = new Stat[6];

            Stats[0].Name = "Strenght";
            Stats[1].Name = "Dexterity";
            Stats[2].Name = "Constitution";
            Stats[3].Name = "Intelligent";
            Stats[4].Name = "Wisdom";
            Stats[5].Name = "Charisma";
        }

        List<Class> Class;
        List<Item> Inventory;
        List<Spell> SpellList;
        Background Background;
        //0: Strength, 1: Dexterity, 2: Constitution, 3: Intellignece, 4: Wisdom, 5: Charisma
        Stat[] Stats;
        //Race Race;
        string Race;
        Personality Personality;

        //If copper, silver, elektrum, gold, platinum are all wanted to kep track of.
        int[] Money;
        //If there is only one gold kind to keep track of.
        Double Gold;
    }
}
