using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DSaladin.FontAwesome.WPF
{
    public static class FontAwesomeExtension
    {
        public static string GetIconID(this FontAwesomeIcon icon)
        {
            MemberInfo[] memberInfos = typeof(FontAwesomeIcon).GetMember(icon.ToString());
            MemberInfo enumValueMemberInfo = memberInfos.FirstOrDefault(m => m.DeclaringType == typeof(FontAwesomeIcon));
            object[] valueAttributes = enumValueMemberInfo.GetCustomAttributes(typeof(IconIDAttribute), false);

            if (valueAttributes == null || valueAttributes.Length == 0)
                return "";

            return ((IconIDAttribute)valueAttributes[0]).Id;
        }

        public static char GetUnicode(this FontAwesomeIcon icon)
        {
            MemberInfo[] memberInfos = typeof(FontAwesomeIcon).GetMember(icon.ToString());
            MemberInfo enumValueMemberInfo = memberInfos.FirstOrDefault(m => m.DeclaringType == typeof(FontAwesomeIcon));
            object[] valueAttributes = enumValueMemberInfo.GetCustomAttributes(typeof(IconUnicodeGlyphAttribute), false);

            if (valueAttributes == null || valueAttributes.Length == 0)
                return (char)0x0;

            return ((IconUnicodeGlyphAttribute)valueAttributes[0]).UnicodeGlyph;
        }
    }
}
