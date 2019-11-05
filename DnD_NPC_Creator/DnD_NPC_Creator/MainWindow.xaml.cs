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
        public string lol;
        private void ComboBoxRace_Loaded(object sender, RoutedEventArgs e)
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
            // todo: geselecteerde dada in nieuw tabalad zien 


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
    }
}
