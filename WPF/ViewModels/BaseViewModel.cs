using System.ComponentModel;
using System.Diagnostics;

namespace WPF.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
    
        protected void CallPropertyChanged()
        {
            StackFrame caller = new StackFrame(1);
            string[] methodNames = caller.GetMethod().Name.Split("_");
            int i= methodNames.Length - 1;
            string propertyName = methodNames[i];

            CallPropertyChanged(propertyName);
        }
        protected void CallPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
