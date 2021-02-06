using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace DSaladin.FontAwesomeWPF
{
    public static class Icon
    {
        /// <summary>
        /// FontAwesome FontFamily.
        /// </summary>
        public static readonly FontFamily FontAwesomeSolid = new FontFamily(new Uri("pack://application:,,,/FontAwesomeWPF;component/"), "./#Font Awesome 5 Free Solid");
        public static readonly FontFamily FontAwesomeRegular = new FontFamily(new Uri("pack://application:,,,/FontAwesomeWPF;component/"), "./#Font Awesome 5 Free Regular");
        public static readonly FontFamily FontAwesomeBrand = new FontFamily(new Uri("pack://application:,,,/FontAwesomeWPF;component/"), "./#Font Awesome 5 Brands Regular");

        /// <summary>
        /// Identifies the FontAwesome.WPF.Awesome.Content attached dependency property.
        /// </summary>
        public static readonly DependencyProperty ContentProperty =
            DependencyProperty.RegisterAttached(
                "Content",
                typeof(FontAwesomeIcon),
                typeof(Icon),
                new PropertyMetadata(DEFAULT_CONTENT, ContentChanged));

        /// <summary>
        /// Gets the content of a ContentControl, expressed as a FontAwesome icon.
        /// </summary>
        /// <param name="target">The ContentControl subject of the query</param>
        /// <returns>FontAwesome icon found as content</returns>
        public static FontAwesomeIcon GetContent(DependencyObject target)
        {
            return (FontAwesomeIcon)target.GetValue(ContentProperty);
        }

        /// <summary>
        /// Sets the content of a ContentControl expressed as a FontAwesome icon. This will cause the content to be redrawn.
        /// </summary>
        /// <param name="target">The ContentControl where to set the content</param>
        /// <param name="value">FontAwesome icon to set as content</param>
        public static void SetContent(DependencyObject target, FontAwesomeIcon value)
        {
            target.SetValue(ContentProperty, value);
        }

        private static void ContentChanged(DependencyObject sender, DependencyPropertyChangedEventArgs evt)
        {
            // If target is not a ContenControl just ignore: Awesome.Content property can only be set on a ContentControl element
            if (!(sender is ContentControl)) return;

            ContentControl target = (ContentControl)sender;

            // If value is not a FontAwesomeIcon just ignore: Awesome.Content property can only be set to a FontAwesomeIcon value
            if (!(evt.NewValue is FontAwesomeIcon)) return;

            FontAwesomeIcon symbolIcon = (FontAwesomeIcon)evt.NewValue;
            int symbolCode = (int)symbolIcon;
            char symbolChar = (char)symbolCode;

            string iconID = symbolIcon.GetIconID();
            if (iconID.StartsWith("far"))
                target.FontFamily = FontAwesomeRegular;
            else if (iconID.StartsWith("fab"))
                target.FontFamily = FontAwesomeBrand;
            else
                target.FontFamily = FontAwesomeSolid;

            target.Content = symbolChar;
        }

        private const FontAwesomeIcon DEFAULT_CONTENT = FontAwesomeIcon.None;
    }
}
