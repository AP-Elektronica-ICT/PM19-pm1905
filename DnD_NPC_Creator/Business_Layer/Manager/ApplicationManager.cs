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
        SaveManager saveManager;
        public ApplicationManager()
        {
            saveManager = new SaveManager();
        }
        public void SaveCharacter(Character character)
        {
            saveManager.SaveCharacter(character);
        }
        public Character LoadCharacter(string character)
        {
            return saveManager.LoadCharacter(character);
        }
        public List<string> GetSavedCharacters()
        {
            return saveManager.GetSavedCharacters();
        }
        //public Character InitialiseCharacter(List<string> charInfo)
        //{
        //    Character character = new Character();

        //    return character;
        //}
    }
}
