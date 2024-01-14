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

namespace ДЗ__51_до_04._01._24_WPF_Элементы__обработка_ввода_
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

        //============================================================================
        // для второй кнопки
        private void Button_Loaded2(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;

            // Применение оригинального линейного градиента к фону кнопки
            button.Background = radialGradient;

        }
        private void Button_MouseEnter2(object sender, MouseEventArgs e)
        {
            Button button = sender as Button;

            // Применение радиального градиента при входе мыши
            button.Background = originalLinearGradient;

        }

        private void Button_MouseLeave2(object sender, MouseEventArgs e)
        {
            Button button = sender as Button;

            // Восстановление линейного градиента при убирании мыши
            button.Background = radialGradient;
        }

    }
}
