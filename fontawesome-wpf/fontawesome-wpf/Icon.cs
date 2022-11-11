using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace DSaladin.FontAwesome.WPF
{
    public static class Content
    {
        #region Icon
        /// <summary>
        /// The dependencyproperty for a FontAwesome icon on a ContentControl
        /// </summary>
        public static readonly DependencyProperty IconProperty =
            DependencyProperty.RegisterAttached(
                "Icon",
                typeof(FontAwesomeIcon),
                typeof(Content),
                new FrameworkPropertyMetadata(FontAwesomeIcon.None, new PropertyChangedCallback(IconChanged)));

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

        #region Icon Family
        /// <summary>
        /// The dependencyproperty for a FontAwesome icon on a ContentControl
        /// </summary>
        public static readonly DependencyProperty IconFamilyProperty =
            DependencyProperty.RegisterAttached(
                "IconFamily",
                typeof(IconFamily),
                typeof(Content),
                new FrameworkPropertyMetadata(IconFamily.Classic, new PropertyChangedCallback(IconChanged)));

        /// <summary>
        /// Gets the content of a ContentControl, expressed as a FontAwesome icon.
        /// </summary>
        /// <param name="target">The ContentControl subject of the query</param>
        /// <returns>FontAwesome icon found as content</returns>
        public static IconFamily GetIconFamily(DependencyObject target)
        {
            return (IconFamily)target.GetValue(IconFamilyProperty);
        }

        /// <summary>
        /// Sets the content of a ContentControl expressed as a FontAwesome icon. This will cause the content to be redrawn.
        /// </summary>
        /// <param name="target">The ContentControl where to set the content</param>
        /// <param name="value">FontAwesome icon to set as content</param>
        public static void SetIconFamily(DependencyObject target, IconFamily value)
        {
            target.SetValue(IconFamilyProperty, value);
        }
        #endregion

        #region Icon Style
        /// <summary>
        /// The dependencyproperty for a FontAwesome icon on a ContentControl
        /// </summary>
        public static readonly DependencyProperty IconStyleProperty =
            DependencyProperty.RegisterAttached(
                "IconStyle",
                typeof(IconStyle),
                typeof(Content),
                new FrameworkPropertyMetadata(IconStyle.Solid, new PropertyChangedCallback(IconChanged)));

        /// <summary>
        /// Gets the content of a ContentControl, expressed as a FontAwesome icon.
        /// </summary>
        /// <param name="target">The ContentControl subject of the query</param>
        /// <returns>FontAwesome icon found as content</returns>
        public static IconStyle GetIconStyle(DependencyObject target)
        {
            return (IconStyle)target.GetValue(IconStyleProperty);
        }

        /// <summary>
        /// Sets the content of a ContentControl expressed as a FontAwesome icon. This will cause the content to be redrawn.
        /// </summary>
        /// <param name="target">The ContentControl where to set the content</param>
        /// <param name="value">FontAwesome icon to set as content</param>
        public static void SetIconStyle(DependencyObject target, IconStyle value)
        {
            target.SetValue(IconStyleProperty, value);
        }
        #endregion

        private static void IconChanged(DependencyObject sender, DependencyPropertyChangedEventArgs evt)
        {
            if (!(sender is ContentControl)) return;

            ContentControl target = (ContentControl)sender;

            if (!(evt.NewValue is FontAwesomeIcon)) return;

            FontAwesomeIcon symbolIcon = (FontAwesomeIcon)evt.NewValue;
            char symbolChar = symbolIcon.GetUnicode();

            target.FontFamily = Management.FontAwesomeFreeSolid;
            string key = $"FontAwesomeFont_{target.GetValue(IconFamilyProperty)}_{target.GetValue(IconStyleProperty)}";
            if (Application.Current.Resources.Contains(key))
            {
                string uri = (string)Application.Current.Resources[key];
                FontFamily fontFamily = new FontFamily(new Uri(uri), GetFontName((IconFamily)target.GetValue(IconFamilyProperty), (IconStyle)target.GetValue(IconStyleProperty)));
                target.FontFamily = fontFamily;
            }

            target.Content = symbolChar;
        }

        private static string GetFontName(IconFamily family, IconStyle style)
        {
            switch (family)
            {
                case IconFamily.Classic:
                    switch (style)
                    {
                        case IconStyle.Solid:
                            return "Font Awesome 6 Pro Solid";
                        case IconStyle.Regular:
                            break;
                        case IconStyle.Light:
                            break;
                        case IconStyle.Thin:
                            break;
                        case IconStyle.Brands:
                            break;
                        default:
                            break;
                    }
                    return "";
                case IconFamily.Duotone:
                    return "";
                case IconFamily.Sharp:
                    return "";
                default:
                    return "Font Awesome 6 Free Solid";
            }
        }
    }
}
