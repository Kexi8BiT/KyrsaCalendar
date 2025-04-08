using System;
using System.Windows.Data;
using System.Diagnostics;
using System.Collections.Generic;

namespace Kursovaya
{
    public class DateInCollectionConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (values == null || values.Length != 2)
            {
                Debug.WriteLine("Values is null or length != 2");
                return false;
            }
            var date = values[0] as DateTime?;
            var collection = values[1] as HashSet<DateTime>;
            Debug.WriteLine($"Date: {date}, Collection: {(collection != null ? collection.Count : -1)}");
            if (date == null || collection == null)
            {
                Debug.WriteLine("Date or Collection is null");
                return false;
            }
            bool result = collection.Contains(date.Value);
            Debug.WriteLine($"Result: {result}");
            return result;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotSupportedException();
        }
    }
}