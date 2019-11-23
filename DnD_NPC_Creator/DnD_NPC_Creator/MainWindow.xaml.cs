using Business_Layer.Manager;
using System;
using System.Collections.Generic;
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
        public MainWindow()
        {
            applicationManager = new ApplicationManager();
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
            objsecondwindow.ConSecond.Content = Convert.ToString(Constitutiorbox.Text + ConstitutionLabel.Content);
            objsecondwindow.Intsecond.Content = Convert.ToString(Intelligencebox.Text + IntelligenceLabel.Content);
            objsecondwindow.WisSecond.Content = Convert.ToString(Wisdombox.Text + WisdomLabel.Content);
            objsecondwindow.ChaSecond.Content = Convert.ToString(Charismabox.Text + CharismaLabel.Content);
            objsecondwindow.FeatureNameSecond.Content = Convert.ToString(FeatureName.Text);

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
            FeatureName.Text = " ";

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
        private void SpecificationComo_Loaded(object sender, RoutedEventArgs e) //In Progress
        {

        }
        private void SubRaceCombo_Loaded(object sender, RoutedEventArgs e) //Empty
        {

        }
        #endregion

        #region Combobox Selection Changed
        private void SublassCombo_SelectionChanged(object sender, SelectionChangedEventArgs e) //Empty
        {

        }
        private void FeatureName_SelectionChanged(object sender, SelectionChangedEventArgs e) //Empty
        {
            string[] SpecCriminal = new string[] { "Blackmailer", "Burglar", "Enforcer", "Fence", "Highway robber", "Hired killer", "Pickpocket", "Smuggler", };
            string[] SpecEntertainer = new string[] { "Actor", "Dancer", "Fire-eater", "Jester", "Juggler", "Instrumentalist", "Poet", "Singer", "Storyteller", "Tumbler" };
            string[] SpecFarTraveler = new string[] { "Emissary", "Exile", "Fugitive", "Pilgrim", "Sightseer", "Wanderer" };
            string[] SpecGuildArtisan = new string[] {"Alchemists and apothecaries", "Armorers, locksmiths, and finesmiths", "Brewers, distillers, and vintners", "Calligraphers, scribes, and scriveners", "Carpenters, roofers, and plasterers", "Cartographers, surveyors, and chart-makers", "Cobblers and shoemakers", "Cooks and bakers", "Glassblowers and glaziers", "Jewelers and gemcutters", "Leatherworkers, skinners, and tanners", "Masons and stonecutters", "Painters, limners, and sign-makers", "Potters and tile-makers", "Shipwrights and sailmakers", "Smiths and metal-forgers", "Tinkers, pewterers, and casters", "Wagon-makers and wheelwrights", "Weavers and dyers", "Woodcarvers, coopers, and bowyers" };
            string[] SpecOutlander = new string[] { "Forester", "Trapper", "Homesteader", "Guide", "Exile or outcast", "Bounty hunter", "Pilgrim", "Tribal nomad", "Hunter-gatherer", "Tribal marauder" };
            string[] SpecSage = new string[] { "Alchemist", "Astronomer", "Discredited academic", "Librarian", "Professor", "Researcher", "Wizard's apprentice", "Scribe" };
            string[] SpecSoldier = new string[] { "Officer", "Scout", "Infantry", "Cavalry", "Healer", "Quartermaster", "Standard bearer", "Support staff (cook, blacksmith, or the like)" };

            SpecificationComo.Items.Clear();
            switch (Convert.ToString(FeatureName.SelectedItem))
            {
                case "Criminal":
                    foreach (string criminal in SpecCriminal)
                    {
                        SpecificationComo.Items.Add(criminal);
                    }
                    break;
                case "Entertainer":
                    foreach (string entertainer in SpecEntertainer)
                    {
                        SpecificationComo.Items.Add(entertainer);
                    }
                    break;
                case "Far Traveler":
                    foreach (string farTraveler in SpecFarTraveler)
                    {
                        SpecificationComo.Items.Add(farTraveler);
                    }
                    break;
                case "Guild Artisan":
                    foreach (string guildArtisan in SpecGuildArtisan)
                    {
                        SpecificationComo.Items.Add(guildArtisan);
                    }
                    break;
                case "Outlander":
                    foreach (string outlander in SpecOutlander)
                    {
                        SpecificationComo.Items.Add(outlander);
                    }
                    break;
                case "Sage":
                    foreach (string sage in SpecSage)
                    {
                        SpecificationComo.Items.Add(sage);
                    }
                    break;
                case "Soldier":
                    foreach (string soldier in SpecSoldier)
                    {
                        SpecificationComo.Items.Add(soldier);
                    }
                    break;
                default:
                    break;
            }
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

        }
        #endregion

        #region Button Click
        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            //on click save character
        }
        #endregion

        #region Keydown classes
        private void Strength_KeyDown(object sender, KeyEventArgs e)
        {
            int getal;

            if (e.Key == Key.Enter)
            {

                getal = int.Parse(StrengthBox.Text);
                //schrijf hier berkening voor +points
                StrengthLabel.Content = "+" + getal;
            }
        }

        private void Dexterity_KeyDown(object sender, KeyEventArgs e)
        {
            int getal;

            if (e.Key == Key.Enter)
            {
                getal = int.Parse(Dexteritybox.Text);
                DexterityLabel.Content = "+" + getal;


            }
        }

        private void Constitution_KeyDown(object sender, KeyEventArgs e)
        {
            int getal;

            if (e.Key == Key.Enter)
            {
                getal = int.Parse(Constitutiorbox.Text);
                ConstitutionLabel.Content = "+" + getal;


            }
        }

        private void Intelligence_KeyDown(object sender, KeyEventArgs e)
        {
            int getal;

            if (e.Key == Key.Enter)
            {
                getal = int.Parse(Intelligencebox.Text);
                IntelligenceLabel.Content = "+" + getal;


            }
        }

        private void Wisdom_KeyDown(object sender, KeyEventArgs e)
        {
            int getal;

            if (e.Key == Key.Enter)
            {
                getal = int.Parse(Wisdombox.Text);
                WisdomLabel.Content = "+" + getal;


            }

        }

        private void Charisma_KeyDown(object sender, KeyEventArgs e)
        {
            int getal;

            if (e.Key == Key.Enter)
            {
                getal = int.Parse(Charismabox.Text);
                CharismaLabel.Content = "+" + getal;


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

        private void Constitutiorbox_previewTextBox(object sender, TextCompositionEventArgs e)
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
        #endregion

    }
}