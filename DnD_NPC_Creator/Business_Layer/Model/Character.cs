using System;
using System.Collections.Generic;
using System.Text;

namespace Business_Layer.Model
{
    public class Character
    {
        public string Name;
        public int Level;
        public SkillList Skills;
        public Stat[] Stats;

        public Character()
        {
            //Class = new List<Class>();
            //Inventory = new List<Item>();
            //SpellList = new List<Spell>();
            Stats = new Stat[6];

            Stats[0] = new Stat("Strenght");
            Stats[1] = new Stat("Dexterity");
            Stats[2] = new Stat("Constitution");
            Stats[3] = new Stat("Intelligent");
            Stats[4] = new Stat("Wisdom");
            Stats[5] = new Stat("Charisma");

            Skills = new SkillList();
        }

        //List<Class> Class;
        //List<Item> Inventory;
        //List<Spell> SpellList;
        ///Background Background;
        //0: Strength, 1: Dexterity, 2: Constitution, 3: Intellignece, 4: Wisdom, 5: Charisma
        //Race Race;
        //string Race;
        //Personality Personality;

        //If copper, silver, elektrum, gold, platinum are all wanted to kep track of.
        //int[] Money;
        //If there is only one gold kind to keep track of.
        //Double Gold;

        //=>Because of rewriting of perimitters of project lots of models have become obsolete. Won't delete them yet until sure that they are useless.
    }
}
