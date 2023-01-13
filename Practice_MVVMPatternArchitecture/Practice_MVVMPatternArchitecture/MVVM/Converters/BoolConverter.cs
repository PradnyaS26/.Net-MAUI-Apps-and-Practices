using System;
using System.Globalization;

namespace Practice_MVVMPatternArchitecture.MVVM.Converters
{
	public class BoolConverter:IValueConverter
	{
		public BoolConverter()
		{
		}

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var answer = value.ToString();
            if (answer == "YES")
            {
                return true;
            }
            return false;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
           
            if ((bool)value)
            {
                return "YES";
            }
            return "NO";
        }
    }
}

