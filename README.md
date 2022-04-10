<div align="center">
  <a href="./images/FontAwesomeLogo.png">
    <img src="./images/FontAwesomeLogo.png" alt="Logo" width="80" height="80">
  </a>

  <h3 align="center">FontAwesome for WPF</h3>

  <p align="center">
    WPF Controls with FontAwesome Icons
    <br />
<div>

[![GitHub issues](https://img.shields.io/github/issues/DSaladinCH/fontawesome-wpf?style=for-the-badge)](https://github.com/DSaladinCH/fontawesome-wpf/issues)
[![GitHub license](https://img.shields.io/github/license/DSaladinCH/fontawesome-wpf?style=for-the-badge)](https://github.com/DSaladinCH/fontawesome-wpf/blob/master/LICENSE.txt)
[![NuGet version (DSaladin.FontAwesome.WPF)](https://img.shields.io/nuget/v/DSaladin.FontAwesome.WPF.svg?style=for-the-badge)](https://www.nuget.org/packages/DSaladin.FontAwesome.WPF/)  

</div>
    <a href="https://www.nuget.org/packages/DSaladin.FontAwesome.WPF">Download</a>
    ·
    <a href="https://github.com/DSaladinCH/fontawesome-wpf/issues">Report Bug</a>
    ·
    <a href="https://github.com/DSaladinCH/fontawesome-wpf/issues">Request Feature</a>
  </p>
</div>

# About This Project
**FontAwesome Website:** [FontAwesome Website](https://fontawesome.com/icons) \
**Current FontAwesome Version:** 6.1.1 \
**Official FontAwesome Changelog:** [GitHub Changelog](https://github.com/FortAwesome/Font-Awesome/blob/master/CHANGELOG.md) \
**Package Changelog:** [GitHub Changelog](https://github.com/DSaladinCH/fontawesome-wpf/blob/master/CHANGELOG.md) \

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