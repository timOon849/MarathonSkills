﻿using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media.Imaging;

namespace MarathonSkills.Pages
{
	public class ImagePathConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			if (value is string fileName && !string.IsNullOrEmpty(fileName))
			{
				// Добавляем фиксированную часть пути
				string fullPath = $"/Materials/{fileName}";
				return new BitmapImage(new Uri(fullPath, UriKind.Relative));
			}
			return null; // Если значение пустое, возвращаем null
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}
	}
}