using Business_Layer.Manager;
using Business_Layer.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business_Layer.UnitTests
{
    [TestClass]
    class ManagerTests
    {
        #region ApplicationManager Tests
        [TestMethod]
        public void ApplicationManagerDelegatesSavecharacterCall()
        {
            //Arrange
            Mock<SaveManager> saveManager = new Mock<SaveManager>();
            saveManager.Setup(mock => mock.SaveCharacter(null));
            ApplicationManager applicationManager = new ApplicationManager(saveManager.Object);

            //Act
            applicationManager.SaveCharacter(null);
            
            //Assert
            saveManager.Verify(mock => mock.SaveCharacter(null), Times.Once());
        }
        public void ApplicationManagerDelegatesLoadcharacterCall()
        {
            //Arrange
            Mock<SaveManager> saveManager = new Mock<SaveManager>();
            saveManager.Setup(mock => mock.LoadCharacter(null));
            ApplicationManager applicationManager = new ApplicationManager(saveManager.Object);

            //Act
            applicationManager.LoadCharacter(null);

            //Assert
            saveManager.Verify(mock => mock.LoadCharacter(null), Times.Once());
        }
        public void ApplicationManagerDelegatesGetSavedCharactersCall()
        {
            //Arrange
            Mock<SaveManager> saveManager = new Mock<SaveManager>();
            saveManager.Setup(mock => mock.GetSavedCharacters());
            ApplicationManager applicationManager = new ApplicationManager(saveManager.Object);

            //Act
            applicationManager.LoadCharacter(null);

            //Assert
            saveManager.Verify(mock => mock.GetSavedCharacters(), Times.Once());
        }
        #endregion

        #region SaveManager Tests
        [TestMethod]
        public void TestMethod1()
        {
            //Voorbeeldcode
            //Arrange
            //Act
            //Assert
        }
        #endregion
    }
}
