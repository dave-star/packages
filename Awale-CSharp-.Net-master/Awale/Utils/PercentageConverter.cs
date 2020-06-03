﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Awale.Utils
{
    /// <summary>
    /// Source : https://stackoverflow.com/questions/717299/wpf-setting-the-width-and-height-as-a-percentage-value
    /// </summary>
    public class PercentageConverter : IValueConverter
    {
        public object Convert(object value,
        Type targetType,
        object parameter,
        System.Globalization.CultureInfo culture)
        {
            return System.Convert.ToDouble(value) *
                   System.Convert.ToDouble(parameter);
        }

        public object ConvertBack(object value,
            Type targetType,
            object parameter,
            System.Globalization.CultureInfo culture)
        {
            return System.Convert.ToDouble(value) /
                   System.Convert.ToDouble(parameter);
        }
    }
}
