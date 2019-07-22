using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Pets.Viewer
{
    public class SpeciesConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var species = value?.ToString();
            if (string.IsNullOrWhiteSpace(species))
                return new SolidColorBrush(Colors.DarkSlateBlue);

            switch (species.ToLower())
            {
                case "cat":
                    return new SolidColorBrush(Colors.Maroon);
                case "dog":
                    return new SolidColorBrush(Colors.DarkGreen);
                default:
                    return new SolidColorBrush(Colors.DarkOrange);
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    public class AgeConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var age = (int)value;
            return $"{age} year{(age == 1 ? "" : "s")} old";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    public class ImageUrlConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            try
            {
                var url = value?.ToString();
                if (Uri.TryCreate(url, UriKind.Absolute, out var imageUri))
                {
                    return new BitmapImage(imageUri);
                }
            }
            catch
            { }

            PixelFormat pf = PixelFormats.Bgr32;
            int width = 100;
            int height = 100;
            int rawStride = (width * pf.BitsPerPixel + 7) / 8;
            byte[] rawImage = new byte[rawStride * height];

            var bitmapSource = BitmapSource.Create(width, height, 96, 96, pf, null, rawImage, rawStride);
            var encoder = new JpegBitmapEncoder();
            var bImg = new BitmapImage();
            encoder.Frames.Add(BitmapFrame.Create(bitmapSource));
            using (var memoryStream = new MemoryStream())
            {
                encoder.Save(memoryStream);

                memoryStream.Position = 0;
                bImg.BeginInit();
                bImg.StreamSource = memoryStream;
                bImg.EndInit();

            }
            return bImg;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}

