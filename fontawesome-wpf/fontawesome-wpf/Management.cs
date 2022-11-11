using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media;

namespace DSaladin.FontAwesome.WPF
{
    /// <summary>
    /// Internal management
    /// </summary>
    internal class Management
    {
        /// <summary>
        /// Free Solid FontAwesome FontFamily
        /// </summary>
        internal static readonly FontFamily FontAwesomeFreeSolid = new FontFamily(new Uri("pack://application:,,,/DSaladin.FontAwesome.WPF;component/"), "./#Font Awesome 6 Free Solid");
        /// <summary>
        /// Free Regular FontAwesome FontFamily
        /// </summary>
        internal static readonly FontFamily FontAwesomeFreeRegular = new FontFamily(new Uri("pack://application:,,,/DSaladin.FontAwesome.WPF;component/"), "./#Font Awesome 6 Free Regular");
        /// <summary>
        /// Brands Regular FontAwesome FontFamily
        /// </summary>
        internal static readonly FontFamily FontAwesomeBrandsRegular = new FontFamily(new Uri("pack://application:,,,/DSaladin.FontAwesome.WPF;component/"), "./#Font Awesome 6 Brands Regular");
    }
}
