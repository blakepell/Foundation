﻿using Digimezzo.Foundation.WPF.Extensions;
using System;
using System.Globalization;
using System.Windows.Data;

namespace Digimezzo.Foundation.WPF.Converters
{
    public class AddValueConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {

            if (value == null || parameter == null || !parameter.ToString().IsNumeric())
            {
                return Binding.DoNothing;
            }

            return double.Parse(value.ToString()) + double.Parse(parameter.ToString());
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return Binding.DoNothing;
        }
    }
}
