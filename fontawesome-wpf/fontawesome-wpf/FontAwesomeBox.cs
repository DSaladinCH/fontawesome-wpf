using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace DSaladin.FontAwesome.WPF
{
    /// <summary>
    /// Provides a TextBlock with a FontAwesome Icon
    /// </summary>
    public class FontAwesomeBox : TextBlock, IRotatable, IFlippable
    {
        /// <summary>
        /// FontAwesome FontFamily.
        /// </summary>
        public static readonly FontFamily FontAwesomeSolid = new FontFamily(new Uri("pack://application:,,,/DSaladin.FontAwesome.WPF;component/"), "./#Font Awesome 5 Free Solid");
        public static readonly FontFamily FontAwesomeRegular = new FontFamily(new Uri("pack://application:,,,/DSaladin.FontAwesome.WPF;component/"), "./#Font Awesome 5 Free Regular");
        public static readonly FontFamily FontAwesomeBrand = new FontFamily(new Uri("pack://application:,,,/DSaladin.FontAwesome.WPF;component/"), "./#Font Awesome 5 Brands Regular");

        /// <summary>
        /// Identifies the FontAwesome.WPF.FontAwesome.Icon dependency property.
        /// </summary>
        public static readonly DependencyProperty IconProperty =
            DependencyProperty.Register("Icon", typeof(FontAwesomeIcon), typeof(FontAwesomeBox), new PropertyMetadata(FontAwesomeIcon.None, OnIconPropertyChanged));

        /// <summary>
        /// Identifies the FontAwesome.WPF.FontAwesome.Rotation dependency property.
        /// </summary>
        public static readonly DependencyProperty RotationProperty =
            DependencyProperty.Register("Rotation", typeof(double), typeof(FontAwesomeBox), new PropertyMetadata(0d, RotationChanged, RotationCoerceValue));

        /// <summary>
        /// Identifies the FontAwesome.WPF.FontAwesome.FlipOrientation dependency property.
        /// </summary>
        public static readonly DependencyProperty FlipOrientationProperty =
            DependencyProperty.Register("FlipOrientation", typeof(FlipOrientation), typeof(FontAwesomeBox), new PropertyMetadata(FlipOrientation.Normal, FlipOrientationChanged));

        static FontAwesomeBox()
        {
            //OpacityProperty.OverrideMetadata(typeof(FontAwesomeBox), new UIPropertyMetadata(1.0, OpacityChanged));
        }

        /// <summary>
        /// Gets or sets the FontAwesome icon. Changing this property will cause the icon to be redrawn.
        /// </summary>
        public FontAwesomeIcon Icon
        {
            get { return (FontAwesomeIcon)GetValue(IconProperty); }
            set { SetValue(IconProperty, value); }
        }

        private static void OnIconPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            FontAwesomeIcon symbolIcon = (FontAwesomeIcon)e.NewValue;

            d.SetValue(TextOptions.TextRenderingModeProperty, TextRenderingMode.ClearType);

            string iconID = symbolIcon.GetIconID();
            if (iconID.StartsWith("far"))
            {
                d.SetValue(FontFamilyProperty, FontAwesomeRegular);
                d.SetValue(FontWeightProperty, FontWeights.Regular);
            }
            else if (iconID.StartsWith("fab"))
            {
                d.SetValue(FontFamilyProperty, FontAwesomeBrand);
                d.SetValue(FontWeightProperty, FontWeights.Regular);
            }
            else
            {
                d.SetValue(FontFamilyProperty, FontAwesomeSolid);
                d.SetValue(FontWeightProperty, FontWeights.Normal);
            }

            d.SetValue(TextAlignmentProperty, TextAlignment.Center);
            d.SetValue(TextProperty, char.ConvertFromUtf32((int)e.NewValue));
        }

        #region Rotation
        /// <summary>
        /// Gets or sets the current rotation (angle).
        /// </summary>
        public double Rotation
        {
            get { return (double)GetValue(RotationProperty); }
            set { SetValue(RotationProperty, value); }
        }

        private static void RotationChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var fontAwesome = d as FontAwesomeBox;

            //if (null == fontAwesome || fontAwesome.Spin || !(e.NewValue is double) || e.NewValue.Equals(e.OldValue)) return;
            if (null == fontAwesome || !(e.NewValue is double) || e.NewValue.Equals(e.OldValue))
                return;

            fontAwesome.SetRotation();
        }

        private static object RotationCoerceValue(DependencyObject d, object value)
        {
            double val = (double)value;
            return val < 0 ? 0d : val > 360 ? 360d : value;
        }
        #endregion

        #region Flip
        /// <summary>
        /// Gets or sets the current orientation (horizontal, vertical).
        /// </summary>
        public FlipOrientation FlipOrientation
        {
            get { return (FlipOrientation)GetValue(FlipOrientationProperty); }
            set { SetValue(FlipOrientationProperty, value); }
        }

        private static void FlipOrientationChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var fontAwesome = d as FontAwesomeBox;

            if (null == fontAwesome || !(e.NewValue is FlipOrientation) || e.NewValue.Equals(e.OldValue))
                return;

            fontAwesome.SetFlipOrientation();
        }
        #endregion
    }
}
