using Business_Layer.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business_Layer.Manager
{
    public class ApplicationManager
    {
        LoadManager loadManager;
        SaveManager saveManager;
        Character character; 
        //ContentLoader contentLoader;
        public ApplicationManager()
        {
            loadManager = new LoadManager();
            saveManager = new SaveManager();
            character = new Character();
        }
        public void SaveCharacter()
        {
            saveManager.SaveCharacter(character);
        }
        public void LoadCharacter(string characterDocName)
        {
            InitialiseCharacter(saveManager.LoadCharacter(characterDocName));
        }
        public void InitialiseCharacter(List<string> charInfo)
        {

        }
    }
}
