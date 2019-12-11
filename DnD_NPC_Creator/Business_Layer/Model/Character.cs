using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer.Model
{
    public class Character
    {
        public string Name;
        private int Level;
        public SkillList Skills;
        public Stat[] Stats;
        public string Class;
        public string SubClass;
        public string Background;
        public string Occupation;
        public string Race;
        public string Subrace;
        public int Speed;
        public int HP;
        public List<string> Inventory;
        public string Personality;
        public string Ideals;
        public string Bonds;
        public string Flaws;
        public string CharacterInfo;
        public List<string> LanguageProficiencies;
        public List<string> ToolProficiencies;
        public List<Skill> ArmorProficiencies;
        public List<Skill> WeaponProficiencies;
        public string OtherWeaponProficiencies;

        public Character()
        {
            //Class = new List<Class>();
            //Inventory = new List<Item>();
            //SpellList = new List<Spell>();
            Inventory = new List<string>();
            //Currently initialses 8 inventory slots
            for (int i = 0; i < 8; i++)
            {
                Inventory.Add("");
            }
            LanguageProficiencies = new List<string>();
            for (int i = 0; i < 4; i++)
            {
                LanguageProficiencies.Add("");
            }
            ToolProficiencies = new List<string>();
            for (int i = 0; i < 4; i++)
            {
                ToolProficiencies.Add("");
            }
            ArmorProficiencies = new List<Skill>
            {
                new Skill("Light"),
                new Skill("Medium"),
                new Skill("Heavy"),
                new Skill("Shields")
            };
            WeaponProficiencies = new List<Skill>
            {
                new Skill("Simple"),
                new Skill("Martial")
            };

            Stats = new Stat[6];

            Stats[0] = new Stat("Strenght");
            Stats[1] = new Stat("Dexterity");
            Stats[2] = new Stat("Constitution");
            Stats[3] = new Stat("Intelligence");
            Stats[4] = new Stat("Wisdom");
            Stats[5] = new Stat("Charisma");

            Skills = new SkillList();
        }

        public bool SetLevel(int inp)
        {
            if (inp > 0 && inp <= 20)
            {
                Level = inp;
                return true;
            }
            else
            {
                return false;
            }
        }
        public int GetLevel()
        {
            return Level;
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
