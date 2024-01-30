using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Windows;
using System.Windows.Markup;
using System.Windows.Media;
using System.Threading;

namespace ДЗ__55_до_22._01._23_WPF_Расширения_разметки
{
    public class LanguageBrushExtension : MarkupExtension
    {
        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            string currentCulture = Thread.CurrentThread.CurrentCulture.ToString();
            LinearGradientBrush brush = new LinearGradientBrush();
            RadialGradientBrush brushRadial = new RadialGradientBrush();

            switch (currentCulture)
            {
                case "en": // English
                    RadialGradientBrush radialBrush = new RadialGradientBrush();
                    radialBrush.GradientStops.Add(new GradientStop(Colors.Red, 0.0));
                    radialBrush.GradientStops.Add(new GradientStop(Colors.White, 0.5));
                    radialBrush.GradientStops.Add(new GradientStop(Colors.Blue, 1.0));
                    return radialBrush;
                case "fr": // French
                    brush.GradientStops.Add(new GradientStop(Colors.Blue, 0.0));
                    brush.GradientStops.Add(new GradientStop(Colors.White, 0.5));
                    brush.GradientStops.Add(new GradientStop(Colors.Red, 1.0));
                    break;
                case "es": // Spanish
                    brush.StartPoint = new Point(0, 0);
                    brush.EndPoint = new Point(0, 1);
                    brush.GradientStops.Add(new GradientStop(Colors.Red, 0.0));
                    brush.GradientStops.Add(new GradientStop(Colors.Yellow, 0.5));
                    brush.GradientStops.Add(new GradientStop(Colors.Red, 1.0));
                    break;
                case "id": // Indonesian
                    brush.StartPoint = new Point(0, 0);
                    brush.EndPoint = new Point(0, 1);
                    brush.GradientStops.Add(new GradientStop(Colors.White, 0.0));
                    brush.GradientStops.Add(new GradientStop(Colors.Red, 1.0));
                    break;
                default: // Russian 
                    brush.StartPoint = new Point(0, 0);
                    brush.EndPoint = new Point(0, 1);
                    brush.GradientStops.Add(new GradientStop(Colors.White, 0.0));
                    brush.GradientStops.Add(new GradientStop(Colors.Blue, 0.5));
                    brush.GradientStops.Add(new GradientStop(Colors.Red, 1.0));
                    break;
            }

            return brush;
        }
    }
}