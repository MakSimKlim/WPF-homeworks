using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

namespace ДЗ__48_до_29._12._23_WPF_Кисти_и_элементы_окна
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private LinearGradientBrush originalLinearGradient = new LinearGradientBrush(
               Colors.Yellow, Colors.Red, new Point(0, 0), new Point(1, 0));

        private RadialGradientBrush radialGradient = new RadialGradientBrush(
                Colors.Yellow, Colors.Red);

        // для первой кнопки
        private void Button_Loaded(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;

            // Применение оригинального линейного градиента к фону кнопки
            button.Background = originalLinearGradient;

        }

        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {
            Button button = sender as Button;

            // Применение радиального градиента при входе мыши
            button.Background = radialGradient;

        }

        private void Button_MouseLeave(object sender, MouseEventArgs e)
        {
            Button button = sender as Button;

            // Восстановление линейного градиента при убирании мыши
            button.Background = originalLinearGradient;
        }

    }
}
