using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace NetStandard2.ViewModels
{
    public class HomeViewModel : INotifyPropertyChanged
    {
        string name;
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
                RaisePropertyChanged();
            }
        }

        List<string> persons;
        public List<string> Persons
        {
            get
            {
                return persons;
            }

            set
            {
                persons = value;
                RaisePropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void RaisePropertyChanged([CallerMemberName] string propertyName = "") =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
