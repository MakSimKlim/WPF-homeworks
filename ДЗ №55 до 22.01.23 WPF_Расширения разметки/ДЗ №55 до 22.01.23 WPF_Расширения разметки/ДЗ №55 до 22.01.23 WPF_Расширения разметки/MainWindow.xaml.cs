using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace ДЗ__55_до_22._01._23_WPF_Расширения_разметки
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            UpdateUI();
            LanguageChangedNotifier.LanguageChanged += UpdateTabItemBackgrounds;
        }

        private void UpdateTabItemBackgrounds()
        {
            Main.Background = new LanguageBrushExtension().ProvideValue(null) as Brush;
            News.Background = new LanguageBrushExtension().ProvideValue(null) as Brush;
            Services.Background = new LanguageBrushExtension().ProvideValue(null) as Brush;
            Contacts.Background = new LanguageBrushExtension().ProvideValue(null) as Brush;
            Language.Background = new LanguageBrushExtension().ProvideValue(null) as Brush;
        }

        private void UpdateUI()
        {
            this.Title = ItemsMenu.MainTitle;
            Main.Header = ItemsMenu.Main;
            MainText.Text = ItemsMenu.MainText;
            News.Header = ItemsMenu.News;
            NewsItem1.Text = ItemsMenu.NewsItem1;
            NewsItem2.Text = ItemsMenu.NewsItem2;
            Services.Header = ItemsMenu.Services;
            ServicesText.Text = ItemsMenu.ServicesText;
            Contacts.Header = ItemsMenu.Contacts;
            ContactsText.Text = ItemsMenu.ContactsText;
            Language.Header = ItemsMenu.Language;
            Russian.Header = ItemsMenu.Russian;
            English.Header = ItemsMenu.English;
            French.Header = ItemsMenu.French;
            Spanish.Header = ItemsMenu.Spanish;
            Indonesian.Header = ItemsMenu.Indonesian;



        }

        private void SwitchRu_Click(object sender, RoutedEventArgs e)
        {
            SwitchLanguage("ru");//русский 
        }

        private void SwitchEn_Click(object sender, RoutedEventArgs e)
        {
            SwitchLanguage("en");//английский
        }
        private void SwitchFr_Click(object sender, RoutedEventArgs e)
        {
            SwitchLanguage("fr");//французский
        }
        private void SwitchEs_Click(object sender, RoutedEventArgs e)
        {
            SwitchLanguage("es");//испанский
        }
        private void SwitchId_Click(object sender, RoutedEventArgs e)
        {
            SwitchLanguage("id");//индонезийский
        }

        public static class LanguageChangedNotifier
        {
            public static event Action LanguageChanged;

            public static void OnLanguageChanged()
            {
                LanguageChanged?.Invoke();
            }
        }

        private void SwitchLanguage(string language)
        {
            CultureInfo culture = new CultureInfo(language);
            Thread.CurrentThread.CurrentCulture = culture;
            Thread.CurrentThread.CurrentUICulture = culture;


            UpdateUI();
            UpdateMenuItemsFontWeight(language);
            LanguageChangedNotifier.OnLanguageChanged(); // Уведомление об изменении языка

        }
        private void UpdateMenuItemsFontWeight(string selectedLanguage)
        {
            Russian.FontWeight = selectedLanguage == "ru" ? FontWeights.Bold : FontWeights.Normal;
            English.FontWeight = selectedLanguage == "en" ? FontWeights.Bold : FontWeights.Normal;
            French.FontWeight = selectedLanguage == "fr" ? FontWeights.Bold : FontWeights.Normal;
            Spanish.FontWeight = selectedLanguage == "es" ? FontWeights.Bold : FontWeights.Normal;
            Indonesian.FontWeight = selectedLanguage == "id" ? FontWeights.Bold : FontWeights.Normal;
        }
    }
}
