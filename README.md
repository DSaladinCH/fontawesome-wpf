# FontAwesome for WPF

WPF Controls with FontAwesome Icons.

FontAwesome Website: https://fontawesome.com/icons  
Current FontAwesome Version: 5.15.2

## Usage
### Include in Window/Usercontrol
`xmlns:fa="clr-namespace:DSaladin.FontAwesomeWPF;assembly=FontAwesomeWPF"`

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
![GitHub Logo](/images/FontAwesomeWPF_RotationProp.png)

## License Type
MIT
