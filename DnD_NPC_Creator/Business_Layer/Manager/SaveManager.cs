using Business_Layer.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer.Manager
{
    public class SaveManager
    {
        private char characterSeparator = ',';
        private string _saveFolder = @"\Characters";
        public List<string> GetSavedCharacters()
        {
            string saveFolderPath = GetSaveFolderPath();
            if (Directory.Exists(saveFolderPath))
            {
                List<string> characterSaves = new List<string>(Directory.GetFiles(saveFolderPath));
                var replacements = new[]
                {
                    new {Find=saveFolderPath+"\\", Replace=""},
                    new {Find=".txt", Replace=""}
                };
                for (int i = 0; i < characterSaves.Count; i++)
                {
                    foreach (var set in replacements)
                    {
                        characterSaves[i] = characterSaves[i].Replace(set.Find, set.Replace);
                    }
                }
                return characterSaves;
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
                sw.WriteLine(character.GetLevel());
                //Stats
                for (int i = 0; i < 6; i++)
                {
                    sw.Write(character.Stats[i].TotalStat);
                    sw.Write(characterSeparator.ToString());
                }
                sw.WriteLine();
                
                //Skills
                foreach (var skill in character.Skills.Skills)
                {
                    sw.Write(skill.Name + characterSeparator + skill.HasProficiency + characterSeparator + skill.HasExpertise + characterSeparator);
                }
                sw.WriteLine();
                //Class + Subclass
                sw.WriteLine(character.Class + characterSeparator + character.SubClass);
                //Background
                sw.WriteLine(character.Background);
                //Occupation
                sw.WriteLine(character.Occupation);
                //Speed
                sw.WriteLine(character.Speed);
                //HP
                sw.WriteLine(character.HP);
                //Inventory
                foreach (string item in character.Inventory)
                {
                    sw.Write(item + characterSeparator);
                }
                sw.WriteLine();
                //Personality
                sw.WriteLine(character.Personality);
                //Ideals
                sw.WriteLine(character.Ideals);
                //Bonds
                sw.WriteLine(character.Bonds);
                //Flaws
                sw.WriteLine(character.Flaws);
                //Character Info
                sw.WriteLine(character.CharacterInfo);
                //Language proficiencies
                foreach (var item in character.LanguageProficiencies)
                {
                    sw.Write(item + characterSeparator);
                }
                sw.WriteLine();
                //Tool proficiencies
                foreach (var item in character.ToolProficiencies)
                {
                    sw.Write(item + characterSeparator);
                }
                sw.WriteLine();
                //Armor proficiencies
                foreach (var item in character.ArmorProficiencies)
                {
                    sw.Write(item.Name + characterSeparator + item.HasProficiency + characterSeparator);
                }
                sw.WriteLine();
                //Weapon proficiencies
                foreach (var item in character.WeaponProficiencies)
                {
                    sw.Write(item.Name + characterSeparator + item.HasProficiency + characterSeparator);
                }
                sw.WriteLine();
                //Other weapon proficiencies
                sw.WriteLine(character.OtherWeaponProficiencies);
                //Race + Subrace
                sw.WriteLine(character.Race + characterSeparator + character.Subrace);

                //Close the file
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }
        public Character LoadCharacter(string characterName)
        {
            //Setup character
            Character character = new Character();
            //Loading character info
            List<string> characterinfo = LoadTxtFile(characterName);
            //Assigning character info to character
            //Name
            character.Name = characterinfo[0];
            //Level
            character.SetLevel(Convert.ToInt32(characterinfo[1]));
            //Stats
            string[] stats = characterinfo[2].Split(characterSeparator);
            for (int i = 0; i < 6; i++)
            {
                character.Stats[i].TotalStat = Convert.ToInt32(stats[i]);
            }
            //Skills
            string[] skills = characterinfo[3].Split(characterSeparator);
            for (int i = 0; i < 54; i+=3)
            {
                if (skills[i + 1].ToLower() == "true")
                    character.Skills.UpdateSkillProficiency(true, skills[i]);
                if (skills[i + 2].ToLower() == "true")
                    character.Skills.UpdateSkillExpertise(true, skills[i]);
            }
            //Class + Subclass
            string[] c = characterinfo[4].Split(characterSeparator);
            if(c.Length > 0)
                character.Class = c[0];
            if(c.Length > 1)
                character.SubClass = c[1];
            //Background
            character.Background = characterinfo[5];
            //Occupation
            character.Occupation = characterinfo[6];
            //Speed
            character.Speed = Convert.ToInt32(characterinfo[7]);
            //HP
            character.HP = Convert.ToInt32(characterinfo[8]);
            //Inventory
            string[] inventory = characterinfo[9].Split(characterSeparator);
            for (int i = 0; i < inventory.Length; i++)
            {
                character.Inventory.Add(inventory[i]);
            }
            //Personality
            character.Personality = characterinfo[10];
            //Ideals
            character.Ideals = characterinfo[11];
            //Bonds
            character.Bonds = characterinfo[12];
            //Flaws
            character.Flaws = characterinfo[13];
            //Character Info
            character.CharacterInfo = characterinfo[14];
            //Language proficiencies
            string[] lang = characterinfo[15].Split(characterSeparator);
            for (int i = 0; i < lang.Length; i++)
            {
                character.LanguageProficiencies.Add(lang[i]);
            }
            //Tool proficiencies
            string[] tool = characterinfo[16].Split(characterSeparator);
            for (int i = 0; i < tool.Length; i++)
            {
                character.ToolProficiencies.Add(tool[i]);
            }
            //Armor proficiencies
            string[] armor = characterinfo[17].Split(characterSeparator);
            for (int i = 0; i < 4; i += 2)
            {
                if (armor[i + 1].ToLower() == "true")
                    character.ArmorProficiencies[i].HasProficiency = true;
            }
            //Weapon proficiencies
            string[] weapon = characterinfo[18].Split(characterSeparator);
            for (int i = 0; i < 2; i += 2)
            {
                if (weapon[i + 1] == "true")
                    character.WeaponProficiencies[i].HasProficiency = true;
            }
            //Other weapon proficiencies
            character.OtherWeaponProficiencies = characterinfo[19];
            //Race + Subrace
            string[] r = characterinfo[20].Split(characterSeparator);
            if (r.Length > 0)
                character.Class = r[0];
            if (r.Length > 1)
                character.SubClass = r[1];

            return character;
        }
        private List<string> LoadTxtFile(string characterName)
        {
            if (!characterName.EndsWith(".txt"))
                characterName += ".txt";
            try
            {
                //Pass the file path and file name to the StreamReader constructor
                StreamReader sr = new StreamReader(GetSaveFolderPath() + "\\" + characterName);

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
