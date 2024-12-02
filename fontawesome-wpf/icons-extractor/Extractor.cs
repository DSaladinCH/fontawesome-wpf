using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace icons_extractor
{
    internal static class Extractor
    {
        private static List<FontAwesomeIcon> icons = new List<FontAwesomeIcon>();
        private static int iconCounter = 0;

        internal static void Start()
        {
            string filePath = "";

            Console.WriteLine("Please insert file path:");
            filePath = Console.ReadLine()!;

            if (filePath.StartsWith("\"") && filePath.EndsWith("\""))
                filePath = filePath.Substring(1, filePath.Length - 2);

            if (string.IsNullOrEmpty(filePath))
                return;

            if (!File.Exists(filePath))
                return;

            ReadFile(filePath);

            string generatedFileContent = "";
            generatedFileContent += "///<summary>Set this value to show no icon.</summary>";
            generatedFileContent += "\r\n";
            generatedFileContent += "None = 0x0,";
            foreach (FontAwesomeIcon icon in icons)
            {
                string iconWhitespace = icon.IconID.Replace("-", " ");
                string iconName = icon.TypeDisplay + CultureInfo.CurrentCulture.TextInfo.ToTitleCase(iconWhitespace).Replace(" ", "");
                string typeIconID = icon.Type + "-" + icon.IconID;

                generatedFileContent += "\r\n";
                generatedFileContent += string.Format("///<summary>{0} {1}</summary>", icon.TypeDisplay, icon.Name);
                generatedFileContent += "\r\n";
                generatedFileContent += string.Format("///<see href=\"https://fontawesome.com/icons/{0}?style={1}\"/>", icon.IconID, icon.TypeDisplay.ToLower());
                generatedFileContent += "\r\n";
                generatedFileContent += string.Format("[Description(\"{0} {1}\"), IconID(\"{2}\"), IconUnicodeGlyph(0x{3})]", icon.TypeDisplay, icon.Name, typeIconID, icon.Unicode);
                generatedFileContent += "\r\n";
                generatedFileContent += string.Format("{0} = {1},", iconName, iconCounter);

                iconCounter++;
            }
            // Remove last comma
            generatedFileContent = generatedFileContent.Substring(0, generatedFileContent.Length - 1);

            File.WriteAllText(Path.Combine(Path.GetDirectoryName(filePath)!, "AllIcons.txt"), generatedFileContent);

            Console.WriteLine("Saved!");
            Console.ReadLine();
        }

        private static void ReadFile(string filePath)
        {
            string fileContent = File.ReadAllText(filePath);

            JsonObject? jsonObjects = JsonNode.Parse(fileContent)?.AsObject();
            if (jsonObjects is null)
                return;

            foreach (var item in jsonObjects)
            {
                string iconID = item.Key;
                //int count = item.Value!["styles"]!.AsArray()!.Count;
                //if (count > 1)
                //    System.Diagnostics.Debugger.Break();
                string iconUnicode = item.Value!["unicode"]!.GetValue<string>();
                string iconLabel = item.Value!["label"]!.GetValue<string>();
                foreach (var arrayItem in item.Value!["styles"]!.AsArray())
                {
                    icons.Add(new(arrayItem!.GetValue<string>(), iconID, iconLabel, iconUnicode));
                }
            }
        }
    }

    [System.Diagnostics.DebuggerDisplay("{TypeDisplay,np}: {IconID} - Unicode: {Unicode}")]
    class FontAwesomeIcon
    {
        public string Type { get; set; }
        public string TypeDisplay { get; set; }
        public string IconID { get; set; }
        public string Unicode { get; set; }
        public string Name { get; set; }

        public FontAwesomeIcon(string type, string iconID, string name, string unicode)
        {
            switch (type.ToLower())
            {
                case "solid":
                    TypeDisplay = "Solid";
                    Type = "fas";
                    break;
                case "regular":
                    TypeDisplay = "Regular";
                    Type = "far";
                    break;
                case "brands":
                    TypeDisplay = "Brands";
                    Type = "fab";
                    break;
            }
            IconID = iconID;
            Name = name;
            Unicode = unicode;
        }
    }
}
