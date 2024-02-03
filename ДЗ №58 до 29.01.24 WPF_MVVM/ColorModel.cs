using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Media;

namespace ДЗ__58_до_29._01._24_WPF_MVVM
{
    public abstract class ModelCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        protected virtual bool CanExecute()
        {
            return true;
        }

        public void RaiseCanExecute()
        {
            if (CanExecuteChanged != null)
                CanExecuteChanged(this, EventArgs.Empty);
        }

        protected abstract void Execute();

        bool ICommand.CanExecute(object parameter)
        {
            return CanExecute();
        }

        void ICommand.Execute(object parameter)
        {
            Execute();
        }
    }
    public class ModelListColors
    {
        public Color Color { get; set; }
        public string HexColor { get { return Color.ToString(); } }
        public ICommand DeleteColorFromColCommand { get; set; }
    }
}