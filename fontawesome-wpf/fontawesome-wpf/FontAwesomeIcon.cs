﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DSaladin.FontAwesome.WPF
{
    public enum FontAwesomeIcon
    {
        ///<summary>Set this value to show no icon.</summary>
        None = 0x0,
        ///<summary>Solid 0</summary>
        ///<see href="https://fontawesome.com/icons/0?style=solid"/>
        [Description("Solid 0"), IconID("fas-0"), IconUnicodeGlyph(0x30)]
        Solid0 = 0,
        ///<summary>Solid 1</summary>
        ///<see href="https://fontawesome.com/icons/1?style=solid"/>
        [Description("Solid 1"), IconID("fas-1"), IconUnicodeGlyph(0x31)]
        Solid1 = 1,
        ///<summary>Solid 2</summary>
        ///<see href="https://fontawesome.com/icons/2?style=solid"/>
        [Description("Solid 2"), IconID("fas-2"), IconUnicodeGlyph(0x32)]
        Solid2 = 2,
        ///<summary>Solid 3</summary>
        ///<see href="https://fontawesome.com/icons/3?style=solid"/>
        [Description("Solid 3"), IconID("fas-3"), IconUnicodeGlyph(0x33)]
        Solid3 = 3,
        ///<summary>Solid 4</summary>
        ///<see href="https://fontawesome.com/icons/4?style=solid"/>
        [Description("Solid 4"), IconID("fas-4"), IconUnicodeGlyph(0x34)]
        Solid4 = 4,
        ///<summary>Solid 5</summary>
        ///<see href="https://fontawesome.com/icons/5?style=solid"/>
        [Description("Solid 5"), IconID("fas-5"), IconUnicodeGlyph(0x35)]
        Solid5 = 5,
        ///<summary>Solid 6</summary>
        ///<see href="https://fontawesome.com/icons/6?style=solid"/>
        [Description("Solid 6"), IconID("fas-6"), IconUnicodeGlyph(0x36)]
        Solid6 = 6,
        ///<summary>Solid 7</summary>
        ///<see href="https://fontawesome.com/icons/7?style=solid"/>
        [Description("Solid 7"), IconID("fas-7"), IconUnicodeGlyph(0x37)]
        Solid7 = 7,
        ///<summary>Solid 8</summary>
        ///<see href="https://fontawesome.com/icons/8?style=solid"/>
        [Description("Solid 8"), IconID("fas-8"), IconUnicodeGlyph(0x38)]
        Solid8 = 8,
        ///<summary>Solid 9</summary>
        ///<see href="https://fontawesome.com/icons/9?style=solid"/>
        [Description("Solid 9"), IconID("fas-9"), IconUnicodeGlyph(0x39)]
        Solid9 = 9,
        ///<summary>Brands 42.group</summary>
        ///<see href="https://fontawesome.com/icons/42-group?style=brands"/>
        [Description("Brands 42.group"), IconID("fab-42-group"), IconUnicodeGlyph(0xe080)]
        Brands42Group = 10,
        ///<summary>Brands 500px</summary>
        ///<see href="https://fontawesome.com/icons/500px?style=brands"/>
        [Description("Brands 500px"), IconID("fab-500px"), IconUnicodeGlyph(0xf26e)]
        Brands500Px = 11,
        ///<summary>Solid A</summary>
        ///<see href="https://fontawesome.com/icons/a?style=solid"/>
        [Description("Solid A"), IconID("fas-a"), IconUnicodeGlyph(0x41)]
        SolidA = 12,
        ///<summary>Brands Accessible Icon</summary>
        ///<see href="https://fontawesome.com/icons/accessible-icon?style=brands"/>
        [Description("Brands Accessible Icon"), IconID("fab-accessible-icon"), IconUnicodeGlyph(0xf368)]
        BrandsAccessibleIcon = 13,
        ///<summary>Brands Accusoft</summary>
        ///<see href="https://fontawesome.com/icons/accusoft?style=brands"/>
        [Description("Brands Accusoft"), IconID("fab-accusoft"), IconUnicodeGlyph(0xf369)]
        BrandsAccusoft = 14,
        ///<summary>Solid Address Book</summary>
        ///<see href="https://fontawesome.com/icons/address-book?style=solid"/>
        [Description("Solid Address Book"), IconID("fas-address-book"), IconUnicodeGlyph(0xf2b9)]
        SolidAddressBook = 15,
        ///<summary>Regular Address Book</summary>
        ///<see href="https://fontawesome.com/icons/address-book?style=regular"/>
        [Description("Regular Address Book"), IconID("far-address-book"), IconUnicodeGlyph(0xf2b9)]
        RegularAddressBook = 16,
        ///<summary>Solid Address Card</summary>
        ///<see href="https://fontawesome.com/icons/address-card?style=solid"/>
        [Description("Solid Address Card"), IconID("fas-address-card"), IconUnicodeGlyph(0xf2bb)]
        SolidAddressCard = 17,
        ///<summary>Regular Address Card</summary>
        ///<see href="https://fontawesome.com/icons/address-card?style=regular"/>
        [Description("Regular Address Card"), IconID("far-address-card"), IconUnicodeGlyph(0xf2bb)]
        RegularAddressCard = 18,
        ///<summary>Brands App.net</summary>
        ///<see href="https://fontawesome.com/icons/adn?style=brands"/>
        [Description("Brands App.net"), IconID("fab-adn"), IconUnicodeGlyph(0xf170)]
        BrandsAdn = 19,
        ///<summary>Brands Adversal</summary>
        ///<see href="https://fontawesome.com/icons/adversal?style=brands"/>
        [Description("Brands Adversal"), IconID("fab-adversal"), IconUnicodeGlyph(0xf36a)]
        BrandsAdversal = 20,
        ///<summary>Brands affiliatetheme</summary>
        ///<see href="https://fontawesome.com/icons/affiliatetheme?style=brands"/>
        [Description("Brands affiliatetheme"), IconID("fab-affiliatetheme"), IconUnicodeGlyph(0xf36b)]
        BrandsAffiliatetheme = 21,
        ///<summary>Brands Airbnb</summary>
        ///<see href="https://fontawesome.com/icons/airbnb?style=brands"/>
        [Description("Brands Airbnb"), IconID("fab-airbnb"), IconUnicodeGlyph(0xf834)]
        BrandsAirbnb = 22,
        ///<summary>Brands Algolia</summary>
        ///<see href="https://fontawesome.com/icons/algolia?style=brands"/>
        [Description("Brands Algolia"), IconID("fab-algolia"), IconUnicodeGlyph(0xf36c)]
        BrandsAlgolia = 23,
        ///<summary>Solid Align Center</summary>
        ///<see href="https://fontawesome.com/icons/align-center?style=solid"/>
        [Description("Solid Align Center"), IconID("fas-align-center"), IconUnicodeGlyph(0xf037)]
        SolidAlignCenter = 24,
        ///<summary>Solid Align Justify</summary>
        ///<see href="https://fontawesome.com/icons/align-justify?style=solid"/>
        [Description("Solid Align Justify"), IconID("fas-align-justify"), IconUnicodeGlyph(0xf039)]
        SolidAlignJustify = 25,
        ///<summary>Solid Align Left</summary>
        ///<see href="https://fontawesome.com/icons/align-left?style=solid"/>
        [Description("Solid Align Left"), IconID("fas-align-left"), IconUnicodeGlyph(0xf036)]
        SolidAlignLeft = 26,
        ///<summary>Solid Align Right</summary>
        ///<see href="https://fontawesome.com/icons/align-right?style=solid"/>
        [Description("Solid Align Right"), IconID("fas-align-right"), IconUnicodeGlyph(0xf038)]
        SolidAlignRight = 27,
        ///<summary>Brands Alipay</summary>
        ///<see href="https://fontawesome.com/icons/alipay?style=brands"/>
        [Description("Brands Alipay"), IconID("fab-alipay"), IconUnicodeGlyph(0xf642)]
        BrandsAlipay = 28,
        ///<summary>Brands Amazon</summary>
        ///<see href="https://fontawesome.com/icons/amazon?style=brands"/>
        [Description("Brands Amazon"), IconID("fab-amazon"), IconUnicodeGlyph(0xf270)]
        BrandsAmazon = 29,
        ///<summary>Brands Amazon Pay</summary>
        ///<see href="https://fontawesome.com/icons/amazon-pay?style=brands"/>
        [Description("Brands Amazon Pay"), IconID("fab-amazon-pay"), IconUnicodeGlyph(0xf42c)]
        BrandsAmazonPay = 30,
        ///<summary>Brands Amilia</summary>
        ///<see href="https://fontawesome.com/icons/amilia?style=brands"/>
        [Description("Brands Amilia"), IconID("fab-amilia"), IconUnicodeGlyph(0xf36d)]
        BrandsAmilia = 31,
        ///<summary>Solid Anchor</summary>
        ///<see href="https://fontawesome.com/icons/anchor?style=solid"/>
        [Description("Solid Anchor"), IconID("fas-anchor"), IconUnicodeGlyph(0xf13d)]
        SolidAnchor = 32,
        ///<summary>Solid Anchor Circle Check</summary>
        ///<see href="https://fontawesome.com/icons/anchor-circle-check?style=solid"/>
        [Description("Solid Anchor Circle Check"), IconID("fas-anchor-circle-check"), IconUnicodeGlyph(0xe4aa)]
        SolidAnchorCircleCheck = 33,
        ///<summary>Solid Anchor Circle Exclamation</summary>
        ///<see href="https://fontawesome.com/icons/anchor-circle-exclamation?style=solid"/>
        [Description("Solid Anchor Circle Exclamation"), IconID("fas-anchor-circle-exclamation"), IconUnicodeGlyph(0xe4ab)]
        SolidAnchorCircleExclamation = 34,
        ///<summary>Solid Anchor Circle Xmark</summary>
        ///<see href="https://fontawesome.com/icons/anchor-circle-xmark?style=solid"/>
        [Description("Solid Anchor Circle Xmark"), IconID("fas-anchor-circle-xmark"), IconUnicodeGlyph(0xe4ac)]
        SolidAnchorCircleXmark = 35,
        ///<summary>Solid Anchor Lock</summary>
        ///<see href="https://fontawesome.com/icons/anchor-lock?style=solid"/>
        [Description("Solid Anchor Lock"), IconID("fas-anchor-lock"), IconUnicodeGlyph(0xe4ad)]
        SolidAnchorLock = 36,
        ///<summary>Brands Android</summary>
        ///<see href="https://fontawesome.com/icons/android?style=brands"/>
        [Description("Brands Android"), IconID("fab-android"), IconUnicodeGlyph(0xf17b)]
        BrandsAndroid = 37,
        ///<summary>Brands AngelList</summary>
        ///<see href="https://fontawesome.com/icons/angellist?style=brands"/>
        [Description("Brands AngelList"), IconID("fab-angellist"), IconUnicodeGlyph(0xf209)]
        BrandsAngellist = 38,
        ///<summary>Solid Angle Down</summary>
        ///<see href="https://fontawesome.com/icons/angle-down?style=solid"/>
        [Description("Solid Angle Down"), IconID("fas-angle-down"), IconUnicodeGlyph(0xf107)]
        SolidAngleDown = 39,
        ///<summary>Solid Angle Left</summary>
        ///<see href="https://fontawesome.com/icons/angle-left?style=solid"/>
        [Description("Solid Angle Left"), IconID("fas-angle-left"), IconUnicodeGlyph(0xf104)]
        SolidAngleLeft = 40,
        ///<summary>Solid Angle Right</summary>
        ///<see href="https://fontawesome.com/icons/angle-right?style=solid"/>
        [Description("Solid Angle Right"), IconID("fas-angle-right"), IconUnicodeGlyph(0xf105)]
        SolidAngleRight = 41,
        ///<summary>Solid Angle Up</summary>
        ///<see href="https://fontawesome.com/icons/angle-up?style=solid"/>
        [Description("Solid Angle Up"), IconID("fas-angle-up"), IconUnicodeGlyph(0xf106)]
        SolidAngleUp = 42,
        ///<summary>Solid Angles Down</summary>
        ///<see href="https://fontawesome.com/icons/angles-down?style=solid"/>
        [Description("Solid Angles Down"), IconID("fas-angles-down"), IconUnicodeGlyph(0xf103)]
        SolidAnglesDown = 43,
        ///<summary>Solid Angles Left</summary>
        ///<see href="https://fontawesome.com/icons/angles-left?style=solid"/>
        [Description("Solid Angles Left"), IconID("fas-angles-left"), IconUnicodeGlyph(0xf100)]
        SolidAnglesLeft = 44,
        ///<summary>Solid Angles Right</summary>
        ///<see href="https://fontawesome.com/icons/angles-right?style=solid"/>
        [Description("Solid Angles Right"), IconID("fas-angles-right"), IconUnicodeGlyph(0xf101)]
        SolidAnglesRight = 45,
        ///<summary>Solid Angles Up</summary>
        ///<see href="https://fontawesome.com/icons/angles-up?style=solid"/>
        [Description("Solid Angles Up"), IconID("fas-angles-up"), IconUnicodeGlyph(0xf102)]
        SolidAnglesUp = 46,
        ///<summary>Brands Angry Creative</summary>
        ///<see href="https://fontawesome.com/icons/angrycreative?style=brands"/>
        [Description("Brands Angry Creative"), IconID("fab-angrycreative"), IconUnicodeGlyph(0xf36e)]
        BrandsAngrycreative = 47,
        ///<summary>Brands Angular</summary>
        ///<see href="https://fontawesome.com/icons/angular?style=brands"/>
        [Description("Brands Angular"), IconID("fab-angular"), IconUnicodeGlyph(0xf420)]
        BrandsAngular = 48,
        ///<summary>Solid Ankh</summary>
        ///<see href="https://fontawesome.com/icons/ankh?style=solid"/>
        [Description("Solid Ankh"), IconID("fas-ankh"), IconUnicodeGlyph(0xf644)]
        SolidAnkh = 49,
        ///<summary>Brands App Store</summary>
        ///<see href="https://fontawesome.com/icons/app-store?style=brands"/>
        [Description("Brands App Store"), IconID("fab-app-store"), IconUnicodeGlyph(0xf36f)]
        BrandsAppStore = 50,
        ///<summary>Brands iOS App Store</summary>
        ///<see href="https://fontawesome.com/icons/app-store-ios?style=brands"/>
        [Description("Brands iOS App Store"), IconID("fab-app-store-ios"), IconUnicodeGlyph(0xf370)]
        BrandsAppStoreIos = 51,
        ///<summary>Brands Apper Systems AB</summary>
        ///<see href="https://fontawesome.com/icons/apper?style=brands"/>
        [Description("Brands Apper Systems AB"), IconID("fab-apper"), IconUnicodeGlyph(0xf371)]
        BrandsApper = 52,
        ///<summary>Brands Apple</summary>
        ///<see href="https://fontawesome.com/icons/apple?style=brands"/>
        [Description("Brands Apple"), IconID("fab-apple"), IconUnicodeGlyph(0xf179)]
        BrandsApple = 53,
        ///<summary>Brands Apple Pay</summary>
        ///<see href="https://fontawesome.com/icons/apple-pay?style=brands"/>
        [Description("Brands Apple Pay"), IconID("fab-apple-pay"), IconUnicodeGlyph(0xf415)]
        BrandsApplePay = 54,
        ///<summary>Solid Apple Whole</summary>
        ///<see href="https://fontawesome.com/icons/apple-whole?style=solid"/>
        [Description("Solid Apple Whole"), IconID("fas-apple-whole"), IconUnicodeGlyph(0xf5d1)]
        SolidAppleWhole = 55,
        ///<summary>Solid Archway</summary>
        ///<see href="https://fontawesome.com/icons/archway?style=solid"/>
        [Description("Solid Archway"), IconID("fas-archway"), IconUnicodeGlyph(0xf557)]
        SolidArchway = 56,
        ///<summary>Solid Arrow Down</summary>
        ///<see href="https://fontawesome.com/icons/arrow-down?style=solid"/>
        [Description("Solid Arrow Down"), IconID("fas-arrow-down"), IconUnicodeGlyph(0xf063)]
        SolidArrowDown = 57,
        ///<summary>Solid Arrow Down 1 9</summary>
        ///<see href="https://fontawesome.com/icons/arrow-down-1-9?style=solid"/>
        [Description("Solid Arrow Down 1 9"), IconID("fas-arrow-down-1-9"), IconUnicodeGlyph(0xf162)]
        SolidArrowDown19 = 58,
        ///<summary>Solid Arrow Down 9 1</summary>
        ///<see href="https://fontawesome.com/icons/arrow-down-9-1?style=solid"/>
        [Description("Solid Arrow Down 9 1"), IconID("fas-arrow-down-9-1"), IconUnicodeGlyph(0xf886)]
        SolidArrowDown91 = 59,
        ///<summary>Solid Arrow Down A Z</summary>
        ///<see href="https://fontawesome.com/icons/arrow-down-a-z?style=solid"/>
        [Description("Solid Arrow Down A Z"), IconID("fas-arrow-down-a-z"), IconUnicodeGlyph(0xf15d)]
        SolidArrowDownAZ = 60,
        ///<summary>Solid Arrow Down Long</summary>
        ///<see href="https://fontawesome.com/icons/arrow-down-long?style=solid"/>
        [Description("Solid Arrow Down Long"), IconID("fas-arrow-down-long"), IconUnicodeGlyph(0xf175)]
        SolidArrowDownLong = 61,
        ///<summary>Solid Arrow Down Short Wide</summary>
        ///<see href="https://fontawesome.com/icons/arrow-down-short-wide?style=solid"/>
        [Description("Solid Arrow Down Short Wide"), IconID("fas-arrow-down-short-wide"), IconUnicodeGlyph(0xf884)]
        SolidArrowDownShortWide = 62,
        ///<summary>Solid Arrow Down Up Across Line</summary>
        ///<see href="https://fontawesome.com/icons/arrow-down-up-across-line?style=solid"/>
        [Description("Solid Arrow Down Up Across Line"), IconID("fas-arrow-down-up-across-line"), IconUnicodeGlyph(0xe4af)]
        SolidArrowDownUpAcrossLine = 63,
        ///<summary>Solid Arrow Down Up Lock</summary>
        ///<see href="https://fontawesome.com/icons/arrow-down-up-lock?style=solid"/>
        [Description("Solid Arrow Down Up Lock"), IconID("fas-arrow-down-up-lock"), IconUnicodeGlyph(0xe4b0)]
        SolidArrowDownUpLock = 64,
        ///<summary>Solid Arrow Down Wide Short</summary>
        ///<see href="https://fontawesome.com/icons/arrow-down-wide-short?style=solid"/>
        [Description("Solid Arrow Down Wide Short"), IconID("fas-arrow-down-wide-short"), IconUnicodeGlyph(0xf160)]
        SolidArrowDownWideShort = 65,
        ///<summary>Solid Arrow Down Z A</summary>
        ///<see href="https://fontawesome.com/icons/arrow-down-z-a?style=solid"/>
        [Description("Solid Arrow Down Z A"), IconID("fas-arrow-down-z-a"), IconUnicodeGlyph(0xf881)]
        SolidArrowDownZA = 66,
        ///<summary>Solid Arrow Left</summary>
        ///<see href="https://fontawesome.com/icons/arrow-left?style=solid"/>
        [Description("Solid Arrow Left"), IconID("fas-arrow-left"), IconUnicodeGlyph(0xf060)]
        SolidArrowLeft = 67,
        ///<summary>Solid Arrow Left Long</summary>
        ///<see href="https://fontawesome.com/icons/arrow-left-long?style=solid"/>
        [Description("Solid Arrow Left Long"), IconID("fas-arrow-left-long"), IconUnicodeGlyph(0xf177)]
        SolidArrowLeftLong = 68,
        ///<summary>Solid Arrow Pointer</summary>
        ///<see href="https://fontawesome.com/icons/arrow-pointer?style=solid"/>
        [Description("Solid Arrow Pointer"), IconID("fas-arrow-pointer"), IconUnicodeGlyph(0xf245)]
        SolidArrowPointer = 69,
        ///<summary>Solid Arrow Right</summary>
        ///<see href="https://fontawesome.com/icons/arrow-right?style=solid"/>
        [Description("Solid Arrow Right"), IconID("fas-arrow-right"), IconUnicodeGlyph(0xf061)]
        SolidArrowRight = 70,
        ///<summary>Solid Arrow Right Arrow Left</summary>
        ///<see href="https://fontawesome.com/icons/arrow-right-arrow-left?style=solid"/>
        [Description("Solid Arrow Right Arrow Left"), IconID("fas-arrow-right-arrow-left"), IconUnicodeGlyph(0xf0ec)]
        SolidArrowRightArrowLeft = 71,
        ///<summary>Solid Arrow Right From Bracket</summary>
        ///<see href="https://fontawesome.com/icons/arrow-right-from-bracket?style=solid"/>
        [Description("Solid Arrow Right From Bracket"), IconID("fas-arrow-right-from-bracket"), IconUnicodeGlyph(0xf08b)]
        SolidArrowRightFromBracket = 72,
        ///<summary>Solid Arrow Right Long</summary>
        ///<see href="https://fontawesome.com/icons/arrow-right-long?style=solid"/>
        [Description("Solid Arrow Right Long"), IconID("fas-arrow-right-long"), IconUnicodeGlyph(0xf178)]
        SolidArrowRightLong = 73,
        ///<summary>Solid Arrow Right To Bracket</summary>
        ///<see href="https://fontawesome.com/icons/arrow-right-to-bracket?style=solid"/>
        [Description("Solid Arrow Right To Bracket"), IconID("fas-arrow-right-to-bracket"), IconUnicodeGlyph(0xf090)]
        SolidArrowRightToBracket = 74,
        ///<summary>Solid Arrow Right To City</summary>
        ///<see href="https://fontawesome.com/icons/arrow-right-to-city?style=solid"/>
        [Description("Solid Arrow Right To City"), IconID("fas-arrow-right-to-city"), IconUnicodeGlyph(0xe4b3)]
        SolidArrowRightToCity = 75,
        ///<summary>Solid Arrow Rotate Left</summary>
        ///<see href="https://fontawesome.com/icons/arrow-rotate-left?style=solid"/>
        [Description("Solid Arrow Rotate Left"), IconID("fas-arrow-rotate-left"), IconUnicodeGlyph(0xf0e2)]
        SolidArrowRotateLeft = 76,
        ///<summary>Solid Arrow Rotate Right</summary>
        ///<see href="https://fontawesome.com/icons/arrow-rotate-right?style=solid"/>
        [Description("Solid Arrow Rotate Right"), IconID("fas-arrow-rotate-right"), IconUnicodeGlyph(0xf01e)]
        SolidArrowRotateRight = 77,
        ///<summary>Solid Arrow Trend Down</summary>
        ///<see href="https://fontawesome.com/icons/arrow-trend-down?style=solid"/>
        [Description("Solid Arrow Trend Down"), IconID("fas-arrow-trend-down"), IconUnicodeGlyph(0xe097)]
        SolidArrowTrendDown = 78,
        ///<summary>Solid Arrow Trend Up</summary>
        ///<see href="https://fontawesome.com/icons/arrow-trend-up?style=solid"/>
        [Description("Solid Arrow Trend Up"), IconID("fas-arrow-trend-up"), IconUnicodeGlyph(0xe098)]
        SolidArrowTrendUp = 79,
        ///<summary>Solid Arrow Turn Down</summary>
        ///<see href="https://fontawesome.com/icons/arrow-turn-down?style=solid"/>
        [Description("Solid Arrow Turn Down"), IconID("fas-arrow-turn-down"), IconUnicodeGlyph(0xf149)]
        SolidArrowTurnDown = 80,
        ///<summary>Solid Arrow Turn Up</summary>
        ///<see href="https://fontawesome.com/icons/arrow-turn-up?style=solid"/>
        [Description("Solid Arrow Turn Up"), IconID("fas-arrow-turn-up"), IconUnicodeGlyph(0xf148)]
        SolidArrowTurnUp = 81,
        ///<summary>Solid Arrow Up</summary>
        ///<see href="https://fontawesome.com/icons/arrow-up?style=solid"/>
        [Description("Solid Arrow Up"), IconID("fas-arrow-up"), IconUnicodeGlyph(0xf062)]
        SolidArrowUp = 82,
        ///<summary>Solid Arrow Up 1 9</summary>
        ///<see href="https://fontawesome.com/icons/arrow-up-1-9?style=solid"/>
        [Description("Solid Arrow Up 1 9"), IconID("fas-arrow-up-1-9"), IconUnicodeGlyph(0xf163)]
        SolidArrowUp19 = 83,
        ///<summary>Solid Arrow Up 9 1</summary>
        ///<see href="https://fontawesome.com/icons/arrow-up-9-1?style=solid"/>
        [Description("Solid Arrow Up 9 1"), IconID("fas-arrow-up-9-1"), IconUnicodeGlyph(0xf887)]
        SolidArrowUp91 = 84,
        ///<summary>Solid Arrow Up A Z</summary>
        ///<see href="https://fontawesome.com/icons/arrow-up-a-z?style=solid"/>
        [Description("Solid Arrow Up A Z"), IconID("fas-arrow-up-a-z"), IconUnicodeGlyph(0xf15e)]
        SolidArrowUpAZ = 85,
        ///<summary>Solid Arrow Up From Bracket</summary>
        ///<see href="https://fontawesome.com/icons/arrow-up-from-bracket?style=solid"/>
        [Description("Solid Arrow Up From Bracket"), IconID("fas-arrow-up-from-bracket"), IconUnicodeGlyph(0xe09a)]
        SolidArrowUpFromBracket = 86,
        ///<summary>Solid Arrow Up From Ground Water</summary>
        ///<see href="https://fontawesome.com/icons/arrow-up-from-ground-water?style=solid"/>
        [Description("Solid Arrow Up From Ground Water"), IconID("fas-arrow-up-from-ground-water"), IconUnicodeGlyph(0xe4b5)]
        SolidArrowUpFromGroundWater = 87,
        ///<summary>Solid Arrow Up From Water Pump</summary>
        ///<see href="https://fontawesome.com/icons/arrow-up-from-water-pump?style=solid"/>
        [Description("Solid Arrow Up From Water Pump"), IconID("fas-arrow-up-from-water-pump"), IconUnicodeGlyph(0xe4b6)]
        SolidArrowUpFromWaterPump = 88,
        ///<summary>Solid Arrow Up Long</summary>
        ///<see href="https://fontawesome.com/icons/arrow-up-long?style=solid"/>
        [Description("Solid Arrow Up Long"), IconID("fas-arrow-up-long"), IconUnicodeGlyph(0xf176)]
        SolidArrowUpLong = 89,
        ///<summary>Solid Arrow Up Right Dots</summary>
        ///<see href="https://fontawesome.com/icons/arrow-up-right-dots?style=solid"/>
        [Description("Solid Arrow Up Right Dots"), IconID("fas-arrow-up-right-dots"), IconUnicodeGlyph(0xe4b7)]
        SolidArrowUpRightDots = 90,
        ///<summary>Solid Arrow Up Right From Square</summary>
        ///<see href="https://fontawesome.com/icons/arrow-up-right-from-square?style=solid"/>
        [Description("Solid Arrow Up Right From Square"), IconID("fas-arrow-up-right-from-square"), IconUnicodeGlyph(0xf08e)]
        SolidArrowUpRightFromSquare = 91,
        ///<summary>Solid Arrow Up Short Wide</summary>
        ///<see href="https://fontawesome.com/icons/arrow-up-short-wide?style=solid"/>
        [Description("Solid Arrow Up Short Wide"), IconID("fas-arrow-up-short-wide"), IconUnicodeGlyph(0xf885)]
        SolidArrowUpShortWide = 92,
        ///<summary>Solid Arrow Up Wide Short</summary>
        ///<see href="https://fontawesome.com/icons/arrow-up-wide-short?style=solid"/>
        [Description("Solid Arrow Up Wide Short"), IconID("fas-arrow-up-wide-short"), IconUnicodeGlyph(0xf161)]
        SolidArrowUpWideShort = 93,
        ///<summary>Solid Arrow Up Z A</summary>
        ///<see href="https://fontawesome.com/icons/arrow-up-z-a?style=solid"/>
        [Description("Solid Arrow Up Z A"), IconID("fas-arrow-up-z-a"), IconUnicodeGlyph(0xf882)]
        SolidArrowUpZA = 94,
        ///<summary>Solid Arrows Down To Line</summary>
        ///<see href="https://fontawesome.com/icons/arrows-down-to-line?style=solid"/>
        [Description("Solid Arrows Down To Line"), IconID("fas-arrows-down-to-line"), IconUnicodeGlyph(0xe4b8)]
        SolidArrowsDownToLine = 95,
        ///<summary>Solid Arrows Down To People</summary>
        ///<see href="https://fontawesome.com/icons/arrows-down-to-people?style=solid"/>
        [Description("Solid Arrows Down To People"), IconID("fas-arrows-down-to-people"), IconUnicodeGlyph(0xe4b9)]
        SolidArrowsDownToPeople = 96,
        ///<summary>Solid Arrows Left Right</summary>
        ///<see href="https://fontawesome.com/icons/arrows-left-right?style=solid"/>
        [Description("Solid Arrows Left Right"), IconID("fas-arrows-left-right"), IconUnicodeGlyph(0xf07e)]
        SolidArrowsLeftRight = 97,
        ///<summary>Solid Arrows Left Right To Line</summary>
        ///<see href="https://fontawesome.com/icons/arrows-left-right-to-line?style=solid"/>
        [Description("Solid Arrows Left Right To Line"), IconID("fas-arrows-left-right-to-line"), IconUnicodeGlyph(0xe4ba)]
        SolidArrowsLeftRightToLine = 98,
        ///<summary>Solid Arrows Rotate</summary>
        ///<see href="https://fontawesome.com/icons/arrows-rotate?style=solid"/>
        [Description("Solid Arrows Rotate"), IconID("fas-arrows-rotate"), IconUnicodeGlyph(0xf021)]
        SolidArrowsRotate = 99,
        ///<summary>Solid Arrows Spin</summary>
        ///<see href="https://fontawesome.com/icons/arrows-spin?style=solid"/>
        [Description("Solid Arrows Spin"), IconID("fas-arrows-spin"), IconUnicodeGlyph(0xe4bb)]
        SolidArrowsSpin = 100,
        ///<summary>Solid Arrows Split Up And Left</summary>
        ///<see href="https://fontawesome.com/icons/arrows-split-up-and-left?style=solid"/>
        [Description("Solid Arrows Split Up And Left"), IconID("fas-arrows-split-up-and-left"), IconUnicodeGlyph(0xe4bc)]
        SolidArrowsSplitUpAndLeft = 101,
        ///<summary>Solid Arrows To Circle</summary>
        ///<see href="https://fontawesome.com/icons/arrows-to-circle?style=solid"/>
        [Description("Solid Arrows To Circle"), IconID("fas-arrows-to-circle"), IconUnicodeGlyph(0xe4bd)]
        SolidArrowsToCircle = 102,
        ///<summary>Solid Arrows To Dot</summary>
        ///<see href="https://fontawesome.com/icons/arrows-to-dot?style=solid"/>
        [Description("Solid Arrows To Dot"), IconID("fas-arrows-to-dot"), IconUnicodeGlyph(0xe4be)]
        SolidArrowsToDot = 103,
        ///<summary>Solid Arrows To Eye</summary>
        ///<see href="https://fontawesome.com/icons/arrows-to-eye?style=solid"/>
        [Description("Solid Arrows To Eye"), IconID("fas-arrows-to-eye"), IconUnicodeGlyph(0xe4bf)]
        SolidArrowsToEye = 104,
        ///<summary>Solid Arrows Turn Right</summary>
        ///<see href="https://fontawesome.com/icons/arrows-turn-right?style=solid"/>
        [Description("Solid Arrows Turn Right"), IconID("fas-arrows-turn-right"), IconUnicodeGlyph(0xe4c0)]
        SolidArrowsTurnRight = 105,
        ///<summary>Solid Arrows Turn To Dots</summary>
        ///<see href="https://fontawesome.com/icons/arrows-turn-to-dots?style=solid"/>
        [Description("Solid Arrows Turn To Dots"), IconID("fas-arrows-turn-to-dots"), IconUnicodeGlyph(0xe4c1)]
        SolidArrowsTurnToDots = 106,
        ///<summary>Solid Arrows Up Down</summary>
        ///<see href="https://fontawesome.com/icons/arrows-up-down?style=solid"/>
        [Description("Solid Arrows Up Down"), IconID("fas-arrows-up-down"), IconUnicodeGlyph(0xf07d)]
        SolidArrowsUpDown = 107,
        ///<summary>Solid Arrows Up Down Left Right</summary>
        ///<see href="https://fontawesome.com/icons/arrows-up-down-left-right?style=solid"/>
        [Description("Solid Arrows Up Down Left Right"), IconID("fas-arrows-up-down-left-right"), IconUnicodeGlyph(0xf047)]
        SolidArrowsUpDownLeftRight = 108,
        ///<summary>Solid Arrows Up To Line</summary>
        ///<see href="https://fontawesome.com/icons/arrows-up-to-line?style=solid"/>
        [Description("Solid Arrows Up To Line"), IconID("fas-arrows-up-to-line"), IconUnicodeGlyph(0xe4c2)]
        SolidArrowsUpToLine = 109,
        ///<summary>Brands Artstation</summary>
        ///<see href="https://fontawesome.com/icons/artstation?style=brands"/>
        [Description("Brands Artstation"), IconID("fab-artstation"), IconUnicodeGlyph(0xf77a)]
        BrandsArtstation = 110,
        ///<summary>Solid Asterisk</summary>
        ///<see href="https://fontawesome.com/icons/asterisk?style=solid"/>
        [Description("Solid Asterisk"), IconID("fas-asterisk"), IconUnicodeGlyph(0x2a)]
        SolidAsterisk = 111,
        ///<summary>Brands Asymmetrik, Ltd.</summary>
        ///<see href="https://fontawesome.com/icons/asymmetrik?style=brands"/>
        [Description("Brands Asymmetrik, Ltd."), IconID("fab-asymmetrik"), IconUnicodeGlyph(0xf372)]
        BrandsAsymmetrik = 112,
        ///<summary>Solid At</summary>
        ///<see href="https://fontawesome.com/icons/at?style=solid"/>
        [Description("Solid At"), IconID("fas-at"), IconUnicodeGlyph(0x40)]
        SolidAt = 113,
        ///<summary>Brands Atlassian</summary>
        ///<see href="https://fontawesome.com/icons/atlassian?style=brands"/>
        [Description("Brands Atlassian"), IconID("fab-atlassian"), IconUnicodeGlyph(0xf77b)]
        BrandsAtlassian = 114,
        ///<summary>Solid Atom</summary>
        ///<see href="https://fontawesome.com/icons/atom?style=solid"/>
        [Description("Solid Atom"), IconID("fas-atom"), IconUnicodeGlyph(0xf5d2)]
        SolidAtom = 115,
        ///<summary>Brands Audible</summary>
        ///<see href="https://fontawesome.com/icons/audible?style=brands"/>
        [Description("Brands Audible"), IconID("fab-audible"), IconUnicodeGlyph(0xf373)]
        BrandsAudible = 116,
        ///<summary>Solid Audio Description</summary>
        ///<see href="https://fontawesome.com/icons/audio-description?style=solid"/>
        [Description("Solid Audio Description"), IconID("fas-audio-description"), IconUnicodeGlyph(0xf29e)]
        SolidAudioDescription = 117,
        ///<summary>Solid Austral Sign</summary>
        ///<see href="https://fontawesome.com/icons/austral-sign?style=solid"/>
        [Description("Solid Austral Sign"), IconID("fas-austral-sign"), IconUnicodeGlyph(0xe0a9)]
        SolidAustralSign = 118,
        ///<summary>Brands Autoprefixer</summary>
        ///<see href="https://fontawesome.com/icons/autoprefixer?style=brands"/>
        [Description("Brands Autoprefixer"), IconID("fab-autoprefixer"), IconUnicodeGlyph(0xf41c)]
        BrandsAutoprefixer = 119,
        ///<summary>Brands avianex</summary>
        ///<see href="https://fontawesome.com/icons/avianex?style=brands"/>
        [Description("Brands avianex"), IconID("fab-avianex"), IconUnicodeGlyph(0xf374)]
        BrandsAvianex = 120,
        ///<summary>Brands Aviato</summary>
        ///<see href="https://fontawesome.com/icons/aviato?style=brands"/>
        [Description("Brands Aviato"), IconID("fab-aviato"), IconUnicodeGlyph(0xf421)]
        BrandsAviato = 121,
        ///<summary>Solid Award</summary>
        ///<see href="https://fontawesome.com/icons/award?style=solid"/>
        [Description("Solid Award"), IconID("fas-award"), IconUnicodeGlyph(0xf559)]
        SolidAward = 122,
        ///<summary>Brands Amazon Web Services (AWS)</summary>
        ///<see href="https://fontawesome.com/icons/aws?style=brands"/>
        [Description("Brands Amazon Web Services (AWS)"), IconID("fab-aws"), IconUnicodeGlyph(0xf375)]
        BrandsAws = 123,
        ///<summary>Solid B</summary>
        ///<see href="https://fontawesome.com/icons/b?style=solid"/>
        [Description("Solid B"), IconID("fas-b"), IconUnicodeGlyph(0x42)]
        SolidB = 124,
        ///<summary>Solid Baby</summary>
        ///<see href="https://fontawesome.com/icons/baby?style=solid"/>
        [Description("Solid Baby"), IconID("fas-baby"), IconUnicodeGlyph(0xf77c)]
        SolidBaby = 125,
        ///<summary>Solid Baby Carriage</summary>
        ///<see href="https://fontawesome.com/icons/baby-carriage?style=solid"/>
        [Description("Solid Baby Carriage"), IconID("fas-baby-carriage"), IconUnicodeGlyph(0xf77d)]
        SolidBabyCarriage = 126,
        ///<summary>Solid Backward</summary>
        ///<see href="https://fontawesome.com/icons/backward?style=solid"/>
        [Description("Solid Backward"), IconID("fas-backward"), IconUnicodeGlyph(0xf04a)]
        SolidBackward = 127,
        ///<summary>Solid Backward Fast</summary>
        ///<see href="https://fontawesome.com/icons/backward-fast?style=solid"/>
        [Description("Solid Backward Fast"), IconID("fas-backward-fast"), IconUnicodeGlyph(0xf049)]
        SolidBackwardFast = 128,
        ///<summary>Solid Backward Step</summary>
        ///<see href="https://fontawesome.com/icons/backward-step?style=solid"/>
        [Description("Solid Backward Step"), IconID("fas-backward-step"), IconUnicodeGlyph(0xf048)]
        SolidBackwardStep = 129,
        ///<summary>Solid Bacon</summary>
        ///<see href="https://fontawesome.com/icons/bacon?style=solid"/>
        [Description("Solid Bacon"), IconID("fas-bacon"), IconUnicodeGlyph(0xf7e5)]
        SolidBacon = 130,
        ///<summary>Solid Bacteria</summary>
        ///<see href="https://fontawesome.com/icons/bacteria?style=solid"/>
        [Description("Solid Bacteria"), IconID("fas-bacteria"), IconUnicodeGlyph(0xe059)]
        SolidBacteria = 131,
        ///<summary>Solid Bacterium</summary>
        ///<see href="https://fontawesome.com/icons/bacterium?style=solid"/>
        [Description("Solid Bacterium"), IconID("fas-bacterium"), IconUnicodeGlyph(0xe05a)]
        SolidBacterium = 132,
        ///<summary>Solid Bag Shopping</summary>
        ///<see href="https://fontawesome.com/icons/bag-shopping?style=solid"/>
        [Description("Solid Bag Shopping"), IconID("fas-bag-shopping"), IconUnicodeGlyph(0xf290)]
        SolidBagShopping = 133,
        ///<summary>Solid Bahai</summary>
        ///<see href="https://fontawesome.com/icons/bahai?style=solid"/>
        [Description("Solid Bahai"), IconID("fas-bahai"), IconUnicodeGlyph(0xf666)]
        SolidBahai = 134,
        ///<summary>Solid Baht Sign</summary>
        ///<see href="https://fontawesome.com/icons/baht-sign?style=solid"/>
        [Description("Solid Baht Sign"), IconID("fas-baht-sign"), IconUnicodeGlyph(0xe0ac)]
        SolidBahtSign = 135,
        ///<summary>Solid Ban</summary>
        ///<see href="https://fontawesome.com/icons/ban?style=solid"/>
        [Description("Solid Ban"), IconID("fas-ban"), IconUnicodeGlyph(0xf05e)]
        SolidBan = 136,
        ///<summary>Solid Ban Smoking</summary>
        ///<see href="https://fontawesome.com/icons/ban-smoking?style=solid"/>
        [Description("Solid Ban Smoking"), IconID("fas-ban-smoking"), IconUnicodeGlyph(0xf54d)]
        SolidBanSmoking = 137,
        ///<summary>Solid Bandage</summary>
        ///<see href="https://fontawesome.com/icons/bandage?style=solid"/>
        [Description("Solid Bandage"), IconID("fas-bandage"), IconUnicodeGlyph(0xf462)]
        SolidBandage = 138,
        ///<summary>Brands Bandcamp</summary>
        ///<see href="https://fontawesome.com/icons/bandcamp?style=brands"/>
        [Description("Brands Bandcamp"), IconID("fab-bandcamp"), IconUnicodeGlyph(0xf2d5)]
        BrandsBandcamp = 139,
        ///<summary>Solid Bangladeshi Taka Sign</summary>
        ///<see href="https://fontawesome.com/icons/bangladeshi-taka-sign?style=solid"/>
        [Description("Solid Bangladeshi Taka Sign"), IconID("fas-bangladeshi-taka-sign"), IconUnicodeGlyph(0xe2e6)]
        SolidBangladeshiTakaSign = 140,
        ///<summary>Solid Barcode</summary>
        ///<see href="https://fontawesome.com/icons/barcode?style=solid"/>
        [Description("Solid Barcode"), IconID("fas-barcode"), IconUnicodeGlyph(0xf02a)]
        SolidBarcode = 141,
        ///<summary>Solid Bars</summary>
        ///<see href="https://fontawesome.com/icons/bars?style=solid"/>
        [Description("Solid Bars"), IconID("fas-bars"), IconUnicodeGlyph(0xf0c9)]
        SolidBars = 142,
        ///<summary>Solid Bars Progress</summary>
        ///<see href="https://fontawesome.com/icons/bars-progress?style=solid"/>
        [Description("Solid Bars Progress"), IconID("fas-bars-progress"), IconUnicodeGlyph(0xf828)]
        SolidBarsProgress = 143,
        ///<summary>Solid Bars Staggered</summary>
        ///<see href="https://fontawesome.com/icons/bars-staggered?style=solid"/>
        [Description("Solid Bars Staggered"), IconID("fas-bars-staggered"), IconUnicodeGlyph(0xf550)]
        SolidBarsStaggered = 144,
        ///<summary>Solid Baseball</summary>
        ///<see href="https://fontawesome.com/icons/baseball?style=solid"/>
        [Description("Solid Baseball"), IconID("fas-baseball"), IconUnicodeGlyph(0xf433)]
        SolidBaseball = 145,
        ///<summary>Solid Baseball Bat Ball</summary>
        ///<see href="https://fontawesome.com/icons/baseball-bat-ball?style=solid"/>
        [Description("Solid Baseball Bat Ball"), IconID("fas-baseball-bat-ball"), IconUnicodeGlyph(0xf432)]
        SolidBaseballBatBall = 146,
        ///<summary>Solid Basket Shopping</summary>
        ///<see href="https://fontawesome.com/icons/basket-shopping?style=solid"/>
        [Description("Solid Basket Shopping"), IconID("fas-basket-shopping"), IconUnicodeGlyph(0xf291)]
        SolidBasketShopping = 147,
        ///<summary>Solid Basketball</summary>
        ///<see href="https://fontawesome.com/icons/basketball?style=solid"/>
        [Description("Solid Basketball"), IconID("fas-basketball"), IconUnicodeGlyph(0xf434)]
        SolidBasketball = 148,
        ///<summary>Solid Bath</summary>
        ///<see href="https://fontawesome.com/icons/bath?style=solid"/>
        [Description("Solid Bath"), IconID("fas-bath"), IconUnicodeGlyph(0xf2cd)]
        SolidBath = 149,
        ///<summary>Solid Battery Empty</summary>
        ///<see href="https://fontawesome.com/icons/battery-empty?style=solid"/>
        [Description("Solid Battery Empty"), IconID("fas-battery-empty"), IconUnicodeGlyph(0xf244)]
        SolidBatteryEmpty = 150,
        ///<summary>Solid Battery Full</summary>
        ///<see href="https://fontawesome.com/icons/battery-full?style=solid"/>
        [Description("Solid Battery Full"), IconID("fas-battery-full"), IconUnicodeGlyph(0xf240)]
        SolidBatteryFull = 151,
        ///<summary>Solid Battery Half</summary>
        ///<see href="https://fontawesome.com/icons/battery-half?style=solid"/>
        [Description("Solid Battery Half"), IconID("fas-battery-half"), IconUnicodeGlyph(0xf242)]
        SolidBatteryHalf = 152,
        ///<summary>Solid Battery Quarter</summary>
        ///<see href="https://fontawesome.com/icons/battery-quarter?style=solid"/>
        [Description("Solid Battery Quarter"), IconID("fas-battery-quarter"), IconUnicodeGlyph(0xf243)]
        SolidBatteryQuarter = 153,
        ///<summary>Solid Battery Three Quarters</summary>
        ///<see href="https://fontawesome.com/icons/battery-three-quarters?style=solid"/>
        [Description("Solid Battery Three Quarters"), IconID("fas-battery-three-quarters"), IconUnicodeGlyph(0xf241)]
        SolidBatteryThreeQuarters = 154,
        ///<summary>Brands Battle.net</summary>
        ///<see href="https://fontawesome.com/icons/battle-net?style=brands"/>
        [Description("Brands Battle.net"), IconID("fab-battle-net"), IconUnicodeGlyph(0xf835)]
        BrandsBattleNet = 155,
        ///<summary>Solid Bed</summary>
        ///<see href="https://fontawesome.com/icons/bed?style=solid"/>
        [Description("Solid Bed"), IconID("fas-bed"), IconUnicodeGlyph(0xf236)]
        SolidBed = 156,
        ///<summary>Solid Bed Pulse</summary>
        ///<see href="https://fontawesome.com/icons/bed-pulse?style=solid"/>
        [Description("Solid Bed Pulse"), IconID("fas-bed-pulse"), IconUnicodeGlyph(0xf487)]
        SolidBedPulse = 157,
        ///<summary>Solid Beer Mug Empty</summary>
        ///<see href="https://fontawesome.com/icons/beer-mug-empty?style=solid"/>
        [Description("Solid Beer Mug Empty"), IconID("fas-beer-mug-empty"), IconUnicodeGlyph(0xf0fc)]
        SolidBeerMugEmpty = 158,
        ///<summary>Brands Behance</summary>
        ///<see href="https://fontawesome.com/icons/behance?style=brands"/>
        [Description("Brands Behance"), IconID("fab-behance"), IconUnicodeGlyph(0xf1b4)]
        BrandsBehance = 159,
        ///<summary>Solid Bell</summary>
        ///<see href="https://fontawesome.com/icons/bell?style=solid"/>
        [Description("Solid Bell"), IconID("fas-bell"), IconUnicodeGlyph(0xf0f3)]
        SolidBell = 160,
        ///<summary>Regular Bell</summary>
        ///<see href="https://fontawesome.com/icons/bell?style=regular"/>
        [Description("Regular Bell"), IconID("far-bell"), IconUnicodeGlyph(0xf0f3)]
        RegularBell = 161,
        ///<summary>Solid Bell Concierge</summary>
        ///<see href="https://fontawesome.com/icons/bell-concierge?style=solid"/>
        [Description("Solid Bell Concierge"), IconID("fas-bell-concierge"), IconUnicodeGlyph(0xf562)]
        SolidBellConcierge = 162,
        ///<summary>Solid Bell Slash</summary>
        ///<see href="https://fontawesome.com/icons/bell-slash?style=solid"/>
        [Description("Solid Bell Slash"), IconID("fas-bell-slash"), IconUnicodeGlyph(0xf1f6)]
        SolidBellSlash = 163,
        ///<summary>Regular Bell Slash</summary>
        ///<see href="https://fontawesome.com/icons/bell-slash?style=regular"/>
        [Description("Regular Bell Slash"), IconID("far-bell-slash"), IconUnicodeGlyph(0xf1f6)]
        RegularBellSlash = 164,
        ///<summary>Solid Bezier Curve</summary>
        ///<see href="https://fontawesome.com/icons/bezier-curve?style=solid"/>
        [Description("Solid Bezier Curve"), IconID("fas-bezier-curve"), IconUnicodeGlyph(0xf55b)]
        SolidBezierCurve = 165,
        ///<summary>Solid Bicycle</summary>
        ///<see href="https://fontawesome.com/icons/bicycle?style=solid"/>
        [Description("Solid Bicycle"), IconID("fas-bicycle"), IconUnicodeGlyph(0xf206)]
        SolidBicycle = 166,
        ///<summary>Brands Bilibili</summary>
        ///<see href="https://fontawesome.com/icons/bilibili?style=brands"/>
        [Description("Brands Bilibili"), IconID("fab-bilibili"), IconUnicodeGlyph(0xe3d9)]
        BrandsBilibili = 167,
        ///<summary>Brands BIMobject</summary>
        ///<see href="https://fontawesome.com/icons/bimobject?style=brands"/>
        [Description("Brands BIMobject"), IconID("fab-bimobject"), IconUnicodeGlyph(0xf378)]
        BrandsBimobject = 168,
        ///<summary>Solid Binoculars</summary>
        ///<see href="https://fontawesome.com/icons/binoculars?style=solid"/>
        [Description("Solid Binoculars"), IconID("fas-binoculars"), IconUnicodeGlyph(0xf1e5)]
        SolidBinoculars = 169,
        ///<summary>Solid Biohazard</summary>
        ///<see href="https://fontawesome.com/icons/biohazard?style=solid"/>
        [Description("Solid Biohazard"), IconID("fas-biohazard"), IconUnicodeGlyph(0xf780)]
        SolidBiohazard = 170,
        ///<summary>Brands Bitbucket</summary>
        ///<see href="https://fontawesome.com/icons/bitbucket?style=brands"/>
        [Description("Brands Bitbucket"), IconID("fab-bitbucket"), IconUnicodeGlyph(0xf171)]
        BrandsBitbucket = 171,
        ///<summary>Brands Bitcoin</summary>
        ///<see href="https://fontawesome.com/icons/bitcoin?style=brands"/>
        [Description("Brands Bitcoin"), IconID("fab-bitcoin"), IconUnicodeGlyph(0xf379)]
        BrandsBitcoin = 172,
        ///<summary>Solid Bitcoin Sign</summary>
        ///<see href="https://fontawesome.com/icons/bitcoin-sign?style=solid"/>
        [Description("Solid Bitcoin Sign"), IconID("fas-bitcoin-sign"), IconUnicodeGlyph(0xe0b4)]
        SolidBitcoinSign = 173,
        ///<summary>Brands Bity</summary>
        ///<see href="https://fontawesome.com/icons/bity?style=brands"/>
        [Description("Brands Bity"), IconID("fab-bity"), IconUnicodeGlyph(0xf37a)]
        BrandsBity = 174,
        ///<summary>Brands Font Awesome Black Tie</summary>
        ///<see href="https://fontawesome.com/icons/black-tie?style=brands"/>
        [Description("Brands Font Awesome Black Tie"), IconID("fab-black-tie"), IconUnicodeGlyph(0xf27e)]
        BrandsBlackTie = 175,
        ///<summary>Brands BlackBerry</summary>
        ///<see href="https://fontawesome.com/icons/blackberry?style=brands"/>
        [Description("Brands BlackBerry"), IconID("fab-blackberry"), IconUnicodeGlyph(0xf37b)]
        BrandsBlackberry = 176,
        ///<summary>Solid Blender</summary>
        ///<see href="https://fontawesome.com/icons/blender?style=solid"/>
        [Description("Solid Blender"), IconID("fas-blender"), IconUnicodeGlyph(0xf517)]
        SolidBlender = 177,
        ///<summary>Solid Blender Phone</summary>
        ///<see href="https://fontawesome.com/icons/blender-phone?style=solid"/>
        [Description("Solid Blender Phone"), IconID("fas-blender-phone"), IconUnicodeGlyph(0xf6b6)]
        SolidBlenderPhone = 178,
        ///<summary>Solid Blog</summary>
        ///<see href="https://fontawesome.com/icons/blog?style=solid"/>
        [Description("Solid Blog"), IconID("fas-blog"), IconUnicodeGlyph(0xf781)]
        SolidBlog = 179,
        ///<summary>Brands Blogger</summary>
        ///<see href="https://fontawesome.com/icons/blogger?style=brands"/>
        [Description("Brands Blogger"), IconID("fab-blogger"), IconUnicodeGlyph(0xf37c)]
        BrandsBlogger = 180,
        ///<summary>Brands Blogger B</summary>
        ///<see href="https://fontawesome.com/icons/blogger-b?style=brands"/>
        [Description("Brands Blogger B"), IconID("fab-blogger-b"), IconUnicodeGlyph(0xf37d)]
        BrandsBloggerB = 181,
        ///<summary>Brands Bluesky</summary>
        ///<see href="https://fontawesome.com/icons/bluesky?style=brands"/>
        [Description("Brands Bluesky"), IconID("fab-bluesky"), IconUnicodeGlyph(0xe671)]
        BrandsBluesky = 182,
        ///<summary>Brands Bluetooth</summary>
        ///<see href="https://fontawesome.com/icons/bluetooth?style=brands"/>
        [Description("Brands Bluetooth"), IconID("fab-bluetooth"), IconUnicodeGlyph(0xf293)]
        BrandsBluetooth = 183,
        ///<summary>Brands Bluetooth</summary>
        ///<see href="https://fontawesome.com/icons/bluetooth-b?style=brands"/>
        [Description("Brands Bluetooth"), IconID("fab-bluetooth-b"), IconUnicodeGlyph(0xf294)]
        BrandsBluetoothB = 184,
        ///<summary>Solid Bold</summary>
        ///<see href="https://fontawesome.com/icons/bold?style=solid"/>
        [Description("Solid Bold"), IconID("fas-bold"), IconUnicodeGlyph(0xf032)]
        SolidBold = 185,
        ///<summary>Solid Bolt</summary>
        ///<see href="https://fontawesome.com/icons/bolt?style=solid"/>
        [Description("Solid Bolt"), IconID("fas-bolt"), IconUnicodeGlyph(0xf0e7)]
        SolidBolt = 186,
        ///<summary>Solid Bolt Lightning</summary>
        ///<see href="https://fontawesome.com/icons/bolt-lightning?style=solid"/>
        [Description("Solid Bolt Lightning"), IconID("fas-bolt-lightning"), IconUnicodeGlyph(0xe0b7)]
        SolidBoltLightning = 187,
        ///<summary>Solid Bomb</summary>
        ///<see href="https://fontawesome.com/icons/bomb?style=solid"/>
        [Description("Solid Bomb"), IconID("fas-bomb"), IconUnicodeGlyph(0xf1e2)]
        SolidBomb = 188,
        ///<summary>Solid Bone</summary>
        ///<see href="https://fontawesome.com/icons/bone?style=solid"/>
        [Description("Solid Bone"), IconID("fas-bone"), IconUnicodeGlyph(0xf5d7)]
        SolidBone = 189,
        ///<summary>Solid Bong</summary>
        ///<see href="https://fontawesome.com/icons/bong?style=solid"/>
        [Description("Solid Bong"), IconID("fas-bong"), IconUnicodeGlyph(0xf55c)]
        SolidBong = 190,
        ///<summary>Solid Book</summary>
        ///<see href="https://fontawesome.com/icons/book?style=solid"/>
        [Description("Solid Book"), IconID("fas-book"), IconUnicodeGlyph(0xf02d)]
        SolidBook = 191,
        ///<summary>Solid Book Atlas</summary>
        ///<see href="https://fontawesome.com/icons/book-atlas?style=solid"/>
        [Description("Solid Book Atlas"), IconID("fas-book-atlas"), IconUnicodeGlyph(0xf558)]
        SolidBookAtlas = 192,
        ///<summary>Solid Book Bible</summary>
        ///<see href="https://fontawesome.com/icons/book-bible?style=solid"/>
        [Description("Solid Book Bible"), IconID("fas-book-bible"), IconUnicodeGlyph(0xf647)]
        SolidBookBible = 193,
        ///<summary>Solid Book Bookmark</summary>
        ///<see href="https://fontawesome.com/icons/book-bookmark?style=solid"/>
        [Description("Solid Book Bookmark"), IconID("fas-book-bookmark"), IconUnicodeGlyph(0xe0bb)]
        SolidBookBookmark = 194,
        ///<summary>Solid Book Journal Whills</summary>
        ///<see href="https://fontawesome.com/icons/book-journal-whills?style=solid"/>
        [Description("Solid Book Journal Whills"), IconID("fas-book-journal-whills"), IconUnicodeGlyph(0xf66a)]
        SolidBookJournalWhills = 195,
        ///<summary>Solid Book Medical</summary>
        ///<see href="https://fontawesome.com/icons/book-medical?style=solid"/>
        [Description("Solid Book Medical"), IconID("fas-book-medical"), IconUnicodeGlyph(0xf7e6)]
        SolidBookMedical = 196,
        ///<summary>Solid Book Open</summary>
        ///<see href="https://fontawesome.com/icons/book-open?style=solid"/>
        [Description("Solid Book Open"), IconID("fas-book-open"), IconUnicodeGlyph(0xf518)]
        SolidBookOpen = 197,
        ///<summary>Solid Book Open Reader</summary>
        ///<see href="https://fontawesome.com/icons/book-open-reader?style=solid"/>
        [Description("Solid Book Open Reader"), IconID("fas-book-open-reader"), IconUnicodeGlyph(0xf5da)]
        SolidBookOpenReader = 198,
        ///<summary>Solid Book Quran</summary>
        ///<see href="https://fontawesome.com/icons/book-quran?style=solid"/>
        [Description("Solid Book Quran"), IconID("fas-book-quran"), IconUnicodeGlyph(0xf687)]
        SolidBookQuran = 199,
        ///<summary>Solid Book Skull</summary>
        ///<see href="https://fontawesome.com/icons/book-skull?style=solid"/>
        [Description("Solid Book Skull"), IconID("fas-book-skull"), IconUnicodeGlyph(0xf6b7)]
        SolidBookSkull = 200,
        ///<summary>Solid Book Tanakh</summary>
        ///<see href="https://fontawesome.com/icons/book-tanakh?style=solid"/>
        [Description("Solid Book Tanakh"), IconID("fas-book-tanakh"), IconUnicodeGlyph(0xf827)]
        SolidBookTanakh = 201,
        ///<summary>Solid Bookmark</summary>
        ///<see href="https://fontawesome.com/icons/bookmark?style=solid"/>
        [Description("Solid Bookmark"), IconID("fas-bookmark"), IconUnicodeGlyph(0xf02e)]
        SolidBookmark = 202,
        ///<summary>Regular Bookmark</summary>
        ///<see href="https://fontawesome.com/icons/bookmark?style=regular"/>
        [Description("Regular Bookmark"), IconID("far-bookmark"), IconUnicodeGlyph(0xf02e)]
        RegularBookmark = 203,
        ///<summary>Brands Bootstrap</summary>
        ///<see href="https://fontawesome.com/icons/bootstrap?style=brands"/>
        [Description("Brands Bootstrap"), IconID("fab-bootstrap"), IconUnicodeGlyph(0xf836)]
        BrandsBootstrap = 204,
        ///<summary>Solid Border All</summary>
        ///<see href="https://fontawesome.com/icons/border-all?style=solid"/>
        [Description("Solid Border All"), IconID("fas-border-all"), IconUnicodeGlyph(0xf84c)]
        SolidBorderAll = 205,
        ///<summary>Solid Border None</summary>
        ///<see href="https://fontawesome.com/icons/border-none?style=solid"/>
        [Description("Solid Border None"), IconID("fas-border-none"), IconUnicodeGlyph(0xf850)]
        SolidBorderNone = 206,
        ///<summary>Solid Border Top Left</summary>
        ///<see href="https://fontawesome.com/icons/border-top-left?style=solid"/>
        [Description("Solid Border Top Left"), IconID("fas-border-top-left"), IconUnicodeGlyph(0xf853)]
        SolidBorderTopLeft = 207,
        ///<summary>Solid Bore Hole</summary>
        ///<see href="https://fontawesome.com/icons/bore-hole?style=solid"/>
        [Description("Solid Bore Hole"), IconID("fas-bore-hole"), IconUnicodeGlyph(0xe4c3)]
        SolidBoreHole = 208,
        ///<summary>Brands Bots</summary>
        ///<see href="https://fontawesome.com/icons/bots?style=brands"/>
        [Description("Brands Bots"), IconID("fab-bots"), IconUnicodeGlyph(0xe340)]
        BrandsBots = 209,
        ///<summary>Solid Bottle Droplet</summary>
        ///<see href="https://fontawesome.com/icons/bottle-droplet?style=solid"/>
        [Description("Solid Bottle Droplet"), IconID("fas-bottle-droplet"), IconUnicodeGlyph(0xe4c4)]
        SolidBottleDroplet = 210,
        ///<summary>Solid Bottle Water</summary>
        ///<see href="https://fontawesome.com/icons/bottle-water?style=solid"/>
        [Description("Solid Bottle Water"), IconID("fas-bottle-water"), IconUnicodeGlyph(0xe4c5)]
        SolidBottleWater = 211,
        ///<summary>Solid Bowl Food</summary>
        ///<see href="https://fontawesome.com/icons/bowl-food?style=solid"/>
        [Description("Solid Bowl Food"), IconID("fas-bowl-food"), IconUnicodeGlyph(0xe4c6)]
        SolidBowlFood = 212,
        ///<summary>Solid Bowl Rice</summary>
        ///<see href="https://fontawesome.com/icons/bowl-rice?style=solid"/>
        [Description("Solid Bowl Rice"), IconID("fas-bowl-rice"), IconUnicodeGlyph(0xe2eb)]
        SolidBowlRice = 213,
        ///<summary>Solid Bowling Ball</summary>
        ///<see href="https://fontawesome.com/icons/bowling-ball?style=solid"/>
        [Description("Solid Bowling Ball"), IconID("fas-bowling-ball"), IconUnicodeGlyph(0xf436)]
        SolidBowlingBall = 214,
        ///<summary>Solid Box</summary>
        ///<see href="https://fontawesome.com/icons/box?style=solid"/>
        [Description("Solid Box"), IconID("fas-box"), IconUnicodeGlyph(0xf466)]
        SolidBox = 215,
        ///<summary>Solid Box Archive</summary>
        ///<see href="https://fontawesome.com/icons/box-archive?style=solid"/>
        [Description("Solid Box Archive"), IconID("fas-box-archive"), IconUnicodeGlyph(0xf187)]
        SolidBoxArchive = 216,
        ///<summary>Solid Box Open</summary>
        ///<see href="https://fontawesome.com/icons/box-open?style=solid"/>
        [Description("Solid Box Open"), IconID("fas-box-open"), IconUnicodeGlyph(0xf49e)]
        SolidBoxOpen = 217,
        ///<summary>Solid Box Tissue</summary>
        ///<see href="https://fontawesome.com/icons/box-tissue?style=solid"/>
        [Description("Solid Box Tissue"), IconID("fas-box-tissue"), IconUnicodeGlyph(0xe05b)]
        SolidBoxTissue = 218,
        ///<summary>Solid Boxes Packing</summary>
        ///<see href="https://fontawesome.com/icons/boxes-packing?style=solid"/>
        [Description("Solid Boxes Packing"), IconID("fas-boxes-packing"), IconUnicodeGlyph(0xe4c7)]
        SolidBoxesPacking = 219,
        ///<summary>Solid Boxes Stacked</summary>
        ///<see href="https://fontawesome.com/icons/boxes-stacked?style=solid"/>
        [Description("Solid Boxes Stacked"), IconID("fas-boxes-stacked"), IconUnicodeGlyph(0xf468)]
        SolidBoxesStacked = 220,
        ///<summary>Solid Braille</summary>
        ///<see href="https://fontawesome.com/icons/braille?style=solid"/>
        [Description("Solid Braille"), IconID("fas-braille"), IconUnicodeGlyph(0xf2a1)]
        SolidBraille = 221,
        ///<summary>Solid Brain</summary>
        ///<see href="https://fontawesome.com/icons/brain?style=solid"/>
        [Description("Solid Brain"), IconID("fas-brain"), IconUnicodeGlyph(0xf5dc)]
        SolidBrain = 222,
        ///<summary>Brands Brave</summary>
        ///<see href="https://fontawesome.com/icons/brave?style=brands"/>
        [Description("Brands Brave"), IconID("fab-brave"), IconUnicodeGlyph(0xe63c)]
        BrandsBrave = 223,
        ///<summary>Brands Brave Reverse</summary>
        ///<see href="https://fontawesome.com/icons/brave-reverse?style=brands"/>
        [Description("Brands Brave Reverse"), IconID("fab-brave-reverse"), IconUnicodeGlyph(0xe63d)]
        BrandsBraveReverse = 224,
        ///<summary>Solid Brazilian Real Sign</summary>
        ///<see href="https://fontawesome.com/icons/brazilian-real-sign?style=solid"/>
        [Description("Solid Brazilian Real Sign"), IconID("fas-brazilian-real-sign"), IconUnicodeGlyph(0xe46c)]
        SolidBrazilianRealSign = 225,
        ///<summary>Solid Bread Slice</summary>
        ///<see href="https://fontawesome.com/icons/bread-slice?style=solid"/>
        [Description("Solid Bread Slice"), IconID("fas-bread-slice"), IconUnicodeGlyph(0xf7ec)]
        SolidBreadSlice = 226,
        ///<summary>Solid Bridge</summary>
        ///<see href="https://fontawesome.com/icons/bridge?style=solid"/>
        [Description("Solid Bridge"), IconID("fas-bridge"), IconUnicodeGlyph(0xe4c8)]
        SolidBridge = 227,
        ///<summary>Solid Bridge Circle Check</summary>
        ///<see href="https://fontawesome.com/icons/bridge-circle-check?style=solid"/>
        [Description("Solid Bridge Circle Check"), IconID("fas-bridge-circle-check"), IconUnicodeGlyph(0xe4c9)]
        SolidBridgeCircleCheck = 228,
        ///<summary>Solid Bridge Circle Exclamation</summary>
        ///<see href="https://fontawesome.com/icons/bridge-circle-exclamation?style=solid"/>
        [Description("Solid Bridge Circle Exclamation"), IconID("fas-bridge-circle-exclamation"), IconUnicodeGlyph(0xe4ca)]
        SolidBridgeCircleExclamation = 229,
        ///<summary>Solid Bridge Circle Xmark</summary>
        ///<see href="https://fontawesome.com/icons/bridge-circle-xmark?style=solid"/>
        [Description("Solid Bridge Circle Xmark"), IconID("fas-bridge-circle-xmark"), IconUnicodeGlyph(0xe4cb)]
        SolidBridgeCircleXmark = 230,
        ///<summary>Solid Bridge Lock</summary>
        ///<see href="https://fontawesome.com/icons/bridge-lock?style=solid"/>
        [Description("Solid Bridge Lock"), IconID("fas-bridge-lock"), IconUnicodeGlyph(0xe4cc)]
        SolidBridgeLock = 231,
        ///<summary>Solid Bridge Water</summary>
        ///<see href="https://fontawesome.com/icons/bridge-water?style=solid"/>
        [Description("Solid Bridge Water"), IconID("fas-bridge-water"), IconUnicodeGlyph(0xe4ce)]
        SolidBridgeWater = 232,
        ///<summary>Solid Briefcase</summary>
        ///<see href="https://fontawesome.com/icons/briefcase?style=solid"/>
        [Description("Solid Briefcase"), IconID("fas-briefcase"), IconUnicodeGlyph(0xf0b1)]
        SolidBriefcase = 233,
        ///<summary>Solid Briefcase Medical</summary>
        ///<see href="https://fontawesome.com/icons/briefcase-medical?style=solid"/>
        [Description("Solid Briefcase Medical"), IconID("fas-briefcase-medical"), IconUnicodeGlyph(0xf469)]
        SolidBriefcaseMedical = 234,
        ///<summary>Solid Broom</summary>
        ///<see href="https://fontawesome.com/icons/broom?style=solid"/>
        [Description("Solid Broom"), IconID("fas-broom"), IconUnicodeGlyph(0xf51a)]
        SolidBroom = 235,
        ///<summary>Solid Broom Ball</summary>
        ///<see href="https://fontawesome.com/icons/broom-ball?style=solid"/>
        [Description("Solid Broom Ball"), IconID("fas-broom-ball"), IconUnicodeGlyph(0xf458)]
        SolidBroomBall = 236,
        ///<summary>Solid Brush</summary>
        ///<see href="https://fontawesome.com/icons/brush?style=solid"/>
        [Description("Solid Brush"), IconID("fas-brush"), IconUnicodeGlyph(0xf55d)]
        SolidBrush = 237,
        ///<summary>Brands BTC</summary>
        ///<see href="https://fontawesome.com/icons/btc?style=brands"/>
        [Description("Brands BTC"), IconID("fab-btc"), IconUnicodeGlyph(0xf15a)]
        BrandsBtc = 238,
        ///<summary>Solid Bucket</summary>
        ///<see href="https://fontawesome.com/icons/bucket?style=solid"/>
        [Description("Solid Bucket"), IconID("fas-bucket"), IconUnicodeGlyph(0xe4cf)]
        SolidBucket = 239,
        ///<summary>Brands Buffer</summary>
        ///<see href="https://fontawesome.com/icons/buffer?style=brands"/>
        [Description("Brands Buffer"), IconID("fab-buffer"), IconUnicodeGlyph(0xf837)]
        BrandsBuffer = 240,
        ///<summary>Solid Bug</summary>
        ///<see href="https://fontawesome.com/icons/bug?style=solid"/>
        [Description("Solid Bug"), IconID("fas-bug"), IconUnicodeGlyph(0xf188)]
        SolidBug = 241,
        ///<summary>Solid Bug Slash</summary>
        ///<see href="https://fontawesome.com/icons/bug-slash?style=solid"/>
        [Description("Solid Bug Slash"), IconID("fas-bug-slash"), IconUnicodeGlyph(0xe490)]
        SolidBugSlash = 242,
        ///<summary>Solid Bugs</summary>
        ///<see href="https://fontawesome.com/icons/bugs?style=solid"/>
        [Description("Solid Bugs"), IconID("fas-bugs"), IconUnicodeGlyph(0xe4d0)]
        SolidBugs = 243,
        ///<summary>Solid Building</summary>
        ///<see href="https://fontawesome.com/icons/building?style=solid"/>
        [Description("Solid Building"), IconID("fas-building"), IconUnicodeGlyph(0xf1ad)]
        SolidBuilding = 244,
        ///<summary>Regular Building</summary>
        ///<see href="https://fontawesome.com/icons/building?style=regular"/>
        [Description("Regular Building"), IconID("far-building"), IconUnicodeGlyph(0xf1ad)]
        RegularBuilding = 245,
        ///<summary>Solid Building Circle Arrow Right</summary>
        ///<see href="https://fontawesome.com/icons/building-circle-arrow-right?style=solid"/>
        [Description("Solid Building Circle Arrow Right"), IconID("fas-building-circle-arrow-right"), IconUnicodeGlyph(0xe4d1)]
        SolidBuildingCircleArrowRight = 246,
        ///<summary>Solid Building Circle Check</summary>
        ///<see href="https://fontawesome.com/icons/building-circle-check?style=solid"/>
        [Description("Solid Building Circle Check"), IconID("fas-building-circle-check"), IconUnicodeGlyph(0xe4d2)]
        SolidBuildingCircleCheck = 247,
        ///<summary>Solid Building Circle Exclamation</summary>
        ///<see href="https://fontawesome.com/icons/building-circle-exclamation?style=solid"/>
        [Description("Solid Building Circle Exclamation"), IconID("fas-building-circle-exclamation"), IconUnicodeGlyph(0xe4d3)]
        SolidBuildingCircleExclamation = 248,
        ///<summary>Solid Building Circle Xmark</summary>
        ///<see href="https://fontawesome.com/icons/building-circle-xmark?style=solid"/>
        [Description("Solid Building Circle Xmark"), IconID("fas-building-circle-xmark"), IconUnicodeGlyph(0xe4d4)]
        SolidBuildingCircleXmark = 249,
        ///<summary>Solid Building Columns</summary>
        ///<see href="https://fontawesome.com/icons/building-columns?style=solid"/>
        [Description("Solid Building Columns"), IconID("fas-building-columns"), IconUnicodeGlyph(0xf19c)]
        SolidBuildingColumns = 250,
        ///<summary>Solid Building Flag</summary>
        ///<see href="https://fontawesome.com/icons/building-flag?style=solid"/>
        [Description("Solid Building Flag"), IconID("fas-building-flag"), IconUnicodeGlyph(0xe4d5)]
        SolidBuildingFlag = 251,
        ///<summary>Solid Building Lock</summary>
        ///<see href="https://fontawesome.com/icons/building-lock?style=solid"/>
        [Description("Solid Building Lock"), IconID("fas-building-lock"), IconUnicodeGlyph(0xe4d6)]
        SolidBuildingLock = 252,
        ///<summary>Solid Building Ngo</summary>
        ///<see href="https://fontawesome.com/icons/building-ngo?style=solid"/>
        [Description("Solid Building Ngo"), IconID("fas-building-ngo"), IconUnicodeGlyph(0xe4d7)]
        SolidBuildingNgo = 253,
        ///<summary>Solid Building Shield</summary>
        ///<see href="https://fontawesome.com/icons/building-shield?style=solid"/>
        [Description("Solid Building Shield"), IconID("fas-building-shield"), IconUnicodeGlyph(0xe4d8)]
        SolidBuildingShield = 254,
        ///<summary>Solid Building Un</summary>
        ///<see href="https://fontawesome.com/icons/building-un?style=solid"/>
        [Description("Solid Building Un"), IconID("fas-building-un"), IconUnicodeGlyph(0xe4d9)]
        SolidBuildingUn = 255,
        ///<summary>Solid Building User</summary>
        ///<see href="https://fontawesome.com/icons/building-user?style=solid"/>
        [Description("Solid Building User"), IconID("fas-building-user"), IconUnicodeGlyph(0xe4da)]
        SolidBuildingUser = 256,
        ///<summary>Solid Building Wheat</summary>
        ///<see href="https://fontawesome.com/icons/building-wheat?style=solid"/>
        [Description("Solid Building Wheat"), IconID("fas-building-wheat"), IconUnicodeGlyph(0xe4db)]
        SolidBuildingWheat = 257,
        ///<summary>Solid Bullhorn</summary>
        ///<see href="https://fontawesome.com/icons/bullhorn?style=solid"/>
        [Description("Solid Bullhorn"), IconID("fas-bullhorn"), IconUnicodeGlyph(0xf0a1)]
        SolidBullhorn = 258,
        ///<summary>Solid Bullseye</summary>
        ///<see href="https://fontawesome.com/icons/bullseye?style=solid"/>
        [Description("Solid Bullseye"), IconID("fas-bullseye"), IconUnicodeGlyph(0xf140)]
        SolidBullseye = 259,
        ///<summary>Solid Burger</summary>
        ///<see href="https://fontawesome.com/icons/burger?style=solid"/>
        [Description("Solid Burger"), IconID("fas-burger"), IconUnicodeGlyph(0xf805)]
        SolidBurger = 260,
        ///<summary>Brands Büromöbel-Experte GmbH & Co. KG.</summary>
        ///<see href="https://fontawesome.com/icons/buromobelexperte?style=brands"/>
        [Description("Brands Büromöbel-Experte GmbH & Co. KG."), IconID("fab-buromobelexperte"), IconUnicodeGlyph(0xf37f)]
        BrandsBuromobelexperte = 261,
        ///<summary>Solid Burst</summary>
        ///<see href="https://fontawesome.com/icons/burst?style=solid"/>
        [Description("Solid Burst"), IconID("fas-burst"), IconUnicodeGlyph(0xe4dc)]
        SolidBurst = 262,
        ///<summary>Solid Bus</summary>
        ///<see href="https://fontawesome.com/icons/bus?style=solid"/>
        [Description("Solid Bus"), IconID("fas-bus"), IconUnicodeGlyph(0xf207)]
        SolidBus = 263,
        ///<summary>Solid Bus Simple</summary>
        ///<see href="https://fontawesome.com/icons/bus-simple?style=solid"/>
        [Description("Solid Bus Simple"), IconID("fas-bus-simple"), IconUnicodeGlyph(0xf55e)]
        SolidBusSimple = 264,
        ///<summary>Solid Business Time</summary>
        ///<see href="https://fontawesome.com/icons/business-time?style=solid"/>
        [Description("Solid Business Time"), IconID("fas-business-time"), IconUnicodeGlyph(0xf64a)]
        SolidBusinessTime = 265,
        ///<summary>Brands Buy n Large</summary>
        ///<see href="https://fontawesome.com/icons/buy-n-large?style=brands"/>
        [Description("Brands Buy n Large"), IconID("fab-buy-n-large"), IconUnicodeGlyph(0xf8a6)]
        BrandsBuyNLarge = 266,
        ///<summary>Brands BuySellAds</summary>
        ///<see href="https://fontawesome.com/icons/buysellads?style=brands"/>
        [Description("Brands BuySellAds"), IconID("fab-buysellads"), IconUnicodeGlyph(0xf20d)]
        BrandsBuysellads = 267,
        ///<summary>Solid C</summary>
        ///<see href="https://fontawesome.com/icons/c?style=solid"/>
        [Description("Solid C"), IconID("fas-c"), IconUnicodeGlyph(0x43)]
        SolidC = 268,
        ///<summary>Solid Cable Car</summary>
        ///<see href="https://fontawesome.com/icons/cable-car?style=solid"/>
        [Description("Solid Cable Car"), IconID("fas-cable-car"), IconUnicodeGlyph(0xf7da)]
        SolidCableCar = 269,
        ///<summary>Solid Cake Candles</summary>
        ///<see href="https://fontawesome.com/icons/cake-candles?style=solid"/>
        [Description("Solid Cake Candles"), IconID("fas-cake-candles"), IconUnicodeGlyph(0xf1fd)]
        SolidCakeCandles = 270,
        ///<summary>Solid Calculator</summary>
        ///<see href="https://fontawesome.com/icons/calculator?style=solid"/>
        [Description("Solid Calculator"), IconID("fas-calculator"), IconUnicodeGlyph(0xf1ec)]
        SolidCalculator = 271,
        ///<summary>Solid Calendar</summary>
        ///<see href="https://fontawesome.com/icons/calendar?style=solid"/>
        [Description("Solid Calendar"), IconID("fas-calendar"), IconUnicodeGlyph(0xf133)]
        SolidCalendar = 272,
        ///<summary>Regular Calendar</summary>
        ///<see href="https://fontawesome.com/icons/calendar?style=regular"/>
        [Description("Regular Calendar"), IconID("far-calendar"), IconUnicodeGlyph(0xf133)]
        RegularCalendar = 273,
        ///<summary>Solid Calendar Check</summary>
        ///<see href="https://fontawesome.com/icons/calendar-check?style=solid"/>
        [Description("Solid Calendar Check"), IconID("fas-calendar-check"), IconUnicodeGlyph(0xf274)]
        SolidCalendarCheck = 274,
        ///<summary>Regular Calendar Check</summary>
        ///<see href="https://fontawesome.com/icons/calendar-check?style=regular"/>
        [Description("Regular Calendar Check"), IconID("far-calendar-check"), IconUnicodeGlyph(0xf274)]
        RegularCalendarCheck = 275,
        ///<summary>Solid Calendar Day</summary>
        ///<see href="https://fontawesome.com/icons/calendar-day?style=solid"/>
        [Description("Solid Calendar Day"), IconID("fas-calendar-day"), IconUnicodeGlyph(0xf783)]
        SolidCalendarDay = 276,
        ///<summary>Solid Calendar Days</summary>
        ///<see href="https://fontawesome.com/icons/calendar-days?style=solid"/>
        [Description("Solid Calendar Days"), IconID("fas-calendar-days"), IconUnicodeGlyph(0xf073)]
        SolidCalendarDays = 277,
        ///<summary>Regular Calendar Days</summary>
        ///<see href="https://fontawesome.com/icons/calendar-days?style=regular"/>
        [Description("Regular Calendar Days"), IconID("far-calendar-days"), IconUnicodeGlyph(0xf073)]
        RegularCalendarDays = 278,
        ///<summary>Solid Calendar Minus</summary>
        ///<see href="https://fontawesome.com/icons/calendar-minus?style=solid"/>
        [Description("Solid Calendar Minus"), IconID("fas-calendar-minus"), IconUnicodeGlyph(0xf272)]
        SolidCalendarMinus = 279,
        ///<summary>Regular Calendar Minus</summary>
        ///<see href="https://fontawesome.com/icons/calendar-minus?style=regular"/>
        [Description("Regular Calendar Minus"), IconID("far-calendar-minus"), IconUnicodeGlyph(0xf272)]
        RegularCalendarMinus = 280,
        ///<summary>Solid Calendar Plus</summary>
        ///<see href="https://fontawesome.com/icons/calendar-plus?style=solid"/>
        [Description("Solid Calendar Plus"), IconID("fas-calendar-plus"), IconUnicodeGlyph(0xf271)]
        SolidCalendarPlus = 281,
        ///<summary>Regular Calendar Plus</summary>
        ///<see href="https://fontawesome.com/icons/calendar-plus?style=regular"/>
        [Description("Regular Calendar Plus"), IconID("far-calendar-plus"), IconUnicodeGlyph(0xf271)]
        RegularCalendarPlus = 282,
        ///<summary>Solid Calendar Week</summary>
        ///<see href="https://fontawesome.com/icons/calendar-week?style=solid"/>
        [Description("Solid Calendar Week"), IconID("fas-calendar-week"), IconUnicodeGlyph(0xf784)]
        SolidCalendarWeek = 283,
        ///<summary>Solid Calendar Xmark</summary>
        ///<see href="https://fontawesome.com/icons/calendar-xmark?style=solid"/>
        [Description("Solid Calendar Xmark"), IconID("fas-calendar-xmark"), IconUnicodeGlyph(0xf273)]
        SolidCalendarXmark = 284,
        ///<summary>Regular Calendar Xmark</summary>
        ///<see href="https://fontawesome.com/icons/calendar-xmark?style=regular"/>
        [Description("Regular Calendar Xmark"), IconID("far-calendar-xmark"), IconUnicodeGlyph(0xf273)]
        RegularCalendarXmark = 285,
        ///<summary>Solid Camera</summary>
        ///<see href="https://fontawesome.com/icons/camera?style=solid"/>
        [Description("Solid Camera"), IconID("fas-camera"), IconUnicodeGlyph(0xf030)]
        SolidCamera = 286,
        ///<summary>Solid Camera Retro</summary>
        ///<see href="https://fontawesome.com/icons/camera-retro?style=solid"/>
        [Description("Solid Camera Retro"), IconID("fas-camera-retro"), IconUnicodeGlyph(0xf083)]
        SolidCameraRetro = 287,
        ///<summary>Solid Camera Rotate</summary>
        ///<see href="https://fontawesome.com/icons/camera-rotate?style=solid"/>
        [Description("Solid Camera Rotate"), IconID("fas-camera-rotate"), IconUnicodeGlyph(0xe0d8)]
        SolidCameraRotate = 288,
        ///<summary>Solid Campground</summary>
        ///<see href="https://fontawesome.com/icons/campground?style=solid"/>
        [Description("Solid Campground"), IconID("fas-campground"), IconUnicodeGlyph(0xf6bb)]
        SolidCampground = 289,
        ///<summary>Brands Canadian Maple Leaf</summary>
        ///<see href="https://fontawesome.com/icons/canadian-maple-leaf?style=brands"/>
        [Description("Brands Canadian Maple Leaf"), IconID("fab-canadian-maple-leaf"), IconUnicodeGlyph(0xf785)]
        BrandsCanadianMapleLeaf = 290,
        ///<summary>Solid Candy Cane</summary>
        ///<see href="https://fontawesome.com/icons/candy-cane?style=solid"/>
        [Description("Solid Candy Cane"), IconID("fas-candy-cane"), IconUnicodeGlyph(0xf786)]
        SolidCandyCane = 291,
        ///<summary>Solid Cannabis</summary>
        ///<see href="https://fontawesome.com/icons/cannabis?style=solid"/>
        [Description("Solid Cannabis"), IconID("fas-cannabis"), IconUnicodeGlyph(0xf55f)]
        SolidCannabis = 292,
        ///<summary>Solid Capsules</summary>
        ///<see href="https://fontawesome.com/icons/capsules?style=solid"/>
        [Description("Solid Capsules"), IconID("fas-capsules"), IconUnicodeGlyph(0xf46b)]
        SolidCapsules = 293,
        ///<summary>Solid Car</summary>
        ///<see href="https://fontawesome.com/icons/car?style=solid"/>
        [Description("Solid Car"), IconID("fas-car"), IconUnicodeGlyph(0xf1b9)]
        SolidCar = 294,
        ///<summary>Solid Car Battery</summary>
        ///<see href="https://fontawesome.com/icons/car-battery?style=solid"/>
        [Description("Solid Car Battery"), IconID("fas-car-battery"), IconUnicodeGlyph(0xf5df)]
        SolidCarBattery = 295,
        ///<summary>Solid Car Burst</summary>
        ///<see href="https://fontawesome.com/icons/car-burst?style=solid"/>
        [Description("Solid Car Burst"), IconID("fas-car-burst"), IconUnicodeGlyph(0xf5e1)]
        SolidCarBurst = 296,
        ///<summary>Solid Car On</summary>
        ///<see href="https://fontawesome.com/icons/car-on?style=solid"/>
        [Description("Solid Car On"), IconID("fas-car-on"), IconUnicodeGlyph(0xe4dd)]
        SolidCarOn = 297,
        ///<summary>Solid Car Rear</summary>
        ///<see href="https://fontawesome.com/icons/car-rear?style=solid"/>
        [Description("Solid Car Rear"), IconID("fas-car-rear"), IconUnicodeGlyph(0xf5de)]
        SolidCarRear = 298,
        ///<summary>Solid Car Side</summary>
        ///<see href="https://fontawesome.com/icons/car-side?style=solid"/>
        [Description("Solid Car Side"), IconID("fas-car-side"), IconUnicodeGlyph(0xf5e4)]
        SolidCarSide = 299,
        ///<summary>Solid Car Tunnel</summary>
        ///<see href="https://fontawesome.com/icons/car-tunnel?style=solid"/>
        [Description("Solid Car Tunnel"), IconID("fas-car-tunnel"), IconUnicodeGlyph(0xe4de)]
        SolidCarTunnel = 300,
        ///<summary>Solid Caravan</summary>
        ///<see href="https://fontawesome.com/icons/caravan?style=solid"/>
        [Description("Solid Caravan"), IconID("fas-caravan"), IconUnicodeGlyph(0xf8ff)]
        SolidCaravan = 301,
        ///<summary>Solid Caret Down</summary>
        ///<see href="https://fontawesome.com/icons/caret-down?style=solid"/>
        [Description("Solid Caret Down"), IconID("fas-caret-down"), IconUnicodeGlyph(0xf0d7)]
        SolidCaretDown = 302,
        ///<summary>Solid Caret Left</summary>
        ///<see href="https://fontawesome.com/icons/caret-left?style=solid"/>
        [Description("Solid Caret Left"), IconID("fas-caret-left"), IconUnicodeGlyph(0xf0d9)]
        SolidCaretLeft = 303,
        ///<summary>Solid Caret Right</summary>
        ///<see href="https://fontawesome.com/icons/caret-right?style=solid"/>
        [Description("Solid Caret Right"), IconID("fas-caret-right"), IconUnicodeGlyph(0xf0da)]
        SolidCaretRight = 304,
        ///<summary>Solid Caret Up</summary>
        ///<see href="https://fontawesome.com/icons/caret-up?style=solid"/>
        [Description("Solid Caret Up"), IconID("fas-caret-up"), IconUnicodeGlyph(0xf0d8)]
        SolidCaretUp = 305,
        ///<summary>Solid Carrot</summary>
        ///<see href="https://fontawesome.com/icons/carrot?style=solid"/>
        [Description("Solid Carrot"), IconID("fas-carrot"), IconUnicodeGlyph(0xf787)]
        SolidCarrot = 306,
        ///<summary>Solid Cart Arrow Down</summary>
        ///<see href="https://fontawesome.com/icons/cart-arrow-down?style=solid"/>
        [Description("Solid Cart Arrow Down"), IconID("fas-cart-arrow-down"), IconUnicodeGlyph(0xf218)]
        SolidCartArrowDown = 307,
        ///<summary>Solid Cart Flatbed</summary>
        ///<see href="https://fontawesome.com/icons/cart-flatbed?style=solid"/>
        [Description("Solid Cart Flatbed"), IconID("fas-cart-flatbed"), IconUnicodeGlyph(0xf474)]
        SolidCartFlatbed = 308,
        ///<summary>Solid Cart Flatbed Suitcase</summary>
        ///<see href="https://fontawesome.com/icons/cart-flatbed-suitcase?style=solid"/>
        [Description("Solid Cart Flatbed Suitcase"), IconID("fas-cart-flatbed-suitcase"), IconUnicodeGlyph(0xf59d)]
        SolidCartFlatbedSuitcase = 309,
        ///<summary>Solid Cart Plus</summary>
        ///<see href="https://fontawesome.com/icons/cart-plus?style=solid"/>
        [Description("Solid Cart Plus"), IconID("fas-cart-plus"), IconUnicodeGlyph(0xf217)]
        SolidCartPlus = 310,
        ///<summary>Solid Cart Shopping</summary>
        ///<see href="https://fontawesome.com/icons/cart-shopping?style=solid"/>
        [Description("Solid Cart Shopping"), IconID("fas-cart-shopping"), IconUnicodeGlyph(0xf07a)]
        SolidCartShopping = 311,
        ///<summary>Solid Cash Register</summary>
        ///<see href="https://fontawesome.com/icons/cash-register?style=solid"/>
        [Description("Solid Cash Register"), IconID("fas-cash-register"), IconUnicodeGlyph(0xf788)]
        SolidCashRegister = 312,
        ///<summary>Solid Cat</summary>
        ///<see href="https://fontawesome.com/icons/cat?style=solid"/>
        [Description("Solid Cat"), IconID("fas-cat"), IconUnicodeGlyph(0xf6be)]
        SolidCat = 313,
        ///<summary>Brands Amazon Pay Credit Card</summary>
        ///<see href="https://fontawesome.com/icons/cc-amazon-pay?style=brands"/>
        [Description("Brands Amazon Pay Credit Card"), IconID("fab-cc-amazon-pay"), IconUnicodeGlyph(0xf42d)]
        BrandsCcAmazonPay = 314,
        ///<summary>Brands Cc Amex</summary>
        ///<see href="https://fontawesome.com/icons/cc-amex?style=brands"/>
        [Description("Brands Cc Amex"), IconID("fab-cc-amex"), IconUnicodeGlyph(0xf1f3)]
        BrandsCcAmex = 315,
        ///<summary>Brands Apple Pay Credit Card</summary>
        ///<see href="https://fontawesome.com/icons/cc-apple-pay?style=brands"/>
        [Description("Brands Apple Pay Credit Card"), IconID("fab-cc-apple-pay"), IconUnicodeGlyph(0xf416)]
        BrandsCcApplePay = 316,
        ///<summary>Brands Diner's Club Credit Card</summary>
        ///<see href="https://fontawesome.com/icons/cc-diners-club?style=brands"/>
        [Description("Brands Diner's Club Credit Card"), IconID("fab-cc-diners-club"), IconUnicodeGlyph(0xf24c)]
        BrandsCcDinersClub = 317,
        ///<summary>Brands Discover Credit Card</summary>
        ///<see href="https://fontawesome.com/icons/cc-discover?style=brands"/>
        [Description("Brands Discover Credit Card"), IconID("fab-cc-discover"), IconUnicodeGlyph(0xf1f2)]
        BrandsCcDiscover = 318,
        ///<summary>Brands JCB Credit Card</summary>
        ///<see href="https://fontawesome.com/icons/cc-jcb?style=brands"/>
        [Description("Brands JCB Credit Card"), IconID("fab-cc-jcb"), IconUnicodeGlyph(0xf24b)]
        BrandsCcJcb = 319,
        ///<summary>Brands MasterCard Credit Card</summary>
        ///<see href="https://fontawesome.com/icons/cc-mastercard?style=brands"/>
        [Description("Brands MasterCard Credit Card"), IconID("fab-cc-mastercard"), IconUnicodeGlyph(0xf1f1)]
        BrandsCcMastercard = 320,
        ///<summary>Brands Paypal Credit Card</summary>
        ///<see href="https://fontawesome.com/icons/cc-paypal?style=brands"/>
        [Description("Brands Paypal Credit Card"), IconID("fab-cc-paypal"), IconUnicodeGlyph(0xf1f4)]
        BrandsCcPaypal = 321,
        ///<summary>Brands Stripe Credit Card</summary>
        ///<see href="https://fontawesome.com/icons/cc-stripe?style=brands"/>
        [Description("Brands Stripe Credit Card"), IconID("fab-cc-stripe"), IconUnicodeGlyph(0xf1f5)]
        BrandsCcStripe = 322,
        ///<summary>Brands Visa Credit Card</summary>
        ///<see href="https://fontawesome.com/icons/cc-visa?style=brands"/>
        [Description("Brands Visa Credit Card"), IconID("fab-cc-visa"), IconUnicodeGlyph(0xf1f0)]
        BrandsCcVisa = 323,
        ///<summary>Solid Cedi Sign</summary>
        ///<see href="https://fontawesome.com/icons/cedi-sign?style=solid"/>
        [Description("Solid Cedi Sign"), IconID("fas-cedi-sign"), IconUnicodeGlyph(0xe0df)]
        SolidCediSign = 324,
        ///<summary>Solid Cent Sign</summary>
        ///<see href="https://fontawesome.com/icons/cent-sign?style=solid"/>
        [Description("Solid Cent Sign"), IconID("fas-cent-sign"), IconUnicodeGlyph(0xe3f5)]
        SolidCentSign = 325,
        ///<summary>Brands Centercode</summary>
        ///<see href="https://fontawesome.com/icons/centercode?style=brands"/>
        [Description("Brands Centercode"), IconID("fab-centercode"), IconUnicodeGlyph(0xf380)]
        BrandsCentercode = 326,
        ///<summary>Brands Centos</summary>
        ///<see href="https://fontawesome.com/icons/centos?style=brands"/>
        [Description("Brands Centos"), IconID("fab-centos"), IconUnicodeGlyph(0xf789)]
        BrandsCentos = 327,
        ///<summary>Solid Certificate</summary>
        ///<see href="https://fontawesome.com/icons/certificate?style=solid"/>
        [Description("Solid Certificate"), IconID("fas-certificate"), IconUnicodeGlyph(0xf0a3)]
        SolidCertificate = 328,
        ///<summary>Solid Chair</summary>
        ///<see href="https://fontawesome.com/icons/chair?style=solid"/>
        [Description("Solid Chair"), IconID("fas-chair"), IconUnicodeGlyph(0xf6c0)]
        SolidChair = 329,
        ///<summary>Solid Chalkboard</summary>
        ///<see href="https://fontawesome.com/icons/chalkboard?style=solid"/>
        [Description("Solid Chalkboard"), IconID("fas-chalkboard"), IconUnicodeGlyph(0xf51b)]
        SolidChalkboard = 330,
        ///<summary>Solid Chalkboard User</summary>
        ///<see href="https://fontawesome.com/icons/chalkboard-user?style=solid"/>
        [Description("Solid Chalkboard User"), IconID("fas-chalkboard-user"), IconUnicodeGlyph(0xf51c)]
        SolidChalkboardUser = 331,
        ///<summary>Solid Champagne Glasses</summary>
        ///<see href="https://fontawesome.com/icons/champagne-glasses?style=solid"/>
        [Description("Solid Champagne Glasses"), IconID("fas-champagne-glasses"), IconUnicodeGlyph(0xf79f)]
        SolidChampagneGlasses = 332,
        ///<summary>Solid Charging Station</summary>
        ///<see href="https://fontawesome.com/icons/charging-station?style=solid"/>
        [Description("Solid Charging Station"), IconID("fas-charging-station"), IconUnicodeGlyph(0xf5e7)]
        SolidChargingStation = 333,
        ///<summary>Solid Chart Area</summary>
        ///<see href="https://fontawesome.com/icons/chart-area?style=solid"/>
        [Description("Solid Chart Area"), IconID("fas-chart-area"), IconUnicodeGlyph(0xf1fe)]
        SolidChartArea = 334,
        ///<summary>Solid Chart Bar</summary>
        ///<see href="https://fontawesome.com/icons/chart-bar?style=solid"/>
        [Description("Solid Chart Bar"), IconID("fas-chart-bar"), IconUnicodeGlyph(0xf080)]
        SolidChartBar = 335,
        ///<summary>Regular Chart Bar</summary>
        ///<see href="https://fontawesome.com/icons/chart-bar?style=regular"/>
        [Description("Regular Chart Bar"), IconID("far-chart-bar"), IconUnicodeGlyph(0xf080)]
        RegularChartBar = 336,
        ///<summary>Solid Chart Column</summary>
        ///<see href="https://fontawesome.com/icons/chart-column?style=solid"/>
        [Description("Solid Chart Column"), IconID("fas-chart-column"), IconUnicodeGlyph(0xe0e3)]
        SolidChartColumn = 337,
        ///<summary>Solid Chart Diagram</summary>
        ///<see href="https://fontawesome.com/icons/chart-diagram?style=solid"/>
        [Description("Solid Chart Diagram"), IconID("fas-chart-diagram"), IconUnicodeGlyph(0xe695)]
        SolidChartDiagram = 338,
        ///<summary>Solid Chart Gantt</summary>
        ///<see href="https://fontawesome.com/icons/chart-gantt?style=solid"/>
        [Description("Solid Chart Gantt"), IconID("fas-chart-gantt"), IconUnicodeGlyph(0xe0e4)]
        SolidChartGantt = 339,
        ///<summary>Solid Chart Line</summary>
        ///<see href="https://fontawesome.com/icons/chart-line?style=solid"/>
        [Description("Solid Chart Line"), IconID("fas-chart-line"), IconUnicodeGlyph(0xf201)]
        SolidChartLine = 340,
        ///<summary>Solid Chart Pie</summary>
        ///<see href="https://fontawesome.com/icons/chart-pie?style=solid"/>
        [Description("Solid Chart Pie"), IconID("fas-chart-pie"), IconUnicodeGlyph(0xf200)]
        SolidChartPie = 341,
        ///<summary>Solid Chart Simple</summary>
        ///<see href="https://fontawesome.com/icons/chart-simple?style=solid"/>
        [Description("Solid Chart Simple"), IconID("fas-chart-simple"), IconUnicodeGlyph(0xe473)]
        SolidChartSimple = 342,
        ///<summary>Solid Check</summary>
        ///<see href="https://fontawesome.com/icons/check?style=solid"/>
        [Description("Solid Check"), IconID("fas-check"), IconUnicodeGlyph(0xf00c)]
        SolidCheck = 343,
        ///<summary>Solid Check Double</summary>
        ///<see href="https://fontawesome.com/icons/check-double?style=solid"/>
        [Description("Solid Check Double"), IconID("fas-check-double"), IconUnicodeGlyph(0xf560)]
        SolidCheckDouble = 344,
        ///<summary>Solid Check To Slot</summary>
        ///<see href="https://fontawesome.com/icons/check-to-slot?style=solid"/>
        [Description("Solid Check To Slot"), IconID("fas-check-to-slot"), IconUnicodeGlyph(0xf772)]
        SolidCheckToSlot = 345,
        ///<summary>Solid Cheese</summary>
        ///<see href="https://fontawesome.com/icons/cheese?style=solid"/>
        [Description("Solid Cheese"), IconID("fas-cheese"), IconUnicodeGlyph(0xf7ef)]
        SolidCheese = 346,
        ///<summary>Solid Chess</summary>
        ///<see href="https://fontawesome.com/icons/chess?style=solid"/>
        [Description("Solid Chess"), IconID("fas-chess"), IconUnicodeGlyph(0xf439)]
        SolidChess = 347,
        ///<summary>Solid Chess Bishop</summary>
        ///<see href="https://fontawesome.com/icons/chess-bishop?style=solid"/>
        [Description("Solid Chess Bishop"), IconID("fas-chess-bishop"), IconUnicodeGlyph(0xf43a)]
        SolidChessBishop = 348,
        ///<summary>Regular Chess Bishop</summary>
        ///<see href="https://fontawesome.com/icons/chess-bishop?style=regular"/>
        [Description("Regular Chess Bishop"), IconID("far-chess-bishop"), IconUnicodeGlyph(0xf43a)]
        RegularChessBishop = 349,
        ///<summary>Solid Chess Board</summary>
        ///<see href="https://fontawesome.com/icons/chess-board?style=solid"/>
        [Description("Solid Chess Board"), IconID("fas-chess-board"), IconUnicodeGlyph(0xf43c)]
        SolidChessBoard = 350,
        ///<summary>Solid Chess King</summary>
        ///<see href="https://fontawesome.com/icons/chess-king?style=solid"/>
        [Description("Solid Chess King"), IconID("fas-chess-king"), IconUnicodeGlyph(0xf43f)]
        SolidChessKing = 351,
        ///<summary>Regular Chess King</summary>
        ///<see href="https://fontawesome.com/icons/chess-king?style=regular"/>
        [Description("Regular Chess King"), IconID("far-chess-king"), IconUnicodeGlyph(0xf43f)]
        RegularChessKing = 352,
        ///<summary>Solid Chess Knight</summary>
        ///<see href="https://fontawesome.com/icons/chess-knight?style=solid"/>
        [Description("Solid Chess Knight"), IconID("fas-chess-knight"), IconUnicodeGlyph(0xf441)]
        SolidChessKnight = 353,
        ///<summary>Regular Chess Knight</summary>
        ///<see href="https://fontawesome.com/icons/chess-knight?style=regular"/>
        [Description("Regular Chess Knight"), IconID("far-chess-knight"), IconUnicodeGlyph(0xf441)]
        RegularChessKnight = 354,
        ///<summary>Solid Chess Pawn</summary>
        ///<see href="https://fontawesome.com/icons/chess-pawn?style=solid"/>
        [Description("Solid Chess Pawn"), IconID("fas-chess-pawn"), IconUnicodeGlyph(0xf443)]
        SolidChessPawn = 355,
        ///<summary>Regular Chess Pawn</summary>
        ///<see href="https://fontawesome.com/icons/chess-pawn?style=regular"/>
        [Description("Regular Chess Pawn"), IconID("far-chess-pawn"), IconUnicodeGlyph(0xf443)]
        RegularChessPawn = 356,
        ///<summary>Solid Chess Queen</summary>
        ///<see href="https://fontawesome.com/icons/chess-queen?style=solid"/>
        [Description("Solid Chess Queen"), IconID("fas-chess-queen"), IconUnicodeGlyph(0xf445)]
        SolidChessQueen = 357,
        ///<summary>Regular Chess Queen</summary>
        ///<see href="https://fontawesome.com/icons/chess-queen?style=regular"/>
        [Description("Regular Chess Queen"), IconID("far-chess-queen"), IconUnicodeGlyph(0xf445)]
        RegularChessQueen = 358,
        ///<summary>Solid Chess Rook</summary>
        ///<see href="https://fontawesome.com/icons/chess-rook?style=solid"/>
        [Description("Solid Chess Rook"), IconID("fas-chess-rook"), IconUnicodeGlyph(0xf447)]
        SolidChessRook = 359,
        ///<summary>Regular Chess Rook</summary>
        ///<see href="https://fontawesome.com/icons/chess-rook?style=regular"/>
        [Description("Regular Chess Rook"), IconID("far-chess-rook"), IconUnicodeGlyph(0xf447)]
        RegularChessRook = 360,
        ///<summary>Solid Chevron Down</summary>
        ///<see href="https://fontawesome.com/icons/chevron-down?style=solid"/>
        [Description("Solid Chevron Down"), IconID("fas-chevron-down"), IconUnicodeGlyph(0xf078)]
        SolidChevronDown = 361,
        ///<summary>Solid Chevron Left</summary>
        ///<see href="https://fontawesome.com/icons/chevron-left?style=solid"/>
        [Description("Solid Chevron Left"), IconID("fas-chevron-left"), IconUnicodeGlyph(0xf053)]
        SolidChevronLeft = 362,
        ///<summary>Solid Chevron Right</summary>
        ///<see href="https://fontawesome.com/icons/chevron-right?style=solid"/>
        [Description("Solid Chevron Right"), IconID("fas-chevron-right"), IconUnicodeGlyph(0xf054)]
        SolidChevronRight = 363,
        ///<summary>Solid Chevron Up</summary>
        ///<see href="https://fontawesome.com/icons/chevron-up?style=solid"/>
        [Description("Solid Chevron Up"), IconID("fas-chevron-up"), IconUnicodeGlyph(0xf077)]
        SolidChevronUp = 364,
        ///<summary>Solid Child</summary>
        ///<see href="https://fontawesome.com/icons/child?style=solid"/>
        [Description("Solid Child"), IconID("fas-child"), IconUnicodeGlyph(0xf1ae)]
        SolidChild = 365,
        ///<summary>Solid Child Combatant</summary>
        ///<see href="https://fontawesome.com/icons/child-combatant?style=solid"/>
        [Description("Solid Child Combatant"), IconID("fas-child-combatant"), IconUnicodeGlyph(0xe4e0)]
        SolidChildCombatant = 366,
        ///<summary>Solid Child Dress</summary>
        ///<see href="https://fontawesome.com/icons/child-dress?style=solid"/>
        [Description("Solid Child Dress"), IconID("fas-child-dress"), IconUnicodeGlyph(0xe59c)]
        SolidChildDress = 367,
        ///<summary>Solid Child Reaching</summary>
        ///<see href="https://fontawesome.com/icons/child-reaching?style=solid"/>
        [Description("Solid Child Reaching"), IconID("fas-child-reaching"), IconUnicodeGlyph(0xe59d)]
        SolidChildReaching = 368,
        ///<summary>Solid Children</summary>
        ///<see href="https://fontawesome.com/icons/children?style=solid"/>
        [Description("Solid Children"), IconID("fas-children"), IconUnicodeGlyph(0xe4e1)]
        SolidChildren = 369,
        ///<summary>Brands Chrome</summary>
        ///<see href="https://fontawesome.com/icons/chrome?style=brands"/>
        [Description("Brands Chrome"), IconID("fab-chrome"), IconUnicodeGlyph(0xf268)]
        BrandsChrome = 370,
        ///<summary>Brands Chromecast</summary>
        ///<see href="https://fontawesome.com/icons/chromecast?style=brands"/>
        [Description("Brands Chromecast"), IconID("fab-chromecast"), IconUnicodeGlyph(0xf838)]
        BrandsChromecast = 371,
        ///<summary>Solid Church</summary>
        ///<see href="https://fontawesome.com/icons/church?style=solid"/>
        [Description("Solid Church"), IconID("fas-church"), IconUnicodeGlyph(0xf51d)]
        SolidChurch = 372,
        ///<summary>Solid Circle</summary>
        ///<see href="https://fontawesome.com/icons/circle?style=solid"/>
        [Description("Solid Circle"), IconID("fas-circle"), IconUnicodeGlyph(0xf111)]
        SolidCircle = 373,
        ///<summary>Regular Circle</summary>
        ///<see href="https://fontawesome.com/icons/circle?style=regular"/>
        [Description("Regular Circle"), IconID("far-circle"), IconUnicodeGlyph(0xf111)]
        RegularCircle = 374,
        ///<summary>Solid Circle Arrow Down</summary>
        ///<see href="https://fontawesome.com/icons/circle-arrow-down?style=solid"/>
        [Description("Solid Circle Arrow Down"), IconID("fas-circle-arrow-down"), IconUnicodeGlyph(0xf0ab)]
        SolidCircleArrowDown = 375,
        ///<summary>Solid Circle Arrow Left</summary>
        ///<see href="https://fontawesome.com/icons/circle-arrow-left?style=solid"/>
        [Description("Solid Circle Arrow Left"), IconID("fas-circle-arrow-left"), IconUnicodeGlyph(0xf0a8)]
        SolidCircleArrowLeft = 376,
        ///<summary>Solid Circle Arrow Right</summary>
        ///<see href="https://fontawesome.com/icons/circle-arrow-right?style=solid"/>
        [Description("Solid Circle Arrow Right"), IconID("fas-circle-arrow-right"), IconUnicodeGlyph(0xf0a9)]
        SolidCircleArrowRight = 377,
        ///<summary>Solid Circle Arrow Up</summary>
        ///<see href="https://fontawesome.com/icons/circle-arrow-up?style=solid"/>
        [Description("Solid Circle Arrow Up"), IconID("fas-circle-arrow-up"), IconUnicodeGlyph(0xf0aa)]
        SolidCircleArrowUp = 378,
        ///<summary>Solid Circle Check</summary>
        ///<see href="https://fontawesome.com/icons/circle-check?style=solid"/>
        [Description("Solid Circle Check"), IconID("fas-circle-check"), IconUnicodeGlyph(0xf058)]
        SolidCircleCheck = 379,
        ///<summary>Regular Circle Check</summary>
        ///<see href="https://fontawesome.com/icons/circle-check?style=regular"/>
        [Description("Regular Circle Check"), IconID("far-circle-check"), IconUnicodeGlyph(0xf058)]
        RegularCircleCheck = 380,
        ///<summary>Solid Circle Chevron Down</summary>
        ///<see href="https://fontawesome.com/icons/circle-chevron-down?style=solid"/>
        [Description("Solid Circle Chevron Down"), IconID("fas-circle-chevron-down"), IconUnicodeGlyph(0xf13a)]
        SolidCircleChevronDown = 381,
        ///<summary>Solid Circle Chevron Left</summary>
        ///<see href="https://fontawesome.com/icons/circle-chevron-left?style=solid"/>
        [Description("Solid Circle Chevron Left"), IconID("fas-circle-chevron-left"), IconUnicodeGlyph(0xf137)]
        SolidCircleChevronLeft = 382,
        ///<summary>Solid Circle Chevron Right</summary>
        ///<see href="https://fontawesome.com/icons/circle-chevron-right?style=solid"/>
        [Description("Solid Circle Chevron Right"), IconID("fas-circle-chevron-right"), IconUnicodeGlyph(0xf138)]
        SolidCircleChevronRight = 383,
        ///<summary>Solid Circle Chevron Up</summary>
        ///<see href="https://fontawesome.com/icons/circle-chevron-up?style=solid"/>
        [Description("Solid Circle Chevron Up"), IconID("fas-circle-chevron-up"), IconUnicodeGlyph(0xf139)]
        SolidCircleChevronUp = 384,
        ///<summary>Solid Circle Dollar To Slot</summary>
        ///<see href="https://fontawesome.com/icons/circle-dollar-to-slot?style=solid"/>
        [Description("Solid Circle Dollar To Slot"), IconID("fas-circle-dollar-to-slot"), IconUnicodeGlyph(0xf4b9)]
        SolidCircleDollarToSlot = 385,
        ///<summary>Solid Circle Dot</summary>
        ///<see href="https://fontawesome.com/icons/circle-dot?style=solid"/>
        [Description("Solid Circle Dot"), IconID("fas-circle-dot"), IconUnicodeGlyph(0xf192)]
        SolidCircleDot = 386,
        ///<summary>Regular Circle Dot</summary>
        ///<see href="https://fontawesome.com/icons/circle-dot?style=regular"/>
        [Description("Regular Circle Dot"), IconID("far-circle-dot"), IconUnicodeGlyph(0xf192)]
        RegularCircleDot = 387,
        ///<summary>Solid Circle Down</summary>
        ///<see href="https://fontawesome.com/icons/circle-down?style=solid"/>
        [Description("Solid Circle Down"), IconID("fas-circle-down"), IconUnicodeGlyph(0xf358)]
        SolidCircleDown = 388,
        ///<summary>Regular Circle Down</summary>
        ///<see href="https://fontawesome.com/icons/circle-down?style=regular"/>
        [Description("Regular Circle Down"), IconID("far-circle-down"), IconUnicodeGlyph(0xf358)]
        RegularCircleDown = 389,
        ///<summary>Solid Circle Exclamation</summary>
        ///<see href="https://fontawesome.com/icons/circle-exclamation?style=solid"/>
        [Description("Solid Circle Exclamation"), IconID("fas-circle-exclamation"), IconUnicodeGlyph(0xf06a)]
        SolidCircleExclamation = 390,
        ///<summary>Solid Circle H</summary>
        ///<see href="https://fontawesome.com/icons/circle-h?style=solid"/>
        [Description("Solid Circle H"), IconID("fas-circle-h"), IconUnicodeGlyph(0xf47e)]
        SolidCircleH = 391,
        ///<summary>Solid Circle Half Stroke</summary>
        ///<see href="https://fontawesome.com/icons/circle-half-stroke?style=solid"/>
        [Description("Solid Circle Half Stroke"), IconID("fas-circle-half-stroke"), IconUnicodeGlyph(0xf042)]
        SolidCircleHalfStroke = 392,
        ///<summary>Solid Circle Info</summary>
        ///<see href="https://fontawesome.com/icons/circle-info?style=solid"/>
        [Description("Solid Circle Info"), IconID("fas-circle-info"), IconUnicodeGlyph(0xf05a)]
        SolidCircleInfo = 393,
        ///<summary>Solid Circle Left</summary>
        ///<see href="https://fontawesome.com/icons/circle-left?style=solid"/>
        [Description("Solid Circle Left"), IconID("fas-circle-left"), IconUnicodeGlyph(0xf359)]
        SolidCircleLeft = 394,
        ///<summary>Regular Circle Left</summary>
        ///<see href="https://fontawesome.com/icons/circle-left?style=regular"/>
        [Description("Regular Circle Left"), IconID("far-circle-left"), IconUnicodeGlyph(0xf359)]
        RegularCircleLeft = 395,
        ///<summary>Solid Circle Minus</summary>
        ///<see href="https://fontawesome.com/icons/circle-minus?style=solid"/>
        [Description("Solid Circle Minus"), IconID("fas-circle-minus"), IconUnicodeGlyph(0xf056)]
        SolidCircleMinus = 396,
        ///<summary>Solid Circle Nodes</summary>
        ///<see href="https://fontawesome.com/icons/circle-nodes?style=solid"/>
        [Description("Solid Circle Nodes"), IconID("fas-circle-nodes"), IconUnicodeGlyph(0xe4e2)]
        SolidCircleNodes = 397,
        ///<summary>Solid Circle Notch</summary>
        ///<see href="https://fontawesome.com/icons/circle-notch?style=solid"/>
        [Description("Solid Circle Notch"), IconID("fas-circle-notch"), IconUnicodeGlyph(0xf1ce)]
        SolidCircleNotch = 398,
        ///<summary>Solid Circle Pause</summary>
        ///<see href="https://fontawesome.com/icons/circle-pause?style=solid"/>
        [Description("Solid Circle Pause"), IconID("fas-circle-pause"), IconUnicodeGlyph(0xf28b)]
        SolidCirclePause = 399,
        ///<summary>Regular Circle Pause</summary>
        ///<see href="https://fontawesome.com/icons/circle-pause?style=regular"/>
        [Description("Regular Circle Pause"), IconID("far-circle-pause"), IconUnicodeGlyph(0xf28b)]
        RegularCirclePause = 400,
        ///<summary>Solid Circle Play</summary>
        ///<see href="https://fontawesome.com/icons/circle-play?style=solid"/>
        [Description("Solid Circle Play"), IconID("fas-circle-play"), IconUnicodeGlyph(0xf144)]
        SolidCirclePlay = 401,
        ///<summary>Regular Circle Play</summary>
        ///<see href="https://fontawesome.com/icons/circle-play?style=regular"/>
        [Description("Regular Circle Play"), IconID("far-circle-play"), IconUnicodeGlyph(0xf144)]
        RegularCirclePlay = 402,
        ///<summary>Solid Circle Plus</summary>
        ///<see href="https://fontawesome.com/icons/circle-plus?style=solid"/>
        [Description("Solid Circle Plus"), IconID("fas-circle-plus"), IconUnicodeGlyph(0xf055)]
        SolidCirclePlus = 403,
        ///<summary>Solid Circle Question</summary>
        ///<see href="https://fontawesome.com/icons/circle-question?style=solid"/>
        [Description("Solid Circle Question"), IconID("fas-circle-question"), IconUnicodeGlyph(0xf059)]
        SolidCircleQuestion = 404,
        ///<summary>Regular Circle Question</summary>
        ///<see href="https://fontawesome.com/icons/circle-question?style=regular"/>
        [Description("Regular Circle Question"), IconID("far-circle-question"), IconUnicodeGlyph(0xf059)]
        RegularCircleQuestion = 405,
        ///<summary>Solid Circle Radiation</summary>
        ///<see href="https://fontawesome.com/icons/circle-radiation?style=solid"/>
        [Description("Solid Circle Radiation"), IconID("fas-circle-radiation"), IconUnicodeGlyph(0xf7ba)]
        SolidCircleRadiation = 406,
        ///<summary>Solid Circle Right</summary>
        ///<see href="https://fontawesome.com/icons/circle-right?style=solid"/>
        [Description("Solid Circle Right"), IconID("fas-circle-right"), IconUnicodeGlyph(0xf35a)]
        SolidCircleRight = 407,
        ///<summary>Regular Circle Right</summary>
        ///<see href="https://fontawesome.com/icons/circle-right?style=regular"/>
        [Description("Regular Circle Right"), IconID("far-circle-right"), IconUnicodeGlyph(0xf35a)]
        RegularCircleRight = 408,
        ///<summary>Solid Circle Stop</summary>
        ///<see href="https://fontawesome.com/icons/circle-stop?style=solid"/>
        [Description("Solid Circle Stop"), IconID("fas-circle-stop"), IconUnicodeGlyph(0xf28d)]
        SolidCircleStop = 409,
        ///<summary>Regular Circle Stop</summary>
        ///<see href="https://fontawesome.com/icons/circle-stop?style=regular"/>
        [Description("Regular Circle Stop"), IconID("far-circle-stop"), IconUnicodeGlyph(0xf28d)]
        RegularCircleStop = 410,
        ///<summary>Solid Circle Up</summary>
        ///<see href="https://fontawesome.com/icons/circle-up?style=solid"/>
        [Description("Solid Circle Up"), IconID("fas-circle-up"), IconUnicodeGlyph(0xf35b)]
        SolidCircleUp = 411,
        ///<summary>Regular Circle Up</summary>
        ///<see href="https://fontawesome.com/icons/circle-up?style=regular"/>
        [Description("Regular Circle Up"), IconID("far-circle-up"), IconUnicodeGlyph(0xf35b)]
        RegularCircleUp = 412,
        ///<summary>Solid Circle User</summary>
        ///<see href="https://fontawesome.com/icons/circle-user?style=solid"/>
        [Description("Solid Circle User"), IconID("fas-circle-user"), IconUnicodeGlyph(0xf2bd)]
        SolidCircleUser = 413,
        ///<summary>Regular Circle User</summary>
        ///<see href="https://fontawesome.com/icons/circle-user?style=regular"/>
        [Description("Regular Circle User"), IconID("far-circle-user"), IconUnicodeGlyph(0xf2bd)]
        RegularCircleUser = 414,
        ///<summary>Solid Circle Xmark</summary>
        ///<see href="https://fontawesome.com/icons/circle-xmark?style=solid"/>
        [Description("Solid Circle Xmark"), IconID("fas-circle-xmark"), IconUnicodeGlyph(0xf057)]
        SolidCircleXmark = 415,
        ///<summary>Regular Circle Xmark</summary>
        ///<see href="https://fontawesome.com/icons/circle-xmark?style=regular"/>
        [Description("Regular Circle Xmark"), IconID("far-circle-xmark"), IconUnicodeGlyph(0xf057)]
        RegularCircleXmark = 416,
        ///<summary>Solid City</summary>
        ///<see href="https://fontawesome.com/icons/city?style=solid"/>
        [Description("Solid City"), IconID("fas-city"), IconUnicodeGlyph(0xf64f)]
        SolidCity = 417,
        ///<summary>Solid Clapperboard</summary>
        ///<see href="https://fontawesome.com/icons/clapperboard?style=solid"/>
        [Description("Solid Clapperboard"), IconID("fas-clapperboard"), IconUnicodeGlyph(0xe131)]
        SolidClapperboard = 418,
        ///<summary>Solid Clipboard</summary>
        ///<see href="https://fontawesome.com/icons/clipboard?style=solid"/>
        [Description("Solid Clipboard"), IconID("fas-clipboard"), IconUnicodeGlyph(0xf328)]
        SolidClipboard = 419,
        ///<summary>Regular Clipboard</summary>
        ///<see href="https://fontawesome.com/icons/clipboard?style=regular"/>
        [Description("Regular Clipboard"), IconID("far-clipboard"), IconUnicodeGlyph(0xf328)]
        RegularClipboard = 420,
        ///<summary>Solid Clipboard Check</summary>
        ///<see href="https://fontawesome.com/icons/clipboard-check?style=solid"/>
        [Description("Solid Clipboard Check"), IconID("fas-clipboard-check"), IconUnicodeGlyph(0xf46c)]
        SolidClipboardCheck = 421,
        ///<summary>Solid Clipboard List</summary>
        ///<see href="https://fontawesome.com/icons/clipboard-list?style=solid"/>
        [Description("Solid Clipboard List"), IconID("fas-clipboard-list"), IconUnicodeGlyph(0xf46d)]
        SolidClipboardList = 422,
        ///<summary>Solid Clipboard Question</summary>
        ///<see href="https://fontawesome.com/icons/clipboard-question?style=solid"/>
        [Description("Solid Clipboard Question"), IconID("fas-clipboard-question"), IconUnicodeGlyph(0xe4e3)]
        SolidClipboardQuestion = 423,
        ///<summary>Solid Clipboard User</summary>
        ///<see href="https://fontawesome.com/icons/clipboard-user?style=solid"/>
        [Description("Solid Clipboard User"), IconID("fas-clipboard-user"), IconUnicodeGlyph(0xf7f3)]
        SolidClipboardUser = 424,
        ///<summary>Solid Clock</summary>
        ///<see href="https://fontawesome.com/icons/clock?style=solid"/>
        [Description("Solid Clock"), IconID("fas-clock"), IconUnicodeGlyph(0xf017)]
        SolidClock = 425,
        ///<summary>Regular Clock</summary>
        ///<see href="https://fontawesome.com/icons/clock?style=regular"/>
        [Description("Regular Clock"), IconID("far-clock"), IconUnicodeGlyph(0xf017)]
        RegularClock = 426,
        ///<summary>Solid Clock Rotate Left</summary>
        ///<see href="https://fontawesome.com/icons/clock-rotate-left?style=solid"/>
        [Description("Solid Clock Rotate Left"), IconID("fas-clock-rotate-left"), IconUnicodeGlyph(0xf1da)]
        SolidClockRotateLeft = 427,
        ///<summary>Solid Clone</summary>
        ///<see href="https://fontawesome.com/icons/clone?style=solid"/>
        [Description("Solid Clone"), IconID("fas-clone"), IconUnicodeGlyph(0xf24d)]
        SolidClone = 428,
        ///<summary>Regular Clone</summary>
        ///<see href="https://fontawesome.com/icons/clone?style=regular"/>
        [Description("Regular Clone"), IconID("far-clone"), IconUnicodeGlyph(0xf24d)]
        RegularClone = 429,
        ///<summary>Solid Closed Captioning</summary>
        ///<see href="https://fontawesome.com/icons/closed-captioning?style=solid"/>
        [Description("Solid Closed Captioning"), IconID("fas-closed-captioning"), IconUnicodeGlyph(0xf20a)]
        SolidClosedCaptioning = 430,
        ///<summary>Regular Closed Captioning</summary>
        ///<see href="https://fontawesome.com/icons/closed-captioning?style=regular"/>
        [Description("Regular Closed Captioning"), IconID("far-closed-captioning"), IconUnicodeGlyph(0xf20a)]
        RegularClosedCaptioning = 431,
        ///<summary>Solid Cloud</summary>
        ///<see href="https://fontawesome.com/icons/cloud?style=solid"/>
        [Description("Solid Cloud"), IconID("fas-cloud"), IconUnicodeGlyph(0xf0c2)]
        SolidCloud = 432,
        ///<summary>Solid Cloud Arrow Down</summary>
        ///<see href="https://fontawesome.com/icons/cloud-arrow-down?style=solid"/>
        [Description("Solid Cloud Arrow Down"), IconID("fas-cloud-arrow-down"), IconUnicodeGlyph(0xf0ed)]
        SolidCloudArrowDown = 433,
        ///<summary>Solid Cloud Arrow Up</summary>
        ///<see href="https://fontawesome.com/icons/cloud-arrow-up?style=solid"/>
        [Description("Solid Cloud Arrow Up"), IconID("fas-cloud-arrow-up"), IconUnicodeGlyph(0xf0ee)]
        SolidCloudArrowUp = 434,
        ///<summary>Solid Cloud Bolt</summary>
        ///<see href="https://fontawesome.com/icons/cloud-bolt?style=solid"/>
        [Description("Solid Cloud Bolt"), IconID("fas-cloud-bolt"), IconUnicodeGlyph(0xf76c)]
        SolidCloudBolt = 435,
        ///<summary>Solid Cloud Meatball</summary>
        ///<see href="https://fontawesome.com/icons/cloud-meatball?style=solid"/>
        [Description("Solid Cloud Meatball"), IconID("fas-cloud-meatball"), IconUnicodeGlyph(0xf73b)]
        SolidCloudMeatball = 436,
        ///<summary>Solid Cloud Moon</summary>
        ///<see href="https://fontawesome.com/icons/cloud-moon?style=solid"/>
        [Description("Solid Cloud Moon"), IconID("fas-cloud-moon"), IconUnicodeGlyph(0xf6c3)]
        SolidCloudMoon = 437,
        ///<summary>Solid Cloud Moon Rain</summary>
        ///<see href="https://fontawesome.com/icons/cloud-moon-rain?style=solid"/>
        [Description("Solid Cloud Moon Rain"), IconID("fas-cloud-moon-rain"), IconUnicodeGlyph(0xf73c)]
        SolidCloudMoonRain = 438,
        ///<summary>Solid Cloud Rain</summary>
        ///<see href="https://fontawesome.com/icons/cloud-rain?style=solid"/>
        [Description("Solid Cloud Rain"), IconID("fas-cloud-rain"), IconUnicodeGlyph(0xf73d)]
        SolidCloudRain = 439,
        ///<summary>Solid Cloud Showers Heavy</summary>
        ///<see href="https://fontawesome.com/icons/cloud-showers-heavy?style=solid"/>
        [Description("Solid Cloud Showers Heavy"), IconID("fas-cloud-showers-heavy"), IconUnicodeGlyph(0xf740)]
        SolidCloudShowersHeavy = 440,
        ///<summary>Solid Cloud Showers Water</summary>
        ///<see href="https://fontawesome.com/icons/cloud-showers-water?style=solid"/>
        [Description("Solid Cloud Showers Water"), IconID("fas-cloud-showers-water"), IconUnicodeGlyph(0xe4e4)]
        SolidCloudShowersWater = 441,
        ///<summary>Solid Cloud Sun</summary>
        ///<see href="https://fontawesome.com/icons/cloud-sun?style=solid"/>
        [Description("Solid Cloud Sun"), IconID("fas-cloud-sun"), IconUnicodeGlyph(0xf6c4)]
        SolidCloudSun = 442,
        ///<summary>Solid Cloud Sun Rain</summary>
        ///<see href="https://fontawesome.com/icons/cloud-sun-rain?style=solid"/>
        [Description("Solid Cloud Sun Rain"), IconID("fas-cloud-sun-rain"), IconUnicodeGlyph(0xf743)]
        SolidCloudSunRain = 443,
        ///<summary>Brands Cloudflare</summary>
        ///<see href="https://fontawesome.com/icons/cloudflare?style=brands"/>
        [Description("Brands Cloudflare"), IconID("fab-cloudflare"), IconUnicodeGlyph(0xe07d)]
        BrandsCloudflare = 444,
        ///<summary>Brands cloudscale.ch</summary>
        ///<see href="https://fontawesome.com/icons/cloudscale?style=brands"/>
        [Description("Brands cloudscale.ch"), IconID("fab-cloudscale"), IconUnicodeGlyph(0xf383)]
        BrandsCloudscale = 445,
        ///<summary>Brands Cloudsmith</summary>
        ///<see href="https://fontawesome.com/icons/cloudsmith?style=brands"/>
        [Description("Brands Cloudsmith"), IconID("fab-cloudsmith"), IconUnicodeGlyph(0xf384)]
        BrandsCloudsmith = 446,
        ///<summary>Brands cloudversify</summary>
        ///<see href="https://fontawesome.com/icons/cloudversify?style=brands"/>
        [Description("Brands cloudversify"), IconID("fab-cloudversify"), IconUnicodeGlyph(0xf385)]
        BrandsCloudversify = 447,
        ///<summary>Solid Clover</summary>
        ///<see href="https://fontawesome.com/icons/clover?style=solid"/>
        [Description("Solid Clover"), IconID("fas-clover"), IconUnicodeGlyph(0xe139)]
        SolidClover = 448,
        ///<summary>Brands Cmplid</summary>
        ///<see href="https://fontawesome.com/icons/cmplid?style=brands"/>
        [Description("Brands Cmplid"), IconID("fab-cmplid"), IconUnicodeGlyph(0xe360)]
        BrandsCmplid = 449,
        ///<summary>Solid Code</summary>
        ///<see href="https://fontawesome.com/icons/code?style=solid"/>
        [Description("Solid Code"), IconID("fas-code"), IconUnicodeGlyph(0xf121)]
        SolidCode = 450,
        ///<summary>Solid Code Branch</summary>
        ///<see href="https://fontawesome.com/icons/code-branch?style=solid"/>
        [Description("Solid Code Branch"), IconID("fas-code-branch"), IconUnicodeGlyph(0xf126)]
        SolidCodeBranch = 451,
        ///<summary>Solid Code Commit</summary>
        ///<see href="https://fontawesome.com/icons/code-commit?style=solid"/>
        [Description("Solid Code Commit"), IconID("fas-code-commit"), IconUnicodeGlyph(0xf386)]
        SolidCodeCommit = 452,
        ///<summary>Solid Code Compare</summary>
        ///<see href="https://fontawesome.com/icons/code-compare?style=solid"/>
        [Description("Solid Code Compare"), IconID("fas-code-compare"), IconUnicodeGlyph(0xe13a)]
        SolidCodeCompare = 453,
        ///<summary>Solid Code Fork</summary>
        ///<see href="https://fontawesome.com/icons/code-fork?style=solid"/>
        [Description("Solid Code Fork"), IconID("fas-code-fork"), IconUnicodeGlyph(0xe13b)]
        SolidCodeFork = 454,
        ///<summary>Solid Code Merge</summary>
        ///<see href="https://fontawesome.com/icons/code-merge?style=solid"/>
        [Description("Solid Code Merge"), IconID("fas-code-merge"), IconUnicodeGlyph(0xf387)]
        SolidCodeMerge = 455,
        ///<summary>Solid Code Pull Request</summary>
        ///<see href="https://fontawesome.com/icons/code-pull-request?style=solid"/>
        [Description("Solid Code Pull Request"), IconID("fas-code-pull-request"), IconUnicodeGlyph(0xe13c)]
        SolidCodePullRequest = 456,
        ///<summary>Brands Codepen</summary>
        ///<see href="https://fontawesome.com/icons/codepen?style=brands"/>
        [Description("Brands Codepen"), IconID("fab-codepen"), IconUnicodeGlyph(0xf1cb)]
        BrandsCodepen = 457,
        ///<summary>Brands Codie Pie</summary>
        ///<see href="https://fontawesome.com/icons/codiepie?style=brands"/>
        [Description("Brands Codie Pie"), IconID("fab-codiepie"), IconUnicodeGlyph(0xf284)]
        BrandsCodiepie = 458,
        ///<summary>Solid Coins</summary>
        ///<see href="https://fontawesome.com/icons/coins?style=solid"/>
        [Description("Solid Coins"), IconID("fas-coins"), IconUnicodeGlyph(0xf51e)]
        SolidCoins = 459,
        ///<summary>Solid Colon Sign</summary>
        ///<see href="https://fontawesome.com/icons/colon-sign?style=solid"/>
        [Description("Solid Colon Sign"), IconID("fas-colon-sign"), IconUnicodeGlyph(0xe140)]
        SolidColonSign = 460,
        ///<summary>Solid Comment</summary>
        ///<see href="https://fontawesome.com/icons/comment?style=solid"/>
        [Description("Solid Comment"), IconID("fas-comment"), IconUnicodeGlyph(0xf075)]
        SolidComment = 461,
        ///<summary>Regular Comment</summary>
        ///<see href="https://fontawesome.com/icons/comment?style=regular"/>
        [Description("Regular Comment"), IconID("far-comment"), IconUnicodeGlyph(0xf075)]
        RegularComment = 462,
        ///<summary>Solid Comment Dollar</summary>
        ///<see href="https://fontawesome.com/icons/comment-dollar?style=solid"/>
        [Description("Solid Comment Dollar"), IconID("fas-comment-dollar"), IconUnicodeGlyph(0xf651)]
        SolidCommentDollar = 463,
        ///<summary>Solid Comment Dots</summary>
        ///<see href="https://fontawesome.com/icons/comment-dots?style=solid"/>
        [Description("Solid Comment Dots"), IconID("fas-comment-dots"), IconUnicodeGlyph(0xf4ad)]
        SolidCommentDots = 464,
        ///<summary>Regular Comment Dots</summary>
        ///<see href="https://fontawesome.com/icons/comment-dots?style=regular"/>
        [Description("Regular Comment Dots"), IconID("far-comment-dots"), IconUnicodeGlyph(0xf4ad)]
        RegularCommentDots = 465,
        ///<summary>Solid Comment Medical</summary>
        ///<see href="https://fontawesome.com/icons/comment-medical?style=solid"/>
        [Description("Solid Comment Medical"), IconID("fas-comment-medical"), IconUnicodeGlyph(0xf7f5)]
        SolidCommentMedical = 466,
        ///<summary>Solid Comment Nodes</summary>
        ///<see href="https://fontawesome.com/icons/comment-nodes?style=solid"/>
        [Description("Solid Comment Nodes"), IconID("fas-comment-nodes"), IconUnicodeGlyph(0xe696)]
        SolidCommentNodes = 467,
        ///<summary>Solid Comment Slash</summary>
        ///<see href="https://fontawesome.com/icons/comment-slash?style=solid"/>
        [Description("Solid Comment Slash"), IconID("fas-comment-slash"), IconUnicodeGlyph(0xf4b3)]
        SolidCommentSlash = 468,
        ///<summary>Solid Comment Sms</summary>
        ///<see href="https://fontawesome.com/icons/comment-sms?style=solid"/>
        [Description("Solid Comment Sms"), IconID("fas-comment-sms"), IconUnicodeGlyph(0xf7cd)]
        SolidCommentSms = 469,
        ///<summary>Solid Comments</summary>
        ///<see href="https://fontawesome.com/icons/comments?style=solid"/>
        [Description("Solid Comments"), IconID("fas-comments"), IconUnicodeGlyph(0xf086)]
        SolidComments = 470,
        ///<summary>Regular Comments</summary>
        ///<see href="https://fontawesome.com/icons/comments?style=regular"/>
        [Description("Regular Comments"), IconID("far-comments"), IconUnicodeGlyph(0xf086)]
        RegularComments = 471,
        ///<summary>Solid Comments Dollar</summary>
        ///<see href="https://fontawesome.com/icons/comments-dollar?style=solid"/>
        [Description("Solid Comments Dollar"), IconID("fas-comments-dollar"), IconUnicodeGlyph(0xf653)]
        SolidCommentsDollar = 472,
        ///<summary>Solid Compact Disc</summary>
        ///<see href="https://fontawesome.com/icons/compact-disc?style=solid"/>
        [Description("Solid Compact Disc"), IconID("fas-compact-disc"), IconUnicodeGlyph(0xf51f)]
        SolidCompactDisc = 473,
        ///<summary>Solid Compass</summary>
        ///<see href="https://fontawesome.com/icons/compass?style=solid"/>
        [Description("Solid Compass"), IconID("fas-compass"), IconUnicodeGlyph(0xf14e)]
        SolidCompass = 474,
        ///<summary>Regular Compass</summary>
        ///<see href="https://fontawesome.com/icons/compass?style=regular"/>
        [Description("Regular Compass"), IconID("far-compass"), IconUnicodeGlyph(0xf14e)]
        RegularCompass = 475,
        ///<summary>Solid Compass Drafting</summary>
        ///<see href="https://fontawesome.com/icons/compass-drafting?style=solid"/>
        [Description("Solid Compass Drafting"), IconID("fas-compass-drafting"), IconUnicodeGlyph(0xf568)]
        SolidCompassDrafting = 476,
        ///<summary>Solid Compress</summary>
        ///<see href="https://fontawesome.com/icons/compress?style=solid"/>
        [Description("Solid Compress"), IconID("fas-compress"), IconUnicodeGlyph(0xf066)]
        SolidCompress = 477,
        ///<summary>Solid Computer</summary>
        ///<see href="https://fontawesome.com/icons/computer?style=solid"/>
        [Description("Solid Computer"), IconID("fas-computer"), IconUnicodeGlyph(0xe4e5)]
        SolidComputer = 478,
        ///<summary>Solid Computer Mouse</summary>
        ///<see href="https://fontawesome.com/icons/computer-mouse?style=solid"/>
        [Description("Solid Computer Mouse"), IconID("fas-computer-mouse"), IconUnicodeGlyph(0xf8cc)]
        SolidComputerMouse = 479,
        ///<summary>Brands Confluence</summary>
        ///<see href="https://fontawesome.com/icons/confluence?style=brands"/>
        [Description("Brands Confluence"), IconID("fab-confluence"), IconUnicodeGlyph(0xf78d)]
        BrandsConfluence = 480,
        ///<summary>Brands Connect Develop</summary>
        ///<see href="https://fontawesome.com/icons/connectdevelop?style=brands"/>
        [Description("Brands Connect Develop"), IconID("fab-connectdevelop"), IconUnicodeGlyph(0xf20e)]
        BrandsConnectdevelop = 481,
        ///<summary>Brands Contao</summary>
        ///<see href="https://fontawesome.com/icons/contao?style=brands"/>
        [Description("Brands Contao"), IconID("fab-contao"), IconUnicodeGlyph(0xf26d)]
        BrandsContao = 482,
        ///<summary>Solid Cookie</summary>
        ///<see href="https://fontawesome.com/icons/cookie?style=solid"/>
        [Description("Solid Cookie"), IconID("fas-cookie"), IconUnicodeGlyph(0xf563)]
        SolidCookie = 483,
        ///<summary>Solid Cookie Bite</summary>
        ///<see href="https://fontawesome.com/icons/cookie-bite?style=solid"/>
        [Description("Solid Cookie Bite"), IconID("fas-cookie-bite"), IconUnicodeGlyph(0xf564)]
        SolidCookieBite = 484,
        ///<summary>Solid Copy</summary>
        ///<see href="https://fontawesome.com/icons/copy?style=solid"/>
        [Description("Solid Copy"), IconID("fas-copy"), IconUnicodeGlyph(0xf0c5)]
        SolidCopy = 485,
        ///<summary>Regular Copy</summary>
        ///<see href="https://fontawesome.com/icons/copy?style=regular"/>
        [Description("Regular Copy"), IconID("far-copy"), IconUnicodeGlyph(0xf0c5)]
        RegularCopy = 486,
        ///<summary>Solid Copyright</summary>
        ///<see href="https://fontawesome.com/icons/copyright?style=solid"/>
        [Description("Solid Copyright"), IconID("fas-copyright"), IconUnicodeGlyph(0xf1f9)]
        SolidCopyright = 487,
        ///<summary>Regular Copyright</summary>
        ///<see href="https://fontawesome.com/icons/copyright?style=regular"/>
        [Description("Regular Copyright"), IconID("far-copyright"), IconUnicodeGlyph(0xf1f9)]
        RegularCopyright = 488,
        ///<summary>Brands Cotton Bureau</summary>
        ///<see href="https://fontawesome.com/icons/cotton-bureau?style=brands"/>
        [Description("Brands Cotton Bureau"), IconID("fab-cotton-bureau"), IconUnicodeGlyph(0xf89e)]
        BrandsCottonBureau = 489,
        ///<summary>Solid Couch</summary>
        ///<see href="https://fontawesome.com/icons/couch?style=solid"/>
        [Description("Solid Couch"), IconID("fas-couch"), IconUnicodeGlyph(0xf4b8)]
        SolidCouch = 490,
        ///<summary>Solid Cow</summary>
        ///<see href="https://fontawesome.com/icons/cow?style=solid"/>
        [Description("Solid Cow"), IconID("fas-cow"), IconUnicodeGlyph(0xf6c8)]
        SolidCow = 491,
        ///<summary>Brands cPanel</summary>
        ///<see href="https://fontawesome.com/icons/cpanel?style=brands"/>
        [Description("Brands cPanel"), IconID("fab-cpanel"), IconUnicodeGlyph(0xf388)]
        BrandsCpanel = 492,
        ///<summary>Brands Creative Commons</summary>
        ///<see href="https://fontawesome.com/icons/creative-commons?style=brands"/>
        [Description("Brands Creative Commons"), IconID("fab-creative-commons"), IconUnicodeGlyph(0xf25e)]
        BrandsCreativeCommons = 493,
        ///<summary>Brands Creative Commons Attribution</summary>
        ///<see href="https://fontawesome.com/icons/creative-commons-by?style=brands"/>
        [Description("Brands Creative Commons Attribution"), IconID("fab-creative-commons-by"), IconUnicodeGlyph(0xf4e7)]
        BrandsCreativeCommonsBy = 494,
        ///<summary>Brands Creative Commons Noncommercial</summary>
        ///<see href="https://fontawesome.com/icons/creative-commons-nc?style=brands"/>
        [Description("Brands Creative Commons Noncommercial"), IconID("fab-creative-commons-nc"), IconUnicodeGlyph(0xf4e8)]
        BrandsCreativeCommonsNc = 495,
        ///<summary>Brands Creative Commons Noncommercial (Euro Sign)</summary>
        ///<see href="https://fontawesome.com/icons/creative-commons-nc-eu?style=brands"/>
        [Description("Brands Creative Commons Noncommercial (Euro Sign)"), IconID("fab-creative-commons-nc-eu"), IconUnicodeGlyph(0xf4e9)]
        BrandsCreativeCommonsNcEu = 496,
        ///<summary>Brands Creative Commons Noncommercial (Yen Sign)</summary>
        ///<see href="https://fontawesome.com/icons/creative-commons-nc-jp?style=brands"/>
        [Description("Brands Creative Commons Noncommercial (Yen Sign)"), IconID("fab-creative-commons-nc-jp"), IconUnicodeGlyph(0xf4ea)]
        BrandsCreativeCommonsNcJp = 497,
        ///<summary>Brands Creative Commons No Derivative Works</summary>
        ///<see href="https://fontawesome.com/icons/creative-commons-nd?style=brands"/>
        [Description("Brands Creative Commons No Derivative Works"), IconID("fab-creative-commons-nd"), IconUnicodeGlyph(0xf4eb)]
        BrandsCreativeCommonsNd = 498,
        ///<summary>Brands Creative Commons Public Domain</summary>
        ///<see href="https://fontawesome.com/icons/creative-commons-pd?style=brands"/>
        [Description("Brands Creative Commons Public Domain"), IconID("fab-creative-commons-pd"), IconUnicodeGlyph(0xf4ec)]
        BrandsCreativeCommonsPd = 499,
        ///<summary>Brands Alternate Creative Commons Public Domain</summary>
        ///<see href="https://fontawesome.com/icons/creative-commons-pd-alt?style=brands"/>
        [Description("Brands Alternate Creative Commons Public Domain"), IconID("fab-creative-commons-pd-alt"), IconUnicodeGlyph(0xf4ed)]
        BrandsCreativeCommonsPdAlt = 500,
        ///<summary>Brands Creative Commons Remix</summary>
        ///<see href="https://fontawesome.com/icons/creative-commons-remix?style=brands"/>
        [Description("Brands Creative Commons Remix"), IconID("fab-creative-commons-remix"), IconUnicodeGlyph(0xf4ee)]
        BrandsCreativeCommonsRemix = 501,
        ///<summary>Brands Creative Commons Share Alike</summary>
        ///<see href="https://fontawesome.com/icons/creative-commons-sa?style=brands"/>
        [Description("Brands Creative Commons Share Alike"), IconID("fab-creative-commons-sa"), IconUnicodeGlyph(0xf4ef)]
        BrandsCreativeCommonsSa = 502,
        ///<summary>Brands Creative Commons Sampling</summary>
        ///<see href="https://fontawesome.com/icons/creative-commons-sampling?style=brands"/>
        [Description("Brands Creative Commons Sampling"), IconID("fab-creative-commons-sampling"), IconUnicodeGlyph(0xf4f0)]
        BrandsCreativeCommonsSampling = 503,
        ///<summary>Brands Creative Commons Sampling +</summary>
        ///<see href="https://fontawesome.com/icons/creative-commons-sampling-plus?style=brands"/>
        [Description("Brands Creative Commons Sampling +"), IconID("fab-creative-commons-sampling-plus"), IconUnicodeGlyph(0xf4f1)]
        BrandsCreativeCommonsSamplingPlus = 504,
        ///<summary>Brands Creative Commons Share</summary>
        ///<see href="https://fontawesome.com/icons/creative-commons-share?style=brands"/>
        [Description("Brands Creative Commons Share"), IconID("fab-creative-commons-share"), IconUnicodeGlyph(0xf4f2)]
        BrandsCreativeCommonsShare = 505,
        ///<summary>Brands Creative Commons CC0</summary>
        ///<see href="https://fontawesome.com/icons/creative-commons-zero?style=brands"/>
        [Description("Brands Creative Commons CC0"), IconID("fab-creative-commons-zero"), IconUnicodeGlyph(0xf4f3)]
        BrandsCreativeCommonsZero = 506,
        ///<summary>Solid Credit Card</summary>
        ///<see href="https://fontawesome.com/icons/credit-card?style=solid"/>
        [Description("Solid Credit Card"), IconID("fas-credit-card"), IconUnicodeGlyph(0xf09d)]
        SolidCreditCard = 507,
        ///<summary>Regular Credit Card</summary>
        ///<see href="https://fontawesome.com/icons/credit-card?style=regular"/>
        [Description("Regular Credit Card"), IconID("far-credit-card"), IconUnicodeGlyph(0xf09d)]
        RegularCreditCard = 508,
        ///<summary>Brands Critical Role</summary>
        ///<see href="https://fontawesome.com/icons/critical-role?style=brands"/>
        [Description("Brands Critical Role"), IconID("fab-critical-role"), IconUnicodeGlyph(0xf6c9)]
        BrandsCriticalRole = 509,
        ///<summary>Solid Crop</summary>
        ///<see href="https://fontawesome.com/icons/crop?style=solid"/>
        [Description("Solid Crop"), IconID("fas-crop"), IconUnicodeGlyph(0xf125)]
        SolidCrop = 510,
        ///<summary>Solid Crop Simple</summary>
        ///<see href="https://fontawesome.com/icons/crop-simple?style=solid"/>
        [Description("Solid Crop Simple"), IconID("fas-crop-simple"), IconUnicodeGlyph(0xf565)]
        SolidCropSimple = 511,
        ///<summary>Solid Cross</summary>
        ///<see href="https://fontawesome.com/icons/cross?style=solid"/>
        [Description("Solid Cross"), IconID("fas-cross"), IconUnicodeGlyph(0xf654)]
        SolidCross = 512,
        ///<summary>Solid Crosshairs</summary>
        ///<see href="https://fontawesome.com/icons/crosshairs?style=solid"/>
        [Description("Solid Crosshairs"), IconID("fas-crosshairs"), IconUnicodeGlyph(0xf05b)]
        SolidCrosshairs = 513,
        ///<summary>Solid Crow</summary>
        ///<see href="https://fontawesome.com/icons/crow?style=solid"/>
        [Description("Solid Crow"), IconID("fas-crow"), IconUnicodeGlyph(0xf520)]
        SolidCrow = 514,
        ///<summary>Solid Crown</summary>
        ///<see href="https://fontawesome.com/icons/crown?style=solid"/>
        [Description("Solid Crown"), IconID("fas-crown"), IconUnicodeGlyph(0xf521)]
        SolidCrown = 515,
        ///<summary>Solid Crutch</summary>
        ///<see href="https://fontawesome.com/icons/crutch?style=solid"/>
        [Description("Solid Crutch"), IconID("fas-crutch"), IconUnicodeGlyph(0xf7f7)]
        SolidCrutch = 516,
        ///<summary>Solid Cruzeiro Sign</summary>
        ///<see href="https://fontawesome.com/icons/cruzeiro-sign?style=solid"/>
        [Description("Solid Cruzeiro Sign"), IconID("fas-cruzeiro-sign"), IconUnicodeGlyph(0xe152)]
        SolidCruzeiroSign = 517,
        ///<summary>Brands Css</summary>
        ///<see href="https://fontawesome.com/icons/css?style=brands"/>
        [Description("Brands Css"), IconID("fab-css"), IconUnicodeGlyph(0xe6a2)]
        BrandsCss = 518,
        ///<summary>Brands CSS 3 Logo</summary>
        ///<see href="https://fontawesome.com/icons/css3?style=brands"/>
        [Description("Brands CSS 3 Logo"), IconID("fab-css3"), IconUnicodeGlyph(0xf13c)]
        BrandsCss3 = 519,
        ///<summary>Brands Alternate CSS3 Logo</summary>
        ///<see href="https://fontawesome.com/icons/css3-alt?style=brands"/>
        [Description("Brands Alternate CSS3 Logo"), IconID("fab-css3-alt"), IconUnicodeGlyph(0xf38b)]
        BrandsCss3Alt = 520,
        ///<summary>Solid Cube</summary>
        ///<see href="https://fontawesome.com/icons/cube?style=solid"/>
        [Description("Solid Cube"), IconID("fas-cube"), IconUnicodeGlyph(0xf1b2)]
        SolidCube = 521,
        ///<summary>Solid Cubes</summary>
        ///<see href="https://fontawesome.com/icons/cubes?style=solid"/>
        [Description("Solid Cubes"), IconID("fas-cubes"), IconUnicodeGlyph(0xf1b3)]
        SolidCubes = 522,
        ///<summary>Solid Cubes Stacked</summary>
        ///<see href="https://fontawesome.com/icons/cubes-stacked?style=solid"/>
        [Description("Solid Cubes Stacked"), IconID("fas-cubes-stacked"), IconUnicodeGlyph(0xe4e6)]
        SolidCubesStacked = 523,
        ///<summary>Brands Cuttlefish</summary>
        ///<see href="https://fontawesome.com/icons/cuttlefish?style=brands"/>
        [Description("Brands Cuttlefish"), IconID("fab-cuttlefish"), IconUnicodeGlyph(0xf38c)]
        BrandsCuttlefish = 524,
        ///<summary>Solid D</summary>
        ///<see href="https://fontawesome.com/icons/d?style=solid"/>
        [Description("Solid D"), IconID("fas-d"), IconUnicodeGlyph(0x44)]
        SolidD = 525,
        ///<summary>Brands Dungeons & Dragons</summary>
        ///<see href="https://fontawesome.com/icons/d-and-d?style=brands"/>
        [Description("Brands Dungeons & Dragons"), IconID("fab-d-and-d"), IconUnicodeGlyph(0xf38d)]
        BrandsDAndD = 526,
        ///<summary>Brands D&D Beyond</summary>
        ///<see href="https://fontawesome.com/icons/d-and-d-beyond?style=brands"/>
        [Description("Brands D&D Beyond"), IconID("fab-d-and-d-beyond"), IconUnicodeGlyph(0xf6ca)]
        BrandsDAndDBeyond = 527,
        ///<summary>Brands dailymotion</summary>
        ///<see href="https://fontawesome.com/icons/dailymotion?style=brands"/>
        [Description("Brands dailymotion"), IconID("fab-dailymotion"), IconUnicodeGlyph(0xe052)]
        BrandsDailymotion = 528,
        ///<summary>Brands Dart Lang</summary>
        ///<see href="https://fontawesome.com/icons/dart-lang?style=brands"/>
        [Description("Brands Dart Lang"), IconID("fab-dart-lang"), IconUnicodeGlyph(0xe693)]
        BrandsDartLang = 529,
        ///<summary>Brands DashCube</summary>
        ///<see href="https://fontawesome.com/icons/dashcube?style=brands"/>
        [Description("Brands DashCube"), IconID("fab-dashcube"), IconUnicodeGlyph(0xf210)]
        BrandsDashcube = 530,
        ///<summary>Solid Database</summary>
        ///<see href="https://fontawesome.com/icons/database?style=solid"/>
        [Description("Solid Database"), IconID("fas-database"), IconUnicodeGlyph(0xf1c0)]
        SolidDatabase = 531,
        ///<summary>Brands Debian</summary>
        ///<see href="https://fontawesome.com/icons/debian?style=brands"/>
        [Description("Brands Debian"), IconID("fab-debian"), IconUnicodeGlyph(0xe60b)]
        BrandsDebian = 532,
        ///<summary>Brands Deezer</summary>
        ///<see href="https://fontawesome.com/icons/deezer?style=brands"/>
        [Description("Brands Deezer"), IconID("fab-deezer"), IconUnicodeGlyph(0xe077)]
        BrandsDeezer = 533,
        ///<summary>Solid Delete Left</summary>
        ///<see href="https://fontawesome.com/icons/delete-left?style=solid"/>
        [Description("Solid Delete Left"), IconID("fas-delete-left"), IconUnicodeGlyph(0xf55a)]
        SolidDeleteLeft = 534,
        ///<summary>Brands Delicious</summary>
        ///<see href="https://fontawesome.com/icons/delicious?style=brands"/>
        [Description("Brands Delicious"), IconID("fab-delicious"), IconUnicodeGlyph(0xf1a5)]
        BrandsDelicious = 535,
        ///<summary>Solid Democrat</summary>
        ///<see href="https://fontawesome.com/icons/democrat?style=solid"/>
        [Description("Solid Democrat"), IconID("fas-democrat"), IconUnicodeGlyph(0xf747)]
        SolidDemocrat = 536,
        ///<summary>Brands deploy.dog</summary>
        ///<see href="https://fontawesome.com/icons/deploydog?style=brands"/>
        [Description("Brands deploy.dog"), IconID("fab-deploydog"), IconUnicodeGlyph(0xf38e)]
        BrandsDeploydog = 537,
        ///<summary>Brands Deskpro</summary>
        ///<see href="https://fontawesome.com/icons/deskpro?style=brands"/>
        [Description("Brands Deskpro"), IconID("fab-deskpro"), IconUnicodeGlyph(0xf38f)]
        BrandsDeskpro = 538,
        ///<summary>Solid Desktop</summary>
        ///<see href="https://fontawesome.com/icons/desktop?style=solid"/>
        [Description("Solid Desktop"), IconID("fas-desktop"), IconUnicodeGlyph(0xf390)]
        SolidDesktop = 539,
        ///<summary>Brands DEV</summary>
        ///<see href="https://fontawesome.com/icons/dev?style=brands"/>
        [Description("Brands DEV"), IconID("fab-dev"), IconUnicodeGlyph(0xf6cc)]
        BrandsDev = 540,
        ///<summary>Brands deviantART</summary>
        ///<see href="https://fontawesome.com/icons/deviantart?style=brands"/>
        [Description("Brands deviantART"), IconID("fab-deviantart"), IconUnicodeGlyph(0xf1bd)]
        BrandsDeviantart = 541,
        ///<summary>Solid Dharmachakra</summary>
        ///<see href="https://fontawesome.com/icons/dharmachakra?style=solid"/>
        [Description("Solid Dharmachakra"), IconID("fas-dharmachakra"), IconUnicodeGlyph(0xf655)]
        SolidDharmachakra = 542,
        ///<summary>Brands DHL</summary>
        ///<see href="https://fontawesome.com/icons/dhl?style=brands"/>
        [Description("Brands DHL"), IconID("fab-dhl"), IconUnicodeGlyph(0xf790)]
        BrandsDhl = 543,
        ///<summary>Solid Diagram Next</summary>
        ///<see href="https://fontawesome.com/icons/diagram-next?style=solid"/>
        [Description("Solid Diagram Next"), IconID("fas-diagram-next"), IconUnicodeGlyph(0xe476)]
        SolidDiagramNext = 544,
        ///<summary>Solid Diagram Predecessor</summary>
        ///<see href="https://fontawesome.com/icons/diagram-predecessor?style=solid"/>
        [Description("Solid Diagram Predecessor"), IconID("fas-diagram-predecessor"), IconUnicodeGlyph(0xe477)]
        SolidDiagramPredecessor = 545,
        ///<summary>Solid Diagram Project</summary>
        ///<see href="https://fontawesome.com/icons/diagram-project?style=solid"/>
        [Description("Solid Diagram Project"), IconID("fas-diagram-project"), IconUnicodeGlyph(0xf542)]
        SolidDiagramProject = 546,
        ///<summary>Solid Diagram Successor</summary>
        ///<see href="https://fontawesome.com/icons/diagram-successor?style=solid"/>
        [Description("Solid Diagram Successor"), IconID("fas-diagram-successor"), IconUnicodeGlyph(0xe47a)]
        SolidDiagramSuccessor = 547,
        ///<summary>Solid Diamond</summary>
        ///<see href="https://fontawesome.com/icons/diamond?style=solid"/>
        [Description("Solid Diamond"), IconID("fas-diamond"), IconUnicodeGlyph(0xf219)]
        SolidDiamond = 548,
        ///<summary>Solid Diamond Turn Right</summary>
        ///<see href="https://fontawesome.com/icons/diamond-turn-right?style=solid"/>
        [Description("Solid Diamond Turn Right"), IconID("fas-diamond-turn-right"), IconUnicodeGlyph(0xf5eb)]
        SolidDiamondTurnRight = 549,
        ///<summary>Brands Diaspora</summary>
        ///<see href="https://fontawesome.com/icons/diaspora?style=brands"/>
        [Description("Brands Diaspora"), IconID("fab-diaspora"), IconUnicodeGlyph(0xf791)]
        BrandsDiaspora = 550,
        ///<summary>Solid Dice</summary>
        ///<see href="https://fontawesome.com/icons/dice?style=solid"/>
        [Description("Solid Dice"), IconID("fas-dice"), IconUnicodeGlyph(0xf522)]
        SolidDice = 551,
        ///<summary>Solid Dice D20</summary>
        ///<see href="https://fontawesome.com/icons/dice-d20?style=solid"/>
        [Description("Solid Dice D20"), IconID("fas-dice-d20"), IconUnicodeGlyph(0xf6cf)]
        SolidDiceD20 = 552,
        ///<summary>Solid Dice D6</summary>
        ///<see href="https://fontawesome.com/icons/dice-d6?style=solid"/>
        [Description("Solid Dice D6"), IconID("fas-dice-d6"), IconUnicodeGlyph(0xf6d1)]
        SolidDiceD6 = 553,
        ///<summary>Solid Dice Five</summary>
        ///<see href="https://fontawesome.com/icons/dice-five?style=solid"/>
        [Description("Solid Dice Five"), IconID("fas-dice-five"), IconUnicodeGlyph(0xf523)]
        SolidDiceFive = 554,
        ///<summary>Solid Dice Four</summary>
        ///<see href="https://fontawesome.com/icons/dice-four?style=solid"/>
        [Description("Solid Dice Four"), IconID("fas-dice-four"), IconUnicodeGlyph(0xf524)]
        SolidDiceFour = 555,
        ///<summary>Solid Dice One</summary>
        ///<see href="https://fontawesome.com/icons/dice-one?style=solid"/>
        [Description("Solid Dice One"), IconID("fas-dice-one"), IconUnicodeGlyph(0xf525)]
        SolidDiceOne = 556,
        ///<summary>Solid Dice Six</summary>
        ///<see href="https://fontawesome.com/icons/dice-six?style=solid"/>
        [Description("Solid Dice Six"), IconID("fas-dice-six"), IconUnicodeGlyph(0xf526)]
        SolidDiceSix = 557,
        ///<summary>Solid Dice Three</summary>
        ///<see href="https://fontawesome.com/icons/dice-three?style=solid"/>
        [Description("Solid Dice Three"), IconID("fas-dice-three"), IconUnicodeGlyph(0xf527)]
        SolidDiceThree = 558,
        ///<summary>Solid Dice Two</summary>
        ///<see href="https://fontawesome.com/icons/dice-two?style=solid"/>
        [Description("Solid Dice Two"), IconID("fas-dice-two"), IconUnicodeGlyph(0xf528)]
        SolidDiceTwo = 559,
        ///<summary>Brands Digg Logo</summary>
        ///<see href="https://fontawesome.com/icons/digg?style=brands"/>
        [Description("Brands Digg Logo"), IconID("fab-digg"), IconUnicodeGlyph(0xf1a6)]
        BrandsDigg = 560,
        ///<summary>Brands Digital Ocean</summary>
        ///<see href="https://fontawesome.com/icons/digital-ocean?style=brands"/>
        [Description("Brands Digital Ocean"), IconID("fab-digital-ocean"), IconUnicodeGlyph(0xf391)]
        BrandsDigitalOcean = 561,
        ///<summary>Brands Discord</summary>
        ///<see href="https://fontawesome.com/icons/discord?style=brands"/>
        [Description("Brands Discord"), IconID("fab-discord"), IconUnicodeGlyph(0xf392)]
        BrandsDiscord = 562,
        ///<summary>Brands Discourse</summary>
        ///<see href="https://fontawesome.com/icons/discourse?style=brands"/>
        [Description("Brands Discourse"), IconID("fab-discourse"), IconUnicodeGlyph(0xf393)]
        BrandsDiscourse = 563,
        ///<summary>Solid Disease</summary>
        ///<see href="https://fontawesome.com/icons/disease?style=solid"/>
        [Description("Solid Disease"), IconID("fas-disease"), IconUnicodeGlyph(0xf7fa)]
        SolidDisease = 564,
        ///<summary>Solid Display</summary>
        ///<see href="https://fontawesome.com/icons/display?style=solid"/>
        [Description("Solid Display"), IconID("fas-display"), IconUnicodeGlyph(0xe163)]
        SolidDisplay = 565,
        ///<summary>Solid Divide</summary>
        ///<see href="https://fontawesome.com/icons/divide?style=solid"/>
        [Description("Solid Divide"), IconID("fas-divide"), IconUnicodeGlyph(0xf529)]
        SolidDivide = 566,
        ///<summary>Solid Dna</summary>
        ///<see href="https://fontawesome.com/icons/dna?style=solid"/>
        [Description("Solid Dna"), IconID("fas-dna"), IconUnicodeGlyph(0xf471)]
        SolidDna = 567,
        ///<summary>Brands DocHub</summary>
        ///<see href="https://fontawesome.com/icons/dochub?style=brands"/>
        [Description("Brands DocHub"), IconID("fab-dochub"), IconUnicodeGlyph(0xf394)]
        BrandsDochub = 568,
        ///<summary>Brands Docker</summary>
        ///<see href="https://fontawesome.com/icons/docker?style=brands"/>
        [Description("Brands Docker"), IconID("fab-docker"), IconUnicodeGlyph(0xf395)]
        BrandsDocker = 569,
        ///<summary>Solid Dog</summary>
        ///<see href="https://fontawesome.com/icons/dog?style=solid"/>
        [Description("Solid Dog"), IconID("fas-dog"), IconUnicodeGlyph(0xf6d3)]
        SolidDog = 570,
        ///<summary>Solid Dollar Sign</summary>
        ///<see href="https://fontawesome.com/icons/dollar-sign?style=solid"/>
        [Description("Solid Dollar Sign"), IconID("fas-dollar-sign"), IconUnicodeGlyph(0x24)]
        SolidDollarSign = 571,
        ///<summary>Solid Dolly</summary>
        ///<see href="https://fontawesome.com/icons/dolly?style=solid"/>
        [Description("Solid Dolly"), IconID("fas-dolly"), IconUnicodeGlyph(0xf472)]
        SolidDolly = 572,
        ///<summary>Solid Dong Sign</summary>
        ///<see href="https://fontawesome.com/icons/dong-sign?style=solid"/>
        [Description("Solid Dong Sign"), IconID("fas-dong-sign"), IconUnicodeGlyph(0xe169)]
        SolidDongSign = 573,
        ///<summary>Solid Door Closed</summary>
        ///<see href="https://fontawesome.com/icons/door-closed?style=solid"/>
        [Description("Solid Door Closed"), IconID("fas-door-closed"), IconUnicodeGlyph(0xf52a)]
        SolidDoorClosed = 574,
        ///<summary>Solid Door Open</summary>
        ///<see href="https://fontawesome.com/icons/door-open?style=solid"/>
        [Description("Solid Door Open"), IconID("fas-door-open"), IconUnicodeGlyph(0xf52b)]
        SolidDoorOpen = 575,
        ///<summary>Solid Dove</summary>
        ///<see href="https://fontawesome.com/icons/dove?style=solid"/>
        [Description("Solid Dove"), IconID("fas-dove"), IconUnicodeGlyph(0xf4ba)]
        SolidDove = 576,
        ///<summary>Solid Down Left And Up Right To Center</summary>
        ///<see href="https://fontawesome.com/icons/down-left-and-up-right-to-center?style=solid"/>
        [Description("Solid Down Left And Up Right To Center"), IconID("fas-down-left-and-up-right-to-center"), IconUnicodeGlyph(0xf422)]
        SolidDownLeftAndUpRightToCenter = 577,
        ///<summary>Solid Down Long</summary>
        ///<see href="https://fontawesome.com/icons/down-long?style=solid"/>
        [Description("Solid Down Long"), IconID("fas-down-long"), IconUnicodeGlyph(0xf309)]
        SolidDownLong = 578,
        ///<summary>Solid Download</summary>
        ///<see href="https://fontawesome.com/icons/download?style=solid"/>
        [Description("Solid Download"), IconID("fas-download"), IconUnicodeGlyph(0xf019)]
        SolidDownload = 579,
        ///<summary>Brands Draft2digital</summary>
        ///<see href="https://fontawesome.com/icons/draft2digital?style=brands"/>
        [Description("Brands Draft2digital"), IconID("fab-draft2digital"), IconUnicodeGlyph(0xf396)]
        BrandsDraft2digital = 580,
        ///<summary>Solid Dragon</summary>
        ///<see href="https://fontawesome.com/icons/dragon?style=solid"/>
        [Description("Solid Dragon"), IconID("fas-dragon"), IconUnicodeGlyph(0xf6d5)]
        SolidDragon = 581,
        ///<summary>Solid Draw Polygon</summary>
        ///<see href="https://fontawesome.com/icons/draw-polygon?style=solid"/>
        [Description("Solid Draw Polygon"), IconID("fas-draw-polygon"), IconUnicodeGlyph(0xf5ee)]
        SolidDrawPolygon = 582,
        ///<summary>Brands Dribbble</summary>
        ///<see href="https://fontawesome.com/icons/dribbble?style=brands"/>
        [Description("Brands Dribbble"), IconID("fab-dribbble"), IconUnicodeGlyph(0xf17d)]
        BrandsDribbble = 583,
        ///<summary>Brands Dropbox</summary>
        ///<see href="https://fontawesome.com/icons/dropbox?style=brands"/>
        [Description("Brands Dropbox"), IconID("fab-dropbox"), IconUnicodeGlyph(0xf16b)]
        BrandsDropbox = 584,
        ///<summary>Solid Droplet</summary>
        ///<see href="https://fontawesome.com/icons/droplet?style=solid"/>
        [Description("Solid Droplet"), IconID("fas-droplet"), IconUnicodeGlyph(0xf043)]
        SolidDroplet = 585,
        ///<summary>Solid Droplet Slash</summary>
        ///<see href="https://fontawesome.com/icons/droplet-slash?style=solid"/>
        [Description("Solid Droplet Slash"), IconID("fas-droplet-slash"), IconUnicodeGlyph(0xf5c7)]
        SolidDropletSlash = 586,
        ///<summary>Solid Drum</summary>
        ///<see href="https://fontawesome.com/icons/drum?style=solid"/>
        [Description("Solid Drum"), IconID("fas-drum"), IconUnicodeGlyph(0xf569)]
        SolidDrum = 587,
        ///<summary>Solid Drum Steelpan</summary>
        ///<see href="https://fontawesome.com/icons/drum-steelpan?style=solid"/>
        [Description("Solid Drum Steelpan"), IconID("fas-drum-steelpan"), IconUnicodeGlyph(0xf56a)]
        SolidDrumSteelpan = 588,
        ///<summary>Solid Drumstick Bite</summary>
        ///<see href="https://fontawesome.com/icons/drumstick-bite?style=solid"/>
        [Description("Solid Drumstick Bite"), IconID("fas-drumstick-bite"), IconUnicodeGlyph(0xf6d7)]
        SolidDrumstickBite = 589,
        ///<summary>Brands Drupal Logo</summary>
        ///<see href="https://fontawesome.com/icons/drupal?style=brands"/>
        [Description("Brands Drupal Logo"), IconID("fab-drupal"), IconUnicodeGlyph(0xf1a9)]
        BrandsDrupal = 590,
        ///<summary>Solid Dumbbell</summary>
        ///<see href="https://fontawesome.com/icons/dumbbell?style=solid"/>
        [Description("Solid Dumbbell"), IconID("fas-dumbbell"), IconUnicodeGlyph(0xf44b)]
        SolidDumbbell = 591,
        ///<summary>Solid Dumpster</summary>
        ///<see href="https://fontawesome.com/icons/dumpster?style=solid"/>
        [Description("Solid Dumpster"), IconID("fas-dumpster"), IconUnicodeGlyph(0xf793)]
        SolidDumpster = 592,
        ///<summary>Solid Dumpster Fire</summary>
        ///<see href="https://fontawesome.com/icons/dumpster-fire?style=solid"/>
        [Description("Solid Dumpster Fire"), IconID("fas-dumpster-fire"), IconUnicodeGlyph(0xf794)]
        SolidDumpsterFire = 593,
        ///<summary>Solid Dungeon</summary>
        ///<see href="https://fontawesome.com/icons/dungeon?style=solid"/>
        [Description("Solid Dungeon"), IconID("fas-dungeon"), IconUnicodeGlyph(0xf6d9)]
        SolidDungeon = 594,
        ///<summary>Brands Dyalog</summary>
        ///<see href="https://fontawesome.com/icons/dyalog?style=brands"/>
        [Description("Brands Dyalog"), IconID("fab-dyalog"), IconUnicodeGlyph(0xf399)]
        BrandsDyalog = 595,
        ///<summary>Solid E</summary>
        ///<see href="https://fontawesome.com/icons/e?style=solid"/>
        [Description("Solid E"), IconID("fas-e"), IconUnicodeGlyph(0x45)]
        SolidE = 596,
        ///<summary>Solid Ear Deaf</summary>
        ///<see href="https://fontawesome.com/icons/ear-deaf?style=solid"/>
        [Description("Solid Ear Deaf"), IconID("fas-ear-deaf"), IconUnicodeGlyph(0xf2a4)]
        SolidEarDeaf = 597,
        ///<summary>Solid Ear Listen</summary>
        ///<see href="https://fontawesome.com/icons/ear-listen?style=solid"/>
        [Description("Solid Ear Listen"), IconID("fas-ear-listen"), IconUnicodeGlyph(0xf2a2)]
        SolidEarListen = 598,
        ///<summary>Brands Earlybirds</summary>
        ///<see href="https://fontawesome.com/icons/earlybirds?style=brands"/>
        [Description("Brands Earlybirds"), IconID("fab-earlybirds"), IconUnicodeGlyph(0xf39a)]
        BrandsEarlybirds = 599,
        ///<summary>Solid Earth Africa</summary>
        ///<see href="https://fontawesome.com/icons/earth-africa?style=solid"/>
        [Description("Solid Earth Africa"), IconID("fas-earth-africa"), IconUnicodeGlyph(0xf57c)]
        SolidEarthAfrica = 600,
        ///<summary>Solid Earth Americas</summary>
        ///<see href="https://fontawesome.com/icons/earth-americas?style=solid"/>
        [Description("Solid Earth Americas"), IconID("fas-earth-americas"), IconUnicodeGlyph(0xf57d)]
        SolidEarthAmericas = 601,
        ///<summary>Solid Earth Asia</summary>
        ///<see href="https://fontawesome.com/icons/earth-asia?style=solid"/>
        [Description("Solid Earth Asia"), IconID("fas-earth-asia"), IconUnicodeGlyph(0xf57e)]
        SolidEarthAsia = 602,
        ///<summary>Solid Earth Europe</summary>
        ///<see href="https://fontawesome.com/icons/earth-europe?style=solid"/>
        [Description("Solid Earth Europe"), IconID("fas-earth-europe"), IconUnicodeGlyph(0xf7a2)]
        SolidEarthEurope = 603,
        ///<summary>Solid Earth Oceania</summary>
        ///<see href="https://fontawesome.com/icons/earth-oceania?style=solid"/>
        [Description("Solid Earth Oceania"), IconID("fas-earth-oceania"), IconUnicodeGlyph(0xe47b)]
        SolidEarthOceania = 604,
        ///<summary>Brands eBay</summary>
        ///<see href="https://fontawesome.com/icons/ebay?style=brands"/>
        [Description("Brands eBay"), IconID("fab-ebay"), IconUnicodeGlyph(0xf4f4)]
        BrandsEbay = 605,
        ///<summary>Brands Edge Browser</summary>
        ///<see href="https://fontawesome.com/icons/edge?style=brands"/>
        [Description("Brands Edge Browser"), IconID("fab-edge"), IconUnicodeGlyph(0xf282)]
        BrandsEdge = 606,
        ///<summary>Brands Edge Legacy Browser</summary>
        ///<see href="https://fontawesome.com/icons/edge-legacy?style=brands"/>
        [Description("Brands Edge Legacy Browser"), IconID("fab-edge-legacy"), IconUnicodeGlyph(0xe078)]
        BrandsEdgeLegacy = 607,
        ///<summary>Solid Egg</summary>
        ///<see href="https://fontawesome.com/icons/egg?style=solid"/>
        [Description("Solid Egg"), IconID("fas-egg"), IconUnicodeGlyph(0xf7fb)]
        SolidEgg = 608,
        ///<summary>Solid Eject</summary>
        ///<see href="https://fontawesome.com/icons/eject?style=solid"/>
        [Description("Solid Eject"), IconID("fas-eject"), IconUnicodeGlyph(0xf052)]
        SolidEject = 609,
        ///<summary>Brands Elementor</summary>
        ///<see href="https://fontawesome.com/icons/elementor?style=brands"/>
        [Description("Brands Elementor"), IconID("fab-elementor"), IconUnicodeGlyph(0xf430)]
        BrandsElementor = 610,
        ///<summary>Solid Elevator</summary>
        ///<see href="https://fontawesome.com/icons/elevator?style=solid"/>
        [Description("Solid Elevator"), IconID("fas-elevator"), IconUnicodeGlyph(0xe16d)]
        SolidElevator = 611,
        ///<summary>Solid Ellipsis</summary>
        ///<see href="https://fontawesome.com/icons/ellipsis?style=solid"/>
        [Description("Solid Ellipsis"), IconID("fas-ellipsis"), IconUnicodeGlyph(0xf141)]
        SolidEllipsis = 612,
        ///<summary>Solid Ellipsis Vertical</summary>
        ///<see href="https://fontawesome.com/icons/ellipsis-vertical?style=solid"/>
        [Description("Solid Ellipsis Vertical"), IconID("fas-ellipsis-vertical"), IconUnicodeGlyph(0xf142)]
        SolidEllipsisVertical = 613,
        ///<summary>Brands Ello</summary>
        ///<see href="https://fontawesome.com/icons/ello?style=brands"/>
        [Description("Brands Ello"), IconID("fab-ello"), IconUnicodeGlyph(0xf5f1)]
        BrandsEllo = 614,
        ///<summary>Brands Ember</summary>
        ///<see href="https://fontawesome.com/icons/ember?style=brands"/>
        [Description("Brands Ember"), IconID("fab-ember"), IconUnicodeGlyph(0xf423)]
        BrandsEmber = 615,
        ///<summary>Brands Galactic Empire</summary>
        ///<see href="https://fontawesome.com/icons/empire?style=brands"/>
        [Description("Brands Galactic Empire"), IconID("fab-empire"), IconUnicodeGlyph(0xf1d1)]
        BrandsEmpire = 616,
        ///<summary>Solid Envelope</summary>
        ///<see href="https://fontawesome.com/icons/envelope?style=solid"/>
        [Description("Solid Envelope"), IconID("fas-envelope"), IconUnicodeGlyph(0xf0e0)]
        SolidEnvelope = 617,
        ///<summary>Regular Envelope</summary>
        ///<see href="https://fontawesome.com/icons/envelope?style=regular"/>
        [Description("Regular Envelope"), IconID("far-envelope"), IconUnicodeGlyph(0xf0e0)]
        RegularEnvelope = 618,
        ///<summary>Solid Envelope Circle Check</summary>
        ///<see href="https://fontawesome.com/icons/envelope-circle-check?style=solid"/>
        [Description("Solid Envelope Circle Check"), IconID("fas-envelope-circle-check"), IconUnicodeGlyph(0xe4e8)]
        SolidEnvelopeCircleCheck = 619,
        ///<summary>Solid Envelope Open</summary>
        ///<see href="https://fontawesome.com/icons/envelope-open?style=solid"/>
        [Description("Solid Envelope Open"), IconID("fas-envelope-open"), IconUnicodeGlyph(0xf2b6)]
        SolidEnvelopeOpen = 620,
        ///<summary>Regular Envelope Open</summary>
        ///<see href="https://fontawesome.com/icons/envelope-open?style=regular"/>
        [Description("Regular Envelope Open"), IconID("far-envelope-open"), IconUnicodeGlyph(0xf2b6)]
        RegularEnvelopeOpen = 621,
        ///<summary>Solid Envelope Open Text</summary>
        ///<see href="https://fontawesome.com/icons/envelope-open-text?style=solid"/>
        [Description("Solid Envelope Open Text"), IconID("fas-envelope-open-text"), IconUnicodeGlyph(0xf658)]
        SolidEnvelopeOpenText = 622,
        ///<summary>Solid Envelopes Bulk</summary>
        ///<see href="https://fontawesome.com/icons/envelopes-bulk?style=solid"/>
        [Description("Solid Envelopes Bulk"), IconID("fas-envelopes-bulk"), IconUnicodeGlyph(0xf674)]
        SolidEnvelopesBulk = 623,
        ///<summary>Brands Envira Gallery</summary>
        ///<see href="https://fontawesome.com/icons/envira?style=brands"/>
        [Description("Brands Envira Gallery"), IconID("fab-envira"), IconUnicodeGlyph(0xf299)]
        BrandsEnvira = 624,
        ///<summary>Solid Equals</summary>
        ///<see href="https://fontawesome.com/icons/equals?style=solid"/>
        [Description("Solid Equals"), IconID("fas-equals"), IconUnicodeGlyph(0x3d)]
        SolidEquals = 625,
        ///<summary>Solid Eraser</summary>
        ///<see href="https://fontawesome.com/icons/eraser?style=solid"/>
        [Description("Solid Eraser"), IconID("fas-eraser"), IconUnicodeGlyph(0xf12d)]
        SolidEraser = 626,
        ///<summary>Brands Erlang</summary>
        ///<see href="https://fontawesome.com/icons/erlang?style=brands"/>
        [Description("Brands Erlang"), IconID("fab-erlang"), IconUnicodeGlyph(0xf39d)]
        BrandsErlang = 627,
        ///<summary>Brands Ethereum</summary>
        ///<see href="https://fontawesome.com/icons/ethereum?style=brands"/>
        [Description("Brands Ethereum"), IconID("fab-ethereum"), IconUnicodeGlyph(0xf42e)]
        BrandsEthereum = 628,
        ///<summary>Solid Ethernet</summary>
        ///<see href="https://fontawesome.com/icons/ethernet?style=solid"/>
        [Description("Solid Ethernet"), IconID("fas-ethernet"), IconUnicodeGlyph(0xf796)]
        SolidEthernet = 629,
        ///<summary>Brands Etsy</summary>
        ///<see href="https://fontawesome.com/icons/etsy?style=brands"/>
        [Description("Brands Etsy"), IconID("fab-etsy"), IconUnicodeGlyph(0xf2d7)]
        BrandsEtsy = 630,
        ///<summary>Solid Euro Sign</summary>
        ///<see href="https://fontawesome.com/icons/euro-sign?style=solid"/>
        [Description("Solid Euro Sign"), IconID("fas-euro-sign"), IconUnicodeGlyph(0xf153)]
        SolidEuroSign = 631,
        ///<summary>Brands Evernote</summary>
        ///<see href="https://fontawesome.com/icons/evernote?style=brands"/>
        [Description("Brands Evernote"), IconID("fab-evernote"), IconUnicodeGlyph(0xf839)]
        BrandsEvernote = 632,
        ///<summary>Solid Exclamation</summary>
        ///<see href="https://fontawesome.com/icons/exclamation?style=solid"/>
        [Description("Solid Exclamation"), IconID("fas-exclamation"), IconUnicodeGlyph(0x21)]
        SolidExclamation = 633,
        ///<summary>Solid Expand</summary>
        ///<see href="https://fontawesome.com/icons/expand?style=solid"/>
        [Description("Solid Expand"), IconID("fas-expand"), IconUnicodeGlyph(0xf065)]
        SolidExpand = 634,
        ///<summary>Brands ExpeditedSSL</summary>
        ///<see href="https://fontawesome.com/icons/expeditedssl?style=brands"/>
        [Description("Brands ExpeditedSSL"), IconID("fab-expeditedssl"), IconUnicodeGlyph(0xf23e)]
        BrandsExpeditedssl = 635,
        ///<summary>Solid Explosion</summary>
        ///<see href="https://fontawesome.com/icons/explosion?style=solid"/>
        [Description("Solid Explosion"), IconID("fas-explosion"), IconUnicodeGlyph(0xe4e9)]
        SolidExplosion = 636,
        ///<summary>Solid Eye</summary>
        ///<see href="https://fontawesome.com/icons/eye?style=solid"/>
        [Description("Solid Eye"), IconID("fas-eye"), IconUnicodeGlyph(0xf06e)]
        SolidEye = 637,
        ///<summary>Regular Eye</summary>
        ///<see href="https://fontawesome.com/icons/eye?style=regular"/>
        [Description("Regular Eye"), IconID("far-eye"), IconUnicodeGlyph(0xf06e)]
        RegularEye = 638,
        ///<summary>Solid Eye Dropper</summary>
        ///<see href="https://fontawesome.com/icons/eye-dropper?style=solid"/>
        [Description("Solid Eye Dropper"), IconID("fas-eye-dropper"), IconUnicodeGlyph(0xf1fb)]
        SolidEyeDropper = 639,
        ///<summary>Solid Eye Low Vision</summary>
        ///<see href="https://fontawesome.com/icons/eye-low-vision?style=solid"/>
        [Description("Solid Eye Low Vision"), IconID("fas-eye-low-vision"), IconUnicodeGlyph(0xf2a8)]
        SolidEyeLowVision = 640,
        ///<summary>Solid Eye Slash</summary>
        ///<see href="https://fontawesome.com/icons/eye-slash?style=solid"/>
        [Description("Solid Eye Slash"), IconID("fas-eye-slash"), IconUnicodeGlyph(0xf070)]
        SolidEyeSlash = 641,
        ///<summary>Regular Eye Slash</summary>
        ///<see href="https://fontawesome.com/icons/eye-slash?style=regular"/>
        [Description("Regular Eye Slash"), IconID("far-eye-slash"), IconUnicodeGlyph(0xf070)]
        RegularEyeSlash = 642,
        ///<summary>Solid F</summary>
        ///<see href="https://fontawesome.com/icons/f?style=solid"/>
        [Description("Solid F"), IconID("fas-f"), IconUnicodeGlyph(0x46)]
        SolidF = 643,
        ///<summary>Solid Face Angry</summary>
        ///<see href="https://fontawesome.com/icons/face-angry?style=solid"/>
        [Description("Solid Face Angry"), IconID("fas-face-angry"), IconUnicodeGlyph(0xf556)]
        SolidFaceAngry = 644,
        ///<summary>Regular Face Angry</summary>
        ///<see href="https://fontawesome.com/icons/face-angry?style=regular"/>
        [Description("Regular Face Angry"), IconID("far-face-angry"), IconUnicodeGlyph(0xf556)]
        RegularFaceAngry = 645,
        ///<summary>Solid Face Dizzy</summary>
        ///<see href="https://fontawesome.com/icons/face-dizzy?style=solid"/>
        [Description("Solid Face Dizzy"), IconID("fas-face-dizzy"), IconUnicodeGlyph(0xf567)]
        SolidFaceDizzy = 646,
        ///<summary>Regular Face Dizzy</summary>
        ///<see href="https://fontawesome.com/icons/face-dizzy?style=regular"/>
        [Description("Regular Face Dizzy"), IconID("far-face-dizzy"), IconUnicodeGlyph(0xf567)]
        RegularFaceDizzy = 647,
        ///<summary>Solid Face Flushed</summary>
        ///<see href="https://fontawesome.com/icons/face-flushed?style=solid"/>
        [Description("Solid Face Flushed"), IconID("fas-face-flushed"), IconUnicodeGlyph(0xf579)]
        SolidFaceFlushed = 648,
        ///<summary>Regular Face Flushed</summary>
        ///<see href="https://fontawesome.com/icons/face-flushed?style=regular"/>
        [Description("Regular Face Flushed"), IconID("far-face-flushed"), IconUnicodeGlyph(0xf579)]
        RegularFaceFlushed = 649,
        ///<summary>Solid Face Frown</summary>
        ///<see href="https://fontawesome.com/icons/face-frown?style=solid"/>
        [Description("Solid Face Frown"), IconID("fas-face-frown"), IconUnicodeGlyph(0xf119)]
        SolidFaceFrown = 650,
        ///<summary>Regular Face Frown</summary>
        ///<see href="https://fontawesome.com/icons/face-frown?style=regular"/>
        [Description("Regular Face Frown"), IconID("far-face-frown"), IconUnicodeGlyph(0xf119)]
        RegularFaceFrown = 651,
        ///<summary>Solid Face Frown Open</summary>
        ///<see href="https://fontawesome.com/icons/face-frown-open?style=solid"/>
        [Description("Solid Face Frown Open"), IconID("fas-face-frown-open"), IconUnicodeGlyph(0xf57a)]
        SolidFaceFrownOpen = 652,
        ///<summary>Regular Face Frown Open</summary>
        ///<see href="https://fontawesome.com/icons/face-frown-open?style=regular"/>
        [Description("Regular Face Frown Open"), IconID("far-face-frown-open"), IconUnicodeGlyph(0xf57a)]
        RegularFaceFrownOpen = 653,
        ///<summary>Solid Face Grimace</summary>
        ///<see href="https://fontawesome.com/icons/face-grimace?style=solid"/>
        [Description("Solid Face Grimace"), IconID("fas-face-grimace"), IconUnicodeGlyph(0xf57f)]
        SolidFaceGrimace = 654,
        ///<summary>Regular Face Grimace</summary>
        ///<see href="https://fontawesome.com/icons/face-grimace?style=regular"/>
        [Description("Regular Face Grimace"), IconID("far-face-grimace"), IconUnicodeGlyph(0xf57f)]
        RegularFaceGrimace = 655,
        ///<summary>Solid Face Grin</summary>
        ///<see href="https://fontawesome.com/icons/face-grin?style=solid"/>
        [Description("Solid Face Grin"), IconID("fas-face-grin"), IconUnicodeGlyph(0xf580)]
        SolidFaceGrin = 656,
        ///<summary>Regular Face Grin</summary>
        ///<see href="https://fontawesome.com/icons/face-grin?style=regular"/>
        [Description("Regular Face Grin"), IconID("far-face-grin"), IconUnicodeGlyph(0xf580)]
        RegularFaceGrin = 657,
        ///<summary>Solid Face Grin Beam</summary>
        ///<see href="https://fontawesome.com/icons/face-grin-beam?style=solid"/>
        [Description("Solid Face Grin Beam"), IconID("fas-face-grin-beam"), IconUnicodeGlyph(0xf582)]
        SolidFaceGrinBeam = 658,
        ///<summary>Regular Face Grin Beam</summary>
        ///<see href="https://fontawesome.com/icons/face-grin-beam?style=regular"/>
        [Description("Regular Face Grin Beam"), IconID("far-face-grin-beam"), IconUnicodeGlyph(0xf582)]
        RegularFaceGrinBeam = 659,
        ///<summary>Solid Face Grin Beam Sweat</summary>
        ///<see href="https://fontawesome.com/icons/face-grin-beam-sweat?style=solid"/>
        [Description("Solid Face Grin Beam Sweat"), IconID("fas-face-grin-beam-sweat"), IconUnicodeGlyph(0xf583)]
        SolidFaceGrinBeamSweat = 660,
        ///<summary>Regular Face Grin Beam Sweat</summary>
        ///<see href="https://fontawesome.com/icons/face-grin-beam-sweat?style=regular"/>
        [Description("Regular Face Grin Beam Sweat"), IconID("far-face-grin-beam-sweat"), IconUnicodeGlyph(0xf583)]
        RegularFaceGrinBeamSweat = 661,
        ///<summary>Solid Face Grin Hearts</summary>
        ///<see href="https://fontawesome.com/icons/face-grin-hearts?style=solid"/>
        [Description("Solid Face Grin Hearts"), IconID("fas-face-grin-hearts"), IconUnicodeGlyph(0xf584)]
        SolidFaceGrinHearts = 662,
        ///<summary>Regular Face Grin Hearts</summary>
        ///<see href="https://fontawesome.com/icons/face-grin-hearts?style=regular"/>
        [Description("Regular Face Grin Hearts"), IconID("far-face-grin-hearts"), IconUnicodeGlyph(0xf584)]
        RegularFaceGrinHearts = 663,
        ///<summary>Solid Face Grin Squint</summary>
        ///<see href="https://fontawesome.com/icons/face-grin-squint?style=solid"/>
        [Description("Solid Face Grin Squint"), IconID("fas-face-grin-squint"), IconUnicodeGlyph(0xf585)]
        SolidFaceGrinSquint = 664,
        ///<summary>Regular Face Grin Squint</summary>
        ///<see href="https://fontawesome.com/icons/face-grin-squint?style=regular"/>
        [Description("Regular Face Grin Squint"), IconID("far-face-grin-squint"), IconUnicodeGlyph(0xf585)]
        RegularFaceGrinSquint = 665,
        ///<summary>Solid Face Grin Squint Tears</summary>
        ///<see href="https://fontawesome.com/icons/face-grin-squint-tears?style=solid"/>
        [Description("Solid Face Grin Squint Tears"), IconID("fas-face-grin-squint-tears"), IconUnicodeGlyph(0xf586)]
        SolidFaceGrinSquintTears = 666,
        ///<summary>Regular Face Grin Squint Tears</summary>
        ///<see href="https://fontawesome.com/icons/face-grin-squint-tears?style=regular"/>
        [Description("Regular Face Grin Squint Tears"), IconID("far-face-grin-squint-tears"), IconUnicodeGlyph(0xf586)]
        RegularFaceGrinSquintTears = 667,
        ///<summary>Solid Face Grin Stars</summary>
        ///<see href="https://fontawesome.com/icons/face-grin-stars?style=solid"/>
        [Description("Solid Face Grin Stars"), IconID("fas-face-grin-stars"), IconUnicodeGlyph(0xf587)]
        SolidFaceGrinStars = 668,
        ///<summary>Regular Face Grin Stars</summary>
        ///<see href="https://fontawesome.com/icons/face-grin-stars?style=regular"/>
        [Description("Regular Face Grin Stars"), IconID("far-face-grin-stars"), IconUnicodeGlyph(0xf587)]
        RegularFaceGrinStars = 669,
        ///<summary>Solid Face Grin Tears</summary>
        ///<see href="https://fontawesome.com/icons/face-grin-tears?style=solid"/>
        [Description("Solid Face Grin Tears"), IconID("fas-face-grin-tears"), IconUnicodeGlyph(0xf588)]
        SolidFaceGrinTears = 670,
        ///<summary>Regular Face Grin Tears</summary>
        ///<see href="https://fontawesome.com/icons/face-grin-tears?style=regular"/>
        [Description("Regular Face Grin Tears"), IconID("far-face-grin-tears"), IconUnicodeGlyph(0xf588)]
        RegularFaceGrinTears = 671,
        ///<summary>Solid Face Grin Tongue</summary>
        ///<see href="https://fontawesome.com/icons/face-grin-tongue?style=solid"/>
        [Description("Solid Face Grin Tongue"), IconID("fas-face-grin-tongue"), IconUnicodeGlyph(0xf589)]
        SolidFaceGrinTongue = 672,
        ///<summary>Regular Face Grin Tongue</summary>
        ///<see href="https://fontawesome.com/icons/face-grin-tongue?style=regular"/>
        [Description("Regular Face Grin Tongue"), IconID("far-face-grin-tongue"), IconUnicodeGlyph(0xf589)]
        RegularFaceGrinTongue = 673,
        ///<summary>Solid Face Grin Tongue Squint</summary>
        ///<see href="https://fontawesome.com/icons/face-grin-tongue-squint?style=solid"/>
        [Description("Solid Face Grin Tongue Squint"), IconID("fas-face-grin-tongue-squint"), IconUnicodeGlyph(0xf58a)]
        SolidFaceGrinTongueSquint = 674,
        ///<summary>Regular Face Grin Tongue Squint</summary>
        ///<see href="https://fontawesome.com/icons/face-grin-tongue-squint?style=regular"/>
        [Description("Regular Face Grin Tongue Squint"), IconID("far-face-grin-tongue-squint"), IconUnicodeGlyph(0xf58a)]
        RegularFaceGrinTongueSquint = 675,
        ///<summary>Solid Face Grin Tongue Wink</summary>
        ///<see href="https://fontawesome.com/icons/face-grin-tongue-wink?style=solid"/>
        [Description("Solid Face Grin Tongue Wink"), IconID("fas-face-grin-tongue-wink"), IconUnicodeGlyph(0xf58b)]
        SolidFaceGrinTongueWink = 676,
        ///<summary>Regular Face Grin Tongue Wink</summary>
        ///<see href="https://fontawesome.com/icons/face-grin-tongue-wink?style=regular"/>
        [Description("Regular Face Grin Tongue Wink"), IconID("far-face-grin-tongue-wink"), IconUnicodeGlyph(0xf58b)]
        RegularFaceGrinTongueWink = 677,
        ///<summary>Solid Face Grin Wide</summary>
        ///<see href="https://fontawesome.com/icons/face-grin-wide?style=solid"/>
        [Description("Solid Face Grin Wide"), IconID("fas-face-grin-wide"), IconUnicodeGlyph(0xf581)]
        SolidFaceGrinWide = 678,
        ///<summary>Regular Face Grin Wide</summary>
        ///<see href="https://fontawesome.com/icons/face-grin-wide?style=regular"/>
        [Description("Regular Face Grin Wide"), IconID("far-face-grin-wide"), IconUnicodeGlyph(0xf581)]
        RegularFaceGrinWide = 679,
        ///<summary>Solid Face Grin Wink</summary>
        ///<see href="https://fontawesome.com/icons/face-grin-wink?style=solid"/>
        [Description("Solid Face Grin Wink"), IconID("fas-face-grin-wink"), IconUnicodeGlyph(0xf58c)]
        SolidFaceGrinWink = 680,
        ///<summary>Regular Face Grin Wink</summary>
        ///<see href="https://fontawesome.com/icons/face-grin-wink?style=regular"/>
        [Description("Regular Face Grin Wink"), IconID("far-face-grin-wink"), IconUnicodeGlyph(0xf58c)]
        RegularFaceGrinWink = 681,
        ///<summary>Solid Face Kiss</summary>
        ///<see href="https://fontawesome.com/icons/face-kiss?style=solid"/>
        [Description("Solid Face Kiss"), IconID("fas-face-kiss"), IconUnicodeGlyph(0xf596)]
        SolidFaceKiss = 682,
        ///<summary>Regular Face Kiss</summary>
        ///<see href="https://fontawesome.com/icons/face-kiss?style=regular"/>
        [Description("Regular Face Kiss"), IconID("far-face-kiss"), IconUnicodeGlyph(0xf596)]
        RegularFaceKiss = 683,
        ///<summary>Solid Face Kiss Beam</summary>
        ///<see href="https://fontawesome.com/icons/face-kiss-beam?style=solid"/>
        [Description("Solid Face Kiss Beam"), IconID("fas-face-kiss-beam"), IconUnicodeGlyph(0xf597)]
        SolidFaceKissBeam = 684,
        ///<summary>Regular Face Kiss Beam</summary>
        ///<see href="https://fontawesome.com/icons/face-kiss-beam?style=regular"/>
        [Description("Regular Face Kiss Beam"), IconID("far-face-kiss-beam"), IconUnicodeGlyph(0xf597)]
        RegularFaceKissBeam = 685,
        ///<summary>Solid Face Kiss Wink Heart</summary>
        ///<see href="https://fontawesome.com/icons/face-kiss-wink-heart?style=solid"/>
        [Description("Solid Face Kiss Wink Heart"), IconID("fas-face-kiss-wink-heart"), IconUnicodeGlyph(0xf598)]
        SolidFaceKissWinkHeart = 686,
        ///<summary>Regular Face Kiss Wink Heart</summary>
        ///<see href="https://fontawesome.com/icons/face-kiss-wink-heart?style=regular"/>
        [Description("Regular Face Kiss Wink Heart"), IconID("far-face-kiss-wink-heart"), IconUnicodeGlyph(0xf598)]
        RegularFaceKissWinkHeart = 687,
        ///<summary>Solid Face Laugh</summary>
        ///<see href="https://fontawesome.com/icons/face-laugh?style=solid"/>
        [Description("Solid Face Laugh"), IconID("fas-face-laugh"), IconUnicodeGlyph(0xf599)]
        SolidFaceLaugh = 688,
        ///<summary>Regular Face Laugh</summary>
        ///<see href="https://fontawesome.com/icons/face-laugh?style=regular"/>
        [Description("Regular Face Laugh"), IconID("far-face-laugh"), IconUnicodeGlyph(0xf599)]
        RegularFaceLaugh = 689,
        ///<summary>Solid Face Laugh Beam</summary>
        ///<see href="https://fontawesome.com/icons/face-laugh-beam?style=solid"/>
        [Description("Solid Face Laugh Beam"), IconID("fas-face-laugh-beam"), IconUnicodeGlyph(0xf59a)]
        SolidFaceLaughBeam = 690,
        ///<summary>Regular Face Laugh Beam</summary>
        ///<see href="https://fontawesome.com/icons/face-laugh-beam?style=regular"/>
        [Description("Regular Face Laugh Beam"), IconID("far-face-laugh-beam"), IconUnicodeGlyph(0xf59a)]
        RegularFaceLaughBeam = 691,
        ///<summary>Solid Face Laugh Squint</summary>
        ///<see href="https://fontawesome.com/icons/face-laugh-squint?style=solid"/>
        [Description("Solid Face Laugh Squint"), IconID("fas-face-laugh-squint"), IconUnicodeGlyph(0xf59b)]
        SolidFaceLaughSquint = 692,
        ///<summary>Regular Face Laugh Squint</summary>
        ///<see href="https://fontawesome.com/icons/face-laugh-squint?style=regular"/>
        [Description("Regular Face Laugh Squint"), IconID("far-face-laugh-squint"), IconUnicodeGlyph(0xf59b)]
        RegularFaceLaughSquint = 693,
        ///<summary>Solid Face Laugh Wink</summary>
        ///<see href="https://fontawesome.com/icons/face-laugh-wink?style=solid"/>
        [Description("Solid Face Laugh Wink"), IconID("fas-face-laugh-wink"), IconUnicodeGlyph(0xf59c)]
        SolidFaceLaughWink = 694,
        ///<summary>Regular Face Laugh Wink</summary>
        ///<see href="https://fontawesome.com/icons/face-laugh-wink?style=regular"/>
        [Description("Regular Face Laugh Wink"), IconID("far-face-laugh-wink"), IconUnicodeGlyph(0xf59c)]
        RegularFaceLaughWink = 695,
        ///<summary>Solid Face Meh</summary>
        ///<see href="https://fontawesome.com/icons/face-meh?style=solid"/>
        [Description("Solid Face Meh"), IconID("fas-face-meh"), IconUnicodeGlyph(0xf11a)]
        SolidFaceMeh = 696,
        ///<summary>Regular Face Meh</summary>
        ///<see href="https://fontawesome.com/icons/face-meh?style=regular"/>
        [Description("Regular Face Meh"), IconID("far-face-meh"), IconUnicodeGlyph(0xf11a)]
        RegularFaceMeh = 697,
        ///<summary>Solid Face Meh Blank</summary>
        ///<see href="https://fontawesome.com/icons/face-meh-blank?style=solid"/>
        [Description("Solid Face Meh Blank"), IconID("fas-face-meh-blank"), IconUnicodeGlyph(0xf5a4)]
        SolidFaceMehBlank = 698,
        ///<summary>Regular Face Meh Blank</summary>
        ///<see href="https://fontawesome.com/icons/face-meh-blank?style=regular"/>
        [Description("Regular Face Meh Blank"), IconID("far-face-meh-blank"), IconUnicodeGlyph(0xf5a4)]
        RegularFaceMehBlank = 699,
        ///<summary>Solid Face Rolling Eyes</summary>
        ///<see href="https://fontawesome.com/icons/face-rolling-eyes?style=solid"/>
        [Description("Solid Face Rolling Eyes"), IconID("fas-face-rolling-eyes"), IconUnicodeGlyph(0xf5a5)]
        SolidFaceRollingEyes = 700,
        ///<summary>Regular Face Rolling Eyes</summary>
        ///<see href="https://fontawesome.com/icons/face-rolling-eyes?style=regular"/>
        [Description("Regular Face Rolling Eyes"), IconID("far-face-rolling-eyes"), IconUnicodeGlyph(0xf5a5)]
        RegularFaceRollingEyes = 701,
        ///<summary>Solid Face Sad Cry</summary>
        ///<see href="https://fontawesome.com/icons/face-sad-cry?style=solid"/>
        [Description("Solid Face Sad Cry"), IconID("fas-face-sad-cry"), IconUnicodeGlyph(0xf5b3)]
        SolidFaceSadCry = 702,
        ///<summary>Regular Face Sad Cry</summary>
        ///<see href="https://fontawesome.com/icons/face-sad-cry?style=regular"/>
        [Description("Regular Face Sad Cry"), IconID("far-face-sad-cry"), IconUnicodeGlyph(0xf5b3)]
        RegularFaceSadCry = 703,
        ///<summary>Solid Face Sad Tear</summary>
        ///<see href="https://fontawesome.com/icons/face-sad-tear?style=solid"/>
        [Description("Solid Face Sad Tear"), IconID("fas-face-sad-tear"), IconUnicodeGlyph(0xf5b4)]
        SolidFaceSadTear = 704,
        ///<summary>Regular Face Sad Tear</summary>
        ///<see href="https://fontawesome.com/icons/face-sad-tear?style=regular"/>
        [Description("Regular Face Sad Tear"), IconID("far-face-sad-tear"), IconUnicodeGlyph(0xf5b4)]
        RegularFaceSadTear = 705,
        ///<summary>Solid Face Smile</summary>
        ///<see href="https://fontawesome.com/icons/face-smile?style=solid"/>
        [Description("Solid Face Smile"), IconID("fas-face-smile"), IconUnicodeGlyph(0xf118)]
        SolidFaceSmile = 706,
        ///<summary>Regular Face Smile</summary>
        ///<see href="https://fontawesome.com/icons/face-smile?style=regular"/>
        [Description("Regular Face Smile"), IconID("far-face-smile"), IconUnicodeGlyph(0xf118)]
        RegularFaceSmile = 707,
        ///<summary>Solid Face Smile Beam</summary>
        ///<see href="https://fontawesome.com/icons/face-smile-beam?style=solid"/>
        [Description("Solid Face Smile Beam"), IconID("fas-face-smile-beam"), IconUnicodeGlyph(0xf5b8)]
        SolidFaceSmileBeam = 708,
        ///<summary>Regular Face Smile Beam</summary>
        ///<see href="https://fontawesome.com/icons/face-smile-beam?style=regular"/>
        [Description("Regular Face Smile Beam"), IconID("far-face-smile-beam"), IconUnicodeGlyph(0xf5b8)]
        RegularFaceSmileBeam = 709,
        ///<summary>Solid Face Smile Wink</summary>
        ///<see href="https://fontawesome.com/icons/face-smile-wink?style=solid"/>
        [Description("Solid Face Smile Wink"), IconID("fas-face-smile-wink"), IconUnicodeGlyph(0xf4da)]
        SolidFaceSmileWink = 710,
        ///<summary>Regular Face Smile Wink</summary>
        ///<see href="https://fontawesome.com/icons/face-smile-wink?style=regular"/>
        [Description("Regular Face Smile Wink"), IconID("far-face-smile-wink"), IconUnicodeGlyph(0xf4da)]
        RegularFaceSmileWink = 711,
        ///<summary>Solid Face Surprise</summary>
        ///<see href="https://fontawesome.com/icons/face-surprise?style=solid"/>
        [Description("Solid Face Surprise"), IconID("fas-face-surprise"), IconUnicodeGlyph(0xf5c2)]
        SolidFaceSurprise = 712,
        ///<summary>Regular Face Surprise</summary>
        ///<see href="https://fontawesome.com/icons/face-surprise?style=regular"/>
        [Description("Regular Face Surprise"), IconID("far-face-surprise"), IconUnicodeGlyph(0xf5c2)]
        RegularFaceSurprise = 713,
        ///<summary>Solid Face Tired</summary>
        ///<see href="https://fontawesome.com/icons/face-tired?style=solid"/>
        [Description("Solid Face Tired"), IconID("fas-face-tired"), IconUnicodeGlyph(0xf5c8)]
        SolidFaceTired = 714,
        ///<summary>Regular Face Tired</summary>
        ///<see href="https://fontawesome.com/icons/face-tired?style=regular"/>
        [Description("Regular Face Tired"), IconID("far-face-tired"), IconUnicodeGlyph(0xf5c8)]
        RegularFaceTired = 715,
        ///<summary>Brands Facebook</summary>
        ///<see href="https://fontawesome.com/icons/facebook?style=brands"/>
        [Description("Brands Facebook"), IconID("fab-facebook"), IconUnicodeGlyph(0xf09a)]
        BrandsFacebook = 716,
        ///<summary>Brands Facebook F</summary>
        ///<see href="https://fontawesome.com/icons/facebook-f?style=brands"/>
        [Description("Brands Facebook F"), IconID("fab-facebook-f"), IconUnicodeGlyph(0xf39e)]
        BrandsFacebookF = 717,
        ///<summary>Brands Facebook Messenger</summary>
        ///<see href="https://fontawesome.com/icons/facebook-messenger?style=brands"/>
        [Description("Brands Facebook Messenger"), IconID("fab-facebook-messenger"), IconUnicodeGlyph(0xf39f)]
        BrandsFacebookMessenger = 718,
        ///<summary>Solid Fan</summary>
        ///<see href="https://fontawesome.com/icons/fan?style=solid"/>
        [Description("Solid Fan"), IconID("fas-fan"), IconUnicodeGlyph(0xf863)]
        SolidFan = 719,
        ///<summary>Brands Fantasy Flight-games</summary>
        ///<see href="https://fontawesome.com/icons/fantasy-flight-games?style=brands"/>
        [Description("Brands Fantasy Flight-games"), IconID("fab-fantasy-flight-games"), IconUnicodeGlyph(0xf6dc)]
        BrandsFantasyFlightGames = 720,
        ///<summary>Solid Faucet</summary>
        ///<see href="https://fontawesome.com/icons/faucet?style=solid"/>
        [Description("Solid Faucet"), IconID("fas-faucet"), IconUnicodeGlyph(0xe005)]
        SolidFaucet = 721,
        ///<summary>Solid Faucet Drip</summary>
        ///<see href="https://fontawesome.com/icons/faucet-drip?style=solid"/>
        [Description("Solid Faucet Drip"), IconID("fas-faucet-drip"), IconUnicodeGlyph(0xe006)]
        SolidFaucetDrip = 722,
        ///<summary>Solid Fax</summary>
        ///<see href="https://fontawesome.com/icons/fax?style=solid"/>
        [Description("Solid Fax"), IconID("fas-fax"), IconUnicodeGlyph(0xf1ac)]
        SolidFax = 723,
        ///<summary>Solid Feather</summary>
        ///<see href="https://fontawesome.com/icons/feather?style=solid"/>
        [Description("Solid Feather"), IconID("fas-feather"), IconUnicodeGlyph(0xf52d)]
        SolidFeather = 724,
        ///<summary>Solid Feather Pointed</summary>
        ///<see href="https://fontawesome.com/icons/feather-pointed?style=solid"/>
        [Description("Solid Feather Pointed"), IconID("fas-feather-pointed"), IconUnicodeGlyph(0xf56b)]
        SolidFeatherPointed = 725,
        ///<summary>Brands FedEx</summary>
        ///<see href="https://fontawesome.com/icons/fedex?style=brands"/>
        [Description("Brands FedEx"), IconID("fab-fedex"), IconUnicodeGlyph(0xf797)]
        BrandsFedex = 726,
        ///<summary>Brands Fedora</summary>
        ///<see href="https://fontawesome.com/icons/fedora?style=brands"/>
        [Description("Brands Fedora"), IconID("fab-fedora"), IconUnicodeGlyph(0xf798)]
        BrandsFedora = 727,
        ///<summary>Solid Ferry</summary>
        ///<see href="https://fontawesome.com/icons/ferry?style=solid"/>
        [Description("Solid Ferry"), IconID("fas-ferry"), IconUnicodeGlyph(0xe4ea)]
        SolidFerry = 728,
        ///<summary>Brands Figma</summary>
        ///<see href="https://fontawesome.com/icons/figma?style=brands"/>
        [Description("Brands Figma"), IconID("fab-figma"), IconUnicodeGlyph(0xf799)]
        BrandsFigma = 729,
        ///<summary>Solid File</summary>
        ///<see href="https://fontawesome.com/icons/file?style=solid"/>
        [Description("Solid File"), IconID("fas-file"), IconUnicodeGlyph(0xf15b)]
        SolidFile = 730,
        ///<summary>Regular File</summary>
        ///<see href="https://fontawesome.com/icons/file?style=regular"/>
        [Description("Regular File"), IconID("far-file"), IconUnicodeGlyph(0xf15b)]
        RegularFile = 731,
        ///<summary>Solid File Arrow Down</summary>
        ///<see href="https://fontawesome.com/icons/file-arrow-down?style=solid"/>
        [Description("Solid File Arrow Down"), IconID("fas-file-arrow-down"), IconUnicodeGlyph(0xf56d)]
        SolidFileArrowDown = 732,
        ///<summary>Solid File Arrow Up</summary>
        ///<see href="https://fontawesome.com/icons/file-arrow-up?style=solid"/>
        [Description("Solid File Arrow Up"), IconID("fas-file-arrow-up"), IconUnicodeGlyph(0xf574)]
        SolidFileArrowUp = 733,
        ///<summary>Solid File Audio</summary>
        ///<see href="https://fontawesome.com/icons/file-audio?style=solid"/>
        [Description("Solid File Audio"), IconID("fas-file-audio"), IconUnicodeGlyph(0xf1c7)]
        SolidFileAudio = 734,
        ///<summary>Regular File Audio</summary>
        ///<see href="https://fontawesome.com/icons/file-audio?style=regular"/>
        [Description("Regular File Audio"), IconID("far-file-audio"), IconUnicodeGlyph(0xf1c7)]
        RegularFileAudio = 735,
        ///<summary>Solid File Circle Check</summary>
        ///<see href="https://fontawesome.com/icons/file-circle-check?style=solid"/>
        [Description("Solid File Circle Check"), IconID("fas-file-circle-check"), IconUnicodeGlyph(0xe5a0)]
        SolidFileCircleCheck = 736,
        ///<summary>Solid File Circle Exclamation</summary>
        ///<see href="https://fontawesome.com/icons/file-circle-exclamation?style=solid"/>
        [Description("Solid File Circle Exclamation"), IconID("fas-file-circle-exclamation"), IconUnicodeGlyph(0xe4eb)]
        SolidFileCircleExclamation = 737,
        ///<summary>Solid File Circle Minus</summary>
        ///<see href="https://fontawesome.com/icons/file-circle-minus?style=solid"/>
        [Description("Solid File Circle Minus"), IconID("fas-file-circle-minus"), IconUnicodeGlyph(0xe4ed)]
        SolidFileCircleMinus = 738,
        ///<summary>Solid File Circle Plus</summary>
        ///<see href="https://fontawesome.com/icons/file-circle-plus?style=solid"/>
        [Description("Solid File Circle Plus"), IconID("fas-file-circle-plus"), IconUnicodeGlyph(0xe494)]
        SolidFileCirclePlus = 739,
        ///<summary>Solid File Circle Question</summary>
        ///<see href="https://fontawesome.com/icons/file-circle-question?style=solid"/>
        [Description("Solid File Circle Question"), IconID("fas-file-circle-question"), IconUnicodeGlyph(0xe4ef)]
        SolidFileCircleQuestion = 740,
        ///<summary>Solid File Circle Xmark</summary>
        ///<see href="https://fontawesome.com/icons/file-circle-xmark?style=solid"/>
        [Description("Solid File Circle Xmark"), IconID("fas-file-circle-xmark"), IconUnicodeGlyph(0xe5a1)]
        SolidFileCircleXmark = 741,
        ///<summary>Solid File Code</summary>
        ///<see href="https://fontawesome.com/icons/file-code?style=solid"/>
        [Description("Solid File Code"), IconID("fas-file-code"), IconUnicodeGlyph(0xf1c9)]
        SolidFileCode = 742,
        ///<summary>Regular File Code</summary>
        ///<see href="https://fontawesome.com/icons/file-code?style=regular"/>
        [Description("Regular File Code"), IconID("far-file-code"), IconUnicodeGlyph(0xf1c9)]
        RegularFileCode = 743,
        ///<summary>Solid File Contract</summary>
        ///<see href="https://fontawesome.com/icons/file-contract?style=solid"/>
        [Description("Solid File Contract"), IconID("fas-file-contract"), IconUnicodeGlyph(0xf56c)]
        SolidFileContract = 744,
        ///<summary>Solid File Csv</summary>
        ///<see href="https://fontawesome.com/icons/file-csv?style=solid"/>
        [Description("Solid File Csv"), IconID("fas-file-csv"), IconUnicodeGlyph(0xf6dd)]
        SolidFileCsv = 745,
        ///<summary>Solid File Excel</summary>
        ///<see href="https://fontawesome.com/icons/file-excel?style=solid"/>
        [Description("Solid File Excel"), IconID("fas-file-excel"), IconUnicodeGlyph(0xf1c3)]
        SolidFileExcel = 746,
        ///<summary>Regular File Excel</summary>
        ///<see href="https://fontawesome.com/icons/file-excel?style=regular"/>
        [Description("Regular File Excel"), IconID("far-file-excel"), IconUnicodeGlyph(0xf1c3)]
        RegularFileExcel = 747,
        ///<summary>Solid File Export</summary>
        ///<see href="https://fontawesome.com/icons/file-export?style=solid"/>
        [Description("Solid File Export"), IconID("fas-file-export"), IconUnicodeGlyph(0xf56e)]
        SolidFileExport = 748,
        ///<summary>Solid File Fragment</summary>
        ///<see href="https://fontawesome.com/icons/file-fragment?style=solid"/>
        [Description("Solid File Fragment"), IconID("fas-file-fragment"), IconUnicodeGlyph(0xe697)]
        SolidFileFragment = 749,
        ///<summary>Solid File Half Dashed</summary>
        ///<see href="https://fontawesome.com/icons/file-half-dashed?style=solid"/>
        [Description("Solid File Half Dashed"), IconID("fas-file-half-dashed"), IconUnicodeGlyph(0xe698)]
        SolidFileHalfDashed = 750,
        ///<summary>Solid File Image</summary>
        ///<see href="https://fontawesome.com/icons/file-image?style=solid"/>
        [Description("Solid File Image"), IconID("fas-file-image"), IconUnicodeGlyph(0xf1c5)]
        SolidFileImage = 751,
        ///<summary>Regular File Image</summary>
        ///<see href="https://fontawesome.com/icons/file-image?style=regular"/>
        [Description("Regular File Image"), IconID("far-file-image"), IconUnicodeGlyph(0xf1c5)]
        RegularFileImage = 752,
        ///<summary>Solid File Import</summary>
        ///<see href="https://fontawesome.com/icons/file-import?style=solid"/>
        [Description("Solid File Import"), IconID("fas-file-import"), IconUnicodeGlyph(0xf56f)]
        SolidFileImport = 753,
        ///<summary>Solid File Invoice</summary>
        ///<see href="https://fontawesome.com/icons/file-invoice?style=solid"/>
        [Description("Solid File Invoice"), IconID("fas-file-invoice"), IconUnicodeGlyph(0xf570)]
        SolidFileInvoice = 754,
        ///<summary>Solid File Invoice Dollar</summary>
        ///<see href="https://fontawesome.com/icons/file-invoice-dollar?style=solid"/>
        [Description("Solid File Invoice Dollar"), IconID("fas-file-invoice-dollar"), IconUnicodeGlyph(0xf571)]
        SolidFileInvoiceDollar = 755,
        ///<summary>Solid File Lines</summary>
        ///<see href="https://fontawesome.com/icons/file-lines?style=solid"/>
        [Description("Solid File Lines"), IconID("fas-file-lines"), IconUnicodeGlyph(0xf15c)]
        SolidFileLines = 756,
        ///<summary>Regular File Lines</summary>
        ///<see href="https://fontawesome.com/icons/file-lines?style=regular"/>
        [Description("Regular File Lines"), IconID("far-file-lines"), IconUnicodeGlyph(0xf15c)]
        RegularFileLines = 757,
        ///<summary>Solid File Medical</summary>
        ///<see href="https://fontawesome.com/icons/file-medical?style=solid"/>
        [Description("Solid File Medical"), IconID("fas-file-medical"), IconUnicodeGlyph(0xf477)]
        SolidFileMedical = 758,
        ///<summary>Solid File Pdf</summary>
        ///<see href="https://fontawesome.com/icons/file-pdf?style=solid"/>
        [Description("Solid File Pdf"), IconID("fas-file-pdf"), IconUnicodeGlyph(0xf1c1)]
        SolidFilePdf = 759,
        ///<summary>Regular File Pdf</summary>
        ///<see href="https://fontawesome.com/icons/file-pdf?style=regular"/>
        [Description("Regular File Pdf"), IconID("far-file-pdf"), IconUnicodeGlyph(0xf1c1)]
        RegularFilePdf = 760,
        ///<summary>Solid File Pen</summary>
        ///<see href="https://fontawesome.com/icons/file-pen?style=solid"/>
        [Description("Solid File Pen"), IconID("fas-file-pen"), IconUnicodeGlyph(0xf31c)]
        SolidFilePen = 761,
        ///<summary>Solid File Powerpoint</summary>
        ///<see href="https://fontawesome.com/icons/file-powerpoint?style=solid"/>
        [Description("Solid File Powerpoint"), IconID("fas-file-powerpoint"), IconUnicodeGlyph(0xf1c4)]
        SolidFilePowerpoint = 762,
        ///<summary>Regular File Powerpoint</summary>
        ///<see href="https://fontawesome.com/icons/file-powerpoint?style=regular"/>
        [Description("Regular File Powerpoint"), IconID("far-file-powerpoint"), IconUnicodeGlyph(0xf1c4)]
        RegularFilePowerpoint = 763,
        ///<summary>Solid File Prescription</summary>
        ///<see href="https://fontawesome.com/icons/file-prescription?style=solid"/>
        [Description("Solid File Prescription"), IconID("fas-file-prescription"), IconUnicodeGlyph(0xf572)]
        SolidFilePrescription = 764,
        ///<summary>Solid File Shield</summary>
        ///<see href="https://fontawesome.com/icons/file-shield?style=solid"/>
        [Description("Solid File Shield"), IconID("fas-file-shield"), IconUnicodeGlyph(0xe4f0)]
        SolidFileShield = 765,
        ///<summary>Solid File Signature</summary>
        ///<see href="https://fontawesome.com/icons/file-signature?style=solid"/>
        [Description("Solid File Signature"), IconID("fas-file-signature"), IconUnicodeGlyph(0xf573)]
        SolidFileSignature = 766,
        ///<summary>Solid File Video</summary>
        ///<see href="https://fontawesome.com/icons/file-video?style=solid"/>
        [Description("Solid File Video"), IconID("fas-file-video"), IconUnicodeGlyph(0xf1c8)]
        SolidFileVideo = 767,
        ///<summary>Regular File Video</summary>
        ///<see href="https://fontawesome.com/icons/file-video?style=regular"/>
        [Description("Regular File Video"), IconID("far-file-video"), IconUnicodeGlyph(0xf1c8)]
        RegularFileVideo = 768,
        ///<summary>Solid File Waveform</summary>
        ///<see href="https://fontawesome.com/icons/file-waveform?style=solid"/>
        [Description("Solid File Waveform"), IconID("fas-file-waveform"), IconUnicodeGlyph(0xf478)]
        SolidFileWaveform = 769,
        ///<summary>Solid File Word</summary>
        ///<see href="https://fontawesome.com/icons/file-word?style=solid"/>
        [Description("Solid File Word"), IconID("fas-file-word"), IconUnicodeGlyph(0xf1c2)]
        SolidFileWord = 770,
        ///<summary>Regular File Word</summary>
        ///<see href="https://fontawesome.com/icons/file-word?style=regular"/>
        [Description("Regular File Word"), IconID("far-file-word"), IconUnicodeGlyph(0xf1c2)]
        RegularFileWord = 771,
        ///<summary>Solid File Zipper</summary>
        ///<see href="https://fontawesome.com/icons/file-zipper?style=solid"/>
        [Description("Solid File Zipper"), IconID("fas-file-zipper"), IconUnicodeGlyph(0xf1c6)]
        SolidFileZipper = 772,
        ///<summary>Regular File Zipper</summary>
        ///<see href="https://fontawesome.com/icons/file-zipper?style=regular"/>
        [Description("Regular File Zipper"), IconID("far-file-zipper"), IconUnicodeGlyph(0xf1c6)]
        RegularFileZipper = 773,
        ///<summary>Brands Files Pinwheel</summary>
        ///<see href="https://fontawesome.com/icons/files-pinwheel?style=brands"/>
        [Description("Brands Files Pinwheel"), IconID("fab-files-pinwheel"), IconUnicodeGlyph(0xe69f)]
        BrandsFilesPinwheel = 774,
        ///<summary>Solid Fill</summary>
        ///<see href="https://fontawesome.com/icons/fill?style=solid"/>
        [Description("Solid Fill"), IconID("fas-fill"), IconUnicodeGlyph(0xf575)]
        SolidFill = 775,
        ///<summary>Solid Fill Drip</summary>
        ///<see href="https://fontawesome.com/icons/fill-drip?style=solid"/>
        [Description("Solid Fill Drip"), IconID("fas-fill-drip"), IconUnicodeGlyph(0xf576)]
        SolidFillDrip = 776,
        ///<summary>Solid Film</summary>
        ///<see href="https://fontawesome.com/icons/film?style=solid"/>
        [Description("Solid Film"), IconID("fas-film"), IconUnicodeGlyph(0xf008)]
        SolidFilm = 777,
        ///<summary>Solid Filter</summary>
        ///<see href="https://fontawesome.com/icons/filter?style=solid"/>
        [Description("Solid Filter"), IconID("fas-filter"), IconUnicodeGlyph(0xf0b0)]
        SolidFilter = 778,
        ///<summary>Solid Filter Circle Dollar</summary>
        ///<see href="https://fontawesome.com/icons/filter-circle-dollar?style=solid"/>
        [Description("Solid Filter Circle Dollar"), IconID("fas-filter-circle-dollar"), IconUnicodeGlyph(0xf662)]
        SolidFilterCircleDollar = 779,
        ///<summary>Solid Filter Circle Xmark</summary>
        ///<see href="https://fontawesome.com/icons/filter-circle-xmark?style=solid"/>
        [Description("Solid Filter Circle Xmark"), IconID("fas-filter-circle-xmark"), IconUnicodeGlyph(0xe17b)]
        SolidFilterCircleXmark = 780,
        ///<summary>Solid Fingerprint</summary>
        ///<see href="https://fontawesome.com/icons/fingerprint?style=solid"/>
        [Description("Solid Fingerprint"), IconID("fas-fingerprint"), IconUnicodeGlyph(0xf577)]
        SolidFingerprint = 781,
        ///<summary>Solid Fire</summary>
        ///<see href="https://fontawesome.com/icons/fire?style=solid"/>
        [Description("Solid Fire"), IconID("fas-fire"), IconUnicodeGlyph(0xf06d)]
        SolidFire = 782,
        ///<summary>Solid Fire Burner</summary>
        ///<see href="https://fontawesome.com/icons/fire-burner?style=solid"/>
        [Description("Solid Fire Burner"), IconID("fas-fire-burner"), IconUnicodeGlyph(0xe4f1)]
        SolidFireBurner = 783,
        ///<summary>Solid Fire Extinguisher</summary>
        ///<see href="https://fontawesome.com/icons/fire-extinguisher?style=solid"/>
        [Description("Solid Fire Extinguisher"), IconID("fas-fire-extinguisher"), IconUnicodeGlyph(0xf134)]
        SolidFireExtinguisher = 784,
        ///<summary>Solid Fire Flame Curved</summary>
        ///<see href="https://fontawesome.com/icons/fire-flame-curved?style=solid"/>
        [Description("Solid Fire Flame Curved"), IconID("fas-fire-flame-curved"), IconUnicodeGlyph(0xf7e4)]
        SolidFireFlameCurved = 785,
        ///<summary>Solid Fire Flame Simple</summary>
        ///<see href="https://fontawesome.com/icons/fire-flame-simple?style=solid"/>
        [Description("Solid Fire Flame Simple"), IconID("fas-fire-flame-simple"), IconUnicodeGlyph(0xf46a)]
        SolidFireFlameSimple = 786,
        ///<summary>Brands Firefox</summary>
        ///<see href="https://fontawesome.com/icons/firefox?style=brands"/>
        [Description("Brands Firefox"), IconID("fab-firefox"), IconUnicodeGlyph(0xf269)]
        BrandsFirefox = 787,
        ///<summary>Brands Firefox Browser</summary>
        ///<see href="https://fontawesome.com/icons/firefox-browser?style=brands"/>
        [Description("Brands Firefox Browser"), IconID("fab-firefox-browser"), IconUnicodeGlyph(0xe007)]
        BrandsFirefoxBrowser = 788,
        ///<summary>Brands First Order</summary>
        ///<see href="https://fontawesome.com/icons/first-order?style=brands"/>
        [Description("Brands First Order"), IconID("fab-first-order"), IconUnicodeGlyph(0xf2b0)]
        BrandsFirstOrder = 789,
        ///<summary>Brands Alternate First Order</summary>
        ///<see href="https://fontawesome.com/icons/first-order-alt?style=brands"/>
        [Description("Brands Alternate First Order"), IconID("fab-first-order-alt"), IconUnicodeGlyph(0xf50a)]
        BrandsFirstOrderAlt = 790,
        ///<summary>Brands firstdraft</summary>
        ///<see href="https://fontawesome.com/icons/firstdraft?style=brands"/>
        [Description("Brands firstdraft"), IconID("fab-firstdraft"), IconUnicodeGlyph(0xf3a1)]
        BrandsFirstdraft = 791,
        ///<summary>Solid Fish</summary>
        ///<see href="https://fontawesome.com/icons/fish?style=solid"/>
        [Description("Solid Fish"), IconID("fas-fish"), IconUnicodeGlyph(0xf578)]
        SolidFish = 792,
        ///<summary>Solid Fish Fins</summary>
        ///<see href="https://fontawesome.com/icons/fish-fins?style=solid"/>
        [Description("Solid Fish Fins"), IconID("fas-fish-fins"), IconUnicodeGlyph(0xe4f2)]
        SolidFishFins = 793,
        ///<summary>Solid Flag</summary>
        ///<see href="https://fontawesome.com/icons/flag?style=solid"/>
        [Description("Solid Flag"), IconID("fas-flag"), IconUnicodeGlyph(0xf024)]
        SolidFlag = 794,
        ///<summary>Regular Flag</summary>
        ///<see href="https://fontawesome.com/icons/flag?style=regular"/>
        [Description("Regular Flag"), IconID("far-flag"), IconUnicodeGlyph(0xf024)]
        RegularFlag = 795,
        ///<summary>Solid Flag Checkered</summary>
        ///<see href="https://fontawesome.com/icons/flag-checkered?style=solid"/>
        [Description("Solid Flag Checkered"), IconID("fas-flag-checkered"), IconUnicodeGlyph(0xf11e)]
        SolidFlagCheckered = 796,
        ///<summary>Solid Flag Usa</summary>
        ///<see href="https://fontawesome.com/icons/flag-usa?style=solid"/>
        [Description("Solid Flag Usa"), IconID("fas-flag-usa"), IconUnicodeGlyph(0xf74d)]
        SolidFlagUsa = 797,
        ///<summary>Solid Flask</summary>
        ///<see href="https://fontawesome.com/icons/flask?style=solid"/>
        [Description("Solid Flask"), IconID("fas-flask"), IconUnicodeGlyph(0xf0c3)]
        SolidFlask = 798,
        ///<summary>Solid Flask Vial</summary>
        ///<see href="https://fontawesome.com/icons/flask-vial?style=solid"/>
        [Description("Solid Flask Vial"), IconID("fas-flask-vial"), IconUnicodeGlyph(0xe4f3)]
        SolidFlaskVial = 799,
        ///<summary>Brands Flickr</summary>
        ///<see href="https://fontawesome.com/icons/flickr?style=brands"/>
        [Description("Brands Flickr"), IconID("fab-flickr"), IconUnicodeGlyph(0xf16e)]
        BrandsFlickr = 800,
        ///<summary>Brands Flipboard</summary>
        ///<see href="https://fontawesome.com/icons/flipboard?style=brands"/>
        [Description("Brands Flipboard"), IconID("fab-flipboard"), IconUnicodeGlyph(0xf44d)]
        BrandsFlipboard = 801,
        ///<summary>Solid Floppy Disk</summary>
        ///<see href="https://fontawesome.com/icons/floppy-disk?style=solid"/>
        [Description("Solid Floppy Disk"), IconID("fas-floppy-disk"), IconUnicodeGlyph(0xf0c7)]
        SolidFloppyDisk = 802,
        ///<summary>Regular Floppy Disk</summary>
        ///<see href="https://fontawesome.com/icons/floppy-disk?style=regular"/>
        [Description("Regular Floppy Disk"), IconID("far-floppy-disk"), IconUnicodeGlyph(0xf0c7)]
        RegularFloppyDisk = 803,
        ///<summary>Solid Florin Sign</summary>
        ///<see href="https://fontawesome.com/icons/florin-sign?style=solid"/>
        [Description("Solid Florin Sign"), IconID("fas-florin-sign"), IconUnicodeGlyph(0xe184)]
        SolidFlorinSign = 804,
        ///<summary>Brands Flutter</summary>
        ///<see href="https://fontawesome.com/icons/flutter?style=brands"/>
        [Description("Brands Flutter"), IconID("fab-flutter"), IconUnicodeGlyph(0xe694)]
        BrandsFlutter = 805,
        ///<summary>Brands Fly</summary>
        ///<see href="https://fontawesome.com/icons/fly?style=brands"/>
        [Description("Brands Fly"), IconID("fab-fly"), IconUnicodeGlyph(0xf417)]
        BrandsFly = 806,
        ///<summary>Solid Folder</summary>
        ///<see href="https://fontawesome.com/icons/folder?style=solid"/>
        [Description("Solid Folder"), IconID("fas-folder"), IconUnicodeGlyph(0xf07b)]
        SolidFolder = 807,
        ///<summary>Regular Folder</summary>
        ///<see href="https://fontawesome.com/icons/folder?style=regular"/>
        [Description("Regular Folder"), IconID("far-folder"), IconUnicodeGlyph(0xf07b)]
        RegularFolder = 808,
        ///<summary>Solid Folder Closed</summary>
        ///<see href="https://fontawesome.com/icons/folder-closed?style=solid"/>
        [Description("Solid Folder Closed"), IconID("fas-folder-closed"), IconUnicodeGlyph(0xe185)]
        SolidFolderClosed = 809,
        ///<summary>Regular Folder Closed</summary>
        ///<see href="https://fontawesome.com/icons/folder-closed?style=regular"/>
        [Description("Regular Folder Closed"), IconID("far-folder-closed"), IconUnicodeGlyph(0xe185)]
        RegularFolderClosed = 810,
        ///<summary>Solid Folder Minus</summary>
        ///<see href="https://fontawesome.com/icons/folder-minus?style=solid"/>
        [Description("Solid Folder Minus"), IconID("fas-folder-minus"), IconUnicodeGlyph(0xf65d)]
        SolidFolderMinus = 811,
        ///<summary>Solid Folder Open</summary>
        ///<see href="https://fontawesome.com/icons/folder-open?style=solid"/>
        [Description("Solid Folder Open"), IconID("fas-folder-open"), IconUnicodeGlyph(0xf07c)]
        SolidFolderOpen = 812,
        ///<summary>Regular Folder Open</summary>
        ///<see href="https://fontawesome.com/icons/folder-open?style=regular"/>
        [Description("Regular Folder Open"), IconID("far-folder-open"), IconUnicodeGlyph(0xf07c)]
        RegularFolderOpen = 813,
        ///<summary>Solid Folder Plus</summary>
        ///<see href="https://fontawesome.com/icons/folder-plus?style=solid"/>
        [Description("Solid Folder Plus"), IconID("fas-folder-plus"), IconUnicodeGlyph(0xf65e)]
        SolidFolderPlus = 814,
        ///<summary>Solid Folder Tree</summary>
        ///<see href="https://fontawesome.com/icons/folder-tree?style=solid"/>
        [Description("Solid Folder Tree"), IconID("fas-folder-tree"), IconUnicodeGlyph(0xf802)]
        SolidFolderTree = 815,
        ///<summary>Solid Font</summary>
        ///<see href="https://fontawesome.com/icons/font?style=solid"/>
        [Description("Solid Font"), IconID("fas-font"), IconUnicodeGlyph(0xf031)]
        SolidFont = 816,
        ///<summary>Solid Font Awesome</summary>
        ///<see href="https://fontawesome.com/icons/font-awesome?style=solid"/>
        [Description("Solid Font Awesome"), IconID("fas-font-awesome"), IconUnicodeGlyph(0xf2b4)]
        SolidFontAwesome = 817,
        ///<summary>Regular Font Awesome</summary>
        ///<see href="https://fontawesome.com/icons/font-awesome?style=regular"/>
        [Description("Regular Font Awesome"), IconID("far-font-awesome"), IconUnicodeGlyph(0xf2b4)]
        RegularFontAwesome = 818,
        ///<summary>Brands Font Awesome</summary>
        ///<see href="https://fontawesome.com/icons/font-awesome?style=brands"/>
        [Description("Brands Font Awesome"), IconID("fab-font-awesome"), IconUnicodeGlyph(0xf2b4)]
        BrandsFontAwesome = 819,
        ///<summary>Brands Fonticons</summary>
        ///<see href="https://fontawesome.com/icons/fonticons?style=brands"/>
        [Description("Brands Fonticons"), IconID("fab-fonticons"), IconUnicodeGlyph(0xf280)]
        BrandsFonticons = 820,
        ///<summary>Brands Fonticons Fi</summary>
        ///<see href="https://fontawesome.com/icons/fonticons-fi?style=brands"/>
        [Description("Brands Fonticons Fi"), IconID("fab-fonticons-fi"), IconUnicodeGlyph(0xf3a2)]
        BrandsFonticonsFi = 821,
        ///<summary>Solid Football</summary>
        ///<see href="https://fontawesome.com/icons/football?style=solid"/>
        [Description("Solid Football"), IconID("fas-football"), IconUnicodeGlyph(0xf44e)]
        SolidFootball = 822,
        ///<summary>Brands Fort Awesome</summary>
        ///<see href="https://fontawesome.com/icons/fort-awesome?style=brands"/>
        [Description("Brands Fort Awesome"), IconID("fab-fort-awesome"), IconUnicodeGlyph(0xf286)]
        BrandsFortAwesome = 823,
        ///<summary>Brands Alternate Fort Awesome</summary>
        ///<see href="https://fontawesome.com/icons/fort-awesome-alt?style=brands"/>
        [Description("Brands Alternate Fort Awesome"), IconID("fab-fort-awesome-alt"), IconUnicodeGlyph(0xf3a3)]
        BrandsFortAwesomeAlt = 824,
        ///<summary>Brands Forumbee</summary>
        ///<see href="https://fontawesome.com/icons/forumbee?style=brands"/>
        [Description("Brands Forumbee"), IconID("fab-forumbee"), IconUnicodeGlyph(0xf211)]
        BrandsForumbee = 825,
        ///<summary>Solid Forward</summary>
        ///<see href="https://fontawesome.com/icons/forward?style=solid"/>
        [Description("Solid Forward"), IconID("fas-forward"), IconUnicodeGlyph(0xf04e)]
        SolidForward = 826,
        ///<summary>Solid Forward Fast</summary>
        ///<see href="https://fontawesome.com/icons/forward-fast?style=solid"/>
        [Description("Solid Forward Fast"), IconID("fas-forward-fast"), IconUnicodeGlyph(0xf050)]
        SolidForwardFast = 827,
        ///<summary>Solid Forward Step</summary>
        ///<see href="https://fontawesome.com/icons/forward-step?style=solid"/>
        [Description("Solid Forward Step"), IconID("fas-forward-step"), IconUnicodeGlyph(0xf051)]
        SolidForwardStep = 828,
        ///<summary>Brands Foursquare</summary>
        ///<see href="https://fontawesome.com/icons/foursquare?style=brands"/>
        [Description("Brands Foursquare"), IconID("fab-foursquare"), IconUnicodeGlyph(0xf180)]
        BrandsFoursquare = 829,
        ///<summary>Solid Franc Sign</summary>
        ///<see href="https://fontawesome.com/icons/franc-sign?style=solid"/>
        [Description("Solid Franc Sign"), IconID("fas-franc-sign"), IconUnicodeGlyph(0xe18f)]
        SolidFrancSign = 830,
        ///<summary>Brands freeCodeCamp</summary>
        ///<see href="https://fontawesome.com/icons/free-code-camp?style=brands"/>
        [Description("Brands freeCodeCamp"), IconID("fab-free-code-camp"), IconUnicodeGlyph(0xf2c5)]
        BrandsFreeCodeCamp = 831,
        ///<summary>Brands FreeBSD</summary>
        ///<see href="https://fontawesome.com/icons/freebsd?style=brands"/>
        [Description("Brands FreeBSD"), IconID("fab-freebsd"), IconUnicodeGlyph(0xf3a4)]
        BrandsFreebsd = 832,
        ///<summary>Solid Frog</summary>
        ///<see href="https://fontawesome.com/icons/frog?style=solid"/>
        [Description("Solid Frog"), IconID("fas-frog"), IconUnicodeGlyph(0xf52e)]
        SolidFrog = 833,
        ///<summary>Brands Fulcrum</summary>
        ///<see href="https://fontawesome.com/icons/fulcrum?style=brands"/>
        [Description("Brands Fulcrum"), IconID("fab-fulcrum"), IconUnicodeGlyph(0xf50b)]
        BrandsFulcrum = 834,
        ///<summary>Solid Futbol</summary>
        ///<see href="https://fontawesome.com/icons/futbol?style=solid"/>
        [Description("Solid Futbol"), IconID("fas-futbol"), IconUnicodeGlyph(0xf1e3)]
        SolidFutbol = 835,
        ///<summary>Regular Futbol</summary>
        ///<see href="https://fontawesome.com/icons/futbol?style=regular"/>
        [Description("Regular Futbol"), IconID("far-futbol"), IconUnicodeGlyph(0xf1e3)]
        RegularFutbol = 836,
        ///<summary>Solid G</summary>
        ///<see href="https://fontawesome.com/icons/g?style=solid"/>
        [Description("Solid G"), IconID("fas-g"), IconUnicodeGlyph(0x47)]
        SolidG = 837,
        ///<summary>Brands Galactic Republic</summary>
        ///<see href="https://fontawesome.com/icons/galactic-republic?style=brands"/>
        [Description("Brands Galactic Republic"), IconID("fab-galactic-republic"), IconUnicodeGlyph(0xf50c)]
        BrandsGalacticRepublic = 838,
        ///<summary>Brands Galactic Senate</summary>
        ///<see href="https://fontawesome.com/icons/galactic-senate?style=brands"/>
        [Description("Brands Galactic Senate"), IconID("fab-galactic-senate"), IconUnicodeGlyph(0xf50d)]
        BrandsGalacticSenate = 839,
        ///<summary>Solid Gamepad</summary>
        ///<see href="https://fontawesome.com/icons/gamepad?style=solid"/>
        [Description("Solid Gamepad"), IconID("fas-gamepad"), IconUnicodeGlyph(0xf11b)]
        SolidGamepad = 840,
        ///<summary>Solid Gas Pump</summary>
        ///<see href="https://fontawesome.com/icons/gas-pump?style=solid"/>
        [Description("Solid Gas Pump"), IconID("fas-gas-pump"), IconUnicodeGlyph(0xf52f)]
        SolidGasPump = 841,
        ///<summary>Solid Gauge</summary>
        ///<see href="https://fontawesome.com/icons/gauge?style=solid"/>
        [Description("Solid Gauge"), IconID("fas-gauge"), IconUnicodeGlyph(0xf624)]
        SolidGauge = 842,
        ///<summary>Solid Gauge High</summary>
        ///<see href="https://fontawesome.com/icons/gauge-high?style=solid"/>
        [Description("Solid Gauge High"), IconID("fas-gauge-high"), IconUnicodeGlyph(0xf625)]
        SolidGaugeHigh = 843,
        ///<summary>Solid Gauge Simple</summary>
        ///<see href="https://fontawesome.com/icons/gauge-simple?style=solid"/>
        [Description("Solid Gauge Simple"), IconID("fas-gauge-simple"), IconUnicodeGlyph(0xf629)]
        SolidGaugeSimple = 844,
        ///<summary>Solid Gauge Simple High</summary>
        ///<see href="https://fontawesome.com/icons/gauge-simple-high?style=solid"/>
        [Description("Solid Gauge Simple High"), IconID("fas-gauge-simple-high"), IconUnicodeGlyph(0xf62a)]
        SolidGaugeSimpleHigh = 845,
        ///<summary>Solid Gavel</summary>
        ///<see href="https://fontawesome.com/icons/gavel?style=solid"/>
        [Description("Solid Gavel"), IconID("fas-gavel"), IconUnicodeGlyph(0xf0e3)]
        SolidGavel = 846,
        ///<summary>Solid Gear</summary>
        ///<see href="https://fontawesome.com/icons/gear?style=solid"/>
        [Description("Solid Gear"), IconID("fas-gear"), IconUnicodeGlyph(0xf013)]
        SolidGear = 847,
        ///<summary>Solid Gears</summary>
        ///<see href="https://fontawesome.com/icons/gears?style=solid"/>
        [Description("Solid Gears"), IconID("fas-gears"), IconUnicodeGlyph(0xf085)]
        SolidGears = 848,
        ///<summary>Solid Gem</summary>
        ///<see href="https://fontawesome.com/icons/gem?style=solid"/>
        [Description("Solid Gem"), IconID("fas-gem"), IconUnicodeGlyph(0xf3a5)]
        SolidGem = 849,
        ///<summary>Regular Gem</summary>
        ///<see href="https://fontawesome.com/icons/gem?style=regular"/>
        [Description("Regular Gem"), IconID("far-gem"), IconUnicodeGlyph(0xf3a5)]
        RegularGem = 850,
        ///<summary>Solid Genderless</summary>
        ///<see href="https://fontawesome.com/icons/genderless?style=solid"/>
        [Description("Solid Genderless"), IconID("fas-genderless"), IconUnicodeGlyph(0xf22d)]
        SolidGenderless = 851,
        ///<summary>Brands Get Pocket</summary>
        ///<see href="https://fontawesome.com/icons/get-pocket?style=brands"/>
        [Description("Brands Get Pocket"), IconID("fab-get-pocket"), IconUnicodeGlyph(0xf265)]
        BrandsGetPocket = 852,
        ///<summary>Brands GG Currency</summary>
        ///<see href="https://fontawesome.com/icons/gg?style=brands"/>
        [Description("Brands GG Currency"), IconID("fab-gg"), IconUnicodeGlyph(0xf260)]
        BrandsGg = 853,
        ///<summary>Brands GG Currency Circle</summary>
        ///<see href="https://fontawesome.com/icons/gg-circle?style=brands"/>
        [Description("Brands GG Currency Circle"), IconID("fab-gg-circle"), IconUnicodeGlyph(0xf261)]
        BrandsGgCircle = 854,
        ///<summary>Solid Ghost</summary>
        ///<see href="https://fontawesome.com/icons/ghost?style=solid"/>
        [Description("Solid Ghost"), IconID("fas-ghost"), IconUnicodeGlyph(0xf6e2)]
        SolidGhost = 855,
        ///<summary>Solid Gift</summary>
        ///<see href="https://fontawesome.com/icons/gift?style=solid"/>
        [Description("Solid Gift"), IconID("fas-gift"), IconUnicodeGlyph(0xf06b)]
        SolidGift = 856,
        ///<summary>Solid Gifts</summary>
        ///<see href="https://fontawesome.com/icons/gifts?style=solid"/>
        [Description("Solid Gifts"), IconID("fas-gifts"), IconUnicodeGlyph(0xf79c)]
        SolidGifts = 857,
        ///<summary>Brands Git</summary>
        ///<see href="https://fontawesome.com/icons/git?style=brands"/>
        [Description("Brands Git"), IconID("fab-git"), IconUnicodeGlyph(0xf1d3)]
        BrandsGit = 858,
        ///<summary>Brands Git Alt</summary>
        ///<see href="https://fontawesome.com/icons/git-alt?style=brands"/>
        [Description("Brands Git Alt"), IconID("fab-git-alt"), IconUnicodeGlyph(0xf841)]
        BrandsGitAlt = 859,
        ///<summary>Brands GitHub</summary>
        ///<see href="https://fontawesome.com/icons/github?style=brands"/>
        [Description("Brands GitHub"), IconID("fab-github"), IconUnicodeGlyph(0xf09b)]
        BrandsGithub = 860,
        ///<summary>Brands Alternate GitHub</summary>
        ///<see href="https://fontawesome.com/icons/github-alt?style=brands"/>
        [Description("Brands Alternate GitHub"), IconID("fab-github-alt"), IconUnicodeGlyph(0xf113)]
        BrandsGithubAlt = 861,
        ///<summary>Brands GitKraken</summary>
        ///<see href="https://fontawesome.com/icons/gitkraken?style=brands"/>
        [Description("Brands GitKraken"), IconID("fab-gitkraken"), IconUnicodeGlyph(0xf3a6)]
        BrandsGitkraken = 862,
        ///<summary>Brands GitLab</summary>
        ///<see href="https://fontawesome.com/icons/gitlab?style=brands"/>
        [Description("Brands GitLab"), IconID("fab-gitlab"), IconUnicodeGlyph(0xf296)]
        BrandsGitlab = 863,
        ///<summary>Brands Gitter</summary>
        ///<see href="https://fontawesome.com/icons/gitter?style=brands"/>
        [Description("Brands Gitter"), IconID("fab-gitter"), IconUnicodeGlyph(0xf426)]
        BrandsGitter = 864,
        ///<summary>Solid Glass Water</summary>
        ///<see href="https://fontawesome.com/icons/glass-water?style=solid"/>
        [Description("Solid Glass Water"), IconID("fas-glass-water"), IconUnicodeGlyph(0xe4f4)]
        SolidGlassWater = 865,
        ///<summary>Solid Glass Water Droplet</summary>
        ///<see href="https://fontawesome.com/icons/glass-water-droplet?style=solid"/>
        [Description("Solid Glass Water Droplet"), IconID("fas-glass-water-droplet"), IconUnicodeGlyph(0xe4f5)]
        SolidGlassWaterDroplet = 866,
        ///<summary>Solid Glasses</summary>
        ///<see href="https://fontawesome.com/icons/glasses?style=solid"/>
        [Description("Solid Glasses"), IconID("fas-glasses"), IconUnicodeGlyph(0xf530)]
        SolidGlasses = 867,
        ///<summary>Brands Glide</summary>
        ///<see href="https://fontawesome.com/icons/glide?style=brands"/>
        [Description("Brands Glide"), IconID("fab-glide"), IconUnicodeGlyph(0xf2a5)]
        BrandsGlide = 868,
        ///<summary>Brands Glide G</summary>
        ///<see href="https://fontawesome.com/icons/glide-g?style=brands"/>
        [Description("Brands Glide G"), IconID("fab-glide-g"), IconUnicodeGlyph(0xf2a6)]
        BrandsGlideG = 869,
        ///<summary>Solid Globe</summary>
        ///<see href="https://fontawesome.com/icons/globe?style=solid"/>
        [Description("Solid Globe"), IconID("fas-globe"), IconUnicodeGlyph(0xf0ac)]
        SolidGlobe = 870,
        ///<summary>Brands Gofore</summary>
        ///<see href="https://fontawesome.com/icons/gofore?style=brands"/>
        [Description("Brands Gofore"), IconID("fab-gofore"), IconUnicodeGlyph(0xf3a7)]
        BrandsGofore = 871,
        ///<summary>Brands Go</summary>
        ///<see href="https://fontawesome.com/icons/golang?style=brands"/>
        [Description("Brands Go"), IconID("fab-golang"), IconUnicodeGlyph(0xe40f)]
        BrandsGolang = 872,
        ///<summary>Solid Golf Ball Tee</summary>
        ///<see href="https://fontawesome.com/icons/golf-ball-tee?style=solid"/>
        [Description("Solid Golf Ball Tee"), IconID("fas-golf-ball-tee"), IconUnicodeGlyph(0xf450)]
        SolidGolfBallTee = 873,
        ///<summary>Brands Goodreads</summary>
        ///<see href="https://fontawesome.com/icons/goodreads?style=brands"/>
        [Description("Brands Goodreads"), IconID("fab-goodreads"), IconUnicodeGlyph(0xf3a8)]
        BrandsGoodreads = 874,
        ///<summary>Brands Goodreads G</summary>
        ///<see href="https://fontawesome.com/icons/goodreads-g?style=brands"/>
        [Description("Brands Goodreads G"), IconID("fab-goodreads-g"), IconUnicodeGlyph(0xf3a9)]
        BrandsGoodreadsG = 875,
        ///<summary>Brands Google Logo</summary>
        ///<see href="https://fontawesome.com/icons/google?style=brands"/>
        [Description("Brands Google Logo"), IconID("fab-google"), IconUnicodeGlyph(0xf1a0)]
        BrandsGoogle = 876,
        ///<summary>Brands Google Drive</summary>
        ///<see href="https://fontawesome.com/icons/google-drive?style=brands"/>
        [Description("Brands Google Drive"), IconID("fab-google-drive"), IconUnicodeGlyph(0xf3aa)]
        BrandsGoogleDrive = 877,
        ///<summary>Brands Google Pay</summary>
        ///<see href="https://fontawesome.com/icons/google-pay?style=brands"/>
        [Description("Brands Google Pay"), IconID("fab-google-pay"), IconUnicodeGlyph(0xe079)]
        BrandsGooglePay = 878,
        ///<summary>Brands Google Play</summary>
        ///<see href="https://fontawesome.com/icons/google-play?style=brands"/>
        [Description("Brands Google Play"), IconID("fab-google-play"), IconUnicodeGlyph(0xf3ab)]
        BrandsGooglePlay = 879,
        ///<summary>Brands Google Plus</summary>
        ///<see href="https://fontawesome.com/icons/google-plus?style=brands"/>
        [Description("Brands Google Plus"), IconID("fab-google-plus"), IconUnicodeGlyph(0xf2b3)]
        BrandsGooglePlus = 880,
        ///<summary>Brands Google Plus G</summary>
        ///<see href="https://fontawesome.com/icons/google-plus-g?style=brands"/>
        [Description("Brands Google Plus G"), IconID("fab-google-plus-g"), IconUnicodeGlyph(0xf0d5)]
        BrandsGooglePlusG = 881,
        ///<summary>Brands Google Scholar</summary>
        ///<see href="https://fontawesome.com/icons/google-scholar?style=brands"/>
        [Description("Brands Google Scholar"), IconID("fab-google-scholar"), IconUnicodeGlyph(0xe63b)]
        BrandsGoogleScholar = 882,
        ///<summary>Brands Google Wallet</summary>
        ///<see href="https://fontawesome.com/icons/google-wallet?style=brands"/>
        [Description("Brands Google Wallet"), IconID("fab-google-wallet"), IconUnicodeGlyph(0xf1ee)]
        BrandsGoogleWallet = 883,
        ///<summary>Solid Gopuram</summary>
        ///<see href="https://fontawesome.com/icons/gopuram?style=solid"/>
        [Description("Solid Gopuram"), IconID("fas-gopuram"), IconUnicodeGlyph(0xf664)]
        SolidGopuram = 884,
        ///<summary>Solid Graduation Cap</summary>
        ///<see href="https://fontawesome.com/icons/graduation-cap?style=solid"/>
        [Description("Solid Graduation Cap"), IconID("fas-graduation-cap"), IconUnicodeGlyph(0xf19d)]
        SolidGraduationCap = 885,
        ///<summary>Brands Gratipay (Gittip)</summary>
        ///<see href="https://fontawesome.com/icons/gratipay?style=brands"/>
        [Description("Brands Gratipay (Gittip)"), IconID("fab-gratipay"), IconUnicodeGlyph(0xf184)]
        BrandsGratipay = 886,
        ///<summary>Brands Grav</summary>
        ///<see href="https://fontawesome.com/icons/grav?style=brands"/>
        [Description("Brands Grav"), IconID("fab-grav"), IconUnicodeGlyph(0xf2d6)]
        BrandsGrav = 887,
        ///<summary>Solid Greater Than</summary>
        ///<see href="https://fontawesome.com/icons/greater-than?style=solid"/>
        [Description("Solid Greater Than"), IconID("fas-greater-than"), IconUnicodeGlyph(0x3e)]
        SolidGreaterThan = 888,
        ///<summary>Solid Greater Than Equal</summary>
        ///<see href="https://fontawesome.com/icons/greater-than-equal?style=solid"/>
        [Description("Solid Greater Than Equal"), IconID("fas-greater-than-equal"), IconUnicodeGlyph(0xf532)]
        SolidGreaterThanEqual = 889,
        ///<summary>Solid Grip</summary>
        ///<see href="https://fontawesome.com/icons/grip?style=solid"/>
        [Description("Solid Grip"), IconID("fas-grip"), IconUnicodeGlyph(0xf58d)]
        SolidGrip = 890,
        ///<summary>Solid Grip Lines</summary>
        ///<see href="https://fontawesome.com/icons/grip-lines?style=solid"/>
        [Description("Solid Grip Lines"), IconID("fas-grip-lines"), IconUnicodeGlyph(0xf7a4)]
        SolidGripLines = 891,
        ///<summary>Solid Grip Lines Vertical</summary>
        ///<see href="https://fontawesome.com/icons/grip-lines-vertical?style=solid"/>
        [Description("Solid Grip Lines Vertical"), IconID("fas-grip-lines-vertical"), IconUnicodeGlyph(0xf7a5)]
        SolidGripLinesVertical = 892,
        ///<summary>Solid Grip Vertical</summary>
        ///<see href="https://fontawesome.com/icons/grip-vertical?style=solid"/>
        [Description("Solid Grip Vertical"), IconID("fas-grip-vertical"), IconUnicodeGlyph(0xf58e)]
        SolidGripVertical = 893,
        ///<summary>Brands Gripfire, Inc.</summary>
        ///<see href="https://fontawesome.com/icons/gripfire?style=brands"/>
        [Description("Brands Gripfire, Inc."), IconID("fab-gripfire"), IconUnicodeGlyph(0xf3ac)]
        BrandsGripfire = 894,
        ///<summary>Solid Group Arrows Rotate</summary>
        ///<see href="https://fontawesome.com/icons/group-arrows-rotate?style=solid"/>
        [Description("Solid Group Arrows Rotate"), IconID("fas-group-arrows-rotate"), IconUnicodeGlyph(0xe4f6)]
        SolidGroupArrowsRotate = 895,
        ///<summary>Brands Grunt</summary>
        ///<see href="https://fontawesome.com/icons/grunt?style=brands"/>
        [Description("Brands Grunt"), IconID("fab-grunt"), IconUnicodeGlyph(0xf3ad)]
        BrandsGrunt = 896,
        ///<summary>Solid Guarani Sign</summary>
        ///<see href="https://fontawesome.com/icons/guarani-sign?style=solid"/>
        [Description("Solid Guarani Sign"), IconID("fas-guarani-sign"), IconUnicodeGlyph(0xe19a)]
        SolidGuaraniSign = 897,
        ///<summary>Brands Guilded</summary>
        ///<see href="https://fontawesome.com/icons/guilded?style=brands"/>
        [Description("Brands Guilded"), IconID("fab-guilded"), IconUnicodeGlyph(0xe07e)]
        BrandsGuilded = 898,
        ///<summary>Solid Guitar</summary>
        ///<see href="https://fontawesome.com/icons/guitar?style=solid"/>
        [Description("Solid Guitar"), IconID("fas-guitar"), IconUnicodeGlyph(0xf7a6)]
        SolidGuitar = 899,
        ///<summary>Brands Gulp</summary>
        ///<see href="https://fontawesome.com/icons/gulp?style=brands"/>
        [Description("Brands Gulp"), IconID("fab-gulp"), IconUnicodeGlyph(0xf3ae)]
        BrandsGulp = 900,
        ///<summary>Solid Gun</summary>
        ///<see href="https://fontawesome.com/icons/gun?style=solid"/>
        [Description("Solid Gun"), IconID("fas-gun"), IconUnicodeGlyph(0xe19b)]
        SolidGun = 901,
        ///<summary>Solid H</summary>
        ///<see href="https://fontawesome.com/icons/h?style=solid"/>
        [Description("Solid H"), IconID("fas-h"), IconUnicodeGlyph(0x48)]
        SolidH = 902,
        ///<summary>Brands Hacker News</summary>
        ///<see href="https://fontawesome.com/icons/hacker-news?style=brands"/>
        [Description("Brands Hacker News"), IconID("fab-hacker-news"), IconUnicodeGlyph(0xf1d4)]
        BrandsHackerNews = 903,
        ///<summary>Brands Hackerrank</summary>
        ///<see href="https://fontawesome.com/icons/hackerrank?style=brands"/>
        [Description("Brands Hackerrank"), IconID("fab-hackerrank"), IconUnicodeGlyph(0xf5f7)]
        BrandsHackerrank = 904,
        ///<summary>Solid Hammer</summary>
        ///<see href="https://fontawesome.com/icons/hammer?style=solid"/>
        [Description("Solid Hammer"), IconID("fas-hammer"), IconUnicodeGlyph(0xf6e3)]
        SolidHammer = 905,
        ///<summary>Solid Hamsa</summary>
        ///<see href="https://fontawesome.com/icons/hamsa?style=solid"/>
        [Description("Solid Hamsa"), IconID("fas-hamsa"), IconUnicodeGlyph(0xf665)]
        SolidHamsa = 906,
        ///<summary>Solid Hand</summary>
        ///<see href="https://fontawesome.com/icons/hand?style=solid"/>
        [Description("Solid Hand"), IconID("fas-hand"), IconUnicodeGlyph(0xf256)]
        SolidHand = 907,
        ///<summary>Regular Hand</summary>
        ///<see href="https://fontawesome.com/icons/hand?style=regular"/>
        [Description("Regular Hand"), IconID("far-hand"), IconUnicodeGlyph(0xf256)]
        RegularHand = 908,
        ///<summary>Solid Hand Back Fist</summary>
        ///<see href="https://fontawesome.com/icons/hand-back-fist?style=solid"/>
        [Description("Solid Hand Back Fist"), IconID("fas-hand-back-fist"), IconUnicodeGlyph(0xf255)]
        SolidHandBackFist = 909,
        ///<summary>Regular Hand Back Fist</summary>
        ///<see href="https://fontawesome.com/icons/hand-back-fist?style=regular"/>
        [Description("Regular Hand Back Fist"), IconID("far-hand-back-fist"), IconUnicodeGlyph(0xf255)]
        RegularHandBackFist = 910,
        ///<summary>Solid Hand Dots</summary>
        ///<see href="https://fontawesome.com/icons/hand-dots?style=solid"/>
        [Description("Solid Hand Dots"), IconID("fas-hand-dots"), IconUnicodeGlyph(0xf461)]
        SolidHandDots = 911,
        ///<summary>Solid Hand Fist</summary>
        ///<see href="https://fontawesome.com/icons/hand-fist?style=solid"/>
        [Description("Solid Hand Fist"), IconID("fas-hand-fist"), IconUnicodeGlyph(0xf6de)]
        SolidHandFist = 912,
        ///<summary>Solid Hand Holding</summary>
        ///<see href="https://fontawesome.com/icons/hand-holding?style=solid"/>
        [Description("Solid Hand Holding"), IconID("fas-hand-holding"), IconUnicodeGlyph(0xf4bd)]
        SolidHandHolding = 913,
        ///<summary>Solid Hand Holding Dollar</summary>
        ///<see href="https://fontawesome.com/icons/hand-holding-dollar?style=solid"/>
        [Description("Solid Hand Holding Dollar"), IconID("fas-hand-holding-dollar"), IconUnicodeGlyph(0xf4c0)]
        SolidHandHoldingDollar = 914,
        ///<summary>Solid Hand Holding Droplet</summary>
        ///<see href="https://fontawesome.com/icons/hand-holding-droplet?style=solid"/>
        [Description("Solid Hand Holding Droplet"), IconID("fas-hand-holding-droplet"), IconUnicodeGlyph(0xf4c1)]
        SolidHandHoldingDroplet = 915,
        ///<summary>Solid Hand Holding Hand</summary>
        ///<see href="https://fontawesome.com/icons/hand-holding-hand?style=solid"/>
        [Description("Solid Hand Holding Hand"), IconID("fas-hand-holding-hand"), IconUnicodeGlyph(0xe4f7)]
        SolidHandHoldingHand = 916,
        ///<summary>Solid Hand Holding Heart</summary>
        ///<see href="https://fontawesome.com/icons/hand-holding-heart?style=solid"/>
        [Description("Solid Hand Holding Heart"), IconID("fas-hand-holding-heart"), IconUnicodeGlyph(0xf4be)]
        SolidHandHoldingHeart = 917,
        ///<summary>Solid Hand Holding Medical</summary>
        ///<see href="https://fontawesome.com/icons/hand-holding-medical?style=solid"/>
        [Description("Solid Hand Holding Medical"), IconID("fas-hand-holding-medical"), IconUnicodeGlyph(0xe05c)]
        SolidHandHoldingMedical = 918,
        ///<summary>Solid Hand Lizard</summary>
        ///<see href="https://fontawesome.com/icons/hand-lizard?style=solid"/>
        [Description("Solid Hand Lizard"), IconID("fas-hand-lizard"), IconUnicodeGlyph(0xf258)]
        SolidHandLizard = 919,
        ///<summary>Regular Hand Lizard</summary>
        ///<see href="https://fontawesome.com/icons/hand-lizard?style=regular"/>
        [Description("Regular Hand Lizard"), IconID("far-hand-lizard"), IconUnicodeGlyph(0xf258)]
        RegularHandLizard = 920,
        ///<summary>Solid Hand Middle Finger</summary>
        ///<see href="https://fontawesome.com/icons/hand-middle-finger?style=solid"/>
        [Description("Solid Hand Middle Finger"), IconID("fas-hand-middle-finger"), IconUnicodeGlyph(0xf806)]
        SolidHandMiddleFinger = 921,
        ///<summary>Solid Hand Peace</summary>
        ///<see href="https://fontawesome.com/icons/hand-peace?style=solid"/>
        [Description("Solid Hand Peace"), IconID("fas-hand-peace"), IconUnicodeGlyph(0xf25b)]
        SolidHandPeace = 922,
        ///<summary>Regular Hand Peace</summary>
        ///<see href="https://fontawesome.com/icons/hand-peace?style=regular"/>
        [Description("Regular Hand Peace"), IconID("far-hand-peace"), IconUnicodeGlyph(0xf25b)]
        RegularHandPeace = 923,
        ///<summary>Solid Hand Point Down</summary>
        ///<see href="https://fontawesome.com/icons/hand-point-down?style=solid"/>
        [Description("Solid Hand Point Down"), IconID("fas-hand-point-down"), IconUnicodeGlyph(0xf0a7)]
        SolidHandPointDown = 924,
        ///<summary>Regular Hand Point Down</summary>
        ///<see href="https://fontawesome.com/icons/hand-point-down?style=regular"/>
        [Description("Regular Hand Point Down"), IconID("far-hand-point-down"), IconUnicodeGlyph(0xf0a7)]
        RegularHandPointDown = 925,
        ///<summary>Solid Hand Point Left</summary>
        ///<see href="https://fontawesome.com/icons/hand-point-left?style=solid"/>
        [Description("Solid Hand Point Left"), IconID("fas-hand-point-left"), IconUnicodeGlyph(0xf0a5)]
        SolidHandPointLeft = 926,
        ///<summary>Regular Hand Point Left</summary>
        ///<see href="https://fontawesome.com/icons/hand-point-left?style=regular"/>
        [Description("Regular Hand Point Left"), IconID("far-hand-point-left"), IconUnicodeGlyph(0xf0a5)]
        RegularHandPointLeft = 927,
        ///<summary>Solid Hand Point Right</summary>
        ///<see href="https://fontawesome.com/icons/hand-point-right?style=solid"/>
        [Description("Solid Hand Point Right"), IconID("fas-hand-point-right"), IconUnicodeGlyph(0xf0a4)]
        SolidHandPointRight = 928,
        ///<summary>Regular Hand Point Right</summary>
        ///<see href="https://fontawesome.com/icons/hand-point-right?style=regular"/>
        [Description("Regular Hand Point Right"), IconID("far-hand-point-right"), IconUnicodeGlyph(0xf0a4)]
        RegularHandPointRight = 929,
        ///<summary>Solid Hand Point Up</summary>
        ///<see href="https://fontawesome.com/icons/hand-point-up?style=solid"/>
        [Description("Solid Hand Point Up"), IconID("fas-hand-point-up"), IconUnicodeGlyph(0xf0a6)]
        SolidHandPointUp = 930,
        ///<summary>Regular Hand Point Up</summary>
        ///<see href="https://fontawesome.com/icons/hand-point-up?style=regular"/>
        [Description("Regular Hand Point Up"), IconID("far-hand-point-up"), IconUnicodeGlyph(0xf0a6)]
        RegularHandPointUp = 931,
        ///<summary>Solid Hand Pointer</summary>
        ///<see href="https://fontawesome.com/icons/hand-pointer?style=solid"/>
        [Description("Solid Hand Pointer"), IconID("fas-hand-pointer"), IconUnicodeGlyph(0xf25a)]
        SolidHandPointer = 932,
        ///<summary>Regular Hand Pointer</summary>
        ///<see href="https://fontawesome.com/icons/hand-pointer?style=regular"/>
        [Description("Regular Hand Pointer"), IconID("far-hand-pointer"), IconUnicodeGlyph(0xf25a)]
        RegularHandPointer = 933,
        ///<summary>Solid Hand Scissors</summary>
        ///<see href="https://fontawesome.com/icons/hand-scissors?style=solid"/>
        [Description("Solid Hand Scissors"), IconID("fas-hand-scissors"), IconUnicodeGlyph(0xf257)]
        SolidHandScissors = 934,
        ///<summary>Regular Hand Scissors</summary>
        ///<see href="https://fontawesome.com/icons/hand-scissors?style=regular"/>
        [Description("Regular Hand Scissors"), IconID("far-hand-scissors"), IconUnicodeGlyph(0xf257)]
        RegularHandScissors = 935,
        ///<summary>Solid Hand Sparkles</summary>
        ///<see href="https://fontawesome.com/icons/hand-sparkles?style=solid"/>
        [Description("Solid Hand Sparkles"), IconID("fas-hand-sparkles"), IconUnicodeGlyph(0xe05d)]
        SolidHandSparkles = 936,
        ///<summary>Solid Hand Spock</summary>
        ///<see href="https://fontawesome.com/icons/hand-spock?style=solid"/>
        [Description("Solid Hand Spock"), IconID("fas-hand-spock"), IconUnicodeGlyph(0xf259)]
        SolidHandSpock = 937,
        ///<summary>Regular Hand Spock</summary>
        ///<see href="https://fontawesome.com/icons/hand-spock?style=regular"/>
        [Description("Regular Hand Spock"), IconID("far-hand-spock"), IconUnicodeGlyph(0xf259)]
        RegularHandSpock = 938,
        ///<summary>Solid Handcuffs</summary>
        ///<see href="https://fontawesome.com/icons/handcuffs?style=solid"/>
        [Description("Solid Handcuffs"), IconID("fas-handcuffs"), IconUnicodeGlyph(0xe4f8)]
        SolidHandcuffs = 939,
        ///<summary>Solid Hands</summary>
        ///<see href="https://fontawesome.com/icons/hands?style=solid"/>
        [Description("Solid Hands"), IconID("fas-hands"), IconUnicodeGlyph(0xf2a7)]
        SolidHands = 940,
        ///<summary>Solid Hands Asl Interpreting</summary>
        ///<see href="https://fontawesome.com/icons/hands-asl-interpreting?style=solid"/>
        [Description("Solid Hands Asl Interpreting"), IconID("fas-hands-asl-interpreting"), IconUnicodeGlyph(0xf2a3)]
        SolidHandsAslInterpreting = 941,
        ///<summary>Solid Hands Bound</summary>
        ///<see href="https://fontawesome.com/icons/hands-bound?style=solid"/>
        [Description("Solid Hands Bound"), IconID("fas-hands-bound"), IconUnicodeGlyph(0xe4f9)]
        SolidHandsBound = 942,
        ///<summary>Solid Hands Bubbles</summary>
        ///<see href="https://fontawesome.com/icons/hands-bubbles?style=solid"/>
        [Description("Solid Hands Bubbles"), IconID("fas-hands-bubbles"), IconUnicodeGlyph(0xe05e)]
        SolidHandsBubbles = 943,
        ///<summary>Solid Hands Clapping</summary>
        ///<see href="https://fontawesome.com/icons/hands-clapping?style=solid"/>
        [Description("Solid Hands Clapping"), IconID("fas-hands-clapping"), IconUnicodeGlyph(0xe1a8)]
        SolidHandsClapping = 944,
        ///<summary>Solid Hands Holding</summary>
        ///<see href="https://fontawesome.com/icons/hands-holding?style=solid"/>
        [Description("Solid Hands Holding"), IconID("fas-hands-holding"), IconUnicodeGlyph(0xf4c2)]
        SolidHandsHolding = 945,
        ///<summary>Solid Hands Holding Child</summary>
        ///<see href="https://fontawesome.com/icons/hands-holding-child?style=solid"/>
        [Description("Solid Hands Holding Child"), IconID("fas-hands-holding-child"), IconUnicodeGlyph(0xe4fa)]
        SolidHandsHoldingChild = 946,
        ///<summary>Solid Hands Holding Circle</summary>
        ///<see href="https://fontawesome.com/icons/hands-holding-circle?style=solid"/>
        [Description("Solid Hands Holding Circle"), IconID("fas-hands-holding-circle"), IconUnicodeGlyph(0xe4fb)]
        SolidHandsHoldingCircle = 947,
        ///<summary>Solid Hands Praying</summary>
        ///<see href="https://fontawesome.com/icons/hands-praying?style=solid"/>
        [Description("Solid Hands Praying"), IconID("fas-hands-praying"), IconUnicodeGlyph(0xf684)]
        SolidHandsPraying = 948,
        ///<summary>Solid Handshake</summary>
        ///<see href="https://fontawesome.com/icons/handshake?style=solid"/>
        [Description("Solid Handshake"), IconID("fas-handshake"), IconUnicodeGlyph(0xf2b5)]
        SolidHandshake = 949,
        ///<summary>Regular Handshake</summary>
        ///<see href="https://fontawesome.com/icons/handshake?style=regular"/>
        [Description("Regular Handshake"), IconID("far-handshake"), IconUnicodeGlyph(0xf2b5)]
        RegularHandshake = 950,
        ///<summary>Solid Handshake Angle</summary>
        ///<see href="https://fontawesome.com/icons/handshake-angle?style=solid"/>
        [Description("Solid Handshake Angle"), IconID("fas-handshake-angle"), IconUnicodeGlyph(0xf4c4)]
        SolidHandshakeAngle = 951,
        ///<summary>Solid Handshake Simple</summary>
        ///<see href="https://fontawesome.com/icons/handshake-simple?style=solid"/>
        [Description("Solid Handshake Simple"), IconID("fas-handshake-simple"), IconUnicodeGlyph(0xf4c6)]
        SolidHandshakeSimple = 952,
        ///<summary>Solid Handshake Simple Slash</summary>
        ///<see href="https://fontawesome.com/icons/handshake-simple-slash?style=solid"/>
        [Description("Solid Handshake Simple Slash"), IconID("fas-handshake-simple-slash"), IconUnicodeGlyph(0xe05f)]
        SolidHandshakeSimpleSlash = 953,
        ///<summary>Solid Handshake Slash</summary>
        ///<see href="https://fontawesome.com/icons/handshake-slash?style=solid"/>
        [Description("Solid Handshake Slash"), IconID("fas-handshake-slash"), IconUnicodeGlyph(0xe060)]
        SolidHandshakeSlash = 954,
        ///<summary>Solid Hanukiah</summary>
        ///<see href="https://fontawesome.com/icons/hanukiah?style=solid"/>
        [Description("Solid Hanukiah"), IconID("fas-hanukiah"), IconUnicodeGlyph(0xf6e6)]
        SolidHanukiah = 955,
        ///<summary>Solid Hard Drive</summary>
        ///<see href="https://fontawesome.com/icons/hard-drive?style=solid"/>
        [Description("Solid Hard Drive"), IconID("fas-hard-drive"), IconUnicodeGlyph(0xf0a0)]
        SolidHardDrive = 956,
        ///<summary>Regular Hard Drive</summary>
        ///<see href="https://fontawesome.com/icons/hard-drive?style=regular"/>
        [Description("Regular Hard Drive"), IconID("far-hard-drive"), IconUnicodeGlyph(0xf0a0)]
        RegularHardDrive = 957,
        ///<summary>Brands Hashnode</summary>
        ///<see href="https://fontawesome.com/icons/hashnode?style=brands"/>
        [Description("Brands Hashnode"), IconID("fab-hashnode"), IconUnicodeGlyph(0xe499)]
        BrandsHashnode = 958,
        ///<summary>Solid Hashtag</summary>
        ///<see href="https://fontawesome.com/icons/hashtag?style=solid"/>
        [Description("Solid Hashtag"), IconID("fas-hashtag"), IconUnicodeGlyph(0x23)]
        SolidHashtag = 959,
        ///<summary>Solid Hat Cowboy</summary>
        ///<see href="https://fontawesome.com/icons/hat-cowboy?style=solid"/>
        [Description("Solid Hat Cowboy"), IconID("fas-hat-cowboy"), IconUnicodeGlyph(0xf8c0)]
        SolidHatCowboy = 960,
        ///<summary>Solid Hat Cowboy Side</summary>
        ///<see href="https://fontawesome.com/icons/hat-cowboy-side?style=solid"/>
        [Description("Solid Hat Cowboy Side"), IconID("fas-hat-cowboy-side"), IconUnicodeGlyph(0xf8c1)]
        SolidHatCowboySide = 961,
        ///<summary>Solid Hat Wizard</summary>
        ///<see href="https://fontawesome.com/icons/hat-wizard?style=solid"/>
        [Description("Solid Hat Wizard"), IconID("fas-hat-wizard"), IconUnicodeGlyph(0xf6e8)]
        SolidHatWizard = 962,
        ///<summary>Solid Head Side Cough</summary>
        ///<see href="https://fontawesome.com/icons/head-side-cough?style=solid"/>
        [Description("Solid Head Side Cough"), IconID("fas-head-side-cough"), IconUnicodeGlyph(0xe061)]
        SolidHeadSideCough = 963,
        ///<summary>Solid Head Side Cough Slash</summary>
        ///<see href="https://fontawesome.com/icons/head-side-cough-slash?style=solid"/>
        [Description("Solid Head Side Cough Slash"), IconID("fas-head-side-cough-slash"), IconUnicodeGlyph(0xe062)]
        SolidHeadSideCoughSlash = 964,
        ///<summary>Solid Head Side Mask</summary>
        ///<see href="https://fontawesome.com/icons/head-side-mask?style=solid"/>
        [Description("Solid Head Side Mask"), IconID("fas-head-side-mask"), IconUnicodeGlyph(0xe063)]
        SolidHeadSideMask = 965,
        ///<summary>Solid Head Side Virus</summary>
        ///<see href="https://fontawesome.com/icons/head-side-virus?style=solid"/>
        [Description("Solid Head Side Virus"), IconID("fas-head-side-virus"), IconUnicodeGlyph(0xe064)]
        SolidHeadSideVirus = 966,
        ///<summary>Solid Heading</summary>
        ///<see href="https://fontawesome.com/icons/heading?style=solid"/>
        [Description("Solid Heading"), IconID("fas-heading"), IconUnicodeGlyph(0xf1dc)]
        SolidHeading = 967,
        ///<summary>Solid Headphones</summary>
        ///<see href="https://fontawesome.com/icons/headphones?style=solid"/>
        [Description("Solid Headphones"), IconID("fas-headphones"), IconUnicodeGlyph(0xf025)]
        SolidHeadphones = 968,
        ///<summary>Solid Headphones Simple</summary>
        ///<see href="https://fontawesome.com/icons/headphones-simple?style=solid"/>
        [Description("Solid Headphones Simple"), IconID("fas-headphones-simple"), IconUnicodeGlyph(0xf58f)]
        SolidHeadphonesSimple = 969,
        ///<summary>Solid Headset</summary>
        ///<see href="https://fontawesome.com/icons/headset?style=solid"/>
        [Description("Solid Headset"), IconID("fas-headset"), IconUnicodeGlyph(0xf590)]
        SolidHeadset = 970,
        ///<summary>Solid Heart</summary>
        ///<see href="https://fontawesome.com/icons/heart?style=solid"/>
        [Description("Solid Heart"), IconID("fas-heart"), IconUnicodeGlyph(0xf004)]
        SolidHeart = 971,
        ///<summary>Regular Heart</summary>
        ///<see href="https://fontawesome.com/icons/heart?style=regular"/>
        [Description("Regular Heart"), IconID("far-heart"), IconUnicodeGlyph(0xf004)]
        RegularHeart = 972,
        ///<summary>Solid Heart Circle Bolt</summary>
        ///<see href="https://fontawesome.com/icons/heart-circle-bolt?style=solid"/>
        [Description("Solid Heart Circle Bolt"), IconID("fas-heart-circle-bolt"), IconUnicodeGlyph(0xe4fc)]
        SolidHeartCircleBolt = 973,
        ///<summary>Solid Heart Circle Check</summary>
        ///<see href="https://fontawesome.com/icons/heart-circle-check?style=solid"/>
        [Description("Solid Heart Circle Check"), IconID("fas-heart-circle-check"), IconUnicodeGlyph(0xe4fd)]
        SolidHeartCircleCheck = 974,
        ///<summary>Solid Heart Circle Exclamation</summary>
        ///<see href="https://fontawesome.com/icons/heart-circle-exclamation?style=solid"/>
        [Description("Solid Heart Circle Exclamation"), IconID("fas-heart-circle-exclamation"), IconUnicodeGlyph(0xe4fe)]
        SolidHeartCircleExclamation = 975,
        ///<summary>Solid Heart Circle Minus</summary>
        ///<see href="https://fontawesome.com/icons/heart-circle-minus?style=solid"/>
        [Description("Solid Heart Circle Minus"), IconID("fas-heart-circle-minus"), IconUnicodeGlyph(0xe4ff)]
        SolidHeartCircleMinus = 976,
        ///<summary>Solid Heart Circle Plus</summary>
        ///<see href="https://fontawesome.com/icons/heart-circle-plus?style=solid"/>
        [Description("Solid Heart Circle Plus"), IconID("fas-heart-circle-plus"), IconUnicodeGlyph(0xe500)]
        SolidHeartCirclePlus = 977,
        ///<summary>Solid Heart Circle Xmark</summary>
        ///<see href="https://fontawesome.com/icons/heart-circle-xmark?style=solid"/>
        [Description("Solid Heart Circle Xmark"), IconID("fas-heart-circle-xmark"), IconUnicodeGlyph(0xe501)]
        SolidHeartCircleXmark = 978,
        ///<summary>Solid Heart Crack</summary>
        ///<see href="https://fontawesome.com/icons/heart-crack?style=solid"/>
        [Description("Solid Heart Crack"), IconID("fas-heart-crack"), IconUnicodeGlyph(0xf7a9)]
        SolidHeartCrack = 979,
        ///<summary>Solid Heart Pulse</summary>
        ///<see href="https://fontawesome.com/icons/heart-pulse?style=solid"/>
        [Description("Solid Heart Pulse"), IconID("fas-heart-pulse"), IconUnicodeGlyph(0xf21e)]
        SolidHeartPulse = 980,
        ///<summary>Solid Helicopter</summary>
        ///<see href="https://fontawesome.com/icons/helicopter?style=solid"/>
        [Description("Solid Helicopter"), IconID("fas-helicopter"), IconUnicodeGlyph(0xf533)]
        SolidHelicopter = 981,
        ///<summary>Solid Helicopter Symbol</summary>
        ///<see href="https://fontawesome.com/icons/helicopter-symbol?style=solid"/>
        [Description("Solid Helicopter Symbol"), IconID("fas-helicopter-symbol"), IconUnicodeGlyph(0xe502)]
        SolidHelicopterSymbol = 982,
        ///<summary>Solid Helmet Safety</summary>
        ///<see href="https://fontawesome.com/icons/helmet-safety?style=solid"/>
        [Description("Solid Helmet Safety"), IconID("fas-helmet-safety"), IconUnicodeGlyph(0xf807)]
        SolidHelmetSafety = 983,
        ///<summary>Solid Helmet Un</summary>
        ///<see href="https://fontawesome.com/icons/helmet-un?style=solid"/>
        [Description("Solid Helmet Un"), IconID("fas-helmet-un"), IconUnicodeGlyph(0xe503)]
        SolidHelmetUn = 984,
        ///<summary>Solid Hexagon Nodes</summary>
        ///<see href="https://fontawesome.com/icons/hexagon-nodes?style=solid"/>
        [Description("Solid Hexagon Nodes"), IconID("fas-hexagon-nodes"), IconUnicodeGlyph(0xe699)]
        SolidHexagonNodes = 985,
        ///<summary>Solid Hexagon Nodes Bolt</summary>
        ///<see href="https://fontawesome.com/icons/hexagon-nodes-bolt?style=solid"/>
        [Description("Solid Hexagon Nodes Bolt"), IconID("fas-hexagon-nodes-bolt"), IconUnicodeGlyph(0xe69a)]
        SolidHexagonNodesBolt = 986,
        ///<summary>Solid Highlighter</summary>
        ///<see href="https://fontawesome.com/icons/highlighter?style=solid"/>
        [Description("Solid Highlighter"), IconID("fas-highlighter"), IconUnicodeGlyph(0xf591)]
        SolidHighlighter = 987,
        ///<summary>Solid Hill Avalanche</summary>
        ///<see href="https://fontawesome.com/icons/hill-avalanche?style=solid"/>
        [Description("Solid Hill Avalanche"), IconID("fas-hill-avalanche"), IconUnicodeGlyph(0xe507)]
        SolidHillAvalanche = 988,
        ///<summary>Solid Hill Rockslide</summary>
        ///<see href="https://fontawesome.com/icons/hill-rockslide?style=solid"/>
        [Description("Solid Hill Rockslide"), IconID("fas-hill-rockslide"), IconUnicodeGlyph(0xe508)]
        SolidHillRockslide = 989,
        ///<summary>Solid Hippo</summary>
        ///<see href="https://fontawesome.com/icons/hippo?style=solid"/>
        [Description("Solid Hippo"), IconID("fas-hippo"), IconUnicodeGlyph(0xf6ed)]
        SolidHippo = 990,
        ///<summary>Brands Hips</summary>
        ///<see href="https://fontawesome.com/icons/hips?style=brands"/>
        [Description("Brands Hips"), IconID("fab-hips"), IconUnicodeGlyph(0xf452)]
        BrandsHips = 991,
        ///<summary>Brands HireAHelper</summary>
        ///<see href="https://fontawesome.com/icons/hire-a-helper?style=brands"/>
        [Description("Brands HireAHelper"), IconID("fab-hire-a-helper"), IconUnicodeGlyph(0xf3b0)]
        BrandsHireAHelper = 992,
        ///<summary>Brands Hive Blockchain Network</summary>
        ///<see href="https://fontawesome.com/icons/hive?style=brands"/>
        [Description("Brands Hive Blockchain Network"), IconID("fab-hive"), IconUnicodeGlyph(0xe07f)]
        BrandsHive = 993,
        ///<summary>Solid Hockey Puck</summary>
        ///<see href="https://fontawesome.com/icons/hockey-puck?style=solid"/>
        [Description("Solid Hockey Puck"), IconID("fas-hockey-puck"), IconUnicodeGlyph(0xf453)]
        SolidHockeyPuck = 994,
        ///<summary>Solid Holly Berry</summary>
        ///<see href="https://fontawesome.com/icons/holly-berry?style=solid"/>
        [Description("Solid Holly Berry"), IconID("fas-holly-berry"), IconUnicodeGlyph(0xf7aa)]
        SolidHollyBerry = 995,
        ///<summary>Brands Hooli</summary>
        ///<see href="https://fontawesome.com/icons/hooli?style=brands"/>
        [Description("Brands Hooli"), IconID("fab-hooli"), IconUnicodeGlyph(0xf427)]
        BrandsHooli = 996,
        ///<summary>Brands Hornbill</summary>
        ///<see href="https://fontawesome.com/icons/hornbill?style=brands"/>
        [Description("Brands Hornbill"), IconID("fab-hornbill"), IconUnicodeGlyph(0xf592)]
        BrandsHornbill = 997,
        ///<summary>Solid Horse</summary>
        ///<see href="https://fontawesome.com/icons/horse?style=solid"/>
        [Description("Solid Horse"), IconID("fas-horse"), IconUnicodeGlyph(0xf6f0)]
        SolidHorse = 998,
        ///<summary>Solid Horse Head</summary>
        ///<see href="https://fontawesome.com/icons/horse-head?style=solid"/>
        [Description("Solid Horse Head"), IconID("fas-horse-head"), IconUnicodeGlyph(0xf7ab)]
        SolidHorseHead = 999,
        ///<summary>Solid Hospital</summary>
        ///<see href="https://fontawesome.com/icons/hospital?style=solid"/>
        [Description("Solid Hospital"), IconID("fas-hospital"), IconUnicodeGlyph(0xf0f8)]
        SolidHospital = 1000,
        ///<summary>Regular Hospital</summary>
        ///<see href="https://fontawesome.com/icons/hospital?style=regular"/>
        [Description("Regular Hospital"), IconID("far-hospital"), IconUnicodeGlyph(0xf0f8)]
        RegularHospital = 1001,
        ///<summary>Solid Hospital User</summary>
        ///<see href="https://fontawesome.com/icons/hospital-user?style=solid"/>
        [Description("Solid Hospital User"), IconID("fas-hospital-user"), IconUnicodeGlyph(0xf80d)]
        SolidHospitalUser = 1002,
        ///<summary>Solid Hot Tub Person</summary>
        ///<see href="https://fontawesome.com/icons/hot-tub-person?style=solid"/>
        [Description("Solid Hot Tub Person"), IconID("fas-hot-tub-person"), IconUnicodeGlyph(0xf593)]
        SolidHotTubPerson = 1003,
        ///<summary>Solid Hotdog</summary>
        ///<see href="https://fontawesome.com/icons/hotdog?style=solid"/>
        [Description("Solid Hotdog"), IconID("fas-hotdog"), IconUnicodeGlyph(0xf80f)]
        SolidHotdog = 1004,
        ///<summary>Solid Hotel</summary>
        ///<see href="https://fontawesome.com/icons/hotel?style=solid"/>
        [Description("Solid Hotel"), IconID("fas-hotel"), IconUnicodeGlyph(0xf594)]
        SolidHotel = 1005,
        ///<summary>Brands Hotjar</summary>
        ///<see href="https://fontawesome.com/icons/hotjar?style=brands"/>
        [Description("Brands Hotjar"), IconID("fab-hotjar"), IconUnicodeGlyph(0xf3b1)]
        BrandsHotjar = 1006,
        ///<summary>Solid Hourglass</summary>
        ///<see href="https://fontawesome.com/icons/hourglass?style=solid"/>
        [Description("Solid Hourglass"), IconID("fas-hourglass"), IconUnicodeGlyph(0xf254)]
        SolidHourglass = 1007,
        ///<summary>Regular Hourglass</summary>
        ///<see href="https://fontawesome.com/icons/hourglass?style=regular"/>
        [Description("Regular Hourglass"), IconID("far-hourglass"), IconUnicodeGlyph(0xf254)]
        RegularHourglass = 1008,
        ///<summary>Solid Hourglass End</summary>
        ///<see href="https://fontawesome.com/icons/hourglass-end?style=solid"/>
        [Description("Solid Hourglass End"), IconID("fas-hourglass-end"), IconUnicodeGlyph(0xf253)]
        SolidHourglassEnd = 1009,
        ///<summary>Solid Hourglass Half</summary>
        ///<see href="https://fontawesome.com/icons/hourglass-half?style=solid"/>
        [Description("Solid Hourglass Half"), IconID("fas-hourglass-half"), IconUnicodeGlyph(0xf252)]
        SolidHourglassHalf = 1010,
        ///<summary>Regular Hourglass Half</summary>
        ///<see href="https://fontawesome.com/icons/hourglass-half?style=regular"/>
        [Description("Regular Hourglass Half"), IconID("far-hourglass-half"), IconUnicodeGlyph(0xf252)]
        RegularHourglassHalf = 1011,
        ///<summary>Solid Hourglass Start</summary>
        ///<see href="https://fontawesome.com/icons/hourglass-start?style=solid"/>
        [Description("Solid Hourglass Start"), IconID("fas-hourglass-start"), IconUnicodeGlyph(0xf251)]
        SolidHourglassStart = 1012,
        ///<summary>Solid House</summary>
        ///<see href="https://fontawesome.com/icons/house?style=solid"/>
        [Description("Solid House"), IconID("fas-house"), IconUnicodeGlyph(0xf015)]
        SolidHouse = 1013,
        ///<summary>Solid House Chimney</summary>
        ///<see href="https://fontawesome.com/icons/house-chimney?style=solid"/>
        [Description("Solid House Chimney"), IconID("fas-house-chimney"), IconUnicodeGlyph(0xe3af)]
        SolidHouseChimney = 1014,
        ///<summary>Solid House Chimney Crack</summary>
        ///<see href="https://fontawesome.com/icons/house-chimney-crack?style=solid"/>
        [Description("Solid House Chimney Crack"), IconID("fas-house-chimney-crack"), IconUnicodeGlyph(0xf6f1)]
        SolidHouseChimneyCrack = 1015,
        ///<summary>Solid House Chimney Medical</summary>
        ///<see href="https://fontawesome.com/icons/house-chimney-medical?style=solid"/>
        [Description("Solid House Chimney Medical"), IconID("fas-house-chimney-medical"), IconUnicodeGlyph(0xf7f2)]
        SolidHouseChimneyMedical = 1016,
        ///<summary>Solid House Chimney User</summary>
        ///<see href="https://fontawesome.com/icons/house-chimney-user?style=solid"/>
        [Description("Solid House Chimney User"), IconID("fas-house-chimney-user"), IconUnicodeGlyph(0xe065)]
        SolidHouseChimneyUser = 1017,
        ///<summary>Solid House Chimney Window</summary>
        ///<see href="https://fontawesome.com/icons/house-chimney-window?style=solid"/>
        [Description("Solid House Chimney Window"), IconID("fas-house-chimney-window"), IconUnicodeGlyph(0xe00d)]
        SolidHouseChimneyWindow = 1018,
        ///<summary>Solid House Circle Check</summary>
        ///<see href="https://fontawesome.com/icons/house-circle-check?style=solid"/>
        [Description("Solid House Circle Check"), IconID("fas-house-circle-check"), IconUnicodeGlyph(0xe509)]
        SolidHouseCircleCheck = 1019,
        ///<summary>Solid House Circle Exclamation</summary>
        ///<see href="https://fontawesome.com/icons/house-circle-exclamation?style=solid"/>
        [Description("Solid House Circle Exclamation"), IconID("fas-house-circle-exclamation"), IconUnicodeGlyph(0xe50a)]
        SolidHouseCircleExclamation = 1020,
        ///<summary>Solid House Circle Xmark</summary>
        ///<see href="https://fontawesome.com/icons/house-circle-xmark?style=solid"/>
        [Description("Solid House Circle Xmark"), IconID("fas-house-circle-xmark"), IconUnicodeGlyph(0xe50b)]
        SolidHouseCircleXmark = 1021,
        ///<summary>Solid House Crack</summary>
        ///<see href="https://fontawesome.com/icons/house-crack?style=solid"/>
        [Description("Solid House Crack"), IconID("fas-house-crack"), IconUnicodeGlyph(0xe3b1)]
        SolidHouseCrack = 1022,
        ///<summary>Solid House Fire</summary>
        ///<see href="https://fontawesome.com/icons/house-fire?style=solid"/>
        [Description("Solid House Fire"), IconID("fas-house-fire"), IconUnicodeGlyph(0xe50c)]
        SolidHouseFire = 1023,
        ///<summary>Solid House Flag</summary>
        ///<see href="https://fontawesome.com/icons/house-flag?style=solid"/>
        [Description("Solid House Flag"), IconID("fas-house-flag"), IconUnicodeGlyph(0xe50d)]
        SolidHouseFlag = 1024,
        ///<summary>Solid House Flood Water</summary>
        ///<see href="https://fontawesome.com/icons/house-flood-water?style=solid"/>
        [Description("Solid House Flood Water"), IconID("fas-house-flood-water"), IconUnicodeGlyph(0xe50e)]
        SolidHouseFloodWater = 1025,
        ///<summary>Solid House Flood Water Circle Arrow Right</summary>
        ///<see href="https://fontawesome.com/icons/house-flood-water-circle-arrow-right?style=solid"/>
        [Description("Solid House Flood Water Circle Arrow Right"), IconID("fas-house-flood-water-circle-arrow-right"), IconUnicodeGlyph(0xe50f)]
        SolidHouseFloodWaterCircleArrowRight = 1026,
        ///<summary>Solid House Laptop</summary>
        ///<see href="https://fontawesome.com/icons/house-laptop?style=solid"/>
        [Description("Solid House Laptop"), IconID("fas-house-laptop"), IconUnicodeGlyph(0xe066)]
        SolidHouseLaptop = 1027,
        ///<summary>Solid House Lock</summary>
        ///<see href="https://fontawesome.com/icons/house-lock?style=solid"/>
        [Description("Solid House Lock"), IconID("fas-house-lock"), IconUnicodeGlyph(0xe510)]
        SolidHouseLock = 1028,
        ///<summary>Solid House Medical</summary>
        ///<see href="https://fontawesome.com/icons/house-medical?style=solid"/>
        [Description("Solid House Medical"), IconID("fas-house-medical"), IconUnicodeGlyph(0xe3b2)]
        SolidHouseMedical = 1029,
        ///<summary>Solid House Medical Circle Check</summary>
        ///<see href="https://fontawesome.com/icons/house-medical-circle-check?style=solid"/>
        [Description("Solid House Medical Circle Check"), IconID("fas-house-medical-circle-check"), IconUnicodeGlyph(0xe511)]
        SolidHouseMedicalCircleCheck = 1030,
        ///<summary>Solid House Medical Circle Exclamation</summary>
        ///<see href="https://fontawesome.com/icons/house-medical-circle-exclamation?style=solid"/>
        [Description("Solid House Medical Circle Exclamation"), IconID("fas-house-medical-circle-exclamation"), IconUnicodeGlyph(0xe512)]
        SolidHouseMedicalCircleExclamation = 1031,
        ///<summary>Solid House Medical Circle Xmark</summary>
        ///<see href="https://fontawesome.com/icons/house-medical-circle-xmark?style=solid"/>
        [Description("Solid House Medical Circle Xmark"), IconID("fas-house-medical-circle-xmark"), IconUnicodeGlyph(0xe513)]
        SolidHouseMedicalCircleXmark = 1032,
        ///<summary>Solid House Medical Flag</summary>
        ///<see href="https://fontawesome.com/icons/house-medical-flag?style=solid"/>
        [Description("Solid House Medical Flag"), IconID("fas-house-medical-flag"), IconUnicodeGlyph(0xe514)]
        SolidHouseMedicalFlag = 1033,
        ///<summary>Solid House Signal</summary>
        ///<see href="https://fontawesome.com/icons/house-signal?style=solid"/>
        [Description("Solid House Signal"), IconID("fas-house-signal"), IconUnicodeGlyph(0xe012)]
        SolidHouseSignal = 1034,
        ///<summary>Solid House Tsunami</summary>
        ///<see href="https://fontawesome.com/icons/house-tsunami?style=solid"/>
        [Description("Solid House Tsunami"), IconID("fas-house-tsunami"), IconUnicodeGlyph(0xe515)]
        SolidHouseTsunami = 1035,
        ///<summary>Solid House User</summary>
        ///<see href="https://fontawesome.com/icons/house-user?style=solid"/>
        [Description("Solid House User"), IconID("fas-house-user"), IconUnicodeGlyph(0xe1b0)]
        SolidHouseUser = 1036,
        ///<summary>Brands Houzz</summary>
        ///<see href="https://fontawesome.com/icons/houzz?style=brands"/>
        [Description("Brands Houzz"), IconID("fab-houzz"), IconUnicodeGlyph(0xf27c)]
        BrandsHouzz = 1037,
        ///<summary>Solid Hryvnia Sign</summary>
        ///<see href="https://fontawesome.com/icons/hryvnia-sign?style=solid"/>
        [Description("Solid Hryvnia Sign"), IconID("fas-hryvnia-sign"), IconUnicodeGlyph(0xf6f2)]
        SolidHryvniaSign = 1038,
        ///<summary>Brands HTML 5 Logo</summary>
        ///<see href="https://fontawesome.com/icons/html5?style=brands"/>
        [Description("Brands HTML 5 Logo"), IconID("fab-html5"), IconUnicodeGlyph(0xf13b)]
        BrandsHtml5 = 1039,
        ///<summary>Brands HubSpot</summary>
        ///<see href="https://fontawesome.com/icons/hubspot?style=brands"/>
        [Description("Brands HubSpot"), IconID("fab-hubspot"), IconUnicodeGlyph(0xf3b2)]
        BrandsHubspot = 1040,
        ///<summary>Solid Hurricane</summary>
        ///<see href="https://fontawesome.com/icons/hurricane?style=solid"/>
        [Description("Solid Hurricane"), IconID("fas-hurricane"), IconUnicodeGlyph(0xf751)]
        SolidHurricane = 1041,
        ///<summary>Solid I</summary>
        ///<see href="https://fontawesome.com/icons/i?style=solid"/>
        [Description("Solid I"), IconID("fas-i"), IconUnicodeGlyph(0x49)]
        SolidI = 1042,
        ///<summary>Solid I Cursor</summary>
        ///<see href="https://fontawesome.com/icons/i-cursor?style=solid"/>
        [Description("Solid I Cursor"), IconID("fas-i-cursor"), IconUnicodeGlyph(0xf246)]
        SolidICursor = 1043,
        ///<summary>Solid Ice Cream</summary>
        ///<see href="https://fontawesome.com/icons/ice-cream?style=solid"/>
        [Description("Solid Ice Cream"), IconID("fas-ice-cream"), IconUnicodeGlyph(0xf810)]
        SolidIceCream = 1044,
        ///<summary>Solid Icicles</summary>
        ///<see href="https://fontawesome.com/icons/icicles?style=solid"/>
        [Description("Solid Icicles"), IconID("fas-icicles"), IconUnicodeGlyph(0xf7ad)]
        SolidIcicles = 1045,
        ///<summary>Solid Icons</summary>
        ///<see href="https://fontawesome.com/icons/icons?style=solid"/>
        [Description("Solid Icons"), IconID("fas-icons"), IconUnicodeGlyph(0xf86d)]
        SolidIcons = 1046,
        ///<summary>Solid Id Badge</summary>
        ///<see href="https://fontawesome.com/icons/id-badge?style=solid"/>
        [Description("Solid Id Badge"), IconID("fas-id-badge"), IconUnicodeGlyph(0xf2c1)]
        SolidIdBadge = 1047,
        ///<summary>Regular Id Badge</summary>
        ///<see href="https://fontawesome.com/icons/id-badge?style=regular"/>
        [Description("Regular Id Badge"), IconID("far-id-badge"), IconUnicodeGlyph(0xf2c1)]
        RegularIdBadge = 1048,
        ///<summary>Solid Id Card</summary>
        ///<see href="https://fontawesome.com/icons/id-card?style=solid"/>
        [Description("Solid Id Card"), IconID("fas-id-card"), IconUnicodeGlyph(0xf2c2)]
        SolidIdCard = 1049,
        ///<summary>Regular Id Card</summary>
        ///<see href="https://fontawesome.com/icons/id-card?style=regular"/>
        [Description("Regular Id Card"), IconID("far-id-card"), IconUnicodeGlyph(0xf2c2)]
        RegularIdCard = 1050,
        ///<summary>Solid Id Card Clip</summary>
        ///<see href="https://fontawesome.com/icons/id-card-clip?style=solid"/>
        [Description("Solid Id Card Clip"), IconID("fas-id-card-clip"), IconUnicodeGlyph(0xf47f)]
        SolidIdCardClip = 1051,
        ///<summary>Brands iDeal</summary>
        ///<see href="https://fontawesome.com/icons/ideal?style=brands"/>
        [Description("Brands iDeal"), IconID("fab-ideal"), IconUnicodeGlyph(0xe013)]
        BrandsIdeal = 1052,
        ///<summary>Solid Igloo</summary>
        ///<see href="https://fontawesome.com/icons/igloo?style=solid"/>
        [Description("Solid Igloo"), IconID("fas-igloo"), IconUnicodeGlyph(0xf7ae)]
        SolidIgloo = 1053,
        ///<summary>Solid Image</summary>
        ///<see href="https://fontawesome.com/icons/image?style=solid"/>
        [Description("Solid Image"), IconID("fas-image"), IconUnicodeGlyph(0xf03e)]
        SolidImage = 1054,
        ///<summary>Regular Image</summary>
        ///<see href="https://fontawesome.com/icons/image?style=regular"/>
        [Description("Regular Image"), IconID("far-image"), IconUnicodeGlyph(0xf03e)]
        RegularImage = 1055,
        ///<summary>Solid Image Portrait</summary>
        ///<see href="https://fontawesome.com/icons/image-portrait?style=solid"/>
        [Description("Solid Image Portrait"), IconID("fas-image-portrait"), IconUnicodeGlyph(0xf3e0)]
        SolidImagePortrait = 1056,
        ///<summary>Solid Images</summary>
        ///<see href="https://fontawesome.com/icons/images?style=solid"/>
        [Description("Solid Images"), IconID("fas-images"), IconUnicodeGlyph(0xf302)]
        SolidImages = 1057,
        ///<summary>Regular Images</summary>
        ///<see href="https://fontawesome.com/icons/images?style=regular"/>
        [Description("Regular Images"), IconID("far-images"), IconUnicodeGlyph(0xf302)]
        RegularImages = 1058,
        ///<summary>Brands IMDB</summary>
        ///<see href="https://fontawesome.com/icons/imdb?style=brands"/>
        [Description("Brands IMDB"), IconID("fab-imdb"), IconUnicodeGlyph(0xf2d8)]
        BrandsImdb = 1059,
        ///<summary>Solid Inbox</summary>
        ///<see href="https://fontawesome.com/icons/inbox?style=solid"/>
        [Description("Solid Inbox"), IconID("fas-inbox"), IconUnicodeGlyph(0xf01c)]
        SolidInbox = 1060,
        ///<summary>Solid Indent</summary>
        ///<see href="https://fontawesome.com/icons/indent?style=solid"/>
        [Description("Solid Indent"), IconID("fas-indent"), IconUnicodeGlyph(0xf03c)]
        SolidIndent = 1061,
        ///<summary>Solid Indian Rupee Sign</summary>
        ///<see href="https://fontawesome.com/icons/indian-rupee-sign?style=solid"/>
        [Description("Solid Indian Rupee Sign"), IconID("fas-indian-rupee-sign"), IconUnicodeGlyph(0xe1bc)]
        SolidIndianRupeeSign = 1062,
        ///<summary>Solid Industry</summary>
        ///<see href="https://fontawesome.com/icons/industry?style=solid"/>
        [Description("Solid Industry"), IconID("fas-industry"), IconUnicodeGlyph(0xf275)]
        SolidIndustry = 1063,
        ///<summary>Solid Infinity</summary>
        ///<see href="https://fontawesome.com/icons/infinity?style=solid"/>
        [Description("Solid Infinity"), IconID("fas-infinity"), IconUnicodeGlyph(0xf534)]
        SolidInfinity = 1064,
        ///<summary>Solid Info</summary>
        ///<see href="https://fontawesome.com/icons/info?style=solid"/>
        [Description("Solid Info"), IconID("fas-info"), IconUnicodeGlyph(0xf129)]
        SolidInfo = 1065,
        ///<summary>Brands Instagram</summary>
        ///<see href="https://fontawesome.com/icons/instagram?style=brands"/>
        [Description("Brands Instagram"), IconID("fab-instagram"), IconUnicodeGlyph(0xf16d)]
        BrandsInstagram = 1066,
        ///<summary>Brands InstaLOD</summary>
        ///<see href="https://fontawesome.com/icons/instalod?style=brands"/>
        [Description("Brands InstaLOD"), IconID("fab-instalod"), IconUnicodeGlyph(0xe081)]
        BrandsInstalod = 1067,
        ///<summary>Brands Intercom</summary>
        ///<see href="https://fontawesome.com/icons/intercom?style=brands"/>
        [Description("Brands Intercom"), IconID("fab-intercom"), IconUnicodeGlyph(0xf7af)]
        BrandsIntercom = 1068,
        ///<summary>Brands Internet-explorer</summary>
        ///<see href="https://fontawesome.com/icons/internet-explorer?style=brands"/>
        [Description("Brands Internet-explorer"), IconID("fab-internet-explorer"), IconUnicodeGlyph(0xf26b)]
        BrandsInternetExplorer = 1069,
        ///<summary>Brands InVision</summary>
        ///<see href="https://fontawesome.com/icons/invision?style=brands"/>
        [Description("Brands InVision"), IconID("fab-invision"), IconUnicodeGlyph(0xf7b0)]
        BrandsInvision = 1070,
        ///<summary>Brands ioxhost</summary>
        ///<see href="https://fontawesome.com/icons/ioxhost?style=brands"/>
        [Description("Brands ioxhost"), IconID("fab-ioxhost"), IconUnicodeGlyph(0xf208)]
        BrandsIoxhost = 1071,
        ///<summary>Solid Italic</summary>
        ///<see href="https://fontawesome.com/icons/italic?style=solid"/>
        [Description("Solid Italic"), IconID("fas-italic"), IconUnicodeGlyph(0xf033)]
        SolidItalic = 1072,
        ///<summary>Brands itch.io</summary>
        ///<see href="https://fontawesome.com/icons/itch-io?style=brands"/>
        [Description("Brands itch.io"), IconID("fab-itch-io"), IconUnicodeGlyph(0xf83a)]
        BrandsItchIo = 1073,
        ///<summary>Brands iTunes</summary>
        ///<see href="https://fontawesome.com/icons/itunes?style=brands"/>
        [Description("Brands iTunes"), IconID("fab-itunes"), IconUnicodeGlyph(0xf3b4)]
        BrandsItunes = 1074,
        ///<summary>Brands Itunes Note</summary>
        ///<see href="https://fontawesome.com/icons/itunes-note?style=brands"/>
        [Description("Brands Itunes Note"), IconID("fab-itunes-note"), IconUnicodeGlyph(0xf3b5)]
        BrandsItunesNote = 1075,
        ///<summary>Solid J</summary>
        ///<see href="https://fontawesome.com/icons/j?style=solid"/>
        [Description("Solid J"), IconID("fas-j"), IconUnicodeGlyph(0x4a)]
        SolidJ = 1076,
        ///<summary>Solid Jar</summary>
        ///<see href="https://fontawesome.com/icons/jar?style=solid"/>
        [Description("Solid Jar"), IconID("fas-jar"), IconUnicodeGlyph(0xe516)]
        SolidJar = 1077,
        ///<summary>Solid Jar Wheat</summary>
        ///<see href="https://fontawesome.com/icons/jar-wheat?style=solid"/>
        [Description("Solid Jar Wheat"), IconID("fas-jar-wheat"), IconUnicodeGlyph(0xe517)]
        SolidJarWheat = 1078,
        ///<summary>Brands Java</summary>
        ///<see href="https://fontawesome.com/icons/java?style=brands"/>
        [Description("Brands Java"), IconID("fab-java"), IconUnicodeGlyph(0xf4e4)]
        BrandsJava = 1079,
        ///<summary>Solid Jedi</summary>
        ///<see href="https://fontawesome.com/icons/jedi?style=solid"/>
        [Description("Solid Jedi"), IconID("fas-jedi"), IconUnicodeGlyph(0xf669)]
        SolidJedi = 1080,
        ///<summary>Brands Jedi Order</summary>
        ///<see href="https://fontawesome.com/icons/jedi-order?style=brands"/>
        [Description("Brands Jedi Order"), IconID("fab-jedi-order"), IconUnicodeGlyph(0xf50e)]
        BrandsJediOrder = 1081,
        ///<summary>Brands Jenkis</summary>
        ///<see href="https://fontawesome.com/icons/jenkins?style=brands"/>
        [Description("Brands Jenkis"), IconID("fab-jenkins"), IconUnicodeGlyph(0xf3b6)]
        BrandsJenkins = 1082,
        ///<summary>Solid Jet Fighter</summary>
        ///<see href="https://fontawesome.com/icons/jet-fighter?style=solid"/>
        [Description("Solid Jet Fighter"), IconID("fas-jet-fighter"), IconUnicodeGlyph(0xf0fb)]
        SolidJetFighter = 1083,
        ///<summary>Solid Jet Fighter Up</summary>
        ///<see href="https://fontawesome.com/icons/jet-fighter-up?style=solid"/>
        [Description("Solid Jet Fighter Up"), IconID("fas-jet-fighter-up"), IconUnicodeGlyph(0xe518)]
        SolidJetFighterUp = 1084,
        ///<summary>Brands Jira</summary>
        ///<see href="https://fontawesome.com/icons/jira?style=brands"/>
        [Description("Brands Jira"), IconID("fab-jira"), IconUnicodeGlyph(0xf7b1)]
        BrandsJira = 1085,
        ///<summary>Brands Joget</summary>
        ///<see href="https://fontawesome.com/icons/joget?style=brands"/>
        [Description("Brands Joget"), IconID("fab-joget"), IconUnicodeGlyph(0xf3b7)]
        BrandsJoget = 1086,
        ///<summary>Solid Joint</summary>
        ///<see href="https://fontawesome.com/icons/joint?style=solid"/>
        [Description("Solid Joint"), IconID("fas-joint"), IconUnicodeGlyph(0xf595)]
        SolidJoint = 1087,
        ///<summary>Brands Joomla Logo</summary>
        ///<see href="https://fontawesome.com/icons/joomla?style=brands"/>
        [Description("Brands Joomla Logo"), IconID("fab-joomla"), IconUnicodeGlyph(0xf1aa)]
        BrandsJoomla = 1088,
        ///<summary>Brands JavaScript (JS)</summary>
        ///<see href="https://fontawesome.com/icons/js?style=brands"/>
        [Description("Brands JavaScript (JS)"), IconID("fab-js"), IconUnicodeGlyph(0xf3b8)]
        BrandsJs = 1089,
        ///<summary>Brands jsFiddle</summary>
        ///<see href="https://fontawesome.com/icons/jsfiddle?style=brands"/>
        [Description("Brands jsFiddle"), IconID("fab-jsfiddle"), IconUnicodeGlyph(0xf1cc)]
        BrandsJsfiddle = 1090,
        ///<summary>Solid Jug Detergent</summary>
        ///<see href="https://fontawesome.com/icons/jug-detergent?style=solid"/>
        [Description("Solid Jug Detergent"), IconID("fas-jug-detergent"), IconUnicodeGlyph(0xe519)]
        SolidJugDetergent = 1091,
        ///<summary>Brands JXL</summary>
        ///<see href="https://fontawesome.com/icons/jxl?style=brands"/>
        [Description("Brands JXL"), IconID("fab-jxl"), IconUnicodeGlyph(0xe67b)]
        BrandsJxl = 1092,
        ///<summary>Solid K</summary>
        ///<see href="https://fontawesome.com/icons/k?style=solid"/>
        [Description("Solid K"), IconID("fas-k"), IconUnicodeGlyph(0x4b)]
        SolidK = 1093,
        ///<summary>Solid Kaaba</summary>
        ///<see href="https://fontawesome.com/icons/kaaba?style=solid"/>
        [Description("Solid Kaaba"), IconID("fas-kaaba"), IconUnicodeGlyph(0xf66b)]
        SolidKaaba = 1094,
        ///<summary>Brands Kaggle</summary>
        ///<see href="https://fontawesome.com/icons/kaggle?style=brands"/>
        [Description("Brands Kaggle"), IconID("fab-kaggle"), IconUnicodeGlyph(0xf5fa)]
        BrandsKaggle = 1095,
        ///<summary>Solid Key</summary>
        ///<see href="https://fontawesome.com/icons/key?style=solid"/>
        [Description("Solid Key"), IconID("fas-key"), IconUnicodeGlyph(0xf084)]
        SolidKey = 1096,
        ///<summary>Brands Keybase</summary>
        ///<see href="https://fontawesome.com/icons/keybase?style=brands"/>
        [Description("Brands Keybase"), IconID("fab-keybase"), IconUnicodeGlyph(0xf4f5)]
        BrandsKeybase = 1097,
        ///<summary>Solid Keyboard</summary>
        ///<see href="https://fontawesome.com/icons/keyboard?style=solid"/>
        [Description("Solid Keyboard"), IconID("fas-keyboard"), IconUnicodeGlyph(0xf11c)]
        SolidKeyboard = 1098,
        ///<summary>Regular Keyboard</summary>
        ///<see href="https://fontawesome.com/icons/keyboard?style=regular"/>
        [Description("Regular Keyboard"), IconID("far-keyboard"), IconUnicodeGlyph(0xf11c)]
        RegularKeyboard = 1099,
        ///<summary>Brands KeyCDN</summary>
        ///<see href="https://fontawesome.com/icons/keycdn?style=brands"/>
        [Description("Brands KeyCDN"), IconID("fab-keycdn"), IconUnicodeGlyph(0xf3ba)]
        BrandsKeycdn = 1100,
        ///<summary>Solid Khanda</summary>
        ///<see href="https://fontawesome.com/icons/khanda?style=solid"/>
        [Description("Solid Khanda"), IconID("fas-khanda"), IconUnicodeGlyph(0xf66d)]
        SolidKhanda = 1101,
        ///<summary>Brands Kickstarter</summary>
        ///<see href="https://fontawesome.com/icons/kickstarter?style=brands"/>
        [Description("Brands Kickstarter"), IconID("fab-kickstarter"), IconUnicodeGlyph(0xf3bb)]
        BrandsKickstarter = 1102,
        ///<summary>Brands Kickstarter K</summary>
        ///<see href="https://fontawesome.com/icons/kickstarter-k?style=brands"/>
        [Description("Brands Kickstarter K"), IconID("fab-kickstarter-k"), IconUnicodeGlyph(0xf3bc)]
        BrandsKickstarterK = 1103,
        ///<summary>Solid Kip Sign</summary>
        ///<see href="https://fontawesome.com/icons/kip-sign?style=solid"/>
        [Description("Solid Kip Sign"), IconID("fas-kip-sign"), IconUnicodeGlyph(0xe1c4)]
        SolidKipSign = 1104,
        ///<summary>Solid Kit Medical</summary>
        ///<see href="https://fontawesome.com/icons/kit-medical?style=solid"/>
        [Description("Solid Kit Medical"), IconID("fas-kit-medical"), IconUnicodeGlyph(0xf479)]
        SolidKitMedical = 1105,
        ///<summary>Solid Kitchen Set</summary>
        ///<see href="https://fontawesome.com/icons/kitchen-set?style=solid"/>
        [Description("Solid Kitchen Set"), IconID("fas-kitchen-set"), IconUnicodeGlyph(0xe51a)]
        SolidKitchenSet = 1106,
        ///<summary>Solid Kiwi Bird</summary>
        ///<see href="https://fontawesome.com/icons/kiwi-bird?style=solid"/>
        [Description("Solid Kiwi Bird"), IconID("fas-kiwi-bird"), IconUnicodeGlyph(0xf535)]
        SolidKiwiBird = 1107,
        ///<summary>Brands KORVUE</summary>
        ///<see href="https://fontawesome.com/icons/korvue?style=brands"/>
        [Description("Brands KORVUE"), IconID("fab-korvue"), IconUnicodeGlyph(0xf42f)]
        BrandsKorvue = 1108,
        ///<summary>Solid L</summary>
        ///<see href="https://fontawesome.com/icons/l?style=solid"/>
        [Description("Solid L"), IconID("fas-l"), IconUnicodeGlyph(0x4c)]
        SolidL = 1109,
        ///<summary>Solid Land Mine On</summary>
        ///<see href="https://fontawesome.com/icons/land-mine-on?style=solid"/>
        [Description("Solid Land Mine On"), IconID("fas-land-mine-on"), IconUnicodeGlyph(0xe51b)]
        SolidLandMineOn = 1110,
        ///<summary>Solid Landmark</summary>
        ///<see href="https://fontawesome.com/icons/landmark?style=solid"/>
        [Description("Solid Landmark"), IconID("fas-landmark"), IconUnicodeGlyph(0xf66f)]
        SolidLandmark = 1111,
        ///<summary>Solid Landmark Dome</summary>
        ///<see href="https://fontawesome.com/icons/landmark-dome?style=solid"/>
        [Description("Solid Landmark Dome"), IconID("fas-landmark-dome"), IconUnicodeGlyph(0xf752)]
        SolidLandmarkDome = 1112,
        ///<summary>Solid Landmark Flag</summary>
        ///<see href="https://fontawesome.com/icons/landmark-flag?style=solid"/>
        [Description("Solid Landmark Flag"), IconID("fas-landmark-flag"), IconUnicodeGlyph(0xe51c)]
        SolidLandmarkFlag = 1113,
        ///<summary>Solid Language</summary>
        ///<see href="https://fontawesome.com/icons/language?style=solid"/>
        [Description("Solid Language"), IconID("fas-language"), IconUnicodeGlyph(0xf1ab)]
        SolidLanguage = 1114,
        ///<summary>Solid Laptop</summary>
        ///<see href="https://fontawesome.com/icons/laptop?style=solid"/>
        [Description("Solid Laptop"), IconID("fas-laptop"), IconUnicodeGlyph(0xf109)]
        SolidLaptop = 1115,
        ///<summary>Solid Laptop Code</summary>
        ///<see href="https://fontawesome.com/icons/laptop-code?style=solid"/>
        [Description("Solid Laptop Code"), IconID("fas-laptop-code"), IconUnicodeGlyph(0xf5fc)]
        SolidLaptopCode = 1116,
        ///<summary>Solid Laptop File</summary>
        ///<see href="https://fontawesome.com/icons/laptop-file?style=solid"/>
        [Description("Solid Laptop File"), IconID("fas-laptop-file"), IconUnicodeGlyph(0xe51d)]
        SolidLaptopFile = 1117,
        ///<summary>Solid Laptop Medical</summary>
        ///<see href="https://fontawesome.com/icons/laptop-medical?style=solid"/>
        [Description("Solid Laptop Medical"), IconID("fas-laptop-medical"), IconUnicodeGlyph(0xf812)]
        SolidLaptopMedical = 1118,
        ///<summary>Brands Laravel</summary>
        ///<see href="https://fontawesome.com/icons/laravel?style=brands"/>
        [Description("Brands Laravel"), IconID("fab-laravel"), IconUnicodeGlyph(0xf3bd)]
        BrandsLaravel = 1119,
        ///<summary>Solid Lari Sign</summary>
        ///<see href="https://fontawesome.com/icons/lari-sign?style=solid"/>
        [Description("Solid Lari Sign"), IconID("fas-lari-sign"), IconUnicodeGlyph(0xe1c8)]
        SolidLariSign = 1120,
        ///<summary>Brands last.fm</summary>
        ///<see href="https://fontawesome.com/icons/lastfm?style=brands"/>
        [Description("Brands last.fm"), IconID("fab-lastfm"), IconUnicodeGlyph(0xf202)]
        BrandsLastfm = 1121,
        ///<summary>Solid Layer Group</summary>
        ///<see href="https://fontawesome.com/icons/layer-group?style=solid"/>
        [Description("Solid Layer Group"), IconID("fas-layer-group"), IconUnicodeGlyph(0xf5fd)]
        SolidLayerGroup = 1122,
        ///<summary>Solid Leaf</summary>
        ///<see href="https://fontawesome.com/icons/leaf?style=solid"/>
        [Description("Solid Leaf"), IconID("fas-leaf"), IconUnicodeGlyph(0xf06c)]
        SolidLeaf = 1123,
        ///<summary>Brands Leanpub</summary>
        ///<see href="https://fontawesome.com/icons/leanpub?style=brands"/>
        [Description("Brands Leanpub"), IconID("fab-leanpub"), IconUnicodeGlyph(0xf212)]
        BrandsLeanpub = 1124,
        ///<summary>Solid Left Long</summary>
        ///<see href="https://fontawesome.com/icons/left-long?style=solid"/>
        [Description("Solid Left Long"), IconID("fas-left-long"), IconUnicodeGlyph(0xf30a)]
        SolidLeftLong = 1125,
        ///<summary>Solid Left Right</summary>
        ///<see href="https://fontawesome.com/icons/left-right?style=solid"/>
        [Description("Solid Left Right"), IconID("fas-left-right"), IconUnicodeGlyph(0xf337)]
        SolidLeftRight = 1126,
        ///<summary>Solid Lemon</summary>
        ///<see href="https://fontawesome.com/icons/lemon?style=solid"/>
        [Description("Solid Lemon"), IconID("fas-lemon"), IconUnicodeGlyph(0xf094)]
        SolidLemon = 1127,
        ///<summary>Regular Lemon</summary>
        ///<see href="https://fontawesome.com/icons/lemon?style=regular"/>
        [Description("Regular Lemon"), IconID("far-lemon"), IconUnicodeGlyph(0xf094)]
        RegularLemon = 1128,
        ///<summary>Brands Less</summary>
        ///<see href="https://fontawesome.com/icons/less?style=brands"/>
        [Description("Brands Less"), IconID("fab-less"), IconUnicodeGlyph(0xf41d)]
        BrandsLess = 1129,
        ///<summary>Solid Less Than</summary>
        ///<see href="https://fontawesome.com/icons/less-than?style=solid"/>
        [Description("Solid Less Than"), IconID("fas-less-than"), IconUnicodeGlyph(0x3c)]
        SolidLessThan = 1130,
        ///<summary>Solid Less Than Equal</summary>
        ///<see href="https://fontawesome.com/icons/less-than-equal?style=solid"/>
        [Description("Solid Less Than Equal"), IconID("fas-less-than-equal"), IconUnicodeGlyph(0xf537)]
        SolidLessThanEqual = 1131,
        ///<summary>Brands Letterboxd</summary>
        ///<see href="https://fontawesome.com/icons/letterboxd?style=brands"/>
        [Description("Brands Letterboxd"), IconID("fab-letterboxd"), IconUnicodeGlyph(0xe62d)]
        BrandsLetterboxd = 1132,
        ///<summary>Solid Life Ring</summary>
        ///<see href="https://fontawesome.com/icons/life-ring?style=solid"/>
        [Description("Solid Life Ring"), IconID("fas-life-ring"), IconUnicodeGlyph(0xf1cd)]
        SolidLifeRing = 1133,
        ///<summary>Regular Life Ring</summary>
        ///<see href="https://fontawesome.com/icons/life-ring?style=regular"/>
        [Description("Regular Life Ring"), IconID("far-life-ring"), IconUnicodeGlyph(0xf1cd)]
        RegularLifeRing = 1134,
        ///<summary>Solid Lightbulb</summary>
        ///<see href="https://fontawesome.com/icons/lightbulb?style=solid"/>
        [Description("Solid Lightbulb"), IconID("fas-lightbulb"), IconUnicodeGlyph(0xf0eb)]
        SolidLightbulb = 1135,
        ///<summary>Regular Lightbulb</summary>
        ///<see href="https://fontawesome.com/icons/lightbulb?style=regular"/>
        [Description("Regular Lightbulb"), IconID("far-lightbulb"), IconUnicodeGlyph(0xf0eb)]
        RegularLightbulb = 1136,
        ///<summary>Brands Line</summary>
        ///<see href="https://fontawesome.com/icons/line?style=brands"/>
        [Description("Brands Line"), IconID("fab-line"), IconUnicodeGlyph(0xf3c0)]
        BrandsLine = 1137,
        ///<summary>Solid Lines Leaning</summary>
        ///<see href="https://fontawesome.com/icons/lines-leaning?style=solid"/>
        [Description("Solid Lines Leaning"), IconID("fas-lines-leaning"), IconUnicodeGlyph(0xe51e)]
        SolidLinesLeaning = 1138,
        ///<summary>Solid Link</summary>
        ///<see href="https://fontawesome.com/icons/link?style=solid"/>
        [Description("Solid Link"), IconID("fas-link"), IconUnicodeGlyph(0xf0c1)]
        SolidLink = 1139,
        ///<summary>Solid Link Slash</summary>
        ///<see href="https://fontawesome.com/icons/link-slash?style=solid"/>
        [Description("Solid Link Slash"), IconID("fas-link-slash"), IconUnicodeGlyph(0xf127)]
        SolidLinkSlash = 1140,
        ///<summary>Brands LinkedIn</summary>
        ///<see href="https://fontawesome.com/icons/linkedin?style=brands"/>
        [Description("Brands LinkedIn"), IconID("fab-linkedin"), IconUnicodeGlyph(0xf08c)]
        BrandsLinkedin = 1141,
        ///<summary>Brands LinkedIn In</summary>
        ///<see href="https://fontawesome.com/icons/linkedin-in?style=brands"/>
        [Description("Brands LinkedIn In"), IconID("fab-linkedin-in"), IconUnicodeGlyph(0xf0e1)]
        BrandsLinkedinIn = 1142,
        ///<summary>Brands Linode</summary>
        ///<see href="https://fontawesome.com/icons/linode?style=brands"/>
        [Description("Brands Linode"), IconID("fab-linode"), IconUnicodeGlyph(0xf2b8)]
        BrandsLinode = 1143,
        ///<summary>Brands Linux</summary>
        ///<see href="https://fontawesome.com/icons/linux?style=brands"/>
        [Description("Brands Linux"), IconID("fab-linux"), IconUnicodeGlyph(0xf17c)]
        BrandsLinux = 1144,
        ///<summary>Solid Lira Sign</summary>
        ///<see href="https://fontawesome.com/icons/lira-sign?style=solid"/>
        [Description("Solid Lira Sign"), IconID("fas-lira-sign"), IconUnicodeGlyph(0xf195)]
        SolidLiraSign = 1145,
        ///<summary>Solid List</summary>
        ///<see href="https://fontawesome.com/icons/list?style=solid"/>
        [Description("Solid List"), IconID("fas-list"), IconUnicodeGlyph(0xf03a)]
        SolidList = 1146,
        ///<summary>Solid List Check</summary>
        ///<see href="https://fontawesome.com/icons/list-check?style=solid"/>
        [Description("Solid List Check"), IconID("fas-list-check"), IconUnicodeGlyph(0xf0ae)]
        SolidListCheck = 1147,
        ///<summary>Solid List Ol</summary>
        ///<see href="https://fontawesome.com/icons/list-ol?style=solid"/>
        [Description("Solid List Ol"), IconID("fas-list-ol"), IconUnicodeGlyph(0xf0cb)]
        SolidListOl = 1148,
        ///<summary>Solid List Ul</summary>
        ///<see href="https://fontawesome.com/icons/list-ul?style=solid"/>
        [Description("Solid List Ul"), IconID("fas-list-ul"), IconUnicodeGlyph(0xf0ca)]
        SolidListUl = 1149,
        ///<summary>Solid Litecoin Sign</summary>
        ///<see href="https://fontawesome.com/icons/litecoin-sign?style=solid"/>
        [Description("Solid Litecoin Sign"), IconID("fas-litecoin-sign"), IconUnicodeGlyph(0xe1d3)]
        SolidLitecoinSign = 1150,
        ///<summary>Solid Location Arrow</summary>
        ///<see href="https://fontawesome.com/icons/location-arrow?style=solid"/>
        [Description("Solid Location Arrow"), IconID("fas-location-arrow"), IconUnicodeGlyph(0xf124)]
        SolidLocationArrow = 1151,
        ///<summary>Solid Location Crosshairs</summary>
        ///<see href="https://fontawesome.com/icons/location-crosshairs?style=solid"/>
        [Description("Solid Location Crosshairs"), IconID("fas-location-crosshairs"), IconUnicodeGlyph(0xf601)]
        SolidLocationCrosshairs = 1152,
        ///<summary>Solid Location Dot</summary>
        ///<see href="https://fontawesome.com/icons/location-dot?style=solid"/>
        [Description("Solid Location Dot"), IconID("fas-location-dot"), IconUnicodeGlyph(0xf3c5)]
        SolidLocationDot = 1153,
        ///<summary>Solid Location Pin</summary>
        ///<see href="https://fontawesome.com/icons/location-pin?style=solid"/>
        [Description("Solid Location Pin"), IconID("fas-location-pin"), IconUnicodeGlyph(0xf041)]
        SolidLocationPin = 1154,
        ///<summary>Solid Location Pin Lock</summary>
        ///<see href="https://fontawesome.com/icons/location-pin-lock?style=solid"/>
        [Description("Solid Location Pin Lock"), IconID("fas-location-pin-lock"), IconUnicodeGlyph(0xe51f)]
        SolidLocationPinLock = 1155,
        ///<summary>Solid Lock</summary>
        ///<see href="https://fontawesome.com/icons/lock?style=solid"/>
        [Description("Solid Lock"), IconID("fas-lock"), IconUnicodeGlyph(0xf023)]
        SolidLock = 1156,
        ///<summary>Solid Lock Open</summary>
        ///<see href="https://fontawesome.com/icons/lock-open?style=solid"/>
        [Description("Solid Lock Open"), IconID("fas-lock-open"), IconUnicodeGlyph(0xf3c1)]
        SolidLockOpen = 1157,
        ///<summary>Solid Locust</summary>
        ///<see href="https://fontawesome.com/icons/locust?style=solid"/>
        [Description("Solid Locust"), IconID("fas-locust"), IconUnicodeGlyph(0xe520)]
        SolidLocust = 1158,
        ///<summary>Solid Lungs</summary>
        ///<see href="https://fontawesome.com/icons/lungs?style=solid"/>
        [Description("Solid Lungs"), IconID("fas-lungs"), IconUnicodeGlyph(0xf604)]
        SolidLungs = 1159,
        ///<summary>Solid Lungs Virus</summary>
        ///<see href="https://fontawesome.com/icons/lungs-virus?style=solid"/>
        [Description("Solid Lungs Virus"), IconID("fas-lungs-virus"), IconUnicodeGlyph(0xe067)]
        SolidLungsVirus = 1160,
        ///<summary>Brands lyft</summary>
        ///<see href="https://fontawesome.com/icons/lyft?style=brands"/>
        [Description("Brands lyft"), IconID("fab-lyft"), IconUnicodeGlyph(0xf3c3)]
        BrandsLyft = 1161,
        ///<summary>Solid M</summary>
        ///<see href="https://fontawesome.com/icons/m?style=solid"/>
        [Description("Solid M"), IconID("fas-m"), IconUnicodeGlyph(0x4d)]
        SolidM = 1162,
        ///<summary>Brands Magento</summary>
        ///<see href="https://fontawesome.com/icons/magento?style=brands"/>
        [Description("Brands Magento"), IconID("fab-magento"), IconUnicodeGlyph(0xf3c4)]
        BrandsMagento = 1163,
        ///<summary>Solid Magnet</summary>
        ///<see href="https://fontawesome.com/icons/magnet?style=solid"/>
        [Description("Solid Magnet"), IconID("fas-magnet"), IconUnicodeGlyph(0xf076)]
        SolidMagnet = 1164,
        ///<summary>Solid Magnifying Glass</summary>
        ///<see href="https://fontawesome.com/icons/magnifying-glass?style=solid"/>
        [Description("Solid Magnifying Glass"), IconID("fas-magnifying-glass"), IconUnicodeGlyph(0xf002)]
        SolidMagnifyingGlass = 1165,
        ///<summary>Solid Magnifying Glass Arrow Right</summary>
        ///<see href="https://fontawesome.com/icons/magnifying-glass-arrow-right?style=solid"/>
        [Description("Solid Magnifying Glass Arrow Right"), IconID("fas-magnifying-glass-arrow-right"), IconUnicodeGlyph(0xe521)]
        SolidMagnifyingGlassArrowRight = 1166,
        ///<summary>Solid Magnifying Glass Chart</summary>
        ///<see href="https://fontawesome.com/icons/magnifying-glass-chart?style=solid"/>
        [Description("Solid Magnifying Glass Chart"), IconID("fas-magnifying-glass-chart"), IconUnicodeGlyph(0xe522)]
        SolidMagnifyingGlassChart = 1167,
        ///<summary>Solid Magnifying Glass Dollar</summary>
        ///<see href="https://fontawesome.com/icons/magnifying-glass-dollar?style=solid"/>
        [Description("Solid Magnifying Glass Dollar"), IconID("fas-magnifying-glass-dollar"), IconUnicodeGlyph(0xf688)]
        SolidMagnifyingGlassDollar = 1168,
        ///<summary>Solid Magnifying Glass Location</summary>
        ///<see href="https://fontawesome.com/icons/magnifying-glass-location?style=solid"/>
        [Description("Solid Magnifying Glass Location"), IconID("fas-magnifying-glass-location"), IconUnicodeGlyph(0xf689)]
        SolidMagnifyingGlassLocation = 1169,
        ///<summary>Solid Magnifying Glass Minus</summary>
        ///<see href="https://fontawesome.com/icons/magnifying-glass-minus?style=solid"/>
        [Description("Solid Magnifying Glass Minus"), IconID("fas-magnifying-glass-minus"), IconUnicodeGlyph(0xf010)]
        SolidMagnifyingGlassMinus = 1170,
        ///<summary>Solid Magnifying Glass Plus</summary>
        ///<see href="https://fontawesome.com/icons/magnifying-glass-plus?style=solid"/>
        [Description("Solid Magnifying Glass Plus"), IconID("fas-magnifying-glass-plus"), IconUnicodeGlyph(0xf00e)]
        SolidMagnifyingGlassPlus = 1171,
        ///<summary>Brands Mailchimp</summary>
        ///<see href="https://fontawesome.com/icons/mailchimp?style=brands"/>
        [Description("Brands Mailchimp"), IconID("fab-mailchimp"), IconUnicodeGlyph(0xf59e)]
        BrandsMailchimp = 1172,
        ///<summary>Solid Manat Sign</summary>
        ///<see href="https://fontawesome.com/icons/manat-sign?style=solid"/>
        [Description("Solid Manat Sign"), IconID("fas-manat-sign"), IconUnicodeGlyph(0xe1d5)]
        SolidManatSign = 1173,
        ///<summary>Brands Mandalorian</summary>
        ///<see href="https://fontawesome.com/icons/mandalorian?style=brands"/>
        [Description("Brands Mandalorian"), IconID("fab-mandalorian"), IconUnicodeGlyph(0xf50f)]
        BrandsMandalorian = 1174,
        ///<summary>Solid Map</summary>
        ///<see href="https://fontawesome.com/icons/map?style=solid"/>
        [Description("Solid Map"), IconID("fas-map"), IconUnicodeGlyph(0xf279)]
        SolidMap = 1175,
        ///<summary>Regular Map</summary>
        ///<see href="https://fontawesome.com/icons/map?style=regular"/>
        [Description("Regular Map"), IconID("far-map"), IconUnicodeGlyph(0xf279)]
        RegularMap = 1176,
        ///<summary>Solid Map Location</summary>
        ///<see href="https://fontawesome.com/icons/map-location?style=solid"/>
        [Description("Solid Map Location"), IconID("fas-map-location"), IconUnicodeGlyph(0xf59f)]
        SolidMapLocation = 1177,
        ///<summary>Solid Map Location Dot</summary>
        ///<see href="https://fontawesome.com/icons/map-location-dot?style=solid"/>
        [Description("Solid Map Location Dot"), IconID("fas-map-location-dot"), IconUnicodeGlyph(0xf5a0)]
        SolidMapLocationDot = 1178,
        ///<summary>Solid Map Pin</summary>
        ///<see href="https://fontawesome.com/icons/map-pin?style=solid"/>
        [Description("Solid Map Pin"), IconID("fas-map-pin"), IconUnicodeGlyph(0xf276)]
        SolidMapPin = 1179,
        ///<summary>Brands Markdown</summary>
        ///<see href="https://fontawesome.com/icons/markdown?style=brands"/>
        [Description("Brands Markdown"), IconID("fab-markdown"), IconUnicodeGlyph(0xf60f)]
        BrandsMarkdown = 1180,
        ///<summary>Solid Marker</summary>
        ///<see href="https://fontawesome.com/icons/marker?style=solid"/>
        [Description("Solid Marker"), IconID("fas-marker"), IconUnicodeGlyph(0xf5a1)]
        SolidMarker = 1181,
        ///<summary>Solid Mars</summary>
        ///<see href="https://fontawesome.com/icons/mars?style=solid"/>
        [Description("Solid Mars"), IconID("fas-mars"), IconUnicodeGlyph(0xf222)]
        SolidMars = 1182,
        ///<summary>Solid Mars And Venus</summary>
        ///<see href="https://fontawesome.com/icons/mars-and-venus?style=solid"/>
        [Description("Solid Mars And Venus"), IconID("fas-mars-and-venus"), IconUnicodeGlyph(0xf224)]
        SolidMarsAndVenus = 1183,
        ///<summary>Solid Mars And Venus Burst</summary>
        ///<see href="https://fontawesome.com/icons/mars-and-venus-burst?style=solid"/>
        [Description("Solid Mars And Venus Burst"), IconID("fas-mars-and-venus-burst"), IconUnicodeGlyph(0xe523)]
        SolidMarsAndVenusBurst = 1184,
        ///<summary>Solid Mars Double</summary>
        ///<see href="https://fontawesome.com/icons/mars-double?style=solid"/>
        [Description("Solid Mars Double"), IconID("fas-mars-double"), IconUnicodeGlyph(0xf227)]
        SolidMarsDouble = 1185,
        ///<summary>Solid Mars Stroke</summary>
        ///<see href="https://fontawesome.com/icons/mars-stroke?style=solid"/>
        [Description("Solid Mars Stroke"), IconID("fas-mars-stroke"), IconUnicodeGlyph(0xf229)]
        SolidMarsStroke = 1186,
        ///<summary>Solid Mars Stroke Right</summary>
        ///<see href="https://fontawesome.com/icons/mars-stroke-right?style=solid"/>
        [Description("Solid Mars Stroke Right"), IconID("fas-mars-stroke-right"), IconUnicodeGlyph(0xf22b)]
        SolidMarsStrokeRight = 1187,
        ///<summary>Solid Mars Stroke Up</summary>
        ///<see href="https://fontawesome.com/icons/mars-stroke-up?style=solid"/>
        [Description("Solid Mars Stroke Up"), IconID("fas-mars-stroke-up"), IconUnicodeGlyph(0xf22a)]
        SolidMarsStrokeUp = 1188,
        ///<summary>Solid Martini Glass</summary>
        ///<see href="https://fontawesome.com/icons/martini-glass?style=solid"/>
        [Description("Solid Martini Glass"), IconID("fas-martini-glass"), IconUnicodeGlyph(0xf57b)]
        SolidMartiniGlass = 1189,
        ///<summary>Solid Martini Glass Citrus</summary>
        ///<see href="https://fontawesome.com/icons/martini-glass-citrus?style=solid"/>
        [Description("Solid Martini Glass Citrus"), IconID("fas-martini-glass-citrus"), IconUnicodeGlyph(0xf561)]
        SolidMartiniGlassCitrus = 1190,
        ///<summary>Solid Martini Glass Empty</summary>
        ///<see href="https://fontawesome.com/icons/martini-glass-empty?style=solid"/>
        [Description("Solid Martini Glass Empty"), IconID("fas-martini-glass-empty"), IconUnicodeGlyph(0xf000)]
        SolidMartiniGlassEmpty = 1191,
        ///<summary>Solid Mask</summary>
        ///<see href="https://fontawesome.com/icons/mask?style=solid"/>
        [Description("Solid Mask"), IconID("fas-mask"), IconUnicodeGlyph(0xf6fa)]
        SolidMask = 1192,
        ///<summary>Solid Mask Face</summary>
        ///<see href="https://fontawesome.com/icons/mask-face?style=solid"/>
        [Description("Solid Mask Face"), IconID("fas-mask-face"), IconUnicodeGlyph(0xe1d7)]
        SolidMaskFace = 1193,
        ///<summary>Solid Mask Ventilator</summary>
        ///<see href="https://fontawesome.com/icons/mask-ventilator?style=solid"/>
        [Description("Solid Mask Ventilator"), IconID("fas-mask-ventilator"), IconUnicodeGlyph(0xe524)]
        SolidMaskVentilator = 1194,
        ///<summary>Solid Masks Theater</summary>
        ///<see href="https://fontawesome.com/icons/masks-theater?style=solid"/>
        [Description("Solid Masks Theater"), IconID("fas-masks-theater"), IconUnicodeGlyph(0xf630)]
        SolidMasksTheater = 1195,
        ///<summary>Brands Mastodon</summary>
        ///<see href="https://fontawesome.com/icons/mastodon?style=brands"/>
        [Description("Brands Mastodon"), IconID("fab-mastodon"), IconUnicodeGlyph(0xf4f6)]
        BrandsMastodon = 1196,
        ///<summary>Solid Mattress Pillow</summary>
        ///<see href="https://fontawesome.com/icons/mattress-pillow?style=solid"/>
        [Description("Solid Mattress Pillow"), IconID("fas-mattress-pillow"), IconUnicodeGlyph(0xe525)]
        SolidMattressPillow = 1197,
        ///<summary>Brands MaxCDN</summary>
        ///<see href="https://fontawesome.com/icons/maxcdn?style=brands"/>
        [Description("Brands MaxCDN"), IconID("fab-maxcdn"), IconUnicodeGlyph(0xf136)]
        BrandsMaxcdn = 1198,
        ///<summary>Solid Maximize</summary>
        ///<see href="https://fontawesome.com/icons/maximize?style=solid"/>
        [Description("Solid Maximize"), IconID("fas-maximize"), IconUnicodeGlyph(0xf31e)]
        SolidMaximize = 1199,
        ///<summary>Brands Material Design for Bootstrap</summary>
        ///<see href="https://fontawesome.com/icons/mdb?style=brands"/>
        [Description("Brands Material Design for Bootstrap"), IconID("fab-mdb"), IconUnicodeGlyph(0xf8ca)]
        BrandsMdb = 1200,
        ///<summary>Solid Medal</summary>
        ///<see href="https://fontawesome.com/icons/medal?style=solid"/>
        [Description("Solid Medal"), IconID("fas-medal"), IconUnicodeGlyph(0xf5a2)]
        SolidMedal = 1201,
        ///<summary>Brands MedApps</summary>
        ///<see href="https://fontawesome.com/icons/medapps?style=brands"/>
        [Description("Brands MedApps"), IconID("fab-medapps"), IconUnicodeGlyph(0xf3c6)]
        BrandsMedapps = 1202,
        ///<summary>Brands Medium</summary>
        ///<see href="https://fontawesome.com/icons/medium?style=brands"/>
        [Description("Brands Medium"), IconID("fab-medium"), IconUnicodeGlyph(0xf23a)]
        BrandsMedium = 1203,
        ///<summary>Brands MRT</summary>
        ///<see href="https://fontawesome.com/icons/medrt?style=brands"/>
        [Description("Brands MRT"), IconID("fab-medrt"), IconUnicodeGlyph(0xf3c8)]
        BrandsMedrt = 1204,
        ///<summary>Brands Meetup</summary>
        ///<see href="https://fontawesome.com/icons/meetup?style=brands"/>
        [Description("Brands Meetup"), IconID("fab-meetup"), IconUnicodeGlyph(0xf2e0)]
        BrandsMeetup = 1205,
        ///<summary>Brands Megaport</summary>
        ///<see href="https://fontawesome.com/icons/megaport?style=brands"/>
        [Description("Brands Megaport"), IconID("fab-megaport"), IconUnicodeGlyph(0xf5a3)]
        BrandsMegaport = 1206,
        ///<summary>Solid Memory</summary>
        ///<see href="https://fontawesome.com/icons/memory?style=solid"/>
        [Description("Solid Memory"), IconID("fas-memory"), IconUnicodeGlyph(0xf538)]
        SolidMemory = 1207,
        ///<summary>Brands Mendeley</summary>
        ///<see href="https://fontawesome.com/icons/mendeley?style=brands"/>
        [Description("Brands Mendeley"), IconID("fab-mendeley"), IconUnicodeGlyph(0xf7b3)]
        BrandsMendeley = 1208,
        ///<summary>Solid Menorah</summary>
        ///<see href="https://fontawesome.com/icons/menorah?style=solid"/>
        [Description("Solid Menorah"), IconID("fas-menorah"), IconUnicodeGlyph(0xf676)]
        SolidMenorah = 1209,
        ///<summary>Solid Mercury</summary>
        ///<see href="https://fontawesome.com/icons/mercury?style=solid"/>
        [Description("Solid Mercury"), IconID("fas-mercury"), IconUnicodeGlyph(0xf223)]
        SolidMercury = 1210,
        ///<summary>Solid Message</summary>
        ///<see href="https://fontawesome.com/icons/message?style=solid"/>
        [Description("Solid Message"), IconID("fas-message"), IconUnicodeGlyph(0xf27a)]
        SolidMessage = 1211,
        ///<summary>Regular Message</summary>
        ///<see href="https://fontawesome.com/icons/message?style=regular"/>
        [Description("Regular Message"), IconID("far-message"), IconUnicodeGlyph(0xf27a)]
        RegularMessage = 1212,
        ///<summary>Brands Meta</summary>
        ///<see href="https://fontawesome.com/icons/meta?style=brands"/>
        [Description("Brands Meta"), IconID("fab-meta"), IconUnicodeGlyph(0xe49b)]
        BrandsMeta = 1213,
        ///<summary>Solid Meteor</summary>
        ///<see href="https://fontawesome.com/icons/meteor?style=solid"/>
        [Description("Solid Meteor"), IconID("fas-meteor"), IconUnicodeGlyph(0xf753)]
        SolidMeteor = 1214,
        ///<summary>Brands Micro.blog</summary>
        ///<see href="https://fontawesome.com/icons/microblog?style=brands"/>
        [Description("Brands Micro.blog"), IconID("fab-microblog"), IconUnicodeGlyph(0xe01a)]
        BrandsMicroblog = 1215,
        ///<summary>Solid Microchip</summary>
        ///<see href="https://fontawesome.com/icons/microchip?style=solid"/>
        [Description("Solid Microchip"), IconID("fas-microchip"), IconUnicodeGlyph(0xf2db)]
        SolidMicrochip = 1216,
        ///<summary>Solid Microphone</summary>
        ///<see href="https://fontawesome.com/icons/microphone?style=solid"/>
        [Description("Solid Microphone"), IconID("fas-microphone"), IconUnicodeGlyph(0xf130)]
        SolidMicrophone = 1217,
        ///<summary>Solid Microphone Lines</summary>
        ///<see href="https://fontawesome.com/icons/microphone-lines?style=solid"/>
        [Description("Solid Microphone Lines"), IconID("fas-microphone-lines"), IconUnicodeGlyph(0xf3c9)]
        SolidMicrophoneLines = 1218,
        ///<summary>Solid Microphone Lines Slash</summary>
        ///<see href="https://fontawesome.com/icons/microphone-lines-slash?style=solid"/>
        [Description("Solid Microphone Lines Slash"), IconID("fas-microphone-lines-slash"), IconUnicodeGlyph(0xf539)]
        SolidMicrophoneLinesSlash = 1219,
        ///<summary>Solid Microphone Slash</summary>
        ///<see href="https://fontawesome.com/icons/microphone-slash?style=solid"/>
        [Description("Solid Microphone Slash"), IconID("fas-microphone-slash"), IconUnicodeGlyph(0xf131)]
        SolidMicrophoneSlash = 1220,
        ///<summary>Solid Microscope</summary>
        ///<see href="https://fontawesome.com/icons/microscope?style=solid"/>
        [Description("Solid Microscope"), IconID("fas-microscope"), IconUnicodeGlyph(0xf610)]
        SolidMicroscope = 1221,
        ///<summary>Brands Microsoft</summary>
        ///<see href="https://fontawesome.com/icons/microsoft?style=brands"/>
        [Description("Brands Microsoft"), IconID("fab-microsoft"), IconUnicodeGlyph(0xf3ca)]
        BrandsMicrosoft = 1222,
        ///<summary>Solid Mill Sign</summary>
        ///<see href="https://fontawesome.com/icons/mill-sign?style=solid"/>
        [Description("Solid Mill Sign"), IconID("fas-mill-sign"), IconUnicodeGlyph(0xe1ed)]
        SolidMillSign = 1223,
        ///<summary>Solid Minimize</summary>
        ///<see href="https://fontawesome.com/icons/minimize?style=solid"/>
        [Description("Solid Minimize"), IconID("fas-minimize"), IconUnicodeGlyph(0xf78c)]
        SolidMinimize = 1224,
        ///<summary>Brands Mintbit</summary>
        ///<see href="https://fontawesome.com/icons/mintbit?style=brands"/>
        [Description("Brands Mintbit"), IconID("fab-mintbit"), IconUnicodeGlyph(0xe62f)]
        BrandsMintbit = 1225,
        ///<summary>Solid Minus</summary>
        ///<see href="https://fontawesome.com/icons/minus?style=solid"/>
        [Description("Solid Minus"), IconID("fas-minus"), IconUnicodeGlyph(0xf068)]
        SolidMinus = 1226,
        ///<summary>Solid Mitten</summary>
        ///<see href="https://fontawesome.com/icons/mitten?style=solid"/>
        [Description("Solid Mitten"), IconID("fas-mitten"), IconUnicodeGlyph(0xf7b5)]
        SolidMitten = 1227,
        ///<summary>Brands Mix</summary>
        ///<see href="https://fontawesome.com/icons/mix?style=brands"/>
        [Description("Brands Mix"), IconID("fab-mix"), IconUnicodeGlyph(0xf3cb)]
        BrandsMix = 1228,
        ///<summary>Brands Mixcloud</summary>
        ///<see href="https://fontawesome.com/icons/mixcloud?style=brands"/>
        [Description("Brands Mixcloud"), IconID("fab-mixcloud"), IconUnicodeGlyph(0xf289)]
        BrandsMixcloud = 1229,
        ///<summary>Brands Mixer</summary>
        ///<see href="https://fontawesome.com/icons/mixer?style=brands"/>
        [Description("Brands Mixer"), IconID("fab-mixer"), IconUnicodeGlyph(0xe056)]
        BrandsMixer = 1230,
        ///<summary>Brands Mizuni</summary>
        ///<see href="https://fontawesome.com/icons/mizuni?style=brands"/>
        [Description("Brands Mizuni"), IconID("fab-mizuni"), IconUnicodeGlyph(0xf3cc)]
        BrandsMizuni = 1231,
        ///<summary>Solid Mobile</summary>
        ///<see href="https://fontawesome.com/icons/mobile?style=solid"/>
        [Description("Solid Mobile"), IconID("fas-mobile"), IconUnicodeGlyph(0xf3ce)]
        SolidMobile = 1232,
        ///<summary>Solid Mobile Button</summary>
        ///<see href="https://fontawesome.com/icons/mobile-button?style=solid"/>
        [Description("Solid Mobile Button"), IconID("fas-mobile-button"), IconUnicodeGlyph(0xf10b)]
        SolidMobileButton = 1233,
        ///<summary>Solid Mobile Retro</summary>
        ///<see href="https://fontawesome.com/icons/mobile-retro?style=solid"/>
        [Description("Solid Mobile Retro"), IconID("fas-mobile-retro"), IconUnicodeGlyph(0xe527)]
        SolidMobileRetro = 1234,
        ///<summary>Solid Mobile Screen</summary>
        ///<see href="https://fontawesome.com/icons/mobile-screen?style=solid"/>
        [Description("Solid Mobile Screen"), IconID("fas-mobile-screen"), IconUnicodeGlyph(0xf3cf)]
        SolidMobileScreen = 1235,
        ///<summary>Solid Mobile Screen Button</summary>
        ///<see href="https://fontawesome.com/icons/mobile-screen-button?style=solid"/>
        [Description("Solid Mobile Screen Button"), IconID("fas-mobile-screen-button"), IconUnicodeGlyph(0xf3cd)]
        SolidMobileScreenButton = 1236,
        ///<summary>Brands MODX</summary>
        ///<see href="https://fontawesome.com/icons/modx?style=brands"/>
        [Description("Brands MODX"), IconID("fab-modx"), IconUnicodeGlyph(0xf285)]
        BrandsModx = 1237,
        ///<summary>Brands Monero</summary>
        ///<see href="https://fontawesome.com/icons/monero?style=brands"/>
        [Description("Brands Monero"), IconID("fab-monero"), IconUnicodeGlyph(0xf3d0)]
        BrandsMonero = 1238,
        ///<summary>Solid Money Bill</summary>
        ///<see href="https://fontawesome.com/icons/money-bill?style=solid"/>
        [Description("Solid Money Bill"), IconID("fas-money-bill"), IconUnicodeGlyph(0xf0d6)]
        SolidMoneyBill = 1239,
        ///<summary>Solid Money Bill 1</summary>
        ///<see href="https://fontawesome.com/icons/money-bill-1?style=solid"/>
        [Description("Solid Money Bill 1"), IconID("fas-money-bill-1"), IconUnicodeGlyph(0xf3d1)]
        SolidMoneyBill1 = 1240,
        ///<summary>Regular Money Bill 1</summary>
        ///<see href="https://fontawesome.com/icons/money-bill-1?style=regular"/>
        [Description("Regular Money Bill 1"), IconID("far-money-bill-1"), IconUnicodeGlyph(0xf3d1)]
        RegularMoneyBill1 = 1241,
        ///<summary>Solid Money Bill 1 Wave</summary>
        ///<see href="https://fontawesome.com/icons/money-bill-1-wave?style=solid"/>
        [Description("Solid Money Bill 1 Wave"), IconID("fas-money-bill-1-wave"), IconUnicodeGlyph(0xf53b)]
        SolidMoneyBill1Wave = 1242,
        ///<summary>Solid Money Bill Transfer</summary>
        ///<see href="https://fontawesome.com/icons/money-bill-transfer?style=solid"/>
        [Description("Solid Money Bill Transfer"), IconID("fas-money-bill-transfer"), IconUnicodeGlyph(0xe528)]
        SolidMoneyBillTransfer = 1243,
        ///<summary>Solid Money Bill Trend Up</summary>
        ///<see href="https://fontawesome.com/icons/money-bill-trend-up?style=solid"/>
        [Description("Solid Money Bill Trend Up"), IconID("fas-money-bill-trend-up"), IconUnicodeGlyph(0xe529)]
        SolidMoneyBillTrendUp = 1244,
        ///<summary>Solid Money Bill Wave</summary>
        ///<see href="https://fontawesome.com/icons/money-bill-wave?style=solid"/>
        [Description("Solid Money Bill Wave"), IconID("fas-money-bill-wave"), IconUnicodeGlyph(0xf53a)]
        SolidMoneyBillWave = 1245,
        ///<summary>Solid Money Bill Wheat</summary>
        ///<see href="https://fontawesome.com/icons/money-bill-wheat?style=solid"/>
        [Description("Solid Money Bill Wheat"), IconID("fas-money-bill-wheat"), IconUnicodeGlyph(0xe52a)]
        SolidMoneyBillWheat = 1246,
        ///<summary>Solid Money Bills</summary>
        ///<see href="https://fontawesome.com/icons/money-bills?style=solid"/>
        [Description("Solid Money Bills"), IconID("fas-money-bills"), IconUnicodeGlyph(0xe1f3)]
        SolidMoneyBills = 1247,
        ///<summary>Solid Money Check</summary>
        ///<see href="https://fontawesome.com/icons/money-check?style=solid"/>
        [Description("Solid Money Check"), IconID("fas-money-check"), IconUnicodeGlyph(0xf53c)]
        SolidMoneyCheck = 1248,
        ///<summary>Solid Money Check Dollar</summary>
        ///<see href="https://fontawesome.com/icons/money-check-dollar?style=solid"/>
        [Description("Solid Money Check Dollar"), IconID("fas-money-check-dollar"), IconUnicodeGlyph(0xf53d)]
        SolidMoneyCheckDollar = 1249,
        ///<summary>Solid Monument</summary>
        ///<see href="https://fontawesome.com/icons/monument?style=solid"/>
        [Description("Solid Monument"), IconID("fas-monument"), IconUnicodeGlyph(0xf5a6)]
        SolidMonument = 1250,
        ///<summary>Solid Moon</summary>
        ///<see href="https://fontawesome.com/icons/moon?style=solid"/>
        [Description("Solid Moon"), IconID("fas-moon"), IconUnicodeGlyph(0xf186)]
        SolidMoon = 1251,
        ///<summary>Regular Moon</summary>
        ///<see href="https://fontawesome.com/icons/moon?style=regular"/>
        [Description("Regular Moon"), IconID("far-moon"), IconUnicodeGlyph(0xf186)]
        RegularMoon = 1252,
        ///<summary>Solid Mortar Pestle</summary>
        ///<see href="https://fontawesome.com/icons/mortar-pestle?style=solid"/>
        [Description("Solid Mortar Pestle"), IconID("fas-mortar-pestle"), IconUnicodeGlyph(0xf5a7)]
        SolidMortarPestle = 1253,
        ///<summary>Solid Mosque</summary>
        ///<see href="https://fontawesome.com/icons/mosque?style=solid"/>
        [Description("Solid Mosque"), IconID("fas-mosque"), IconUnicodeGlyph(0xf678)]
        SolidMosque = 1254,
        ///<summary>Solid Mosquito</summary>
        ///<see href="https://fontawesome.com/icons/mosquito?style=solid"/>
        [Description("Solid Mosquito"), IconID("fas-mosquito"), IconUnicodeGlyph(0xe52b)]
        SolidMosquito = 1255,
        ///<summary>Solid Mosquito Net</summary>
        ///<see href="https://fontawesome.com/icons/mosquito-net?style=solid"/>
        [Description("Solid Mosquito Net"), IconID("fas-mosquito-net"), IconUnicodeGlyph(0xe52c)]
        SolidMosquitoNet = 1256,
        ///<summary>Solid Motorcycle</summary>
        ///<see href="https://fontawesome.com/icons/motorcycle?style=solid"/>
        [Description("Solid Motorcycle"), IconID("fas-motorcycle"), IconUnicodeGlyph(0xf21c)]
        SolidMotorcycle = 1257,
        ///<summary>Solid Mound</summary>
        ///<see href="https://fontawesome.com/icons/mound?style=solid"/>
        [Description("Solid Mound"), IconID("fas-mound"), IconUnicodeGlyph(0xe52d)]
        SolidMound = 1258,
        ///<summary>Solid Mountain</summary>
        ///<see href="https://fontawesome.com/icons/mountain?style=solid"/>
        [Description("Solid Mountain"), IconID("fas-mountain"), IconUnicodeGlyph(0xf6fc)]
        SolidMountain = 1259,
        ///<summary>Solid Mountain City</summary>
        ///<see href="https://fontawesome.com/icons/mountain-city?style=solid"/>
        [Description("Solid Mountain City"), IconID("fas-mountain-city"), IconUnicodeGlyph(0xe52e)]
        SolidMountainCity = 1260,
        ///<summary>Solid Mountain Sun</summary>
        ///<see href="https://fontawesome.com/icons/mountain-sun?style=solid"/>
        [Description("Solid Mountain Sun"), IconID("fas-mountain-sun"), IconUnicodeGlyph(0xe52f)]
        SolidMountainSun = 1261,
        ///<summary>Solid Mug Hot</summary>
        ///<see href="https://fontawesome.com/icons/mug-hot?style=solid"/>
        [Description("Solid Mug Hot"), IconID("fas-mug-hot"), IconUnicodeGlyph(0xf7b6)]
        SolidMugHot = 1262,
        ///<summary>Solid Mug Saucer</summary>
        ///<see href="https://fontawesome.com/icons/mug-saucer?style=solid"/>
        [Description("Solid Mug Saucer"), IconID("fas-mug-saucer"), IconUnicodeGlyph(0xf0f4)]
        SolidMugSaucer = 1263,
        ///<summary>Solid Music</summary>
        ///<see href="https://fontawesome.com/icons/music?style=solid"/>
        [Description("Solid Music"), IconID("fas-music"), IconUnicodeGlyph(0xf001)]
        SolidMusic = 1264,
        ///<summary>Solid N</summary>
        ///<see href="https://fontawesome.com/icons/n?style=solid"/>
        [Description("Solid N"), IconID("fas-n"), IconUnicodeGlyph(0x4e)]
        SolidN = 1265,
        ///<summary>Solid Naira Sign</summary>
        ///<see href="https://fontawesome.com/icons/naira-sign?style=solid"/>
        [Description("Solid Naira Sign"), IconID("fas-naira-sign"), IconUnicodeGlyph(0xe1f6)]
        SolidNairaSign = 1266,
        ///<summary>Brands Napster</summary>
        ///<see href="https://fontawesome.com/icons/napster?style=brands"/>
        [Description("Brands Napster"), IconID("fab-napster"), IconUnicodeGlyph(0xf3d2)]
        BrandsNapster = 1267,
        ///<summary>Brands Neos</summary>
        ///<see href="https://fontawesome.com/icons/neos?style=brands"/>
        [Description("Brands Neos"), IconID("fab-neos"), IconUnicodeGlyph(0xf612)]
        BrandsNeos = 1268,
        ///<summary>Solid Network Wired</summary>
        ///<see href="https://fontawesome.com/icons/network-wired?style=solid"/>
        [Description("Solid Network Wired"), IconID("fas-network-wired"), IconUnicodeGlyph(0xf6ff)]
        SolidNetworkWired = 1269,
        ///<summary>Solid Neuter</summary>
        ///<see href="https://fontawesome.com/icons/neuter?style=solid"/>
        [Description("Solid Neuter"), IconID("fas-neuter"), IconUnicodeGlyph(0xf22c)]
        SolidNeuter = 1270,
        ///<summary>Solid Newspaper</summary>
        ///<see href="https://fontawesome.com/icons/newspaper?style=solid"/>
        [Description("Solid Newspaper"), IconID("fas-newspaper"), IconUnicodeGlyph(0xf1ea)]
        SolidNewspaper = 1271,
        ///<summary>Regular Newspaper</summary>
        ///<see href="https://fontawesome.com/icons/newspaper?style=regular"/>
        [Description("Regular Newspaper"), IconID("far-newspaper"), IconUnicodeGlyph(0xf1ea)]
        RegularNewspaper = 1272,
        ///<summary>Brands NFC Directional</summary>
        ///<see href="https://fontawesome.com/icons/nfc-directional?style=brands"/>
        [Description("Brands NFC Directional"), IconID("fab-nfc-directional"), IconUnicodeGlyph(0xe530)]
        BrandsNfcDirectional = 1273,
        ///<summary>Brands Nfc Symbol</summary>
        ///<see href="https://fontawesome.com/icons/nfc-symbol?style=brands"/>
        [Description("Brands Nfc Symbol"), IconID("fab-nfc-symbol"), IconUnicodeGlyph(0xe531)]
        BrandsNfcSymbol = 1274,
        ///<summary>Brands Nimblr</summary>
        ///<see href="https://fontawesome.com/icons/nimblr?style=brands"/>
        [Description("Brands Nimblr"), IconID("fab-nimblr"), IconUnicodeGlyph(0xf5a8)]
        BrandsNimblr = 1275,
        ///<summary>Brands Node.js</summary>
        ///<see href="https://fontawesome.com/icons/node?style=brands"/>
        [Description("Brands Node.js"), IconID("fab-node"), IconUnicodeGlyph(0xf419)]
        BrandsNode = 1276,
        ///<summary>Brands Node.js JS</summary>
        ///<see href="https://fontawesome.com/icons/node-js?style=brands"/>
        [Description("Brands Node.js JS"), IconID("fab-node-js"), IconUnicodeGlyph(0xf3d3)]
        BrandsNodeJs = 1277,
        ///<summary>Solid Not Equal</summary>
        ///<see href="https://fontawesome.com/icons/not-equal?style=solid"/>
        [Description("Solid Not Equal"), IconID("fas-not-equal"), IconUnicodeGlyph(0xf53e)]
        SolidNotEqual = 1278,
        ///<summary>Solid Notdef</summary>
        ///<see href="https://fontawesome.com/icons/notdef?style=solid"/>
        [Description("Solid Notdef"), IconID("fas-notdef"), IconUnicodeGlyph(0xe1fe)]
        SolidNotdef = 1279,
        ///<summary>Solid Note Sticky</summary>
        ///<see href="https://fontawesome.com/icons/note-sticky?style=solid"/>
        [Description("Solid Note Sticky"), IconID("fas-note-sticky"), IconUnicodeGlyph(0xf249)]
        SolidNoteSticky = 1280,
        ///<summary>Regular Note Sticky</summary>
        ///<see href="https://fontawesome.com/icons/note-sticky?style=regular"/>
        [Description("Regular Note Sticky"), IconID("far-note-sticky"), IconUnicodeGlyph(0xf249)]
        RegularNoteSticky = 1281,
        ///<summary>Solid Notes Medical</summary>
        ///<see href="https://fontawesome.com/icons/notes-medical?style=solid"/>
        [Description("Solid Notes Medical"), IconID("fas-notes-medical"), IconUnicodeGlyph(0xf481)]
        SolidNotesMedical = 1282,
        ///<summary>Brands npm</summary>
        ///<see href="https://fontawesome.com/icons/npm?style=brands"/>
        [Description("Brands npm"), IconID("fab-npm"), IconUnicodeGlyph(0xf3d4)]
        BrandsNpm = 1283,
        ///<summary>Brands NS8</summary>
        ///<see href="https://fontawesome.com/icons/ns8?style=brands"/>
        [Description("Brands NS8"), IconID("fab-ns8"), IconUnicodeGlyph(0xf3d5)]
        BrandsNs8 = 1284,
        ///<summary>Brands Nutritionix</summary>
        ///<see href="https://fontawesome.com/icons/nutritionix?style=brands"/>
        [Description("Brands Nutritionix"), IconID("fab-nutritionix"), IconUnicodeGlyph(0xf3d6)]
        BrandsNutritionix = 1285,
        ///<summary>Solid O</summary>
        ///<see href="https://fontawesome.com/icons/o?style=solid"/>
        [Description("Solid O"), IconID("fas-o"), IconUnicodeGlyph(0x4f)]
        SolidO = 1286,
        ///<summary>Solid Object Group</summary>
        ///<see href="https://fontawesome.com/icons/object-group?style=solid"/>
        [Description("Solid Object Group"), IconID("fas-object-group"), IconUnicodeGlyph(0xf247)]
        SolidObjectGroup = 1287,
        ///<summary>Regular Object Group</summary>
        ///<see href="https://fontawesome.com/icons/object-group?style=regular"/>
        [Description("Regular Object Group"), IconID("far-object-group"), IconUnicodeGlyph(0xf247)]
        RegularObjectGroup = 1288,
        ///<summary>Solid Object Ungroup</summary>
        ///<see href="https://fontawesome.com/icons/object-ungroup?style=solid"/>
        [Description("Solid Object Ungroup"), IconID("fas-object-ungroup"), IconUnicodeGlyph(0xf248)]
        SolidObjectUngroup = 1289,
        ///<summary>Regular Object Ungroup</summary>
        ///<see href="https://fontawesome.com/icons/object-ungroup?style=regular"/>
        [Description("Regular Object Ungroup"), IconID("far-object-ungroup"), IconUnicodeGlyph(0xf248)]
        RegularObjectUngroup = 1290,
        ///<summary>Brands Octopus Deploy</summary>
        ///<see href="https://fontawesome.com/icons/octopus-deploy?style=brands"/>
        [Description("Brands Octopus Deploy"), IconID("fab-octopus-deploy"), IconUnicodeGlyph(0xe082)]
        BrandsOctopusDeploy = 1291,
        ///<summary>Brands Odnoklassniki</summary>
        ///<see href="https://fontawesome.com/icons/odnoklassniki?style=brands"/>
        [Description("Brands Odnoklassniki"), IconID("fab-odnoklassniki"), IconUnicodeGlyph(0xf263)]
        BrandsOdnoklassniki = 1292,
        ///<summary>Brands Odysee</summary>
        ///<see href="https://fontawesome.com/icons/odysee?style=brands"/>
        [Description("Brands Odysee"), IconID("fab-odysee"), IconUnicodeGlyph(0xe5c6)]
        BrandsOdysee = 1293,
        ///<summary>Solid Oil Can</summary>
        ///<see href="https://fontawesome.com/icons/oil-can?style=solid"/>
        [Description("Solid Oil Can"), IconID("fas-oil-can"), IconUnicodeGlyph(0xf613)]
        SolidOilCan = 1294,
        ///<summary>Solid Oil Well</summary>
        ///<see href="https://fontawesome.com/icons/oil-well?style=solid"/>
        [Description("Solid Oil Well"), IconID("fas-oil-well"), IconUnicodeGlyph(0xe532)]
        SolidOilWell = 1295,
        ///<summary>Brands Old Republic</summary>
        ///<see href="https://fontawesome.com/icons/old-republic?style=brands"/>
        [Description("Brands Old Republic"), IconID("fab-old-republic"), IconUnicodeGlyph(0xf510)]
        BrandsOldRepublic = 1296,
        ///<summary>Solid Om</summary>
        ///<see href="https://fontawesome.com/icons/om?style=solid"/>
        [Description("Solid Om"), IconID("fas-om"), IconUnicodeGlyph(0xf679)]
        SolidOm = 1297,
        ///<summary>Brands OpenCart</summary>
        ///<see href="https://fontawesome.com/icons/opencart?style=brands"/>
        [Description("Brands OpenCart"), IconID("fab-opencart"), IconUnicodeGlyph(0xf23d)]
        BrandsOpencart = 1298,
        ///<summary>Brands OpenID</summary>
        ///<see href="https://fontawesome.com/icons/openid?style=brands"/>
        [Description("Brands OpenID"), IconID("fab-openid"), IconUnicodeGlyph(0xf19b)]
        BrandsOpenid = 1299,
        ///<summary>Brands Opensuse</summary>
        ///<see href="https://fontawesome.com/icons/opensuse?style=brands"/>
        [Description("Brands Opensuse"), IconID("fab-opensuse"), IconUnicodeGlyph(0xe62b)]
        BrandsOpensuse = 1300,
        ///<summary>Brands Opera</summary>
        ///<see href="https://fontawesome.com/icons/opera?style=brands"/>
        [Description("Brands Opera"), IconID("fab-opera"), IconUnicodeGlyph(0xf26a)]
        BrandsOpera = 1301,
        ///<summary>Brands Optin Monster</summary>
        ///<see href="https://fontawesome.com/icons/optin-monster?style=brands"/>
        [Description("Brands Optin Monster"), IconID("fab-optin-monster"), IconUnicodeGlyph(0xf23c)]
        BrandsOptinMonster = 1302,
        ///<summary>Brands ORCID</summary>
        ///<see href="https://fontawesome.com/icons/orcid?style=brands"/>
        [Description("Brands ORCID"), IconID("fab-orcid"), IconUnicodeGlyph(0xf8d2)]
        BrandsOrcid = 1303,
        ///<summary>Brands Open Source Initiative</summary>
        ///<see href="https://fontawesome.com/icons/osi?style=brands"/>
        [Description("Brands Open Source Initiative"), IconID("fab-osi"), IconUnicodeGlyph(0xf41a)]
        BrandsOsi = 1304,
        ///<summary>Solid Otter</summary>
        ///<see href="https://fontawesome.com/icons/otter?style=solid"/>
        [Description("Solid Otter"), IconID("fas-otter"), IconUnicodeGlyph(0xf700)]
        SolidOtter = 1305,
        ///<summary>Solid Outdent</summary>
        ///<see href="https://fontawesome.com/icons/outdent?style=solid"/>
        [Description("Solid Outdent"), IconID("fas-outdent"), IconUnicodeGlyph(0xf03b)]
        SolidOutdent = 1306,
        ///<summary>Solid P</summary>
        ///<see href="https://fontawesome.com/icons/p?style=solid"/>
        [Description("Solid P"), IconID("fas-p"), IconUnicodeGlyph(0x50)]
        SolidP = 1307,
        ///<summary>Brands Padlet</summary>
        ///<see href="https://fontawesome.com/icons/padlet?style=brands"/>
        [Description("Brands Padlet"), IconID("fab-padlet"), IconUnicodeGlyph(0xe4a0)]
        BrandsPadlet = 1308,
        ///<summary>Brands page4 Corporation</summary>
        ///<see href="https://fontawesome.com/icons/page4?style=brands"/>
        [Description("Brands page4 Corporation"), IconID("fab-page4"), IconUnicodeGlyph(0xf3d7)]
        BrandsPage4 = 1309,
        ///<summary>Brands Pagelines</summary>
        ///<see href="https://fontawesome.com/icons/pagelines?style=brands"/>
        [Description("Brands Pagelines"), IconID("fab-pagelines"), IconUnicodeGlyph(0xf18c)]
        BrandsPagelines = 1310,
        ///<summary>Solid Pager</summary>
        ///<see href="https://fontawesome.com/icons/pager?style=solid"/>
        [Description("Solid Pager"), IconID("fas-pager"), IconUnicodeGlyph(0xf815)]
        SolidPager = 1311,
        ///<summary>Solid Paint Roller</summary>
        ///<see href="https://fontawesome.com/icons/paint-roller?style=solid"/>
        [Description("Solid Paint Roller"), IconID("fas-paint-roller"), IconUnicodeGlyph(0xf5aa)]
        SolidPaintRoller = 1312,
        ///<summary>Solid Paintbrush</summary>
        ///<see href="https://fontawesome.com/icons/paintbrush?style=solid"/>
        [Description("Solid Paintbrush"), IconID("fas-paintbrush"), IconUnicodeGlyph(0xf1fc)]
        SolidPaintbrush = 1313,
        ///<summary>Solid Palette</summary>
        ///<see href="https://fontawesome.com/icons/palette?style=solid"/>
        [Description("Solid Palette"), IconID("fas-palette"), IconUnicodeGlyph(0xf53f)]
        SolidPalette = 1314,
        ///<summary>Brands Palfed</summary>
        ///<see href="https://fontawesome.com/icons/palfed?style=brands"/>
        [Description("Brands Palfed"), IconID("fab-palfed"), IconUnicodeGlyph(0xf3d8)]
        BrandsPalfed = 1315,
        ///<summary>Solid Pallet</summary>
        ///<see href="https://fontawesome.com/icons/pallet?style=solid"/>
        [Description("Solid Pallet"), IconID("fas-pallet"), IconUnicodeGlyph(0xf482)]
        SolidPallet = 1316,
        ///<summary>Solid Panorama</summary>
        ///<see href="https://fontawesome.com/icons/panorama?style=solid"/>
        [Description("Solid Panorama"), IconID("fas-panorama"), IconUnicodeGlyph(0xe209)]
        SolidPanorama = 1317,
        ///<summary>Solid Paper Plane</summary>
        ///<see href="https://fontawesome.com/icons/paper-plane?style=solid"/>
        [Description("Solid Paper Plane"), IconID("fas-paper-plane"), IconUnicodeGlyph(0xf1d8)]
        SolidPaperPlane = 1318,
        ///<summary>Regular Paper Plane</summary>
        ///<see href="https://fontawesome.com/icons/paper-plane?style=regular"/>
        [Description("Regular Paper Plane"), IconID("far-paper-plane"), IconUnicodeGlyph(0xf1d8)]
        RegularPaperPlane = 1319,
        ///<summary>Solid Paperclip</summary>
        ///<see href="https://fontawesome.com/icons/paperclip?style=solid"/>
        [Description("Solid Paperclip"), IconID("fas-paperclip"), IconUnicodeGlyph(0xf0c6)]
        SolidPaperclip = 1320,
        ///<summary>Solid Parachute Box</summary>
        ///<see href="https://fontawesome.com/icons/parachute-box?style=solid"/>
        [Description("Solid Parachute Box"), IconID("fas-parachute-box"), IconUnicodeGlyph(0xf4cd)]
        SolidParachuteBox = 1321,
        ///<summary>Solid Paragraph</summary>
        ///<see href="https://fontawesome.com/icons/paragraph?style=solid"/>
        [Description("Solid Paragraph"), IconID("fas-paragraph"), IconUnicodeGlyph(0xf1dd)]
        SolidParagraph = 1322,
        ///<summary>Solid Passport</summary>
        ///<see href="https://fontawesome.com/icons/passport?style=solid"/>
        [Description("Solid Passport"), IconID("fas-passport"), IconUnicodeGlyph(0xf5ab)]
        SolidPassport = 1323,
        ///<summary>Solid Paste</summary>
        ///<see href="https://fontawesome.com/icons/paste?style=solid"/>
        [Description("Solid Paste"), IconID("fas-paste"), IconUnicodeGlyph(0xf0ea)]
        SolidPaste = 1324,
        ///<summary>Regular Paste</summary>
        ///<see href="https://fontawesome.com/icons/paste?style=regular"/>
        [Description("Regular Paste"), IconID("far-paste"), IconUnicodeGlyph(0xf0ea)]
        RegularPaste = 1325,
        ///<summary>Brands Patreon</summary>
        ///<see href="https://fontawesome.com/icons/patreon?style=brands"/>
        [Description("Brands Patreon"), IconID("fab-patreon"), IconUnicodeGlyph(0xf3d9)]
        BrandsPatreon = 1326,
        ///<summary>Solid Pause</summary>
        ///<see href="https://fontawesome.com/icons/pause?style=solid"/>
        [Description("Solid Pause"), IconID("fas-pause"), IconUnicodeGlyph(0xf04c)]
        SolidPause = 1327,
        ///<summary>Solid Paw</summary>
        ///<see href="https://fontawesome.com/icons/paw?style=solid"/>
        [Description("Solid Paw"), IconID("fas-paw"), IconUnicodeGlyph(0xf1b0)]
        SolidPaw = 1328,
        ///<summary>Brands Paypal</summary>
        ///<see href="https://fontawesome.com/icons/paypal?style=brands"/>
        [Description("Brands Paypal"), IconID("fab-paypal"), IconUnicodeGlyph(0xf1ed)]
        BrandsPaypal = 1329,
        ///<summary>Solid Peace</summary>
        ///<see href="https://fontawesome.com/icons/peace?style=solid"/>
        [Description("Solid Peace"), IconID("fas-peace"), IconUnicodeGlyph(0xf67c)]
        SolidPeace = 1330,
        ///<summary>Solid Pen</summary>
        ///<see href="https://fontawesome.com/icons/pen?style=solid"/>
        [Description("Solid Pen"), IconID("fas-pen"), IconUnicodeGlyph(0xf304)]
        SolidPen = 1331,
        ///<summary>Solid Pen Clip</summary>
        ///<see href="https://fontawesome.com/icons/pen-clip?style=solid"/>
        [Description("Solid Pen Clip"), IconID("fas-pen-clip"), IconUnicodeGlyph(0xf305)]
        SolidPenClip = 1332,
        ///<summary>Solid Pen Fancy</summary>
        ///<see href="https://fontawesome.com/icons/pen-fancy?style=solid"/>
        [Description("Solid Pen Fancy"), IconID("fas-pen-fancy"), IconUnicodeGlyph(0xf5ac)]
        SolidPenFancy = 1333,
        ///<summary>Solid Pen Nib</summary>
        ///<see href="https://fontawesome.com/icons/pen-nib?style=solid"/>
        [Description("Solid Pen Nib"), IconID("fas-pen-nib"), IconUnicodeGlyph(0xf5ad)]
        SolidPenNib = 1334,
        ///<summary>Solid Pen Ruler</summary>
        ///<see href="https://fontawesome.com/icons/pen-ruler?style=solid"/>
        [Description("Solid Pen Ruler"), IconID("fas-pen-ruler"), IconUnicodeGlyph(0xf5ae)]
        SolidPenRuler = 1335,
        ///<summary>Solid Pen To Square</summary>
        ///<see href="https://fontawesome.com/icons/pen-to-square?style=solid"/>
        [Description("Solid Pen To Square"), IconID("fas-pen-to-square"), IconUnicodeGlyph(0xf044)]
        SolidPenToSquare = 1336,
        ///<summary>Regular Pen To Square</summary>
        ///<see href="https://fontawesome.com/icons/pen-to-square?style=regular"/>
        [Description("Regular Pen To Square"), IconID("far-pen-to-square"), IconUnicodeGlyph(0xf044)]
        RegularPenToSquare = 1337,
        ///<summary>Solid Pencil</summary>
        ///<see href="https://fontawesome.com/icons/pencil?style=solid"/>
        [Description("Solid Pencil"), IconID("fas-pencil"), IconUnicodeGlyph(0xf303)]
        SolidPencil = 1338,
        ///<summary>Solid People Arrows</summary>
        ///<see href="https://fontawesome.com/icons/people-arrows?style=solid"/>
        [Description("Solid People Arrows"), IconID("fas-people-arrows"), IconUnicodeGlyph(0xe068)]
        SolidPeopleArrows = 1339,
        ///<summary>Solid People Carry Box</summary>
        ///<see href="https://fontawesome.com/icons/people-carry-box?style=solid"/>
        [Description("Solid People Carry Box"), IconID("fas-people-carry-box"), IconUnicodeGlyph(0xf4ce)]
        SolidPeopleCarryBox = 1340,
        ///<summary>Solid People Group</summary>
        ///<see href="https://fontawesome.com/icons/people-group?style=solid"/>
        [Description("Solid People Group"), IconID("fas-people-group"), IconUnicodeGlyph(0xe533)]
        SolidPeopleGroup = 1341,
        ///<summary>Solid People Line</summary>
        ///<see href="https://fontawesome.com/icons/people-line?style=solid"/>
        [Description("Solid People Line"), IconID("fas-people-line"), IconUnicodeGlyph(0xe534)]
        SolidPeopleLine = 1342,
        ///<summary>Solid People Pulling</summary>
        ///<see href="https://fontawesome.com/icons/people-pulling?style=solid"/>
        [Description("Solid People Pulling"), IconID("fas-people-pulling"), IconUnicodeGlyph(0xe535)]
        SolidPeoplePulling = 1343,
        ///<summary>Solid People Robbery</summary>
        ///<see href="https://fontawesome.com/icons/people-robbery?style=solid"/>
        [Description("Solid People Robbery"), IconID("fas-people-robbery"), IconUnicodeGlyph(0xe536)]
        SolidPeopleRobbery = 1344,
        ///<summary>Solid People Roof</summary>
        ///<see href="https://fontawesome.com/icons/people-roof?style=solid"/>
        [Description("Solid People Roof"), IconID("fas-people-roof"), IconUnicodeGlyph(0xe537)]
        SolidPeopleRoof = 1345,
        ///<summary>Solid Pepper Hot</summary>
        ///<see href="https://fontawesome.com/icons/pepper-hot?style=solid"/>
        [Description("Solid Pepper Hot"), IconID("fas-pepper-hot"), IconUnicodeGlyph(0xf816)]
        SolidPepperHot = 1346,
        ///<summary>Brands PerByte</summary>
        ///<see href="https://fontawesome.com/icons/perbyte?style=brands"/>
        [Description("Brands PerByte"), IconID("fab-perbyte"), IconUnicodeGlyph(0xe083)]
        BrandsPerbyte = 1347,
        ///<summary>Solid Percent</summary>
        ///<see href="https://fontawesome.com/icons/percent?style=solid"/>
        [Description("Solid Percent"), IconID("fas-percent"), IconUnicodeGlyph(0x25)]
        SolidPercent = 1348,
        ///<summary>Brands Periscope</summary>
        ///<see href="https://fontawesome.com/icons/periscope?style=brands"/>
        [Description("Brands Periscope"), IconID("fab-periscope"), IconUnicodeGlyph(0xf3da)]
        BrandsPeriscope = 1349,
        ///<summary>Solid Person</summary>
        ///<see href="https://fontawesome.com/icons/person?style=solid"/>
        [Description("Solid Person"), IconID("fas-person"), IconUnicodeGlyph(0xf183)]
        SolidPerson = 1350,
        ///<summary>Solid Person Arrow Down To Line</summary>
        ///<see href="https://fontawesome.com/icons/person-arrow-down-to-line?style=solid"/>
        [Description("Solid Person Arrow Down To Line"), IconID("fas-person-arrow-down-to-line"), IconUnicodeGlyph(0xe538)]
        SolidPersonArrowDownToLine = 1351,
        ///<summary>Solid Person Arrow Up From Line</summary>
        ///<see href="https://fontawesome.com/icons/person-arrow-up-from-line?style=solid"/>
        [Description("Solid Person Arrow Up From Line"), IconID("fas-person-arrow-up-from-line"), IconUnicodeGlyph(0xe539)]
        SolidPersonArrowUpFromLine = 1352,
        ///<summary>Solid Person Biking</summary>
        ///<see href="https://fontawesome.com/icons/person-biking?style=solid"/>
        [Description("Solid Person Biking"), IconID("fas-person-biking"), IconUnicodeGlyph(0xf84a)]
        SolidPersonBiking = 1353,
        ///<summary>Solid Person Booth</summary>
        ///<see href="https://fontawesome.com/icons/person-booth?style=solid"/>
        [Description("Solid Person Booth"), IconID("fas-person-booth"), IconUnicodeGlyph(0xf756)]
        SolidPersonBooth = 1354,
        ///<summary>Solid Person Breastfeeding</summary>
        ///<see href="https://fontawesome.com/icons/person-breastfeeding?style=solid"/>
        [Description("Solid Person Breastfeeding"), IconID("fas-person-breastfeeding"), IconUnicodeGlyph(0xe53a)]
        SolidPersonBreastfeeding = 1355,
        ///<summary>Solid Person Burst</summary>
        ///<see href="https://fontawesome.com/icons/person-burst?style=solid"/>
        [Description("Solid Person Burst"), IconID("fas-person-burst"), IconUnicodeGlyph(0xe53b)]
        SolidPersonBurst = 1356,
        ///<summary>Solid Person Cane</summary>
        ///<see href="https://fontawesome.com/icons/person-cane?style=solid"/>
        [Description("Solid Person Cane"), IconID("fas-person-cane"), IconUnicodeGlyph(0xe53c)]
        SolidPersonCane = 1357,
        ///<summary>Solid Person Chalkboard</summary>
        ///<see href="https://fontawesome.com/icons/person-chalkboard?style=solid"/>
        [Description("Solid Person Chalkboard"), IconID("fas-person-chalkboard"), IconUnicodeGlyph(0xe53d)]
        SolidPersonChalkboard = 1358,
        ///<summary>Solid Person Circle Check</summary>
        ///<see href="https://fontawesome.com/icons/person-circle-check?style=solid"/>
        [Description("Solid Person Circle Check"), IconID("fas-person-circle-check"), IconUnicodeGlyph(0xe53e)]
        SolidPersonCircleCheck = 1359,
        ///<summary>Solid Person Circle Exclamation</summary>
        ///<see href="https://fontawesome.com/icons/person-circle-exclamation?style=solid"/>
        [Description("Solid Person Circle Exclamation"), IconID("fas-person-circle-exclamation"), IconUnicodeGlyph(0xe53f)]
        SolidPersonCircleExclamation = 1360,
        ///<summary>Solid Person Circle Minus</summary>
        ///<see href="https://fontawesome.com/icons/person-circle-minus?style=solid"/>
        [Description("Solid Person Circle Minus"), IconID("fas-person-circle-minus"), IconUnicodeGlyph(0xe540)]
        SolidPersonCircleMinus = 1361,
        ///<summary>Solid Person Circle Plus</summary>
        ///<see href="https://fontawesome.com/icons/person-circle-plus?style=solid"/>
        [Description("Solid Person Circle Plus"), IconID("fas-person-circle-plus"), IconUnicodeGlyph(0xe541)]
        SolidPersonCirclePlus = 1362,
        ///<summary>Solid Person Circle Question</summary>
        ///<see href="https://fontawesome.com/icons/person-circle-question?style=solid"/>
        [Description("Solid Person Circle Question"), IconID("fas-person-circle-question"), IconUnicodeGlyph(0xe542)]
        SolidPersonCircleQuestion = 1363,
        ///<summary>Solid Person Circle Xmark</summary>
        ///<see href="https://fontawesome.com/icons/person-circle-xmark?style=solid"/>
        [Description("Solid Person Circle Xmark"), IconID("fas-person-circle-xmark"), IconUnicodeGlyph(0xe543)]
        SolidPersonCircleXmark = 1364,
        ///<summary>Solid Person Digging</summary>
        ///<see href="https://fontawesome.com/icons/person-digging?style=solid"/>
        [Description("Solid Person Digging"), IconID("fas-person-digging"), IconUnicodeGlyph(0xf85e)]
        SolidPersonDigging = 1365,
        ///<summary>Solid Person Dots From Line</summary>
        ///<see href="https://fontawesome.com/icons/person-dots-from-line?style=solid"/>
        [Description("Solid Person Dots From Line"), IconID("fas-person-dots-from-line"), IconUnicodeGlyph(0xf470)]
        SolidPersonDotsFromLine = 1366,
        ///<summary>Solid Person Dress</summary>
        ///<see href="https://fontawesome.com/icons/person-dress?style=solid"/>
        [Description("Solid Person Dress"), IconID("fas-person-dress"), IconUnicodeGlyph(0xf182)]
        SolidPersonDress = 1367,
        ///<summary>Solid Person Dress Burst</summary>
        ///<see href="https://fontawesome.com/icons/person-dress-burst?style=solid"/>
        [Description("Solid Person Dress Burst"), IconID("fas-person-dress-burst"), IconUnicodeGlyph(0xe544)]
        SolidPersonDressBurst = 1368,
        ///<summary>Solid Person Drowning</summary>
        ///<see href="https://fontawesome.com/icons/person-drowning?style=solid"/>
        [Description("Solid Person Drowning"), IconID("fas-person-drowning"), IconUnicodeGlyph(0xe545)]
        SolidPersonDrowning = 1369,
        ///<summary>Solid Person Falling</summary>
        ///<see href="https://fontawesome.com/icons/person-falling?style=solid"/>
        [Description("Solid Person Falling"), IconID("fas-person-falling"), IconUnicodeGlyph(0xe546)]
        SolidPersonFalling = 1370,
        ///<summary>Solid Person Falling Burst</summary>
        ///<see href="https://fontawesome.com/icons/person-falling-burst?style=solid"/>
        [Description("Solid Person Falling Burst"), IconID("fas-person-falling-burst"), IconUnicodeGlyph(0xe547)]
        SolidPersonFallingBurst = 1371,
        ///<summary>Solid Person Half Dress</summary>
        ///<see href="https://fontawesome.com/icons/person-half-dress?style=solid"/>
        [Description("Solid Person Half Dress"), IconID("fas-person-half-dress"), IconUnicodeGlyph(0xe548)]
        SolidPersonHalfDress = 1372,
        ///<summary>Solid Person Harassing</summary>
        ///<see href="https://fontawesome.com/icons/person-harassing?style=solid"/>
        [Description("Solid Person Harassing"), IconID("fas-person-harassing"), IconUnicodeGlyph(0xe549)]
        SolidPersonHarassing = 1373,
        ///<summary>Solid Person Hiking</summary>
        ///<see href="https://fontawesome.com/icons/person-hiking?style=solid"/>
        [Description("Solid Person Hiking"), IconID("fas-person-hiking"), IconUnicodeGlyph(0xf6ec)]
        SolidPersonHiking = 1374,
        ///<summary>Solid Person Military Pointing</summary>
        ///<see href="https://fontawesome.com/icons/person-military-pointing?style=solid"/>
        [Description("Solid Person Military Pointing"), IconID("fas-person-military-pointing"), IconUnicodeGlyph(0xe54a)]
        SolidPersonMilitaryPointing = 1375,
        ///<summary>Solid Person Military Rifle</summary>
        ///<see href="https://fontawesome.com/icons/person-military-rifle?style=solid"/>
        [Description("Solid Person Military Rifle"), IconID("fas-person-military-rifle"), IconUnicodeGlyph(0xe54b)]
        SolidPersonMilitaryRifle = 1376,
        ///<summary>Solid Person Military To Person</summary>
        ///<see href="https://fontawesome.com/icons/person-military-to-person?style=solid"/>
        [Description("Solid Person Military To Person"), IconID("fas-person-military-to-person"), IconUnicodeGlyph(0xe54c)]
        SolidPersonMilitaryToPerson = 1377,
        ///<summary>Solid Person Praying</summary>
        ///<see href="https://fontawesome.com/icons/person-praying?style=solid"/>
        [Description("Solid Person Praying"), IconID("fas-person-praying"), IconUnicodeGlyph(0xf683)]
        SolidPersonPraying = 1378,
        ///<summary>Solid Person Pregnant</summary>
        ///<see href="https://fontawesome.com/icons/person-pregnant?style=solid"/>
        [Description("Solid Person Pregnant"), IconID("fas-person-pregnant"), IconUnicodeGlyph(0xe31e)]
        SolidPersonPregnant = 1379,
        ///<summary>Solid Person Rays</summary>
        ///<see href="https://fontawesome.com/icons/person-rays?style=solid"/>
        [Description("Solid Person Rays"), IconID("fas-person-rays"), IconUnicodeGlyph(0xe54d)]
        SolidPersonRays = 1380,
        ///<summary>Solid Person Rifle</summary>
        ///<see href="https://fontawesome.com/icons/person-rifle?style=solid"/>
        [Description("Solid Person Rifle"), IconID("fas-person-rifle"), IconUnicodeGlyph(0xe54e)]
        SolidPersonRifle = 1381,
        ///<summary>Solid Person Running</summary>
        ///<see href="https://fontawesome.com/icons/person-running?style=solid"/>
        [Description("Solid Person Running"), IconID("fas-person-running"), IconUnicodeGlyph(0xf70c)]
        SolidPersonRunning = 1382,
        ///<summary>Solid Person Shelter</summary>
        ///<see href="https://fontawesome.com/icons/person-shelter?style=solid"/>
        [Description("Solid Person Shelter"), IconID("fas-person-shelter"), IconUnicodeGlyph(0xe54f)]
        SolidPersonShelter = 1383,
        ///<summary>Solid Person Skating</summary>
        ///<see href="https://fontawesome.com/icons/person-skating?style=solid"/>
        [Description("Solid Person Skating"), IconID("fas-person-skating"), IconUnicodeGlyph(0xf7c5)]
        SolidPersonSkating = 1384,
        ///<summary>Solid Person Skiing</summary>
        ///<see href="https://fontawesome.com/icons/person-skiing?style=solid"/>
        [Description("Solid Person Skiing"), IconID("fas-person-skiing"), IconUnicodeGlyph(0xf7c9)]
        SolidPersonSkiing = 1385,
        ///<summary>Solid Person Skiing Nordic</summary>
        ///<see href="https://fontawesome.com/icons/person-skiing-nordic?style=solid"/>
        [Description("Solid Person Skiing Nordic"), IconID("fas-person-skiing-nordic"), IconUnicodeGlyph(0xf7ca)]
        SolidPersonSkiingNordic = 1386,
        ///<summary>Solid Person Snowboarding</summary>
        ///<see href="https://fontawesome.com/icons/person-snowboarding?style=solid"/>
        [Description("Solid Person Snowboarding"), IconID("fas-person-snowboarding"), IconUnicodeGlyph(0xf7ce)]
        SolidPersonSnowboarding = 1387,
        ///<summary>Solid Person Swimming</summary>
        ///<see href="https://fontawesome.com/icons/person-swimming?style=solid"/>
        [Description("Solid Person Swimming"), IconID("fas-person-swimming"), IconUnicodeGlyph(0xf5c4)]
        SolidPersonSwimming = 1388,
        ///<summary>Solid Person Through Window</summary>
        ///<see href="https://fontawesome.com/icons/person-through-window?style=solid"/>
        [Description("Solid Person Through Window"), IconID("fas-person-through-window"), IconUnicodeGlyph(0xe5a9)]
        SolidPersonThroughWindow = 1389,
        ///<summary>Solid Person Walking</summary>
        ///<see href="https://fontawesome.com/icons/person-walking?style=solid"/>
        [Description("Solid Person Walking"), IconID("fas-person-walking"), IconUnicodeGlyph(0xf554)]
        SolidPersonWalking = 1390,
        ///<summary>Solid Person Walking Arrow Loop Left</summary>
        ///<see href="https://fontawesome.com/icons/person-walking-arrow-loop-left?style=solid"/>
        [Description("Solid Person Walking Arrow Loop Left"), IconID("fas-person-walking-arrow-loop-left"), IconUnicodeGlyph(0xe551)]
        SolidPersonWalkingArrowLoopLeft = 1391,
        ///<summary>Solid Person Walking Arrow Right</summary>
        ///<see href="https://fontawesome.com/icons/person-walking-arrow-right?style=solid"/>
        [Description("Solid Person Walking Arrow Right"), IconID("fas-person-walking-arrow-right"), IconUnicodeGlyph(0xe552)]
        SolidPersonWalkingArrowRight = 1392,
        ///<summary>Solid Person Walking Dashed Line Arrow Right</summary>
        ///<see href="https://fontawesome.com/icons/person-walking-dashed-line-arrow-right?style=solid"/>
        [Description("Solid Person Walking Dashed Line Arrow Right"), IconID("fas-person-walking-dashed-line-arrow-right"), IconUnicodeGlyph(0xe553)]
        SolidPersonWalkingDashedLineArrowRight = 1393,
        ///<summary>Solid Person Walking Luggage</summary>
        ///<see href="https://fontawesome.com/icons/person-walking-luggage?style=solid"/>
        [Description("Solid Person Walking Luggage"), IconID("fas-person-walking-luggage"), IconUnicodeGlyph(0xe554)]
        SolidPersonWalkingLuggage = 1394,
        ///<summary>Solid Person Walking With Cane</summary>
        ///<see href="https://fontawesome.com/icons/person-walking-with-cane?style=solid"/>
        [Description("Solid Person Walking With Cane"), IconID("fas-person-walking-with-cane"), IconUnicodeGlyph(0xf29d)]
        SolidPersonWalkingWithCane = 1395,
        ///<summary>Solid Peseta Sign</summary>
        ///<see href="https://fontawesome.com/icons/peseta-sign?style=solid"/>
        [Description("Solid Peseta Sign"), IconID("fas-peseta-sign"), IconUnicodeGlyph(0xe221)]
        SolidPesetaSign = 1396,
        ///<summary>Solid Peso Sign</summary>
        ///<see href="https://fontawesome.com/icons/peso-sign?style=solid"/>
        [Description("Solid Peso Sign"), IconID("fas-peso-sign"), IconUnicodeGlyph(0xe222)]
        SolidPesoSign = 1397,
        ///<summary>Brands Phabricator</summary>
        ///<see href="https://fontawesome.com/icons/phabricator?style=brands"/>
        [Description("Brands Phabricator"), IconID("fab-phabricator"), IconUnicodeGlyph(0xf3db)]
        BrandsPhabricator = 1398,
        ///<summary>Brands Phoenix Framework</summary>
        ///<see href="https://fontawesome.com/icons/phoenix-framework?style=brands"/>
        [Description("Brands Phoenix Framework"), IconID("fab-phoenix-framework"), IconUnicodeGlyph(0xf3dc)]
        BrandsPhoenixFramework = 1399,
        ///<summary>Brands Phoenix Squadron</summary>
        ///<see href="https://fontawesome.com/icons/phoenix-squadron?style=brands"/>
        [Description("Brands Phoenix Squadron"), IconID("fab-phoenix-squadron"), IconUnicodeGlyph(0xf511)]
        BrandsPhoenixSquadron = 1400,
        ///<summary>Solid Phone</summary>
        ///<see href="https://fontawesome.com/icons/phone?style=solid"/>
        [Description("Solid Phone"), IconID("fas-phone"), IconUnicodeGlyph(0xf095)]
        SolidPhone = 1401,
        ///<summary>Solid Phone Flip</summary>
        ///<see href="https://fontawesome.com/icons/phone-flip?style=solid"/>
        [Description("Solid Phone Flip"), IconID("fas-phone-flip"), IconUnicodeGlyph(0xf879)]
        SolidPhoneFlip = 1402,
        ///<summary>Solid Phone Slash</summary>
        ///<see href="https://fontawesome.com/icons/phone-slash?style=solid"/>
        [Description("Solid Phone Slash"), IconID("fas-phone-slash"), IconUnicodeGlyph(0xf3dd)]
        SolidPhoneSlash = 1403,
        ///<summary>Solid Phone Volume</summary>
        ///<see href="https://fontawesome.com/icons/phone-volume?style=solid"/>
        [Description("Solid Phone Volume"), IconID("fas-phone-volume"), IconUnicodeGlyph(0xf2a0)]
        SolidPhoneVolume = 1404,
        ///<summary>Solid Photo Film</summary>
        ///<see href="https://fontawesome.com/icons/photo-film?style=solid"/>
        [Description("Solid Photo Film"), IconID("fas-photo-film"), IconUnicodeGlyph(0xf87c)]
        SolidPhotoFilm = 1405,
        ///<summary>Brands PHP</summary>
        ///<see href="https://fontawesome.com/icons/php?style=brands"/>
        [Description("Brands PHP"), IconID("fab-php"), IconUnicodeGlyph(0xf457)]
        BrandsPhp = 1406,
        ///<summary>Brands Pied Piper Logo</summary>
        ///<see href="https://fontawesome.com/icons/pied-piper?style=brands"/>
        [Description("Brands Pied Piper Logo"), IconID("fab-pied-piper"), IconUnicodeGlyph(0xf2ae)]
        BrandsPiedPiper = 1407,
        ///<summary>Brands Alternate Pied Piper Logo (Old)</summary>
        ///<see href="https://fontawesome.com/icons/pied-piper-alt?style=brands"/>
        [Description("Brands Alternate Pied Piper Logo (Old)"), IconID("fab-pied-piper-alt"), IconUnicodeGlyph(0xf1a8)]
        BrandsPiedPiperAlt = 1408,
        ///<summary>Brands Pied Piper Hat (Old)</summary>
        ///<see href="https://fontawesome.com/icons/pied-piper-hat?style=brands"/>
        [Description("Brands Pied Piper Hat (Old)"), IconID("fab-pied-piper-hat"), IconUnicodeGlyph(0xf4e5)]
        BrandsPiedPiperHat = 1409,
        ///<summary>Brands Pied Piper PP Logo (Old)</summary>
        ///<see href="https://fontawesome.com/icons/pied-piper-pp?style=brands"/>
        [Description("Brands Pied Piper PP Logo (Old)"), IconID("fab-pied-piper-pp"), IconUnicodeGlyph(0xf1a7)]
        BrandsPiedPiperPp = 1410,
        ///<summary>Solid Piggy Bank</summary>
        ///<see href="https://fontawesome.com/icons/piggy-bank?style=solid"/>
        [Description("Solid Piggy Bank"), IconID("fas-piggy-bank"), IconUnicodeGlyph(0xf4d3)]
        SolidPiggyBank = 1411,
        ///<summary>Solid Pills</summary>
        ///<see href="https://fontawesome.com/icons/pills?style=solid"/>
        [Description("Solid Pills"), IconID("fas-pills"), IconUnicodeGlyph(0xf484)]
        SolidPills = 1412,
        ///<summary>Brands Pinterest</summary>
        ///<see href="https://fontawesome.com/icons/pinterest?style=brands"/>
        [Description("Brands Pinterest"), IconID("fab-pinterest"), IconUnicodeGlyph(0xf0d2)]
        BrandsPinterest = 1413,
        ///<summary>Brands Pinterest P</summary>
        ///<see href="https://fontawesome.com/icons/pinterest-p?style=brands"/>
        [Description("Brands Pinterest P"), IconID("fab-pinterest-p"), IconUnicodeGlyph(0xf231)]
        BrandsPinterestP = 1414,
        ///<summary>Brands Pix</summary>
        ///<see href="https://fontawesome.com/icons/pix?style=brands"/>
        [Description("Brands Pix"), IconID("fab-pix"), IconUnicodeGlyph(0xe43a)]
        BrandsPix = 1415,
        ///<summary>Brands Pixiv</summary>
        ///<see href="https://fontawesome.com/icons/pixiv?style=brands"/>
        [Description("Brands Pixiv"), IconID("fab-pixiv"), IconUnicodeGlyph(0xe640)]
        BrandsPixiv = 1416,
        ///<summary>Solid Pizza Slice</summary>
        ///<see href="https://fontawesome.com/icons/pizza-slice?style=solid"/>
        [Description("Solid Pizza Slice"), IconID("fas-pizza-slice"), IconUnicodeGlyph(0xf818)]
        SolidPizzaSlice = 1417,
        ///<summary>Solid Place Of Worship</summary>
        ///<see href="https://fontawesome.com/icons/place-of-worship?style=solid"/>
        [Description("Solid Place Of Worship"), IconID("fas-place-of-worship"), IconUnicodeGlyph(0xf67f)]
        SolidPlaceOfWorship = 1418,
        ///<summary>Solid Plane</summary>
        ///<see href="https://fontawesome.com/icons/plane?style=solid"/>
        [Description("Solid Plane"), IconID("fas-plane"), IconUnicodeGlyph(0xf072)]
        SolidPlane = 1419,
        ///<summary>Solid Plane Arrival</summary>
        ///<see href="https://fontawesome.com/icons/plane-arrival?style=solid"/>
        [Description("Solid Plane Arrival"), IconID("fas-plane-arrival"), IconUnicodeGlyph(0xf5af)]
        SolidPlaneArrival = 1420,
        ///<summary>Solid Plane Circle Check</summary>
        ///<see href="https://fontawesome.com/icons/plane-circle-check?style=solid"/>
        [Description("Solid Plane Circle Check"), IconID("fas-plane-circle-check"), IconUnicodeGlyph(0xe555)]
        SolidPlaneCircleCheck = 1421,
        ///<summary>Solid Plane Circle Exclamation</summary>
        ///<see href="https://fontawesome.com/icons/plane-circle-exclamation?style=solid"/>
        [Description("Solid Plane Circle Exclamation"), IconID("fas-plane-circle-exclamation"), IconUnicodeGlyph(0xe556)]
        SolidPlaneCircleExclamation = 1422,
        ///<summary>Solid Plane Circle Xmark</summary>
        ///<see href="https://fontawesome.com/icons/plane-circle-xmark?style=solid"/>
        [Description("Solid Plane Circle Xmark"), IconID("fas-plane-circle-xmark"), IconUnicodeGlyph(0xe557)]
        SolidPlaneCircleXmark = 1423,
        ///<summary>Solid Plane Departure</summary>
        ///<see href="https://fontawesome.com/icons/plane-departure?style=solid"/>
        [Description("Solid Plane Departure"), IconID("fas-plane-departure"), IconUnicodeGlyph(0xf5b0)]
        SolidPlaneDeparture = 1424,
        ///<summary>Solid Plane Lock</summary>
        ///<see href="https://fontawesome.com/icons/plane-lock?style=solid"/>
        [Description("Solid Plane Lock"), IconID("fas-plane-lock"), IconUnicodeGlyph(0xe558)]
        SolidPlaneLock = 1425,
        ///<summary>Solid Plane Slash</summary>
        ///<see href="https://fontawesome.com/icons/plane-slash?style=solid"/>
        [Description("Solid Plane Slash"), IconID("fas-plane-slash"), IconUnicodeGlyph(0xe069)]
        SolidPlaneSlash = 1426,
        ///<summary>Solid Plane Up</summary>
        ///<see href="https://fontawesome.com/icons/plane-up?style=solid"/>
        [Description("Solid Plane Up"), IconID("fas-plane-up"), IconUnicodeGlyph(0xe22d)]
        SolidPlaneUp = 1427,
        ///<summary>Solid Plant Wilt</summary>
        ///<see href="https://fontawesome.com/icons/plant-wilt?style=solid"/>
        [Description("Solid Plant Wilt"), IconID("fas-plant-wilt"), IconUnicodeGlyph(0xe5aa)]
        SolidPlantWilt = 1428,
        ///<summary>Solid Plate Wheat</summary>
        ///<see href="https://fontawesome.com/icons/plate-wheat?style=solid"/>
        [Description("Solid Plate Wheat"), IconID("fas-plate-wheat"), IconUnicodeGlyph(0xe55a)]
        SolidPlateWheat = 1429,
        ///<summary>Solid Play</summary>
        ///<see href="https://fontawesome.com/icons/play?style=solid"/>
        [Description("Solid Play"), IconID("fas-play"), IconUnicodeGlyph(0xf04b)]
        SolidPlay = 1430,
        ///<summary>Brands PlayStation</summary>
        ///<see href="https://fontawesome.com/icons/playstation?style=brands"/>
        [Description("Brands PlayStation"), IconID("fab-playstation"), IconUnicodeGlyph(0xf3df)]
        BrandsPlaystation = 1431,
        ///<summary>Solid Plug</summary>
        ///<see href="https://fontawesome.com/icons/plug?style=solid"/>
        [Description("Solid Plug"), IconID("fas-plug"), IconUnicodeGlyph(0xf1e6)]
        SolidPlug = 1432,
        ///<summary>Solid Plug Circle Bolt</summary>
        ///<see href="https://fontawesome.com/icons/plug-circle-bolt?style=solid"/>
        [Description("Solid Plug Circle Bolt"), IconID("fas-plug-circle-bolt"), IconUnicodeGlyph(0xe55b)]
        SolidPlugCircleBolt = 1433,
        ///<summary>Solid Plug Circle Check</summary>
        ///<see href="https://fontawesome.com/icons/plug-circle-check?style=solid"/>
        [Description("Solid Plug Circle Check"), IconID("fas-plug-circle-check"), IconUnicodeGlyph(0xe55c)]
        SolidPlugCircleCheck = 1434,
        ///<summary>Solid Plug Circle Exclamation</summary>
        ///<see href="https://fontawesome.com/icons/plug-circle-exclamation?style=solid"/>
        [Description("Solid Plug Circle Exclamation"), IconID("fas-plug-circle-exclamation"), IconUnicodeGlyph(0xe55d)]
        SolidPlugCircleExclamation = 1435,
        ///<summary>Solid Plug Circle Minus</summary>
        ///<see href="https://fontawesome.com/icons/plug-circle-minus?style=solid"/>
        [Description("Solid Plug Circle Minus"), IconID("fas-plug-circle-minus"), IconUnicodeGlyph(0xe55e)]
        SolidPlugCircleMinus = 1436,
        ///<summary>Solid Plug Circle Plus</summary>
        ///<see href="https://fontawesome.com/icons/plug-circle-plus?style=solid"/>
        [Description("Solid Plug Circle Plus"), IconID("fas-plug-circle-plus"), IconUnicodeGlyph(0xe55f)]
        SolidPlugCirclePlus = 1437,
        ///<summary>Solid Plug Circle Xmark</summary>
        ///<see href="https://fontawesome.com/icons/plug-circle-xmark?style=solid"/>
        [Description("Solid Plug Circle Xmark"), IconID("fas-plug-circle-xmark"), IconUnicodeGlyph(0xe560)]
        SolidPlugCircleXmark = 1438,
        ///<summary>Solid Plus</summary>
        ///<see href="https://fontawesome.com/icons/plus?style=solid"/>
        [Description("Solid Plus"), IconID("fas-plus"), IconUnicodeGlyph(0x2b)]
        SolidPlus = 1439,
        ///<summary>Solid Plus Minus</summary>
        ///<see href="https://fontawesome.com/icons/plus-minus?style=solid"/>
        [Description("Solid Plus Minus"), IconID("fas-plus-minus"), IconUnicodeGlyph(0xe43c)]
        SolidPlusMinus = 1440,
        ///<summary>Solid Podcast</summary>
        ///<see href="https://fontawesome.com/icons/podcast?style=solid"/>
        [Description("Solid Podcast"), IconID("fas-podcast"), IconUnicodeGlyph(0xf2ce)]
        SolidPodcast = 1441,
        ///<summary>Solid Poo</summary>
        ///<see href="https://fontawesome.com/icons/poo?style=solid"/>
        [Description("Solid Poo"), IconID("fas-poo"), IconUnicodeGlyph(0xf2fe)]
        SolidPoo = 1442,
        ///<summary>Solid Poo Storm</summary>
        ///<see href="https://fontawesome.com/icons/poo-storm?style=solid"/>
        [Description("Solid Poo Storm"), IconID("fas-poo-storm"), IconUnicodeGlyph(0xf75a)]
        SolidPooStorm = 1443,
        ///<summary>Solid Poop</summary>
        ///<see href="https://fontawesome.com/icons/poop?style=solid"/>
        [Description("Solid Poop"), IconID("fas-poop"), IconUnicodeGlyph(0xf619)]
        SolidPoop = 1444,
        ///<summary>Solid Power Off</summary>
        ///<see href="https://fontawesome.com/icons/power-off?style=solid"/>
        [Description("Solid Power Off"), IconID("fas-power-off"), IconUnicodeGlyph(0xf011)]
        SolidPowerOff = 1445,
        ///<summary>Solid Prescription</summary>
        ///<see href="https://fontawesome.com/icons/prescription?style=solid"/>
        [Description("Solid Prescription"), IconID("fas-prescription"), IconUnicodeGlyph(0xf5b1)]
        SolidPrescription = 1446,
        ///<summary>Solid Prescription Bottle</summary>
        ///<see href="https://fontawesome.com/icons/prescription-bottle?style=solid"/>
        [Description("Solid Prescription Bottle"), IconID("fas-prescription-bottle"), IconUnicodeGlyph(0xf485)]
        SolidPrescriptionBottle = 1447,
        ///<summary>Solid Prescription Bottle Medical</summary>
        ///<see href="https://fontawesome.com/icons/prescription-bottle-medical?style=solid"/>
        [Description("Solid Prescription Bottle Medical"), IconID("fas-prescription-bottle-medical"), IconUnicodeGlyph(0xf486)]
        SolidPrescriptionBottleMedical = 1448,
        ///<summary>Solid Print</summary>
        ///<see href="https://fontawesome.com/icons/print?style=solid"/>
        [Description("Solid Print"), IconID("fas-print"), IconUnicodeGlyph(0xf02f)]
        SolidPrint = 1449,
        ///<summary>Brands Product Hunt</summary>
        ///<see href="https://fontawesome.com/icons/product-hunt?style=brands"/>
        [Description("Brands Product Hunt"), IconID("fab-product-hunt"), IconUnicodeGlyph(0xf288)]
        BrandsProductHunt = 1450,
        ///<summary>Solid Pump Medical</summary>
        ///<see href="https://fontawesome.com/icons/pump-medical?style=solid"/>
        [Description("Solid Pump Medical"), IconID("fas-pump-medical"), IconUnicodeGlyph(0xe06a)]
        SolidPumpMedical = 1451,
        ///<summary>Solid Pump Soap</summary>
        ///<see href="https://fontawesome.com/icons/pump-soap?style=solid"/>
        [Description("Solid Pump Soap"), IconID("fas-pump-soap"), IconUnicodeGlyph(0xe06b)]
        SolidPumpSoap = 1452,
        ///<summary>Brands Pushed</summary>
        ///<see href="https://fontawesome.com/icons/pushed?style=brands"/>
        [Description("Brands Pushed"), IconID("fab-pushed"), IconUnicodeGlyph(0xf3e1)]
        BrandsPushed = 1453,
        ///<summary>Solid Puzzle Piece</summary>
        ///<see href="https://fontawesome.com/icons/puzzle-piece?style=solid"/>
        [Description("Solid Puzzle Piece"), IconID("fas-puzzle-piece"), IconUnicodeGlyph(0xf12e)]
        SolidPuzzlePiece = 1454,
        ///<summary>Brands Python</summary>
        ///<see href="https://fontawesome.com/icons/python?style=brands"/>
        [Description("Brands Python"), IconID("fab-python"), IconUnicodeGlyph(0xf3e2)]
        BrandsPython = 1455,
        ///<summary>Solid Q</summary>
        ///<see href="https://fontawesome.com/icons/q?style=solid"/>
        [Description("Solid Q"), IconID("fas-q"), IconUnicodeGlyph(0x51)]
        SolidQ = 1456,
        ///<summary>Brands QQ</summary>
        ///<see href="https://fontawesome.com/icons/qq?style=brands"/>
        [Description("Brands QQ"), IconID("fab-qq"), IconUnicodeGlyph(0xf1d6)]
        BrandsQq = 1457,
        ///<summary>Solid Qrcode</summary>
        ///<see href="https://fontawesome.com/icons/qrcode?style=solid"/>
        [Description("Solid Qrcode"), IconID("fas-qrcode"), IconUnicodeGlyph(0xf029)]
        SolidQrcode = 1458,
        ///<summary>Solid Question</summary>
        ///<see href="https://fontawesome.com/icons/question?style=solid"/>
        [Description("Solid Question"), IconID("fas-question"), IconUnicodeGlyph(0x3f)]
        SolidQuestion = 1459,
        ///<summary>Brands QuinScape</summary>
        ///<see href="https://fontawesome.com/icons/quinscape?style=brands"/>
        [Description("Brands QuinScape"), IconID("fab-quinscape"), IconUnicodeGlyph(0xf459)]
        BrandsQuinscape = 1460,
        ///<summary>Brands Quora</summary>
        ///<see href="https://fontawesome.com/icons/quora?style=brands"/>
        [Description("Brands Quora"), IconID("fab-quora"), IconUnicodeGlyph(0xf2c4)]
        BrandsQuora = 1461,
        ///<summary>Solid Quote Left</summary>
        ///<see href="https://fontawesome.com/icons/quote-left?style=solid"/>
        [Description("Solid Quote Left"), IconID("fas-quote-left"), IconUnicodeGlyph(0xf10d)]
        SolidQuoteLeft = 1462,
        ///<summary>Solid Quote Right</summary>
        ///<see href="https://fontawesome.com/icons/quote-right?style=solid"/>
        [Description("Solid Quote Right"), IconID("fas-quote-right"), IconUnicodeGlyph(0xf10e)]
        SolidQuoteRight = 1463,
        ///<summary>Solid R</summary>
        ///<see href="https://fontawesome.com/icons/r?style=solid"/>
        [Description("Solid R"), IconID("fas-r"), IconUnicodeGlyph(0x52)]
        SolidR = 1464,
        ///<summary>Brands R Project</summary>
        ///<see href="https://fontawesome.com/icons/r-project?style=brands"/>
        [Description("Brands R Project"), IconID("fab-r-project"), IconUnicodeGlyph(0xf4f7)]
        BrandsRProject = 1465,
        ///<summary>Solid Radiation</summary>
        ///<see href="https://fontawesome.com/icons/radiation?style=solid"/>
        [Description("Solid Radiation"), IconID("fas-radiation"), IconUnicodeGlyph(0xf7b9)]
        SolidRadiation = 1466,
        ///<summary>Solid Radio</summary>
        ///<see href="https://fontawesome.com/icons/radio?style=solid"/>
        [Description("Solid Radio"), IconID("fas-radio"), IconUnicodeGlyph(0xf8d7)]
        SolidRadio = 1467,
        ///<summary>Solid Rainbow</summary>
        ///<see href="https://fontawesome.com/icons/rainbow?style=solid"/>
        [Description("Solid Rainbow"), IconID("fas-rainbow"), IconUnicodeGlyph(0xf75b)]
        SolidRainbow = 1468,
        ///<summary>Solid Ranking Star</summary>
        ///<see href="https://fontawesome.com/icons/ranking-star?style=solid"/>
        [Description("Solid Ranking Star"), IconID("fas-ranking-star"), IconUnicodeGlyph(0xe561)]
        SolidRankingStar = 1469,
        ///<summary>Brands Raspberry Pi</summary>
        ///<see href="https://fontawesome.com/icons/raspberry-pi?style=brands"/>
        [Description("Brands Raspberry Pi"), IconID("fab-raspberry-pi"), IconUnicodeGlyph(0xf7bb)]
        BrandsRaspberryPi = 1470,
        ///<summary>Brands Ravelry</summary>
        ///<see href="https://fontawesome.com/icons/ravelry?style=brands"/>
        [Description("Brands Ravelry"), IconID("fab-ravelry"), IconUnicodeGlyph(0xf2d9)]
        BrandsRavelry = 1471,
        ///<summary>Brands React</summary>
        ///<see href="https://fontawesome.com/icons/react?style=brands"/>
        [Description("Brands React"), IconID("fab-react"), IconUnicodeGlyph(0xf41b)]
        BrandsReact = 1472,
        ///<summary>Brands ReactEurope</summary>
        ///<see href="https://fontawesome.com/icons/reacteurope?style=brands"/>
        [Description("Brands ReactEurope"), IconID("fab-reacteurope"), IconUnicodeGlyph(0xf75d)]
        BrandsReacteurope = 1473,
        ///<summary>Brands ReadMe</summary>
        ///<see href="https://fontawesome.com/icons/readme?style=brands"/>
        [Description("Brands ReadMe"), IconID("fab-readme"), IconUnicodeGlyph(0xf4d5)]
        BrandsReadme = 1474,
        ///<summary>Brands Rebel Alliance</summary>
        ///<see href="https://fontawesome.com/icons/rebel?style=brands"/>
        [Description("Brands Rebel Alliance"), IconID("fab-rebel"), IconUnicodeGlyph(0xf1d0)]
        BrandsRebel = 1475,
        ///<summary>Solid Receipt</summary>
        ///<see href="https://fontawesome.com/icons/receipt?style=solid"/>
        [Description("Solid Receipt"), IconID("fas-receipt"), IconUnicodeGlyph(0xf543)]
        SolidReceipt = 1476,
        ///<summary>Solid Record Vinyl</summary>
        ///<see href="https://fontawesome.com/icons/record-vinyl?style=solid"/>
        [Description("Solid Record Vinyl"), IconID("fas-record-vinyl"), IconUnicodeGlyph(0xf8d9)]
        SolidRecordVinyl = 1477,
        ///<summary>Solid Rectangle Ad</summary>
        ///<see href="https://fontawesome.com/icons/rectangle-ad?style=solid"/>
        [Description("Solid Rectangle Ad"), IconID("fas-rectangle-ad"), IconUnicodeGlyph(0xf641)]
        SolidRectangleAd = 1478,
        ///<summary>Solid Rectangle List</summary>
        ///<see href="https://fontawesome.com/icons/rectangle-list?style=solid"/>
        [Description("Solid Rectangle List"), IconID("fas-rectangle-list"), IconUnicodeGlyph(0xf022)]
        SolidRectangleList = 1479,
        ///<summary>Regular Rectangle List</summary>
        ///<see href="https://fontawesome.com/icons/rectangle-list?style=regular"/>
        [Description("Regular Rectangle List"), IconID("far-rectangle-list"), IconUnicodeGlyph(0xf022)]
        RegularRectangleList = 1480,
        ///<summary>Solid Rectangle Xmark</summary>
        ///<see href="https://fontawesome.com/icons/rectangle-xmark?style=solid"/>
        [Description("Solid Rectangle Xmark"), IconID("fas-rectangle-xmark"), IconUnicodeGlyph(0xf410)]
        SolidRectangleXmark = 1481,
        ///<summary>Regular Rectangle Xmark</summary>
        ///<see href="https://fontawesome.com/icons/rectangle-xmark?style=regular"/>
        [Description("Regular Rectangle Xmark"), IconID("far-rectangle-xmark"), IconUnicodeGlyph(0xf410)]
        RegularRectangleXmark = 1482,
        ///<summary>Solid Recycle</summary>
        ///<see href="https://fontawesome.com/icons/recycle?style=solid"/>
        [Description("Solid Recycle"), IconID("fas-recycle"), IconUnicodeGlyph(0xf1b8)]
        SolidRecycle = 1483,
        ///<summary>Brands red river</summary>
        ///<see href="https://fontawesome.com/icons/red-river?style=brands"/>
        [Description("Brands red river"), IconID("fab-red-river"), IconUnicodeGlyph(0xf3e3)]
        BrandsRedRiver = 1484,
        ///<summary>Brands Reddit</summary>
        ///<see href="https://fontawesome.com/icons/reddit?style=brands"/>
        [Description("Brands Reddit"), IconID("fab-reddit"), IconUnicodeGlyph(0xf1a1)]
        BrandsReddit = 1485,
        ///<summary>Brands Reddit Alien</summary>
        ///<see href="https://fontawesome.com/icons/reddit-alien?style=brands"/>
        [Description("Brands Reddit Alien"), IconID("fab-reddit-alien"), IconUnicodeGlyph(0xf281)]
        BrandsRedditAlien = 1486,
        ///<summary>Brands Redhat</summary>
        ///<see href="https://fontawesome.com/icons/redhat?style=brands"/>
        [Description("Brands Redhat"), IconID("fab-redhat"), IconUnicodeGlyph(0xf7bc)]
        BrandsRedhat = 1487,
        ///<summary>Solid Registered</summary>
        ///<see href="https://fontawesome.com/icons/registered?style=solid"/>
        [Description("Solid Registered"), IconID("fas-registered"), IconUnicodeGlyph(0xf25d)]
        SolidRegistered = 1488,
        ///<summary>Regular Registered</summary>
        ///<see href="https://fontawesome.com/icons/registered?style=regular"/>
        [Description("Regular Registered"), IconID("far-registered"), IconUnicodeGlyph(0xf25d)]
        RegularRegistered = 1489,
        ///<summary>Brands Renren</summary>
        ///<see href="https://fontawesome.com/icons/renren?style=brands"/>
        [Description("Brands Renren"), IconID("fab-renren"), IconUnicodeGlyph(0xf18b)]
        BrandsRenren = 1490,
        ///<summary>Solid Repeat</summary>
        ///<see href="https://fontawesome.com/icons/repeat?style=solid"/>
        [Description("Solid Repeat"), IconID("fas-repeat"), IconUnicodeGlyph(0xf363)]
        SolidRepeat = 1491,
        ///<summary>Solid Reply</summary>
        ///<see href="https://fontawesome.com/icons/reply?style=solid"/>
        [Description("Solid Reply"), IconID("fas-reply"), IconUnicodeGlyph(0xf3e5)]
        SolidReply = 1492,
        ///<summary>Solid Reply All</summary>
        ///<see href="https://fontawesome.com/icons/reply-all?style=solid"/>
        [Description("Solid Reply All"), IconID("fas-reply-all"), IconUnicodeGlyph(0xf122)]
        SolidReplyAll = 1493,
        ///<summary>Brands replyd</summary>
        ///<see href="https://fontawesome.com/icons/replyd?style=brands"/>
        [Description("Brands replyd"), IconID("fab-replyd"), IconUnicodeGlyph(0xf3e6)]
        BrandsReplyd = 1494,
        ///<summary>Solid Republican</summary>
        ///<see href="https://fontawesome.com/icons/republican?style=solid"/>
        [Description("Solid Republican"), IconID("fas-republican"), IconUnicodeGlyph(0xf75e)]
        SolidRepublican = 1495,
        ///<summary>Brands Researchgate</summary>
        ///<see href="https://fontawesome.com/icons/researchgate?style=brands"/>
        [Description("Brands Researchgate"), IconID("fab-researchgate"), IconUnicodeGlyph(0xf4f8)]
        BrandsResearchgate = 1496,
        ///<summary>Brands Resolving</summary>
        ///<see href="https://fontawesome.com/icons/resolving?style=brands"/>
        [Description("Brands Resolving"), IconID("fab-resolving"), IconUnicodeGlyph(0xf3e7)]
        BrandsResolving = 1497,
        ///<summary>Solid Restroom</summary>
        ///<see href="https://fontawesome.com/icons/restroom?style=solid"/>
        [Description("Solid Restroom"), IconID("fas-restroom"), IconUnicodeGlyph(0xf7bd)]
        SolidRestroom = 1498,
        ///<summary>Solid Retweet</summary>
        ///<see href="https://fontawesome.com/icons/retweet?style=solid"/>
        [Description("Solid Retweet"), IconID("fas-retweet"), IconUnicodeGlyph(0xf079)]
        SolidRetweet = 1499,
        ///<summary>Brands Rev.io</summary>
        ///<see href="https://fontawesome.com/icons/rev?style=brands"/>
        [Description("Brands Rev.io"), IconID("fab-rev"), IconUnicodeGlyph(0xf5b2)]
        BrandsRev = 1500,
        ///<summary>Solid Ribbon</summary>
        ///<see href="https://fontawesome.com/icons/ribbon?style=solid"/>
        [Description("Solid Ribbon"), IconID("fas-ribbon"), IconUnicodeGlyph(0xf4d6)]
        SolidRibbon = 1501,
        ///<summary>Solid Right From Bracket</summary>
        ///<see href="https://fontawesome.com/icons/right-from-bracket?style=solid"/>
        [Description("Solid Right From Bracket"), IconID("fas-right-from-bracket"), IconUnicodeGlyph(0xf2f5)]
        SolidRightFromBracket = 1502,
        ///<summary>Solid Right Left</summary>
        ///<see href="https://fontawesome.com/icons/right-left?style=solid"/>
        [Description("Solid Right Left"), IconID("fas-right-left"), IconUnicodeGlyph(0xf362)]
        SolidRightLeft = 1503,
        ///<summary>Solid Right Long</summary>
        ///<see href="https://fontawesome.com/icons/right-long?style=solid"/>
        [Description("Solid Right Long"), IconID("fas-right-long"), IconUnicodeGlyph(0xf30b)]
        SolidRightLong = 1504,
        ///<summary>Solid Right To Bracket</summary>
        ///<see href="https://fontawesome.com/icons/right-to-bracket?style=solid"/>
        [Description("Solid Right To Bracket"), IconID("fas-right-to-bracket"), IconUnicodeGlyph(0xf2f6)]
        SolidRightToBracket = 1505,
        ///<summary>Solid Ring</summary>
        ///<see href="https://fontawesome.com/icons/ring?style=solid"/>
        [Description("Solid Ring"), IconID("fas-ring"), IconUnicodeGlyph(0xf70b)]
        SolidRing = 1506,
        ///<summary>Solid Road</summary>
        ///<see href="https://fontawesome.com/icons/road?style=solid"/>
        [Description("Solid Road"), IconID("fas-road"), IconUnicodeGlyph(0xf018)]
        SolidRoad = 1507,
        ///<summary>Solid Road Barrier</summary>
        ///<see href="https://fontawesome.com/icons/road-barrier?style=solid"/>
        [Description("Solid Road Barrier"), IconID("fas-road-barrier"), IconUnicodeGlyph(0xe562)]
        SolidRoadBarrier = 1508,
        ///<summary>Solid Road Bridge</summary>
        ///<see href="https://fontawesome.com/icons/road-bridge?style=solid"/>
        [Description("Solid Road Bridge"), IconID("fas-road-bridge"), IconUnicodeGlyph(0xe563)]
        SolidRoadBridge = 1509,
        ///<summary>Solid Road Circle Check</summary>
        ///<see href="https://fontawesome.com/icons/road-circle-check?style=solid"/>
        [Description("Solid Road Circle Check"), IconID("fas-road-circle-check"), IconUnicodeGlyph(0xe564)]
        SolidRoadCircleCheck = 1510,
        ///<summary>Solid Road Circle Exclamation</summary>
        ///<see href="https://fontawesome.com/icons/road-circle-exclamation?style=solid"/>
        [Description("Solid Road Circle Exclamation"), IconID("fas-road-circle-exclamation"), IconUnicodeGlyph(0xe565)]
        SolidRoadCircleExclamation = 1511,
        ///<summary>Solid Road Circle Xmark</summary>
        ///<see href="https://fontawesome.com/icons/road-circle-xmark?style=solid"/>
        [Description("Solid Road Circle Xmark"), IconID("fas-road-circle-xmark"), IconUnicodeGlyph(0xe566)]
        SolidRoadCircleXmark = 1512,
        ///<summary>Solid Road Lock</summary>
        ///<see href="https://fontawesome.com/icons/road-lock?style=solid"/>
        [Description("Solid Road Lock"), IconID("fas-road-lock"), IconUnicodeGlyph(0xe567)]
        SolidRoadLock = 1513,
        ///<summary>Solid Road Spikes</summary>
        ///<see href="https://fontawesome.com/icons/road-spikes?style=solid"/>
        [Description("Solid Road Spikes"), IconID("fas-road-spikes"), IconUnicodeGlyph(0xe568)]
        SolidRoadSpikes = 1514,
        ///<summary>Solid Robot</summary>
        ///<see href="https://fontawesome.com/icons/robot?style=solid"/>
        [Description("Solid Robot"), IconID("fas-robot"), IconUnicodeGlyph(0xf544)]
        SolidRobot = 1515,
        ///<summary>Solid Rocket</summary>
        ///<see href="https://fontawesome.com/icons/rocket?style=solid"/>
        [Description("Solid Rocket"), IconID("fas-rocket"), IconUnicodeGlyph(0xf135)]
        SolidRocket = 1516,
        ///<summary>Brands Rocket.Chat</summary>
        ///<see href="https://fontawesome.com/icons/rocketchat?style=brands"/>
        [Description("Brands Rocket.Chat"), IconID("fab-rocketchat"), IconUnicodeGlyph(0xf3e8)]
        BrandsRocketchat = 1517,
        ///<summary>Brands Rockrms</summary>
        ///<see href="https://fontawesome.com/icons/rockrms?style=brands"/>
        [Description("Brands Rockrms"), IconID("fab-rockrms"), IconUnicodeGlyph(0xf3e9)]
        BrandsRockrms = 1518,
        ///<summary>Solid Rotate</summary>
        ///<see href="https://fontawesome.com/icons/rotate?style=solid"/>
        [Description("Solid Rotate"), IconID("fas-rotate"), IconUnicodeGlyph(0xf2f1)]
        SolidRotate = 1519,
        ///<summary>Solid Rotate Left</summary>
        ///<see href="https://fontawesome.com/icons/rotate-left?style=solid"/>
        [Description("Solid Rotate Left"), IconID("fas-rotate-left"), IconUnicodeGlyph(0xf2ea)]
        SolidRotateLeft = 1520,
        ///<summary>Solid Rotate Right</summary>
        ///<see href="https://fontawesome.com/icons/rotate-right?style=solid"/>
        [Description("Solid Rotate Right"), IconID("fas-rotate-right"), IconUnicodeGlyph(0xf2f9)]
        SolidRotateRight = 1521,
        ///<summary>Solid Route</summary>
        ///<see href="https://fontawesome.com/icons/route?style=solid"/>
        [Description("Solid Route"), IconID("fas-route"), IconUnicodeGlyph(0xf4d7)]
        SolidRoute = 1522,
        ///<summary>Solid Rss</summary>
        ///<see href="https://fontawesome.com/icons/rss?style=solid"/>
        [Description("Solid Rss"), IconID("fas-rss"), IconUnicodeGlyph(0xf09e)]
        SolidRss = 1523,
        ///<summary>Solid Ruble Sign</summary>
        ///<see href="https://fontawesome.com/icons/ruble-sign?style=solid"/>
        [Description("Solid Ruble Sign"), IconID("fas-ruble-sign"), IconUnicodeGlyph(0xf158)]
        SolidRubleSign = 1524,
        ///<summary>Solid Rug</summary>
        ///<see href="https://fontawesome.com/icons/rug?style=solid"/>
        [Description("Solid Rug"), IconID("fas-rug"), IconUnicodeGlyph(0xe569)]
        SolidRug = 1525,
        ///<summary>Solid Ruler</summary>
        ///<see href="https://fontawesome.com/icons/ruler?style=solid"/>
        [Description("Solid Ruler"), IconID("fas-ruler"), IconUnicodeGlyph(0xf545)]
        SolidRuler = 1526,
        ///<summary>Solid Ruler Combined</summary>
        ///<see href="https://fontawesome.com/icons/ruler-combined?style=solid"/>
        [Description("Solid Ruler Combined"), IconID("fas-ruler-combined"), IconUnicodeGlyph(0xf546)]
        SolidRulerCombined = 1527,
        ///<summary>Solid Ruler Horizontal</summary>
        ///<see href="https://fontawesome.com/icons/ruler-horizontal?style=solid"/>
        [Description("Solid Ruler Horizontal"), IconID("fas-ruler-horizontal"), IconUnicodeGlyph(0xf547)]
        SolidRulerHorizontal = 1528,
        ///<summary>Solid Ruler Vertical</summary>
        ///<see href="https://fontawesome.com/icons/ruler-vertical?style=solid"/>
        [Description("Solid Ruler Vertical"), IconID("fas-ruler-vertical"), IconUnicodeGlyph(0xf548)]
        SolidRulerVertical = 1529,
        ///<summary>Solid Rupee Sign</summary>
        ///<see href="https://fontawesome.com/icons/rupee-sign?style=solid"/>
        [Description("Solid Rupee Sign"), IconID("fas-rupee-sign"), IconUnicodeGlyph(0xf156)]
        SolidRupeeSign = 1530,
        ///<summary>Solid Rupiah Sign</summary>
        ///<see href="https://fontawesome.com/icons/rupiah-sign?style=solid"/>
        [Description("Solid Rupiah Sign"), IconID("fas-rupiah-sign"), IconUnicodeGlyph(0xe23d)]
        SolidRupiahSign = 1531,
        ///<summary>Brands Rust</summary>
        ///<see href="https://fontawesome.com/icons/rust?style=brands"/>
        [Description("Brands Rust"), IconID("fab-rust"), IconUnicodeGlyph(0xe07a)]
        BrandsRust = 1532,
        ///<summary>Solid S</summary>
        ///<see href="https://fontawesome.com/icons/s?style=solid"/>
        [Description("Solid S"), IconID("fas-s"), IconUnicodeGlyph(0x53)]
        SolidS = 1533,
        ///<summary>Solid Sack Dollar</summary>
        ///<see href="https://fontawesome.com/icons/sack-dollar?style=solid"/>
        [Description("Solid Sack Dollar"), IconID("fas-sack-dollar"), IconUnicodeGlyph(0xf81d)]
        SolidSackDollar = 1534,
        ///<summary>Solid Sack Xmark</summary>
        ///<see href="https://fontawesome.com/icons/sack-xmark?style=solid"/>
        [Description("Solid Sack Xmark"), IconID("fas-sack-xmark"), IconUnicodeGlyph(0xe56a)]
        SolidSackXmark = 1535,
        ///<summary>Brands Safari</summary>
        ///<see href="https://fontawesome.com/icons/safari?style=brands"/>
        [Description("Brands Safari"), IconID("fab-safari"), IconUnicodeGlyph(0xf267)]
        BrandsSafari = 1536,
        ///<summary>Solid Sailboat</summary>
        ///<see href="https://fontawesome.com/icons/sailboat?style=solid"/>
        [Description("Solid Sailboat"), IconID("fas-sailboat"), IconUnicodeGlyph(0xe445)]
        SolidSailboat = 1537,
        ///<summary>Brands Salesforce</summary>
        ///<see href="https://fontawesome.com/icons/salesforce?style=brands"/>
        [Description("Brands Salesforce"), IconID("fab-salesforce"), IconUnicodeGlyph(0xf83b)]
        BrandsSalesforce = 1538,
        ///<summary>Brands Sass</summary>
        ///<see href="https://fontawesome.com/icons/sass?style=brands"/>
        [Description("Brands Sass"), IconID("fab-sass"), IconUnicodeGlyph(0xf41e)]
        BrandsSass = 1539,
        ///<summary>Solid Satellite</summary>
        ///<see href="https://fontawesome.com/icons/satellite?style=solid"/>
        [Description("Solid Satellite"), IconID("fas-satellite"), IconUnicodeGlyph(0xf7bf)]
        SolidSatellite = 1540,
        ///<summary>Solid Satellite Dish</summary>
        ///<see href="https://fontawesome.com/icons/satellite-dish?style=solid"/>
        [Description("Solid Satellite Dish"), IconID("fas-satellite-dish"), IconUnicodeGlyph(0xf7c0)]
        SolidSatelliteDish = 1541,
        ///<summary>Solid Scale Balanced</summary>
        ///<see href="https://fontawesome.com/icons/scale-balanced?style=solid"/>
        [Description("Solid Scale Balanced"), IconID("fas-scale-balanced"), IconUnicodeGlyph(0xf24e)]
        SolidScaleBalanced = 1542,
        ///<summary>Solid Scale Unbalanced</summary>
        ///<see href="https://fontawesome.com/icons/scale-unbalanced?style=solid"/>
        [Description("Solid Scale Unbalanced"), IconID("fas-scale-unbalanced"), IconUnicodeGlyph(0xf515)]
        SolidScaleUnbalanced = 1543,
        ///<summary>Solid Scale Unbalanced Flip</summary>
        ///<see href="https://fontawesome.com/icons/scale-unbalanced-flip?style=solid"/>
        [Description("Solid Scale Unbalanced Flip"), IconID("fas-scale-unbalanced-flip"), IconUnicodeGlyph(0xf516)]
        SolidScaleUnbalancedFlip = 1544,
        ///<summary>Brands SCHLIX</summary>
        ///<see href="https://fontawesome.com/icons/schlix?style=brands"/>
        [Description("Brands SCHLIX"), IconID("fab-schlix"), IconUnicodeGlyph(0xf3ea)]
        BrandsSchlix = 1545,
        ///<summary>Solid School</summary>
        ///<see href="https://fontawesome.com/icons/school?style=solid"/>
        [Description("Solid School"), IconID("fas-school"), IconUnicodeGlyph(0xf549)]
        SolidSchool = 1546,
        ///<summary>Solid School Circle Check</summary>
        ///<see href="https://fontawesome.com/icons/school-circle-check?style=solid"/>
        [Description("Solid School Circle Check"), IconID("fas-school-circle-check"), IconUnicodeGlyph(0xe56b)]
        SolidSchoolCircleCheck = 1547,
        ///<summary>Solid School Circle Exclamation</summary>
        ///<see href="https://fontawesome.com/icons/school-circle-exclamation?style=solid"/>
        [Description("Solid School Circle Exclamation"), IconID("fas-school-circle-exclamation"), IconUnicodeGlyph(0xe56c)]
        SolidSchoolCircleExclamation = 1548,
        ///<summary>Solid School Circle Xmark</summary>
        ///<see href="https://fontawesome.com/icons/school-circle-xmark?style=solid"/>
        [Description("Solid School Circle Xmark"), IconID("fas-school-circle-xmark"), IconUnicodeGlyph(0xe56d)]
        SolidSchoolCircleXmark = 1549,
        ///<summary>Solid School Flag</summary>
        ///<see href="https://fontawesome.com/icons/school-flag?style=solid"/>
        [Description("Solid School Flag"), IconID("fas-school-flag"), IconUnicodeGlyph(0xe56e)]
        SolidSchoolFlag = 1550,
        ///<summary>Solid School Lock</summary>
        ///<see href="https://fontawesome.com/icons/school-lock?style=solid"/>
        [Description("Solid School Lock"), IconID("fas-school-lock"), IconUnicodeGlyph(0xe56f)]
        SolidSchoolLock = 1551,
        ///<summary>Solid Scissors</summary>
        ///<see href="https://fontawesome.com/icons/scissors?style=solid"/>
        [Description("Solid Scissors"), IconID("fas-scissors"), IconUnicodeGlyph(0xf0c4)]
        SolidScissors = 1552,
        ///<summary>Brands Screenpal</summary>
        ///<see href="https://fontawesome.com/icons/screenpal?style=brands"/>
        [Description("Brands Screenpal"), IconID("fab-screenpal"), IconUnicodeGlyph(0xe570)]
        BrandsScreenpal = 1553,
        ///<summary>Solid Screwdriver</summary>
        ///<see href="https://fontawesome.com/icons/screwdriver?style=solid"/>
        [Description("Solid Screwdriver"), IconID("fas-screwdriver"), IconUnicodeGlyph(0xf54a)]
        SolidScrewdriver = 1554,
        ///<summary>Solid Screwdriver Wrench</summary>
        ///<see href="https://fontawesome.com/icons/screwdriver-wrench?style=solid"/>
        [Description("Solid Screwdriver Wrench"), IconID("fas-screwdriver-wrench"), IconUnicodeGlyph(0xf7d9)]
        SolidScrewdriverWrench = 1555,
        ///<summary>Brands Scribd</summary>
        ///<see href="https://fontawesome.com/icons/scribd?style=brands"/>
        [Description("Brands Scribd"), IconID("fab-scribd"), IconUnicodeGlyph(0xf28a)]
        BrandsScribd = 1556,
        ///<summary>Solid Scroll</summary>
        ///<see href="https://fontawesome.com/icons/scroll?style=solid"/>
        [Description("Solid Scroll"), IconID("fas-scroll"), IconUnicodeGlyph(0xf70e)]
        SolidScroll = 1557,
        ///<summary>Solid Scroll Torah</summary>
        ///<see href="https://fontawesome.com/icons/scroll-torah?style=solid"/>
        [Description("Solid Scroll Torah"), IconID("fas-scroll-torah"), IconUnicodeGlyph(0xf6a0)]
        SolidScrollTorah = 1558,
        ///<summary>Solid Sd Card</summary>
        ///<see href="https://fontawesome.com/icons/sd-card?style=solid"/>
        [Description("Solid Sd Card"), IconID("fas-sd-card"), IconUnicodeGlyph(0xf7c2)]
        SolidSdCard = 1559,
        ///<summary>Brands Searchengin</summary>
        ///<see href="https://fontawesome.com/icons/searchengin?style=brands"/>
        [Description("Brands Searchengin"), IconID("fab-searchengin"), IconUnicodeGlyph(0xf3eb)]
        BrandsSearchengin = 1560,
        ///<summary>Solid Section</summary>
        ///<see href="https://fontawesome.com/icons/section?style=solid"/>
        [Description("Solid Section"), IconID("fas-section"), IconUnicodeGlyph(0xe447)]
        SolidSection = 1561,
        ///<summary>Solid Seedling</summary>
        ///<see href="https://fontawesome.com/icons/seedling?style=solid"/>
        [Description("Solid Seedling"), IconID("fas-seedling"), IconUnicodeGlyph(0xf4d8)]
        SolidSeedling = 1562,
        ///<summary>Brands Sellcast</summary>
        ///<see href="https://fontawesome.com/icons/sellcast?style=brands"/>
        [Description("Brands Sellcast"), IconID("fab-sellcast"), IconUnicodeGlyph(0xf2da)]
        BrandsSellcast = 1563,
        ///<summary>Brands Sellsy</summary>
        ///<see href="https://fontawesome.com/icons/sellsy?style=brands"/>
        [Description("Brands Sellsy"), IconID("fab-sellsy"), IconUnicodeGlyph(0xf213)]
        BrandsSellsy = 1564,
        ///<summary>Solid Server</summary>
        ///<see href="https://fontawesome.com/icons/server?style=solid"/>
        [Description("Solid Server"), IconID("fas-server"), IconUnicodeGlyph(0xf233)]
        SolidServer = 1565,
        ///<summary>Brands Servicestack</summary>
        ///<see href="https://fontawesome.com/icons/servicestack?style=brands"/>
        [Description("Brands Servicestack"), IconID("fab-servicestack"), IconUnicodeGlyph(0xf3ec)]
        BrandsServicestack = 1566,
        ///<summary>Solid Shapes</summary>
        ///<see href="https://fontawesome.com/icons/shapes?style=solid"/>
        [Description("Solid Shapes"), IconID("fas-shapes"), IconUnicodeGlyph(0xf61f)]
        SolidShapes = 1567,
        ///<summary>Solid Share</summary>
        ///<see href="https://fontawesome.com/icons/share?style=solid"/>
        [Description("Solid Share"), IconID("fas-share"), IconUnicodeGlyph(0xf064)]
        SolidShare = 1568,
        ///<summary>Solid Share From Square</summary>
        ///<see href="https://fontawesome.com/icons/share-from-square?style=solid"/>
        [Description("Solid Share From Square"), IconID("fas-share-from-square"), IconUnicodeGlyph(0xf14d)]
        SolidShareFromSquare = 1569,
        ///<summary>Regular Share From Square</summary>
        ///<see href="https://fontawesome.com/icons/share-from-square?style=regular"/>
        [Description("Regular Share From Square"), IconID("far-share-from-square"), IconUnicodeGlyph(0xf14d)]
        RegularShareFromSquare = 1570,
        ///<summary>Solid Share Nodes</summary>
        ///<see href="https://fontawesome.com/icons/share-nodes?style=solid"/>
        [Description("Solid Share Nodes"), IconID("fas-share-nodes"), IconUnicodeGlyph(0xf1e0)]
        SolidShareNodes = 1571,
        ///<summary>Solid Sheet Plastic</summary>
        ///<see href="https://fontawesome.com/icons/sheet-plastic?style=solid"/>
        [Description("Solid Sheet Plastic"), IconID("fas-sheet-plastic"), IconUnicodeGlyph(0xe571)]
        SolidSheetPlastic = 1572,
        ///<summary>Solid Shekel Sign</summary>
        ///<see href="https://fontawesome.com/icons/shekel-sign?style=solid"/>
        [Description("Solid Shekel Sign"), IconID("fas-shekel-sign"), IconUnicodeGlyph(0xf20b)]
        SolidShekelSign = 1573,
        ///<summary>Solid Shield</summary>
        ///<see href="https://fontawesome.com/icons/shield?style=solid"/>
        [Description("Solid Shield"), IconID("fas-shield"), IconUnicodeGlyph(0xf132)]
        SolidShield = 1574,
        ///<summary>Solid Shield Cat</summary>
        ///<see href="https://fontawesome.com/icons/shield-cat?style=solid"/>
        [Description("Solid Shield Cat"), IconID("fas-shield-cat"), IconUnicodeGlyph(0xe572)]
        SolidShieldCat = 1575,
        ///<summary>Solid Shield Dog</summary>
        ///<see href="https://fontawesome.com/icons/shield-dog?style=solid"/>
        [Description("Solid Shield Dog"), IconID("fas-shield-dog"), IconUnicodeGlyph(0xe573)]
        SolidShieldDog = 1576,
        ///<summary>Solid Shield Halved</summary>
        ///<see href="https://fontawesome.com/icons/shield-halved?style=solid"/>
        [Description("Solid Shield Halved"), IconID("fas-shield-halved"), IconUnicodeGlyph(0xf3ed)]
        SolidShieldHalved = 1577,
        ///<summary>Solid Shield Heart</summary>
        ///<see href="https://fontawesome.com/icons/shield-heart?style=solid"/>
        [Description("Solid Shield Heart"), IconID("fas-shield-heart"), IconUnicodeGlyph(0xe574)]
        SolidShieldHeart = 1578,
        ///<summary>Solid Shield Virus</summary>
        ///<see href="https://fontawesome.com/icons/shield-virus?style=solid"/>
        [Description("Solid Shield Virus"), IconID("fas-shield-virus"), IconUnicodeGlyph(0xe06c)]
        SolidShieldVirus = 1579,
        ///<summary>Solid Ship</summary>
        ///<see href="https://fontawesome.com/icons/ship?style=solid"/>
        [Description("Solid Ship"), IconID("fas-ship"), IconUnicodeGlyph(0xf21a)]
        SolidShip = 1580,
        ///<summary>Solid Shirt</summary>
        ///<see href="https://fontawesome.com/icons/shirt?style=solid"/>
        [Description("Solid Shirt"), IconID("fas-shirt"), IconUnicodeGlyph(0xf553)]
        SolidShirt = 1581,
        ///<summary>Brands Shirts in Bulk</summary>
        ///<see href="https://fontawesome.com/icons/shirtsinbulk?style=brands"/>
        [Description("Brands Shirts in Bulk"), IconID("fab-shirtsinbulk"), IconUnicodeGlyph(0xf214)]
        BrandsShirtsinbulk = 1582,
        ///<summary>Solid Shoe Prints</summary>
        ///<see href="https://fontawesome.com/icons/shoe-prints?style=solid"/>
        [Description("Solid Shoe Prints"), IconID("fas-shoe-prints"), IconUnicodeGlyph(0xf54b)]
        SolidShoePrints = 1583,
        ///<summary>Brands Shoelace</summary>
        ///<see href="https://fontawesome.com/icons/shoelace?style=brands"/>
        [Description("Brands Shoelace"), IconID("fab-shoelace"), IconUnicodeGlyph(0xe60c)]
        BrandsShoelace = 1584,
        ///<summary>Solid Shop</summary>
        ///<see href="https://fontawesome.com/icons/shop?style=solid"/>
        [Description("Solid Shop"), IconID("fas-shop"), IconUnicodeGlyph(0xf54f)]
        SolidShop = 1585,
        ///<summary>Solid Shop Lock</summary>
        ///<see href="https://fontawesome.com/icons/shop-lock?style=solid"/>
        [Description("Solid Shop Lock"), IconID("fas-shop-lock"), IconUnicodeGlyph(0xe4a5)]
        SolidShopLock = 1586,
        ///<summary>Solid Shop Slash</summary>
        ///<see href="https://fontawesome.com/icons/shop-slash?style=solid"/>
        [Description("Solid Shop Slash"), IconID("fas-shop-slash"), IconUnicodeGlyph(0xe070)]
        SolidShopSlash = 1587,
        ///<summary>Brands Shopify</summary>
        ///<see href="https://fontawesome.com/icons/shopify?style=brands"/>
        [Description("Brands Shopify"), IconID("fab-shopify"), IconUnicodeGlyph(0xe057)]
        BrandsShopify = 1588,
        ///<summary>Brands Shopware</summary>
        ///<see href="https://fontawesome.com/icons/shopware?style=brands"/>
        [Description("Brands Shopware"), IconID("fab-shopware"), IconUnicodeGlyph(0xf5b5)]
        BrandsShopware = 1589,
        ///<summary>Solid Shower</summary>
        ///<see href="https://fontawesome.com/icons/shower?style=solid"/>
        [Description("Solid Shower"), IconID("fas-shower"), IconUnicodeGlyph(0xf2cc)]
        SolidShower = 1590,
        ///<summary>Solid Shrimp</summary>
        ///<see href="https://fontawesome.com/icons/shrimp?style=solid"/>
        [Description("Solid Shrimp"), IconID("fas-shrimp"), IconUnicodeGlyph(0xe448)]
        SolidShrimp = 1591,
        ///<summary>Solid Shuffle</summary>
        ///<see href="https://fontawesome.com/icons/shuffle?style=solid"/>
        [Description("Solid Shuffle"), IconID("fas-shuffle"), IconUnicodeGlyph(0xf074)]
        SolidShuffle = 1592,
        ///<summary>Solid Shuttle Space</summary>
        ///<see href="https://fontawesome.com/icons/shuttle-space?style=solid"/>
        [Description("Solid Shuttle Space"), IconID("fas-shuttle-space"), IconUnicodeGlyph(0xf197)]
        SolidShuttleSpace = 1593,
        ///<summary>Solid Sign Hanging</summary>
        ///<see href="https://fontawesome.com/icons/sign-hanging?style=solid"/>
        [Description("Solid Sign Hanging"), IconID("fas-sign-hanging"), IconUnicodeGlyph(0xf4d9)]
        SolidSignHanging = 1594,
        ///<summary>Solid Signal</summary>
        ///<see href="https://fontawesome.com/icons/signal?style=solid"/>
        [Description("Solid Signal"), IconID("fas-signal"), IconUnicodeGlyph(0xf012)]
        SolidSignal = 1595,
        ///<summary>Brands Signal Messenger</summary>
        ///<see href="https://fontawesome.com/icons/signal-messenger?style=brands"/>
        [Description("Brands Signal Messenger"), IconID("fab-signal-messenger"), IconUnicodeGlyph(0xe663)]
        BrandsSignalMessenger = 1596,
        ///<summary>Solid Signature</summary>
        ///<see href="https://fontawesome.com/icons/signature?style=solid"/>
        [Description("Solid Signature"), IconID("fas-signature"), IconUnicodeGlyph(0xf5b7)]
        SolidSignature = 1597,
        ///<summary>Solid Signs Post</summary>
        ///<see href="https://fontawesome.com/icons/signs-post?style=solid"/>
        [Description("Solid Signs Post"), IconID("fas-signs-post"), IconUnicodeGlyph(0xf277)]
        SolidSignsPost = 1598,
        ///<summary>Solid Sim Card</summary>
        ///<see href="https://fontawesome.com/icons/sim-card?style=solid"/>
        [Description("Solid Sim Card"), IconID("fas-sim-card"), IconUnicodeGlyph(0xf7c4)]
        SolidSimCard = 1599,
        ///<summary>Brands SimplyBuilt</summary>
        ///<see href="https://fontawesome.com/icons/simplybuilt?style=brands"/>
        [Description("Brands SimplyBuilt"), IconID("fab-simplybuilt"), IconUnicodeGlyph(0xf215)]
        BrandsSimplybuilt = 1600,
        ///<summary>Solid Sink</summary>
        ///<see href="https://fontawesome.com/icons/sink?style=solid"/>
        [Description("Solid Sink"), IconID("fas-sink"), IconUnicodeGlyph(0xe06d)]
        SolidSink = 1601,
        ///<summary>Brands SISTRIX</summary>
        ///<see href="https://fontawesome.com/icons/sistrix?style=brands"/>
        [Description("Brands SISTRIX"), IconID("fab-sistrix"), IconUnicodeGlyph(0xf3ee)]
        BrandsSistrix = 1602,
        ///<summary>Solid Sitemap</summary>
        ///<see href="https://fontawesome.com/icons/sitemap?style=solid"/>
        [Description("Solid Sitemap"), IconID("fas-sitemap"), IconUnicodeGlyph(0xf0e8)]
        SolidSitemap = 1603,
        ///<summary>Brands Sith</summary>
        ///<see href="https://fontawesome.com/icons/sith?style=brands"/>
        [Description("Brands Sith"), IconID("fab-sith"), IconUnicodeGlyph(0xf512)]
        BrandsSith = 1604,
        ///<summary>Brands Sitrox</summary>
        ///<see href="https://fontawesome.com/icons/sitrox?style=brands"/>
        [Description("Brands Sitrox"), IconID("fab-sitrox"), IconUnicodeGlyph(0xe44a)]
        BrandsSitrox = 1605,
        ///<summary>Brands Sketch</summary>
        ///<see href="https://fontawesome.com/icons/sketch?style=brands"/>
        [Description("Brands Sketch"), IconID("fab-sketch"), IconUnicodeGlyph(0xf7c6)]
        BrandsSketch = 1606,
        ///<summary>Solid Skull</summary>
        ///<see href="https://fontawesome.com/icons/skull?style=solid"/>
        [Description("Solid Skull"), IconID("fas-skull"), IconUnicodeGlyph(0xf54c)]
        SolidSkull = 1607,
        ///<summary>Solid Skull Crossbones</summary>
        ///<see href="https://fontawesome.com/icons/skull-crossbones?style=solid"/>
        [Description("Solid Skull Crossbones"), IconID("fas-skull-crossbones"), IconUnicodeGlyph(0xf714)]
        SolidSkullCrossbones = 1608,
        ///<summary>Brands skyatlas</summary>
        ///<see href="https://fontawesome.com/icons/skyatlas?style=brands"/>
        [Description("Brands skyatlas"), IconID("fab-skyatlas"), IconUnicodeGlyph(0xf216)]
        BrandsSkyatlas = 1609,
        ///<summary>Brands Skype</summary>
        ///<see href="https://fontawesome.com/icons/skype?style=brands"/>
        [Description("Brands Skype"), IconID("fab-skype"), IconUnicodeGlyph(0xf17e)]
        BrandsSkype = 1610,
        ///<summary>Brands Slack Logo</summary>
        ///<see href="https://fontawesome.com/icons/slack?style=brands"/>
        [Description("Brands Slack Logo"), IconID("fab-slack"), IconUnicodeGlyph(0xf198)]
        BrandsSlack = 1611,
        ///<summary>Solid Slash</summary>
        ///<see href="https://fontawesome.com/icons/slash?style=solid"/>
        [Description("Solid Slash"), IconID("fas-slash"), IconUnicodeGlyph(0xf715)]
        SolidSlash = 1612,
        ///<summary>Solid Sleigh</summary>
        ///<see href="https://fontawesome.com/icons/sleigh?style=solid"/>
        [Description("Solid Sleigh"), IconID("fas-sleigh"), IconUnicodeGlyph(0xf7cc)]
        SolidSleigh = 1613,
        ///<summary>Solid Sliders</summary>
        ///<see href="https://fontawesome.com/icons/sliders?style=solid"/>
        [Description("Solid Sliders"), IconID("fas-sliders"), IconUnicodeGlyph(0xf1de)]
        SolidSliders = 1614,
        ///<summary>Brands Slideshare</summary>
        ///<see href="https://fontawesome.com/icons/slideshare?style=brands"/>
        [Description("Brands Slideshare"), IconID("fab-slideshare"), IconUnicodeGlyph(0xf1e7)]
        BrandsSlideshare = 1615,
        ///<summary>Solid Smog</summary>
        ///<see href="https://fontawesome.com/icons/smog?style=solid"/>
        [Description("Solid Smog"), IconID("fas-smog"), IconUnicodeGlyph(0xf75f)]
        SolidSmog = 1616,
        ///<summary>Solid Smoking</summary>
        ///<see href="https://fontawesome.com/icons/smoking?style=solid"/>
        [Description("Solid Smoking"), IconID("fas-smoking"), IconUnicodeGlyph(0xf48d)]
        SolidSmoking = 1617,
        ///<summary>Brands Snapchat</summary>
        ///<see href="https://fontawesome.com/icons/snapchat?style=brands"/>
        [Description("Brands Snapchat"), IconID("fab-snapchat"), IconUnicodeGlyph(0xf2ab)]
        BrandsSnapchat = 1618,
        ///<summary>Solid Snowflake</summary>
        ///<see href="https://fontawesome.com/icons/snowflake?style=solid"/>
        [Description("Solid Snowflake"), IconID("fas-snowflake"), IconUnicodeGlyph(0xf2dc)]
        SolidSnowflake = 1619,
        ///<summary>Regular Snowflake</summary>
        ///<see href="https://fontawesome.com/icons/snowflake?style=regular"/>
        [Description("Regular Snowflake"), IconID("far-snowflake"), IconUnicodeGlyph(0xf2dc)]
        RegularSnowflake = 1620,
        ///<summary>Solid Snowman</summary>
        ///<see href="https://fontawesome.com/icons/snowman?style=solid"/>
        [Description("Solid Snowman"), IconID("fas-snowman"), IconUnicodeGlyph(0xf7d0)]
        SolidSnowman = 1621,
        ///<summary>Solid Snowplow</summary>
        ///<see href="https://fontawesome.com/icons/snowplow?style=solid"/>
        [Description("Solid Snowplow"), IconID("fas-snowplow"), IconUnicodeGlyph(0xf7d2)]
        SolidSnowplow = 1622,
        ///<summary>Solid Soap</summary>
        ///<see href="https://fontawesome.com/icons/soap?style=solid"/>
        [Description("Solid Soap"), IconID("fas-soap"), IconUnicodeGlyph(0xe06e)]
        SolidSoap = 1623,
        ///<summary>Solid Socks</summary>
        ///<see href="https://fontawesome.com/icons/socks?style=solid"/>
        [Description("Solid Socks"), IconID("fas-socks"), IconUnicodeGlyph(0xf696)]
        SolidSocks = 1624,
        ///<summary>Solid Solar Panel</summary>
        ///<see href="https://fontawesome.com/icons/solar-panel?style=solid"/>
        [Description("Solid Solar Panel"), IconID("fas-solar-panel"), IconUnicodeGlyph(0xf5ba)]
        SolidSolarPanel = 1625,
        ///<summary>Solid Sort</summary>
        ///<see href="https://fontawesome.com/icons/sort?style=solid"/>
        [Description("Solid Sort"), IconID("fas-sort"), IconUnicodeGlyph(0xf0dc)]
        SolidSort = 1626,
        ///<summary>Solid Sort Down</summary>
        ///<see href="https://fontawesome.com/icons/sort-down?style=solid"/>
        [Description("Solid Sort Down"), IconID("fas-sort-down"), IconUnicodeGlyph(0xf0dd)]
        SolidSortDown = 1627,
        ///<summary>Solid Sort Up</summary>
        ///<see href="https://fontawesome.com/icons/sort-up?style=solid"/>
        [Description("Solid Sort Up"), IconID("fas-sort-up"), IconUnicodeGlyph(0xf0de)]
        SolidSortUp = 1628,
        ///<summary>Brands Soundcloud</summary>
        ///<see href="https://fontawesome.com/icons/soundcloud?style=brands"/>
        [Description("Brands Soundcloud"), IconID("fab-soundcloud"), IconUnicodeGlyph(0xf1be)]
        BrandsSoundcloud = 1629,
        ///<summary>Brands Sourcetree</summary>
        ///<see href="https://fontawesome.com/icons/sourcetree?style=brands"/>
        [Description("Brands Sourcetree"), IconID("fab-sourcetree"), IconUnicodeGlyph(0xf7d3)]
        BrandsSourcetree = 1630,
        ///<summary>Solid Spa</summary>
        ///<see href="https://fontawesome.com/icons/spa?style=solid"/>
        [Description("Solid Spa"), IconID("fas-spa"), IconUnicodeGlyph(0xf5bb)]
        SolidSpa = 1631,
        ///<summary>Brands Space Awesome</summary>
        ///<see href="https://fontawesome.com/icons/space-awesome?style=brands"/>
        [Description("Brands Space Awesome"), IconID("fab-space-awesome"), IconUnicodeGlyph(0xe5ac)]
        BrandsSpaceAwesome = 1632,
        ///<summary>Solid Spaghetti Monster Flying</summary>
        ///<see href="https://fontawesome.com/icons/spaghetti-monster-flying?style=solid"/>
        [Description("Solid Spaghetti Monster Flying"), IconID("fas-spaghetti-monster-flying"), IconUnicodeGlyph(0xf67b)]
        SolidSpaghettiMonsterFlying = 1633,
        ///<summary>Brands Speakap</summary>
        ///<see href="https://fontawesome.com/icons/speakap?style=brands"/>
        [Description("Brands Speakap"), IconID("fab-speakap"), IconUnicodeGlyph(0xf3f3)]
        BrandsSpeakap = 1634,
        ///<summary>Brands Speaker Deck</summary>
        ///<see href="https://fontawesome.com/icons/speaker-deck?style=brands"/>
        [Description("Brands Speaker Deck"), IconID("fab-speaker-deck"), IconUnicodeGlyph(0xf83c)]
        BrandsSpeakerDeck = 1635,
        ///<summary>Solid Spell Check</summary>
        ///<see href="https://fontawesome.com/icons/spell-check?style=solid"/>
        [Description("Solid Spell Check"), IconID("fas-spell-check"), IconUnicodeGlyph(0xf891)]
        SolidSpellCheck = 1636,
        ///<summary>Solid Spider</summary>
        ///<see href="https://fontawesome.com/icons/spider?style=solid"/>
        [Description("Solid Spider"), IconID("fas-spider"), IconUnicodeGlyph(0xf717)]
        SolidSpider = 1637,
        ///<summary>Solid Spinner</summary>
        ///<see href="https://fontawesome.com/icons/spinner?style=solid"/>
        [Description("Solid Spinner"), IconID("fas-spinner"), IconUnicodeGlyph(0xf110)]
        SolidSpinner = 1638,
        ///<summary>Solid Splotch</summary>
        ///<see href="https://fontawesome.com/icons/splotch?style=solid"/>
        [Description("Solid Splotch"), IconID("fas-splotch"), IconUnicodeGlyph(0xf5bc)]
        SolidSplotch = 1639,
        ///<summary>Solid Spoon</summary>
        ///<see href="https://fontawesome.com/icons/spoon?style=solid"/>
        [Description("Solid Spoon"), IconID("fas-spoon"), IconUnicodeGlyph(0xf2e5)]
        SolidSpoon = 1640,
        ///<summary>Brands Spotify</summary>
        ///<see href="https://fontawesome.com/icons/spotify?style=brands"/>
        [Description("Brands Spotify"), IconID("fab-spotify"), IconUnicodeGlyph(0xf1bc)]
        BrandsSpotify = 1641,
        ///<summary>Solid Spray Can</summary>
        ///<see href="https://fontawesome.com/icons/spray-can?style=solid"/>
        [Description("Solid Spray Can"), IconID("fas-spray-can"), IconUnicodeGlyph(0xf5bd)]
        SolidSprayCan = 1642,
        ///<summary>Solid Spray Can Sparkles</summary>
        ///<see href="https://fontawesome.com/icons/spray-can-sparkles?style=solid"/>
        [Description("Solid Spray Can Sparkles"), IconID("fas-spray-can-sparkles"), IconUnicodeGlyph(0xf5d0)]
        SolidSprayCanSparkles = 1643,
        ///<summary>Solid Square</summary>
        ///<see href="https://fontawesome.com/icons/square?style=solid"/>
        [Description("Solid Square"), IconID("fas-square"), IconUnicodeGlyph(0xf0c8)]
        SolidSquare = 1644,
        ///<summary>Regular Square</summary>
        ///<see href="https://fontawesome.com/icons/square?style=regular"/>
        [Description("Regular Square"), IconID("far-square"), IconUnicodeGlyph(0xf0c8)]
        RegularSquare = 1645,
        ///<summary>Solid Square Arrow Up Right</summary>
        ///<see href="https://fontawesome.com/icons/square-arrow-up-right?style=solid"/>
        [Description("Solid Square Arrow Up Right"), IconID("fas-square-arrow-up-right"), IconUnicodeGlyph(0xf14c)]
        SolidSquareArrowUpRight = 1646,
        ///<summary>Brands Square Behance</summary>
        ///<see href="https://fontawesome.com/icons/square-behance?style=brands"/>
        [Description("Brands Square Behance"), IconID("fab-square-behance"), IconUnicodeGlyph(0xf1b5)]
        BrandsSquareBehance = 1647,
        ///<summary>Solid Square Binary</summary>
        ///<see href="https://fontawesome.com/icons/square-binary?style=solid"/>
        [Description("Solid Square Binary"), IconID("fas-square-binary"), IconUnicodeGlyph(0xe69b)]
        SolidSquareBinary = 1648,
        ///<summary>Brands Square Bluesky</summary>
        ///<see href="https://fontawesome.com/icons/square-bluesky?style=brands"/>
        [Description("Brands Square Bluesky"), IconID("fab-square-bluesky"), IconUnicodeGlyph(0xe6a3)]
        BrandsSquareBluesky = 1649,
        ///<summary>Solid Square Caret Down</summary>
        ///<see href="https://fontawesome.com/icons/square-caret-down?style=solid"/>
        [Description("Solid Square Caret Down"), IconID("fas-square-caret-down"), IconUnicodeGlyph(0xf150)]
        SolidSquareCaretDown = 1650,
        ///<summary>Regular Square Caret Down</summary>
        ///<see href="https://fontawesome.com/icons/square-caret-down?style=regular"/>
        [Description("Regular Square Caret Down"), IconID("far-square-caret-down"), IconUnicodeGlyph(0xf150)]
        RegularSquareCaretDown = 1651,
        ///<summary>Solid Square Caret Left</summary>
        ///<see href="https://fontawesome.com/icons/square-caret-left?style=solid"/>
        [Description("Solid Square Caret Left"), IconID("fas-square-caret-left"), IconUnicodeGlyph(0xf191)]
        SolidSquareCaretLeft = 1652,
        ///<summary>Regular Square Caret Left</summary>
        ///<see href="https://fontawesome.com/icons/square-caret-left?style=regular"/>
        [Description("Regular Square Caret Left"), IconID("far-square-caret-left"), IconUnicodeGlyph(0xf191)]
        RegularSquareCaretLeft = 1653,
        ///<summary>Solid Square Caret Right</summary>
        ///<see href="https://fontawesome.com/icons/square-caret-right?style=solid"/>
        [Description("Solid Square Caret Right"), IconID("fas-square-caret-right"), IconUnicodeGlyph(0xf152)]
        SolidSquareCaretRight = 1654,
        ///<summary>Regular Square Caret Right</summary>
        ///<see href="https://fontawesome.com/icons/square-caret-right?style=regular"/>
        [Description("Regular Square Caret Right"), IconID("far-square-caret-right"), IconUnicodeGlyph(0xf152)]
        RegularSquareCaretRight = 1655,
        ///<summary>Solid Square Caret Up</summary>
        ///<see href="https://fontawesome.com/icons/square-caret-up?style=solid"/>
        [Description("Solid Square Caret Up"), IconID("fas-square-caret-up"), IconUnicodeGlyph(0xf151)]
        SolidSquareCaretUp = 1656,
        ///<summary>Regular Square Caret Up</summary>
        ///<see href="https://fontawesome.com/icons/square-caret-up?style=regular"/>
        [Description("Regular Square Caret Up"), IconID("far-square-caret-up"), IconUnicodeGlyph(0xf151)]
        RegularSquareCaretUp = 1657,
        ///<summary>Solid Square Check</summary>
        ///<see href="https://fontawesome.com/icons/square-check?style=solid"/>
        [Description("Solid Square Check"), IconID("fas-square-check"), IconUnicodeGlyph(0xf14a)]
        SolidSquareCheck = 1658,
        ///<summary>Regular Square Check</summary>
        ///<see href="https://fontawesome.com/icons/square-check?style=regular"/>
        [Description("Regular Square Check"), IconID("far-square-check"), IconUnicodeGlyph(0xf14a)]
        RegularSquareCheck = 1659,
        ///<summary>Brands Square Dribbble</summary>
        ///<see href="https://fontawesome.com/icons/square-dribbble?style=brands"/>
        [Description("Brands Square Dribbble"), IconID("fab-square-dribbble"), IconUnicodeGlyph(0xf397)]
        BrandsSquareDribbble = 1660,
        ///<summary>Solid Square Envelope</summary>
        ///<see href="https://fontawesome.com/icons/square-envelope?style=solid"/>
        [Description("Solid Square Envelope"), IconID("fas-square-envelope"), IconUnicodeGlyph(0xf199)]
        SolidSquareEnvelope = 1661,
        ///<summary>Brands Square Facebook</summary>
        ///<see href="https://fontawesome.com/icons/square-facebook?style=brands"/>
        [Description("Brands Square Facebook"), IconID("fab-square-facebook"), IconUnicodeGlyph(0xf082)]
        BrandsSquareFacebook = 1662,
        ///<summary>Brands Square Font Awesome</summary>
        ///<see href="https://fontawesome.com/icons/square-font-awesome?style=brands"/>
        [Description("Brands Square Font Awesome"), IconID("fab-square-font-awesome"), IconUnicodeGlyph(0xe5ad)]
        BrandsSquareFontAwesome = 1663,
        ///<summary>Brands Square Font Awesome Stroke</summary>
        ///<see href="https://fontawesome.com/icons/square-font-awesome-stroke?style=brands"/>
        [Description("Brands Square Font Awesome Stroke"), IconID("fab-square-font-awesome-stroke"), IconUnicodeGlyph(0xf35c)]
        BrandsSquareFontAwesomeStroke = 1664,
        ///<summary>Solid Square Full</summary>
        ///<see href="https://fontawesome.com/icons/square-full?style=solid"/>
        [Description("Solid Square Full"), IconID("fas-square-full"), IconUnicodeGlyph(0xf45c)]
        SolidSquareFull = 1665,
        ///<summary>Regular Square Full</summary>
        ///<see href="https://fontawesome.com/icons/square-full?style=regular"/>
        [Description("Regular Square Full"), IconID("far-square-full"), IconUnicodeGlyph(0xf45c)]
        RegularSquareFull = 1666,
        ///<summary>Brands Square Git</summary>
        ///<see href="https://fontawesome.com/icons/square-git?style=brands"/>
        [Description("Brands Square Git"), IconID("fab-square-git"), IconUnicodeGlyph(0xf1d2)]
        BrandsSquareGit = 1667,
        ///<summary>Brands Square Github</summary>
        ///<see href="https://fontawesome.com/icons/square-github?style=brands"/>
        [Description("Brands Square Github"), IconID("fab-square-github"), IconUnicodeGlyph(0xf092)]
        BrandsSquareGithub = 1668,
        ///<summary>Brands Square Gitlab</summary>
        ///<see href="https://fontawesome.com/icons/square-gitlab?style=brands"/>
        [Description("Brands Square Gitlab"), IconID("fab-square-gitlab"), IconUnicodeGlyph(0xe5ae)]
        BrandsSquareGitlab = 1669,
        ///<summary>Brands Square Google Plus</summary>
        ///<see href="https://fontawesome.com/icons/square-google-plus?style=brands"/>
        [Description("Brands Square Google Plus"), IconID("fab-square-google-plus"), IconUnicodeGlyph(0xf0d4)]
        BrandsSquareGooglePlus = 1670,
        ///<summary>Solid Square H</summary>
        ///<see href="https://fontawesome.com/icons/square-h?style=solid"/>
        [Description("Solid Square H"), IconID("fas-square-h"), IconUnicodeGlyph(0xf0fd)]
        SolidSquareH = 1671,
        ///<summary>Brands Square Hacker News</summary>
        ///<see href="https://fontawesome.com/icons/square-hacker-news?style=brands"/>
        [Description("Brands Square Hacker News"), IconID("fab-square-hacker-news"), IconUnicodeGlyph(0xf3af)]
        BrandsSquareHackerNews = 1672,
        ///<summary>Brands Square Instagram</summary>
        ///<see href="https://fontawesome.com/icons/square-instagram?style=brands"/>
        [Description("Brands Square Instagram"), IconID("fab-square-instagram"), IconUnicodeGlyph(0xe055)]
        BrandsSquareInstagram = 1673,
        ///<summary>Brands Square Js</summary>
        ///<see href="https://fontawesome.com/icons/square-js?style=brands"/>
        [Description("Brands Square Js"), IconID("fab-square-js"), IconUnicodeGlyph(0xf3b9)]
        BrandsSquareJs = 1674,
        ///<summary>Brands Square Lastfm</summary>
        ///<see href="https://fontawesome.com/icons/square-lastfm?style=brands"/>
        [Description("Brands Square Lastfm"), IconID("fab-square-lastfm"), IconUnicodeGlyph(0xf203)]
        BrandsSquareLastfm = 1675,
        ///<summary>Brands Square Letterboxd</summary>
        ///<see href="https://fontawesome.com/icons/square-letterboxd?style=brands"/>
        [Description("Brands Square Letterboxd"), IconID("fab-square-letterboxd"), IconUnicodeGlyph(0xe62e)]
        BrandsSquareLetterboxd = 1676,
        ///<summary>Solid Square Minus</summary>
        ///<see href="https://fontawesome.com/icons/square-minus?style=solid"/>
        [Description("Solid Square Minus"), IconID("fas-square-minus"), IconUnicodeGlyph(0xf146)]
        SolidSquareMinus = 1677,
        ///<summary>Regular Square Minus</summary>
        ///<see href="https://fontawesome.com/icons/square-minus?style=regular"/>
        [Description("Regular Square Minus"), IconID("far-square-minus"), IconUnicodeGlyph(0xf146)]
        RegularSquareMinus = 1678,
        ///<summary>Solid Square Nfi</summary>
        ///<see href="https://fontawesome.com/icons/square-nfi?style=solid"/>
        [Description("Solid Square Nfi"), IconID("fas-square-nfi"), IconUnicodeGlyph(0xe576)]
        SolidSquareNfi = 1679,
        ///<summary>Brands Square Odnoklassniki</summary>
        ///<see href="https://fontawesome.com/icons/square-odnoklassniki?style=brands"/>
        [Description("Brands Square Odnoklassniki"), IconID("fab-square-odnoklassniki"), IconUnicodeGlyph(0xf264)]
        BrandsSquareOdnoklassniki = 1680,
        ///<summary>Solid Square Parking</summary>
        ///<see href="https://fontawesome.com/icons/square-parking?style=solid"/>
        [Description("Solid Square Parking"), IconID("fas-square-parking"), IconUnicodeGlyph(0xf540)]
        SolidSquareParking = 1681,
        ///<summary>Solid Square Pen</summary>
        ///<see href="https://fontawesome.com/icons/square-pen?style=solid"/>
        [Description("Solid Square Pen"), IconID("fas-square-pen"), IconUnicodeGlyph(0xf14b)]
        SolidSquarePen = 1682,
        ///<summary>Solid Square Person Confined</summary>
        ///<see href="https://fontawesome.com/icons/square-person-confined?style=solid"/>
        [Description("Solid Square Person Confined"), IconID("fas-square-person-confined"), IconUnicodeGlyph(0xe577)]
        SolidSquarePersonConfined = 1683,
        ///<summary>Solid Square Phone</summary>
        ///<see href="https://fontawesome.com/icons/square-phone?style=solid"/>
        [Description("Solid Square Phone"), IconID("fas-square-phone"), IconUnicodeGlyph(0xf098)]
        SolidSquarePhone = 1684,
        ///<summary>Solid Square Phone Flip</summary>
        ///<see href="https://fontawesome.com/icons/square-phone-flip?style=solid"/>
        [Description("Solid Square Phone Flip"), IconID("fas-square-phone-flip"), IconUnicodeGlyph(0xf87b)]
        SolidSquarePhoneFlip = 1685,
        ///<summary>Brands Pied Piper Square Logo (Old)</summary>
        ///<see href="https://fontawesome.com/icons/square-pied-piper?style=brands"/>
        [Description("Brands Pied Piper Square Logo (Old)"), IconID("fab-square-pied-piper"), IconUnicodeGlyph(0xe01e)]
        BrandsSquarePiedPiper = 1686,
        ///<summary>Brands Square Pinterest</summary>
        ///<see href="https://fontawesome.com/icons/square-pinterest?style=brands"/>
        [Description("Brands Square Pinterest"), IconID("fab-square-pinterest"), IconUnicodeGlyph(0xf0d3)]
        BrandsSquarePinterest = 1687,
        ///<summary>Solid Square Plus</summary>
        ///<see href="https://fontawesome.com/icons/square-plus?style=solid"/>
        [Description("Solid Square Plus"), IconID("fas-square-plus"), IconUnicodeGlyph(0xf0fe)]
        SolidSquarePlus = 1688,
        ///<summary>Regular Square Plus</summary>
        ///<see href="https://fontawesome.com/icons/square-plus?style=regular"/>
        [Description("Regular Square Plus"), IconID("far-square-plus"), IconUnicodeGlyph(0xf0fe)]
        RegularSquarePlus = 1689,
        ///<summary>Solid Square Poll Horizontal</summary>
        ///<see href="https://fontawesome.com/icons/square-poll-horizontal?style=solid"/>
        [Description("Solid Square Poll Horizontal"), IconID("fas-square-poll-horizontal"), IconUnicodeGlyph(0xf682)]
        SolidSquarePollHorizontal = 1690,
        ///<summary>Solid Square Poll Vertical</summary>
        ///<see href="https://fontawesome.com/icons/square-poll-vertical?style=solid"/>
        [Description("Solid Square Poll Vertical"), IconID("fas-square-poll-vertical"), IconUnicodeGlyph(0xf681)]
        SolidSquarePollVertical = 1691,
        ///<summary>Brands Square Reddit</summary>
        ///<see href="https://fontawesome.com/icons/square-reddit?style=brands"/>
        [Description("Brands Square Reddit"), IconID("fab-square-reddit"), IconUnicodeGlyph(0xf1a2)]
        BrandsSquareReddit = 1692,
        ///<summary>Solid Square Root Variable</summary>
        ///<see href="https://fontawesome.com/icons/square-root-variable?style=solid"/>
        [Description("Solid Square Root Variable"), IconID("fas-square-root-variable"), IconUnicodeGlyph(0xf698)]
        SolidSquareRootVariable = 1693,
        ///<summary>Solid Square Rss</summary>
        ///<see href="https://fontawesome.com/icons/square-rss?style=solid"/>
        [Description("Solid Square Rss"), IconID("fas-square-rss"), IconUnicodeGlyph(0xf143)]
        SolidSquareRss = 1694,
        ///<summary>Solid Square Share Nodes</summary>
        ///<see href="https://fontawesome.com/icons/square-share-nodes?style=solid"/>
        [Description("Solid Square Share Nodes"), IconID("fas-square-share-nodes"), IconUnicodeGlyph(0xf1e1)]
        SolidSquareShareNodes = 1695,
        ///<summary>Brands Snapchat Square</summary>
        ///<see href="https://fontawesome.com/icons/square-snapchat?style=brands"/>
        [Description("Brands Snapchat Square"), IconID("fab-square-snapchat"), IconUnicodeGlyph(0xf2ad)]
        BrandsSquareSnapchat = 1696,
        ///<summary>Brands Square Steam</summary>
        ///<see href="https://fontawesome.com/icons/square-steam?style=brands"/>
        [Description("Brands Square Steam"), IconID("fab-square-steam"), IconUnicodeGlyph(0xf1b7)]
        BrandsSquareSteam = 1697,
        ///<summary>Brands Square Threads</summary>
        ///<see href="https://fontawesome.com/icons/square-threads?style=brands"/>
        [Description("Brands Square Threads"), IconID("fab-square-threads"), IconUnicodeGlyph(0xe619)]
        BrandsSquareThreads = 1698,
        ///<summary>Brands Square Tumblr</summary>
        ///<see href="https://fontawesome.com/icons/square-tumblr?style=brands"/>
        [Description("Brands Square Tumblr"), IconID("fab-square-tumblr"), IconUnicodeGlyph(0xf174)]
        BrandsSquareTumblr = 1699,
        ///<summary>Brands Square Twitter</summary>
        ///<see href="https://fontawesome.com/icons/square-twitter?style=brands"/>
        [Description("Brands Square Twitter"), IconID("fab-square-twitter"), IconUnicodeGlyph(0xf081)]
        BrandsSquareTwitter = 1700,
        ///<summary>Solid Square Up Right</summary>
        ///<see href="https://fontawesome.com/icons/square-up-right?style=solid"/>
        [Description("Solid Square Up Right"), IconID("fas-square-up-right"), IconUnicodeGlyph(0xf360)]
        SolidSquareUpRight = 1701,
        ///<summary>Brands Square Upwork</summary>
        ///<see href="https://fontawesome.com/icons/square-upwork?style=brands"/>
        [Description("Brands Square Upwork"), IconID("fab-square-upwork"), IconUnicodeGlyph(0xe67c)]
        BrandsSquareUpwork = 1702,
        ///<summary>Brands Square Viadeo</summary>
        ///<see href="https://fontawesome.com/icons/square-viadeo?style=brands"/>
        [Description("Brands Square Viadeo"), IconID("fab-square-viadeo"), IconUnicodeGlyph(0xf2aa)]
        BrandsSquareViadeo = 1703,
        ///<summary>Brands Square Vimeo</summary>
        ///<see href="https://fontawesome.com/icons/square-vimeo?style=brands"/>
        [Description("Brands Square Vimeo"), IconID("fab-square-vimeo"), IconUnicodeGlyph(0xf194)]
        BrandsSquareVimeo = 1704,
        ///<summary>Solid Square Virus</summary>
        ///<see href="https://fontawesome.com/icons/square-virus?style=solid"/>
        [Description("Solid Square Virus"), IconID("fas-square-virus"), IconUnicodeGlyph(0xe578)]
        SolidSquareVirus = 1705,
        ///<summary>Brands Square Web Awesome</summary>
        ///<see href="https://fontawesome.com/icons/square-web-awesome?style=brands"/>
        [Description("Brands Square Web Awesome"), IconID("fab-square-web-awesome"), IconUnicodeGlyph(0xe683)]
        BrandsSquareWebAwesome = 1706,
        ///<summary>Brands Square Web Awesome Stroke</summary>
        ///<see href="https://fontawesome.com/icons/square-web-awesome-stroke?style=brands"/>
        [Description("Brands Square Web Awesome Stroke"), IconID("fab-square-web-awesome-stroke"), IconUnicodeGlyph(0xe684)]
        BrandsSquareWebAwesomeStroke = 1707,
        ///<summary>Brands Square Whatsapp</summary>
        ///<see href="https://fontawesome.com/icons/square-whatsapp?style=brands"/>
        [Description("Brands Square Whatsapp"), IconID("fab-square-whatsapp"), IconUnicodeGlyph(0xf40c)]
        BrandsSquareWhatsapp = 1708,
        ///<summary>Brands Square X Twitter</summary>
        ///<see href="https://fontawesome.com/icons/square-x-twitter?style=brands"/>
        [Description("Brands Square X Twitter"), IconID("fab-square-x-twitter"), IconUnicodeGlyph(0xe61a)]
        BrandsSquareXTwitter = 1709,
        ///<summary>Brands Square Xing</summary>
        ///<see href="https://fontawesome.com/icons/square-xing?style=brands"/>
        [Description("Brands Square Xing"), IconID("fab-square-xing"), IconUnicodeGlyph(0xf169)]
        BrandsSquareXing = 1710,
        ///<summary>Solid Square Xmark</summary>
        ///<see href="https://fontawesome.com/icons/square-xmark?style=solid"/>
        [Description("Solid Square Xmark"), IconID("fas-square-xmark"), IconUnicodeGlyph(0xf2d3)]
        SolidSquareXmark = 1711,
        ///<summary>Brands Square Youtube</summary>
        ///<see href="https://fontawesome.com/icons/square-youtube?style=brands"/>
        [Description("Brands Square Youtube"), IconID("fab-square-youtube"), IconUnicodeGlyph(0xf431)]
        BrandsSquareYoutube = 1712,
        ///<summary>Brands Squarespace</summary>
        ///<see href="https://fontawesome.com/icons/squarespace?style=brands"/>
        [Description("Brands Squarespace"), IconID("fab-squarespace"), IconUnicodeGlyph(0xf5be)]
        BrandsSquarespace = 1713,
        ///<summary>Brands Stack Exchange</summary>
        ///<see href="https://fontawesome.com/icons/stack-exchange?style=brands"/>
        [Description("Brands Stack Exchange"), IconID("fab-stack-exchange"), IconUnicodeGlyph(0xf18d)]
        BrandsStackExchange = 1714,
        ///<summary>Brands Stack Overflow</summary>
        ///<see href="https://fontawesome.com/icons/stack-overflow?style=brands"/>
        [Description("Brands Stack Overflow"), IconID("fab-stack-overflow"), IconUnicodeGlyph(0xf16c)]
        BrandsStackOverflow = 1715,
        ///<summary>Brands Stackpath</summary>
        ///<see href="https://fontawesome.com/icons/stackpath?style=brands"/>
        [Description("Brands Stackpath"), IconID("fab-stackpath"), IconUnicodeGlyph(0xf842)]
        BrandsStackpath = 1716,
        ///<summary>Solid Staff Snake</summary>
        ///<see href="https://fontawesome.com/icons/staff-snake?style=solid"/>
        [Description("Solid Staff Snake"), IconID("fas-staff-snake"), IconUnicodeGlyph(0xe579)]
        SolidStaffSnake = 1717,
        ///<summary>Solid Stairs</summary>
        ///<see href="https://fontawesome.com/icons/stairs?style=solid"/>
        [Description("Solid Stairs"), IconID("fas-stairs"), IconUnicodeGlyph(0xe289)]
        SolidStairs = 1718,
        ///<summary>Solid Stamp</summary>
        ///<see href="https://fontawesome.com/icons/stamp?style=solid"/>
        [Description("Solid Stamp"), IconID("fas-stamp"), IconUnicodeGlyph(0xf5bf)]
        SolidStamp = 1719,
        ///<summary>Solid Stapler</summary>
        ///<see href="https://fontawesome.com/icons/stapler?style=solid"/>
        [Description("Solid Stapler"), IconID("fas-stapler"), IconUnicodeGlyph(0xe5af)]
        SolidStapler = 1720,
        ///<summary>Solid Star</summary>
        ///<see href="https://fontawesome.com/icons/star?style=solid"/>
        [Description("Solid Star"), IconID("fas-star"), IconUnicodeGlyph(0xf005)]
        SolidStar = 1721,
        ///<summary>Regular Star</summary>
        ///<see href="https://fontawesome.com/icons/star?style=regular"/>
        [Description("Regular Star"), IconID("far-star"), IconUnicodeGlyph(0xf005)]
        RegularStar = 1722,
        ///<summary>Solid Star And Crescent</summary>
        ///<see href="https://fontawesome.com/icons/star-and-crescent?style=solid"/>
        [Description("Solid Star And Crescent"), IconID("fas-star-and-crescent"), IconUnicodeGlyph(0xf699)]
        SolidStarAndCrescent = 1723,
        ///<summary>Solid Star Half</summary>
        ///<see href="https://fontawesome.com/icons/star-half?style=solid"/>
        [Description("Solid Star Half"), IconID("fas-star-half"), IconUnicodeGlyph(0xf089)]
        SolidStarHalf = 1724,
        ///<summary>Regular Star Half</summary>
        ///<see href="https://fontawesome.com/icons/star-half?style=regular"/>
        [Description("Regular Star Half"), IconID("far-star-half"), IconUnicodeGlyph(0xf089)]
        RegularStarHalf = 1725,
        ///<summary>Solid Star Half Stroke</summary>
        ///<see href="https://fontawesome.com/icons/star-half-stroke?style=solid"/>
        [Description("Solid Star Half Stroke"), IconID("fas-star-half-stroke"), IconUnicodeGlyph(0xf5c0)]
        SolidStarHalfStroke = 1726,
        ///<summary>Regular Star Half Stroke</summary>
        ///<see href="https://fontawesome.com/icons/star-half-stroke?style=regular"/>
        [Description("Regular Star Half Stroke"), IconID("far-star-half-stroke"), IconUnicodeGlyph(0xf5c0)]
        RegularStarHalfStroke = 1727,
        ///<summary>Solid Star Of David</summary>
        ///<see href="https://fontawesome.com/icons/star-of-david?style=solid"/>
        [Description("Solid Star Of David"), IconID("fas-star-of-david"), IconUnicodeGlyph(0xf69a)]
        SolidStarOfDavid = 1728,
        ///<summary>Solid Star Of Life</summary>
        ///<see href="https://fontawesome.com/icons/star-of-life?style=solid"/>
        [Description("Solid Star Of Life"), IconID("fas-star-of-life"), IconUnicodeGlyph(0xf621)]
        SolidStarOfLife = 1729,
        ///<summary>Brands StayLinked</summary>
        ///<see href="https://fontawesome.com/icons/staylinked?style=brands"/>
        [Description("Brands StayLinked"), IconID("fab-staylinked"), IconUnicodeGlyph(0xf3f5)]
        BrandsStaylinked = 1730,
        ///<summary>Brands Steam</summary>
        ///<see href="https://fontawesome.com/icons/steam?style=brands"/>
        [Description("Brands Steam"), IconID("fab-steam"), IconUnicodeGlyph(0xf1b6)]
        BrandsSteam = 1731,
        ///<summary>Brands Steam Symbol</summary>
        ///<see href="https://fontawesome.com/icons/steam-symbol?style=brands"/>
        [Description("Brands Steam Symbol"), IconID("fab-steam-symbol"), IconUnicodeGlyph(0xf3f6)]
        BrandsSteamSymbol = 1732,
        ///<summary>Solid Sterling Sign</summary>
        ///<see href="https://fontawesome.com/icons/sterling-sign?style=solid"/>
        [Description("Solid Sterling Sign"), IconID("fas-sterling-sign"), IconUnicodeGlyph(0xf154)]
        SolidSterlingSign = 1733,
        ///<summary>Solid Stethoscope</summary>
        ///<see href="https://fontawesome.com/icons/stethoscope?style=solid"/>
        [Description("Solid Stethoscope"), IconID("fas-stethoscope"), IconUnicodeGlyph(0xf0f1)]
        SolidStethoscope = 1734,
        ///<summary>Brands Sticker Mule</summary>
        ///<see href="https://fontawesome.com/icons/sticker-mule?style=brands"/>
        [Description("Brands Sticker Mule"), IconID("fab-sticker-mule"), IconUnicodeGlyph(0xf3f7)]
        BrandsStickerMule = 1735,
        ///<summary>Solid Stop</summary>
        ///<see href="https://fontawesome.com/icons/stop?style=solid"/>
        [Description("Solid Stop"), IconID("fas-stop"), IconUnicodeGlyph(0xf04d)]
        SolidStop = 1736,
        ///<summary>Solid Stopwatch</summary>
        ///<see href="https://fontawesome.com/icons/stopwatch?style=solid"/>
        [Description("Solid Stopwatch"), IconID("fas-stopwatch"), IconUnicodeGlyph(0xf2f2)]
        SolidStopwatch = 1737,
        ///<summary>Solid Stopwatch 20</summary>
        ///<see href="https://fontawesome.com/icons/stopwatch-20?style=solid"/>
        [Description("Solid Stopwatch 20"), IconID("fas-stopwatch-20"), IconUnicodeGlyph(0xe06f)]
        SolidStopwatch20 = 1738,
        ///<summary>Solid Store</summary>
        ///<see href="https://fontawesome.com/icons/store?style=solid"/>
        [Description("Solid Store"), IconID("fas-store"), IconUnicodeGlyph(0xf54e)]
        SolidStore = 1739,
        ///<summary>Solid Store Slash</summary>
        ///<see href="https://fontawesome.com/icons/store-slash?style=solid"/>
        [Description("Solid Store Slash"), IconID("fas-store-slash"), IconUnicodeGlyph(0xe071)]
        SolidStoreSlash = 1740,
        ///<summary>Brands Strava</summary>
        ///<see href="https://fontawesome.com/icons/strava?style=brands"/>
        [Description("Brands Strava"), IconID("fab-strava"), IconUnicodeGlyph(0xf428)]
        BrandsStrava = 1741,
        ///<summary>Solid Street View</summary>
        ///<see href="https://fontawesome.com/icons/street-view?style=solid"/>
        [Description("Solid Street View"), IconID("fas-street-view"), IconUnicodeGlyph(0xf21d)]
        SolidStreetView = 1742,
        ///<summary>Solid Strikethrough</summary>
        ///<see href="https://fontawesome.com/icons/strikethrough?style=solid"/>
        [Description("Solid Strikethrough"), IconID("fas-strikethrough"), IconUnicodeGlyph(0xf0cc)]
        SolidStrikethrough = 1743,
        ///<summary>Brands Stripe</summary>
        ///<see href="https://fontawesome.com/icons/stripe?style=brands"/>
        [Description("Brands Stripe"), IconID("fab-stripe"), IconUnicodeGlyph(0xf429)]
        BrandsStripe = 1744,
        ///<summary>Brands Stripe S</summary>
        ///<see href="https://fontawesome.com/icons/stripe-s?style=brands"/>
        [Description("Brands Stripe S"), IconID("fab-stripe-s"), IconUnicodeGlyph(0xf42a)]
        BrandsStripeS = 1745,
        ///<summary>Solid Stroopwafel</summary>
        ///<see href="https://fontawesome.com/icons/stroopwafel?style=solid"/>
        [Description("Solid Stroopwafel"), IconID("fas-stroopwafel"), IconUnicodeGlyph(0xf551)]
        SolidStroopwafel = 1746,
        ///<summary>Brands Stubber</summary>
        ///<see href="https://fontawesome.com/icons/stubber?style=brands"/>
        [Description("Brands Stubber"), IconID("fab-stubber"), IconUnicodeGlyph(0xe5c7)]
        BrandsStubber = 1747,
        ///<summary>Brands Studio Vinari</summary>
        ///<see href="https://fontawesome.com/icons/studiovinari?style=brands"/>
        [Description("Brands Studio Vinari"), IconID("fab-studiovinari"), IconUnicodeGlyph(0xf3f8)]
        BrandsStudiovinari = 1748,
        ///<summary>Brands StumbleUpon Logo</summary>
        ///<see href="https://fontawesome.com/icons/stumbleupon?style=brands"/>
        [Description("Brands StumbleUpon Logo"), IconID("fab-stumbleupon"), IconUnicodeGlyph(0xf1a4)]
        BrandsStumbleupon = 1749,
        ///<summary>Brands StumbleUpon Circle</summary>
        ///<see href="https://fontawesome.com/icons/stumbleupon-circle?style=brands"/>
        [Description("Brands StumbleUpon Circle"), IconID("fab-stumbleupon-circle"), IconUnicodeGlyph(0xf1a3)]
        BrandsStumbleuponCircle = 1750,
        ///<summary>Solid Subscript</summary>
        ///<see href="https://fontawesome.com/icons/subscript?style=solid"/>
        [Description("Solid Subscript"), IconID("fas-subscript"), IconUnicodeGlyph(0xf12c)]
        SolidSubscript = 1751,
        ///<summary>Solid Suitcase</summary>
        ///<see href="https://fontawesome.com/icons/suitcase?style=solid"/>
        [Description("Solid Suitcase"), IconID("fas-suitcase"), IconUnicodeGlyph(0xf0f2)]
        SolidSuitcase = 1752,
        ///<summary>Solid Suitcase Medical</summary>
        ///<see href="https://fontawesome.com/icons/suitcase-medical?style=solid"/>
        [Description("Solid Suitcase Medical"), IconID("fas-suitcase-medical"), IconUnicodeGlyph(0xf0fa)]
        SolidSuitcaseMedical = 1753,
        ///<summary>Solid Suitcase Rolling</summary>
        ///<see href="https://fontawesome.com/icons/suitcase-rolling?style=solid"/>
        [Description("Solid Suitcase Rolling"), IconID("fas-suitcase-rolling"), IconUnicodeGlyph(0xf5c1)]
        SolidSuitcaseRolling = 1754,
        ///<summary>Solid Sun</summary>
        ///<see href="https://fontawesome.com/icons/sun?style=solid"/>
        [Description("Solid Sun"), IconID("fas-sun"), IconUnicodeGlyph(0xf185)]
        SolidSun = 1755,
        ///<summary>Regular Sun</summary>
        ///<see href="https://fontawesome.com/icons/sun?style=regular"/>
        [Description("Regular Sun"), IconID("far-sun"), IconUnicodeGlyph(0xf185)]
        RegularSun = 1756,
        ///<summary>Solid Sun Plant Wilt</summary>
        ///<see href="https://fontawesome.com/icons/sun-plant-wilt?style=solid"/>
        [Description("Solid Sun Plant Wilt"), IconID("fas-sun-plant-wilt"), IconUnicodeGlyph(0xe57a)]
        SolidSunPlantWilt = 1757,
        ///<summary>Brands Superpowers</summary>
        ///<see href="https://fontawesome.com/icons/superpowers?style=brands"/>
        [Description("Brands Superpowers"), IconID("fab-superpowers"), IconUnicodeGlyph(0xf2dd)]
        BrandsSuperpowers = 1758,
        ///<summary>Solid Superscript</summary>
        ///<see href="https://fontawesome.com/icons/superscript?style=solid"/>
        [Description("Solid Superscript"), IconID("fas-superscript"), IconUnicodeGlyph(0xf12b)]
        SolidSuperscript = 1759,
        ///<summary>Brands Supple</summary>
        ///<see href="https://fontawesome.com/icons/supple?style=brands"/>
        [Description("Brands Supple"), IconID("fab-supple"), IconUnicodeGlyph(0xf3f9)]
        BrandsSupple = 1760,
        ///<summary>Brands Suse</summary>
        ///<see href="https://fontawesome.com/icons/suse?style=brands"/>
        [Description("Brands Suse"), IconID("fab-suse"), IconUnicodeGlyph(0xf7d6)]
        BrandsSuse = 1761,
        ///<summary>Solid Swatchbook</summary>
        ///<see href="https://fontawesome.com/icons/swatchbook?style=solid"/>
        [Description("Solid Swatchbook"), IconID("fas-swatchbook"), IconUnicodeGlyph(0xf5c3)]
        SolidSwatchbook = 1762,
        ///<summary>Brands Swift</summary>
        ///<see href="https://fontawesome.com/icons/swift?style=brands"/>
        [Description("Brands Swift"), IconID("fab-swift"), IconUnicodeGlyph(0xf8e1)]
        BrandsSwift = 1763,
        ///<summary>Brands Symfony</summary>
        ///<see href="https://fontawesome.com/icons/symfony?style=brands"/>
        [Description("Brands Symfony"), IconID("fab-symfony"), IconUnicodeGlyph(0xf83d)]
        BrandsSymfony = 1764,
        ///<summary>Solid Synagogue</summary>
        ///<see href="https://fontawesome.com/icons/synagogue?style=solid"/>
        [Description("Solid Synagogue"), IconID("fas-synagogue"), IconUnicodeGlyph(0xf69b)]
        SolidSynagogue = 1765,
        ///<summary>Solid Syringe</summary>
        ///<see href="https://fontawesome.com/icons/syringe?style=solid"/>
        [Description("Solid Syringe"), IconID("fas-syringe"), IconUnicodeGlyph(0xf48e)]
        SolidSyringe = 1766,
        ///<summary>Solid T</summary>
        ///<see href="https://fontawesome.com/icons/t?style=solid"/>
        [Description("Solid T"), IconID("fas-t"), IconUnicodeGlyph(0x54)]
        SolidT = 1767,
        ///<summary>Solid Table</summary>
        ///<see href="https://fontawesome.com/icons/table?style=solid"/>
        [Description("Solid Table"), IconID("fas-table"), IconUnicodeGlyph(0xf0ce)]
        SolidTable = 1768,
        ///<summary>Solid Table Cells</summary>
        ///<see href="https://fontawesome.com/icons/table-cells?style=solid"/>
        [Description("Solid Table Cells"), IconID("fas-table-cells"), IconUnicodeGlyph(0xf00a)]
        SolidTableCells = 1769,
        ///<summary>Solid Table Cells Column Lock</summary>
        ///<see href="https://fontawesome.com/icons/table-cells-column-lock?style=solid"/>
        [Description("Solid Table Cells Column Lock"), IconID("fas-table-cells-column-lock"), IconUnicodeGlyph(0xe678)]
        SolidTableCellsColumnLock = 1770,
        ///<summary>Solid Table Cells Large</summary>
        ///<see href="https://fontawesome.com/icons/table-cells-large?style=solid"/>
        [Description("Solid Table Cells Large"), IconID("fas-table-cells-large"), IconUnicodeGlyph(0xf009)]
        SolidTableCellsLarge = 1771,
        ///<summary>Solid Table Cells Row Lock</summary>
        ///<see href="https://fontawesome.com/icons/table-cells-row-lock?style=solid"/>
        [Description("Solid Table Cells Row Lock"), IconID("fas-table-cells-row-lock"), IconUnicodeGlyph(0xe67a)]
        SolidTableCellsRowLock = 1772,
        ///<summary>Solid Table Cells Row Unlock</summary>
        ///<see href="https://fontawesome.com/icons/table-cells-row-unlock?style=solid"/>
        [Description("Solid Table Cells Row Unlock"), IconID("fas-table-cells-row-unlock"), IconUnicodeGlyph(0xe691)]
        SolidTableCellsRowUnlock = 1773,
        ///<summary>Solid Table Columns</summary>
        ///<see href="https://fontawesome.com/icons/table-columns?style=solid"/>
        [Description("Solid Table Columns"), IconID("fas-table-columns"), IconUnicodeGlyph(0xf0db)]
        SolidTableColumns = 1774,
        ///<summary>Solid Table List</summary>
        ///<see href="https://fontawesome.com/icons/table-list?style=solid"/>
        [Description("Solid Table List"), IconID("fas-table-list"), IconUnicodeGlyph(0xf00b)]
        SolidTableList = 1775,
        ///<summary>Solid Table Tennis Paddle Ball</summary>
        ///<see href="https://fontawesome.com/icons/table-tennis-paddle-ball?style=solid"/>
        [Description("Solid Table Tennis Paddle Ball"), IconID("fas-table-tennis-paddle-ball"), IconUnicodeGlyph(0xf45d)]
        SolidTableTennisPaddleBall = 1776,
        ///<summary>Solid Tablet</summary>
        ///<see href="https://fontawesome.com/icons/tablet?style=solid"/>
        [Description("Solid Tablet"), IconID("fas-tablet"), IconUnicodeGlyph(0xf3fb)]
        SolidTablet = 1777,
        ///<summary>Solid Tablet Button</summary>
        ///<see href="https://fontawesome.com/icons/tablet-button?style=solid"/>
        [Description("Solid Tablet Button"), IconID("fas-tablet-button"), IconUnicodeGlyph(0xf10a)]
        SolidTabletButton = 1778,
        ///<summary>Solid Tablet Screen Button</summary>
        ///<see href="https://fontawesome.com/icons/tablet-screen-button?style=solid"/>
        [Description("Solid Tablet Screen Button"), IconID("fas-tablet-screen-button"), IconUnicodeGlyph(0xf3fa)]
        SolidTabletScreenButton = 1779,
        ///<summary>Solid Tablets</summary>
        ///<see href="https://fontawesome.com/icons/tablets?style=solid"/>
        [Description("Solid Tablets"), IconID("fas-tablets"), IconUnicodeGlyph(0xf490)]
        SolidTablets = 1780,
        ///<summary>Solid Tachograph Digital</summary>
        ///<see href="https://fontawesome.com/icons/tachograph-digital?style=solid"/>
        [Description("Solid Tachograph Digital"), IconID("fas-tachograph-digital"), IconUnicodeGlyph(0xf566)]
        SolidTachographDigital = 1781,
        ///<summary>Solid Tag</summary>
        ///<see href="https://fontawesome.com/icons/tag?style=solid"/>
        [Description("Solid Tag"), IconID("fas-tag"), IconUnicodeGlyph(0xf02b)]
        SolidTag = 1782,
        ///<summary>Solid Tags</summary>
        ///<see href="https://fontawesome.com/icons/tags?style=solid"/>
        [Description("Solid Tags"), IconID("fas-tags"), IconUnicodeGlyph(0xf02c)]
        SolidTags = 1783,
        ///<summary>Solid Tape</summary>
        ///<see href="https://fontawesome.com/icons/tape?style=solid"/>
        [Description("Solid Tape"), IconID("fas-tape"), IconUnicodeGlyph(0xf4db)]
        SolidTape = 1784,
        ///<summary>Solid Tarp</summary>
        ///<see href="https://fontawesome.com/icons/tarp?style=solid"/>
        [Description("Solid Tarp"), IconID("fas-tarp"), IconUnicodeGlyph(0xe57b)]
        SolidTarp = 1785,
        ///<summary>Solid Tarp Droplet</summary>
        ///<see href="https://fontawesome.com/icons/tarp-droplet?style=solid"/>
        [Description("Solid Tarp Droplet"), IconID("fas-tarp-droplet"), IconUnicodeGlyph(0xe57c)]
        SolidTarpDroplet = 1786,
        ///<summary>Solid Taxi</summary>
        ///<see href="https://fontawesome.com/icons/taxi?style=solid"/>
        [Description("Solid Taxi"), IconID("fas-taxi"), IconUnicodeGlyph(0xf1ba)]
        SolidTaxi = 1787,
        ///<summary>Brands Teamspeak</summary>
        ///<see href="https://fontawesome.com/icons/teamspeak?style=brands"/>
        [Description("Brands Teamspeak"), IconID("fab-teamspeak"), IconUnicodeGlyph(0xf4f9)]
        BrandsTeamspeak = 1788,
        ///<summary>Solid Teeth</summary>
        ///<see href="https://fontawesome.com/icons/teeth?style=solid"/>
        [Description("Solid Teeth"), IconID("fas-teeth"), IconUnicodeGlyph(0xf62e)]
        SolidTeeth = 1789,
        ///<summary>Solid Teeth Open</summary>
        ///<see href="https://fontawesome.com/icons/teeth-open?style=solid"/>
        [Description("Solid Teeth Open"), IconID("fas-teeth-open"), IconUnicodeGlyph(0xf62f)]
        SolidTeethOpen = 1790,
        ///<summary>Brands Telegram</summary>
        ///<see href="https://fontawesome.com/icons/telegram?style=brands"/>
        [Description("Brands Telegram"), IconID("fab-telegram"), IconUnicodeGlyph(0xf2c6)]
        BrandsTelegram = 1791,
        ///<summary>Solid Temperature Arrow Down</summary>
        ///<see href="https://fontawesome.com/icons/temperature-arrow-down?style=solid"/>
        [Description("Solid Temperature Arrow Down"), IconID("fas-temperature-arrow-down"), IconUnicodeGlyph(0xe03f)]
        SolidTemperatureArrowDown = 1792,
        ///<summary>Solid Temperature Arrow Up</summary>
        ///<see href="https://fontawesome.com/icons/temperature-arrow-up?style=solid"/>
        [Description("Solid Temperature Arrow Up"), IconID("fas-temperature-arrow-up"), IconUnicodeGlyph(0xe040)]
        SolidTemperatureArrowUp = 1793,
        ///<summary>Solid Temperature Empty</summary>
        ///<see href="https://fontawesome.com/icons/temperature-empty?style=solid"/>
        [Description("Solid Temperature Empty"), IconID("fas-temperature-empty"), IconUnicodeGlyph(0xf2cb)]
        SolidTemperatureEmpty = 1794,
        ///<summary>Solid Temperature Full</summary>
        ///<see href="https://fontawesome.com/icons/temperature-full?style=solid"/>
        [Description("Solid Temperature Full"), IconID("fas-temperature-full"), IconUnicodeGlyph(0xf2c7)]
        SolidTemperatureFull = 1795,
        ///<summary>Solid Temperature Half</summary>
        ///<see href="https://fontawesome.com/icons/temperature-half?style=solid"/>
        [Description("Solid Temperature Half"), IconID("fas-temperature-half"), IconUnicodeGlyph(0xf2c9)]
        SolidTemperatureHalf = 1796,
        ///<summary>Solid Temperature High</summary>
        ///<see href="https://fontawesome.com/icons/temperature-high?style=solid"/>
        [Description("Solid Temperature High"), IconID("fas-temperature-high"), IconUnicodeGlyph(0xf769)]
        SolidTemperatureHigh = 1797,
        ///<summary>Solid Temperature Low</summary>
        ///<see href="https://fontawesome.com/icons/temperature-low?style=solid"/>
        [Description("Solid Temperature Low"), IconID("fas-temperature-low"), IconUnicodeGlyph(0xf76b)]
        SolidTemperatureLow = 1798,
        ///<summary>Solid Temperature Quarter</summary>
        ///<see href="https://fontawesome.com/icons/temperature-quarter?style=solid"/>
        [Description("Solid Temperature Quarter"), IconID("fas-temperature-quarter"), IconUnicodeGlyph(0xf2ca)]
        SolidTemperatureQuarter = 1799,
        ///<summary>Solid Temperature Three Quarters</summary>
        ///<see href="https://fontawesome.com/icons/temperature-three-quarters?style=solid"/>
        [Description("Solid Temperature Three Quarters"), IconID("fas-temperature-three-quarters"), IconUnicodeGlyph(0xf2c8)]
        SolidTemperatureThreeQuarters = 1800,
        ///<summary>Brands Tencent Weibo</summary>
        ///<see href="https://fontawesome.com/icons/tencent-weibo?style=brands"/>
        [Description("Brands Tencent Weibo"), IconID("fab-tencent-weibo"), IconUnicodeGlyph(0xf1d5)]
        BrandsTencentWeibo = 1801,
        ///<summary>Solid Tenge Sign</summary>
        ///<see href="https://fontawesome.com/icons/tenge-sign?style=solid"/>
        [Description("Solid Tenge Sign"), IconID("fas-tenge-sign"), IconUnicodeGlyph(0xf7d7)]
        SolidTengeSign = 1802,
        ///<summary>Solid Tent</summary>
        ///<see href="https://fontawesome.com/icons/tent?style=solid"/>
        [Description("Solid Tent"), IconID("fas-tent"), IconUnicodeGlyph(0xe57d)]
        SolidTent = 1803,
        ///<summary>Solid Tent Arrow Down To Line</summary>
        ///<see href="https://fontawesome.com/icons/tent-arrow-down-to-line?style=solid"/>
        [Description("Solid Tent Arrow Down To Line"), IconID("fas-tent-arrow-down-to-line"), IconUnicodeGlyph(0xe57e)]
        SolidTentArrowDownToLine = 1804,
        ///<summary>Solid Tent Arrow Left Right</summary>
        ///<see href="https://fontawesome.com/icons/tent-arrow-left-right?style=solid"/>
        [Description("Solid Tent Arrow Left Right"), IconID("fas-tent-arrow-left-right"), IconUnicodeGlyph(0xe57f)]
        SolidTentArrowLeftRight = 1805,
        ///<summary>Solid Tent Arrow Turn Left</summary>
        ///<see href="https://fontawesome.com/icons/tent-arrow-turn-left?style=solid"/>
        [Description("Solid Tent Arrow Turn Left"), IconID("fas-tent-arrow-turn-left"), IconUnicodeGlyph(0xe580)]
        SolidTentArrowTurnLeft = 1806,
        ///<summary>Solid Tent Arrows Down</summary>
        ///<see href="https://fontawesome.com/icons/tent-arrows-down?style=solid"/>
        [Description("Solid Tent Arrows Down"), IconID("fas-tent-arrows-down"), IconUnicodeGlyph(0xe581)]
        SolidTentArrowsDown = 1807,
        ///<summary>Solid Tents</summary>
        ///<see href="https://fontawesome.com/icons/tents?style=solid"/>
        [Description("Solid Tents"), IconID("fas-tents"), IconUnicodeGlyph(0xe582)]
        SolidTents = 1808,
        ///<summary>Solid Terminal</summary>
        ///<see href="https://fontawesome.com/icons/terminal?style=solid"/>
        [Description("Solid Terminal"), IconID("fas-terminal"), IconUnicodeGlyph(0xf120)]
        SolidTerminal = 1809,
        ///<summary>Solid Text Height</summary>
        ///<see href="https://fontawesome.com/icons/text-height?style=solid"/>
        [Description("Solid Text Height"), IconID("fas-text-height"), IconUnicodeGlyph(0xf034)]
        SolidTextHeight = 1810,
        ///<summary>Solid Text Slash</summary>
        ///<see href="https://fontawesome.com/icons/text-slash?style=solid"/>
        [Description("Solid Text Slash"), IconID("fas-text-slash"), IconUnicodeGlyph(0xf87d)]
        SolidTextSlash = 1811,
        ///<summary>Solid Text Width</summary>
        ///<see href="https://fontawesome.com/icons/text-width?style=solid"/>
        [Description("Solid Text Width"), IconID("fas-text-width"), IconUnicodeGlyph(0xf035)]
        SolidTextWidth = 1812,
        ///<summary>Brands The Red Yeti</summary>
        ///<see href="https://fontawesome.com/icons/the-red-yeti?style=brands"/>
        [Description("Brands The Red Yeti"), IconID("fab-the-red-yeti"), IconUnicodeGlyph(0xf69d)]
        BrandsTheRedYeti = 1813,
        ///<summary>Brands Themeco</summary>
        ///<see href="https://fontawesome.com/icons/themeco?style=brands"/>
        [Description("Brands Themeco"), IconID("fab-themeco"), IconUnicodeGlyph(0xf5c6)]
        BrandsThemeco = 1814,
        ///<summary>Brands ThemeIsle</summary>
        ///<see href="https://fontawesome.com/icons/themeisle?style=brands"/>
        [Description("Brands ThemeIsle"), IconID("fab-themeisle"), IconUnicodeGlyph(0xf2b2)]
        BrandsThemeisle = 1815,
        ///<summary>Solid Thermometer</summary>
        ///<see href="https://fontawesome.com/icons/thermometer?style=solid"/>
        [Description("Solid Thermometer"), IconID("fas-thermometer"), IconUnicodeGlyph(0xf491)]
        SolidThermometer = 1816,
        ///<summary>Brands Think Peaks</summary>
        ///<see href="https://fontawesome.com/icons/think-peaks?style=brands"/>
        [Description("Brands Think Peaks"), IconID("fab-think-peaks"), IconUnicodeGlyph(0xf731)]
        BrandsThinkPeaks = 1817,
        ///<summary>Brands Threads</summary>
        ///<see href="https://fontawesome.com/icons/threads?style=brands"/>
        [Description("Brands Threads"), IconID("fab-threads"), IconUnicodeGlyph(0xe618)]
        BrandsThreads = 1818,
        ///<summary>Solid Thumbs Down</summary>
        ///<see href="https://fontawesome.com/icons/thumbs-down?style=solid"/>
        [Description("Solid Thumbs Down"), IconID("fas-thumbs-down"), IconUnicodeGlyph(0xf165)]
        SolidThumbsDown = 1819,
        ///<summary>Regular Thumbs Down</summary>
        ///<see href="https://fontawesome.com/icons/thumbs-down?style=regular"/>
        [Description("Regular Thumbs Down"), IconID("far-thumbs-down"), IconUnicodeGlyph(0xf165)]
        RegularThumbsDown = 1820,
        ///<summary>Solid Thumbs Up</summary>
        ///<see href="https://fontawesome.com/icons/thumbs-up?style=solid"/>
        [Description("Solid Thumbs Up"), IconID("fas-thumbs-up"), IconUnicodeGlyph(0xf164)]
        SolidThumbsUp = 1821,
        ///<summary>Regular Thumbs Up</summary>
        ///<see href="https://fontawesome.com/icons/thumbs-up?style=regular"/>
        [Description("Regular Thumbs Up"), IconID("far-thumbs-up"), IconUnicodeGlyph(0xf164)]
        RegularThumbsUp = 1822,
        ///<summary>Solid Thumbtack</summary>
        ///<see href="https://fontawesome.com/icons/thumbtack?style=solid"/>
        [Description("Solid Thumbtack"), IconID("fas-thumbtack"), IconUnicodeGlyph(0xf08d)]
        SolidThumbtack = 1823,
        ///<summary>Solid Thumbtack Slash</summary>
        ///<see href="https://fontawesome.com/icons/thumbtack-slash?style=solid"/>
        [Description("Solid Thumbtack Slash"), IconID("fas-thumbtack-slash"), IconUnicodeGlyph(0xe68f)]
        SolidThumbtackSlash = 1824,
        ///<summary>Solid Ticket</summary>
        ///<see href="https://fontawesome.com/icons/ticket?style=solid"/>
        [Description("Solid Ticket"), IconID("fas-ticket"), IconUnicodeGlyph(0xf145)]
        SolidTicket = 1825,
        ///<summary>Solid Ticket Simple</summary>
        ///<see href="https://fontawesome.com/icons/ticket-simple?style=solid"/>
        [Description("Solid Ticket Simple"), IconID("fas-ticket-simple"), IconUnicodeGlyph(0xf3ff)]
        SolidTicketSimple = 1826,
        ///<summary>Brands TikTok</summary>
        ///<see href="https://fontawesome.com/icons/tiktok?style=brands"/>
        [Description("Brands TikTok"), IconID("fab-tiktok"), IconUnicodeGlyph(0xe07b)]
        BrandsTiktok = 1827,
        ///<summary>Solid Timeline</summary>
        ///<see href="https://fontawesome.com/icons/timeline?style=solid"/>
        [Description("Solid Timeline"), IconID("fas-timeline"), IconUnicodeGlyph(0xe29c)]
        SolidTimeline = 1828,
        ///<summary>Solid Toggle Off</summary>
        ///<see href="https://fontawesome.com/icons/toggle-off?style=solid"/>
        [Description("Solid Toggle Off"), IconID("fas-toggle-off"), IconUnicodeGlyph(0xf204)]
        SolidToggleOff = 1829,
        ///<summary>Solid Toggle On</summary>
        ///<see href="https://fontawesome.com/icons/toggle-on?style=solid"/>
        [Description("Solid Toggle On"), IconID("fas-toggle-on"), IconUnicodeGlyph(0xf205)]
        SolidToggleOn = 1830,
        ///<summary>Solid Toilet</summary>
        ///<see href="https://fontawesome.com/icons/toilet?style=solid"/>
        [Description("Solid Toilet"), IconID("fas-toilet"), IconUnicodeGlyph(0xf7d8)]
        SolidToilet = 1831,
        ///<summary>Solid Toilet Paper</summary>
        ///<see href="https://fontawesome.com/icons/toilet-paper?style=solid"/>
        [Description("Solid Toilet Paper"), IconID("fas-toilet-paper"), IconUnicodeGlyph(0xf71e)]
        SolidToiletPaper = 1832,
        ///<summary>Solid Toilet Paper Slash</summary>
        ///<see href="https://fontawesome.com/icons/toilet-paper-slash?style=solid"/>
        [Description("Solid Toilet Paper Slash"), IconID("fas-toilet-paper-slash"), IconUnicodeGlyph(0xe072)]
        SolidToiletPaperSlash = 1833,
        ///<summary>Solid Toilet Portable</summary>
        ///<see href="https://fontawesome.com/icons/toilet-portable?style=solid"/>
        [Description("Solid Toilet Portable"), IconID("fas-toilet-portable"), IconUnicodeGlyph(0xe583)]
        SolidToiletPortable = 1834,
        ///<summary>Solid Toilets Portable</summary>
        ///<see href="https://fontawesome.com/icons/toilets-portable?style=solid"/>
        [Description("Solid Toilets Portable"), IconID("fas-toilets-portable"), IconUnicodeGlyph(0xe584)]
        SolidToiletsPortable = 1835,
        ///<summary>Solid Toolbox</summary>
        ///<see href="https://fontawesome.com/icons/toolbox?style=solid"/>
        [Description("Solid Toolbox"), IconID("fas-toolbox"), IconUnicodeGlyph(0xf552)]
        SolidToolbox = 1836,
        ///<summary>Solid Tooth</summary>
        ///<see href="https://fontawesome.com/icons/tooth?style=solid"/>
        [Description("Solid Tooth"), IconID("fas-tooth"), IconUnicodeGlyph(0xf5c9)]
        SolidTooth = 1837,
        ///<summary>Solid Torii Gate</summary>
        ///<see href="https://fontawesome.com/icons/torii-gate?style=solid"/>
        [Description("Solid Torii Gate"), IconID("fas-torii-gate"), IconUnicodeGlyph(0xf6a1)]
        SolidToriiGate = 1838,
        ///<summary>Solid Tornado</summary>
        ///<see href="https://fontawesome.com/icons/tornado?style=solid"/>
        [Description("Solid Tornado"), IconID("fas-tornado"), IconUnicodeGlyph(0xf76f)]
        SolidTornado = 1839,
        ///<summary>Solid Tower Broadcast</summary>
        ///<see href="https://fontawesome.com/icons/tower-broadcast?style=solid"/>
        [Description("Solid Tower Broadcast"), IconID("fas-tower-broadcast"), IconUnicodeGlyph(0xf519)]
        SolidTowerBroadcast = 1840,
        ///<summary>Solid Tower Cell</summary>
        ///<see href="https://fontawesome.com/icons/tower-cell?style=solid"/>
        [Description("Solid Tower Cell"), IconID("fas-tower-cell"), IconUnicodeGlyph(0xe585)]
        SolidTowerCell = 1841,
        ///<summary>Solid Tower Observation</summary>
        ///<see href="https://fontawesome.com/icons/tower-observation?style=solid"/>
        [Description("Solid Tower Observation"), IconID("fas-tower-observation"), IconUnicodeGlyph(0xe586)]
        SolidTowerObservation = 1842,
        ///<summary>Solid Tractor</summary>
        ///<see href="https://fontawesome.com/icons/tractor?style=solid"/>
        [Description("Solid Tractor"), IconID("fas-tractor"), IconUnicodeGlyph(0xf722)]
        SolidTractor = 1843,
        ///<summary>Brands Trade Federation</summary>
        ///<see href="https://fontawesome.com/icons/trade-federation?style=brands"/>
        [Description("Brands Trade Federation"), IconID("fab-trade-federation"), IconUnicodeGlyph(0xf513)]
        BrandsTradeFederation = 1844,
        ///<summary>Solid Trademark</summary>
        ///<see href="https://fontawesome.com/icons/trademark?style=solid"/>
        [Description("Solid Trademark"), IconID("fas-trademark"), IconUnicodeGlyph(0xf25c)]
        SolidTrademark = 1845,
        ///<summary>Solid Traffic Light</summary>
        ///<see href="https://fontawesome.com/icons/traffic-light?style=solid"/>
        [Description("Solid Traffic Light"), IconID("fas-traffic-light"), IconUnicodeGlyph(0xf637)]
        SolidTrafficLight = 1846,
        ///<summary>Solid Trailer</summary>
        ///<see href="https://fontawesome.com/icons/trailer?style=solid"/>
        [Description("Solid Trailer"), IconID("fas-trailer"), IconUnicodeGlyph(0xe041)]
        SolidTrailer = 1847,
        ///<summary>Solid Train</summary>
        ///<see href="https://fontawesome.com/icons/train?style=solid"/>
        [Description("Solid Train"), IconID("fas-train"), IconUnicodeGlyph(0xf238)]
        SolidTrain = 1848,
        ///<summary>Solid Train Subway</summary>
        ///<see href="https://fontawesome.com/icons/train-subway?style=solid"/>
        [Description("Solid Train Subway"), IconID("fas-train-subway"), IconUnicodeGlyph(0xf239)]
        SolidTrainSubway = 1849,
        ///<summary>Solid Train Tram</summary>
        ///<see href="https://fontawesome.com/icons/train-tram?style=solid"/>
        [Description("Solid Train Tram"), IconID("fas-train-tram"), IconUnicodeGlyph(0xe5b4)]
        SolidTrainTram = 1850,
        ///<summary>Solid Transgender</summary>
        ///<see href="https://fontawesome.com/icons/transgender?style=solid"/>
        [Description("Solid Transgender"), IconID("fas-transgender"), IconUnicodeGlyph(0xf225)]
        SolidTransgender = 1851,
        ///<summary>Solid Trash</summary>
        ///<see href="https://fontawesome.com/icons/trash?style=solid"/>
        [Description("Solid Trash"), IconID("fas-trash"), IconUnicodeGlyph(0xf1f8)]
        SolidTrash = 1852,
        ///<summary>Solid Trash Arrow Up</summary>
        ///<see href="https://fontawesome.com/icons/trash-arrow-up?style=solid"/>
        [Description("Solid Trash Arrow Up"), IconID("fas-trash-arrow-up"), IconUnicodeGlyph(0xf829)]
        SolidTrashArrowUp = 1853,
        ///<summary>Solid Trash Can</summary>
        ///<see href="https://fontawesome.com/icons/trash-can?style=solid"/>
        [Description("Solid Trash Can"), IconID("fas-trash-can"), IconUnicodeGlyph(0xf2ed)]
        SolidTrashCan = 1854,
        ///<summary>Regular Trash Can</summary>
        ///<see href="https://fontawesome.com/icons/trash-can?style=regular"/>
        [Description("Regular Trash Can"), IconID("far-trash-can"), IconUnicodeGlyph(0xf2ed)]
        RegularTrashCan = 1855,
        ///<summary>Solid Trash Can Arrow Up</summary>
        ///<see href="https://fontawesome.com/icons/trash-can-arrow-up?style=solid"/>
        [Description("Solid Trash Can Arrow Up"), IconID("fas-trash-can-arrow-up"), IconUnicodeGlyph(0xf82a)]
        SolidTrashCanArrowUp = 1856,
        ///<summary>Solid Tree</summary>
        ///<see href="https://fontawesome.com/icons/tree?style=solid"/>
        [Description("Solid Tree"), IconID("fas-tree"), IconUnicodeGlyph(0xf1bb)]
        SolidTree = 1857,
        ///<summary>Solid Tree City</summary>
        ///<see href="https://fontawesome.com/icons/tree-city?style=solid"/>
        [Description("Solid Tree City"), IconID("fas-tree-city"), IconUnicodeGlyph(0xe587)]
        SolidTreeCity = 1858,
        ///<summary>Brands Trello</summary>
        ///<see href="https://fontawesome.com/icons/trello?style=brands"/>
        [Description("Brands Trello"), IconID("fab-trello"), IconUnicodeGlyph(0xf181)]
        BrandsTrello = 1859,
        ///<summary>Solid Triangle Exclamation</summary>
        ///<see href="https://fontawesome.com/icons/triangle-exclamation?style=solid"/>
        [Description("Solid Triangle Exclamation"), IconID("fas-triangle-exclamation"), IconUnicodeGlyph(0xf071)]
        SolidTriangleExclamation = 1860,
        ///<summary>Solid Trophy</summary>
        ///<see href="https://fontawesome.com/icons/trophy?style=solid"/>
        [Description("Solid Trophy"), IconID("fas-trophy"), IconUnicodeGlyph(0xf091)]
        SolidTrophy = 1861,
        ///<summary>Solid Trowel</summary>
        ///<see href="https://fontawesome.com/icons/trowel?style=solid"/>
        [Description("Solid Trowel"), IconID("fas-trowel"), IconUnicodeGlyph(0xe589)]
        SolidTrowel = 1862,
        ///<summary>Solid Trowel Bricks</summary>
        ///<see href="https://fontawesome.com/icons/trowel-bricks?style=solid"/>
        [Description("Solid Trowel Bricks"), IconID("fas-trowel-bricks"), IconUnicodeGlyph(0xe58a)]
        SolidTrowelBricks = 1863,
        ///<summary>Solid Truck</summary>
        ///<see href="https://fontawesome.com/icons/truck?style=solid"/>
        [Description("Solid Truck"), IconID("fas-truck"), IconUnicodeGlyph(0xf0d1)]
        SolidTruck = 1864,
        ///<summary>Solid Truck Arrow Right</summary>
        ///<see href="https://fontawesome.com/icons/truck-arrow-right?style=solid"/>
        [Description("Solid Truck Arrow Right"), IconID("fas-truck-arrow-right"), IconUnicodeGlyph(0xe58b)]
        SolidTruckArrowRight = 1865,
        ///<summary>Solid Truck Droplet</summary>
        ///<see href="https://fontawesome.com/icons/truck-droplet?style=solid"/>
        [Description("Solid Truck Droplet"), IconID("fas-truck-droplet"), IconUnicodeGlyph(0xe58c)]
        SolidTruckDroplet = 1866,
        ///<summary>Solid Truck Fast</summary>
        ///<see href="https://fontawesome.com/icons/truck-fast?style=solid"/>
        [Description("Solid Truck Fast"), IconID("fas-truck-fast"), IconUnicodeGlyph(0xf48b)]
        SolidTruckFast = 1867,
        ///<summary>Solid Truck Field</summary>
        ///<see href="https://fontawesome.com/icons/truck-field?style=solid"/>
        [Description("Solid Truck Field"), IconID("fas-truck-field"), IconUnicodeGlyph(0xe58d)]
        SolidTruckField = 1868,
        ///<summary>Solid Truck Field Un</summary>
        ///<see href="https://fontawesome.com/icons/truck-field-un?style=solid"/>
        [Description("Solid Truck Field Un"), IconID("fas-truck-field-un"), IconUnicodeGlyph(0xe58e)]
        SolidTruckFieldUn = 1869,
        ///<summary>Solid Truck Front</summary>
        ///<see href="https://fontawesome.com/icons/truck-front?style=solid"/>
        [Description("Solid Truck Front"), IconID("fas-truck-front"), IconUnicodeGlyph(0xe2b7)]
        SolidTruckFront = 1870,
        ///<summary>Solid Truck Medical</summary>
        ///<see href="https://fontawesome.com/icons/truck-medical?style=solid"/>
        [Description("Solid Truck Medical"), IconID("fas-truck-medical"), IconUnicodeGlyph(0xf0f9)]
        SolidTruckMedical = 1871,
        ///<summary>Solid Truck Monster</summary>
        ///<see href="https://fontawesome.com/icons/truck-monster?style=solid"/>
        [Description("Solid Truck Monster"), IconID("fas-truck-monster"), IconUnicodeGlyph(0xf63b)]
        SolidTruckMonster = 1872,
        ///<summary>Solid Truck Moving</summary>
        ///<see href="https://fontawesome.com/icons/truck-moving?style=solid"/>
        [Description("Solid Truck Moving"), IconID("fas-truck-moving"), IconUnicodeGlyph(0xf4df)]
        SolidTruckMoving = 1873,
        ///<summary>Solid Truck Pickup</summary>
        ///<see href="https://fontawesome.com/icons/truck-pickup?style=solid"/>
        [Description("Solid Truck Pickup"), IconID("fas-truck-pickup"), IconUnicodeGlyph(0xf63c)]
        SolidTruckPickup = 1874,
        ///<summary>Solid Truck Plane</summary>
        ///<see href="https://fontawesome.com/icons/truck-plane?style=solid"/>
        [Description("Solid Truck Plane"), IconID("fas-truck-plane"), IconUnicodeGlyph(0xe58f)]
        SolidTruckPlane = 1875,
        ///<summary>Solid Truck Ramp Box</summary>
        ///<see href="https://fontawesome.com/icons/truck-ramp-box?style=solid"/>
        [Description("Solid Truck Ramp Box"), IconID("fas-truck-ramp-box"), IconUnicodeGlyph(0xf4de)]
        SolidTruckRampBox = 1876,
        ///<summary>Solid Tty</summary>
        ///<see href="https://fontawesome.com/icons/tty?style=solid"/>
        [Description("Solid Tty"), IconID("fas-tty"), IconUnicodeGlyph(0xf1e4)]
        SolidTty = 1877,
        ///<summary>Brands Tumblr</summary>
        ///<see href="https://fontawesome.com/icons/tumblr?style=brands"/>
        [Description("Brands Tumblr"), IconID("fab-tumblr"), IconUnicodeGlyph(0xf173)]
        BrandsTumblr = 1878,
        ///<summary>Solid Turkish Lira Sign</summary>
        ///<see href="https://fontawesome.com/icons/turkish-lira-sign?style=solid"/>
        [Description("Solid Turkish Lira Sign"), IconID("fas-turkish-lira-sign"), IconUnicodeGlyph(0xe2bb)]
        SolidTurkishLiraSign = 1879,
        ///<summary>Solid Turn Down</summary>
        ///<see href="https://fontawesome.com/icons/turn-down?style=solid"/>
        [Description("Solid Turn Down"), IconID("fas-turn-down"), IconUnicodeGlyph(0xf3be)]
        SolidTurnDown = 1880,
        ///<summary>Solid Turn Up</summary>
        ///<see href="https://fontawesome.com/icons/turn-up?style=solid"/>
        [Description("Solid Turn Up"), IconID("fas-turn-up"), IconUnicodeGlyph(0xf3bf)]
        SolidTurnUp = 1881,
        ///<summary>Solid Tv</summary>
        ///<see href="https://fontawesome.com/icons/tv?style=solid"/>
        [Description("Solid Tv"), IconID("fas-tv"), IconUnicodeGlyph(0xf26c)]
        SolidTv = 1882,
        ///<summary>Brands Twitch</summary>
        ///<see href="https://fontawesome.com/icons/twitch?style=brands"/>
        [Description("Brands Twitch"), IconID("fab-twitch"), IconUnicodeGlyph(0xf1e8)]
        BrandsTwitch = 1883,
        ///<summary>Brands Twitter</summary>
        ///<see href="https://fontawesome.com/icons/twitter?style=brands"/>
        [Description("Brands Twitter"), IconID("fab-twitter"), IconUnicodeGlyph(0xf099)]
        BrandsTwitter = 1884,
        ///<summary>Brands Typo3</summary>
        ///<see href="https://fontawesome.com/icons/typo3?style=brands"/>
        [Description("Brands Typo3"), IconID("fab-typo3"), IconUnicodeGlyph(0xf42b)]
        BrandsTypo3 = 1885,
        ///<summary>Solid U</summary>
        ///<see href="https://fontawesome.com/icons/u?style=solid"/>
        [Description("Solid U"), IconID("fas-u"), IconUnicodeGlyph(0x55)]
        SolidU = 1886,
        ///<summary>Brands Uber</summary>
        ///<see href="https://fontawesome.com/icons/uber?style=brands"/>
        [Description("Brands Uber"), IconID("fab-uber"), IconUnicodeGlyph(0xf402)]
        BrandsUber = 1887,
        ///<summary>Brands Ubuntu</summary>
        ///<see href="https://fontawesome.com/icons/ubuntu?style=brands"/>
        [Description("Brands Ubuntu"), IconID("fab-ubuntu"), IconUnicodeGlyph(0xf7df)]
        BrandsUbuntu = 1888,
        ///<summary>Brands UIkit</summary>
        ///<see href="https://fontawesome.com/icons/uikit?style=brands"/>
        [Description("Brands UIkit"), IconID("fab-uikit"), IconUnicodeGlyph(0xf403)]
        BrandsUikit = 1889,
        ///<summary>Brands Umbraco</summary>
        ///<see href="https://fontawesome.com/icons/umbraco?style=brands"/>
        [Description("Brands Umbraco"), IconID("fab-umbraco"), IconUnicodeGlyph(0xf8e8)]
        BrandsUmbraco = 1890,
        ///<summary>Solid Umbrella</summary>
        ///<see href="https://fontawesome.com/icons/umbrella?style=solid"/>
        [Description("Solid Umbrella"), IconID("fas-umbrella"), IconUnicodeGlyph(0xf0e9)]
        SolidUmbrella = 1891,
        ///<summary>Solid Umbrella Beach</summary>
        ///<see href="https://fontawesome.com/icons/umbrella-beach?style=solid"/>
        [Description("Solid Umbrella Beach"), IconID("fas-umbrella-beach"), IconUnicodeGlyph(0xf5ca)]
        SolidUmbrellaBeach = 1892,
        ///<summary>Brands Uncharted Software</summary>
        ///<see href="https://fontawesome.com/icons/uncharted?style=brands"/>
        [Description("Brands Uncharted Software"), IconID("fab-uncharted"), IconUnicodeGlyph(0xe084)]
        BrandsUncharted = 1893,
        ///<summary>Solid Underline</summary>
        ///<see href="https://fontawesome.com/icons/underline?style=solid"/>
        [Description("Solid Underline"), IconID("fas-underline"), IconUnicodeGlyph(0xf0cd)]
        SolidUnderline = 1894,
        ///<summary>Brands Uniregistry</summary>
        ///<see href="https://fontawesome.com/icons/uniregistry?style=brands"/>
        [Description("Brands Uniregistry"), IconID("fab-uniregistry"), IconUnicodeGlyph(0xf404)]
        BrandsUniregistry = 1895,
        ///<summary>Brands Unity 3D</summary>
        ///<see href="https://fontawesome.com/icons/unity?style=brands"/>
        [Description("Brands Unity 3D"), IconID("fab-unity"), IconUnicodeGlyph(0xe049)]
        BrandsUnity = 1896,
        ///<summary>Solid Universal Access</summary>
        ///<see href="https://fontawesome.com/icons/universal-access?style=solid"/>
        [Description("Solid Universal Access"), IconID("fas-universal-access"), IconUnicodeGlyph(0xf29a)]
        SolidUniversalAccess = 1897,
        ///<summary>Solid Unlock</summary>
        ///<see href="https://fontawesome.com/icons/unlock?style=solid"/>
        [Description("Solid Unlock"), IconID("fas-unlock"), IconUnicodeGlyph(0xf09c)]
        SolidUnlock = 1898,
        ///<summary>Solid Unlock Keyhole</summary>
        ///<see href="https://fontawesome.com/icons/unlock-keyhole?style=solid"/>
        [Description("Solid Unlock Keyhole"), IconID("fas-unlock-keyhole"), IconUnicodeGlyph(0xf13e)]
        SolidUnlockKeyhole = 1899,
        ///<summary>Brands Unsplash</summary>
        ///<see href="https://fontawesome.com/icons/unsplash?style=brands"/>
        [Description("Brands Unsplash"), IconID("fab-unsplash"), IconUnicodeGlyph(0xe07c)]
        BrandsUnsplash = 1900,
        ///<summary>Brands Untappd</summary>
        ///<see href="https://fontawesome.com/icons/untappd?style=brands"/>
        [Description("Brands Untappd"), IconID("fab-untappd"), IconUnicodeGlyph(0xf405)]
        BrandsUntappd = 1901,
        ///<summary>Solid Up Down</summary>
        ///<see href="https://fontawesome.com/icons/up-down?style=solid"/>
        [Description("Solid Up Down"), IconID("fas-up-down"), IconUnicodeGlyph(0xf338)]
        SolidUpDown = 1902,
        ///<summary>Solid Up Down Left Right</summary>
        ///<see href="https://fontawesome.com/icons/up-down-left-right?style=solid"/>
        [Description("Solid Up Down Left Right"), IconID("fas-up-down-left-right"), IconUnicodeGlyph(0xf0b2)]
        SolidUpDownLeftRight = 1903,
        ///<summary>Solid Up Long</summary>
        ///<see href="https://fontawesome.com/icons/up-long?style=solid"/>
        [Description("Solid Up Long"), IconID("fas-up-long"), IconUnicodeGlyph(0xf30c)]
        SolidUpLong = 1904,
        ///<summary>Solid Up Right And Down Left From Center</summary>
        ///<see href="https://fontawesome.com/icons/up-right-and-down-left-from-center?style=solid"/>
        [Description("Solid Up Right And Down Left From Center"), IconID("fas-up-right-and-down-left-from-center"), IconUnicodeGlyph(0xf424)]
        SolidUpRightAndDownLeftFromCenter = 1905,
        ///<summary>Solid Up Right From Square</summary>
        ///<see href="https://fontawesome.com/icons/up-right-from-square?style=solid"/>
        [Description("Solid Up Right From Square"), IconID("fas-up-right-from-square"), IconUnicodeGlyph(0xf35d)]
        SolidUpRightFromSquare = 1906,
        ///<summary>Solid Upload</summary>
        ///<see href="https://fontawesome.com/icons/upload?style=solid"/>
        [Description("Solid Upload"), IconID("fas-upload"), IconUnicodeGlyph(0xf093)]
        SolidUpload = 1907,
        ///<summary>Brands UPS</summary>
        ///<see href="https://fontawesome.com/icons/ups?style=brands"/>
        [Description("Brands UPS"), IconID("fab-ups"), IconUnicodeGlyph(0xf7e0)]
        BrandsUps = 1908,
        ///<summary>Brands Upwork</summary>
        ///<see href="https://fontawesome.com/icons/upwork?style=brands"/>
        [Description("Brands Upwork"), IconID("fab-upwork"), IconUnicodeGlyph(0xe641)]
        BrandsUpwork = 1909,
        ///<summary>Brands USB</summary>
        ///<see href="https://fontawesome.com/icons/usb?style=brands"/>
        [Description("Brands USB"), IconID("fab-usb"), IconUnicodeGlyph(0xf287)]
        BrandsUsb = 1910,
        ///<summary>Solid User</summary>
        ///<see href="https://fontawesome.com/icons/user?style=solid"/>
        [Description("Solid User"), IconID("fas-user"), IconUnicodeGlyph(0xf007)]
        SolidUser = 1911,
        ///<summary>Regular User</summary>
        ///<see href="https://fontawesome.com/icons/user?style=regular"/>
        [Description("Regular User"), IconID("far-user"), IconUnicodeGlyph(0xf007)]
        RegularUser = 1912,
        ///<summary>Solid User Astronaut</summary>
        ///<see href="https://fontawesome.com/icons/user-astronaut?style=solid"/>
        [Description("Solid User Astronaut"), IconID("fas-user-astronaut"), IconUnicodeGlyph(0xf4fb)]
        SolidUserAstronaut = 1913,
        ///<summary>Solid User Check</summary>
        ///<see href="https://fontawesome.com/icons/user-check?style=solid"/>
        [Description("Solid User Check"), IconID("fas-user-check"), IconUnicodeGlyph(0xf4fc)]
        SolidUserCheck = 1914,
        ///<summary>Solid User Clock</summary>
        ///<see href="https://fontawesome.com/icons/user-clock?style=solid"/>
        [Description("Solid User Clock"), IconID("fas-user-clock"), IconUnicodeGlyph(0xf4fd)]
        SolidUserClock = 1915,
        ///<summary>Solid User Doctor</summary>
        ///<see href="https://fontawesome.com/icons/user-doctor?style=solid"/>
        [Description("Solid User Doctor"), IconID("fas-user-doctor"), IconUnicodeGlyph(0xf0f0)]
        SolidUserDoctor = 1916,
        ///<summary>Solid User Gear</summary>
        ///<see href="https://fontawesome.com/icons/user-gear?style=solid"/>
        [Description("Solid User Gear"), IconID("fas-user-gear"), IconUnicodeGlyph(0xf4fe)]
        SolidUserGear = 1917,
        ///<summary>Solid User Graduate</summary>
        ///<see href="https://fontawesome.com/icons/user-graduate?style=solid"/>
        [Description("Solid User Graduate"), IconID("fas-user-graduate"), IconUnicodeGlyph(0xf501)]
        SolidUserGraduate = 1918,
        ///<summary>Solid User Group</summary>
        ///<see href="https://fontawesome.com/icons/user-group?style=solid"/>
        [Description("Solid User Group"), IconID("fas-user-group"), IconUnicodeGlyph(0xf500)]
        SolidUserGroup = 1919,
        ///<summary>Solid User Injured</summary>
        ///<see href="https://fontawesome.com/icons/user-injured?style=solid"/>
        [Description("Solid User Injured"), IconID("fas-user-injured"), IconUnicodeGlyph(0xf728)]
        SolidUserInjured = 1920,
        ///<summary>Solid User Large</summary>
        ///<see href="https://fontawesome.com/icons/user-large?style=solid"/>
        [Description("Solid User Large"), IconID("fas-user-large"), IconUnicodeGlyph(0xf406)]
        SolidUserLarge = 1921,
        ///<summary>Solid User Large Slash</summary>
        ///<see href="https://fontawesome.com/icons/user-large-slash?style=solid"/>
        [Description("Solid User Large Slash"), IconID("fas-user-large-slash"), IconUnicodeGlyph(0xf4fa)]
        SolidUserLargeSlash = 1922,
        ///<summary>Solid User Lock</summary>
        ///<see href="https://fontawesome.com/icons/user-lock?style=solid"/>
        [Description("Solid User Lock"), IconID("fas-user-lock"), IconUnicodeGlyph(0xf502)]
        SolidUserLock = 1923,
        ///<summary>Solid User Minus</summary>
        ///<see href="https://fontawesome.com/icons/user-minus?style=solid"/>
        [Description("Solid User Minus"), IconID("fas-user-minus"), IconUnicodeGlyph(0xf503)]
        SolidUserMinus = 1924,
        ///<summary>Solid User Ninja</summary>
        ///<see href="https://fontawesome.com/icons/user-ninja?style=solid"/>
        [Description("Solid User Ninja"), IconID("fas-user-ninja"), IconUnicodeGlyph(0xf504)]
        SolidUserNinja = 1925,
        ///<summary>Solid User Nurse</summary>
        ///<see href="https://fontawesome.com/icons/user-nurse?style=solid"/>
        [Description("Solid User Nurse"), IconID("fas-user-nurse"), IconUnicodeGlyph(0xf82f)]
        SolidUserNurse = 1926,
        ///<summary>Solid User Pen</summary>
        ///<see href="https://fontawesome.com/icons/user-pen?style=solid"/>
        [Description("Solid User Pen"), IconID("fas-user-pen"), IconUnicodeGlyph(0xf4ff)]
        SolidUserPen = 1927,
        ///<summary>Solid User Plus</summary>
        ///<see href="https://fontawesome.com/icons/user-plus?style=solid"/>
        [Description("Solid User Plus"), IconID("fas-user-plus"), IconUnicodeGlyph(0xf234)]
        SolidUserPlus = 1928,
        ///<summary>Solid User Secret</summary>
        ///<see href="https://fontawesome.com/icons/user-secret?style=solid"/>
        [Description("Solid User Secret"), IconID("fas-user-secret"), IconUnicodeGlyph(0xf21b)]
        SolidUserSecret = 1929,
        ///<summary>Solid User Shield</summary>
        ///<see href="https://fontawesome.com/icons/user-shield?style=solid"/>
        [Description("Solid User Shield"), IconID("fas-user-shield"), IconUnicodeGlyph(0xf505)]
        SolidUserShield = 1930,
        ///<summary>Solid User Slash</summary>
        ///<see href="https://fontawesome.com/icons/user-slash?style=solid"/>
        [Description("Solid User Slash"), IconID("fas-user-slash"), IconUnicodeGlyph(0xf506)]
        SolidUserSlash = 1931,
        ///<summary>Solid User Tag</summary>
        ///<see href="https://fontawesome.com/icons/user-tag?style=solid"/>
        [Description("Solid User Tag"), IconID("fas-user-tag"), IconUnicodeGlyph(0xf507)]
        SolidUserTag = 1932,
        ///<summary>Solid User Tie</summary>
        ///<see href="https://fontawesome.com/icons/user-tie?style=solid"/>
        [Description("Solid User Tie"), IconID("fas-user-tie"), IconUnicodeGlyph(0xf508)]
        SolidUserTie = 1933,
        ///<summary>Solid User Xmark</summary>
        ///<see href="https://fontawesome.com/icons/user-xmark?style=solid"/>
        [Description("Solid User Xmark"), IconID("fas-user-xmark"), IconUnicodeGlyph(0xf235)]
        SolidUserXmark = 1934,
        ///<summary>Solid Users</summary>
        ///<see href="https://fontawesome.com/icons/users?style=solid"/>
        [Description("Solid Users"), IconID("fas-users"), IconUnicodeGlyph(0xf0c0)]
        SolidUsers = 1935,
        ///<summary>Solid Users Between Lines</summary>
        ///<see href="https://fontawesome.com/icons/users-between-lines?style=solid"/>
        [Description("Solid Users Between Lines"), IconID("fas-users-between-lines"), IconUnicodeGlyph(0xe591)]
        SolidUsersBetweenLines = 1936,
        ///<summary>Solid Users Gear</summary>
        ///<see href="https://fontawesome.com/icons/users-gear?style=solid"/>
        [Description("Solid Users Gear"), IconID("fas-users-gear"), IconUnicodeGlyph(0xf509)]
        SolidUsersGear = 1937,
        ///<summary>Solid Users Line</summary>
        ///<see href="https://fontawesome.com/icons/users-line?style=solid"/>
        [Description("Solid Users Line"), IconID("fas-users-line"), IconUnicodeGlyph(0xe592)]
        SolidUsersLine = 1938,
        ///<summary>Solid Users Rays</summary>
        ///<see href="https://fontawesome.com/icons/users-rays?style=solid"/>
        [Description("Solid Users Rays"), IconID("fas-users-rays"), IconUnicodeGlyph(0xe593)]
        SolidUsersRays = 1939,
        ///<summary>Solid Users Rectangle</summary>
        ///<see href="https://fontawesome.com/icons/users-rectangle?style=solid"/>
        [Description("Solid Users Rectangle"), IconID("fas-users-rectangle"), IconUnicodeGlyph(0xe594)]
        SolidUsersRectangle = 1940,
        ///<summary>Solid Users Slash</summary>
        ///<see href="https://fontawesome.com/icons/users-slash?style=solid"/>
        [Description("Solid Users Slash"), IconID("fas-users-slash"), IconUnicodeGlyph(0xe073)]
        SolidUsersSlash = 1941,
        ///<summary>Solid Users Viewfinder</summary>
        ///<see href="https://fontawesome.com/icons/users-viewfinder?style=solid"/>
        [Description("Solid Users Viewfinder"), IconID("fas-users-viewfinder"), IconUnicodeGlyph(0xe595)]
        SolidUsersViewfinder = 1942,
        ///<summary>Brands United States Postal Service</summary>
        ///<see href="https://fontawesome.com/icons/usps?style=brands"/>
        [Description("Brands United States Postal Service"), IconID("fab-usps"), IconUnicodeGlyph(0xf7e1)]
        BrandsUsps = 1943,
        ///<summary>Brands us-Sunnah Foundation</summary>
        ///<see href="https://fontawesome.com/icons/ussunnah?style=brands"/>
        [Description("Brands us-Sunnah Foundation"), IconID("fab-ussunnah"), IconUnicodeGlyph(0xf407)]
        BrandsUssunnah = 1944,
        ///<summary>Solid Utensils</summary>
        ///<see href="https://fontawesome.com/icons/utensils?style=solid"/>
        [Description("Solid Utensils"), IconID("fas-utensils"), IconUnicodeGlyph(0xf2e7)]
        SolidUtensils = 1945,
        ///<summary>Solid V</summary>
        ///<see href="https://fontawesome.com/icons/v?style=solid"/>
        [Description("Solid V"), IconID("fas-v"), IconUnicodeGlyph(0x56)]
        SolidV = 1946,
        ///<summary>Brands Vaadin</summary>
        ///<see href="https://fontawesome.com/icons/vaadin?style=brands"/>
        [Description("Brands Vaadin"), IconID("fab-vaadin"), IconUnicodeGlyph(0xf408)]
        BrandsVaadin = 1947,
        ///<summary>Solid Van Shuttle</summary>
        ///<see href="https://fontawesome.com/icons/van-shuttle?style=solid"/>
        [Description("Solid Van Shuttle"), IconID("fas-van-shuttle"), IconUnicodeGlyph(0xf5b6)]
        SolidVanShuttle = 1948,
        ///<summary>Solid Vault</summary>
        ///<see href="https://fontawesome.com/icons/vault?style=solid"/>
        [Description("Solid Vault"), IconID("fas-vault"), IconUnicodeGlyph(0xe2c5)]
        SolidVault = 1949,
        ///<summary>Solid Vector Square</summary>
        ///<see href="https://fontawesome.com/icons/vector-square?style=solid"/>
        [Description("Solid Vector Square"), IconID("fas-vector-square"), IconUnicodeGlyph(0xf5cb)]
        SolidVectorSquare = 1950,
        ///<summary>Solid Venus</summary>
        ///<see href="https://fontawesome.com/icons/venus?style=solid"/>
        [Description("Solid Venus"), IconID("fas-venus"), IconUnicodeGlyph(0xf221)]
        SolidVenus = 1951,
        ///<summary>Solid Venus Double</summary>
        ///<see href="https://fontawesome.com/icons/venus-double?style=solid"/>
        [Description("Solid Venus Double"), IconID("fas-venus-double"), IconUnicodeGlyph(0xf226)]
        SolidVenusDouble = 1952,
        ///<summary>Solid Venus Mars</summary>
        ///<see href="https://fontawesome.com/icons/venus-mars?style=solid"/>
        [Description("Solid Venus Mars"), IconID("fas-venus-mars"), IconUnicodeGlyph(0xf228)]
        SolidVenusMars = 1953,
        ///<summary>Solid Vest</summary>
        ///<see href="https://fontawesome.com/icons/vest?style=solid"/>
        [Description("Solid Vest"), IconID("fas-vest"), IconUnicodeGlyph(0xe085)]
        SolidVest = 1954,
        ///<summary>Solid Vest Patches</summary>
        ///<see href="https://fontawesome.com/icons/vest-patches?style=solid"/>
        [Description("Solid Vest Patches"), IconID("fas-vest-patches"), IconUnicodeGlyph(0xe086)]
        SolidVestPatches = 1955,
        ///<summary>Brands Viacoin</summary>
        ///<see href="https://fontawesome.com/icons/viacoin?style=brands"/>
        [Description("Brands Viacoin"), IconID("fab-viacoin"), IconUnicodeGlyph(0xf237)]
        BrandsViacoin = 1956,
        ///<summary>Brands Viadeo</summary>
        ///<see href="https://fontawesome.com/icons/viadeo?style=brands"/>
        [Description("Brands Viadeo"), IconID("fab-viadeo"), IconUnicodeGlyph(0xf2a9)]
        BrandsViadeo = 1957,
        ///<summary>Solid Vial</summary>
        ///<see href="https://fontawesome.com/icons/vial?style=solid"/>
        [Description("Solid Vial"), IconID("fas-vial"), IconUnicodeGlyph(0xf492)]
        SolidVial = 1958,
        ///<summary>Solid Vial Circle Check</summary>
        ///<see href="https://fontawesome.com/icons/vial-circle-check?style=solid"/>
        [Description("Solid Vial Circle Check"), IconID("fas-vial-circle-check"), IconUnicodeGlyph(0xe596)]
        SolidVialCircleCheck = 1959,
        ///<summary>Solid Vial Virus</summary>
        ///<see href="https://fontawesome.com/icons/vial-virus?style=solid"/>
        [Description("Solid Vial Virus"), IconID("fas-vial-virus"), IconUnicodeGlyph(0xe597)]
        SolidVialVirus = 1960,
        ///<summary>Solid Vials</summary>
        ///<see href="https://fontawesome.com/icons/vials?style=solid"/>
        [Description("Solid Vials"), IconID("fas-vials"), IconUnicodeGlyph(0xf493)]
        SolidVials = 1961,
        ///<summary>Brands Viber</summary>
        ///<see href="https://fontawesome.com/icons/viber?style=brands"/>
        [Description("Brands Viber"), IconID("fab-viber"), IconUnicodeGlyph(0xf409)]
        BrandsViber = 1962,
        ///<summary>Solid Video</summary>
        ///<see href="https://fontawesome.com/icons/video?style=solid"/>
        [Description("Solid Video"), IconID("fas-video"), IconUnicodeGlyph(0xf03d)]
        SolidVideo = 1963,
        ///<summary>Solid Video Slash</summary>
        ///<see href="https://fontawesome.com/icons/video-slash?style=solid"/>
        [Description("Solid Video Slash"), IconID("fas-video-slash"), IconUnicodeGlyph(0xf4e2)]
        SolidVideoSlash = 1964,
        ///<summary>Solid Vihara</summary>
        ///<see href="https://fontawesome.com/icons/vihara?style=solid"/>
        [Description("Solid Vihara"), IconID("fas-vihara"), IconUnicodeGlyph(0xf6a7)]
        SolidVihara = 1965,
        ///<summary>Brands Vimeo</summary>
        ///<see href="https://fontawesome.com/icons/vimeo?style=brands"/>
        [Description("Brands Vimeo"), IconID("fab-vimeo"), IconUnicodeGlyph(0xf40a)]
        BrandsVimeo = 1966,
        ///<summary>Brands Vimeo V</summary>
        ///<see href="https://fontawesome.com/icons/vimeo-v?style=brands"/>
        [Description("Brands Vimeo V"), IconID("fab-vimeo-v"), IconUnicodeGlyph(0xf27d)]
        BrandsVimeoV = 1967,
        ///<summary>Brands Vine</summary>
        ///<see href="https://fontawesome.com/icons/vine?style=brands"/>
        [Description("Brands Vine"), IconID("fab-vine"), IconUnicodeGlyph(0xf1ca)]
        BrandsVine = 1968,
        ///<summary>Solid Virus</summary>
        ///<see href="https://fontawesome.com/icons/virus?style=solid"/>
        [Description("Solid Virus"), IconID("fas-virus"), IconUnicodeGlyph(0xe074)]
        SolidVirus = 1969,
        ///<summary>Solid Virus Covid</summary>
        ///<see href="https://fontawesome.com/icons/virus-covid?style=solid"/>
        [Description("Solid Virus Covid"), IconID("fas-virus-covid"), IconUnicodeGlyph(0xe4a8)]
        SolidVirusCovid = 1970,
        ///<summary>Solid Virus Covid Slash</summary>
        ///<see href="https://fontawesome.com/icons/virus-covid-slash?style=solid"/>
        [Description("Solid Virus Covid Slash"), IconID("fas-virus-covid-slash"), IconUnicodeGlyph(0xe4a9)]
        SolidVirusCovidSlash = 1971,
        ///<summary>Solid Virus Slash</summary>
        ///<see href="https://fontawesome.com/icons/virus-slash?style=solid"/>
        [Description("Solid Virus Slash"), IconID("fas-virus-slash"), IconUnicodeGlyph(0xe075)]
        SolidVirusSlash = 1972,
        ///<summary>Solid Viruses</summary>
        ///<see href="https://fontawesome.com/icons/viruses?style=solid"/>
        [Description("Solid Viruses"), IconID("fas-viruses"), IconUnicodeGlyph(0xe076)]
        SolidViruses = 1973,
        ///<summary>Brands VK</summary>
        ///<see href="https://fontawesome.com/icons/vk?style=brands"/>
        [Description("Brands VK"), IconID("fab-vk"), IconUnicodeGlyph(0xf189)]
        BrandsVk = 1974,
        ///<summary>Brands VNV</summary>
        ///<see href="https://fontawesome.com/icons/vnv?style=brands"/>
        [Description("Brands VNV"), IconID("fab-vnv"), IconUnicodeGlyph(0xf40b)]
        BrandsVnv = 1975,
        ///<summary>Solid Voicemail</summary>
        ///<see href="https://fontawesome.com/icons/voicemail?style=solid"/>
        [Description("Solid Voicemail"), IconID("fas-voicemail"), IconUnicodeGlyph(0xf897)]
        SolidVoicemail = 1976,
        ///<summary>Solid Volcano</summary>
        ///<see href="https://fontawesome.com/icons/volcano?style=solid"/>
        [Description("Solid Volcano"), IconID("fas-volcano"), IconUnicodeGlyph(0xf770)]
        SolidVolcano = 1977,
        ///<summary>Solid Volleyball</summary>
        ///<see href="https://fontawesome.com/icons/volleyball?style=solid"/>
        [Description("Solid Volleyball"), IconID("fas-volleyball"), IconUnicodeGlyph(0xf45f)]
        SolidVolleyball = 1978,
        ///<summary>Solid Volume High</summary>
        ///<see href="https://fontawesome.com/icons/volume-high?style=solid"/>
        [Description("Solid Volume High"), IconID("fas-volume-high"), IconUnicodeGlyph(0xf028)]
        SolidVolumeHigh = 1979,
        ///<summary>Solid Volume Low</summary>
        ///<see href="https://fontawesome.com/icons/volume-low?style=solid"/>
        [Description("Solid Volume Low"), IconID("fas-volume-low"), IconUnicodeGlyph(0xf027)]
        SolidVolumeLow = 1980,
        ///<summary>Solid Volume Off</summary>
        ///<see href="https://fontawesome.com/icons/volume-off?style=solid"/>
        [Description("Solid Volume Off"), IconID("fas-volume-off"), IconUnicodeGlyph(0xf026)]
        SolidVolumeOff = 1981,
        ///<summary>Solid Volume Xmark</summary>
        ///<see href="https://fontawesome.com/icons/volume-xmark?style=solid"/>
        [Description("Solid Volume Xmark"), IconID("fas-volume-xmark"), IconUnicodeGlyph(0xf6a9)]
        SolidVolumeXmark = 1982,
        ///<summary>Solid Vr Cardboard</summary>
        ///<see href="https://fontawesome.com/icons/vr-cardboard?style=solid"/>
        [Description("Solid Vr Cardboard"), IconID("fas-vr-cardboard"), IconUnicodeGlyph(0xf729)]
        SolidVrCardboard = 1983,
        ///<summary>Brands Vue.js</summary>
        ///<see href="https://fontawesome.com/icons/vuejs?style=brands"/>
        [Description("Brands Vue.js"), IconID("fab-vuejs"), IconUnicodeGlyph(0xf41f)]
        BrandsVuejs = 1984,
        ///<summary>Solid W</summary>
        ///<see href="https://fontawesome.com/icons/w?style=solid"/>
        [Description("Solid W"), IconID("fas-w"), IconUnicodeGlyph(0x57)]
        SolidW = 1985,
        ///<summary>Solid Walkie Talkie</summary>
        ///<see href="https://fontawesome.com/icons/walkie-talkie?style=solid"/>
        [Description("Solid Walkie Talkie"), IconID("fas-walkie-talkie"), IconUnicodeGlyph(0xf8ef)]
        SolidWalkieTalkie = 1986,
        ///<summary>Solid Wallet</summary>
        ///<see href="https://fontawesome.com/icons/wallet?style=solid"/>
        [Description("Solid Wallet"), IconID("fas-wallet"), IconUnicodeGlyph(0xf555)]
        SolidWallet = 1987,
        ///<summary>Solid Wand Magic</summary>
        ///<see href="https://fontawesome.com/icons/wand-magic?style=solid"/>
        [Description("Solid Wand Magic"), IconID("fas-wand-magic"), IconUnicodeGlyph(0xf0d0)]
        SolidWandMagic = 1988,
        ///<summary>Solid Wand Magic Sparkles</summary>
        ///<see href="https://fontawesome.com/icons/wand-magic-sparkles?style=solid"/>
        [Description("Solid Wand Magic Sparkles"), IconID("fas-wand-magic-sparkles"), IconUnicodeGlyph(0xe2ca)]
        SolidWandMagicSparkles = 1989,
        ///<summary>Solid Wand Sparkles</summary>
        ///<see href="https://fontawesome.com/icons/wand-sparkles?style=solid"/>
        [Description("Solid Wand Sparkles"), IconID("fas-wand-sparkles"), IconUnicodeGlyph(0xf72b)]
        SolidWandSparkles = 1990,
        ///<summary>Solid Warehouse</summary>
        ///<see href="https://fontawesome.com/icons/warehouse?style=solid"/>
        [Description("Solid Warehouse"), IconID("fas-warehouse"), IconUnicodeGlyph(0xf494)]
        SolidWarehouse = 1991,
        ///<summary>Brands Watchman Monitoring</summary>
        ///<see href="https://fontawesome.com/icons/watchman-monitoring?style=brands"/>
        [Description("Brands Watchman Monitoring"), IconID("fab-watchman-monitoring"), IconUnicodeGlyph(0xe087)]
        BrandsWatchmanMonitoring = 1992,
        ///<summary>Solid Water</summary>
        ///<see href="https://fontawesome.com/icons/water?style=solid"/>
        [Description("Solid Water"), IconID("fas-water"), IconUnicodeGlyph(0xf773)]
        SolidWater = 1993,
        ///<summary>Solid Water Ladder</summary>
        ///<see href="https://fontawesome.com/icons/water-ladder?style=solid"/>
        [Description("Solid Water Ladder"), IconID("fas-water-ladder"), IconUnicodeGlyph(0xf5c5)]
        SolidWaterLadder = 1994,
        ///<summary>Solid Wave Square</summary>
        ///<see href="https://fontawesome.com/icons/wave-square?style=solid"/>
        [Description("Solid Wave Square"), IconID("fas-wave-square"), IconUnicodeGlyph(0xf83e)]
        SolidWaveSquare = 1995,
        ///<summary>Brands Waze</summary>
        ///<see href="https://fontawesome.com/icons/waze?style=brands"/>
        [Description("Brands Waze"), IconID("fab-waze"), IconUnicodeGlyph(0xf83f)]
        BrandsWaze = 1996,
        ///<summary>Solid Web Awesome</summary>
        ///<see href="https://fontawesome.com/icons/web-awesome?style=solid"/>
        [Description("Solid Web Awesome"), IconID("fas-web-awesome"), IconUnicodeGlyph(0xe682)]
        SolidWebAwesome = 1997,
        ///<summary>Brands Web Awesome</summary>
        ///<see href="https://fontawesome.com/icons/web-awesome?style=brands"/>
        [Description("Brands Web Awesome"), IconID("fab-web-awesome"), IconUnicodeGlyph(0xe682)]
        BrandsWebAwesome = 1998,
        ///<summary>Brands Webflow</summary>
        ///<see href="https://fontawesome.com/icons/webflow?style=brands"/>
        [Description("Brands Webflow"), IconID("fab-webflow"), IconUnicodeGlyph(0xe65c)]
        BrandsWebflow = 1999,
        ///<summary>Brands Weebly</summary>
        ///<see href="https://fontawesome.com/icons/weebly?style=brands"/>
        [Description("Brands Weebly"), IconID("fab-weebly"), IconUnicodeGlyph(0xf5cc)]
        BrandsWeebly = 2000,
        ///<summary>Brands Weibo</summary>
        ///<see href="https://fontawesome.com/icons/weibo?style=brands"/>
        [Description("Brands Weibo"), IconID("fab-weibo"), IconUnicodeGlyph(0xf18a)]
        BrandsWeibo = 2001,
        ///<summary>Solid Weight Hanging</summary>
        ///<see href="https://fontawesome.com/icons/weight-hanging?style=solid"/>
        [Description("Solid Weight Hanging"), IconID("fas-weight-hanging"), IconUnicodeGlyph(0xf5cd)]
        SolidWeightHanging = 2002,
        ///<summary>Solid Weight Scale</summary>
        ///<see href="https://fontawesome.com/icons/weight-scale?style=solid"/>
        [Description("Solid Weight Scale"), IconID("fas-weight-scale"), IconUnicodeGlyph(0xf496)]
        SolidWeightScale = 2003,
        ///<summary>Brands Weixin (WeChat)</summary>
        ///<see href="https://fontawesome.com/icons/weixin?style=brands"/>
        [Description("Brands Weixin (WeChat)"), IconID("fab-weixin"), IconUnicodeGlyph(0xf1d7)]
        BrandsWeixin = 2004,
        ///<summary>Brands What's App</summary>
        ///<see href="https://fontawesome.com/icons/whatsapp?style=brands"/>
        [Description("Brands What's App"), IconID("fab-whatsapp"), IconUnicodeGlyph(0xf232)]
        BrandsWhatsapp = 2005,
        ///<summary>Solid Wheat Awn</summary>
        ///<see href="https://fontawesome.com/icons/wheat-awn?style=solid"/>
        [Description("Solid Wheat Awn"), IconID("fas-wheat-awn"), IconUnicodeGlyph(0xe2cd)]
        SolidWheatAwn = 2006,
        ///<summary>Solid Wheat Awn Circle Exclamation</summary>
        ///<see href="https://fontawesome.com/icons/wheat-awn-circle-exclamation?style=solid"/>
        [Description("Solid Wheat Awn Circle Exclamation"), IconID("fas-wheat-awn-circle-exclamation"), IconUnicodeGlyph(0xe598)]
        SolidWheatAwnCircleExclamation = 2007,
        ///<summary>Solid Wheelchair</summary>
        ///<see href="https://fontawesome.com/icons/wheelchair?style=solid"/>
        [Description("Solid Wheelchair"), IconID("fas-wheelchair"), IconUnicodeGlyph(0xf193)]
        SolidWheelchair = 2008,
        ///<summary>Solid Wheelchair Move</summary>
        ///<see href="https://fontawesome.com/icons/wheelchair-move?style=solid"/>
        [Description("Solid Wheelchair Move"), IconID("fas-wheelchair-move"), IconUnicodeGlyph(0xe2ce)]
        SolidWheelchairMove = 2009,
        ///<summary>Solid Whiskey Glass</summary>
        ///<see href="https://fontawesome.com/icons/whiskey-glass?style=solid"/>
        [Description("Solid Whiskey Glass"), IconID("fas-whiskey-glass"), IconUnicodeGlyph(0xf7a0)]
        SolidWhiskeyGlass = 2010,
        ///<summary>Brands WHMCS</summary>
        ///<see href="https://fontawesome.com/icons/whmcs?style=brands"/>
        [Description("Brands WHMCS"), IconID("fab-whmcs"), IconUnicodeGlyph(0xf40d)]
        BrandsWhmcs = 2011,
        ///<summary>Solid Wifi</summary>
        ///<see href="https://fontawesome.com/icons/wifi?style=solid"/>
        [Description("Solid Wifi"), IconID("fas-wifi"), IconUnicodeGlyph(0xf1eb)]
        SolidWifi = 2012,
        ///<summary>Brands Wikipedia W</summary>
        ///<see href="https://fontawesome.com/icons/wikipedia-w?style=brands"/>
        [Description("Brands Wikipedia W"), IconID("fab-wikipedia-w"), IconUnicodeGlyph(0xf266)]
        BrandsWikipediaW = 2013,
        ///<summary>Solid Wind</summary>
        ///<see href="https://fontawesome.com/icons/wind?style=solid"/>
        [Description("Solid Wind"), IconID("fas-wind"), IconUnicodeGlyph(0xf72e)]
        SolidWind = 2014,
        ///<summary>Solid Window Maximize</summary>
        ///<see href="https://fontawesome.com/icons/window-maximize?style=solid"/>
        [Description("Solid Window Maximize"), IconID("fas-window-maximize"), IconUnicodeGlyph(0xf2d0)]
        SolidWindowMaximize = 2015,
        ///<summary>Regular Window Maximize</summary>
        ///<see href="https://fontawesome.com/icons/window-maximize?style=regular"/>
        [Description("Regular Window Maximize"), IconID("far-window-maximize"), IconUnicodeGlyph(0xf2d0)]
        RegularWindowMaximize = 2016,
        ///<summary>Solid Window Minimize</summary>
        ///<see href="https://fontawesome.com/icons/window-minimize?style=solid"/>
        [Description("Solid Window Minimize"), IconID("fas-window-minimize"), IconUnicodeGlyph(0xf2d1)]
        SolidWindowMinimize = 2017,
        ///<summary>Regular Window Minimize</summary>
        ///<see href="https://fontawesome.com/icons/window-minimize?style=regular"/>
        [Description("Regular Window Minimize"), IconID("far-window-minimize"), IconUnicodeGlyph(0xf2d1)]
        RegularWindowMinimize = 2018,
        ///<summary>Solid Window Restore</summary>
        ///<see href="https://fontawesome.com/icons/window-restore?style=solid"/>
        [Description("Solid Window Restore"), IconID("fas-window-restore"), IconUnicodeGlyph(0xf2d2)]
        SolidWindowRestore = 2019,
        ///<summary>Regular Window Restore</summary>
        ///<see href="https://fontawesome.com/icons/window-restore?style=regular"/>
        [Description("Regular Window Restore"), IconID("far-window-restore"), IconUnicodeGlyph(0xf2d2)]
        RegularWindowRestore = 2020,
        ///<summary>Brands Windows</summary>
        ///<see href="https://fontawesome.com/icons/windows?style=brands"/>
        [Description("Brands Windows"), IconID("fab-windows"), IconUnicodeGlyph(0xf17a)]
        BrandsWindows = 2021,
        ///<summary>Solid Wine Bottle</summary>
        ///<see href="https://fontawesome.com/icons/wine-bottle?style=solid"/>
        [Description("Solid Wine Bottle"), IconID("fas-wine-bottle"), IconUnicodeGlyph(0xf72f)]
        SolidWineBottle = 2022,
        ///<summary>Solid Wine Glass</summary>
        ///<see href="https://fontawesome.com/icons/wine-glass?style=solid"/>
        [Description("Solid Wine Glass"), IconID("fas-wine-glass"), IconUnicodeGlyph(0xf4e3)]
        SolidWineGlass = 2023,
        ///<summary>Solid Wine Glass Empty</summary>
        ///<see href="https://fontawesome.com/icons/wine-glass-empty?style=solid"/>
        [Description("Solid Wine Glass Empty"), IconID("fas-wine-glass-empty"), IconUnicodeGlyph(0xf5ce)]
        SolidWineGlassEmpty = 2024,
        ///<summary>Brands wirsindhandwerk</summary>
        ///<see href="https://fontawesome.com/icons/wirsindhandwerk?style=brands"/>
        [Description("Brands wirsindhandwerk"), IconID("fab-wirsindhandwerk"), IconUnicodeGlyph(0xe2d0)]
        BrandsWirsindhandwerk = 2025,
        ///<summary>Brands Wix</summary>
        ///<see href="https://fontawesome.com/icons/wix?style=brands"/>
        [Description("Brands Wix"), IconID("fab-wix"), IconUnicodeGlyph(0xf5cf)]
        BrandsWix = 2026,
        ///<summary>Brands Wizards of the Coast</summary>
        ///<see href="https://fontawesome.com/icons/wizards-of-the-coast?style=brands"/>
        [Description("Brands Wizards of the Coast"), IconID("fab-wizards-of-the-coast"), IconUnicodeGlyph(0xf730)]
        BrandsWizardsOfTheCoast = 2027,
        ///<summary>Brands Wodu</summary>
        ///<see href="https://fontawesome.com/icons/wodu?style=brands"/>
        [Description("Brands Wodu"), IconID("fab-wodu"), IconUnicodeGlyph(0xe088)]
        BrandsWodu = 2028,
        ///<summary>Brands Wolf Pack Battalion</summary>
        ///<see href="https://fontawesome.com/icons/wolf-pack-battalion?style=brands"/>
        [Description("Brands Wolf Pack Battalion"), IconID("fab-wolf-pack-battalion"), IconUnicodeGlyph(0xf514)]
        BrandsWolfPackBattalion = 2029,
        ///<summary>Solid Won Sign</summary>
        ///<see href="https://fontawesome.com/icons/won-sign?style=solid"/>
        [Description("Solid Won Sign"), IconID("fas-won-sign"), IconUnicodeGlyph(0xf159)]
        SolidWonSign = 2030,
        ///<summary>Brands WordPress Logo</summary>
        ///<see href="https://fontawesome.com/icons/wordpress?style=brands"/>
        [Description("Brands WordPress Logo"), IconID("fab-wordpress"), IconUnicodeGlyph(0xf19a)]
        BrandsWordpress = 2031,
        ///<summary>Brands Wordpress Simple</summary>
        ///<see href="https://fontawesome.com/icons/wordpress-simple?style=brands"/>
        [Description("Brands Wordpress Simple"), IconID("fab-wordpress-simple"), IconUnicodeGlyph(0xf411)]
        BrandsWordpressSimple = 2032,
        ///<summary>Solid Worm</summary>
        ///<see href="https://fontawesome.com/icons/worm?style=solid"/>
        [Description("Solid Worm"), IconID("fas-worm"), IconUnicodeGlyph(0xe599)]
        SolidWorm = 2033,
        ///<summary>Brands WPBeginner</summary>
        ///<see href="https://fontawesome.com/icons/wpbeginner?style=brands"/>
        [Description("Brands WPBeginner"), IconID("fab-wpbeginner"), IconUnicodeGlyph(0xf297)]
        BrandsWpbeginner = 2034,
        ///<summary>Brands WPExplorer</summary>
        ///<see href="https://fontawesome.com/icons/wpexplorer?style=brands"/>
        [Description("Brands WPExplorer"), IconID("fab-wpexplorer"), IconUnicodeGlyph(0xf2de)]
        BrandsWpexplorer = 2035,
        ///<summary>Brands WPForms</summary>
        ///<see href="https://fontawesome.com/icons/wpforms?style=brands"/>
        [Description("Brands WPForms"), IconID("fab-wpforms"), IconUnicodeGlyph(0xf298)]
        BrandsWpforms = 2036,
        ///<summary>Brands wpressr</summary>
        ///<see href="https://fontawesome.com/icons/wpressr?style=brands"/>
        [Description("Brands wpressr"), IconID("fab-wpressr"), IconUnicodeGlyph(0xf3e4)]
        BrandsWpressr = 2037,
        ///<summary>Solid Wrench</summary>
        ///<see href="https://fontawesome.com/icons/wrench?style=solid"/>
        [Description("Solid Wrench"), IconID("fas-wrench"), IconUnicodeGlyph(0xf0ad)]
        SolidWrench = 2038,
        ///<summary>Solid X</summary>
        ///<see href="https://fontawesome.com/icons/x?style=solid"/>
        [Description("Solid X"), IconID("fas-x"), IconUnicodeGlyph(0x58)]
        SolidX = 2039,
        ///<summary>Solid X Ray</summary>
        ///<see href="https://fontawesome.com/icons/x-ray?style=solid"/>
        [Description("Solid X Ray"), IconID("fas-x-ray"), IconUnicodeGlyph(0xf497)]
        SolidXRay = 2040,
        ///<summary>Brands X Twitter</summary>
        ///<see href="https://fontawesome.com/icons/x-twitter?style=brands"/>
        [Description("Brands X Twitter"), IconID("fab-x-twitter"), IconUnicodeGlyph(0xe61b)]
        BrandsXTwitter = 2041,
        ///<summary>Brands Xbox</summary>
        ///<see href="https://fontawesome.com/icons/xbox?style=brands"/>
        [Description("Brands Xbox"), IconID("fab-xbox"), IconUnicodeGlyph(0xf412)]
        BrandsXbox = 2042,
        ///<summary>Brands Xing</summary>
        ///<see href="https://fontawesome.com/icons/xing?style=brands"/>
        [Description("Brands Xing"), IconID("fab-xing"), IconUnicodeGlyph(0xf168)]
        BrandsXing = 2043,
        ///<summary>Solid Xmark</summary>
        ///<see href="https://fontawesome.com/icons/xmark?style=solid"/>
        [Description("Solid Xmark"), IconID("fas-xmark"), IconUnicodeGlyph(0xf00d)]
        SolidXmark = 2044,
        ///<summary>Solid Xmarks Lines</summary>
        ///<see href="https://fontawesome.com/icons/xmarks-lines?style=solid"/>
        [Description("Solid Xmarks Lines"), IconID("fas-xmarks-lines"), IconUnicodeGlyph(0xe59a)]
        SolidXmarksLines = 2045,
        ///<summary>Solid Y</summary>
        ///<see href="https://fontawesome.com/icons/y?style=solid"/>
        [Description("Solid Y"), IconID("fas-y"), IconUnicodeGlyph(0x59)]
        SolidY = 2046,
        ///<summary>Brands Y Combinator</summary>
        ///<see href="https://fontawesome.com/icons/y-combinator?style=brands"/>
        [Description("Brands Y Combinator"), IconID("fab-y-combinator"), IconUnicodeGlyph(0xf23b)]
        BrandsYCombinator = 2047,
        ///<summary>Brands Yahoo Logo</summary>
        ///<see href="https://fontawesome.com/icons/yahoo?style=brands"/>
        [Description("Brands Yahoo Logo"), IconID("fab-yahoo"), IconUnicodeGlyph(0xf19e)]
        BrandsYahoo = 2048,
        ///<summary>Brands Yammer</summary>
        ///<see href="https://fontawesome.com/icons/yammer?style=brands"/>
        [Description("Brands Yammer"), IconID("fab-yammer"), IconUnicodeGlyph(0xf840)]
        BrandsYammer = 2049,
        ///<summary>Brands Yandex</summary>
        ///<see href="https://fontawesome.com/icons/yandex?style=brands"/>
        [Description("Brands Yandex"), IconID("fab-yandex"), IconUnicodeGlyph(0xf413)]
        BrandsYandex = 2050,
        ///<summary>Brands Yandex International</summary>
        ///<see href="https://fontawesome.com/icons/yandex-international?style=brands"/>
        [Description("Brands Yandex International"), IconID("fab-yandex-international"), IconUnicodeGlyph(0xf414)]
        BrandsYandexInternational = 2051,
        ///<summary>Brands Yarn</summary>
        ///<see href="https://fontawesome.com/icons/yarn?style=brands"/>
        [Description("Brands Yarn"), IconID("fab-yarn"), IconUnicodeGlyph(0xf7e3)]
        BrandsYarn = 2052,
        ///<summary>Brands Yelp</summary>
        ///<see href="https://fontawesome.com/icons/yelp?style=brands"/>
        [Description("Brands Yelp"), IconID("fab-yelp"), IconUnicodeGlyph(0xf1e9)]
        BrandsYelp = 2053,
        ///<summary>Solid Yen Sign</summary>
        ///<see href="https://fontawesome.com/icons/yen-sign?style=solid"/>
        [Description("Solid Yen Sign"), IconID("fas-yen-sign"), IconUnicodeGlyph(0xf157)]
        SolidYenSign = 2054,
        ///<summary>Solid Yin Yang</summary>
        ///<see href="https://fontawesome.com/icons/yin-yang?style=solid"/>
        [Description("Solid Yin Yang"), IconID("fas-yin-yang"), IconUnicodeGlyph(0xf6ad)]
        SolidYinYang = 2055,
        ///<summary>Brands Yoast</summary>
        ///<see href="https://fontawesome.com/icons/yoast?style=brands"/>
        [Description("Brands Yoast"), IconID("fab-yoast"), IconUnicodeGlyph(0xf2b1)]
        BrandsYoast = 2056,
        ///<summary>Brands YouTube</summary>
        ///<see href="https://fontawesome.com/icons/youtube?style=brands"/>
        [Description("Brands YouTube"), IconID("fab-youtube"), IconUnicodeGlyph(0xf167)]
        BrandsYoutube = 2057,
        ///<summary>Solid Z</summary>
        ///<see href="https://fontawesome.com/icons/z?style=solid"/>
        [Description("Solid Z"), IconID("fas-z"), IconUnicodeGlyph(0x5a)]
        SolidZ = 2058,
        ///<summary>Brands Zhihu</summary>
        ///<see href="https://fontawesome.com/icons/zhihu?style=brands"/>
        [Description("Brands Zhihu"), IconID("fab-zhihu"), IconUnicodeGlyph(0xf63f)]
        BrandsZhihu = 2059
    }
}
