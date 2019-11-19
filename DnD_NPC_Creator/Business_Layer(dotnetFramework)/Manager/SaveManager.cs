using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer_dotnetFramework_.Manager
{
    class SaveManager
    {
        private string _saveFolder = @"\Characters";
        public List<string> GetSelectCharacters()
        {
            if (Directory.Exists(GetSaveFolderPath() + _saveFolder))
            {
                return new List<string>(Directory.GetFiles(GetSaveFolderPath() + _saveFolder));
            }
            else
            {
                return null;
            }
        }
        public string GetSaveFolderPath()
        {
            if (!Directory.Exists(Environment.CurrentDirectory + _saveFolder))
                CreateSaveFolder(Environment.CurrentDirectory + _saveFolder);
            return Environment.CurrentDirectory + _saveFolder;
        }
        public void CreateSaveFolder(string path)
        {
            Directory.CreateDirectory(path);
        }
        public void SaveCharacter(Character character)
        {
            try
            {

                //Pass the filepath and filename to the StreamWriter Constructor
                StreamWriter sw = new StreamWriter(GetSaveFolderPath() + "\\" + character.Name + ".txt");

                //Writing a line to the textfile
                //Name
                sw.WriteLine(character.Name);
                //Level
                sw.WriteLine(character.Level);
                //Stats
                sw.WriteLine(character.Stats[0].TotalStat + " " + character.Stats[1].TotalStat + " " + character.Stats[2].TotalStat + " " + character.Stats[3].TotalStat + " " + character.Stats[4].TotalStat + " " + character.Stats[5].TotalStat);
                //Skills
                foreach (var skill in character.Skills.Skills)
                {
                    sw.Write(skill.Name + " " + skill.HasProficiency + " " + skill.HasExpertise + " ");
                }
                sw.WriteLine();

                //Close the file
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }
        public List<string> LoadCharacter(string character)
        {
            if (!character.EndsWith(".txt"))
                character += ".txt";
            try
            {
                //Pass the file path and file name to the StreamReader constructor
                StreamReader sr = new StreamReader(GetSaveFolderPath() + "\\" + character);

                List<string> characterInfo = new List<string>();

                //Read the first line of text
                string line = sr.ReadLine();

                //Continue to read until you reach end of file
                while (line != null)
                {
                    //write the lie to console window
                    characterInfo.Add(line);
                    //Read the next line
                    line = sr.ReadLine();
                }

                //close the file
                sr.Close();

                return characterInfo;
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
                return null;
            }
        }
    }
}
