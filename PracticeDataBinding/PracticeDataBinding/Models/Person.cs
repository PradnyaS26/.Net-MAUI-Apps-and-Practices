using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace PracticeDataBinding.Models
{
    public class Person : INotifyPropertyChanged
    {
        private string name;

        public string Name { get => name; set
            {
                name = value;
                OnPropertyChanged();
            } }
        public string Phone { get; set; }
        public string Address { get; set; }

        public Person()
        {
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propname = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propname));
        }
    }
}

