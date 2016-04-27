using System;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace XFPresentation
{
    public class VisibilityViewModel : INotifyPropertyChanged
    {
        public ICommand ChangeVisibility
        {
            get
            {
                return new Command(() => 
                    {
                        _labelVisible = !_labelVisible;
                        LabelTitle = _labelVisible ? "Label Visible" : string.Empty;
                    });
            }
        }

        string _labelTitle = string.Empty;
        public string LabelTitle
        {
            get
            {
                return _labelTitle;
            }
            set
            {
                _labelTitle = value;
                OnPropertyChanged("LabelTitle");
            }
        }
        bool _labelVisible = false;
       

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

