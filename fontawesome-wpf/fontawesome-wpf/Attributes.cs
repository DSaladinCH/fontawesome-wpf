using System;
using System.Collections.Generic;
using System.Text;

namespace DSaladin.FontAwesome.WPF
{
    /// <summary>
    /// Represents the category of a fontawesome icon.
    /// </summary>
    [AttributeUsage(AttributeTargets.All, AllowMultiple = true, Inherited = false)]
    public class IconCategoryAttribute : Attribute
    {
        /// <summary>
        /// Gets or sets the category of the icon.
        /// </summary>
        public string Category { get; set; }
        /// <summary>
        /// Initializes a new instance of the FontAwesome.WPF.IconCategoryAttribute class.
        /// </summary>
        /// <param name="category">The icon category.</param>
        public IconCategoryAttribute(string category)
        {
            Category = category;
        }
    }
    /// <summary>
    /// Represents the field is an alias of another icon.
    /// </summary>
    [AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = false)]
    public class IconAliasAttribute : Attribute
    { }

    /// <summary>
    /// Represents the id (css class name) of the icon.
    /// </summary>
    [AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = false)]
    public class IconIDAttribute : Attribute
    {
        /// <summary>
        /// Gets or sets the id (css class name) of the icon.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Initializes a new instance of the FontAwesome.WPF.IconIdAttribute class.
        /// </summary>
        /// <param name="id">The icon id (css class name).</param>
        public IconIDAttribute(string id)
        {
            Id = id;
        }
    }

    /// <summary>
    /// Represents the unicode glyph of the icon.
    /// </summary>
    [AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = false)]
    public class IconUnicodeGlyphAttribute : Attribute
    {
        /// <summary>
        /// Gets or sets the unicode glyph of the icon.
        /// </summary>
        public char UnicodeGlyph { get; set; }

        /// <summary>
        /// Initializes a new instance of the FontAwesome.WPF.IconUnicodeGlyphAttribute class.
        /// </summary>
        /// <param name="unicodeGlyph">The unicode glyph</param>
        public IconUnicodeGlyphAttribute(int unicodeGlyph)
        {
            UnicodeGlyph = (char)unicodeGlyph;
        }
    }
}
