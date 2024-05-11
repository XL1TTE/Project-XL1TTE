using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Project_XLT.Convertors
{
    public class DateTimeToStringConvertor : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string StringTimeFormat = ((DateTime)value).ToString("dd MMMM yyyy");
            return StringTimeFormat;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            DateTime DateTimeFormat = DateTime.ParseExact(value.ToString(), "dd MMMM yyyy", CultureInfo.InvariantCulture);
            return DateTimeFormat;
        }
    }
}
