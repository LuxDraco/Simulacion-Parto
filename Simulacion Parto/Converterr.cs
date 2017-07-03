using Syncfusion.UI.Xaml.Charts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;

namespace Simulacion_Parto
{
    public class ColumnPointsConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            var ydata = (value as ColumnSegment).XData;
            Point point = new Point();
            if (ydata == 0.0)
            {
                point.X = 0;
                point.Y = 0;
            }
            else if (ydata == 1.0)
            {
                point.X = 0;
                point.Y = 0.4;
            }
            else if (ydata == 3.0)
            {
                point.X = 0;
                point.Y = 0.4;
            }
            else if (ydata == 2.0)
            {
                point.X = 0;
                point.Y = 0.2;
            }
            else if (ydata == 4.0)
            {
                point.X = 0;
                point.Y = 0.1;
            }

            return point;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    public class ColumnPointsConverter1 : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            var ydata = (value as ColumnSegment).XData;
            Point point = new Point();
            if (ydata == 0.0)
            {
                point.X = 0;
                point.Y = 0.25;
            }
            else if (ydata == 1.0)
            {
                point.X = 0;
                point.Y = 0.1;
            }
            else if (ydata == 3.0)
            {
                point.X = 0;
                point.Y = 0.25;
            }
            else if (ydata == 2.0)
            {
                point.X = 0;
                point.Y = 0;
            }
            else if (ydata == 4.0)
            {
                point.X = 0;
                point.Y = 0.2;
            }

            return point;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    public class ColumnPointsConverter2 : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            var ydata = (value as ColumnSegment).XData;
            Point point = new Point();
            if (ydata == 0.0)
            {
                point.X = 0;
                point.Y = 0.25;
            }
            else if (ydata == 1.0)
            {
                point.X = 0;
                point.Y = 0.1;
            }
            else if (ydata == 3.0)
            {
                point.X = 0;
                point.Y = 0.25;
            }
            else if (ydata == 2.0)
            {
                point.X = 0;
                point.Y = 0;
            }
            else if (ydata == 4.0)
            {
                point.X = 0;
                point.Y = 0.2;
            }

            return point;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    public class SplineValueConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            var ydata = (value as SplineSegment).YData;
            Brush interior;

            interior = ydata > 0 ?
                new SolidColorBrush(Color.FromArgb(0xFF, 0xFF, 0xC1, 0x07)) :
                new SolidColorBrush(Color.FromArgb(0xFF, 0xD1, 0xD3, 0xD4));

            return interior;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }


    //***************************************************

    public class Labelconvertor : IValueConverter
    {

        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return String.Format("{0} %", value);
        }
        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return value;
        }
    }

    public class LegendConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return value;
        }
    }
}
