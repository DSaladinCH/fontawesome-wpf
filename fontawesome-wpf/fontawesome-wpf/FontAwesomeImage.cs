using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace DSaladin.FontAwesome.WPF
{
    /// <summary>
    /// Provides a ImageBox with a FontAwesome Icon
    /// </summary>
    public class FontAwesomeImage : Image, IRotatable, IFlippable
    {
        /// <summary>
        /// Typeface used to generate FontAwesome icon.
        /// </summary>
        private static readonly Typeface FontAwesomeTypefaceSolid = new Typeface(Management.FontAwesomeSolid, FontStyles.Normal, FontWeights.Normal, FontStretches.Normal);
        private static readonly Typeface FontAwesomeTypefaceRegular = new Typeface(Management.FontAwesomeRegular, FontStyles.Normal, FontWeights.Normal, FontStretches.Normal);
        private static readonly Typeface FontAwesomeTypefaceBrand = new Typeface(Management.FontAwesomeBrand, FontStyles.Normal, FontWeights.Normal, FontStretches.Normal);

        /// <summary>
        /// Identifies the FontAwesome.WPF.ImageAwesome.Foreground dependency property.
        /// </summary>
        public static readonly DependencyProperty ForegroundProperty =
            DependencyProperty.Register("Foreground", typeof(Brush), typeof(FontAwesomeImage), new PropertyMetadata(Brushes.Black, OnIconPropertyChanged));

        /// <summary>
        /// Identifies the FontAwesome.WPF.ImageAwesome.Icon dependency property.
        /// </summary>
        public static readonly DependencyProperty IconProperty =
            DependencyProperty.Register("Icon", typeof(FontAwesomeIcon), typeof(FontAwesomeImage), new PropertyMetadata(FontAwesomeIcon.None, OnIconPropertyChanged));

        /// <summary>
        /// Identifies the FontAwesome.WPF.ImageAwesome.Rotation dependency property.
        /// </summary>
        public static readonly DependencyProperty RotationProperty =
            DependencyProperty.Register("Rotation", typeof(double), typeof(FontAwesomeImage), new PropertyMetadata(0d, RotationChanged, RotationCoerceValue));

        /// <summary>
        /// Identifies the FontAwesome.WPF.ImageAwesome.FlipOrientation dependency property.
        /// </summary>
        public static readonly DependencyProperty FlipOrientationProperty =
            DependencyProperty.Register("FlipOrientation", typeof(FlipOrientation), typeof(FontAwesomeImage), new PropertyMetadata(FlipOrientation.Normal, FlipOrientationChanged));

        static FontAwesomeImage()
        {
            //OpacityProperty.OverrideMetadata(typeof(FontAwesomeImage), new UIPropertyMetadata(1.0, OpacityChanged));
        }

        /// <summary>
        /// Gets or sets the foreground brush of the icon. Changing this property will cause the icon to be redrawn.
        /// </summary>
        public Brush Foreground
        {
            get { return (Brush)GetValue(ForegroundProperty); }
            set { SetValue(ForegroundProperty, value); }
        }
        /// <summary>
        /// Gets or sets the FontAwesome icon. Changing this property will cause the icon to be redrawn.
        /// </summary>
        public FontAwesomeIcon Icon
        {
            get { return (FontAwesomeIcon)GetValue(IconProperty); }
            set { SetValue(IconProperty, value); }
        }

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
            var imageAwesome = d as FontAwesomeImage;

            //if (null == imageAwesome || imageAwesome.Spin || !(e.NewValue is double) || e.NewValue.Equals(e.OldValue)) return;
            if (null == imageAwesome || !(e.NewValue is double) || e.NewValue.Equals(e.OldValue))
                return;

            imageAwesome.SetRotation((double)e.NewValue);
        }

        private static object RotationCoerceValue(DependencyObject d, object value)
        {
            double val = (double)value;
            return val < 0 ? 0d : val > 360 ? 360d : value;
        }

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
            var imageAwesome = d as FontAwesomeImage;

            if (null == imageAwesome || !(e.NewValue is FlipOrientation) || e.NewValue.Equals(e.OldValue))
                return;

            imageAwesome.SetFlipOrientation();
        }

        private static void OnIconPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var imageAwesome = d as FontAwesomeImage;

            if (imageAwesome == null)
                return;

            imageAwesome.SetValue(SourceProperty, CreateImageSource(imageAwesome.Icon, imageAwesome.Foreground));
        }

        /// <summary>
        /// Creates a new System.Windows.Media.ImageSource of a specified FontAwesomeIcon and foreground System.Windows.Media.Brush.
        /// </summary>
        /// <param name="icon">The FontAwesome icon to be drawn.</param>
        /// <param name="foregroundBrush">The System.Windows.Media.Brush to be used as the foreground.</param>
        /// <returns>A new System.Windows.Media.ImageSource</returns>
        public static ImageSource CreateImageSource(FontAwesomeIcon icon, Brush foregroundBrush, double emSize = 100)
        {
            var charIcon = char.ConvertFromUtf32(icon.GetUnicode());

            var visual = new DrawingVisual();
            using (var drawingContext = visual.RenderOpen())
            {
                Typeface temp = FontAwesomeTypefaceSolid;
                string iconID = icon.GetIconID();
                if (iconID.StartsWith("far"))
                    temp = FontAwesomeTypefaceRegular;
                else if (iconID.StartsWith("fab"))
                    temp = FontAwesomeTypefaceBrand;

#if NETCOREAPP3_1_OR_GREATER
                drawingContext.DrawText(new FormattedText(charIcon, CultureInfo.InvariantCulture, FlowDirection.LeftToRight, temp, emSize, foregroundBrush, 125)
                { TextAlignment = TextAlignment.Center }, new Point(0, 0));
#elif NETFRAMEWORK
                drawingContext.DrawText(new FormattedText(charIcon, CultureInfo.InvariantCulture, FlowDirection.LeftToRight, temp, emSize, foregroundBrush)
                { TextAlignment = TextAlignment.Center }, new Point(0, 0));
#endif
            }
            return new DrawingImage(visual.Drawing);
        }
    }
}
