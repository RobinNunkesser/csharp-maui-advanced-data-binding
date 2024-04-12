using System.Globalization;

namespace AdvancedDataBinding;

public class IntToColorConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter,
        CultureInfo culture)
    {
        var minimumLength = System.Convert.ToInt32(parameter);
        return (int)value >= minimumLength ? Colors.Green : Colors.Red;
    }

    public object ConvertBack(object value, Type targetType, object parameter,
        CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}