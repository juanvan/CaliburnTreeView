using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Data;

namespace CaliburnTreeView.Converters
{
    public class CompositeCollectionConverter : IMultiValueConverter
    {

        public object Convert(object[] values
            , Type targetType
            , object parameter
            , System.Globalization.CultureInfo culture)
        {
            var res = new CompositeCollection();
            foreach (var item in values)
                if (item is IEnumerable<object> && item != null)
                    res.Add(new CollectionContainer()
                    {
                        Collection = item as IEnumerable<object>
                    });
            return res;
        }

        public object[] ConvertBack(object value
            , Type[] targetTypes
            , object parameter
            , System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
