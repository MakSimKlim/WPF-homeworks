using System;
using System.Collections.Generic;
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

namespace ДЗ__54_до_20._01._24_WPF_Локализация_файлы_ресур_языки_
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
        }
        private void UpdateUI()
        {
            Main.Header = ItemsMenu.Main;
            MainText.Text = ItemsMenu.MainText;
            News.Header = ItemsMenu.News;
            Services.Header = ItemsMenu.Services;
            ServicesText.Text = ItemsMenu.ServicesText;
            Contacts.Header = ItemsMenu.Contacts;
            Language.Header = ItemsMenu.Language;
            Russian.Header = ItemsMenu.Russian;
            English.Header = ItemsMenu.English;

        }

        private void SwitchRu_Click(object sender, RoutedEventArgs e)
        {
            SwitchLanguage("ru");
        }

        private void SwitchEn_Click(object sender, RoutedEventArgs e)
        {
            SwitchLanguage("en");
        }
        private void SwitchLanguage(string language)
        {
            CultureInfo culture = new CultureInfo(language);
            Thread.CurrentThread.CurrentCulture = culture;
            Thread.CurrentThread.CurrentUICulture = culture;

            UpdateUI();

        }
    }
}
