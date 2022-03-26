# FontAwesome for WPF
[![NuGet version (DSaladin.FontAwesome.WPF)](https://img.shields.io/nuget/v/DSaladin.FontAwesome.WPF.svg?style=flat-square)](https://www.nuget.org/packages/DSaladin.FontAwesome.WPF/)  

WPF Controls with FontAwesome Icons.

**FontAwesome Website:** https://fontawesome.com/icons  
**Current FontAwesome Version:** 6.1.1

### Changes in the newest version of FontAwesome
https://github.com/FortAwesome/Font-Awesome/blob/master/CHANGELOG.md

## How to use
### Include in Window / UserControl / ResourceDictionary
```
xmlns:fa="https://dsaladin.dev/products/fontawesome/wpf/xaml"
```

### Step 2 - Set icon in Control
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

## License Type
MIT
