using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace DSaladin.FontAwesome.WPF
{
    public static class ControlExtension
    {
        /// <summary>
        /// Sets the rotation for the control
        /// </summary>
        /// <typeparam name="T">FrameworkElement and IRotatable</typeparam>
        /// <param name="control">Control to apply the rotation</param>
        public static void SetRotation<T>(this T control)
            where T : FrameworkElement, IRotatable
        {
            var transformGroup = control.RenderTransform as TransformGroup ?? new TransformGroup();

            var rotateTransform = transformGroup.Children.OfType<RotateTransform>().FirstOrDefault();

            if (rotateTransform != null)
            {
                rotateTransform.Angle = control.Rotation;
            }
            else
            {
                transformGroup.Children.Add(new RotateTransform(control.Rotation));
                control.RenderTransform = transformGroup;
                control.RenderTransformOrigin = new Point(0.5, 0.5);
            }
        }

        /// <summary>
        /// Sets the flip orientation for the control
        /// </summary>
        /// <typeparam name="T">FrameworkElement and IRotatable</typeparam>
        /// <param name="control">Control to apply the rotation</param>
        public static void SetFlipOrientation<T>(this T control)
            where T : FrameworkElement, IFlippable
        {
            var transformGroup = control.RenderTransform as TransformGroup ?? new TransformGroup();

            var scaleX = control.FlipOrientation == FlipOrientation.Normal || control.FlipOrientation == FlipOrientation.Vertical ? 1 : -1;
            var scaleY = control.FlipOrientation == FlipOrientation.Normal || control.FlipOrientation == FlipOrientation.Horizontal ? 1 : -1;

            var scaleTransform = transformGroup.Children.OfType<ScaleTransform>().FirstOrDefault();

            if (scaleTransform != null)
            {
                scaleTransform.ScaleX = scaleX;
                scaleTransform.ScaleY = scaleY;
            }
            else
            {
                transformGroup.Children.Add(new ScaleTransform(scaleX, scaleY));
                control.RenderTransform = transformGroup;
                control.RenderTransformOrigin = new Point(0.5, 0.5);
            }
        }
    }
}
