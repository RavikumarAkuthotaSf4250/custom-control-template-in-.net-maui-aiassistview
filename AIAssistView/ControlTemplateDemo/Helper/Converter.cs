﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlTemplate
{
    public class FontAttributeConverter : IValueConverter
    {
        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            if (value is bool isActive)
            {
                if (isActive)
                {
                    return FontAttributes.Bold;
                }
                else
                {
                    return FontAttributes.None;
                }
            }
            return FontAttributes.None;
        }

        public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    public class NavigationColorConverter : IValueConverter
    {
        // The Convert method to change bool to color
        public object Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            if (value is bool isEnabled)
            {
                // Get the theme from the parameter
                var theme = Application.Current?.RequestedTheme;

                if (isEnabled)
                {
                    return theme == AppTheme.Light ? Color.FromArgb("#79747E") : Color.FromArgb("#ACACAC");
                }
                else
                {
                    return theme == AppTheme.Light ? Color.FromArgb("#CAC4D0") : Color.FromArgb("#49454F");

                }
            }

            return Colors.Transparent;
        }

        public object ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
