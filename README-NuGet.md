# FontAwesome for WPF
[![GitHub issues](https://img.shields.io/github/issues/DSaladinCH/fontawesome-wpf?style=for-the-badge)](https://github.com/DSaladinCH/fontawesome-wpf/issues)
[![GitHub license](https://img.shields.io/github/license/DSaladinCH/fontawesome-wpf?style=for-the-badge)](https://github.com/DSaladinCH/fontawesome-wpf/blob/main/LICENSE.txt)
[![NuGet version (DSaladin.FontAwesome.WPF)](https://img.shields.io/nuget/v/DSaladin.FontAwesome.WPF.svg?style=for-the-badge)](https://www.nuget.org/packages/DSaladin.FontAwesome.WPF/)  

[!["Buy Me A Coffee"](https://raw.githubusercontent.com/DSaladinCH/fontawesome-wpf/main/images/buy_me_a_coffee.png)](https://www.buymeacoffee.com/dsaladin)

- **FontAwesome Website:** [FontAwesome Website](https://fontawesome.com/icons)
- **Current FontAwesome Version:** 6.7.2
- **Official FontAwesome Changelog:** [Changelog](https://fontawesome.com/changelog)
- **Package Changelog:** [GitHub Changelog](https://github.com/DSaladinCH/fontawesome-wpf/blob/main/CHANGELOG.md)

# How to use
## Step 1 - Include in Window / UserControl / ResourceDictionary
```
xmlns:fa="https://dsaladin.dev/products/fontawesome/wpf/xaml"
```

## Step 2 - Set icon in Control
```
<Label fa:Content.Icon="SolidArrowUp" />
<Button fa:Content.Icon="SolidArrowUp" />
```

## FontAwesome Controls
This package also contains two custom controls.
#### FontAwesome Controls
```
<fa:FontAwesomeBox Icon="SolidArrowUp" FlipOrientation="Horizontal" Rotation="10" />
<fa:FontAwesomeImage Icon="SolidArrowUp" />
```

# Troubleshooting
## Error CS8630 - Invalid 'nullable' value
The package uses nullable values (for example `string?`), this was officially added in C# 8.0. This version (or higher) is used from .NET Core 3.x onwards.
In .NET Framework the default is C# 7.3. So in order to use the package you have to set the project language version to 8.0 (or higher).
### Set language version
1. Open the .csproj file
2. Add `<LangVersion>8.0</LangVersion>` to the PropertyGroup

For more information visit https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/configure-language-version