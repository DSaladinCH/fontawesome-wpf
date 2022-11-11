using DSaladin.FontAwesome.WPF;
using System.Collections.Specialized;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json.Nodes;
using System.Text.RegularExpressions;
using System.Windows.Forms;

List<FontAwesomeIcon> icons = new List<FontAwesomeIcon>();
int iconCounter = 0;

// Get file
Console.WriteLine("Please insert file path to icons.json:");
string filePath = Console.ReadLine()!;

if (filePath.StartsWith("\"") && filePath.EndsWith("\""))
    filePath = filePath.Substring(1, filePath.Length - 2);

string directory = Path.GetDirectoryName(filePath)!;
string csFile = Path.Combine(directory, "FontAwesomeIcon.cs");

// Extract data from file
ReadFile(filePath);

// Generate cs file
using StreamWriter stream = new(csFile, false, Encoding.UTF8);
await stream.WriteAsync("""
    using System.ComponentModel;

    namespace DSaladin.FontAwesome.WPF
    {
        public enum FontAwesomeIcon
        {
            ///<summary>Set this value to show no icon.</summary>
            None = 0x0,
    """);

string newLine = """

            ///<summary>{1} {3}</summary>"
            [IconID("{0}"), IconUnicodeGlyph(0x{4})]
            {5} = {6},
    """;

int max = icons.DistinctBy(i => i.IconID).ToList().Count;
foreach (FontAwesomeIcon icon in icons.DistinctBy(i => i.IconID))
{
    string formattedIconName = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(icon.IconID.Replace("-", " ")).Replace(" ", "");
    if (Regex.IsMatch(formattedIconName, @"^\d"))
        formattedIconName = "FA" + formattedIconName;

    await stream.WriteAsync(string.Format(newLine, icon.IconID, icon.Style, icon.Family, icon.Name, icon.Unicode, formattedIconName, iconCounter));
    iconCounter++;
    if (iconCounter % 250 == 0)
        Console.Write("\rCreated {0:D5}/{1:D5}", iconCounter, max);
}
Console.Write("\rCreated {0:D5}/{1:D5}", iconCounter, max);

// Remove last comma
//generatedFileContent = generatedFileContent[..^1];
await stream.WriteAsync("""
        }
    }
    """);

stream.Close();
//File.WriteAllText(csFile, generatedFileContent);
Console.WriteLine("\r\nSaved!");
Console.ReadLine();

void ReadFile(string filePath)
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
            FontAwesomeIcon.Add(ref icons, arrayItem!.GetValue<string>(), iconID, iconLabel, iconUnicode);
            //icons.Add(new(arrayItem!.GetValue<string>(), iconID, iconLabel, iconUnicode));
        }
    }
}

[System.Diagnostics.DebuggerDisplay("{Family} {Style}: {IconID} - Unicode: {Unicode}")]
class FontAwesomeIcon
{
    public IconFamily Family { get; set; } = IconFamily.Classic;
    public IconStyle Style { get; set; } = IconStyle.Solid;
    public string IconID { get; set; }
    public string Unicode { get; set; }
    public string Name { get; set; }

    public static void Add(ref List<FontAwesomeIcon> list, string style, string iconID, string name, string unicode)
    {
        FontAwesomeIcon icon = new();

        switch (style.ToLower())
        {
            case "solid":
                icon.Family = IconFamily.Classic;
                icon.Style = IconStyle.Solid;
                // is listed as own style in icons.json
                //Add(ref list, IconFamily.Duotone.ToString(), iconID, name, unicode);
                Add(ref list, IconFamily.Sharp.ToString(), iconID, name, unicode);
                break;
            case "regular":
                icon.Family = IconFamily.Classic;
                icon.Style = IconStyle.Regular;
                break;
            case "light":
                icon.Family = IconFamily.Classic;
                break;
            case "thin":
                icon.Family = IconFamily.Classic;
                break;

            case "brands":
                icon.Family = IconFamily.Classic;
                icon.Style = IconStyle.Brands;
                break;

            // No new style, but a new family
            case "duotone":
                icon.Family = IconFamily.Duotone;
                icon.Style = IconStyle.Solid;
                break;
            case "sharp":
                icon.Family = IconFamily.Sharp;
                icon.Style = IconStyle.Solid;
                break;
        }

        icon.IconID = iconID;
        icon.Name = name;
        icon.Unicode = unicode;

        list.Add(icon);
    }
}