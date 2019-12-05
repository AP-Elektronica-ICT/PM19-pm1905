using Business_Layer.Manager;
using Business_Layer.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace DnD_NPC_Creator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ApplicationManager applicationManager;
        Character character;
        public MainWindow()
        {
            applicationManager = new ApplicationManager();
            character = new Character();
            InitializeComponent();
        }

        private void OpenWidow(object sender, RoutedEventArgs e)
        {
            //example, nog af te maken
            SecondWindow1 next = new SecondWindow1();

            // openen van nieuw tablad
            SecondWindow1 objsecondwindow = new SecondWindow1();
            objsecondwindow.RaceSecond.Content = Convert.ToString(ComboBoxRace.SelectedItem);
            objsecondwindow.Namesecond.Content = Convert.ToString(NameInput.Text);
            objsecondwindow.StrengthSecond.Content = Convert.ToString(StrengthBox.Text + "" + StrengthLabel.Content);
            objsecondwindow.DexSecond.Content = Convert.ToString(Dexteritybox.Text + DexterityLabel.Content);
            objsecondwindow.ConSecond.Content = Convert.ToString(Constitutionbox.Text + ConstitutionLabel.Content);
            objsecondwindow.Intsecond.Content = Convert.ToString(Intelligencebox.Text + IntelligenceLabel.Content);
            objsecondwindow.WisSecond.Content = Convert.ToString(Wisdombox.Text + WisdomLabel.Content);
            objsecondwindow.ChaSecond.Content = Convert.ToString(Charismabox.Text + CharismaLabel.Content);
            objsecondwindow.FeatureNameSecond.Content = Convert.ToString(BackgroundCombobox.Text);

            objsecondwindow.ClassSecond.Content = Convert.ToString(ComboClass.SelectedItem);
            objsecondwindow.SubClassSecond.Content = Convert.ToString(SubclassCombo.SelectedItem);
            objsecondwindow.PersonalSecond.Text = Convert.ToString(PersonalBox.Text);
            objsecondwindow.IdealsSecond.Text = Convert.ToString(IdealsBox.Text);
            objsecondwindow.BondsSecond.Text = Convert.ToString(BondsBox.Text);
            objsecondwindow.FlawsSecond.Text = Convert.ToString(FlawsBox.Text);
            objsecondwindow.ToolsSecond.Content = Convert.ToString(ToolsCombobox.SelectedItem);
            objsecondwindow.InstrumentsSecond.Content = Convert.ToString(InstrumentsCombobox.SelectedItem);

            this.Visibility = Visibility.Hidden;
            objsecondwindow.Show();
        }
        public void InitializeCharacter()
        {
            //All comboboxes need to be implemented diffrently
            //Name
            NameInput.Text = character.Name;
            //HP
            HPTextBox.Text = character.HP.ToString();
            //Speed
            SpeedTextBox.Text = character.Speed.ToString();
            //Level
            LevelTextBox.Text = character.GetLevel().ToString();
            //Stats
            StrengthBox.Text = character.Stats[0].TotalStat.ToString();
            StrengthLabel.Content = character.Stats[0].StatModifier.ToString();
            Dexteritybox.Text = character.Stats[1].TotalStat.ToString();
            DexterityLabel.Content = character.Stats[1].StatModifier.ToString();
            Constitutionbox.Text = character.Stats[2].TotalStat.ToString();
            ConstitutionLabel.Content = character.Stats[2].StatModifier.ToString();
            Intelligencebox.Text = character.Stats[3].TotalStat.ToString();
            IntelligenceLabel.Content = character.Stats[3].StatModifier.ToString();
            Wisdombox.Text = character.Stats[4].TotalStat.ToString();
            WisdomLabel.Content = character.Stats[4].StatModifier.ToString();
            Charismabox.Text = character.Stats[5].TotalStat.ToString();
            CharismaLabel.Content = character.Stats[5].StatModifier.ToString();
            //Skills
            //Proficiencies
            Prof_Acrobatics.IsChecked = character.Skills.Skills[0].HasProficiency;
            Prof_Animal_Handling.IsChecked = character.Skills.Skills[1].HasProficiency;
            Prof_Arcana.IsChecked = character.Skills.Skills[2].HasProficiency; ;
            Prof_Athletics.IsChecked = character.Skills.Skills[3].HasProficiency;
            Prof_Deception.IsChecked = character.Skills.Skills[4].HasProficiency;
            Prof_History.IsChecked = character.Skills.Skills[5].HasProficiency;
            Prof_Insight.IsChecked = character.Skills.Skills[6].HasProficiency;
            Prof_Intimidation.IsChecked = character.Skills.Skills[7].HasProficiency;
            Prof_Investigation.IsChecked = character.Skills.Skills[8].HasProficiency;
            Prof_Medicine.IsChecked = character.Skills.Skills[9].HasProficiency; ;
            Prof_Nature.IsChecked = character.Skills.Skills[10].HasProficiency;
            Prof_Perception.IsChecked = character.Skills.Skills[11].HasProficiency;
            Prof_Performance.IsChecked = character.Skills.Skills[12].HasProficiency;
            Prof_Persuation.IsChecked = character.Skills.Skills[13].HasProficiency;
            Prof_Religion.IsChecked = character.Skills.Skills[14].HasProficiency;
            Prof_Sleight_Of_Hand.IsChecked = character.Skills.Skills[15].HasProficiency;
            Prof_Stealth.IsChecked = character.Skills.Skills[16].HasProficiency;
            Prof_Survival.IsChecked = character.Skills.Skills[17].HasProficiency;
            //Expertise
            Ex_Acrobatics.IsChecked = character.Skills.Skills[0].HasExpertise;
            Ex_Animal_Handling.IsChecked = character.Skills.Skills[1].HasExpertise;
            Ex_Arcana.IsChecked = character.Skills.Skills[2].HasExpertise;
            Ex_Athletics.IsChecked = character.Skills.Skills[3].HasExpertise;
            Ex_Deception.IsChecked = character.Skills.Skills[4].HasExpertise;
            Ex_History.IsChecked = character.Skills.Skills[5].HasExpertise;
            Ex_Insight.IsChecked = character.Skills.Skills[6].HasExpertise;
            Ex_Intimidation.IsChecked = character.Skills.Skills[7].HasExpertise;
            Ex_Investigation.IsChecked = character.Skills.Skills[8].HasExpertise;
            Ex_Medicine.IsChecked = character.Skills.Skills[9].HasExpertise;
            Ex_Nature.IsChecked = character.Skills.Skills[10].HasExpertise;
            Ex_Perception.IsChecked = character.Skills.Skills[11].HasExpertise;
            Ex_Performance.IsChecked = character.Skills.Skills[12].HasExpertise;
            Ex_Persuation.IsChecked = character.Skills.Skills[13].HasExpertise;
            Ex_Religion.IsChecked = character.Skills.Skills[14].HasExpertise;
            Ex_Sleight_Of_Hand.IsChecked = character.Skills.Skills[15].HasExpertise;
            Ex_Stealth.IsChecked = character.Skills.Skills[16].HasExpertise;
            Ex_Survival.IsChecked = character.Skills.Skills[17].HasExpertise;
            //Armor
            LightCheck.IsChecked = character.ArmorProficiencies[0].HasExpertise;
            MediumCheck.IsChecked = character.ArmorProficiencies[1].HasExpertise;
            HeavyCheck.IsChecked = character.ArmorProficiencies[2].HasExpertise;
            ShieldsCheck.IsChecked = character.ArmorProficiencies[3].HasExpertise;
            //Weapons
            SimpleCheck.IsChecked = character.WeaponProficiencies[0].HasExpertise;
            MartialCheck.IsChecked = character.WeaponProficiencies[1].HasExpertise;
            WeaponsTextBox.Text = character.OtherWeaponProficiencies;
            //Languages
            LangTextBox1.Text = character.LanguageProficiencies[0];
            LangTextBox2.Text = character.LanguageProficiencies[1];
            LangTextBox3.Text = character.LanguageProficiencies[2];
            LangTextBox4.Text = character.LanguageProficiencies[3];
            //Tools
            ToolsTextBox1.Text = character.ToolProficiencies[0];
            ToolsTextBox2.Text = character.ToolProficiencies[1];
            ToolsTextBox3.Text = character.ToolProficiencies[2];
            ToolsTextBox4.Text = character.ToolProficiencies[3];
            //Personality
            PersonalBox.Text = character.Personality;
            //Ideals
            IdealsBox.Text = character.Ideals;
            //Bonds
            BondsBox.Text = character.Bonds;
            //Flaws
            FlawsBox.Text = character.Flaws;
            //Character Info
            CharInfoTextBox.Text = character.CharacterInfo;
            //Character Items
            CharItemsTextBox1.Text = character.Inventory[0];
            CharItemsTextBox2.Text = character.Inventory[1];
            CharItemsTextBox3.Text = character.Inventory[2];
            CharItemsTextBox4.Text = character.Inventory[3];
            CharItemsTextBox5.Text = character.Inventory[4];
            CharItemsTextBox6.Text = character.Inventory[5];
            CharItemsTextBox7.Text = character.Inventory[6];
            CharItemsTextBox8.Text = character.Inventory[7];
        }

        #region ComboBox Loaded classes
        private void ComboBoxRace_Loaded(object sender, RoutedEventArgs e) //Done
        {
            ComboBoxRace.Text = " ";

            List<string> Races = new List<string>();
            Races.Add("Dragonborn");
            Races.Add("Dwarf");
            Races.Add("Elf");
            Races.Add("Gnome");
            Races.Add("Half-Elf");
            Races.Add("Half-Orc");
            Races.Add("Halfling");
            Races.Add("Human");
            Races.Add("Tiefling");

            var Race = sender as ComboBox;
            Race.ItemsSource = Races;
        }
        private void ComboBoxClass_Loaded(object sender, RoutedEventArgs e) //Done
        {
            ComboClass.Text = "";

            List<string> Classes = new List<string>();
            Classes.Add("Barbarian");
            Classes.Add("Bard");
            Classes.Add("Cleric");
            Classes.Add("Druid");
            Classes.Add("Fighter");
            Classes.Add("Monk");
            Classes.Add("Paladin");
            Classes.Add("Ranger");
            Classes.Add("Rogue");
            Classes.Add("Sorcorer");
            Classes.Add("Warlock");
            Classes.Add("Wizard");

            var Class = sender as ComboBox;
            Class.ItemsSource = Classes;
        }
        private void ComboBoxSubClass_Loaded(object sender, RoutedEventArgs e) //Empty
        {

        }
        private void ComboBoxBackground_Loaded(object sender, RoutedEventArgs e) //Done
        {
            BackgroundCombobox.Text = " ";

            List<string> Backgrounds = new List<string>();
            Backgrounds.Add("Acolyte");
            Backgrounds.Add("Anthropologist");
            Backgrounds.Add("Archeologist");
            Backgrounds.Add("Charlatan");
            Backgrounds.Add("City Watch");
            Backgrounds.Add("Clan Crafter");
            Backgrounds.Add("Cloistered Scholar");
            Backgrounds.Add("Courtier");
            Backgrounds.Add("Criminal");
            Backgrounds.Add("Entertainer");
            Backgrounds.Add("Faction Agent");
            Backgrounds.Add("Far Traveler");
            Backgrounds.Add("Folk Hero");
            Backgrounds.Add("Gladiator (Entertainer)");
            Backgrounds.Add("Guild Artisan");
            Backgrounds.Add("Guild Merchant (Guild Artisan)");
            Backgrounds.Add("Haunted one");
            Backgrounds.Add("Hermit");
            Backgrounds.Add("Inheritor");
            Backgrounds.Add("Investigator (City Watch)");
            Backgrounds.Add("Knight (Noble)");
            Backgrounds.Add("Knight of the Order");
            Backgrounds.Add("Mercenary Veteran");
            Backgrounds.Add("Noble");
            Backgrounds.Add("Outlander");
            Backgrounds.Add("Pirate (Sailor)");
            Backgrounds.Add("Sage");
            Backgrounds.Add("Sailor");
            Backgrounds.Add("Soldier");
            Backgrounds.Add("Spy (Criminal)");
            Backgrounds.Add("Urban Bounty Hunter");
            Backgrounds.Add("Urchin");
            Backgrounds.Add("Uthgardt Tribe Member");
            Backgrounds.Add("Waterdhavian Noble");
            
            var Background = sender as ComboBox;
            Background.ItemsSource = Backgrounds;
        }

        private void LoadBox_Loaded(object sender, RoutedEventArgs e)
        {
            List<string> characters = applicationManager.GetSavedCharacters();

            var character = sender as ComboBox;
            character.ItemsSource = characters;
        }


        private void ToolsCombobox_Loaded(object sender, RoutedEventArgs e) //Done?
        {
            string[] ToolItems = new string[] { "Alchemist's suplies", "Brewer's supplies", "Calligrapher's Supplies", "Carpenters's tools", "cortographer's tools", "Cobbler's tools", "Cook's utensils", "Glassblower's tools", "jeweler's tools", "leatherworker's tools", "Mason's tools", "Potter's tools", "Smith's tools", "Tinker's tools", "Weaver's tools", "Woodcarver's tools" };
            List<string> Tools = new List<string>();
            for (int i = 0; i < ToolItems.Length; i++)
            {
                ToolsCombobox.Items.Add(ToolItems[i]);
            }


            /*

            var Tool = sender as ComboBox;
            Tool.ItemsSource = Tools;
            Tool.SelectedIndex = 0;
            */
        }
        private void InstrumentsCombobox_Loaded(object sender, RoutedEventArgs e) //Done
        {
            string[] InstrumentsItems = new string[] { "Bagpipes", "Drum", "Dulcimer", "Flute", "Lute", "Lyre", "Horn", "Pan Flute", "Shawn", "Viol", "Navigator's tool", "Thieves' tools" };
            List<string> Instruments = new List<string>();

            foreach (string instrument in InstrumentsItems)
            {
                InstrumentsCombobox.Items.Add(instrument);
            }
        }
        private void SpecificationCombobox_Loaded(object sender, RoutedEventArgs e) //In Progress
        {

            //foreach (string specification in SpecificationItems)
            //{
            //    SpecificationCombobox.Items.Add(specification);
            //}

            
        }
        private void SubRaceCombo_Loaded(object sender, RoutedEventArgs e) //Empty
        {

        }
        #endregion

        #region Combobox Selection Changed
        private void SublassCombo_SelectionChanged(object sender, SelectionChangedEventArgs e) //Empty
        {
            character.SubClass = SubclassCombo.SelectedItem.ToString();
        }

        private void BackgroundCombobox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string[] SpecCriminal = new string[] { "Blackmailer", "Burglar", "Enforcer", "Fence", "Highway robber", "Hired killer", "Pickpocket", "Smuggler", };
            string[] SpecEntertainer = new string[] { "Actor", "Dancer", "Fire-eater", "Jester", "Juggler", "Instrumentalist", "Poet", "Singer", "Storyteller", "Tumbler" };
            string[] SpecFarTraveler = new string[] { "Emissary", "Exile", "Fugitive", "Pilgrim", "Sightseer", "Wanderer" };
            string[] SpecGuildArtisan = new string[] {"Alchemists and apothecaries", "Armorers, locksmiths, and finesmiths", "Brewers, distillers, and vintners", "Calligraphers, scribes, and scriveners", "Carpenters, roofers, and plasterers", "Cartographers, surveyors, and chart-makers", "Cobblers and shoemakers", "Cooks and bakers", "Glassblowers and glaziers", "Jewelers and gemcutters", "Leatherworkers, skinners, and tanners", "Masons and stonecutters", "Painters, limners, and sign-makers", "Potters and tile-makers", "Shipwrights and sailmakers", "Smiths and metal-forgers", "Tinkers, pewterers, and casters", "Wagon-makers and wheelwrights", "Weavers and dyers", "Woodcarvers, coopers, and bowyers" };
            string[] SpecOutlander = new string[] { "Forester", "Trapper", "Homesteader", "Guide", "Exile or outcast", "Bounty hunter", "Pilgrim", "Tribal nomad", "Hunter-gatherer", "Tribal marauder" };
            string[] SpecSage = new string[] { "Alchemist", "Astronomer", "Discredited academic", "Librarian", "Professor", "Researcher", "Wizard's apprentice", "Scribe" };
            string[] SpecSoldier = new string[] { "Officer", "Scout", "Infantry", "Cavalry", "Healer", "Quartermaster", "Standard bearer", "Support staff (cook, blacksmith, or the like)" };

            SpecificationCombobox.Items.Clear();
            switch (Convert.ToString(BackgroundCombobox.SelectedItem))
            {
                case "Criminal":
                    foreach (string criminal in SpecCriminal)
                    {
                        SpecificationCombobox.Items.Add(criminal);
                    }
                    break;
                case "Entertainer":
                    foreach (string entertainer in SpecEntertainer)
                    {
                        SpecificationCombobox.Items.Add(entertainer);
                    }
                    break;
                case "Far Traveler":
                    foreach (string farTraveler in SpecFarTraveler)
                    {
                        SpecificationCombobox.Items.Add(farTraveler);
                    }
                    break;
                case "Guild Artisan":
                    foreach (string guildArtisan in SpecGuildArtisan)
                    {
                        SpecificationCombobox.Items.Add(guildArtisan);
                    }
                    break;
                case "Outlander":
                    foreach (string outlander in SpecOutlander)
                    {
                        SpecificationCombobox.Items.Add(outlander);
                    }
                    break;
                case "Sage":
                    foreach (string sage in SpecSage)
                    {
                        SpecificationCombobox.Items.Add(sage);
                    }
                    break;
                case "Soldier":
                    foreach (string soldier in SpecSoldier)
                    {
                        SpecificationCombobox.Items.Add(soldier);
                    }
                    break;
                default:
                    break;
            }
            character.Background = BackgroundCombobox.SelectedItem.ToString();
        }
        private void Race_SelectionChanged(object sender, SelectionChangedEventArgs e) //Done
        {
            string[] SubDragonborn = new string[] { "Black", "Blue", "Brass", "Bronze", "Copper", "Gold", "Green", "Red", "Silver", "White" };
            string[] SubDwarf = new string[] { "Hill Dwarf", "Mountain Dwarf", "Underdark Dwarf" };
            string[] SubElf = new string[] { "Dark Elf", "Eladrin", "High Elf", "Sea Elf", "Shadar-Kai", "Wood Elf" };
            string[] SubGnome = new string[] { "Forest Gnome", "Rock Gnome", "Svirfneblin" };
            string[] SubHalfElf = new string[] { };
            string[] SubHalfOrc = new string[] { };
            string[] SubHalfling = new string[] { "Lightfoot Halfling", "Stout Halfling", "Ghostwise Halfling" };
            string[] SubHuman = new string[] { "Standard Human", "Variant Human" };
            string[] SubTiefling = new string[] { "Bloodline of Asmodeus", "Bloodline of Baalzebul", "Devil's Tongue Bloodline", "Bloodline of Dispater", "Bloodline of Fierna", "Bloodline of Glasya", "Bloodline of Levistus", "Bloodline of Mammon", "Bloodline of Mephistopheles", "Winged Bloodline", "Bloodline of Zariel" };

            SubRaceCombo.Items.Clear();
            switch (Convert.ToString(ComboBoxRace.SelectedItem))
            {
                case "Dragonborn":
                    foreach (string dragonborn in SubDragonborn)
                    {                 
                        SubRaceCombo.Items.Add(dragonborn);
                    }
                    break;
                case "Dwarf":
                    foreach (string dwarf in SubDwarf)
                    {
                        SubRaceCombo.Items.Add(dwarf);
                    }
                    break;
                case "Elf":
                    foreach (string elf in SubElf)
                    {
                        SubRaceCombo.Items.Add(elf);
                    }
                    break;
                case "Gnome":
                    foreach (string gnome in SubGnome)
                    {
                        SubRaceCombo.Items.Add(gnome);
                    }
                    break;
                case "Half-Elf":
                    foreach (string halfElf in SubHalfElf)
                    {
                        SubRaceCombo.Items.Add(halfElf);
                    }
                    break;
                case "Half-Orc":
                    foreach (string halfOrc in SubHalfOrc)
                    {
                        SubRaceCombo.Items.Add(halfOrc);
                    }
                    break;
                case "Halfling":
                    foreach (string halfling in SubHalfling)
                    {
                        SubRaceCombo.Items.Add(halfling);
                    }
                    break;
                case "Human":
                    foreach (string human in SubHuman)
                    {
                        SubRaceCombo.Items.Add(human);
                    }
                    break;
                case "Tiefling":
                    foreach (string tiefling in SubTiefling)
                    {
                        SubRaceCombo.Items.Add(tiefling);
                    }
                    break;
                default:
                    break;
            }
            character.Race = ComboBoxRace.SelectedItem.ToString();
        }
        private void Class_SelectionChanged(object sender, SelectionChangedEventArgs e) //Done
        {
            string[] SubBarbarian = new string[] { "Path of the Ancestral quardian", "Path of the Battlerager", "Path of the Berserker", "Path of the Storm Herald", "Path of the Totem Warrior", "Path of the Zealot" };
            string[] SubBard = new string[] { "College of Glamour", "College of Lore", "College of Swords", "College of Valor", "College of Whispers" };
            string[] SubCleric = new string[] { "Arcana Domain", "Death Domain", "Forge Domain", "Grave Domain", "Knowledge Domain", "Life Domain", "Light Domain", "Nature Domain", "Order Domain", "Tempest Domain", "Trickery Domain", "War Domain" };
            string[] SubDruid = new string[] { "Circle of Dreams", "Circle of Land", "Circle of Moon", "Circle of Shepherd", "Circle of Spores" };
            string[] SubFighter = new string[] { "Arcane Archer", "Banneret", "Battle Master", "Cavalier", "Champion", "Eldritch Knight", "Samurai" };
            string[] SubMonk = new string[] { "Way of the Drunken Master", "Way of the Four Elements", "Way of the Kensei", "Way of the Long Death", "Way of the Open Hand", "Way of Shadow", "Way of the Sun Soul" };
            string[] SubPaladin = new string[] { "Oath of the Ancients", "Oath of Concuest", "Oath of the Crown", "Oath of Devotion", "Oath of Redemption", "Oath of Vengeance", "Oathbreaker" };
            string[] SubRanger = new string[] { "Beast Master Conclave", "Gloom Stalker Conclave", "Horizon Walker Conclave", "Hunter Conclave", "Monster Slayer Conclave" };
            string[] SubRogue = new string[] { "Arcane Trickster", "Assassin", "Inquisitive", "Mastermind", "Scout", "Swashbuckler", "Thief" };
            string[] SubSorcorer = new string[] { "Draconic Bloodline", "Devine Soul", "Phoenix Sorcery", "Shadow Magic", "Storm Sorcery", "Wild Magic" };
            string[] SubWarlock = new string[] { "Archfey", "Celestial", "Fiend", "Great Old One", "Hexblade", "Undying" };
            string[] SubWizard = new string[] { "School of Abjuration", "School of Bladesinging", "School of Conjuration", "School of Divination", "School of Enchantment", "School of Evocation", "School of Illusion", "School of Necromancy", "School of Transmutaion", "School of War Magic" };


            SubclassCombo.Items.Clear();
            switch (Convert.ToString(ComboClass.SelectedItem))
            {
                case "Barbarian":
                    foreach (string barbarian in SubBarbarian)
                    {
                        SubclassCombo.Items.Add(barbarian);
                    }
                    break;
                case "Bard":
                    foreach (string bard in SubBard)
                    {
                        SubclassCombo.Items.Add(bard);
                    }
                    break;
                case "Cleric":
                    foreach (string cleric in SubCleric)
                    {
                        SubclassCombo.Items.Add(cleric);
                    }
                    break;
                case "Druid":
                    foreach (string druid in SubDruid)
                    {
                        SubclassCombo.Items.Add(druid);
                    }
                    break;
                case "Fighter":
                    foreach (string fighter in SubFighter)
                    {
                        SubclassCombo.Items.Add(fighter);
                    }
                    break;
                case "Monk":
                    foreach (string monk in SubMonk)
                    {
                        SubclassCombo.Items.Add(monk);
                    }
                    break;
                case "Paladin":
                    foreach (string paladin in SubPaladin)
                    {
                        SubclassCombo.Items.Add(paladin);
                    }
                    break;
                case "Ranger":
                    foreach (string ranger in SubRanger)
                    {
                        SubclassCombo.Items.Add(ranger);
                    }
                    break;
                case "Rogue":
                    foreach (string rogue in SubRogue)
                    {
                        SubclassCombo.Items.Add(rogue);
                    }
                    break;
                case "Sorcorer":
                    foreach (string sorcorer in SubSorcorer)
                    {
                        SubclassCombo.Items.Add(sorcorer);
                    }
                    break;
                case "Warlock":
                    foreach (string warlock in SubWarlock)
                    {
                        SubclassCombo.Items.Add(warlock);
                    }
                    break;
                case "Wizard":
                    foreach (string wizard in SubWizard)
                    {
                        SubclassCombo.Items.Add(wizard);
                    }
                    break;
                default:
                    break;
            }

            character.Class = ComboClass.SelectedItem.ToString();

        }
        private void LoadBox_SelectionChanged(object sender, RoutedEventArgs e)
        {
            //Debug.WriteLine(LoadBox.SelectedItem.ToString());
            character = applicationManager.LoadCharacter(LoadBox.SelectedItem.ToString());
            InitializeCharacter();
        }
        private void SpecificationCombobox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            character.Specification = SpecificationCombobox.SelectedItem.ToString();
        }
        #endregion

        #region Button Click
        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
             Debug.WriteLine("Saving named character");
            applicationManager.SaveCharacter(character);

             List<string> characters = applicationManager.GetSavedCharacters();

            var loadbox = LoadBox as ComboBox;
            loadbox.ItemsSource = characters;
        }
        #endregion

        #region Keydown classes

        private bool PressedTab(KeyEventArgs e)
        {
            return (e.Key == Key.Tab);
        }
        private bool PressedEnter(KeyEventArgs e)
        {
            return (e.Key == Key.Enter);
        }
        private void Strength_KeyDown(object sender, KeyEventArgs e)
        {
            int getal;

            if (PressedEnter(e))
            {
                getal = int.Parse(StrengthBox.Text);
                character.Stats[0].TotalStat = getal;
                //schrijf hier berkening voor +points
                if (character.Stats[0].StatModifier < 0)
                    StrengthLabel.Content = character.Stats[0].StatModifier;
                else
                    StrengthLabel.Content = "+" + character.Stats[0].StatModifier;
            }
        }

        private void Dexterity_KeyDown(object sender, KeyEventArgs e)
        {
            int getal;

            if (PressedEnter(e))
            {
                getal = int.Parse(Dexteritybox.Text);
                character.Stats[1].TotalStat = getal;
                if (character.Stats[1].StatModifier < 0)
                    DexterityLabel.Content = character.Stats[1].StatModifier;
                else
                    DexterityLabel.Content = "+" + character.Stats[1].StatModifier;
            }
        }

        private void Constitution_KeyDown(object sender, KeyEventArgs e)
        {
            int getal;

            if (PressedEnter(e))
            {
                getal = int.Parse(Constitutionbox.Text);
                character.Stats[2].TotalStat = getal;
                if (character.Stats[2].StatModifier < 0)
                    ConstitutionLabel.Content = character.Stats[2].StatModifier;
                else
                    ConstitutionLabel.Content = "+" + character.Stats[2].StatModifier;
            }
        }

        private void Intelligence_KeyDown(object sender, KeyEventArgs e)
        {
            int getal;

            if (PressedEnter(e))
            {
                getal = int.Parse(Intelligencebox.Text);
                character.Stats[3].TotalStat = getal;
                if(character.Stats[3].StatModifier<0)
                    IntelligenceLabel.Content = character.Stats[3].StatModifier;
                else
                    IntelligenceLabel.Content = "+" + character.Stats[3].StatModifier;

            }
        }

        private void Wisdom_KeyDown(object sender, KeyEventArgs e)
        {
            int getal;

            if (PressedEnter(e))
            {
                getal = int.Parse(Wisdombox.Text);
                character.Stats[4].TotalStat = getal;
                if (character.Stats[4].StatModifier < 0)
                    WisdomLabel.Content = character.Stats[4].StatModifier;
                else
                    WisdomLabel.Content = "+" + character.Stats[4].StatModifier;


            }

        }

        private void Charisma_KeyDown(object sender, KeyEventArgs e)
        {
            int getal;

            if (PressedEnter(e))
            {
                getal = int.Parse(Charismabox.Text);
                character.Stats[5].TotalStat = getal;
                if (character.Stats[5].StatModifier < 0)
                    CharismaLabel.Content = character.Stats[5].StatModifier;
                else
                    CharismaLabel.Content = "+" + character.Stats[5].StatModifier;

            }
        }
        #endregion

        #region PreviewTextInput Classes
        private void Scorebox_previewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = new Regex("[^0-9]+").IsMatch(e.Text);
        }

        private void Dexteriybox_previewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = new Regex("[^0-9]+").IsMatch(e.Text);
        }

        private void Constitutionbox_previewTextBox(object sender, TextCompositionEventArgs e)
        {
            e.Handled = new Regex("[^0-9]+").IsMatch(e.Text);
        }

        private void Intelligencebox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = new Regex("[^0-9]+").IsMatch(e.Text);
        }

        private void Wisdombox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = new Regex("[^0-9]+").IsMatch(e.Text);

        }

        private void Charisma_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = new Regex("[^0-9]+").IsMatch(e.Text);

        }
        private void LevelTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = new Regex("[^0-9]+").IsMatch(e.Text);
        }

        private void HPTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = new Regex("[^0-9]+").IsMatch(e.Text);
        }

        private void SpeedTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = new Regex("[^0-9]+").IsMatch(e.Text);
        }
        #endregion

        #region LostKeyboardFocus
        private void NameInput_LostKeyboardFocus(object sender, RoutedEventArgs e)
        {
            character.Name = NameInput.Text;
        }

        private void PersonalBox_LostKeyboardFocus(object sender, RoutedEventArgs e)
        {
            character.Personality = PersonalBox.Text;
        }

        private void IdealsBox_LostKeyboardFocus(object sender, RoutedEventArgs e)
        {
            character.Ideals = IdealsBox.Text;
        }

        private void BondsBox_LostKeyboardFocus(object sender, RoutedEventArgs e)
        {
            character.Bonds = BondsBox.Text;
        }

        private void FlawsBox_LostKeyboardFocus(object sender, RoutedEventArgs e)
        {
            character.Flaws = FlawsBox.Text;
        }

        private void HPTextBox_LostKeyboardFocus(object sender, RoutedEventArgs e)
        {
        
            try 
	        {
                character.HP = Convert.ToInt32(HPTextBox.Text);	
	        }
	        catch (global::System.Exception)
	        {
                HPTextBox.Text = "Invalid";
	        }
        }

        private void SpeedTextBox_LostKeyboardFocus(object sender, RoutedEventArgs e)
        {
            try
            {
                character.Speed = Convert.ToInt32(SpeedTextBox.Text);
            }
            catch (global::System.Exception)
            {
                SpeedTextBox.Text = "Invalid";
            }
        }

        private void CharacterInfo_LostKeyboardFocus(object sender, RoutedEventArgs e)
        {
            character.CharacterInfo = CharInfoTextBox.Text;
        }

        private void CharItemTextBox_LostKeyboardFocus(object sender, RoutedEventArgs e)
        {
            character.Inventory[0] = CharItemsTextBox1.Text;
            character.Inventory[1] = CharItemsTextBox2.Text;
            character.Inventory[2] = CharItemsTextBox3.Text;
            character.Inventory[3] = CharItemsTextBox4.Text;
            character.Inventory[4] = CharItemsTextBox5.Text;
            character.Inventory[5] = CharItemsTextBox6.Text;
            character.Inventory[6] = CharItemsTextBox7.Text;
            character.Inventory[7] = CharItemsTextBox8.Text;
        }

        private void WeaponsTextBox_LostKeyboardFocus(object sender, RoutedEventArgs e)
        {
            character.OtherWeaponProficiencies = WeaponsTextBox.Text;
        }

        private void ToolTextBox_LostKeyboardFocus(object sender, RoutedEventArgs e)
        {
            character.ToolProficiencies[0] = ToolsTextBox1.Text;
            character.ToolProficiencies[1] = ToolsTextBox2.Text;
            character.ToolProficiencies[2] = ToolsTextBox3.Text;
            character.ToolProficiencies[3] = ToolsTextBox4.Text;
        }

        private void LanguangeTextBox_LostKeyboardFocus(object sender, RoutedEventArgs e)
        {
            character.LanguageProficiencies[0] = LangTextBox1.Text;
            character.LanguageProficiencies[1] = LangTextBox2.Text;
            character.LanguageProficiencies[2] = LangTextBox3.Text;
            character.LanguageProficiencies[3] = LangTextBox4.Text;
        }

        private void LevelTextBox_LostKeyboardFocus(object sender, RoutedEventArgs e)
        {
            int speed = 0;
            try
            {
                speed = Convert.ToInt32(LevelTextBox.Text);
            }
            catch (global::System.Exception)
            {
                LevelTextBox.Text = "Invalid";
            }

            if (!character.SetLevel(speed))
                LevelTextBox.Text = "Invalid";
        }
        private void StrengthBox_LostKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            int getal = int.Parse(StrengthBox.Text);
            character.Stats[0].TotalStat = getal;
            if (character.Stats[0].StatModifier < 0)
                StrengthLabel.Content = character.Stats[0].StatModifier;
            else
                StrengthLabel.Content = "+" + character.Stats[0].StatModifier;
        }

        private void DexterityBox_LostKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            int getal = int.Parse(Dexteritybox.Text);
            character.Stats[1].TotalStat = getal;
            if (character.Stats[1].StatModifier < 0)
                DexterityLabel.Content = character.Stats[1].StatModifier;
            else
                DexterityLabel.Content = "+" + character.Stats[1].StatModifier;
        }

        private void ConstitutionBox_LostKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            int getal = int.Parse(Constitutionbox.Text);
            character.Stats[2].TotalStat = getal;
            if (character.Stats[2].StatModifier < 0)
                ConstitutionLabel.Content = character.Stats[2].StatModifier;
            else
                ConstitutionLabel.Content = "+" + character.Stats[2].StatModifier;
        }

        private void IntelligenceBox_LostKeyboardFocus(object sender, RoutedEventArgs e)
        {
            int getal = int.Parse(Intelligencebox.Text);
            character.Stats[3].TotalStat = getal;
            if (character.Stats[3].StatModifier < 0)
                IntelligenceLabel.Content = character.Stats[3].StatModifier;
            else
                IntelligenceLabel.Content = "+" + character.Stats[3].StatModifier;
        }

        private void WindowBox_LostKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            int getal = int.Parse(Wisdombox.Text);
            character.Stats[4].TotalStat = getal;
            if (character.Stats[4].StatModifier < 0)
                WisdomLabel.Content = character.Stats[4].StatModifier;
            else
                WisdomLabel.Content = "+" + character.Stats[4].StatModifier;
        }

        private void CharismaBox_LostKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            int getal = int.Parse(Charismabox.Text);
            character.Stats[5].TotalStat = getal;
            if (character.Stats[5].StatModifier < 0)
                CharismaLabel.Content = character.Stats[5].StatModifier;
            else
                CharismaLabel.Content = "+" + character.Stats[5].StatModifier;
        }
        #endregion

        #region Changed
        private void Expertise_Changed(object sender, RoutedEventArgs e)
        {
            character.Skills.UpdateSkillProficiency(Ex_Acrobatics.IsChecked == true, "acrobatics");
            character.Skills.UpdateSkillProficiency(Ex_Animal_Handling.IsChecked == true, "animal handling");
            character.Skills.UpdateSkillProficiency(Ex_Arcana.IsChecked == true, "arcana");
            character.Skills.UpdateSkillProficiency(Ex_Athletics.IsChecked == true, "athletics");
            character.Skills.UpdateSkillProficiency(Ex_Deception.IsChecked == true, "deception");
            character.Skills.UpdateSkillProficiency(Ex_History.IsChecked == true, "history");
            character.Skills.UpdateSkillProficiency(Ex_Insight.IsChecked == true, "insight");
            character.Skills.UpdateSkillProficiency(Ex_Intimidation.IsChecked == true, "intimidation");
            character.Skills.UpdateSkillProficiency(Ex_Investigation.IsChecked == true, "investigation");
            character.Skills.UpdateSkillProficiency(Ex_Medicine.IsChecked == true, "medicine");
            character.Skills.UpdateSkillProficiency(Ex_Nature.IsChecked == true, "nature");
            character.Skills.UpdateSkillProficiency(Ex_Perception.IsChecked == true, "perception");
            character.Skills.UpdateSkillProficiency(Ex_Performance.IsChecked == true, "performance");
            character.Skills.UpdateSkillProficiency(Ex_Persuation.IsChecked == true, "persuation");
            character.Skills.UpdateSkillProficiency(Ex_Religion.IsChecked == true, "religion");
            character.Skills.UpdateSkillProficiency(Ex_Sleight_Of_Hand.IsChecked == true, "sleight of hand");
            character.Skills.UpdateSkillProficiency(Ex_Stealth.IsChecked == true, "stealth");
            character.Skills.UpdateSkillProficiency(Ex_Survival.IsChecked == true, "survival");
        }

        private void Prof_Changed(object sender, RoutedEventArgs e)
        {
            character.Skills.UpdateSkillProficiency(Prof_Acrobatics.IsChecked == true, "acrobatics");
            character.Skills.UpdateSkillProficiency(Prof_Animal_Handling.IsChecked == true, "animal handling");
            character.Skills.UpdateSkillProficiency(Prof_Arcana.IsChecked == true, "arcana");
            character.Skills.UpdateSkillProficiency(Prof_Athletics.IsChecked == true, "athletics");
            character.Skills.UpdateSkillProficiency(Prof_Deception.IsChecked == true, "deception");
            character.Skills.UpdateSkillProficiency(Prof_History.IsChecked == true, "history");
            character.Skills.UpdateSkillProficiency(Prof_Insight.IsChecked == true, "insight");
            character.Skills.UpdateSkillProficiency(Prof_Intimidation.IsChecked == true, "intimidation");
            character.Skills.UpdateSkillProficiency(Prof_Investigation.IsChecked == true, "investigation");
            character.Skills.UpdateSkillProficiency(Prof_Medicine.IsChecked == true, "medicine");
            character.Skills.UpdateSkillProficiency(Prof_Nature.IsChecked == true, "nature");
            character.Skills.UpdateSkillProficiency(Prof_Perception.IsChecked == true, "perception");
            character.Skills.UpdateSkillProficiency(Prof_Performance.IsChecked == true, "performance");
            character.Skills.UpdateSkillProficiency(Prof_Persuation.IsChecked == true, "persuation");
            character.Skills.UpdateSkillProficiency(Prof_Religion.IsChecked == true, "religion");
            character.Skills.UpdateSkillProficiency(Prof_Sleight_Of_Hand.IsChecked == true, "sleight of hand");
            character.Skills.UpdateSkillProficiency(Prof_Stealth.IsChecked == true, "stealth");
            character.Skills.UpdateSkillProficiency(Prof_Survival.IsChecked == true, "survival");
        }

        #endregion

        
    }
}