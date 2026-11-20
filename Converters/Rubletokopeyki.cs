using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace prakt7_trifonov_trpo.Converters
{
    public class Rubletokopeyki : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is decimal rubles)
            {
                return Math.Round(rubles * 100);
            }

            return 0;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null && decimal.TryParse(value.ToString(), out decimal kopecks))
            {
                return kopecks / 100m;
            }
            return 0m;
        }
    }
}
