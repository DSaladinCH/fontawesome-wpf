using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace DSaladin.FontAwesome.WPF
{
    public static class Content
    {
        /// <summary>
        /// FontAwesome FontFamily.
        /// </summary>
        public static readonly FontFamily FontAwesomeSolid = new FontFamily(new Uri("pack://application:,,,/DSaladin.FontAwesome.WPF;component/"), "./#Font Awesome 5 Free Solid");
        public static readonly FontFamily FontAwesomeRegular = new FontFamily(new Uri("pack://application:,,,/DSaladin.FontAwesome.WPF;component/"), "./#Font Awesome 5 Free Regular");
        public static readonly FontFamily FontAwesomeBrand = new FontFamily(new Uri("pack://application:,,,/DSaladin.FontAwesome.WPF;component/"), "./#Font Awesome 5 Brands Regular");

        #region Icon
        /// <summary>
        /// Identifies the FontAwesome.WPF.Awesome.Content attached dependency property.
        /// </summary>
        public static readonly DependencyProperty IconProperty =
            DependencyProperty.RegisterAttached(
                "Icon",
                typeof(FontAwesomeIcon),
                typeof(ContentControl),
                new PropertyMetadata(FontAwesomeIcon.None, IconChanged));

        /// <summary>
        /// Gets the content of a ContentControl, expressed as a FontAwesome icon.
        /// </summary>
        /// <param name="target">The ContentControl subject of the query</param>
        /// <returns>FontAwesome icon found as content</returns>
        public static FontAwesomeIcon GetIcon(DependencyObject target)
        {
            return (FontAwesomeIcon)target.GetValue(IconProperty);
        }

        /// <summary>
        /// Sets the content of a ContentControl expressed as a FontAwesome icon. This will cause the content to be redrawn.
        /// </summary>
        /// <param name="target">The ContentControl where to set the content</param>
        /// <param name="value">FontAwesome icon to set as content</param>
        public static void SetIcon(DependencyObject target, FontAwesomeIcon value)
        {
            target.SetValue(IconProperty, value);
        }
        #endregion

        #region IconRotation
        public static readonly DependencyProperty IconRotationProperty =
            DependencyProperty.RegisterAttached(
                "IconRotation",
                typeof(double),
                typeof(ContentControl),
                new PropertyMetadata(default(double), RotationChanged));

        public static double GetIconRotation(DependencyObject target)
        {
            return (double)target.GetValue(IconRotationProperty);
        }

        public static void SetIconRotation(DependencyObject target, double value)
        {
            target.SetValue(IconRotationProperty, value);
        }
        #endregion

        private static void IconChanged(DependencyObject sender, DependencyPropertyChangedEventArgs evt)
        {
            if (!(sender is ContentControl)) return;

            ContentControl target = (ContentControl)sender;

            if (!(evt.NewValue is FontAwesomeIcon)) return;

            FontAwesomeIcon symbolIcon = (FontAwesomeIcon)evt.NewValue;
            int symbolCode = (int)symbolIcon;
            char symbolChar = symbolIcon.GetUnicode();

            string iconID = symbolIcon.GetIconID();
            if (iconID.StartsWith("far"))
                target.FontFamily = FontAwesomeRegular;
            else if (iconID.StartsWith("fab"))
                target.FontFamily = FontAwesomeBrand;
            else
                target.FontFamily = FontAwesomeSolid;

            target.Content = symbolChar;
        }

        private static void RotationChanged(DependencyObject sender, DependencyPropertyChangedEventArgs evt)
        {
            if (!(sender is ContentControl)) return;

            ContentControl target = (ContentControl)sender;

            if (!double.TryParse(evt.NewValue.ToString(), out double value)) return;
            target.SetRotation(value);
        }
    }
}
