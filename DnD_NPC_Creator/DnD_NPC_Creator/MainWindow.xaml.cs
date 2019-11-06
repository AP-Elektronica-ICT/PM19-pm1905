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
        
        public MainWindow()
        {
            InitializeComponent();
            
        }

       
        
        private void ComboBoxRace_Loaded(object sender, RoutedEventArgs e )
        {
            

            List<string> races = new List<string>();
            races.Add(" ");
            races.Add("Dwarf");
            races.Add("Elf");
            races.Add("Halfling");
            races.Add("Human");
            races.Add("Dragonborn");
            races.Add("Gnome");
            races.Add("Half-Elf");
            races.Add("Half-Orc");
            races.Add("Tiefling");

            

            var race = sender as ComboBox;
            race.ItemsSource = races;
            race.SelectedIndex = 0;
            
        }
        
        private void ComboBoxClass_Loaded(object sender, RoutedEventArgs e)
        {

            List<string> Classes = new List<string>();
            Classes.Add(" ");
            Classes.Add("Barbarian");
            Classes.Add("Cleric");
            Classes.Add("Druid");
            Classes.Add("Fighter");
            Classes.Add("Hunter");
            Classes.Add("Monk");
            Classes.Add("Paladin");
            Classes.Add("Sorcorer");
            Classes.Add("Warlock");
            Classes.Add("Wizard");

            var Class = sender as ComboBox;
            Class.ItemsSource = Classes;
            Class.SelectedIndex = 0;
            
        }
        private void Class_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string[] SubBarb = new string[] {"item1", "item1", "item1", "item1", "item1"};
            string[] SubCleric = new string[] { "item2", "item2", "item2", "item2", "item2" };
            string[] SubDruid = new string[] { "item3", "item3", "item3", "item3", "item3" };
            string[] SubFighter = new string[] { "item4", "item4", "item4", "item4", "item4" };
            string[] SubHunter = new string[] { "item5", "item5", "item5", "item5", "item5" };
            string[] SubMonk = new string[] { "item6", "item6", "item6", "item6", "item6" };
            string[] SubPaladin = new string[] { "item7", "item7", "item7", "item7", "item7" };
            string[] SubSorcorer = new string[] { "item8", "item8", "item8", "item8", "item8" };
            string[] SubWarlock = new string[] { "item9", "item9", "item9", "item9", "item9" };
            string[] SubWizard = new string[] { "item10", "item10", "item10", "item10", "item10" };

            
            SublassCombo.Items.Clear();
            switch (Convert.ToString(ComboClass.SelectedItem))
            {
                case "Barbarian":

                    for (int i = 0; i < SubBarb.Length; i++)
                    {
                        SublassCombo.Items.Add(SubBarb[i]);
                    }
                   
                    break;

                case "Cleric":
                    for (int i = 0; i < SubCleric.Length; i++)
                    {
                        SublassCombo.Items.Add(SubCleric[i]);
                    }
                    break;

                case "Druid":
                    for (int i = 0; i < SubDruid.Length; i++)
                    {
                        SublassCombo.Items.Add(SubDruid[i]);
                    }
                    break;

                case "Fighter":
                    for (int i = 0; i < SubFighter.Length; i++)
                    {
                        SublassCombo.Items.Add(SubFighter[i]);
                    }
                    break;

                case "Hunter":
                    for (int i = 0; i < SubHunter.Length; i++)
                    {
                        SublassCombo.Items.Add(SubHunter[i]);
                    }
                    break;
                case "Monk":
                    for (int i = 0; i < SubMonk.Length; i++)
                    {
                        SublassCombo.Items.Add(SubMonk[i]);
                    }
                    break;
                case "Paladin":
                    for (int i = 0; i < SubPaladin.Length; i++)
                    {
                        SublassCombo.Items.Add(SubPaladin[i]);
                    }
                    break;
                case "Sorcorer":
                    for (int i = 0; i < SubSorcorer.Length; i++)
                    {
                        SublassCombo.Items.Add(SubSorcorer[i]);
                    }
                    break;
                case "Warlock":
                    for (int i = 0; i < SubWarlock.Length; i++)
                    {
                        SublassCombo.Items.Add(SubWarlock[i]);
                    }
                    break;
                case "Wizard":
                    for (int i = 0; i < SubWizard.Length; i++)
                    {
                        SublassCombo.Items.Add(SubWizard[i]);
                    }
                    break;

                default:
                    break;
            }

        }

        private void ComboBoxSubClass_Loaded(object sender, RoutedEventArgs e)
        {

           
            
        }
        private void ComboBoxBackground_Loaded(object sender, RoutedEventArgs e)
        {
            List<string> Backgrounds = new List<string>();
            Backgrounds.Add(" ");
            Backgrounds.Add("Adept linguist");
            Backgrounds.Add("All eyes on You");
            Backgrounds.Add("Are you entertained?");
            Backgrounds.Add("At home in the wild");
            Backgrounds.Add("Bad reputation");
            Backgrounds.Add("Black-Market Breeder");
            Backgrounds.Add("By popular demand");
            Backgrounds.Add("City secrets");
            Backgrounds.Add("Court Functionary");
            Backgrounds.Add("Criminal contact");
            Backgrounds.Add("Cult of the dragon infiltrator");
            Backgrounds.Add("Deep delver");
            Backgrounds.Add("Deep miner");
            Backgrounds.Add("Discovery");
            Backgrounds.Add("Double agent");
            Backgrounds.Add("Dragon scholar");
            Backgrounds.Add("Dragonscarred");
            Backgrounds.Add("Ear to the ground");
            Backgrounds.Add("Ex-convict");
            Backgrounds.Add("Factor");
            Backgrounds.Add("False identity");
            Backgrounds.Add("Guerilla");
            Backgrounds.Add("Guild Membership");
            Backgrounds.Add("Harborfolk");
            Backgrounds.Add("Heart of the darkness");
            Backgrounds.Add("Highborn");
            Backgrounds.Add("Historical knowledge");
            Backgrounds.Add("Inheritance");
            Backgrounds.Add("Investigative Services");
            Backgrounds.Add("Kept in style");
            Backgrounds.Add("Knightly regard");
            Backgrounds.Add("Library Access");
            Backgrounds.Add("Mercenary life");
            Backgrounds.Add("Military rank");
            Backgrounds.Add("Phlan survivor");
            Backgrounds.Add("Position of privilege");
            Backgrounds.Add("Red plume and mage guild Contacts");
            Backgrounds.Add("Researcher");
            Backgrounds.Add("Respect of the stout folk");
            Backgrounds.Add("Retainers");
            Backgrounds.Add("Rustic hospitality");
            Backgrounds.Add("Safe haven");
            Backgrounds.Add("Secret identity");
            Backgrounds.Add("Secret passage");
            Backgrounds.Add("Secret society");
            Backgrounds.Add("Shelter of the Elven Clergy");
            Backgrounds.Add("Shelter of faithfull");
            Backgrounds.Add("Ship's passage");
            Backgrounds.Add("Trade contact");
            Backgrounds.Add("Underdark experience");
            Backgrounds.Add("Uthgardt Heritage");
            Backgrounds.Add("Wagonmaster");
            Backgrounds.Add("Wanderer");
            Backgrounds.Add("Watcher's eye");
           
            var Background = sender as ComboBox;
            Background.ItemsSource = Backgrounds;
            Background.SelectedIndex = 0;
        }

        

        private void OpenWidow(object sender, RoutedEventArgs e)
        {
            // todo: Data in 2de window laten zien

           //example, nog af te maken
            SecondWindow1 next  = new SecondWindow1();
            
            next.raceResult.Text = "lol";
            // openen van nieuw tablad
            
            SecondWindow1 objsecondwindow = new SecondWindow1();
            this.Visibility = Visibility.Hidden;
            objsecondwindow.Show();
        }

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

        private void Strength_KeyDown(object sender, KeyEventArgs e)
        {
            int getal; 

            if (e.Key == Key.Enter)
            {
                
                getal = int.Parse(StrengthBox.Text);
                //schrijf hier berkening voor +points
                StrengthLabel.Content = "+"+getal;
            }
        }

        private void Dexterity_KeyDown(object sender, KeyEventArgs e)
        {
            int getal;

            if (e.Key == Key.Enter)
            {
                getal = int.Parse(Dexteritybox.Text);
                DexterityLabel.Content = "+"+getal;

                
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

        private void ToolsCombobox_Loaded(object sender, RoutedEventArgs e)
        {
            string[] ToolItems = new string[] {"Alchemist's suplies", "Brewer's supplies", "Calligrapher's Supplies", "Carpenters's tools", "cortographer's tools", "Cobbler's tools", "Cook's utensils", "Glassblower's tools", "jeweler's tools", "leatherworker's tools", "Mason's tools", "Potter's tools", "Smith's tools", "Tinker's tools", "Weaver's tools", "Woodcarver's tools" };
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
    }
    
}
