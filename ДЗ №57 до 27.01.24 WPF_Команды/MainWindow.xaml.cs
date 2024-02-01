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

namespace ДЗ__57_до_27._01._24_WPF_Команды
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //реализация команды Delete
            CommandBinding deleteCommandBinding = new CommandBinding(
            ApplicationCommands.Delete,
            ExecuteDeleteCommand,
            CanExecuteDeleteCommand);
            this.CommandBindings.Add(deleteCommandBinding);

            //реализация добавления даты и времени в конец


        }
        //реализация добавления даты и времени в конец
        private void AddDateTime_Click(object sender, RoutedEventArgs e)
        {
            textBox.AppendText($"{Environment.NewLine}{DateTime.Now}");
        }
        // реализация меню выхода
        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
        //реализация команды Delete
        private void CanExecuteDeleteCommand(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = textBox != null && textBox.SelectedText.Length > 0;
        }

        private void ExecuteDeleteCommand(object sender, ExecutedRoutedEventArgs e)
        {
            textBox.Text = textBox.Text.Remove(textBox.SelectionStart, textBox.SelectionLength);
            e.Handled = true;
        }

        // для команд Copy, Cut, Redo, Undo и Paste уже опредлены встроенные привязки.
        // Поэтому в данном случае нам не надо вносить в файл кода C# никаких изменений.
    }
}
