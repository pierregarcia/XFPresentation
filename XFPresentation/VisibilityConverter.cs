using System;
using Xamarin.Forms;

namespace XFPresentation
{
    public class VisibilityConverter : IValueConverter
    {
        /*
         * If the value is null or 0, the control should be hidden
        */

        #region IValueConverter implementation

        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value == null)
            {
                return false;
            }

            if (value is bool)
            {
                return (bool)value;
            }

            if (value is int)
            {
                if (parameter == null)
                {
                    return (int)value > 0;
                }
                else
                {
                    return (int)value > int.Parse(parameter.ToString());
                }
            }

            if (value is double)
            {
                return (double)value > 0;
            }

            if (value is string)
            {
                return !string.IsNullOrWhiteSpace(value as string);
            }

            return true;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}

