using System;
using System.Collections.ObjectModel;
using UnitsNet;
using PropertyChanged;
using System.Windows.Input;

namespace UnitConverterApp.MVVM.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public class ConverterViewModel
    {
        public string QuantityName { get; set; }
        public ObservableCollection<string> FromMeasures { get; set; }
        public ObservableCollection<string> ToMeasures { get; set; }

        public string CurrentFromMeasure { get; set; }
        public string CurrentToMeasure { get; set; }

        public double FromValue { get; set; } = 10;
        public double ToValue { get; set; }


       

        public ConverterViewModel(string quantityName)
        {
            QuantityName = quantityName;
            FromMeasures = LoadMeasures();
            ToMeasures = LoadMeasures();
            CurrentFromMeasure = FromMeasures.FirstOrDefault();
            CurrentToMeasure = ToMeasures.FirstOrDefault();
            Convert();
        }

        public void Convert()
        {
            var result = UnitConverter.ConvertByName(FromValue, QuantityName,
                CurrentFromMeasure, CurrentToMeasure);
            ToValue = result;
        }

        public ICommand ReturnCommand =>
           new Command(() =>
           {
               Convert();
           });

        private ObservableCollection<string> LoadMeasures()
        {
            var types = Quantity.Infos
                .FirstOrDefault(x => x.Name == QuantityName)
                .UnitInfos
                .Select(u => u.Name)
                .ToList();
            return new ObservableCollection<string>(types);
        }


    }

}
