using Business_Layer.Manager;
using Business_Layer.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Business_Layer.UnitTests
{
    [TestClass]
    public class CharacterTests
    {
        Character character;
        [TestInitialize]
        public void TestInitialise()
        {
            this.character = new Character();
        }
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            //Act
            //Assert
        }
        [TestMethod]
        public void TestSkillListSetAllBonusses_WithoutProficiencyBonus()
        {
            //Arrange
            foreach (var stat in character.Stats)
            {
                stat.TotalStat = 12;
            }
            //Act
            character.Skills.SetStatBonusses(character.Stats);
            List<int> bonussesList = character.Skills.GetAllSkillBonusses();
            //Assert
            foreach (var bonus in bonussesList)
            {
                Assert.AreEqual(bonus, 1);
            }

        }
        [TestMethod]
        public void TestSkillListUpdateStatBonus_Get()
        {
            //Act
            foreach (var stat in character.Stats)
            {
                stat.TotalStat = 14;
            }
            character.Skills.UpdateStatBonus(character.Stats[0]);
            character.Skills.UpdateSkillProficiencyBonus(3);
            List<int> bonussesList = character.Skills.GetAllSkillBonusses();
            //Assert
            for (int i = 0; i < bonussesList.Count; i++)
            {
                if (i == 3)
                    Assert.AreEqual(bonussesList[i], 2);
                else    //All others should be 0
                    Assert.AreEqual(bonussesList[i], 0);
            }

        }
        public void TestSkillListUpdateStatBonus_Strength()
        {
            //Act
            foreach (var stat in character.Stats)
            {
                stat.TotalStat = 14;
            }
            character.Skills.UpdateStatBonus(character.Stats[0]);
            character.Skills.UpdateSkillProficiencyBonus(3);
            List<int> bonussesList = character.Skills.GetAllSkillBonusses();
            //Assert
            for (int i = 0; i < bonussesList.Count; i++)
            {
                if (i == 3)
                    Assert.AreEqual(bonussesList[i], 2);
                else    //All others should be 0
                    Assert.AreEqual(bonussesList[i], 0);
            }

        }
        public void TestSkillListUpdateStatBonus_Dexterity()
        {
            //Act
            foreach (var stat in character.Stats)
            {
                stat.TotalStat = 14;
            }
            character.Skills.UpdateStatBonus(character.Stats[1]);
            character.Skills.UpdateSkillProficiencyBonus(3);
            List<int> bonussesList = character.Skills.GetAllSkillBonusses();
            //Assert
            for (int i = 0; i < bonussesList.Count; i++)
            {
                if (i == 0 || i==15||i==16)
                    Assert.AreEqual(bonussesList[i], 2);
                else    //All others should be 0
                    Assert.AreEqual(bonussesList[i], 0);
            }

        }
        public void TestSkillListUpdateStatBonus_Intelligence()
        {
            //Act
            foreach (var stat in character.Stats)
            {
                stat.TotalStat = 14;
            }
            character.Skills.UpdateStatBonus(character.Stats[3]);
            character.Skills.UpdateSkillProficiencyBonus(3);
            List<int> bonussesList = character.Skills.GetAllSkillBonusses();
            //Assert
            for (int i = 0; i < bonussesList.Count; i++)
            {
                if (i == 2||i==5||i==8||i==10||i==14)
                    Assert.AreEqual(bonussesList[i], 2);
                else    //All others should be 0
                    Assert.AreEqual(bonussesList[i], 0);
            }

        }
        public void TestSkillListUpdateStatBonus_Wisdom()
        {
            //Act
            foreach (var stat in character.Stats)
            {
                stat.TotalStat = 14;
            }
            character.Skills.UpdateStatBonus(character.Stats[4]);
            character.Skills.UpdateSkillProficiencyBonus(3);
            List<int> bonussesList = character.Skills.GetAllSkillBonusses();
            //Assert
            for (int i = 0; i < bonussesList.Count; i++)
            {
                if (i == 1||i==6|i==9|i==11|i==16)
                    Assert.AreEqual(bonussesList[i], 2);
                else    //All others should be 0
                    Assert.AreEqual(bonussesList[i], 0);
            }

        }
        public void TestSkillListUpdateStatBonus_Charisma()
        {
            //Act
            foreach (var stat in character.Stats)
            {
                stat.TotalStat = 14;
            }
            character.Skills.UpdateStatBonus(character.Stats[5]);
            character.Skills.UpdateSkillProficiencyBonus(3);
            List<int> bonussesList = character.Skills.GetAllSkillBonusses();
            //Assert
            for (int i = 0; i < bonussesList.Count; i++)
            {
                if (i == 4||i==7||i==12||i==13)
                    Assert.AreEqual(bonussesList[i], 2);
                else    //All others should be 0
                    Assert.AreEqual(bonussesList[i], 0);
            }

        }
    }
}
