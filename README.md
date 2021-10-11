# FontAwesome for WPF
[![NuGet version (DSaladin.FontAwesome.WPF)](https://img.shields.io/nuget/v/DSaladin.FontAwesome.WPF.svg?style=flat-square)](https://www.nuget.org/packages/DSaladin.FontAwesome.WPF/)  

WPF Controls with FontAwesome Icons.

FontAwesome Website: https://fontawesome.com/icons  
Current FontAwesome Version: 5.15.4

## Changes in the newest version of FontAwesome
https://github.com/FortAwesome/Font-Awesome/blob/master/CHANGELOG.md

## Usage
### Include in Window/Usercontrol
`xmlns:fa="clr-namespace:DSaladin.FontAwesome.WPF;assembly=DSaladin.FontAwesome.WPF"`

### In Controls
(ex. Label)  
```
// instead of using Content
<Label fa:Icon.Content="SolidArrowUp" />
// instead of using Text
<Button fa:Icon.Content="SolidArrowUp" />
```

### Custom Controls
```
<fa:FontAwesomeBox Icon="SolidArrowUp" />
<fa:FontAwesomeImage Icon="SolidArrowUp" />
```

#### Control Properties
Rotate any FontAwesomeBox or FontAwesomeImage:  
`<fa:FontAwesomeBox Icon="SolidArrowUp" FlipOrientation="Horizontal" Rotation="10" />`  
![Rotation Example](https://raw.githubusercontent.com/DSaladinCH/fontawesome-wpf/master/images/FontAwesomeWPF_RotationProp.png)

## License Type
MIT
