using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSaladin.FontAwesome.WPF
{
    public static class FontAwesomeExtension
    {
        public static string GetIconID(this FontAwesomeIcon icon)
        {
            var memberInfos = typeof(FontAwesomeIcon).GetMember(icon.ToString());
            var enumValueMemberInfo = memberInfos.FirstOrDefault(m => m.DeclaringType == typeof(FontAwesomeIcon));
            var valueAttributes =
                  enumValueMemberInfo.GetCustomAttributes(typeof(IconIDAttribute), false);
            var iconID = ((IconIDAttribute)valueAttributes[0]).Id;

            return iconID;
        }

        public static char GetUnicode(this FontAwesomeIcon icon)
        {
            var memberInfos = typeof(FontAwesomeIcon).GetMember(icon.ToString());
            var enumValueMemberInfo = memberInfos.FirstOrDefault(m => m.DeclaringType == typeof(FontAwesomeIcon));
            var valueAttributes =
                  enumValueMemberInfo.GetCustomAttributes(typeof(IconUnicodeGlyphAttribute), false);
            var iconID = ((IconUnicodeGlyphAttribute)valueAttributes[0]).UnicodeGlyph;

            return iconID;
        }
    }
}
