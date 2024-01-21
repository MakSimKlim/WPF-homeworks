using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ДЗ__53_до_08._01._24_WPF_Текст_и_документы_Википедия_
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

        private void ToggleButton_Click(object sender, RoutedEventArgs e)
        {
            ToggleButton toggleButton = sender as ToggleButton;
            if (toggleButton != null)
            {

                switch (toggleButton.Content.ToString())
                {
                    case "Жирный":
                        richTextBox.Selection.ApplyPropertyValue(TextElement.FontWeightProperty, (toggleButton.IsChecked ?? false) ? FontWeights.Bold : FontWeights.Normal);
                        break;
                    case "Курсив":
                        richTextBox.Selection.ApplyPropertyValue(TextElement.FontStyleProperty, (toggleButton.IsChecked ?? false) ? FontStyles.Italic : FontStyles.Normal);
                        break;
                    case "Подчеркнутый":
                        richTextBox.Selection.ApplyPropertyValue(Inline.TextDecorationsProperty, (toggleButton.IsChecked ?? false) ? TextDecorations.Underline : null);
                        break;

                }
            }
        }

        private void RichTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            UpdateButtonsState();
        }

        private void UpdateButtonsState()
        {
            FontWeight fontWeight = (FontWeight)richTextBox.Selection.GetPropertyValue(TextElement.FontWeightProperty);
            FontStyle fontStyle = (FontStyle)richTextBox.Selection.GetPropertyValue(TextElement.FontStyleProperty);
            TextDecorationCollection textDecorations = (TextDecorationCollection)richTextBox.Selection.GetPropertyValue(Inline.TextDecorationsProperty);
            if (stackPanel != null)
            {
                foreach (UIElement child in stackPanel.Children)
                {
                    if (child is ToggleButton toggleButton)
                    {
                        switch (toggleButton.Content.ToString())
                        {
                            case "Жирный":
                                toggleButton.IsChecked = fontWeight == FontWeights.Bold;
                                break;
                            case "Курсив":
                                toggleButton.IsChecked = fontStyle == FontStyles.Italic;
                                break;
                            case "Подчеркнутый":
                                toggleButton.IsChecked = textDecorations != null && textDecorations.Contains(TextDecorations.Underline[0]);
                                break;

                        }
                    }
                }
            }
        }

    }
}