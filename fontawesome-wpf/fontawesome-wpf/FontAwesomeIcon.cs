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
        ///<summary>Solid align-center</summary>
        ///<see href="https://fontawesome.com/icons/align-center?style=solid"/>
        [Description("Solid align-center"), IconID("fas-align-center"), IconUnicodeGlyph(0xf037)]
        SolidAlignCenter = 24,
        ///<summary>Solid align-justify</summary>
        ///<see href="https://fontawesome.com/icons/align-justify?style=solid"/>
        [Description("Solid align-justify"), IconID("fas-align-justify"), IconUnicodeGlyph(0xf039)]
        SolidAlignJustify = 25,
        ///<summary>Solid align-left</summary>
        ///<see href="https://fontawesome.com/icons/align-left?style=solid"/>
        [Description("Solid align-left"), IconID("fas-align-left"), IconUnicodeGlyph(0xf036)]
        SolidAlignLeft = 26,
        ///<summary>Solid align-right</summary>
        ///<see href="https://fontawesome.com/icons/align-right?style=solid"/>
        [Description("Solid align-right"), IconID("fas-align-right"), IconUnicodeGlyph(0xf038)]
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
        ///<summary>Solid Anchor Circle-check</summary>
        ///<see href="https://fontawesome.com/icons/anchor-circle-check?style=solid"/>
        [Description("Solid Anchor Circle-check"), IconID("fas-anchor-circle-check"), IconUnicodeGlyph(0xe4aa)]
        SolidAnchorCircleCheck = 33,
        ///<summary>Solid Anchor Circle-exclamation</summary>
        ///<see href="https://fontawesome.com/icons/anchor-circle-exclamation?style=solid"/>
        [Description("Solid Anchor Circle-exclamation"), IconID("fas-anchor-circle-exclamation"), IconUnicodeGlyph(0xe4ab)]
        SolidAnchorCircleExclamation = 34,
        ///<summary>Solid Anchor Circle-xmark</summary>
        ///<see href="https://fontawesome.com/icons/anchor-circle-xmark?style=solid"/>
        [Description("Solid Anchor Circle-xmark"), IconID("fas-anchor-circle-xmark"), IconUnicodeGlyph(0xe4ac)]
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
        ///<summary>Solid angle-down</summary>
        ///<see href="https://fontawesome.com/icons/angle-down?style=solid"/>
        [Description("Solid angle-down"), IconID("fas-angle-down"), IconUnicodeGlyph(0xf107)]
        SolidAngleDown = 39,
        ///<summary>Solid angle-left</summary>
        ///<see href="https://fontawesome.com/icons/angle-left?style=solid"/>
        [Description("Solid angle-left"), IconID("fas-angle-left"), IconUnicodeGlyph(0xf104)]
        SolidAngleLeft = 40,
        ///<summary>Solid angle-right</summary>
        ///<see href="https://fontawesome.com/icons/angle-right?style=solid"/>
        [Description("Solid angle-right"), IconID("fas-angle-right"), IconUnicodeGlyph(0xf105)]
        SolidAngleRight = 41,
        ///<summary>Solid angle-up</summary>
        ///<see href="https://fontawesome.com/icons/angle-up?style=solid"/>
        [Description("Solid angle-up"), IconID("fas-angle-up"), IconUnicodeGlyph(0xf106)]
        SolidAngleUp = 42,
        ///<summary>Solid Angles down</summary>
        ///<see href="https://fontawesome.com/icons/angles-down?style=solid"/>
        [Description("Solid Angles down"), IconID("fas-angles-down"), IconUnicodeGlyph(0xf103)]
        SolidAnglesDown = 43,
        ///<summary>Solid Angles left</summary>
        ///<see href="https://fontawesome.com/icons/angles-left?style=solid"/>
        [Description("Solid Angles left"), IconID("fas-angles-left"), IconUnicodeGlyph(0xf100)]
        SolidAnglesLeft = 44,
        ///<summary>Solid Angles right</summary>
        ///<see href="https://fontawesome.com/icons/angles-right?style=solid"/>
        [Description("Solid Angles right"), IconID("fas-angles-right"), IconUnicodeGlyph(0xf101)]
        SolidAnglesRight = 45,
        ///<summary>Solid Angles up</summary>
        ///<see href="https://fontawesome.com/icons/angles-up?style=solid"/>
        [Description("Solid Angles up"), IconID("fas-angles-up"), IconUnicodeGlyph(0xf102)]
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
        ///<summary>Solid Apple whole</summary>
        ///<see href="https://fontawesome.com/icons/apple-whole?style=solid"/>
        [Description("Solid Apple whole"), IconID("fas-apple-whole"), IconUnicodeGlyph(0xf5d1)]
        SolidAppleWhole = 55,
        ///<summary>Solid Archway</summary>
        ///<see href="https://fontawesome.com/icons/archway?style=solid"/>
        [Description("Solid Archway"), IconID("fas-archway"), IconUnicodeGlyph(0xf557)]
        SolidArchway = 56,
        ///<summary>Solid Arrow down</summary>
        ///<see href="https://fontawesome.com/icons/arrow-down?style=solid"/>
        [Description("Solid Arrow down"), IconID("fas-arrow-down"), IconUnicodeGlyph(0xf063)]
        SolidArrowDown = 57,
        ///<summary>Solid Arrow down 1 9</summary>
        ///<see href="https://fontawesome.com/icons/arrow-down-1-9?style=solid"/>
        [Description("Solid Arrow down 1 9"), IconID("fas-arrow-down-1-9"), IconUnicodeGlyph(0xf162)]
        SolidArrowDown19 = 58,
        ///<summary>Solid Arrow down 9 1</summary>
        ///<see href="https://fontawesome.com/icons/arrow-down-9-1?style=solid"/>
        [Description("Solid Arrow down 9 1"), IconID("fas-arrow-down-9-1"), IconUnicodeGlyph(0xf886)]
        SolidArrowDown91 = 59,
        ///<summary>Solid Arrow down a z</summary>
        ///<see href="https://fontawesome.com/icons/arrow-down-a-z?style=solid"/>
        [Description("Solid Arrow down a z"), IconID("fas-arrow-down-a-z"), IconUnicodeGlyph(0xf15d)]
        SolidArrowDownAZ = 60,
        ///<summary>Solid Arrow down long</summary>
        ///<see href="https://fontawesome.com/icons/arrow-down-long?style=solid"/>
        [Description("Solid Arrow down long"), IconID("fas-arrow-down-long"), IconUnicodeGlyph(0xf175)]
        SolidArrowDownLong = 61,
        ///<summary>Solid Arrow down short wide</summary>
        ///<see href="https://fontawesome.com/icons/arrow-down-short-wide?style=solid"/>
        [Description("Solid Arrow down short wide"), IconID("fas-arrow-down-short-wide"), IconUnicodeGlyph(0xf884)]
        SolidArrowDownShortWide = 62,
        ///<summary>Solid Arrow Down-up-across-line</summary>
        ///<see href="https://fontawesome.com/icons/arrow-down-up-across-line?style=solid"/>
        [Description("Solid Arrow Down-up-across-line"), IconID("fas-arrow-down-up-across-line"), IconUnicodeGlyph(0xe4af)]
        SolidArrowDownUpAcrossLine = 63,
        ///<summary>Solid Arrow Down-up-lock</summary>
        ///<see href="https://fontawesome.com/icons/arrow-down-up-lock?style=solid"/>
        [Description("Solid Arrow Down-up-lock"), IconID("fas-arrow-down-up-lock"), IconUnicodeGlyph(0xe4b0)]
        SolidArrowDownUpLock = 64,
        ///<summary>Solid Arrow down wide short</summary>
        ///<see href="https://fontawesome.com/icons/arrow-down-wide-short?style=solid"/>
        [Description("Solid Arrow down wide short"), IconID("fas-arrow-down-wide-short"), IconUnicodeGlyph(0xf160)]
        SolidArrowDownWideShort = 65,
        ///<summary>Solid Arrow down z a</summary>
        ///<see href="https://fontawesome.com/icons/arrow-down-z-a?style=solid"/>
        [Description("Solid Arrow down z a"), IconID("fas-arrow-down-z-a"), IconUnicodeGlyph(0xf881)]
        SolidArrowDownZA = 66,
        ///<summary>Solid arrow-left</summary>
        ///<see href="https://fontawesome.com/icons/arrow-left?style=solid"/>
        [Description("Solid arrow-left"), IconID("fas-arrow-left"), IconUnicodeGlyph(0xf060)]
        SolidArrowLeft = 67,
        ///<summary>Solid Arrow left long</summary>
        ///<see href="https://fontawesome.com/icons/arrow-left-long?style=solid"/>
        [Description("Solid Arrow left long"), IconID("fas-arrow-left-long"), IconUnicodeGlyph(0xf177)]
        SolidArrowLeftLong = 68,
        ///<summary>Solid Arrow pointer</summary>
        ///<see href="https://fontawesome.com/icons/arrow-pointer?style=solid"/>
        [Description("Solid Arrow pointer"), IconID("fas-arrow-pointer"), IconUnicodeGlyph(0xf245)]
        SolidArrowPointer = 69,
        ///<summary>Solid arrow right</summary>
        ///<see href="https://fontawesome.com/icons/arrow-right?style=solid"/>
        [Description("Solid arrow right"), IconID("fas-arrow-right"), IconUnicodeGlyph(0xf061)]
        SolidArrowRight = 70,
        ///<summary>Solid Arrow right arrow left</summary>
        ///<see href="https://fontawesome.com/icons/arrow-right-arrow-left?style=solid"/>
        [Description("Solid Arrow right arrow left"), IconID("fas-arrow-right-arrow-left"), IconUnicodeGlyph(0xf0ec)]
        SolidArrowRightArrowLeft = 71,
        ///<summary>Solid Arrow right from bracket</summary>
        ///<see href="https://fontawesome.com/icons/arrow-right-from-bracket?style=solid"/>
        [Description("Solid Arrow right from bracket"), IconID("fas-arrow-right-from-bracket"), IconUnicodeGlyph(0xf08b)]
        SolidArrowRightFromBracket = 72,
        ///<summary>Solid Arrow right long</summary>
        ///<see href="https://fontawesome.com/icons/arrow-right-long?style=solid"/>
        [Description("Solid Arrow right long"), IconID("fas-arrow-right-long"), IconUnicodeGlyph(0xf178)]
        SolidArrowRightLong = 73,
        ///<summary>Solid Arrow right to bracket</summary>
        ///<see href="https://fontawesome.com/icons/arrow-right-to-bracket?style=solid"/>
        [Description("Solid Arrow right to bracket"), IconID("fas-arrow-right-to-bracket"), IconUnicodeGlyph(0xf090)]
        SolidArrowRightToBracket = 74,
        ///<summary>Solid Arrow Right-to-city</summary>
        ///<see href="https://fontawesome.com/icons/arrow-right-to-city?style=solid"/>
        [Description("Solid Arrow Right-to-city"), IconID("fas-arrow-right-to-city"), IconUnicodeGlyph(0xe4b3)]
        SolidArrowRightToCity = 75,
        ///<summary>Solid Arrow Rotate Left</summary>
        ///<see href="https://fontawesome.com/icons/arrow-rotate-left?style=solid"/>
        [Description("Solid Arrow Rotate Left"), IconID("fas-arrow-rotate-left"), IconUnicodeGlyph(0xf0e2)]
        SolidArrowRotateLeft = 76,
        ///<summary>Solid Arrow Rotate Right</summary>
        ///<see href="https://fontawesome.com/icons/arrow-rotate-right?style=solid"/>
        [Description("Solid Arrow Rotate Right"), IconID("fas-arrow-rotate-right"), IconUnicodeGlyph(0xf01e)]
        SolidArrowRotateRight = 77,
        ///<summary>Solid Arrow trend down</summary>
        ///<see href="https://fontawesome.com/icons/arrow-trend-down?style=solid"/>
        [Description("Solid Arrow trend down"), IconID("fas-arrow-trend-down"), IconUnicodeGlyph(0xe097)]
        SolidArrowTrendDown = 78,
        ///<summary>Solid Arrow trend up</summary>
        ///<see href="https://fontawesome.com/icons/arrow-trend-up?style=solid"/>
        [Description("Solid Arrow trend up"), IconID("fas-arrow-trend-up"), IconUnicodeGlyph(0xe098)]
        SolidArrowTrendUp = 79,
        ///<summary>Solid Arrow turn down</summary>
        ///<see href="https://fontawesome.com/icons/arrow-turn-down?style=solid"/>
        [Description("Solid Arrow turn down"), IconID("fas-arrow-turn-down"), IconUnicodeGlyph(0xf149)]
        SolidArrowTurnDown = 80,
        ///<summary>Solid Arrow turn up</summary>
        ///<see href="https://fontawesome.com/icons/arrow-turn-up?style=solid"/>
        [Description("Solid Arrow turn up"), IconID("fas-arrow-turn-up"), IconUnicodeGlyph(0xf148)]
        SolidArrowTurnUp = 81,
        ///<summary>Solid Arrow up</summary>
        ///<see href="https://fontawesome.com/icons/arrow-up?style=solid"/>
        [Description("Solid Arrow up"), IconID("fas-arrow-up"), IconUnicodeGlyph(0xf062)]
        SolidArrowUp = 82,
        ///<summary>Solid Arrow up 1 9</summary>
        ///<see href="https://fontawesome.com/icons/arrow-up-1-9?style=solid"/>
        [Description("Solid Arrow up 1 9"), IconID("fas-arrow-up-1-9"), IconUnicodeGlyph(0xf163)]
        SolidArrowUp19 = 83,
        ///<summary>Solid Arrow up 9 1</summary>
        ///<see href="https://fontawesome.com/icons/arrow-up-9-1?style=solid"/>
        [Description("Solid Arrow up 9 1"), IconID("fas-arrow-up-9-1"), IconUnicodeGlyph(0xf887)]
        SolidArrowUp91 = 84,
        ///<summary>Solid Arrow up a z</summary>
        ///<see href="https://fontawesome.com/icons/arrow-up-a-z?style=solid"/>
        [Description("Solid Arrow up a z"), IconID("fas-arrow-up-a-z"), IconUnicodeGlyph(0xf15e)]
        SolidArrowUpAZ = 85,
        ///<summary>Solid Arrow up from bracket</summary>
        ///<see href="https://fontawesome.com/icons/arrow-up-from-bracket?style=solid"/>
        [Description("Solid Arrow up from bracket"), IconID("fas-arrow-up-from-bracket"), IconUnicodeGlyph(0xe09a)]
        SolidArrowUpFromBracket = 86,
        ///<summary>Solid Arrow Up-from-ground-water</summary>
        ///<see href="https://fontawesome.com/icons/arrow-up-from-ground-water?style=solid"/>
        [Description("Solid Arrow Up-from-ground-water"), IconID("fas-arrow-up-from-ground-water"), IconUnicodeGlyph(0xe4b5)]
        SolidArrowUpFromGroundWater = 87,
        ///<summary>Solid Arrow Up-from-water-pump</summary>
        ///<see href="https://fontawesome.com/icons/arrow-up-from-water-pump?style=solid"/>
        [Description("Solid Arrow Up-from-water-pump"), IconID("fas-arrow-up-from-water-pump"), IconUnicodeGlyph(0xe4b6)]
        SolidArrowUpFromWaterPump = 88,
        ///<summary>Solid Arrow up long</summary>
        ///<see href="https://fontawesome.com/icons/arrow-up-long?style=solid"/>
        [Description("Solid Arrow up long"), IconID("fas-arrow-up-long"), IconUnicodeGlyph(0xf176)]
        SolidArrowUpLong = 89,
        ///<summary>Solid Arrow Up-right-dots</summary>
        ///<see href="https://fontawesome.com/icons/arrow-up-right-dots?style=solid"/>
        [Description("Solid Arrow Up-right-dots"), IconID("fas-arrow-up-right-dots"), IconUnicodeGlyph(0xe4b7)]
        SolidArrowUpRightDots = 90,
        ///<summary>Solid Arrow up right from square</summary>
        ///<see href="https://fontawesome.com/icons/arrow-up-right-from-square?style=solid"/>
        [Description("Solid Arrow up right from square"), IconID("fas-arrow-up-right-from-square"), IconUnicodeGlyph(0xf08e)]
        SolidArrowUpRightFromSquare = 91,
        ///<summary>Solid Arrow up short wide</summary>
        ///<see href="https://fontawesome.com/icons/arrow-up-short-wide?style=solid"/>
        [Description("Solid Arrow up short wide"), IconID("fas-arrow-up-short-wide"), IconUnicodeGlyph(0xf885)]
        SolidArrowUpShortWide = 92,
        ///<summary>Solid Arrow up wide short</summary>
        ///<see href="https://fontawesome.com/icons/arrow-up-wide-short?style=solid"/>
        [Description("Solid Arrow up wide short"), IconID("fas-arrow-up-wide-short"), IconUnicodeGlyph(0xf161)]
        SolidArrowUpWideShort = 93,
        ///<summary>Solid Arrow up z a</summary>
        ///<see href="https://fontawesome.com/icons/arrow-up-z-a?style=solid"/>
        [Description("Solid Arrow up z a"), IconID("fas-arrow-up-z-a"), IconUnicodeGlyph(0xf882)]
        SolidArrowUpZA = 94,
        ///<summary>Solid Arrows Down-to-line</summary>
        ///<see href="https://fontawesome.com/icons/arrows-down-to-line?style=solid"/>
        [Description("Solid Arrows Down-to-line"), IconID("fas-arrows-down-to-line"), IconUnicodeGlyph(0xe4b8)]
        SolidArrowsDownToLine = 95,
        ///<summary>Solid Arrows Down-to-people</summary>
        ///<see href="https://fontawesome.com/icons/arrows-down-to-people?style=solid"/>
        [Description("Solid Arrows Down-to-people"), IconID("fas-arrows-down-to-people"), IconUnicodeGlyph(0xe4b9)]
        SolidArrowsDownToPeople = 96,
        ///<summary>Solid Arrows left right</summary>
        ///<see href="https://fontawesome.com/icons/arrows-left-right?style=solid"/>
        [Description("Solid Arrows left right"), IconID("fas-arrows-left-right"), IconUnicodeGlyph(0xf07e)]
        SolidArrowsLeftRight = 97,
        ///<summary>Solid Arrows Left-right-to-line</summary>
        ///<see href="https://fontawesome.com/icons/arrows-left-right-to-line?style=solid"/>
        [Description("Solid Arrows Left-right-to-line"), IconID("fas-arrows-left-right-to-line"), IconUnicodeGlyph(0xe4ba)]
        SolidArrowsLeftRightToLine = 98,
        ///<summary>Solid Arrows rotate</summary>
        ///<see href="https://fontawesome.com/icons/arrows-rotate?style=solid"/>
        [Description("Solid Arrows rotate"), IconID("fas-arrows-rotate"), IconUnicodeGlyph(0xf021)]
        SolidArrowsRotate = 99,
        ///<summary>Solid Arrows Spin</summary>
        ///<see href="https://fontawesome.com/icons/arrows-spin?style=solid"/>
        [Description("Solid Arrows Spin"), IconID("fas-arrows-spin"), IconUnicodeGlyph(0xe4bb)]
        SolidArrowsSpin = 100,
        ///<summary>Solid Arrows Split-up-and-left</summary>
        ///<see href="https://fontawesome.com/icons/arrows-split-up-and-left?style=solid"/>
        [Description("Solid Arrows Split-up-and-left"), IconID("fas-arrows-split-up-and-left"), IconUnicodeGlyph(0xe4bc)]
        SolidArrowsSplitUpAndLeft = 101,
        ///<summary>Solid Arrows To-circle</summary>
        ///<see href="https://fontawesome.com/icons/arrows-to-circle?style=solid"/>
        [Description("Solid Arrows To-circle"), IconID("fas-arrows-to-circle"), IconUnicodeGlyph(0xe4bd)]
        SolidArrowsToCircle = 102,
        ///<summary>Solid Arrows To-dot</summary>
        ///<see href="https://fontawesome.com/icons/arrows-to-dot?style=solid"/>
        [Description("Solid Arrows To-dot"), IconID("fas-arrows-to-dot"), IconUnicodeGlyph(0xe4be)]
        SolidArrowsToDot = 103,
        ///<summary>Solid Arrows To-eye</summary>
        ///<see href="https://fontawesome.com/icons/arrows-to-eye?style=solid"/>
        [Description("Solid Arrows To-eye"), IconID("fas-arrows-to-eye"), IconUnicodeGlyph(0xe4bf)]
        SolidArrowsToEye = 104,
        ///<summary>Solid Arrows Turn-right</summary>
        ///<see href="https://fontawesome.com/icons/arrows-turn-right?style=solid"/>
        [Description("Solid Arrows Turn-right"), IconID("fas-arrows-turn-right"), IconUnicodeGlyph(0xe4c0)]
        SolidArrowsTurnRight = 105,
        ///<summary>Solid Arrows Turn-to-dots</summary>
        ///<see href="https://fontawesome.com/icons/arrows-turn-to-dots?style=solid"/>
        [Description("Solid Arrows Turn-to-dots"), IconID("fas-arrows-turn-to-dots"), IconUnicodeGlyph(0xe4c1)]
        SolidArrowsTurnToDots = 106,
        ///<summary>Solid Arrows up down</summary>
        ///<see href="https://fontawesome.com/icons/arrows-up-down?style=solid"/>
        [Description("Solid Arrows up down"), IconID("fas-arrows-up-down"), IconUnicodeGlyph(0xf07d)]
        SolidArrowsUpDown = 107,
        ///<summary>Solid Arrows up down left right</summary>
        ///<see href="https://fontawesome.com/icons/arrows-up-down-left-right?style=solid"/>
        [Description("Solid Arrows up down left right"), IconID("fas-arrows-up-down-left-right"), IconUnicodeGlyph(0xf047)]
        SolidArrowsUpDownLeftRight = 108,
        ///<summary>Solid Arrows Up-to-line</summary>
        ///<see href="https://fontawesome.com/icons/arrows-up-to-line?style=solid"/>
        [Description("Solid Arrows Up-to-line"), IconID("fas-arrows-up-to-line"), IconUnicodeGlyph(0xe4c2)]
        SolidArrowsUpToLine = 109,
        ///<summary>Brands Artstation</summary>
        ///<see href="https://fontawesome.com/icons/artstation?style=brands"/>
        [Description("Brands Artstation"), IconID("fab-artstation"), IconUnicodeGlyph(0xf77a)]
        BrandsArtstation = 110,
        ///<summary>Solid asterisk</summary>
        ///<see href="https://fontawesome.com/icons/asterisk?style=solid"/>
        [Description("Solid asterisk"), IconID("fas-asterisk"), IconUnicodeGlyph(0x2a)]
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
        ///<summary>Solid Rectangle audio description</summary>
        ///<see href="https://fontawesome.com/icons/audio-description?style=solid"/>
        [Description("Solid Rectangle audio description"), IconID("fas-audio-description"), IconUnicodeGlyph(0xf29e)]
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
        ///<summary>Solid backward</summary>
        ///<see href="https://fontawesome.com/icons/backward?style=solid"/>
        [Description("Solid backward"), IconID("fas-backward"), IconUnicodeGlyph(0xf04a)]
        SolidBackward = 127,
        ///<summary>Solid Backward fast</summary>
        ///<see href="https://fontawesome.com/icons/backward-fast?style=solid"/>
        [Description("Solid Backward fast"), IconID("fas-backward-fast"), IconUnicodeGlyph(0xf049)]
        SolidBackwardFast = 128,
        ///<summary>Solid Backward step</summary>
        ///<see href="https://fontawesome.com/icons/backward-step?style=solid"/>
        [Description("Solid Backward step"), IconID("fas-backward-step"), IconUnicodeGlyph(0xf048)]
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
        ///<summary>Solid Bag shopping</summary>
        ///<see href="https://fontawesome.com/icons/bag-shopping?style=solid"/>
        [Description("Solid Bag shopping"), IconID("fas-bag-shopping"), IconUnicodeGlyph(0xf290)]
        SolidBagShopping = 133,
        ///<summary>Solid Bahá'í</summary>
        ///<see href="https://fontawesome.com/icons/bahai?style=solid"/>
        [Description("Solid Bahá'í"), IconID("fas-bahai"), IconUnicodeGlyph(0xf666)]
        SolidBahai = 134,
        ///<summary>Solid Baht Sign</summary>
        ///<see href="https://fontawesome.com/icons/baht-sign?style=solid"/>
        [Description("Solid Baht Sign"), IconID("fas-baht-sign"), IconUnicodeGlyph(0xe0ac)]
        SolidBahtSign = 135,
        ///<summary>Solid ban</summary>
        ///<see href="https://fontawesome.com/icons/ban?style=solid"/>
        [Description("Solid ban"), IconID("fas-ban"), IconUnicodeGlyph(0xf05e)]
        SolidBan = 136,
        ///<summary>Solid Ban smoking</summary>
        ///<see href="https://fontawesome.com/icons/ban-smoking?style=solid"/>
        [Description("Solid Ban smoking"), IconID("fas-ban-smoking"), IconUnicodeGlyph(0xf54d)]
        SolidBanSmoking = 137,
        ///<summary>Solid Bandage</summary>
        ///<see href="https://fontawesome.com/icons/bandage?style=solid"/>
        [Description("Solid Bandage"), IconID("fas-bandage"), IconUnicodeGlyph(0xf462)]
        SolidBandage = 138,
        ///<summary>Brands Bandcamp</summary>
        ///<see href="https://fontawesome.com/icons/bandcamp?style=brands"/>
        [Description("Brands Bandcamp"), IconID("fab-bandcamp"), IconUnicodeGlyph(0xf2d5)]
        BrandsBandcamp = 139,
        ///<summary>Solid barcode</summary>
        ///<see href="https://fontawesome.com/icons/barcode?style=solid"/>
        [Description("Solid barcode"), IconID("fas-barcode"), IconUnicodeGlyph(0xf02a)]
        SolidBarcode = 140,
        ///<summary>Solid Bars</summary>
        ///<see href="https://fontawesome.com/icons/bars?style=solid"/>
        [Description("Solid Bars"), IconID("fas-bars"), IconUnicodeGlyph(0xf0c9)]
        SolidBars = 141,
        ///<summary>Solid Bars progress</summary>
        ///<see href="https://fontawesome.com/icons/bars-progress?style=solid"/>
        [Description("Solid Bars progress"), IconID("fas-bars-progress"), IconUnicodeGlyph(0xf828)]
        SolidBarsProgress = 142,
        ///<summary>Solid Bars staggered</summary>
        ///<see href="https://fontawesome.com/icons/bars-staggered?style=solid"/>
        [Description("Solid Bars staggered"), IconID("fas-bars-staggered"), IconUnicodeGlyph(0xf550)]
        SolidBarsStaggered = 143,
        ///<summary>Solid Baseball Ball</summary>
        ///<see href="https://fontawesome.com/icons/baseball?style=solid"/>
        [Description("Solid Baseball Ball"), IconID("fas-baseball"), IconUnicodeGlyph(0xf433)]
        SolidBaseball = 144,
        ///<summary>Solid Baseball bat ball</summary>
        ///<see href="https://fontawesome.com/icons/baseball-bat-ball?style=solid"/>
        [Description("Solid Baseball bat ball"), IconID("fas-baseball-bat-ball"), IconUnicodeGlyph(0xf432)]
        SolidBaseballBatBall = 145,
        ///<summary>Solid Basket shopping</summary>
        ///<see href="https://fontawesome.com/icons/basket-shopping?style=solid"/>
        [Description("Solid Basket shopping"), IconID("fas-basket-shopping"), IconUnicodeGlyph(0xf291)]
        SolidBasketShopping = 146,
        ///<summary>Solid Basketball Ball</summary>
        ///<see href="https://fontawesome.com/icons/basketball?style=solid"/>
        [Description("Solid Basketball Ball"), IconID("fas-basketball"), IconUnicodeGlyph(0xf434)]
        SolidBasketball = 147,
        ///<summary>Solid Bath</summary>
        ///<see href="https://fontawesome.com/icons/bath?style=solid"/>
        [Description("Solid Bath"), IconID("fas-bath"), IconUnicodeGlyph(0xf2cd)]
        SolidBath = 148,
        ///<summary>Solid Battery Empty</summary>
        ///<see href="https://fontawesome.com/icons/battery-empty?style=solid"/>
        [Description("Solid Battery Empty"), IconID("fas-battery-empty"), IconUnicodeGlyph(0xf244)]
        SolidBatteryEmpty = 149,
        ///<summary>Solid Battery Full</summary>
        ///<see href="https://fontawesome.com/icons/battery-full?style=solid"/>
        [Description("Solid Battery Full"), IconID("fas-battery-full"), IconUnicodeGlyph(0xf240)]
        SolidBatteryFull = 150,
        ///<summary>Solid Battery 1/2 Full</summary>
        ///<see href="https://fontawesome.com/icons/battery-half?style=solid"/>
        [Description("Solid Battery 1/2 Full"), IconID("fas-battery-half"), IconUnicodeGlyph(0xf242)]
        SolidBatteryHalf = 151,
        ///<summary>Solid Battery 1/4 Full</summary>
        ///<see href="https://fontawesome.com/icons/battery-quarter?style=solid"/>
        [Description("Solid Battery 1/4 Full"), IconID("fas-battery-quarter"), IconUnicodeGlyph(0xf243)]
        SolidBatteryQuarter = 152,
        ///<summary>Solid Battery 3/4 Full</summary>
        ///<see href="https://fontawesome.com/icons/battery-three-quarters?style=solid"/>
        [Description("Solid Battery 3/4 Full"), IconID("fas-battery-three-quarters"), IconUnicodeGlyph(0xf241)]
        SolidBatteryThreeQuarters = 153,
        ///<summary>Brands Battle.net</summary>
        ///<see href="https://fontawesome.com/icons/battle-net?style=brands"/>
        [Description("Brands Battle.net"), IconID("fab-battle-net"), IconUnicodeGlyph(0xf835)]
        BrandsBattleNet = 154,
        ///<summary>Solid Bed</summary>
        ///<see href="https://fontawesome.com/icons/bed?style=solid"/>
        [Description("Solid Bed"), IconID("fas-bed"), IconUnicodeGlyph(0xf236)]
        SolidBed = 155,
        ///<summary>Solid Bed pulse</summary>
        ///<see href="https://fontawesome.com/icons/bed-pulse?style=solid"/>
        [Description("Solid Bed pulse"), IconID("fas-bed-pulse"), IconUnicodeGlyph(0xf487)]
        SolidBedPulse = 156,
        ///<summary>Solid Beer mug empty</summary>
        ///<see href="https://fontawesome.com/icons/beer-mug-empty?style=solid"/>
        [Description("Solid Beer mug empty"), IconID("fas-beer-mug-empty"), IconUnicodeGlyph(0xf0fc)]
        SolidBeerMugEmpty = 157,
        ///<summary>Brands Behance</summary>
        ///<see href="https://fontawesome.com/icons/behance?style=brands"/>
        [Description("Brands Behance"), IconID("fab-behance"), IconUnicodeGlyph(0xf1b4)]
        BrandsBehance = 158,
        ///<summary>Solid bell</summary>
        ///<see href="https://fontawesome.com/icons/bell?style=solid"/>
        [Description("Solid bell"), IconID("fas-bell"), IconUnicodeGlyph(0xf0f3)]
        SolidBell = 159,
        ///<summary>Regular bell</summary>
        ///<see href="https://fontawesome.com/icons/bell?style=regular"/>
        [Description("Regular bell"), IconID("far-bell"), IconUnicodeGlyph(0xf0f3)]
        RegularBell = 160,
        ///<summary>Solid Bell concierge</summary>
        ///<see href="https://fontawesome.com/icons/bell-concierge?style=solid"/>
        [Description("Solid Bell concierge"), IconID("fas-bell-concierge"), IconUnicodeGlyph(0xf562)]
        SolidBellConcierge = 161,
        ///<summary>Solid Bell Slash</summary>
        ///<see href="https://fontawesome.com/icons/bell-slash?style=solid"/>
        [Description("Solid Bell Slash"), IconID("fas-bell-slash"), IconUnicodeGlyph(0xf1f6)]
        SolidBellSlash = 162,
        ///<summary>Regular Bell Slash</summary>
        ///<see href="https://fontawesome.com/icons/bell-slash?style=regular"/>
        [Description("Regular Bell Slash"), IconID("far-bell-slash"), IconUnicodeGlyph(0xf1f6)]
        RegularBellSlash = 163,
        ///<summary>Solid Bezier Curve</summary>
        ///<see href="https://fontawesome.com/icons/bezier-curve?style=solid"/>
        [Description("Solid Bezier Curve"), IconID("fas-bezier-curve"), IconUnicodeGlyph(0xf55b)]
        SolidBezierCurve = 164,
        ///<summary>Solid Bicycle</summary>
        ///<see href="https://fontawesome.com/icons/bicycle?style=solid"/>
        [Description("Solid Bicycle"), IconID("fas-bicycle"), IconUnicodeGlyph(0xf206)]
        SolidBicycle = 165,
        ///<summary>Brands Bilibili</summary>
        ///<see href="https://fontawesome.com/icons/bilibili?style=brands"/>
        [Description("Brands Bilibili"), IconID("fab-bilibili"), IconUnicodeGlyph(0xe3d9)]
        BrandsBilibili = 166,
        ///<summary>Brands BIMobject</summary>
        ///<see href="https://fontawesome.com/icons/bimobject?style=brands"/>
        [Description("Brands BIMobject"), IconID("fab-bimobject"), IconUnicodeGlyph(0xf378)]
        BrandsBimobject = 167,
        ///<summary>Solid Binoculars</summary>
        ///<see href="https://fontawesome.com/icons/binoculars?style=solid"/>
        [Description("Solid Binoculars"), IconID("fas-binoculars"), IconUnicodeGlyph(0xf1e5)]
        SolidBinoculars = 168,
        ///<summary>Solid Biohazard</summary>
        ///<see href="https://fontawesome.com/icons/biohazard?style=solid"/>
        [Description("Solid Biohazard"), IconID("fas-biohazard"), IconUnicodeGlyph(0xf780)]
        SolidBiohazard = 169,
        ///<summary>Brands Bitbucket</summary>
        ///<see href="https://fontawesome.com/icons/bitbucket?style=brands"/>
        [Description("Brands Bitbucket"), IconID("fab-bitbucket"), IconUnicodeGlyph(0xf171)]
        BrandsBitbucket = 170,
        ///<summary>Brands Bitcoin</summary>
        ///<see href="https://fontawesome.com/icons/bitcoin?style=brands"/>
        [Description("Brands Bitcoin"), IconID("fab-bitcoin"), IconUnicodeGlyph(0xf379)]
        BrandsBitcoin = 171,
        ///<summary>Solid Bitcoin Sign</summary>
        ///<see href="https://fontawesome.com/icons/bitcoin-sign?style=solid"/>
        [Description("Solid Bitcoin Sign"), IconID("fas-bitcoin-sign"), IconUnicodeGlyph(0xe0b4)]
        SolidBitcoinSign = 172,
        ///<summary>Brands Bity</summary>
        ///<see href="https://fontawesome.com/icons/bity?style=brands"/>
        [Description("Brands Bity"), IconID("fab-bity"), IconUnicodeGlyph(0xf37a)]
        BrandsBity = 173,
        ///<summary>Brands Font Awesome Black Tie</summary>
        ///<see href="https://fontawesome.com/icons/black-tie?style=brands"/>
        [Description("Brands Font Awesome Black Tie"), IconID("fab-black-tie"), IconUnicodeGlyph(0xf27e)]
        BrandsBlackTie = 174,
        ///<summary>Brands BlackBerry</summary>
        ///<see href="https://fontawesome.com/icons/blackberry?style=brands"/>
        [Description("Brands BlackBerry"), IconID("fab-blackberry"), IconUnicodeGlyph(0xf37b)]
        BrandsBlackberry = 175,
        ///<summary>Solid Blender</summary>
        ///<see href="https://fontawesome.com/icons/blender?style=solid"/>
        [Description("Solid Blender"), IconID("fas-blender"), IconUnicodeGlyph(0xf517)]
        SolidBlender = 176,
        ///<summary>Solid Blender Phone</summary>
        ///<see href="https://fontawesome.com/icons/blender-phone?style=solid"/>
        [Description("Solid Blender Phone"), IconID("fas-blender-phone"), IconUnicodeGlyph(0xf6b6)]
        SolidBlenderPhone = 177,
        ///<summary>Solid Blog</summary>
        ///<see href="https://fontawesome.com/icons/blog?style=solid"/>
        [Description("Solid Blog"), IconID("fas-blog"), IconUnicodeGlyph(0xf781)]
        SolidBlog = 178,
        ///<summary>Brands Blogger</summary>
        ///<see href="https://fontawesome.com/icons/blogger?style=brands"/>
        [Description("Brands Blogger"), IconID("fab-blogger"), IconUnicodeGlyph(0xf37c)]
        BrandsBlogger = 179,
        ///<summary>Brands Blogger B</summary>
        ///<see href="https://fontawesome.com/icons/blogger-b?style=brands"/>
        [Description("Brands Blogger B"), IconID("fab-blogger-b"), IconUnicodeGlyph(0xf37d)]
        BrandsBloggerB = 180,
        ///<summary>Brands Bluetooth</summary>
        ///<see href="https://fontawesome.com/icons/bluetooth?style=brands"/>
        [Description("Brands Bluetooth"), IconID("fab-bluetooth"), IconUnicodeGlyph(0xf293)]
        BrandsBluetooth = 181,
        ///<summary>Brands Bluetooth</summary>
        ///<see href="https://fontawesome.com/icons/bluetooth-b?style=brands"/>
        [Description("Brands Bluetooth"), IconID("fab-bluetooth-b"), IconUnicodeGlyph(0xf294)]
        BrandsBluetoothB = 182,
        ///<summary>Solid bold</summary>
        ///<see href="https://fontawesome.com/icons/bold?style=solid"/>
        [Description("Solid bold"), IconID("fas-bold"), IconUnicodeGlyph(0xf032)]
        SolidBold = 183,
        ///<summary>Solid Bolt</summary>
        ///<see href="https://fontawesome.com/icons/bolt?style=solid"/>
        [Description("Solid Bolt"), IconID("fas-bolt"), IconUnicodeGlyph(0xf0e7)]
        SolidBolt = 184,
        ///<summary>Solid Lightning Bolt</summary>
        ///<see href="https://fontawesome.com/icons/bolt-lightning?style=solid"/>
        [Description("Solid Lightning Bolt"), IconID("fas-bolt-lightning"), IconUnicodeGlyph(0xe0b7)]
        SolidBoltLightning = 185,
        ///<summary>Solid Bomb</summary>
        ///<see href="https://fontawesome.com/icons/bomb?style=solid"/>
        [Description("Solid Bomb"), IconID("fas-bomb"), IconUnicodeGlyph(0xf1e2)]
        SolidBomb = 186,
        ///<summary>Solid Bone</summary>
        ///<see href="https://fontawesome.com/icons/bone?style=solid"/>
        [Description("Solid Bone"), IconID("fas-bone"), IconUnicodeGlyph(0xf5d7)]
        SolidBone = 187,
        ///<summary>Solid Bong</summary>
        ///<see href="https://fontawesome.com/icons/bong?style=solid"/>
        [Description("Solid Bong"), IconID("fas-bong"), IconUnicodeGlyph(0xf55c)]
        SolidBong = 188,
        ///<summary>Solid book</summary>
        ///<see href="https://fontawesome.com/icons/book?style=solid"/>
        [Description("Solid book"), IconID("fas-book"), IconUnicodeGlyph(0xf02d)]
        SolidBook = 189,
        ///<summary>Solid Book atlas</summary>
        ///<see href="https://fontawesome.com/icons/book-atlas?style=solid"/>
        [Description("Solid Book atlas"), IconID("fas-book-atlas"), IconUnicodeGlyph(0xf558)]
        SolidBookAtlas = 190,
        ///<summary>Solid Book bible</summary>
        ///<see href="https://fontawesome.com/icons/book-bible?style=solid"/>
        [Description("Solid Book bible"), IconID("fas-book-bible"), IconUnicodeGlyph(0xf647)]
        SolidBookBible = 191,
        ///<summary>Solid Book Bookmark</summary>
        ///<see href="https://fontawesome.com/icons/book-bookmark?style=solid"/>
        [Description("Solid Book Bookmark"), IconID("fas-book-bookmark"), IconUnicodeGlyph(0xe0bb)]
        SolidBookBookmark = 192,
        ///<summary>Solid Book journal whills</summary>
        ///<see href="https://fontawesome.com/icons/book-journal-whills?style=solid"/>
        [Description("Solid Book journal whills"), IconID("fas-book-journal-whills"), IconUnicodeGlyph(0xf66a)]
        SolidBookJournalWhills = 193,
        ///<summary>Solid Medical Book</summary>
        ///<see href="https://fontawesome.com/icons/book-medical?style=solid"/>
        [Description("Solid Medical Book"), IconID("fas-book-medical"), IconUnicodeGlyph(0xf7e6)]
        SolidBookMedical = 194,
        ///<summary>Solid Book Open</summary>
        ///<see href="https://fontawesome.com/icons/book-open?style=solid"/>
        [Description("Solid Book Open"), IconID("fas-book-open"), IconUnicodeGlyph(0xf518)]
        SolidBookOpen = 195,
        ///<summary>Solid Book open reader</summary>
        ///<see href="https://fontawesome.com/icons/book-open-reader?style=solid"/>
        [Description("Solid Book open reader"), IconID("fas-book-open-reader"), IconUnicodeGlyph(0xf5da)]
        SolidBookOpenReader = 196,
        ///<summary>Solid Book quran</summary>
        ///<see href="https://fontawesome.com/icons/book-quran?style=solid"/>
        [Description("Solid Book quran"), IconID("fas-book-quran"), IconUnicodeGlyph(0xf687)]
        SolidBookQuran = 197,
        ///<summary>Solid Book skull</summary>
        ///<see href="https://fontawesome.com/icons/book-skull?style=solid"/>
        [Description("Solid Book skull"), IconID("fas-book-skull"), IconUnicodeGlyph(0xf6b7)]
        SolidBookSkull = 198,
        ///<summary>Solid Book tanakh</summary>
        ///<see href="https://fontawesome.com/icons/book-tanakh?style=solid"/>
        [Description("Solid Book tanakh"), IconID("fas-book-tanakh"), IconUnicodeGlyph(0xf827)]
        SolidBookTanakh = 199,
        ///<summary>Solid bookmark</summary>
        ///<see href="https://fontawesome.com/icons/bookmark?style=solid"/>
        [Description("Solid bookmark"), IconID("fas-bookmark"), IconUnicodeGlyph(0xf02e)]
        SolidBookmark = 200,
        ///<summary>Regular bookmark</summary>
        ///<see href="https://fontawesome.com/icons/bookmark?style=regular"/>
        [Description("Regular bookmark"), IconID("far-bookmark"), IconUnicodeGlyph(0xf02e)]
        RegularBookmark = 201,
        ///<summary>Brands Bootstrap</summary>
        ///<see href="https://fontawesome.com/icons/bootstrap?style=brands"/>
        [Description("Brands Bootstrap"), IconID("fab-bootstrap"), IconUnicodeGlyph(0xf836)]
        BrandsBootstrap = 202,
        ///<summary>Solid Border All</summary>
        ///<see href="https://fontawesome.com/icons/border-all?style=solid"/>
        [Description("Solid Border All"), IconID("fas-border-all"), IconUnicodeGlyph(0xf84c)]
        SolidBorderAll = 203,
        ///<summary>Solid Border None</summary>
        ///<see href="https://fontawesome.com/icons/border-none?style=solid"/>
        [Description("Solid Border None"), IconID("fas-border-none"), IconUnicodeGlyph(0xf850)]
        SolidBorderNone = 204,
        ///<summary>Solid Border top left</summary>
        ///<see href="https://fontawesome.com/icons/border-top-left?style=solid"/>
        [Description("Solid Border top left"), IconID("fas-border-top-left"), IconUnicodeGlyph(0xf853)]
        SolidBorderTopLeft = 205,
        ///<summary>Solid Bore Hole</summary>
        ///<see href="https://fontawesome.com/icons/bore-hole?style=solid"/>
        [Description("Solid Bore Hole"), IconID("fas-bore-hole"), IconUnicodeGlyph(0xe4c3)]
        SolidBoreHole = 206,
        ///<summary>Brands Bots</summary>
        ///<see href="https://fontawesome.com/icons/bots?style=brands"/>
        [Description("Brands Bots"), IconID("fab-bots"), IconUnicodeGlyph(0xe340)]
        BrandsBots = 207,
        ///<summary>Solid Bottle Droplet</summary>
        ///<see href="https://fontawesome.com/icons/bottle-droplet?style=solid"/>
        [Description("Solid Bottle Droplet"), IconID("fas-bottle-droplet"), IconUnicodeGlyph(0xe4c4)]
        SolidBottleDroplet = 208,
        ///<summary>Solid Bottle Water</summary>
        ///<see href="https://fontawesome.com/icons/bottle-water?style=solid"/>
        [Description("Solid Bottle Water"), IconID("fas-bottle-water"), IconUnicodeGlyph(0xe4c5)]
        SolidBottleWater = 209,
        ///<summary>Solid Bowl Food</summary>
        ///<see href="https://fontawesome.com/icons/bowl-food?style=solid"/>
        [Description("Solid Bowl Food"), IconID("fas-bowl-food"), IconUnicodeGlyph(0xe4c6)]
        SolidBowlFood = 210,
        ///<summary>Solid Bowl Rice</summary>
        ///<see href="https://fontawesome.com/icons/bowl-rice?style=solid"/>
        [Description("Solid Bowl Rice"), IconID("fas-bowl-rice"), IconUnicodeGlyph(0xe2eb)]
        SolidBowlRice = 211,
        ///<summary>Solid Bowling Ball</summary>
        ///<see href="https://fontawesome.com/icons/bowling-ball?style=solid"/>
        [Description("Solid Bowling Ball"), IconID("fas-bowling-ball"), IconUnicodeGlyph(0xf436)]
        SolidBowlingBall = 212,
        ///<summary>Solid Box</summary>
        ///<see href="https://fontawesome.com/icons/box?style=solid"/>
        [Description("Solid Box"), IconID("fas-box"), IconUnicodeGlyph(0xf466)]
        SolidBox = 213,
        ///<summary>Solid Box archive</summary>
        ///<see href="https://fontawesome.com/icons/box-archive?style=solid"/>
        [Description("Solid Box archive"), IconID("fas-box-archive"), IconUnicodeGlyph(0xf187)]
        SolidBoxArchive = 214,
        ///<summary>Solid Box Open</summary>
        ///<see href="https://fontawesome.com/icons/box-open?style=solid"/>
        [Description("Solid Box Open"), IconID("fas-box-open"), IconUnicodeGlyph(0xf49e)]
        SolidBoxOpen = 215,
        ///<summary>Solid Tissue Box</summary>
        ///<see href="https://fontawesome.com/icons/box-tissue?style=solid"/>
        [Description("Solid Tissue Box"), IconID("fas-box-tissue"), IconUnicodeGlyph(0xe05b)]
        SolidBoxTissue = 216,
        ///<summary>Solid Boxes Packing</summary>
        ///<see href="https://fontawesome.com/icons/boxes-packing?style=solid"/>
        [Description("Solid Boxes Packing"), IconID("fas-boxes-packing"), IconUnicodeGlyph(0xe4c7)]
        SolidBoxesPacking = 217,
        ///<summary>Solid Boxes stacked</summary>
        ///<see href="https://fontawesome.com/icons/boxes-stacked?style=solid"/>
        [Description("Solid Boxes stacked"), IconID("fas-boxes-stacked"), IconUnicodeGlyph(0xf468)]
        SolidBoxesStacked = 218,
        ///<summary>Solid Braille</summary>
        ///<see href="https://fontawesome.com/icons/braille?style=solid"/>
        [Description("Solid Braille"), IconID("fas-braille"), IconUnicodeGlyph(0xf2a1)]
        SolidBraille = 219,
        ///<summary>Solid Brain</summary>
        ///<see href="https://fontawesome.com/icons/brain?style=solid"/>
        [Description("Solid Brain"), IconID("fas-brain"), IconUnicodeGlyph(0xf5dc)]
        SolidBrain = 220,
        ///<summary>Solid Brazilian Real Sign</summary>
        ///<see href="https://fontawesome.com/icons/brazilian-real-sign?style=solid"/>
        [Description("Solid Brazilian Real Sign"), IconID("fas-brazilian-real-sign"), IconUnicodeGlyph(0xe46c)]
        SolidBrazilianRealSign = 221,
        ///<summary>Solid Bread Slice</summary>
        ///<see href="https://fontawesome.com/icons/bread-slice?style=solid"/>
        [Description("Solid Bread Slice"), IconID("fas-bread-slice"), IconUnicodeGlyph(0xf7ec)]
        SolidBreadSlice = 222,
        ///<summary>Solid Bridge</summary>
        ///<see href="https://fontawesome.com/icons/bridge?style=solid"/>
        [Description("Solid Bridge"), IconID("fas-bridge"), IconUnicodeGlyph(0xe4c8)]
        SolidBridge = 223,
        ///<summary>Solid Bridge Circle-check</summary>
        ///<see href="https://fontawesome.com/icons/bridge-circle-check?style=solid"/>
        [Description("Solid Bridge Circle-check"), IconID("fas-bridge-circle-check"), IconUnicodeGlyph(0xe4c9)]
        SolidBridgeCircleCheck = 224,
        ///<summary>Solid Bridge Circle-exclamation</summary>
        ///<see href="https://fontawesome.com/icons/bridge-circle-exclamation?style=solid"/>
        [Description("Solid Bridge Circle-exclamation"), IconID("fas-bridge-circle-exclamation"), IconUnicodeGlyph(0xe4ca)]
        SolidBridgeCircleExclamation = 225,
        ///<summary>Solid Bridge Circle-xmark</summary>
        ///<see href="https://fontawesome.com/icons/bridge-circle-xmark?style=solid"/>
        [Description("Solid Bridge Circle-xmark"), IconID("fas-bridge-circle-xmark"), IconUnicodeGlyph(0xe4cb)]
        SolidBridgeCircleXmark = 226,
        ///<summary>Solid Bridge Lock</summary>
        ///<see href="https://fontawesome.com/icons/bridge-lock?style=solid"/>
        [Description("Solid Bridge Lock"), IconID("fas-bridge-lock"), IconUnicodeGlyph(0xe4cc)]
        SolidBridgeLock = 227,
        ///<summary>Solid Bridge Water</summary>
        ///<see href="https://fontawesome.com/icons/bridge-water?style=solid"/>
        [Description("Solid Bridge Water"), IconID("fas-bridge-water"), IconUnicodeGlyph(0xe4ce)]
        SolidBridgeWater = 228,
        ///<summary>Solid Briefcase</summary>
        ///<see href="https://fontawesome.com/icons/briefcase?style=solid"/>
        [Description("Solid Briefcase"), IconID("fas-briefcase"), IconUnicodeGlyph(0xf0b1)]
        SolidBriefcase = 229,
        ///<summary>Solid Medical Briefcase</summary>
        ///<see href="https://fontawesome.com/icons/briefcase-medical?style=solid"/>
        [Description("Solid Medical Briefcase"), IconID("fas-briefcase-medical"), IconUnicodeGlyph(0xf469)]
        SolidBriefcaseMedical = 230,
        ///<summary>Solid Broom</summary>
        ///<see href="https://fontawesome.com/icons/broom?style=solid"/>
        [Description("Solid Broom"), IconID("fas-broom"), IconUnicodeGlyph(0xf51a)]
        SolidBroom = 231,
        ///<summary>Solid Broom and Ball</summary>
        ///<see href="https://fontawesome.com/icons/broom-ball?style=solid"/>
        [Description("Solid Broom and Ball"), IconID("fas-broom-ball"), IconUnicodeGlyph(0xf458)]
        SolidBroomBall = 232,
        ///<summary>Solid Brush</summary>
        ///<see href="https://fontawesome.com/icons/brush?style=solid"/>
        [Description("Solid Brush"), IconID("fas-brush"), IconUnicodeGlyph(0xf55d)]
        SolidBrush = 233,
        ///<summary>Brands BTC</summary>
        ///<see href="https://fontawesome.com/icons/btc?style=brands"/>
        [Description("Brands BTC"), IconID("fab-btc"), IconUnicodeGlyph(0xf15a)]
        BrandsBtc = 234,
        ///<summary>Solid Bucket</summary>
        ///<see href="https://fontawesome.com/icons/bucket?style=solid"/>
        [Description("Solid Bucket"), IconID("fas-bucket"), IconUnicodeGlyph(0xe4cf)]
        SolidBucket = 235,
        ///<summary>Brands Buffer</summary>
        ///<see href="https://fontawesome.com/icons/buffer?style=brands"/>
        [Description("Brands Buffer"), IconID("fab-buffer"), IconUnicodeGlyph(0xf837)]
        BrandsBuffer = 236,
        ///<summary>Solid Bug</summary>
        ///<see href="https://fontawesome.com/icons/bug?style=solid"/>
        [Description("Solid Bug"), IconID("fas-bug"), IconUnicodeGlyph(0xf188)]
        SolidBug = 237,
        ///<summary>Solid Bug Slash</summary>
        ///<see href="https://fontawesome.com/icons/bug-slash?style=solid"/>
        [Description("Solid Bug Slash"), IconID("fas-bug-slash"), IconUnicodeGlyph(0xe490)]
        SolidBugSlash = 238,
        ///<summary>Solid Bugs</summary>
        ///<see href="https://fontawesome.com/icons/bugs?style=solid"/>
        [Description("Solid Bugs"), IconID("fas-bugs"), IconUnicodeGlyph(0xe4d0)]
        SolidBugs = 239,
        ///<summary>Solid Building</summary>
        ///<see href="https://fontawesome.com/icons/building?style=solid"/>
        [Description("Solid Building"), IconID("fas-building"), IconUnicodeGlyph(0xf1ad)]
        SolidBuilding = 240,
        ///<summary>Regular Building</summary>
        ///<see href="https://fontawesome.com/icons/building?style=regular"/>
        [Description("Regular Building"), IconID("far-building"), IconUnicodeGlyph(0xf1ad)]
        RegularBuilding = 241,
        ///<summary>Solid Building Circle-arrow-right</summary>
        ///<see href="https://fontawesome.com/icons/building-circle-arrow-right?style=solid"/>
        [Description("Solid Building Circle-arrow-right"), IconID("fas-building-circle-arrow-right"), IconUnicodeGlyph(0xe4d1)]
        SolidBuildingCircleArrowRight = 242,
        ///<summary>Solid Building Circle-check</summary>
        ///<see href="https://fontawesome.com/icons/building-circle-check?style=solid"/>
        [Description("Solid Building Circle-check"), IconID("fas-building-circle-check"), IconUnicodeGlyph(0xe4d2)]
        SolidBuildingCircleCheck = 243,
        ///<summary>Solid Building Circle-exclamation</summary>
        ///<see href="https://fontawesome.com/icons/building-circle-exclamation?style=solid"/>
        [Description("Solid Building Circle-exclamation"), IconID("fas-building-circle-exclamation"), IconUnicodeGlyph(0xe4d3)]
        SolidBuildingCircleExclamation = 244,
        ///<summary>Solid Building Circle-xmark</summary>
        ///<see href="https://fontawesome.com/icons/building-circle-xmark?style=solid"/>
        [Description("Solid Building Circle-xmark"), IconID("fas-building-circle-xmark"), IconUnicodeGlyph(0xe4d4)]
        SolidBuildingCircleXmark = 245,
        ///<summary>Solid Building with Columns</summary>
        ///<see href="https://fontawesome.com/icons/building-columns?style=solid"/>
        [Description("Solid Building with Columns"), IconID("fas-building-columns"), IconUnicodeGlyph(0xf19c)]
        SolidBuildingColumns = 246,
        ///<summary>Solid Building Flag</summary>
        ///<see href="https://fontawesome.com/icons/building-flag?style=solid"/>
        [Description("Solid Building Flag"), IconID("fas-building-flag"), IconUnicodeGlyph(0xe4d5)]
        SolidBuildingFlag = 247,
        ///<summary>Solid Building Lock</summary>
        ///<see href="https://fontawesome.com/icons/building-lock?style=solid"/>
        [Description("Solid Building Lock"), IconID("fas-building-lock"), IconUnicodeGlyph(0xe4d6)]
        SolidBuildingLock = 248,
        ///<summary>Solid Building Ngo</summary>
        ///<see href="https://fontawesome.com/icons/building-ngo?style=solid"/>
        [Description("Solid Building Ngo"), IconID("fas-building-ngo"), IconUnicodeGlyph(0xe4d7)]
        SolidBuildingNgo = 249,
        ///<summary>Solid Building Shield</summary>
        ///<see href="https://fontawesome.com/icons/building-shield?style=solid"/>
        [Description("Solid Building Shield"), IconID("fas-building-shield"), IconUnicodeGlyph(0xe4d8)]
        SolidBuildingShield = 250,
        ///<summary>Solid Building Un</summary>
        ///<see href="https://fontawesome.com/icons/building-un?style=solid"/>
        [Description("Solid Building Un"), IconID("fas-building-un"), IconUnicodeGlyph(0xe4d9)]
        SolidBuildingUn = 251,
        ///<summary>Solid Building User</summary>
        ///<see href="https://fontawesome.com/icons/building-user?style=solid"/>
        [Description("Solid Building User"), IconID("fas-building-user"), IconUnicodeGlyph(0xe4da)]
        SolidBuildingUser = 252,
        ///<summary>Solid Building Wheat</summary>
        ///<see href="https://fontawesome.com/icons/building-wheat?style=solid"/>
        [Description("Solid Building Wheat"), IconID("fas-building-wheat"), IconUnicodeGlyph(0xe4db)]
        SolidBuildingWheat = 253,
        ///<summary>Solid bullhorn</summary>
        ///<see href="https://fontawesome.com/icons/bullhorn?style=solid"/>
        [Description("Solid bullhorn"), IconID("fas-bullhorn"), IconUnicodeGlyph(0xf0a1)]
        SolidBullhorn = 254,
        ///<summary>Solid Bullseye</summary>
        ///<see href="https://fontawesome.com/icons/bullseye?style=solid"/>
        [Description("Solid Bullseye"), IconID("fas-bullseye"), IconUnicodeGlyph(0xf140)]
        SolidBullseye = 255,
        ///<summary>Solid Burger</summary>
        ///<see href="https://fontawesome.com/icons/burger?style=solid"/>
        [Description("Solid Burger"), IconID("fas-burger"), IconUnicodeGlyph(0xf805)]
        SolidBurger = 256,
        ///<summary>Brands Büromöbel-Experte GmbH & Co. KG.</summary>
        ///<see href="https://fontawesome.com/icons/buromobelexperte?style=brands"/>
        [Description("Brands Büromöbel-Experte GmbH & Co. KG."), IconID("fab-buromobelexperte"), IconUnicodeGlyph(0xf37f)]
        BrandsBuromobelexperte = 257,
        ///<summary>Solid Burst</summary>
        ///<see href="https://fontawesome.com/icons/burst?style=solid"/>
        [Description("Solid Burst"), IconID("fas-burst"), IconUnicodeGlyph(0xe4dc)]
        SolidBurst = 258,
        ///<summary>Solid Bus</summary>
        ///<see href="https://fontawesome.com/icons/bus?style=solid"/>
        [Description("Solid Bus"), IconID("fas-bus"), IconUnicodeGlyph(0xf207)]
        SolidBus = 259,
        ///<summary>Solid Bus simple</summary>
        ///<see href="https://fontawesome.com/icons/bus-simple?style=solid"/>
        [Description("Solid Bus simple"), IconID("fas-bus-simple"), IconUnicodeGlyph(0xf55e)]
        SolidBusSimple = 260,
        ///<summary>Solid Briefcase clock</summary>
        ///<see href="https://fontawesome.com/icons/business-time?style=solid"/>
        [Description("Solid Briefcase clock"), IconID("fas-business-time"), IconUnicodeGlyph(0xf64a)]
        SolidBusinessTime = 261,
        ///<summary>Brands Buy n Large</summary>
        ///<see href="https://fontawesome.com/icons/buy-n-large?style=brands"/>
        [Description("Brands Buy n Large"), IconID("fab-buy-n-large"), IconUnicodeGlyph(0xf8a6)]
        BrandsBuyNLarge = 262,
        ///<summary>Brands BuySellAds</summary>
        ///<see href="https://fontawesome.com/icons/buysellads?style=brands"/>
        [Description("Brands BuySellAds"), IconID("fab-buysellads"), IconUnicodeGlyph(0xf20d)]
        BrandsBuysellads = 263,
        ///<summary>Solid C</summary>
        ///<see href="https://fontawesome.com/icons/c?style=solid"/>
        [Description("Solid C"), IconID("fas-c"), IconUnicodeGlyph(0x43)]
        SolidC = 264,
        ///<summary>Solid Cable Car</summary>
        ///<see href="https://fontawesome.com/icons/cable-car?style=solid"/>
        [Description("Solid Cable Car"), IconID("fas-cable-car"), IconUnicodeGlyph(0xf7da)]
        SolidCableCar = 265,
        ///<summary>Solid Cake candles</summary>
        ///<see href="https://fontawesome.com/icons/cake-candles?style=solid"/>
        [Description("Solid Cake candles"), IconID("fas-cake-candles"), IconUnicodeGlyph(0xf1fd)]
        SolidCakeCandles = 266,
        ///<summary>Solid Calculator</summary>
        ///<see href="https://fontawesome.com/icons/calculator?style=solid"/>
        [Description("Solid Calculator"), IconID("fas-calculator"), IconUnicodeGlyph(0xf1ec)]
        SolidCalculator = 267,
        ///<summary>Solid Calendar</summary>
        ///<see href="https://fontawesome.com/icons/calendar?style=solid"/>
        [Description("Solid Calendar"), IconID("fas-calendar"), IconUnicodeGlyph(0xf133)]
        SolidCalendar = 268,
        ///<summary>Regular Calendar</summary>
        ///<see href="https://fontawesome.com/icons/calendar?style=regular"/>
        [Description("Regular Calendar"), IconID("far-calendar"), IconUnicodeGlyph(0xf133)]
        RegularCalendar = 269,
        ///<summary>Solid Calendar Check</summary>
        ///<see href="https://fontawesome.com/icons/calendar-check?style=solid"/>
        [Description("Solid Calendar Check"), IconID("fas-calendar-check"), IconUnicodeGlyph(0xf274)]
        SolidCalendarCheck = 270,
        ///<summary>Regular Calendar Check</summary>
        ///<see href="https://fontawesome.com/icons/calendar-check?style=regular"/>
        [Description("Regular Calendar Check"), IconID("far-calendar-check"), IconUnicodeGlyph(0xf274)]
        RegularCalendarCheck = 271,
        ///<summary>Solid Calendar with Day Focus</summary>
        ///<see href="https://fontawesome.com/icons/calendar-day?style=solid"/>
        [Description("Solid Calendar with Day Focus"), IconID("fas-calendar-day"), IconUnicodeGlyph(0xf783)]
        SolidCalendarDay = 272,
        ///<summary>Solid Calendar Days</summary>
        ///<see href="https://fontawesome.com/icons/calendar-days?style=solid"/>
        [Description("Solid Calendar Days"), IconID("fas-calendar-days"), IconUnicodeGlyph(0xf073)]
        SolidCalendarDays = 273,
        ///<summary>Regular Calendar Days</summary>
        ///<see href="https://fontawesome.com/icons/calendar-days?style=regular"/>
        [Description("Regular Calendar Days"), IconID("far-calendar-days"), IconUnicodeGlyph(0xf073)]
        RegularCalendarDays = 274,
        ///<summary>Solid Calendar Minus</summary>
        ///<see href="https://fontawesome.com/icons/calendar-minus?style=solid"/>
        [Description("Solid Calendar Minus"), IconID("fas-calendar-minus"), IconUnicodeGlyph(0xf272)]
        SolidCalendarMinus = 275,
        ///<summary>Regular Calendar Minus</summary>
        ///<see href="https://fontawesome.com/icons/calendar-minus?style=regular"/>
        [Description("Regular Calendar Minus"), IconID("far-calendar-minus"), IconUnicodeGlyph(0xf272)]
        RegularCalendarMinus = 276,
        ///<summary>Solid Calendar Plus</summary>
        ///<see href="https://fontawesome.com/icons/calendar-plus?style=solid"/>
        [Description("Solid Calendar Plus"), IconID("fas-calendar-plus"), IconUnicodeGlyph(0xf271)]
        SolidCalendarPlus = 277,
        ///<summary>Regular Calendar Plus</summary>
        ///<see href="https://fontawesome.com/icons/calendar-plus?style=regular"/>
        [Description("Regular Calendar Plus"), IconID("far-calendar-plus"), IconUnicodeGlyph(0xf271)]
        RegularCalendarPlus = 278,
        ///<summary>Solid Calendar with Week Focus</summary>
        ///<see href="https://fontawesome.com/icons/calendar-week?style=solid"/>
        [Description("Solid Calendar with Week Focus"), IconID("fas-calendar-week"), IconUnicodeGlyph(0xf784)]
        SolidCalendarWeek = 279,
        ///<summary>Solid Calendar X Mark</summary>
        ///<see href="https://fontawesome.com/icons/calendar-xmark?style=solid"/>
        [Description("Solid Calendar X Mark"), IconID("fas-calendar-xmark"), IconUnicodeGlyph(0xf273)]
        SolidCalendarXmark = 280,
        ///<summary>Regular Calendar X Mark</summary>
        ///<see href="https://fontawesome.com/icons/calendar-xmark?style=regular"/>
        [Description("Regular Calendar X Mark"), IconID("far-calendar-xmark"), IconUnicodeGlyph(0xf273)]
        RegularCalendarXmark = 281,
        ///<summary>Solid camera</summary>
        ///<see href="https://fontawesome.com/icons/camera?style=solid"/>
        [Description("Solid camera"), IconID("fas-camera"), IconUnicodeGlyph(0xf030)]
        SolidCamera = 282,
        ///<summary>Solid Retro Camera</summary>
        ///<see href="https://fontawesome.com/icons/camera-retro?style=solid"/>
        [Description("Solid Retro Camera"), IconID("fas-camera-retro"), IconUnicodeGlyph(0xf083)]
        SolidCameraRetro = 283,
        ///<summary>Solid Camera Rotate</summary>
        ///<see href="https://fontawesome.com/icons/camera-rotate?style=solid"/>
        [Description("Solid Camera Rotate"), IconID("fas-camera-rotate"), IconUnicodeGlyph(0xe0d8)]
        SolidCameraRotate = 284,
        ///<summary>Solid Campground</summary>
        ///<see href="https://fontawesome.com/icons/campground?style=solid"/>
        [Description("Solid Campground"), IconID("fas-campground"), IconUnicodeGlyph(0xf6bb)]
        SolidCampground = 285,
        ///<summary>Brands Canadian Maple Leaf</summary>
        ///<see href="https://fontawesome.com/icons/canadian-maple-leaf?style=brands"/>
        [Description("Brands Canadian Maple Leaf"), IconID("fab-canadian-maple-leaf"), IconUnicodeGlyph(0xf785)]
        BrandsCanadianMapleLeaf = 286,
        ///<summary>Solid Candy Cane</summary>
        ///<see href="https://fontawesome.com/icons/candy-cane?style=solid"/>
        [Description("Solid Candy Cane"), IconID("fas-candy-cane"), IconUnicodeGlyph(0xf786)]
        SolidCandyCane = 287,
        ///<summary>Solid Cannabis</summary>
        ///<see href="https://fontawesome.com/icons/cannabis?style=solid"/>
        [Description("Solid Cannabis"), IconID("fas-cannabis"), IconUnicodeGlyph(0xf55f)]
        SolidCannabis = 288,
        ///<summary>Solid Capsules</summary>
        ///<see href="https://fontawesome.com/icons/capsules?style=solid"/>
        [Description("Solid Capsules"), IconID("fas-capsules"), IconUnicodeGlyph(0xf46b)]
        SolidCapsules = 289,
        ///<summary>Solid Car</summary>
        ///<see href="https://fontawesome.com/icons/car?style=solid"/>
        [Description("Solid Car"), IconID("fas-car"), IconUnicodeGlyph(0xf1b9)]
        SolidCar = 290,
        ///<summary>Solid Car Battery</summary>
        ///<see href="https://fontawesome.com/icons/car-battery?style=solid"/>
        [Description("Solid Car Battery"), IconID("fas-car-battery"), IconUnicodeGlyph(0xf5df)]
        SolidCarBattery = 291,
        ///<summary>Solid Car Crash</summary>
        ///<see href="https://fontawesome.com/icons/car-burst?style=solid"/>
        [Description("Solid Car Crash"), IconID("fas-car-burst"), IconUnicodeGlyph(0xf5e1)]
        SolidCarBurst = 292,
        ///<summary>Solid Car On</summary>
        ///<see href="https://fontawesome.com/icons/car-on?style=solid"/>
        [Description("Solid Car On"), IconID("fas-car-on"), IconUnicodeGlyph(0xe4dd)]
        SolidCarOn = 293,
        ///<summary>Solid Car rear</summary>
        ///<see href="https://fontawesome.com/icons/car-rear?style=solid"/>
        [Description("Solid Car rear"), IconID("fas-car-rear"), IconUnicodeGlyph(0xf5de)]
        SolidCarRear = 294,
        ///<summary>Solid Car Side</summary>
        ///<see href="https://fontawesome.com/icons/car-side?style=solid"/>
        [Description("Solid Car Side"), IconID("fas-car-side"), IconUnicodeGlyph(0xf5e4)]
        SolidCarSide = 295,
        ///<summary>Solid Car Tunnel</summary>
        ///<see href="https://fontawesome.com/icons/car-tunnel?style=solid"/>
        [Description("Solid Car Tunnel"), IconID("fas-car-tunnel"), IconUnicodeGlyph(0xe4de)]
        SolidCarTunnel = 296,
        ///<summary>Solid Caravan</summary>
        ///<see href="https://fontawesome.com/icons/caravan?style=solid"/>
        [Description("Solid Caravan"), IconID("fas-caravan"), IconUnicodeGlyph(0xf8ff)]
        SolidCaravan = 297,
        ///<summary>Solid Caret Down</summary>
        ///<see href="https://fontawesome.com/icons/caret-down?style=solid"/>
        [Description("Solid Caret Down"), IconID("fas-caret-down"), IconUnicodeGlyph(0xf0d7)]
        SolidCaretDown = 298,
        ///<summary>Solid Caret Left</summary>
        ///<see href="https://fontawesome.com/icons/caret-left?style=solid"/>
        [Description("Solid Caret Left"), IconID("fas-caret-left"), IconUnicodeGlyph(0xf0d9)]
        SolidCaretLeft = 299,
        ///<summary>Solid Caret Right</summary>
        ///<see href="https://fontawesome.com/icons/caret-right?style=solid"/>
        [Description("Solid Caret Right"), IconID("fas-caret-right"), IconUnicodeGlyph(0xf0da)]
        SolidCaretRight = 300,
        ///<summary>Solid Caret Up</summary>
        ///<see href="https://fontawesome.com/icons/caret-up?style=solid"/>
        [Description("Solid Caret Up"), IconID("fas-caret-up"), IconUnicodeGlyph(0xf0d8)]
        SolidCaretUp = 301,
        ///<summary>Solid Carrot</summary>
        ///<see href="https://fontawesome.com/icons/carrot?style=solid"/>
        [Description("Solid Carrot"), IconID("fas-carrot"), IconUnicodeGlyph(0xf787)]
        SolidCarrot = 302,
        ///<summary>Solid Shopping Cart Arrow Down</summary>
        ///<see href="https://fontawesome.com/icons/cart-arrow-down?style=solid"/>
        [Description("Solid Shopping Cart Arrow Down"), IconID("fas-cart-arrow-down"), IconUnicodeGlyph(0xf218)]
        SolidCartArrowDown = 303,
        ///<summary>Solid Cart flatbed</summary>
        ///<see href="https://fontawesome.com/icons/cart-flatbed?style=solid"/>
        [Description("Solid Cart flatbed"), IconID("fas-cart-flatbed"), IconUnicodeGlyph(0xf474)]
        SolidCartFlatbed = 304,
        ///<summary>Solid Cart flatbed suitcase</summary>
        ///<see href="https://fontawesome.com/icons/cart-flatbed-suitcase?style=solid"/>
        [Description("Solid Cart flatbed suitcase"), IconID("fas-cart-flatbed-suitcase"), IconUnicodeGlyph(0xf59d)]
        SolidCartFlatbedSuitcase = 305,
        ///<summary>Solid Add to Shopping Cart</summary>
        ///<see href="https://fontawesome.com/icons/cart-plus?style=solid"/>
        [Description("Solid Add to Shopping Cart"), IconID("fas-cart-plus"), IconUnicodeGlyph(0xf217)]
        SolidCartPlus = 306,
        ///<summary>Solid Cart shopping</summary>
        ///<see href="https://fontawesome.com/icons/cart-shopping?style=solid"/>
        [Description("Solid Cart shopping"), IconID("fas-cart-shopping"), IconUnicodeGlyph(0xf07a)]
        SolidCartShopping = 307,
        ///<summary>Solid Cash Register</summary>
        ///<see href="https://fontawesome.com/icons/cash-register?style=solid"/>
        [Description("Solid Cash Register"), IconID("fas-cash-register"), IconUnicodeGlyph(0xf788)]
        SolidCashRegister = 308,
        ///<summary>Solid Cat</summary>
        ///<see href="https://fontawesome.com/icons/cat?style=solid"/>
        [Description("Solid Cat"), IconID("fas-cat"), IconUnicodeGlyph(0xf6be)]
        SolidCat = 309,
        ///<summary>Brands Amazon Pay Credit Card</summary>
        ///<see href="https://fontawesome.com/icons/cc-amazon-pay?style=brands"/>
        [Description("Brands Amazon Pay Credit Card"), IconID("fab-cc-amazon-pay"), IconUnicodeGlyph(0xf42d)]
        BrandsCcAmazonPay = 310,
        ///<summary>Brands American Express Credit Card</summary>
        ///<see href="https://fontawesome.com/icons/cc-amex?style=brands"/>
        [Description("Brands American Express Credit Card"), IconID("fab-cc-amex"), IconUnicodeGlyph(0xf1f3)]
        BrandsCcAmex = 311,
        ///<summary>Brands Apple Pay Credit Card</summary>
        ///<see href="https://fontawesome.com/icons/cc-apple-pay?style=brands"/>
        [Description("Brands Apple Pay Credit Card"), IconID("fab-cc-apple-pay"), IconUnicodeGlyph(0xf416)]
        BrandsCcApplePay = 312,
        ///<summary>Brands Diner's Club Credit Card</summary>
        ///<see href="https://fontawesome.com/icons/cc-diners-club?style=brands"/>
        [Description("Brands Diner's Club Credit Card"), IconID("fab-cc-diners-club"), IconUnicodeGlyph(0xf24c)]
        BrandsCcDinersClub = 313,
        ///<summary>Brands Discover Credit Card</summary>
        ///<see href="https://fontawesome.com/icons/cc-discover?style=brands"/>
        [Description("Brands Discover Credit Card"), IconID("fab-cc-discover"), IconUnicodeGlyph(0xf1f2)]
        BrandsCcDiscover = 314,
        ///<summary>Brands JCB Credit Card</summary>
        ///<see href="https://fontawesome.com/icons/cc-jcb?style=brands"/>
        [Description("Brands JCB Credit Card"), IconID("fab-cc-jcb"), IconUnicodeGlyph(0xf24b)]
        BrandsCcJcb = 315,
        ///<summary>Brands MasterCard Credit Card</summary>
        ///<see href="https://fontawesome.com/icons/cc-mastercard?style=brands"/>
        [Description("Brands MasterCard Credit Card"), IconID("fab-cc-mastercard"), IconUnicodeGlyph(0xf1f1)]
        BrandsCcMastercard = 316,
        ///<summary>Brands Paypal Credit Card</summary>
        ///<see href="https://fontawesome.com/icons/cc-paypal?style=brands"/>
        [Description("Brands Paypal Credit Card"), IconID("fab-cc-paypal"), IconUnicodeGlyph(0xf1f4)]
        BrandsCcPaypal = 317,
        ///<summary>Brands Stripe Credit Card</summary>
        ///<see href="https://fontawesome.com/icons/cc-stripe?style=brands"/>
        [Description("Brands Stripe Credit Card"), IconID("fab-cc-stripe"), IconUnicodeGlyph(0xf1f5)]
        BrandsCcStripe = 318,
        ///<summary>Brands Visa Credit Card</summary>
        ///<see href="https://fontawesome.com/icons/cc-visa?style=brands"/>
        [Description("Brands Visa Credit Card"), IconID("fab-cc-visa"), IconUnicodeGlyph(0xf1f0)]
        BrandsCcVisa = 319,
        ///<summary>Solid Cedi Sign</summary>
        ///<see href="https://fontawesome.com/icons/cedi-sign?style=solid"/>
        [Description("Solid Cedi Sign"), IconID("fas-cedi-sign"), IconUnicodeGlyph(0xe0df)]
        SolidCediSign = 320,
        ///<summary>Solid Cent Sign</summary>
        ///<see href="https://fontawesome.com/icons/cent-sign?style=solid"/>
        [Description("Solid Cent Sign"), IconID("fas-cent-sign"), IconUnicodeGlyph(0xe3f5)]
        SolidCentSign = 321,
        ///<summary>Brands Centercode</summary>
        ///<see href="https://fontawesome.com/icons/centercode?style=brands"/>
        [Description("Brands Centercode"), IconID("fab-centercode"), IconUnicodeGlyph(0xf380)]
        BrandsCentercode = 322,
        ///<summary>Brands Centos</summary>
        ///<see href="https://fontawesome.com/icons/centos?style=brands"/>
        [Description("Brands Centos"), IconID("fab-centos"), IconUnicodeGlyph(0xf789)]
        BrandsCentos = 323,
        ///<summary>Solid certificate</summary>
        ///<see href="https://fontawesome.com/icons/certificate?style=solid"/>
        [Description("Solid certificate"), IconID("fas-certificate"), IconUnicodeGlyph(0xf0a3)]
        SolidCertificate = 324,
        ///<summary>Solid Chair</summary>
        ///<see href="https://fontawesome.com/icons/chair?style=solid"/>
        [Description("Solid Chair"), IconID("fas-chair"), IconUnicodeGlyph(0xf6c0)]
        SolidChair = 325,
        ///<summary>Solid Chalkboard</summary>
        ///<see href="https://fontawesome.com/icons/chalkboard?style=solid"/>
        [Description("Solid Chalkboard"), IconID("fas-chalkboard"), IconUnicodeGlyph(0xf51b)]
        SolidChalkboard = 326,
        ///<summary>Solid Chalkboard user</summary>
        ///<see href="https://fontawesome.com/icons/chalkboard-user?style=solid"/>
        [Description("Solid Chalkboard user"), IconID("fas-chalkboard-user"), IconUnicodeGlyph(0xf51c)]
        SolidChalkboardUser = 327,
        ///<summary>Solid Champagne glasses</summary>
        ///<see href="https://fontawesome.com/icons/champagne-glasses?style=solid"/>
        [Description("Solid Champagne glasses"), IconID("fas-champagne-glasses"), IconUnicodeGlyph(0xf79f)]
        SolidChampagneGlasses = 328,
        ///<summary>Solid Charging Station</summary>
        ///<see href="https://fontawesome.com/icons/charging-station?style=solid"/>
        [Description("Solid Charging Station"), IconID("fas-charging-station"), IconUnicodeGlyph(0xf5e7)]
        SolidChargingStation = 329,
        ///<summary>Solid Area Chart</summary>
        ///<see href="https://fontawesome.com/icons/chart-area?style=solid"/>
        [Description("Solid Area Chart"), IconID("fas-chart-area"), IconUnicodeGlyph(0xf1fe)]
        SolidChartArea = 330,
        ///<summary>Solid Bar Chart</summary>
        ///<see href="https://fontawesome.com/icons/chart-bar?style=solid"/>
        [Description("Solid Bar Chart"), IconID("fas-chart-bar"), IconUnicodeGlyph(0xf080)]
        SolidChartBar = 331,
        ///<summary>Regular Bar Chart</summary>
        ///<see href="https://fontawesome.com/icons/chart-bar?style=regular"/>
        [Description("Regular Bar Chart"), IconID("far-chart-bar"), IconUnicodeGlyph(0xf080)]
        RegularChartBar = 332,
        ///<summary>Solid Chart Column</summary>
        ///<see href="https://fontawesome.com/icons/chart-column?style=solid"/>
        [Description("Solid Chart Column"), IconID("fas-chart-column"), IconUnicodeGlyph(0xe0e3)]
        SolidChartColumn = 333,
        ///<summary>Solid Chart Gantt</summary>
        ///<see href="https://fontawesome.com/icons/chart-gantt?style=solid"/>
        [Description("Solid Chart Gantt"), IconID("fas-chart-gantt"), IconUnicodeGlyph(0xe0e4)]
        SolidChartGantt = 334,
        ///<summary>Solid Line Chart</summary>
        ///<see href="https://fontawesome.com/icons/chart-line?style=solid"/>
        [Description("Solid Line Chart"), IconID("fas-chart-line"), IconUnicodeGlyph(0xf201)]
        SolidChartLine = 335,
        ///<summary>Solid Pie Chart</summary>
        ///<see href="https://fontawesome.com/icons/chart-pie?style=solid"/>
        [Description("Solid Pie Chart"), IconID("fas-chart-pie"), IconUnicodeGlyph(0xf200)]
        SolidChartPie = 336,
        ///<summary>Solid Chart Simple</summary>
        ///<see href="https://fontawesome.com/icons/chart-simple?style=solid"/>
        [Description("Solid Chart Simple"), IconID("fas-chart-simple"), IconUnicodeGlyph(0xe473)]
        SolidChartSimple = 337,
        ///<summary>Solid Check</summary>
        ///<see href="https://fontawesome.com/icons/check?style=solid"/>
        [Description("Solid Check"), IconID("fas-check"), IconUnicodeGlyph(0xf00c)]
        SolidCheck = 338,
        ///<summary>Solid Double Check</summary>
        ///<see href="https://fontawesome.com/icons/check-double?style=solid"/>
        [Description("Solid Double Check"), IconID("fas-check-double"), IconUnicodeGlyph(0xf560)]
        SolidCheckDouble = 339,
        ///<summary>Solid Check to Slot</summary>
        ///<see href="https://fontawesome.com/icons/check-to-slot?style=solid"/>
        [Description("Solid Check to Slot"), IconID("fas-check-to-slot"), IconUnicodeGlyph(0xf772)]
        SolidCheckToSlot = 340,
        ///<summary>Solid Cheese</summary>
        ///<see href="https://fontawesome.com/icons/cheese?style=solid"/>
        [Description("Solid Cheese"), IconID("fas-cheese"), IconUnicodeGlyph(0xf7ef)]
        SolidCheese = 341,
        ///<summary>Solid Chess</summary>
        ///<see href="https://fontawesome.com/icons/chess?style=solid"/>
        [Description("Solid Chess"), IconID("fas-chess"), IconUnicodeGlyph(0xf439)]
        SolidChess = 342,
        ///<summary>Solid Chess Bishop</summary>
        ///<see href="https://fontawesome.com/icons/chess-bishop?style=solid"/>
        [Description("Solid Chess Bishop"), IconID("fas-chess-bishop"), IconUnicodeGlyph(0xf43a)]
        SolidChessBishop = 343,
        ///<summary>Regular Chess Bishop</summary>
        ///<see href="https://fontawesome.com/icons/chess-bishop?style=regular"/>
        [Description("Regular Chess Bishop"), IconID("far-chess-bishop"), IconUnicodeGlyph(0xf43a)]
        RegularChessBishop = 344,
        ///<summary>Solid Chess Board</summary>
        ///<see href="https://fontawesome.com/icons/chess-board?style=solid"/>
        [Description("Solid Chess Board"), IconID("fas-chess-board"), IconUnicodeGlyph(0xf43c)]
        SolidChessBoard = 345,
        ///<summary>Solid Chess King</summary>
        ///<see href="https://fontawesome.com/icons/chess-king?style=solid"/>
        [Description("Solid Chess King"), IconID("fas-chess-king"), IconUnicodeGlyph(0xf43f)]
        SolidChessKing = 346,
        ///<summary>Regular Chess King</summary>
        ///<see href="https://fontawesome.com/icons/chess-king?style=regular"/>
        [Description("Regular Chess King"), IconID("far-chess-king"), IconUnicodeGlyph(0xf43f)]
        RegularChessKing = 347,
        ///<summary>Solid Chess Knight</summary>
        ///<see href="https://fontawesome.com/icons/chess-knight?style=solid"/>
        [Description("Solid Chess Knight"), IconID("fas-chess-knight"), IconUnicodeGlyph(0xf441)]
        SolidChessKnight = 348,
        ///<summary>Regular Chess Knight</summary>
        ///<see href="https://fontawesome.com/icons/chess-knight?style=regular"/>
        [Description("Regular Chess Knight"), IconID("far-chess-knight"), IconUnicodeGlyph(0xf441)]
        RegularChessKnight = 349,
        ///<summary>Solid Chess Pawn</summary>
        ///<see href="https://fontawesome.com/icons/chess-pawn?style=solid"/>
        [Description("Solid Chess Pawn"), IconID("fas-chess-pawn"), IconUnicodeGlyph(0xf443)]
        SolidChessPawn = 350,
        ///<summary>Regular Chess Pawn</summary>
        ///<see href="https://fontawesome.com/icons/chess-pawn?style=regular"/>
        [Description("Regular Chess Pawn"), IconID("far-chess-pawn"), IconUnicodeGlyph(0xf443)]
        RegularChessPawn = 351,
        ///<summary>Solid Chess Queen</summary>
        ///<see href="https://fontawesome.com/icons/chess-queen?style=solid"/>
        [Description("Solid Chess Queen"), IconID("fas-chess-queen"), IconUnicodeGlyph(0xf445)]
        SolidChessQueen = 352,
        ///<summary>Regular Chess Queen</summary>
        ///<see href="https://fontawesome.com/icons/chess-queen?style=regular"/>
        [Description("Regular Chess Queen"), IconID("far-chess-queen"), IconUnicodeGlyph(0xf445)]
        RegularChessQueen = 353,
        ///<summary>Solid Chess Rook</summary>
        ///<see href="https://fontawesome.com/icons/chess-rook?style=solid"/>
        [Description("Solid Chess Rook"), IconID("fas-chess-rook"), IconUnicodeGlyph(0xf447)]
        SolidChessRook = 354,
        ///<summary>Regular Chess Rook</summary>
        ///<see href="https://fontawesome.com/icons/chess-rook?style=regular"/>
        [Description("Regular Chess Rook"), IconID("far-chess-rook"), IconUnicodeGlyph(0xf447)]
        RegularChessRook = 355,
        ///<summary>Solid chevron-down</summary>
        ///<see href="https://fontawesome.com/icons/chevron-down?style=solid"/>
        [Description("Solid chevron-down"), IconID("fas-chevron-down"), IconUnicodeGlyph(0xf078)]
        SolidChevronDown = 356,
        ///<summary>Solid chevron-left</summary>
        ///<see href="https://fontawesome.com/icons/chevron-left?style=solid"/>
        [Description("Solid chevron-left"), IconID("fas-chevron-left"), IconUnicodeGlyph(0xf053)]
        SolidChevronLeft = 357,
        ///<summary>Solid chevron-right</summary>
        ///<see href="https://fontawesome.com/icons/chevron-right?style=solid"/>
        [Description("Solid chevron-right"), IconID("fas-chevron-right"), IconUnicodeGlyph(0xf054)]
        SolidChevronRight = 358,
        ///<summary>Solid chevron-up</summary>
        ///<see href="https://fontawesome.com/icons/chevron-up?style=solid"/>
        [Description("Solid chevron-up"), IconID("fas-chevron-up"), IconUnicodeGlyph(0xf077)]
        SolidChevronUp = 359,
        ///<summary>Solid Child</summary>
        ///<see href="https://fontawesome.com/icons/child?style=solid"/>
        [Description("Solid Child"), IconID("fas-child"), IconUnicodeGlyph(0xf1ae)]
        SolidChild = 360,
        ///<summary>Solid Child Dress</summary>
        ///<see href="https://fontawesome.com/icons/child-dress?style=solid"/>
        [Description("Solid Child Dress"), IconID("fas-child-dress"), IconUnicodeGlyph(0xe59c)]
        SolidChildDress = 361,
        ///<summary>Solid Child Reaching</summary>
        ///<see href="https://fontawesome.com/icons/child-reaching?style=solid"/>
        [Description("Solid Child Reaching"), IconID("fas-child-reaching"), IconUnicodeGlyph(0xe59d)]
        SolidChildReaching = 362,
        ///<summary>Solid Child Rifle</summary>
        ///<see href="https://fontawesome.com/icons/child-rifle?style=solid"/>
        [Description("Solid Child Rifle"), IconID("fas-child-rifle"), IconUnicodeGlyph(0xe4e0)]
        SolidChildRifle = 363,
        ///<summary>Solid Children</summary>
        ///<see href="https://fontawesome.com/icons/children?style=solid"/>
        [Description("Solid Children"), IconID("fas-children"), IconUnicodeGlyph(0xe4e1)]
        SolidChildren = 364,
        ///<summary>Brands Chrome</summary>
        ///<see href="https://fontawesome.com/icons/chrome?style=brands"/>
        [Description("Brands Chrome"), IconID("fab-chrome"), IconUnicodeGlyph(0xf268)]
        BrandsChrome = 365,
        ///<summary>Brands Chromecast</summary>
        ///<see href="https://fontawesome.com/icons/chromecast?style=brands"/>
        [Description("Brands Chromecast"), IconID("fab-chromecast"), IconUnicodeGlyph(0xf838)]
        BrandsChromecast = 366,
        ///<summary>Solid Church</summary>
        ///<see href="https://fontawesome.com/icons/church?style=solid"/>
        [Description("Solid Church"), IconID("fas-church"), IconUnicodeGlyph(0xf51d)]
        SolidChurch = 367,
        ///<summary>Solid Circle</summary>
        ///<see href="https://fontawesome.com/icons/circle?style=solid"/>
        [Description("Solid Circle"), IconID("fas-circle"), IconUnicodeGlyph(0xf111)]
        SolidCircle = 368,
        ///<summary>Regular Circle</summary>
        ///<see href="https://fontawesome.com/icons/circle?style=regular"/>
        [Description("Regular Circle"), IconID("far-circle"), IconUnicodeGlyph(0xf111)]
        RegularCircle = 369,
        ///<summary>Solid Circle arrow down</summary>
        ///<see href="https://fontawesome.com/icons/circle-arrow-down?style=solid"/>
        [Description("Solid Circle arrow down"), IconID("fas-circle-arrow-down"), IconUnicodeGlyph(0xf0ab)]
        SolidCircleArrowDown = 370,
        ///<summary>Solid Circle arrow left</summary>
        ///<see href="https://fontawesome.com/icons/circle-arrow-left?style=solid"/>
        [Description("Solid Circle arrow left"), IconID("fas-circle-arrow-left"), IconUnicodeGlyph(0xf0a8)]
        SolidCircleArrowLeft = 371,
        ///<summary>Solid Circle arrow right</summary>
        ///<see href="https://fontawesome.com/icons/circle-arrow-right?style=solid"/>
        [Description("Solid Circle arrow right"), IconID("fas-circle-arrow-right"), IconUnicodeGlyph(0xf0a9)]
        SolidCircleArrowRight = 372,
        ///<summary>Solid Circle arrow up</summary>
        ///<see href="https://fontawesome.com/icons/circle-arrow-up?style=solid"/>
        [Description("Solid Circle arrow up"), IconID("fas-circle-arrow-up"), IconUnicodeGlyph(0xf0aa)]
        SolidCircleArrowUp = 373,
        ///<summary>Solid Circle check</summary>
        ///<see href="https://fontawesome.com/icons/circle-check?style=solid"/>
        [Description("Solid Circle check"), IconID("fas-circle-check"), IconUnicodeGlyph(0xf058)]
        SolidCircleCheck = 374,
        ///<summary>Regular Circle check</summary>
        ///<see href="https://fontawesome.com/icons/circle-check?style=regular"/>
        [Description("Regular Circle check"), IconID("far-circle-check"), IconUnicodeGlyph(0xf058)]
        RegularCircleCheck = 375,
        ///<summary>Solid Circle chevron down</summary>
        ///<see href="https://fontawesome.com/icons/circle-chevron-down?style=solid"/>
        [Description("Solid Circle chevron down"), IconID("fas-circle-chevron-down"), IconUnicodeGlyph(0xf13a)]
        SolidCircleChevronDown = 376,
        ///<summary>Solid Circle chevron left</summary>
        ///<see href="https://fontawesome.com/icons/circle-chevron-left?style=solid"/>
        [Description("Solid Circle chevron left"), IconID("fas-circle-chevron-left"), IconUnicodeGlyph(0xf137)]
        SolidCircleChevronLeft = 377,
        ///<summary>Solid Circle chevron right</summary>
        ///<see href="https://fontawesome.com/icons/circle-chevron-right?style=solid"/>
        [Description("Solid Circle chevron right"), IconID("fas-circle-chevron-right"), IconUnicodeGlyph(0xf138)]
        SolidCircleChevronRight = 378,
        ///<summary>Solid Circle chevron up</summary>
        ///<see href="https://fontawesome.com/icons/circle-chevron-up?style=solid"/>
        [Description("Solid Circle chevron up"), IconID("fas-circle-chevron-up"), IconUnicodeGlyph(0xf139)]
        SolidCircleChevronUp = 379,
        ///<summary>Solid Circle dollar to slot</summary>
        ///<see href="https://fontawesome.com/icons/circle-dollar-to-slot?style=solid"/>
        [Description("Solid Circle dollar to slot"), IconID("fas-circle-dollar-to-slot"), IconUnicodeGlyph(0xf4b9)]
        SolidCircleDollarToSlot = 380,
        ///<summary>Solid Circle dot</summary>
        ///<see href="https://fontawesome.com/icons/circle-dot?style=solid"/>
        [Description("Solid Circle dot"), IconID("fas-circle-dot"), IconUnicodeGlyph(0xf192)]
        SolidCircleDot = 381,
        ///<summary>Regular Circle dot</summary>
        ///<see href="https://fontawesome.com/icons/circle-dot?style=regular"/>
        [Description("Regular Circle dot"), IconID("far-circle-dot"), IconUnicodeGlyph(0xf192)]
        RegularCircleDot = 382,
        ///<summary>Solid Circle down</summary>
        ///<see href="https://fontawesome.com/icons/circle-down?style=solid"/>
        [Description("Solid Circle down"), IconID("fas-circle-down"), IconUnicodeGlyph(0xf358)]
        SolidCircleDown = 383,
        ///<summary>Regular Circle down</summary>
        ///<see href="https://fontawesome.com/icons/circle-down?style=regular"/>
        [Description("Regular Circle down"), IconID("far-circle-down"), IconUnicodeGlyph(0xf358)]
        RegularCircleDown = 384,
        ///<summary>Solid Circle exclamation</summary>
        ///<see href="https://fontawesome.com/icons/circle-exclamation?style=solid"/>
        [Description("Solid Circle exclamation"), IconID("fas-circle-exclamation"), IconUnicodeGlyph(0xf06a)]
        SolidCircleExclamation = 385,
        ///<summary>Solid Circle h</summary>
        ///<see href="https://fontawesome.com/icons/circle-h?style=solid"/>
        [Description("Solid Circle h"), IconID("fas-circle-h"), IconUnicodeGlyph(0xf47e)]
        SolidCircleH = 386,
        ///<summary>Solid Circle half stroke</summary>
        ///<see href="https://fontawesome.com/icons/circle-half-stroke?style=solid"/>
        [Description("Solid Circle half stroke"), IconID("fas-circle-half-stroke"), IconUnicodeGlyph(0xf042)]
        SolidCircleHalfStroke = 387,
        ///<summary>Solid Circle info</summary>
        ///<see href="https://fontawesome.com/icons/circle-info?style=solid"/>
        [Description("Solid Circle info"), IconID("fas-circle-info"), IconUnicodeGlyph(0xf05a)]
        SolidCircleInfo = 388,
        ///<summary>Solid Circle left</summary>
        ///<see href="https://fontawesome.com/icons/circle-left?style=solid"/>
        [Description("Solid Circle left"), IconID("fas-circle-left"), IconUnicodeGlyph(0xf359)]
        SolidCircleLeft = 389,
        ///<summary>Regular Circle left</summary>
        ///<see href="https://fontawesome.com/icons/circle-left?style=regular"/>
        [Description("Regular Circle left"), IconID("far-circle-left"), IconUnicodeGlyph(0xf359)]
        RegularCircleLeft = 390,
        ///<summary>Solid Circle minus</summary>
        ///<see href="https://fontawesome.com/icons/circle-minus?style=solid"/>
        [Description("Solid Circle minus"), IconID("fas-circle-minus"), IconUnicodeGlyph(0xf056)]
        SolidCircleMinus = 391,
        ///<summary>Solid Circle Nodes</summary>
        ///<see href="https://fontawesome.com/icons/circle-nodes?style=solid"/>
        [Description("Solid Circle Nodes"), IconID("fas-circle-nodes"), IconUnicodeGlyph(0xe4e2)]
        SolidCircleNodes = 392,
        ///<summary>Solid Circle Notched</summary>
        ///<see href="https://fontawesome.com/icons/circle-notch?style=solid"/>
        [Description("Solid Circle Notched"), IconID("fas-circle-notch"), IconUnicodeGlyph(0xf1ce)]
        SolidCircleNotch = 393,
        ///<summary>Solid Circle pause</summary>
        ///<see href="https://fontawesome.com/icons/circle-pause?style=solid"/>
        [Description("Solid Circle pause"), IconID("fas-circle-pause"), IconUnicodeGlyph(0xf28b)]
        SolidCirclePause = 394,
        ///<summary>Regular Circle pause</summary>
        ///<see href="https://fontawesome.com/icons/circle-pause?style=regular"/>
        [Description("Regular Circle pause"), IconID("far-circle-pause"), IconUnicodeGlyph(0xf28b)]
        RegularCirclePause = 395,
        ///<summary>Solid Circle play</summary>
        ///<see href="https://fontawesome.com/icons/circle-play?style=solid"/>
        [Description("Solid Circle play"), IconID("fas-circle-play"), IconUnicodeGlyph(0xf144)]
        SolidCirclePlay = 396,
        ///<summary>Regular Circle play</summary>
        ///<see href="https://fontawesome.com/icons/circle-play?style=regular"/>
        [Description("Regular Circle play"), IconID("far-circle-play"), IconUnicodeGlyph(0xf144)]
        RegularCirclePlay = 397,
        ///<summary>Solid Circle plus</summary>
        ///<see href="https://fontawesome.com/icons/circle-plus?style=solid"/>
        [Description("Solid Circle plus"), IconID("fas-circle-plus"), IconUnicodeGlyph(0xf055)]
        SolidCirclePlus = 398,
        ///<summary>Solid Circle question</summary>
        ///<see href="https://fontawesome.com/icons/circle-question?style=solid"/>
        [Description("Solid Circle question"), IconID("fas-circle-question"), IconUnicodeGlyph(0xf059)]
        SolidCircleQuestion = 399,
        ///<summary>Regular Circle question</summary>
        ///<see href="https://fontawesome.com/icons/circle-question?style=regular"/>
        [Description("Regular Circle question"), IconID("far-circle-question"), IconUnicodeGlyph(0xf059)]
        RegularCircleQuestion = 400,
        ///<summary>Solid Circle radiation</summary>
        ///<see href="https://fontawesome.com/icons/circle-radiation?style=solid"/>
        [Description("Solid Circle radiation"), IconID("fas-circle-radiation"), IconUnicodeGlyph(0xf7ba)]
        SolidCircleRadiation = 401,
        ///<summary>Solid Circle right</summary>
        ///<see href="https://fontawesome.com/icons/circle-right?style=solid"/>
        [Description("Solid Circle right"), IconID("fas-circle-right"), IconUnicodeGlyph(0xf35a)]
        SolidCircleRight = 402,
        ///<summary>Regular Circle right</summary>
        ///<see href="https://fontawesome.com/icons/circle-right?style=regular"/>
        [Description("Regular Circle right"), IconID("far-circle-right"), IconUnicodeGlyph(0xf35a)]
        RegularCircleRight = 403,
        ///<summary>Solid Circle stop</summary>
        ///<see href="https://fontawesome.com/icons/circle-stop?style=solid"/>
        [Description("Solid Circle stop"), IconID("fas-circle-stop"), IconUnicodeGlyph(0xf28d)]
        SolidCircleStop = 404,
        ///<summary>Regular Circle stop</summary>
        ///<see href="https://fontawesome.com/icons/circle-stop?style=regular"/>
        [Description("Regular Circle stop"), IconID("far-circle-stop"), IconUnicodeGlyph(0xf28d)]
        RegularCircleStop = 405,
        ///<summary>Solid Circle up</summary>
        ///<see href="https://fontawesome.com/icons/circle-up?style=solid"/>
        [Description("Solid Circle up"), IconID("fas-circle-up"), IconUnicodeGlyph(0xf35b)]
        SolidCircleUp = 406,
        ///<summary>Regular Circle up</summary>
        ///<see href="https://fontawesome.com/icons/circle-up?style=regular"/>
        [Description("Regular Circle up"), IconID("far-circle-up"), IconUnicodeGlyph(0xf35b)]
        RegularCircleUp = 407,
        ///<summary>Solid Circle user</summary>
        ///<see href="https://fontawesome.com/icons/circle-user?style=solid"/>
        [Description("Solid Circle user"), IconID("fas-circle-user"), IconUnicodeGlyph(0xf2bd)]
        SolidCircleUser = 408,
        ///<summary>Regular Circle user</summary>
        ///<see href="https://fontawesome.com/icons/circle-user?style=regular"/>
        [Description("Regular Circle user"), IconID("far-circle-user"), IconUnicodeGlyph(0xf2bd)]
        RegularCircleUser = 409,
        ///<summary>Solid Circle X Mark</summary>
        ///<see href="https://fontawesome.com/icons/circle-xmark?style=solid"/>
        [Description("Solid Circle X Mark"), IconID("fas-circle-xmark"), IconUnicodeGlyph(0xf057)]
        SolidCircleXmark = 410,
        ///<summary>Regular Circle X Mark</summary>
        ///<see href="https://fontawesome.com/icons/circle-xmark?style=regular"/>
        [Description("Regular Circle X Mark"), IconID("far-circle-xmark"), IconUnicodeGlyph(0xf057)]
        RegularCircleXmark = 411,
        ///<summary>Solid City</summary>
        ///<see href="https://fontawesome.com/icons/city?style=solid"/>
        [Description("Solid City"), IconID("fas-city"), IconUnicodeGlyph(0xf64f)]
        SolidCity = 412,
        ///<summary>Solid Clapperboard</summary>
        ///<see href="https://fontawesome.com/icons/clapperboard?style=solid"/>
        [Description("Solid Clapperboard"), IconID("fas-clapperboard"), IconUnicodeGlyph(0xe131)]
        SolidClapperboard = 413,
        ///<summary>Solid Clipboard</summary>
        ///<see href="https://fontawesome.com/icons/clipboard?style=solid"/>
        [Description("Solid Clipboard"), IconID("fas-clipboard"), IconUnicodeGlyph(0xf328)]
        SolidClipboard = 414,
        ///<summary>Regular Clipboard</summary>
        ///<see href="https://fontawesome.com/icons/clipboard?style=regular"/>
        [Description("Regular Clipboard"), IconID("far-clipboard"), IconUnicodeGlyph(0xf328)]
        RegularClipboard = 415,
        ///<summary>Solid Clipboard with Check</summary>
        ///<see href="https://fontawesome.com/icons/clipboard-check?style=solid"/>
        [Description("Solid Clipboard with Check"), IconID("fas-clipboard-check"), IconUnicodeGlyph(0xf46c)]
        SolidClipboardCheck = 416,
        ///<summary>Solid Clipboard List</summary>
        ///<see href="https://fontawesome.com/icons/clipboard-list?style=solid"/>
        [Description("Solid Clipboard List"), IconID("fas-clipboard-list"), IconUnicodeGlyph(0xf46d)]
        SolidClipboardList = 417,
        ///<summary>Solid Clipboard Question</summary>
        ///<see href="https://fontawesome.com/icons/clipboard-question?style=solid"/>
        [Description("Solid Clipboard Question"), IconID("fas-clipboard-question"), IconUnicodeGlyph(0xe4e3)]
        SolidClipboardQuestion = 418,
        ///<summary>Solid Clipboard with User</summary>
        ///<see href="https://fontawesome.com/icons/clipboard-user?style=solid"/>
        [Description("Solid Clipboard with User"), IconID("fas-clipboard-user"), IconUnicodeGlyph(0xf7f3)]
        SolidClipboardUser = 419,
        ///<summary>Solid Clock</summary>
        ///<see href="https://fontawesome.com/icons/clock?style=solid"/>
        [Description("Solid Clock"), IconID("fas-clock"), IconUnicodeGlyph(0xf017)]
        SolidClock = 420,
        ///<summary>Regular Clock</summary>
        ///<see href="https://fontawesome.com/icons/clock?style=regular"/>
        [Description("Regular Clock"), IconID("far-clock"), IconUnicodeGlyph(0xf017)]
        RegularClock = 421,
        ///<summary>Solid Clock Rotate Left</summary>
        ///<see href="https://fontawesome.com/icons/clock-rotate-left?style=solid"/>
        [Description("Solid Clock Rotate Left"), IconID("fas-clock-rotate-left"), IconUnicodeGlyph(0xf1da)]
        SolidClockRotateLeft = 422,
        ///<summary>Solid Clone</summary>
        ///<see href="https://fontawesome.com/icons/clone?style=solid"/>
        [Description("Solid Clone"), IconID("fas-clone"), IconUnicodeGlyph(0xf24d)]
        SolidClone = 423,
        ///<summary>Regular Clone</summary>
        ///<see href="https://fontawesome.com/icons/clone?style=regular"/>
        [Description("Regular Clone"), IconID("far-clone"), IconUnicodeGlyph(0xf24d)]
        RegularClone = 424,
        ///<summary>Solid Closed Captioning</summary>
        ///<see href="https://fontawesome.com/icons/closed-captioning?style=solid"/>
        [Description("Solid Closed Captioning"), IconID("fas-closed-captioning"), IconUnicodeGlyph(0xf20a)]
        SolidClosedCaptioning = 425,
        ///<summary>Regular Closed Captioning</summary>
        ///<see href="https://fontawesome.com/icons/closed-captioning?style=regular"/>
        [Description("Regular Closed Captioning"), IconID("far-closed-captioning"), IconUnicodeGlyph(0xf20a)]
        RegularClosedCaptioning = 426,
        ///<summary>Solid Cloud</summary>
        ///<see href="https://fontawesome.com/icons/cloud?style=solid"/>
        [Description("Solid Cloud"), IconID("fas-cloud"), IconUnicodeGlyph(0xf0c2)]
        SolidCloud = 427,
        ///<summary>Solid Cloud arrow down</summary>
        ///<see href="https://fontawesome.com/icons/cloud-arrow-down?style=solid"/>
        [Description("Solid Cloud arrow down"), IconID("fas-cloud-arrow-down"), IconUnicodeGlyph(0xf0ed)]
        SolidCloudArrowDown = 428,
        ///<summary>Solid Cloud arrow up</summary>
        ///<see href="https://fontawesome.com/icons/cloud-arrow-up?style=solid"/>
        [Description("Solid Cloud arrow up"), IconID("fas-cloud-arrow-up"), IconUnicodeGlyph(0xf0ee)]
        SolidCloudArrowUp = 429,
        ///<summary>Solid Cloud bolt</summary>
        ///<see href="https://fontawesome.com/icons/cloud-bolt?style=solid"/>
        [Description("Solid Cloud bolt"), IconID("fas-cloud-bolt"), IconUnicodeGlyph(0xf76c)]
        SolidCloudBolt = 430,
        ///<summary>Solid Cloud with (a chance of) Meatball</summary>
        ///<see href="https://fontawesome.com/icons/cloud-meatball?style=solid"/>
        [Description("Solid Cloud with (a chance of) Meatball"), IconID("fas-cloud-meatball"), IconUnicodeGlyph(0xf73b)]
        SolidCloudMeatball = 431,
        ///<summary>Solid Cloud with Moon</summary>
        ///<see href="https://fontawesome.com/icons/cloud-moon?style=solid"/>
        [Description("Solid Cloud with Moon"), IconID("fas-cloud-moon"), IconUnicodeGlyph(0xf6c3)]
        SolidCloudMoon = 432,
        ///<summary>Solid Cloud with Moon and Rain</summary>
        ///<see href="https://fontawesome.com/icons/cloud-moon-rain?style=solid"/>
        [Description("Solid Cloud with Moon and Rain"), IconID("fas-cloud-moon-rain"), IconUnicodeGlyph(0xf73c)]
        SolidCloudMoonRain = 433,
        ///<summary>Solid Cloud with Rain</summary>
        ///<see href="https://fontawesome.com/icons/cloud-rain?style=solid"/>
        [Description("Solid Cloud with Rain"), IconID("fas-cloud-rain"), IconUnicodeGlyph(0xf73d)]
        SolidCloudRain = 434,
        ///<summary>Solid Cloud with Heavy Showers</summary>
        ///<see href="https://fontawesome.com/icons/cloud-showers-heavy?style=solid"/>
        [Description("Solid Cloud with Heavy Showers"), IconID("fas-cloud-showers-heavy"), IconUnicodeGlyph(0xf740)]
        SolidCloudShowersHeavy = 435,
        ///<summary>Solid Cloud Showers-water</summary>
        ///<see href="https://fontawesome.com/icons/cloud-showers-water?style=solid"/>
        [Description("Solid Cloud Showers-water"), IconID("fas-cloud-showers-water"), IconUnicodeGlyph(0xe4e4)]
        SolidCloudShowersWater = 436,
        ///<summary>Solid Cloud with Sun</summary>
        ///<see href="https://fontawesome.com/icons/cloud-sun?style=solid"/>
        [Description("Solid Cloud with Sun"), IconID("fas-cloud-sun"), IconUnicodeGlyph(0xf6c4)]
        SolidCloudSun = 437,
        ///<summary>Solid Cloud with Sun and Rain</summary>
        ///<see href="https://fontawesome.com/icons/cloud-sun-rain?style=solid"/>
        [Description("Solid Cloud with Sun and Rain"), IconID("fas-cloud-sun-rain"), IconUnicodeGlyph(0xf743)]
        SolidCloudSunRain = 438,
        ///<summary>Brands Cloudflare</summary>
        ///<see href="https://fontawesome.com/icons/cloudflare?style=brands"/>
        [Description("Brands Cloudflare"), IconID("fab-cloudflare"), IconUnicodeGlyph(0xe07d)]
        BrandsCloudflare = 439,
        ///<summary>Brands cloudscale.ch</summary>
        ///<see href="https://fontawesome.com/icons/cloudscale?style=brands"/>
        [Description("Brands cloudscale.ch"), IconID("fab-cloudscale"), IconUnicodeGlyph(0xf383)]
        BrandsCloudscale = 440,
        ///<summary>Brands Cloudsmith</summary>
        ///<see href="https://fontawesome.com/icons/cloudsmith?style=brands"/>
        [Description("Brands Cloudsmith"), IconID("fab-cloudsmith"), IconUnicodeGlyph(0xf384)]
        BrandsCloudsmith = 441,
        ///<summary>Brands cloudversify</summary>
        ///<see href="https://fontawesome.com/icons/cloudversify?style=brands"/>
        [Description("Brands cloudversify"), IconID("fab-cloudversify"), IconUnicodeGlyph(0xf385)]
        BrandsCloudversify = 442,
        ///<summary>Solid Clover</summary>
        ///<see href="https://fontawesome.com/icons/clover?style=solid"/>
        [Description("Solid Clover"), IconID("fas-clover"), IconUnicodeGlyph(0xe139)]
        SolidClover = 443,
        ///<summary>Brands Cmplid</summary>
        ///<see href="https://fontawesome.com/icons/cmplid?style=brands"/>
        [Description("Brands Cmplid"), IconID("fab-cmplid"), IconUnicodeGlyph(0xe360)]
        BrandsCmplid = 444,
        ///<summary>Solid Code</summary>
        ///<see href="https://fontawesome.com/icons/code?style=solid"/>
        [Description("Solid Code"), IconID("fas-code"), IconUnicodeGlyph(0xf121)]
        SolidCode = 445,
        ///<summary>Solid Code Branch</summary>
        ///<see href="https://fontawesome.com/icons/code-branch?style=solid"/>
        [Description("Solid Code Branch"), IconID("fas-code-branch"), IconUnicodeGlyph(0xf126)]
        SolidCodeBranch = 446,
        ///<summary>Solid Code Commit</summary>
        ///<see href="https://fontawesome.com/icons/code-commit?style=solid"/>
        [Description("Solid Code Commit"), IconID("fas-code-commit"), IconUnicodeGlyph(0xf386)]
        SolidCodeCommit = 447,
        ///<summary>Solid Code Compare</summary>
        ///<see href="https://fontawesome.com/icons/code-compare?style=solid"/>
        [Description("Solid Code Compare"), IconID("fas-code-compare"), IconUnicodeGlyph(0xe13a)]
        SolidCodeCompare = 448,
        ///<summary>Solid Code Fork</summary>
        ///<see href="https://fontawesome.com/icons/code-fork?style=solid"/>
        [Description("Solid Code Fork"), IconID("fas-code-fork"), IconUnicodeGlyph(0xe13b)]
        SolidCodeFork = 449,
        ///<summary>Solid Code Merge</summary>
        ///<see href="https://fontawesome.com/icons/code-merge?style=solid"/>
        [Description("Solid Code Merge"), IconID("fas-code-merge"), IconUnicodeGlyph(0xf387)]
        SolidCodeMerge = 450,
        ///<summary>Solid Code Pull Request</summary>
        ///<see href="https://fontawesome.com/icons/code-pull-request?style=solid"/>
        [Description("Solid Code Pull Request"), IconID("fas-code-pull-request"), IconUnicodeGlyph(0xe13c)]
        SolidCodePullRequest = 451,
        ///<summary>Brands Codepen</summary>
        ///<see href="https://fontawesome.com/icons/codepen?style=brands"/>
        [Description("Brands Codepen"), IconID("fab-codepen"), IconUnicodeGlyph(0xf1cb)]
        BrandsCodepen = 452,
        ///<summary>Brands Codie Pie</summary>
        ///<see href="https://fontawesome.com/icons/codiepie?style=brands"/>
        [Description("Brands Codie Pie"), IconID("fab-codiepie"), IconUnicodeGlyph(0xf284)]
        BrandsCodiepie = 453,
        ///<summary>Solid Coins</summary>
        ///<see href="https://fontawesome.com/icons/coins?style=solid"/>
        [Description("Solid Coins"), IconID("fas-coins"), IconUnicodeGlyph(0xf51e)]
        SolidCoins = 454,
        ///<summary>Solid Colon Sign</summary>
        ///<see href="https://fontawesome.com/icons/colon-sign?style=solid"/>
        [Description("Solid Colon Sign"), IconID("fas-colon-sign"), IconUnicodeGlyph(0xe140)]
        SolidColonSign = 455,
        ///<summary>Solid comment</summary>
        ///<see href="https://fontawesome.com/icons/comment?style=solid"/>
        [Description("Solid comment"), IconID("fas-comment"), IconUnicodeGlyph(0xf075)]
        SolidComment = 456,
        ///<summary>Regular comment</summary>
        ///<see href="https://fontawesome.com/icons/comment?style=regular"/>
        [Description("Regular comment"), IconID("far-comment"), IconUnicodeGlyph(0xf075)]
        RegularComment = 457,
        ///<summary>Solid Comment Dollar</summary>
        ///<see href="https://fontawesome.com/icons/comment-dollar?style=solid"/>
        [Description("Solid Comment Dollar"), IconID("fas-comment-dollar"), IconUnicodeGlyph(0xf651)]
        SolidCommentDollar = 458,
        ///<summary>Solid Comment Dots</summary>
        ///<see href="https://fontawesome.com/icons/comment-dots?style=solid"/>
        [Description("Solid Comment Dots"), IconID("fas-comment-dots"), IconUnicodeGlyph(0xf4ad)]
        SolidCommentDots = 459,
        ///<summary>Regular Comment Dots</summary>
        ///<see href="https://fontawesome.com/icons/comment-dots?style=regular"/>
        [Description("Regular Comment Dots"), IconID("far-comment-dots"), IconUnicodeGlyph(0xf4ad)]
        RegularCommentDots = 460,
        ///<summary>Solid Alternate Medical Chat</summary>
        ///<see href="https://fontawesome.com/icons/comment-medical?style=solid"/>
        [Description("Solid Alternate Medical Chat"), IconID("fas-comment-medical"), IconUnicodeGlyph(0xf7f5)]
        SolidCommentMedical = 461,
        ///<summary>Solid Comment Slash</summary>
        ///<see href="https://fontawesome.com/icons/comment-slash?style=solid"/>
        [Description("Solid Comment Slash"), IconID("fas-comment-slash"), IconUnicodeGlyph(0xf4b3)]
        SolidCommentSlash = 462,
        ///<summary>Solid Comment sms</summary>
        ///<see href="https://fontawesome.com/icons/comment-sms?style=solid"/>
        [Description("Solid Comment sms"), IconID("fas-comment-sms"), IconUnicodeGlyph(0xf7cd)]
        SolidCommentSms = 463,
        ///<summary>Solid comments</summary>
        ///<see href="https://fontawesome.com/icons/comments?style=solid"/>
        [Description("Solid comments"), IconID("fas-comments"), IconUnicodeGlyph(0xf086)]
        SolidComments = 464,
        ///<summary>Regular comments</summary>
        ///<see href="https://fontawesome.com/icons/comments?style=regular"/>
        [Description("Regular comments"), IconID("far-comments"), IconUnicodeGlyph(0xf086)]
        RegularComments = 465,
        ///<summary>Solid Comments Dollar</summary>
        ///<see href="https://fontawesome.com/icons/comments-dollar?style=solid"/>
        [Description("Solid Comments Dollar"), IconID("fas-comments-dollar"), IconUnicodeGlyph(0xf653)]
        SolidCommentsDollar = 466,
        ///<summary>Solid Compact Disc</summary>
        ///<see href="https://fontawesome.com/icons/compact-disc?style=solid"/>
        [Description("Solid Compact Disc"), IconID("fas-compact-disc"), IconUnicodeGlyph(0xf51f)]
        SolidCompactDisc = 467,
        ///<summary>Solid Compass</summary>
        ///<see href="https://fontawesome.com/icons/compass?style=solid"/>
        [Description("Solid Compass"), IconID("fas-compass"), IconUnicodeGlyph(0xf14e)]
        SolidCompass = 468,
        ///<summary>Regular Compass</summary>
        ///<see href="https://fontawesome.com/icons/compass?style=regular"/>
        [Description("Regular Compass"), IconID("far-compass"), IconUnicodeGlyph(0xf14e)]
        RegularCompass = 469,
        ///<summary>Solid Compass drafting</summary>
        ///<see href="https://fontawesome.com/icons/compass-drafting?style=solid"/>
        [Description("Solid Compass drafting"), IconID("fas-compass-drafting"), IconUnicodeGlyph(0xf568)]
        SolidCompassDrafting = 470,
        ///<summary>Solid Compress</summary>
        ///<see href="https://fontawesome.com/icons/compress?style=solid"/>
        [Description("Solid Compress"), IconID("fas-compress"), IconUnicodeGlyph(0xf066)]
        SolidCompress = 471,
        ///<summary>Solid Computer</summary>
        ///<see href="https://fontawesome.com/icons/computer?style=solid"/>
        [Description("Solid Computer"), IconID("fas-computer"), IconUnicodeGlyph(0xe4e5)]
        SolidComputer = 472,
        ///<summary>Solid Computer mouse</summary>
        ///<see href="https://fontawesome.com/icons/computer-mouse?style=solid"/>
        [Description("Solid Computer mouse"), IconID("fas-computer-mouse"), IconUnicodeGlyph(0xf8cc)]
        SolidComputerMouse = 473,
        ///<summary>Brands Confluence</summary>
        ///<see href="https://fontawesome.com/icons/confluence?style=brands"/>
        [Description("Brands Confluence"), IconID("fab-confluence"), IconUnicodeGlyph(0xf78d)]
        BrandsConfluence = 474,
        ///<summary>Brands Connect Develop</summary>
        ///<see href="https://fontawesome.com/icons/connectdevelop?style=brands"/>
        [Description("Brands Connect Develop"), IconID("fab-connectdevelop"), IconUnicodeGlyph(0xf20e)]
        BrandsConnectdevelop = 475,
        ///<summary>Brands Contao</summary>
        ///<see href="https://fontawesome.com/icons/contao?style=brands"/>
        [Description("Brands Contao"), IconID("fab-contao"), IconUnicodeGlyph(0xf26d)]
        BrandsContao = 476,
        ///<summary>Solid Cookie</summary>
        ///<see href="https://fontawesome.com/icons/cookie?style=solid"/>
        [Description("Solid Cookie"), IconID("fas-cookie"), IconUnicodeGlyph(0xf563)]
        SolidCookie = 477,
        ///<summary>Solid Cookie Bite</summary>
        ///<see href="https://fontawesome.com/icons/cookie-bite?style=solid"/>
        [Description("Solid Cookie Bite"), IconID("fas-cookie-bite"), IconUnicodeGlyph(0xf564)]
        SolidCookieBite = 478,
        ///<summary>Solid Copy</summary>
        ///<see href="https://fontawesome.com/icons/copy?style=solid"/>
        [Description("Solid Copy"), IconID("fas-copy"), IconUnicodeGlyph(0xf0c5)]
        SolidCopy = 479,
        ///<summary>Regular Copy</summary>
        ///<see href="https://fontawesome.com/icons/copy?style=regular"/>
        [Description("Regular Copy"), IconID("far-copy"), IconUnicodeGlyph(0xf0c5)]
        RegularCopy = 480,
        ///<summary>Solid Copyright</summary>
        ///<see href="https://fontawesome.com/icons/copyright?style=solid"/>
        [Description("Solid Copyright"), IconID("fas-copyright"), IconUnicodeGlyph(0xf1f9)]
        SolidCopyright = 481,
        ///<summary>Regular Copyright</summary>
        ///<see href="https://fontawesome.com/icons/copyright?style=regular"/>
        [Description("Regular Copyright"), IconID("far-copyright"), IconUnicodeGlyph(0xf1f9)]
        RegularCopyright = 482,
        ///<summary>Brands Cotton Bureau</summary>
        ///<see href="https://fontawesome.com/icons/cotton-bureau?style=brands"/>
        [Description("Brands Cotton Bureau"), IconID("fab-cotton-bureau"), IconUnicodeGlyph(0xf89e)]
        BrandsCottonBureau = 483,
        ///<summary>Solid Couch</summary>
        ///<see href="https://fontawesome.com/icons/couch?style=solid"/>
        [Description("Solid Couch"), IconID("fas-couch"), IconUnicodeGlyph(0xf4b8)]
        SolidCouch = 484,
        ///<summary>Solid Cow</summary>
        ///<see href="https://fontawesome.com/icons/cow?style=solid"/>
        [Description("Solid Cow"), IconID("fas-cow"), IconUnicodeGlyph(0xf6c8)]
        SolidCow = 485,
        ///<summary>Brands cPanel</summary>
        ///<see href="https://fontawesome.com/icons/cpanel?style=brands"/>
        [Description("Brands cPanel"), IconID("fab-cpanel"), IconUnicodeGlyph(0xf388)]
        BrandsCpanel = 486,
        ///<summary>Brands Creative Commons</summary>
        ///<see href="https://fontawesome.com/icons/creative-commons?style=brands"/>
        [Description("Brands Creative Commons"), IconID("fab-creative-commons"), IconUnicodeGlyph(0xf25e)]
        BrandsCreativeCommons = 487,
        ///<summary>Brands Creative Commons Attribution</summary>
        ///<see href="https://fontawesome.com/icons/creative-commons-by?style=brands"/>
        [Description("Brands Creative Commons Attribution"), IconID("fab-creative-commons-by"), IconUnicodeGlyph(0xf4e7)]
        BrandsCreativeCommonsBy = 488,
        ///<summary>Brands Creative Commons Noncommercial</summary>
        ///<see href="https://fontawesome.com/icons/creative-commons-nc?style=brands"/>
        [Description("Brands Creative Commons Noncommercial"), IconID("fab-creative-commons-nc"), IconUnicodeGlyph(0xf4e8)]
        BrandsCreativeCommonsNc = 489,
        ///<summary>Brands Creative Commons Noncommercial (Euro Sign)</summary>
        ///<see href="https://fontawesome.com/icons/creative-commons-nc-eu?style=brands"/>
        [Description("Brands Creative Commons Noncommercial (Euro Sign)"), IconID("fab-creative-commons-nc-eu"), IconUnicodeGlyph(0xf4e9)]
        BrandsCreativeCommonsNcEu = 490,
        ///<summary>Brands Creative Commons Noncommercial (Yen Sign)</summary>
        ///<see href="https://fontawesome.com/icons/creative-commons-nc-jp?style=brands"/>
        [Description("Brands Creative Commons Noncommercial (Yen Sign)"), IconID("fab-creative-commons-nc-jp"), IconUnicodeGlyph(0xf4ea)]
        BrandsCreativeCommonsNcJp = 491,
        ///<summary>Brands Creative Commons No Derivative Works</summary>
        ///<see href="https://fontawesome.com/icons/creative-commons-nd?style=brands"/>
        [Description("Brands Creative Commons No Derivative Works"), IconID("fab-creative-commons-nd"), IconUnicodeGlyph(0xf4eb)]
        BrandsCreativeCommonsNd = 492,
        ///<summary>Brands Creative Commons Public Domain</summary>
        ///<see href="https://fontawesome.com/icons/creative-commons-pd?style=brands"/>
        [Description("Brands Creative Commons Public Domain"), IconID("fab-creative-commons-pd"), IconUnicodeGlyph(0xf4ec)]
        BrandsCreativeCommonsPd = 493,
        ///<summary>Brands Alternate Creative Commons Public Domain</summary>
        ///<see href="https://fontawesome.com/icons/creative-commons-pd-alt?style=brands"/>
        [Description("Brands Alternate Creative Commons Public Domain"), IconID("fab-creative-commons-pd-alt"), IconUnicodeGlyph(0xf4ed)]
        BrandsCreativeCommonsPdAlt = 494,
        ///<summary>Brands Creative Commons Remix</summary>
        ///<see href="https://fontawesome.com/icons/creative-commons-remix?style=brands"/>
        [Description("Brands Creative Commons Remix"), IconID("fab-creative-commons-remix"), IconUnicodeGlyph(0xf4ee)]
        BrandsCreativeCommonsRemix = 495,
        ///<summary>Brands Creative Commons Share Alike</summary>
        ///<see href="https://fontawesome.com/icons/creative-commons-sa?style=brands"/>
        [Description("Brands Creative Commons Share Alike"), IconID("fab-creative-commons-sa"), IconUnicodeGlyph(0xf4ef)]
        BrandsCreativeCommonsSa = 496,
        ///<summary>Brands Creative Commons Sampling</summary>
        ///<see href="https://fontawesome.com/icons/creative-commons-sampling?style=brands"/>
        [Description("Brands Creative Commons Sampling"), IconID("fab-creative-commons-sampling"), IconUnicodeGlyph(0xf4f0)]
        BrandsCreativeCommonsSampling = 497,
        ///<summary>Brands Creative Commons Sampling +</summary>
        ///<see href="https://fontawesome.com/icons/creative-commons-sampling-plus?style=brands"/>
        [Description("Brands Creative Commons Sampling +"), IconID("fab-creative-commons-sampling-plus"), IconUnicodeGlyph(0xf4f1)]
        BrandsCreativeCommonsSamplingPlus = 498,
        ///<summary>Brands Creative Commons Share</summary>
        ///<see href="https://fontawesome.com/icons/creative-commons-share?style=brands"/>
        [Description("Brands Creative Commons Share"), IconID("fab-creative-commons-share"), IconUnicodeGlyph(0xf4f2)]
        BrandsCreativeCommonsShare = 499,
        ///<summary>Brands Creative Commons CC0</summary>
        ///<see href="https://fontawesome.com/icons/creative-commons-zero?style=brands"/>
        [Description("Brands Creative Commons CC0"), IconID("fab-creative-commons-zero"), IconUnicodeGlyph(0xf4f3)]
        BrandsCreativeCommonsZero = 500,
        ///<summary>Solid Credit Card</summary>
        ///<see href="https://fontawesome.com/icons/credit-card?style=solid"/>
        [Description("Solid Credit Card"), IconID("fas-credit-card"), IconUnicodeGlyph(0xf09d)]
        SolidCreditCard = 501,
        ///<summary>Regular Credit Card</summary>
        ///<see href="https://fontawesome.com/icons/credit-card?style=regular"/>
        [Description("Regular Credit Card"), IconID("far-credit-card"), IconUnicodeGlyph(0xf09d)]
        RegularCreditCard = 502,
        ///<summary>Brands Critical Role</summary>
        ///<see href="https://fontawesome.com/icons/critical-role?style=brands"/>
        [Description("Brands Critical Role"), IconID("fab-critical-role"), IconUnicodeGlyph(0xf6c9)]
        BrandsCriticalRole = 503,
        ///<summary>Solid crop</summary>
        ///<see href="https://fontawesome.com/icons/crop?style=solid"/>
        [Description("Solid crop"), IconID("fas-crop"), IconUnicodeGlyph(0xf125)]
        SolidCrop = 504,
        ///<summary>Solid Crop simple</summary>
        ///<see href="https://fontawesome.com/icons/crop-simple?style=solid"/>
        [Description("Solid Crop simple"), IconID("fas-crop-simple"), IconUnicodeGlyph(0xf565)]
        SolidCropSimple = 505,
        ///<summary>Solid Cross</summary>
        ///<see href="https://fontawesome.com/icons/cross?style=solid"/>
        [Description("Solid Cross"), IconID("fas-cross"), IconUnicodeGlyph(0xf654)]
        SolidCross = 506,
        ///<summary>Solid Crosshairs</summary>
        ///<see href="https://fontawesome.com/icons/crosshairs?style=solid"/>
        [Description("Solid Crosshairs"), IconID("fas-crosshairs"), IconUnicodeGlyph(0xf05b)]
        SolidCrosshairs = 507,
        ///<summary>Solid Crow</summary>
        ///<see href="https://fontawesome.com/icons/crow?style=solid"/>
        [Description("Solid Crow"), IconID("fas-crow"), IconUnicodeGlyph(0xf520)]
        SolidCrow = 508,
        ///<summary>Solid Crown</summary>
        ///<see href="https://fontawesome.com/icons/crown?style=solid"/>
        [Description("Solid Crown"), IconID("fas-crown"), IconUnicodeGlyph(0xf521)]
        SolidCrown = 509,
        ///<summary>Solid Crutch</summary>
        ///<see href="https://fontawesome.com/icons/crutch?style=solid"/>
        [Description("Solid Crutch"), IconID("fas-crutch"), IconUnicodeGlyph(0xf7f7)]
        SolidCrutch = 510,
        ///<summary>Solid Cruzeiro Sign</summary>
        ///<see href="https://fontawesome.com/icons/cruzeiro-sign?style=solid"/>
        [Description("Solid Cruzeiro Sign"), IconID("fas-cruzeiro-sign"), IconUnicodeGlyph(0xe152)]
        SolidCruzeiroSign = 511,
        ///<summary>Brands CSS 3 Logo</summary>
        ///<see href="https://fontawesome.com/icons/css3?style=brands"/>
        [Description("Brands CSS 3 Logo"), IconID("fab-css3"), IconUnicodeGlyph(0xf13c)]
        BrandsCss3 = 512,
        ///<summary>Brands Alternate CSS3 Logo</summary>
        ///<see href="https://fontawesome.com/icons/css3-alt?style=brands"/>
        [Description("Brands Alternate CSS3 Logo"), IconID("fab-css3-alt"), IconUnicodeGlyph(0xf38b)]
        BrandsCss3Alt = 513,
        ///<summary>Solid Cube</summary>
        ///<see href="https://fontawesome.com/icons/cube?style=solid"/>
        [Description("Solid Cube"), IconID("fas-cube"), IconUnicodeGlyph(0xf1b2)]
        SolidCube = 514,
        ///<summary>Solid Cubes</summary>
        ///<see href="https://fontawesome.com/icons/cubes?style=solid"/>
        [Description("Solid Cubes"), IconID("fas-cubes"), IconUnicodeGlyph(0xf1b3)]
        SolidCubes = 515,
        ///<summary>Solid Cubes Stacked</summary>
        ///<see href="https://fontawesome.com/icons/cubes-stacked?style=solid"/>
        [Description("Solid Cubes Stacked"), IconID("fas-cubes-stacked"), IconUnicodeGlyph(0xe4e6)]
        SolidCubesStacked = 516,
        ///<summary>Brands Cuttlefish</summary>
        ///<see href="https://fontawesome.com/icons/cuttlefish?style=brands"/>
        [Description("Brands Cuttlefish"), IconID("fab-cuttlefish"), IconUnicodeGlyph(0xf38c)]
        BrandsCuttlefish = 517,
        ///<summary>Solid D</summary>
        ///<see href="https://fontawesome.com/icons/d?style=solid"/>
        [Description("Solid D"), IconID("fas-d"), IconUnicodeGlyph(0x44)]
        SolidD = 518,
        ///<summary>Brands Dungeons & Dragons</summary>
        ///<see href="https://fontawesome.com/icons/d-and-d?style=brands"/>
        [Description("Brands Dungeons & Dragons"), IconID("fab-d-and-d"), IconUnicodeGlyph(0xf38d)]
        BrandsDAndD = 519,
        ///<summary>Brands D&D Beyond</summary>
        ///<see href="https://fontawesome.com/icons/d-and-d-beyond?style=brands"/>
        [Description("Brands D&D Beyond"), IconID("fab-d-and-d-beyond"), IconUnicodeGlyph(0xf6ca)]
        BrandsDAndDBeyond = 520,
        ///<summary>Brands dailymotion</summary>
        ///<see href="https://fontawesome.com/icons/dailymotion?style=brands"/>
        [Description("Brands dailymotion"), IconID("fab-dailymotion"), IconUnicodeGlyph(0xe052)]
        BrandsDailymotion = 521,
        ///<summary>Brands DashCube</summary>
        ///<see href="https://fontawesome.com/icons/dashcube?style=brands"/>
        [Description("Brands DashCube"), IconID("fab-dashcube"), IconUnicodeGlyph(0xf210)]
        BrandsDashcube = 522,
        ///<summary>Solid Database</summary>
        ///<see href="https://fontawesome.com/icons/database?style=solid"/>
        [Description("Solid Database"), IconID("fas-database"), IconUnicodeGlyph(0xf1c0)]
        SolidDatabase = 523,
        ///<summary>Brands Deezer</summary>
        ///<see href="https://fontawesome.com/icons/deezer?style=brands"/>
        [Description("Brands Deezer"), IconID("fab-deezer"), IconUnicodeGlyph(0xe077)]
        BrandsDeezer = 524,
        ///<summary>Solid Delete left</summary>
        ///<see href="https://fontawesome.com/icons/delete-left?style=solid"/>
        [Description("Solid Delete left"), IconID("fas-delete-left"), IconUnicodeGlyph(0xf55a)]
        SolidDeleteLeft = 525,
        ///<summary>Brands Delicious</summary>
        ///<see href="https://fontawesome.com/icons/delicious?style=brands"/>
        [Description("Brands Delicious"), IconID("fab-delicious"), IconUnicodeGlyph(0xf1a5)]
        BrandsDelicious = 526,
        ///<summary>Solid Democrat</summary>
        ///<see href="https://fontawesome.com/icons/democrat?style=solid"/>
        [Description("Solid Democrat"), IconID("fas-democrat"), IconUnicodeGlyph(0xf747)]
        SolidDemocrat = 527,
        ///<summary>Brands deploy.dog</summary>
        ///<see href="https://fontawesome.com/icons/deploydog?style=brands"/>
        [Description("Brands deploy.dog"), IconID("fab-deploydog"), IconUnicodeGlyph(0xf38e)]
        BrandsDeploydog = 528,
        ///<summary>Brands Deskpro</summary>
        ///<see href="https://fontawesome.com/icons/deskpro?style=brands"/>
        [Description("Brands Deskpro"), IconID("fab-deskpro"), IconUnicodeGlyph(0xf38f)]
        BrandsDeskpro = 529,
        ///<summary>Solid Desktop</summary>
        ///<see href="https://fontawesome.com/icons/desktop?style=solid"/>
        [Description("Solid Desktop"), IconID("fas-desktop"), IconUnicodeGlyph(0xf390)]
        SolidDesktop = 530,
        ///<summary>Brands DEV</summary>
        ///<see href="https://fontawesome.com/icons/dev?style=brands"/>
        [Description("Brands DEV"), IconID("fab-dev"), IconUnicodeGlyph(0xf6cc)]
        BrandsDev = 531,
        ///<summary>Brands deviantART</summary>
        ///<see href="https://fontawesome.com/icons/deviantart?style=brands"/>
        [Description("Brands deviantART"), IconID("fab-deviantart"), IconUnicodeGlyph(0xf1bd)]
        BrandsDeviantart = 532,
        ///<summary>Solid Dharmachakra</summary>
        ///<see href="https://fontawesome.com/icons/dharmachakra?style=solid"/>
        [Description("Solid Dharmachakra"), IconID("fas-dharmachakra"), IconUnicodeGlyph(0xf655)]
        SolidDharmachakra = 533,
        ///<summary>Brands DHL</summary>
        ///<see href="https://fontawesome.com/icons/dhl?style=brands"/>
        [Description("Brands DHL"), IconID("fab-dhl"), IconUnicodeGlyph(0xf790)]
        BrandsDhl = 534,
        ///<summary>Solid Diagram Next</summary>
        ///<see href="https://fontawesome.com/icons/diagram-next?style=solid"/>
        [Description("Solid Diagram Next"), IconID("fas-diagram-next"), IconUnicodeGlyph(0xe476)]
        SolidDiagramNext = 535,
        ///<summary>Solid Diagram Predecessor</summary>
        ///<see href="https://fontawesome.com/icons/diagram-predecessor?style=solid"/>
        [Description("Solid Diagram Predecessor"), IconID("fas-diagram-predecessor"), IconUnicodeGlyph(0xe477)]
        SolidDiagramPredecessor = 536,
        ///<summary>Solid Project Diagram</summary>
        ///<see href="https://fontawesome.com/icons/diagram-project?style=solid"/>
        [Description("Solid Project Diagram"), IconID("fas-diagram-project"), IconUnicodeGlyph(0xf542)]
        SolidDiagramProject = 537,
        ///<summary>Solid Diagram Successor</summary>
        ///<see href="https://fontawesome.com/icons/diagram-successor?style=solid"/>
        [Description("Solid Diagram Successor"), IconID("fas-diagram-successor"), IconUnicodeGlyph(0xe47a)]
        SolidDiagramSuccessor = 538,
        ///<summary>Solid Diamond</summary>
        ///<see href="https://fontawesome.com/icons/diamond?style=solid"/>
        [Description("Solid Diamond"), IconID("fas-diamond"), IconUnicodeGlyph(0xf219)]
        SolidDiamond = 539,
        ///<summary>Solid Diamond turn right</summary>
        ///<see href="https://fontawesome.com/icons/diamond-turn-right?style=solid"/>
        [Description("Solid Diamond turn right"), IconID("fas-diamond-turn-right"), IconUnicodeGlyph(0xf5eb)]
        SolidDiamondTurnRight = 540,
        ///<summary>Brands Diaspora</summary>
        ///<see href="https://fontawesome.com/icons/diaspora?style=brands"/>
        [Description("Brands Diaspora"), IconID("fab-diaspora"), IconUnicodeGlyph(0xf791)]
        BrandsDiaspora = 541,
        ///<summary>Solid Dice</summary>
        ///<see href="https://fontawesome.com/icons/dice?style=solid"/>
        [Description("Solid Dice"), IconID("fas-dice"), IconUnicodeGlyph(0xf522)]
        SolidDice = 542,
        ///<summary>Solid Dice D20</summary>
        ///<see href="https://fontawesome.com/icons/dice-d20?style=solid"/>
        [Description("Solid Dice D20"), IconID("fas-dice-d20"), IconUnicodeGlyph(0xf6cf)]
        SolidDiceD20 = 543,
        ///<summary>Solid Dice D6</summary>
        ///<see href="https://fontawesome.com/icons/dice-d6?style=solid"/>
        [Description("Solid Dice D6"), IconID("fas-dice-d6"), IconUnicodeGlyph(0xf6d1)]
        SolidDiceD6 = 544,
        ///<summary>Solid Dice Five</summary>
        ///<see href="https://fontawesome.com/icons/dice-five?style=solid"/>
        [Description("Solid Dice Five"), IconID("fas-dice-five"), IconUnicodeGlyph(0xf523)]
        SolidDiceFive = 545,
        ///<summary>Solid Dice Four</summary>
        ///<see href="https://fontawesome.com/icons/dice-four?style=solid"/>
        [Description("Solid Dice Four"), IconID("fas-dice-four"), IconUnicodeGlyph(0xf524)]
        SolidDiceFour = 546,
        ///<summary>Solid Dice One</summary>
        ///<see href="https://fontawesome.com/icons/dice-one?style=solid"/>
        [Description("Solid Dice One"), IconID("fas-dice-one"), IconUnicodeGlyph(0xf525)]
        SolidDiceOne = 547,
        ///<summary>Solid Dice Six</summary>
        ///<see href="https://fontawesome.com/icons/dice-six?style=solid"/>
        [Description("Solid Dice Six"), IconID("fas-dice-six"), IconUnicodeGlyph(0xf526)]
        SolidDiceSix = 548,
        ///<summary>Solid Dice Three</summary>
        ///<see href="https://fontawesome.com/icons/dice-three?style=solid"/>
        [Description("Solid Dice Three"), IconID("fas-dice-three"), IconUnicodeGlyph(0xf527)]
        SolidDiceThree = 549,
        ///<summary>Solid Dice Two</summary>
        ///<see href="https://fontawesome.com/icons/dice-two?style=solid"/>
        [Description("Solid Dice Two"), IconID("fas-dice-two"), IconUnicodeGlyph(0xf528)]
        SolidDiceTwo = 550,
        ///<summary>Brands Digg Logo</summary>
        ///<see href="https://fontawesome.com/icons/digg?style=brands"/>
        [Description("Brands Digg Logo"), IconID("fab-digg"), IconUnicodeGlyph(0xf1a6)]
        BrandsDigg = 551,
        ///<summary>Brands Digital Ocean</summary>
        ///<see href="https://fontawesome.com/icons/digital-ocean?style=brands"/>
        [Description("Brands Digital Ocean"), IconID("fab-digital-ocean"), IconUnicodeGlyph(0xf391)]
        BrandsDigitalOcean = 552,
        ///<summary>Brands Discord</summary>
        ///<see href="https://fontawesome.com/icons/discord?style=brands"/>
        [Description("Brands Discord"), IconID("fab-discord"), IconUnicodeGlyph(0xf392)]
        BrandsDiscord = 553,
        ///<summary>Brands Discourse</summary>
        ///<see href="https://fontawesome.com/icons/discourse?style=brands"/>
        [Description("Brands Discourse"), IconID("fab-discourse"), IconUnicodeGlyph(0xf393)]
        BrandsDiscourse = 554,
        ///<summary>Solid Disease</summary>
        ///<see href="https://fontawesome.com/icons/disease?style=solid"/>
        [Description("Solid Disease"), IconID("fas-disease"), IconUnicodeGlyph(0xf7fa)]
        SolidDisease = 555,
        ///<summary>Solid Display</summary>
        ///<see href="https://fontawesome.com/icons/display?style=solid"/>
        [Description("Solid Display"), IconID("fas-display"), IconUnicodeGlyph(0xe163)]
        SolidDisplay = 556,
        ///<summary>Solid Divide</summary>
        ///<see href="https://fontawesome.com/icons/divide?style=solid"/>
        [Description("Solid Divide"), IconID("fas-divide"), IconUnicodeGlyph(0xf529)]
        SolidDivide = 557,
        ///<summary>Solid DNA</summary>
        ///<see href="https://fontawesome.com/icons/dna?style=solid"/>
        [Description("Solid DNA"), IconID("fas-dna"), IconUnicodeGlyph(0xf471)]
        SolidDna = 558,
        ///<summary>Brands DocHub</summary>
        ///<see href="https://fontawesome.com/icons/dochub?style=brands"/>
        [Description("Brands DocHub"), IconID("fab-dochub"), IconUnicodeGlyph(0xf394)]
        BrandsDochub = 559,
        ///<summary>Brands Docker</summary>
        ///<see href="https://fontawesome.com/icons/docker?style=brands"/>
        [Description("Brands Docker"), IconID("fab-docker"), IconUnicodeGlyph(0xf395)]
        BrandsDocker = 560,
        ///<summary>Solid Dog</summary>
        ///<see href="https://fontawesome.com/icons/dog?style=solid"/>
        [Description("Solid Dog"), IconID("fas-dog"), IconUnicodeGlyph(0xf6d3)]
        SolidDog = 561,
        ///<summary>Solid Dollar Sign</summary>
        ///<see href="https://fontawesome.com/icons/dollar-sign?style=solid"/>
        [Description("Solid Dollar Sign"), IconID("fas-dollar-sign"), IconUnicodeGlyph(0x24)]
        SolidDollarSign = 562,
        ///<summary>Solid Dolly</summary>
        ///<see href="https://fontawesome.com/icons/dolly?style=solid"/>
        [Description("Solid Dolly"), IconID("fas-dolly"), IconUnicodeGlyph(0xf472)]
        SolidDolly = 563,
        ///<summary>Solid Dong Sign</summary>
        ///<see href="https://fontawesome.com/icons/dong-sign?style=solid"/>
        [Description("Solid Dong Sign"), IconID("fas-dong-sign"), IconUnicodeGlyph(0xe169)]
        SolidDongSign = 564,
        ///<summary>Solid Door Closed</summary>
        ///<see href="https://fontawesome.com/icons/door-closed?style=solid"/>
        [Description("Solid Door Closed"), IconID("fas-door-closed"), IconUnicodeGlyph(0xf52a)]
        SolidDoorClosed = 565,
        ///<summary>Solid Door Open</summary>
        ///<see href="https://fontawesome.com/icons/door-open?style=solid"/>
        [Description("Solid Door Open"), IconID("fas-door-open"), IconUnicodeGlyph(0xf52b)]
        SolidDoorOpen = 566,
        ///<summary>Solid Dove</summary>
        ///<see href="https://fontawesome.com/icons/dove?style=solid"/>
        [Description("Solid Dove"), IconID("fas-dove"), IconUnicodeGlyph(0xf4ba)]
        SolidDove = 567,
        ///<summary>Solid Down left and up right to center</summary>
        ///<see href="https://fontawesome.com/icons/down-left-and-up-right-to-center?style=solid"/>
        [Description("Solid Down left and up right to center"), IconID("fas-down-left-and-up-right-to-center"), IconUnicodeGlyph(0xf422)]
        SolidDownLeftAndUpRightToCenter = 568,
        ///<summary>Solid Down long</summary>
        ///<see href="https://fontawesome.com/icons/down-long?style=solid"/>
        [Description("Solid Down long"), IconID("fas-down-long"), IconUnicodeGlyph(0xf309)]
        SolidDownLong = 569,
        ///<summary>Solid Download</summary>
        ///<see href="https://fontawesome.com/icons/download?style=solid"/>
        [Description("Solid Download"), IconID("fas-download"), IconUnicodeGlyph(0xf019)]
        SolidDownload = 570,
        ///<summary>Brands Draft2digital</summary>
        ///<see href="https://fontawesome.com/icons/draft2digital?style=brands"/>
        [Description("Brands Draft2digital"), IconID("fab-draft2digital"), IconUnicodeGlyph(0xf396)]
        BrandsDraft2digital = 571,
        ///<summary>Solid Dragon</summary>
        ///<see href="https://fontawesome.com/icons/dragon?style=solid"/>
        [Description("Solid Dragon"), IconID("fas-dragon"), IconUnicodeGlyph(0xf6d5)]
        SolidDragon = 572,
        ///<summary>Solid Draw Polygon</summary>
        ///<see href="https://fontawesome.com/icons/draw-polygon?style=solid"/>
        [Description("Solid Draw Polygon"), IconID("fas-draw-polygon"), IconUnicodeGlyph(0xf5ee)]
        SolidDrawPolygon = 573,
        ///<summary>Brands Dribbble</summary>
        ///<see href="https://fontawesome.com/icons/dribbble?style=brands"/>
        [Description("Brands Dribbble"), IconID("fab-dribbble"), IconUnicodeGlyph(0xf17d)]
        BrandsDribbble = 574,
        ///<summary>Brands Dropbox</summary>
        ///<see href="https://fontawesome.com/icons/dropbox?style=brands"/>
        [Description("Brands Dropbox"), IconID("fab-dropbox"), IconUnicodeGlyph(0xf16b)]
        BrandsDropbox = 575,
        ///<summary>Solid Droplet</summary>
        ///<see href="https://fontawesome.com/icons/droplet?style=solid"/>
        [Description("Solid Droplet"), IconID("fas-droplet"), IconUnicodeGlyph(0xf043)]
        SolidDroplet = 576,
        ///<summary>Solid Droplet slash</summary>
        ///<see href="https://fontawesome.com/icons/droplet-slash?style=solid"/>
        [Description("Solid Droplet slash"), IconID("fas-droplet-slash"), IconUnicodeGlyph(0xf5c7)]
        SolidDropletSlash = 577,
        ///<summary>Solid Drum</summary>
        ///<see href="https://fontawesome.com/icons/drum?style=solid"/>
        [Description("Solid Drum"), IconID("fas-drum"), IconUnicodeGlyph(0xf569)]
        SolidDrum = 578,
        ///<summary>Solid Drum Steelpan</summary>
        ///<see href="https://fontawesome.com/icons/drum-steelpan?style=solid"/>
        [Description("Solid Drum Steelpan"), IconID("fas-drum-steelpan"), IconUnicodeGlyph(0xf56a)]
        SolidDrumSteelpan = 579,
        ///<summary>Solid Drumstick with Bite Taken Out</summary>
        ///<see href="https://fontawesome.com/icons/drumstick-bite?style=solid"/>
        [Description("Solid Drumstick with Bite Taken Out"), IconID("fas-drumstick-bite"), IconUnicodeGlyph(0xf6d7)]
        SolidDrumstickBite = 580,
        ///<summary>Brands Drupal Logo</summary>
        ///<see href="https://fontawesome.com/icons/drupal?style=brands"/>
        [Description("Brands Drupal Logo"), IconID("fab-drupal"), IconUnicodeGlyph(0xf1a9)]
        BrandsDrupal = 581,
        ///<summary>Solid Dumbbell</summary>
        ///<see href="https://fontawesome.com/icons/dumbbell?style=solid"/>
        [Description("Solid Dumbbell"), IconID("fas-dumbbell"), IconUnicodeGlyph(0xf44b)]
        SolidDumbbell = 582,
        ///<summary>Solid Dumpster</summary>
        ///<see href="https://fontawesome.com/icons/dumpster?style=solid"/>
        [Description("Solid Dumpster"), IconID("fas-dumpster"), IconUnicodeGlyph(0xf793)]
        SolidDumpster = 583,
        ///<summary>Solid Dumpster Fire</summary>
        ///<see href="https://fontawesome.com/icons/dumpster-fire?style=solid"/>
        [Description("Solid Dumpster Fire"), IconID("fas-dumpster-fire"), IconUnicodeGlyph(0xf794)]
        SolidDumpsterFire = 584,
        ///<summary>Solid Dungeon</summary>
        ///<see href="https://fontawesome.com/icons/dungeon?style=solid"/>
        [Description("Solid Dungeon"), IconID("fas-dungeon"), IconUnicodeGlyph(0xf6d9)]
        SolidDungeon = 585,
        ///<summary>Brands Dyalog</summary>
        ///<see href="https://fontawesome.com/icons/dyalog?style=brands"/>
        [Description("Brands Dyalog"), IconID("fab-dyalog"), IconUnicodeGlyph(0xf399)]
        BrandsDyalog = 586,
        ///<summary>Solid E</summary>
        ///<see href="https://fontawesome.com/icons/e?style=solid"/>
        [Description("Solid E"), IconID("fas-e"), IconUnicodeGlyph(0x45)]
        SolidE = 587,
        ///<summary>Solid Ear deaf</summary>
        ///<see href="https://fontawesome.com/icons/ear-deaf?style=solid"/>
        [Description("Solid Ear deaf"), IconID("fas-ear-deaf"), IconUnicodeGlyph(0xf2a4)]
        SolidEarDeaf = 588,
        ///<summary>Solid Ear listen</summary>
        ///<see href="https://fontawesome.com/icons/ear-listen?style=solid"/>
        [Description("Solid Ear listen"), IconID("fas-ear-listen"), IconUnicodeGlyph(0xf2a2)]
        SolidEarListen = 589,
        ///<summary>Brands Earlybirds</summary>
        ///<see href="https://fontawesome.com/icons/earlybirds?style=brands"/>
        [Description("Brands Earlybirds"), IconID("fab-earlybirds"), IconUnicodeGlyph(0xf39a)]
        BrandsEarlybirds = 590,
        ///<summary>Solid Earth Africa</summary>
        ///<see href="https://fontawesome.com/icons/earth-africa?style=solid"/>
        [Description("Solid Earth Africa"), IconID("fas-earth-africa"), IconUnicodeGlyph(0xf57c)]
        SolidEarthAfrica = 591,
        ///<summary>Solid Earth americas</summary>
        ///<see href="https://fontawesome.com/icons/earth-americas?style=solid"/>
        [Description("Solid Earth americas"), IconID("fas-earth-americas"), IconUnicodeGlyph(0xf57d)]
        SolidEarthAmericas = 592,
        ///<summary>Solid Earth Asia</summary>
        ///<see href="https://fontawesome.com/icons/earth-asia?style=solid"/>
        [Description("Solid Earth Asia"), IconID("fas-earth-asia"), IconUnicodeGlyph(0xf57e)]
        SolidEarthAsia = 593,
        ///<summary>Solid Earth Europe</summary>
        ///<see href="https://fontawesome.com/icons/earth-europe?style=solid"/>
        [Description("Solid Earth Europe"), IconID("fas-earth-europe"), IconUnicodeGlyph(0xf7a2)]
        SolidEarthEurope = 594,
        ///<summary>Solid Earth Oceania</summary>
        ///<see href="https://fontawesome.com/icons/earth-oceania?style=solid"/>
        [Description("Solid Earth Oceania"), IconID("fas-earth-oceania"), IconUnicodeGlyph(0xe47b)]
        SolidEarthOceania = 595,
        ///<summary>Brands eBay</summary>
        ///<see href="https://fontawesome.com/icons/ebay?style=brands"/>
        [Description("Brands eBay"), IconID("fab-ebay"), IconUnicodeGlyph(0xf4f4)]
        BrandsEbay = 596,
        ///<summary>Brands Edge Browser</summary>
        ///<see href="https://fontawesome.com/icons/edge?style=brands"/>
        [Description("Brands Edge Browser"), IconID("fab-edge"), IconUnicodeGlyph(0xf282)]
        BrandsEdge = 597,
        ///<summary>Brands Edge Legacy Browser</summary>
        ///<see href="https://fontawesome.com/icons/edge-legacy?style=brands"/>
        [Description("Brands Edge Legacy Browser"), IconID("fab-edge-legacy"), IconUnicodeGlyph(0xe078)]
        BrandsEdgeLegacy = 598,
        ///<summary>Solid Egg</summary>
        ///<see href="https://fontawesome.com/icons/egg?style=solid"/>
        [Description("Solid Egg"), IconID("fas-egg"), IconUnicodeGlyph(0xf7fb)]
        SolidEgg = 599,
        ///<summary>Solid eject</summary>
        ///<see href="https://fontawesome.com/icons/eject?style=solid"/>
        [Description("Solid eject"), IconID("fas-eject"), IconUnicodeGlyph(0xf052)]
        SolidEject = 600,
        ///<summary>Brands Elementor</summary>
        ///<see href="https://fontawesome.com/icons/elementor?style=brands"/>
        [Description("Brands Elementor"), IconID("fab-elementor"), IconUnicodeGlyph(0xf430)]
        BrandsElementor = 601,
        ///<summary>Solid Elevator</summary>
        ///<see href="https://fontawesome.com/icons/elevator?style=solid"/>
        [Description("Solid Elevator"), IconID("fas-elevator"), IconUnicodeGlyph(0xe16d)]
        SolidElevator = 602,
        ///<summary>Solid Ellipsis</summary>
        ///<see href="https://fontawesome.com/icons/ellipsis?style=solid"/>
        [Description("Solid Ellipsis"), IconID("fas-ellipsis"), IconUnicodeGlyph(0xf141)]
        SolidEllipsis = 603,
        ///<summary>Solid Ellipsis vertical</summary>
        ///<see href="https://fontawesome.com/icons/ellipsis-vertical?style=solid"/>
        [Description("Solid Ellipsis vertical"), IconID("fas-ellipsis-vertical"), IconUnicodeGlyph(0xf142)]
        SolidEllipsisVertical = 604,
        ///<summary>Brands Ello</summary>
        ///<see href="https://fontawesome.com/icons/ello?style=brands"/>
        [Description("Brands Ello"), IconID("fab-ello"), IconUnicodeGlyph(0xf5f1)]
        BrandsEllo = 605,
        ///<summary>Brands Ember</summary>
        ///<see href="https://fontawesome.com/icons/ember?style=brands"/>
        [Description("Brands Ember"), IconID("fab-ember"), IconUnicodeGlyph(0xf423)]
        BrandsEmber = 606,
        ///<summary>Brands Galactic Empire</summary>
        ///<see href="https://fontawesome.com/icons/empire?style=brands"/>
        [Description("Brands Galactic Empire"), IconID("fab-empire"), IconUnicodeGlyph(0xf1d1)]
        BrandsEmpire = 607,
        ///<summary>Solid Envelope</summary>
        ///<see href="https://fontawesome.com/icons/envelope?style=solid"/>
        [Description("Solid Envelope"), IconID("fas-envelope"), IconUnicodeGlyph(0xf0e0)]
        SolidEnvelope = 608,
        ///<summary>Regular Envelope</summary>
        ///<see href="https://fontawesome.com/icons/envelope?style=regular"/>
        [Description("Regular Envelope"), IconID("far-envelope"), IconUnicodeGlyph(0xf0e0)]
        RegularEnvelope = 609,
        ///<summary>Solid Envelope Circle-check</summary>
        ///<see href="https://fontawesome.com/icons/envelope-circle-check?style=solid"/>
        [Description("Solid Envelope Circle-check"), IconID("fas-envelope-circle-check"), IconUnicodeGlyph(0xe4e8)]
        SolidEnvelopeCircleCheck = 610,
        ///<summary>Solid Envelope Open</summary>
        ///<see href="https://fontawesome.com/icons/envelope-open?style=solid"/>
        [Description("Solid Envelope Open"), IconID("fas-envelope-open"), IconUnicodeGlyph(0xf2b6)]
        SolidEnvelopeOpen = 611,
        ///<summary>Regular Envelope Open</summary>
        ///<see href="https://fontawesome.com/icons/envelope-open?style=regular"/>
        [Description("Regular Envelope Open"), IconID("far-envelope-open"), IconUnicodeGlyph(0xf2b6)]
        RegularEnvelopeOpen = 612,
        ///<summary>Solid Envelope Open-text</summary>
        ///<see href="https://fontawesome.com/icons/envelope-open-text?style=solid"/>
        [Description("Solid Envelope Open-text"), IconID("fas-envelope-open-text"), IconUnicodeGlyph(0xf658)]
        SolidEnvelopeOpenText = 613,
        ///<summary>Solid Envelopes bulk</summary>
        ///<see href="https://fontawesome.com/icons/envelopes-bulk?style=solid"/>
        [Description("Solid Envelopes bulk"), IconID("fas-envelopes-bulk"), IconUnicodeGlyph(0xf674)]
        SolidEnvelopesBulk = 614,
        ///<summary>Brands Envira Gallery</summary>
        ///<see href="https://fontawesome.com/icons/envira?style=brands"/>
        [Description("Brands Envira Gallery"), IconID("fab-envira"), IconUnicodeGlyph(0xf299)]
        BrandsEnvira = 615,
        ///<summary>Solid Equals</summary>
        ///<see href="https://fontawesome.com/icons/equals?style=solid"/>
        [Description("Solid Equals"), IconID("fas-equals"), IconUnicodeGlyph(0x3d)]
        SolidEquals = 616,
        ///<summary>Solid eraser</summary>
        ///<see href="https://fontawesome.com/icons/eraser?style=solid"/>
        [Description("Solid eraser"), IconID("fas-eraser"), IconUnicodeGlyph(0xf12d)]
        SolidEraser = 617,
        ///<summary>Brands Erlang</summary>
        ///<see href="https://fontawesome.com/icons/erlang?style=brands"/>
        [Description("Brands Erlang"), IconID("fab-erlang"), IconUnicodeGlyph(0xf39d)]
        BrandsErlang = 618,
        ///<summary>Brands Ethereum</summary>
        ///<see href="https://fontawesome.com/icons/ethereum?style=brands"/>
        [Description("Brands Ethereum"), IconID("fab-ethereum"), IconUnicodeGlyph(0xf42e)]
        BrandsEthereum = 619,
        ///<summary>Solid Ethernet</summary>
        ///<see href="https://fontawesome.com/icons/ethernet?style=solid"/>
        [Description("Solid Ethernet"), IconID("fas-ethernet"), IconUnicodeGlyph(0xf796)]
        SolidEthernet = 620,
        ///<summary>Brands Etsy</summary>
        ///<see href="https://fontawesome.com/icons/etsy?style=brands"/>
        [Description("Brands Etsy"), IconID("fab-etsy"), IconUnicodeGlyph(0xf2d7)]
        BrandsEtsy = 621,
        ///<summary>Solid Euro Sign</summary>
        ///<see href="https://fontawesome.com/icons/euro-sign?style=solid"/>
        [Description("Solid Euro Sign"), IconID("fas-euro-sign"), IconUnicodeGlyph(0xf153)]
        SolidEuroSign = 622,
        ///<summary>Brands Evernote</summary>
        ///<see href="https://fontawesome.com/icons/evernote?style=brands"/>
        [Description("Brands Evernote"), IconID("fab-evernote"), IconUnicodeGlyph(0xf839)]
        BrandsEvernote = 623,
        ///<summary>Solid exclamation</summary>
        ///<see href="https://fontawesome.com/icons/exclamation?style=solid"/>
        [Description("Solid exclamation"), IconID("fas-exclamation"), IconUnicodeGlyph(0x21)]
        SolidExclamation = 624,
        ///<summary>Solid Expand</summary>
        ///<see href="https://fontawesome.com/icons/expand?style=solid"/>
        [Description("Solid Expand"), IconID("fas-expand"), IconUnicodeGlyph(0xf065)]
        SolidExpand = 625,
        ///<summary>Brands ExpeditedSSL</summary>
        ///<see href="https://fontawesome.com/icons/expeditedssl?style=brands"/>
        [Description("Brands ExpeditedSSL"), IconID("fab-expeditedssl"), IconUnicodeGlyph(0xf23e)]
        BrandsExpeditedssl = 626,
        ///<summary>Solid Explosion</summary>
        ///<see href="https://fontawesome.com/icons/explosion?style=solid"/>
        [Description("Solid Explosion"), IconID("fas-explosion"), IconUnicodeGlyph(0xe4e9)]
        SolidExplosion = 627,
        ///<summary>Solid Eye</summary>
        ///<see href="https://fontawesome.com/icons/eye?style=solid"/>
        [Description("Solid Eye"), IconID("fas-eye"), IconUnicodeGlyph(0xf06e)]
        SolidEye = 628,
        ///<summary>Regular Eye</summary>
        ///<see href="https://fontawesome.com/icons/eye?style=regular"/>
        [Description("Regular Eye"), IconID("far-eye"), IconUnicodeGlyph(0xf06e)]
        RegularEye = 629,
        ///<summary>Solid Eye Dropper</summary>
        ///<see href="https://fontawesome.com/icons/eye-dropper?style=solid"/>
        [Description("Solid Eye Dropper"), IconID("fas-eye-dropper"), IconUnicodeGlyph(0xf1fb)]
        SolidEyeDropper = 630,
        ///<summary>Solid Eye low vision</summary>
        ///<see href="https://fontawesome.com/icons/eye-low-vision?style=solid"/>
        [Description("Solid Eye low vision"), IconID("fas-eye-low-vision"), IconUnicodeGlyph(0xf2a8)]
        SolidEyeLowVision = 631,
        ///<summary>Solid Eye Slash</summary>
        ///<see href="https://fontawesome.com/icons/eye-slash?style=solid"/>
        [Description("Solid Eye Slash"), IconID("fas-eye-slash"), IconUnicodeGlyph(0xf070)]
        SolidEyeSlash = 632,
        ///<summary>Regular Eye Slash</summary>
        ///<see href="https://fontawesome.com/icons/eye-slash?style=regular"/>
        [Description("Regular Eye Slash"), IconID("far-eye-slash"), IconUnicodeGlyph(0xf070)]
        RegularEyeSlash = 633,
        ///<summary>Solid F</summary>
        ///<see href="https://fontawesome.com/icons/f?style=solid"/>
        [Description("Solid F"), IconID("fas-f"), IconUnicodeGlyph(0x46)]
        SolidF = 634,
        ///<summary>Solid Face angry</summary>
        ///<see href="https://fontawesome.com/icons/face-angry?style=solid"/>
        [Description("Solid Face angry"), IconID("fas-face-angry"), IconUnicodeGlyph(0xf556)]
        SolidFaceAngry = 635,
        ///<summary>Regular Face angry</summary>
        ///<see href="https://fontawesome.com/icons/face-angry?style=regular"/>
        [Description("Regular Face angry"), IconID("far-face-angry"), IconUnicodeGlyph(0xf556)]
        RegularFaceAngry = 636,
        ///<summary>Solid Face dizzy</summary>
        ///<see href="https://fontawesome.com/icons/face-dizzy?style=solid"/>
        [Description("Solid Face dizzy"), IconID("fas-face-dizzy"), IconUnicodeGlyph(0xf567)]
        SolidFaceDizzy = 637,
        ///<summary>Regular Face dizzy</summary>
        ///<see href="https://fontawesome.com/icons/face-dizzy?style=regular"/>
        [Description("Regular Face dizzy"), IconID("far-face-dizzy"), IconUnicodeGlyph(0xf567)]
        RegularFaceDizzy = 638,
        ///<summary>Solid Face flushed</summary>
        ///<see href="https://fontawesome.com/icons/face-flushed?style=solid"/>
        [Description("Solid Face flushed"), IconID("fas-face-flushed"), IconUnicodeGlyph(0xf579)]
        SolidFaceFlushed = 639,
        ///<summary>Regular Face flushed</summary>
        ///<see href="https://fontawesome.com/icons/face-flushed?style=regular"/>
        [Description("Regular Face flushed"), IconID("far-face-flushed"), IconUnicodeGlyph(0xf579)]
        RegularFaceFlushed = 640,
        ///<summary>Solid Face frown</summary>
        ///<see href="https://fontawesome.com/icons/face-frown?style=solid"/>
        [Description("Solid Face frown"), IconID("fas-face-frown"), IconUnicodeGlyph(0xf119)]
        SolidFaceFrown = 641,
        ///<summary>Regular Face frown</summary>
        ///<see href="https://fontawesome.com/icons/face-frown?style=regular"/>
        [Description("Regular Face frown"), IconID("far-face-frown"), IconUnicodeGlyph(0xf119)]
        RegularFaceFrown = 642,
        ///<summary>Solid Face frown open</summary>
        ///<see href="https://fontawesome.com/icons/face-frown-open?style=solid"/>
        [Description("Solid Face frown open"), IconID("fas-face-frown-open"), IconUnicodeGlyph(0xf57a)]
        SolidFaceFrownOpen = 643,
        ///<summary>Regular Face frown open</summary>
        ///<see href="https://fontawesome.com/icons/face-frown-open?style=regular"/>
        [Description("Regular Face frown open"), IconID("far-face-frown-open"), IconUnicodeGlyph(0xf57a)]
        RegularFaceFrownOpen = 644,
        ///<summary>Solid Face grimace</summary>
        ///<see href="https://fontawesome.com/icons/face-grimace?style=solid"/>
        [Description("Solid Face grimace"), IconID("fas-face-grimace"), IconUnicodeGlyph(0xf57f)]
        SolidFaceGrimace = 645,
        ///<summary>Regular Face grimace</summary>
        ///<see href="https://fontawesome.com/icons/face-grimace?style=regular"/>
        [Description("Regular Face grimace"), IconID("far-face-grimace"), IconUnicodeGlyph(0xf57f)]
        RegularFaceGrimace = 646,
        ///<summary>Solid Face grin</summary>
        ///<see href="https://fontawesome.com/icons/face-grin?style=solid"/>
        [Description("Solid Face grin"), IconID("fas-face-grin"), IconUnicodeGlyph(0xf580)]
        SolidFaceGrin = 647,
        ///<summary>Regular Face grin</summary>
        ///<see href="https://fontawesome.com/icons/face-grin?style=regular"/>
        [Description("Regular Face grin"), IconID("far-face-grin"), IconUnicodeGlyph(0xf580)]
        RegularFaceGrin = 648,
        ///<summary>Solid Face grin beam</summary>
        ///<see href="https://fontawesome.com/icons/face-grin-beam?style=solid"/>
        [Description("Solid Face grin beam"), IconID("fas-face-grin-beam"), IconUnicodeGlyph(0xf582)]
        SolidFaceGrinBeam = 649,
        ///<summary>Regular Face grin beam</summary>
        ///<see href="https://fontawesome.com/icons/face-grin-beam?style=regular"/>
        [Description("Regular Face grin beam"), IconID("far-face-grin-beam"), IconUnicodeGlyph(0xf582)]
        RegularFaceGrinBeam = 650,
        ///<summary>Solid Face grin beam sweat</summary>
        ///<see href="https://fontawesome.com/icons/face-grin-beam-sweat?style=solid"/>
        [Description("Solid Face grin beam sweat"), IconID("fas-face-grin-beam-sweat"), IconUnicodeGlyph(0xf583)]
        SolidFaceGrinBeamSweat = 651,
        ///<summary>Regular Face grin beam sweat</summary>
        ///<see href="https://fontawesome.com/icons/face-grin-beam-sweat?style=regular"/>
        [Description("Regular Face grin beam sweat"), IconID("far-face-grin-beam-sweat"), IconUnicodeGlyph(0xf583)]
        RegularFaceGrinBeamSweat = 652,
        ///<summary>Solid Face grin hearts</summary>
        ///<see href="https://fontawesome.com/icons/face-grin-hearts?style=solid"/>
        [Description("Solid Face grin hearts"), IconID("fas-face-grin-hearts"), IconUnicodeGlyph(0xf584)]
        SolidFaceGrinHearts = 653,
        ///<summary>Regular Face grin hearts</summary>
        ///<see href="https://fontawesome.com/icons/face-grin-hearts?style=regular"/>
        [Description("Regular Face grin hearts"), IconID("far-face-grin-hearts"), IconUnicodeGlyph(0xf584)]
        RegularFaceGrinHearts = 654,
        ///<summary>Solid Face grin squint</summary>
        ///<see href="https://fontawesome.com/icons/face-grin-squint?style=solid"/>
        [Description("Solid Face grin squint"), IconID("fas-face-grin-squint"), IconUnicodeGlyph(0xf585)]
        SolidFaceGrinSquint = 655,
        ///<summary>Regular Face grin squint</summary>
        ///<see href="https://fontawesome.com/icons/face-grin-squint?style=regular"/>
        [Description("Regular Face grin squint"), IconID("far-face-grin-squint"), IconUnicodeGlyph(0xf585)]
        RegularFaceGrinSquint = 656,
        ///<summary>Solid Face grin squint tears</summary>
        ///<see href="https://fontawesome.com/icons/face-grin-squint-tears?style=solid"/>
        [Description("Solid Face grin squint tears"), IconID("fas-face-grin-squint-tears"), IconUnicodeGlyph(0xf586)]
        SolidFaceGrinSquintTears = 657,
        ///<summary>Regular Face grin squint tears</summary>
        ///<see href="https://fontawesome.com/icons/face-grin-squint-tears?style=regular"/>
        [Description("Regular Face grin squint tears"), IconID("far-face-grin-squint-tears"), IconUnicodeGlyph(0xf586)]
        RegularFaceGrinSquintTears = 658,
        ///<summary>Solid Face grin stars</summary>
        ///<see href="https://fontawesome.com/icons/face-grin-stars?style=solid"/>
        [Description("Solid Face grin stars"), IconID("fas-face-grin-stars"), IconUnicodeGlyph(0xf587)]
        SolidFaceGrinStars = 659,
        ///<summary>Regular Face grin stars</summary>
        ///<see href="https://fontawesome.com/icons/face-grin-stars?style=regular"/>
        [Description("Regular Face grin stars"), IconID("far-face-grin-stars"), IconUnicodeGlyph(0xf587)]
        RegularFaceGrinStars = 660,
        ///<summary>Solid Face grin tears</summary>
        ///<see href="https://fontawesome.com/icons/face-grin-tears?style=solid"/>
        [Description("Solid Face grin tears"), IconID("fas-face-grin-tears"), IconUnicodeGlyph(0xf588)]
        SolidFaceGrinTears = 661,
        ///<summary>Regular Face grin tears</summary>
        ///<see href="https://fontawesome.com/icons/face-grin-tears?style=regular"/>
        [Description("Regular Face grin tears"), IconID("far-face-grin-tears"), IconUnicodeGlyph(0xf588)]
        RegularFaceGrinTears = 662,
        ///<summary>Solid Face grin tongue</summary>
        ///<see href="https://fontawesome.com/icons/face-grin-tongue?style=solid"/>
        [Description("Solid Face grin tongue"), IconID("fas-face-grin-tongue"), IconUnicodeGlyph(0xf589)]
        SolidFaceGrinTongue = 663,
        ///<summary>Regular Face grin tongue</summary>
        ///<see href="https://fontawesome.com/icons/face-grin-tongue?style=regular"/>
        [Description("Regular Face grin tongue"), IconID("far-face-grin-tongue"), IconUnicodeGlyph(0xf589)]
        RegularFaceGrinTongue = 664,
        ///<summary>Solid Face grin tongue squint</summary>
        ///<see href="https://fontawesome.com/icons/face-grin-tongue-squint?style=solid"/>
        [Description("Solid Face grin tongue squint"), IconID("fas-face-grin-tongue-squint"), IconUnicodeGlyph(0xf58a)]
        SolidFaceGrinTongueSquint = 665,
        ///<summary>Regular Face grin tongue squint</summary>
        ///<see href="https://fontawesome.com/icons/face-grin-tongue-squint?style=regular"/>
        [Description("Regular Face grin tongue squint"), IconID("far-face-grin-tongue-squint"), IconUnicodeGlyph(0xf58a)]
        RegularFaceGrinTongueSquint = 666,
        ///<summary>Solid Face grin tongue wink</summary>
        ///<see href="https://fontawesome.com/icons/face-grin-tongue-wink?style=solid"/>
        [Description("Solid Face grin tongue wink"), IconID("fas-face-grin-tongue-wink"), IconUnicodeGlyph(0xf58b)]
        SolidFaceGrinTongueWink = 667,
        ///<summary>Regular Face grin tongue wink</summary>
        ///<see href="https://fontawesome.com/icons/face-grin-tongue-wink?style=regular"/>
        [Description("Regular Face grin tongue wink"), IconID("far-face-grin-tongue-wink"), IconUnicodeGlyph(0xf58b)]
        RegularFaceGrinTongueWink = 668,
        ///<summary>Solid Face grin wide</summary>
        ///<see href="https://fontawesome.com/icons/face-grin-wide?style=solid"/>
        [Description("Solid Face grin wide"), IconID("fas-face-grin-wide"), IconUnicodeGlyph(0xf581)]
        SolidFaceGrinWide = 669,
        ///<summary>Regular Face grin wide</summary>
        ///<see href="https://fontawesome.com/icons/face-grin-wide?style=regular"/>
        [Description("Regular Face grin wide"), IconID("far-face-grin-wide"), IconUnicodeGlyph(0xf581)]
        RegularFaceGrinWide = 670,
        ///<summary>Solid Face grin wink</summary>
        ///<see href="https://fontawesome.com/icons/face-grin-wink?style=solid"/>
        [Description("Solid Face grin wink"), IconID("fas-face-grin-wink"), IconUnicodeGlyph(0xf58c)]
        SolidFaceGrinWink = 671,
        ///<summary>Regular Face grin wink</summary>
        ///<see href="https://fontawesome.com/icons/face-grin-wink?style=regular"/>
        [Description("Regular Face grin wink"), IconID("far-face-grin-wink"), IconUnicodeGlyph(0xf58c)]
        RegularFaceGrinWink = 672,
        ///<summary>Solid Face kiss</summary>
        ///<see href="https://fontawesome.com/icons/face-kiss?style=solid"/>
        [Description("Solid Face kiss"), IconID("fas-face-kiss"), IconUnicodeGlyph(0xf596)]
        SolidFaceKiss = 673,
        ///<summary>Regular Face kiss</summary>
        ///<see href="https://fontawesome.com/icons/face-kiss?style=regular"/>
        [Description("Regular Face kiss"), IconID("far-face-kiss"), IconUnicodeGlyph(0xf596)]
        RegularFaceKiss = 674,
        ///<summary>Solid Face Kiss Beam</summary>
        ///<see href="https://fontawesome.com/icons/face-kiss-beam?style=solid"/>
        [Description("Solid Face Kiss Beam"), IconID("fas-face-kiss-beam"), IconUnicodeGlyph(0xf597)]
        SolidFaceKissBeam = 675,
        ///<summary>Regular Face Kiss Beam</summary>
        ///<see href="https://fontawesome.com/icons/face-kiss-beam?style=regular"/>
        [Description("Regular Face Kiss Beam"), IconID("far-face-kiss-beam"), IconUnicodeGlyph(0xf597)]
        RegularFaceKissBeam = 676,
        ///<summary>Solid Face Kiss Wink Heart</summary>
        ///<see href="https://fontawesome.com/icons/face-kiss-wink-heart?style=solid"/>
        [Description("Solid Face Kiss Wink Heart"), IconID("fas-face-kiss-wink-heart"), IconUnicodeGlyph(0xf598)]
        SolidFaceKissWinkHeart = 677,
        ///<summary>Regular Face Kiss Wink Heart</summary>
        ///<see href="https://fontawesome.com/icons/face-kiss-wink-heart?style=regular"/>
        [Description("Regular Face Kiss Wink Heart"), IconID("far-face-kiss-wink-heart"), IconUnicodeGlyph(0xf598)]
        RegularFaceKissWinkHeart = 678,
        ///<summary>Solid Face Laugh</summary>
        ///<see href="https://fontawesome.com/icons/face-laugh?style=solid"/>
        [Description("Solid Face Laugh"), IconID("fas-face-laugh"), IconUnicodeGlyph(0xf599)]
        SolidFaceLaugh = 679,
        ///<summary>Regular Face Laugh</summary>
        ///<see href="https://fontawesome.com/icons/face-laugh?style=regular"/>
        [Description("Regular Face Laugh"), IconID("far-face-laugh"), IconUnicodeGlyph(0xf599)]
        RegularFaceLaugh = 680,
        ///<summary>Solid Face Laugh Beam</summary>
        ///<see href="https://fontawesome.com/icons/face-laugh-beam?style=solid"/>
        [Description("Solid Face Laugh Beam"), IconID("fas-face-laugh-beam"), IconUnicodeGlyph(0xf59a)]
        SolidFaceLaughBeam = 681,
        ///<summary>Regular Face Laugh Beam</summary>
        ///<see href="https://fontawesome.com/icons/face-laugh-beam?style=regular"/>
        [Description("Regular Face Laugh Beam"), IconID("far-face-laugh-beam"), IconUnicodeGlyph(0xf59a)]
        RegularFaceLaughBeam = 682,
        ///<summary>Solid Face Laugh Squint</summary>
        ///<see href="https://fontawesome.com/icons/face-laugh-squint?style=solid"/>
        [Description("Solid Face Laugh Squint"), IconID("fas-face-laugh-squint"), IconUnicodeGlyph(0xf59b)]
        SolidFaceLaughSquint = 683,
        ///<summary>Regular Face Laugh Squint</summary>
        ///<see href="https://fontawesome.com/icons/face-laugh-squint?style=regular"/>
        [Description("Regular Face Laugh Squint"), IconID("far-face-laugh-squint"), IconUnicodeGlyph(0xf59b)]
        RegularFaceLaughSquint = 684,
        ///<summary>Solid Face Laugh Wink</summary>
        ///<see href="https://fontawesome.com/icons/face-laugh-wink?style=solid"/>
        [Description("Solid Face Laugh Wink"), IconID("fas-face-laugh-wink"), IconUnicodeGlyph(0xf59c)]
        SolidFaceLaughWink = 685,
        ///<summary>Regular Face Laugh Wink</summary>
        ///<see href="https://fontawesome.com/icons/face-laugh-wink?style=regular"/>
        [Description("Regular Face Laugh Wink"), IconID("far-face-laugh-wink"), IconUnicodeGlyph(0xf59c)]
        RegularFaceLaughWink = 686,
        ///<summary>Solid Face meh</summary>
        ///<see href="https://fontawesome.com/icons/face-meh?style=solid"/>
        [Description("Solid Face meh"), IconID("fas-face-meh"), IconUnicodeGlyph(0xf11a)]
        SolidFaceMeh = 687,
        ///<summary>Regular Face meh</summary>
        ///<see href="https://fontawesome.com/icons/face-meh?style=regular"/>
        [Description("Regular Face meh"), IconID("far-face-meh"), IconUnicodeGlyph(0xf11a)]
        RegularFaceMeh = 688,
        ///<summary>Solid Face Meh Blank</summary>
        ///<see href="https://fontawesome.com/icons/face-meh-blank?style=solid"/>
        [Description("Solid Face Meh Blank"), IconID("fas-face-meh-blank"), IconUnicodeGlyph(0xf5a4)]
        SolidFaceMehBlank = 689,
        ///<summary>Regular Face Meh Blank</summary>
        ///<see href="https://fontawesome.com/icons/face-meh-blank?style=regular"/>
        [Description("Regular Face Meh Blank"), IconID("far-face-meh-blank"), IconUnicodeGlyph(0xf5a4)]
        RegularFaceMehBlank = 690,
        ///<summary>Solid Face Rolling Eyes</summary>
        ///<see href="https://fontawesome.com/icons/face-rolling-eyes?style=solid"/>
        [Description("Solid Face Rolling Eyes"), IconID("fas-face-rolling-eyes"), IconUnicodeGlyph(0xf5a5)]
        SolidFaceRollingEyes = 691,
        ///<summary>Regular Face Rolling Eyes</summary>
        ///<see href="https://fontawesome.com/icons/face-rolling-eyes?style=regular"/>
        [Description("Regular Face Rolling Eyes"), IconID("far-face-rolling-eyes"), IconUnicodeGlyph(0xf5a5)]
        RegularFaceRollingEyes = 692,
        ///<summary>Solid Face Sad Cry</summary>
        ///<see href="https://fontawesome.com/icons/face-sad-cry?style=solid"/>
        [Description("Solid Face Sad Cry"), IconID("fas-face-sad-cry"), IconUnicodeGlyph(0xf5b3)]
        SolidFaceSadCry = 693,
        ///<summary>Regular Face Sad Cry</summary>
        ///<see href="https://fontawesome.com/icons/face-sad-cry?style=regular"/>
        [Description("Regular Face Sad Cry"), IconID("far-face-sad-cry"), IconUnicodeGlyph(0xf5b3)]
        RegularFaceSadCry = 694,
        ///<summary>Solid Face Sad Tear</summary>
        ///<see href="https://fontawesome.com/icons/face-sad-tear?style=solid"/>
        [Description("Solid Face Sad Tear"), IconID("fas-face-sad-tear"), IconUnicodeGlyph(0xf5b4)]
        SolidFaceSadTear = 695,
        ///<summary>Regular Face Sad Tear</summary>
        ///<see href="https://fontawesome.com/icons/face-sad-tear?style=regular"/>
        [Description("Regular Face Sad Tear"), IconID("far-face-sad-tear"), IconUnicodeGlyph(0xf5b4)]
        RegularFaceSadTear = 696,
        ///<summary>Solid Face Smile</summary>
        ///<see href="https://fontawesome.com/icons/face-smile?style=solid"/>
        [Description("Solid Face Smile"), IconID("fas-face-smile"), IconUnicodeGlyph(0xf118)]
        SolidFaceSmile = 697,
        ///<summary>Regular Face Smile</summary>
        ///<see href="https://fontawesome.com/icons/face-smile?style=regular"/>
        [Description("Regular Face Smile"), IconID("far-face-smile"), IconUnicodeGlyph(0xf118)]
        RegularFaceSmile = 698,
        ///<summary>Solid Face Smile Beam</summary>
        ///<see href="https://fontawesome.com/icons/face-smile-beam?style=solid"/>
        [Description("Solid Face Smile Beam"), IconID("fas-face-smile-beam"), IconUnicodeGlyph(0xf5b8)]
        SolidFaceSmileBeam = 699,
        ///<summary>Regular Face Smile Beam</summary>
        ///<see href="https://fontawesome.com/icons/face-smile-beam?style=regular"/>
        [Description("Regular Face Smile Beam"), IconID("far-face-smile-beam"), IconUnicodeGlyph(0xf5b8)]
        RegularFaceSmileBeam = 700,
        ///<summary>Solid Face Smile Wink</summary>
        ///<see href="https://fontawesome.com/icons/face-smile-wink?style=solid"/>
        [Description("Solid Face Smile Wink"), IconID("fas-face-smile-wink"), IconUnicodeGlyph(0xf4da)]
        SolidFaceSmileWink = 701,
        ///<summary>Regular Face Smile Wink</summary>
        ///<see href="https://fontawesome.com/icons/face-smile-wink?style=regular"/>
        [Description("Regular Face Smile Wink"), IconID("far-face-smile-wink"), IconUnicodeGlyph(0xf4da)]
        RegularFaceSmileWink = 702,
        ///<summary>Solid Face Surprise</summary>
        ///<see href="https://fontawesome.com/icons/face-surprise?style=solid"/>
        [Description("Solid Face Surprise"), IconID("fas-face-surprise"), IconUnicodeGlyph(0xf5c2)]
        SolidFaceSurprise = 703,
        ///<summary>Regular Face Surprise</summary>
        ///<see href="https://fontawesome.com/icons/face-surprise?style=regular"/>
        [Description("Regular Face Surprise"), IconID("far-face-surprise"), IconUnicodeGlyph(0xf5c2)]
        RegularFaceSurprise = 704,
        ///<summary>Solid Face Tired</summary>
        ///<see href="https://fontawesome.com/icons/face-tired?style=solid"/>
        [Description("Solid Face Tired"), IconID("fas-face-tired"), IconUnicodeGlyph(0xf5c8)]
        SolidFaceTired = 705,
        ///<summary>Regular Face Tired</summary>
        ///<see href="https://fontawesome.com/icons/face-tired?style=regular"/>
        [Description("Regular Face Tired"), IconID("far-face-tired"), IconUnicodeGlyph(0xf5c8)]
        RegularFaceTired = 706,
        ///<summary>Brands Facebook</summary>
        ///<see href="https://fontawesome.com/icons/facebook?style=brands"/>
        [Description("Brands Facebook"), IconID("fab-facebook"), IconUnicodeGlyph(0xf09a)]
        BrandsFacebook = 707,
        ///<summary>Brands Facebook F</summary>
        ///<see href="https://fontawesome.com/icons/facebook-f?style=brands"/>
        [Description("Brands Facebook F"), IconID("fab-facebook-f"), IconUnicodeGlyph(0xf39e)]
        BrandsFacebookF = 708,
        ///<summary>Brands Facebook Messenger</summary>
        ///<see href="https://fontawesome.com/icons/facebook-messenger?style=brands"/>
        [Description("Brands Facebook Messenger"), IconID("fab-facebook-messenger"), IconUnicodeGlyph(0xf39f)]
        BrandsFacebookMessenger = 709,
        ///<summary>Solid Fan</summary>
        ///<see href="https://fontawesome.com/icons/fan?style=solid"/>
        [Description("Solid Fan"), IconID("fas-fan"), IconUnicodeGlyph(0xf863)]
        SolidFan = 710,
        ///<summary>Brands Fantasy Flight-games</summary>
        ///<see href="https://fontawesome.com/icons/fantasy-flight-games?style=brands"/>
        [Description("Brands Fantasy Flight-games"), IconID("fab-fantasy-flight-games"), IconUnicodeGlyph(0xf6dc)]
        BrandsFantasyFlightGames = 711,
        ///<summary>Solid Faucet</summary>
        ///<see href="https://fontawesome.com/icons/faucet?style=solid"/>
        [Description("Solid Faucet"), IconID("fas-faucet"), IconUnicodeGlyph(0xe005)]
        SolidFaucet = 712,
        ///<summary>Solid Faucet Drip</summary>
        ///<see href="https://fontawesome.com/icons/faucet-drip?style=solid"/>
        [Description("Solid Faucet Drip"), IconID("fas-faucet-drip"), IconUnicodeGlyph(0xe006)]
        SolidFaucetDrip = 713,
        ///<summary>Solid Fax</summary>
        ///<see href="https://fontawesome.com/icons/fax?style=solid"/>
        [Description("Solid Fax"), IconID("fas-fax"), IconUnicodeGlyph(0xf1ac)]
        SolidFax = 714,
        ///<summary>Solid Feather</summary>
        ///<see href="https://fontawesome.com/icons/feather?style=solid"/>
        [Description("Solid Feather"), IconID("fas-feather"), IconUnicodeGlyph(0xf52d)]
        SolidFeather = 715,
        ///<summary>Solid Feather pointed</summary>
        ///<see href="https://fontawesome.com/icons/feather-pointed?style=solid"/>
        [Description("Solid Feather pointed"), IconID("fas-feather-pointed"), IconUnicodeGlyph(0xf56b)]
        SolidFeatherPointed = 716,
        ///<summary>Brands FedEx</summary>
        ///<see href="https://fontawesome.com/icons/fedex?style=brands"/>
        [Description("Brands FedEx"), IconID("fab-fedex"), IconUnicodeGlyph(0xf797)]
        BrandsFedex = 717,
        ///<summary>Brands Fedora</summary>
        ///<see href="https://fontawesome.com/icons/fedora?style=brands"/>
        [Description("Brands Fedora"), IconID("fab-fedora"), IconUnicodeGlyph(0xf798)]
        BrandsFedora = 718,
        ///<summary>Solid Ferry</summary>
        ///<see href="https://fontawesome.com/icons/ferry?style=solid"/>
        [Description("Solid Ferry"), IconID("fas-ferry"), IconUnicodeGlyph(0xe4ea)]
        SolidFerry = 719,
        ///<summary>Brands Figma</summary>
        ///<see href="https://fontawesome.com/icons/figma?style=brands"/>
        [Description("Brands Figma"), IconID("fab-figma"), IconUnicodeGlyph(0xf799)]
        BrandsFigma = 720,
        ///<summary>Solid File</summary>
        ///<see href="https://fontawesome.com/icons/file?style=solid"/>
        [Description("Solid File"), IconID("fas-file"), IconUnicodeGlyph(0xf15b)]
        SolidFile = 721,
        ///<summary>Regular File</summary>
        ///<see href="https://fontawesome.com/icons/file?style=regular"/>
        [Description("Regular File"), IconID("far-file"), IconUnicodeGlyph(0xf15b)]
        RegularFile = 722,
        ///<summary>Solid File arrow down</summary>
        ///<see href="https://fontawesome.com/icons/file-arrow-down?style=solid"/>
        [Description("Solid File arrow down"), IconID("fas-file-arrow-down"), IconUnicodeGlyph(0xf56d)]
        SolidFileArrowDown = 723,
        ///<summary>Solid File arrow up</summary>
        ///<see href="https://fontawesome.com/icons/file-arrow-up?style=solid"/>
        [Description("Solid File arrow up"), IconID("fas-file-arrow-up"), IconUnicodeGlyph(0xf574)]
        SolidFileArrowUp = 724,
        ///<summary>Solid Audio File</summary>
        ///<see href="https://fontawesome.com/icons/file-audio?style=solid"/>
        [Description("Solid Audio File"), IconID("fas-file-audio"), IconUnicodeGlyph(0xf1c7)]
        SolidFileAudio = 725,
        ///<summary>Regular Audio File</summary>
        ///<see href="https://fontawesome.com/icons/file-audio?style=regular"/>
        [Description("Regular Audio File"), IconID("far-file-audio"), IconUnicodeGlyph(0xf1c7)]
        RegularFileAudio = 726,
        ///<summary>Solid File Circle-Check</summary>
        ///<see href="https://fontawesome.com/icons/file-circle-check?style=solid"/>
        [Description("Solid File Circle-Check"), IconID("fas-file-circle-check"), IconUnicodeGlyph(0xe5a0)]
        SolidFileCircleCheck = 727,
        ///<summary>Solid File Circle-exclamation</summary>
        ///<see href="https://fontawesome.com/icons/file-circle-exclamation?style=solid"/>
        [Description("Solid File Circle-exclamation"), IconID("fas-file-circle-exclamation"), IconUnicodeGlyph(0xe4eb)]
        SolidFileCircleExclamation = 728,
        ///<summary>Solid File Circle-minus</summary>
        ///<see href="https://fontawesome.com/icons/file-circle-minus?style=solid"/>
        [Description("Solid File Circle-minus"), IconID("fas-file-circle-minus"), IconUnicodeGlyph(0xe4ed)]
        SolidFileCircleMinus = 729,
        ///<summary>Solid File Circle-plus</summary>
        ///<see href="https://fontawesome.com/icons/file-circle-plus?style=solid"/>
        [Description("Solid File Circle-plus"), IconID("fas-file-circle-plus"), IconUnicodeGlyph(0xe494)]
        SolidFileCirclePlus = 730,
        ///<summary>Solid File Circle-question</summary>
        ///<see href="https://fontawesome.com/icons/file-circle-question?style=solid"/>
        [Description("Solid File Circle-question"), IconID("fas-file-circle-question"), IconUnicodeGlyph(0xe4ef)]
        SolidFileCircleQuestion = 731,
        ///<summary>Solid File Circle-xmark</summary>
        ///<see href="https://fontawesome.com/icons/file-circle-xmark?style=solid"/>
        [Description("Solid File Circle-xmark"), IconID("fas-file-circle-xmark"), IconUnicodeGlyph(0xe5a1)]
        SolidFileCircleXmark = 732,
        ///<summary>Solid Code File</summary>
        ///<see href="https://fontawesome.com/icons/file-code?style=solid"/>
        [Description("Solid Code File"), IconID("fas-file-code"), IconUnicodeGlyph(0xf1c9)]
        SolidFileCode = 733,
        ///<summary>Regular Code File</summary>
        ///<see href="https://fontawesome.com/icons/file-code?style=regular"/>
        [Description("Regular Code File"), IconID("far-file-code"), IconUnicodeGlyph(0xf1c9)]
        RegularFileCode = 734,
        ///<summary>Solid File Contract</summary>
        ///<see href="https://fontawesome.com/icons/file-contract?style=solid"/>
        [Description("Solid File Contract"), IconID("fas-file-contract"), IconUnicodeGlyph(0xf56c)]
        SolidFileContract = 735,
        ///<summary>Solid File CSV</summary>
        ///<see href="https://fontawesome.com/icons/file-csv?style=solid"/>
        [Description("Solid File CSV"), IconID("fas-file-csv"), IconUnicodeGlyph(0xf6dd)]
        SolidFileCsv = 736,
        ///<summary>Solid Excel File</summary>
        ///<see href="https://fontawesome.com/icons/file-excel?style=solid"/>
        [Description("Solid Excel File"), IconID("fas-file-excel"), IconUnicodeGlyph(0xf1c3)]
        SolidFileExcel = 737,
        ///<summary>Regular Excel File</summary>
        ///<see href="https://fontawesome.com/icons/file-excel?style=regular"/>
        [Description("Regular Excel File"), IconID("far-file-excel"), IconUnicodeGlyph(0xf1c3)]
        RegularFileExcel = 738,
        ///<summary>Solid File Export</summary>
        ///<see href="https://fontawesome.com/icons/file-export?style=solid"/>
        [Description("Solid File Export"), IconID("fas-file-export"), IconUnicodeGlyph(0xf56e)]
        SolidFileExport = 739,
        ///<summary>Solid Image File</summary>
        ///<see href="https://fontawesome.com/icons/file-image?style=solid"/>
        [Description("Solid Image File"), IconID("fas-file-image"), IconUnicodeGlyph(0xf1c5)]
        SolidFileImage = 740,
        ///<summary>Regular Image File</summary>
        ///<see href="https://fontawesome.com/icons/file-image?style=regular"/>
        [Description("Regular Image File"), IconID("far-file-image"), IconUnicodeGlyph(0xf1c5)]
        RegularFileImage = 741,
        ///<summary>Solid File Import</summary>
        ///<see href="https://fontawesome.com/icons/file-import?style=solid"/>
        [Description("Solid File Import"), IconID("fas-file-import"), IconUnicodeGlyph(0xf56f)]
        SolidFileImport = 742,
        ///<summary>Solid File Invoice</summary>
        ///<see href="https://fontawesome.com/icons/file-invoice?style=solid"/>
        [Description("Solid File Invoice"), IconID("fas-file-invoice"), IconUnicodeGlyph(0xf570)]
        SolidFileInvoice = 743,
        ///<summary>Solid File Invoice with US Dollar</summary>
        ///<see href="https://fontawesome.com/icons/file-invoice-dollar?style=solid"/>
        [Description("Solid File Invoice with US Dollar"), IconID("fas-file-invoice-dollar"), IconUnicodeGlyph(0xf571)]
        SolidFileInvoiceDollar = 744,
        ///<summary>Solid File lines</summary>
        ///<see href="https://fontawesome.com/icons/file-lines?style=solid"/>
        [Description("Solid File lines"), IconID("fas-file-lines"), IconUnicodeGlyph(0xf15c)]
        SolidFileLines = 745,
        ///<summary>Regular File lines</summary>
        ///<see href="https://fontawesome.com/icons/file-lines?style=regular"/>
        [Description("Regular File lines"), IconID("far-file-lines"), IconUnicodeGlyph(0xf15c)]
        RegularFileLines = 746,
        ///<summary>Solid Medical File</summary>
        ///<see href="https://fontawesome.com/icons/file-medical?style=solid"/>
        [Description("Solid Medical File"), IconID("fas-file-medical"), IconUnicodeGlyph(0xf477)]
        SolidFileMedical = 747,
        ///<summary>Solid PDF File</summary>
        ///<see href="https://fontawesome.com/icons/file-pdf?style=solid"/>
        [Description("Solid PDF File"), IconID("fas-file-pdf"), IconUnicodeGlyph(0xf1c1)]
        SolidFilePdf = 748,
        ///<summary>Regular PDF File</summary>
        ///<see href="https://fontawesome.com/icons/file-pdf?style=regular"/>
        [Description("Regular PDF File"), IconID("far-file-pdf"), IconUnicodeGlyph(0xf1c1)]
        RegularFilePdf = 749,
        ///<summary>Solid File pen</summary>
        ///<see href="https://fontawesome.com/icons/file-pen?style=solid"/>
        [Description("Solid File pen"), IconID("fas-file-pen"), IconUnicodeGlyph(0xf31c)]
        SolidFilePen = 750,
        ///<summary>Solid Powerpoint File</summary>
        ///<see href="https://fontawesome.com/icons/file-powerpoint?style=solid"/>
        [Description("Solid Powerpoint File"), IconID("fas-file-powerpoint"), IconUnicodeGlyph(0xf1c4)]
        SolidFilePowerpoint = 751,
        ///<summary>Regular Powerpoint File</summary>
        ///<see href="https://fontawesome.com/icons/file-powerpoint?style=regular"/>
        [Description("Regular Powerpoint File"), IconID("far-file-powerpoint"), IconUnicodeGlyph(0xf1c4)]
        RegularFilePowerpoint = 752,
        ///<summary>Solid File Prescription</summary>
        ///<see href="https://fontawesome.com/icons/file-prescription?style=solid"/>
        [Description("Solid File Prescription"), IconID("fas-file-prescription"), IconUnicodeGlyph(0xf572)]
        SolidFilePrescription = 753,
        ///<summary>Solid File Shield</summary>
        ///<see href="https://fontawesome.com/icons/file-shield?style=solid"/>
        [Description("Solid File Shield"), IconID("fas-file-shield"), IconUnicodeGlyph(0xe4f0)]
        SolidFileShield = 754,
        ///<summary>Solid File Signature</summary>
        ///<see href="https://fontawesome.com/icons/file-signature?style=solid"/>
        [Description("Solid File Signature"), IconID("fas-file-signature"), IconUnicodeGlyph(0xf573)]
        SolidFileSignature = 755,
        ///<summary>Solid Video File</summary>
        ///<see href="https://fontawesome.com/icons/file-video?style=solid"/>
        [Description("Solid Video File"), IconID("fas-file-video"), IconUnicodeGlyph(0xf1c8)]
        SolidFileVideo = 756,
        ///<summary>Regular Video File</summary>
        ///<see href="https://fontawesome.com/icons/file-video?style=regular"/>
        [Description("Regular Video File"), IconID("far-file-video"), IconUnicodeGlyph(0xf1c8)]
        RegularFileVideo = 757,
        ///<summary>Solid File waveform</summary>
        ///<see href="https://fontawesome.com/icons/file-waveform?style=solid"/>
        [Description("Solid File waveform"), IconID("fas-file-waveform"), IconUnicodeGlyph(0xf478)]
        SolidFileWaveform = 758,
        ///<summary>Solid Word File</summary>
        ///<see href="https://fontawesome.com/icons/file-word?style=solid"/>
        [Description("Solid Word File"), IconID("fas-file-word"), IconUnicodeGlyph(0xf1c2)]
        SolidFileWord = 759,
        ///<summary>Regular Word File</summary>
        ///<see href="https://fontawesome.com/icons/file-word?style=regular"/>
        [Description("Regular Word File"), IconID("far-file-word"), IconUnicodeGlyph(0xf1c2)]
        RegularFileWord = 760,
        ///<summary>Solid File zipper</summary>
        ///<see href="https://fontawesome.com/icons/file-zipper?style=solid"/>
        [Description("Solid File zipper"), IconID("fas-file-zipper"), IconUnicodeGlyph(0xf1c6)]
        SolidFileZipper = 761,
        ///<summary>Regular File zipper</summary>
        ///<see href="https://fontawesome.com/icons/file-zipper?style=regular"/>
        [Description("Regular File zipper"), IconID("far-file-zipper"), IconUnicodeGlyph(0xf1c6)]
        RegularFileZipper = 762,
        ///<summary>Solid Fill</summary>
        ///<see href="https://fontawesome.com/icons/fill?style=solid"/>
        [Description("Solid Fill"), IconID("fas-fill"), IconUnicodeGlyph(0xf575)]
        SolidFill = 763,
        ///<summary>Solid Fill Drip</summary>
        ///<see href="https://fontawesome.com/icons/fill-drip?style=solid"/>
        [Description("Solid Fill Drip"), IconID("fas-fill-drip"), IconUnicodeGlyph(0xf576)]
        SolidFillDrip = 764,
        ///<summary>Solid Film</summary>
        ///<see href="https://fontawesome.com/icons/film?style=solid"/>
        [Description("Solid Film"), IconID("fas-film"), IconUnicodeGlyph(0xf008)]
        SolidFilm = 765,
        ///<summary>Solid Filter</summary>
        ///<see href="https://fontawesome.com/icons/filter?style=solid"/>
        [Description("Solid Filter"), IconID("fas-filter"), IconUnicodeGlyph(0xf0b0)]
        SolidFilter = 766,
        ///<summary>Solid Filter Circle Dollar</summary>
        ///<see href="https://fontawesome.com/icons/filter-circle-dollar?style=solid"/>
        [Description("Solid Filter Circle Dollar"), IconID("fas-filter-circle-dollar"), IconUnicodeGlyph(0xf662)]
        SolidFilterCircleDollar = 767,
        ///<summary>Solid Filter Circle X Mark</summary>
        ///<see href="https://fontawesome.com/icons/filter-circle-xmark?style=solid"/>
        [Description("Solid Filter Circle X Mark"), IconID("fas-filter-circle-xmark"), IconUnicodeGlyph(0xe17b)]
        SolidFilterCircleXmark = 768,
        ///<summary>Solid Fingerprint</summary>
        ///<see href="https://fontawesome.com/icons/fingerprint?style=solid"/>
        [Description("Solid Fingerprint"), IconID("fas-fingerprint"), IconUnicodeGlyph(0xf577)]
        SolidFingerprint = 769,
        ///<summary>Solid fire</summary>
        ///<see href="https://fontawesome.com/icons/fire?style=solid"/>
        [Description("Solid fire"), IconID("fas-fire"), IconUnicodeGlyph(0xf06d)]
        SolidFire = 770,
        ///<summary>Solid Fire Burner</summary>
        ///<see href="https://fontawesome.com/icons/fire-burner?style=solid"/>
        [Description("Solid Fire Burner"), IconID("fas-fire-burner"), IconUnicodeGlyph(0xe4f1)]
        SolidFireBurner = 771,
        ///<summary>Solid fire-extinguisher</summary>
        ///<see href="https://fontawesome.com/icons/fire-extinguisher?style=solid"/>
        [Description("Solid fire-extinguisher"), IconID("fas-fire-extinguisher"), IconUnicodeGlyph(0xf134)]
        SolidFireExtinguisher = 772,
        ///<summary>Solid Fire flame curved</summary>
        ///<see href="https://fontawesome.com/icons/fire-flame-curved?style=solid"/>
        [Description("Solid Fire flame curved"), IconID("fas-fire-flame-curved"), IconUnicodeGlyph(0xf7e4)]
        SolidFireFlameCurved = 773,
        ///<summary>Solid Fire flame simple</summary>
        ///<see href="https://fontawesome.com/icons/fire-flame-simple?style=solid"/>
        [Description("Solid Fire flame simple"), IconID("fas-fire-flame-simple"), IconUnicodeGlyph(0xf46a)]
        SolidFireFlameSimple = 774,
        ///<summary>Brands Firefox</summary>
        ///<see href="https://fontawesome.com/icons/firefox?style=brands"/>
        [Description("Brands Firefox"), IconID("fab-firefox"), IconUnicodeGlyph(0xf269)]
        BrandsFirefox = 775,
        ///<summary>Brands Firefox Browser</summary>
        ///<see href="https://fontawesome.com/icons/firefox-browser?style=brands"/>
        [Description("Brands Firefox Browser"), IconID("fab-firefox-browser"), IconUnicodeGlyph(0xe007)]
        BrandsFirefoxBrowser = 776,
        ///<summary>Brands First Order</summary>
        ///<see href="https://fontawesome.com/icons/first-order?style=brands"/>
        [Description("Brands First Order"), IconID("fab-first-order"), IconUnicodeGlyph(0xf2b0)]
        BrandsFirstOrder = 777,
        ///<summary>Brands Alternate First Order</summary>
        ///<see href="https://fontawesome.com/icons/first-order-alt?style=brands"/>
        [Description("Brands Alternate First Order"), IconID("fab-first-order-alt"), IconUnicodeGlyph(0xf50a)]
        BrandsFirstOrderAlt = 778,
        ///<summary>Brands firstdraft</summary>
        ///<see href="https://fontawesome.com/icons/firstdraft?style=brands"/>
        [Description("Brands firstdraft"), IconID("fab-firstdraft"), IconUnicodeGlyph(0xf3a1)]
        BrandsFirstdraft = 779,
        ///<summary>Solid Fish</summary>
        ///<see href="https://fontawesome.com/icons/fish?style=solid"/>
        [Description("Solid Fish"), IconID("fas-fish"), IconUnicodeGlyph(0xf578)]
        SolidFish = 780,
        ///<summary>Solid Fish Fins</summary>
        ///<see href="https://fontawesome.com/icons/fish-fins?style=solid"/>
        [Description("Solid Fish Fins"), IconID("fas-fish-fins"), IconUnicodeGlyph(0xe4f2)]
        SolidFishFins = 781,
        ///<summary>Solid flag</summary>
        ///<see href="https://fontawesome.com/icons/flag?style=solid"/>
        [Description("Solid flag"), IconID("fas-flag"), IconUnicodeGlyph(0xf024)]
        SolidFlag = 782,
        ///<summary>Regular flag</summary>
        ///<see href="https://fontawesome.com/icons/flag?style=regular"/>
        [Description("Regular flag"), IconID("far-flag"), IconUnicodeGlyph(0xf024)]
        RegularFlag = 783,
        ///<summary>Solid flag-checkered</summary>
        ///<see href="https://fontawesome.com/icons/flag-checkered?style=solid"/>
        [Description("Solid flag-checkered"), IconID("fas-flag-checkered"), IconUnicodeGlyph(0xf11e)]
        SolidFlagCheckered = 784,
        ///<summary>Solid United States of America Flag</summary>
        ///<see href="https://fontawesome.com/icons/flag-usa?style=solid"/>
        [Description("Solid United States of America Flag"), IconID("fas-flag-usa"), IconUnicodeGlyph(0xf74d)]
        SolidFlagUsa = 785,
        ///<summary>Solid Flask</summary>
        ///<see href="https://fontawesome.com/icons/flask?style=solid"/>
        [Description("Solid Flask"), IconID("fas-flask"), IconUnicodeGlyph(0xf0c3)]
        SolidFlask = 786,
        ///<summary>Solid Flask and Vial</summary>
        ///<see href="https://fontawesome.com/icons/flask-vial?style=solid"/>
        [Description("Solid Flask and Vial"), IconID("fas-flask-vial"), IconUnicodeGlyph(0xe4f3)]
        SolidFlaskVial = 787,
        ///<summary>Brands Flickr</summary>
        ///<see href="https://fontawesome.com/icons/flickr?style=brands"/>
        [Description("Brands Flickr"), IconID("fab-flickr"), IconUnicodeGlyph(0xf16e)]
        BrandsFlickr = 788,
        ///<summary>Brands Flipboard</summary>
        ///<see href="https://fontawesome.com/icons/flipboard?style=brands"/>
        [Description("Brands Flipboard"), IconID("fab-flipboard"), IconUnicodeGlyph(0xf44d)]
        BrandsFlipboard = 789,
        ///<summary>Solid Floppy Disk</summary>
        ///<see href="https://fontawesome.com/icons/floppy-disk?style=solid"/>
        [Description("Solid Floppy Disk"), IconID("fas-floppy-disk"), IconUnicodeGlyph(0xf0c7)]
        SolidFloppyDisk = 790,
        ///<summary>Regular Floppy Disk</summary>
        ///<see href="https://fontawesome.com/icons/floppy-disk?style=regular"/>
        [Description("Regular Floppy Disk"), IconID("far-floppy-disk"), IconUnicodeGlyph(0xf0c7)]
        RegularFloppyDisk = 791,
        ///<summary>Solid Florin Sign</summary>
        ///<see href="https://fontawesome.com/icons/florin-sign?style=solid"/>
        [Description("Solid Florin Sign"), IconID("fas-florin-sign"), IconUnicodeGlyph(0xe184)]
        SolidFlorinSign = 792,
        ///<summary>Brands Fly</summary>
        ///<see href="https://fontawesome.com/icons/fly?style=brands"/>
        [Description("Brands Fly"), IconID("fab-fly"), IconUnicodeGlyph(0xf417)]
        BrandsFly = 793,
        ///<summary>Solid Folder</summary>
        ///<see href="https://fontawesome.com/icons/folder?style=solid"/>
        [Description("Solid Folder"), IconID("fas-folder"), IconUnicodeGlyph(0xf07b)]
        SolidFolder = 794,
        ///<summary>Regular Folder</summary>
        ///<see href="https://fontawesome.com/icons/folder?style=regular"/>
        [Description("Regular Folder"), IconID("far-folder"), IconUnicodeGlyph(0xf07b)]
        RegularFolder = 795,
        ///<summary>Solid Folder Closed</summary>
        ///<see href="https://fontawesome.com/icons/folder-closed?style=solid"/>
        [Description("Solid Folder Closed"), IconID("fas-folder-closed"), IconUnicodeGlyph(0xe185)]
        SolidFolderClosed = 796,
        ///<summary>Regular Folder Closed</summary>
        ///<see href="https://fontawesome.com/icons/folder-closed?style=regular"/>
        [Description("Regular Folder Closed"), IconID("far-folder-closed"), IconUnicodeGlyph(0xe185)]
        RegularFolderClosed = 797,
        ///<summary>Solid Folder Minus</summary>
        ///<see href="https://fontawesome.com/icons/folder-minus?style=solid"/>
        [Description("Solid Folder Minus"), IconID("fas-folder-minus"), IconUnicodeGlyph(0xf65d)]
        SolidFolderMinus = 798,
        ///<summary>Solid Folder Open</summary>
        ///<see href="https://fontawesome.com/icons/folder-open?style=solid"/>
        [Description("Solid Folder Open"), IconID("fas-folder-open"), IconUnicodeGlyph(0xf07c)]
        SolidFolderOpen = 799,
        ///<summary>Regular Folder Open</summary>
        ///<see href="https://fontawesome.com/icons/folder-open?style=regular"/>
        [Description("Regular Folder Open"), IconID("far-folder-open"), IconUnicodeGlyph(0xf07c)]
        RegularFolderOpen = 800,
        ///<summary>Solid Folder Plus</summary>
        ///<see href="https://fontawesome.com/icons/folder-plus?style=solid"/>
        [Description("Solid Folder Plus"), IconID("fas-folder-plus"), IconUnicodeGlyph(0xf65e)]
        SolidFolderPlus = 801,
        ///<summary>Solid Folder Tree</summary>
        ///<see href="https://fontawesome.com/icons/folder-tree?style=solid"/>
        [Description("Solid Folder Tree"), IconID("fas-folder-tree"), IconUnicodeGlyph(0xf802)]
        SolidFolderTree = 802,
        ///<summary>Solid font</summary>
        ///<see href="https://fontawesome.com/icons/font?style=solid"/>
        [Description("Solid font"), IconID("fas-font"), IconUnicodeGlyph(0xf031)]
        SolidFont = 803,
        ///<summary>Solid Font Awesome</summary>
        ///<see href="https://fontawesome.com/icons/font-awesome?style=solid"/>
        [Description("Solid Font Awesome"), IconID("fas-font-awesome"), IconUnicodeGlyph(0xf2b4)]
        SolidFontAwesome = 804,
        ///<summary>Regular Font Awesome</summary>
        ///<see href="https://fontawesome.com/icons/font-awesome?style=regular"/>
        [Description("Regular Font Awesome"), IconID("far-font-awesome"), IconUnicodeGlyph(0xf2b4)]
        RegularFontAwesome = 805,
        ///<summary>Brands Font Awesome</summary>
        ///<see href="https://fontawesome.com/icons/font-awesome?style=brands"/>
        [Description("Brands Font Awesome"), IconID("fab-font-awesome"), IconUnicodeGlyph(0xf2b4)]
        BrandsFontAwesome = 806,
        ///<summary>Brands Fonticons</summary>
        ///<see href="https://fontawesome.com/icons/fonticons?style=brands"/>
        [Description("Brands Fonticons"), IconID("fab-fonticons"), IconUnicodeGlyph(0xf280)]
        BrandsFonticons = 807,
        ///<summary>Brands Fonticons Fi</summary>
        ///<see href="https://fontawesome.com/icons/fonticons-fi?style=brands"/>
        [Description("Brands Fonticons Fi"), IconID("fab-fonticons-fi"), IconUnicodeGlyph(0xf3a2)]
        BrandsFonticonsFi = 808,
        ///<summary>Solid Football Ball</summary>
        ///<see href="https://fontawesome.com/icons/football?style=solid"/>
        [Description("Solid Football Ball"), IconID("fas-football"), IconUnicodeGlyph(0xf44e)]
        SolidFootball = 809,
        ///<summary>Brands Fort Awesome</summary>
        ///<see href="https://fontawesome.com/icons/fort-awesome?style=brands"/>
        [Description("Brands Fort Awesome"), IconID("fab-fort-awesome"), IconUnicodeGlyph(0xf286)]
        BrandsFortAwesome = 810,
        ///<summary>Brands Alternate Fort Awesome</summary>
        ///<see href="https://fontawesome.com/icons/fort-awesome-alt?style=brands"/>
        [Description("Brands Alternate Fort Awesome"), IconID("fab-fort-awesome-alt"), IconUnicodeGlyph(0xf3a3)]
        BrandsFortAwesomeAlt = 811,
        ///<summary>Brands Forumbee</summary>
        ///<see href="https://fontawesome.com/icons/forumbee?style=brands"/>
        [Description("Brands Forumbee"), IconID("fab-forumbee"), IconUnicodeGlyph(0xf211)]
        BrandsForumbee = 812,
        ///<summary>Solid forward</summary>
        ///<see href="https://fontawesome.com/icons/forward?style=solid"/>
        [Description("Solid forward"), IconID("fas-forward"), IconUnicodeGlyph(0xf04e)]
        SolidForward = 813,
        ///<summary>Solid Forward fast</summary>
        ///<see href="https://fontawesome.com/icons/forward-fast?style=solid"/>
        [Description("Solid Forward fast"), IconID("fas-forward-fast"), IconUnicodeGlyph(0xf050)]
        SolidForwardFast = 814,
        ///<summary>Solid Forward step</summary>
        ///<see href="https://fontawesome.com/icons/forward-step?style=solid"/>
        [Description("Solid Forward step"), IconID("fas-forward-step"), IconUnicodeGlyph(0xf051)]
        SolidForwardStep = 815,
        ///<summary>Brands Foursquare</summary>
        ///<see href="https://fontawesome.com/icons/foursquare?style=brands"/>
        [Description("Brands Foursquare"), IconID("fab-foursquare"), IconUnicodeGlyph(0xf180)]
        BrandsFoursquare = 816,
        ///<summary>Solid Franc Sign</summary>
        ///<see href="https://fontawesome.com/icons/franc-sign?style=solid"/>
        [Description("Solid Franc Sign"), IconID("fas-franc-sign"), IconUnicodeGlyph(0xe18f)]
        SolidFrancSign = 817,
        ///<summary>Brands freeCodeCamp</summary>
        ///<see href="https://fontawesome.com/icons/free-code-camp?style=brands"/>
        [Description("Brands freeCodeCamp"), IconID("fab-free-code-camp"), IconUnicodeGlyph(0xf2c5)]
        BrandsFreeCodeCamp = 818,
        ///<summary>Brands FreeBSD</summary>
        ///<see href="https://fontawesome.com/icons/freebsd?style=brands"/>
        [Description("Brands FreeBSD"), IconID("fab-freebsd"), IconUnicodeGlyph(0xf3a4)]
        BrandsFreebsd = 819,
        ///<summary>Solid Frog</summary>
        ///<see href="https://fontawesome.com/icons/frog?style=solid"/>
        [Description("Solid Frog"), IconID("fas-frog"), IconUnicodeGlyph(0xf52e)]
        SolidFrog = 820,
        ///<summary>Brands Fulcrum</summary>
        ///<see href="https://fontawesome.com/icons/fulcrum?style=brands"/>
        [Description("Brands Fulcrum"), IconID("fab-fulcrum"), IconUnicodeGlyph(0xf50b)]
        BrandsFulcrum = 821,
        ///<summary>Solid Futbol ball</summary>
        ///<see href="https://fontawesome.com/icons/futbol?style=solid"/>
        [Description("Solid Futbol ball"), IconID("fas-futbol"), IconUnicodeGlyph(0xf1e3)]
        SolidFutbol = 822,
        ///<summary>Regular Futbol ball</summary>
        ///<see href="https://fontawesome.com/icons/futbol?style=regular"/>
        [Description("Regular Futbol ball"), IconID("far-futbol"), IconUnicodeGlyph(0xf1e3)]
        RegularFutbol = 823,
        ///<summary>Solid G</summary>
        ///<see href="https://fontawesome.com/icons/g?style=solid"/>
        [Description("Solid G"), IconID("fas-g"), IconUnicodeGlyph(0x47)]
        SolidG = 824,
        ///<summary>Brands Galactic Republic</summary>
        ///<see href="https://fontawesome.com/icons/galactic-republic?style=brands"/>
        [Description("Brands Galactic Republic"), IconID("fab-galactic-republic"), IconUnicodeGlyph(0xf50c)]
        BrandsGalacticRepublic = 825,
        ///<summary>Brands Galactic Senate</summary>
        ///<see href="https://fontawesome.com/icons/galactic-senate?style=brands"/>
        [Description("Brands Galactic Senate"), IconID("fab-galactic-senate"), IconUnicodeGlyph(0xf50d)]
        BrandsGalacticSenate = 826,
        ///<summary>Solid Gamepad</summary>
        ///<see href="https://fontawesome.com/icons/gamepad?style=solid"/>
        [Description("Solid Gamepad"), IconID("fas-gamepad"), IconUnicodeGlyph(0xf11b)]
        SolidGamepad = 827,
        ///<summary>Solid Gas Pump</summary>
        ///<see href="https://fontawesome.com/icons/gas-pump?style=solid"/>
        [Description("Solid Gas Pump"), IconID("fas-gas-pump"), IconUnicodeGlyph(0xf52f)]
        SolidGasPump = 828,
        ///<summary>Solid Gauge med</summary>
        ///<see href="https://fontawesome.com/icons/gauge?style=solid"/>
        [Description("Solid Gauge med"), IconID("fas-gauge"), IconUnicodeGlyph(0xf624)]
        SolidGauge = 829,
        ///<summary>Solid Gauge</summary>
        ///<see href="https://fontawesome.com/icons/gauge-high?style=solid"/>
        [Description("Solid Gauge"), IconID("fas-gauge-high"), IconUnicodeGlyph(0xf625)]
        SolidGaugeHigh = 830,
        ///<summary>Solid Gauge simple med</summary>
        ///<see href="https://fontawesome.com/icons/gauge-simple?style=solid"/>
        [Description("Solid Gauge simple med"), IconID("fas-gauge-simple"), IconUnicodeGlyph(0xf629)]
        SolidGaugeSimple = 831,
        ///<summary>Solid Gauge simple</summary>
        ///<see href="https://fontawesome.com/icons/gauge-simple-high?style=solid"/>
        [Description("Solid Gauge simple"), IconID("fas-gauge-simple-high"), IconUnicodeGlyph(0xf62a)]
        SolidGaugeSimpleHigh = 832,
        ///<summary>Solid Gavel</summary>
        ///<see href="https://fontawesome.com/icons/gavel?style=solid"/>
        [Description("Solid Gavel"), IconID("fas-gavel"), IconUnicodeGlyph(0xf0e3)]
        SolidGavel = 833,
        ///<summary>Solid Gear</summary>
        ///<see href="https://fontawesome.com/icons/gear?style=solid"/>
        [Description("Solid Gear"), IconID("fas-gear"), IconUnicodeGlyph(0xf013)]
        SolidGear = 834,
        ///<summary>Solid Gears</summary>
        ///<see href="https://fontawesome.com/icons/gears?style=solid"/>
        [Description("Solid Gears"), IconID("fas-gears"), IconUnicodeGlyph(0xf085)]
        SolidGears = 835,
        ///<summary>Solid Gem</summary>
        ///<see href="https://fontawesome.com/icons/gem?style=solid"/>
        [Description("Solid Gem"), IconID("fas-gem"), IconUnicodeGlyph(0xf3a5)]
        SolidGem = 836,
        ///<summary>Regular Gem</summary>
        ///<see href="https://fontawesome.com/icons/gem?style=regular"/>
        [Description("Regular Gem"), IconID("far-gem"), IconUnicodeGlyph(0xf3a5)]
        RegularGem = 837,
        ///<summary>Solid Genderless</summary>
        ///<see href="https://fontawesome.com/icons/genderless?style=solid"/>
        [Description("Solid Genderless"), IconID("fas-genderless"), IconUnicodeGlyph(0xf22d)]
        SolidGenderless = 838,
        ///<summary>Brands Get Pocket</summary>
        ///<see href="https://fontawesome.com/icons/get-pocket?style=brands"/>
        [Description("Brands Get Pocket"), IconID("fab-get-pocket"), IconUnicodeGlyph(0xf265)]
        BrandsGetPocket = 839,
        ///<summary>Brands GG Currency</summary>
        ///<see href="https://fontawesome.com/icons/gg?style=brands"/>
        [Description("Brands GG Currency"), IconID("fab-gg"), IconUnicodeGlyph(0xf260)]
        BrandsGg = 840,
        ///<summary>Brands GG Currency Circle</summary>
        ///<see href="https://fontawesome.com/icons/gg-circle?style=brands"/>
        [Description("Brands GG Currency Circle"), IconID("fab-gg-circle"), IconUnicodeGlyph(0xf261)]
        BrandsGgCircle = 841,
        ///<summary>Solid Ghost</summary>
        ///<see href="https://fontawesome.com/icons/ghost?style=solid"/>
        [Description("Solid Ghost"), IconID("fas-ghost"), IconUnicodeGlyph(0xf6e2)]
        SolidGhost = 842,
        ///<summary>Solid gift</summary>
        ///<see href="https://fontawesome.com/icons/gift?style=solid"/>
        [Description("Solid gift"), IconID("fas-gift"), IconUnicodeGlyph(0xf06b)]
        SolidGift = 843,
        ///<summary>Solid Gifts</summary>
        ///<see href="https://fontawesome.com/icons/gifts?style=solid"/>
        [Description("Solid Gifts"), IconID("fas-gifts"), IconUnicodeGlyph(0xf79c)]
        SolidGifts = 844,
        ///<summary>Brands Git</summary>
        ///<see href="https://fontawesome.com/icons/git?style=brands"/>
        [Description("Brands Git"), IconID("fab-git"), IconUnicodeGlyph(0xf1d3)]
        BrandsGit = 845,
        ///<summary>Brands Git Alt</summary>
        ///<see href="https://fontawesome.com/icons/git-alt?style=brands"/>
        [Description("Brands Git Alt"), IconID("fab-git-alt"), IconUnicodeGlyph(0xf841)]
        BrandsGitAlt = 846,
        ///<summary>Brands GitHub</summary>
        ///<see href="https://fontawesome.com/icons/github?style=brands"/>
        [Description("Brands GitHub"), IconID("fab-github"), IconUnicodeGlyph(0xf09b)]
        BrandsGithub = 847,
        ///<summary>Brands Alternate GitHub</summary>
        ///<see href="https://fontawesome.com/icons/github-alt?style=brands"/>
        [Description("Brands Alternate GitHub"), IconID("fab-github-alt"), IconUnicodeGlyph(0xf113)]
        BrandsGithubAlt = 848,
        ///<summary>Brands GitKraken</summary>
        ///<see href="https://fontawesome.com/icons/gitkraken?style=brands"/>
        [Description("Brands GitKraken"), IconID("fab-gitkraken"), IconUnicodeGlyph(0xf3a6)]
        BrandsGitkraken = 849,
        ///<summary>Brands GitLab</summary>
        ///<see href="https://fontawesome.com/icons/gitlab?style=brands"/>
        [Description("Brands GitLab"), IconID("fab-gitlab"), IconUnicodeGlyph(0xf296)]
        BrandsGitlab = 850,
        ///<summary>Brands Gitter</summary>
        ///<see href="https://fontawesome.com/icons/gitter?style=brands"/>
        [Description("Brands Gitter"), IconID("fab-gitter"), IconUnicodeGlyph(0xf426)]
        BrandsGitter = 851,
        ///<summary>Solid Glass Water</summary>
        ///<see href="https://fontawesome.com/icons/glass-water?style=solid"/>
        [Description("Solid Glass Water"), IconID("fas-glass-water"), IconUnicodeGlyph(0xe4f4)]
        SolidGlassWater = 852,
        ///<summary>Solid Glass Water-droplet</summary>
        ///<see href="https://fontawesome.com/icons/glass-water-droplet?style=solid"/>
        [Description("Solid Glass Water-droplet"), IconID("fas-glass-water-droplet"), IconUnicodeGlyph(0xe4f5)]
        SolidGlassWaterDroplet = 853,
        ///<summary>Solid Glasses</summary>
        ///<see href="https://fontawesome.com/icons/glasses?style=solid"/>
        [Description("Solid Glasses"), IconID("fas-glasses"), IconUnicodeGlyph(0xf530)]
        SolidGlasses = 854,
        ///<summary>Brands Glide</summary>
        ///<see href="https://fontawesome.com/icons/glide?style=brands"/>
        [Description("Brands Glide"), IconID("fab-glide"), IconUnicodeGlyph(0xf2a5)]
        BrandsGlide = 855,
        ///<summary>Brands Glide G</summary>
        ///<see href="https://fontawesome.com/icons/glide-g?style=brands"/>
        [Description("Brands Glide G"), IconID("fab-glide-g"), IconUnicodeGlyph(0xf2a6)]
        BrandsGlideG = 856,
        ///<summary>Solid Globe</summary>
        ///<see href="https://fontawesome.com/icons/globe?style=solid"/>
        [Description("Solid Globe"), IconID("fas-globe"), IconUnicodeGlyph(0xf0ac)]
        SolidGlobe = 857,
        ///<summary>Brands Gofore</summary>
        ///<see href="https://fontawesome.com/icons/gofore?style=brands"/>
        [Description("Brands Gofore"), IconID("fab-gofore"), IconUnicodeGlyph(0xf3a7)]
        BrandsGofore = 858,
        ///<summary>Brands Go</summary>
        ///<see href="https://fontawesome.com/icons/golang?style=brands"/>
        [Description("Brands Go"), IconID("fab-golang"), IconUnicodeGlyph(0xe40f)]
        BrandsGolang = 859,
        ///<summary>Solid Golf ball tee</summary>
        ///<see href="https://fontawesome.com/icons/golf-ball-tee?style=solid"/>
        [Description("Solid Golf ball tee"), IconID("fas-golf-ball-tee"), IconUnicodeGlyph(0xf450)]
        SolidGolfBallTee = 860,
        ///<summary>Brands Goodreads</summary>
        ///<see href="https://fontawesome.com/icons/goodreads?style=brands"/>
        [Description("Brands Goodreads"), IconID("fab-goodreads"), IconUnicodeGlyph(0xf3a8)]
        BrandsGoodreads = 861,
        ///<summary>Brands Goodreads G</summary>
        ///<see href="https://fontawesome.com/icons/goodreads-g?style=brands"/>
        [Description("Brands Goodreads G"), IconID("fab-goodreads-g"), IconUnicodeGlyph(0xf3a9)]
        BrandsGoodreadsG = 862,
        ///<summary>Brands Google Logo</summary>
        ///<see href="https://fontawesome.com/icons/google?style=brands"/>
        [Description("Brands Google Logo"), IconID("fab-google"), IconUnicodeGlyph(0xf1a0)]
        BrandsGoogle = 863,
        ///<summary>Brands Google Drive</summary>
        ///<see href="https://fontawesome.com/icons/google-drive?style=brands"/>
        [Description("Brands Google Drive"), IconID("fab-google-drive"), IconUnicodeGlyph(0xf3aa)]
        BrandsGoogleDrive = 864,
        ///<summary>Brands Google Pay</summary>
        ///<see href="https://fontawesome.com/icons/google-pay?style=brands"/>
        [Description("Brands Google Pay"), IconID("fab-google-pay"), IconUnicodeGlyph(0xe079)]
        BrandsGooglePay = 865,
        ///<summary>Brands Google Play</summary>
        ///<see href="https://fontawesome.com/icons/google-play?style=brands"/>
        [Description("Brands Google Play"), IconID("fab-google-play"), IconUnicodeGlyph(0xf3ab)]
        BrandsGooglePlay = 866,
        ///<summary>Brands Google Plus</summary>
        ///<see href="https://fontawesome.com/icons/google-plus?style=brands"/>
        [Description("Brands Google Plus"), IconID("fab-google-plus"), IconUnicodeGlyph(0xf2b3)]
        BrandsGooglePlus = 867,
        ///<summary>Brands Google Plus G</summary>
        ///<see href="https://fontawesome.com/icons/google-plus-g?style=brands"/>
        [Description("Brands Google Plus G"), IconID("fab-google-plus-g"), IconUnicodeGlyph(0xf0d5)]
        BrandsGooglePlusG = 868,
        ///<summary>Brands Google Wallet</summary>
        ///<see href="https://fontawesome.com/icons/google-wallet?style=brands"/>
        [Description("Brands Google Wallet"), IconID("fab-google-wallet"), IconUnicodeGlyph(0xf1ee)]
        BrandsGoogleWallet = 869,
        ///<summary>Solid Gopuram</summary>
        ///<see href="https://fontawesome.com/icons/gopuram?style=solid"/>
        [Description("Solid Gopuram"), IconID("fas-gopuram"), IconUnicodeGlyph(0xf664)]
        SolidGopuram = 870,
        ///<summary>Solid Graduation Cap</summary>
        ///<see href="https://fontawesome.com/icons/graduation-cap?style=solid"/>
        [Description("Solid Graduation Cap"), IconID("fas-graduation-cap"), IconUnicodeGlyph(0xf19d)]
        SolidGraduationCap = 871,
        ///<summary>Brands Gratipay (Gittip)</summary>
        ///<see href="https://fontawesome.com/icons/gratipay?style=brands"/>
        [Description("Brands Gratipay (Gittip)"), IconID("fab-gratipay"), IconUnicodeGlyph(0xf184)]
        BrandsGratipay = 872,
        ///<summary>Brands Grav</summary>
        ///<see href="https://fontawesome.com/icons/grav?style=brands"/>
        [Description("Brands Grav"), IconID("fab-grav"), IconUnicodeGlyph(0xf2d6)]
        BrandsGrav = 873,
        ///<summary>Solid Greater Than</summary>
        ///<see href="https://fontawesome.com/icons/greater-than?style=solid"/>
        [Description("Solid Greater Than"), IconID("fas-greater-than"), IconUnicodeGlyph(0x3e)]
        SolidGreaterThan = 874,
        ///<summary>Solid Greater Than Equal To</summary>
        ///<see href="https://fontawesome.com/icons/greater-than-equal?style=solid"/>
        [Description("Solid Greater Than Equal To"), IconID("fas-greater-than-equal"), IconUnicodeGlyph(0xf532)]
        SolidGreaterThanEqual = 875,
        ///<summary>Solid Grip</summary>
        ///<see href="https://fontawesome.com/icons/grip?style=solid"/>
        [Description("Solid Grip"), IconID("fas-grip"), IconUnicodeGlyph(0xf58d)]
        SolidGrip = 876,
        ///<summary>Solid Grip Lines</summary>
        ///<see href="https://fontawesome.com/icons/grip-lines?style=solid"/>
        [Description("Solid Grip Lines"), IconID("fas-grip-lines"), IconUnicodeGlyph(0xf7a4)]
        SolidGripLines = 877,
        ///<summary>Solid Grip Lines Vertical</summary>
        ///<see href="https://fontawesome.com/icons/grip-lines-vertical?style=solid"/>
        [Description("Solid Grip Lines Vertical"), IconID("fas-grip-lines-vertical"), IconUnicodeGlyph(0xf7a5)]
        SolidGripLinesVertical = 878,
        ///<summary>Solid Grip Vertical</summary>
        ///<see href="https://fontawesome.com/icons/grip-vertical?style=solid"/>
        [Description("Solid Grip Vertical"), IconID("fas-grip-vertical"), IconUnicodeGlyph(0xf58e)]
        SolidGripVertical = 879,
        ///<summary>Brands Gripfire, Inc.</summary>
        ///<see href="https://fontawesome.com/icons/gripfire?style=brands"/>
        [Description("Brands Gripfire, Inc."), IconID("fab-gripfire"), IconUnicodeGlyph(0xf3ac)]
        BrandsGripfire = 880,
        ///<summary>Solid Group Arrows-rotate</summary>
        ///<see href="https://fontawesome.com/icons/group-arrows-rotate?style=solid"/>
        [Description("Solid Group Arrows-rotate"), IconID("fas-group-arrows-rotate"), IconUnicodeGlyph(0xe4f6)]
        SolidGroupArrowsRotate = 881,
        ///<summary>Brands Grunt</summary>
        ///<see href="https://fontawesome.com/icons/grunt?style=brands"/>
        [Description("Brands Grunt"), IconID("fab-grunt"), IconUnicodeGlyph(0xf3ad)]
        BrandsGrunt = 882,
        ///<summary>Solid Guarani Sign</summary>
        ///<see href="https://fontawesome.com/icons/guarani-sign?style=solid"/>
        [Description("Solid Guarani Sign"), IconID("fas-guarani-sign"), IconUnicodeGlyph(0xe19a)]
        SolidGuaraniSign = 883,
        ///<summary>Brands Guilded</summary>
        ///<see href="https://fontawesome.com/icons/guilded?style=brands"/>
        [Description("Brands Guilded"), IconID("fab-guilded"), IconUnicodeGlyph(0xe07e)]
        BrandsGuilded = 884,
        ///<summary>Solid Guitar</summary>
        ///<see href="https://fontawesome.com/icons/guitar?style=solid"/>
        [Description("Solid Guitar"), IconID("fas-guitar"), IconUnicodeGlyph(0xf7a6)]
        SolidGuitar = 885,
        ///<summary>Brands Gulp</summary>
        ///<see href="https://fontawesome.com/icons/gulp?style=brands"/>
        [Description("Brands Gulp"), IconID("fab-gulp"), IconUnicodeGlyph(0xf3ae)]
        BrandsGulp = 886,
        ///<summary>Solid Gun</summary>
        ///<see href="https://fontawesome.com/icons/gun?style=solid"/>
        [Description("Solid Gun"), IconID("fas-gun"), IconUnicodeGlyph(0xe19b)]
        SolidGun = 887,
        ///<summary>Solid H</summary>
        ///<see href="https://fontawesome.com/icons/h?style=solid"/>
        [Description("Solid H"), IconID("fas-h"), IconUnicodeGlyph(0x48)]
        SolidH = 888,
        ///<summary>Brands Hacker News</summary>
        ///<see href="https://fontawesome.com/icons/hacker-news?style=brands"/>
        [Description("Brands Hacker News"), IconID("fab-hacker-news"), IconUnicodeGlyph(0xf1d4)]
        BrandsHackerNews = 889,
        ///<summary>Brands Hackerrank</summary>
        ///<see href="https://fontawesome.com/icons/hackerrank?style=brands"/>
        [Description("Brands Hackerrank"), IconID("fab-hackerrank"), IconUnicodeGlyph(0xf5f7)]
        BrandsHackerrank = 890,
        ///<summary>Solid Hammer</summary>
        ///<see href="https://fontawesome.com/icons/hammer?style=solid"/>
        [Description("Solid Hammer"), IconID("fas-hammer"), IconUnicodeGlyph(0xf6e3)]
        SolidHammer = 891,
        ///<summary>Solid Hamsa</summary>
        ///<see href="https://fontawesome.com/icons/hamsa?style=solid"/>
        [Description("Solid Hamsa"), IconID("fas-hamsa"), IconUnicodeGlyph(0xf665)]
        SolidHamsa = 892,
        ///<summary>Solid Paper (Hand)</summary>
        ///<see href="https://fontawesome.com/icons/hand?style=solid"/>
        [Description("Solid Paper (Hand)"), IconID("fas-hand"), IconUnicodeGlyph(0xf256)]
        SolidHand = 893,
        ///<summary>Regular Paper (Hand)</summary>
        ///<see href="https://fontawesome.com/icons/hand?style=regular"/>
        [Description("Regular Paper (Hand)"), IconID("far-hand"), IconUnicodeGlyph(0xf256)]
        RegularHand = 894,
        ///<summary>Solid Rock (Hand)</summary>
        ///<see href="https://fontawesome.com/icons/hand-back-fist?style=solid"/>
        [Description("Solid Rock (Hand)"), IconID("fas-hand-back-fist"), IconUnicodeGlyph(0xf255)]
        SolidHandBackFist = 895,
        ///<summary>Regular Rock (Hand)</summary>
        ///<see href="https://fontawesome.com/icons/hand-back-fist?style=regular"/>
        [Description("Regular Rock (Hand)"), IconID("far-hand-back-fist"), IconUnicodeGlyph(0xf255)]
        RegularHandBackFist = 896,
        ///<summary>Solid Hand dots</summary>
        ///<see href="https://fontawesome.com/icons/hand-dots?style=solid"/>
        [Description("Solid Hand dots"), IconID("fas-hand-dots"), IconUnicodeGlyph(0xf461)]
        SolidHandDots = 897,
        ///<summary>Solid Raised Fist</summary>
        ///<see href="https://fontawesome.com/icons/hand-fist?style=solid"/>
        [Description("Solid Raised Fist"), IconID("fas-hand-fist"), IconUnicodeGlyph(0xf6de)]
        SolidHandFist = 898,
        ///<summary>Solid Hand Holding</summary>
        ///<see href="https://fontawesome.com/icons/hand-holding?style=solid"/>
        [Description("Solid Hand Holding"), IconID("fas-hand-holding"), IconUnicodeGlyph(0xf4bd)]
        SolidHandHolding = 899,
        ///<summary>Solid Hand holding dollar</summary>
        ///<see href="https://fontawesome.com/icons/hand-holding-dollar?style=solid"/>
        [Description("Solid Hand holding dollar"), IconID("fas-hand-holding-dollar"), IconUnicodeGlyph(0xf4c0)]
        SolidHandHoldingDollar = 900,
        ///<summary>Solid Hand holding droplet</summary>
        ///<see href="https://fontawesome.com/icons/hand-holding-droplet?style=solid"/>
        [Description("Solid Hand holding droplet"), IconID("fas-hand-holding-droplet"), IconUnicodeGlyph(0xf4c1)]
        SolidHandHoldingDroplet = 901,
        ///<summary>Solid Hand Holding-hand</summary>
        ///<see href="https://fontawesome.com/icons/hand-holding-hand?style=solid"/>
        [Description("Solid Hand Holding-hand"), IconID("fas-hand-holding-hand"), IconUnicodeGlyph(0xe4f7)]
        SolidHandHoldingHand = 902,
        ///<summary>Solid Hand Holding Heart</summary>
        ///<see href="https://fontawesome.com/icons/hand-holding-heart?style=solid"/>
        [Description("Solid Hand Holding Heart"), IconID("fas-hand-holding-heart"), IconUnicodeGlyph(0xf4be)]
        SolidHandHoldingHeart = 903,
        ///<summary>Solid Hand Holding Medical Cross</summary>
        ///<see href="https://fontawesome.com/icons/hand-holding-medical?style=solid"/>
        [Description("Solid Hand Holding Medical Cross"), IconID("fas-hand-holding-medical"), IconUnicodeGlyph(0xe05c)]
        SolidHandHoldingMedical = 904,
        ///<summary>Solid Lizard (Hand)</summary>
        ///<see href="https://fontawesome.com/icons/hand-lizard?style=solid"/>
        [Description("Solid Lizard (Hand)"), IconID("fas-hand-lizard"), IconUnicodeGlyph(0xf258)]
        SolidHandLizard = 905,
        ///<summary>Regular Lizard (Hand)</summary>
        ///<see href="https://fontawesome.com/icons/hand-lizard?style=regular"/>
        [Description("Regular Lizard (Hand)"), IconID("far-hand-lizard"), IconUnicodeGlyph(0xf258)]
        RegularHandLizard = 906,
        ///<summary>Solid Hand with Middle Finger Raised</summary>
        ///<see href="https://fontawesome.com/icons/hand-middle-finger?style=solid"/>
        [Description("Solid Hand with Middle Finger Raised"), IconID("fas-hand-middle-finger"), IconUnicodeGlyph(0xf806)]
        SolidHandMiddleFinger = 907,
        ///<summary>Solid Peace (Hand)</summary>
        ///<see href="https://fontawesome.com/icons/hand-peace?style=solid"/>
        [Description("Solid Peace (Hand)"), IconID("fas-hand-peace"), IconUnicodeGlyph(0xf25b)]
        SolidHandPeace = 908,
        ///<summary>Regular Peace (Hand)</summary>
        ///<see href="https://fontawesome.com/icons/hand-peace?style=regular"/>
        [Description("Regular Peace (Hand)"), IconID("far-hand-peace"), IconUnicodeGlyph(0xf25b)]
        RegularHandPeace = 909,
        ///<summary>Solid Hand Pointing Down</summary>
        ///<see href="https://fontawesome.com/icons/hand-point-down?style=solid"/>
        [Description("Solid Hand Pointing Down"), IconID("fas-hand-point-down"), IconUnicodeGlyph(0xf0a7)]
        SolidHandPointDown = 910,
        ///<summary>Regular Hand Pointing Down</summary>
        ///<see href="https://fontawesome.com/icons/hand-point-down?style=regular"/>
        [Description("Regular Hand Pointing Down"), IconID("far-hand-point-down"), IconUnicodeGlyph(0xf0a7)]
        RegularHandPointDown = 911,
        ///<summary>Solid Hand Pointing Left</summary>
        ///<see href="https://fontawesome.com/icons/hand-point-left?style=solid"/>
        [Description("Solid Hand Pointing Left"), IconID("fas-hand-point-left"), IconUnicodeGlyph(0xf0a5)]
        SolidHandPointLeft = 912,
        ///<summary>Regular Hand Pointing Left</summary>
        ///<see href="https://fontawesome.com/icons/hand-point-left?style=regular"/>
        [Description("Regular Hand Pointing Left"), IconID("far-hand-point-left"), IconUnicodeGlyph(0xf0a5)]
        RegularHandPointLeft = 913,
        ///<summary>Solid Hand Pointing Right</summary>
        ///<see href="https://fontawesome.com/icons/hand-point-right?style=solid"/>
        [Description("Solid Hand Pointing Right"), IconID("fas-hand-point-right"), IconUnicodeGlyph(0xf0a4)]
        SolidHandPointRight = 914,
        ///<summary>Regular Hand Pointing Right</summary>
        ///<see href="https://fontawesome.com/icons/hand-point-right?style=regular"/>
        [Description("Regular Hand Pointing Right"), IconID("far-hand-point-right"), IconUnicodeGlyph(0xf0a4)]
        RegularHandPointRight = 915,
        ///<summary>Solid Hand Pointing Up</summary>
        ///<see href="https://fontawesome.com/icons/hand-point-up?style=solid"/>
        [Description("Solid Hand Pointing Up"), IconID("fas-hand-point-up"), IconUnicodeGlyph(0xf0a6)]
        SolidHandPointUp = 916,
        ///<summary>Regular Hand Pointing Up</summary>
        ///<see href="https://fontawesome.com/icons/hand-point-up?style=regular"/>
        [Description("Regular Hand Pointing Up"), IconID("far-hand-point-up"), IconUnicodeGlyph(0xf0a6)]
        RegularHandPointUp = 917,
        ///<summary>Solid Pointer (Hand)</summary>
        ///<see href="https://fontawesome.com/icons/hand-pointer?style=solid"/>
        [Description("Solid Pointer (Hand)"), IconID("fas-hand-pointer"), IconUnicodeGlyph(0xf25a)]
        SolidHandPointer = 918,
        ///<summary>Regular Pointer (Hand)</summary>
        ///<see href="https://fontawesome.com/icons/hand-pointer?style=regular"/>
        [Description("Regular Pointer (Hand)"), IconID("far-hand-pointer"), IconUnicodeGlyph(0xf25a)]
        RegularHandPointer = 919,
        ///<summary>Solid Scissors (Hand)</summary>
        ///<see href="https://fontawesome.com/icons/hand-scissors?style=solid"/>
        [Description("Solid Scissors (Hand)"), IconID("fas-hand-scissors"), IconUnicodeGlyph(0xf257)]
        SolidHandScissors = 920,
        ///<summary>Regular Scissors (Hand)</summary>
        ///<see href="https://fontawesome.com/icons/hand-scissors?style=regular"/>
        [Description("Regular Scissors (Hand)"), IconID("far-hand-scissors"), IconUnicodeGlyph(0xf257)]
        RegularHandScissors = 921,
        ///<summary>Solid Hand Sparkles</summary>
        ///<see href="https://fontawesome.com/icons/hand-sparkles?style=solid"/>
        [Description("Solid Hand Sparkles"), IconID("fas-hand-sparkles"), IconUnicodeGlyph(0xe05d)]
        SolidHandSparkles = 922,
        ///<summary>Solid Spock (Hand)</summary>
        ///<see href="https://fontawesome.com/icons/hand-spock?style=solid"/>
        [Description("Solid Spock (Hand)"), IconID("fas-hand-spock"), IconUnicodeGlyph(0xf259)]
        SolidHandSpock = 923,
        ///<summary>Regular Spock (Hand)</summary>
        ///<see href="https://fontawesome.com/icons/hand-spock?style=regular"/>
        [Description("Regular Spock (Hand)"), IconID("far-hand-spock"), IconUnicodeGlyph(0xf259)]
        RegularHandSpock = 924,
        ///<summary>Solid Handcuffs</summary>
        ///<see href="https://fontawesome.com/icons/handcuffs?style=solid"/>
        [Description("Solid Handcuffs"), IconID("fas-handcuffs"), IconUnicodeGlyph(0xe4f8)]
        SolidHandcuffs = 925,
        ///<summary>Solid Hands</summary>
        ///<see href="https://fontawesome.com/icons/hands?style=solid"/>
        [Description("Solid Hands"), IconID("fas-hands"), IconUnicodeGlyph(0xf2a7)]
        SolidHands = 926,
        ///<summary>Solid Hands american sign language interpreting</summary>
        ///<see href="https://fontawesome.com/icons/hands-asl-interpreting?style=solid"/>
        [Description("Solid Hands american sign language interpreting"), IconID("fas-hands-asl-interpreting"), IconUnicodeGlyph(0xf2a3)]
        SolidHandsAslInterpreting = 927,
        ///<summary>Solid Hands Bound</summary>
        ///<see href="https://fontawesome.com/icons/hands-bound?style=solid"/>
        [Description("Solid Hands Bound"), IconID("fas-hands-bound"), IconUnicodeGlyph(0xe4f9)]
        SolidHandsBound = 928,
        ///<summary>Solid Hands bubbles</summary>
        ///<see href="https://fontawesome.com/icons/hands-bubbles?style=solid"/>
        [Description("Solid Hands bubbles"), IconID("fas-hands-bubbles"), IconUnicodeGlyph(0xe05e)]
        SolidHandsBubbles = 929,
        ///<summary>Solid Hands Clapping</summary>
        ///<see href="https://fontawesome.com/icons/hands-clapping?style=solid"/>
        [Description("Solid Hands Clapping"), IconID("fas-hands-clapping"), IconUnicodeGlyph(0xe1a8)]
        SolidHandsClapping = 930,
        ///<summary>Solid Hands holding</summary>
        ///<see href="https://fontawesome.com/icons/hands-holding?style=solid"/>
        [Description("Solid Hands holding"), IconID("fas-hands-holding"), IconUnicodeGlyph(0xf4c2)]
        SolidHandsHolding = 931,
        ///<summary>Solid Hands Holding-child</summary>
        ///<see href="https://fontawesome.com/icons/hands-holding-child?style=solid"/>
        [Description("Solid Hands Holding-child"), IconID("fas-hands-holding-child"), IconUnicodeGlyph(0xe4fa)]
        SolidHandsHoldingChild = 932,
        ///<summary>Solid Hands Holding-circle</summary>
        ///<see href="https://fontawesome.com/icons/hands-holding-circle?style=solid"/>
        [Description("Solid Hands Holding-circle"), IconID("fas-hands-holding-circle"), IconUnicodeGlyph(0xe4fb)]
        SolidHandsHoldingCircle = 933,
        ///<summary>Solid Hands praying</summary>
        ///<see href="https://fontawesome.com/icons/hands-praying?style=solid"/>
        [Description("Solid Hands praying"), IconID("fas-hands-praying"), IconUnicodeGlyph(0xf684)]
        SolidHandsPraying = 934,
        ///<summary>Solid Handshake</summary>
        ///<see href="https://fontawesome.com/icons/handshake?style=solid"/>
        [Description("Solid Handshake"), IconID("fas-handshake"), IconUnicodeGlyph(0xf2b5)]
        SolidHandshake = 935,
        ///<summary>Regular Handshake</summary>
        ///<see href="https://fontawesome.com/icons/handshake?style=regular"/>
        [Description("Regular Handshake"), IconID("far-handshake"), IconUnicodeGlyph(0xf2b5)]
        RegularHandshake = 936,
        ///<summary>Solid Handshake angle</summary>
        ///<see href="https://fontawesome.com/icons/handshake-angle?style=solid"/>
        [Description("Solid Handshake angle"), IconID("fas-handshake-angle"), IconUnicodeGlyph(0xf4c4)]
        SolidHandshakeAngle = 937,
        ///<summary>Solid Handshake simple</summary>
        ///<see href="https://fontawesome.com/icons/handshake-simple?style=solid"/>
        [Description("Solid Handshake simple"), IconID("fas-handshake-simple"), IconUnicodeGlyph(0xf4c6)]
        SolidHandshakeSimple = 938,
        ///<summary>Solid Handshake simple slash</summary>
        ///<see href="https://fontawesome.com/icons/handshake-simple-slash?style=solid"/>
        [Description("Solid Handshake simple slash"), IconID("fas-handshake-simple-slash"), IconUnicodeGlyph(0xe05f)]
        SolidHandshakeSimpleSlash = 939,
        ///<summary>Solid Handshake Slash</summary>
        ///<see href="https://fontawesome.com/icons/handshake-slash?style=solid"/>
        [Description("Solid Handshake Slash"), IconID("fas-handshake-slash"), IconUnicodeGlyph(0xe060)]
        SolidHandshakeSlash = 940,
        ///<summary>Solid Hanukiah</summary>
        ///<see href="https://fontawesome.com/icons/hanukiah?style=solid"/>
        [Description("Solid Hanukiah"), IconID("fas-hanukiah"), IconUnicodeGlyph(0xf6e6)]
        SolidHanukiah = 941,
        ///<summary>Solid Hard drive</summary>
        ///<see href="https://fontawesome.com/icons/hard-drive?style=solid"/>
        [Description("Solid Hard drive"), IconID("fas-hard-drive"), IconUnicodeGlyph(0xf0a0)]
        SolidHardDrive = 942,
        ///<summary>Regular Hard drive</summary>
        ///<see href="https://fontawesome.com/icons/hard-drive?style=regular"/>
        [Description("Regular Hard drive"), IconID("far-hard-drive"), IconUnicodeGlyph(0xf0a0)]
        RegularHardDrive = 943,
        ///<summary>Brands Hashnode</summary>
        ///<see href="https://fontawesome.com/icons/hashnode?style=brands"/>
        [Description("Brands Hashnode"), IconID("fab-hashnode"), IconUnicodeGlyph(0xe499)]
        BrandsHashnode = 944,
        ///<summary>Solid Hashtag</summary>
        ///<see href="https://fontawesome.com/icons/hashtag?style=solid"/>
        [Description("Solid Hashtag"), IconID("fas-hashtag"), IconUnicodeGlyph(0x23)]
        SolidHashtag = 945,
        ///<summary>Solid Cowboy Hat</summary>
        ///<see href="https://fontawesome.com/icons/hat-cowboy?style=solid"/>
        [Description("Solid Cowboy Hat"), IconID("fas-hat-cowboy"), IconUnicodeGlyph(0xf8c0)]
        SolidHatCowboy = 946,
        ///<summary>Solid Cowboy Hat Side</summary>
        ///<see href="https://fontawesome.com/icons/hat-cowboy-side?style=solid"/>
        [Description("Solid Cowboy Hat Side"), IconID("fas-hat-cowboy-side"), IconUnicodeGlyph(0xf8c1)]
        SolidHatCowboySide = 947,
        ///<summary>Solid Wizard's Hat</summary>
        ///<see href="https://fontawesome.com/icons/hat-wizard?style=solid"/>
        [Description("Solid Wizard's Hat"), IconID("fas-hat-wizard"), IconUnicodeGlyph(0xf6e8)]
        SolidHatWizard = 948,
        ///<summary>Solid Head Side Cough</summary>
        ///<see href="https://fontawesome.com/icons/head-side-cough?style=solid"/>
        [Description("Solid Head Side Cough"), IconID("fas-head-side-cough"), IconUnicodeGlyph(0xe061)]
        SolidHeadSideCough = 949,
        ///<summary>Solid Head Side-cough-slash</summary>
        ///<see href="https://fontawesome.com/icons/head-side-cough-slash?style=solid"/>
        [Description("Solid Head Side-cough-slash"), IconID("fas-head-side-cough-slash"), IconUnicodeGlyph(0xe062)]
        SolidHeadSideCoughSlash = 950,
        ///<summary>Solid Head Side Mask</summary>
        ///<see href="https://fontawesome.com/icons/head-side-mask?style=solid"/>
        [Description("Solid Head Side Mask"), IconID("fas-head-side-mask"), IconUnicodeGlyph(0xe063)]
        SolidHeadSideMask = 951,
        ///<summary>Solid Head Side Virus</summary>
        ///<see href="https://fontawesome.com/icons/head-side-virus?style=solid"/>
        [Description("Solid Head Side Virus"), IconID("fas-head-side-virus"), IconUnicodeGlyph(0xe064)]
        SolidHeadSideVirus = 952,
        ///<summary>Solid heading</summary>
        ///<see href="https://fontawesome.com/icons/heading?style=solid"/>
        [Description("Solid heading"), IconID("fas-heading"), IconUnicodeGlyph(0xf1dc)]
        SolidHeading = 953,
        ///<summary>Solid headphones</summary>
        ///<see href="https://fontawesome.com/icons/headphones?style=solid"/>
        [Description("Solid headphones"), IconID("fas-headphones"), IconUnicodeGlyph(0xf025)]
        SolidHeadphones = 954,
        ///<summary>Solid Headphones simple</summary>
        ///<see href="https://fontawesome.com/icons/headphones-simple?style=solid"/>
        [Description("Solid Headphones simple"), IconID("fas-headphones-simple"), IconUnicodeGlyph(0xf58f)]
        SolidHeadphonesSimple = 955,
        ///<summary>Solid Headset</summary>
        ///<see href="https://fontawesome.com/icons/headset?style=solid"/>
        [Description("Solid Headset"), IconID("fas-headset"), IconUnicodeGlyph(0xf590)]
        SolidHeadset = 956,
        ///<summary>Solid Heart</summary>
        ///<see href="https://fontawesome.com/icons/heart?style=solid"/>
        [Description("Solid Heart"), IconID("fas-heart"), IconUnicodeGlyph(0xf004)]
        SolidHeart = 957,
        ///<summary>Regular Heart</summary>
        ///<see href="https://fontawesome.com/icons/heart?style=regular"/>
        [Description("Regular Heart"), IconID("far-heart"), IconUnicodeGlyph(0xf004)]
        RegularHeart = 958,
        ///<summary>Solid Heart Circle-bolt</summary>
        ///<see href="https://fontawesome.com/icons/heart-circle-bolt?style=solid"/>
        [Description("Solid Heart Circle-bolt"), IconID("fas-heart-circle-bolt"), IconUnicodeGlyph(0xe4fc)]
        SolidHeartCircleBolt = 959,
        ///<summary>Solid Heart Circle-check</summary>
        ///<see href="https://fontawesome.com/icons/heart-circle-check?style=solid"/>
        [Description("Solid Heart Circle-check"), IconID("fas-heart-circle-check"), IconUnicodeGlyph(0xe4fd)]
        SolidHeartCircleCheck = 960,
        ///<summary>Solid Heart Circle-exclamation</summary>
        ///<see href="https://fontawesome.com/icons/heart-circle-exclamation?style=solid"/>
        [Description("Solid Heart Circle-exclamation"), IconID("fas-heart-circle-exclamation"), IconUnicodeGlyph(0xe4fe)]
        SolidHeartCircleExclamation = 961,
        ///<summary>Solid Heart Circle-minus</summary>
        ///<see href="https://fontawesome.com/icons/heart-circle-minus?style=solid"/>
        [Description("Solid Heart Circle-minus"), IconID("fas-heart-circle-minus"), IconUnicodeGlyph(0xe4ff)]
        SolidHeartCircleMinus = 962,
        ///<summary>Solid Heart Circle-plus</summary>
        ///<see href="https://fontawesome.com/icons/heart-circle-plus?style=solid"/>
        [Description("Solid Heart Circle-plus"), IconID("fas-heart-circle-plus"), IconUnicodeGlyph(0xe500)]
        SolidHeartCirclePlus = 963,
        ///<summary>Solid Heart Circle-xmark</summary>
        ///<see href="https://fontawesome.com/icons/heart-circle-xmark?style=solid"/>
        [Description("Solid Heart Circle-xmark"), IconID("fas-heart-circle-xmark"), IconUnicodeGlyph(0xe501)]
        SolidHeartCircleXmark = 964,
        ///<summary>Solid Heart crack</summary>
        ///<see href="https://fontawesome.com/icons/heart-crack?style=solid"/>
        [Description("Solid Heart crack"), IconID("fas-heart-crack"), IconUnicodeGlyph(0xf7a9)]
        SolidHeartCrack = 965,
        ///<summary>Solid Heart pulse</summary>
        ///<see href="https://fontawesome.com/icons/heart-pulse?style=solid"/>
        [Description("Solid Heart pulse"), IconID("fas-heart-pulse"), IconUnicodeGlyph(0xf21e)]
        SolidHeartPulse = 966,
        ///<summary>Solid Helicopter</summary>
        ///<see href="https://fontawesome.com/icons/helicopter?style=solid"/>
        [Description("Solid Helicopter"), IconID("fas-helicopter"), IconUnicodeGlyph(0xf533)]
        SolidHelicopter = 967,
        ///<summary>Solid Helicopter Symbol</summary>
        ///<see href="https://fontawesome.com/icons/helicopter-symbol?style=solid"/>
        [Description("Solid Helicopter Symbol"), IconID("fas-helicopter-symbol"), IconUnicodeGlyph(0xe502)]
        SolidHelicopterSymbol = 968,
        ///<summary>Solid Helmet safety</summary>
        ///<see href="https://fontawesome.com/icons/helmet-safety?style=solid"/>
        [Description("Solid Helmet safety"), IconID("fas-helmet-safety"), IconUnicodeGlyph(0xf807)]
        SolidHelmetSafety = 969,
        ///<summary>Solid Helmet Un</summary>
        ///<see href="https://fontawesome.com/icons/helmet-un?style=solid"/>
        [Description("Solid Helmet Un"), IconID("fas-helmet-un"), IconUnicodeGlyph(0xe503)]
        SolidHelmetUn = 970,
        ///<summary>Solid Highlighter</summary>
        ///<see href="https://fontawesome.com/icons/highlighter?style=solid"/>
        [Description("Solid Highlighter"), IconID("fas-highlighter"), IconUnicodeGlyph(0xf591)]
        SolidHighlighter = 971,
        ///<summary>Solid Hill Avalanche</summary>
        ///<see href="https://fontawesome.com/icons/hill-avalanche?style=solid"/>
        [Description("Solid Hill Avalanche"), IconID("fas-hill-avalanche"), IconUnicodeGlyph(0xe507)]
        SolidHillAvalanche = 972,
        ///<summary>Solid Hill Rockslide</summary>
        ///<see href="https://fontawesome.com/icons/hill-rockslide?style=solid"/>
        [Description("Solid Hill Rockslide"), IconID("fas-hill-rockslide"), IconUnicodeGlyph(0xe508)]
        SolidHillRockslide = 973,
        ///<summary>Solid Hippo</summary>
        ///<see href="https://fontawesome.com/icons/hippo?style=solid"/>
        [Description("Solid Hippo"), IconID("fas-hippo"), IconUnicodeGlyph(0xf6ed)]
        SolidHippo = 974,
        ///<summary>Brands Hips</summary>
        ///<see href="https://fontawesome.com/icons/hips?style=brands"/>
        [Description("Brands Hips"), IconID("fab-hips"), IconUnicodeGlyph(0xf452)]
        BrandsHips = 975,
        ///<summary>Brands HireAHelper</summary>
        ///<see href="https://fontawesome.com/icons/hire-a-helper?style=brands"/>
        [Description("Brands HireAHelper"), IconID("fab-hire-a-helper"), IconUnicodeGlyph(0xf3b0)]
        BrandsHireAHelper = 976,
        ///<summary>Brands Hive Blockchain Network</summary>
        ///<see href="https://fontawesome.com/icons/hive?style=brands"/>
        [Description("Brands Hive Blockchain Network"), IconID("fab-hive"), IconUnicodeGlyph(0xe07f)]
        BrandsHive = 977,
        ///<summary>Solid Hockey Puck</summary>
        ///<see href="https://fontawesome.com/icons/hockey-puck?style=solid"/>
        [Description("Solid Hockey Puck"), IconID("fas-hockey-puck"), IconUnicodeGlyph(0xf453)]
        SolidHockeyPuck = 978,
        ///<summary>Solid Holly Berry</summary>
        ///<see href="https://fontawesome.com/icons/holly-berry?style=solid"/>
        [Description("Solid Holly Berry"), IconID("fas-holly-berry"), IconUnicodeGlyph(0xf7aa)]
        SolidHollyBerry = 979,
        ///<summary>Brands Hooli</summary>
        ///<see href="https://fontawesome.com/icons/hooli?style=brands"/>
        [Description("Brands Hooli"), IconID("fab-hooli"), IconUnicodeGlyph(0xf427)]
        BrandsHooli = 980,
        ///<summary>Brands Hornbill</summary>
        ///<see href="https://fontawesome.com/icons/hornbill?style=brands"/>
        [Description("Brands Hornbill"), IconID("fab-hornbill"), IconUnicodeGlyph(0xf592)]
        BrandsHornbill = 981,
        ///<summary>Solid Horse</summary>
        ///<see href="https://fontawesome.com/icons/horse?style=solid"/>
        [Description("Solid Horse"), IconID("fas-horse"), IconUnicodeGlyph(0xf6f0)]
        SolidHorse = 982,
        ///<summary>Solid Horse Head</summary>
        ///<see href="https://fontawesome.com/icons/horse-head?style=solid"/>
        [Description("Solid Horse Head"), IconID("fas-horse-head"), IconUnicodeGlyph(0xf7ab)]
        SolidHorseHead = 983,
        ///<summary>Solid hospital</summary>
        ///<see href="https://fontawesome.com/icons/hospital?style=solid"/>
        [Description("Solid hospital"), IconID("fas-hospital"), IconUnicodeGlyph(0xf0f8)]
        SolidHospital = 984,
        ///<summary>Regular hospital</summary>
        ///<see href="https://fontawesome.com/icons/hospital?style=regular"/>
        [Description("Regular hospital"), IconID("far-hospital"), IconUnicodeGlyph(0xf0f8)]
        RegularHospital = 985,
        ///<summary>Solid Hospital with User</summary>
        ///<see href="https://fontawesome.com/icons/hospital-user?style=solid"/>
        [Description("Solid Hospital with User"), IconID("fas-hospital-user"), IconUnicodeGlyph(0xf80d)]
        SolidHospitalUser = 986,
        ///<summary>Solid Hot tub person</summary>
        ///<see href="https://fontawesome.com/icons/hot-tub-person?style=solid"/>
        [Description("Solid Hot tub person"), IconID("fas-hot-tub-person"), IconUnicodeGlyph(0xf593)]
        SolidHotTubPerson = 987,
        ///<summary>Solid Hot Dog</summary>
        ///<see href="https://fontawesome.com/icons/hotdog?style=solid"/>
        [Description("Solid Hot Dog"), IconID("fas-hotdog"), IconUnicodeGlyph(0xf80f)]
        SolidHotdog = 988,
        ///<summary>Solid Hotel</summary>
        ///<see href="https://fontawesome.com/icons/hotel?style=solid"/>
        [Description("Solid Hotel"), IconID("fas-hotel"), IconUnicodeGlyph(0xf594)]
        SolidHotel = 989,
        ///<summary>Brands Hotjar</summary>
        ///<see href="https://fontawesome.com/icons/hotjar?style=brands"/>
        [Description("Brands Hotjar"), IconID("fab-hotjar"), IconUnicodeGlyph(0xf3b1)]
        BrandsHotjar = 990,
        ///<summary>Solid Hourglass</summary>
        ///<see href="https://fontawesome.com/icons/hourglass?style=solid"/>
        [Description("Solid Hourglass"), IconID("fas-hourglass"), IconUnicodeGlyph(0xf254)]
        SolidHourglass = 991,
        ///<summary>Regular Hourglass</summary>
        ///<see href="https://fontawesome.com/icons/hourglass?style=regular"/>
        [Description("Regular Hourglass"), IconID("far-hourglass"), IconUnicodeGlyph(0xf254)]
        RegularHourglass = 992,
        ///<summary>Solid Hourglass End</summary>
        ///<see href="https://fontawesome.com/icons/hourglass-end?style=solid"/>
        [Description("Solid Hourglass End"), IconID("fas-hourglass-end"), IconUnicodeGlyph(0xf253)]
        SolidHourglassEnd = 993,
        ///<summary>Solid Hourglass Half</summary>
        ///<see href="https://fontawesome.com/icons/hourglass-half?style=solid"/>
        [Description("Solid Hourglass Half"), IconID("fas-hourglass-half"), IconUnicodeGlyph(0xf252)]
        SolidHourglassHalf = 994,
        ///<summary>Regular Hourglass Half</summary>
        ///<see href="https://fontawesome.com/icons/hourglass-half?style=regular"/>
        [Description("Regular Hourglass Half"), IconID("far-hourglass-half"), IconUnicodeGlyph(0xf252)]
        RegularHourglassHalf = 995,
        ///<summary>Solid Hourglass Start</summary>
        ///<see href="https://fontawesome.com/icons/hourglass-start?style=solid"/>
        [Description("Solid Hourglass Start"), IconID("fas-hourglass-start"), IconUnicodeGlyph(0xf251)]
        SolidHourglassStart = 996,
        ///<summary>Solid House</summary>
        ///<see href="https://fontawesome.com/icons/house?style=solid"/>
        [Description("Solid House"), IconID("fas-house"), IconUnicodeGlyph(0xf015)]
        SolidHouse = 997,
        ///<summary>Solid House Chimney</summary>
        ///<see href="https://fontawesome.com/icons/house-chimney?style=solid"/>
        [Description("Solid House Chimney"), IconID("fas-house-chimney"), IconUnicodeGlyph(0xe3af)]
        SolidHouseChimney = 998,
        ///<summary>Solid House crack</summary>
        ///<see href="https://fontawesome.com/icons/house-chimney-crack?style=solid"/>
        [Description("Solid House crack"), IconID("fas-house-chimney-crack"), IconUnicodeGlyph(0xf6f1)]
        SolidHouseChimneyCrack = 999,
        ///<summary>Solid House medical</summary>
        ///<see href="https://fontawesome.com/icons/house-chimney-medical?style=solid"/>
        [Description("Solid House medical"), IconID("fas-house-chimney-medical"), IconUnicodeGlyph(0xf7f2)]
        SolidHouseChimneyMedical = 1000,
        ///<summary>Solid House User</summary>
        ///<see href="https://fontawesome.com/icons/house-chimney-user?style=solid"/>
        [Description("Solid House User"), IconID("fas-house-chimney-user"), IconUnicodeGlyph(0xe065)]
        SolidHouseChimneyUser = 1001,
        ///<summary>Solid House with Window + Chimney</summary>
        ///<see href="https://fontawesome.com/icons/house-chimney-window?style=solid"/>
        [Description("Solid House with Window + Chimney"), IconID("fas-house-chimney-window"), IconUnicodeGlyph(0xe00d)]
        SolidHouseChimneyWindow = 1002,
        ///<summary>Solid House Circle-check</summary>
        ///<see href="https://fontawesome.com/icons/house-circle-check?style=solid"/>
        [Description("Solid House Circle-check"), IconID("fas-house-circle-check"), IconUnicodeGlyph(0xe509)]
        SolidHouseCircleCheck = 1003,
        ///<summary>Solid House Circle-exclamation</summary>
        ///<see href="https://fontawesome.com/icons/house-circle-exclamation?style=solid"/>
        [Description("Solid House Circle-exclamation"), IconID("fas-house-circle-exclamation"), IconUnicodeGlyph(0xe50a)]
        SolidHouseCircleExclamation = 1004,
        ///<summary>Solid House Circle-xmark</summary>
        ///<see href="https://fontawesome.com/icons/house-circle-xmark?style=solid"/>
        [Description("Solid House Circle-xmark"), IconID("fas-house-circle-xmark"), IconUnicodeGlyph(0xe50b)]
        SolidHouseCircleXmark = 1005,
        ///<summary>Solid House Simple Crack</summary>
        ///<see href="https://fontawesome.com/icons/house-crack?style=solid"/>
        [Description("Solid House Simple Crack"), IconID("fas-house-crack"), IconUnicodeGlyph(0xe3b1)]
        SolidHouseCrack = 1006,
        ///<summary>Solid House Fire</summary>
        ///<see href="https://fontawesome.com/icons/house-fire?style=solid"/>
        [Description("Solid House Fire"), IconID("fas-house-fire"), IconUnicodeGlyph(0xe50c)]
        SolidHouseFire = 1007,
        ///<summary>Solid House Flag</summary>
        ///<see href="https://fontawesome.com/icons/house-flag?style=solid"/>
        [Description("Solid House Flag"), IconID("fas-house-flag"), IconUnicodeGlyph(0xe50d)]
        SolidHouseFlag = 1008,
        ///<summary>Solid House Flood</summary>
        ///<see href="https://fontawesome.com/icons/house-flood-water?style=solid"/>
        [Description("Solid House Flood"), IconID("fas-house-flood-water"), IconUnicodeGlyph(0xe50e)]
        SolidHouseFloodWater = 1009,
        ///<summary>Solid House Flood-circle-arrow-right</summary>
        ///<see href="https://fontawesome.com/icons/house-flood-water-circle-arrow-right?style=solid"/>
        [Description("Solid House Flood-circle-arrow-right"), IconID("fas-house-flood-water-circle-arrow-right"), IconUnicodeGlyph(0xe50f)]
        SolidHouseFloodWaterCircleArrowRight = 1010,
        ///<summary>Solid House laptop</summary>
        ///<see href="https://fontawesome.com/icons/house-laptop?style=solid"/>
        [Description("Solid House laptop"), IconID("fas-house-laptop"), IconUnicodeGlyph(0xe066)]
        SolidHouseLaptop = 1011,
        ///<summary>Solid House Lock</summary>
        ///<see href="https://fontawesome.com/icons/house-lock?style=solid"/>
        [Description("Solid House Lock"), IconID("fas-house-lock"), IconUnicodeGlyph(0xe510)]
        SolidHouseLock = 1012,
        ///<summary>Solid House Simple Medical</summary>
        ///<see href="https://fontawesome.com/icons/house-medical?style=solid"/>
        [Description("Solid House Simple Medical"), IconID("fas-house-medical"), IconUnicodeGlyph(0xe3b2)]
        SolidHouseMedical = 1013,
        ///<summary>Solid House Medical-circle-check</summary>
        ///<see href="https://fontawesome.com/icons/house-medical-circle-check?style=solid"/>
        [Description("Solid House Medical-circle-check"), IconID("fas-house-medical-circle-check"), IconUnicodeGlyph(0xe511)]
        SolidHouseMedicalCircleCheck = 1014,
        ///<summary>Solid House Medical-circle-exclamation</summary>
        ///<see href="https://fontawesome.com/icons/house-medical-circle-exclamation?style=solid"/>
        [Description("Solid House Medical-circle-exclamation"), IconID("fas-house-medical-circle-exclamation"), IconUnicodeGlyph(0xe512)]
        SolidHouseMedicalCircleExclamation = 1015,
        ///<summary>Solid House Medical-circle-xmark</summary>
        ///<see href="https://fontawesome.com/icons/house-medical-circle-xmark?style=solid"/>
        [Description("Solid House Medical-circle-xmark"), IconID("fas-house-medical-circle-xmark"), IconUnicodeGlyph(0xe513)]
        SolidHouseMedicalCircleXmark = 1016,
        ///<summary>Solid House Medical-flag</summary>
        ///<see href="https://fontawesome.com/icons/house-medical-flag?style=solid"/>
        [Description("Solid House Medical-flag"), IconID("fas-house-medical-flag"), IconUnicodeGlyph(0xe514)]
        SolidHouseMedicalFlag = 1017,
        ///<summary>Solid House Signal</summary>
        ///<see href="https://fontawesome.com/icons/house-signal?style=solid"/>
        [Description("Solid House Signal"), IconID("fas-house-signal"), IconUnicodeGlyph(0xe012)]
        SolidHouseSignal = 1018,
        ///<summary>Solid House Tsunami</summary>
        ///<see href="https://fontawesome.com/icons/house-tsunami?style=solid"/>
        [Description("Solid House Tsunami"), IconID("fas-house-tsunami"), IconUnicodeGlyph(0xe515)]
        SolidHouseTsunami = 1019,
        ///<summary>Solid Home User</summary>
        ///<see href="https://fontawesome.com/icons/house-user?style=solid"/>
        [Description("Solid Home User"), IconID("fas-house-user"), IconUnicodeGlyph(0xe1b0)]
        SolidHouseUser = 1020,
        ///<summary>Brands Houzz</summary>
        ///<see href="https://fontawesome.com/icons/houzz?style=brands"/>
        [Description("Brands Houzz"), IconID("fab-houzz"), IconUnicodeGlyph(0xf27c)]
        BrandsHouzz = 1021,
        ///<summary>Solid Hryvnia sign</summary>
        ///<see href="https://fontawesome.com/icons/hryvnia-sign?style=solid"/>
        [Description("Solid Hryvnia sign"), IconID("fas-hryvnia-sign"), IconUnicodeGlyph(0xf6f2)]
        SolidHryvniaSign = 1022,
        ///<summary>Brands HTML 5 Logo</summary>
        ///<see href="https://fontawesome.com/icons/html5?style=brands"/>
        [Description("Brands HTML 5 Logo"), IconID("fab-html5"), IconUnicodeGlyph(0xf13b)]
        BrandsHtml5 = 1023,
        ///<summary>Brands HubSpot</summary>
        ///<see href="https://fontawesome.com/icons/hubspot?style=brands"/>
        [Description("Brands HubSpot"), IconID("fab-hubspot"), IconUnicodeGlyph(0xf3b2)]
        BrandsHubspot = 1024,
        ///<summary>Solid Hurricane</summary>
        ///<see href="https://fontawesome.com/icons/hurricane?style=solid"/>
        [Description("Solid Hurricane"), IconID("fas-hurricane"), IconUnicodeGlyph(0xf751)]
        SolidHurricane = 1025,
        ///<summary>Solid I</summary>
        ///<see href="https://fontawesome.com/icons/i?style=solid"/>
        [Description("Solid I"), IconID("fas-i"), IconUnicodeGlyph(0x49)]
        SolidI = 1026,
        ///<summary>Solid I Beam Cursor</summary>
        ///<see href="https://fontawesome.com/icons/i-cursor?style=solid"/>
        [Description("Solid I Beam Cursor"), IconID("fas-i-cursor"), IconUnicodeGlyph(0xf246)]
        SolidICursor = 1027,
        ///<summary>Solid Ice Cream</summary>
        ///<see href="https://fontawesome.com/icons/ice-cream?style=solid"/>
        [Description("Solid Ice Cream"), IconID("fas-ice-cream"), IconUnicodeGlyph(0xf810)]
        SolidIceCream = 1028,
        ///<summary>Solid Icicles</summary>
        ///<see href="https://fontawesome.com/icons/icicles?style=solid"/>
        [Description("Solid Icicles"), IconID("fas-icicles"), IconUnicodeGlyph(0xf7ad)]
        SolidIcicles = 1029,
        ///<summary>Solid Icons</summary>
        ///<see href="https://fontawesome.com/icons/icons?style=solid"/>
        [Description("Solid Icons"), IconID("fas-icons"), IconUnicodeGlyph(0xf86d)]
        SolidIcons = 1030,
        ///<summary>Solid Identification Badge</summary>
        ///<see href="https://fontawesome.com/icons/id-badge?style=solid"/>
        [Description("Solid Identification Badge"), IconID("fas-id-badge"), IconUnicodeGlyph(0xf2c1)]
        SolidIdBadge = 1031,
        ///<summary>Regular Identification Badge</summary>
        ///<see href="https://fontawesome.com/icons/id-badge?style=regular"/>
        [Description("Regular Identification Badge"), IconID("far-id-badge"), IconUnicodeGlyph(0xf2c1)]
        RegularIdBadge = 1032,
        ///<summary>Solid Identification Card</summary>
        ///<see href="https://fontawesome.com/icons/id-card?style=solid"/>
        [Description("Solid Identification Card"), IconID("fas-id-card"), IconUnicodeGlyph(0xf2c2)]
        SolidIdCard = 1033,
        ///<summary>Regular Identification Card</summary>
        ///<see href="https://fontawesome.com/icons/id-card?style=regular"/>
        [Description("Regular Identification Card"), IconID("far-id-card"), IconUnicodeGlyph(0xf2c2)]
        RegularIdCard = 1034,
        ///<summary>Solid Id card clip</summary>
        ///<see href="https://fontawesome.com/icons/id-card-clip?style=solid"/>
        [Description("Solid Id card clip"), IconID("fas-id-card-clip"), IconUnicodeGlyph(0xf47f)]
        SolidIdCardClip = 1035,
        ///<summary>Brands iDeal</summary>
        ///<see href="https://fontawesome.com/icons/ideal?style=brands"/>
        [Description("Brands iDeal"), IconID("fab-ideal"), IconUnicodeGlyph(0xe013)]
        BrandsIdeal = 1036,
        ///<summary>Solid Igloo</summary>
        ///<see href="https://fontawesome.com/icons/igloo?style=solid"/>
        [Description("Solid Igloo"), IconID("fas-igloo"), IconUnicodeGlyph(0xf7ae)]
        SolidIgloo = 1037,
        ///<summary>Solid Image</summary>
        ///<see href="https://fontawesome.com/icons/image?style=solid"/>
        [Description("Solid Image"), IconID("fas-image"), IconUnicodeGlyph(0xf03e)]
        SolidImage = 1038,
        ///<summary>Regular Image</summary>
        ///<see href="https://fontawesome.com/icons/image?style=regular"/>
        [Description("Regular Image"), IconID("far-image"), IconUnicodeGlyph(0xf03e)]
        RegularImage = 1039,
        ///<summary>Solid Image portrait</summary>
        ///<see href="https://fontawesome.com/icons/image-portrait?style=solid"/>
        [Description("Solid Image portrait"), IconID("fas-image-portrait"), IconUnicodeGlyph(0xf3e0)]
        SolidImagePortrait = 1040,
        ///<summary>Solid Images</summary>
        ///<see href="https://fontawesome.com/icons/images?style=solid"/>
        [Description("Solid Images"), IconID("fas-images"), IconUnicodeGlyph(0xf302)]
        SolidImages = 1041,
        ///<summary>Regular Images</summary>
        ///<see href="https://fontawesome.com/icons/images?style=regular"/>
        [Description("Regular Images"), IconID("far-images"), IconUnicodeGlyph(0xf302)]
        RegularImages = 1042,
        ///<summary>Brands IMDB</summary>
        ///<see href="https://fontawesome.com/icons/imdb?style=brands"/>
        [Description("Brands IMDB"), IconID("fab-imdb"), IconUnicodeGlyph(0xf2d8)]
        BrandsImdb = 1043,
        ///<summary>Solid inbox</summary>
        ///<see href="https://fontawesome.com/icons/inbox?style=solid"/>
        [Description("Solid inbox"), IconID("fas-inbox"), IconUnicodeGlyph(0xf01c)]
        SolidInbox = 1044,
        ///<summary>Solid Indent</summary>
        ///<see href="https://fontawesome.com/icons/indent?style=solid"/>
        [Description("Solid Indent"), IconID("fas-indent"), IconUnicodeGlyph(0xf03c)]
        SolidIndent = 1045,
        ///<summary>Solid Indian Rupee-sign</summary>
        ///<see href="https://fontawesome.com/icons/indian-rupee-sign?style=solid"/>
        [Description("Solid Indian Rupee-sign"), IconID("fas-indian-rupee-sign"), IconUnicodeGlyph(0xe1bc)]
        SolidIndianRupeeSign = 1046,
        ///<summary>Solid Industry</summary>
        ///<see href="https://fontawesome.com/icons/industry?style=solid"/>
        [Description("Solid Industry"), IconID("fas-industry"), IconUnicodeGlyph(0xf275)]
        SolidIndustry = 1047,
        ///<summary>Solid Infinity</summary>
        ///<see href="https://fontawesome.com/icons/infinity?style=solid"/>
        [Description("Solid Infinity"), IconID("fas-infinity"), IconUnicodeGlyph(0xf534)]
        SolidInfinity = 1048,
        ///<summary>Solid Info</summary>
        ///<see href="https://fontawesome.com/icons/info?style=solid"/>
        [Description("Solid Info"), IconID("fas-info"), IconUnicodeGlyph(0xf129)]
        SolidInfo = 1049,
        ///<summary>Brands Instagram</summary>
        ///<see href="https://fontawesome.com/icons/instagram?style=brands"/>
        [Description("Brands Instagram"), IconID("fab-instagram"), IconUnicodeGlyph(0xf16d)]
        BrandsInstagram = 1050,
        ///<summary>Brands InstaLOD</summary>
        ///<see href="https://fontawesome.com/icons/instalod?style=brands"/>
        [Description("Brands InstaLOD"), IconID("fab-instalod"), IconUnicodeGlyph(0xe081)]
        BrandsInstalod = 1051,
        ///<summary>Brands Intercom</summary>
        ///<see href="https://fontawesome.com/icons/intercom?style=brands"/>
        [Description("Brands Intercom"), IconID("fab-intercom"), IconUnicodeGlyph(0xf7af)]
        BrandsIntercom = 1052,
        ///<summary>Brands Internet-explorer</summary>
        ///<see href="https://fontawesome.com/icons/internet-explorer?style=brands"/>
        [Description("Brands Internet-explorer"), IconID("fab-internet-explorer"), IconUnicodeGlyph(0xf26b)]
        BrandsInternetExplorer = 1053,
        ///<summary>Brands InVision</summary>
        ///<see href="https://fontawesome.com/icons/invision?style=brands"/>
        [Description("Brands InVision"), IconID("fab-invision"), IconUnicodeGlyph(0xf7b0)]
        BrandsInvision = 1054,
        ///<summary>Brands ioxhost</summary>
        ///<see href="https://fontawesome.com/icons/ioxhost?style=brands"/>
        [Description("Brands ioxhost"), IconID("fab-ioxhost"), IconUnicodeGlyph(0xf208)]
        BrandsIoxhost = 1055,
        ///<summary>Solid italic</summary>
        ///<see href="https://fontawesome.com/icons/italic?style=solid"/>
        [Description("Solid italic"), IconID("fas-italic"), IconUnicodeGlyph(0xf033)]
        SolidItalic = 1056,
        ///<summary>Brands itch.io</summary>
        ///<see href="https://fontawesome.com/icons/itch-io?style=brands"/>
        [Description("Brands itch.io"), IconID("fab-itch-io"), IconUnicodeGlyph(0xf83a)]
        BrandsItchIo = 1057,
        ///<summary>Brands iTunes</summary>
        ///<see href="https://fontawesome.com/icons/itunes?style=brands"/>
        [Description("Brands iTunes"), IconID("fab-itunes"), IconUnicodeGlyph(0xf3b4)]
        BrandsItunes = 1058,
        ///<summary>Brands Itunes Note</summary>
        ///<see href="https://fontawesome.com/icons/itunes-note?style=brands"/>
        [Description("Brands Itunes Note"), IconID("fab-itunes-note"), IconUnicodeGlyph(0xf3b5)]
        BrandsItunesNote = 1059,
        ///<summary>Solid J</summary>
        ///<see href="https://fontawesome.com/icons/j?style=solid"/>
        [Description("Solid J"), IconID("fas-j"), IconUnicodeGlyph(0x4a)]
        SolidJ = 1060,
        ///<summary>Solid Jar</summary>
        ///<see href="https://fontawesome.com/icons/jar?style=solid"/>
        [Description("Solid Jar"), IconID("fas-jar"), IconUnicodeGlyph(0xe516)]
        SolidJar = 1061,
        ///<summary>Solid Jar Wheat</summary>
        ///<see href="https://fontawesome.com/icons/jar-wheat?style=solid"/>
        [Description("Solid Jar Wheat"), IconID("fas-jar-wheat"), IconUnicodeGlyph(0xe517)]
        SolidJarWheat = 1062,
        ///<summary>Brands Java</summary>
        ///<see href="https://fontawesome.com/icons/java?style=brands"/>
        [Description("Brands Java"), IconID("fab-java"), IconUnicodeGlyph(0xf4e4)]
        BrandsJava = 1063,
        ///<summary>Solid Jedi</summary>
        ///<see href="https://fontawesome.com/icons/jedi?style=solid"/>
        [Description("Solid Jedi"), IconID("fas-jedi"), IconUnicodeGlyph(0xf669)]
        SolidJedi = 1064,
        ///<summary>Brands Jedi Order</summary>
        ///<see href="https://fontawesome.com/icons/jedi-order?style=brands"/>
        [Description("Brands Jedi Order"), IconID("fab-jedi-order"), IconUnicodeGlyph(0xf50e)]
        BrandsJediOrder = 1065,
        ///<summary>Brands Jenkis</summary>
        ///<see href="https://fontawesome.com/icons/jenkins?style=brands"/>
        [Description("Brands Jenkis"), IconID("fab-jenkins"), IconUnicodeGlyph(0xf3b6)]
        BrandsJenkins = 1066,
        ///<summary>Solid Jet fighter</summary>
        ///<see href="https://fontawesome.com/icons/jet-fighter?style=solid"/>
        [Description("Solid Jet fighter"), IconID("fas-jet-fighter"), IconUnicodeGlyph(0xf0fb)]
        SolidJetFighter = 1067,
        ///<summary>Solid Jet Fighter Up</summary>
        ///<see href="https://fontawesome.com/icons/jet-fighter-up?style=solid"/>
        [Description("Solid Jet Fighter Up"), IconID("fas-jet-fighter-up"), IconUnicodeGlyph(0xe518)]
        SolidJetFighterUp = 1068,
        ///<summary>Brands Jira</summary>
        ///<see href="https://fontawesome.com/icons/jira?style=brands"/>
        [Description("Brands Jira"), IconID("fab-jira"), IconUnicodeGlyph(0xf7b1)]
        BrandsJira = 1069,
        ///<summary>Brands Joget</summary>
        ///<see href="https://fontawesome.com/icons/joget?style=brands"/>
        [Description("Brands Joget"), IconID("fab-joget"), IconUnicodeGlyph(0xf3b7)]
        BrandsJoget = 1070,
        ///<summary>Solid Joint</summary>
        ///<see href="https://fontawesome.com/icons/joint?style=solid"/>
        [Description("Solid Joint"), IconID("fas-joint"), IconUnicodeGlyph(0xf595)]
        SolidJoint = 1071,
        ///<summary>Brands Joomla Logo</summary>
        ///<see href="https://fontawesome.com/icons/joomla?style=brands"/>
        [Description("Brands Joomla Logo"), IconID("fab-joomla"), IconUnicodeGlyph(0xf1aa)]
        BrandsJoomla = 1072,
        ///<summary>Brands JavaScript (JS)</summary>
        ///<see href="https://fontawesome.com/icons/js?style=brands"/>
        [Description("Brands JavaScript (JS)"), IconID("fab-js"), IconUnicodeGlyph(0xf3b8)]
        BrandsJs = 1073,
        ///<summary>Brands jsFiddle</summary>
        ///<see href="https://fontawesome.com/icons/jsfiddle?style=brands"/>
        [Description("Brands jsFiddle"), IconID("fab-jsfiddle"), IconUnicodeGlyph(0xf1cc)]
        BrandsJsfiddle = 1074,
        ///<summary>Solid Jug Detergent</summary>
        ///<see href="https://fontawesome.com/icons/jug-detergent?style=solid"/>
        [Description("Solid Jug Detergent"), IconID("fas-jug-detergent"), IconUnicodeGlyph(0xe519)]
        SolidJugDetergent = 1075,
        ///<summary>Solid K</summary>
        ///<see href="https://fontawesome.com/icons/k?style=solid"/>
        [Description("Solid K"), IconID("fas-k"), IconUnicodeGlyph(0x4b)]
        SolidK = 1076,
        ///<summary>Solid Kaaba</summary>
        ///<see href="https://fontawesome.com/icons/kaaba?style=solid"/>
        [Description("Solid Kaaba"), IconID("fas-kaaba"), IconUnicodeGlyph(0xf66b)]
        SolidKaaba = 1077,
        ///<summary>Brands Kaggle</summary>
        ///<see href="https://fontawesome.com/icons/kaggle?style=brands"/>
        [Description("Brands Kaggle"), IconID("fab-kaggle"), IconUnicodeGlyph(0xf5fa)]
        BrandsKaggle = 1078,
        ///<summary>Solid key</summary>
        ///<see href="https://fontawesome.com/icons/key?style=solid"/>
        [Description("Solid key"), IconID("fas-key"), IconUnicodeGlyph(0xf084)]
        SolidKey = 1079,
        ///<summary>Brands Keybase</summary>
        ///<see href="https://fontawesome.com/icons/keybase?style=brands"/>
        [Description("Brands Keybase"), IconID("fab-keybase"), IconUnicodeGlyph(0xf4f5)]
        BrandsKeybase = 1080,
        ///<summary>Solid Keyboard</summary>
        ///<see href="https://fontawesome.com/icons/keyboard?style=solid"/>
        [Description("Solid Keyboard"), IconID("fas-keyboard"), IconUnicodeGlyph(0xf11c)]
        SolidKeyboard = 1081,
        ///<summary>Regular Keyboard</summary>
        ///<see href="https://fontawesome.com/icons/keyboard?style=regular"/>
        [Description("Regular Keyboard"), IconID("far-keyboard"), IconUnicodeGlyph(0xf11c)]
        RegularKeyboard = 1082,
        ///<summary>Brands KeyCDN</summary>
        ///<see href="https://fontawesome.com/icons/keycdn?style=brands"/>
        [Description("Brands KeyCDN"), IconID("fab-keycdn"), IconUnicodeGlyph(0xf3ba)]
        BrandsKeycdn = 1083,
        ///<summary>Solid Khanda</summary>
        ///<see href="https://fontawesome.com/icons/khanda?style=solid"/>
        [Description("Solid Khanda"), IconID("fas-khanda"), IconUnicodeGlyph(0xf66d)]
        SolidKhanda = 1084,
        ///<summary>Brands Kickstarter</summary>
        ///<see href="https://fontawesome.com/icons/kickstarter?style=brands"/>
        [Description("Brands Kickstarter"), IconID("fab-kickstarter"), IconUnicodeGlyph(0xf3bb)]
        BrandsKickstarter = 1085,
        ///<summary>Brands Kickstarter K</summary>
        ///<see href="https://fontawesome.com/icons/kickstarter-k?style=brands"/>
        [Description("Brands Kickstarter K"), IconID("fab-kickstarter-k"), IconUnicodeGlyph(0xf3bc)]
        BrandsKickstarterK = 1086,
        ///<summary>Solid Kip Sign</summary>
        ///<see href="https://fontawesome.com/icons/kip-sign?style=solid"/>
        [Description("Solid Kip Sign"), IconID("fas-kip-sign"), IconUnicodeGlyph(0xe1c4)]
        SolidKipSign = 1087,
        ///<summary>Solid Kit medical</summary>
        ///<see href="https://fontawesome.com/icons/kit-medical?style=solid"/>
        [Description("Solid Kit medical"), IconID("fas-kit-medical"), IconUnicodeGlyph(0xf479)]
        SolidKitMedical = 1088,
        ///<summary>Solid Kitchen Set</summary>
        ///<see href="https://fontawesome.com/icons/kitchen-set?style=solid"/>
        [Description("Solid Kitchen Set"), IconID("fas-kitchen-set"), IconUnicodeGlyph(0xe51a)]
        SolidKitchenSet = 1089,
        ///<summary>Solid Kiwi Bird</summary>
        ///<see href="https://fontawesome.com/icons/kiwi-bird?style=solid"/>
        [Description("Solid Kiwi Bird"), IconID("fas-kiwi-bird"), IconUnicodeGlyph(0xf535)]
        SolidKiwiBird = 1090,
        ///<summary>Brands KORVUE</summary>
        ///<see href="https://fontawesome.com/icons/korvue?style=brands"/>
        [Description("Brands KORVUE"), IconID("fab-korvue"), IconUnicodeGlyph(0xf42f)]
        BrandsKorvue = 1091,
        ///<summary>Solid L</summary>
        ///<see href="https://fontawesome.com/icons/l?style=solid"/>
        [Description("Solid L"), IconID("fas-l"), IconUnicodeGlyph(0x4c)]
        SolidL = 1092,
        ///<summary>Solid Land Mine-on</summary>
        ///<see href="https://fontawesome.com/icons/land-mine-on?style=solid"/>
        [Description("Solid Land Mine-on"), IconID("fas-land-mine-on"), IconUnicodeGlyph(0xe51b)]
        SolidLandMineOn = 1093,
        ///<summary>Solid Landmark</summary>
        ///<see href="https://fontawesome.com/icons/landmark?style=solid"/>
        [Description("Solid Landmark"), IconID("fas-landmark"), IconUnicodeGlyph(0xf66f)]
        SolidLandmark = 1094,
        ///<summary>Solid Landmark dome</summary>
        ///<see href="https://fontawesome.com/icons/landmark-dome?style=solid"/>
        [Description("Solid Landmark dome"), IconID("fas-landmark-dome"), IconUnicodeGlyph(0xf752)]
        SolidLandmarkDome = 1095,
        ///<summary>Solid Landmark Flag</summary>
        ///<see href="https://fontawesome.com/icons/landmark-flag?style=solid"/>
        [Description("Solid Landmark Flag"), IconID("fas-landmark-flag"), IconUnicodeGlyph(0xe51c)]
        SolidLandmarkFlag = 1096,
        ///<summary>Solid Language</summary>
        ///<see href="https://fontawesome.com/icons/language?style=solid"/>
        [Description("Solid Language"), IconID("fas-language"), IconUnicodeGlyph(0xf1ab)]
        SolidLanguage = 1097,
        ///<summary>Solid Laptop</summary>
        ///<see href="https://fontawesome.com/icons/laptop?style=solid"/>
        [Description("Solid Laptop"), IconID("fas-laptop"), IconUnicodeGlyph(0xf109)]
        SolidLaptop = 1098,
        ///<summary>Solid Laptop Code</summary>
        ///<see href="https://fontawesome.com/icons/laptop-code?style=solid"/>
        [Description("Solid Laptop Code"), IconID("fas-laptop-code"), IconUnicodeGlyph(0xf5fc)]
        SolidLaptopCode = 1099,
        ///<summary>Solid Laptop File</summary>
        ///<see href="https://fontawesome.com/icons/laptop-file?style=solid"/>
        [Description("Solid Laptop File"), IconID("fas-laptop-file"), IconUnicodeGlyph(0xe51d)]
        SolidLaptopFile = 1100,
        ///<summary>Solid Laptop Medical</summary>
        ///<see href="https://fontawesome.com/icons/laptop-medical?style=solid"/>
        [Description("Solid Laptop Medical"), IconID("fas-laptop-medical"), IconUnicodeGlyph(0xf812)]
        SolidLaptopMedical = 1101,
        ///<summary>Brands Laravel</summary>
        ///<see href="https://fontawesome.com/icons/laravel?style=brands"/>
        [Description("Brands Laravel"), IconID("fab-laravel"), IconUnicodeGlyph(0xf3bd)]
        BrandsLaravel = 1102,
        ///<summary>Solid Lari Sign</summary>
        ///<see href="https://fontawesome.com/icons/lari-sign?style=solid"/>
        [Description("Solid Lari Sign"), IconID("fas-lari-sign"), IconUnicodeGlyph(0xe1c8)]
        SolidLariSign = 1103,
        ///<summary>Brands last.fm</summary>
        ///<see href="https://fontawesome.com/icons/lastfm?style=brands"/>
        [Description("Brands last.fm"), IconID("fab-lastfm"), IconUnicodeGlyph(0xf202)]
        BrandsLastfm = 1104,
        ///<summary>Solid Layer Group</summary>
        ///<see href="https://fontawesome.com/icons/layer-group?style=solid"/>
        [Description("Solid Layer Group"), IconID("fas-layer-group"), IconUnicodeGlyph(0xf5fd)]
        SolidLayerGroup = 1105,
        ///<summary>Solid leaf</summary>
        ///<see href="https://fontawesome.com/icons/leaf?style=solid"/>
        [Description("Solid leaf"), IconID("fas-leaf"), IconUnicodeGlyph(0xf06c)]
        SolidLeaf = 1106,
        ///<summary>Brands Leanpub</summary>
        ///<see href="https://fontawesome.com/icons/leanpub?style=brands"/>
        [Description("Brands Leanpub"), IconID("fab-leanpub"), IconUnicodeGlyph(0xf212)]
        BrandsLeanpub = 1107,
        ///<summary>Solid Left long</summary>
        ///<see href="https://fontawesome.com/icons/left-long?style=solid"/>
        [Description("Solid Left long"), IconID("fas-left-long"), IconUnicodeGlyph(0xf30a)]
        SolidLeftLong = 1108,
        ///<summary>Solid Left right</summary>
        ///<see href="https://fontawesome.com/icons/left-right?style=solid"/>
        [Description("Solid Left right"), IconID("fas-left-right"), IconUnicodeGlyph(0xf337)]
        SolidLeftRight = 1109,
        ///<summary>Solid Lemon</summary>
        ///<see href="https://fontawesome.com/icons/lemon?style=solid"/>
        [Description("Solid Lemon"), IconID("fas-lemon"), IconUnicodeGlyph(0xf094)]
        SolidLemon = 1110,
        ///<summary>Regular Lemon</summary>
        ///<see href="https://fontawesome.com/icons/lemon?style=regular"/>
        [Description("Regular Lemon"), IconID("far-lemon"), IconUnicodeGlyph(0xf094)]
        RegularLemon = 1111,
        ///<summary>Brands Less</summary>
        ///<see href="https://fontawesome.com/icons/less?style=brands"/>
        [Description("Brands Less"), IconID("fab-less"), IconUnicodeGlyph(0xf41d)]
        BrandsLess = 1112,
        ///<summary>Solid Less Than</summary>
        ///<see href="https://fontawesome.com/icons/less-than?style=solid"/>
        [Description("Solid Less Than"), IconID("fas-less-than"), IconUnicodeGlyph(0x3c)]
        SolidLessThan = 1113,
        ///<summary>Solid Less Than Equal To</summary>
        ///<see href="https://fontawesome.com/icons/less-than-equal?style=solid"/>
        [Description("Solid Less Than Equal To"), IconID("fas-less-than-equal"), IconUnicodeGlyph(0xf537)]
        SolidLessThanEqual = 1114,
        ///<summary>Solid Life Ring</summary>
        ///<see href="https://fontawesome.com/icons/life-ring?style=solid"/>
        [Description("Solid Life Ring"), IconID("fas-life-ring"), IconUnicodeGlyph(0xf1cd)]
        SolidLifeRing = 1115,
        ///<summary>Regular Life Ring</summary>
        ///<see href="https://fontawesome.com/icons/life-ring?style=regular"/>
        [Description("Regular Life Ring"), IconID("far-life-ring"), IconUnicodeGlyph(0xf1cd)]
        RegularLifeRing = 1116,
        ///<summary>Solid Lightbulb</summary>
        ///<see href="https://fontawesome.com/icons/lightbulb?style=solid"/>
        [Description("Solid Lightbulb"), IconID("fas-lightbulb"), IconUnicodeGlyph(0xf0eb)]
        SolidLightbulb = 1117,
        ///<summary>Regular Lightbulb</summary>
        ///<see href="https://fontawesome.com/icons/lightbulb?style=regular"/>
        [Description("Regular Lightbulb"), IconID("far-lightbulb"), IconUnicodeGlyph(0xf0eb)]
        RegularLightbulb = 1118,
        ///<summary>Brands Line</summary>
        ///<see href="https://fontawesome.com/icons/line?style=brands"/>
        [Description("Brands Line"), IconID("fab-line"), IconUnicodeGlyph(0xf3c0)]
        BrandsLine = 1119,
        ///<summary>Solid Lines Leaning</summary>
        ///<see href="https://fontawesome.com/icons/lines-leaning?style=solid"/>
        [Description("Solid Lines Leaning"), IconID("fas-lines-leaning"), IconUnicodeGlyph(0xe51e)]
        SolidLinesLeaning = 1120,
        ///<summary>Solid Link</summary>
        ///<see href="https://fontawesome.com/icons/link?style=solid"/>
        [Description("Solid Link"), IconID("fas-link"), IconUnicodeGlyph(0xf0c1)]
        SolidLink = 1121,
        ///<summary>Solid Link Slash</summary>
        ///<see href="https://fontawesome.com/icons/link-slash?style=solid"/>
        [Description("Solid Link Slash"), IconID("fas-link-slash"), IconUnicodeGlyph(0xf127)]
        SolidLinkSlash = 1122,
        ///<summary>Brands LinkedIn</summary>
        ///<see href="https://fontawesome.com/icons/linkedin?style=brands"/>
        [Description("Brands LinkedIn"), IconID("fab-linkedin"), IconUnicodeGlyph(0xf08c)]
        BrandsLinkedin = 1123,
        ///<summary>Brands LinkedIn In</summary>
        ///<see href="https://fontawesome.com/icons/linkedin-in?style=brands"/>
        [Description("Brands LinkedIn In"), IconID("fab-linkedin-in"), IconUnicodeGlyph(0xf0e1)]
        BrandsLinkedinIn = 1124,
        ///<summary>Brands Linode</summary>
        ///<see href="https://fontawesome.com/icons/linode?style=brands"/>
        [Description("Brands Linode"), IconID("fab-linode"), IconUnicodeGlyph(0xf2b8)]
        BrandsLinode = 1125,
        ///<summary>Brands Linux</summary>
        ///<see href="https://fontawesome.com/icons/linux?style=brands"/>
        [Description("Brands Linux"), IconID("fab-linux"), IconUnicodeGlyph(0xf17c)]
        BrandsLinux = 1126,
        ///<summary>Solid Turkish Lira Sign</summary>
        ///<see href="https://fontawesome.com/icons/lira-sign?style=solid"/>
        [Description("Solid Turkish Lira Sign"), IconID("fas-lira-sign"), IconUnicodeGlyph(0xf195)]
        SolidLiraSign = 1127,
        ///<summary>Solid List</summary>
        ///<see href="https://fontawesome.com/icons/list?style=solid"/>
        [Description("Solid List"), IconID("fas-list"), IconUnicodeGlyph(0xf03a)]
        SolidList = 1128,
        ///<summary>Solid List check</summary>
        ///<see href="https://fontawesome.com/icons/list-check?style=solid"/>
        [Description("Solid List check"), IconID("fas-list-check"), IconUnicodeGlyph(0xf0ae)]
        SolidListCheck = 1129,
        ///<summary>Solid list-ol</summary>
        ///<see href="https://fontawesome.com/icons/list-ol?style=solid"/>
        [Description("Solid list-ol"), IconID("fas-list-ol"), IconUnicodeGlyph(0xf0cb)]
        SolidListOl = 1130,
        ///<summary>Solid list-ul</summary>
        ///<see href="https://fontawesome.com/icons/list-ul?style=solid"/>
        [Description("Solid list-ul"), IconID("fas-list-ul"), IconUnicodeGlyph(0xf0ca)]
        SolidListUl = 1131,
        ///<summary>Solid Litecoin Sign</summary>
        ///<see href="https://fontawesome.com/icons/litecoin-sign?style=solid"/>
        [Description("Solid Litecoin Sign"), IconID("fas-litecoin-sign"), IconUnicodeGlyph(0xe1d3)]
        SolidLitecoinSign = 1132,
        ///<summary>Solid location-arrow</summary>
        ///<see href="https://fontawesome.com/icons/location-arrow?style=solid"/>
        [Description("Solid location-arrow"), IconID("fas-location-arrow"), IconUnicodeGlyph(0xf124)]
        SolidLocationArrow = 1133,
        ///<summary>Solid Location Crosshairs</summary>
        ///<see href="https://fontawesome.com/icons/location-crosshairs?style=solid"/>
        [Description("Solid Location Crosshairs"), IconID("fas-location-crosshairs"), IconUnicodeGlyph(0xf601)]
        SolidLocationCrosshairs = 1134,
        ///<summary>Solid Location dot</summary>
        ///<see href="https://fontawesome.com/icons/location-dot?style=solid"/>
        [Description("Solid Location dot"), IconID("fas-location-dot"), IconUnicodeGlyph(0xf3c5)]
        SolidLocationDot = 1135,
        ///<summary>Solid Location</summary>
        ///<see href="https://fontawesome.com/icons/location-pin?style=solid"/>
        [Description("Solid Location"), IconID("fas-location-pin"), IconUnicodeGlyph(0xf041)]
        SolidLocationPin = 1136,
        ///<summary>Solid Location Pin-lock</summary>
        ///<see href="https://fontawesome.com/icons/location-pin-lock?style=solid"/>
        [Description("Solid Location Pin-lock"), IconID("fas-location-pin-lock"), IconUnicodeGlyph(0xe51f)]
        SolidLocationPinLock = 1137,
        ///<summary>Solid lock</summary>
        ///<see href="https://fontawesome.com/icons/lock?style=solid"/>
        [Description("Solid lock"), IconID("fas-lock"), IconUnicodeGlyph(0xf023)]
        SolidLock = 1138,
        ///<summary>Solid Lock Open</summary>
        ///<see href="https://fontawesome.com/icons/lock-open?style=solid"/>
        [Description("Solid Lock Open"), IconID("fas-lock-open"), IconUnicodeGlyph(0xf3c1)]
        SolidLockOpen = 1139,
        ///<summary>Solid Locust</summary>
        ///<see href="https://fontawesome.com/icons/locust?style=solid"/>
        [Description("Solid Locust"), IconID("fas-locust"), IconUnicodeGlyph(0xe520)]
        SolidLocust = 1140,
        ///<summary>Solid Lungs</summary>
        ///<see href="https://fontawesome.com/icons/lungs?style=solid"/>
        [Description("Solid Lungs"), IconID("fas-lungs"), IconUnicodeGlyph(0xf604)]
        SolidLungs = 1141,
        ///<summary>Solid Lungs Virus</summary>
        ///<see href="https://fontawesome.com/icons/lungs-virus?style=solid"/>
        [Description("Solid Lungs Virus"), IconID("fas-lungs-virus"), IconUnicodeGlyph(0xe067)]
        SolidLungsVirus = 1142,
        ///<summary>Brands lyft</summary>
        ///<see href="https://fontawesome.com/icons/lyft?style=brands"/>
        [Description("Brands lyft"), IconID("fab-lyft"), IconUnicodeGlyph(0xf3c3)]
        BrandsLyft = 1143,
        ///<summary>Solid M</summary>
        ///<see href="https://fontawesome.com/icons/m?style=solid"/>
        [Description("Solid M"), IconID("fas-m"), IconUnicodeGlyph(0x4d)]
        SolidM = 1144,
        ///<summary>Brands Magento</summary>
        ///<see href="https://fontawesome.com/icons/magento?style=brands"/>
        [Description("Brands Magento"), IconID("fab-magento"), IconUnicodeGlyph(0xf3c4)]
        BrandsMagento = 1145,
        ///<summary>Solid magnet</summary>
        ///<see href="https://fontawesome.com/icons/magnet?style=solid"/>
        [Description("Solid magnet"), IconID("fas-magnet"), IconUnicodeGlyph(0xf076)]
        SolidMagnet = 1146,
        ///<summary>Solid Magnifying glass</summary>
        ///<see href="https://fontawesome.com/icons/magnifying-glass?style=solid"/>
        [Description("Solid Magnifying glass"), IconID("fas-magnifying-glass"), IconUnicodeGlyph(0xf002)]
        SolidMagnifyingGlass = 1147,
        ///<summary>Solid Magnifying Glass-arrow-right</summary>
        ///<see href="https://fontawesome.com/icons/magnifying-glass-arrow-right?style=solid"/>
        [Description("Solid Magnifying Glass-arrow-right"), IconID("fas-magnifying-glass-arrow-right"), IconUnicodeGlyph(0xe521)]
        SolidMagnifyingGlassArrowRight = 1148,
        ///<summary>Solid Magnifying Glass-chart</summary>
        ///<see href="https://fontawesome.com/icons/magnifying-glass-chart?style=solid"/>
        [Description("Solid Magnifying Glass-chart"), IconID("fas-magnifying-glass-chart"), IconUnicodeGlyph(0xe522)]
        SolidMagnifyingGlassChart = 1149,
        ///<summary>Solid Magnifying glass dollar</summary>
        ///<see href="https://fontawesome.com/icons/magnifying-glass-dollar?style=solid"/>
        [Description("Solid Magnifying glass dollar"), IconID("fas-magnifying-glass-dollar"), IconUnicodeGlyph(0xf688)]
        SolidMagnifyingGlassDollar = 1150,
        ///<summary>Solid Magnifying glass location</summary>
        ///<see href="https://fontawesome.com/icons/magnifying-glass-location?style=solid"/>
        [Description("Solid Magnifying glass location"), IconID("fas-magnifying-glass-location"), IconUnicodeGlyph(0xf689)]
        SolidMagnifyingGlassLocation = 1151,
        ///<summary>Solid Magnifying glass minus</summary>
        ///<see href="https://fontawesome.com/icons/magnifying-glass-minus?style=solid"/>
        [Description("Solid Magnifying glass minus"), IconID("fas-magnifying-glass-minus"), IconUnicodeGlyph(0xf010)]
        SolidMagnifyingGlassMinus = 1152,
        ///<summary>Solid Magnifying glass plus</summary>
        ///<see href="https://fontawesome.com/icons/magnifying-glass-plus?style=solid"/>
        [Description("Solid Magnifying glass plus"), IconID("fas-magnifying-glass-plus"), IconUnicodeGlyph(0xf00e)]
        SolidMagnifyingGlassPlus = 1153,
        ///<summary>Brands Mailchimp</summary>
        ///<see href="https://fontawesome.com/icons/mailchimp?style=brands"/>
        [Description("Brands Mailchimp"), IconID("fab-mailchimp"), IconUnicodeGlyph(0xf59e)]
        BrandsMailchimp = 1154,
        ///<summary>Solid Manat Sign</summary>
        ///<see href="https://fontawesome.com/icons/manat-sign?style=solid"/>
        [Description("Solid Manat Sign"), IconID("fas-manat-sign"), IconUnicodeGlyph(0xe1d5)]
        SolidManatSign = 1155,
        ///<summary>Brands Mandalorian</summary>
        ///<see href="https://fontawesome.com/icons/mandalorian?style=brands"/>
        [Description("Brands Mandalorian"), IconID("fab-mandalorian"), IconUnicodeGlyph(0xf50f)]
        BrandsMandalorian = 1156,
        ///<summary>Solid Map</summary>
        ///<see href="https://fontawesome.com/icons/map?style=solid"/>
        [Description("Solid Map"), IconID("fas-map"), IconUnicodeGlyph(0xf279)]
        SolidMap = 1157,
        ///<summary>Regular Map</summary>
        ///<see href="https://fontawesome.com/icons/map?style=regular"/>
        [Description("Regular Map"), IconID("far-map"), IconUnicodeGlyph(0xf279)]
        RegularMap = 1158,
        ///<summary>Solid Map location</summary>
        ///<see href="https://fontawesome.com/icons/map-location?style=solid"/>
        [Description("Solid Map location"), IconID("fas-map-location"), IconUnicodeGlyph(0xf59f)]
        SolidMapLocation = 1159,
        ///<summary>Solid Map location dot</summary>
        ///<see href="https://fontawesome.com/icons/map-location-dot?style=solid"/>
        [Description("Solid Map location dot"), IconID("fas-map-location-dot"), IconUnicodeGlyph(0xf5a0)]
        SolidMapLocationDot = 1160,
        ///<summary>Solid Map Pin</summary>
        ///<see href="https://fontawesome.com/icons/map-pin?style=solid"/>
        [Description("Solid Map Pin"), IconID("fas-map-pin"), IconUnicodeGlyph(0xf276)]
        SolidMapPin = 1161,
        ///<summary>Brands Markdown</summary>
        ///<see href="https://fontawesome.com/icons/markdown?style=brands"/>
        [Description("Brands Markdown"), IconID("fab-markdown"), IconUnicodeGlyph(0xf60f)]
        BrandsMarkdown = 1162,
        ///<summary>Solid Marker</summary>
        ///<see href="https://fontawesome.com/icons/marker?style=solid"/>
        [Description("Solid Marker"), IconID("fas-marker"), IconUnicodeGlyph(0xf5a1)]
        SolidMarker = 1163,
        ///<summary>Solid Mars</summary>
        ///<see href="https://fontawesome.com/icons/mars?style=solid"/>
        [Description("Solid Mars"), IconID("fas-mars"), IconUnicodeGlyph(0xf222)]
        SolidMars = 1164,
        ///<summary>Solid Mars and Venus</summary>
        ///<see href="https://fontawesome.com/icons/mars-and-venus?style=solid"/>
        [Description("Solid Mars and Venus"), IconID("fas-mars-and-venus"), IconUnicodeGlyph(0xf224)]
        SolidMarsAndVenus = 1165,
        ///<summary>Solid Mars and Venus Burst</summary>
        ///<see href="https://fontawesome.com/icons/mars-and-venus-burst?style=solid"/>
        [Description("Solid Mars and Venus Burst"), IconID("fas-mars-and-venus-burst"), IconUnicodeGlyph(0xe523)]
        SolidMarsAndVenusBurst = 1166,
        ///<summary>Solid Mars Double</summary>
        ///<see href="https://fontawesome.com/icons/mars-double?style=solid"/>
        [Description("Solid Mars Double"), IconID("fas-mars-double"), IconUnicodeGlyph(0xf227)]
        SolidMarsDouble = 1167,
        ///<summary>Solid Mars Stroke</summary>
        ///<see href="https://fontawesome.com/icons/mars-stroke?style=solid"/>
        [Description("Solid Mars Stroke"), IconID("fas-mars-stroke"), IconUnicodeGlyph(0xf229)]
        SolidMarsStroke = 1168,
        ///<summary>Solid Mars stroke right</summary>
        ///<see href="https://fontawesome.com/icons/mars-stroke-right?style=solid"/>
        [Description("Solid Mars stroke right"), IconID("fas-mars-stroke-right"), IconUnicodeGlyph(0xf22b)]
        SolidMarsStrokeRight = 1169,
        ///<summary>Solid Mars stroke up</summary>
        ///<see href="https://fontawesome.com/icons/mars-stroke-up?style=solid"/>
        [Description("Solid Mars stroke up"), IconID("fas-mars-stroke-up"), IconUnicodeGlyph(0xf22a)]
        SolidMarsStrokeUp = 1170,
        ///<summary>Solid Martini glass</summary>
        ///<see href="https://fontawesome.com/icons/martini-glass?style=solid"/>
        [Description("Solid Martini glass"), IconID("fas-martini-glass"), IconUnicodeGlyph(0xf57b)]
        SolidMartiniGlass = 1171,
        ///<summary>Solid Martini glass citrus</summary>
        ///<see href="https://fontawesome.com/icons/martini-glass-citrus?style=solid"/>
        [Description("Solid Martini glass citrus"), IconID("fas-martini-glass-citrus"), IconUnicodeGlyph(0xf561)]
        SolidMartiniGlassCitrus = 1172,
        ///<summary>Solid Martini glass empty</summary>
        ///<see href="https://fontawesome.com/icons/martini-glass-empty?style=solid"/>
        [Description("Solid Martini glass empty"), IconID("fas-martini-glass-empty"), IconUnicodeGlyph(0xf000)]
        SolidMartiniGlassEmpty = 1173,
        ///<summary>Solid Mask</summary>
        ///<see href="https://fontawesome.com/icons/mask?style=solid"/>
        [Description("Solid Mask"), IconID("fas-mask"), IconUnicodeGlyph(0xf6fa)]
        SolidMask = 1174,
        ///<summary>Solid Face Mask</summary>
        ///<see href="https://fontawesome.com/icons/mask-face?style=solid"/>
        [Description("Solid Face Mask"), IconID("fas-mask-face"), IconUnicodeGlyph(0xe1d7)]
        SolidMaskFace = 1175,
        ///<summary>Solid Mask Ventilator</summary>
        ///<see href="https://fontawesome.com/icons/mask-ventilator?style=solid"/>
        [Description("Solid Mask Ventilator"), IconID("fas-mask-ventilator"), IconUnicodeGlyph(0xe524)]
        SolidMaskVentilator = 1176,
        ///<summary>Solid Masks theater</summary>
        ///<see href="https://fontawesome.com/icons/masks-theater?style=solid"/>
        [Description("Solid Masks theater"), IconID("fas-masks-theater"), IconUnicodeGlyph(0xf630)]
        SolidMasksTheater = 1177,
        ///<summary>Brands Mastodon</summary>
        ///<see href="https://fontawesome.com/icons/mastodon?style=brands"/>
        [Description("Brands Mastodon"), IconID("fab-mastodon"), IconUnicodeGlyph(0xf4f6)]
        BrandsMastodon = 1178,
        ///<summary>Solid Mattress Pillow</summary>
        ///<see href="https://fontawesome.com/icons/mattress-pillow?style=solid"/>
        [Description("Solid Mattress Pillow"), IconID("fas-mattress-pillow"), IconUnicodeGlyph(0xe525)]
        SolidMattressPillow = 1179,
        ///<summary>Brands MaxCDN</summary>
        ///<see href="https://fontawesome.com/icons/maxcdn?style=brands"/>
        [Description("Brands MaxCDN"), IconID("fab-maxcdn"), IconUnicodeGlyph(0xf136)]
        BrandsMaxcdn = 1180,
        ///<summary>Solid Maximize</summary>
        ///<see href="https://fontawesome.com/icons/maximize?style=solid"/>
        [Description("Solid Maximize"), IconID("fas-maximize"), IconUnicodeGlyph(0xf31e)]
        SolidMaximize = 1181,
        ///<summary>Brands Material Design for Bootstrap</summary>
        ///<see href="https://fontawesome.com/icons/mdb?style=brands"/>
        [Description("Brands Material Design for Bootstrap"), IconID("fab-mdb"), IconUnicodeGlyph(0xf8ca)]
        BrandsMdb = 1182,
        ///<summary>Solid Medal</summary>
        ///<see href="https://fontawesome.com/icons/medal?style=solid"/>
        [Description("Solid Medal"), IconID("fas-medal"), IconUnicodeGlyph(0xf5a2)]
        SolidMedal = 1183,
        ///<summary>Brands MedApps</summary>
        ///<see href="https://fontawesome.com/icons/medapps?style=brands"/>
        [Description("Brands MedApps"), IconID("fab-medapps"), IconUnicodeGlyph(0xf3c6)]
        BrandsMedapps = 1184,
        ///<summary>Brands Medium</summary>
        ///<see href="https://fontawesome.com/icons/medium?style=brands"/>
        [Description("Brands Medium"), IconID("fab-medium"), IconUnicodeGlyph(0xf23a)]
        BrandsMedium = 1185,
        ///<summary>Brands MRT</summary>
        ///<see href="https://fontawesome.com/icons/medrt?style=brands"/>
        [Description("Brands MRT"), IconID("fab-medrt"), IconUnicodeGlyph(0xf3c8)]
        BrandsMedrt = 1186,
        ///<summary>Brands Meetup</summary>
        ///<see href="https://fontawesome.com/icons/meetup?style=brands"/>
        [Description("Brands Meetup"), IconID("fab-meetup"), IconUnicodeGlyph(0xf2e0)]
        BrandsMeetup = 1187,
        ///<summary>Brands Megaport</summary>
        ///<see href="https://fontawesome.com/icons/megaport?style=brands"/>
        [Description("Brands Megaport"), IconID("fab-megaport"), IconUnicodeGlyph(0xf5a3)]
        BrandsMegaport = 1188,
        ///<summary>Solid Memory</summary>
        ///<see href="https://fontawesome.com/icons/memory?style=solid"/>
        [Description("Solid Memory"), IconID("fas-memory"), IconUnicodeGlyph(0xf538)]
        SolidMemory = 1189,
        ///<summary>Brands Mendeley</summary>
        ///<see href="https://fontawesome.com/icons/mendeley?style=brands"/>
        [Description("Brands Mendeley"), IconID("fab-mendeley"), IconUnicodeGlyph(0xf7b3)]
        BrandsMendeley = 1190,
        ///<summary>Solid Menorah</summary>
        ///<see href="https://fontawesome.com/icons/menorah?style=solid"/>
        [Description("Solid Menorah"), IconID("fas-menorah"), IconUnicodeGlyph(0xf676)]
        SolidMenorah = 1191,
        ///<summary>Solid Mercury</summary>
        ///<see href="https://fontawesome.com/icons/mercury?style=solid"/>
        [Description("Solid Mercury"), IconID("fas-mercury"), IconUnicodeGlyph(0xf223)]
        SolidMercury = 1192,
        ///<summary>Solid Message</summary>
        ///<see href="https://fontawesome.com/icons/message?style=solid"/>
        [Description("Solid Message"), IconID("fas-message"), IconUnicodeGlyph(0xf27a)]
        SolidMessage = 1193,
        ///<summary>Regular Message</summary>
        ///<see href="https://fontawesome.com/icons/message?style=regular"/>
        [Description("Regular Message"), IconID("far-message"), IconUnicodeGlyph(0xf27a)]
        RegularMessage = 1194,
        ///<summary>Brands Meta</summary>
        ///<see href="https://fontawesome.com/icons/meta?style=brands"/>
        [Description("Brands Meta"), IconID("fab-meta"), IconUnicodeGlyph(0xe49b)]
        BrandsMeta = 1195,
        ///<summary>Solid Meteor</summary>
        ///<see href="https://fontawesome.com/icons/meteor?style=solid"/>
        [Description("Solid Meteor"), IconID("fas-meteor"), IconUnicodeGlyph(0xf753)]
        SolidMeteor = 1196,
        ///<summary>Brands Micro.blog</summary>
        ///<see href="https://fontawesome.com/icons/microblog?style=brands"/>
        [Description("Brands Micro.blog"), IconID("fab-microblog"), IconUnicodeGlyph(0xe01a)]
        BrandsMicroblog = 1197,
        ///<summary>Solid Microchip</summary>
        ///<see href="https://fontawesome.com/icons/microchip?style=solid"/>
        [Description("Solid Microchip"), IconID("fas-microchip"), IconUnicodeGlyph(0xf2db)]
        SolidMicrochip = 1198,
        ///<summary>Solid microphone</summary>
        ///<see href="https://fontawesome.com/icons/microphone?style=solid"/>
        [Description("Solid microphone"), IconID("fas-microphone"), IconUnicodeGlyph(0xf130)]
        SolidMicrophone = 1199,
        ///<summary>Solid Microphone lines</summary>
        ///<see href="https://fontawesome.com/icons/microphone-lines?style=solid"/>
        [Description("Solid Microphone lines"), IconID("fas-microphone-lines"), IconUnicodeGlyph(0xf3c9)]
        SolidMicrophoneLines = 1200,
        ///<summary>Solid Microphone lines slash</summary>
        ///<see href="https://fontawesome.com/icons/microphone-lines-slash?style=solid"/>
        [Description("Solid Microphone lines slash"), IconID("fas-microphone-lines-slash"), IconUnicodeGlyph(0xf539)]
        SolidMicrophoneLinesSlash = 1201,
        ///<summary>Solid Microphone Slash</summary>
        ///<see href="https://fontawesome.com/icons/microphone-slash?style=solid"/>
        [Description("Solid Microphone Slash"), IconID("fas-microphone-slash"), IconUnicodeGlyph(0xf131)]
        SolidMicrophoneSlash = 1202,
        ///<summary>Solid Microscope</summary>
        ///<see href="https://fontawesome.com/icons/microscope?style=solid"/>
        [Description("Solid Microscope"), IconID("fas-microscope"), IconUnicodeGlyph(0xf610)]
        SolidMicroscope = 1203,
        ///<summary>Brands Microsoft</summary>
        ///<see href="https://fontawesome.com/icons/microsoft?style=brands"/>
        [Description("Brands Microsoft"), IconID("fab-microsoft"), IconUnicodeGlyph(0xf3ca)]
        BrandsMicrosoft = 1204,
        ///<summary>Solid Mill Sign</summary>
        ///<see href="https://fontawesome.com/icons/mill-sign?style=solid"/>
        [Description("Solid Mill Sign"), IconID("fas-mill-sign"), IconUnicodeGlyph(0xe1ed)]
        SolidMillSign = 1205,
        ///<summary>Solid Minimize</summary>
        ///<see href="https://fontawesome.com/icons/minimize?style=solid"/>
        [Description("Solid Minimize"), IconID("fas-minimize"), IconUnicodeGlyph(0xf78c)]
        SolidMinimize = 1206,
        ///<summary>Solid minus</summary>
        ///<see href="https://fontawesome.com/icons/minus?style=solid"/>
        [Description("Solid minus"), IconID("fas-minus"), IconUnicodeGlyph(0xf068)]
        SolidMinus = 1207,
        ///<summary>Solid Mitten</summary>
        ///<see href="https://fontawesome.com/icons/mitten?style=solid"/>
        [Description("Solid Mitten"), IconID("fas-mitten"), IconUnicodeGlyph(0xf7b5)]
        SolidMitten = 1208,
        ///<summary>Brands Mix</summary>
        ///<see href="https://fontawesome.com/icons/mix?style=brands"/>
        [Description("Brands Mix"), IconID("fab-mix"), IconUnicodeGlyph(0xf3cb)]
        BrandsMix = 1209,
        ///<summary>Brands Mixcloud</summary>
        ///<see href="https://fontawesome.com/icons/mixcloud?style=brands"/>
        [Description("Brands Mixcloud"), IconID("fab-mixcloud"), IconUnicodeGlyph(0xf289)]
        BrandsMixcloud = 1210,
        ///<summary>Brands Mixer</summary>
        ///<see href="https://fontawesome.com/icons/mixer?style=brands"/>
        [Description("Brands Mixer"), IconID("fab-mixer"), IconUnicodeGlyph(0xe056)]
        BrandsMixer = 1211,
        ///<summary>Brands Mizuni</summary>
        ///<see href="https://fontawesome.com/icons/mizuni?style=brands"/>
        [Description("Brands Mizuni"), IconID("fab-mizuni"), IconUnicodeGlyph(0xf3cc)]
        BrandsMizuni = 1212,
        ///<summary>Solid Mobile</summary>
        ///<see href="https://fontawesome.com/icons/mobile?style=solid"/>
        [Description("Solid Mobile"), IconID("fas-mobile"), IconUnicodeGlyph(0xf3ce)]
        SolidMobile = 1213,
        ///<summary>Solid Mobile button</summary>
        ///<see href="https://fontawesome.com/icons/mobile-button?style=solid"/>
        [Description("Solid Mobile button"), IconID("fas-mobile-button"), IconUnicodeGlyph(0xf10b)]
        SolidMobileButton = 1214,
        ///<summary>Solid Mobile Retro</summary>
        ///<see href="https://fontawesome.com/icons/mobile-retro?style=solid"/>
        [Description("Solid Mobile Retro"), IconID("fas-mobile-retro"), IconUnicodeGlyph(0xe527)]
        SolidMobileRetro = 1215,
        ///<summary>Solid Mobile screen</summary>
        ///<see href="https://fontawesome.com/icons/mobile-screen?style=solid"/>
        [Description("Solid Mobile screen"), IconID("fas-mobile-screen"), IconUnicodeGlyph(0xf3cf)]
        SolidMobileScreen = 1216,
        ///<summary>Solid Mobile screen button</summary>
        ///<see href="https://fontawesome.com/icons/mobile-screen-button?style=solid"/>
        [Description("Solid Mobile screen button"), IconID("fas-mobile-screen-button"), IconUnicodeGlyph(0xf3cd)]
        SolidMobileScreenButton = 1217,
        ///<summary>Brands MODX</summary>
        ///<see href="https://fontawesome.com/icons/modx?style=brands"/>
        [Description("Brands MODX"), IconID("fab-modx"), IconUnicodeGlyph(0xf285)]
        BrandsModx = 1218,
        ///<summary>Brands Monero</summary>
        ///<see href="https://fontawesome.com/icons/monero?style=brands"/>
        [Description("Brands Monero"), IconID("fab-monero"), IconUnicodeGlyph(0xf3d0)]
        BrandsMonero = 1219,
        ///<summary>Solid Money Bill</summary>
        ///<see href="https://fontawesome.com/icons/money-bill?style=solid"/>
        [Description("Solid Money Bill"), IconID("fas-money-bill"), IconUnicodeGlyph(0xf0d6)]
        SolidMoneyBill = 1220,
        ///<summary>Solid Money bill 1</summary>
        ///<see href="https://fontawesome.com/icons/money-bill-1?style=solid"/>
        [Description("Solid Money bill 1"), IconID("fas-money-bill-1"), IconUnicodeGlyph(0xf3d1)]
        SolidMoneyBill1 = 1221,
        ///<summary>Regular Money bill 1</summary>
        ///<see href="https://fontawesome.com/icons/money-bill-1?style=regular"/>
        [Description("Regular Money bill 1"), IconID("far-money-bill-1"), IconUnicodeGlyph(0xf3d1)]
        RegularMoneyBill1 = 1222,
        ///<summary>Solid Money bill 1 wave</summary>
        ///<see href="https://fontawesome.com/icons/money-bill-1-wave?style=solid"/>
        [Description("Solid Money bill 1 wave"), IconID("fas-money-bill-1-wave"), IconUnicodeGlyph(0xf53b)]
        SolidMoneyBill1Wave = 1223,
        ///<summary>Solid Money Bill-transfer</summary>
        ///<see href="https://fontawesome.com/icons/money-bill-transfer?style=solid"/>
        [Description("Solid Money Bill-transfer"), IconID("fas-money-bill-transfer"), IconUnicodeGlyph(0xe528)]
        SolidMoneyBillTransfer = 1224,
        ///<summary>Solid Money Bill-trend-up</summary>
        ///<see href="https://fontawesome.com/icons/money-bill-trend-up?style=solid"/>
        [Description("Solid Money Bill-trend-up"), IconID("fas-money-bill-trend-up"), IconUnicodeGlyph(0xe529)]
        SolidMoneyBillTrendUp = 1225,
        ///<summary>Solid Wavy Money Bill</summary>
        ///<see href="https://fontawesome.com/icons/money-bill-wave?style=solid"/>
        [Description("Solid Wavy Money Bill"), IconID("fas-money-bill-wave"), IconUnicodeGlyph(0xf53a)]
        SolidMoneyBillWave = 1226,
        ///<summary>Solid Money Bill-wheat</summary>
        ///<see href="https://fontawesome.com/icons/money-bill-wheat?style=solid"/>
        [Description("Solid Money Bill-wheat"), IconID("fas-money-bill-wheat"), IconUnicodeGlyph(0xe52a)]
        SolidMoneyBillWheat = 1227,
        ///<summary>Solid Money Bills</summary>
        ///<see href="https://fontawesome.com/icons/money-bills?style=solid"/>
        [Description("Solid Money Bills"), IconID("fas-money-bills"), IconUnicodeGlyph(0xe1f3)]
        SolidMoneyBills = 1228,
        ///<summary>Solid Money Check</summary>
        ///<see href="https://fontawesome.com/icons/money-check?style=solid"/>
        [Description("Solid Money Check"), IconID("fas-money-check"), IconUnicodeGlyph(0xf53c)]
        SolidMoneyCheck = 1229,
        ///<summary>Solid Money check dollar</summary>
        ///<see href="https://fontawesome.com/icons/money-check-dollar?style=solid"/>
        [Description("Solid Money check dollar"), IconID("fas-money-check-dollar"), IconUnicodeGlyph(0xf53d)]
        SolidMoneyCheckDollar = 1230,
        ///<summary>Solid Monument</summary>
        ///<see href="https://fontawesome.com/icons/monument?style=solid"/>
        [Description("Solid Monument"), IconID("fas-monument"), IconUnicodeGlyph(0xf5a6)]
        SolidMonument = 1231,
        ///<summary>Solid Moon</summary>
        ///<see href="https://fontawesome.com/icons/moon?style=solid"/>
        [Description("Solid Moon"), IconID("fas-moon"), IconUnicodeGlyph(0xf186)]
        SolidMoon = 1232,
        ///<summary>Regular Moon</summary>
        ///<see href="https://fontawesome.com/icons/moon?style=regular"/>
        [Description("Regular Moon"), IconID("far-moon"), IconUnicodeGlyph(0xf186)]
        RegularMoon = 1233,
        ///<summary>Solid Mortar Pestle</summary>
        ///<see href="https://fontawesome.com/icons/mortar-pestle?style=solid"/>
        [Description("Solid Mortar Pestle"), IconID("fas-mortar-pestle"), IconUnicodeGlyph(0xf5a7)]
        SolidMortarPestle = 1234,
        ///<summary>Solid Mosque</summary>
        ///<see href="https://fontawesome.com/icons/mosque?style=solid"/>
        [Description("Solid Mosque"), IconID("fas-mosque"), IconUnicodeGlyph(0xf678)]
        SolidMosque = 1235,
        ///<summary>Solid Mosquito</summary>
        ///<see href="https://fontawesome.com/icons/mosquito?style=solid"/>
        [Description("Solid Mosquito"), IconID("fas-mosquito"), IconUnicodeGlyph(0xe52b)]
        SolidMosquito = 1236,
        ///<summary>Solid Mosquito Net</summary>
        ///<see href="https://fontawesome.com/icons/mosquito-net?style=solid"/>
        [Description("Solid Mosquito Net"), IconID("fas-mosquito-net"), IconUnicodeGlyph(0xe52c)]
        SolidMosquitoNet = 1237,
        ///<summary>Solid Motorcycle</summary>
        ///<see href="https://fontawesome.com/icons/motorcycle?style=solid"/>
        [Description("Solid Motorcycle"), IconID("fas-motorcycle"), IconUnicodeGlyph(0xf21c)]
        SolidMotorcycle = 1238,
        ///<summary>Solid Mound</summary>
        ///<see href="https://fontawesome.com/icons/mound?style=solid"/>
        [Description("Solid Mound"), IconID("fas-mound"), IconUnicodeGlyph(0xe52d)]
        SolidMound = 1239,
        ///<summary>Solid Mountain</summary>
        ///<see href="https://fontawesome.com/icons/mountain?style=solid"/>
        [Description("Solid Mountain"), IconID("fas-mountain"), IconUnicodeGlyph(0xf6fc)]
        SolidMountain = 1240,
        ///<summary>Solid Mountain City</summary>
        ///<see href="https://fontawesome.com/icons/mountain-city?style=solid"/>
        [Description("Solid Mountain City"), IconID("fas-mountain-city"), IconUnicodeGlyph(0xe52e)]
        SolidMountainCity = 1241,
        ///<summary>Solid Mountain Sun</summary>
        ///<see href="https://fontawesome.com/icons/mountain-sun?style=solid"/>
        [Description("Solid Mountain Sun"), IconID("fas-mountain-sun"), IconUnicodeGlyph(0xe52f)]
        SolidMountainSun = 1242,
        ///<summary>Solid Mug Hot</summary>
        ///<see href="https://fontawesome.com/icons/mug-hot?style=solid"/>
        [Description("Solid Mug Hot"), IconID("fas-mug-hot"), IconUnicodeGlyph(0xf7b6)]
        SolidMugHot = 1243,
        ///<summary>Solid Mug saucer</summary>
        ///<see href="https://fontawesome.com/icons/mug-saucer?style=solid"/>
        [Description("Solid Mug saucer"), IconID("fas-mug-saucer"), IconUnicodeGlyph(0xf0f4)]
        SolidMugSaucer = 1244,
        ///<summary>Solid Music</summary>
        ///<see href="https://fontawesome.com/icons/music?style=solid"/>
        [Description("Solid Music"), IconID("fas-music"), IconUnicodeGlyph(0xf001)]
        SolidMusic = 1245,
        ///<summary>Solid N</summary>
        ///<see href="https://fontawesome.com/icons/n?style=solid"/>
        [Description("Solid N"), IconID("fas-n"), IconUnicodeGlyph(0x4e)]
        SolidN = 1246,
        ///<summary>Solid Naira Sign</summary>
        ///<see href="https://fontawesome.com/icons/naira-sign?style=solid"/>
        [Description("Solid Naira Sign"), IconID("fas-naira-sign"), IconUnicodeGlyph(0xe1f6)]
        SolidNairaSign = 1247,
        ///<summary>Brands Napster</summary>
        ///<see href="https://fontawesome.com/icons/napster?style=brands"/>
        [Description("Brands Napster"), IconID("fab-napster"), IconUnicodeGlyph(0xf3d2)]
        BrandsNapster = 1248,
        ///<summary>Brands Neos</summary>
        ///<see href="https://fontawesome.com/icons/neos?style=brands"/>
        [Description("Brands Neos"), IconID("fab-neos"), IconUnicodeGlyph(0xf612)]
        BrandsNeos = 1249,
        ///<summary>Solid Wired Network</summary>
        ///<see href="https://fontawesome.com/icons/network-wired?style=solid"/>
        [Description("Solid Wired Network"), IconID("fas-network-wired"), IconUnicodeGlyph(0xf6ff)]
        SolidNetworkWired = 1250,
        ///<summary>Solid Neuter</summary>
        ///<see href="https://fontawesome.com/icons/neuter?style=solid"/>
        [Description("Solid Neuter"), IconID("fas-neuter"), IconUnicodeGlyph(0xf22c)]
        SolidNeuter = 1251,
        ///<summary>Solid Newspaper</summary>
        ///<see href="https://fontawesome.com/icons/newspaper?style=solid"/>
        [Description("Solid Newspaper"), IconID("fas-newspaper"), IconUnicodeGlyph(0xf1ea)]
        SolidNewspaper = 1252,
        ///<summary>Regular Newspaper</summary>
        ///<see href="https://fontawesome.com/icons/newspaper?style=regular"/>
        [Description("Regular Newspaper"), IconID("far-newspaper"), IconUnicodeGlyph(0xf1ea)]
        RegularNewspaper = 1253,
        ///<summary>Brands NFC Directional</summary>
        ///<see href="https://fontawesome.com/icons/nfc-directional?style=brands"/>
        [Description("Brands NFC Directional"), IconID("fab-nfc-directional"), IconUnicodeGlyph(0xe530)]
        BrandsNfcDirectional = 1254,
        ///<summary>Brands NFC Simplified</summary>
        ///<see href="https://fontawesome.com/icons/nfc-symbol?style=brands"/>
        [Description("Brands NFC Simplified"), IconID("fab-nfc-symbol"), IconUnicodeGlyph(0xe531)]
        BrandsNfcSymbol = 1255,
        ///<summary>Brands Nimblr</summary>
        ///<see href="https://fontawesome.com/icons/nimblr?style=brands"/>
        [Description("Brands Nimblr"), IconID("fab-nimblr"), IconUnicodeGlyph(0xf5a8)]
        BrandsNimblr = 1256,
        ///<summary>Brands Node.js</summary>
        ///<see href="https://fontawesome.com/icons/node?style=brands"/>
        [Description("Brands Node.js"), IconID("fab-node"), IconUnicodeGlyph(0xf419)]
        BrandsNode = 1257,
        ///<summary>Brands Node.js JS</summary>
        ///<see href="https://fontawesome.com/icons/node-js?style=brands"/>
        [Description("Brands Node.js JS"), IconID("fab-node-js"), IconUnicodeGlyph(0xf3d3)]
        BrandsNodeJs = 1258,
        ///<summary>Solid Not Equal</summary>
        ///<see href="https://fontawesome.com/icons/not-equal?style=solid"/>
        [Description("Solid Not Equal"), IconID("fas-not-equal"), IconUnicodeGlyph(0xf53e)]
        SolidNotEqual = 1259,
        ///<summary>Solid Note sticky</summary>
        ///<see href="https://fontawesome.com/icons/note-sticky?style=solid"/>
        [Description("Solid Note sticky"), IconID("fas-note-sticky"), IconUnicodeGlyph(0xf249)]
        SolidNoteSticky = 1260,
        ///<summary>Regular Note sticky</summary>
        ///<see href="https://fontawesome.com/icons/note-sticky?style=regular"/>
        [Description("Regular Note sticky"), IconID("far-note-sticky"), IconUnicodeGlyph(0xf249)]
        RegularNoteSticky = 1261,
        ///<summary>Solid Medical Notes</summary>
        ///<see href="https://fontawesome.com/icons/notes-medical?style=solid"/>
        [Description("Solid Medical Notes"), IconID("fas-notes-medical"), IconUnicodeGlyph(0xf481)]
        SolidNotesMedical = 1262,
        ///<summary>Brands npm</summary>
        ///<see href="https://fontawesome.com/icons/npm?style=brands"/>
        [Description("Brands npm"), IconID("fab-npm"), IconUnicodeGlyph(0xf3d4)]
        BrandsNpm = 1263,
        ///<summary>Brands NS8</summary>
        ///<see href="https://fontawesome.com/icons/ns8?style=brands"/>
        [Description("Brands NS8"), IconID("fab-ns8"), IconUnicodeGlyph(0xf3d5)]
        BrandsNs8 = 1264,
        ///<summary>Brands Nutritionix</summary>
        ///<see href="https://fontawesome.com/icons/nutritionix?style=brands"/>
        [Description("Brands Nutritionix"), IconID("fab-nutritionix"), IconUnicodeGlyph(0xf3d6)]
        BrandsNutritionix = 1265,
        ///<summary>Solid O</summary>
        ///<see href="https://fontawesome.com/icons/o?style=solid"/>
        [Description("Solid O"), IconID("fas-o"), IconUnicodeGlyph(0x4f)]
        SolidO = 1266,
        ///<summary>Solid Object Group</summary>
        ///<see href="https://fontawesome.com/icons/object-group?style=solid"/>
        [Description("Solid Object Group"), IconID("fas-object-group"), IconUnicodeGlyph(0xf247)]
        SolidObjectGroup = 1267,
        ///<summary>Regular Object Group</summary>
        ///<see href="https://fontawesome.com/icons/object-group?style=regular"/>
        [Description("Regular Object Group"), IconID("far-object-group"), IconUnicodeGlyph(0xf247)]
        RegularObjectGroup = 1268,
        ///<summary>Solid Object Ungroup</summary>
        ///<see href="https://fontawesome.com/icons/object-ungroup?style=solid"/>
        [Description("Solid Object Ungroup"), IconID("fas-object-ungroup"), IconUnicodeGlyph(0xf248)]
        SolidObjectUngroup = 1269,
        ///<summary>Regular Object Ungroup</summary>
        ///<see href="https://fontawesome.com/icons/object-ungroup?style=regular"/>
        [Description("Regular Object Ungroup"), IconID("far-object-ungroup"), IconUnicodeGlyph(0xf248)]
        RegularObjectUngroup = 1270,
        ///<summary>Brands Octopus Deploy</summary>
        ///<see href="https://fontawesome.com/icons/octopus-deploy?style=brands"/>
        [Description("Brands Octopus Deploy"), IconID("fab-octopus-deploy"), IconUnicodeGlyph(0xe082)]
        BrandsOctopusDeploy = 1271,
        ///<summary>Brands Odnoklassniki</summary>
        ///<see href="https://fontawesome.com/icons/odnoklassniki?style=brands"/>
        [Description("Brands Odnoklassniki"), IconID("fab-odnoklassniki"), IconUnicodeGlyph(0xf263)]
        BrandsOdnoklassniki = 1272,
        ///<summary>Solid Oil Can</summary>
        ///<see href="https://fontawesome.com/icons/oil-can?style=solid"/>
        [Description("Solid Oil Can"), IconID("fas-oil-can"), IconUnicodeGlyph(0xf613)]
        SolidOilCan = 1273,
        ///<summary>Solid Oil Well</summary>
        ///<see href="https://fontawesome.com/icons/oil-well?style=solid"/>
        [Description("Solid Oil Well"), IconID("fas-oil-well"), IconUnicodeGlyph(0xe532)]
        SolidOilWell = 1274,
        ///<summary>Brands Old Republic</summary>
        ///<see href="https://fontawesome.com/icons/old-republic?style=brands"/>
        [Description("Brands Old Republic"), IconID("fab-old-republic"), IconUnicodeGlyph(0xf510)]
        BrandsOldRepublic = 1275,
        ///<summary>Solid Om</summary>
        ///<see href="https://fontawesome.com/icons/om?style=solid"/>
        [Description("Solid Om"), IconID("fas-om"), IconUnicodeGlyph(0xf679)]
        SolidOm = 1276,
        ///<summary>Brands OpenCart</summary>
        ///<see href="https://fontawesome.com/icons/opencart?style=brands"/>
        [Description("Brands OpenCart"), IconID("fab-opencart"), IconUnicodeGlyph(0xf23d)]
        BrandsOpencart = 1277,
        ///<summary>Brands OpenID</summary>
        ///<see href="https://fontawesome.com/icons/openid?style=brands"/>
        [Description("Brands OpenID"), IconID("fab-openid"), IconUnicodeGlyph(0xf19b)]
        BrandsOpenid = 1278,
        ///<summary>Brands Opera</summary>
        ///<see href="https://fontawesome.com/icons/opera?style=brands"/>
        [Description("Brands Opera"), IconID("fab-opera"), IconUnicodeGlyph(0xf26a)]
        BrandsOpera = 1279,
        ///<summary>Brands Optin Monster</summary>
        ///<see href="https://fontawesome.com/icons/optin-monster?style=brands"/>
        [Description("Brands Optin Monster"), IconID("fab-optin-monster"), IconUnicodeGlyph(0xf23c)]
        BrandsOptinMonster = 1280,
        ///<summary>Brands ORCID</summary>
        ///<see href="https://fontawesome.com/icons/orcid?style=brands"/>
        [Description("Brands ORCID"), IconID("fab-orcid"), IconUnicodeGlyph(0xf8d2)]
        BrandsOrcid = 1281,
        ///<summary>Brands Open Source Initiative</summary>
        ///<see href="https://fontawesome.com/icons/osi?style=brands"/>
        [Description("Brands Open Source Initiative"), IconID("fab-osi"), IconUnicodeGlyph(0xf41a)]
        BrandsOsi = 1282,
        ///<summary>Solid Otter</summary>
        ///<see href="https://fontawesome.com/icons/otter?style=solid"/>
        [Description("Solid Otter"), IconID("fas-otter"), IconUnicodeGlyph(0xf700)]
        SolidOtter = 1283,
        ///<summary>Solid Outdent</summary>
        ///<see href="https://fontawesome.com/icons/outdent?style=solid"/>
        [Description("Solid Outdent"), IconID("fas-outdent"), IconUnicodeGlyph(0xf03b)]
        SolidOutdent = 1284,
        ///<summary>Solid P</summary>
        ///<see href="https://fontawesome.com/icons/p?style=solid"/>
        [Description("Solid P"), IconID("fas-p"), IconUnicodeGlyph(0x50)]
        SolidP = 1285,
        ///<summary>Brands Padlet</summary>
        ///<see href="https://fontawesome.com/icons/padlet?style=brands"/>
        [Description("Brands Padlet"), IconID("fab-padlet"), IconUnicodeGlyph(0xe4a0)]
        BrandsPadlet = 1286,
        ///<summary>Brands page4 Corporation</summary>
        ///<see href="https://fontawesome.com/icons/page4?style=brands"/>
        [Description("Brands page4 Corporation"), IconID("fab-page4"), IconUnicodeGlyph(0xf3d7)]
        BrandsPage4 = 1287,
        ///<summary>Brands Pagelines</summary>
        ///<see href="https://fontawesome.com/icons/pagelines?style=brands"/>
        [Description("Brands Pagelines"), IconID("fab-pagelines"), IconUnicodeGlyph(0xf18c)]
        BrandsPagelines = 1288,
        ///<summary>Solid Pager</summary>
        ///<see href="https://fontawesome.com/icons/pager?style=solid"/>
        [Description("Solid Pager"), IconID("fas-pager"), IconUnicodeGlyph(0xf815)]
        SolidPager = 1289,
        ///<summary>Solid Paint Roller</summary>
        ///<see href="https://fontawesome.com/icons/paint-roller?style=solid"/>
        [Description("Solid Paint Roller"), IconID("fas-paint-roller"), IconUnicodeGlyph(0xf5aa)]
        SolidPaintRoller = 1290,
        ///<summary>Solid Paint Brush</summary>
        ///<see href="https://fontawesome.com/icons/paintbrush?style=solid"/>
        [Description("Solid Paint Brush"), IconID("fas-paintbrush"), IconUnicodeGlyph(0xf1fc)]
        SolidPaintbrush = 1291,
        ///<summary>Solid Palette</summary>
        ///<see href="https://fontawesome.com/icons/palette?style=solid"/>
        [Description("Solid Palette"), IconID("fas-palette"), IconUnicodeGlyph(0xf53f)]
        SolidPalette = 1292,
        ///<summary>Brands Palfed</summary>
        ///<see href="https://fontawesome.com/icons/palfed?style=brands"/>
        [Description("Brands Palfed"), IconID("fab-palfed"), IconUnicodeGlyph(0xf3d8)]
        BrandsPalfed = 1293,
        ///<summary>Solid Pallet</summary>
        ///<see href="https://fontawesome.com/icons/pallet?style=solid"/>
        [Description("Solid Pallet"), IconID("fas-pallet"), IconUnicodeGlyph(0xf482)]
        SolidPallet = 1294,
        ///<summary>Solid Panorama</summary>
        ///<see href="https://fontawesome.com/icons/panorama?style=solid"/>
        [Description("Solid Panorama"), IconID("fas-panorama"), IconUnicodeGlyph(0xe209)]
        SolidPanorama = 1295,
        ///<summary>Solid Paper Plane</summary>
        ///<see href="https://fontawesome.com/icons/paper-plane?style=solid"/>
        [Description("Solid Paper Plane"), IconID("fas-paper-plane"), IconUnicodeGlyph(0xf1d8)]
        SolidPaperPlane = 1296,
        ///<summary>Regular Paper Plane</summary>
        ///<see href="https://fontawesome.com/icons/paper-plane?style=regular"/>
        [Description("Regular Paper Plane"), IconID("far-paper-plane"), IconUnicodeGlyph(0xf1d8)]
        RegularPaperPlane = 1297,
        ///<summary>Solid Paperclip</summary>
        ///<see href="https://fontawesome.com/icons/paperclip?style=solid"/>
        [Description("Solid Paperclip"), IconID("fas-paperclip"), IconUnicodeGlyph(0xf0c6)]
        SolidPaperclip = 1298,
        ///<summary>Solid Parachute Box</summary>
        ///<see href="https://fontawesome.com/icons/parachute-box?style=solid"/>
        [Description("Solid Parachute Box"), IconID("fas-parachute-box"), IconUnicodeGlyph(0xf4cd)]
        SolidParachuteBox = 1299,
        ///<summary>Solid paragraph</summary>
        ///<see href="https://fontawesome.com/icons/paragraph?style=solid"/>
        [Description("Solid paragraph"), IconID("fas-paragraph"), IconUnicodeGlyph(0xf1dd)]
        SolidParagraph = 1300,
        ///<summary>Solid Passport</summary>
        ///<see href="https://fontawesome.com/icons/passport?style=solid"/>
        [Description("Solid Passport"), IconID("fas-passport"), IconUnicodeGlyph(0xf5ab)]
        SolidPassport = 1301,
        ///<summary>Solid Paste</summary>
        ///<see href="https://fontawesome.com/icons/paste?style=solid"/>
        [Description("Solid Paste"), IconID("fas-paste"), IconUnicodeGlyph(0xf0ea)]
        SolidPaste = 1302,
        ///<summary>Regular Paste</summary>
        ///<see href="https://fontawesome.com/icons/paste?style=regular"/>
        [Description("Regular Paste"), IconID("far-paste"), IconUnicodeGlyph(0xf0ea)]
        RegularPaste = 1303,
        ///<summary>Brands Patreon</summary>
        ///<see href="https://fontawesome.com/icons/patreon?style=brands"/>
        [Description("Brands Patreon"), IconID("fab-patreon"), IconUnicodeGlyph(0xf3d9)]
        BrandsPatreon = 1304,
        ///<summary>Solid pause</summary>
        ///<see href="https://fontawesome.com/icons/pause?style=solid"/>
        [Description("Solid pause"), IconID("fas-pause"), IconUnicodeGlyph(0xf04c)]
        SolidPause = 1305,
        ///<summary>Solid Paw</summary>
        ///<see href="https://fontawesome.com/icons/paw?style=solid"/>
        [Description("Solid Paw"), IconID("fas-paw"), IconUnicodeGlyph(0xf1b0)]
        SolidPaw = 1306,
        ///<summary>Brands Paypal</summary>
        ///<see href="https://fontawesome.com/icons/paypal?style=brands"/>
        [Description("Brands Paypal"), IconID("fab-paypal"), IconUnicodeGlyph(0xf1ed)]
        BrandsPaypal = 1307,
        ///<summary>Solid Peace</summary>
        ///<see href="https://fontawesome.com/icons/peace?style=solid"/>
        [Description("Solid Peace"), IconID("fas-peace"), IconUnicodeGlyph(0xf67c)]
        SolidPeace = 1308,
        ///<summary>Solid Pen</summary>
        ///<see href="https://fontawesome.com/icons/pen?style=solid"/>
        [Description("Solid Pen"), IconID("fas-pen"), IconUnicodeGlyph(0xf304)]
        SolidPen = 1309,
        ///<summary>Solid Pen clip</summary>
        ///<see href="https://fontawesome.com/icons/pen-clip?style=solid"/>
        [Description("Solid Pen clip"), IconID("fas-pen-clip"), IconUnicodeGlyph(0xf305)]
        SolidPenClip = 1310,
        ///<summary>Solid Pen Fancy</summary>
        ///<see href="https://fontawesome.com/icons/pen-fancy?style=solid"/>
        [Description("Solid Pen Fancy"), IconID("fas-pen-fancy"), IconUnicodeGlyph(0xf5ac)]
        SolidPenFancy = 1311,
        ///<summary>Solid Pen Nib</summary>
        ///<see href="https://fontawesome.com/icons/pen-nib?style=solid"/>
        [Description("Solid Pen Nib"), IconID("fas-pen-nib"), IconUnicodeGlyph(0xf5ad)]
        SolidPenNib = 1312,
        ///<summary>Solid Pen ruler</summary>
        ///<see href="https://fontawesome.com/icons/pen-ruler?style=solid"/>
        [Description("Solid Pen ruler"), IconID("fas-pen-ruler"), IconUnicodeGlyph(0xf5ae)]
        SolidPenRuler = 1313,
        ///<summary>Solid Pen to square</summary>
        ///<see href="https://fontawesome.com/icons/pen-to-square?style=solid"/>
        [Description("Solid Pen to square"), IconID("fas-pen-to-square"), IconUnicodeGlyph(0xf044)]
        SolidPenToSquare = 1314,
        ///<summary>Regular Pen to square</summary>
        ///<see href="https://fontawesome.com/icons/pen-to-square?style=regular"/>
        [Description("Regular Pen to square"), IconID("far-pen-to-square"), IconUnicodeGlyph(0xf044)]
        RegularPenToSquare = 1315,
        ///<summary>Solid pencil</summary>
        ///<see href="https://fontawesome.com/icons/pencil?style=solid"/>
        [Description("Solid pencil"), IconID("fas-pencil"), IconUnicodeGlyph(0xf303)]
        SolidPencil = 1316,
        ///<summary>Solid People arrows left right</summary>
        ///<see href="https://fontawesome.com/icons/people-arrows?style=solid"/>
        [Description("Solid People arrows left right"), IconID("fas-people-arrows"), IconUnicodeGlyph(0xe068)]
        SolidPeopleArrows = 1317,
        ///<summary>Solid People carry box</summary>
        ///<see href="https://fontawesome.com/icons/people-carry-box?style=solid"/>
        [Description("Solid People carry box"), IconID("fas-people-carry-box"), IconUnicodeGlyph(0xf4ce)]
        SolidPeopleCarryBox = 1318,
        ///<summary>Solid People Group</summary>
        ///<see href="https://fontawesome.com/icons/people-group?style=solid"/>
        [Description("Solid People Group"), IconID("fas-people-group"), IconUnicodeGlyph(0xe533)]
        SolidPeopleGroup = 1319,
        ///<summary>Solid People Line</summary>
        ///<see href="https://fontawesome.com/icons/people-line?style=solid"/>
        [Description("Solid People Line"), IconID("fas-people-line"), IconUnicodeGlyph(0xe534)]
        SolidPeopleLine = 1320,
        ///<summary>Solid People Pulling</summary>
        ///<see href="https://fontawesome.com/icons/people-pulling?style=solid"/>
        [Description("Solid People Pulling"), IconID("fas-people-pulling"), IconUnicodeGlyph(0xe535)]
        SolidPeoplePulling = 1321,
        ///<summary>Solid People Robbery</summary>
        ///<see href="https://fontawesome.com/icons/people-robbery?style=solid"/>
        [Description("Solid People Robbery"), IconID("fas-people-robbery"), IconUnicodeGlyph(0xe536)]
        SolidPeopleRobbery = 1322,
        ///<summary>Solid People Roof</summary>
        ///<see href="https://fontawesome.com/icons/people-roof?style=solid"/>
        [Description("Solid People Roof"), IconID("fas-people-roof"), IconUnicodeGlyph(0xe537)]
        SolidPeopleRoof = 1323,
        ///<summary>Solid Hot Pepper</summary>
        ///<see href="https://fontawesome.com/icons/pepper-hot?style=solid"/>
        [Description("Solid Hot Pepper"), IconID("fas-pepper-hot"), IconUnicodeGlyph(0xf816)]
        SolidPepperHot = 1324,
        ///<summary>Brands PerByte</summary>
        ///<see href="https://fontawesome.com/icons/perbyte?style=brands"/>
        [Description("Brands PerByte"), IconID("fab-perbyte"), IconUnicodeGlyph(0xe083)]
        BrandsPerbyte = 1325,
        ///<summary>Solid Percent</summary>
        ///<see href="https://fontawesome.com/icons/percent?style=solid"/>
        [Description("Solid Percent"), IconID("fas-percent"), IconUnicodeGlyph(0x25)]
        SolidPercent = 1326,
        ///<summary>Brands Periscope</summary>
        ///<see href="https://fontawesome.com/icons/periscope?style=brands"/>
        [Description("Brands Periscope"), IconID("fab-periscope"), IconUnicodeGlyph(0xf3da)]
        BrandsPeriscope = 1327,
        ///<summary>Solid Person</summary>
        ///<see href="https://fontawesome.com/icons/person?style=solid"/>
        [Description("Solid Person"), IconID("fas-person"), IconUnicodeGlyph(0xf183)]
        SolidPerson = 1328,
        ///<summary>Solid Person Arrow-down-to-line</summary>
        ///<see href="https://fontawesome.com/icons/person-arrow-down-to-line?style=solid"/>
        [Description("Solid Person Arrow-down-to-line"), IconID("fas-person-arrow-down-to-line"), IconUnicodeGlyph(0xe538)]
        SolidPersonArrowDownToLine = 1329,
        ///<summary>Solid Person Arrow-up-from-line</summary>
        ///<see href="https://fontawesome.com/icons/person-arrow-up-from-line?style=solid"/>
        [Description("Solid Person Arrow-up-from-line"), IconID("fas-person-arrow-up-from-line"), IconUnicodeGlyph(0xe539)]
        SolidPersonArrowUpFromLine = 1330,
        ///<summary>Solid Person biking</summary>
        ///<see href="https://fontawesome.com/icons/person-biking?style=solid"/>
        [Description("Solid Person biking"), IconID("fas-person-biking"), IconUnicodeGlyph(0xf84a)]
        SolidPersonBiking = 1331,
        ///<summary>Solid Person Entering Booth</summary>
        ///<see href="https://fontawesome.com/icons/person-booth?style=solid"/>
        [Description("Solid Person Entering Booth"), IconID("fas-person-booth"), IconUnicodeGlyph(0xf756)]
        SolidPersonBooth = 1332,
        ///<summary>Solid Person Breastfeeding</summary>
        ///<see href="https://fontawesome.com/icons/person-breastfeeding?style=solid"/>
        [Description("Solid Person Breastfeeding"), IconID("fas-person-breastfeeding"), IconUnicodeGlyph(0xe53a)]
        SolidPersonBreastfeeding = 1333,
        ///<summary>Solid Person Burst</summary>
        ///<see href="https://fontawesome.com/icons/person-burst?style=solid"/>
        [Description("Solid Person Burst"), IconID("fas-person-burst"), IconUnicodeGlyph(0xe53b)]
        SolidPersonBurst = 1334,
        ///<summary>Solid Person Cane</summary>
        ///<see href="https://fontawesome.com/icons/person-cane?style=solid"/>
        [Description("Solid Person Cane"), IconID("fas-person-cane"), IconUnicodeGlyph(0xe53c)]
        SolidPersonCane = 1335,
        ///<summary>Solid Person Chalkboard</summary>
        ///<see href="https://fontawesome.com/icons/person-chalkboard?style=solid"/>
        [Description("Solid Person Chalkboard"), IconID("fas-person-chalkboard"), IconUnicodeGlyph(0xe53d)]
        SolidPersonChalkboard = 1336,
        ///<summary>Solid Person Circle-check</summary>
        ///<see href="https://fontawesome.com/icons/person-circle-check?style=solid"/>
        [Description("Solid Person Circle-check"), IconID("fas-person-circle-check"), IconUnicodeGlyph(0xe53e)]
        SolidPersonCircleCheck = 1337,
        ///<summary>Solid Person Circle-exclamation</summary>
        ///<see href="https://fontawesome.com/icons/person-circle-exclamation?style=solid"/>
        [Description("Solid Person Circle-exclamation"), IconID("fas-person-circle-exclamation"), IconUnicodeGlyph(0xe53f)]
        SolidPersonCircleExclamation = 1338,
        ///<summary>Solid Person Circle-minus</summary>
        ///<see href="https://fontawesome.com/icons/person-circle-minus?style=solid"/>
        [Description("Solid Person Circle-minus"), IconID("fas-person-circle-minus"), IconUnicodeGlyph(0xe540)]
        SolidPersonCircleMinus = 1339,
        ///<summary>Solid Person Circle-plus</summary>
        ///<see href="https://fontawesome.com/icons/person-circle-plus?style=solid"/>
        [Description("Solid Person Circle-plus"), IconID("fas-person-circle-plus"), IconUnicodeGlyph(0xe541)]
        SolidPersonCirclePlus = 1340,
        ///<summary>Solid Person Circle-question</summary>
        ///<see href="https://fontawesome.com/icons/person-circle-question?style=solid"/>
        [Description("Solid Person Circle-question"), IconID("fas-person-circle-question"), IconUnicodeGlyph(0xe542)]
        SolidPersonCircleQuestion = 1341,
        ///<summary>Solid Person Circle-xmark</summary>
        ///<see href="https://fontawesome.com/icons/person-circle-xmark?style=solid"/>
        [Description("Solid Person Circle-xmark"), IconID("fas-person-circle-xmark"), IconUnicodeGlyph(0xe543)]
        SolidPersonCircleXmark = 1342,
        ///<summary>Solid Person digging</summary>
        ///<see href="https://fontawesome.com/icons/person-digging?style=solid"/>
        [Description("Solid Person digging"), IconID("fas-person-digging"), IconUnicodeGlyph(0xf85e)]
        SolidPersonDigging = 1343,
        ///<summary>Solid Person dots from line</summary>
        ///<see href="https://fontawesome.com/icons/person-dots-from-line?style=solid"/>
        [Description("Solid Person dots from line"), IconID("fas-person-dots-from-line"), IconUnicodeGlyph(0xf470)]
        SolidPersonDotsFromLine = 1344,
        ///<summary>Solid Person dress</summary>
        ///<see href="https://fontawesome.com/icons/person-dress?style=solid"/>
        [Description("Solid Person dress"), IconID("fas-person-dress"), IconUnicodeGlyph(0xf182)]
        SolidPersonDress = 1345,
        ///<summary>Solid Person Dress BUrst</summary>
        ///<see href="https://fontawesome.com/icons/person-dress-burst?style=solid"/>
        [Description("Solid Person Dress BUrst"), IconID("fas-person-dress-burst"), IconUnicodeGlyph(0xe544)]
        SolidPersonDressBurst = 1346,
        ///<summary>Solid Person Drowning</summary>
        ///<see href="https://fontawesome.com/icons/person-drowning?style=solid"/>
        [Description("Solid Person Drowning"), IconID("fas-person-drowning"), IconUnicodeGlyph(0xe545)]
        SolidPersonDrowning = 1347,
        ///<summary>Solid Person Falling</summary>
        ///<see href="https://fontawesome.com/icons/person-falling?style=solid"/>
        [Description("Solid Person Falling"), IconID("fas-person-falling"), IconUnicodeGlyph(0xe546)]
        SolidPersonFalling = 1348,
        ///<summary>Solid Person Falling Burst</summary>
        ///<see href="https://fontawesome.com/icons/person-falling-burst?style=solid"/>
        [Description("Solid Person Falling Burst"), IconID("fas-person-falling-burst"), IconUnicodeGlyph(0xe547)]
        SolidPersonFallingBurst = 1349,
        ///<summary>Solid Person Half-dress</summary>
        ///<see href="https://fontawesome.com/icons/person-half-dress?style=solid"/>
        [Description("Solid Person Half-dress"), IconID("fas-person-half-dress"), IconUnicodeGlyph(0xe548)]
        SolidPersonHalfDress = 1350,
        ///<summary>Solid Person Harassing</summary>
        ///<see href="https://fontawesome.com/icons/person-harassing?style=solid"/>
        [Description("Solid Person Harassing"), IconID("fas-person-harassing"), IconUnicodeGlyph(0xe549)]
        SolidPersonHarassing = 1351,
        ///<summary>Solid Person hiking</summary>
        ///<see href="https://fontawesome.com/icons/person-hiking?style=solid"/>
        [Description("Solid Person hiking"), IconID("fas-person-hiking"), IconUnicodeGlyph(0xf6ec)]
        SolidPersonHiking = 1352,
        ///<summary>Solid Person Military-pointing</summary>
        ///<see href="https://fontawesome.com/icons/person-military-pointing?style=solid"/>
        [Description("Solid Person Military-pointing"), IconID("fas-person-military-pointing"), IconUnicodeGlyph(0xe54a)]
        SolidPersonMilitaryPointing = 1353,
        ///<summary>Solid Person Military-rifle</summary>
        ///<see href="https://fontawesome.com/icons/person-military-rifle?style=solid"/>
        [Description("Solid Person Military-rifle"), IconID("fas-person-military-rifle"), IconUnicodeGlyph(0xe54b)]
        SolidPersonMilitaryRifle = 1354,
        ///<summary>Solid Person Military-to-person</summary>
        ///<see href="https://fontawesome.com/icons/person-military-to-person?style=solid"/>
        [Description("Solid Person Military-to-person"), IconID("fas-person-military-to-person"), IconUnicodeGlyph(0xe54c)]
        SolidPersonMilitaryToPerson = 1355,
        ///<summary>Solid Person praying</summary>
        ///<see href="https://fontawesome.com/icons/person-praying?style=solid"/>
        [Description("Solid Person praying"), IconID("fas-person-praying"), IconUnicodeGlyph(0xf683)]
        SolidPersonPraying = 1356,
        ///<summary>Solid Person Pregnant</summary>
        ///<see href="https://fontawesome.com/icons/person-pregnant?style=solid"/>
        [Description("Solid Person Pregnant"), IconID("fas-person-pregnant"), IconUnicodeGlyph(0xe31e)]
        SolidPersonPregnant = 1357,
        ///<summary>Solid Person Rays</summary>
        ///<see href="https://fontawesome.com/icons/person-rays?style=solid"/>
        [Description("Solid Person Rays"), IconID("fas-person-rays"), IconUnicodeGlyph(0xe54d)]
        SolidPersonRays = 1358,
        ///<summary>Solid Person Rifle</summary>
        ///<see href="https://fontawesome.com/icons/person-rifle?style=solid"/>
        [Description("Solid Person Rifle"), IconID("fas-person-rifle"), IconUnicodeGlyph(0xe54e)]
        SolidPersonRifle = 1359,
        ///<summary>Solid Person running</summary>
        ///<see href="https://fontawesome.com/icons/person-running?style=solid"/>
        [Description("Solid Person running"), IconID("fas-person-running"), IconUnicodeGlyph(0xf70c)]
        SolidPersonRunning = 1360,
        ///<summary>Solid Person Shelter</summary>
        ///<see href="https://fontawesome.com/icons/person-shelter?style=solid"/>
        [Description("Solid Person Shelter"), IconID("fas-person-shelter"), IconUnicodeGlyph(0xe54f)]
        SolidPersonShelter = 1361,
        ///<summary>Solid Person skating</summary>
        ///<see href="https://fontawesome.com/icons/person-skating?style=solid"/>
        [Description("Solid Person skating"), IconID("fas-person-skating"), IconUnicodeGlyph(0xf7c5)]
        SolidPersonSkating = 1362,
        ///<summary>Solid Person skiing</summary>
        ///<see href="https://fontawesome.com/icons/person-skiing?style=solid"/>
        [Description("Solid Person skiing"), IconID("fas-person-skiing"), IconUnicodeGlyph(0xf7c9)]
        SolidPersonSkiing = 1363,
        ///<summary>Solid Person skiing nordic</summary>
        ///<see href="https://fontawesome.com/icons/person-skiing-nordic?style=solid"/>
        [Description("Solid Person skiing nordic"), IconID("fas-person-skiing-nordic"), IconUnicodeGlyph(0xf7ca)]
        SolidPersonSkiingNordic = 1364,
        ///<summary>Solid Person snowboarding</summary>
        ///<see href="https://fontawesome.com/icons/person-snowboarding?style=solid"/>
        [Description("Solid Person snowboarding"), IconID("fas-person-snowboarding"), IconUnicodeGlyph(0xf7ce)]
        SolidPersonSnowboarding = 1365,
        ///<summary>Solid Person swimming</summary>
        ///<see href="https://fontawesome.com/icons/person-swimming?style=solid"/>
        [Description("Solid Person swimming"), IconID("fas-person-swimming"), IconUnicodeGlyph(0xf5c4)]
        SolidPersonSwimming = 1366,
        ///<summary>Solid Person Through-window</summary>
        ///<see href="https://fontawesome.com/icons/person-through-window?style=solid"/>
        [Description("Solid Person Through-window"), IconID("fas-person-through-window"), IconUnicodeGlyph(0xe5a9)]
        SolidPersonThroughWindow = 1367,
        ///<summary>Solid Person walking</summary>
        ///<see href="https://fontawesome.com/icons/person-walking?style=solid"/>
        [Description("Solid Person walking"), IconID("fas-person-walking"), IconUnicodeGlyph(0xf554)]
        SolidPersonWalking = 1368,
        ///<summary>Solid Person Walking-arrow-loop-left</summary>
        ///<see href="https://fontawesome.com/icons/person-walking-arrow-loop-left?style=solid"/>
        [Description("Solid Person Walking-arrow-loop-left"), IconID("fas-person-walking-arrow-loop-left"), IconUnicodeGlyph(0xe551)]
        SolidPersonWalkingArrowLoopLeft = 1369,
        ///<summary>Solid Person Walking-arrow-right</summary>
        ///<see href="https://fontawesome.com/icons/person-walking-arrow-right?style=solid"/>
        [Description("Solid Person Walking-arrow-right"), IconID("fas-person-walking-arrow-right"), IconUnicodeGlyph(0xe552)]
        SolidPersonWalkingArrowRight = 1370,
        ///<summary>Solid Person Walking-dashed-line-arrow-right</summary>
        ///<see href="https://fontawesome.com/icons/person-walking-dashed-line-arrow-right?style=solid"/>
        [Description("Solid Person Walking-dashed-line-arrow-right"), IconID("fas-person-walking-dashed-line-arrow-right"), IconUnicodeGlyph(0xe553)]
        SolidPersonWalkingDashedLineArrowRight = 1371,
        ///<summary>Solid Person Walking-luggage</summary>
        ///<see href="https://fontawesome.com/icons/person-walking-luggage?style=solid"/>
        [Description("Solid Person Walking-luggage"), IconID("fas-person-walking-luggage"), IconUnicodeGlyph(0xe554)]
        SolidPersonWalkingLuggage = 1372,
        ///<summary>Solid Person walking with cane</summary>
        ///<see href="https://fontawesome.com/icons/person-walking-with-cane?style=solid"/>
        [Description("Solid Person walking with cane"), IconID("fas-person-walking-with-cane"), IconUnicodeGlyph(0xf29d)]
        SolidPersonWalkingWithCane = 1373,
        ///<summary>Solid Peseta Sign</summary>
        ///<see href="https://fontawesome.com/icons/peseta-sign?style=solid"/>
        [Description("Solid Peseta Sign"), IconID("fas-peseta-sign"), IconUnicodeGlyph(0xe221)]
        SolidPesetaSign = 1374,
        ///<summary>Solid Peso Sign</summary>
        ///<see href="https://fontawesome.com/icons/peso-sign?style=solid"/>
        [Description("Solid Peso Sign"), IconID("fas-peso-sign"), IconUnicodeGlyph(0xe222)]
        SolidPesoSign = 1375,
        ///<summary>Brands Phabricator</summary>
        ///<see href="https://fontawesome.com/icons/phabricator?style=brands"/>
        [Description("Brands Phabricator"), IconID("fab-phabricator"), IconUnicodeGlyph(0xf3db)]
        BrandsPhabricator = 1376,
        ///<summary>Brands Phoenix Framework</summary>
        ///<see href="https://fontawesome.com/icons/phoenix-framework?style=brands"/>
        [Description("Brands Phoenix Framework"), IconID("fab-phoenix-framework"), IconUnicodeGlyph(0xf3dc)]
        BrandsPhoenixFramework = 1377,
        ///<summary>Brands Phoenix Squadron</summary>
        ///<see href="https://fontawesome.com/icons/phoenix-squadron?style=brands"/>
        [Description("Brands Phoenix Squadron"), IconID("fab-phoenix-squadron"), IconUnicodeGlyph(0xf511)]
        BrandsPhoenixSquadron = 1378,
        ///<summary>Solid Phone</summary>
        ///<see href="https://fontawesome.com/icons/phone?style=solid"/>
        [Description("Solid Phone"), IconID("fas-phone"), IconUnicodeGlyph(0xf095)]
        SolidPhone = 1379,
        ///<summary>Solid Phone flip</summary>
        ///<see href="https://fontawesome.com/icons/phone-flip?style=solid"/>
        [Description("Solid Phone flip"), IconID("fas-phone-flip"), IconUnicodeGlyph(0xf879)]
        SolidPhoneFlip = 1380,
        ///<summary>Solid Phone Slash</summary>
        ///<see href="https://fontawesome.com/icons/phone-slash?style=solid"/>
        [Description("Solid Phone Slash"), IconID("fas-phone-slash"), IconUnicodeGlyph(0xf3dd)]
        SolidPhoneSlash = 1381,
        ///<summary>Solid Phone Volume</summary>
        ///<see href="https://fontawesome.com/icons/phone-volume?style=solid"/>
        [Description("Solid Phone Volume"), IconID("fas-phone-volume"), IconUnicodeGlyph(0xf2a0)]
        SolidPhoneVolume = 1382,
        ///<summary>Solid Photo film</summary>
        ///<see href="https://fontawesome.com/icons/photo-film?style=solid"/>
        [Description("Solid Photo film"), IconID("fas-photo-film"), IconUnicodeGlyph(0xf87c)]
        SolidPhotoFilm = 1383,
        ///<summary>Brands PHP</summary>
        ///<see href="https://fontawesome.com/icons/php?style=brands"/>
        [Description("Brands PHP"), IconID("fab-php"), IconUnicodeGlyph(0xf457)]
        BrandsPhp = 1384,
        ///<summary>Brands Pied Piper Logo</summary>
        ///<see href="https://fontawesome.com/icons/pied-piper?style=brands"/>
        [Description("Brands Pied Piper Logo"), IconID("fab-pied-piper"), IconUnicodeGlyph(0xf2ae)]
        BrandsPiedPiper = 1385,
        ///<summary>Brands Alternate Pied Piper Logo (Old)</summary>
        ///<see href="https://fontawesome.com/icons/pied-piper-alt?style=brands"/>
        [Description("Brands Alternate Pied Piper Logo (Old)"), IconID("fab-pied-piper-alt"), IconUnicodeGlyph(0xf1a8)]
        BrandsPiedPiperAlt = 1386,
        ///<summary>Brands Pied Piper Hat (Old)</summary>
        ///<see href="https://fontawesome.com/icons/pied-piper-hat?style=brands"/>
        [Description("Brands Pied Piper Hat (Old)"), IconID("fab-pied-piper-hat"), IconUnicodeGlyph(0xf4e5)]
        BrandsPiedPiperHat = 1387,
        ///<summary>Brands Pied Piper PP Logo (Old)</summary>
        ///<see href="https://fontawesome.com/icons/pied-piper-pp?style=brands"/>
        [Description("Brands Pied Piper PP Logo (Old)"), IconID("fab-pied-piper-pp"), IconUnicodeGlyph(0xf1a7)]
        BrandsPiedPiperPp = 1388,
        ///<summary>Solid Piggy Bank</summary>
        ///<see href="https://fontawesome.com/icons/piggy-bank?style=solid"/>
        [Description("Solid Piggy Bank"), IconID("fas-piggy-bank"), IconUnicodeGlyph(0xf4d3)]
        SolidPiggyBank = 1389,
        ///<summary>Solid Pills</summary>
        ///<see href="https://fontawesome.com/icons/pills?style=solid"/>
        [Description("Solid Pills"), IconID("fas-pills"), IconUnicodeGlyph(0xf484)]
        SolidPills = 1390,
        ///<summary>Brands Pinterest</summary>
        ///<see href="https://fontawesome.com/icons/pinterest?style=brands"/>
        [Description("Brands Pinterest"), IconID("fab-pinterest"), IconUnicodeGlyph(0xf0d2)]
        BrandsPinterest = 1391,
        ///<summary>Brands Pinterest P</summary>
        ///<see href="https://fontawesome.com/icons/pinterest-p?style=brands"/>
        [Description("Brands Pinterest P"), IconID("fab-pinterest-p"), IconUnicodeGlyph(0xf231)]
        BrandsPinterestP = 1392,
        ///<summary>Brands Pix</summary>
        ///<see href="https://fontawesome.com/icons/pix?style=brands"/>
        [Description("Brands Pix"), IconID("fab-pix"), IconUnicodeGlyph(0xe43a)]
        BrandsPix = 1393,
        ///<summary>Solid Pizza Slice</summary>
        ///<see href="https://fontawesome.com/icons/pizza-slice?style=solid"/>
        [Description("Solid Pizza Slice"), IconID("fas-pizza-slice"), IconUnicodeGlyph(0xf818)]
        SolidPizzaSlice = 1394,
        ///<summary>Solid Place of Worship</summary>
        ///<see href="https://fontawesome.com/icons/place-of-worship?style=solid"/>
        [Description("Solid Place of Worship"), IconID("fas-place-of-worship"), IconUnicodeGlyph(0xf67f)]
        SolidPlaceOfWorship = 1395,
        ///<summary>Solid plane</summary>
        ///<see href="https://fontawesome.com/icons/plane?style=solid"/>
        [Description("Solid plane"), IconID("fas-plane"), IconUnicodeGlyph(0xf072)]
        SolidPlane = 1396,
        ///<summary>Solid Plane Arrival</summary>
        ///<see href="https://fontawesome.com/icons/plane-arrival?style=solid"/>
        [Description("Solid Plane Arrival"), IconID("fas-plane-arrival"), IconUnicodeGlyph(0xf5af)]
        SolidPlaneArrival = 1397,
        ///<summary>Solid Plane Circle-check</summary>
        ///<see href="https://fontawesome.com/icons/plane-circle-check?style=solid"/>
        [Description("Solid Plane Circle-check"), IconID("fas-plane-circle-check"), IconUnicodeGlyph(0xe555)]
        SolidPlaneCircleCheck = 1398,
        ///<summary>Solid Plane Circle-exclamation</summary>
        ///<see href="https://fontawesome.com/icons/plane-circle-exclamation?style=solid"/>
        [Description("Solid Plane Circle-exclamation"), IconID("fas-plane-circle-exclamation"), IconUnicodeGlyph(0xe556)]
        SolidPlaneCircleExclamation = 1399,
        ///<summary>Solid Plane Circle-xmark</summary>
        ///<see href="https://fontawesome.com/icons/plane-circle-xmark?style=solid"/>
        [Description("Solid Plane Circle-xmark"), IconID("fas-plane-circle-xmark"), IconUnicodeGlyph(0xe557)]
        SolidPlaneCircleXmark = 1400,
        ///<summary>Solid Plane Departure</summary>
        ///<see href="https://fontawesome.com/icons/plane-departure?style=solid"/>
        [Description("Solid Plane Departure"), IconID("fas-plane-departure"), IconUnicodeGlyph(0xf5b0)]
        SolidPlaneDeparture = 1401,
        ///<summary>Solid Plane Lock</summary>
        ///<see href="https://fontawesome.com/icons/plane-lock?style=solid"/>
        [Description("Solid Plane Lock"), IconID("fas-plane-lock"), IconUnicodeGlyph(0xe558)]
        SolidPlaneLock = 1402,
        ///<summary>Solid Plane Slash</summary>
        ///<see href="https://fontawesome.com/icons/plane-slash?style=solid"/>
        [Description("Solid Plane Slash"), IconID("fas-plane-slash"), IconUnicodeGlyph(0xe069)]
        SolidPlaneSlash = 1403,
        ///<summary>Solid Plane Up</summary>
        ///<see href="https://fontawesome.com/icons/plane-up?style=solid"/>
        [Description("Solid Plane Up"), IconID("fas-plane-up"), IconUnicodeGlyph(0xe22d)]
        SolidPlaneUp = 1404,
        ///<summary>Solid Plant Wilt</summary>
        ///<see href="https://fontawesome.com/icons/plant-wilt?style=solid"/>
        [Description("Solid Plant Wilt"), IconID("fas-plant-wilt"), IconUnicodeGlyph(0xe5aa)]
        SolidPlantWilt = 1405,
        ///<summary>Solid Plate Wheat</summary>
        ///<see href="https://fontawesome.com/icons/plate-wheat?style=solid"/>
        [Description("Solid Plate Wheat"), IconID("fas-plate-wheat"), IconUnicodeGlyph(0xe55a)]
        SolidPlateWheat = 1406,
        ///<summary>Solid play</summary>
        ///<see href="https://fontawesome.com/icons/play?style=solid"/>
        [Description("Solid play"), IconID("fas-play"), IconUnicodeGlyph(0xf04b)]
        SolidPlay = 1407,
        ///<summary>Brands PlayStation</summary>
        ///<see href="https://fontawesome.com/icons/playstation?style=brands"/>
        [Description("Brands PlayStation"), IconID("fab-playstation"), IconUnicodeGlyph(0xf3df)]
        BrandsPlaystation = 1408,
        ///<summary>Solid Plug</summary>
        ///<see href="https://fontawesome.com/icons/plug?style=solid"/>
        [Description("Solid Plug"), IconID("fas-plug"), IconUnicodeGlyph(0xf1e6)]
        SolidPlug = 1409,
        ///<summary>Solid Plug Circle-bolt</summary>
        ///<see href="https://fontawesome.com/icons/plug-circle-bolt?style=solid"/>
        [Description("Solid Plug Circle-bolt"), IconID("fas-plug-circle-bolt"), IconUnicodeGlyph(0xe55b)]
        SolidPlugCircleBolt = 1410,
        ///<summary>Solid Plug Circle-check</summary>
        ///<see href="https://fontawesome.com/icons/plug-circle-check?style=solid"/>
        [Description("Solid Plug Circle-check"), IconID("fas-plug-circle-check"), IconUnicodeGlyph(0xe55c)]
        SolidPlugCircleCheck = 1411,
        ///<summary>Solid Plug Circle-exclamation</summary>
        ///<see href="https://fontawesome.com/icons/plug-circle-exclamation?style=solid"/>
        [Description("Solid Plug Circle-exclamation"), IconID("fas-plug-circle-exclamation"), IconUnicodeGlyph(0xe55d)]
        SolidPlugCircleExclamation = 1412,
        ///<summary>Solid Plug Circle-minus</summary>
        ///<see href="https://fontawesome.com/icons/plug-circle-minus?style=solid"/>
        [Description("Solid Plug Circle-minus"), IconID("fas-plug-circle-minus"), IconUnicodeGlyph(0xe55e)]
        SolidPlugCircleMinus = 1413,
        ///<summary>Solid Plug Circle-plus</summary>
        ///<see href="https://fontawesome.com/icons/plug-circle-plus?style=solid"/>
        [Description("Solid Plug Circle-plus"), IconID("fas-plug-circle-plus"), IconUnicodeGlyph(0xe55f)]
        SolidPlugCirclePlus = 1414,
        ///<summary>Solid Plug Circle-xmark</summary>
        ///<see href="https://fontawesome.com/icons/plug-circle-xmark?style=solid"/>
        [Description("Solid Plug Circle-xmark"), IconID("fas-plug-circle-xmark"), IconUnicodeGlyph(0xe560)]
        SolidPlugCircleXmark = 1415,
        ///<summary>Solid plus</summary>
        ///<see href="https://fontawesome.com/icons/plus?style=solid"/>
        [Description("Solid plus"), IconID("fas-plus"), IconUnicodeGlyph(0x2b)]
        SolidPlus = 1416,
        ///<summary>Solid Plus Minus</summary>
        ///<see href="https://fontawesome.com/icons/plus-minus?style=solid"/>
        [Description("Solid Plus Minus"), IconID("fas-plus-minus"), IconUnicodeGlyph(0xe43c)]
        SolidPlusMinus = 1417,
        ///<summary>Solid Podcast</summary>
        ///<see href="https://fontawesome.com/icons/podcast?style=solid"/>
        [Description("Solid Podcast"), IconID("fas-podcast"), IconUnicodeGlyph(0xf2ce)]
        SolidPodcast = 1418,
        ///<summary>Solid Poo</summary>
        ///<see href="https://fontawesome.com/icons/poo?style=solid"/>
        [Description("Solid Poo"), IconID("fas-poo"), IconUnicodeGlyph(0xf2fe)]
        SolidPoo = 1419,
        ///<summary>Solid Poo bolt</summary>
        ///<see href="https://fontawesome.com/icons/poo-storm?style=solid"/>
        [Description("Solid Poo bolt"), IconID("fas-poo-storm"), IconUnicodeGlyph(0xf75a)]
        SolidPooStorm = 1420,
        ///<summary>Solid Poop</summary>
        ///<see href="https://fontawesome.com/icons/poop?style=solid"/>
        [Description("Solid Poop"), IconID("fas-poop"), IconUnicodeGlyph(0xf619)]
        SolidPoop = 1421,
        ///<summary>Solid Power Off</summary>
        ///<see href="https://fontawesome.com/icons/power-off?style=solid"/>
        [Description("Solid Power Off"), IconID("fas-power-off"), IconUnicodeGlyph(0xf011)]
        SolidPowerOff = 1422,
        ///<summary>Solid Prescription</summary>
        ///<see href="https://fontawesome.com/icons/prescription?style=solid"/>
        [Description("Solid Prescription"), IconID("fas-prescription"), IconUnicodeGlyph(0xf5b1)]
        SolidPrescription = 1423,
        ///<summary>Solid Prescription Bottle</summary>
        ///<see href="https://fontawesome.com/icons/prescription-bottle?style=solid"/>
        [Description("Solid Prescription Bottle"), IconID("fas-prescription-bottle"), IconUnicodeGlyph(0xf485)]
        SolidPrescriptionBottle = 1424,
        ///<summary>Solid Prescription bottle medical</summary>
        ///<see href="https://fontawesome.com/icons/prescription-bottle-medical?style=solid"/>
        [Description("Solid Prescription bottle medical"), IconID("fas-prescription-bottle-medical"), IconUnicodeGlyph(0xf486)]
        SolidPrescriptionBottleMedical = 1425,
        ///<summary>Solid print</summary>
        ///<see href="https://fontawesome.com/icons/print?style=solid"/>
        [Description("Solid print"), IconID("fas-print"), IconUnicodeGlyph(0xf02f)]
        SolidPrint = 1426,
        ///<summary>Brands Product Hunt</summary>
        ///<see href="https://fontawesome.com/icons/product-hunt?style=brands"/>
        [Description("Brands Product Hunt"), IconID("fab-product-hunt"), IconUnicodeGlyph(0xf288)]
        BrandsProductHunt = 1427,
        ///<summary>Solid Pump Medical</summary>
        ///<see href="https://fontawesome.com/icons/pump-medical?style=solid"/>
        [Description("Solid Pump Medical"), IconID("fas-pump-medical"), IconUnicodeGlyph(0xe06a)]
        SolidPumpMedical = 1428,
        ///<summary>Solid Pump Soap</summary>
        ///<see href="https://fontawesome.com/icons/pump-soap?style=solid"/>
        [Description("Solid Pump Soap"), IconID("fas-pump-soap"), IconUnicodeGlyph(0xe06b)]
        SolidPumpSoap = 1429,
        ///<summary>Brands Pushed</summary>
        ///<see href="https://fontawesome.com/icons/pushed?style=brands"/>
        [Description("Brands Pushed"), IconID("fab-pushed"), IconUnicodeGlyph(0xf3e1)]
        BrandsPushed = 1430,
        ///<summary>Solid Puzzle Piece</summary>
        ///<see href="https://fontawesome.com/icons/puzzle-piece?style=solid"/>
        [Description("Solid Puzzle Piece"), IconID("fas-puzzle-piece"), IconUnicodeGlyph(0xf12e)]
        SolidPuzzlePiece = 1431,
        ///<summary>Brands Python</summary>
        ///<see href="https://fontawesome.com/icons/python?style=brands"/>
        [Description("Brands Python"), IconID("fab-python"), IconUnicodeGlyph(0xf3e2)]
        BrandsPython = 1432,
        ///<summary>Solid Q</summary>
        ///<see href="https://fontawesome.com/icons/q?style=solid"/>
        [Description("Solid Q"), IconID("fas-q"), IconUnicodeGlyph(0x51)]
        SolidQ = 1433,
        ///<summary>Brands QQ</summary>
        ///<see href="https://fontawesome.com/icons/qq?style=brands"/>
        [Description("Brands QQ"), IconID("fab-qq"), IconUnicodeGlyph(0xf1d6)]
        BrandsQq = 1434,
        ///<summary>Solid qrcode</summary>
        ///<see href="https://fontawesome.com/icons/qrcode?style=solid"/>
        [Description("Solid qrcode"), IconID("fas-qrcode"), IconUnicodeGlyph(0xf029)]
        SolidQrcode = 1435,
        ///<summary>Solid Question</summary>
        ///<see href="https://fontawesome.com/icons/question?style=solid"/>
        [Description("Solid Question"), IconID("fas-question"), IconUnicodeGlyph(0x3f)]
        SolidQuestion = 1436,
        ///<summary>Brands QuinScape</summary>
        ///<see href="https://fontawesome.com/icons/quinscape?style=brands"/>
        [Description("Brands QuinScape"), IconID("fab-quinscape"), IconUnicodeGlyph(0xf459)]
        BrandsQuinscape = 1437,
        ///<summary>Brands Quora</summary>
        ///<see href="https://fontawesome.com/icons/quora?style=brands"/>
        [Description("Brands Quora"), IconID("fab-quora"), IconUnicodeGlyph(0xf2c4)]
        BrandsQuora = 1438,
        ///<summary>Solid quote-left</summary>
        ///<see href="https://fontawesome.com/icons/quote-left?style=solid"/>
        [Description("Solid quote-left"), IconID("fas-quote-left"), IconUnicodeGlyph(0xf10d)]
        SolidQuoteLeft = 1439,
        ///<summary>Solid quote-right</summary>
        ///<see href="https://fontawesome.com/icons/quote-right?style=solid"/>
        [Description("Solid quote-right"), IconID("fas-quote-right"), IconUnicodeGlyph(0xf10e)]
        SolidQuoteRight = 1440,
        ///<summary>Solid R</summary>
        ///<see href="https://fontawesome.com/icons/r?style=solid"/>
        [Description("Solid R"), IconID("fas-r"), IconUnicodeGlyph(0x52)]
        SolidR = 1441,
        ///<summary>Brands R Project</summary>
        ///<see href="https://fontawesome.com/icons/r-project?style=brands"/>
        [Description("Brands R Project"), IconID("fab-r-project"), IconUnicodeGlyph(0xf4f7)]
        BrandsRProject = 1442,
        ///<summary>Solid Radiation</summary>
        ///<see href="https://fontawesome.com/icons/radiation?style=solid"/>
        [Description("Solid Radiation"), IconID("fas-radiation"), IconUnicodeGlyph(0xf7b9)]
        SolidRadiation = 1443,
        ///<summary>Solid Radio</summary>
        ///<see href="https://fontawesome.com/icons/radio?style=solid"/>
        [Description("Solid Radio"), IconID("fas-radio"), IconUnicodeGlyph(0xf8d7)]
        SolidRadio = 1444,
        ///<summary>Solid Rainbow</summary>
        ///<see href="https://fontawesome.com/icons/rainbow?style=solid"/>
        [Description("Solid Rainbow"), IconID("fas-rainbow"), IconUnicodeGlyph(0xf75b)]
        SolidRainbow = 1445,
        ///<summary>Solid Ranking Star</summary>
        ///<see href="https://fontawesome.com/icons/ranking-star?style=solid"/>
        [Description("Solid Ranking Star"), IconID("fas-ranking-star"), IconUnicodeGlyph(0xe561)]
        SolidRankingStar = 1446,
        ///<summary>Brands Raspberry Pi</summary>
        ///<see href="https://fontawesome.com/icons/raspberry-pi?style=brands"/>
        [Description("Brands Raspberry Pi"), IconID("fab-raspberry-pi"), IconUnicodeGlyph(0xf7bb)]
        BrandsRaspberryPi = 1447,
        ///<summary>Brands Ravelry</summary>
        ///<see href="https://fontawesome.com/icons/ravelry?style=brands"/>
        [Description("Brands Ravelry"), IconID("fab-ravelry"), IconUnicodeGlyph(0xf2d9)]
        BrandsRavelry = 1448,
        ///<summary>Brands React</summary>
        ///<see href="https://fontawesome.com/icons/react?style=brands"/>
        [Description("Brands React"), IconID("fab-react"), IconUnicodeGlyph(0xf41b)]
        BrandsReact = 1449,
        ///<summary>Brands ReactEurope</summary>
        ///<see href="https://fontawesome.com/icons/reacteurope?style=brands"/>
        [Description("Brands ReactEurope"), IconID("fab-reacteurope"), IconUnicodeGlyph(0xf75d)]
        BrandsReacteurope = 1450,
        ///<summary>Brands ReadMe</summary>
        ///<see href="https://fontawesome.com/icons/readme?style=brands"/>
        [Description("Brands ReadMe"), IconID("fab-readme"), IconUnicodeGlyph(0xf4d5)]
        BrandsReadme = 1451,
        ///<summary>Brands Rebel Alliance</summary>
        ///<see href="https://fontawesome.com/icons/rebel?style=brands"/>
        [Description("Brands Rebel Alliance"), IconID("fab-rebel"), IconUnicodeGlyph(0xf1d0)]
        BrandsRebel = 1452,
        ///<summary>Solid Receipt</summary>
        ///<see href="https://fontawesome.com/icons/receipt?style=solid"/>
        [Description("Solid Receipt"), IconID("fas-receipt"), IconUnicodeGlyph(0xf543)]
        SolidReceipt = 1453,
        ///<summary>Solid Record Vinyl</summary>
        ///<see href="https://fontawesome.com/icons/record-vinyl?style=solid"/>
        [Description("Solid Record Vinyl"), IconID("fas-record-vinyl"), IconUnicodeGlyph(0xf8d9)]
        SolidRecordVinyl = 1454,
        ///<summary>Solid Rectangle ad</summary>
        ///<see href="https://fontawesome.com/icons/rectangle-ad?style=solid"/>
        [Description("Solid Rectangle ad"), IconID("fas-rectangle-ad"), IconUnicodeGlyph(0xf641)]
        SolidRectangleAd = 1455,
        ///<summary>Solid Rectangle list</summary>
        ///<see href="https://fontawesome.com/icons/rectangle-list?style=solid"/>
        [Description("Solid Rectangle list"), IconID("fas-rectangle-list"), IconUnicodeGlyph(0xf022)]
        SolidRectangleList = 1456,
        ///<summary>Regular Rectangle list</summary>
        ///<see href="https://fontawesome.com/icons/rectangle-list?style=regular"/>
        [Description("Regular Rectangle list"), IconID("far-rectangle-list"), IconUnicodeGlyph(0xf022)]
        RegularRectangleList = 1457,
        ///<summary>Solid Rectangle X Mark</summary>
        ///<see href="https://fontawesome.com/icons/rectangle-xmark?style=solid"/>
        [Description("Solid Rectangle X Mark"), IconID("fas-rectangle-xmark"), IconUnicodeGlyph(0xf410)]
        SolidRectangleXmark = 1458,
        ///<summary>Regular Rectangle X Mark</summary>
        ///<see href="https://fontawesome.com/icons/rectangle-xmark?style=regular"/>
        [Description("Regular Rectangle X Mark"), IconID("far-rectangle-xmark"), IconUnicodeGlyph(0xf410)]
        RegularRectangleXmark = 1459,
        ///<summary>Solid Recycle</summary>
        ///<see href="https://fontawesome.com/icons/recycle?style=solid"/>
        [Description("Solid Recycle"), IconID("fas-recycle"), IconUnicodeGlyph(0xf1b8)]
        SolidRecycle = 1460,
        ///<summary>Brands red river</summary>
        ///<see href="https://fontawesome.com/icons/red-river?style=brands"/>
        [Description("Brands red river"), IconID("fab-red-river"), IconUnicodeGlyph(0xf3e3)]
        BrandsRedRiver = 1461,
        ///<summary>Brands reddit Logo</summary>
        ///<see href="https://fontawesome.com/icons/reddit?style=brands"/>
        [Description("Brands reddit Logo"), IconID("fab-reddit"), IconUnicodeGlyph(0xf1a1)]
        BrandsReddit = 1462,
        ///<summary>Brands reddit Alien</summary>
        ///<see href="https://fontawesome.com/icons/reddit-alien?style=brands"/>
        [Description("Brands reddit Alien"), IconID("fab-reddit-alien"), IconUnicodeGlyph(0xf281)]
        BrandsRedditAlien = 1463,
        ///<summary>Brands Redhat</summary>
        ///<see href="https://fontawesome.com/icons/redhat?style=brands"/>
        [Description("Brands Redhat"), IconID("fab-redhat"), IconUnicodeGlyph(0xf7bc)]
        BrandsRedhat = 1464,
        ///<summary>Solid Registered Trademark</summary>
        ///<see href="https://fontawesome.com/icons/registered?style=solid"/>
        [Description("Solid Registered Trademark"), IconID("fas-registered"), IconUnicodeGlyph(0xf25d)]
        SolidRegistered = 1465,
        ///<summary>Regular Registered Trademark</summary>
        ///<see href="https://fontawesome.com/icons/registered?style=regular"/>
        [Description("Regular Registered Trademark"), IconID("far-registered"), IconUnicodeGlyph(0xf25d)]
        RegularRegistered = 1466,
        ///<summary>Brands Renren</summary>
        ///<see href="https://fontawesome.com/icons/renren?style=brands"/>
        [Description("Brands Renren"), IconID("fab-renren"), IconUnicodeGlyph(0xf18b)]
        BrandsRenren = 1467,
        ///<summary>Solid Repeat</summary>
        ///<see href="https://fontawesome.com/icons/repeat?style=solid"/>
        [Description("Solid Repeat"), IconID("fas-repeat"), IconUnicodeGlyph(0xf363)]
        SolidRepeat = 1468,
        ///<summary>Solid Reply</summary>
        ///<see href="https://fontawesome.com/icons/reply?style=solid"/>
        [Description("Solid Reply"), IconID("fas-reply"), IconUnicodeGlyph(0xf3e5)]
        SolidReply = 1469,
        ///<summary>Solid reply-all</summary>
        ///<see href="https://fontawesome.com/icons/reply-all?style=solid"/>
        [Description("Solid reply-all"), IconID("fas-reply-all"), IconUnicodeGlyph(0xf122)]
        SolidReplyAll = 1470,
        ///<summary>Brands replyd</summary>
        ///<see href="https://fontawesome.com/icons/replyd?style=brands"/>
        [Description("Brands replyd"), IconID("fab-replyd"), IconUnicodeGlyph(0xf3e6)]
        BrandsReplyd = 1471,
        ///<summary>Solid Republican</summary>
        ///<see href="https://fontawesome.com/icons/republican?style=solid"/>
        [Description("Solid Republican"), IconID("fas-republican"), IconUnicodeGlyph(0xf75e)]
        SolidRepublican = 1472,
        ///<summary>Brands Researchgate</summary>
        ///<see href="https://fontawesome.com/icons/researchgate?style=brands"/>
        [Description("Brands Researchgate"), IconID("fab-researchgate"), IconUnicodeGlyph(0xf4f8)]
        BrandsResearchgate = 1473,
        ///<summary>Brands Resolving</summary>
        ///<see href="https://fontawesome.com/icons/resolving?style=brands"/>
        [Description("Brands Resolving"), IconID("fab-resolving"), IconUnicodeGlyph(0xf3e7)]
        BrandsResolving = 1474,
        ///<summary>Solid Restroom</summary>
        ///<see href="https://fontawesome.com/icons/restroom?style=solid"/>
        [Description("Solid Restroom"), IconID("fas-restroom"), IconUnicodeGlyph(0xf7bd)]
        SolidRestroom = 1475,
        ///<summary>Solid Retweet</summary>
        ///<see href="https://fontawesome.com/icons/retweet?style=solid"/>
        [Description("Solid Retweet"), IconID("fas-retweet"), IconUnicodeGlyph(0xf079)]
        SolidRetweet = 1476,
        ///<summary>Brands Rev.io</summary>
        ///<see href="https://fontawesome.com/icons/rev?style=brands"/>
        [Description("Brands Rev.io"), IconID("fab-rev"), IconUnicodeGlyph(0xf5b2)]
        BrandsRev = 1477,
        ///<summary>Solid Ribbon</summary>
        ///<see href="https://fontawesome.com/icons/ribbon?style=solid"/>
        [Description("Solid Ribbon"), IconID("fas-ribbon"), IconUnicodeGlyph(0xf4d6)]
        SolidRibbon = 1478,
        ///<summary>Solid Right from bracket</summary>
        ///<see href="https://fontawesome.com/icons/right-from-bracket?style=solid"/>
        [Description("Solid Right from bracket"), IconID("fas-right-from-bracket"), IconUnicodeGlyph(0xf2f5)]
        SolidRightFromBracket = 1479,
        ///<summary>Solid Right left</summary>
        ///<see href="https://fontawesome.com/icons/right-left?style=solid"/>
        [Description("Solid Right left"), IconID("fas-right-left"), IconUnicodeGlyph(0xf362)]
        SolidRightLeft = 1480,
        ///<summary>Solid Right long</summary>
        ///<see href="https://fontawesome.com/icons/right-long?style=solid"/>
        [Description("Solid Right long"), IconID("fas-right-long"), IconUnicodeGlyph(0xf30b)]
        SolidRightLong = 1481,
        ///<summary>Solid Right to bracket</summary>
        ///<see href="https://fontawesome.com/icons/right-to-bracket?style=solid"/>
        [Description("Solid Right to bracket"), IconID("fas-right-to-bracket"), IconUnicodeGlyph(0xf2f6)]
        SolidRightToBracket = 1482,
        ///<summary>Solid Ring</summary>
        ///<see href="https://fontawesome.com/icons/ring?style=solid"/>
        [Description("Solid Ring"), IconID("fas-ring"), IconUnicodeGlyph(0xf70b)]
        SolidRing = 1483,
        ///<summary>Solid road</summary>
        ///<see href="https://fontawesome.com/icons/road?style=solid"/>
        [Description("Solid road"), IconID("fas-road"), IconUnicodeGlyph(0xf018)]
        SolidRoad = 1484,
        ///<summary>Solid Road Barrier</summary>
        ///<see href="https://fontawesome.com/icons/road-barrier?style=solid"/>
        [Description("Solid Road Barrier"), IconID("fas-road-barrier"), IconUnicodeGlyph(0xe562)]
        SolidRoadBarrier = 1485,
        ///<summary>Solid Road Bridge</summary>
        ///<see href="https://fontawesome.com/icons/road-bridge?style=solid"/>
        [Description("Solid Road Bridge"), IconID("fas-road-bridge"), IconUnicodeGlyph(0xe563)]
        SolidRoadBridge = 1486,
        ///<summary>Solid Road Circle-check</summary>
        ///<see href="https://fontawesome.com/icons/road-circle-check?style=solid"/>
        [Description("Solid Road Circle-check"), IconID("fas-road-circle-check"), IconUnicodeGlyph(0xe564)]
        SolidRoadCircleCheck = 1487,
        ///<summary>Solid Road Circle-exclamation</summary>
        ///<see href="https://fontawesome.com/icons/road-circle-exclamation?style=solid"/>
        [Description("Solid Road Circle-exclamation"), IconID("fas-road-circle-exclamation"), IconUnicodeGlyph(0xe565)]
        SolidRoadCircleExclamation = 1488,
        ///<summary>Solid Road Circle-xmark</summary>
        ///<see href="https://fontawesome.com/icons/road-circle-xmark?style=solid"/>
        [Description("Solid Road Circle-xmark"), IconID("fas-road-circle-xmark"), IconUnicodeGlyph(0xe566)]
        SolidRoadCircleXmark = 1489,
        ///<summary>Solid Road Lock</summary>
        ///<see href="https://fontawesome.com/icons/road-lock?style=solid"/>
        [Description("Solid Road Lock"), IconID("fas-road-lock"), IconUnicodeGlyph(0xe567)]
        SolidRoadLock = 1490,
        ///<summary>Solid Road Spikes</summary>
        ///<see href="https://fontawesome.com/icons/road-spikes?style=solid"/>
        [Description("Solid Road Spikes"), IconID("fas-road-spikes"), IconUnicodeGlyph(0xe568)]
        SolidRoadSpikes = 1491,
        ///<summary>Solid Robot</summary>
        ///<see href="https://fontawesome.com/icons/robot?style=solid"/>
        [Description("Solid Robot"), IconID("fas-robot"), IconUnicodeGlyph(0xf544)]
        SolidRobot = 1492,
        ///<summary>Solid rocket</summary>
        ///<see href="https://fontawesome.com/icons/rocket?style=solid"/>
        [Description("Solid rocket"), IconID("fas-rocket"), IconUnicodeGlyph(0xf135)]
        SolidRocket = 1493,
        ///<summary>Brands Rocket.Chat</summary>
        ///<see href="https://fontawesome.com/icons/rocketchat?style=brands"/>
        [Description("Brands Rocket.Chat"), IconID("fab-rocketchat"), IconUnicodeGlyph(0xf3e8)]
        BrandsRocketchat = 1494,
        ///<summary>Brands Rockrms</summary>
        ///<see href="https://fontawesome.com/icons/rockrms?style=brands"/>
        [Description("Brands Rockrms"), IconID("fab-rockrms"), IconUnicodeGlyph(0xf3e9)]
        BrandsRockrms = 1495,
        ///<summary>Solid Rotate</summary>
        ///<see href="https://fontawesome.com/icons/rotate?style=solid"/>
        [Description("Solid Rotate"), IconID("fas-rotate"), IconUnicodeGlyph(0xf2f1)]
        SolidRotate = 1496,
        ///<summary>Solid Rotate Left</summary>
        ///<see href="https://fontawesome.com/icons/rotate-left?style=solid"/>
        [Description("Solid Rotate Left"), IconID("fas-rotate-left"), IconUnicodeGlyph(0xf2ea)]
        SolidRotateLeft = 1497,
        ///<summary>Solid Rotate Right</summary>
        ///<see href="https://fontawesome.com/icons/rotate-right?style=solid"/>
        [Description("Solid Rotate Right"), IconID("fas-rotate-right"), IconUnicodeGlyph(0xf2f9)]
        SolidRotateRight = 1498,
        ///<summary>Solid Route</summary>
        ///<see href="https://fontawesome.com/icons/route?style=solid"/>
        [Description("Solid Route"), IconID("fas-route"), IconUnicodeGlyph(0xf4d7)]
        SolidRoute = 1499,
        ///<summary>Solid rss</summary>
        ///<see href="https://fontawesome.com/icons/rss?style=solid"/>
        [Description("Solid rss"), IconID("fas-rss"), IconUnicodeGlyph(0xf09e)]
        SolidRss = 1500,
        ///<summary>Solid Ruble Sign</summary>
        ///<see href="https://fontawesome.com/icons/ruble-sign?style=solid"/>
        [Description("Solid Ruble Sign"), IconID("fas-ruble-sign"), IconUnicodeGlyph(0xf158)]
        SolidRubleSign = 1501,
        ///<summary>Solid Rug</summary>
        ///<see href="https://fontawesome.com/icons/rug?style=solid"/>
        [Description("Solid Rug"), IconID("fas-rug"), IconUnicodeGlyph(0xe569)]
        SolidRug = 1502,
        ///<summary>Solid Ruler</summary>
        ///<see href="https://fontawesome.com/icons/ruler?style=solid"/>
        [Description("Solid Ruler"), IconID("fas-ruler"), IconUnicodeGlyph(0xf545)]
        SolidRuler = 1503,
        ///<summary>Solid Ruler Combined</summary>
        ///<see href="https://fontawesome.com/icons/ruler-combined?style=solid"/>
        [Description("Solid Ruler Combined"), IconID("fas-ruler-combined"), IconUnicodeGlyph(0xf546)]
        SolidRulerCombined = 1504,
        ///<summary>Solid Ruler Horizontal</summary>
        ///<see href="https://fontawesome.com/icons/ruler-horizontal?style=solid"/>
        [Description("Solid Ruler Horizontal"), IconID("fas-ruler-horizontal"), IconUnicodeGlyph(0xf547)]
        SolidRulerHorizontal = 1505,
        ///<summary>Solid Ruler Vertical</summary>
        ///<see href="https://fontawesome.com/icons/ruler-vertical?style=solid"/>
        [Description("Solid Ruler Vertical"), IconID("fas-ruler-vertical"), IconUnicodeGlyph(0xf548)]
        SolidRulerVertical = 1506,
        ///<summary>Solid Indian Rupee Sign</summary>
        ///<see href="https://fontawesome.com/icons/rupee-sign?style=solid"/>
        [Description("Solid Indian Rupee Sign"), IconID("fas-rupee-sign"), IconUnicodeGlyph(0xf156)]
        SolidRupeeSign = 1507,
        ///<summary>Solid Rupiah Sign</summary>
        ///<see href="https://fontawesome.com/icons/rupiah-sign?style=solid"/>
        [Description("Solid Rupiah Sign"), IconID("fas-rupiah-sign"), IconUnicodeGlyph(0xe23d)]
        SolidRupiahSign = 1508,
        ///<summary>Brands Rust</summary>
        ///<see href="https://fontawesome.com/icons/rust?style=brands"/>
        [Description("Brands Rust"), IconID("fab-rust"), IconUnicodeGlyph(0xe07a)]
        BrandsRust = 1509,
        ///<summary>Solid S</summary>
        ///<see href="https://fontawesome.com/icons/s?style=solid"/>
        [Description("Solid S"), IconID("fas-s"), IconUnicodeGlyph(0x53)]
        SolidS = 1510,
        ///<summary>Solid Sack of Money</summary>
        ///<see href="https://fontawesome.com/icons/sack-dollar?style=solid"/>
        [Description("Solid Sack of Money"), IconID("fas-sack-dollar"), IconUnicodeGlyph(0xf81d)]
        SolidSackDollar = 1511,
        ///<summary>Solid Sack Xmark</summary>
        ///<see href="https://fontawesome.com/icons/sack-xmark?style=solid"/>
        [Description("Solid Sack Xmark"), IconID("fas-sack-xmark"), IconUnicodeGlyph(0xe56a)]
        SolidSackXmark = 1512,
        ///<summary>Brands Safari</summary>
        ///<see href="https://fontawesome.com/icons/safari?style=brands"/>
        [Description("Brands Safari"), IconID("fab-safari"), IconUnicodeGlyph(0xf267)]
        BrandsSafari = 1513,
        ///<summary>Solid Sailboat</summary>
        ///<see href="https://fontawesome.com/icons/sailboat?style=solid"/>
        [Description("Solid Sailboat"), IconID("fas-sailboat"), IconUnicodeGlyph(0xe445)]
        SolidSailboat = 1514,
        ///<summary>Brands Salesforce</summary>
        ///<see href="https://fontawesome.com/icons/salesforce?style=brands"/>
        [Description("Brands Salesforce"), IconID("fab-salesforce"), IconUnicodeGlyph(0xf83b)]
        BrandsSalesforce = 1515,
        ///<summary>Brands Sass</summary>
        ///<see href="https://fontawesome.com/icons/sass?style=brands"/>
        [Description("Brands Sass"), IconID("fab-sass"), IconUnicodeGlyph(0xf41e)]
        BrandsSass = 1516,
        ///<summary>Solid Satellite</summary>
        ///<see href="https://fontawesome.com/icons/satellite?style=solid"/>
        [Description("Solid Satellite"), IconID("fas-satellite"), IconUnicodeGlyph(0xf7bf)]
        SolidSatellite = 1517,
        ///<summary>Solid Satellite Dish</summary>
        ///<see href="https://fontawesome.com/icons/satellite-dish?style=solid"/>
        [Description("Solid Satellite Dish"), IconID("fas-satellite-dish"), IconUnicodeGlyph(0xf7c0)]
        SolidSatelliteDish = 1518,
        ///<summary>Solid Scale balanced</summary>
        ///<see href="https://fontawesome.com/icons/scale-balanced?style=solid"/>
        [Description("Solid Scale balanced"), IconID("fas-scale-balanced"), IconUnicodeGlyph(0xf24e)]
        SolidScaleBalanced = 1519,
        ///<summary>Solid Scale unbalanced</summary>
        ///<see href="https://fontawesome.com/icons/scale-unbalanced?style=solid"/>
        [Description("Solid Scale unbalanced"), IconID("fas-scale-unbalanced"), IconUnicodeGlyph(0xf515)]
        SolidScaleUnbalanced = 1520,
        ///<summary>Solid Scale unbalanced flip</summary>
        ///<see href="https://fontawesome.com/icons/scale-unbalanced-flip?style=solid"/>
        [Description("Solid Scale unbalanced flip"), IconID("fas-scale-unbalanced-flip"), IconUnicodeGlyph(0xf516)]
        SolidScaleUnbalancedFlip = 1521,
        ///<summary>Brands SCHLIX</summary>
        ///<see href="https://fontawesome.com/icons/schlix?style=brands"/>
        [Description("Brands SCHLIX"), IconID("fab-schlix"), IconUnicodeGlyph(0xf3ea)]
        BrandsSchlix = 1522,
        ///<summary>Solid School</summary>
        ///<see href="https://fontawesome.com/icons/school?style=solid"/>
        [Description("Solid School"), IconID("fas-school"), IconUnicodeGlyph(0xf549)]
        SolidSchool = 1523,
        ///<summary>Solid School Circle-check</summary>
        ///<see href="https://fontawesome.com/icons/school-circle-check?style=solid"/>
        [Description("Solid School Circle-check"), IconID("fas-school-circle-check"), IconUnicodeGlyph(0xe56b)]
        SolidSchoolCircleCheck = 1524,
        ///<summary>Solid School Circle-exclamation</summary>
        ///<see href="https://fontawesome.com/icons/school-circle-exclamation?style=solid"/>
        [Description("Solid School Circle-exclamation"), IconID("fas-school-circle-exclamation"), IconUnicodeGlyph(0xe56c)]
        SolidSchoolCircleExclamation = 1525,
        ///<summary>Solid School Circle-xmark</summary>
        ///<see href="https://fontawesome.com/icons/school-circle-xmark?style=solid"/>
        [Description("Solid School Circle-xmark"), IconID("fas-school-circle-xmark"), IconUnicodeGlyph(0xe56d)]
        SolidSchoolCircleXmark = 1526,
        ///<summary>Solid School Flag</summary>
        ///<see href="https://fontawesome.com/icons/school-flag?style=solid"/>
        [Description("Solid School Flag"), IconID("fas-school-flag"), IconUnicodeGlyph(0xe56e)]
        SolidSchoolFlag = 1527,
        ///<summary>Solid School Lock</summary>
        ///<see href="https://fontawesome.com/icons/school-lock?style=solid"/>
        [Description("Solid School Lock"), IconID("fas-school-lock"), IconUnicodeGlyph(0xe56f)]
        SolidSchoolLock = 1528,
        ///<summary>Solid Scissors</summary>
        ///<see href="https://fontawesome.com/icons/scissors?style=solid"/>
        [Description("Solid Scissors"), IconID("fas-scissors"), IconUnicodeGlyph(0xf0c4)]
        SolidScissors = 1529,
        ///<summary>Brands Screenpal</summary>
        ///<see href="https://fontawesome.com/icons/screenpal?style=brands"/>
        [Description("Brands Screenpal"), IconID("fab-screenpal"), IconUnicodeGlyph(0xe570)]
        BrandsScreenpal = 1530,
        ///<summary>Solid Screwdriver</summary>
        ///<see href="https://fontawesome.com/icons/screwdriver?style=solid"/>
        [Description("Solid Screwdriver"), IconID("fas-screwdriver"), IconUnicodeGlyph(0xf54a)]
        SolidScrewdriver = 1531,
        ///<summary>Solid Screwdriver wrench</summary>
        ///<see href="https://fontawesome.com/icons/screwdriver-wrench?style=solid"/>
        [Description("Solid Screwdriver wrench"), IconID("fas-screwdriver-wrench"), IconUnicodeGlyph(0xf7d9)]
        SolidScrewdriverWrench = 1532,
        ///<summary>Brands Scribd</summary>
        ///<see href="https://fontawesome.com/icons/scribd?style=brands"/>
        [Description("Brands Scribd"), IconID("fab-scribd"), IconUnicodeGlyph(0xf28a)]
        BrandsScribd = 1533,
        ///<summary>Solid Scroll</summary>
        ///<see href="https://fontawesome.com/icons/scroll?style=solid"/>
        [Description("Solid Scroll"), IconID("fas-scroll"), IconUnicodeGlyph(0xf70e)]
        SolidScroll = 1534,
        ///<summary>Solid Scroll torah</summary>
        ///<see href="https://fontawesome.com/icons/scroll-torah?style=solid"/>
        [Description("Solid Scroll torah"), IconID("fas-scroll-torah"), IconUnicodeGlyph(0xf6a0)]
        SolidScrollTorah = 1535,
        ///<summary>Solid Sd Card</summary>
        ///<see href="https://fontawesome.com/icons/sd-card?style=solid"/>
        [Description("Solid Sd Card"), IconID("fas-sd-card"), IconUnicodeGlyph(0xf7c2)]
        SolidSdCard = 1536,
        ///<summary>Brands Searchengin</summary>
        ///<see href="https://fontawesome.com/icons/searchengin?style=brands"/>
        [Description("Brands Searchengin"), IconID("fab-searchengin"), IconUnicodeGlyph(0xf3eb)]
        BrandsSearchengin = 1537,
        ///<summary>Solid Section</summary>
        ///<see href="https://fontawesome.com/icons/section?style=solid"/>
        [Description("Solid Section"), IconID("fas-section"), IconUnicodeGlyph(0xe447)]
        SolidSection = 1538,
        ///<summary>Solid Seedling</summary>
        ///<see href="https://fontawesome.com/icons/seedling?style=solid"/>
        [Description("Solid Seedling"), IconID("fas-seedling"), IconUnicodeGlyph(0xf4d8)]
        SolidSeedling = 1539,
        ///<summary>Brands Sellcast</summary>
        ///<see href="https://fontawesome.com/icons/sellcast?style=brands"/>
        [Description("Brands Sellcast"), IconID("fab-sellcast"), IconUnicodeGlyph(0xf2da)]
        BrandsSellcast = 1540,
        ///<summary>Brands Sellsy</summary>
        ///<see href="https://fontawesome.com/icons/sellsy?style=brands"/>
        [Description("Brands Sellsy"), IconID("fab-sellsy"), IconUnicodeGlyph(0xf213)]
        BrandsSellsy = 1541,
        ///<summary>Solid Server</summary>
        ///<see href="https://fontawesome.com/icons/server?style=solid"/>
        [Description("Solid Server"), IconID("fas-server"), IconUnicodeGlyph(0xf233)]
        SolidServer = 1542,
        ///<summary>Brands Servicestack</summary>
        ///<see href="https://fontawesome.com/icons/servicestack?style=brands"/>
        [Description("Brands Servicestack"), IconID("fab-servicestack"), IconUnicodeGlyph(0xf3ec)]
        BrandsServicestack = 1543,
        ///<summary>Solid Shapes</summary>
        ///<see href="https://fontawesome.com/icons/shapes?style=solid"/>
        [Description("Solid Shapes"), IconID("fas-shapes"), IconUnicodeGlyph(0xf61f)]
        SolidShapes = 1544,
        ///<summary>Solid Share</summary>
        ///<see href="https://fontawesome.com/icons/share?style=solid"/>
        [Description("Solid Share"), IconID("fas-share"), IconUnicodeGlyph(0xf064)]
        SolidShare = 1545,
        ///<summary>Solid Share from square</summary>
        ///<see href="https://fontawesome.com/icons/share-from-square?style=solid"/>
        [Description("Solid Share from square"), IconID("fas-share-from-square"), IconUnicodeGlyph(0xf14d)]
        SolidShareFromSquare = 1546,
        ///<summary>Regular Share from square</summary>
        ///<see href="https://fontawesome.com/icons/share-from-square?style=regular"/>
        [Description("Regular Share from square"), IconID("far-share-from-square"), IconUnicodeGlyph(0xf14d)]
        RegularShareFromSquare = 1547,
        ///<summary>Solid Share nodes</summary>
        ///<see href="https://fontawesome.com/icons/share-nodes?style=solid"/>
        [Description("Solid Share nodes"), IconID("fas-share-nodes"), IconUnicodeGlyph(0xf1e0)]
        SolidShareNodes = 1548,
        ///<summary>Solid Sheet Plastic</summary>
        ///<see href="https://fontawesome.com/icons/sheet-plastic?style=solid"/>
        [Description("Solid Sheet Plastic"), IconID("fas-sheet-plastic"), IconUnicodeGlyph(0xe571)]
        SolidSheetPlastic = 1549,
        ///<summary>Solid Shekel Sign</summary>
        ///<see href="https://fontawesome.com/icons/shekel-sign?style=solid"/>
        [Description("Solid Shekel Sign"), IconID("fas-shekel-sign"), IconUnicodeGlyph(0xf20b)]
        SolidShekelSign = 1550,
        ///<summary>Solid shield</summary>
        ///<see href="https://fontawesome.com/icons/shield?style=solid"/>
        [Description("Solid shield"), IconID("fas-shield"), IconUnicodeGlyph(0xf132)]
        SolidShield = 1551,
        ///<summary>Solid Shield Cat</summary>
        ///<see href="https://fontawesome.com/icons/shield-cat?style=solid"/>
        [Description("Solid Shield Cat"), IconID("fas-shield-cat"), IconUnicodeGlyph(0xe572)]
        SolidShieldCat = 1552,
        ///<summary>Solid Shield Dog</summary>
        ///<see href="https://fontawesome.com/icons/shield-dog?style=solid"/>
        [Description("Solid Shield Dog"), IconID("fas-shield-dog"), IconUnicodeGlyph(0xe573)]
        SolidShieldDog = 1553,
        ///<summary>Solid Shield Halved</summary>
        ///<see href="https://fontawesome.com/icons/shield-halved?style=solid"/>
        [Description("Solid Shield Halved"), IconID("fas-shield-halved"), IconUnicodeGlyph(0xf3ed)]
        SolidShieldHalved = 1554,
        ///<summary>Solid Shield Heart</summary>
        ///<see href="https://fontawesome.com/icons/shield-heart?style=solid"/>
        [Description("Solid Shield Heart"), IconID("fas-shield-heart"), IconUnicodeGlyph(0xe574)]
        SolidShieldHeart = 1555,
        ///<summary>Solid Shield Virus</summary>
        ///<see href="https://fontawesome.com/icons/shield-virus?style=solid"/>
        [Description("Solid Shield Virus"), IconID("fas-shield-virus"), IconUnicodeGlyph(0xe06c)]
        SolidShieldVirus = 1556,
        ///<summary>Solid Ship</summary>
        ///<see href="https://fontawesome.com/icons/ship?style=solid"/>
        [Description("Solid Ship"), IconID("fas-ship"), IconUnicodeGlyph(0xf21a)]
        SolidShip = 1557,
        ///<summary>Solid T-Shirt</summary>
        ///<see href="https://fontawesome.com/icons/shirt?style=solid"/>
        [Description("Solid T-Shirt"), IconID("fas-shirt"), IconUnicodeGlyph(0xf553)]
        SolidShirt = 1558,
        ///<summary>Brands Shirts in Bulk</summary>
        ///<see href="https://fontawesome.com/icons/shirtsinbulk?style=brands"/>
        [Description("Brands Shirts in Bulk"), IconID("fab-shirtsinbulk"), IconUnicodeGlyph(0xf214)]
        BrandsShirtsinbulk = 1559,
        ///<summary>Solid Shoe Prints</summary>
        ///<see href="https://fontawesome.com/icons/shoe-prints?style=solid"/>
        [Description("Solid Shoe Prints"), IconID("fas-shoe-prints"), IconUnicodeGlyph(0xf54b)]
        SolidShoePrints = 1560,
        ///<summary>Solid Shop</summary>
        ///<see href="https://fontawesome.com/icons/shop?style=solid"/>
        [Description("Solid Shop"), IconID("fas-shop"), IconUnicodeGlyph(0xf54f)]
        SolidShop = 1561,
        ///<summary>Solid Shop Lock</summary>
        ///<see href="https://fontawesome.com/icons/shop-lock?style=solid"/>
        [Description("Solid Shop Lock"), IconID("fas-shop-lock"), IconUnicodeGlyph(0xe4a5)]
        SolidShopLock = 1562,
        ///<summary>Solid Shop slash</summary>
        ///<see href="https://fontawesome.com/icons/shop-slash?style=solid"/>
        [Description("Solid Shop slash"), IconID("fas-shop-slash"), IconUnicodeGlyph(0xe070)]
        SolidShopSlash = 1563,
        ///<summary>Brands Shopify</summary>
        ///<see href="https://fontawesome.com/icons/shopify?style=brands"/>
        [Description("Brands Shopify"), IconID("fab-shopify"), IconUnicodeGlyph(0xe057)]
        BrandsShopify = 1564,
        ///<summary>Brands Shopware</summary>
        ///<see href="https://fontawesome.com/icons/shopware?style=brands"/>
        [Description("Brands Shopware"), IconID("fab-shopware"), IconUnicodeGlyph(0xf5b5)]
        BrandsShopware = 1565,
        ///<summary>Solid Shower</summary>
        ///<see href="https://fontawesome.com/icons/shower?style=solid"/>
        [Description("Solid Shower"), IconID("fas-shower"), IconUnicodeGlyph(0xf2cc)]
        SolidShower = 1566,
        ///<summary>Solid Shrimp</summary>
        ///<see href="https://fontawesome.com/icons/shrimp?style=solid"/>
        [Description("Solid Shrimp"), IconID("fas-shrimp"), IconUnicodeGlyph(0xe448)]
        SolidShrimp = 1567,
        ///<summary>Solid Shuffle</summary>
        ///<see href="https://fontawesome.com/icons/shuffle?style=solid"/>
        [Description("Solid Shuffle"), IconID("fas-shuffle"), IconUnicodeGlyph(0xf074)]
        SolidShuffle = 1568,
        ///<summary>Solid Shuttle space</summary>
        ///<see href="https://fontawesome.com/icons/shuttle-space?style=solid"/>
        [Description("Solid Shuttle space"), IconID("fas-shuttle-space"), IconUnicodeGlyph(0xf197)]
        SolidShuttleSpace = 1569,
        ///<summary>Solid Sign hanging</summary>
        ///<see href="https://fontawesome.com/icons/sign-hanging?style=solid"/>
        [Description("Solid Sign hanging"), IconID("fas-sign-hanging"), IconUnicodeGlyph(0xf4d9)]
        SolidSignHanging = 1570,
        ///<summary>Solid signal</summary>
        ///<see href="https://fontawesome.com/icons/signal?style=solid"/>
        [Description("Solid signal"), IconID("fas-signal"), IconUnicodeGlyph(0xf012)]
        SolidSignal = 1571,
        ///<summary>Solid Signature</summary>
        ///<see href="https://fontawesome.com/icons/signature?style=solid"/>
        [Description("Solid Signature"), IconID("fas-signature"), IconUnicodeGlyph(0xf5b7)]
        SolidSignature = 1572,
        ///<summary>Solid Signs post</summary>
        ///<see href="https://fontawesome.com/icons/signs-post?style=solid"/>
        [Description("Solid Signs post"), IconID("fas-signs-post"), IconUnicodeGlyph(0xf277)]
        SolidSignsPost = 1573,
        ///<summary>Solid SIM Card</summary>
        ///<see href="https://fontawesome.com/icons/sim-card?style=solid"/>
        [Description("Solid SIM Card"), IconID("fas-sim-card"), IconUnicodeGlyph(0xf7c4)]
        SolidSimCard = 1574,
        ///<summary>Brands SimplyBuilt</summary>
        ///<see href="https://fontawesome.com/icons/simplybuilt?style=brands"/>
        [Description("Brands SimplyBuilt"), IconID("fab-simplybuilt"), IconUnicodeGlyph(0xf215)]
        BrandsSimplybuilt = 1575,
        ///<summary>Solid Sink</summary>
        ///<see href="https://fontawesome.com/icons/sink?style=solid"/>
        [Description("Solid Sink"), IconID("fas-sink"), IconUnicodeGlyph(0xe06d)]
        SolidSink = 1576,
        ///<summary>Brands SISTRIX</summary>
        ///<see href="https://fontawesome.com/icons/sistrix?style=brands"/>
        [Description("Brands SISTRIX"), IconID("fab-sistrix"), IconUnicodeGlyph(0xf3ee)]
        BrandsSistrix = 1577,
        ///<summary>Solid Sitemap</summary>
        ///<see href="https://fontawesome.com/icons/sitemap?style=solid"/>
        [Description("Solid Sitemap"), IconID("fas-sitemap"), IconUnicodeGlyph(0xf0e8)]
        SolidSitemap = 1578,
        ///<summary>Brands Sith</summary>
        ///<see href="https://fontawesome.com/icons/sith?style=brands"/>
        [Description("Brands Sith"), IconID("fab-sith"), IconUnicodeGlyph(0xf512)]
        BrandsSith = 1579,
        ///<summary>Brands Sitrox</summary>
        ///<see href="https://fontawesome.com/icons/sitrox?style=brands"/>
        [Description("Brands Sitrox"), IconID("fab-sitrox"), IconUnicodeGlyph(0xe44a)]
        BrandsSitrox = 1580,
        ///<summary>Brands Sketch</summary>
        ///<see href="https://fontawesome.com/icons/sketch?style=brands"/>
        [Description("Brands Sketch"), IconID("fab-sketch"), IconUnicodeGlyph(0xf7c6)]
        BrandsSketch = 1581,
        ///<summary>Solid Skull</summary>
        ///<see href="https://fontawesome.com/icons/skull?style=solid"/>
        [Description("Solid Skull"), IconID("fas-skull"), IconUnicodeGlyph(0xf54c)]
        SolidSkull = 1582,
        ///<summary>Solid Skull & Crossbones</summary>
        ///<see href="https://fontawesome.com/icons/skull-crossbones?style=solid"/>
        [Description("Solid Skull & Crossbones"), IconID("fas-skull-crossbones"), IconUnicodeGlyph(0xf714)]
        SolidSkullCrossbones = 1583,
        ///<summary>Brands skyatlas</summary>
        ///<see href="https://fontawesome.com/icons/skyatlas?style=brands"/>
        [Description("Brands skyatlas"), IconID("fab-skyatlas"), IconUnicodeGlyph(0xf216)]
        BrandsSkyatlas = 1584,
        ///<summary>Brands Skype</summary>
        ///<see href="https://fontawesome.com/icons/skype?style=brands"/>
        [Description("Brands Skype"), IconID("fab-skype"), IconUnicodeGlyph(0xf17e)]
        BrandsSkype = 1585,
        ///<summary>Brands Slack Logo</summary>
        ///<see href="https://fontawesome.com/icons/slack?style=brands"/>
        [Description("Brands Slack Logo"), IconID("fab-slack"), IconUnicodeGlyph(0xf198)]
        BrandsSlack = 1586,
        ///<summary>Solid Slash</summary>
        ///<see href="https://fontawesome.com/icons/slash?style=solid"/>
        [Description("Solid Slash"), IconID("fas-slash"), IconUnicodeGlyph(0xf715)]
        SolidSlash = 1587,
        ///<summary>Solid Sleigh</summary>
        ///<see href="https://fontawesome.com/icons/sleigh?style=solid"/>
        [Description("Solid Sleigh"), IconID("fas-sleigh"), IconUnicodeGlyph(0xf7cc)]
        SolidSleigh = 1588,
        ///<summary>Solid Sliders</summary>
        ///<see href="https://fontawesome.com/icons/sliders?style=solid"/>
        [Description("Solid Sliders"), IconID("fas-sliders"), IconUnicodeGlyph(0xf1de)]
        SolidSliders = 1589,
        ///<summary>Brands Slideshare</summary>
        ///<see href="https://fontawesome.com/icons/slideshare?style=brands"/>
        [Description("Brands Slideshare"), IconID("fab-slideshare"), IconUnicodeGlyph(0xf1e7)]
        BrandsSlideshare = 1590,
        ///<summary>Solid Smog</summary>
        ///<see href="https://fontawesome.com/icons/smog?style=solid"/>
        [Description("Solid Smog"), IconID("fas-smog"), IconUnicodeGlyph(0xf75f)]
        SolidSmog = 1591,
        ///<summary>Solid Smoking</summary>
        ///<see href="https://fontawesome.com/icons/smoking?style=solid"/>
        [Description("Solid Smoking"), IconID("fas-smoking"), IconUnicodeGlyph(0xf48d)]
        SolidSmoking = 1592,
        ///<summary>Brands Snapchat</summary>
        ///<see href="https://fontawesome.com/icons/snapchat?style=brands"/>
        [Description("Brands Snapchat"), IconID("fab-snapchat"), IconUnicodeGlyph(0xf2ab)]
        BrandsSnapchat = 1593,
        ///<summary>Solid Snowflake</summary>
        ///<see href="https://fontawesome.com/icons/snowflake?style=solid"/>
        [Description("Solid Snowflake"), IconID("fas-snowflake"), IconUnicodeGlyph(0xf2dc)]
        SolidSnowflake = 1594,
        ///<summary>Regular Snowflake</summary>
        ///<see href="https://fontawesome.com/icons/snowflake?style=regular"/>
        [Description("Regular Snowflake"), IconID("far-snowflake"), IconUnicodeGlyph(0xf2dc)]
        RegularSnowflake = 1595,
        ///<summary>Solid Snowman</summary>
        ///<see href="https://fontawesome.com/icons/snowman?style=solid"/>
        [Description("Solid Snowman"), IconID("fas-snowman"), IconUnicodeGlyph(0xf7d0)]
        SolidSnowman = 1596,
        ///<summary>Solid Snowplow</summary>
        ///<see href="https://fontawesome.com/icons/snowplow?style=solid"/>
        [Description("Solid Snowplow"), IconID("fas-snowplow"), IconUnicodeGlyph(0xf7d2)]
        SolidSnowplow = 1597,
        ///<summary>Solid Soap</summary>
        ///<see href="https://fontawesome.com/icons/soap?style=solid"/>
        [Description("Solid Soap"), IconID("fas-soap"), IconUnicodeGlyph(0xe06e)]
        SolidSoap = 1598,
        ///<summary>Solid Socks</summary>
        ///<see href="https://fontawesome.com/icons/socks?style=solid"/>
        [Description("Solid Socks"), IconID("fas-socks"), IconUnicodeGlyph(0xf696)]
        SolidSocks = 1599,
        ///<summary>Solid Solar Panel</summary>
        ///<see href="https://fontawesome.com/icons/solar-panel?style=solid"/>
        [Description("Solid Solar Panel"), IconID("fas-solar-panel"), IconUnicodeGlyph(0xf5ba)]
        SolidSolarPanel = 1600,
        ///<summary>Solid Sort</summary>
        ///<see href="https://fontawesome.com/icons/sort?style=solid"/>
        [Description("Solid Sort"), IconID("fas-sort"), IconUnicodeGlyph(0xf0dc)]
        SolidSort = 1601,
        ///<summary>Solid Sort Down (Descending)</summary>
        ///<see href="https://fontawesome.com/icons/sort-down?style=solid"/>
        [Description("Solid Sort Down (Descending)"), IconID("fas-sort-down"), IconUnicodeGlyph(0xf0dd)]
        SolidSortDown = 1602,
        ///<summary>Solid Sort Up (Ascending)</summary>
        ///<see href="https://fontawesome.com/icons/sort-up?style=solid"/>
        [Description("Solid Sort Up (Ascending)"), IconID("fas-sort-up"), IconUnicodeGlyph(0xf0de)]
        SolidSortUp = 1603,
        ///<summary>Brands SoundCloud</summary>
        ///<see href="https://fontawesome.com/icons/soundcloud?style=brands"/>
        [Description("Brands SoundCloud"), IconID("fab-soundcloud"), IconUnicodeGlyph(0xf1be)]
        BrandsSoundcloud = 1604,
        ///<summary>Brands Sourcetree</summary>
        ///<see href="https://fontawesome.com/icons/sourcetree?style=brands"/>
        [Description("Brands Sourcetree"), IconID("fab-sourcetree"), IconUnicodeGlyph(0xf7d3)]
        BrandsSourcetree = 1605,
        ///<summary>Solid Spa</summary>
        ///<see href="https://fontawesome.com/icons/spa?style=solid"/>
        [Description("Solid Spa"), IconID("fas-spa"), IconUnicodeGlyph(0xf5bb)]
        SolidSpa = 1606,
        ///<summary>Brands Space Awesome</summary>
        ///<see href="https://fontawesome.com/icons/space-awesome?style=brands"/>
        [Description("Brands Space Awesome"), IconID("fab-space-awesome"), IconUnicodeGlyph(0xe5ac)]
        BrandsSpaceAwesome = 1607,
        ///<summary>Solid Spaghetti monster flying</summary>
        ///<see href="https://fontawesome.com/icons/spaghetti-monster-flying?style=solid"/>
        [Description("Solid Spaghetti monster flying"), IconID("fas-spaghetti-monster-flying"), IconUnicodeGlyph(0xf67b)]
        SolidSpaghettiMonsterFlying = 1608,
        ///<summary>Brands Speakap</summary>
        ///<see href="https://fontawesome.com/icons/speakap?style=brands"/>
        [Description("Brands Speakap"), IconID("fab-speakap"), IconUnicodeGlyph(0xf3f3)]
        BrandsSpeakap = 1609,
        ///<summary>Brands Speaker Deck</summary>
        ///<see href="https://fontawesome.com/icons/speaker-deck?style=brands"/>
        [Description("Brands Speaker Deck"), IconID("fab-speaker-deck"), IconUnicodeGlyph(0xf83c)]
        BrandsSpeakerDeck = 1610,
        ///<summary>Solid Spell Check</summary>
        ///<see href="https://fontawesome.com/icons/spell-check?style=solid"/>
        [Description("Solid Spell Check"), IconID("fas-spell-check"), IconUnicodeGlyph(0xf891)]
        SolidSpellCheck = 1611,
        ///<summary>Solid Spider</summary>
        ///<see href="https://fontawesome.com/icons/spider?style=solid"/>
        [Description("Solid Spider"), IconID("fas-spider"), IconUnicodeGlyph(0xf717)]
        SolidSpider = 1612,
        ///<summary>Solid Spinner</summary>
        ///<see href="https://fontawesome.com/icons/spinner?style=solid"/>
        [Description("Solid Spinner"), IconID("fas-spinner"), IconUnicodeGlyph(0xf110)]
        SolidSpinner = 1613,
        ///<summary>Solid Splotch</summary>
        ///<see href="https://fontawesome.com/icons/splotch?style=solid"/>
        [Description("Solid Splotch"), IconID("fas-splotch"), IconUnicodeGlyph(0xf5bc)]
        SolidSplotch = 1614,
        ///<summary>Solid Spoon</summary>
        ///<see href="https://fontawesome.com/icons/spoon?style=solid"/>
        [Description("Solid Spoon"), IconID("fas-spoon"), IconUnicodeGlyph(0xf2e5)]
        SolidSpoon = 1615,
        ///<summary>Brands Spotify</summary>
        ///<see href="https://fontawesome.com/icons/spotify?style=brands"/>
        [Description("Brands Spotify"), IconID("fab-spotify"), IconUnicodeGlyph(0xf1bc)]
        BrandsSpotify = 1616,
        ///<summary>Solid Spray Can</summary>
        ///<see href="https://fontawesome.com/icons/spray-can?style=solid"/>
        [Description("Solid Spray Can"), IconID("fas-spray-can"), IconUnicodeGlyph(0xf5bd)]
        SolidSprayCan = 1617,
        ///<summary>Solid Spray Can Sparkles</summary>
        ///<see href="https://fontawesome.com/icons/spray-can-sparkles?style=solid"/>
        [Description("Solid Spray Can Sparkles"), IconID("fas-spray-can-sparkles"), IconUnicodeGlyph(0xf5d0)]
        SolidSprayCanSparkles = 1618,
        ///<summary>Solid Square</summary>
        ///<see href="https://fontawesome.com/icons/square?style=solid"/>
        [Description("Solid Square"), IconID("fas-square"), IconUnicodeGlyph(0xf0c8)]
        SolidSquare = 1619,
        ///<summary>Regular Square</summary>
        ///<see href="https://fontawesome.com/icons/square?style=regular"/>
        [Description("Regular Square"), IconID("far-square"), IconUnicodeGlyph(0xf0c8)]
        RegularSquare = 1620,
        ///<summary>Solid Square arrow up right</summary>
        ///<see href="https://fontawesome.com/icons/square-arrow-up-right?style=solid"/>
        [Description("Solid Square arrow up right"), IconID("fas-square-arrow-up-right"), IconUnicodeGlyph(0xf14c)]
        SolidSquareArrowUpRight = 1621,
        ///<summary>Brands Behance Square</summary>
        ///<see href="https://fontawesome.com/icons/square-behance?style=brands"/>
        [Description("Brands Behance Square"), IconID("fab-square-behance"), IconUnicodeGlyph(0xf1b5)]
        BrandsSquareBehance = 1622,
        ///<summary>Solid Square caret down</summary>
        ///<see href="https://fontawesome.com/icons/square-caret-down?style=solid"/>
        [Description("Solid Square caret down"), IconID("fas-square-caret-down"), IconUnicodeGlyph(0xf150)]
        SolidSquareCaretDown = 1623,
        ///<summary>Regular Square caret down</summary>
        ///<see href="https://fontawesome.com/icons/square-caret-down?style=regular"/>
        [Description("Regular Square caret down"), IconID("far-square-caret-down"), IconUnicodeGlyph(0xf150)]
        RegularSquareCaretDown = 1624,
        ///<summary>Solid Square caret left</summary>
        ///<see href="https://fontawesome.com/icons/square-caret-left?style=solid"/>
        [Description("Solid Square caret left"), IconID("fas-square-caret-left"), IconUnicodeGlyph(0xf191)]
        SolidSquareCaretLeft = 1625,
        ///<summary>Regular Square caret left</summary>
        ///<see href="https://fontawesome.com/icons/square-caret-left?style=regular"/>
        [Description("Regular Square caret left"), IconID("far-square-caret-left"), IconUnicodeGlyph(0xf191)]
        RegularSquareCaretLeft = 1626,
        ///<summary>Solid Square caret right</summary>
        ///<see href="https://fontawesome.com/icons/square-caret-right?style=solid"/>
        [Description("Solid Square caret right"), IconID("fas-square-caret-right"), IconUnicodeGlyph(0xf152)]
        SolidSquareCaretRight = 1627,
        ///<summary>Regular Square caret right</summary>
        ///<see href="https://fontawesome.com/icons/square-caret-right?style=regular"/>
        [Description("Regular Square caret right"), IconID("far-square-caret-right"), IconUnicodeGlyph(0xf152)]
        RegularSquareCaretRight = 1628,
        ///<summary>Solid Square caret up</summary>
        ///<see href="https://fontawesome.com/icons/square-caret-up?style=solid"/>
        [Description("Solid Square caret up"), IconID("fas-square-caret-up"), IconUnicodeGlyph(0xf151)]
        SolidSquareCaretUp = 1629,
        ///<summary>Regular Square caret up</summary>
        ///<see href="https://fontawesome.com/icons/square-caret-up?style=regular"/>
        [Description("Regular Square caret up"), IconID("far-square-caret-up"), IconUnicodeGlyph(0xf151)]
        RegularSquareCaretUp = 1630,
        ///<summary>Solid Square check</summary>
        ///<see href="https://fontawesome.com/icons/square-check?style=solid"/>
        [Description("Solid Square check"), IconID("fas-square-check"), IconUnicodeGlyph(0xf14a)]
        SolidSquareCheck = 1631,
        ///<summary>Regular Square check</summary>
        ///<see href="https://fontawesome.com/icons/square-check?style=regular"/>
        [Description("Regular Square check"), IconID("far-square-check"), IconUnicodeGlyph(0xf14a)]
        RegularSquareCheck = 1632,
        ///<summary>Brands Dribbble Square</summary>
        ///<see href="https://fontawesome.com/icons/square-dribbble?style=brands"/>
        [Description("Brands Dribbble Square"), IconID("fab-square-dribbble"), IconUnicodeGlyph(0xf397)]
        BrandsSquareDribbble = 1633,
        ///<summary>Solid Square envelope</summary>
        ///<see href="https://fontawesome.com/icons/square-envelope?style=solid"/>
        [Description("Solid Square envelope"), IconID("fas-square-envelope"), IconUnicodeGlyph(0xf199)]
        SolidSquareEnvelope = 1634,
        ///<summary>Brands Facebook Square</summary>
        ///<see href="https://fontawesome.com/icons/square-facebook?style=brands"/>
        [Description("Brands Facebook Square"), IconID("fab-square-facebook"), IconUnicodeGlyph(0xf082)]
        BrandsSquareFacebook = 1635,
        ///<summary>Brands Font Awesome in Square</summary>
        ///<see href="https://fontawesome.com/icons/square-font-awesome?style=brands"/>
        [Description("Brands Font Awesome in Square"), IconID("fab-square-font-awesome"), IconUnicodeGlyph(0xe5ad)]
        BrandsSquareFontAwesome = 1636,
        ///<summary>Brands Font Awesome in Square with Stroke Outline</summary>
        ///<see href="https://fontawesome.com/icons/square-font-awesome-stroke?style=brands"/>
        [Description("Brands Font Awesome in Square with Stroke Outline"), IconID("fab-square-font-awesome-stroke"), IconUnicodeGlyph(0xf35c)]
        BrandsSquareFontAwesomeStroke = 1637,
        ///<summary>Solid Square Full</summary>
        ///<see href="https://fontawesome.com/icons/square-full?style=solid"/>
        [Description("Solid Square Full"), IconID("fas-square-full"), IconUnicodeGlyph(0xf45c)]
        SolidSquareFull = 1638,
        ///<summary>Regular Square Full</summary>
        ///<see href="https://fontawesome.com/icons/square-full?style=regular"/>
        [Description("Regular Square Full"), IconID("far-square-full"), IconUnicodeGlyph(0xf45c)]
        RegularSquareFull = 1639,
        ///<summary>Brands Git Square</summary>
        ///<see href="https://fontawesome.com/icons/square-git?style=brands"/>
        [Description("Brands Git Square"), IconID("fab-square-git"), IconUnicodeGlyph(0xf1d2)]
        BrandsSquareGit = 1640,
        ///<summary>Brands GitHub Square</summary>
        ///<see href="https://fontawesome.com/icons/square-github?style=brands"/>
        [Description("Brands GitHub Square"), IconID("fab-square-github"), IconUnicodeGlyph(0xf092)]
        BrandsSquareGithub = 1641,
        ///<summary>Brands Square Gitlab</summary>
        ///<see href="https://fontawesome.com/icons/square-gitlab?style=brands"/>
        [Description("Brands Square Gitlab"), IconID("fab-square-gitlab"), IconUnicodeGlyph(0xe5ae)]
        BrandsSquareGitlab = 1642,
        ///<summary>Brands Google Plus Square</summary>
        ///<see href="https://fontawesome.com/icons/square-google-plus?style=brands"/>
        [Description("Brands Google Plus Square"), IconID("fab-square-google-plus"), IconUnicodeGlyph(0xf0d4)]
        BrandsSquareGooglePlus = 1643,
        ///<summary>Solid Square h</summary>
        ///<see href="https://fontawesome.com/icons/square-h?style=solid"/>
        [Description("Solid Square h"), IconID("fas-square-h"), IconUnicodeGlyph(0xf0fd)]
        SolidSquareH = 1644,
        ///<summary>Brands Hacker News Square</summary>
        ///<see href="https://fontawesome.com/icons/square-hacker-news?style=brands"/>
        [Description("Brands Hacker News Square"), IconID("fab-square-hacker-news"), IconUnicodeGlyph(0xf3af)]
        BrandsSquareHackerNews = 1645,
        ///<summary>Brands Instagram Square</summary>
        ///<see href="https://fontawesome.com/icons/square-instagram?style=brands"/>
        [Description("Brands Instagram Square"), IconID("fab-square-instagram"), IconUnicodeGlyph(0xe055)]
        BrandsSquareInstagram = 1646,
        ///<summary>Brands JavaScript (JS) Square</summary>
        ///<see href="https://fontawesome.com/icons/square-js?style=brands"/>
        [Description("Brands JavaScript (JS) Square"), IconID("fab-square-js"), IconUnicodeGlyph(0xf3b9)]
        BrandsSquareJs = 1647,
        ///<summary>Brands last.fm Square</summary>
        ///<see href="https://fontawesome.com/icons/square-lastfm?style=brands"/>
        [Description("Brands last.fm Square"), IconID("fab-square-lastfm"), IconUnicodeGlyph(0xf203)]
        BrandsSquareLastfm = 1648,
        ///<summary>Solid Square minus</summary>
        ///<see href="https://fontawesome.com/icons/square-minus?style=solid"/>
        [Description("Solid Square minus"), IconID("fas-square-minus"), IconUnicodeGlyph(0xf146)]
        SolidSquareMinus = 1649,
        ///<summary>Regular Square minus</summary>
        ///<see href="https://fontawesome.com/icons/square-minus?style=regular"/>
        [Description("Regular Square minus"), IconID("far-square-minus"), IconUnicodeGlyph(0xf146)]
        RegularSquareMinus = 1650,
        ///<summary>Solid Square Nfi</summary>
        ///<see href="https://fontawesome.com/icons/square-nfi?style=solid"/>
        [Description("Solid Square Nfi"), IconID("fas-square-nfi"), IconUnicodeGlyph(0xe576)]
        SolidSquareNfi = 1651,
        ///<summary>Brands Odnoklassniki Square</summary>
        ///<see href="https://fontawesome.com/icons/square-odnoklassniki?style=brands"/>
        [Description("Brands Odnoklassniki Square"), IconID("fab-square-odnoklassniki"), IconUnicodeGlyph(0xf264)]
        BrandsSquareOdnoklassniki = 1652,
        ///<summary>Solid Square parking</summary>
        ///<see href="https://fontawesome.com/icons/square-parking?style=solid"/>
        [Description("Solid Square parking"), IconID("fas-square-parking"), IconUnicodeGlyph(0xf540)]
        SolidSquareParking = 1653,
        ///<summary>Solid Square pen</summary>
        ///<see href="https://fontawesome.com/icons/square-pen?style=solid"/>
        [Description("Solid Square pen"), IconID("fas-square-pen"), IconUnicodeGlyph(0xf14b)]
        SolidSquarePen = 1654,
        ///<summary>Solid Square Person-confined</summary>
        ///<see href="https://fontawesome.com/icons/square-person-confined?style=solid"/>
        [Description("Solid Square Person-confined"), IconID("fas-square-person-confined"), IconUnicodeGlyph(0xe577)]
        SolidSquarePersonConfined = 1655,
        ///<summary>Solid Square phone</summary>
        ///<see href="https://fontawesome.com/icons/square-phone?style=solid"/>
        [Description("Solid Square phone"), IconID("fas-square-phone"), IconUnicodeGlyph(0xf098)]
        SolidSquarePhone = 1656,
        ///<summary>Solid Square phone flip</summary>
        ///<see href="https://fontawesome.com/icons/square-phone-flip?style=solid"/>
        [Description("Solid Square phone flip"), IconID("fas-square-phone-flip"), IconUnicodeGlyph(0xf87b)]
        SolidSquarePhoneFlip = 1657,
        ///<summary>Brands Pied Piper Square Logo (Old)</summary>
        ///<see href="https://fontawesome.com/icons/square-pied-piper?style=brands"/>
        [Description("Brands Pied Piper Square Logo (Old)"), IconID("fab-square-pied-piper"), IconUnicodeGlyph(0xe01e)]
        BrandsSquarePiedPiper = 1658,
        ///<summary>Brands Pinterest Square</summary>
        ///<see href="https://fontawesome.com/icons/square-pinterest?style=brands"/>
        [Description("Brands Pinterest Square"), IconID("fab-square-pinterest"), IconUnicodeGlyph(0xf0d3)]
        BrandsSquarePinterest = 1659,
        ///<summary>Solid Square plus</summary>
        ///<see href="https://fontawesome.com/icons/square-plus?style=solid"/>
        [Description("Solid Square plus"), IconID("fas-square-plus"), IconUnicodeGlyph(0xf0fe)]
        SolidSquarePlus = 1660,
        ///<summary>Regular Square plus</summary>
        ///<see href="https://fontawesome.com/icons/square-plus?style=regular"/>
        [Description("Regular Square plus"), IconID("far-square-plus"), IconUnicodeGlyph(0xf0fe)]
        RegularSquarePlus = 1661,
        ///<summary>Solid Square poll horizontal</summary>
        ///<see href="https://fontawesome.com/icons/square-poll-horizontal?style=solid"/>
        [Description("Solid Square poll horizontal"), IconID("fas-square-poll-horizontal"), IconUnicodeGlyph(0xf682)]
        SolidSquarePollHorizontal = 1662,
        ///<summary>Solid Square poll vertical</summary>
        ///<see href="https://fontawesome.com/icons/square-poll-vertical?style=solid"/>
        [Description("Solid Square poll vertical"), IconID("fas-square-poll-vertical"), IconUnicodeGlyph(0xf681)]
        SolidSquarePollVertical = 1663,
        ///<summary>Brands reddit Square</summary>
        ///<see href="https://fontawesome.com/icons/square-reddit?style=brands"/>
        [Description("Brands reddit Square"), IconID("fab-square-reddit"), IconUnicodeGlyph(0xf1a2)]
        BrandsSquareReddit = 1664,
        ///<summary>Solid Square root variable</summary>
        ///<see href="https://fontawesome.com/icons/square-root-variable?style=solid"/>
        [Description("Solid Square root variable"), IconID("fas-square-root-variable"), IconUnicodeGlyph(0xf698)]
        SolidSquareRootVariable = 1665,
        ///<summary>Solid Square rss</summary>
        ///<see href="https://fontawesome.com/icons/square-rss?style=solid"/>
        [Description("Solid Square rss"), IconID("fas-square-rss"), IconUnicodeGlyph(0xf143)]
        SolidSquareRss = 1666,
        ///<summary>Solid Square share nodes</summary>
        ///<see href="https://fontawesome.com/icons/square-share-nodes?style=solid"/>
        [Description("Solid Square share nodes"), IconID("fas-square-share-nodes"), IconUnicodeGlyph(0xf1e1)]
        SolidSquareShareNodes = 1667,
        ///<summary>Brands Snapchat Square</summary>
        ///<see href="https://fontawesome.com/icons/square-snapchat?style=brands"/>
        [Description("Brands Snapchat Square"), IconID("fab-square-snapchat"), IconUnicodeGlyph(0xf2ad)]
        BrandsSquareSnapchat = 1668,
        ///<summary>Brands Steam Square</summary>
        ///<see href="https://fontawesome.com/icons/square-steam?style=brands"/>
        [Description("Brands Steam Square"), IconID("fab-square-steam"), IconUnicodeGlyph(0xf1b7)]
        BrandsSquareSteam = 1669,
        ///<summary>Brands Tumblr Square</summary>
        ///<see href="https://fontawesome.com/icons/square-tumblr?style=brands"/>
        [Description("Brands Tumblr Square"), IconID("fab-square-tumblr"), IconUnicodeGlyph(0xf174)]
        BrandsSquareTumblr = 1670,
        ///<summary>Brands Twitter Square</summary>
        ///<see href="https://fontawesome.com/icons/square-twitter?style=brands"/>
        [Description("Brands Twitter Square"), IconID("fab-square-twitter"), IconUnicodeGlyph(0xf081)]
        BrandsSquareTwitter = 1671,
        ///<summary>Solid Square up right</summary>
        ///<see href="https://fontawesome.com/icons/square-up-right?style=solid"/>
        [Description("Solid Square up right"), IconID("fas-square-up-right"), IconUnicodeGlyph(0xf360)]
        SolidSquareUpRight = 1672,
        ///<summary>Brands Viadeo Square</summary>
        ///<see href="https://fontawesome.com/icons/square-viadeo?style=brands"/>
        [Description("Brands Viadeo Square"), IconID("fab-square-viadeo"), IconUnicodeGlyph(0xf2aa)]
        BrandsSquareViadeo = 1673,
        ///<summary>Brands Vimeo Square</summary>
        ///<see href="https://fontawesome.com/icons/square-vimeo?style=brands"/>
        [Description("Brands Vimeo Square"), IconID("fab-square-vimeo"), IconUnicodeGlyph(0xf194)]
        BrandsSquareVimeo = 1674,
        ///<summary>Solid Square Virus</summary>
        ///<see href="https://fontawesome.com/icons/square-virus?style=solid"/>
        [Description("Solid Square Virus"), IconID("fas-square-virus"), IconUnicodeGlyph(0xe578)]
        SolidSquareVirus = 1675,
        ///<summary>Brands What's App Square</summary>
        ///<see href="https://fontawesome.com/icons/square-whatsapp?style=brands"/>
        [Description("Brands What's App Square"), IconID("fab-square-whatsapp"), IconUnicodeGlyph(0xf40c)]
        BrandsSquareWhatsapp = 1676,
        ///<summary>Brands Xing Square</summary>
        ///<see href="https://fontawesome.com/icons/square-xing?style=brands"/>
        [Description("Brands Xing Square"), IconID("fab-square-xing"), IconUnicodeGlyph(0xf169)]
        BrandsSquareXing = 1677,
        ///<summary>Solid Square X Mark</summary>
        ///<see href="https://fontawesome.com/icons/square-xmark?style=solid"/>
        [Description("Solid Square X Mark"), IconID("fas-square-xmark"), IconUnicodeGlyph(0xf2d3)]
        SolidSquareXmark = 1678,
        ///<summary>Brands YouTube Square</summary>
        ///<see href="https://fontawesome.com/icons/square-youtube?style=brands"/>
        [Description("Brands YouTube Square"), IconID("fab-square-youtube"), IconUnicodeGlyph(0xf431)]
        BrandsSquareYoutube = 1679,
        ///<summary>Brands Squarespace</summary>
        ///<see href="https://fontawesome.com/icons/squarespace?style=brands"/>
        [Description("Brands Squarespace"), IconID("fab-squarespace"), IconUnicodeGlyph(0xf5be)]
        BrandsSquarespace = 1680,
        ///<summary>Brands Stack Exchange</summary>
        ///<see href="https://fontawesome.com/icons/stack-exchange?style=brands"/>
        [Description("Brands Stack Exchange"), IconID("fab-stack-exchange"), IconUnicodeGlyph(0xf18d)]
        BrandsStackExchange = 1681,
        ///<summary>Brands Stack Overflow</summary>
        ///<see href="https://fontawesome.com/icons/stack-overflow?style=brands"/>
        [Description("Brands Stack Overflow"), IconID("fab-stack-overflow"), IconUnicodeGlyph(0xf16c)]
        BrandsStackOverflow = 1682,
        ///<summary>Brands Stackpath</summary>
        ///<see href="https://fontawesome.com/icons/stackpath?style=brands"/>
        [Description("Brands Stackpath"), IconID("fab-stackpath"), IconUnicodeGlyph(0xf842)]
        BrandsStackpath = 1683,
        ///<summary>Solid Staff Aesculapius</summary>
        ///<see href="https://fontawesome.com/icons/staff-snake?style=solid"/>
        [Description("Solid Staff Aesculapius"), IconID("fas-staff-snake"), IconUnicodeGlyph(0xe579)]
        SolidStaffSnake = 1684,
        ///<summary>Solid Stairs</summary>
        ///<see href="https://fontawesome.com/icons/stairs?style=solid"/>
        [Description("Solid Stairs"), IconID("fas-stairs"), IconUnicodeGlyph(0xe289)]
        SolidStairs = 1685,
        ///<summary>Solid Stamp</summary>
        ///<see href="https://fontawesome.com/icons/stamp?style=solid"/>
        [Description("Solid Stamp"), IconID("fas-stamp"), IconUnicodeGlyph(0xf5bf)]
        SolidStamp = 1686,
        ///<summary>Solid Stapler</summary>
        ///<see href="https://fontawesome.com/icons/stapler?style=solid"/>
        [Description("Solid Stapler"), IconID("fas-stapler"), IconUnicodeGlyph(0xe5af)]
        SolidStapler = 1687,
        ///<summary>Solid Star</summary>
        ///<see href="https://fontawesome.com/icons/star?style=solid"/>
        [Description("Solid Star"), IconID("fas-star"), IconUnicodeGlyph(0xf005)]
        SolidStar = 1688,
        ///<summary>Regular Star</summary>
        ///<see href="https://fontawesome.com/icons/star?style=regular"/>
        [Description("Regular Star"), IconID("far-star"), IconUnicodeGlyph(0xf005)]
        RegularStar = 1689,
        ///<summary>Solid Star and Crescent</summary>
        ///<see href="https://fontawesome.com/icons/star-and-crescent?style=solid"/>
        [Description("Solid Star and Crescent"), IconID("fas-star-and-crescent"), IconUnicodeGlyph(0xf699)]
        SolidStarAndCrescent = 1690,
        ///<summary>Solid star-half</summary>
        ///<see href="https://fontawesome.com/icons/star-half?style=solid"/>
        [Description("Solid star-half"), IconID("fas-star-half"), IconUnicodeGlyph(0xf089)]
        SolidStarHalf = 1691,
        ///<summary>Regular star-half</summary>
        ///<see href="https://fontawesome.com/icons/star-half?style=regular"/>
        [Description("Regular star-half"), IconID("far-star-half"), IconUnicodeGlyph(0xf089)]
        RegularStarHalf = 1692,
        ///<summary>Solid Star half stroke</summary>
        ///<see href="https://fontawesome.com/icons/star-half-stroke?style=solid"/>
        [Description("Solid Star half stroke"), IconID("fas-star-half-stroke"), IconUnicodeGlyph(0xf5c0)]
        SolidStarHalfStroke = 1693,
        ///<summary>Regular Star half stroke</summary>
        ///<see href="https://fontawesome.com/icons/star-half-stroke?style=regular"/>
        [Description("Regular Star half stroke"), IconID("far-star-half-stroke"), IconUnicodeGlyph(0xf5c0)]
        RegularStarHalfStroke = 1694,
        ///<summary>Solid Star of David</summary>
        ///<see href="https://fontawesome.com/icons/star-of-david?style=solid"/>
        [Description("Solid Star of David"), IconID("fas-star-of-david"), IconUnicodeGlyph(0xf69a)]
        SolidStarOfDavid = 1695,
        ///<summary>Solid Star of Life</summary>
        ///<see href="https://fontawesome.com/icons/star-of-life?style=solid"/>
        [Description("Solid Star of Life"), IconID("fas-star-of-life"), IconUnicodeGlyph(0xf621)]
        SolidStarOfLife = 1696,
        ///<summary>Brands StayLinked</summary>
        ///<see href="https://fontawesome.com/icons/staylinked?style=brands"/>
        [Description("Brands StayLinked"), IconID("fab-staylinked"), IconUnicodeGlyph(0xf3f5)]
        BrandsStaylinked = 1697,
        ///<summary>Brands Steam</summary>
        ///<see href="https://fontawesome.com/icons/steam?style=brands"/>
        [Description("Brands Steam"), IconID("fab-steam"), IconUnicodeGlyph(0xf1b6)]
        BrandsSteam = 1698,
        ///<summary>Brands Steam Symbol</summary>
        ///<see href="https://fontawesome.com/icons/steam-symbol?style=brands"/>
        [Description("Brands Steam Symbol"), IconID("fab-steam-symbol"), IconUnicodeGlyph(0xf3f6)]
        BrandsSteamSymbol = 1699,
        ///<summary>Solid Sterling sign</summary>
        ///<see href="https://fontawesome.com/icons/sterling-sign?style=solid"/>
        [Description("Solid Sterling sign"), IconID("fas-sterling-sign"), IconUnicodeGlyph(0xf154)]
        SolidSterlingSign = 1700,
        ///<summary>Solid Stethoscope</summary>
        ///<see href="https://fontawesome.com/icons/stethoscope?style=solid"/>
        [Description("Solid Stethoscope"), IconID("fas-stethoscope"), IconUnicodeGlyph(0xf0f1)]
        SolidStethoscope = 1701,
        ///<summary>Brands Sticker Mule</summary>
        ///<see href="https://fontawesome.com/icons/sticker-mule?style=brands"/>
        [Description("Brands Sticker Mule"), IconID("fab-sticker-mule"), IconUnicodeGlyph(0xf3f7)]
        BrandsStickerMule = 1702,
        ///<summary>Solid stop</summary>
        ///<see href="https://fontawesome.com/icons/stop?style=solid"/>
        [Description("Solid stop"), IconID("fas-stop"), IconUnicodeGlyph(0xf04d)]
        SolidStop = 1703,
        ///<summary>Solid Stopwatch</summary>
        ///<see href="https://fontawesome.com/icons/stopwatch?style=solid"/>
        [Description("Solid Stopwatch"), IconID("fas-stopwatch"), IconUnicodeGlyph(0xf2f2)]
        SolidStopwatch = 1704,
        ///<summary>Solid Stopwatch 20</summary>
        ///<see href="https://fontawesome.com/icons/stopwatch-20?style=solid"/>
        [Description("Solid Stopwatch 20"), IconID("fas-stopwatch-20"), IconUnicodeGlyph(0xe06f)]
        SolidStopwatch20 = 1705,
        ///<summary>Solid Store</summary>
        ///<see href="https://fontawesome.com/icons/store?style=solid"/>
        [Description("Solid Store"), IconID("fas-store"), IconUnicodeGlyph(0xf54e)]
        SolidStore = 1706,
        ///<summary>Solid Store Slash</summary>
        ///<see href="https://fontawesome.com/icons/store-slash?style=solid"/>
        [Description("Solid Store Slash"), IconID("fas-store-slash"), IconUnicodeGlyph(0xe071)]
        SolidStoreSlash = 1707,
        ///<summary>Brands Strava</summary>
        ///<see href="https://fontawesome.com/icons/strava?style=brands"/>
        [Description("Brands Strava"), IconID("fab-strava"), IconUnicodeGlyph(0xf428)]
        BrandsStrava = 1708,
        ///<summary>Solid Street View</summary>
        ///<see href="https://fontawesome.com/icons/street-view?style=solid"/>
        [Description("Solid Street View"), IconID("fas-street-view"), IconUnicodeGlyph(0xf21d)]
        SolidStreetView = 1709,
        ///<summary>Solid Strikethrough</summary>
        ///<see href="https://fontawesome.com/icons/strikethrough?style=solid"/>
        [Description("Solid Strikethrough"), IconID("fas-strikethrough"), IconUnicodeGlyph(0xf0cc)]
        SolidStrikethrough = 1710,
        ///<summary>Brands Stripe</summary>
        ///<see href="https://fontawesome.com/icons/stripe?style=brands"/>
        [Description("Brands Stripe"), IconID("fab-stripe"), IconUnicodeGlyph(0xf429)]
        BrandsStripe = 1711,
        ///<summary>Brands Stripe S</summary>
        ///<see href="https://fontawesome.com/icons/stripe-s?style=brands"/>
        [Description("Brands Stripe S"), IconID("fab-stripe-s"), IconUnicodeGlyph(0xf42a)]
        BrandsStripeS = 1712,
        ///<summary>Solid Stroopwafel</summary>
        ///<see href="https://fontawesome.com/icons/stroopwafel?style=solid"/>
        [Description("Solid Stroopwafel"), IconID("fas-stroopwafel"), IconUnicodeGlyph(0xf551)]
        SolidStroopwafel = 1713,
        ///<summary>Brands Studio Vinari</summary>
        ///<see href="https://fontawesome.com/icons/studiovinari?style=brands"/>
        [Description("Brands Studio Vinari"), IconID("fab-studiovinari"), IconUnicodeGlyph(0xf3f8)]
        BrandsStudiovinari = 1714,
        ///<summary>Brands StumbleUpon Logo</summary>
        ///<see href="https://fontawesome.com/icons/stumbleupon?style=brands"/>
        [Description("Brands StumbleUpon Logo"), IconID("fab-stumbleupon"), IconUnicodeGlyph(0xf1a4)]
        BrandsStumbleupon = 1715,
        ///<summary>Brands StumbleUpon Circle</summary>
        ///<see href="https://fontawesome.com/icons/stumbleupon-circle?style=brands"/>
        [Description("Brands StumbleUpon Circle"), IconID("fab-stumbleupon-circle"), IconUnicodeGlyph(0xf1a3)]
        BrandsStumbleuponCircle = 1716,
        ///<summary>Solid subscript</summary>
        ///<see href="https://fontawesome.com/icons/subscript?style=solid"/>
        [Description("Solid subscript"), IconID("fas-subscript"), IconUnicodeGlyph(0xf12c)]
        SolidSubscript = 1717,
        ///<summary>Solid Suitcase</summary>
        ///<see href="https://fontawesome.com/icons/suitcase?style=solid"/>
        [Description("Solid Suitcase"), IconID("fas-suitcase"), IconUnicodeGlyph(0xf0f2)]
        SolidSuitcase = 1718,
        ///<summary>Solid Suitcase medical</summary>
        ///<see href="https://fontawesome.com/icons/suitcase-medical?style=solid"/>
        [Description("Solid Suitcase medical"), IconID("fas-suitcase-medical"), IconUnicodeGlyph(0xf0fa)]
        SolidSuitcaseMedical = 1719,
        ///<summary>Solid Suitcase Rolling</summary>
        ///<see href="https://fontawesome.com/icons/suitcase-rolling?style=solid"/>
        [Description("Solid Suitcase Rolling"), IconID("fas-suitcase-rolling"), IconUnicodeGlyph(0xf5c1)]
        SolidSuitcaseRolling = 1720,
        ///<summary>Solid Sun</summary>
        ///<see href="https://fontawesome.com/icons/sun?style=solid"/>
        [Description("Solid Sun"), IconID("fas-sun"), IconUnicodeGlyph(0xf185)]
        SolidSun = 1721,
        ///<summary>Regular Sun</summary>
        ///<see href="https://fontawesome.com/icons/sun?style=regular"/>
        [Description("Regular Sun"), IconID("far-sun"), IconUnicodeGlyph(0xf185)]
        RegularSun = 1722,
        ///<summary>Solid Sun Plant-wilt</summary>
        ///<see href="https://fontawesome.com/icons/sun-plant-wilt?style=solid"/>
        [Description("Solid Sun Plant-wilt"), IconID("fas-sun-plant-wilt"), IconUnicodeGlyph(0xe57a)]
        SolidSunPlantWilt = 1723,
        ///<summary>Brands Superpowers</summary>
        ///<see href="https://fontawesome.com/icons/superpowers?style=brands"/>
        [Description("Brands Superpowers"), IconID("fab-superpowers"), IconUnicodeGlyph(0xf2dd)]
        BrandsSuperpowers = 1724,
        ///<summary>Solid superscript</summary>
        ///<see href="https://fontawesome.com/icons/superscript?style=solid"/>
        [Description("Solid superscript"), IconID("fas-superscript"), IconUnicodeGlyph(0xf12b)]
        SolidSuperscript = 1725,
        ///<summary>Brands Supple</summary>
        ///<see href="https://fontawesome.com/icons/supple?style=brands"/>
        [Description("Brands Supple"), IconID("fab-supple"), IconUnicodeGlyph(0xf3f9)]
        BrandsSupple = 1726,
        ///<summary>Brands Suse</summary>
        ///<see href="https://fontawesome.com/icons/suse?style=brands"/>
        [Description("Brands Suse"), IconID("fab-suse"), IconUnicodeGlyph(0xf7d6)]
        BrandsSuse = 1727,
        ///<summary>Solid Swatchbook</summary>
        ///<see href="https://fontawesome.com/icons/swatchbook?style=solid"/>
        [Description("Solid Swatchbook"), IconID("fas-swatchbook"), IconUnicodeGlyph(0xf5c3)]
        SolidSwatchbook = 1728,
        ///<summary>Brands Swift</summary>
        ///<see href="https://fontawesome.com/icons/swift?style=brands"/>
        [Description("Brands Swift"), IconID("fab-swift"), IconUnicodeGlyph(0xf8e1)]
        BrandsSwift = 1729,
        ///<summary>Brands Symfony</summary>
        ///<see href="https://fontawesome.com/icons/symfony?style=brands"/>
        [Description("Brands Symfony"), IconID("fab-symfony"), IconUnicodeGlyph(0xf83d)]
        BrandsSymfony = 1730,
        ///<summary>Solid Synagogue</summary>
        ///<see href="https://fontawesome.com/icons/synagogue?style=solid"/>
        [Description("Solid Synagogue"), IconID("fas-synagogue"), IconUnicodeGlyph(0xf69b)]
        SolidSynagogue = 1731,
        ///<summary>Solid Syringe</summary>
        ///<see href="https://fontawesome.com/icons/syringe?style=solid"/>
        [Description("Solid Syringe"), IconID("fas-syringe"), IconUnicodeGlyph(0xf48e)]
        SolidSyringe = 1732,
        ///<summary>Solid T</summary>
        ///<see href="https://fontawesome.com/icons/t?style=solid"/>
        [Description("Solid T"), IconID("fas-t"), IconUnicodeGlyph(0x54)]
        SolidT = 1733,
        ///<summary>Solid table</summary>
        ///<see href="https://fontawesome.com/icons/table?style=solid"/>
        [Description("Solid table"), IconID("fas-table"), IconUnicodeGlyph(0xf0ce)]
        SolidTable = 1734,
        ///<summary>Solid Table cells</summary>
        ///<see href="https://fontawesome.com/icons/table-cells?style=solid"/>
        [Description("Solid Table cells"), IconID("fas-table-cells"), IconUnicodeGlyph(0xf00a)]
        SolidTableCells = 1735,
        ///<summary>Solid Table cells large</summary>
        ///<see href="https://fontawesome.com/icons/table-cells-large?style=solid"/>
        [Description("Solid Table cells large"), IconID("fas-table-cells-large"), IconUnicodeGlyph(0xf009)]
        SolidTableCellsLarge = 1736,
        ///<summary>Solid Table columns</summary>
        ///<see href="https://fontawesome.com/icons/table-columns?style=solid"/>
        [Description("Solid Table columns"), IconID("fas-table-columns"), IconUnicodeGlyph(0xf0db)]
        SolidTableColumns = 1737,
        ///<summary>Solid Table list</summary>
        ///<see href="https://fontawesome.com/icons/table-list?style=solid"/>
        [Description("Solid Table list"), IconID("fas-table-list"), IconUnicodeGlyph(0xf00b)]
        SolidTableList = 1738,
        ///<summary>Solid Table tennis paddle ball</summary>
        ///<see href="https://fontawesome.com/icons/table-tennis-paddle-ball?style=solid"/>
        [Description("Solid Table tennis paddle ball"), IconID("fas-table-tennis-paddle-ball"), IconUnicodeGlyph(0xf45d)]
        SolidTableTennisPaddleBall = 1739,
        ///<summary>Solid Tablet</summary>
        ///<see href="https://fontawesome.com/icons/tablet?style=solid"/>
        [Description("Solid Tablet"), IconID("fas-tablet"), IconUnicodeGlyph(0xf3fb)]
        SolidTablet = 1740,
        ///<summary>Solid Tablet button</summary>
        ///<see href="https://fontawesome.com/icons/tablet-button?style=solid"/>
        [Description("Solid Tablet button"), IconID("fas-tablet-button"), IconUnicodeGlyph(0xf10a)]
        SolidTabletButton = 1741,
        ///<summary>Solid Tablet screen button</summary>
        ///<see href="https://fontawesome.com/icons/tablet-screen-button?style=solid"/>
        [Description("Solid Tablet screen button"), IconID("fas-tablet-screen-button"), IconUnicodeGlyph(0xf3fa)]
        SolidTabletScreenButton = 1742,
        ///<summary>Solid Tablets</summary>
        ///<see href="https://fontawesome.com/icons/tablets?style=solid"/>
        [Description("Solid Tablets"), IconID("fas-tablets"), IconUnicodeGlyph(0xf490)]
        SolidTablets = 1743,
        ///<summary>Solid Tachograph digital</summary>
        ///<see href="https://fontawesome.com/icons/tachograph-digital?style=solid"/>
        [Description("Solid Tachograph digital"), IconID("fas-tachograph-digital"), IconUnicodeGlyph(0xf566)]
        SolidTachographDigital = 1744,
        ///<summary>Solid tag</summary>
        ///<see href="https://fontawesome.com/icons/tag?style=solid"/>
        [Description("Solid tag"), IconID("fas-tag"), IconUnicodeGlyph(0xf02b)]
        SolidTag = 1745,
        ///<summary>Solid tags</summary>
        ///<see href="https://fontawesome.com/icons/tags?style=solid"/>
        [Description("Solid tags"), IconID("fas-tags"), IconUnicodeGlyph(0xf02c)]
        SolidTags = 1746,
        ///<summary>Solid Tape</summary>
        ///<see href="https://fontawesome.com/icons/tape?style=solid"/>
        [Description("Solid Tape"), IconID("fas-tape"), IconUnicodeGlyph(0xf4db)]
        SolidTape = 1747,
        ///<summary>Solid Tarp</summary>
        ///<see href="https://fontawesome.com/icons/tarp?style=solid"/>
        [Description("Solid Tarp"), IconID("fas-tarp"), IconUnicodeGlyph(0xe57b)]
        SolidTarp = 1748,
        ///<summary>Solid Tarp Droplet</summary>
        ///<see href="https://fontawesome.com/icons/tarp-droplet?style=solid"/>
        [Description("Solid Tarp Droplet"), IconID("fas-tarp-droplet"), IconUnicodeGlyph(0xe57c)]
        SolidTarpDroplet = 1749,
        ///<summary>Solid Taxi</summary>
        ///<see href="https://fontawesome.com/icons/taxi?style=solid"/>
        [Description("Solid Taxi"), IconID("fas-taxi"), IconUnicodeGlyph(0xf1ba)]
        SolidTaxi = 1750,
        ///<summary>Brands TeamSpeak</summary>
        ///<see href="https://fontawesome.com/icons/teamspeak?style=brands"/>
        [Description("Brands TeamSpeak"), IconID("fab-teamspeak"), IconUnicodeGlyph(0xf4f9)]
        BrandsTeamspeak = 1751,
        ///<summary>Solid Teeth</summary>
        ///<see href="https://fontawesome.com/icons/teeth?style=solid"/>
        [Description("Solid Teeth"), IconID("fas-teeth"), IconUnicodeGlyph(0xf62e)]
        SolidTeeth = 1752,
        ///<summary>Solid Teeth Open</summary>
        ///<see href="https://fontawesome.com/icons/teeth-open?style=solid"/>
        [Description("Solid Teeth Open"), IconID("fas-teeth-open"), IconUnicodeGlyph(0xf62f)]
        SolidTeethOpen = 1753,
        ///<summary>Brands Telegram</summary>
        ///<see href="https://fontawesome.com/icons/telegram?style=brands"/>
        [Description("Brands Telegram"), IconID("fab-telegram"), IconUnicodeGlyph(0xf2c6)]
        BrandsTelegram = 1754,
        ///<summary>Solid Temperature arrow down</summary>
        ///<see href="https://fontawesome.com/icons/temperature-arrow-down?style=solid"/>
        [Description("Solid Temperature arrow down"), IconID("fas-temperature-arrow-down"), IconUnicodeGlyph(0xe03f)]
        SolidTemperatureArrowDown = 1755,
        ///<summary>Solid Temperature arrow up</summary>
        ///<see href="https://fontawesome.com/icons/temperature-arrow-up?style=solid"/>
        [Description("Solid Temperature arrow up"), IconID("fas-temperature-arrow-up"), IconUnicodeGlyph(0xe040)]
        SolidTemperatureArrowUp = 1756,
        ///<summary>Solid Temperature empty</summary>
        ///<see href="https://fontawesome.com/icons/temperature-empty?style=solid"/>
        [Description("Solid Temperature empty"), IconID("fas-temperature-empty"), IconUnicodeGlyph(0xf2cb)]
        SolidTemperatureEmpty = 1757,
        ///<summary>Solid Temperature full</summary>
        ///<see href="https://fontawesome.com/icons/temperature-full?style=solid"/>
        [Description("Solid Temperature full"), IconID("fas-temperature-full"), IconUnicodeGlyph(0xf2c7)]
        SolidTemperatureFull = 1758,
        ///<summary>Solid Temperature half</summary>
        ///<see href="https://fontawesome.com/icons/temperature-half?style=solid"/>
        [Description("Solid Temperature half"), IconID("fas-temperature-half"), IconUnicodeGlyph(0xf2c9)]
        SolidTemperatureHalf = 1759,
        ///<summary>Solid High Temperature</summary>
        ///<see href="https://fontawesome.com/icons/temperature-high?style=solid"/>
        [Description("Solid High Temperature"), IconID("fas-temperature-high"), IconUnicodeGlyph(0xf769)]
        SolidTemperatureHigh = 1760,
        ///<summary>Solid Low Temperature</summary>
        ///<see href="https://fontawesome.com/icons/temperature-low?style=solid"/>
        [Description("Solid Low Temperature"), IconID("fas-temperature-low"), IconUnicodeGlyph(0xf76b)]
        SolidTemperatureLow = 1761,
        ///<summary>Solid Temperature quarter</summary>
        ///<see href="https://fontawesome.com/icons/temperature-quarter?style=solid"/>
        [Description("Solid Temperature quarter"), IconID("fas-temperature-quarter"), IconUnicodeGlyph(0xf2ca)]
        SolidTemperatureQuarter = 1762,
        ///<summary>Solid Temperature three quarters</summary>
        ///<see href="https://fontawesome.com/icons/temperature-three-quarters?style=solid"/>
        [Description("Solid Temperature three quarters"), IconID("fas-temperature-three-quarters"), IconUnicodeGlyph(0xf2c8)]
        SolidTemperatureThreeQuarters = 1763,
        ///<summary>Brands Tencent Weibo</summary>
        ///<see href="https://fontawesome.com/icons/tencent-weibo?style=brands"/>
        [Description("Brands Tencent Weibo"), IconID("fab-tencent-weibo"), IconUnicodeGlyph(0xf1d5)]
        BrandsTencentWeibo = 1764,
        ///<summary>Solid Tenge sign</summary>
        ///<see href="https://fontawesome.com/icons/tenge-sign?style=solid"/>
        [Description("Solid Tenge sign"), IconID("fas-tenge-sign"), IconUnicodeGlyph(0xf7d7)]
        SolidTengeSign = 1765,
        ///<summary>Solid Tent</summary>
        ///<see href="https://fontawesome.com/icons/tent?style=solid"/>
        [Description("Solid Tent"), IconID("fas-tent"), IconUnicodeGlyph(0xe57d)]
        SolidTent = 1766,
        ///<summary>Solid Tent Arrow-down-to-line</summary>
        ///<see href="https://fontawesome.com/icons/tent-arrow-down-to-line?style=solid"/>
        [Description("Solid Tent Arrow-down-to-line"), IconID("fas-tent-arrow-down-to-line"), IconUnicodeGlyph(0xe57e)]
        SolidTentArrowDownToLine = 1767,
        ///<summary>Solid Tent Arrow-left-right</summary>
        ///<see href="https://fontawesome.com/icons/tent-arrow-left-right?style=solid"/>
        [Description("Solid Tent Arrow-left-right"), IconID("fas-tent-arrow-left-right"), IconUnicodeGlyph(0xe57f)]
        SolidTentArrowLeftRight = 1768,
        ///<summary>Solid Tent Arrow-turn-left</summary>
        ///<see href="https://fontawesome.com/icons/tent-arrow-turn-left?style=solid"/>
        [Description("Solid Tent Arrow-turn-left"), IconID("fas-tent-arrow-turn-left"), IconUnicodeGlyph(0xe580)]
        SolidTentArrowTurnLeft = 1769,
        ///<summary>Solid Tent Arrows-down</summary>
        ///<see href="https://fontawesome.com/icons/tent-arrows-down?style=solid"/>
        [Description("Solid Tent Arrows-down"), IconID("fas-tent-arrows-down"), IconUnicodeGlyph(0xe581)]
        SolidTentArrowsDown = 1770,
        ///<summary>Solid Tents</summary>
        ///<see href="https://fontawesome.com/icons/tents?style=solid"/>
        [Description("Solid Tents"), IconID("fas-tents"), IconUnicodeGlyph(0xe582)]
        SolidTents = 1771,
        ///<summary>Solid Terminal</summary>
        ///<see href="https://fontawesome.com/icons/terminal?style=solid"/>
        [Description("Solid Terminal"), IconID("fas-terminal"), IconUnicodeGlyph(0xf120)]
        SolidTerminal = 1772,
        ///<summary>Solid text-height</summary>
        ///<see href="https://fontawesome.com/icons/text-height?style=solid"/>
        [Description("Solid text-height"), IconID("fas-text-height"), IconUnicodeGlyph(0xf034)]
        SolidTextHeight = 1773,
        ///<summary>Solid Text slash</summary>
        ///<see href="https://fontawesome.com/icons/text-slash?style=solid"/>
        [Description("Solid Text slash"), IconID("fas-text-slash"), IconUnicodeGlyph(0xf87d)]
        SolidTextSlash = 1774,
        ///<summary>Solid Text Width</summary>
        ///<see href="https://fontawesome.com/icons/text-width?style=solid"/>
        [Description("Solid Text Width"), IconID("fas-text-width"), IconUnicodeGlyph(0xf035)]
        SolidTextWidth = 1775,
        ///<summary>Brands The Red Yeti</summary>
        ///<see href="https://fontawesome.com/icons/the-red-yeti?style=brands"/>
        [Description("Brands The Red Yeti"), IconID("fab-the-red-yeti"), IconUnicodeGlyph(0xf69d)]
        BrandsTheRedYeti = 1776,
        ///<summary>Brands Themeco</summary>
        ///<see href="https://fontawesome.com/icons/themeco?style=brands"/>
        [Description("Brands Themeco"), IconID("fab-themeco"), IconUnicodeGlyph(0xf5c6)]
        BrandsThemeco = 1777,
        ///<summary>Brands ThemeIsle</summary>
        ///<see href="https://fontawesome.com/icons/themeisle?style=brands"/>
        [Description("Brands ThemeIsle"), IconID("fab-themeisle"), IconUnicodeGlyph(0xf2b2)]
        BrandsThemeisle = 1778,
        ///<summary>Solid Thermometer</summary>
        ///<see href="https://fontawesome.com/icons/thermometer?style=solid"/>
        [Description("Solid Thermometer"), IconID("fas-thermometer"), IconUnicodeGlyph(0xf491)]
        SolidThermometer = 1779,
        ///<summary>Brands Think Peaks</summary>
        ///<see href="https://fontawesome.com/icons/think-peaks?style=brands"/>
        [Description("Brands Think Peaks"), IconID("fab-think-peaks"), IconUnicodeGlyph(0xf731)]
        BrandsThinkPeaks = 1780,
        ///<summary>Solid thumbs-down</summary>
        ///<see href="https://fontawesome.com/icons/thumbs-down?style=solid"/>
        [Description("Solid thumbs-down"), IconID("fas-thumbs-down"), IconUnicodeGlyph(0xf165)]
        SolidThumbsDown = 1781,
        ///<summary>Regular thumbs-down</summary>
        ///<see href="https://fontawesome.com/icons/thumbs-down?style=regular"/>
        [Description("Regular thumbs-down"), IconID("far-thumbs-down"), IconUnicodeGlyph(0xf165)]
        RegularThumbsDown = 1782,
        ///<summary>Solid thumbs-up</summary>
        ///<see href="https://fontawesome.com/icons/thumbs-up?style=solid"/>
        [Description("Solid thumbs-up"), IconID("fas-thumbs-up"), IconUnicodeGlyph(0xf164)]
        SolidThumbsUp = 1783,
        ///<summary>Regular thumbs-up</summary>
        ///<see href="https://fontawesome.com/icons/thumbs-up?style=regular"/>
        [Description("Regular thumbs-up"), IconID("far-thumbs-up"), IconUnicodeGlyph(0xf164)]
        RegularThumbsUp = 1784,
        ///<summary>Solid Thumbtack</summary>
        ///<see href="https://fontawesome.com/icons/thumbtack?style=solid"/>
        [Description("Solid Thumbtack"), IconID("fas-thumbtack"), IconUnicodeGlyph(0xf08d)]
        SolidThumbtack = 1785,
        ///<summary>Solid Ticket</summary>
        ///<see href="https://fontawesome.com/icons/ticket?style=solid"/>
        [Description("Solid Ticket"), IconID("fas-ticket"), IconUnicodeGlyph(0xf145)]
        SolidTicket = 1786,
        ///<summary>Solid Ticket simple</summary>
        ///<see href="https://fontawesome.com/icons/ticket-simple?style=solid"/>
        [Description("Solid Ticket simple"), IconID("fas-ticket-simple"), IconUnicodeGlyph(0xf3ff)]
        SolidTicketSimple = 1787,
        ///<summary>Brands TikTok</summary>
        ///<see href="https://fontawesome.com/icons/tiktok?style=brands"/>
        [Description("Brands TikTok"), IconID("fab-tiktok"), IconUnicodeGlyph(0xe07b)]
        BrandsTiktok = 1788,
        ///<summary>Solid Timeline</summary>
        ///<see href="https://fontawesome.com/icons/timeline?style=solid"/>
        [Description("Solid Timeline"), IconID("fas-timeline"), IconUnicodeGlyph(0xe29c)]
        SolidTimeline = 1789,
        ///<summary>Solid Toggle Off</summary>
        ///<see href="https://fontawesome.com/icons/toggle-off?style=solid"/>
        [Description("Solid Toggle Off"), IconID("fas-toggle-off"), IconUnicodeGlyph(0xf204)]
        SolidToggleOff = 1790,
        ///<summary>Solid Toggle On</summary>
        ///<see href="https://fontawesome.com/icons/toggle-on?style=solid"/>
        [Description("Solid Toggle On"), IconID("fas-toggle-on"), IconUnicodeGlyph(0xf205)]
        SolidToggleOn = 1791,
        ///<summary>Solid Toilet</summary>
        ///<see href="https://fontawesome.com/icons/toilet?style=solid"/>
        [Description("Solid Toilet"), IconID("fas-toilet"), IconUnicodeGlyph(0xf7d8)]
        SolidToilet = 1792,
        ///<summary>Solid Toilet Paper</summary>
        ///<see href="https://fontawesome.com/icons/toilet-paper?style=solid"/>
        [Description("Solid Toilet Paper"), IconID("fas-toilet-paper"), IconUnicodeGlyph(0xf71e)]
        SolidToiletPaper = 1793,
        ///<summary>Solid Toilet Paper Slash</summary>
        ///<see href="https://fontawesome.com/icons/toilet-paper-slash?style=solid"/>
        [Description("Solid Toilet Paper Slash"), IconID("fas-toilet-paper-slash"), IconUnicodeGlyph(0xe072)]
        SolidToiletPaperSlash = 1794,
        ///<summary>Solid Toilet Portable</summary>
        ///<see href="https://fontawesome.com/icons/toilet-portable?style=solid"/>
        [Description("Solid Toilet Portable"), IconID("fas-toilet-portable"), IconUnicodeGlyph(0xe583)]
        SolidToiletPortable = 1795,
        ///<summary>Solid Toilets Portable</summary>
        ///<see href="https://fontawesome.com/icons/toilets-portable?style=solid"/>
        [Description("Solid Toilets Portable"), IconID("fas-toilets-portable"), IconUnicodeGlyph(0xe584)]
        SolidToiletsPortable = 1796,
        ///<summary>Solid Toolbox</summary>
        ///<see href="https://fontawesome.com/icons/toolbox?style=solid"/>
        [Description("Solid Toolbox"), IconID("fas-toolbox"), IconUnicodeGlyph(0xf552)]
        SolidToolbox = 1797,
        ///<summary>Solid Tooth</summary>
        ///<see href="https://fontawesome.com/icons/tooth?style=solid"/>
        [Description("Solid Tooth"), IconID("fas-tooth"), IconUnicodeGlyph(0xf5c9)]
        SolidTooth = 1798,
        ///<summary>Solid Torii Gate</summary>
        ///<see href="https://fontawesome.com/icons/torii-gate?style=solid"/>
        [Description("Solid Torii Gate"), IconID("fas-torii-gate"), IconUnicodeGlyph(0xf6a1)]
        SolidToriiGate = 1799,
        ///<summary>Solid Tornado</summary>
        ///<see href="https://fontawesome.com/icons/tornado?style=solid"/>
        [Description("Solid Tornado"), IconID("fas-tornado"), IconUnicodeGlyph(0xf76f)]
        SolidTornado = 1800,
        ///<summary>Solid Tower broadcast</summary>
        ///<see href="https://fontawesome.com/icons/tower-broadcast?style=solid"/>
        [Description("Solid Tower broadcast"), IconID("fas-tower-broadcast"), IconUnicodeGlyph(0xf519)]
        SolidTowerBroadcast = 1801,
        ///<summary>Solid Tower Cell</summary>
        ///<see href="https://fontawesome.com/icons/tower-cell?style=solid"/>
        [Description("Solid Tower Cell"), IconID("fas-tower-cell"), IconUnicodeGlyph(0xe585)]
        SolidTowerCell = 1802,
        ///<summary>Solid Tower Observation</summary>
        ///<see href="https://fontawesome.com/icons/tower-observation?style=solid"/>
        [Description("Solid Tower Observation"), IconID("fas-tower-observation"), IconUnicodeGlyph(0xe586)]
        SolidTowerObservation = 1803,
        ///<summary>Solid Tractor</summary>
        ///<see href="https://fontawesome.com/icons/tractor?style=solid"/>
        [Description("Solid Tractor"), IconID("fas-tractor"), IconUnicodeGlyph(0xf722)]
        SolidTractor = 1804,
        ///<summary>Brands Trade Federation</summary>
        ///<see href="https://fontawesome.com/icons/trade-federation?style=brands"/>
        [Description("Brands Trade Federation"), IconID("fab-trade-federation"), IconUnicodeGlyph(0xf513)]
        BrandsTradeFederation = 1805,
        ///<summary>Solid Trademark</summary>
        ///<see href="https://fontawesome.com/icons/trademark?style=solid"/>
        [Description("Solid Trademark"), IconID("fas-trademark"), IconUnicodeGlyph(0xf25c)]
        SolidTrademark = 1806,
        ///<summary>Solid Traffic Light</summary>
        ///<see href="https://fontawesome.com/icons/traffic-light?style=solid"/>
        [Description("Solid Traffic Light"), IconID("fas-traffic-light"), IconUnicodeGlyph(0xf637)]
        SolidTrafficLight = 1807,
        ///<summary>Solid Trailer</summary>
        ///<see href="https://fontawesome.com/icons/trailer?style=solid"/>
        [Description("Solid Trailer"), IconID("fas-trailer"), IconUnicodeGlyph(0xe041)]
        SolidTrailer = 1808,
        ///<summary>Solid Train</summary>
        ///<see href="https://fontawesome.com/icons/train?style=solid"/>
        [Description("Solid Train"), IconID("fas-train"), IconUnicodeGlyph(0xf238)]
        SolidTrain = 1809,
        ///<summary>Solid Train subway</summary>
        ///<see href="https://fontawesome.com/icons/train-subway?style=solid"/>
        [Description("Solid Train subway"), IconID("fas-train-subway"), IconUnicodeGlyph(0xf239)]
        SolidTrainSubway = 1810,
        ///<summary>Solid Train tram</summary>
        ///<see href="https://fontawesome.com/icons/train-tram?style=solid"/>
        [Description("Solid Train tram"), IconID("fas-train-tram"), IconUnicodeGlyph(0xe5b4)]
        SolidTrainTram = 1811,
        ///<summary>Solid Transgender</summary>
        ///<see href="https://fontawesome.com/icons/transgender?style=solid"/>
        [Description("Solid Transgender"), IconID("fas-transgender"), IconUnicodeGlyph(0xf225)]
        SolidTransgender = 1812,
        ///<summary>Solid Trash</summary>
        ///<see href="https://fontawesome.com/icons/trash?style=solid"/>
        [Description("Solid Trash"), IconID("fas-trash"), IconUnicodeGlyph(0xf1f8)]
        SolidTrash = 1813,
        ///<summary>Solid Trash arrow up</summary>
        ///<see href="https://fontawesome.com/icons/trash-arrow-up?style=solid"/>
        [Description("Solid Trash arrow up"), IconID("fas-trash-arrow-up"), IconUnicodeGlyph(0xf829)]
        SolidTrashArrowUp = 1814,
        ///<summary>Solid Trash can</summary>
        ///<see href="https://fontawesome.com/icons/trash-can?style=solid"/>
        [Description("Solid Trash can"), IconID("fas-trash-can"), IconUnicodeGlyph(0xf2ed)]
        SolidTrashCan = 1815,
        ///<summary>Regular Trash can</summary>
        ///<see href="https://fontawesome.com/icons/trash-can?style=regular"/>
        [Description("Regular Trash can"), IconID("far-trash-can"), IconUnicodeGlyph(0xf2ed)]
        RegularTrashCan = 1816,
        ///<summary>Solid Trash can arrow up</summary>
        ///<see href="https://fontawesome.com/icons/trash-can-arrow-up?style=solid"/>
        [Description("Solid Trash can arrow up"), IconID("fas-trash-can-arrow-up"), IconUnicodeGlyph(0xf82a)]
        SolidTrashCanArrowUp = 1817,
        ///<summary>Solid Tree</summary>
        ///<see href="https://fontawesome.com/icons/tree?style=solid"/>
        [Description("Solid Tree"), IconID("fas-tree"), IconUnicodeGlyph(0xf1bb)]
        SolidTree = 1818,
        ///<summary>Solid Tree City</summary>
        ///<see href="https://fontawesome.com/icons/tree-city?style=solid"/>
        [Description("Solid Tree City"), IconID("fas-tree-city"), IconUnicodeGlyph(0xe587)]
        SolidTreeCity = 1819,
        ///<summary>Brands Trello</summary>
        ///<see href="https://fontawesome.com/icons/trello?style=brands"/>
        [Description("Brands Trello"), IconID("fab-trello"), IconUnicodeGlyph(0xf181)]
        BrandsTrello = 1820,
        ///<summary>Solid Triangle exclamation</summary>
        ///<see href="https://fontawesome.com/icons/triangle-exclamation?style=solid"/>
        [Description("Solid Triangle exclamation"), IconID("fas-triangle-exclamation"), IconUnicodeGlyph(0xf071)]
        SolidTriangleExclamation = 1821,
        ///<summary>Solid trophy</summary>
        ///<see href="https://fontawesome.com/icons/trophy?style=solid"/>
        [Description("Solid trophy"), IconID("fas-trophy"), IconUnicodeGlyph(0xf091)]
        SolidTrophy = 1822,
        ///<summary>Solid Trowel</summary>
        ///<see href="https://fontawesome.com/icons/trowel?style=solid"/>
        [Description("Solid Trowel"), IconID("fas-trowel"), IconUnicodeGlyph(0xe589)]
        SolidTrowel = 1823,
        ///<summary>Solid Trowel Bricks</summary>
        ///<see href="https://fontawesome.com/icons/trowel-bricks?style=solid"/>
        [Description("Solid Trowel Bricks"), IconID("fas-trowel-bricks"), IconUnicodeGlyph(0xe58a)]
        SolidTrowelBricks = 1824,
        ///<summary>Solid truck</summary>
        ///<see href="https://fontawesome.com/icons/truck?style=solid"/>
        [Description("Solid truck"), IconID("fas-truck"), IconUnicodeGlyph(0xf0d1)]
        SolidTruck = 1825,
        ///<summary>Solid Truck Arrow-right</summary>
        ///<see href="https://fontawesome.com/icons/truck-arrow-right?style=solid"/>
        [Description("Solid Truck Arrow-right"), IconID("fas-truck-arrow-right"), IconUnicodeGlyph(0xe58b)]
        SolidTruckArrowRight = 1826,
        ///<summary>Solid Truck Droplet</summary>
        ///<see href="https://fontawesome.com/icons/truck-droplet?style=solid"/>
        [Description("Solid Truck Droplet"), IconID("fas-truck-droplet"), IconUnicodeGlyph(0xe58c)]
        SolidTruckDroplet = 1827,
        ///<summary>Solid Truck fast</summary>
        ///<see href="https://fontawesome.com/icons/truck-fast?style=solid"/>
        [Description("Solid Truck fast"), IconID("fas-truck-fast"), IconUnicodeGlyph(0xf48b)]
        SolidTruckFast = 1828,
        ///<summary>Solid Truck Field</summary>
        ///<see href="https://fontawesome.com/icons/truck-field?style=solid"/>
        [Description("Solid Truck Field"), IconID("fas-truck-field"), IconUnicodeGlyph(0xe58d)]
        SolidTruckField = 1829,
        ///<summary>Solid Truck Field-un</summary>
        ///<see href="https://fontawesome.com/icons/truck-field-un?style=solid"/>
        [Description("Solid Truck Field-un"), IconID("fas-truck-field-un"), IconUnicodeGlyph(0xe58e)]
        SolidTruckFieldUn = 1830,
        ///<summary>Solid Truck Front</summary>
        ///<see href="https://fontawesome.com/icons/truck-front?style=solid"/>
        [Description("Solid Truck Front"), IconID("fas-truck-front"), IconUnicodeGlyph(0xe2b7)]
        SolidTruckFront = 1831,
        ///<summary>Solid Truck medical</summary>
        ///<see href="https://fontawesome.com/icons/truck-medical?style=solid"/>
        [Description("Solid Truck medical"), IconID("fas-truck-medical"), IconUnicodeGlyph(0xf0f9)]
        SolidTruckMedical = 1832,
        ///<summary>Solid Truck Monster</summary>
        ///<see href="https://fontawesome.com/icons/truck-monster?style=solid"/>
        [Description("Solid Truck Monster"), IconID("fas-truck-monster"), IconUnicodeGlyph(0xf63b)]
        SolidTruckMonster = 1833,
        ///<summary>Solid Truck Moving</summary>
        ///<see href="https://fontawesome.com/icons/truck-moving?style=solid"/>
        [Description("Solid Truck Moving"), IconID("fas-truck-moving"), IconUnicodeGlyph(0xf4df)]
        SolidTruckMoving = 1834,
        ///<summary>Solid Truck Side</summary>
        ///<see href="https://fontawesome.com/icons/truck-pickup?style=solid"/>
        [Description("Solid Truck Side"), IconID("fas-truck-pickup"), IconUnicodeGlyph(0xf63c)]
        SolidTruckPickup = 1835,
        ///<summary>Solid Truck Plane</summary>
        ///<see href="https://fontawesome.com/icons/truck-plane?style=solid"/>
        [Description("Solid Truck Plane"), IconID("fas-truck-plane"), IconUnicodeGlyph(0xe58f)]
        SolidTruckPlane = 1836,
        ///<summary>Solid Truck ramp box</summary>
        ///<see href="https://fontawesome.com/icons/truck-ramp-box?style=solid"/>
        [Description("Solid Truck ramp box"), IconID("fas-truck-ramp-box"), IconUnicodeGlyph(0xf4de)]
        SolidTruckRampBox = 1837,
        ///<summary>Solid TTY</summary>
        ///<see href="https://fontawesome.com/icons/tty?style=solid"/>
        [Description("Solid TTY"), IconID("fas-tty"), IconUnicodeGlyph(0xf1e4)]
        SolidTty = 1838,
        ///<summary>Brands Tumblr</summary>
        ///<see href="https://fontawesome.com/icons/tumblr?style=brands"/>
        [Description("Brands Tumblr"), IconID("fab-tumblr"), IconUnicodeGlyph(0xf173)]
        BrandsTumblr = 1839,
        ///<summary>Solid Turkish Lira-sign</summary>
        ///<see href="https://fontawesome.com/icons/turkish-lira-sign?style=solid"/>
        [Description("Solid Turkish Lira-sign"), IconID("fas-turkish-lira-sign"), IconUnicodeGlyph(0xe2bb)]
        SolidTurkishLiraSign = 1840,
        ///<summary>Solid Turn down</summary>
        ///<see href="https://fontawesome.com/icons/turn-down?style=solid"/>
        [Description("Solid Turn down"), IconID("fas-turn-down"), IconUnicodeGlyph(0xf3be)]
        SolidTurnDown = 1841,
        ///<summary>Solid Turn up</summary>
        ///<see href="https://fontawesome.com/icons/turn-up?style=solid"/>
        [Description("Solid Turn up"), IconID("fas-turn-up"), IconUnicodeGlyph(0xf3bf)]
        SolidTurnUp = 1842,
        ///<summary>Solid Television</summary>
        ///<see href="https://fontawesome.com/icons/tv?style=solid"/>
        [Description("Solid Television"), IconID("fas-tv"), IconUnicodeGlyph(0xf26c)]
        SolidTv = 1843,
        ///<summary>Brands Twitch</summary>
        ///<see href="https://fontawesome.com/icons/twitch?style=brands"/>
        [Description("Brands Twitch"), IconID("fab-twitch"), IconUnicodeGlyph(0xf1e8)]
        BrandsTwitch = 1844,
        ///<summary>Brands Twitter</summary>
        ///<see href="https://fontawesome.com/icons/twitter?style=brands"/>
        [Description("Brands Twitter"), IconID("fab-twitter"), IconUnicodeGlyph(0xf099)]
        BrandsTwitter = 1845,
        ///<summary>Brands Typo3</summary>
        ///<see href="https://fontawesome.com/icons/typo3?style=brands"/>
        [Description("Brands Typo3"), IconID("fab-typo3"), IconUnicodeGlyph(0xf42b)]
        BrandsTypo3 = 1846,
        ///<summary>Solid U</summary>
        ///<see href="https://fontawesome.com/icons/u?style=solid"/>
        [Description("Solid U"), IconID("fas-u"), IconUnicodeGlyph(0x55)]
        SolidU = 1847,
        ///<summary>Brands Uber</summary>
        ///<see href="https://fontawesome.com/icons/uber?style=brands"/>
        [Description("Brands Uber"), IconID("fab-uber"), IconUnicodeGlyph(0xf402)]
        BrandsUber = 1848,
        ///<summary>Brands Ubuntu</summary>
        ///<see href="https://fontawesome.com/icons/ubuntu?style=brands"/>
        [Description("Brands Ubuntu"), IconID("fab-ubuntu"), IconUnicodeGlyph(0xf7df)]
        BrandsUbuntu = 1849,
        ///<summary>Brands UIkit</summary>
        ///<see href="https://fontawesome.com/icons/uikit?style=brands"/>
        [Description("Brands UIkit"), IconID("fab-uikit"), IconUnicodeGlyph(0xf403)]
        BrandsUikit = 1850,
        ///<summary>Brands Umbraco</summary>
        ///<see href="https://fontawesome.com/icons/umbraco?style=brands"/>
        [Description("Brands Umbraco"), IconID("fab-umbraco"), IconUnicodeGlyph(0xf8e8)]
        BrandsUmbraco = 1851,
        ///<summary>Solid Umbrella</summary>
        ///<see href="https://fontawesome.com/icons/umbrella?style=solid"/>
        [Description("Solid Umbrella"), IconID("fas-umbrella"), IconUnicodeGlyph(0xf0e9)]
        SolidUmbrella = 1852,
        ///<summary>Solid Umbrella Beach</summary>
        ///<see href="https://fontawesome.com/icons/umbrella-beach?style=solid"/>
        [Description("Solid Umbrella Beach"), IconID("fas-umbrella-beach"), IconUnicodeGlyph(0xf5ca)]
        SolidUmbrellaBeach = 1853,
        ///<summary>Brands Uncharted Software</summary>
        ///<see href="https://fontawesome.com/icons/uncharted?style=brands"/>
        [Description("Brands Uncharted Software"), IconID("fab-uncharted"), IconUnicodeGlyph(0xe084)]
        BrandsUncharted = 1854,
        ///<summary>Solid Underline</summary>
        ///<see href="https://fontawesome.com/icons/underline?style=solid"/>
        [Description("Solid Underline"), IconID("fas-underline"), IconUnicodeGlyph(0xf0cd)]
        SolidUnderline = 1855,
        ///<summary>Brands Uniregistry</summary>
        ///<see href="https://fontawesome.com/icons/uniregistry?style=brands"/>
        [Description("Brands Uniregistry"), IconID("fab-uniregistry"), IconUnicodeGlyph(0xf404)]
        BrandsUniregistry = 1856,
        ///<summary>Brands Unity 3D</summary>
        ///<see href="https://fontawesome.com/icons/unity?style=brands"/>
        [Description("Brands Unity 3D"), IconID("fab-unity"), IconUnicodeGlyph(0xe049)]
        BrandsUnity = 1857,
        ///<summary>Solid Universal Access</summary>
        ///<see href="https://fontawesome.com/icons/universal-access?style=solid"/>
        [Description("Solid Universal Access"), IconID("fas-universal-access"), IconUnicodeGlyph(0xf29a)]
        SolidUniversalAccess = 1858,
        ///<summary>Solid unlock</summary>
        ///<see href="https://fontawesome.com/icons/unlock?style=solid"/>
        [Description("Solid unlock"), IconID("fas-unlock"), IconUnicodeGlyph(0xf09c)]
        SolidUnlock = 1859,
        ///<summary>Solid Unlock keyhole</summary>
        ///<see href="https://fontawesome.com/icons/unlock-keyhole?style=solid"/>
        [Description("Solid Unlock keyhole"), IconID("fas-unlock-keyhole"), IconUnicodeGlyph(0xf13e)]
        SolidUnlockKeyhole = 1860,
        ///<summary>Brands Unsplash</summary>
        ///<see href="https://fontawesome.com/icons/unsplash?style=brands"/>
        [Description("Brands Unsplash"), IconID("fab-unsplash"), IconUnicodeGlyph(0xe07c)]
        BrandsUnsplash = 1861,
        ///<summary>Brands Untappd</summary>
        ///<see href="https://fontawesome.com/icons/untappd?style=brands"/>
        [Description("Brands Untappd"), IconID("fab-untappd"), IconUnicodeGlyph(0xf405)]
        BrandsUntappd = 1862,
        ///<summary>Solid Up down</summary>
        ///<see href="https://fontawesome.com/icons/up-down?style=solid"/>
        [Description("Solid Up down"), IconID("fas-up-down"), IconUnicodeGlyph(0xf338)]
        SolidUpDown = 1863,
        ///<summary>Solid Up down left right</summary>
        ///<see href="https://fontawesome.com/icons/up-down-left-right?style=solid"/>
        [Description("Solid Up down left right"), IconID("fas-up-down-left-right"), IconUnicodeGlyph(0xf0b2)]
        SolidUpDownLeftRight = 1864,
        ///<summary>Solid Up long</summary>
        ///<see href="https://fontawesome.com/icons/up-long?style=solid"/>
        [Description("Solid Up long"), IconID("fas-up-long"), IconUnicodeGlyph(0xf30c)]
        SolidUpLong = 1865,
        ///<summary>Solid Up right and down left from center</summary>
        ///<see href="https://fontawesome.com/icons/up-right-and-down-left-from-center?style=solid"/>
        [Description("Solid Up right and down left from center"), IconID("fas-up-right-and-down-left-from-center"), IconUnicodeGlyph(0xf424)]
        SolidUpRightAndDownLeftFromCenter = 1866,
        ///<summary>Solid Up right from square</summary>
        ///<see href="https://fontawesome.com/icons/up-right-from-square?style=solid"/>
        [Description("Solid Up right from square"), IconID("fas-up-right-from-square"), IconUnicodeGlyph(0xf35d)]
        SolidUpRightFromSquare = 1867,
        ///<summary>Solid Upload</summary>
        ///<see href="https://fontawesome.com/icons/upload?style=solid"/>
        [Description("Solid Upload"), IconID("fas-upload"), IconUnicodeGlyph(0xf093)]
        SolidUpload = 1868,
        ///<summary>Brands UPS</summary>
        ///<see href="https://fontawesome.com/icons/ups?style=brands"/>
        [Description("Brands UPS"), IconID("fab-ups"), IconUnicodeGlyph(0xf7e0)]
        BrandsUps = 1869,
        ///<summary>Brands USB</summary>
        ///<see href="https://fontawesome.com/icons/usb?style=brands"/>
        [Description("Brands USB"), IconID("fab-usb"), IconUnicodeGlyph(0xf287)]
        BrandsUsb = 1870,
        ///<summary>Solid User</summary>
        ///<see href="https://fontawesome.com/icons/user?style=solid"/>
        [Description("Solid User"), IconID("fas-user"), IconUnicodeGlyph(0xf007)]
        SolidUser = 1871,
        ///<summary>Regular User</summary>
        ///<see href="https://fontawesome.com/icons/user?style=regular"/>
        [Description("Regular User"), IconID("far-user"), IconUnicodeGlyph(0xf007)]
        RegularUser = 1872,
        ///<summary>Solid User Astronaut</summary>
        ///<see href="https://fontawesome.com/icons/user-astronaut?style=solid"/>
        [Description("Solid User Astronaut"), IconID("fas-user-astronaut"), IconUnicodeGlyph(0xf4fb)]
        SolidUserAstronaut = 1873,
        ///<summary>Solid User Check</summary>
        ///<see href="https://fontawesome.com/icons/user-check?style=solid"/>
        [Description("Solid User Check"), IconID("fas-user-check"), IconUnicodeGlyph(0xf4fc)]
        SolidUserCheck = 1874,
        ///<summary>Solid User Clock</summary>
        ///<see href="https://fontawesome.com/icons/user-clock?style=solid"/>
        [Description("Solid User Clock"), IconID("fas-user-clock"), IconUnicodeGlyph(0xf4fd)]
        SolidUserClock = 1875,
        ///<summary>Solid User doctor</summary>
        ///<see href="https://fontawesome.com/icons/user-doctor?style=solid"/>
        [Description("Solid User doctor"), IconID("fas-user-doctor"), IconUnicodeGlyph(0xf0f0)]
        SolidUserDoctor = 1876,
        ///<summary>Solid User gear</summary>
        ///<see href="https://fontawesome.com/icons/user-gear?style=solid"/>
        [Description("Solid User gear"), IconID("fas-user-gear"), IconUnicodeGlyph(0xf4fe)]
        SolidUserGear = 1877,
        ///<summary>Solid User Graduate</summary>
        ///<see href="https://fontawesome.com/icons/user-graduate?style=solid"/>
        [Description("Solid User Graduate"), IconID("fas-user-graduate"), IconUnicodeGlyph(0xf501)]
        SolidUserGraduate = 1878,
        ///<summary>Solid User group</summary>
        ///<see href="https://fontawesome.com/icons/user-group?style=solid"/>
        [Description("Solid User group"), IconID("fas-user-group"), IconUnicodeGlyph(0xf500)]
        SolidUserGroup = 1879,
        ///<summary>Solid User Injured</summary>
        ///<see href="https://fontawesome.com/icons/user-injured?style=solid"/>
        [Description("Solid User Injured"), IconID("fas-user-injured"), IconUnicodeGlyph(0xf728)]
        SolidUserInjured = 1880,
        ///<summary>Solid User large</summary>
        ///<see href="https://fontawesome.com/icons/user-large?style=solid"/>
        [Description("Solid User large"), IconID("fas-user-large"), IconUnicodeGlyph(0xf406)]
        SolidUserLarge = 1881,
        ///<summary>Solid User large slash</summary>
        ///<see href="https://fontawesome.com/icons/user-large-slash?style=solid"/>
        [Description("Solid User large slash"), IconID("fas-user-large-slash"), IconUnicodeGlyph(0xf4fa)]
        SolidUserLargeSlash = 1882,
        ///<summary>Solid User Lock</summary>
        ///<see href="https://fontawesome.com/icons/user-lock?style=solid"/>
        [Description("Solid User Lock"), IconID("fas-user-lock"), IconUnicodeGlyph(0xf502)]
        SolidUserLock = 1883,
        ///<summary>Solid User Minus</summary>
        ///<see href="https://fontawesome.com/icons/user-minus?style=solid"/>
        [Description("Solid User Minus"), IconID("fas-user-minus"), IconUnicodeGlyph(0xf503)]
        SolidUserMinus = 1884,
        ///<summary>Solid User Ninja</summary>
        ///<see href="https://fontawesome.com/icons/user-ninja?style=solid"/>
        [Description("Solid User Ninja"), IconID("fas-user-ninja"), IconUnicodeGlyph(0xf504)]
        SolidUserNinja = 1885,
        ///<summary>Solid Nurse</summary>
        ///<see href="https://fontawesome.com/icons/user-nurse?style=solid"/>
        [Description("Solid Nurse"), IconID("fas-user-nurse"), IconUnicodeGlyph(0xf82f)]
        SolidUserNurse = 1886,
        ///<summary>Solid User pen</summary>
        ///<see href="https://fontawesome.com/icons/user-pen?style=solid"/>
        [Description("Solid User pen"), IconID("fas-user-pen"), IconUnicodeGlyph(0xf4ff)]
        SolidUserPen = 1887,
        ///<summary>Solid User Plus</summary>
        ///<see href="https://fontawesome.com/icons/user-plus?style=solid"/>
        [Description("Solid User Plus"), IconID("fas-user-plus"), IconUnicodeGlyph(0xf234)]
        SolidUserPlus = 1888,
        ///<summary>Solid User Secret</summary>
        ///<see href="https://fontawesome.com/icons/user-secret?style=solid"/>
        [Description("Solid User Secret"), IconID("fas-user-secret"), IconUnicodeGlyph(0xf21b)]
        SolidUserSecret = 1889,
        ///<summary>Solid User Shield</summary>
        ///<see href="https://fontawesome.com/icons/user-shield?style=solid"/>
        [Description("Solid User Shield"), IconID("fas-user-shield"), IconUnicodeGlyph(0xf505)]
        SolidUserShield = 1890,
        ///<summary>Solid User Slash</summary>
        ///<see href="https://fontawesome.com/icons/user-slash?style=solid"/>
        [Description("Solid User Slash"), IconID("fas-user-slash"), IconUnicodeGlyph(0xf506)]
        SolidUserSlash = 1891,
        ///<summary>Solid User Tag</summary>
        ///<see href="https://fontawesome.com/icons/user-tag?style=solid"/>
        [Description("Solid User Tag"), IconID("fas-user-tag"), IconUnicodeGlyph(0xf507)]
        SolidUserTag = 1892,
        ///<summary>Solid User Tie</summary>
        ///<see href="https://fontawesome.com/icons/user-tie?style=solid"/>
        [Description("Solid User Tie"), IconID("fas-user-tie"), IconUnicodeGlyph(0xf508)]
        SolidUserTie = 1893,
        ///<summary>Solid User X Mark</summary>
        ///<see href="https://fontawesome.com/icons/user-xmark?style=solid"/>
        [Description("Solid User X Mark"), IconID("fas-user-xmark"), IconUnicodeGlyph(0xf235)]
        SolidUserXmark = 1894,
        ///<summary>Solid Users</summary>
        ///<see href="https://fontawesome.com/icons/users?style=solid"/>
        [Description("Solid Users"), IconID("fas-users"), IconUnicodeGlyph(0xf0c0)]
        SolidUsers = 1895,
        ///<summary>Solid Users Between-lines</summary>
        ///<see href="https://fontawesome.com/icons/users-between-lines?style=solid"/>
        [Description("Solid Users Between-lines"), IconID("fas-users-between-lines"), IconUnicodeGlyph(0xe591)]
        SolidUsersBetweenLines = 1896,
        ///<summary>Solid Users gear</summary>
        ///<see href="https://fontawesome.com/icons/users-gear?style=solid"/>
        [Description("Solid Users gear"), IconID("fas-users-gear"), IconUnicodeGlyph(0xf509)]
        SolidUsersGear = 1897,
        ///<summary>Solid Users Line</summary>
        ///<see href="https://fontawesome.com/icons/users-line?style=solid"/>
        [Description("Solid Users Line"), IconID("fas-users-line"), IconUnicodeGlyph(0xe592)]
        SolidUsersLine = 1898,
        ///<summary>Solid Users Rays</summary>
        ///<see href="https://fontawesome.com/icons/users-rays?style=solid"/>
        [Description("Solid Users Rays"), IconID("fas-users-rays"), IconUnicodeGlyph(0xe593)]
        SolidUsersRays = 1899,
        ///<summary>Solid Users Rectangle</summary>
        ///<see href="https://fontawesome.com/icons/users-rectangle?style=solid"/>
        [Description("Solid Users Rectangle"), IconID("fas-users-rectangle"), IconUnicodeGlyph(0xe594)]
        SolidUsersRectangle = 1900,
        ///<summary>Solid Users Slash</summary>
        ///<see href="https://fontawesome.com/icons/users-slash?style=solid"/>
        [Description("Solid Users Slash"), IconID("fas-users-slash"), IconUnicodeGlyph(0xe073)]
        SolidUsersSlash = 1901,
        ///<summary>Solid Users Viewfinder</summary>
        ///<see href="https://fontawesome.com/icons/users-viewfinder?style=solid"/>
        [Description("Solid Users Viewfinder"), IconID("fas-users-viewfinder"), IconUnicodeGlyph(0xe595)]
        SolidUsersViewfinder = 1902,
        ///<summary>Brands United States Postal Service</summary>
        ///<see href="https://fontawesome.com/icons/usps?style=brands"/>
        [Description("Brands United States Postal Service"), IconID("fab-usps"), IconUnicodeGlyph(0xf7e1)]
        BrandsUsps = 1903,
        ///<summary>Brands us-Sunnah Foundation</summary>
        ///<see href="https://fontawesome.com/icons/ussunnah?style=brands"/>
        [Description("Brands us-Sunnah Foundation"), IconID("fab-ussunnah"), IconUnicodeGlyph(0xf407)]
        BrandsUssunnah = 1904,
        ///<summary>Solid Utensils</summary>
        ///<see href="https://fontawesome.com/icons/utensils?style=solid"/>
        [Description("Solid Utensils"), IconID("fas-utensils"), IconUnicodeGlyph(0xf2e7)]
        SolidUtensils = 1905,
        ///<summary>Solid V</summary>
        ///<see href="https://fontawesome.com/icons/v?style=solid"/>
        [Description("Solid V"), IconID("fas-v"), IconUnicodeGlyph(0x56)]
        SolidV = 1906,
        ///<summary>Brands Vaadin</summary>
        ///<see href="https://fontawesome.com/icons/vaadin?style=brands"/>
        [Description("Brands Vaadin"), IconID("fab-vaadin"), IconUnicodeGlyph(0xf408)]
        BrandsVaadin = 1907,
        ///<summary>Solid Van shuttle</summary>
        ///<see href="https://fontawesome.com/icons/van-shuttle?style=solid"/>
        [Description("Solid Van shuttle"), IconID("fas-van-shuttle"), IconUnicodeGlyph(0xf5b6)]
        SolidVanShuttle = 1908,
        ///<summary>Solid Vault</summary>
        ///<see href="https://fontawesome.com/icons/vault?style=solid"/>
        [Description("Solid Vault"), IconID("fas-vault"), IconUnicodeGlyph(0xe2c5)]
        SolidVault = 1909,
        ///<summary>Solid Vector Square</summary>
        ///<see href="https://fontawesome.com/icons/vector-square?style=solid"/>
        [Description("Solid Vector Square"), IconID("fas-vector-square"), IconUnicodeGlyph(0xf5cb)]
        SolidVectorSquare = 1910,
        ///<summary>Solid Venus</summary>
        ///<see href="https://fontawesome.com/icons/venus?style=solid"/>
        [Description("Solid Venus"), IconID("fas-venus"), IconUnicodeGlyph(0xf221)]
        SolidVenus = 1911,
        ///<summary>Solid Venus Double</summary>
        ///<see href="https://fontawesome.com/icons/venus-double?style=solid"/>
        [Description("Solid Venus Double"), IconID("fas-venus-double"), IconUnicodeGlyph(0xf226)]
        SolidVenusDouble = 1912,
        ///<summary>Solid Venus Mars</summary>
        ///<see href="https://fontawesome.com/icons/venus-mars?style=solid"/>
        [Description("Solid Venus Mars"), IconID("fas-venus-mars"), IconUnicodeGlyph(0xf228)]
        SolidVenusMars = 1913,
        ///<summary>Solid vest</summary>
        ///<see href="https://fontawesome.com/icons/vest?style=solid"/>
        [Description("Solid vest"), IconID("fas-vest"), IconUnicodeGlyph(0xe085)]
        SolidVest = 1914,
        ///<summary>Solid vest-patches</summary>
        ///<see href="https://fontawesome.com/icons/vest-patches?style=solid"/>
        [Description("Solid vest-patches"), IconID("fas-vest-patches"), IconUnicodeGlyph(0xe086)]
        SolidVestPatches = 1915,
        ///<summary>Brands Viacoin</summary>
        ///<see href="https://fontawesome.com/icons/viacoin?style=brands"/>
        [Description("Brands Viacoin"), IconID("fab-viacoin"), IconUnicodeGlyph(0xf237)]
        BrandsViacoin = 1916,
        ///<summary>Brands Viadeo</summary>
        ///<see href="https://fontawesome.com/icons/viadeo?style=brands"/>
        [Description("Brands Viadeo"), IconID("fab-viadeo"), IconUnicodeGlyph(0xf2a9)]
        BrandsViadeo = 1917,
        ///<summary>Solid Vial</summary>
        ///<see href="https://fontawesome.com/icons/vial?style=solid"/>
        [Description("Solid Vial"), IconID("fas-vial"), IconUnicodeGlyph(0xf492)]
        SolidVial = 1918,
        ///<summary>Solid Vial Circle-check</summary>
        ///<see href="https://fontawesome.com/icons/vial-circle-check?style=solid"/>
        [Description("Solid Vial Circle-check"), IconID("fas-vial-circle-check"), IconUnicodeGlyph(0xe596)]
        SolidVialCircleCheck = 1919,
        ///<summary>Solid Vial Virus</summary>
        ///<see href="https://fontawesome.com/icons/vial-virus?style=solid"/>
        [Description("Solid Vial Virus"), IconID("fas-vial-virus"), IconUnicodeGlyph(0xe597)]
        SolidVialVirus = 1920,
        ///<summary>Solid Vials</summary>
        ///<see href="https://fontawesome.com/icons/vials?style=solid"/>
        [Description("Solid Vials"), IconID("fas-vials"), IconUnicodeGlyph(0xf493)]
        SolidVials = 1921,
        ///<summary>Brands Viber</summary>
        ///<see href="https://fontawesome.com/icons/viber?style=brands"/>
        [Description("Brands Viber"), IconID("fab-viber"), IconUnicodeGlyph(0xf409)]
        BrandsViber = 1922,
        ///<summary>Solid Video</summary>
        ///<see href="https://fontawesome.com/icons/video?style=solid"/>
        [Description("Solid Video"), IconID("fas-video"), IconUnicodeGlyph(0xf03d)]
        SolidVideo = 1923,
        ///<summary>Solid Video Slash</summary>
        ///<see href="https://fontawesome.com/icons/video-slash?style=solid"/>
        [Description("Solid Video Slash"), IconID("fas-video-slash"), IconUnicodeGlyph(0xf4e2)]
        SolidVideoSlash = 1924,
        ///<summary>Solid Vihara</summary>
        ///<see href="https://fontawesome.com/icons/vihara?style=solid"/>
        [Description("Solid Vihara"), IconID("fas-vihara"), IconUnicodeGlyph(0xf6a7)]
        SolidVihara = 1925,
        ///<summary>Brands Vimeo</summary>
        ///<see href="https://fontawesome.com/icons/vimeo?style=brands"/>
        [Description("Brands Vimeo"), IconID("fab-vimeo"), IconUnicodeGlyph(0xf40a)]
        BrandsVimeo = 1926,
        ///<summary>Brands Vimeo</summary>
        ///<see href="https://fontawesome.com/icons/vimeo-v?style=brands"/>
        [Description("Brands Vimeo"), IconID("fab-vimeo-v"), IconUnicodeGlyph(0xf27d)]
        BrandsVimeoV = 1927,
        ///<summary>Brands Vine</summary>
        ///<see href="https://fontawesome.com/icons/vine?style=brands"/>
        [Description("Brands Vine"), IconID("fab-vine"), IconUnicodeGlyph(0xf1ca)]
        BrandsVine = 1928,
        ///<summary>Solid Virus</summary>
        ///<see href="https://fontawesome.com/icons/virus?style=solid"/>
        [Description("Solid Virus"), IconID("fas-virus"), IconUnicodeGlyph(0xe074)]
        SolidVirus = 1929,
        ///<summary>Solid Virus Covid</summary>
        ///<see href="https://fontawesome.com/icons/virus-covid?style=solid"/>
        [Description("Solid Virus Covid"), IconID("fas-virus-covid"), IconUnicodeGlyph(0xe4a8)]
        SolidVirusCovid = 1930,
        ///<summary>Solid Virus Covid-slash</summary>
        ///<see href="https://fontawesome.com/icons/virus-covid-slash?style=solid"/>
        [Description("Solid Virus Covid-slash"), IconID("fas-virus-covid-slash"), IconUnicodeGlyph(0xe4a9)]
        SolidVirusCovidSlash = 1931,
        ///<summary>Solid Virus Slash</summary>
        ///<see href="https://fontawesome.com/icons/virus-slash?style=solid"/>
        [Description("Solid Virus Slash"), IconID("fas-virus-slash"), IconUnicodeGlyph(0xe075)]
        SolidVirusSlash = 1932,
        ///<summary>Solid Viruses</summary>
        ///<see href="https://fontawesome.com/icons/viruses?style=solid"/>
        [Description("Solid Viruses"), IconID("fas-viruses"), IconUnicodeGlyph(0xe076)]
        SolidViruses = 1933,
        ///<summary>Brands VK</summary>
        ///<see href="https://fontawesome.com/icons/vk?style=brands"/>
        [Description("Brands VK"), IconID("fab-vk"), IconUnicodeGlyph(0xf189)]
        BrandsVk = 1934,
        ///<summary>Brands VNV</summary>
        ///<see href="https://fontawesome.com/icons/vnv?style=brands"/>
        [Description("Brands VNV"), IconID("fab-vnv"), IconUnicodeGlyph(0xf40b)]
        BrandsVnv = 1935,
        ///<summary>Solid Voicemail</summary>
        ///<see href="https://fontawesome.com/icons/voicemail?style=solid"/>
        [Description("Solid Voicemail"), IconID("fas-voicemail"), IconUnicodeGlyph(0xf897)]
        SolidVoicemail = 1936,
        ///<summary>Solid Volcano</summary>
        ///<see href="https://fontawesome.com/icons/volcano?style=solid"/>
        [Description("Solid Volcano"), IconID("fas-volcano"), IconUnicodeGlyph(0xf770)]
        SolidVolcano = 1937,
        ///<summary>Solid Volleyball Ball</summary>
        ///<see href="https://fontawesome.com/icons/volleyball?style=solid"/>
        [Description("Solid Volleyball Ball"), IconID("fas-volleyball"), IconUnicodeGlyph(0xf45f)]
        SolidVolleyball = 1938,
        ///<summary>Solid Volume high</summary>
        ///<see href="https://fontawesome.com/icons/volume-high?style=solid"/>
        [Description("Solid Volume high"), IconID("fas-volume-high"), IconUnicodeGlyph(0xf028)]
        SolidVolumeHigh = 1939,
        ///<summary>Solid Volume low</summary>
        ///<see href="https://fontawesome.com/icons/volume-low?style=solid"/>
        [Description("Solid Volume low"), IconID("fas-volume-low"), IconUnicodeGlyph(0xf027)]
        SolidVolumeLow = 1940,
        ///<summary>Solid Volume Off</summary>
        ///<see href="https://fontawesome.com/icons/volume-off?style=solid"/>
        [Description("Solid Volume Off"), IconID("fas-volume-off"), IconUnicodeGlyph(0xf026)]
        SolidVolumeOff = 1941,
        ///<summary>Solid Volume X Mark</summary>
        ///<see href="https://fontawesome.com/icons/volume-xmark?style=solid"/>
        [Description("Solid Volume X Mark"), IconID("fas-volume-xmark"), IconUnicodeGlyph(0xf6a9)]
        SolidVolumeXmark = 1942,
        ///<summary>Solid Cardboard VR</summary>
        ///<see href="https://fontawesome.com/icons/vr-cardboard?style=solid"/>
        [Description("Solid Cardboard VR"), IconID("fas-vr-cardboard"), IconUnicodeGlyph(0xf729)]
        SolidVrCardboard = 1943,
        ///<summary>Brands Vue.js</summary>
        ///<see href="https://fontawesome.com/icons/vuejs?style=brands"/>
        [Description("Brands Vue.js"), IconID("fab-vuejs"), IconUnicodeGlyph(0xf41f)]
        BrandsVuejs = 1944,
        ///<summary>Solid W</summary>
        ///<see href="https://fontawesome.com/icons/w?style=solid"/>
        [Description("Solid W"), IconID("fas-w"), IconUnicodeGlyph(0x57)]
        SolidW = 1945,
        ///<summary>Solid Walkie Talkie</summary>
        ///<see href="https://fontawesome.com/icons/walkie-talkie?style=solid"/>
        [Description("Solid Walkie Talkie"), IconID("fas-walkie-talkie"), IconUnicodeGlyph(0xf8ef)]
        SolidWalkieTalkie = 1946,
        ///<summary>Solid Wallet</summary>
        ///<see href="https://fontawesome.com/icons/wallet?style=solid"/>
        [Description("Solid Wallet"), IconID("fas-wallet"), IconUnicodeGlyph(0xf555)]
        SolidWallet = 1947,
        ///<summary>Solid Wand magic</summary>
        ///<see href="https://fontawesome.com/icons/wand-magic?style=solid"/>
        [Description("Solid Wand magic"), IconID("fas-wand-magic"), IconUnicodeGlyph(0xf0d0)]
        SolidWandMagic = 1948,
        ///<summary>Solid Wand magic sparkles</summary>
        ///<see href="https://fontawesome.com/icons/wand-magic-sparkles?style=solid"/>
        [Description("Solid Wand magic sparkles"), IconID("fas-wand-magic-sparkles"), IconUnicodeGlyph(0xe2ca)]
        SolidWandMagicSparkles = 1949,
        ///<summary>Solid Wand sparkles</summary>
        ///<see href="https://fontawesome.com/icons/wand-sparkles?style=solid"/>
        [Description("Solid Wand sparkles"), IconID("fas-wand-sparkles"), IconUnicodeGlyph(0xf72b)]
        SolidWandSparkles = 1950,
        ///<summary>Solid Warehouse</summary>
        ///<see href="https://fontawesome.com/icons/warehouse?style=solid"/>
        [Description("Solid Warehouse"), IconID("fas-warehouse"), IconUnicodeGlyph(0xf494)]
        SolidWarehouse = 1951,
        ///<summary>Brands Watchman Monitoring</summary>
        ///<see href="https://fontawesome.com/icons/watchman-monitoring?style=brands"/>
        [Description("Brands Watchman Monitoring"), IconID("fab-watchman-monitoring"), IconUnicodeGlyph(0xe087)]
        BrandsWatchmanMonitoring = 1952,
        ///<summary>Solid Water</summary>
        ///<see href="https://fontawesome.com/icons/water?style=solid"/>
        [Description("Solid Water"), IconID("fas-water"), IconUnicodeGlyph(0xf773)]
        SolidWater = 1953,
        ///<summary>Solid Water ladder</summary>
        ///<see href="https://fontawesome.com/icons/water-ladder?style=solid"/>
        [Description("Solid Water ladder"), IconID("fas-water-ladder"), IconUnicodeGlyph(0xf5c5)]
        SolidWaterLadder = 1954,
        ///<summary>Solid Square Wave</summary>
        ///<see href="https://fontawesome.com/icons/wave-square?style=solid"/>
        [Description("Solid Square Wave"), IconID("fas-wave-square"), IconUnicodeGlyph(0xf83e)]
        SolidWaveSquare = 1955,
        ///<summary>Brands Waze</summary>
        ///<see href="https://fontawesome.com/icons/waze?style=brands"/>
        [Description("Brands Waze"), IconID("fab-waze"), IconUnicodeGlyph(0xf83f)]
        BrandsWaze = 1956,
        ///<summary>Brands Weebly</summary>
        ///<see href="https://fontawesome.com/icons/weebly?style=brands"/>
        [Description("Brands Weebly"), IconID("fab-weebly"), IconUnicodeGlyph(0xf5cc)]
        BrandsWeebly = 1957,
        ///<summary>Brands Weibo</summary>
        ///<see href="https://fontawesome.com/icons/weibo?style=brands"/>
        [Description("Brands Weibo"), IconID("fab-weibo"), IconUnicodeGlyph(0xf18a)]
        BrandsWeibo = 1958,
        ///<summary>Solid Hanging Weight</summary>
        ///<see href="https://fontawesome.com/icons/weight-hanging?style=solid"/>
        [Description("Solid Hanging Weight"), IconID("fas-weight-hanging"), IconUnicodeGlyph(0xf5cd)]
        SolidWeightHanging = 1959,
        ///<summary>Solid Weight scale</summary>
        ///<see href="https://fontawesome.com/icons/weight-scale?style=solid"/>
        [Description("Solid Weight scale"), IconID("fas-weight-scale"), IconUnicodeGlyph(0xf496)]
        SolidWeightScale = 1960,
        ///<summary>Brands Weixin (WeChat)</summary>
        ///<see href="https://fontawesome.com/icons/weixin?style=brands"/>
        [Description("Brands Weixin (WeChat)"), IconID("fab-weixin"), IconUnicodeGlyph(0xf1d7)]
        BrandsWeixin = 1961,
        ///<summary>Brands What's App</summary>
        ///<see href="https://fontawesome.com/icons/whatsapp?style=brands"/>
        [Description("Brands What's App"), IconID("fab-whatsapp"), IconUnicodeGlyph(0xf232)]
        BrandsWhatsapp = 1962,
        ///<summary>Solid Wheat awn</summary>
        ///<see href="https://fontawesome.com/icons/wheat-awn?style=solid"/>
        [Description("Solid Wheat awn"), IconID("fas-wheat-awn"), IconUnicodeGlyph(0xe2cd)]
        SolidWheatAwn = 1963,
        ///<summary>Solid Wheat Awn-circle-exclamation</summary>
        ///<see href="https://fontawesome.com/icons/wheat-awn-circle-exclamation?style=solid"/>
        [Description("Solid Wheat Awn-circle-exclamation"), IconID("fas-wheat-awn-circle-exclamation"), IconUnicodeGlyph(0xe598)]
        SolidWheatAwnCircleExclamation = 1964,
        ///<summary>Solid Wheelchair</summary>
        ///<see href="https://fontawesome.com/icons/wheelchair?style=solid"/>
        [Description("Solid Wheelchair"), IconID("fas-wheelchair"), IconUnicodeGlyph(0xf193)]
        SolidWheelchair = 1965,
        ///<summary>Solid Wheelchair Move</summary>
        ///<see href="https://fontawesome.com/icons/wheelchair-move?style=solid"/>
        [Description("Solid Wheelchair Move"), IconID("fas-wheelchair-move"), IconUnicodeGlyph(0xe2ce)]
        SolidWheelchairMove = 1966,
        ///<summary>Solid Whiskey glass</summary>
        ///<see href="https://fontawesome.com/icons/whiskey-glass?style=solid"/>
        [Description("Solid Whiskey glass"), IconID("fas-whiskey-glass"), IconUnicodeGlyph(0xf7a0)]
        SolidWhiskeyGlass = 1967,
        ///<summary>Brands WHMCS</summary>
        ///<see href="https://fontawesome.com/icons/whmcs?style=brands"/>
        [Description("Brands WHMCS"), IconID("fab-whmcs"), IconUnicodeGlyph(0xf40d)]
        BrandsWhmcs = 1968,
        ///<summary>Solid WiFi</summary>
        ///<see href="https://fontawesome.com/icons/wifi?style=solid"/>
        [Description("Solid WiFi"), IconID("fas-wifi"), IconUnicodeGlyph(0xf1eb)]
        SolidWifi = 1969,
        ///<summary>Brands Wikipedia W</summary>
        ///<see href="https://fontawesome.com/icons/wikipedia-w?style=brands"/>
        [Description("Brands Wikipedia W"), IconID("fab-wikipedia-w"), IconUnicodeGlyph(0xf266)]
        BrandsWikipediaW = 1970,
        ///<summary>Solid Wind</summary>
        ///<see href="https://fontawesome.com/icons/wind?style=solid"/>
        [Description("Solid Wind"), IconID("fas-wind"), IconUnicodeGlyph(0xf72e)]
        SolidWind = 1971,
        ///<summary>Solid Window Maximize</summary>
        ///<see href="https://fontawesome.com/icons/window-maximize?style=solid"/>
        [Description("Solid Window Maximize"), IconID("fas-window-maximize"), IconUnicodeGlyph(0xf2d0)]
        SolidWindowMaximize = 1972,
        ///<summary>Regular Window Maximize</summary>
        ///<see href="https://fontawesome.com/icons/window-maximize?style=regular"/>
        [Description("Regular Window Maximize"), IconID("far-window-maximize"), IconUnicodeGlyph(0xf2d0)]
        RegularWindowMaximize = 1973,
        ///<summary>Solid Window Minimize</summary>
        ///<see href="https://fontawesome.com/icons/window-minimize?style=solid"/>
        [Description("Solid Window Minimize"), IconID("fas-window-minimize"), IconUnicodeGlyph(0xf2d1)]
        SolidWindowMinimize = 1974,
        ///<summary>Regular Window Minimize</summary>
        ///<see href="https://fontawesome.com/icons/window-minimize?style=regular"/>
        [Description("Regular Window Minimize"), IconID("far-window-minimize"), IconUnicodeGlyph(0xf2d1)]
        RegularWindowMinimize = 1975,
        ///<summary>Solid Window Restore</summary>
        ///<see href="https://fontawesome.com/icons/window-restore?style=solid"/>
        [Description("Solid Window Restore"), IconID("fas-window-restore"), IconUnicodeGlyph(0xf2d2)]
        SolidWindowRestore = 1976,
        ///<summary>Regular Window Restore</summary>
        ///<see href="https://fontawesome.com/icons/window-restore?style=regular"/>
        [Description("Regular Window Restore"), IconID("far-window-restore"), IconUnicodeGlyph(0xf2d2)]
        RegularWindowRestore = 1977,
        ///<summary>Brands Windows</summary>
        ///<see href="https://fontawesome.com/icons/windows?style=brands"/>
        [Description("Brands Windows"), IconID("fab-windows"), IconUnicodeGlyph(0xf17a)]
        BrandsWindows = 1978,
        ///<summary>Solid Wine Bottle</summary>
        ///<see href="https://fontawesome.com/icons/wine-bottle?style=solid"/>
        [Description("Solid Wine Bottle"), IconID("fas-wine-bottle"), IconUnicodeGlyph(0xf72f)]
        SolidWineBottle = 1979,
        ///<summary>Solid Wine Glass</summary>
        ///<see href="https://fontawesome.com/icons/wine-glass?style=solid"/>
        [Description("Solid Wine Glass"), IconID("fas-wine-glass"), IconUnicodeGlyph(0xf4e3)]
        SolidWineGlass = 1980,
        ///<summary>Solid Wine glass empty</summary>
        ///<see href="https://fontawesome.com/icons/wine-glass-empty?style=solid"/>
        [Description("Solid Wine glass empty"), IconID("fas-wine-glass-empty"), IconUnicodeGlyph(0xf5ce)]
        SolidWineGlassEmpty = 1981,
        ///<summary>Brands wirsindhandwerk</summary>
        ///<see href="https://fontawesome.com/icons/wirsindhandwerk?style=brands"/>
        [Description("Brands wirsindhandwerk"), IconID("fab-wirsindhandwerk"), IconUnicodeGlyph(0xe2d0)]
        BrandsWirsindhandwerk = 1982,
        ///<summary>Brands Wix</summary>
        ///<see href="https://fontawesome.com/icons/wix?style=brands"/>
        [Description("Brands Wix"), IconID("fab-wix"), IconUnicodeGlyph(0xf5cf)]
        BrandsWix = 1983,
        ///<summary>Brands Wizards of the Coast</summary>
        ///<see href="https://fontawesome.com/icons/wizards-of-the-coast?style=brands"/>
        [Description("Brands Wizards of the Coast"), IconID("fab-wizards-of-the-coast"), IconUnicodeGlyph(0xf730)]
        BrandsWizardsOfTheCoast = 1984,
        ///<summary>Brands Wodu</summary>
        ///<see href="https://fontawesome.com/icons/wodu?style=brands"/>
        [Description("Brands Wodu"), IconID("fab-wodu"), IconUnicodeGlyph(0xe088)]
        BrandsWodu = 1985,
        ///<summary>Brands Wolf Pack Battalion</summary>
        ///<see href="https://fontawesome.com/icons/wolf-pack-battalion?style=brands"/>
        [Description("Brands Wolf Pack Battalion"), IconID("fab-wolf-pack-battalion"), IconUnicodeGlyph(0xf514)]
        BrandsWolfPackBattalion = 1986,
        ///<summary>Solid Won Sign</summary>
        ///<see href="https://fontawesome.com/icons/won-sign?style=solid"/>
        [Description("Solid Won Sign"), IconID("fas-won-sign"), IconUnicodeGlyph(0xf159)]
        SolidWonSign = 1987,
        ///<summary>Brands WordPress Logo</summary>
        ///<see href="https://fontawesome.com/icons/wordpress?style=brands"/>
        [Description("Brands WordPress Logo"), IconID("fab-wordpress"), IconUnicodeGlyph(0xf19a)]
        BrandsWordpress = 1988,
        ///<summary>Brands Wordpress Simple</summary>
        ///<see href="https://fontawesome.com/icons/wordpress-simple?style=brands"/>
        [Description("Brands Wordpress Simple"), IconID("fab-wordpress-simple"), IconUnicodeGlyph(0xf411)]
        BrandsWordpressSimple = 1989,
        ///<summary>Solid Worm</summary>
        ///<see href="https://fontawesome.com/icons/worm?style=solid"/>
        [Description("Solid Worm"), IconID("fas-worm"), IconUnicodeGlyph(0xe599)]
        SolidWorm = 1990,
        ///<summary>Brands WPBeginner</summary>
        ///<see href="https://fontawesome.com/icons/wpbeginner?style=brands"/>
        [Description("Brands WPBeginner"), IconID("fab-wpbeginner"), IconUnicodeGlyph(0xf297)]
        BrandsWpbeginner = 1991,
        ///<summary>Brands WPExplorer</summary>
        ///<see href="https://fontawesome.com/icons/wpexplorer?style=brands"/>
        [Description("Brands WPExplorer"), IconID("fab-wpexplorer"), IconUnicodeGlyph(0xf2de)]
        BrandsWpexplorer = 1992,
        ///<summary>Brands WPForms</summary>
        ///<see href="https://fontawesome.com/icons/wpforms?style=brands"/>
        [Description("Brands WPForms"), IconID("fab-wpforms"), IconUnicodeGlyph(0xf298)]
        BrandsWpforms = 1993,
        ///<summary>Brands wpressr</summary>
        ///<see href="https://fontawesome.com/icons/wpressr?style=brands"/>
        [Description("Brands wpressr"), IconID("fab-wpressr"), IconUnicodeGlyph(0xf3e4)]
        BrandsWpressr = 1994,
        ///<summary>Solid Wrench</summary>
        ///<see href="https://fontawesome.com/icons/wrench?style=solid"/>
        [Description("Solid Wrench"), IconID("fas-wrench"), IconUnicodeGlyph(0xf0ad)]
        SolidWrench = 1995,
        ///<summary>Solid X</summary>
        ///<see href="https://fontawesome.com/icons/x?style=solid"/>
        [Description("Solid X"), IconID("fas-x"), IconUnicodeGlyph(0x58)]
        SolidX = 1996,
        ///<summary>Solid X-Ray</summary>
        ///<see href="https://fontawesome.com/icons/x-ray?style=solid"/>
        [Description("Solid X-Ray"), IconID("fas-x-ray"), IconUnicodeGlyph(0xf497)]
        SolidXRay = 1997,
        ///<summary>Brands Xbox</summary>
        ///<see href="https://fontawesome.com/icons/xbox?style=brands"/>
        [Description("Brands Xbox"), IconID("fab-xbox"), IconUnicodeGlyph(0xf412)]
        BrandsXbox = 1998,
        ///<summary>Brands Xing</summary>
        ///<see href="https://fontawesome.com/icons/xing?style=brands"/>
        [Description("Brands Xing"), IconID("fab-xing"), IconUnicodeGlyph(0xf168)]
        BrandsXing = 1999,
        ///<summary>Solid X Mark</summary>
        ///<see href="https://fontawesome.com/icons/xmark?style=solid"/>
        [Description("Solid X Mark"), IconID("fas-xmark"), IconUnicodeGlyph(0xf00d)]
        SolidXmark = 2000,
        ///<summary>Solid Xmarks Lines</summary>
        ///<see href="https://fontawesome.com/icons/xmarks-lines?style=solid"/>
        [Description("Solid Xmarks Lines"), IconID("fas-xmarks-lines"), IconUnicodeGlyph(0xe59a)]
        SolidXmarksLines = 2001,
        ///<summary>Solid Y</summary>
        ///<see href="https://fontawesome.com/icons/y?style=solid"/>
        [Description("Solid Y"), IconID("fas-y"), IconUnicodeGlyph(0x59)]
        SolidY = 2002,
        ///<summary>Brands Y Combinator</summary>
        ///<see href="https://fontawesome.com/icons/y-combinator?style=brands"/>
        [Description("Brands Y Combinator"), IconID("fab-y-combinator"), IconUnicodeGlyph(0xf23b)]
        BrandsYCombinator = 2003,
        ///<summary>Brands Yahoo Logo</summary>
        ///<see href="https://fontawesome.com/icons/yahoo?style=brands"/>
        [Description("Brands Yahoo Logo"), IconID("fab-yahoo"), IconUnicodeGlyph(0xf19e)]
        BrandsYahoo = 2004,
        ///<summary>Brands Yammer</summary>
        ///<see href="https://fontawesome.com/icons/yammer?style=brands"/>
        [Description("Brands Yammer"), IconID("fab-yammer"), IconUnicodeGlyph(0xf840)]
        BrandsYammer = 2005,
        ///<summary>Brands Yandex</summary>
        ///<see href="https://fontawesome.com/icons/yandex?style=brands"/>
        [Description("Brands Yandex"), IconID("fab-yandex"), IconUnicodeGlyph(0xf413)]
        BrandsYandex = 2006,
        ///<summary>Brands Yandex International</summary>
        ///<see href="https://fontawesome.com/icons/yandex-international?style=brands"/>
        [Description("Brands Yandex International"), IconID("fab-yandex-international"), IconUnicodeGlyph(0xf414)]
        BrandsYandexInternational = 2007,
        ///<summary>Brands Yarn</summary>
        ///<see href="https://fontawesome.com/icons/yarn?style=brands"/>
        [Description("Brands Yarn"), IconID("fab-yarn"), IconUnicodeGlyph(0xf7e3)]
        BrandsYarn = 2008,
        ///<summary>Brands Yelp</summary>
        ///<see href="https://fontawesome.com/icons/yelp?style=brands"/>
        [Description("Brands Yelp"), IconID("fab-yelp"), IconUnicodeGlyph(0xf1e9)]
        BrandsYelp = 2009,
        ///<summary>Solid Yen Sign</summary>
        ///<see href="https://fontawesome.com/icons/yen-sign?style=solid"/>
        [Description("Solid Yen Sign"), IconID("fas-yen-sign"), IconUnicodeGlyph(0xf157)]
        SolidYenSign = 2010,
        ///<summary>Solid Yin Yang</summary>
        ///<see href="https://fontawesome.com/icons/yin-yang?style=solid"/>
        [Description("Solid Yin Yang"), IconID("fas-yin-yang"), IconUnicodeGlyph(0xf6ad)]
        SolidYinYang = 2011,
        ///<summary>Brands Yoast</summary>
        ///<see href="https://fontawesome.com/icons/yoast?style=brands"/>
        [Description("Brands Yoast"), IconID("fab-yoast"), IconUnicodeGlyph(0xf2b1)]
        BrandsYoast = 2012,
        ///<summary>Brands YouTube</summary>
        ///<see href="https://fontawesome.com/icons/youtube?style=brands"/>
        [Description("Brands YouTube"), IconID("fab-youtube"), IconUnicodeGlyph(0xf167)]
        BrandsYoutube = 2013,
        ///<summary>Solid Z</summary>
        ///<see href="https://fontawesome.com/icons/z?style=solid"/>
        [Description("Solid Z"), IconID("fas-z"), IconUnicodeGlyph(0x5a)]
        SolidZ = 2014,
        ///<summary>Brands Zhihu</summary>
        ///<see href="https://fontawesome.com/icons/zhihu?style=brands"/>
        [Description("Brands Zhihu"), IconID("fab-zhihu"), IconUnicodeGlyph(0xf63f)]
        BrandsZhihu = 2015
    }
}
