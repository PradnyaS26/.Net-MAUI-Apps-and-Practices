using System;
using System.Globalization;

namespace TaskerApp.Converters
{
	public class ColorConverter:IValueConverter
	{
		public ColorConverter()
		{
		}

        object IValueConverter.Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var color = value.ToString();
            return Color.FromArgb(color);
        }

        object IValueConverter.ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}

