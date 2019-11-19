using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer_dotnetFramework_.Model
{
    class SkillList
    {
        public List<Skill> Skills;
        //List<String> Languages;
        //List<Skill> Tools;

        //void AddLanguage(string l)
        //{
        //    Languages.Add(l);
        //}
        //void AddTool(Skill)
        //{

        //}

        public SkillList()
        {
            Skills = new List<Skill>();

            Skills.Add(new Skill("acrobatics", "dex"));         //0
            Skills.Add(new Skill("animal handling", "wis"));    //1
            Skills.Add(new Skill("arcana", "int"));             //2
            Skills.Add(new Skill("athletics", "str"));          //3
            Skills.Add(new Skill("deceptions", "cha"));         //4
            Skills.Add(new Skill("history", "int"));            //5
            Skills.Add(new Skill("insight", "wis"));            //6
            Skills.Add(new Skill("intimidation", "cha"));       //7
            Skills.Add(new Skill("investigation", "int"));      //8
            Skills.Add(new Skill("medicine", "wis"));           //9
            Skills.Add(new Skill("nature", "int"));             //10
            Skills.Add(new Skill("perception", "wis"));         //11
            Skills.Add(new Skill("performance", "cha"));        //12
            Skills.Add(new Skill("persuation", "cha"));         //13
            Skills.Add(new Skill("religion", "int"));           //14
            Skills.Add(new Skill("sleight of hand", "dex"));    //15
            Skills.Add(new Skill("stealth", "dex"));            //16
            Skills.Add(new Skill("survival", "wis"));           //17
        }
        public void SetStatBonusses(Stat[] stats)
        {
            foreach (var skill in Skills)
            {
                if (skill.RelatedStat == "str")
                    skill.StatModifier = stats[0].StatModifier;
                else if (skill.RelatedStat == "dex")
                    skill.StatModifier = stats[1].StatModifier;
                else if (skill.RelatedStat == "int")
                    skill.StatModifier = stats[3].StatModifier;
                else if (skill.RelatedStat == "wis")
                    skill.StatModifier = stats[4].StatModifier;
                else if (skill.RelatedStat == "cha")
                    skill.StatModifier = stats[5].StatModifier;
            }
        }
        public void UpdateStatBonus(Stat stat)
        {
            foreach (var skill in Skills)
            {
                if (skill.RelatedStat == stat.Name.Substring(0, 3).ToLower())
                    skill.StatModifier = stat.StatModifier;
            }
        }
        public List<int> GetAllSkillBonusses()
        {
            List<int> bonusses = new List<int>();

            foreach (var skill in Skills)
            {
                bonusses.Add(skill.GetSkillBonus());
            }

            return bonusses;
        }

        public int GetSkillBonus(string skillName)
        {
            return GetSkill(skillName).GetSkillBonus();
        }
        public int GetSkillBonus(int skillId)
        {
            return GetSkill(skillId).GetSkillBonus();
        }

        public void UpdateSkillProficiencyBonus(int proficiencyBonus)
        {
            foreach (var skill in Skills)
            {
                skill.ProficiencyBonus = proficiencyBonus;
            }
        }

        public void UpdateSkillProficiency(bool hasProficiency, string skillName)
        {
            Skill skill = GetSkill(skillName);
            skill.HasProficiency = hasProficiency;
        }
        public void UpdateSkillProficiency(bool hasProficiency, int skillId)
        {
            Skill skill = GetSkill(skillId);
            skill.HasProficiency = hasProficiency;
        }


        public void UpdateSkillExpertise(bool hasExpertise, string skillName)
        {
            Skill skill = GetSkill(skillName);
            skill.HasExpertise = hasExpertise;
        }

        public void UpdateSkillExpertise(bool hasExpertise, int skillId)
        {
            Skill skill = GetSkill(skillId);
            skill.HasExpertise = hasExpertise;
        }


        public Skill GetSkill(string skillName)
        {
            skillName = skillName.ToLower();

            foreach (var skill in Skills)
            {
                if (skill.Name == skillName)
                {
                    return skill;
                }
            }

            //no skill was found
            return null;
        }
        public Skill GetSkill(int skillId)
        {
            if (skillId < Skills.Count)
            {
                return Skills[skillId];
            }
            else
            {
                //no skill was found
                throw new Exception("Error: ID out of range");
            }
        }
    }
}
