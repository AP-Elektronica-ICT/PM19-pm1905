using System;
using System.Collections.Generic;
using System.Text;

namespace Business_Layer.Model
{
    class SkillList
    {
        List<Skill> Skills;
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

            Skills.Add(new Skill("acrobatics", "dex"));
            Skills.Add(new Skill("animal handling", "wis"));
            Skills.Add(new Skill("arcana", "int"));
            Skills.Add(new Skill("athletics", "str"));
            Skills.Add(new Skill("deceptions", "cha"));
            Skills.Add(new Skill("history", "int"));
            Skills.Add(new Skill("insight", "wis"));
            Skills.Add(new Skill("intimidation", "cha"));
            Skills.Add(new Skill("investigation", "int"));
            Skills.Add(new Skill("medicine", "wis"));
            Skills.Add(new Skill("nature", "int"));
            Skills.Add(new Skill("perception", "wis"));
            Skills.Add(new Skill("performance", "cha"));
            Skills.Add(new Skill("persuation", "cha"));
            Skills.Add(new Skill("religion", "int"));
            Skills.Add(new Skill("sleight of hand", "dex"));
            Skills.Add(new Skill("stealth", "dex"));
            Skills.Add(new Skill("survival", "wis"));
        }

        public List<int> GetAllSkillBonusses()
        {
            List<int> bonusses = new List<int>();

            foreach (var skill in Skills)
            {
                bonusses.Add(skill.GetBonus());
            }

            return bonusses;
        }

        public int GetSkillBonus(string skillName)
        {
            return GetSkill(skillName).GetBonus();
        }
        public int GetSkillBonus(int skillId)
        {
            return GetSkill(skillId).GetBonus();
        }

        public void UpdateSkillProficiencyBonus(int proficiencyBonus)
        {
            foreach (var skill in Skills)
            {
                skill.setProficiencyBonus(proficiencyBonus);
            }
        }

        public void UpdateSkillProficiency(bool hasProficiency, string skillName)
        {
            Skill skill = GetSkill(skillName);
            skill.setProficiency(hasProficiency);
        }
        public void UpdateSkillProficiency(bool hasProficiency, int skillId)
        {
            Skill skill = GetSkill(skillId);
            skill.setProficiency(hasProficiency);
        }


        public void UpdateSkillExpertise(bool hasExpertise, string skillName)
        {
            Skill skill = GetSkill(skillName);
            skill.setExpertise(hasExpertise);
        }

        public void UpdateSkillExpertise(bool hasExpertise, int skillId)
        {
            Skill skill = GetSkill(skillId);
            skill.setExpertise(hasExpertise);
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
