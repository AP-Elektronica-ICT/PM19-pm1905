using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business_Layer.Model;

namespace Business_Layer.Manager
{
    public class ApplicationManager
    {
        //LoadManager loadManager;
        SaveManager saveManager;
        Character character;
        //ContentLoader contentLoader;
        public ApplicationManager()
        {
            //loadManager = new LoadManager();
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
