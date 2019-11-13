using Microsoft.VisualStudio.TestTools.UnitTesting;
using Business_Layer.Model;

namespace Business_Layer.UnitTests
{
    [TestClass]
    public class ModelTests
    {

        [TestMethod]
        public void TestMethodTemplate()
        {
            //Arrange
            //Act
            //Assert
        }
        [DataTestMethod]
        [DataRow(1,-5)]
        [DataRow(2,-4)]
        [DataRow(3,-4)]
        [DataRow(4,-3)]
        [DataRow(5,-3)]
        [DataRow(6,-2)]
        [DataRow(7,-2)]
        [DataRow(8,-1)]
        [DataRow(9,-1)]
        [DataRow(10,0)]
        [DataRow(11,0)]
        [DataRow(12,1)]
        [DataRow(13,1)]
        [DataRow(14,2)]
        [DataRow(15,2)]
        [DataRow(16,3)]
        [DataRow(17,3)]
        [DataRow(18,4)]
        [DataRow(19,4)]
        [DataRow(20,5)]
        public void TestStatInputExpectedNumbers(int a, int b)
        {
            //Arrange
            Stat stat = new Stat("TestStat");
            stat.TotalStat = a;
            //Act
            int result = stat.StatModifier;
            //Assert
            Assert.AreEqual(result, b);
        }
        [TestMethod]
        public void TestStatInputZero()
        {
            //Arrange
            Stat stat = new Stat("TestStat");
            stat.TotalStat = 0;
            //Act
            int result = stat.StatModifier;
            //Assert
            Assert.AreEqual(result, -5);
        }
        [TestMethod]
        public void TestStatInputBelowZero()
        {
            //Arrange
            Stat stat = new Stat("TestStat");
            stat.TotalStat = -4;
            //Act
            int result = stat.StatModifier;
            //Assert
            Assert.AreEqual(result, -7);
        }
        [TestMethod]
        public void TestSkillReturnValue_WithoutProficiency()
        {
            //Arrange
            Skill skill = new Skill("TestSkill","Test");
            skill.ProficiencyBonus = 3;
            skill.StatModifier = 3;
            //Act
            int result = skill.GetSkillBonus();
            //Assert
            Assert.AreEqual(result, 3);
        }
        public void TestSkillReturnValue_WithProficiency()
        {
            //Arrange
            Skill skill = new Skill("TestSkill", "Test");
            skill.ProficiencyBonus = 3;
            skill.StatModifier = 3;
            skill.HasProficiency = true;
            //Act
            int result = skill.GetSkillBonus();
            //Assert
            Assert.AreEqual(result, 6);
        }
        public void TestSkillReturnValue_WithExpertise()
        {
            //Arrange
            Skill skill = new Skill("TestSkill", "Test");
            skill.ProficiencyBonus = 3;
            skill.StatModifier = 3;
            skill.HasProficiency = true;
            skill.HasExpertise = true;
            //Act
            int result = skill.GetSkillBonus();
            //Assert
            Assert.AreEqual(result, 9);
        }
        public void TestSkillReturnValue_WithoutProficiency_WithExpertise()
        {
            //Arrange
            Skill skill = new Skill("TestSkill", "Test");
            skill.ProficiencyBonus = 3;
            skill.StatModifier = 3;
            skill.HasExpertise = true;
            //Act
            int result = skill.GetSkillBonus();
            //Assert
            Assert.AreEqual(result, 6);
        }
            [TestMethod]
        public void TestSkillListSetAllBonusses()
        {
            //Arrange
            //Act
            //Assert
        }
    }
    
}
