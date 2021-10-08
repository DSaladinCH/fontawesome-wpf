﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DSaladin.FontAwesomeWPF
{
    public enum FontAwesomeIcon
    {
        ///<summary>Set this value to show no icon.</summary>
        [Description("None"), IconID("none"), IconUnicodeGlyph(0x0)]
        None = 0x0,
        ///<summary>Brands Steam Symbol</summary>
        ///<see href="https://fontawesome.com/icons/steam-symbol?style=brands"/>
        [Description("Brands Steam Symbol"), IconID("fab-steam-symbol"), IconUnicodeGlyph(0xf3f6)]
        BrandsSteamSymbol = 0,
        ///<summary>Brands Korvue</summary>
        ///<see href="https://fontawesome.com/icons/korvue?style=brands"/>
        [Description("Brands Korvue"), IconID("fab-korvue"), IconUnicodeGlyph(0xf42f)]
        BrandsKorvue = 1,
        ///<summary>Brands Odnoklassniki Square</summary>
        ///<see href="https://fontawesome.com/icons/odnoklassniki-square?style=brands"/>
        [Description("Brands Odnoklassniki Square"), IconID("fab-odnoklassniki-square"), IconUnicodeGlyph(0xf264)]
        BrandsOdnoklassnikiSquare = 2,
        ///<summary>Brands Zhihu</summary>
        ///<see href="https://fontawesome.com/icons/zhihu?style=brands"/>
        [Description("Brands Zhihu"), IconID("fab-zhihu"), IconUnicodeGlyph(0xf63f)]
        BrandsZhihu = 3,
        ///<summary>Brands Intercom</summary>
        ///<see href="https://fontawesome.com/icons/intercom?style=brands"/>
        [Description("Brands Intercom"), IconID("fab-intercom"), IconUnicodeGlyph(0xf7af)]
        BrandsIntercom = 4,
        ///<summary>Brands Google Pay</summary>
        ///<see href="https://fontawesome.com/icons/google-pay?style=brands"/>
        [Description("Brands Google Pay"), IconID("fab-google-pay"), IconUnicodeGlyph(0xe079)]
        BrandsGooglePay = 5,
        ///<summary>Brands Telegram Plane</summary>
        ///<see href="https://fontawesome.com/icons/telegram-plane?style=brands"/>
        [Description("Brands Telegram Plane"), IconID("fab-telegram-plane"), IconUnicodeGlyph(0xf3fe)]
        BrandsTelegramPlane = 6,
        ///<summary>Brands Wodu</summary>
        ///<see href="https://fontawesome.com/icons/wodu?style=brands"/>
        [Description("Brands Wodu"), IconID("fab-wodu"), IconUnicodeGlyph(0xe088)]
        BrandsWodu = 7,
        ///<summary>Brands Git Square</summary>
        ///<see href="https://fontawesome.com/icons/git-square?style=brands"/>
        [Description("Brands Git Square"), IconID("fab-git-square"), IconUnicodeGlyph(0xf1d2)]
        BrandsGitSquare = 8,
        ///<summary>Brands Nutritionix</summary>
        ///<see href="https://fontawesome.com/icons/nutritionix?style=brands"/>
        [Description("Brands Nutritionix"), IconID("fab-nutritionix"), IconUnicodeGlyph(0xf3d6)]
        BrandsNutritionix = 9,
        ///<summary>Brands Wordpress Simple</summary>
        ///<see href="https://fontawesome.com/icons/wordpress-simple?style=brands"/>
        [Description("Brands Wordpress Simple"), IconID("fab-wordpress-simple"), IconUnicodeGlyph(0xf411)]
        BrandsWordpressSimple = 10,
        ///<summary>Brands Pushed</summary>
        ///<see href="https://fontawesome.com/icons/pushed?style=brands"/>
        [Description("Brands Pushed"), IconID("fab-pushed"), IconUnicodeGlyph(0xf3e1)]
        BrandsPushed = 11,
        ///<summary>Brands Teamspeak</summary>
        ///<see href="https://fontawesome.com/icons/teamspeak?style=brands"/>
        [Description("Brands Teamspeak"), IconID("fab-teamspeak"), IconUnicodeGlyph(0xf4f9)]
        BrandsTeamspeak = 12,
        ///<summary>Brands Canadian Maple Leaf</summary>
        ///<see href="https://fontawesome.com/icons/canadian-maple-leaf?style=brands"/>
        [Description("Brands Canadian Maple Leaf"), IconID("fab-canadian-maple-leaf"), IconUnicodeGlyph(0xf785)]
        BrandsCanadianMapleLeaf = 13,
        ///<summary>Brands Ember</summary>
        ///<see href="https://fontawesome.com/icons/ember?style=brands"/>
        [Description("Brands Ember"), IconID("fab-ember"), IconUnicodeGlyph(0xf423)]
        BrandsEmber = 14,
        ///<summary>Brands Strava</summary>
        ///<see href="https://fontawesome.com/icons/strava?style=brands"/>
        [Description("Brands Strava"), IconID("fab-strava"), IconUnicodeGlyph(0xf428)]
        BrandsStrava = 15,
        ///<summary>Brands Creative Commons Sampling Plus</summary>
        ///<see href="https://fontawesome.com/icons/creative-commons-sampling-plus?style=brands"/>
        [Description("Brands Creative Commons Sampling Plus"), IconID("fab-creative-commons-sampling-plus"), IconUnicodeGlyph(0xf4f1)]
        BrandsCreativeCommonsSamplingPlus = 16,
        ///<summary>Brands Gulp</summary>
        ///<see href="https://fontawesome.com/icons/gulp?style=brands"/>
        [Description("Brands Gulp"), IconID("fab-gulp"), IconUnicodeGlyph(0xf3ae)]
        BrandsGulp = 17,
        ///<summary>Brands Buy N Large</summary>
        ///<see href="https://fontawesome.com/icons/buy-n-large?style=brands"/>
        [Description("Brands Buy N Large"), IconID("fab-buy-n-large"), IconUnicodeGlyph(0xf8a6)]
        BrandsBuyNLarge = 18,
        ///<summary>Brands Wolf Pack Battalion</summary>
        ///<see href="https://fontawesome.com/icons/wolf-pack-battalion?style=brands"/>
        [Description("Brands Wolf Pack Battalion"), IconID("fab-wolf-pack-battalion"), IconUnicodeGlyph(0xf514)]
        BrandsWolfPackBattalion = 19,
        ///<summary>Brands Airbnb</summary>
        ///<see href="https://fontawesome.com/icons/airbnb?style=brands"/>
        [Description("Brands Airbnb"), IconID("fab-airbnb"), IconUnicodeGlyph(0xf834)]
        BrandsAirbnb = 20,
        ///<summary>Brands Mastodon</summary>
        ///<see href="https://fontawesome.com/icons/mastodon?style=brands"/>
        [Description("Brands Mastodon"), IconID("fab-mastodon"), IconUnicodeGlyph(0xf4f6)]
        BrandsMastodon = 21,
        ///<summary>Brands Joomla</summary>
        ///<see href="https://fontawesome.com/icons/joomla?style=brands"/>
        [Description("Brands Joomla"), IconID("fab-joomla"), IconUnicodeGlyph(0xf1aa)]
        BrandsJoomla = 22,
        ///<summary>Brands Discourse</summary>
        ///<see href="https://fontawesome.com/icons/discourse?style=brands"/>
        [Description("Brands Discourse"), IconID("fab-discourse"), IconUnicodeGlyph(0xf393)]
        BrandsDiscourse = 23,
        ///<summary>Brands Critical Role</summary>
        ///<see href="https://fontawesome.com/icons/critical-role?style=brands"/>
        [Description("Brands Critical Role"), IconID("fab-critical-role"), IconUnicodeGlyph(0xf6c9)]
        BrandsCriticalRole = 24,
        ///<summary>Brands Viacoin</summary>
        ///<see href="https://fontawesome.com/icons/viacoin?style=brands"/>
        [Description("Brands Viacoin"), IconID("fab-viacoin"), IconUnicodeGlyph(0xf237)]
        BrandsViacoin = 25,
        ///<summary>Brands Pinterest Square</summary>
        ///<see href="https://fontawesome.com/icons/pinterest-square?style=brands"/>
        [Description("Brands Pinterest Square"), IconID("fab-pinterest-square"), IconUnicodeGlyph(0xf0d3)]
        BrandsPinterestSquare = 26,
        ///<summary>Brands Flipboard</summary>
        ///<see href="https://fontawesome.com/icons/flipboard?style=brands"/>
        [Description("Brands Flipboard"), IconID("fab-flipboard"), IconUnicodeGlyph(0xf44d)]
        BrandsFlipboard = 27,
        ///<summary>Brands Mixcloud</summary>
        ///<see href="https://fontawesome.com/icons/mixcloud?style=brands"/>
        [Description("Brands Mixcloud"), IconID("fab-mixcloud"), IconUnicodeGlyph(0xf289)]
        BrandsMixcloud = 28,
        ///<summary>Brands Amilia</summary>
        ///<see href="https://fontawesome.com/icons/amilia?style=brands"/>
        [Description("Brands Amilia"), IconID("fab-amilia"), IconUnicodeGlyph(0xf36d)]
        BrandsAmilia = 29,
        ///<summary>Brands Medium</summary>
        ///<see href="https://fontawesome.com/icons/medium?style=brands"/>
        [Description("Brands Medium"), IconID("fab-medium"), IconUnicodeGlyph(0xf23a)]
        BrandsMedium = 30,
        ///<summary>Brands Reacteurope</summary>
        ///<see href="https://fontawesome.com/icons/reacteurope?style=brands"/>
        [Description("Brands Reacteurope"), IconID("fab-reacteurope"), IconUnicodeGlyph(0xf75d)]
        BrandsReacteurope = 31,
        ///<summary>Brands Quora</summary>
        ///<see href="https://fontawesome.com/icons/quora?style=brands"/>
        [Description("Brands Quora"), IconID("fab-quora"), IconUnicodeGlyph(0xf2c4)]
        BrandsQuora = 32,
        ///<summary>Brands Vaadin</summary>
        ///<see href="https://fontawesome.com/icons/vaadin?style=brands"/>
        [Description("Brands Vaadin"), IconID("fab-vaadin"), IconUnicodeGlyph(0xf408)]
        BrandsVaadin = 33,
        ///<summary>Brands Tumblr</summary>
        ///<see href="https://fontawesome.com/icons/tumblr?style=brands"/>
        [Description("Brands Tumblr"), IconID("fab-tumblr"), IconUnicodeGlyph(0xf173)]
        BrandsTumblr = 34,
        ///<summary>Brands Usb</summary>
        ///<see href="https://fontawesome.com/icons/usb?style=brands"/>
        [Description("Brands Usb"), IconID("fab-usb"), IconUnicodeGlyph(0xf287)]
        BrandsUsb = 35,
        ///<summary>Brands Medrt</summary>
        ///<see href="https://fontawesome.com/icons/medrt?style=brands"/>
        [Description("Brands Medrt"), IconID("fab-medrt"), IconUnicodeGlyph(0xf3c8)]
        BrandsMedrt = 36,
        ///<summary>Brands Slack</summary>
        ///<see href="https://fontawesome.com/icons/slack?style=brands"/>
        [Description("Brands Slack"), IconID("fab-slack"), IconUnicodeGlyph(0xf198)]
        BrandsSlack = 37,
        ///<summary>Brands Edge Legacy</summary>
        ///<see href="https://fontawesome.com/icons/edge-legacy?style=brands"/>
        [Description("Brands Edge Legacy"), IconID("fab-edge-legacy"), IconUnicodeGlyph(0xe078)]
        BrandsEdgeLegacy = 38,
        ///<summary>Brands Node Js</summary>
        ///<see href="https://fontawesome.com/icons/node-js?style=brands"/>
        [Description("Brands Node Js"), IconID("fab-node-js"), IconUnicodeGlyph(0xf3d3)]
        BrandsNodeJs = 39,
        ///<summary>Brands Old Republic</summary>
        ///<see href="https://fontawesome.com/icons/old-republic?style=brands"/>
        [Description("Brands Old Republic"), IconID("fab-old-republic"), IconUnicodeGlyph(0xf510)]
        BrandsOldRepublic = 40,
        ///<summary>Brands Telegram</summary>
        ///<see href="https://fontawesome.com/icons/telegram?style=brands"/>
        [Description("Brands Telegram"), IconID("fab-telegram"), IconUnicodeGlyph(0xf2c6)]
        BrandsTelegram = 41,
        ///<summary>Brands Internet Explorer</summary>
        ///<see href="https://fontawesome.com/icons/internet-explorer?style=brands"/>
        [Description("Brands Internet Explorer"), IconID("fab-internet-explorer"), IconUnicodeGlyph(0xf26b)]
        BrandsInternetExplorer = 42,
        ///<summary>Brands Stumbleupon Circle</summary>
        ///<see href="https://fontawesome.com/icons/stumbleupon-circle?style=brands"/>
        [Description("Brands Stumbleupon Circle"), IconID("fab-stumbleupon-circle"), IconUnicodeGlyph(0xf1a3)]
        BrandsStumbleuponCircle = 43,
        ///<summary>Brands Dribbble</summary>
        ///<see href="https://fontawesome.com/icons/dribbble?style=brands"/>
        [Description("Brands Dribbble"), IconID("fab-dribbble"), IconUnicodeGlyph(0xf17d)]
        BrandsDribbble = 44,
        ///<summary>Brands Btc</summary>
        ///<see href="https://fontawesome.com/icons/btc?style=brands"/>
        [Description("Brands Btc"), IconID("fab-btc"), IconUnicodeGlyph(0xf15a)]
        BrandsBtc = 45,
        ///<summary>Brands Yammer</summary>
        ///<see href="https://fontawesome.com/icons/yammer?style=brands"/>
        [Description("Brands Yammer"), IconID("fab-yammer"), IconUnicodeGlyph(0xf840)]
        BrandsYammer = 46,
        ///<summary>Brands Npm</summary>
        ///<see href="https://fontawesome.com/icons/npm?style=brands"/>
        [Description("Brands Npm"), IconID("fab-npm"), IconUnicodeGlyph(0xf3d4)]
        BrandsNpm = 47,
        ///<summary>Brands Buffer</summary>
        ///<see href="https://fontawesome.com/icons/buffer?style=brands"/>
        [Description("Brands Buffer"), IconID("fab-buffer"), IconUnicodeGlyph(0xf837)]
        BrandsBuffer = 48,
        ///<summary>Brands Pinterest</summary>
        ///<see href="https://fontawesome.com/icons/pinterest?style=brands"/>
        [Description("Brands Pinterest"), IconID("fab-pinterest"), IconUnicodeGlyph(0xf0d2)]
        BrandsPinterest = 49,
        ///<summary>Brands Rockrms</summary>
        ///<see href="https://fontawesome.com/icons/rockrms?style=brands"/>
        [Description("Brands Rockrms"), IconID("fab-rockrms"), IconUnicodeGlyph(0xf3e9)]
        BrandsRockrms = 50,
        ///<summary>Brands Twitter</summary>
        ///<see href="https://fontawesome.com/icons/twitter?style=brands"/>
        [Description("Brands Twitter"), IconID("fab-twitter"), IconUnicodeGlyph(0xf099)]
        BrandsTwitter = 51,
        ///<summary>Brands Jenkins</summary>
        ///<see href="https://fontawesome.com/icons/jenkins?style=brands"/>
        [Description("Brands Jenkins"), IconID("fab-jenkins"), IconUnicodeGlyph(0xf3b6)]
        BrandsJenkins = 52,
        ///<summary>Brands Suse</summary>
        ///<see href="https://fontawesome.com/icons/suse?style=brands"/>
        [Description("Brands Suse"), IconID("fab-suse"), IconUnicodeGlyph(0xf7d6)]
        BrandsSuse = 53,
        ///<summary>Brands Replyd</summary>
        ///<see href="https://fontawesome.com/icons/replyd?style=brands"/>
        [Description("Brands Replyd"), IconID("fab-replyd"), IconUnicodeGlyph(0xf3e6)]
        BrandsReplyd = 54,
        ///<summary>Brands Behance Square</summary>
        ///<see href="https://fontawesome.com/icons/behance-square?style=brands"/>
        [Description("Brands Behance Square"), IconID("fab-behance-square"), IconUnicodeGlyph(0xf1b5)]
        BrandsBehanceSquare = 55,
        ///<summary>Brands Firefox Browser</summary>
        ///<see href="https://fontawesome.com/icons/firefox-browser?style=brands"/>
        [Description("Brands Firefox Browser"), IconID("fab-firefox-browser"), IconUnicodeGlyph(0xe007)]
        BrandsFirefoxBrowser = 56,
        ///<summary>Brands Skyatlas</summary>
        ///<see href="https://fontawesome.com/icons/skyatlas?style=brands"/>
        [Description("Brands Skyatlas"), IconID("fab-skyatlas"), IconUnicodeGlyph(0xf216)]
        BrandsSkyatlas = 57,
        ///<summary>Brands Youtube</summary>
        ///<see href="https://fontawesome.com/icons/youtube?style=brands"/>
        [Description("Brands Youtube"), IconID("fab-youtube"), IconUnicodeGlyph(0xf167)]
        BrandsYoutube = 58,
        ///<summary>Brands Alipay</summary>
        ///<see href="https://fontawesome.com/icons/alipay?style=brands"/>
        [Description("Brands Alipay"), IconID("fab-alipay"), IconUnicodeGlyph(0xf642)]
        BrandsAlipay = 59,
        ///<summary>Brands Php</summary>
        ///<see href="https://fontawesome.com/icons/php?style=brands"/>
        [Description("Brands Php"), IconID("fab-php"), IconUnicodeGlyph(0xf457)]
        BrandsPhp = 60,
        ///<summary>Brands Github</summary>
        ///<see href="https://fontawesome.com/icons/github?style=brands"/>
        [Description("Brands Github"), IconID("fab-github"), IconUnicodeGlyph(0xf09b)]
        BrandsGithub = 61,
        ///<summary>Brands Uber</summary>
        ///<see href="https://fontawesome.com/icons/uber?style=brands"/>
        [Description("Brands Uber"), IconID("fab-uber"), IconUnicodeGlyph(0xf402)]
        BrandsUber = 62,
        ///<summary>Brands Cc Amex</summary>
        ///<see href="https://fontawesome.com/icons/cc-amex?style=brands"/>
        [Description("Brands Cc Amex"), IconID("fab-cc-amex"), IconUnicodeGlyph(0xf1f3)]
        BrandsCcAmex = 63,
        ///<summary>Brands Yandex International</summary>
        ///<see href="https://fontawesome.com/icons/yandex-international?style=brands"/>
        [Description("Brands Yandex International"), IconID("fab-yandex-international"), IconUnicodeGlyph(0xf414)]
        BrandsYandexInternational = 64,
        ///<summary>Brands Sketch</summary>
        ///<see href="https://fontawesome.com/icons/sketch?style=brands"/>
        [Description("Brands Sketch"), IconID("fab-sketch"), IconUnicodeGlyph(0xf7c6)]
        BrandsSketch = 65,
        ///<summary>Brands Dev</summary>
        ///<see href="https://fontawesome.com/icons/dev?style=brands"/>
        [Description("Brands Dev"), IconID("fab-dev"), IconUnicodeGlyph(0xf6cc)]
        BrandsDev = 66,
        ///<summary>Brands Git</summary>
        ///<see href="https://fontawesome.com/icons/git?style=brands"/>
        [Description("Brands Git"), IconID("fab-git"), IconUnicodeGlyph(0xf1d3)]
        BrandsGit = 67,
        ///<summary>Brands Ideal</summary>
        ///<see href="https://fontawesome.com/icons/ideal?style=brands"/>
        [Description("Brands Ideal"), IconID("fab-ideal"), IconUnicodeGlyph(0xe013)]
        BrandsIdeal = 68,
        ///<summary>Brands Js</summary>
        ///<see href="https://fontawesome.com/icons/js?style=brands"/>
        [Description("Brands Js"), IconID("fab-js"), IconUnicodeGlyph(0xf3b8)]
        BrandsJs = 69,
        ///<summary>Brands Hornbill</summary>
        ///<see href="https://fontawesome.com/icons/hornbill?style=brands"/>
        [Description("Brands Hornbill"), IconID("fab-hornbill"), IconUnicodeGlyph(0xf592)]
        BrandsHornbill = 70,
        ///<summary>Brands Free Code Camp</summary>
        ///<see href="https://fontawesome.com/icons/free-code-camp?style=brands"/>
        [Description("Brands Free Code Camp"), IconID("fab-free-code-camp"), IconUnicodeGlyph(0xf2c5)]
        BrandsFreeCodeCamp = 71,
        ///<summary>Brands Android</summary>
        ///<see href="https://fontawesome.com/icons/android?style=brands"/>
        [Description("Brands Android"), IconID("fab-android"), IconUnicodeGlyph(0xf17b)]
        BrandsAndroid = 72,
        ///<summary>Brands Python</summary>
        ///<see href="https://fontawesome.com/icons/python?style=brands"/>
        [Description("Brands Python"), IconID("fab-python"), IconUnicodeGlyph(0xf3e2)]
        BrandsPython = 73,
        ///<summary>Brands Github Square</summary>
        ///<see href="https://fontawesome.com/icons/github-square?style=brands"/>
        [Description("Brands Github Square"), IconID("fab-github-square"), IconUnicodeGlyph(0xf092)]
        BrandsGithubSquare = 74,
        ///<summary>Brands Themeco</summary>
        ///<see href="https://fontawesome.com/icons/themeco?style=brands"/>
        [Description("Brands Themeco"), IconID("fab-themeco"), IconUnicodeGlyph(0xf5c6)]
        BrandsThemeco = 75,
        ///<summary>Brands Black Tie</summary>
        ///<see href="https://fontawesome.com/icons/black-tie?style=brands"/>
        [Description("Brands Black Tie"), IconID("fab-black-tie"), IconUnicodeGlyph(0xf27e)]
        BrandsBlackTie = 76,
        ///<summary>Brands Leanpub</summary>
        ///<see href="https://fontawesome.com/icons/leanpub?style=brands"/>
        [Description("Brands Leanpub"), IconID("fab-leanpub"), IconUnicodeGlyph(0xf212)]
        BrandsLeanpub = 77,
        ///<summary>Brands Connectdevelop</summary>
        ///<see href="https://fontawesome.com/icons/connectdevelop?style=brands"/>
        [Description("Brands Connectdevelop"), IconID("fab-connectdevelop"), IconUnicodeGlyph(0xf20e)]
        BrandsConnectdevelop = 78,
        ///<summary>Brands Weebly</summary>
        ///<see href="https://fontawesome.com/icons/weebly?style=brands"/>
        [Description("Brands Weebly"), IconID("fab-weebly"), IconUnicodeGlyph(0xf5cc)]
        BrandsWeebly = 79,
        ///<summary>Brands Grunt</summary>
        ///<see href="https://fontawesome.com/icons/grunt?style=brands"/>
        [Description("Brands Grunt"), IconID("fab-grunt"), IconUnicodeGlyph(0xf3ad)]
        BrandsGrunt = 80,
        ///<summary>Brands Perbyte</summary>
        ///<see href="https://fontawesome.com/icons/perbyte?style=brands"/>
        [Description("Brands Perbyte"), IconID("fab-perbyte"), IconUnicodeGlyph(0xe083)]
        BrandsPerbyte = 81,
        ///<summary>Brands Get Pocket</summary>
        ///<see href="https://fontawesome.com/icons/get-pocket?style=brands"/>
        [Description("Brands Get Pocket"), IconID("fab-get-pocket"), IconUnicodeGlyph(0xf265)]
        BrandsGetPocket = 82,
        ///<summary>Brands Creative Commons Nc Jp</summary>
        ///<see href="https://fontawesome.com/icons/creative-commons-nc-jp?style=brands"/>
        [Description("Brands Creative Commons Nc Jp"), IconID("fab-creative-commons-nc-jp"), IconUnicodeGlyph(0xf4ea)]
        BrandsCreativeCommonsNcJp = 83,
        ///<summary>Brands Trello</summary>
        ///<see href="https://fontawesome.com/icons/trello?style=brands"/>
        [Description("Brands Trello"), IconID("fab-trello"), IconUnicodeGlyph(0xf181)]
        BrandsTrello = 84,
        ///<summary>Brands Goodreads G</summary>
        ///<see href="https://fontawesome.com/icons/goodreads-g?style=brands"/>
        [Description("Brands Goodreads G"), IconID("fab-goodreads-g"), IconUnicodeGlyph(0xf3a9)]
        BrandsGoodreadsG = 85,
        ///<summary>Brands Cpanel</summary>
        ///<see href="https://fontawesome.com/icons/cpanel?style=brands"/>
        [Description("Brands Cpanel"), IconID("fab-cpanel"), IconUnicodeGlyph(0xf388)]
        BrandsCpanel = 86,
        ///<summary>Brands Deviantart</summary>
        ///<see href="https://fontawesome.com/icons/deviantart?style=brands"/>
        [Description("Brands Deviantart"), IconID("fab-deviantart"), IconUnicodeGlyph(0xf1bd)]
        BrandsDeviantart = 87,
        ///<summary>Brands Kaggle</summary>
        ///<see href="https://fontawesome.com/icons/kaggle?style=brands"/>
        [Description("Brands Kaggle"), IconID("fab-kaggle"), IconUnicodeGlyph(0xf5fa)]
        BrandsKaggle = 88,
        ///<summary>Brands Staylinked</summary>
        ///<see href="https://fontawesome.com/icons/staylinked?style=brands"/>
        [Description("Brands Staylinked"), IconID("fab-staylinked"), IconUnicodeGlyph(0xf3f5)]
        BrandsStaylinked = 89,
        ///<summary>Brands Css3</summary>
        ///<see href="https://fontawesome.com/icons/css3?style=brands"/>
        [Description("Brands Css3"), IconID("fab-css3"), IconUnicodeGlyph(0xf13c)]
        BrandsCss3 = 90,
        ///<summary>Brands Rebel</summary>
        ///<see href="https://fontawesome.com/icons/rebel?style=brands"/>
        [Description("Brands Rebel"), IconID("fab-rebel"), IconUnicodeGlyph(0xf1d0)]
        BrandsRebel = 91,
        ///<summary>Brands Supple</summary>
        ///<see href="https://fontawesome.com/icons/supple?style=brands"/>
        [Description("Brands Supple"), IconID("fab-supple"), IconUnicodeGlyph(0xf3f9)]
        BrandsSupple = 92,
        ///<summary>Brands Pied Piper Square</summary>
        ///<see href="https://fontawesome.com/icons/pied-piper-square?style=brands"/>
        [Description("Brands Pied Piper Square"), IconID("fab-pied-piper-square"), IconUnicodeGlyph(0xe01e)]
        BrandsPiedPiperSquare = 93,
        ///<summary>Brands Wix</summary>
        ///<see href="https://fontawesome.com/icons/wix?style=brands"/>
        [Description("Brands Wix"), IconID("fab-wix"), IconUnicodeGlyph(0xf5cf)]
        BrandsWix = 94,
        ///<summary>Brands Rust</summary>
        ///<see href="https://fontawesome.com/icons/rust?style=brands"/>
        [Description("Brands Rust"), IconID("fab-rust"), IconUnicodeGlyph(0xe07a)]
        BrandsRust = 95,
        ///<summary>Brands Fantasy Flight Games</summary>
        ///<see href="https://fontawesome.com/icons/fantasy-flight-games?style=brands"/>
        [Description("Brands Fantasy Flight Games"), IconID("fab-fantasy-flight-games"), IconUnicodeGlyph(0xf6dc)]
        BrandsFantasyFlightGames = 96,
        ///<summary>Brands Snapchat</summary>
        ///<see href="https://fontawesome.com/icons/snapchat?style=brands"/>
        [Description("Brands Snapchat"), IconID("fab-snapchat"), IconUnicodeGlyph(0xf2ab)]
        BrandsSnapchat = 97,
        ///<summary>Brands Cc Jcb</summary>
        ///<see href="https://fontawesome.com/icons/cc-jcb?style=brands"/>
        [Description("Brands Cc Jcb"), IconID("fab-cc-jcb"), IconUnicodeGlyph(0xf24b)]
        BrandsCcJcb = 98,
        ///<summary>Brands Waze</summary>
        ///<see href="https://fontawesome.com/icons/waze?style=brands"/>
        [Description("Brands Waze"), IconID("fab-waze"), IconUnicodeGlyph(0xf83f)]
        BrandsWaze = 99,
        ///<summary>Brands Fort Awesome</summary>
        ///<see href="https://fontawesome.com/icons/fort-awesome?style=brands"/>
        [Description("Brands Fort Awesome"), IconID("fab-fort-awesome"), IconUnicodeGlyph(0xf286)]
        BrandsFortAwesome = 100,
        ///<summary>Brands Font Awesome Logo Full</summary>
        ///<see href="https://fontawesome.com/icons/font-awesome-logo-full?style=brands"/>
        [Description("Brands Font Awesome Logo Full"), IconID("fab-font-awesome-logo-full"), IconUnicodeGlyph(0xf4e6)]
        BrandsFontAwesomeLogoFull = 101,
        ///<summary>Brands Apper</summary>
        ///<see href="https://fontawesome.com/icons/apper?style=brands"/>
        [Description("Brands Apper"), IconID("fab-apper"), IconUnicodeGlyph(0xf371)]
        BrandsApper = 102,
        ///<summary>Brands Pinterest P</summary>
        ///<see href="https://fontawesome.com/icons/pinterest-p?style=brands"/>
        [Description("Brands Pinterest P"), IconID("fab-pinterest-p"), IconUnicodeGlyph(0xf231)]
        BrandsPinterestP = 103,
        ///<summary>Brands Ns8</summary>
        ///<see href="https://fontawesome.com/icons/ns8?style=brands"/>
        [Description("Brands Ns8"), IconID("fab-ns8"), IconUnicodeGlyph(0xf3d5)]
        BrandsNs8 = 104,
        ///<summary>Brands Medapps</summary>
        ///<see href="https://fontawesome.com/icons/medapps?style=brands"/>
        [Description("Brands Medapps"), IconID("fab-medapps"), IconUnicodeGlyph(0xf3c6)]
        BrandsMedapps = 105,
        ///<summary>Brands Font Awesome Alt</summary>
        ///<see href="https://fontawesome.com/icons/font-awesome-alt?style=brands"/>
        [Description("Brands Font Awesome Alt"), IconID("fab-font-awesome-alt"), IconUnicodeGlyph(0xf35c)]
        BrandsFontAwesomeAlt = 106,
        ///<summary>Brands Octopus Deploy</summary>
        ///<see href="https://fontawesome.com/icons/octopus-deploy?style=brands"/>
        [Description("Brands Octopus Deploy"), IconID("fab-octopus-deploy"), IconUnicodeGlyph(0xe082)]
        BrandsOctopusDeploy = 107,
        ///<summary>Brands Salesforce</summary>
        ///<see href="https://fontawesome.com/icons/salesforce?style=brands"/>
        [Description("Brands Salesforce"), IconID("fab-salesforce"), IconUnicodeGlyph(0xf83b)]
        BrandsSalesforce = 108,
        ///<summary>Brands Buromobelexperte</summary>
        ///<see href="https://fontawesome.com/icons/buromobelexperte?style=brands"/>
        [Description("Brands Buromobelexperte"), IconID("fab-buromobelexperte"), IconUnicodeGlyph(0xf37f)]
        BrandsBuromobelexperte = 109,
        ///<summary>Brands Sass</summary>
        ///<see href="https://fontawesome.com/icons/sass?style=brands"/>
        [Description("Brands Sass"), IconID("fab-sass"), IconUnicodeGlyph(0xf41e)]
        BrandsSass = 110,
        ///<summary>Brands Sellsy</summary>
        ///<see href="https://fontawesome.com/icons/sellsy?style=brands"/>
        [Description("Brands Sellsy"), IconID("fab-sellsy"), IconUnicodeGlyph(0xf213)]
        BrandsSellsy = 111,
        ///<summary>Brands Html5</summary>
        ///<see href="https://fontawesome.com/icons/html5?style=brands"/>
        [Description("Brands Html5"), IconID("fab-html5"), IconUnicodeGlyph(0xf13b)]
        BrandsHtml5 = 112,
        ///<summary>Brands Readme</summary>
        ///<see href="https://fontawesome.com/icons/readme?style=brands"/>
        [Description("Brands Readme"), IconID("fab-readme"), IconUnicodeGlyph(0xf4d5)]
        BrandsReadme = 113,
        ///<summary>Brands Yandex</summary>
        ///<see href="https://fontawesome.com/icons/yandex?style=brands"/>
        [Description("Brands Yandex"), IconID("fab-yandex"), IconUnicodeGlyph(0xf413)]
        BrandsYandex = 114,
        ///<summary>Brands Kickstarter K</summary>
        ///<see href="https://fontawesome.com/icons/kickstarter-k?style=brands"/>
        [Description("Brands Kickstarter K"), IconID("fab-kickstarter-k"), IconUnicodeGlyph(0xf3bc)]
        BrandsKickstarterK = 115,
        ///<summary>Brands Pied Piper Hat</summary>
        ///<see href="https://fontawesome.com/icons/pied-piper-hat?style=brands"/>
        [Description("Brands Pied Piper Hat"), IconID("fab-pied-piper-hat"), IconUnicodeGlyph(0xf4e5)]
        BrandsPiedPiperHat = 116,
        ///<summary>Brands Gg Circle</summary>
        ///<see href="https://fontawesome.com/icons/gg-circle?style=brands"/>
        [Description("Brands Gg Circle"), IconID("fab-gg-circle"), IconUnicodeGlyph(0xf261)]
        BrandsGgCircle = 117,
        ///<summary>Brands Cc Diners Club</summary>
        ///<see href="https://fontawesome.com/icons/cc-diners-club?style=brands"/>
        [Description("Brands Cc Diners Club"), IconID("fab-cc-diners-club"), IconUnicodeGlyph(0xf24c)]
        BrandsCcDinersClub = 118,
        ///<summary>Brands Microblog</summary>
        ///<see href="https://fontawesome.com/icons/microblog?style=brands"/>
        [Description("Brands Microblog"), IconID("fab-microblog"), IconUnicodeGlyph(0xe01a)]
        BrandsMicroblog = 119,
        ///<summary>Brands D And D</summary>
        ///<see href="https://fontawesome.com/icons/d-and-d?style=brands"/>
        [Description("Brands D And D"), IconID("fab-d-and-d"), IconUnicodeGlyph(0xf38d)]
        BrandsDAndD = 120,
        ///<summary>Brands Gitter</summary>
        ///<see href="https://fontawesome.com/icons/gitter?style=brands"/>
        [Description("Brands Gitter"), IconID("fab-gitter"), IconUnicodeGlyph(0xf426)]
        BrandsGitter = 121,
        ///<summary>Brands Bluetooth</summary>
        ///<see href="https://fontawesome.com/icons/bluetooth?style=brands"/>
        [Description("Brands Bluetooth"), IconID("fab-bluetooth"), IconUnicodeGlyph(0xf293)]
        BrandsBluetooth = 122,
        ///<summary>Brands Docker</summary>
        ///<see href="https://fontawesome.com/icons/docker?style=brands"/>
        [Description("Brands Docker"), IconID("fab-docker"), IconUnicodeGlyph(0xf395)]
        BrandsDocker = 123,
        ///<summary>Brands Jira</summary>
        ///<see href="https://fontawesome.com/icons/jira?style=brands"/>
        [Description("Brands Jira"), IconID("fab-jira"), IconUnicodeGlyph(0xf7b1)]
        BrandsJira = 124,
        ///<summary>Brands Raspberry Pi</summary>
        ///<see href="https://fontawesome.com/icons/raspberry-pi?style=brands"/>
        [Description("Brands Raspberry Pi"), IconID("fab-raspberry-pi"), IconUnicodeGlyph(0xf7bb)]
        BrandsRaspberryPi = 125,
        ///<summary>Brands Deezer</summary>
        ///<see href="https://fontawesome.com/icons/deezer?style=brands"/>
        [Description("Brands Deezer"), IconID("fab-deezer"), IconUnicodeGlyph(0xe077)]
        BrandsDeezer = 126,
        ///<summary>Brands Imdb</summary>
        ///<see href="https://fontawesome.com/icons/imdb?style=brands"/>
        [Description("Brands Imdb"), IconID("fab-imdb"), IconUnicodeGlyph(0xf2d8)]
        BrandsImdb = 127,
        ///<summary>Brands Bitbucket</summary>
        ///<see href="https://fontawesome.com/icons/bitbucket?style=brands"/>
        [Description("Brands Bitbucket"), IconID("fab-bitbucket"), IconUnicodeGlyph(0xf171)]
        BrandsBitbucket = 128,
        ///<summary>Brands Simplybuilt</summary>
        ///<see href="https://fontawesome.com/icons/simplybuilt?style=brands"/>
        [Description("Brands Simplybuilt"), IconID("fab-simplybuilt"), IconUnicodeGlyph(0xf215)]
        BrandsSimplybuilt = 129,
        ///<summary>Brands Servicestack</summary>
        ///<see href="https://fontawesome.com/icons/servicestack?style=brands"/>
        [Description("Brands Servicestack"), IconID("fab-servicestack"), IconUnicodeGlyph(0xf3ec)]
        BrandsServicestack = 130,
        ///<summary>Brands Google Drive</summary>
        ///<see href="https://fontawesome.com/icons/google-drive?style=brands"/>
        [Description("Brands Google Drive"), IconID("fab-google-drive"), IconUnicodeGlyph(0xf3aa)]
        BrandsGoogleDrive = 131,
        ///<summary>Brands Line</summary>
        ///<see href="https://fontawesome.com/icons/line?style=brands"/>
        [Description("Brands Line"), IconID("fab-line"), IconUnicodeGlyph(0xf3c0)]
        BrandsLine = 132,
        ///<summary>Brands Viadeo</summary>
        ///<see href="https://fontawesome.com/icons/viadeo?style=brands"/>
        [Description("Brands Viadeo"), IconID("fab-viadeo"), IconUnicodeGlyph(0xf2a9)]
        BrandsViadeo = 133,
        ///<summary>Brands Google Play</summary>
        ///<see href="https://fontawesome.com/icons/google-play?style=brands"/>
        [Description("Brands Google Play"), IconID("fab-google-play"), IconUnicodeGlyph(0xf3ab)]
        BrandsGooglePlay = 134,
        ///<summary>Brands Slideshare</summary>
        ///<see href="https://fontawesome.com/icons/slideshare?style=brands"/>
        [Description("Brands Slideshare"), IconID("fab-slideshare"), IconUnicodeGlyph(0xf1e7)]
        BrandsSlideshare = 135,
        ///<summary>Brands Whatsapp</summary>
        ///<see href="https://fontawesome.com/icons/whatsapp?style=brands"/>
        [Description("Brands Whatsapp"), IconID("fab-whatsapp"), IconUnicodeGlyph(0xf232)]
        BrandsWhatsapp = 136,
        ///<summary>Brands Autoprefixer</summary>
        ///<see href="https://fontawesome.com/icons/autoprefixer?style=brands"/>
        [Description("Brands Autoprefixer"), IconID("fab-autoprefixer"), IconUnicodeGlyph(0xf41c)]
        BrandsAutoprefixer = 137,
        ///<summary>Brands Trade Federation</summary>
        ///<see href="https://fontawesome.com/icons/trade-federation?style=brands"/>
        [Description("Brands Trade Federation"), IconID("fab-trade-federation"), IconUnicodeGlyph(0xf513)]
        BrandsTradeFederation = 138,
        ///<summary>Brands Earlybirds</summary>
        ///<see href="https://fontawesome.com/icons/earlybirds?style=brands"/>
        [Description("Brands Earlybirds"), IconID("fab-earlybirds"), IconUnicodeGlyph(0xf39a)]
        BrandsEarlybirds = 139,
        ///<summary>Brands Ussunnah</summary>
        ///<see href="https://fontawesome.com/icons/ussunnah?style=brands"/>
        [Description("Brands Ussunnah"), IconID("fab-ussunnah"), IconUnicodeGlyph(0xf407)]
        BrandsUssunnah = 140,
        ///<summary>Brands Phabricator</summary>
        ///<see href="https://fontawesome.com/icons/phabricator?style=brands"/>
        [Description("Brands Phabricator"), IconID("fab-phabricator"), IconUnicodeGlyph(0xf3db)]
        BrandsPhabricator = 141,
        ///<summary>Brands Fort Awesome Alt</summary>
        ///<see href="https://fontawesome.com/icons/fort-awesome-alt?style=brands"/>
        [Description("Brands Fort Awesome Alt"), IconID("fab-fort-awesome-alt"), IconUnicodeGlyph(0xf3a3)]
        BrandsFortAwesomeAlt = 142,
        ///<summary>Brands Uikit</summary>
        ///<see href="https://fontawesome.com/icons/uikit?style=brands"/>
        [Description("Brands Uikit"), IconID("fab-uikit"), IconUnicodeGlyph(0xf403)]
        BrandsUikit = 143,
        ///<summary>Brands Jedi Order</summary>
        ///<see href="https://fontawesome.com/icons/jedi-order?style=brands"/>
        [Description("Brands Jedi Order"), IconID("fab-jedi-order"), IconUnicodeGlyph(0xf50e)]
        BrandsJediOrder = 144,
        ///<summary>Brands Gripfire</summary>
        ///<see href="https://fontawesome.com/icons/gripfire?style=brands"/>
        [Description("Brands Gripfire"), IconID("fab-gripfire"), IconUnicodeGlyph(0xf3ac)]
        BrandsGripfire = 145,
        ///<summary>Brands Facebook</summary>
        ///<see href="https://fontawesome.com/icons/facebook?style=brands"/>
        [Description("Brands Facebook"), IconID("fab-facebook"), IconUnicodeGlyph(0xf09a)]
        BrandsFacebook = 146,
        ///<summary>Brands Instagram</summary>
        ///<see href="https://fontawesome.com/icons/instagram?style=brands"/>
        [Description("Brands Instagram"), IconID("fab-instagram"), IconUnicodeGlyph(0xf16d)]
        BrandsInstagram = 147,
        ///<summary>Brands Dropbox</summary>
        ///<see href="https://fontawesome.com/icons/dropbox?style=brands"/>
        [Description("Brands Dropbox"), IconID("fab-dropbox"), IconUnicodeGlyph(0xf16b)]
        BrandsDropbox = 148,
        ///<summary>Brands Cc Amazon Pay</summary>
        ///<see href="https://fontawesome.com/icons/cc-amazon-pay?style=brands"/>
        [Description("Brands Cc Amazon Pay"), IconID("fab-cc-amazon-pay"), IconUnicodeGlyph(0xf42d)]
        BrandsCcAmazonPay = 149,
        ///<summary>Brands Creative Commons Remix</summary>
        ///<see href="https://fontawesome.com/icons/creative-commons-remix?style=brands"/>
        [Description("Brands Creative Commons Remix"), IconID("fab-creative-commons-remix"), IconUnicodeGlyph(0xf4ee)]
        BrandsCreativeCommonsRemix = 150,
        ///<summary>Brands Figma</summary>
        ///<see href="https://fontawesome.com/icons/figma?style=brands"/>
        [Description("Brands Figma"), IconID("fab-figma"), IconUnicodeGlyph(0xf799)]
        BrandsFigma = 151,
        ///<summary>Brands Js Square</summary>
        ///<see href="https://fontawesome.com/icons/js-square?style=brands"/>
        [Description("Brands Js Square"), IconID("fab-js-square"), IconUnicodeGlyph(0xf3b9)]
        BrandsJsSquare = 152,
        ///<summary>Brands Uniregistry</summary>
        ///<see href="https://fontawesome.com/icons/uniregistry?style=brands"/>
        [Description("Brands Uniregistry"), IconID("fab-uniregistry"), IconUnicodeGlyph(0xf404)]
        BrandsUniregistry = 153,
        ///<summary>Brands Mendeley</summary>
        ///<see href="https://fontawesome.com/icons/mendeley?style=brands"/>
        [Description("Brands Mendeley"), IconID("fab-mendeley"), IconUnicodeGlyph(0xf7b3)]
        BrandsMendeley = 154,
        ///<summary>Brands Vimeo</summary>
        ///<see href="https://fontawesome.com/icons/vimeo?style=brands"/>
        [Description("Brands Vimeo"), IconID("fab-vimeo"), IconUnicodeGlyph(0xf40a)]
        BrandsVimeo = 155,
        ///<summary>Brands Medium M</summary>
        ///<see href="https://fontawesome.com/icons/medium-m?style=brands"/>
        [Description("Brands Medium M"), IconID("fab-medium-m"), IconUnicodeGlyph(0xf3c7)]
        BrandsMediumM = 156,
        ///<summary>Brands Mixer</summary>
        ///<see href="https://fontawesome.com/icons/mixer?style=brands"/>
        [Description("Brands Mixer"), IconID("fab-mixer"), IconUnicodeGlyph(0xe056)]
        BrandsMixer = 157,
        ///<summary>Brands Ravelry</summary>
        ///<see href="https://fontawesome.com/icons/ravelry?style=brands"/>
        [Description("Brands Ravelry"), IconID("fab-ravelry"), IconUnicodeGlyph(0xf2d9)]
        BrandsRavelry = 158,
        ///<summary>Brands Twitch</summary>
        ///<see href="https://fontawesome.com/icons/twitch?style=brands"/>
        [Description("Brands Twitch"), IconID("fab-twitch"), IconUnicodeGlyph(0xf1e8)]
        BrandsTwitch = 159,
        ///<summary>Brands Deploydog</summary>
        ///<see href="https://fontawesome.com/icons/deploydog?style=brands"/>
        [Description("Brands Deploydog"), IconID("fab-deploydog"), IconUnicodeGlyph(0xf38e)]
        BrandsDeploydog = 160,
        ///<summary>Brands Hubspot</summary>
        ///<see href="https://fontawesome.com/icons/hubspot?style=brands"/>
        [Description("Brands Hubspot"), IconID("fab-hubspot"), IconUnicodeGlyph(0xf3b2)]
        BrandsHubspot = 161,
        ///<summary>Brands Linkedin</summary>
        ///<see href="https://fontawesome.com/icons/linkedin?style=brands"/>
        [Description("Brands Linkedin"), IconID("fab-linkedin"), IconUnicodeGlyph(0xf08c)]
        BrandsLinkedin = 162,
        ///<summary>Brands Glide</summary>
        ///<see href="https://fontawesome.com/icons/glide?style=brands"/>
        [Description("Brands Glide"), IconID("fab-glide"), IconUnicodeGlyph(0xf2a5)]
        BrandsGlide = 163,
        ///<summary>Brands Linux</summary>
        ///<see href="https://fontawesome.com/icons/linux?style=brands"/>
        [Description("Brands Linux"), IconID("fab-linux"), IconUnicodeGlyph(0xf17c)]
        BrandsLinux = 164,
        ///<summary>Brands Renren</summary>
        ///<see href="https://fontawesome.com/icons/renren?style=brands"/>
        [Description("Brands Renren"), IconID("fab-renren"), IconUnicodeGlyph(0xf18b)]
        BrandsRenren = 165,
        ///<summary>Brands Dribbble Square</summary>
        ///<see href="https://fontawesome.com/icons/dribbble-square?style=brands"/>
        [Description("Brands Dribbble Square"), IconID("fab-dribbble-square"), IconUnicodeGlyph(0xf397)]
        BrandsDribbbleSquare = 166,
        ///<summary>Brands Tiktok</summary>
        ///<see href="https://fontawesome.com/icons/tiktok?style=brands"/>
        [Description("Brands Tiktok"), IconID("fab-tiktok"), IconUnicodeGlyph(0xe07b)]
        BrandsTiktok = 167,
        ///<summary>Brands Steam Square</summary>
        ///<see href="https://fontawesome.com/icons/steam-square?style=brands"/>
        [Description("Brands Steam Square"), IconID("fab-steam-square"), IconUnicodeGlyph(0xf1b7)]
        BrandsSteamSquare = 168,
        ///<summary>Brands Searchengin</summary>
        ///<see href="https://fontawesome.com/icons/searchengin?style=brands"/>
        [Description("Brands Searchengin"), IconID("fab-searchengin"), IconUnicodeGlyph(0xf3eb)]
        BrandsSearchengin = 169,
        ///<summary>Brands Xbox</summary>
        ///<see href="https://fontawesome.com/icons/xbox?style=brands"/>
        [Description("Brands Xbox"), IconID("fab-xbox"), IconUnicodeGlyph(0xf412)]
        BrandsXbox = 170,
        ///<summary>Brands Resolving</summary>
        ///<see href="https://fontawesome.com/icons/resolving?style=brands"/>
        [Description("Brands Resolving"), IconID("fab-resolving"), IconUnicodeGlyph(0xf3e7)]
        BrandsResolving = 171,
        ///<summary>Brands Superpowers</summary>
        ///<see href="https://fontawesome.com/icons/superpowers?style=brands"/>
        [Description("Brands Superpowers"), IconID("fab-superpowers"), IconUnicodeGlyph(0xf2dd)]
        BrandsSuperpowers = 172,
        ///<summary>Brands Palfed</summary>
        ///<see href="https://fontawesome.com/icons/palfed?style=brands"/>
        [Description("Brands Palfed"), IconID("fab-palfed"), IconUnicodeGlyph(0xf3d8)]
        BrandsPalfed = 173,
        ///<summary>Brands Creative Commons Nd</summary>
        ///<see href="https://fontawesome.com/icons/creative-commons-nd?style=brands"/>
        [Description("Brands Creative Commons Nd"), IconID("fab-creative-commons-nd"), IconUnicodeGlyph(0xf4eb)]
        BrandsCreativeCommonsNd = 174,
        ///<summary>Brands Elementor</summary>
        ///<see href="https://fontawesome.com/icons/elementor?style=brands"/>
        [Description("Brands Elementor"), IconID("fab-elementor"), IconUnicodeGlyph(0xf430)]
        BrandsElementor = 175,
        ///<summary>Brands Stack Exchange</summary>
        ///<see href="https://fontawesome.com/icons/stack-exchange?style=brands"/>
        [Description("Brands Stack Exchange"), IconID("fab-stack-exchange"), IconUnicodeGlyph(0xf18d)]
        BrandsStackExchange = 176,
        ///<summary>Brands Font Awesome Flag</summary>
        ///<see href="https://fontawesome.com/icons/font-awesome-flag?style=brands"/>
        [Description("Brands Font Awesome Flag"), IconID("fab-font-awesome-flag"), IconUnicodeGlyph(0xf425)]
        BrandsFontAwesomeFlag = 177,
        ///<summary>Brands Dashcube</summary>
        ///<see href="https://fontawesome.com/icons/dashcube?style=brands"/>
        [Description("Brands Dashcube"), IconID("fab-dashcube"), IconUnicodeGlyph(0xf210)]
        BrandsDashcube = 178,
        ///<summary>Brands Cotton Bureau</summary>
        ///<see href="https://fontawesome.com/icons/cotton-bureau?style=brands"/>
        [Description("Brands Cotton Bureau"), IconID("fab-cotton-bureau"), IconUnicodeGlyph(0xf89e)]
        BrandsCottonBureau = 179,
        ///<summary>Brands Erlang</summary>
        ///<see href="https://fontawesome.com/icons/erlang?style=brands"/>
        [Description("Brands Erlang"), IconID("fab-erlang"), IconUnicodeGlyph(0xf39d)]
        BrandsErlang = 180,
        ///<summary>Brands Slack Hash</summary>
        ///<see href="https://fontawesome.com/icons/slack-hash?style=brands"/>
        [Description("Brands Slack Hash"), IconID("fab-slack-hash"), IconUnicodeGlyph(0xf3ef)]
        BrandsSlackHash = 181,
        ///<summary>Brands Think Peaks</summary>
        ///<see href="https://fontawesome.com/icons/think-peaks?style=brands"/>
        [Description("Brands Think Peaks"), IconID("fab-think-peaks"), IconUnicodeGlyph(0xf731)]
        BrandsThinkPeaks = 182,
        ///<summary>Brands Audible</summary>
        ///<see href="https://fontawesome.com/icons/audible?style=brands"/>
        [Description("Brands Audible"), IconID("fab-audible"), IconUnicodeGlyph(0xf373)]
        BrandsAudible = 183,
        ///<summary>Brands Facebook Messenger</summary>
        ///<see href="https://fontawesome.com/icons/facebook-messenger?style=brands"/>
        [Description("Brands Facebook Messenger"), IconID("fab-facebook-messenger"), IconUnicodeGlyph(0xf39f)]
        BrandsFacebookMessenger = 184,
        ///<summary>Brands Etsy</summary>
        ///<see href="https://fontawesome.com/icons/etsy?style=brands"/>
        [Description("Brands Etsy"), IconID("fab-etsy"), IconUnicodeGlyph(0xf2d7)]
        BrandsEtsy = 185,
        ///<summary>Brands Maxcdn</summary>
        ///<see href="https://fontawesome.com/icons/maxcdn?style=brands"/>
        [Description("Brands Maxcdn"), IconID("fab-maxcdn"), IconUnicodeGlyph(0xf136)]
        BrandsMaxcdn = 186,
        ///<summary>Brands Symfony</summary>
        ///<see href="https://fontawesome.com/icons/symfony?style=brands"/>
        [Description("Brands Symfony"), IconID("fab-symfony"), IconUnicodeGlyph(0xf83d)]
        BrandsSymfony = 187,
        ///<summary>Brands Tencent Weibo</summary>
        ///<see href="https://fontawesome.com/icons/tencent-weibo?style=brands"/>
        [Description("Brands Tencent Weibo"), IconID("fab-tencent-weibo"), IconUnicodeGlyph(0xf1d5)]
        BrandsTencentWeibo = 188,
        ///<summary>Brands Digg</summary>
        ///<see href="https://fontawesome.com/icons/digg?style=brands"/>
        [Description("Brands Digg"), IconID("fab-digg"), IconUnicodeGlyph(0xf1a6)]
        BrandsDigg = 189,
        ///<summary>Brands Soundcloud</summary>
        ///<see href="https://fontawesome.com/icons/soundcloud?style=brands"/>
        [Description("Brands Soundcloud"), IconID("fab-soundcloud"), IconUnicodeGlyph(0xf1be)]
        BrandsSoundcloud = 190,
        ///<summary>Brands Viber</summary>
        ///<see href="https://fontawesome.com/icons/viber?style=brands"/>
        [Description("Brands Viber"), IconID("fab-viber"), IconUnicodeGlyph(0xf409)]
        BrandsViber = 191,
        ///<summary>Brands Flickr</summary>
        ///<see href="https://fontawesome.com/icons/flickr?style=brands"/>
        [Description("Brands Flickr"), IconID("fab-flickr"), IconUnicodeGlyph(0xf16e)]
        BrandsFlickr = 192,
        ///<summary>Brands Blogger</summary>
        ///<see href="https://fontawesome.com/icons/blogger?style=brands"/>
        [Description("Brands Blogger"), IconID("fab-blogger"), IconUnicodeGlyph(0xf37c)]
        BrandsBlogger = 193,
        ///<summary>Brands Cuttlefish</summary>
        ///<see href="https://fontawesome.com/icons/cuttlefish?style=brands"/>
        [Description("Brands Cuttlefish"), IconID("fab-cuttlefish"), IconUnicodeGlyph(0xf38c)]
        BrandsCuttlefish = 194,
        ///<summary>Brands Itunes</summary>
        ///<see href="https://fontawesome.com/icons/itunes?style=brands"/>
        [Description("Brands Itunes"), IconID("fab-itunes"), IconUnicodeGlyph(0xf3b4)]
        BrandsItunes = 195,
        ///<summary>Brands Aviato</summary>
        ///<see href="https://fontawesome.com/icons/aviato?style=brands"/>
        [Description("Brands Aviato"), IconID("fab-aviato"), IconUnicodeGlyph(0xf421)]
        BrandsAviato = 196,
        ///<summary>Brands Fly</summary>
        ///<see href="https://fontawesome.com/icons/fly?style=brands"/>
        [Description("Brands Fly"), IconID("fab-fly"), IconUnicodeGlyph(0xf417)]
        BrandsFly = 197,
        ///<summary>Brands Optin Monster</summary>
        ///<see href="https://fontawesome.com/icons/optin-monster?style=brands"/>
        [Description("Brands Optin Monster"), IconID("fab-optin-monster"), IconUnicodeGlyph(0xf23c)]
        BrandsOptinMonster = 198,
        ///<summary>Brands Spotify</summary>
        ///<see href="https://fontawesome.com/icons/spotify?style=brands"/>
        [Description("Brands Spotify"), IconID("fab-spotify"), IconUnicodeGlyph(0xf1bc)]
        BrandsSpotify = 199,
        ///<summary>Brands Magento</summary>
        ///<see href="https://fontawesome.com/icons/magento?style=brands"/>
        [Description("Brands Magento"), IconID("fab-magento"), IconUnicodeGlyph(0xf3c4)]
        BrandsMagento = 200,
        ///<summary>Brands Megaport</summary>
        ///<see href="https://fontawesome.com/icons/megaport?style=brands"/>
        [Description("Brands Megaport"), IconID("fab-megaport"), IconUnicodeGlyph(0xf5a3)]
        BrandsMegaport = 201,
        ///<summary>Brands Usps</summary>
        ///<see href="https://fontawesome.com/icons/usps?style=brands"/>
        [Description("Brands Usps"), IconID("fab-usps"), IconUnicodeGlyph(0xf7e1)]
        BrandsUsps = 202,
        ///<summary>Brands Cloudversify</summary>
        ///<see href="https://fontawesome.com/icons/cloudversify?style=brands"/>
        [Description("Brands Cloudversify"), IconID("fab-cloudversify"), IconUnicodeGlyph(0xf385)]
        BrandsCloudversify = 203,
        ///<summary>Brands Wpforms</summary>
        ///<see href="https://fontawesome.com/icons/wpforms?style=brands"/>
        [Description("Brands Wpforms"), IconID("fab-wpforms"), IconUnicodeGlyph(0xf298)]
        BrandsWpforms = 204,
        ///<summary>Brands Bandcamp</summary>
        ///<see href="https://fontawesome.com/icons/bandcamp?style=brands"/>
        [Description("Brands Bandcamp"), IconID("fab-bandcamp"), IconUnicodeGlyph(0xf2d5)]
        BrandsBandcamp = 205,
        ///<summary>Brands Schlix</summary>
        ///<see href="https://fontawesome.com/icons/schlix?style=brands"/>
        [Description("Brands Schlix"), IconID("fab-schlix"), IconUnicodeGlyph(0xf3ea)]
        BrandsSchlix = 206,
        ///<summary>Brands Mizuni</summary>
        ///<see href="https://fontawesome.com/icons/mizuni?style=brands"/>
        [Description("Brands Mizuni"), IconID("fab-mizuni"), IconUnicodeGlyph(0xf3cc)]
        BrandsMizuni = 207,
        ///<summary>Brands Forumbee</summary>
        ///<see href="https://fontawesome.com/icons/forumbee?style=brands"/>
        [Description("Brands Forumbee"), IconID("fab-forumbee"), IconUnicodeGlyph(0xf211)]
        BrandsForumbee = 208,
        ///<summary>Brands Cloudscale</summary>
        ///<see href="https://fontawesome.com/icons/cloudscale?style=brands"/>
        [Description("Brands Cloudscale"), IconID("fab-cloudscale"), IconUnicodeGlyph(0xf383)]
        BrandsCloudscale = 209,
        ///<summary>Brands Fulcrum</summary>
        ///<see href="https://fontawesome.com/icons/fulcrum?style=brands"/>
        [Description("Brands Fulcrum"), IconID("fab-fulcrum"), IconUnicodeGlyph(0xf50b)]
        BrandsFulcrum = 210,
        ///<summary>Brands Periscope</summary>
        ///<see href="https://fontawesome.com/icons/periscope?style=brands"/>
        [Description("Brands Periscope"), IconID("fab-periscope"), IconUnicodeGlyph(0xf3da)]
        BrandsPeriscope = 211,
        ///<summary>Brands D And D Beyond</summary>
        ///<see href="https://fontawesome.com/icons/d-and-d-beyond?style=brands"/>
        [Description("Brands D And D Beyond"), IconID("fab-d-and-d-beyond"), IconUnicodeGlyph(0xf6ca)]
        BrandsDAndDBeyond = 212,
        ///<summary>Brands Google Wallet</summary>
        ///<see href="https://fontawesome.com/icons/google-wallet?style=brands"/>
        [Description("Brands Google Wallet"), IconID("fab-google-wallet"), IconUnicodeGlyph(0xf1ee)]
        BrandsGoogleWallet = 213,
        ///<summary>Brands Osi</summary>
        ///<see href="https://fontawesome.com/icons/osi?style=brands"/>
        [Description("Brands Osi"), IconID("fab-osi"), IconUnicodeGlyph(0xf41a)]
        BrandsOsi = 214,
        ///<summary>Brands First Order Alt</summary>
        ///<see href="https://fontawesome.com/icons/first-order-alt?style=brands"/>
        [Description("Brands First Order Alt"), IconID("fab-first-order-alt"), IconUnicodeGlyph(0xf50a)]
        BrandsFirstOrderAlt = 215,
        ///<summary>Brands Mandalorian</summary>
        ///<see href="https://fontawesome.com/icons/mandalorian?style=brands"/>
        [Description("Brands Mandalorian"), IconID("fab-mandalorian"), IconUnicodeGlyph(0xf50f)]
        BrandsMandalorian = 216,
        ///<summary>Brands Facebook F</summary>
        ///<see href="https://fontawesome.com/icons/facebook-f?style=brands"/>
        [Description("Brands Facebook F"), IconID("fab-facebook-f"), IconUnicodeGlyph(0xf39e)]
        BrandsFacebookF = 217,
        ///<summary>Brands Bimobject</summary>
        ///<see href="https://fontawesome.com/icons/bimobject?style=brands"/>
        [Description("Brands Bimobject"), IconID("fab-bimobject"), IconUnicodeGlyph(0xf378)]
        BrandsBimobject = 218,
        ///<summary>Brands Gofore</summary>
        ///<see href="https://fontawesome.com/icons/gofore?style=brands"/>
        [Description("Brands Gofore"), IconID("fab-gofore"), IconUnicodeGlyph(0xf3a7)]
        BrandsGofore = 219,
        ///<summary>Brands Ello</summary>
        ///<see href="https://fontawesome.com/icons/ello?style=brands"/>
        [Description("Brands Ello"), IconID("fab-ello"), IconUnicodeGlyph(0xf5f1)]
        BrandsEllo = 220,
        ///<summary>Brands Avianex</summary>
        ///<see href="https://fontawesome.com/icons/avianex?style=brands"/>
        [Description("Brands Avianex"), IconID("fab-avianex"), IconUnicodeGlyph(0xf374)]
        BrandsAvianex = 221,
        ///<summary>Brands Patreon</summary>
        ///<see href="https://fontawesome.com/icons/patreon?style=brands"/>
        [Description("Brands Patreon"), IconID("fab-patreon"), IconUnicodeGlyph(0xf3d9)]
        BrandsPatreon = 222,
        ///<summary>Brands Creative Commons Nc Eu</summary>
        ///<see href="https://fontawesome.com/icons/creative-commons-nc-eu?style=brands"/>
        [Description("Brands Creative Commons Nc Eu"), IconID("fab-creative-commons-nc-eu"), IconUnicodeGlyph(0xf4e9)]
        BrandsCreativeCommonsNcEu = 223,
        ///<summary>Brands Speaker Deck</summary>
        ///<see href="https://fontawesome.com/icons/speaker-deck?style=brands"/>
        [Description("Brands Speaker Deck"), IconID("fab-speaker-deck"), IconUnicodeGlyph(0xf83c)]
        BrandsSpeakerDeck = 224,
        ///<summary>Brands Ethereum</summary>
        ///<see href="https://fontawesome.com/icons/ethereum?style=brands"/>
        [Description("Brands Ethereum"), IconID("fab-ethereum"), IconUnicodeGlyph(0xf42e)]
        BrandsEthereum = 225,
        ///<summary>Brands Odnoklassniki</summary>
        ///<see href="https://fontawesome.com/icons/odnoklassniki?style=brands"/>
        [Description("Brands Odnoklassniki"), IconID("fab-odnoklassniki"), IconUnicodeGlyph(0xf263)]
        BrandsOdnoklassniki = 226,
        ///<summary>Brands Bootstrap</summary>
        ///<see href="https://fontawesome.com/icons/bootstrap?style=brands"/>
        [Description("Brands Bootstrap"), IconID("fab-bootstrap"), IconUnicodeGlyph(0xf836)]
        BrandsBootstrap = 227,
        ///<summary>Brands Pied Piper Pp</summary>
        ///<see href="https://fontawesome.com/icons/pied-piper-pp?style=brands"/>
        [Description("Brands Pied Piper Pp"), IconID("fab-pied-piper-pp"), IconUnicodeGlyph(0xf1a7)]
        BrandsPiedPiperPp = 228,
        ///<summary>Brands Affiliatetheme</summary>
        ///<see href="https://fontawesome.com/icons/affiliatetheme?style=brands"/>
        [Description("Brands Affiliatetheme"), IconID("fab-affiliatetheme"), IconUnicodeGlyph(0xf36b)]
        BrandsAffiliatetheme = 229,
        ///<summary>Brands Dailymotion</summary>
        ///<see href="https://fontawesome.com/icons/dailymotion?style=brands"/>
        [Description("Brands Dailymotion"), IconID("fab-dailymotion"), IconUnicodeGlyph(0xe052)]
        BrandsDailymotion = 230,
        ///<summary>Brands Yahoo</summary>
        ///<see href="https://fontawesome.com/icons/yahoo?style=brands"/>
        [Description("Brands Yahoo"), IconID("fab-yahoo"), IconUnicodeGlyph(0xf19e)]
        BrandsYahoo = 231,
        ///<summary>Brands Reddit Alien</summary>
        ///<see href="https://fontawesome.com/icons/reddit-alien?style=brands"/>
        [Description("Brands Reddit Alien"), IconID("fab-reddit-alien"), IconUnicodeGlyph(0xf281)]
        BrandsRedditAlien = 232,
        ///<summary>Brands Typo3</summary>
        ///<see href="https://fontawesome.com/icons/typo3?style=brands"/>
        [Description("Brands Typo3"), IconID("fab-typo3"), IconUnicodeGlyph(0xf42b)]
        BrandsTypo3 = 233,
        ///<summary>Brands Gitlab</summary>
        ///<see href="https://fontawesome.com/icons/gitlab?style=brands"/>
        [Description("Brands Gitlab"), IconID("fab-gitlab"), IconUnicodeGlyph(0xf296)]
        BrandsGitlab = 234,
        ///<summary>Brands Paypal</summary>
        ///<see href="https://fontawesome.com/icons/paypal?style=brands"/>
        [Description("Brands Paypal"), IconID("fab-paypal"), IconUnicodeGlyph(0xf1ed)]
        BrandsPaypal = 235,
        ///<summary>Brands Vine</summary>
        ///<see href="https://fontawesome.com/icons/vine?style=brands"/>
        [Description("Brands Vine"), IconID("fab-vine"), IconUnicodeGlyph(0xf1ca)]
        BrandsVine = 236,
        ///<summary>Brands Opencart</summary>
        ///<see href="https://fontawesome.com/icons/opencart?style=brands"/>
        [Description("Brands Opencart"), IconID("fab-opencart"), IconUnicodeGlyph(0xf23d)]
        BrandsOpencart = 237,
        ///<summary>Brands Blogger B</summary>
        ///<see href="https://fontawesome.com/icons/blogger-b?style=brands"/>
        [Description("Brands Blogger B"), IconID("fab-blogger-b"), IconUnicodeGlyph(0xf37d)]
        BrandsBloggerB = 238,
        ///<summary>Brands Less</summary>
        ///<see href="https://fontawesome.com/icons/less?style=brands"/>
        [Description("Brands Less"), IconID("fab-less"), IconUnicodeGlyph(0xf41d)]
        BrandsLess = 239,
        ///<summary>Brands Quinscape</summary>
        ///<see href="https://fontawesome.com/icons/quinscape?style=brands"/>
        [Description("Brands Quinscape"), IconID("fab-quinscape"), IconUnicodeGlyph(0xf459)]
        BrandsQuinscape = 240,
        ///<summary>Brands Playstation</summary>
        ///<see href="https://fontawesome.com/icons/playstation?style=brands"/>
        [Description("Brands Playstation"), IconID("fab-playstation"), IconUnicodeGlyph(0xf3df)]
        BrandsPlaystation = 241,
        ///<summary>Brands Creative Commons Pd</summary>
        ///<see href="https://fontawesome.com/icons/creative-commons-pd?style=brands"/>
        [Description("Brands Creative Commons Pd"), IconID("fab-creative-commons-pd"), IconUnicodeGlyph(0xf4ec)]
        BrandsCreativeCommonsPd = 242,
        ///<summary>Brands Blackberry</summary>
        ///<see href="https://fontawesome.com/icons/blackberry?style=brands"/>
        [Description("Brands Blackberry"), IconID("fab-blackberry"), IconUnicodeGlyph(0xf37b)]
        BrandsBlackberry = 243,
        ///<summary>Brands Xing</summary>
        ///<see href="https://fontawesome.com/icons/xing?style=brands"/>
        [Description("Brands Xing"), IconID("fab-xing"), IconUnicodeGlyph(0xf168)]
        BrandsXing = 244,
        ///<summary>Brands Dhl</summary>
        ///<see href="https://fontawesome.com/icons/dhl?style=brands"/>
        [Description("Brands Dhl"), IconID("fab-dhl"), IconUnicodeGlyph(0xf790)]
        BrandsDhl = 245,
        ///<summary>Brands Gg</summary>
        ///<see href="https://fontawesome.com/icons/gg?style=brands"/>
        [Description("Brands Gg"), IconID("fab-gg"), IconUnicodeGlyph(0xf260)]
        BrandsGg = 246,
        ///<summary>Brands Houzz</summary>
        ///<see href="https://fontawesome.com/icons/houzz?style=brands"/>
        [Description("Brands Houzz"), IconID("fab-houzz"), IconUnicodeGlyph(0xf27c)]
        BrandsHouzz = 247,
        ///<summary>Brands Stripe</summary>
        ///<see href="https://fontawesome.com/icons/stripe?style=brands"/>
        [Description("Brands Stripe"), IconID("fab-stripe"), IconUnicodeGlyph(0xf429)]
        BrandsStripe = 248,
        ///<summary>Brands Draft2digital</summary>
        ///<see href="https://fontawesome.com/icons/draft2digital?style=brands"/>
        [Description("Brands Draft2digital"), IconID("fab-draft2digital"), IconUnicodeGlyph(0xf396)]
        BrandsDraft2digital = 249,
        ///<summary>Brands Ubuntu</summary>
        ///<see href="https://fontawesome.com/icons/ubuntu?style=brands"/>
        [Description("Brands Ubuntu"), IconID("fab-ubuntu"), IconUnicodeGlyph(0xf7df)]
        BrandsUbuntu = 250,
        ///<summary>Brands Galactic Senate</summary>
        ///<see href="https://fontawesome.com/icons/galactic-senate?style=brands"/>
        [Description("Brands Galactic Senate"), IconID("fab-galactic-senate"), IconUnicodeGlyph(0xf50d)]
        BrandsGalacticSenate = 251,
        ///<summary>Brands Umbraco</summary>
        ///<see href="https://fontawesome.com/icons/umbraco?style=brands"/>
        [Description("Brands Umbraco"), IconID("fab-umbraco"), IconUnicodeGlyph(0xf8e8)]
        BrandsUmbraco = 252,
        ///<summary>Brands Itch Io</summary>
        ///<see href="https://fontawesome.com/icons/itch-io?style=brands"/>
        [Description("Brands Itch Io"), IconID("fab-itch-io"), IconUnicodeGlyph(0xf83a)]
        BrandsItchIo = 253,
        ///<summary>Brands Opera</summary>
        ///<see href="https://fontawesome.com/icons/opera?style=brands"/>
        [Description("Brands Opera"), IconID("fab-opera"), IconUnicodeGlyph(0xf26a)]
        BrandsOpera = 254,
        ///<summary>Brands Keycdn</summary>
        ///<see href="https://fontawesome.com/icons/keycdn?style=brands"/>
        [Description("Brands Keycdn"), IconID("fab-keycdn"), IconUnicodeGlyph(0xf3ba)]
        BrandsKeycdn = 255,
        ///<summary>Brands Bitcoin</summary>
        ///<see href="https://fontawesome.com/icons/bitcoin?style=brands"/>
        [Description("Brands Bitcoin"), IconID("fab-bitcoin"), IconUnicodeGlyph(0xf379)]
        BrandsBitcoin = 256,
        ///<summary>Brands Xing Square</summary>
        ///<see href="https://fontawesome.com/icons/xing-square?style=brands"/>
        [Description("Brands Xing Square"), IconID("fab-xing-square"), IconUnicodeGlyph(0xf169)]
        BrandsXingSquare = 257,
        ///<summary>Brands Creative Commons Share</summary>
        ///<see href="https://fontawesome.com/icons/creative-commons-share?style=brands"/>
        [Description("Brands Creative Commons Share"), IconID("fab-creative-commons-share"), IconUnicodeGlyph(0xf4f2)]
        BrandsCreativeCommonsShare = 258,
        ///<summary>Brands Cc Stripe</summary>
        ///<see href="https://fontawesome.com/icons/cc-stripe?style=brands"/>
        [Description("Brands Cc Stripe"), IconID("fab-cc-stripe"), IconUnicodeGlyph(0xf1f5)]
        BrandsCcStripe = 259,
        ///<summary>Brands Squarespace</summary>
        ///<see href="https://fontawesome.com/icons/squarespace?style=brands"/>
        [Description("Brands Squarespace"), IconID("fab-squarespace"), IconUnicodeGlyph(0xf5be)]
        BrandsSquarespace = 260,
        ///<summary>Brands Cc Paypal</summary>
        ///<see href="https://fontawesome.com/icons/cc-paypal?style=brands"/>
        [Description("Brands Cc Paypal"), IconID("fab-cc-paypal"), IconUnicodeGlyph(0xf1f4)]
        BrandsCcPaypal = 261,
        ///<summary>Brands React</summary>
        ///<see href="https://fontawesome.com/icons/react?style=brands"/>
        [Description("Brands React"), IconID("fab-react"), IconUnicodeGlyph(0xf41b)]
        BrandsReact = 262,
        ///<summary>Brands Page4</summary>
        ///<see href="https://fontawesome.com/icons/page4?style=brands"/>
        [Description("Brands Page4"), IconID("fab-page4"), IconUnicodeGlyph(0xf3d7)]
        BrandsPage4 = 263,
        ///<summary>Brands Themeisle</summary>
        ///<see href="https://fontawesome.com/icons/themeisle?style=brands"/>
        [Description("Brands Themeisle"), IconID("fab-themeisle"), IconUnicodeGlyph(0xf2b2)]
        BrandsThemeisle = 264,
        ///<summary>Brands Sith</summary>
        ///<see href="https://fontawesome.com/icons/sith?style=brands"/>
        [Description("Brands Sith"), IconID("fab-sith"), IconUnicodeGlyph(0xf512)]
        BrandsSith = 265,
        ///<summary>Brands Jsfiddle</summary>
        ///<see href="https://fontawesome.com/icons/jsfiddle?style=brands"/>
        [Description("Brands Jsfiddle"), IconID("fab-jsfiddle"), IconUnicodeGlyph(0xf1cc)]
        BrandsJsfiddle = 266,
        ///<summary>Brands Snapchat Ghost</summary>
        ///<see href="https://fontawesome.com/icons/snapchat-ghost?style=brands"/>
        [Description("Brands Snapchat Ghost"), IconID("fab-snapchat-ghost"), IconUnicodeGlyph(0xf2ac)]
        BrandsSnapchatGhost = 267,
        ///<summary>Brands Goodreads</summary>
        ///<see href="https://fontawesome.com/icons/goodreads?style=brands"/>
        [Description("Brands Goodreads"), IconID("fab-goodreads"), IconUnicodeGlyph(0xf3a8)]
        BrandsGoodreads = 268,
        ///<summary>Brands Linode</summary>
        ///<see href="https://fontawesome.com/icons/linode?style=brands"/>
        [Description("Brands Linode"), IconID("fab-linode"), IconUnicodeGlyph(0xf2b8)]
        BrandsLinode = 269,
        ///<summary>Brands Firefox</summary>
        ///<see href="https://fontawesome.com/icons/firefox?style=brands"/>
        [Description("Brands Firefox"), IconID("fab-firefox"), IconUnicodeGlyph(0xf269)]
        BrandsFirefox = 270,
        ///<summary>Brands Product Hunt</summary>
        ///<see href="https://fontawesome.com/icons/product-hunt?style=brands"/>
        [Description("Brands Product Hunt"), IconID("fab-product-hunt"), IconUnicodeGlyph(0xf288)]
        BrandsProductHunt = 271,
        ///<summary>Brands Wordpress</summary>
        ///<see href="https://fontawesome.com/icons/wordpress?style=brands"/>
        [Description("Brands Wordpress"), IconID("fab-wordpress"), IconUnicodeGlyph(0xf19a)]
        BrandsWordpress = 272,
        ///<summary>Brands Pied Piper</summary>
        ///<see href="https://fontawesome.com/icons/pied-piper?style=brands"/>
        [Description("Brands Pied Piper"), IconID("fab-pied-piper"), IconUnicodeGlyph(0xf2ae)]
        BrandsPiedPiper = 273,
        ///<summary>Brands Innosoft</summary>
        ///<see href="https://fontawesome.com/icons/innosoft?style=brands"/>
        [Description("Brands Innosoft"), IconID("fab-innosoft"), IconUnicodeGlyph(0xe080)]
        BrandsInnosoft = 274,
        ///<summary>Brands Studiovinari</summary>
        ///<see href="https://fontawesome.com/icons/studiovinari?style=brands"/>
        [Description("Brands Studiovinari"), IconID("fab-studiovinari"), IconUnicodeGlyph(0xf3f8)]
        BrandsStudiovinari = 275,
        ///<summary>Brands Envira</summary>
        ///<see href="https://fontawesome.com/icons/envira?style=brands"/>
        [Description("Brands Envira"), IconID("fab-envira"), IconUnicodeGlyph(0xf299)]
        BrandsEnvira = 276,
        ///<summary>Brands Empire</summary>
        ///<see href="https://fontawesome.com/icons/empire?style=brands"/>
        [Description("Brands Empire"), IconID("fab-empire"), IconUnicodeGlyph(0xf1d1)]
        BrandsEmpire = 277,
        ///<summary>Brands Y Combinator</summary>
        ///<see href="https://fontawesome.com/icons/y-combinator?style=brands"/>
        [Description("Brands Y Combinator"), IconID("fab-y-combinator"), IconUnicodeGlyph(0xf23b)]
        BrandsYCombinator = 278,
        ///<summary>Brands Angrycreative</summary>
        ///<see href="https://fontawesome.com/icons/angrycreative?style=brands"/>
        [Description("Brands Angrycreative"), IconID("fab-angrycreative"), IconUnicodeGlyph(0xf36e)]
        BrandsAngrycreative = 279,
        ///<summary>Brands Speakap</summary>
        ///<see href="https://fontawesome.com/icons/speakap?style=brands"/>
        [Description("Brands Speakap"), IconID("fab-speakap"), IconUnicodeGlyph(0xf3f3)]
        BrandsSpeakap = 280,
        ///<summary>Brands Angular</summary>
        ///<see href="https://fontawesome.com/icons/angular?style=brands"/>
        [Description("Brands Angular"), IconID("fab-angular"), IconUnicodeGlyph(0xf420)]
        BrandsAngular = 281,
        ///<summary>Brands Swift</summary>
        ///<see href="https://fontawesome.com/icons/swift?style=brands"/>
        [Description("Brands Swift"), IconID("fab-swift"), IconUnicodeGlyph(0xf8e1)]
        BrandsSwift = 282,
        ///<summary>Brands Researchgate</summary>
        ///<see href="https://fontawesome.com/icons/researchgate?style=brands"/>
        [Description("Brands Researchgate"), IconID("fab-researchgate"), IconUnicodeGlyph(0xf4f8)]
        BrandsResearchgate = 283,
        ///<summary>Brands Hackerrank</summary>
        ///<see href="https://fontawesome.com/icons/hackerrank?style=brands"/>
        [Description("Brands Hackerrank"), IconID("fab-hackerrank"), IconUnicodeGlyph(0xf5f7)]
        BrandsHackerrank = 284,
        ///<summary>Brands Neos</summary>
        ///<see href="https://fontawesome.com/icons/neos?style=brands"/>
        [Description("Brands Neos"), IconID("fab-neos"), IconUnicodeGlyph(0xf612)]
        BrandsNeos = 285,
        ///<summary>Brands Shopify</summary>
        ///<see href="https://fontawesome.com/icons/shopify?style=brands"/>
        [Description("Brands Shopify"), IconID("fab-shopify"), IconUnicodeGlyph(0xe057)]
        BrandsShopify = 286,
        ///<summary>Brands Phoenix Framework</summary>
        ///<see href="https://fontawesome.com/icons/phoenix-framework?style=brands"/>
        [Description("Brands Phoenix Framework"), IconID("fab-phoenix-framework"), IconUnicodeGlyph(0xf3dc)]
        BrandsPhoenixFramework = 287,
        ///<summary>Brands Fedex</summary>
        ///<see href="https://fontawesome.com/icons/fedex?style=brands"/>
        [Description("Brands Fedex"), IconID("fab-fedex"), IconUnicodeGlyph(0xf797)]
        BrandsFedex = 288,
        ///<summary>Brands Stumbleupon</summary>
        ///<see href="https://fontawesome.com/icons/stumbleupon?style=brands"/>
        [Description("Brands Stumbleupon"), IconID("fab-stumbleupon"), IconUnicodeGlyph(0xf1a4)]
        BrandsStumbleupon = 289,
        ///<summary>Brands Instagram Square</summary>
        ///<see href="https://fontawesome.com/icons/instagram-square?style=brands"/>
        [Description("Brands Instagram Square"), IconID("fab-instagram-square"), IconUnicodeGlyph(0xe055)]
        BrandsInstagramSquare = 290,
        ///<summary>Brands Amazon Pay</summary>
        ///<see href="https://fontawesome.com/icons/amazon-pay?style=brands"/>
        [Description("Brands Amazon Pay"), IconID("fab-amazon-pay"), IconUnicodeGlyph(0xf42c)]
        BrandsAmazonPay = 291,
        ///<summary>Brands Apple Pay</summary>
        ///<see href="https://fontawesome.com/icons/apple-pay?style=brands"/>
        [Description("Brands Apple Pay"), IconID("fab-apple-pay"), IconUnicodeGlyph(0xf415)]
        BrandsApplePay = 292,
        ///<summary>Brands Keybase</summary>
        ///<see href="https://fontawesome.com/icons/keybase?style=brands"/>
        [Description("Brands Keybase"), IconID("fab-keybase"), IconUnicodeGlyph(0xf4f5)]
        BrandsKeybase = 293,
        ///<summary>Brands Gitkraken</summary>
        ///<see href="https://fontawesome.com/icons/gitkraken?style=brands"/>
        [Description("Brands Gitkraken"), IconID("fab-gitkraken"), IconUnicodeGlyph(0xf3a6)]
        BrandsGitkraken = 294,
        ///<summary>Brands Hive</summary>
        ///<see href="https://fontawesome.com/icons/hive?style=brands"/>
        [Description("Brands Hive"), IconID("fab-hive"), IconUnicodeGlyph(0xe07f)]
        BrandsHive = 295,
        ///<summary>Brands Apple</summary>
        ///<see href="https://fontawesome.com/icons/apple?style=brands"/>
        [Description("Brands Apple"), IconID("fab-apple"), IconUnicodeGlyph(0xf179)]
        BrandsApple = 296,
        ///<summary>Brands Reddit Square</summary>
        ///<see href="https://fontawesome.com/icons/reddit-square?style=brands"/>
        [Description("Brands Reddit Square"), IconID("fab-reddit-square"), IconUnicodeGlyph(0xf1a2)]
        BrandsRedditSquare = 297,
        ///<summary>Brands Gratipay</summary>
        ///<see href="https://fontawesome.com/icons/gratipay?style=brands"/>
        [Description("Brands Gratipay"), IconID("fab-gratipay"), IconUnicodeGlyph(0xf184)]
        BrandsGratipay = 298,
        ///<summary>Brands Font Awesome</summary>
        ///<see href="https://fontawesome.com/icons/font-awesome?style=brands"/>
        [Description("Brands Font Awesome"), IconID("fab-font-awesome"), IconUnicodeGlyph(0xf2b4)]
        BrandsFontAwesome = 299,
        ///<summary>Brands Asymmetrik</summary>
        ///<see href="https://fontawesome.com/icons/asymmetrik?style=brands"/>
        [Description("Brands Asymmetrik"), IconID("fab-asymmetrik"), IconUnicodeGlyph(0xf372)]
        BrandsAsymmetrik = 300,
        ///<summary>Brands 500Px</summary>
        ///<see href="https://fontawesome.com/icons/500px?style=brands"/>
        [Description("Brands 500Px"), IconID("fab-500px"), IconUnicodeGlyph(0xf26e)]
        Brands500Px = 301,
        ///<summary>Brands Yarn</summary>
        ///<see href="https://fontawesome.com/icons/yarn?style=brands"/>
        [Description("Brands Yarn"), IconID("fab-yarn"), IconUnicodeGlyph(0xf7e3)]
        BrandsYarn = 302,
        ///<summary>Brands Unsplash</summary>
        ///<see href="https://fontawesome.com/icons/unsplash?style=brands"/>
        [Description("Brands Unsplash"), IconID("fab-unsplash"), IconUnicodeGlyph(0xe07c)]
        BrandsUnsplash = 303,
        ///<summary>Brands Amazon</summary>
        ///<see href="https://fontawesome.com/icons/amazon?style=brands"/>
        [Description("Brands Amazon"), IconID("fab-amazon"), IconUnicodeGlyph(0xf270)]
        BrandsAmazon = 304,
        ///<summary>Brands Ebay</summary>
        ///<see href="https://fontawesome.com/icons/ebay?style=brands"/>
        [Description("Brands Ebay"), IconID("fab-ebay"), IconUnicodeGlyph(0xf4f4)]
        BrandsEbay = 305,
        ///<summary>Brands Accessible Icon</summary>
        ///<see href="https://fontawesome.com/icons/accessible-icon?style=brands"/>
        [Description("Brands Accessible Icon"), IconID("fab-accessible-icon"), IconUnicodeGlyph(0xf368)]
        BrandsAccessibleIcon = 306,
        ///<summary>Brands Dochub</summary>
        ///<see href="https://fontawesome.com/icons/dochub?style=brands"/>
        [Description("Brands Dochub"), IconID("fab-dochub"), IconUnicodeGlyph(0xf394)]
        BrandsDochub = 307,
        ///<summary>Brands Mdb</summary>
        ///<see href="https://fontawesome.com/icons/mdb?style=brands"/>
        [Description("Brands Mdb"), IconID("fab-mdb"), IconUnicodeGlyph(0xf8ca)]
        BrandsMdb = 308,
        ///<summary>Brands Confluence</summary>
        ///<see href="https://fontawesome.com/icons/confluence?style=brands"/>
        [Description("Brands Confluence"), IconID("fab-confluence"), IconUnicodeGlyph(0xf78d)]
        BrandsConfluence = 309,
        ///<summary>Brands Wpbeginner</summary>
        ///<see href="https://fontawesome.com/icons/wpbeginner?style=brands"/>
        [Description("Brands Wpbeginner"), IconID("fab-wpbeginner"), IconUnicodeGlyph(0xf297)]
        BrandsWpbeginner = 310,
        ///<summary>Brands Cc Discover</summary>
        ///<see href="https://fontawesome.com/icons/cc-discover?style=brands"/>
        [Description("Brands Cc Discover"), IconID("fab-cc-discover"), IconUnicodeGlyph(0xf1f2)]
        BrandsCcDiscover = 311,
        ///<summary>Brands App Store Ios</summary>
        ///<see href="https://fontawesome.com/icons/app-store-ios?style=brands"/>
        [Description("Brands App Store Ios"), IconID("fab-app-store-ios"), IconUnicodeGlyph(0xf370)]
        BrandsAppStoreIos = 312,
        ///<summary>Brands Chrome</summary>
        ///<see href="https://fontawesome.com/icons/chrome?style=brands"/>
        [Description("Brands Chrome"), IconID("fab-chrome"), IconUnicodeGlyph(0xf268)]
        BrandsChrome = 313,
        ///<summary>Brands Discord</summary>
        ///<see href="https://fontawesome.com/icons/discord?style=brands"/>
        [Description("Brands Discord"), IconID("fab-discord"), IconUnicodeGlyph(0xf392)]
        BrandsDiscord = 314,
        ///<summary>Brands Reddit</summary>
        ///<see href="https://fontawesome.com/icons/reddit?style=brands"/>
        [Description("Brands Reddit"), IconID("fab-reddit"), IconUnicodeGlyph(0xf1a1)]
        BrandsReddit = 315,
        ///<summary>Brands Behance</summary>
        ///<see href="https://fontawesome.com/icons/behance?style=brands"/>
        [Description("Brands Behance"), IconID("fab-behance"), IconUnicodeGlyph(0xf1b4)]
        BrandsBehance = 316,
        ///<summary>Brands Hips</summary>
        ///<see href="https://fontawesome.com/icons/hips?style=brands"/>
        [Description("Brands Hips"), IconID("fab-hips"), IconUnicodeGlyph(0xf452)]
        BrandsHips = 317,
        ///<summary>Brands Creative Commons Zero</summary>
        ///<see href="https://fontawesome.com/icons/creative-commons-zero?style=brands"/>
        [Description("Brands Creative Commons Zero"), IconID("fab-creative-commons-zero"), IconUnicodeGlyph(0xf4f3)]
        BrandsCreativeCommonsZero = 318,
        ///<summary>Brands Facebook Square</summary>
        ///<see href="https://fontawesome.com/icons/facebook-square?style=brands"/>
        [Description("Brands Facebook Square"), IconID("fab-facebook-square"), IconUnicodeGlyph(0xf082)]
        BrandsFacebookSquare = 319,
        ///<summary>Brands Sticker Mule</summary>
        ///<see href="https://fontawesome.com/icons/sticker-mule?style=brands"/>
        [Description("Brands Sticker Mule"), IconID("fab-sticker-mule"), IconUnicodeGlyph(0xf3f7)]
        BrandsStickerMule = 320,
        ///<summary>Brands Bluetooth B</summary>
        ///<see href="https://fontawesome.com/icons/bluetooth-b?style=brands"/>
        [Description("Brands Bluetooth B"), IconID("fab-bluetooth-b"), IconUnicodeGlyph(0xf294)]
        BrandsBluetoothB = 321,
        ///<summary>Brands Hotjar</summary>
        ///<see href="https://fontawesome.com/icons/hotjar?style=brands"/>
        [Description("Brands Hotjar"), IconID("fab-hotjar"), IconUnicodeGlyph(0xf3b1)]
        BrandsHotjar = 322,
        ///<summary>Brands Laravel</summary>
        ///<see href="https://fontawesome.com/icons/laravel?style=brands"/>
        [Description("Brands Laravel"), IconID("fab-laravel"), IconUnicodeGlyph(0xf3bd)]
        BrandsLaravel = 323,
        ///<summary>Brands Penny Arcade</summary>
        ///<see href="https://fontawesome.com/icons/penny-arcade?style=brands"/>
        [Description("Brands Penny Arcade"), IconID("fab-penny-arcade"), IconUnicodeGlyph(0xf704)]
        BrandsPennyArcade = 324,
        ///<summary>Brands Stripe S</summary>
        ///<see href="https://fontawesome.com/icons/stripe-s?style=brands"/>
        [Description("Brands Stripe S"), IconID("fab-stripe-s"), IconUnicodeGlyph(0xf42a)]
        BrandsStripeS = 325,
        ///<summary>Brands Fedora</summary>
        ///<see href="https://fontawesome.com/icons/fedora?style=brands"/>
        [Description("Brands Fedora"), IconID("fab-fedora"), IconUnicodeGlyph(0xf798)]
        BrandsFedora = 326,
        ///<summary>Brands Joget</summary>
        ///<see href="https://fontawesome.com/icons/joget?style=brands"/>
        [Description("Brands Joget"), IconID("fab-joget"), IconUnicodeGlyph(0xf3b7)]
        BrandsJoget = 327,
        ///<summary>Brands Skype</summary>
        ///<see href="https://fontawesome.com/icons/skype?style=brands"/>
        [Description("Brands Skype"), IconID("fab-skype"), IconUnicodeGlyph(0xf17e)]
        BrandsSkype = 328,
        ///<summary>Brands Whatsapp Square</summary>
        ///<see href="https://fontawesome.com/icons/whatsapp-square?style=brands"/>
        [Description("Brands Whatsapp Square"), IconID("fab-whatsapp-square"), IconUnicodeGlyph(0xf40c)]
        BrandsWhatsappSquare = 329,
        ///<summary>Brands Galactic Republic</summary>
        ///<see href="https://fontawesome.com/icons/galactic-republic?style=brands"/>
        [Description("Brands Galactic Republic"), IconID("fab-galactic-republic"), IconUnicodeGlyph(0xf50c)]
        BrandsGalacticRepublic = 330,
        ///<summary>Brands Angellist</summary>
        ///<see href="https://fontawesome.com/icons/angellist?style=brands"/>
        [Description("Brands Angellist"), IconID("fab-angellist"), IconUnicodeGlyph(0xf209)]
        BrandsAngellist = 331,
        ///<summary>Brands Wpressr</summary>
        ///<see href="https://fontawesome.com/icons/wpressr?style=brands"/>
        [Description("Brands Wpressr"), IconID("fab-wpressr"), IconUnicodeGlyph(0xf3e4)]
        BrandsWpressr = 332,
        ///<summary>Brands Wikipedia W</summary>
        ///<see href="https://fontawesome.com/icons/wikipedia-w?style=brands"/>
        [Description("Brands Wikipedia W"), IconID("fab-wikipedia-w"), IconUnicodeGlyph(0xf266)]
        BrandsWikipediaW = 333,
        ///<summary>Brands Firstdraft</summary>
        ///<see href="https://fontawesome.com/icons/firstdraft?style=brands"/>
        [Description("Brands Firstdraft"), IconID("fab-firstdraft"), IconUnicodeGlyph(0xf3a1)]
        BrandsFirstdraft = 334,
        ///<summary>Brands Uncharted</summary>
        ///<see href="https://fontawesome.com/icons/uncharted?style=brands"/>
        [Description("Brands Uncharted"), IconID("fab-uncharted"), IconUnicodeGlyph(0xe084)]
        BrandsUncharted = 335,
        ///<summary>Brands Weibo</summary>
        ///<see href="https://fontawesome.com/icons/weibo?style=brands"/>
        [Description("Brands Weibo"), IconID("fab-weibo"), IconUnicodeGlyph(0xf18a)]
        BrandsWeibo = 336,
        ///<summary>Brands Grav</summary>
        ///<see href="https://fontawesome.com/icons/grav?style=brands"/>
        [Description("Brands Grav"), IconID("fab-grav"), IconUnicodeGlyph(0xf2d6)]
        BrandsGrav = 337,
        ///<summary>Brands Kickstarter</summary>
        ///<see href="https://fontawesome.com/icons/kickstarter?style=brands"/>
        [Description("Brands Kickstarter"), IconID("fab-kickstarter"), IconUnicodeGlyph(0xf3bb)]
        BrandsKickstarter = 338,
        ///<summary>Brands Itunes Note</summary>
        ///<see href="https://fontawesome.com/icons/itunes-note?style=brands"/>
        [Description("Brands Itunes Note"), IconID("fab-itunes-note"), IconUnicodeGlyph(0xf3b5)]
        BrandsItunesNote = 339,
        ///<summary>Brands Cc Mastercard</summary>
        ///<see href="https://fontawesome.com/icons/cc-mastercard?style=brands"/>
        [Description("Brands Cc Mastercard"), IconID("fab-cc-mastercard"), IconUnicodeGlyph(0xf1f1)]
        BrandsCcMastercard = 340,
        ///<summary>Brands App Store</summary>
        ///<see href="https://fontawesome.com/icons/app-store?style=brands"/>
        [Description("Brands App Store"), IconID("fab-app-store"), IconUnicodeGlyph(0xf36f)]
        BrandsAppStore = 341,
        ///<summary>Brands Fonticons Fi</summary>
        ///<see href="https://fontawesome.com/icons/fonticons-fi?style=brands"/>
        [Description("Brands Fonticons Fi"), IconID("fab-fonticons-fi"), IconUnicodeGlyph(0xf3a2)]
        BrandsFonticonsFi = 342,
        ///<summary>Brands Ioxhost</summary>
        ///<see href="https://fontawesome.com/icons/ioxhost?style=brands"/>
        [Description("Brands Ioxhost"), IconID("fab-ioxhost"), IconUnicodeGlyph(0xf208)]
        BrandsIoxhost = 343,
        ///<summary>Brands Accusoft</summary>
        ///<see href="https://fontawesome.com/icons/accusoft?style=brands"/>
        [Description("Brands Accusoft"), IconID("fab-accusoft"), IconUnicodeGlyph(0xf369)]
        BrandsAccusoft = 344,
        ///<summary>Brands Vuejs</summary>
        ///<see href="https://fontawesome.com/icons/vuejs?style=brands"/>
        [Description("Brands Vuejs"), IconID("fab-vuejs"), IconUnicodeGlyph(0xf41f)]
        BrandsVuejs = 345,
        ///<summary>Brands Freebsd</summary>
        ///<see href="https://fontawesome.com/icons/freebsd?style=brands"/>
        [Description("Brands Freebsd"), IconID("fab-freebsd"), IconUnicodeGlyph(0xf3a4)]
        BrandsFreebsd = 346,
        ///<summary>Brands Delicious</summary>
        ///<see href="https://fontawesome.com/icons/delicious?style=brands"/>
        [Description("Brands Delicious"), IconID("fab-delicious"), IconUnicodeGlyph(0xf1a5)]
        BrandsDelicious = 347,
        ///<summary>Brands R Project</summary>
        ///<see href="https://fontawesome.com/icons/r-project?style=brands"/>
        [Description("Brands R Project"), IconID("fab-r-project"), IconUnicodeGlyph(0xf4f7)]
        BrandsRProject = 348,
        ///<summary>Brands Youtube Square</summary>
        ///<see href="https://fontawesome.com/icons/youtube-square?style=brands"/>
        [Description("Brands Youtube Square"), IconID("fab-youtube-square"), IconUnicodeGlyph(0xf431)]
        BrandsYoutubeSquare = 349,
        ///<summary>Brands Sellcast</summary>
        ///<see href="https://fontawesome.com/icons/sellcast?style=brands"/>
        [Description("Brands Sellcast"), IconID("fab-sellcast"), IconUnicodeGlyph(0xf2da)]
        BrandsSellcast = 350,
        ///<summary>Brands Expeditedssl</summary>
        ///<see href="https://fontawesome.com/icons/expeditedssl?style=brands"/>
        [Description("Brands Expeditedssl"), IconID("fab-expeditedssl"), IconUnicodeGlyph(0xf23e)]
        BrandsExpeditedssl = 351,
        ///<summary>Brands Instalod</summary>
        ///<see href="https://fontawesome.com/icons/instalod?style=brands"/>
        [Description("Brands Instalod"), IconID("fab-instalod"), IconUnicodeGlyph(0xe081)]
        BrandsInstalod = 352,
        ///<summary>Brands Openid</summary>
        ///<see href="https://fontawesome.com/icons/openid?style=brands"/>
        [Description("Brands Openid"), IconID("fab-openid"), IconUnicodeGlyph(0xf19b)]
        BrandsOpenid = 353,
        ///<summary>Brands Scribd</summary>
        ///<see href="https://fontawesome.com/icons/scribd?style=brands"/>
        [Description("Brands Scribd"), IconID("fab-scribd"), IconUnicodeGlyph(0xf28a)]
        BrandsScribd = 354,
        ///<summary>Brands Cc Apple Pay</summary>
        ///<see href="https://fontawesome.com/icons/cc-apple-pay?style=brands"/>
        [Description("Brands Cc Apple Pay"), IconID("fab-cc-apple-pay"), IconUnicodeGlyph(0xf416)]
        BrandsCcApplePay = 355,
        ///<summary>Brands Steam</summary>
        ///<see href="https://fontawesome.com/icons/steam?style=brands"/>
        [Description("Brands Steam"), IconID("fab-steam"), IconUnicodeGlyph(0xf1b6)]
        BrandsSteam = 356,
        ///<summary>Brands Mix</summary>
        ///<see href="https://fontawesome.com/icons/mix?style=brands"/>
        [Description("Brands Mix"), IconID("fab-mix"), IconUnicodeGlyph(0xf3cb)]
        BrandsMix = 357,
        ///<summary>Brands Node</summary>
        ///<see href="https://fontawesome.com/icons/node?style=brands"/>
        [Description("Brands Node"), IconID("fab-node"), IconUnicodeGlyph(0xf419)]
        BrandsNode = 358,
        ///<summary>Brands Tumblr Square</summary>
        ///<see href="https://fontawesome.com/icons/tumblr-square?style=brands"/>
        [Description("Brands Tumblr Square"), IconID("fab-tumblr-square"), IconUnicodeGlyph(0xf174)]
        BrandsTumblrSquare = 359,
        ///<summary>Brands Codiepie</summary>
        ///<see href="https://fontawesome.com/icons/codiepie?style=brands"/>
        [Description("Brands Codiepie"), IconID("fab-codiepie"), IconUnicodeGlyph(0xf284)]
        BrandsCodiepie = 360,
        ///<summary>Brands Pied Piper Alt</summary>
        ///<see href="https://fontawesome.com/icons/pied-piper-alt?style=brands"/>
        [Description("Brands Pied Piper Alt"), IconID("fab-pied-piper-alt"), IconUnicodeGlyph(0xf1a8)]
        BrandsPiedPiperAlt = 361,
        ///<summary>Brands Vimeo Square</summary>
        ///<see href="https://fontawesome.com/icons/vimeo-square?style=brands"/>
        [Description("Brands Vimeo Square"), IconID("fab-vimeo-square"), IconUnicodeGlyph(0xf194)]
        BrandsVimeoSquare = 362,
        ///<summary>Brands Cloudsmith</summary>
        ///<see href="https://fontawesome.com/icons/cloudsmith?style=brands"/>
        [Description("Brands Cloudsmith"), IconID("fab-cloudsmith"), IconUnicodeGlyph(0xf384)]
        BrandsCloudsmith = 363,
        ///<summary>Brands Adn</summary>
        ///<see href="https://fontawesome.com/icons/adn?style=brands"/>
        [Description("Brands Adn"), IconID("fab-adn"), IconUnicodeGlyph(0xf170)]
        BrandsAdn = 364,
        ///<summary>Brands Centos</summary>
        ///<see href="https://fontawesome.com/icons/centos?style=brands"/>
        [Description("Brands Centos"), IconID("fab-centos"), IconUnicodeGlyph(0xf789)]
        BrandsCentos = 365,
        ///<summary>Brands Meetup</summary>
        ///<see href="https://fontawesome.com/icons/meetup?style=brands"/>
        [Description("Brands Meetup"), IconID("fab-meetup"), IconUnicodeGlyph(0xf2e0)]
        BrandsMeetup = 366,
        ///<summary>Brands Wizards Of The Coast</summary>
        ///<see href="https://fontawesome.com/icons/wizards-of-the-coast?style=brands"/>
        [Description("Brands Wizards Of The Coast"), IconID("fab-wizards-of-the-coast"), IconUnicodeGlyph(0xf730)]
        BrandsWizardsOfTheCoast = 367,
        ///<summary>Brands Windows</summary>
        ///<see href="https://fontawesome.com/icons/windows?style=brands"/>
        [Description("Brands Windows"), IconID("fab-windows"), IconUnicodeGlyph(0xf17a)]
        BrandsWindows = 368,
        ///<summary>Brands Rev</summary>
        ///<see href="https://fontawesome.com/icons/rev?style=brands"/>
        [Description("Brands Rev"), IconID("fab-rev"), IconUnicodeGlyph(0xf5b2)]
        BrandsRev = 369,
        ///<summary>Brands Lyft</summary>
        ///<see href="https://fontawesome.com/icons/lyft?style=brands"/>
        [Description("Brands Lyft"), IconID("fab-lyft"), IconUnicodeGlyph(0xf3c3)]
        BrandsLyft = 370,
        ///<summary>Brands Git Alt</summary>
        ///<see href="https://fontawesome.com/icons/git-alt?style=brands"/>
        [Description("Brands Git Alt"), IconID("fab-git-alt"), IconUnicodeGlyph(0xf841)]
        BrandsGitAlt = 371,
        ///<summary>Brands Codepen</summary>
        ///<see href="https://fontawesome.com/icons/codepen?style=brands"/>
        [Description("Brands Codepen"), IconID("fab-codepen"), IconUnicodeGlyph(0xf1cb)]
        BrandsCodepen = 372,
        ///<summary>Brands Twitter Square</summary>
        ///<see href="https://fontawesome.com/icons/twitter-square?style=brands"/>
        [Description("Brands Twitter Square"), IconID("fab-twitter-square"), IconUnicodeGlyph(0xf081)]
        BrandsTwitterSquare = 373,
        ///<summary>Brands Shirtsinbulk</summary>
        ///<see href="https://fontawesome.com/icons/shirtsinbulk?style=brands"/>
        [Description("Brands Shirtsinbulk"), IconID("fab-shirtsinbulk"), IconUnicodeGlyph(0xf214)]
        BrandsShirtsinbulk = 374,
        ///<summary>Brands Weixin</summary>
        ///<see href="https://fontawesome.com/icons/weixin?style=brands"/>
        [Description("Brands Weixin"), IconID("fab-weixin"), IconUnicodeGlyph(0xf1d7)]
        BrandsWeixin = 375,
        ///<summary>Brands Fonticons</summary>
        ///<see href="https://fontawesome.com/icons/fonticons?style=brands"/>
        [Description("Brands Fonticons"), IconID("fab-fonticons"), IconUnicodeGlyph(0xf280)]
        BrandsFonticons = 376,
        ///<summary>Brands Watchman Monitoring</summary>
        ///<see href="https://fontawesome.com/icons/watchman-monitoring?style=brands"/>
        [Description("Brands Watchman Monitoring"), IconID("fab-watchman-monitoring"), IconUnicodeGlyph(0xe087)]
        BrandsWatchmanMonitoring = 377,
        ///<summary>Brands Creative Commons</summary>
        ///<see href="https://fontawesome.com/icons/creative-commons?style=brands"/>
        [Description("Brands Creative Commons"), IconID("fab-creative-commons"), IconUnicodeGlyph(0xf25e)]
        BrandsCreativeCommons = 378,
        ///<summary>Brands Viadeo Square</summary>
        ///<see href="https://fontawesome.com/icons/viadeo-square?style=brands"/>
        [Description("Brands Viadeo Square"), IconID("fab-viadeo-square"), IconUnicodeGlyph(0xf2aa)]
        BrandsViadeoSquare = 379,
        ///<summary>Brands Adversal</summary>
        ///<see href="https://fontawesome.com/icons/adversal?style=brands"/>
        [Description("Brands Adversal"), IconID("fab-adversal"), IconUnicodeGlyph(0xf36a)]
        BrandsAdversal = 380,
        ///<summary>Brands Creative Commons Sampling</summary>
        ///<see href="https://fontawesome.com/icons/creative-commons-sampling?style=brands"/>
        [Description("Brands Creative Commons Sampling"), IconID("fab-creative-commons-sampling"), IconUnicodeGlyph(0xf4f0)]
        BrandsCreativeCommonsSampling = 381,
        ///<summary>Brands Hacker News</summary>
        ///<see href="https://fontawesome.com/icons/hacker-news?style=brands"/>
        [Description("Brands Hacker News"), IconID("fab-hacker-news"), IconUnicodeGlyph(0xf1d4)]
        BrandsHackerNews = 382,
        ///<summary>Brands Evernote</summary>
        ///<see href="https://fontawesome.com/icons/evernote?style=brands"/>
        [Description("Brands Evernote"), IconID("fab-evernote"), IconUnicodeGlyph(0xf839)]
        BrandsEvernote = 383,
        ///<summary>Brands Chromecast</summary>
        ///<see href="https://fontawesome.com/icons/chromecast?style=brands"/>
        [Description("Brands Chromecast"), IconID("fab-chromecast"), IconUnicodeGlyph(0xf838)]
        BrandsChromecast = 384,
        ///<summary>Brands Nimblr</summary>
        ///<see href="https://fontawesome.com/icons/nimblr?style=brands"/>
        [Description("Brands Nimblr"), IconID("fab-nimblr"), IconUnicodeGlyph(0xf5a8)]
        BrandsNimblr = 385,
        ///<summary>Brands Digital Ocean</summary>
        ///<see href="https://fontawesome.com/icons/digital-ocean?style=brands"/>
        [Description("Brands Digital Ocean"), IconID("fab-digital-ocean"), IconUnicodeGlyph(0xf391)]
        BrandsDigitalOcean = 386,
        ///<summary>Brands Google Plus Square</summary>
        ///<see href="https://fontawesome.com/icons/google-plus-square?style=brands"/>
        [Description("Brands Google Plus Square"), IconID("fab-google-plus-square"), IconUnicodeGlyph(0xf0d4)]
        BrandsGooglePlusSquare = 387,
        ///<summary>Brands Linkedin In</summary>
        ///<see href="https://fontawesome.com/icons/linkedin-in?style=brands"/>
        [Description("Brands Linkedin In"), IconID("fab-linkedin-in"), IconUnicodeGlyph(0xf0e1)]
        BrandsLinkedinIn = 388,
        ///<summary>Brands Atlassian</summary>
        ///<see href="https://fontawesome.com/icons/atlassian?style=brands"/>
        [Description("Brands Atlassian"), IconID("fab-atlassian"), IconUnicodeGlyph(0xf77b)]
        BrandsAtlassian = 389,
        ///<summary>Brands Google</summary>
        ///<see href="https://fontawesome.com/icons/google?style=brands"/>
        [Description("Brands Google"), IconID("fab-google"), IconUnicodeGlyph(0xf1a0)]
        BrandsGoogle = 390,
        ///<summary>Brands Safari</summary>
        ///<see href="https://fontawesome.com/icons/safari?style=brands"/>
        [Description("Brands Safari"), IconID("fab-safari"), IconUnicodeGlyph(0xf267)]
        BrandsSafari = 391,
        ///<summary>Brands Creative Commons Sa</summary>
        ///<see href="https://fontawesome.com/icons/creative-commons-sa?style=brands"/>
        [Description("Brands Creative Commons Sa"), IconID("fab-creative-commons-sa"), IconUnicodeGlyph(0xf4ef)]
        BrandsCreativeCommonsSa = 392,
        ///<summary>Brands Red River</summary>
        ///<see href="https://fontawesome.com/icons/red-river?style=brands"/>
        [Description("Brands Red River"), IconID("fab-red-river"), IconUnicodeGlyph(0xf3e3)]
        BrandsRedRiver = 393,
        ///<summary>Brands Algolia</summary>
        ///<see href="https://fontawesome.com/icons/algolia?style=brands"/>
        [Description("Brands Algolia"), IconID("fab-algolia"), IconUnicodeGlyph(0xf36c)]
        BrandsAlgolia = 394,
        ///<summary>Brands Pagelines</summary>
        ///<see href="https://fontawesome.com/icons/pagelines?style=brands"/>
        [Description("Brands Pagelines"), IconID("fab-pagelines"), IconUnicodeGlyph(0xf18c)]
        BrandsPagelines = 395,
        ///<summary>Brands Phoenix Squadron</summary>
        ///<see href="https://fontawesome.com/icons/phoenix-squadron?style=brands"/>
        [Description("Brands Phoenix Squadron"), IconID("fab-phoenix-squadron"), IconUnicodeGlyph(0xf511)]
        BrandsPhoenixSquadron = 396,
        ///<summary>Brands Github Alt</summary>
        ///<see href="https://fontawesome.com/icons/github-alt?style=brands"/>
        [Description("Brands Github Alt"), IconID("fab-github-alt"), IconUnicodeGlyph(0xf113)]
        BrandsGithubAlt = 397,
        ///<summary>Brands Stack Overflow</summary>
        ///<see href="https://fontawesome.com/icons/stack-overflow?style=brands"/>
        [Description("Brands Stack Overflow"), IconID("fab-stack-overflow"), IconUnicodeGlyph(0xf16c)]
        BrandsStackOverflow = 398,
        ///<summary>Brands Foursquare</summary>
        ///<see href="https://fontawesome.com/icons/foursquare?style=brands"/>
        [Description("Brands Foursquare"), IconID("fab-foursquare"), IconUnicodeGlyph(0xf180)]
        BrandsFoursquare = 399,
        ///<summary>Brands Diaspora</summary>
        ///<see href="https://fontawesome.com/icons/diaspora?style=brands"/>
        [Description("Brands Diaspora"), IconID("fab-diaspora"), IconUnicodeGlyph(0xf791)]
        BrandsDiaspora = 400,
        ///<summary>Brands Google Plus</summary>
        ///<see href="https://fontawesome.com/icons/google-plus?style=brands"/>
        [Description("Brands Google Plus"), IconID("fab-google-plus"), IconUnicodeGlyph(0xf2b3)]
        BrandsGooglePlus = 401,
        ///<summary>Brands Sourcetree</summary>
        ///<see href="https://fontawesome.com/icons/sourcetree?style=brands"/>
        [Description("Brands Sourcetree"), IconID("fab-sourcetree"), IconUnicodeGlyph(0xf7d3)]
        BrandsSourcetree = 402,
        ///<summary>Brands Markdown</summary>
        ///<see href="https://fontawesome.com/icons/markdown?style=brands"/>
        [Description("Brands Markdown"), IconID("fab-markdown"), IconUnicodeGlyph(0xf60f)]
        BrandsMarkdown = 403,
        ///<summary>Brands Artstation</summary>
        ///<see href="https://fontawesome.com/icons/artstation?style=brands"/>
        [Description("Brands Artstation"), IconID("fab-artstation"), IconUnicodeGlyph(0xf77a)]
        BrandsArtstation = 404,
        ///<summary>Brands Google Plus G</summary>
        ///<see href="https://fontawesome.com/icons/google-plus-g?style=brands"/>
        [Description("Brands Google Plus G"), IconID("fab-google-plus-g"), IconUnicodeGlyph(0xf0d5)]
        BrandsGooglePlusG = 405,
        ///<summary>Brands Napster</summary>
        ///<see href="https://fontawesome.com/icons/napster?style=brands"/>
        [Description("Brands Napster"), IconID("fab-napster"), IconUnicodeGlyph(0xf3d2)]
        BrandsNapster = 406,
        ///<summary>Brands Edge</summary>
        ///<see href="https://fontawesome.com/icons/edge?style=brands"/>
        [Description("Brands Edge"), IconID("fab-edge"), IconUnicodeGlyph(0xf282)]
        BrandsEdge = 407,
        ///<summary>Brands Hacker News Square</summary>
        ///<see href="https://fontawesome.com/icons/hacker-news-square?style=brands"/>
        [Description("Brands Hacker News Square"), IconID("fab-hacker-news-square"), IconUnicodeGlyph(0xf3af)]
        BrandsHackerNewsSquare = 408,
        ///<summary>Brands The Red Yeti</summary>
        ///<see href="https://fontawesome.com/icons/the-red-yeti?style=brands"/>
        [Description("Brands The Red Yeti"), IconID("fab-the-red-yeti"), IconUnicodeGlyph(0xf69d)]
        BrandsTheRedYeti = 409,
        ///<summary>Brands Battle Net</summary>
        ///<see href="https://fontawesome.com/icons/battle-net?style=brands"/>
        [Description("Brands Battle Net"), IconID("fab-battle-net"), IconUnicodeGlyph(0xf835)]
        BrandsBattleNet = 410,
        ///<summary>Brands Sistrix</summary>
        ///<see href="https://fontawesome.com/icons/sistrix?style=brands"/>
        [Description("Brands Sistrix"), IconID("fab-sistrix"), IconUnicodeGlyph(0xf3ee)]
        BrandsSistrix = 411,
        ///<summary>Brands Lastfm Square</summary>
        ///<see href="https://fontawesome.com/icons/lastfm-square?style=brands"/>
        [Description("Brands Lastfm Square"), IconID("fab-lastfm-square"), IconUnicodeGlyph(0xf203)]
        BrandsLastfmSquare = 412,
        ///<summary>Brands Acquisitions Incorporated</summary>
        ///<see href="https://fontawesome.com/icons/acquisitions-incorporated?style=brands"/>
        [Description("Brands Acquisitions Incorporated"), IconID("fab-acquisitions-incorporated"), IconUnicodeGlyph(0xf6af)]
        BrandsAcquisitionsIncorporated = 413,
        ///<summary>Brands Deskpro</summary>
        ///<see href="https://fontawesome.com/icons/deskpro?style=brands"/>
        [Description("Brands Deskpro"), IconID("fab-deskpro"), IconUnicodeGlyph(0xf38f)]
        BrandsDeskpro = 414,
        ///<summary>Brands Contao</summary>
        ///<see href="https://fontawesome.com/icons/contao?style=brands"/>
        [Description("Brands Contao"), IconID("fab-contao"), IconUnicodeGlyph(0xf26d)]
        BrandsContao = 415,
        ///<summary>Brands Vimeo V</summary>
        ///<see href="https://fontawesome.com/icons/vimeo-v?style=brands"/>
        [Description("Brands Vimeo V"), IconID("fab-vimeo-v"), IconUnicodeGlyph(0xf27d)]
        BrandsVimeoV = 416,
        ///<summary>Brands Css3 Alt</summary>
        ///<see href="https://fontawesome.com/icons/css3-alt?style=brands"/>
        [Description("Brands Css3 Alt"), IconID("fab-css3-alt"), IconUnicodeGlyph(0xf38b)]
        BrandsCss3Alt = 417,
        ///<summary>Brands Snapchat Square</summary>
        ///<see href="https://fontawesome.com/icons/snapchat-square?style=brands"/>
        [Description("Brands Snapchat Square"), IconID("fab-snapchat-square"), IconUnicodeGlyph(0xf2ad)]
        BrandsSnapchatSquare = 418,
        ///<summary>Brands Mailchimp</summary>
        ///<see href="https://fontawesome.com/icons/mailchimp?style=brands"/>
        [Description("Brands Mailchimp"), IconID("fab-mailchimp"), IconUnicodeGlyph(0xf59e)]
        BrandsMailchimp = 419,
        ///<summary>Brands Untappd</summary>
        ///<see href="https://fontawesome.com/icons/untappd?style=brands"/>
        [Description("Brands Untappd"), IconID("fab-untappd"), IconUnicodeGlyph(0xf405)]
        BrandsUntappd = 420,
        ///<summary>Brands Vk</summary>
        ///<see href="https://fontawesome.com/icons/vk?style=brands"/>
        [Description("Brands Vk"), IconID("fab-vk"), IconUnicodeGlyph(0xf189)]
        BrandsVk = 421,
        ///<summary>Brands Rocketchat</summary>
        ///<see href="https://fontawesome.com/icons/rocketchat?style=brands"/>
        [Description("Brands Rocketchat"), IconID("fab-rocketchat"), IconUnicodeGlyph(0xf3e8)]
        BrandsRocketchat = 422,
        ///<summary>Brands Whmcs</summary>
        ///<see href="https://fontawesome.com/icons/whmcs?style=brands"/>
        [Description("Brands Whmcs"), IconID("fab-whmcs"), IconUnicodeGlyph(0xf40d)]
        BrandsWhmcs = 423,
        ///<summary>Brands Unity</summary>
        ///<see href="https://fontawesome.com/icons/unity?style=brands"/>
        [Description("Brands Unity"), IconID("fab-unity"), IconUnicodeGlyph(0xe049)]
        BrandsUnity = 424,
        ///<summary>Brands Creative Commons By</summary>
        ///<see href="https://fontawesome.com/icons/creative-commons-by?style=brands"/>
        [Description("Brands Creative Commons By"), IconID("fab-creative-commons-by"), IconUnicodeGlyph(0xf4e7)]
        BrandsCreativeCommonsBy = 425,
        ///<summary>Brands Hire A Helper</summary>
        ///<see href="https://fontawesome.com/icons/hire-a-helper?style=brands"/>
        [Description("Brands Hire A Helper"), IconID("fab-hire-a-helper"), IconUnicodeGlyph(0xf3b0)]
        BrandsHireAHelper = 426,
        ///<summary>Brands Drupal</summary>
        ///<see href="https://fontawesome.com/icons/drupal?style=brands"/>
        [Description("Brands Drupal"), IconID("fab-drupal"), IconUnicodeGlyph(0xf1a9)]
        BrandsDrupal = 427,
        ///<summary>Brands Glide G</summary>
        ///<see href="https://fontawesome.com/icons/glide-g?style=brands"/>
        [Description("Brands Glide G"), IconID("fab-glide-g"), IconUnicodeGlyph(0xf2a6)]
        BrandsGlideG = 428,
        ///<summary>Brands Centercode</summary>
        ///<see href="https://fontawesome.com/icons/centercode?style=brands"/>
        [Description("Brands Centercode"), IconID("fab-centercode"), IconUnicodeGlyph(0xf380)]
        BrandsCentercode = 429,
        ///<summary>Brands Creative Commons Pd Alt</summary>
        ///<see href="https://fontawesome.com/icons/creative-commons-pd-alt?style=brands"/>
        [Description("Brands Creative Commons Pd Alt"), IconID("fab-creative-commons-pd-alt"), IconUnicodeGlyph(0xf4ed)]
        BrandsCreativeCommonsPdAlt = 430,
        ///<summary>Brands Invision</summary>
        ///<see href="https://fontawesome.com/icons/invision?style=brands"/>
        [Description("Brands Invision"), IconID("fab-invision"), IconUnicodeGlyph(0xf7b0)]
        BrandsInvision = 431,
        ///<summary>Brands Java</summary>
        ///<see href="https://fontawesome.com/icons/java?style=brands"/>
        [Description("Brands Java"), IconID("fab-java"), IconUnicodeGlyph(0xf4e4)]
        BrandsJava = 432,
        ///<summary>Brands Orcid</summary>
        ///<see href="https://fontawesome.com/icons/orcid?style=brands"/>
        [Description("Brands Orcid"), IconID("fab-orcid"), IconUnicodeGlyph(0xf8d2)]
        BrandsOrcid = 433,
        ///<summary>Brands Qq</summary>
        ///<see href="https://fontawesome.com/icons/qq?style=brands"/>
        [Description("Brands Qq"), IconID("fab-qq"), IconUnicodeGlyph(0xf1d6)]
        BrandsQq = 434,
        ///<summary>Brands Microsoft</summary>
        ///<see href="https://fontawesome.com/icons/microsoft?style=brands"/>
        [Description("Brands Microsoft"), IconID("fab-microsoft"), IconUnicodeGlyph(0xf3ca)]
        BrandsMicrosoft = 435,
        ///<summary>Brands Vnv</summary>
        ///<see href="https://fontawesome.com/icons/vnv?style=brands"/>
        [Description("Brands Vnv"), IconID("fab-vnv"), IconUnicodeGlyph(0xf40b)]
        BrandsVnv = 436,
        ///<summary>Brands Guilded</summary>
        ///<see href="https://fontawesome.com/icons/guilded?style=brands"/>
        [Description("Brands Guilded"), IconID("fab-guilded"), IconUnicodeGlyph(0xe07e)]
        BrandsGuilded = 437,
        ///<summary>Brands Modx</summary>
        ///<see href="https://fontawesome.com/icons/modx?style=brands"/>
        [Description("Brands Modx"), IconID("fab-modx"), IconUnicodeGlyph(0xf285)]
        BrandsModx = 438,
        ///<summary>Brands First Order</summary>
        ///<see href="https://fontawesome.com/icons/first-order?style=brands"/>
        [Description("Brands First Order"), IconID("fab-first-order"), IconUnicodeGlyph(0xf2b0)]
        BrandsFirstOrder = 439,
        ///<summary>Brands Buysellads</summary>
        ///<see href="https://fontawesome.com/icons/buysellads?style=brands"/>
        [Description("Brands Buysellads"), IconID("fab-buysellads"), IconUnicodeGlyph(0xf20d)]
        BrandsBuysellads = 440,
        ///<summary>Brands Stackpath</summary>
        ///<see href="https://fontawesome.com/icons/stackpath?style=brands"/>
        [Description("Brands Stackpath"), IconID("fab-stackpath"), IconUnicodeGlyph(0xf842)]
        BrandsStackpath = 441,
        ///<summary>Brands Bity</summary>
        ///<see href="https://fontawesome.com/icons/bity?style=brands"/>
        [Description("Brands Bity"), IconID("fab-bity"), IconUnicodeGlyph(0xf37a)]
        BrandsBity = 442,
        ///<summary>Brands Dyalog</summary>
        ///<see href="https://fontawesome.com/icons/dyalog?style=brands"/>
        [Description("Brands Dyalog"), IconID("fab-dyalog"), IconUnicodeGlyph(0xf399)]
        BrandsDyalog = 443,
        ///<summary>Brands Wpexplorer</summary>
        ///<see href="https://fontawesome.com/icons/wpexplorer?style=brands"/>
        [Description("Brands Wpexplorer"), IconID("fab-wpexplorer"), IconUnicodeGlyph(0xf2de)]
        BrandsWpexplorer = 444,
        ///<summary>Brands Ups</summary>
        ///<see href="https://fontawesome.com/icons/ups?style=brands"/>
        [Description("Brands Ups"), IconID("fab-ups"), IconUnicodeGlyph(0xf7e0)]
        BrandsUps = 445,
        ///<summary>Brands Cloudflare</summary>
        ///<see href="https://fontawesome.com/icons/cloudflare?style=brands"/>
        [Description("Brands Cloudflare"), IconID("fab-cloudflare"), IconUnicodeGlyph(0xe07d)]
        BrandsCloudflare = 446,
        ///<summary>Brands Yoast</summary>
        ///<see href="https://fontawesome.com/icons/yoast?style=brands"/>
        [Description("Brands Yoast"), IconID("fab-yoast"), IconUnicodeGlyph(0xf2b1)]
        BrandsYoast = 447,
        ///<summary>Brands Redhat</summary>
        ///<see href="https://fontawesome.com/icons/redhat?style=brands"/>
        [Description("Brands Redhat"), IconID("fab-redhat"), IconUnicodeGlyph(0xf7bc)]
        BrandsRedhat = 448,
        ///<summary>Brands Aws</summary>
        ///<see href="https://fontawesome.com/icons/aws?style=brands"/>
        [Description("Brands Aws"), IconID("fab-aws"), IconUnicodeGlyph(0xf375)]
        BrandsAws = 449,
        ///<summary>Brands Creative Commons Nc</summary>
        ///<see href="https://fontawesome.com/icons/creative-commons-nc?style=brands"/>
        [Description("Brands Creative Commons Nc"), IconID("fab-creative-commons-nc"), IconUnicodeGlyph(0xf4e8)]
        BrandsCreativeCommonsNc = 450,
        ///<summary>Brands Shopware</summary>
        ///<see href="https://fontawesome.com/icons/shopware?style=brands"/>
        [Description("Brands Shopware"), IconID("fab-shopware"), IconUnicodeGlyph(0xf5b5)]
        BrandsShopware = 451,
        ///<summary>Brands Lastfm</summary>
        ///<see href="https://fontawesome.com/icons/lastfm?style=brands"/>
        [Description("Brands Lastfm"), IconID("fab-lastfm"), IconUnicodeGlyph(0xf202)]
        BrandsLastfm = 452,
        ///<summary>Brands Cc Visa</summary>
        ///<see href="https://fontawesome.com/icons/cc-visa?style=brands"/>
        [Description("Brands Cc Visa"), IconID("fab-cc-visa"), IconUnicodeGlyph(0xf1f0)]
        BrandsCcVisa = 453,
        ///<summary>Brands Yelp</summary>
        ///<see href="https://fontawesome.com/icons/yelp?style=brands"/>
        [Description("Brands Yelp"), IconID("fab-yelp"), IconUnicodeGlyph(0xf1e9)]
        BrandsYelp = 454,
        ///<summary>Brands Hooli</summary>
        ///<see href="https://fontawesome.com/icons/hooli?style=brands"/>
        [Description("Brands Hooli"), IconID("fab-hooli"), IconUnicodeGlyph(0xf427)]
        BrandsHooli = 455,
        ///<summary>Brands Monero</summary>
        ///<see href="https://fontawesome.com/icons/monero?style=brands"/>
        [Description("Brands Monero"), IconID("fab-monero"), IconUnicodeGlyph(0xf3d0)]
        BrandsMonero = 456,
        ///<summary>Regular Dizzy</summary>
        ///<see href="https://fontawesome.com/icons/dizzy?style=regular"/>
        [Description("Regular Dizzy"), IconID("far-dizzy"), IconUnicodeGlyph(0xf567)]
        RegularDizzy = 457,
        ///<summary>Regular Hand Point Left</summary>
        ///<see href="https://fontawesome.com/icons/hand-point-left?style=regular"/>
        [Description("Regular Hand Point Left"), IconID("far-hand-point-left"), IconUnicodeGlyph(0xf0a5)]
        RegularHandPointLeft = 458,
        ///<summary>Regular Window Minimize</summary>
        ///<see href="https://fontawesome.com/icons/window-minimize?style=regular"/>
        [Description("Regular Window Minimize"), IconID("far-window-minimize"), IconUnicodeGlyph(0xf2d1)]
        RegularWindowMinimize = 459,
        ///<summary>Regular Thumbs Up</summary>
        ///<see href="https://fontawesome.com/icons/thumbs-up?style=regular"/>
        [Description("Regular Thumbs Up"), IconID("far-thumbs-up"), IconUnicodeGlyph(0xf164)]
        RegularThumbsUp = 460,
        ///<summary>Regular Calendar Minus</summary>
        ///<see href="https://fontawesome.com/icons/calendar-minus?style=regular"/>
        [Description("Regular Calendar Minus"), IconID("far-calendar-minus"), IconUnicodeGlyph(0xf272)]
        RegularCalendarMinus = 461,
        ///<summary>Regular Life Ring</summary>
        ///<see href="https://fontawesome.com/icons/life-ring?style=regular"/>
        [Description("Regular Life Ring"), IconID("far-life-ring"), IconUnicodeGlyph(0xf1cd)]
        RegularLifeRing = 462,
        ///<summary>Regular Paper Plane</summary>
        ///<see href="https://fontawesome.com/icons/paper-plane?style=regular"/>
        [Description("Regular Paper Plane"), IconID("far-paper-plane"), IconUnicodeGlyph(0xf1d8)]
        RegularPaperPlane = 463,
        ///<summary>Regular Frown</summary>
        ///<see href="https://fontawesome.com/icons/frown?style=regular"/>
        [Description("Regular Frown"), IconID("far-frown"), IconUnicodeGlyph(0xf119)]
        RegularFrown = 464,
        ///<summary>Regular Grimace</summary>
        ///<see href="https://fontawesome.com/icons/grimace?style=regular"/>
        [Description("Regular Grimace"), IconID("far-grimace"), IconUnicodeGlyph(0xf57f)]
        RegularGrimace = 465,
        ///<summary>Regular Grin Tongue Squint</summary>
        ///<see href="https://fontawesome.com/icons/grin-tongue-squint?style=regular"/>
        [Description("Regular Grin Tongue Squint"), IconID("far-grin-tongue-squint"), IconUnicodeGlyph(0xf58a)]
        RegularGrinTongueSquint = 466,
        ///<summary>Regular Clone</summary>
        ///<see href="https://fontawesome.com/icons/clone?style=regular"/>
        [Description("Regular Clone"), IconID("far-clone"), IconUnicodeGlyph(0xf24d)]
        RegularClone = 467,
        ///<summary>Regular Calendar</summary>
        ///<see href="https://fontawesome.com/icons/calendar?style=regular"/>
        [Description("Regular Calendar"), IconID("far-calendar"), IconUnicodeGlyph(0xf133)]
        RegularCalendar = 468,
        ///<summary>Regular Calendar Alt</summary>
        ///<see href="https://fontawesome.com/icons/calendar-alt?style=regular"/>
        [Description("Regular Calendar Alt"), IconID("far-calendar-alt"), IconUnicodeGlyph(0xf073)]
        RegularCalendarAlt = 469,
        ///<summary>Regular Moon</summary>
        ///<see href="https://fontawesome.com/icons/moon?style=regular"/>
        [Description("Regular Moon"), IconID("far-moon"), IconUnicodeGlyph(0xf186)]
        RegularMoon = 470,
        ///<summary>Regular Kiss</summary>
        ///<see href="https://fontawesome.com/icons/kiss?style=regular"/>
        [Description("Regular Kiss"), IconID("far-kiss"), IconUnicodeGlyph(0xf596)]
        RegularKiss = 471,
        ///<summary>Regular Building</summary>
        ///<see href="https://fontawesome.com/icons/building?style=regular"/>
        [Description("Regular Building"), IconID("far-building"), IconUnicodeGlyph(0xf1ad)]
        RegularBuilding = 472,
        ///<summary>Regular Hand Peace</summary>
        ///<see href="https://fontawesome.com/icons/hand-peace?style=regular"/>
        [Description("Regular Hand Peace"), IconID("far-hand-peace"), IconUnicodeGlyph(0xf25b)]
        RegularHandPeace = 473,
        ///<summary>Regular Sad Tear</summary>
        ///<see href="https://fontawesome.com/icons/sad-tear?style=regular"/>
        [Description("Regular Sad Tear"), IconID("far-sad-tear"), IconUnicodeGlyph(0xf5b4)]
        RegularSadTear = 474,
        ///<summary>Regular Sticky Note</summary>
        ///<see href="https://fontawesome.com/icons/sticky-note?style=regular"/>
        [Description("Regular Sticky Note"), IconID("far-sticky-note"), IconUnicodeGlyph(0xf249)]
        RegularStickyNote = 475,
        ///<summary>Regular Hand Lizard</summary>
        ///<see href="https://fontawesome.com/icons/hand-lizard?style=regular"/>
        [Description("Regular Hand Lizard"), IconID("far-hand-lizard"), IconUnicodeGlyph(0xf258)]
        RegularHandLizard = 476,
        ///<summary>Regular Money Bill Alt</summary>
        ///<see href="https://fontawesome.com/icons/money-bill-alt?style=regular"/>
        [Description("Regular Money Bill Alt"), IconID("far-money-bill-alt"), IconUnicodeGlyph(0xf3d1)]
        RegularMoneyBillAlt = 477,
        ///<summary>Regular Bell Slash</summary>
        ///<see href="https://fontawesome.com/icons/bell-slash?style=regular"/>
        [Description("Regular Bell Slash"), IconID("far-bell-slash"), IconUnicodeGlyph(0xf1f6)]
        RegularBellSlash = 478,
        ///<summary>Regular Map</summary>
        ///<see href="https://fontawesome.com/icons/map?style=regular"/>
        [Description("Regular Map"), IconID("far-map"), IconUnicodeGlyph(0xf279)]
        RegularMap = 479,
        ///<summary>Regular Smile</summary>
        ///<see href="https://fontawesome.com/icons/smile?style=regular"/>
        [Description("Regular Smile"), IconID("far-smile"), IconUnicodeGlyph(0xf118)]
        RegularSmile = 480,
        ///<summary>Regular Copyright</summary>
        ///<see href="https://fontawesome.com/icons/copyright?style=regular"/>
        [Description("Regular Copyright"), IconID("far-copyright"), IconUnicodeGlyph(0xf1f9)]
        RegularCopyright = 481,
        ///<summary>Regular Copy</summary>
        ///<see href="https://fontawesome.com/icons/copy?style=regular"/>
        [Description("Regular Copy"), IconID("far-copy"), IconUnicodeGlyph(0xf0c5)]
        RegularCopy = 482,
        ///<summary>Regular Comment Alt</summary>
        ///<see href="https://fontawesome.com/icons/comment-alt?style=regular"/>
        [Description("Regular Comment Alt"), IconID("far-comment-alt"), IconUnicodeGlyph(0xf27a)]
        RegularCommentAlt = 483,
        ///<summary>Regular Kiss Beam</summary>
        ///<see href="https://fontawesome.com/icons/kiss-beam?style=regular"/>
        [Description("Regular Kiss Beam"), IconID("far-kiss-beam"), IconUnicodeGlyph(0xf597)]
        RegularKissBeam = 484,
        ///<summary>Regular Laugh Squint</summary>
        ///<see href="https://fontawesome.com/icons/laugh-squint?style=regular"/>
        [Description("Regular Laugh Squint"), IconID("far-laugh-squint"), IconUnicodeGlyph(0xf59b)]
        RegularLaughSquint = 485,
        ///<summary>Regular Stop Circle</summary>
        ///<see href="https://fontawesome.com/icons/stop-circle?style=regular"/>
        [Description("Regular Stop Circle"), IconID("far-stop-circle"), IconUnicodeGlyph(0xf28d)]
        RegularStopCircle = 486,
        ///<summary>Regular Star Half</summary>
        ///<see href="https://fontawesome.com/icons/star-half?style=regular"/>
        [Description("Regular Star Half"), IconID("far-star-half"), IconUnicodeGlyph(0xf089)]
        RegularStarHalf = 487,
        ///<summary>Regular Trash Alt</summary>
        ///<see href="https://fontawesome.com/icons/trash-alt?style=regular"/>
        [Description("Regular Trash Alt"), IconID("far-trash-alt"), IconUnicodeGlyph(0xf2ed)]
        RegularTrashAlt = 488,
        ///<summary>Regular Font Awesome Logo Full</summary>
        ///<see href="https://fontawesome.com/icons/font-awesome-logo-full?style=regular"/>
        [Description("Regular Font Awesome Logo Full"), IconID("far-font-awesome-logo-full"), IconUnicodeGlyph(0xf4e6)]
        RegularFontAwesomeLogoFull = 489,
        ///<summary>Regular Hospital</summary>
        ///<see href="https://fontawesome.com/icons/hospital?style=regular"/>
        [Description("Regular Hospital"), IconID("far-hospital"), IconUnicodeGlyph(0xf0f8)]
        RegularHospital = 490,
        ///<summary>Regular File</summary>
        ///<see href="https://fontawesome.com/icons/file?style=regular"/>
        [Description("Regular File"), IconID("far-file"), IconUnicodeGlyph(0xf15b)]
        RegularFile = 491,
        ///<summary>Regular Bell</summary>
        ///<see href="https://fontawesome.com/icons/bell?style=regular"/>
        [Description("Regular Bell"), IconID("far-bell"), IconUnicodeGlyph(0xf0f3)]
        RegularBell = 492,
        ///<summary>Regular Credit Card</summary>
        ///<see href="https://fontawesome.com/icons/credit-card?style=regular"/>
        [Description("Regular Credit Card"), IconID("far-credit-card"), IconUnicodeGlyph(0xf09d)]
        RegularCreditCard = 493,
        ///<summary>Regular Thumbs Down</summary>
        ///<see href="https://fontawesome.com/icons/thumbs-down?style=regular"/>
        [Description("Regular Thumbs Down"), IconID("far-thumbs-down"), IconUnicodeGlyph(0xf165)]
        RegularThumbsDown = 494,
        ///<summary>Regular Sun</summary>
        ///<see href="https://fontawesome.com/icons/sun?style=regular"/>
        [Description("Regular Sun"), IconID("far-sun"), IconUnicodeGlyph(0xf185)]
        RegularSun = 495,
        ///<summary>Regular Id Card</summary>
        ///<see href="https://fontawesome.com/icons/id-card?style=regular"/>
        [Description("Regular Id Card"), IconID("far-id-card"), IconUnicodeGlyph(0xf2c2)]
        RegularIdCard = 496,
        ///<summary>Regular Smile Wink</summary>
        ///<see href="https://fontawesome.com/icons/smile-wink?style=regular"/>
        [Description("Regular Smile Wink"), IconID("far-smile-wink"), IconUnicodeGlyph(0xf4da)]
        RegularSmileWink = 497,
        ///<summary>Regular Images</summary>
        ///<see href="https://fontawesome.com/icons/images?style=regular"/>
        [Description("Regular Images"), IconID("far-images"), IconUnicodeGlyph(0xf302)]
        RegularImages = 498,
        ///<summary>Regular Closed Captioning</summary>
        ///<see href="https://fontawesome.com/icons/closed-captioning?style=regular"/>
        [Description("Regular Closed Captioning"), IconID("far-closed-captioning"), IconUnicodeGlyph(0xf20a)]
        RegularClosedCaptioning = 499,
        ///<summary>Regular Edit</summary>
        ///<see href="https://fontawesome.com/icons/edit?style=regular"/>
        [Description("Regular Edit"), IconID("far-edit"), IconUnicodeGlyph(0xf044)]
        RegularEdit = 500,
        ///<summary>Regular Grin Stars</summary>
        ///<see href="https://fontawesome.com/icons/grin-stars?style=regular"/>
        [Description("Regular Grin Stars"), IconID("far-grin-stars"), IconUnicodeGlyph(0xf587)]
        RegularGrinStars = 501,
        ///<summary>Regular Keyboard</summary>
        ///<see href="https://fontawesome.com/icons/keyboard?style=regular"/>
        [Description("Regular Keyboard"), IconID("far-keyboard"), IconUnicodeGlyph(0xf11c)]
        RegularKeyboard = 502,
        ///<summary>Regular Clock</summary>
        ///<see href="https://fontawesome.com/icons/clock?style=regular"/>
        [Description("Regular Clock"), IconID("far-clock"), IconUnicodeGlyph(0xf017)]
        RegularClock = 503,
        ///<summary>Regular Question Circle</summary>
        ///<see href="https://fontawesome.com/icons/question-circle?style=regular"/>
        [Description("Regular Question Circle"), IconID("far-question-circle"), IconUnicodeGlyph(0xf059)]
        RegularQuestionCircle = 504,
        ///<summary>Regular Calendar Plus</summary>
        ///<see href="https://fontawesome.com/icons/calendar-plus?style=regular"/>
        [Description("Regular Calendar Plus"), IconID("far-calendar-plus"), IconUnicodeGlyph(0xf271)]
        RegularCalendarPlus = 505,
        ///<summary>Regular Tired</summary>
        ///<see href="https://fontawesome.com/icons/tired?style=regular"/>
        [Description("Regular Tired"), IconID("far-tired"), IconUnicodeGlyph(0xf5c8)]
        RegularTired = 506,
        ///<summary>Regular Calendar Check</summary>
        ///<see href="https://fontawesome.com/icons/calendar-check?style=regular"/>
        [Description("Regular Calendar Check"), IconID("far-calendar-check"), IconUnicodeGlyph(0xf274)]
        RegularCalendarCheck = 507,
        ///<summary>Regular Hand Paper</summary>
        ///<see href="https://fontawesome.com/icons/hand-paper?style=regular"/>
        [Description("Regular Hand Paper"), IconID("far-hand-paper"), IconUnicodeGlyph(0xf256)]
        RegularHandPaper = 508,
        ///<summary>Regular Laugh Beam</summary>
        ///<see href="https://fontawesome.com/icons/laugh-beam?style=regular"/>
        [Description("Regular Laugh Beam"), IconID("far-laugh-beam"), IconUnicodeGlyph(0xf59a)]
        RegularLaughBeam = 509,
        ///<summary>Regular Hourglass</summary>
        ///<see href="https://fontawesome.com/icons/hourglass?style=regular"/>
        [Description("Regular Hourglass"), IconID("far-hourglass"), IconUnicodeGlyph(0xf254)]
        RegularHourglass = 510,
        ///<summary>Regular Grin Squint Tears</summary>
        ///<see href="https://fontawesome.com/icons/grin-squint-tears?style=regular"/>
        [Description("Regular Grin Squint Tears"), IconID("far-grin-squint-tears"), IconUnicodeGlyph(0xf586)]
        RegularGrinSquintTears = 511,
        ///<summary>Regular Envelope</summary>
        ///<see href="https://fontawesome.com/icons/envelope?style=regular"/>
        [Description("Regular Envelope"), IconID("far-envelope"), IconUnicodeGlyph(0xf0e0)]
        RegularEnvelope = 512,
        ///<summary>Regular Comment</summary>
        ///<see href="https://fontawesome.com/icons/comment?style=regular"/>
        [Description("Regular Comment"), IconID("far-comment"), IconUnicodeGlyph(0xf075)]
        RegularComment = 513,
        ///<summary>Regular Angry</summary>
        ///<see href="https://fontawesome.com/icons/angry?style=regular"/>
        [Description("Regular Angry"), IconID("far-angry"), IconUnicodeGlyph(0xf556)]
        RegularAngry = 514,
        ///<summary>Regular File Pdf</summary>
        ///<see href="https://fontawesome.com/icons/file-pdf?style=regular"/>
        [Description("Regular File Pdf"), IconID("far-file-pdf"), IconUnicodeGlyph(0xf1c1)]
        RegularFilePdf = 515,
        ///<summary>Regular File Video</summary>
        ///<see href="https://fontawesome.com/icons/file-video?style=regular"/>
        [Description("Regular File Video"), IconID("far-file-video"), IconUnicodeGlyph(0xf1c8)]
        RegularFileVideo = 516,
        ///<summary>Regular Pause Circle</summary>
        ///<see href="https://fontawesome.com/icons/pause-circle?style=regular"/>
        [Description("Regular Pause Circle"), IconID("far-pause-circle"), IconUnicodeGlyph(0xf28b)]
        RegularPauseCircle = 517,
        ///<summary>Regular Share Square</summary>
        ///<see href="https://fontawesome.com/icons/share-square?style=regular"/>
        [Description("Regular Share Square"), IconID("far-share-square"), IconUnicodeGlyph(0xf14d)]
        RegularShareSquare = 518,
        ///<summary>Regular Grin Tongue</summary>
        ///<see href="https://fontawesome.com/icons/grin-tongue?style=regular"/>
        [Description("Regular Grin Tongue"), IconID("far-grin-tongue"), IconUnicodeGlyph(0xf589)]
        RegularGrinTongue = 519,
        ///<summary>Regular Hand Scissors</summary>
        ///<see href="https://fontawesome.com/icons/hand-scissors?style=regular"/>
        [Description("Regular Hand Scissors"), IconID("far-hand-scissors"), IconUnicodeGlyph(0xf257)]
        RegularHandScissors = 520,
        ///<summary>Regular Hand Pointer</summary>
        ///<see href="https://fontawesome.com/icons/hand-pointer?style=regular"/>
        [Description("Regular Hand Pointer"), IconID("far-hand-pointer"), IconUnicodeGlyph(0xf25a)]
        RegularHandPointer = 521,
        ///<summary>Regular Comment Dots</summary>
        ///<see href="https://fontawesome.com/icons/comment-dots?style=regular"/>
        [Description("Regular Comment Dots"), IconID("far-comment-dots"), IconUnicodeGlyph(0xf4ad)]
        RegularCommentDots = 522,
        ///<summary>Regular Window Maximize</summary>
        ///<see href="https://fontawesome.com/icons/window-maximize?style=regular"/>
        [Description("Regular Window Maximize"), IconID("far-window-maximize"), IconUnicodeGlyph(0xf2d0)]
        RegularWindowMaximize = 523,
        ///<summary>Regular File Code</summary>
        ///<see href="https://fontawesome.com/icons/file-code?style=regular"/>
        [Description("Regular File Code"), IconID("far-file-code"), IconUnicodeGlyph(0xf1c9)]
        RegularFileCode = 524,
        ///<summary>Regular File Archive</summary>
        ///<see href="https://fontawesome.com/icons/file-archive?style=regular"/>
        [Description("Regular File Archive"), IconID("far-file-archive"), IconUnicodeGlyph(0xf1c6)]
        RegularFileArchive = 525,
        ///<summary>Regular Eye</summary>
        ///<see href="https://fontawesome.com/icons/eye?style=regular"/>
        [Description("Regular Eye"), IconID("far-eye"), IconUnicodeGlyph(0xf06e)]
        RegularEye = 526,
        ///<summary>Regular Caret Square Down</summary>
        ///<see href="https://fontawesome.com/icons/caret-square-down?style=regular"/>
        [Description("Regular Caret Square Down"), IconID("far-caret-square-down"), IconUnicodeGlyph(0xf150)]
        RegularCaretSquareDown = 527,
        ///<summary>Regular File Image</summary>
        ///<see href="https://fontawesome.com/icons/file-image?style=regular"/>
        [Description("Regular File Image"), IconID("far-file-image"), IconUnicodeGlyph(0xf1c5)]
        RegularFileImage = 528,
        ///<summary>Regular File Audio</summary>
        ///<see href="https://fontawesome.com/icons/file-audio?style=regular"/>
        [Description("Regular File Audio"), IconID("far-file-audio"), IconUnicodeGlyph(0xf1c7)]
        RegularFileAudio = 529,
        ///<summary>Regular Circle</summary>
        ///<see href="https://fontawesome.com/icons/circle?style=regular"/>
        [Description("Regular Circle"), IconID("far-circle"), IconUnicodeGlyph(0xf111)]
        RegularCircle = 530,
        ///<summary>Regular Heart</summary>
        ///<see href="https://fontawesome.com/icons/heart?style=regular"/>
        [Description("Regular Heart"), IconID("far-heart"), IconUnicodeGlyph(0xf004)]
        RegularHeart = 531,
        ///<summary>Regular Hand Rock</summary>
        ///<see href="https://fontawesome.com/icons/hand-rock?style=regular"/>
        [Description("Regular Hand Rock"), IconID("far-hand-rock"), IconUnicodeGlyph(0xf255)]
        RegularHandRock = 532,
        ///<summary>Regular Object Group</summary>
        ///<see href="https://fontawesome.com/icons/object-group?style=regular"/>
        [Description("Regular Object Group"), IconID("far-object-group"), IconUnicodeGlyph(0xf247)]
        RegularObjectGroup = 533,
        ///<summary>Regular Object Ungroup</summary>
        ///<see href="https://fontawesome.com/icons/object-ungroup?style=regular"/>
        [Description("Regular Object Ungroup"), IconID("far-object-ungroup"), IconUnicodeGlyph(0xf248)]
        RegularObjectUngroup = 534,
        ///<summary>Regular File Excel</summary>
        ///<see href="https://fontawesome.com/icons/file-excel?style=regular"/>
        [Description("Regular File Excel"), IconID("far-file-excel"), IconUnicodeGlyph(0xf1c3)]
        RegularFileExcel = 535,
        ///<summary>Regular Grin Squint</summary>
        ///<see href="https://fontawesome.com/icons/grin-squint?style=regular"/>
        [Description("Regular Grin Squint"), IconID("far-grin-squint"), IconUnicodeGlyph(0xf585)]
        RegularGrinSquint = 536,
        ///<summary>Regular Newspaper</summary>
        ///<see href="https://fontawesome.com/icons/newspaper?style=regular"/>
        [Description("Regular Newspaper"), IconID("far-newspaper"), IconUnicodeGlyph(0xf1ea)]
        RegularNewspaper = 537,
        ///<summary>Regular List Alt</summary>
        ///<see href="https://fontawesome.com/icons/list-alt?style=regular"/>
        [Description("Regular List Alt"), IconID("far-list-alt"), IconUnicodeGlyph(0xf022)]
        RegularListAlt = 538,
        ///<summary>Regular Snowflake</summary>
        ///<see href="https://fontawesome.com/icons/snowflake?style=regular"/>
        [Description("Regular Snowflake"), IconID("far-snowflake"), IconUnicodeGlyph(0xf2dc)]
        RegularSnowflake = 539,
        ///<summary>Regular Save</summary>
        ///<see href="https://fontawesome.com/icons/save?style=regular"/>
        [Description("Regular Save"), IconID("far-save"), IconUnicodeGlyph(0xf0c7)]
        RegularSave = 540,
        ///<summary>Regular Square</summary>
        ///<see href="https://fontawesome.com/icons/square?style=regular"/>
        [Description("Regular Square"), IconID("far-square"), IconUnicodeGlyph(0xf0c8)]
        RegularSquare = 541,
        ///<summary>Regular Envelope Open</summary>
        ///<see href="https://fontawesome.com/icons/envelope-open?style=regular"/>
        [Description("Regular Envelope Open"), IconID("far-envelope-open"), IconUnicodeGlyph(0xf2b6)]
        RegularEnvelopeOpen = 542,
        ///<summary>Regular File Powerpoint</summary>
        ///<see href="https://fontawesome.com/icons/file-powerpoint?style=regular"/>
        [Description("Regular File Powerpoint"), IconID("far-file-powerpoint"), IconUnicodeGlyph(0xf1c4)]
        RegularFilePowerpoint = 543,
        ///<summary>Regular File Word</summary>
        ///<see href="https://fontawesome.com/icons/file-word?style=regular"/>
        [Description("Regular File Word"), IconID("far-file-word"), IconUnicodeGlyph(0xf1c2)]
        RegularFileWord = 544,
        ///<summary>Regular File Alt</summary>
        ///<see href="https://fontawesome.com/icons/file-alt?style=regular"/>
        [Description("Regular File Alt"), IconID("far-file-alt"), IconUnicodeGlyph(0xf15c)]
        RegularFileAlt = 545,
        ///<summary>Regular Check Circle</summary>
        ///<see href="https://fontawesome.com/icons/check-circle?style=regular"/>
        [Description("Regular Check Circle"), IconID("far-check-circle"), IconUnicodeGlyph(0xf058)]
        RegularCheckCircle = 546,
        ///<summary>Regular Address Card</summary>
        ///<see href="https://fontawesome.com/icons/address-card?style=regular"/>
        [Description("Regular Address Card"), IconID("far-address-card"), IconUnicodeGlyph(0xf2bb)]
        RegularAddressCard = 547,
        ///<summary>Regular Registered</summary>
        ///<see href="https://fontawesome.com/icons/registered?style=regular"/>
        [Description("Regular Registered"), IconID("far-registered"), IconUnicodeGlyph(0xf25d)]
        RegularRegistered = 548,
        ///<summary>Regular Grin Tongue Wink</summary>
        ///<see href="https://fontawesome.com/icons/grin-tongue-wink?style=regular"/>
        [Description("Regular Grin Tongue Wink"), IconID("far-grin-tongue-wink"), IconUnicodeGlyph(0xf58b)]
        RegularGrinTongueWink = 549,
        ///<summary>Regular Arrow Alt Circle Left</summary>
        ///<see href="https://fontawesome.com/icons/arrow-alt-circle-left?style=regular"/>
        [Description("Regular Arrow Alt Circle Left"), IconID("far-arrow-alt-circle-left"), IconUnicodeGlyph(0xf359)]
        RegularArrowAltCircleLeft = 550,
        ///<summary>Regular Id Badge</summary>
        ///<see href="https://fontawesome.com/icons/id-badge?style=regular"/>
        [Description("Regular Id Badge"), IconID("far-id-badge"), IconUnicodeGlyph(0xf2c1)]
        RegularIdBadge = 551,
        ///<summary>Regular Gem</summary>
        ///<see href="https://fontawesome.com/icons/gem?style=regular"/>
        [Description("Regular Gem"), IconID("far-gem"), IconUnicodeGlyph(0xf3a5)]
        RegularGem = 552,
        ///<summary>Regular Handshake</summary>
        ///<see href="https://fontawesome.com/icons/handshake?style=regular"/>
        [Description("Regular Handshake"), IconID("far-handshake"), IconUnicodeGlyph(0xf2b5)]
        RegularHandshake = 553,
        ///<summary>Regular Lemon</summary>
        ///<see href="https://fontawesome.com/icons/lemon?style=regular"/>
        [Description("Regular Lemon"), IconID("far-lemon"), IconUnicodeGlyph(0xf094)]
        RegularLemon = 554,
        ///<summary>Regular Image</summary>
        ///<see href="https://fontawesome.com/icons/image?style=regular"/>
        [Description("Regular Image"), IconID("far-image"), IconUnicodeGlyph(0xf03e)]
        RegularImage = 555,
        ///<summary>Regular Window Restore</summary>
        ///<see href="https://fontawesome.com/icons/window-restore?style=regular"/>
        [Description("Regular Window Restore"), IconID("far-window-restore"), IconUnicodeGlyph(0xf2d2)]
        RegularWindowRestore = 556,
        ///<summary>Regular Chart Bar</summary>
        ///<see href="https://fontawesome.com/icons/chart-bar?style=regular"/>
        [Description("Regular Chart Bar"), IconID("far-chart-bar"), IconUnicodeGlyph(0xf080)]
        RegularChartBar = 557,
        ///<summary>Regular Laugh Wink</summary>
        ///<see href="https://fontawesome.com/icons/laugh-wink?style=regular"/>
        [Description("Regular Laugh Wink"), IconID("far-laugh-wink"), IconUnicodeGlyph(0xf59c)]
        RegularLaughWink = 558,
        ///<summary>Regular Flushed</summary>
        ///<see href="https://fontawesome.com/icons/flushed?style=regular"/>
        [Description("Regular Flushed"), IconID("far-flushed"), IconUnicodeGlyph(0xf579)]
        RegularFlushed = 559,
        ///<summary>Regular Hdd</summary>
        ///<see href="https://fontawesome.com/icons/hdd?style=regular"/>
        [Description("Regular Hdd"), IconID("far-hdd"), IconUnicodeGlyph(0xf0a0)]
        RegularHdd = 560,
        ///<summary>Regular Laugh</summary>
        ///<see href="https://fontawesome.com/icons/laugh?style=regular"/>
        [Description("Regular Laugh"), IconID("far-laugh"), IconUnicodeGlyph(0xf599)]
        RegularLaugh = 561,
        ///<summary>Regular Meh Rolling Eyes</summary>
        ///<see href="https://fontawesome.com/icons/meh-rolling-eyes?style=regular"/>
        [Description("Regular Meh Rolling Eyes"), IconID("far-meh-rolling-eyes"), IconUnicodeGlyph(0xf5a5)]
        RegularMehRollingEyes = 562,
        ///<summary>Regular Clipboard</summary>
        ///<see href="https://fontawesome.com/icons/clipboard?style=regular"/>
        [Description("Regular Clipboard"), IconID("far-clipboard"), IconUnicodeGlyph(0xf328)]
        RegularClipboard = 563,
        ///<summary>Regular Folder Open</summary>
        ///<see href="https://fontawesome.com/icons/folder-open?style=regular"/>
        [Description("Regular Folder Open"), IconID("far-folder-open"), IconUnicodeGlyph(0xf07c)]
        RegularFolderOpen = 564,
        ///<summary>Regular Minus Square</summary>
        ///<see href="https://fontawesome.com/icons/minus-square?style=regular"/>
        [Description("Regular Minus Square"), IconID("far-minus-square"), IconUnicodeGlyph(0xf146)]
        RegularMinusSquare = 565,
        ///<summary>Regular Window Close</summary>
        ///<see href="https://fontawesome.com/icons/window-close?style=regular"/>
        [Description("Regular Window Close"), IconID("far-window-close"), IconUnicodeGlyph(0xf410)]
        RegularWindowClose = 566,
        ///<summary>Regular Grin</summary>
        ///<see href="https://fontawesome.com/icons/grin?style=regular"/>
        [Description("Regular Grin"), IconID("far-grin"), IconUnicodeGlyph(0xf580)]
        RegularGrin = 567,
        ///<summary>Regular Meh Blank</summary>
        ///<see href="https://fontawesome.com/icons/meh-blank?style=regular"/>
        [Description("Regular Meh Blank"), IconID("far-meh-blank"), IconUnicodeGlyph(0xf5a4)]
        RegularMehBlank = 568,
        ///<summary>Regular Play Circle</summary>
        ///<see href="https://fontawesome.com/icons/play-circle?style=regular"/>
        [Description("Regular Play Circle"), IconID("far-play-circle"), IconUnicodeGlyph(0xf144)]
        RegularPlayCircle = 569,
        ///<summary>Regular Meh</summary>
        ///<see href="https://fontawesome.com/icons/meh?style=regular"/>
        [Description("Regular Meh"), IconID("far-meh"), IconUnicodeGlyph(0xf11a)]
        RegularMeh = 570,
        ///<summary>Regular Star</summary>
        ///<see href="https://fontawesome.com/icons/star?style=regular"/>
        [Description("Regular Star"), IconID("far-star"), IconUnicodeGlyph(0xf005)]
        RegularStar = 571,
        ///<summary>Regular Grin Wink</summary>
        ///<see href="https://fontawesome.com/icons/grin-wink?style=regular"/>
        [Description("Regular Grin Wink"), IconID("far-grin-wink"), IconUnicodeGlyph(0xf58c)]
        RegularGrinWink = 572,
        ///<summary>Regular User</summary>
        ///<see href="https://fontawesome.com/icons/user?style=regular"/>
        [Description("Regular User"), IconID("far-user"), IconUnicodeGlyph(0xf007)]
        RegularUser = 573,
        ///<summary>Regular Folder</summary>
        ///<see href="https://fontawesome.com/icons/folder?style=regular"/>
        [Description("Regular Folder"), IconID("far-folder"), IconUnicodeGlyph(0xf07b)]
        RegularFolder = 574,
        ///<summary>Regular Hand Point Down</summary>
        ///<see href="https://fontawesome.com/icons/hand-point-down?style=regular"/>
        [Description("Regular Hand Point Down"), IconID("far-hand-point-down"), IconUnicodeGlyph(0xf0a7)]
        RegularHandPointDown = 575,
        ///<summary>Regular Calendar Times</summary>
        ///<see href="https://fontawesome.com/icons/calendar-times?style=regular"/>
        [Description("Regular Calendar Times"), IconID("far-calendar-times"), IconUnicodeGlyph(0xf273)]
        RegularCalendarTimes = 576,
        ///<summary>Regular Bookmark</summary>
        ///<see href="https://fontawesome.com/icons/bookmark?style=regular"/>
        [Description("Regular Bookmark"), IconID("far-bookmark"), IconUnicodeGlyph(0xf02e)]
        RegularBookmark = 577,
        ///<summary>Regular Hand Point Up</summary>
        ///<see href="https://fontawesome.com/icons/hand-point-up?style=regular"/>
        [Description("Regular Hand Point Up"), IconID("far-hand-point-up"), IconUnicodeGlyph(0xf0a6)]
        RegularHandPointUp = 578,
        ///<summary>Regular Check Square</summary>
        ///<see href="https://fontawesome.com/icons/check-square?style=regular"/>
        [Description("Regular Check Square"), IconID("far-check-square"), IconUnicodeGlyph(0xf14a)]
        RegularCheckSquare = 579,
        ///<summary>Regular Grin Alt</summary>
        ///<see href="https://fontawesome.com/icons/grin-alt?style=regular"/>
        [Description("Regular Grin Alt"), IconID("far-grin-alt"), IconUnicodeGlyph(0xf581)]
        RegularGrinAlt = 580,
        ///<summary>Regular Caret Square Up</summary>
        ///<see href="https://fontawesome.com/icons/caret-square-up?style=regular"/>
        [Description("Regular Caret Square Up"), IconID("far-caret-square-up"), IconUnicodeGlyph(0xf151)]
        RegularCaretSquareUp = 581,
        ///<summary>Regular Plus Square</summary>
        ///<see href="https://fontawesome.com/icons/plus-square?style=regular"/>
        [Description("Regular Plus Square"), IconID("far-plus-square"), IconUnicodeGlyph(0xf0fe)]
        RegularPlusSquare = 582,
        ///<summary>Regular Arrow Alt Circle Right</summary>
        ///<see href="https://fontawesome.com/icons/arrow-alt-circle-right?style=regular"/>
        [Description("Regular Arrow Alt Circle Right"), IconID("far-arrow-alt-circle-right"), IconUnicodeGlyph(0xf35a)]
        RegularArrowAltCircleRight = 583,
        ///<summary>Regular Arrow Alt Circle Up</summary>
        ///<see href="https://fontawesome.com/icons/arrow-alt-circle-up?style=regular"/>
        [Description("Regular Arrow Alt Circle Up"), IconID("far-arrow-alt-circle-up"), IconUnicodeGlyph(0xf35b)]
        RegularArrowAltCircleUp = 584,
        ///<summary>Regular Arrow Alt Circle Down</summary>
        ///<see href="https://fontawesome.com/icons/arrow-alt-circle-down?style=regular"/>
        [Description("Regular Arrow Alt Circle Down"), IconID("far-arrow-alt-circle-down"), IconUnicodeGlyph(0xf358)]
        RegularArrowAltCircleDown = 585,
        ///<summary>Regular Caret Square Left</summary>
        ///<see href="https://fontawesome.com/icons/caret-square-left?style=regular"/>
        [Description("Regular Caret Square Left"), IconID("far-caret-square-left"), IconUnicodeGlyph(0xf191)]
        RegularCaretSquareLeft = 586,
        ///<summary>Regular Smile Beam</summary>
        ///<see href="https://fontawesome.com/icons/smile-beam?style=regular"/>
        [Description("Regular Smile Beam"), IconID("far-smile-beam"), IconUnicodeGlyph(0xf5b8)]
        RegularSmileBeam = 587,
        ///<summary>Regular Hand Spock</summary>
        ///<see href="https://fontawesome.com/icons/hand-spock?style=regular"/>
        [Description("Regular Hand Spock"), IconID("far-hand-spock"), IconUnicodeGlyph(0xf259)]
        RegularHandSpock = 588,
        ///<summary>Regular Grin Beam Sweat</summary>
        ///<see href="https://fontawesome.com/icons/grin-beam-sweat?style=regular"/>
        [Description("Regular Grin Beam Sweat"), IconID("far-grin-beam-sweat"), IconUnicodeGlyph(0xf583)]
        RegularGrinBeamSweat = 589,
        ///<summary>Regular Surprise</summary>
        ///<see href="https://fontawesome.com/icons/surprise?style=regular"/>
        [Description("Regular Surprise"), IconID("far-surprise"), IconUnicodeGlyph(0xf5c2)]
        RegularSurprise = 590,
        ///<summary>Regular Caret Square Right</summary>
        ///<see href="https://fontawesome.com/icons/caret-square-right?style=regular"/>
        [Description("Regular Caret Square Right"), IconID("far-caret-square-right"), IconUnicodeGlyph(0xf152)]
        RegularCaretSquareRight = 591,
        ///<summary>Regular Eye Slash</summary>
        ///<see href="https://fontawesome.com/icons/eye-slash?style=regular"/>
        [Description("Regular Eye Slash"), IconID("far-eye-slash"), IconUnicodeGlyph(0xf070)]
        RegularEyeSlash = 592,
        ///<summary>Regular Frown Open</summary>
        ///<see href="https://fontawesome.com/icons/frown-open?style=regular"/>
        [Description("Regular Frown Open"), IconID("far-frown-open"), IconUnicodeGlyph(0xf57a)]
        RegularFrownOpen = 593,
        ///<summary>Regular Futbol</summary>
        ///<see href="https://fontawesome.com/icons/futbol?style=regular"/>
        [Description("Regular Futbol"), IconID("far-futbol"), IconUnicodeGlyph(0xf1e3)]
        RegularFutbol = 594,
        ///<summary>Regular Kiss Wink Heart</summary>
        ///<see href="https://fontawesome.com/icons/kiss-wink-heart?style=regular"/>
        [Description("Regular Kiss Wink Heart"), IconID("far-kiss-wink-heart"), IconUnicodeGlyph(0xf598)]
        RegularKissWinkHeart = 595,
        ///<summary>Regular Flag</summary>
        ///<see href="https://fontawesome.com/icons/flag?style=regular"/>
        [Description("Regular Flag"), IconID("far-flag"), IconUnicodeGlyph(0xf024)]
        RegularFlag = 596,
        ///<summary>Regular Lightbulb</summary>
        ///<see href="https://fontawesome.com/icons/lightbulb?style=regular"/>
        [Description("Regular Lightbulb"), IconID("far-lightbulb"), IconUnicodeGlyph(0xf0eb)]
        RegularLightbulb = 597,
        ///<summary>Regular Grin Tears</summary>
        ///<see href="https://fontawesome.com/icons/grin-tears?style=regular"/>
        [Description("Regular Grin Tears"), IconID("far-grin-tears"), IconUnicodeGlyph(0xf588)]
        RegularGrinTears = 598,
        ///<summary>Regular Compass</summary>
        ///<see href="https://fontawesome.com/icons/compass?style=regular"/>
        [Description("Regular Compass"), IconID("far-compass"), IconUnicodeGlyph(0xf14e)]
        RegularCompass = 599,
        ///<summary>Regular Sad Cry</summary>
        ///<see href="https://fontawesome.com/icons/sad-cry?style=regular"/>
        [Description("Regular Sad Cry"), IconID("far-sad-cry"), IconUnicodeGlyph(0xf5b3)]
        RegularSadCry = 600,
        ///<summary>Regular Dot Circle</summary>
        ///<see href="https://fontawesome.com/icons/dot-circle?style=regular"/>
        [Description("Regular Dot Circle"), IconID("far-dot-circle"), IconUnicodeGlyph(0xf192)]
        RegularDotCircle = 601,
        ///<summary>Regular Grin Beam</summary>
        ///<see href="https://fontawesome.com/icons/grin-beam?style=regular"/>
        [Description("Regular Grin Beam"), IconID("far-grin-beam"), IconUnicodeGlyph(0xf582)]
        RegularGrinBeam = 602,
        ///<summary>Regular User Circle</summary>
        ///<see href="https://fontawesome.com/icons/user-circle?style=regular"/>
        [Description("Regular User Circle"), IconID("far-user-circle"), IconUnicodeGlyph(0xf2bd)]
        RegularUserCircle = 603,
        ///<summary>Regular Comments</summary>
        ///<see href="https://fontawesome.com/icons/comments?style=regular"/>
        [Description("Regular Comments"), IconID("far-comments"), IconUnicodeGlyph(0xf086)]
        RegularComments = 604,
        ///<summary>Regular Address Book</summary>
        ///<see href="https://fontawesome.com/icons/address-book?style=regular"/>
        [Description("Regular Address Book"), IconID("far-address-book"), IconUnicodeGlyph(0xf2b9)]
        RegularAddressBook = 605,
        ///<summary>Regular Times Circle</summary>
        ///<see href="https://fontawesome.com/icons/times-circle?style=regular"/>
        [Description("Regular Times Circle"), IconID("far-times-circle"), IconUnicodeGlyph(0xf057)]
        RegularTimesCircle = 606,
        ///<summary>Regular Hand Point Right</summary>
        ///<see href="https://fontawesome.com/icons/hand-point-right?style=regular"/>
        [Description("Regular Hand Point Right"), IconID("far-hand-point-right"), IconUnicodeGlyph(0xf0a4)]
        RegularHandPointRight = 607,
        ///<summary>Regular Grin Hearts</summary>
        ///<see href="https://fontawesome.com/icons/grin-hearts?style=regular"/>
        [Description("Regular Grin Hearts"), IconID("far-grin-hearts"), IconUnicodeGlyph(0xf584)]
        RegularGrinHearts = 608,
        ///<summary>Solid Theater Masks</summary>
        ///<see href="https://fontawesome.com/icons/theater-masks?style=solid"/>
        [Description("Solid Theater Masks"), IconID("fas-theater-masks"), IconUnicodeGlyph(0xf630)]
        SolidTheaterMasks = 609,
        ///<summary>Solid Hand Holding Medical</summary>
        ///<see href="https://fontawesome.com/icons/hand-holding-medical?style=solid"/>
        [Description("Solid Hand Holding Medical"), IconID("fas-hand-holding-medical"), IconUnicodeGlyph(0xe05c)]
        SolidHandHoldingMedical = 610,
        ///<summary>Solid Graduation Cap</summary>
        ///<see href="https://fontawesome.com/icons/graduation-cap?style=solid"/>
        [Description("Solid Graduation Cap"), IconID("fas-graduation-cap"), IconUnicodeGlyph(0xf19d)]
        SolidGraduationCap = 611,
        ///<summary>Solid Video</summary>
        ///<see href="https://fontawesome.com/icons/video?style=solid"/>
        [Description("Solid Video"), IconID("fas-video"), IconUnicodeGlyph(0xf03d)]
        SolidVideo = 612,
        ///<summary>Solid Barcode</summary>
        ///<see href="https://fontawesome.com/icons/barcode?style=solid"/>
        [Description("Solid Barcode"), IconID("fas-barcode"), IconUnicodeGlyph(0xf02a)]
        SolidBarcode = 613,
        ///<summary>Solid Dizzy</summary>
        ///<see href="https://fontawesome.com/icons/dizzy?style=solid"/>
        [Description("Solid Dizzy"), IconID("fas-dizzy"), IconUnicodeGlyph(0xf567)]
        SolidDizzy = 614,
        ///<summary>Solid Hand Point Left</summary>
        ///<see href="https://fontawesome.com/icons/hand-point-left?style=solid"/>
        [Description("Solid Hand Point Left"), IconID("fas-hand-point-left"), IconUnicodeGlyph(0xf0a5)]
        SolidHandPointLeft = 615,
        ///<summary>Solid Arrow Circle Up</summary>
        ///<see href="https://fontawesome.com/icons/arrow-circle-up?style=solid"/>
        [Description("Solid Arrow Circle Up"), IconID("fas-arrow-circle-up"), IconUnicodeGlyph(0xf0aa)]
        SolidArrowCircleUp = 616,
        ///<summary>Solid Walking</summary>
        ///<see href="https://fontawesome.com/icons/walking?style=solid"/>
        [Description("Solid Walking"), IconID("fas-walking"), IconUnicodeGlyph(0xf554)]
        SolidWalking = 617,
        ///<summary>Solid Umbrella</summary>
        ///<see href="https://fontawesome.com/icons/umbrella?style=solid"/>
        [Description("Solid Umbrella"), IconID("fas-umbrella"), IconUnicodeGlyph(0xf0e9)]
        SolidUmbrella = 618,
        ///<summary>Solid Drafting Compass</summary>
        ///<see href="https://fontawesome.com/icons/drafting-compass?style=solid"/>
        [Description("Solid Drafting Compass"), IconID("fas-drafting-compass"), IconUnicodeGlyph(0xf568)]
        SolidDraftingCompass = 619,
        ///<summary>Solid Dollar Sign</summary>
        ///<see href="https://fontawesome.com/icons/dollar-sign?style=solid"/>
        [Description("Solid Dollar Sign"), IconID("fas-dollar-sign"), IconUnicodeGlyph(0xf155)]
        SolidDollarSign = 620,
        ///<summary>Solid Print</summary>
        ///<see href="https://fontawesome.com/icons/print?style=solid"/>
        [Description("Solid Print"), IconID("fas-print"), IconUnicodeGlyph(0xf02f)]
        SolidPrint = 621,
        ///<summary>Solid Search Location</summary>
        ///<see href="https://fontawesome.com/icons/search-location?style=solid"/>
        [Description("Solid Search Location"), IconID("fas-search-location"), IconUnicodeGlyph(0xf689)]
        SolidSearchLocation = 622,
        ///<summary>Solid Exclamation</summary>
        ///<see href="https://fontawesome.com/icons/exclamation?style=solid"/>
        [Description("Solid Exclamation"), IconID("fas-exclamation"), IconUnicodeGlyph(0xf12a)]
        SolidExclamation = 623,
        ///<summary>Solid Basketball Ball</summary>
        ///<see href="https://fontawesome.com/icons/basketball-ball?style=solid"/>
        [Description("Solid Basketball Ball"), IconID("fas-basketball-ball"), IconUnicodeGlyph(0xf434)]
        SolidBasketballBall = 624,
        ///<summary>Solid Swimmer</summary>
        ///<see href="https://fontawesome.com/icons/swimmer?style=solid"/>
        [Description("Solid Swimmer"), IconID("fas-swimmer"), IconUnicodeGlyph(0xf5c4)]
        SolidSwimmer = 625,
        ///<summary>Solid Angle Double Right</summary>
        ///<see href="https://fontawesome.com/icons/angle-double-right?style=solid"/>
        [Description("Solid Angle Double Right"), IconID("fas-angle-double-right"), IconUnicodeGlyph(0xf101)]
        SolidAngleDoubleRight = 626,
        ///<summary>Solid Plane</summary>
        ///<see href="https://fontawesome.com/icons/plane?style=solid"/>
        [Description("Solid Plane"), IconID("fas-plane"), IconUnicodeGlyph(0xf072)]
        SolidPlane = 627,
        ///<summary>Solid User Injured</summary>
        ///<see href="https://fontawesome.com/icons/user-injured?style=solid"/>
        [Description("Solid User Injured"), IconID("fas-user-injured"), IconUnicodeGlyph(0xf728)]
        SolidUserInjured = 628,
        ///<summary>Solid Search Minus</summary>
        ///<see href="https://fontawesome.com/icons/search-minus?style=solid"/>
        [Description("Solid Search Minus"), IconID("fas-search-minus"), IconUnicodeGlyph(0xf010)]
        SolidSearchMinus = 629,
        ///<summary>Solid Bone</summary>
        ///<see href="https://fontawesome.com/icons/bone?style=solid"/>
        [Description("Solid Bone"), IconID("fas-bone"), IconUnicodeGlyph(0xf5d7)]
        SolidBone = 630,
        ///<summary>Solid Search Plus</summary>
        ///<see href="https://fontawesome.com/icons/search-plus?style=solid"/>
        [Description("Solid Search Plus"), IconID("fas-search-plus"), IconUnicodeGlyph(0xf00e)]
        SolidSearchPlus = 631,
        ///<summary>Solid Tshirt</summary>
        ///<see href="https://fontawesome.com/icons/tshirt?style=solid"/>
        [Description("Solid Tshirt"), IconID("fas-tshirt"), IconUnicodeGlyph(0xf553)]
        SolidTshirt = 632,
        ///<summary>Solid Mouse</summary>
        ///<see href="https://fontawesome.com/icons/mouse?style=solid"/>
        [Description("Solid Mouse"), IconID("fas-mouse"), IconUnicodeGlyph(0xf8cc)]
        SolidMouse = 633,
        ///<summary>Solid Magnet</summary>
        ///<see href="https://fontawesome.com/icons/magnet?style=solid"/>
        [Description("Solid Magnet"), IconID("fas-magnet"), IconUnicodeGlyph(0xf076)]
        SolidMagnet = 634,
        ///<summary>Solid Square Full</summary>
        ///<see href="https://fontawesome.com/icons/square-full?style=solid"/>
        [Description("Solid Square Full"), IconID("fas-square-full"), IconUnicodeGlyph(0xf45c)]
        SolidSquareFull = 635,
        ///<summary>Solid Stopwatch 20</summary>
        ///<see href="https://fontawesome.com/icons/stopwatch-20?style=solid"/>
        [Description("Solid Stopwatch 20"), IconID("fas-stopwatch-20"), IconUnicodeGlyph(0xe06f)]
        SolidStopwatch20 = 636,
        ///<summary>Solid Cloud Sun</summary>
        ///<see href="https://fontawesome.com/icons/cloud-sun?style=solid"/>
        [Description("Solid Cloud Sun"), IconID("fas-cloud-sun"), IconUnicodeGlyph(0xf6c4)]
        SolidCloudSun = 637,
        ///<summary>Solid Syringe</summary>
        ///<see href="https://fontawesome.com/icons/syringe?style=solid"/>
        [Description("Solid Syringe"), IconID("fas-syringe"), IconUnicodeGlyph(0xf48e)]
        SolidSyringe = 638,
        ///<summary>Solid User Nurse</summary>
        ///<see href="https://fontawesome.com/icons/user-nurse?style=solid"/>
        [Description("Solid User Nurse"), IconID("fas-user-nurse"), IconUnicodeGlyph(0xf82f)]
        SolidUserNurse = 639,
        ///<summary>Solid Ruler Vertical</summary>
        ///<see href="https://fontawesome.com/icons/ruler-vertical?style=solid"/>
        [Description("Solid Ruler Vertical"), IconID("fas-ruler-vertical"), IconUnicodeGlyph(0xf548)]
        SolidRulerVertical = 640,
        ///<summary>Solid Mask</summary>
        ///<see href="https://fontawesome.com/icons/mask?style=solid"/>
        [Description("Solid Mask"), IconID("fas-mask"), IconUnicodeGlyph(0xf6fa)]
        SolidMask = 641,
        ///<summary>Solid Birthday Cake</summary>
        ///<see href="https://fontawesome.com/icons/birthday-cake?style=solid"/>
        [Description("Solid Birthday Cake"), IconID("fas-birthday-cake"), IconUnicodeGlyph(0xf1fd)]
        SolidBirthdayCake = 642,
        ///<summary>Solid Brush</summary>
        ///<see href="https://fontawesome.com/icons/brush?style=solid"/>
        [Description("Solid Brush"), IconID("fas-brush"), IconUnicodeGlyph(0xf55d)]
        SolidBrush = 643,
        ///<summary>Solid Window Minimize</summary>
        ///<see href="https://fontawesome.com/icons/window-minimize?style=solid"/>
        [Description("Solid Window Minimize"), IconID("fas-window-minimize"), IconUnicodeGlyph(0xf2d1)]
        SolidWindowMinimize = 644,
        ///<summary>Solid File Invoice</summary>
        ///<see href="https://fontawesome.com/icons/file-invoice?style=solid"/>
        [Description("Solid File Invoice"), IconID("fas-file-invoice"), IconUnicodeGlyph(0xf570)]
        SolidFileInvoice = 645,
        ///<summary>Solid User Clock</summary>
        ///<see href="https://fontawesome.com/icons/user-clock?style=solid"/>
        [Description("Solid User Clock"), IconID("fas-user-clock"), IconUnicodeGlyph(0xf4fd)]
        SolidUserClock = 646,
        ///<summary>Solid Thumbs Up</summary>
        ///<see href="https://fontawesome.com/icons/thumbs-up?style=solid"/>
        [Description("Solid Thumbs Up"), IconID("fas-thumbs-up"), IconUnicodeGlyph(0xf164)]
        SolidThumbsUp = 647,
        ///<summary>Solid Hotel</summary>
        ///<see href="https://fontawesome.com/icons/hotel?style=solid"/>
        [Description("Solid Hotel"), IconID("fas-hotel"), IconUnicodeGlyph(0xf594)]
        SolidHotel = 648,
        ///<summary>Solid Gifts</summary>
        ///<see href="https://fontawesome.com/icons/gifts?style=solid"/>
        [Description("Solid Gifts"), IconID("fas-gifts"), IconUnicodeGlyph(0xf79c)]
        SolidGifts = 649,
        ///<summary>Solid Calendar Minus</summary>
        ///<see href="https://fontawesome.com/icons/calendar-minus?style=solid"/>
        [Description("Solid Calendar Minus"), IconID("fas-calendar-minus"), IconUnicodeGlyph(0xf272)]
        SolidCalendarMinus = 650,
        ///<summary>Solid Brain</summary>
        ///<see href="https://fontawesome.com/icons/brain?style=solid"/>
        [Description("Solid Brain"), IconID("fas-brain"), IconUnicodeGlyph(0xf5dc)]
        SolidBrain = 651,
        ///<summary>Solid Bowling Ball</summary>
        ///<see href="https://fontawesome.com/icons/bowling-ball?style=solid"/>
        [Description("Solid Bowling Ball"), IconID("fas-bowling-ball"), IconUnicodeGlyph(0xf436)]
        SolidBowlingBall = 652,
        ///<summary>Solid Dice</summary>
        ///<see href="https://fontawesome.com/icons/dice?style=solid"/>
        [Description("Solid Dice"), IconID("fas-dice"), IconUnicodeGlyph(0xf522)]
        SolidDice = 653,
        ///<summary>Solid Remove Format</summary>
        ///<see href="https://fontawesome.com/icons/remove-format?style=solid"/>
        [Description("Solid Remove Format"), IconID("fas-remove-format"), IconUnicodeGlyph(0xf87d)]
        SolidRemoveFormat = 654,
        ///<summary>Solid Calendar Day</summary>
        ///<see href="https://fontawesome.com/icons/calendar-day?style=solid"/>
        [Description("Solid Calendar Day"), IconID("fas-calendar-day"), IconUnicodeGlyph(0xf783)]
        SolidCalendarDay = 655,
        ///<summary>Solid User Alt Slash</summary>
        ///<see href="https://fontawesome.com/icons/user-alt-slash?style=solid"/>
        [Description("Solid User Alt Slash"), IconID("fas-user-alt-slash"), IconUnicodeGlyph(0xf4fa)]
        SolidUserAltSlash = 656,
        ///<summary>Solid Hands</summary>
        ///<see href="https://fontawesome.com/icons/hands?style=solid"/>
        [Description("Solid Hands"), IconID("fas-hands"), IconUnicodeGlyph(0xf4c2)]
        SolidHands = 657,
        ///<summary>Solid Quidditch</summary>
        ///<see href="https://fontawesome.com/icons/quidditch?style=solid"/>
        [Description("Solid Quidditch"), IconID("fas-quidditch"), IconUnicodeGlyph(0xf458)]
        SolidQuidditch = 658,
        ///<summary>Solid Life Ring</summary>
        ///<see href="https://fontawesome.com/icons/life-ring?style=solid"/>
        [Description("Solid Life Ring"), IconID("fas-life-ring"), IconUnicodeGlyph(0xf1cd)]
        SolidLifeRing = 659,
        ///<summary>Solid Align Right</summary>
        ///<see href="https://fontawesome.com/icons/align-right?style=solid"/>
        [Description("Solid Align Right"), IconID("fas-align-right"), IconUnicodeGlyph(0xf038)]
        SolidAlignRight = 660,
        ///<summary>Solid Prescription Bottle Alt</summary>
        ///<see href="https://fontawesome.com/icons/prescription-bottle-alt?style=solid"/>
        [Description("Solid Prescription Bottle Alt"), IconID("fas-prescription-bottle-alt"), IconUnicodeGlyph(0xf486)]
        SolidPrescriptionBottleAlt = 661,
        ///<summary>Solid Tablet Alt</summary>
        ///<see href="https://fontawesome.com/icons/tablet-alt?style=solid"/>
        [Description("Solid Tablet Alt"), IconID("fas-tablet-alt"), IconUnicodeGlyph(0xf3fa)]
        SolidTabletAlt = 662,
        ///<summary>Solid Dungeon</summary>
        ///<see href="https://fontawesome.com/icons/dungeon?style=solid"/>
        [Description("Solid Dungeon"), IconID("fas-dungeon"), IconUnicodeGlyph(0xf6d9)]
        SolidDungeon = 663,
        ///<summary>Solid Paper Plane</summary>
        ///<see href="https://fontawesome.com/icons/paper-plane?style=solid"/>
        [Description("Solid Paper Plane"), IconID("fas-paper-plane"), IconUnicodeGlyph(0xf1d8)]
        SolidPaperPlane = 664,
        ///<summary>Solid Sort Amount Down Alt</summary>
        ///<see href="https://fontawesome.com/icons/sort-amount-down-alt?style=solid"/>
        [Description("Solid Sort Amount Down Alt"), IconID("fas-sort-amount-down-alt"), IconUnicodeGlyph(0xf884)]
        SolidSortAmountDownAlt = 665,
        ///<summary>Solid Share</summary>
        ///<see href="https://fontawesome.com/icons/share?style=solid"/>
        [Description("Solid Share"), IconID("fas-share"), IconUnicodeGlyph(0xf064)]
        SolidShare = 666,
        ///<summary>Solid Database</summary>
        ///<see href="https://fontawesome.com/icons/database?style=solid"/>
        [Description("Solid Database"), IconID("fas-database"), IconUnicodeGlyph(0xf1c0)]
        SolidDatabase = 667,
        ///<summary>Solid Book Open</summary>
        ///<see href="https://fontawesome.com/icons/book-open?style=solid"/>
        [Description("Solid Book Open"), IconID("fas-book-open"), IconUnicodeGlyph(0xf518)]
        SolidBookOpen = 668,
        ///<summary>Solid Store Alt Slash</summary>
        ///<see href="https://fontawesome.com/icons/store-alt-slash?style=solid"/>
        [Description("Solid Store Alt Slash"), IconID("fas-store-alt-slash"), IconUnicodeGlyph(0xe070)]
        SolidStoreAltSlash = 669,
        ///<summary>Solid User Tag</summary>
        ///<see href="https://fontawesome.com/icons/user-tag?style=solid"/>
        [Description("Solid User Tag"), IconID("fas-user-tag"), IconUnicodeGlyph(0xf507)]
        SolidUserTag = 670,
        ///<summary>Solid Briefcase</summary>
        ///<see href="https://fontawesome.com/icons/briefcase?style=solid"/>
        [Description("Solid Briefcase"), IconID("fas-briefcase"), IconUnicodeGlyph(0xf0b1)]
        SolidBriefcase = 671,
        ///<summary>Solid Cloud Moon</summary>
        ///<see href="https://fontawesome.com/icons/cloud-moon?style=solid"/>
        [Description("Solid Cloud Moon"), IconID("fas-cloud-moon"), IconUnicodeGlyph(0xf6c3)]
        SolidCloudMoon = 672,
        ///<summary>Solid Map Marked Alt</summary>
        ///<see href="https://fontawesome.com/icons/map-marked-alt?style=solid"/>
        [Description("Solid Map Marked Alt"), IconID("fas-map-marked-alt"), IconUnicodeGlyph(0xf5a0)]
        SolidMapMarkedAlt = 673,
        ///<summary>Solid Hand Holding Usd</summary>
        ///<see href="https://fontawesome.com/icons/hand-holding-usd?style=solid"/>
        [Description("Solid Hand Holding Usd"), IconID("fas-hand-holding-usd"), IconUnicodeGlyph(0xf4c0)]
        SolidHandHoldingUsd = 674,
        ///<summary>Solid Angle Left</summary>
        ///<see href="https://fontawesome.com/icons/angle-left?style=solid"/>
        [Description("Solid Angle Left"), IconID("fas-angle-left"), IconUnicodeGlyph(0xf104)]
        SolidAngleLeft = 675,
        ///<summary>Solid Battery Three Quarters</summary>
        ///<see href="https://fontawesome.com/icons/battery-three-quarters?style=solid"/>
        [Description("Solid Battery Three Quarters"), IconID("fas-battery-three-quarters"), IconUnicodeGlyph(0xf241)]
        SolidBatteryThreeQuarters = 676,
        ///<summary>Solid Frown</summary>
        ///<see href="https://fontawesome.com/icons/frown?style=solid"/>
        [Description("Solid Frown"), IconID("fas-frown"), IconUnicodeGlyph(0xf119)]
        SolidFrown = 677,
        ///<summary>Solid Check</summary>
        ///<see href="https://fontawesome.com/icons/check?style=solid"/>
        [Description("Solid Check"), IconID("fas-check"), IconUnicodeGlyph(0xf00c)]
        SolidCheck = 678,
        ///<summary>Solid Grimace</summary>
        ///<see href="https://fontawesome.com/icons/grimace?style=solid"/>
        [Description("Solid Grimace"), IconID("fas-grimace"), IconUnicodeGlyph(0xf57f)]
        SolidGrimace = 679,
        ///<summary>Solid User Plus</summary>
        ///<see href="https://fontawesome.com/icons/user-plus?style=solid"/>
        [Description("Solid User Plus"), IconID("fas-user-plus"), IconUnicodeGlyph(0xf234)]
        SolidUserPlus = 680,
        ///<summary>Solid Book</summary>
        ///<see href="https://fontawesome.com/icons/book?style=solid"/>
        [Description("Solid Book"), IconID("fas-book"), IconUnicodeGlyph(0xf02d)]
        SolidBook = 681,
        ///<summary>Solid Desktop</summary>
        ///<see href="https://fontawesome.com/icons/desktop?style=solid"/>
        [Description("Solid Desktop"), IconID("fas-desktop"), IconUnicodeGlyph(0xf108)]
        SolidDesktop = 682,
        ///<summary>Solid Tram</summary>
        ///<see href="https://fontawesome.com/icons/tram?style=solid"/>
        [Description("Solid Tram"), IconID("fas-tram"), IconUnicodeGlyph(0xf7da)]
        SolidTram = 683,
        ///<summary>Solid Shower</summary>
        ///<see href="https://fontawesome.com/icons/shower?style=solid"/>
        [Description("Solid Shower"), IconID("fas-shower"), IconUnicodeGlyph(0xf2cc)]
        SolidShower = 684,
        ///<summary>Solid Hands Wash</summary>
        ///<see href="https://fontawesome.com/icons/hands-wash?style=solid"/>
        [Description("Solid Hands Wash"), IconID("fas-hands-wash"), IconUnicodeGlyph(0xe05e)]
        SolidHandsWash = 685,
        ///<summary>Solid Draw Polygon</summary>
        ///<see href="https://fontawesome.com/icons/draw-polygon?style=solid"/>
        [Description("Solid Draw Polygon"), IconID("fas-draw-polygon"), IconUnicodeGlyph(0xf5ee)]
        SolidDrawPolygon = 686,
        ///<summary>Solid Rss</summary>
        ///<see href="https://fontawesome.com/icons/rss?style=solid"/>
        [Description("Solid Rss"), IconID("fas-rss"), IconUnicodeGlyph(0xf09e)]
        SolidRss = 687,
        ///<summary>Solid Cookie Bite</summary>
        ///<see href="https://fontawesome.com/icons/cookie-bite?style=solid"/>
        [Description("Solid Cookie Bite"), IconID("fas-cookie-bite"), IconUnicodeGlyph(0xf564)]
        SolidCookieBite = 688,
        ///<summary>Solid Map Marker Alt</summary>
        ///<see href="https://fontawesome.com/icons/map-marker-alt?style=solid"/>
        [Description("Solid Map Marker Alt"), IconID("fas-map-marker-alt"), IconUnicodeGlyph(0xf3c5)]
        SolidMapMarkerAlt = 689,
        ///<summary>Solid Border All</summary>
        ///<see href="https://fontawesome.com/icons/border-all?style=solid"/>
        [Description("Solid Border All"), IconID("fas-border-all"), IconUnicodeGlyph(0xf84c)]
        SolidBorderAll = 690,
        ///<summary>Solid Anchor</summary>
        ///<see href="https://fontawesome.com/icons/anchor?style=solid"/>
        [Description("Solid Anchor"), IconID("fas-anchor"), IconUnicodeGlyph(0xf13d)]
        SolidAnchor = 691,
        ///<summary>Solid Grin Tongue Squint</summary>
        ///<see href="https://fontawesome.com/icons/grin-tongue-squint?style=solid"/>
        [Description("Solid Grin Tongue Squint"), IconID("fas-grin-tongue-squint"), IconUnicodeGlyph(0xf58a)]
        SolidGrinTongueSquint = 692,
        ///<summary>Solid Clone</summary>
        ///<see href="https://fontawesome.com/icons/clone?style=solid"/>
        [Description("Solid Clone"), IconID("fas-clone"), IconUnicodeGlyph(0xf24d)]
        SolidClone = 693,
        ///<summary>Solid Hand Holding</summary>
        ///<see href="https://fontawesome.com/icons/hand-holding?style=solid"/>
        [Description("Solid Hand Holding"), IconID("fas-hand-holding"), IconUnicodeGlyph(0xf4bd)]
        SolidHandHolding = 694,
        ///<summary>Solid Shoe Prints</summary>
        ///<see href="https://fontawesome.com/icons/shoe-prints?style=solid"/>
        [Description("Solid Shoe Prints"), IconID("fas-shoe-prints"), IconUnicodeGlyph(0xf54b)]
        SolidShoePrints = 695,
        ///<summary>Solid Dragon</summary>
        ///<see href="https://fontawesome.com/icons/dragon?style=solid"/>
        [Description("Solid Dragon"), IconID("fas-dragon"), IconUnicodeGlyph(0xf6d5)]
        SolidDragon = 696,
        ///<summary>Solid Sd Card</summary>
        ///<see href="https://fontawesome.com/icons/sd-card?style=solid"/>
        [Description("Solid Sd Card"), IconID("fas-sd-card"), IconUnicodeGlyph(0xf7c2)]
        SolidSdCard = 697,
        ///<summary>Solid Bahai</summary>
        ///<see href="https://fontawesome.com/icons/bahai?style=solid"/>
        [Description("Solid Bahai"), IconID("fas-bahai"), IconUnicodeGlyph(0xf666)]
        SolidBahai = 698,
        ///<summary>Solid Trailer</summary>
        ///<see href="https://fontawesome.com/icons/trailer?style=solid"/>
        [Description("Solid Trailer"), IconID("fas-trailer"), IconUnicodeGlyph(0xe041)]
        SolidTrailer = 699,
        ///<summary>Solid Calendar</summary>
        ///<see href="https://fontawesome.com/icons/calendar?style=solid"/>
        [Description("Solid Calendar"), IconID("fas-calendar"), IconUnicodeGlyph(0xf133)]
        SolidCalendar = 700,
        ///<summary>Solid Cloud Moon Rain</summary>
        ///<see href="https://fontawesome.com/icons/cloud-moon-rain?style=solid"/>
        [Description("Solid Cloud Moon Rain"), IconID("fas-cloud-moon-rain"), IconUnicodeGlyph(0xf73c)]
        SolidCloudMoonRain = 701,
        ///<summary>Solid Calendar Alt</summary>
        ///<see href="https://fontawesome.com/icons/calendar-alt?style=solid"/>
        [Description("Solid Calendar Alt"), IconID("fas-calendar-alt"), IconUnicodeGlyph(0xf073)]
        SolidCalendarAlt = 702,
        ///<summary>Solid Fan</summary>
        ///<see href="https://fontawesome.com/icons/fan?style=solid"/>
        [Description("Solid Fan"), IconID("fas-fan"), IconUnicodeGlyph(0xf863)]
        SolidFan = 703,
        ///<summary>Solid Balance Scale Right</summary>
        ///<see href="https://fontawesome.com/icons/balance-scale-right?style=solid"/>
        [Description("Solid Balance Scale Right"), IconID("fas-balance-scale-right"), IconUnicodeGlyph(0xf516)]
        SolidBalanceScaleRight = 704,
        ///<summary>Solid Voicemail</summary>
        ///<see href="https://fontawesome.com/icons/voicemail?style=solid"/>
        [Description("Solid Voicemail"), IconID("fas-voicemail"), IconUnicodeGlyph(0xf897)]
        SolidVoicemail = 705,
        ///<summary>Solid Infinity</summary>
        ///<see href="https://fontawesome.com/icons/infinity?style=solid"/>
        [Description("Solid Infinity"), IconID("fas-infinity"), IconUnicodeGlyph(0xf534)]
        SolidInfinity = 706,
        ///<summary>Solid Hippo</summary>
        ///<see href="https://fontawesome.com/icons/hippo?style=solid"/>
        [Description("Solid Hippo"), IconID("fas-hippo"), IconUnicodeGlyph(0xf6ed)]
        SolidHippo = 707,
        ///<summary>Solid Oil Can</summary>
        ///<see href="https://fontawesome.com/icons/oil-can?style=solid"/>
        [Description("Solid Oil Can"), IconID("fas-oil-can"), IconUnicodeGlyph(0xf613)]
        SolidOilCan = 708,
        ///<summary>Solid Hashtag</summary>
        ///<see href="https://fontawesome.com/icons/hashtag?style=solid"/>
        [Description("Solid Hashtag"), IconID("fas-hashtag"), IconUnicodeGlyph(0xf292)]
        SolidHashtag = 709,
        ///<summary>Solid Gopuram</summary>
        ///<see href="https://fontawesome.com/icons/gopuram?style=solid"/>
        [Description("Solid Gopuram"), IconID("fas-gopuram"), IconUnicodeGlyph(0xf664)]
        SolidGopuram = 710,
        ///<summary>Solid Trash Restore Alt</summary>
        ///<see href="https://fontawesome.com/icons/trash-restore-alt?style=solid"/>
        [Description("Solid Trash Restore Alt"), IconID("fas-trash-restore-alt"), IconUnicodeGlyph(0xf82a)]
        SolidTrashRestoreAlt = 711,
        ///<summary>Solid Broom</summary>
        ///<see href="https://fontawesome.com/icons/broom?style=solid"/>
        [Description("Solid Broom"), IconID("fas-broom"), IconUnicodeGlyph(0xf51a)]
        SolidBroom = 712,
        ///<summary>Solid Crop Alt</summary>
        ///<see href="https://fontawesome.com/icons/crop-alt?style=solid"/>
        [Description("Solid Crop Alt"), IconID("fas-crop-alt"), IconUnicodeGlyph(0xf565)]
        SolidCropAlt = 713,
        ///<summary>Solid Temperature Low</summary>
        ///<see href="https://fontawesome.com/icons/temperature-low?style=solid"/>
        [Description("Solid Temperature Low"), IconID("fas-temperature-low"), IconUnicodeGlyph(0xf76b)]
        SolidTemperatureLow = 714,
        ///<summary>Solid Handshake Alt Slash</summary>
        ///<see href="https://fontawesome.com/icons/handshake-alt-slash?style=solid"/>
        [Description("Solid Handshake Alt Slash"), IconID("fas-handshake-alt-slash"), IconUnicodeGlyph(0xe05f)]
        SolidHandshakeAltSlash = 715,
        ///<summary>Solid Music</summary>
        ///<see href="https://fontawesome.com/icons/music?style=solid"/>
        [Description("Solid Music"), IconID("fas-music"), IconUnicodeGlyph(0xf001)]
        SolidMusic = 716,
        ///<summary>Solid Yin Yang</summary>
        ///<see href="https://fontawesome.com/icons/yin-yang?style=solid"/>
        [Description("Solid Yin Yang"), IconID("fas-yin-yang"), IconUnicodeGlyph(0xf6ad)]
        SolidYinYang = 717,
        ///<summary>Solid Cheese</summary>
        ///<see href="https://fontawesome.com/icons/cheese?style=solid"/>
        [Description("Solid Cheese"), IconID("fas-cheese"), IconUnicodeGlyph(0xf7ef)]
        SolidCheese = 718,
        ///<summary>Solid Moon</summary>
        ///<see href="https://fontawesome.com/icons/moon?style=solid"/>
        [Description("Solid Moon"), IconID("fas-moon"), IconUnicodeGlyph(0xf186)]
        SolidMoon = 719,
        ///<summary>Solid Carrot</summary>
        ///<see href="https://fontawesome.com/icons/carrot?style=solid"/>
        [Description("Solid Carrot"), IconID("fas-carrot"), IconUnicodeGlyph(0xf787)]
        SolidCarrot = 720,
        ///<summary>Solid Hard Hat</summary>
        ///<see href="https://fontawesome.com/icons/hard-hat?style=solid"/>
        [Description("Solid Hard Hat"), IconID("fas-hard-hat"), IconUnicodeGlyph(0xf807)]
        SolidHardHat = 721,
        ///<summary>Solid Dog</summary>
        ///<see href="https://fontawesome.com/icons/dog?style=solid"/>
        [Description("Solid Dog"), IconID("fas-dog"), IconUnicodeGlyph(0xf6d3)]
        SolidDog = 722,
        ///<summary>Solid Pen Nib</summary>
        ///<see href="https://fontawesome.com/icons/pen-nib?style=solid"/>
        [Description("Solid Pen Nib"), IconID("fas-pen-nib"), IconUnicodeGlyph(0xf5ad)]
        SolidPenNib = 723,
        ///<summary>Solid Redo</summary>
        ///<see href="https://fontawesome.com/icons/redo?style=solid"/>
        [Description("Solid Redo"), IconID("fas-redo"), IconUnicodeGlyph(0xf01e)]
        SolidRedo = 724,
        ///<summary>Solid Poll</summary>
        ///<see href="https://fontawesome.com/icons/poll?style=solid"/>
        [Description("Solid Poll"), IconID("fas-poll"), IconUnicodeGlyph(0xf681)]
        SolidPoll = 725,
        ///<summary>Solid Diagnoses</summary>
        ///<see href="https://fontawesome.com/icons/diagnoses?style=solid"/>
        [Description("Solid Diagnoses"), IconID("fas-diagnoses"), IconUnicodeGlyph(0xf470)]
        SolidDiagnoses = 726,
        ///<summary>Solid File Export</summary>
        ///<see href="https://fontawesome.com/icons/file-export?style=solid"/>
        [Description("Solid File Export"), IconID("fas-file-export"), IconUnicodeGlyph(0xf56e)]
        SolidFileExport = 727,
        ///<summary>Solid Kiss</summary>
        ///<see href="https://fontawesome.com/icons/kiss?style=solid"/>
        [Description("Solid Kiss"), IconID("fas-kiss"), IconUnicodeGlyph(0xf596)]
        SolidKiss = 728,
        ///<summary>Solid Wine Glass Alt</summary>
        ///<see href="https://fontawesome.com/icons/wine-glass-alt?style=solid"/>
        [Description("Solid Wine Glass Alt"), IconID("fas-wine-glass-alt"), IconUnicodeGlyph(0xf5ce)]
        SolidWineGlassAlt = 729,
        ///<summary>Solid Qrcode</summary>
        ///<see href="https://fontawesome.com/icons/qrcode?style=solid"/>
        [Description("Solid Qrcode"), IconID("fas-qrcode"), IconUnicodeGlyph(0xf029)]
        SolidQrcode = 730,
        ///<summary>Solid Building</summary>
        ///<see href="https://fontawesome.com/icons/building?style=solid"/>
        [Description("Solid Building"), IconID("fas-building"), IconUnicodeGlyph(0xf1ad)]
        SolidBuilding = 731,
        ///<summary>Solid Award</summary>
        ///<see href="https://fontawesome.com/icons/award?style=solid"/>
        [Description("Solid Award"), IconID("fas-award"), IconUnicodeGlyph(0xf559)]
        SolidAward = 732,
        ///<summary>Solid Sync</summary>
        ///<see href="https://fontawesome.com/icons/sync?style=solid"/>
        [Description("Solid Sync"), IconID("fas-sync"), IconUnicodeGlyph(0xf021)]
        SolidSync = 733,
        ///<summary>Solid Mercury</summary>
        ///<see href="https://fontawesome.com/icons/mercury?style=solid"/>
        [Description("Solid Mercury"), IconID("fas-mercury"), IconUnicodeGlyph(0xf223)]
        SolidMercury = 734,
        ///<summary>Solid Transgender</summary>
        ///<see href="https://fontawesome.com/icons/transgender?style=solid"/>
        [Description("Solid Transgender"), IconID("fas-transgender"), IconUnicodeGlyph(0xf224)]
        SolidTransgender = 735,
        ///<summary>Solid Sim Card</summary>
        ///<see href="https://fontawesome.com/icons/sim-card?style=solid"/>
        [Description("Solid Sim Card"), IconID("fas-sim-card"), IconUnicodeGlyph(0xf7c4)]
        SolidSimCard = 736,
        ///<summary>Solid Dice Four</summary>
        ///<see href="https://fontawesome.com/icons/dice-four?style=solid"/>
        [Description("Solid Dice Four"), IconID("fas-dice-four"), IconUnicodeGlyph(0xf524)]
        SolidDiceFour = 737,
        ///<summary>Solid Backspace</summary>
        ///<see href="https://fontawesome.com/icons/backspace?style=solid"/>
        [Description("Solid Backspace"), IconID("fas-backspace"), IconUnicodeGlyph(0xf55a)]
        SolidBackspace = 738,
        ///<summary>Solid Splotch</summary>
        ///<see href="https://fontawesome.com/icons/splotch?style=solid"/>
        [Description("Solid Splotch"), IconID("fas-splotch"), IconUnicodeGlyph(0xf5bc)]
        SolidSplotch = 739,
        ///<summary>Solid Warehouse</summary>
        ///<see href="https://fontawesome.com/icons/warehouse?style=solid"/>
        [Description("Solid Warehouse"), IconID("fas-warehouse"), IconUnicodeGlyph(0xf494)]
        SolidWarehouse = 740,
        ///<summary>Solid Peace</summary>
        ///<see href="https://fontawesome.com/icons/peace?style=solid"/>
        [Description("Solid Peace"), IconID("fas-peace"), IconUnicodeGlyph(0xf67c)]
        SolidPeace = 741,
        ///<summary>Solid Robot</summary>
        ///<see href="https://fontawesome.com/icons/robot?style=solid"/>
        [Description("Solid Robot"), IconID("fas-robot"), IconUnicodeGlyph(0xf544)]
        SolidRobot = 742,
        ///<summary>Solid Spinner</summary>
        ///<see href="https://fontawesome.com/icons/spinner?style=solid"/>
        [Description("Solid Spinner"), IconID("fas-spinner"), IconUnicodeGlyph(0xf110)]
        SolidSpinner = 743,
        ///<summary>Solid Hand Peace</summary>
        ///<see href="https://fontawesome.com/icons/hand-peace?style=solid"/>
        [Description("Solid Hand Peace"), IconID("fas-hand-peace"), IconUnicodeGlyph(0xf25b)]
        SolidHandPeace = 744,
        ///<summary>Solid Sad Tear</summary>
        ///<see href="https://fontawesome.com/icons/sad-tear?style=solid"/>
        [Description("Solid Sad Tear"), IconID("fas-sad-tear"), IconUnicodeGlyph(0xf5b4)]
        SolidSadTear = 745,
        ///<summary>Solid Hammer</summary>
        ///<see href="https://fontawesome.com/icons/hammer?style=solid"/>
        [Description("Solid Hammer"), IconID("fas-hammer"), IconUnicodeGlyph(0xf6e3)]
        SolidHammer = 746,
        ///<summary>Solid Trophy</summary>
        ///<see href="https://fontawesome.com/icons/trophy?style=solid"/>
        [Description("Solid Trophy"), IconID("fas-trophy"), IconUnicodeGlyph(0xf091)]
        SolidTrophy = 747,
        ///<summary>Solid Thumbtack</summary>
        ///<see href="https://fontawesome.com/icons/thumbtack?style=solid"/>
        [Description("Solid Thumbtack"), IconID("fas-thumbtack"), IconUnicodeGlyph(0xf08d)]
        SolidThumbtack = 748,
        ///<summary>Solid Columns</summary>
        ///<see href="https://fontawesome.com/icons/columns?style=solid"/>
        [Description("Solid Columns"), IconID("fas-columns"), IconUnicodeGlyph(0xf0db)]
        SolidColumns = 749,
        ///<summary>Solid Broadcast Tower</summary>
        ///<see href="https://fontawesome.com/icons/broadcast-tower?style=solid"/>
        [Description("Solid Broadcast Tower"), IconID("fas-broadcast-tower"), IconUnicodeGlyph(0xf519)]
        SolidBroadcastTower = 750,
        ///<summary>Solid Truck Moving</summary>
        ///<see href="https://fontawesome.com/icons/truck-moving?style=solid"/>
        [Description("Solid Truck Moving"), IconID("fas-truck-moving"), IconUnicodeGlyph(0xf4df)]
        SolidTruckMoving = 751,
        ///<summary>Solid Donate</summary>
        ///<see href="https://fontawesome.com/icons/donate?style=solid"/>
        [Description("Solid Donate"), IconID("fas-donate"), IconUnicodeGlyph(0xf4b9)]
        SolidDonate = 752,
        ///<summary>Solid Percent</summary>
        ///<see href="https://fontawesome.com/icons/percent?style=solid"/>
        [Description("Solid Percent"), IconID("fas-percent"), IconUnicodeGlyph(0xf295)]
        SolidPercent = 753,
        ///<summary>Solid Hand Middle Finger</summary>
        ///<see href="https://fontawesome.com/icons/hand-middle-finger?style=solid"/>
        [Description("Solid Hand Middle Finger"), IconID("fas-hand-middle-finger"), IconUnicodeGlyph(0xf806)]
        SolidHandMiddleFinger = 754,
        ///<summary>Solid Ambulance</summary>
        ///<see href="https://fontawesome.com/icons/ambulance?style=solid"/>
        [Description("Solid Ambulance"), IconID("fas-ambulance"), IconUnicodeGlyph(0xf0f9)]
        SolidAmbulance = 755,
        ///<summary>Solid Vr Cardboard</summary>
        ///<see href="https://fontawesome.com/icons/vr-cardboard?style=solid"/>
        [Description("Solid Vr Cardboard"), IconID("fas-vr-cardboard"), IconUnicodeGlyph(0xf729)]
        SolidVrCardboard = 756,
        ///<summary>Solid Sort Numeric Down Alt</summary>
        ///<see href="https://fontawesome.com/icons/sort-numeric-down-alt?style=solid"/>
        [Description("Solid Sort Numeric Down Alt"), IconID("fas-sort-numeric-down-alt"), IconUnicodeGlyph(0xf886)]
        SolidSortNumericDownAlt = 757,
        ///<summary>Solid Thermometer</summary>
        ///<see href="https://fontawesome.com/icons/thermometer?style=solid"/>
        [Description("Solid Thermometer"), IconID("fas-thermometer"), IconUnicodeGlyph(0xf491)]
        SolidThermometer = 758,
        ///<summary>Solid Traffic Light</summary>
        ///<see href="https://fontawesome.com/icons/traffic-light?style=solid"/>
        [Description("Solid Traffic Light"), IconID("fas-traffic-light"), IconUnicodeGlyph(0xf637)]
        SolidTrafficLight = 759,
        ///<summary>Solid Baby Carriage</summary>
        ///<see href="https://fontawesome.com/icons/baby-carriage?style=solid"/>
        [Description("Solid Baby Carriage"), IconID("fas-baby-carriage"), IconUnicodeGlyph(0xf77d)]
        SolidBabyCarriage = 760,
        ///<summary>Solid Space Shuttle</summary>
        ///<see href="https://fontawesome.com/icons/space-shuttle?style=solid"/>
        [Description("Solid Space Shuttle"), IconID("fas-space-shuttle"), IconUnicodeGlyph(0xf197)]
        SolidSpaceShuttle = 761,
        ///<summary>Solid Battery Quarter</summary>
        ///<see href="https://fontawesome.com/icons/battery-quarter?style=solid"/>
        [Description("Solid Battery Quarter"), IconID("fas-battery-quarter"), IconUnicodeGlyph(0xf243)]
        SolidBatteryQuarter = 762,
        ///<summary>Solid Video Slash</summary>
        ///<see href="https://fontawesome.com/icons/video-slash?style=solid"/>
        [Description("Solid Video Slash"), IconID("fas-video-slash"), IconUnicodeGlyph(0xf4e2)]
        SolidVideoSlash = 763,
        ///<summary>Solid Pump Soap</summary>
        ///<see href="https://fontawesome.com/icons/pump-soap?style=solid"/>
        [Description("Solid Pump Soap"), IconID("fas-pump-soap"), IconUnicodeGlyph(0xe06b)]
        SolidPumpSoap = 764,
        ///<summary>Solid Sticky Note</summary>
        ///<see href="https://fontawesome.com/icons/sticky-note?style=solid"/>
        [Description("Solid Sticky Note"), IconID("fas-sticky-note"), IconUnicodeGlyph(0xf249)]
        SolidStickyNote = 765,
        ///<summary>Solid Retweet</summary>
        ///<see href="https://fontawesome.com/icons/retweet?style=solid"/>
        [Description("Solid Retweet"), IconID("fas-retweet"), IconUnicodeGlyph(0xf079)]
        SolidRetweet = 766,
        ///<summary>Solid Chevron Right</summary>
        ///<see href="https://fontawesome.com/icons/chevron-right?style=solid"/>
        [Description("Solid Chevron Right"), IconID("fas-chevron-right"), IconUnicodeGlyph(0xf054)]
        SolidChevronRight = 767,
        ///<summary>Solid Genderless</summary>
        ///<see href="https://fontawesome.com/icons/genderless?style=solid"/>
        [Description("Solid Genderless"), IconID("fas-genderless"), IconUnicodeGlyph(0xf22d)]
        SolidGenderless = 768,
        ///<summary>Solid Briefcase Medical</summary>
        ///<see href="https://fontawesome.com/icons/briefcase-medical?style=solid"/>
        [Description("Solid Briefcase Medical"), IconID("fas-briefcase-medical"), IconUnicodeGlyph(0xf469)]
        SolidBriefcaseMedical = 769,
        ///<summary>Solid Disease</summary>
        ///<see href="https://fontawesome.com/icons/disease?style=solid"/>
        [Description("Solid Disease"), IconID("fas-disease"), IconUnicodeGlyph(0xf7fa)]
        SolidDisease = 770,
        ///<summary>Solid Hand Lizard</summary>
        ///<see href="https://fontawesome.com/icons/hand-lizard?style=solid"/>
        [Description("Solid Hand Lizard"), IconID("fas-hand-lizard"), IconUnicodeGlyph(0xf258)]
        SolidHandLizard = 771,
        ///<summary>Solid Bacteria</summary>
        ///<see href="https://fontawesome.com/icons/bacteria?style=solid"/>
        [Description("Solid Bacteria"), IconID("fas-bacteria"), IconUnicodeGlyph(0xe059)]
        SolidBacteria = 772,
        ///<summary>Solid Chevron Left</summary>
        ///<see href="https://fontawesome.com/icons/chevron-left?style=solid"/>
        [Description("Solid Chevron Left"), IconID("fas-chevron-left"), IconUnicodeGlyph(0xf053)]
        SolidChevronLeft = 773,
        ///<summary>Solid Holly Berry</summary>
        ///<see href="https://fontawesome.com/icons/holly-berry?style=solid"/>
        [Description("Solid Holly Berry"), IconID("fas-holly-berry"), IconUnicodeGlyph(0xf7aa)]
        SolidHollyBerry = 774,
        ///<summary>Solid American Sign Language Interpreting</summary>
        ///<see href="https://fontawesome.com/icons/american-sign-language-interpreting?style=solid"/>
        [Description("Solid American Sign Language Interpreting"), IconID("fas-american-sign-language-interpreting"), IconUnicodeGlyph(0xf2a3)]
        SolidAmericanSignLanguageInterpreting = 775,
        ///<summary>Solid Mars Stroke V</summary>
        ///<see href="https://fontawesome.com/icons/mars-stroke-v?style=solid"/>
        [Description("Solid Mars Stroke V"), IconID("fas-mars-stroke-v"), IconUnicodeGlyph(0xf22a)]
        SolidMarsStrokeV = 776,
        ///<summary>Solid Drumstick Bite</summary>
        ///<see href="https://fontawesome.com/icons/drumstick-bite?style=solid"/>
        [Description("Solid Drumstick Bite"), IconID("fas-drumstick-bite"), IconUnicodeGlyph(0xf6d7)]
        SolidDrumstickBite = 777,
        ///<summary>Solid Money Bill Alt</summary>
        ///<see href="https://fontawesome.com/icons/money-bill-alt?style=solid"/>
        [Description("Solid Money Bill Alt"), IconID("fas-money-bill-alt"), IconUnicodeGlyph(0xf3d1)]
        SolidMoneyBillAlt = 778,
        ///<summary>Solid Angle Up</summary>
        ///<see href="https://fontawesome.com/icons/angle-up?style=solid"/>
        [Description("Solid Angle Up"), IconID("fas-angle-up"), IconUnicodeGlyph(0xf106)]
        SolidAngleUp = 779,
        ///<summary>Solid Fill</summary>
        ///<see href="https://fontawesome.com/icons/fill?style=solid"/>
        [Description("Solid Fill"), IconID("fas-fill"), IconUnicodeGlyph(0xf575)]
        SolidFill = 780,
        ///<summary>Solid Hand Holding Water</summary>
        ///<see href="https://fontawesome.com/icons/hand-holding-water?style=solid"/>
        [Description("Solid Hand Holding Water"), IconID("fas-hand-holding-water"), IconUnicodeGlyph(0xf4c1)]
        SolidHandHoldingWater = 781,
        ///<summary>Solid Tablet</summary>
        ///<see href="https://fontawesome.com/icons/tablet?style=solid"/>
        [Description("Solid Tablet"), IconID("fas-tablet"), IconUnicodeGlyph(0xf10a)]
        SolidTablet = 782,
        ///<summary>Solid Bell Slash</summary>
        ///<see href="https://fontawesome.com/icons/bell-slash?style=solid"/>
        [Description("Solid Bell Slash"), IconID("fas-bell-slash"), IconUnicodeGlyph(0xf1f6)]
        SolidBellSlash = 783,
        ///<summary>Solid Chevron Circle Down</summary>
        ///<see href="https://fontawesome.com/icons/chevron-circle-down?style=solid"/>
        [Description("Solid Chevron Circle Down"), IconID("fas-chevron-circle-down"), IconUnicodeGlyph(0xf13a)]
        SolidChevronCircleDown = 784,
        ///<summary>Solid Bezier Curve</summary>
        ///<see href="https://fontawesome.com/icons/bezier-curve?style=solid"/>
        [Description("Solid Bezier Curve"), IconID("fas-bezier-curve"), IconUnicodeGlyph(0xf55b)]
        SolidBezierCurve = 785,
        ///<summary>Solid Assistive Listening Systems</summary>
        ///<see href="https://fontawesome.com/icons/assistive-listening-systems?style=solid"/>
        [Description("Solid Assistive Listening Systems"), IconID("fas-assistive-listening-systems"), IconUnicodeGlyph(0xf2a2)]
        SolidAssistiveListeningSystems = 786,
        ///<summary>Solid Rss Square</summary>
        ///<see href="https://fontawesome.com/icons/rss-square?style=solid"/>
        [Description("Solid Rss Square"), IconID("fas-rss-square"), IconUnicodeGlyph(0xf143)]
        SolidRssSquare = 787,
        ///<summary>Solid Store</summary>
        ///<see href="https://fontawesome.com/icons/store?style=solid"/>
        [Description("Solid Store"), IconID("fas-store"), IconUnicodeGlyph(0xf54e)]
        SolidStore = 788,
        ///<summary>Solid Folder Minus</summary>
        ///<see href="https://fontawesome.com/icons/folder-minus?style=solid"/>
        [Description("Solid Folder Minus"), IconID("fas-folder-minus"), IconUnicodeGlyph(0xf65d)]
        SolidFolderMinus = 789,
        ///<summary>Solid Funnel Dollar</summary>
        ///<see href="https://fontawesome.com/icons/funnel-dollar?style=solid"/>
        [Description("Solid Funnel Dollar"), IconID("fas-funnel-dollar"), IconUnicodeGlyph(0xf662)]
        SolidFunnelDollar = 790,
        ///<summary>Solid Balance Scale</summary>
        ///<see href="https://fontawesome.com/icons/balance-scale?style=solid"/>
        [Description("Solid Balance Scale"), IconID("fas-balance-scale"), IconUnicodeGlyph(0xf24e)]
        SolidBalanceScale = 791,
        ///<summary>Solid Rocket</summary>
        ///<see href="https://fontawesome.com/icons/rocket?style=solid"/>
        [Description("Solid Rocket"), IconID("fas-rocket"), IconUnicodeGlyph(0xf135)]
        SolidRocket = 792,
        ///<summary>Solid Map</summary>
        ///<see href="https://fontawesome.com/icons/map?style=solid"/>
        [Description("Solid Map"), IconID("fas-map"), IconUnicodeGlyph(0xf279)]
        SolidMap = 793,
        ///<summary>Solid Shekel Sign</summary>
        ///<see href="https://fontawesome.com/icons/shekel-sign?style=solid"/>
        [Description("Solid Shekel Sign"), IconID("fas-shekel-sign"), IconUnicodeGlyph(0xf20b)]
        SolidShekelSign = 794,
        ///<summary>Solid Teeth</summary>
        ///<see href="https://fontawesome.com/icons/teeth?style=solid"/>
        [Description("Solid Teeth"), IconID("fas-teeth"), IconUnicodeGlyph(0xf62e)]
        SolidTeeth = 795,
        ///<summary>Solid Blender</summary>
        ///<see href="https://fontawesome.com/icons/blender?style=solid"/>
        [Description("Solid Blender"), IconID("fas-blender"), IconUnicodeGlyph(0xf517)]
        SolidBlender = 796,
        ///<summary>Solid Smile</summary>
        ///<see href="https://fontawesome.com/icons/smile?style=solid"/>
        [Description("Solid Smile"), IconID("fas-smile"), IconUnicodeGlyph(0xf118)]
        SolidSmile = 797,
        ///<summary>Solid Share Alt Square</summary>
        ///<see href="https://fontawesome.com/icons/share-alt-square?style=solid"/>
        [Description("Solid Share Alt Square"), IconID("fas-share-alt-square"), IconUnicodeGlyph(0xf1e1)]
        SolidShareAltSquare = 798,
        ///<summary>Solid Equals</summary>
        ///<see href="https://fontawesome.com/icons/equals?style=solid"/>
        [Description("Solid Equals"), IconID("fas-equals"), IconUnicodeGlyph(0xf52c)]
        SolidEquals = 799,
        ///<summary>Solid Sign Language</summary>
        ///<see href="https://fontawesome.com/icons/sign-language?style=solid"/>
        [Description("Solid Sign Language"), IconID("fas-sign-language"), IconUnicodeGlyph(0xf2a7)]
        SolidSignLanguage = 800,
        ///<summary>Solid Copyright</summary>
        ///<see href="https://fontawesome.com/icons/copyright?style=solid"/>
        [Description("Solid Copyright"), IconID("fas-copyright"), IconUnicodeGlyph(0xf1f9)]
        SolidCopyright = 801,
        ///<summary>Solid Ruler Combined</summary>
        ///<see href="https://fontawesome.com/icons/ruler-combined?style=solid"/>
        [Description("Solid Ruler Combined"), IconID("fas-ruler-combined"), IconUnicodeGlyph(0xf546)]
        SolidRulerCombined = 802,
        ///<summary>Solid Tractor</summary>
        ///<see href="https://fontawesome.com/icons/tractor?style=solid"/>
        [Description("Solid Tractor"), IconID("fas-tractor"), IconUnicodeGlyph(0xf722)]
        SolidTractor = 803,
        ///<summary>Solid Quote Left</summary>
        ///<see href="https://fontawesome.com/icons/quote-left?style=solid"/>
        [Description("Solid Quote Left"), IconID("fas-quote-left"), IconUnicodeGlyph(0xf10d)]
        SolidQuoteLeft = 804,
        ///<summary>Solid Baby</summary>
        ///<see href="https://fontawesome.com/icons/baby?style=solid"/>
        [Description("Solid Baby"), IconID("fas-baby"), IconUnicodeGlyph(0xf77c)]
        SolidBaby = 805,
        ///<summary>Solid Glass Martini Alt</summary>
        ///<see href="https://fontawesome.com/icons/glass-martini-alt?style=solid"/>
        [Description("Solid Glass Martini Alt"), IconID("fas-glass-martini-alt"), IconUnicodeGlyph(0xf57b)]
        SolidGlassMartiniAlt = 806,
        ///<summary>Solid Vote Yea</summary>
        ///<see href="https://fontawesome.com/icons/vote-yea?style=solid"/>
        [Description("Solid Vote Yea"), IconID("fas-vote-yea"), IconUnicodeGlyph(0xf772)]
        SolidVoteYea = 807,
        ///<summary>Solid Expand</summary>
        ///<see href="https://fontawesome.com/icons/expand?style=solid"/>
        [Description("Solid Expand"), IconID("fas-expand"), IconUnicodeGlyph(0xf065)]
        SolidExpand = 808,
        ///<summary>Solid Plus</summary>
        ///<see href="https://fontawesome.com/icons/plus?style=solid"/>
        [Description("Solid Plus"), IconID("fas-plus"), IconUnicodeGlyph(0xf067)]
        SolidPlus = 809,
        ///<summary>Solid Store Alt</summary>
        ///<see href="https://fontawesome.com/icons/store-alt?style=solid"/>
        [Description("Solid Store Alt"), IconID("fas-store-alt"), IconUnicodeGlyph(0xf54f)]
        SolidStoreAlt = 810,
        ///<summary>Solid Users Cog</summary>
        ///<see href="https://fontawesome.com/icons/users-cog?style=solid"/>
        [Description("Solid Users Cog"), IconID("fas-users-cog"), IconUnicodeGlyph(0xf509)]
        SolidUsersCog = 811,
        ///<summary>Solid Hand Sparkles</summary>
        ///<see href="https://fontawesome.com/icons/hand-sparkles?style=solid"/>
        [Description("Solid Hand Sparkles"), IconID("fas-hand-sparkles"), IconUnicodeGlyph(0xe05d)]
        SolidHandSparkles = 812,
        ///<summary>Solid Copy</summary>
        ///<see href="https://fontawesome.com/icons/copy?style=solid"/>
        [Description("Solid Copy"), IconID("fas-copy"), IconUnicodeGlyph(0xf0c5)]
        SolidCopy = 813,
        ///<summary>Solid Football Ball</summary>
        ///<see href="https://fontawesome.com/icons/football-ball?style=solid"/>
        [Description("Solid Football Ball"), IconID("fas-football-ball"), IconUnicodeGlyph(0xf44e)]
        SolidFootballBall = 814,
        ///<summary>Solid Heart Broken</summary>
        ///<see href="https://fontawesome.com/icons/heart-broken?style=solid"/>
        [Description("Solid Heart Broken"), IconID("fas-heart-broken"), IconUnicodeGlyph(0xf7a9)]
        SolidHeartBroken = 815,
        ///<summary>Solid User Graduate</summary>
        ///<see href="https://fontawesome.com/icons/user-graduate?style=solid"/>
        [Description("Solid User Graduate"), IconID("fas-user-graduate"), IconUnicodeGlyph(0xf501)]
        SolidUserGraduate = 816,
        ///<summary>Solid Chevron Circle Right</summary>
        ///<see href="https://fontawesome.com/icons/chevron-circle-right?style=solid"/>
        [Description("Solid Chevron Circle Right"), IconID("fas-chevron-circle-right"), IconUnicodeGlyph(0xf138)]
        SolidChevronCircleRight = 817,
        ///<summary>Solid Fish</summary>
        ///<see href="https://fontawesome.com/icons/fish?style=solid"/>
        [Description("Solid Fish"), IconID("fas-fish"), IconUnicodeGlyph(0xf578)]
        SolidFish = 818,
        ///<summary>Solid Hot Tub</summary>
        ///<see href="https://fontawesome.com/icons/hot-tub?style=solid"/>
        [Description("Solid Hot Tub"), IconID("fas-hot-tub"), IconUnicodeGlyph(0xf593)]
        SolidHotTub = 819,
        ///<summary>Solid Wind</summary>
        ///<see href="https://fontawesome.com/icons/wind?style=solid"/>
        [Description("Solid Wind"), IconID("fas-wind"), IconUnicodeGlyph(0xf72e)]
        SolidWind = 820,
        ///<summary>Solid Comment Alt</summary>
        ///<see href="https://fontawesome.com/icons/comment-alt?style=solid"/>
        [Description("Solid Comment Alt"), IconID("fas-comment-alt"), IconUnicodeGlyph(0xf27a)]
        SolidCommentAlt = 821,
        ///<summary>Solid User Shield</summary>
        ///<see href="https://fontawesome.com/icons/user-shield?style=solid"/>
        [Description("Solid User Shield"), IconID("fas-user-shield"), IconUnicodeGlyph(0xf505)]
        SolidUserShield = 822,
        ///<summary>Solid Praying Hands</summary>
        ///<see href="https://fontawesome.com/icons/praying-hands?style=solid"/>
        [Description("Solid Praying Hands"), IconID("fas-praying-hands"), IconUnicodeGlyph(0xf684)]
        SolidPrayingHands = 823,
        ///<summary>Solid Kiss Beam</summary>
        ///<see href="https://fontawesome.com/icons/kiss-beam?style=solid"/>
        [Description("Solid Kiss Beam"), IconID("fas-kiss-beam"), IconUnicodeGlyph(0xf597)]
        SolidKissBeam = 824,
        ///<summary>Solid Tv</summary>
        ///<see href="https://fontawesome.com/icons/tv?style=solid"/>
        [Description("Solid Tv"), IconID("fas-tv"), IconUnicodeGlyph(0xf26c)]
        SolidTv = 825,
        ///<summary>Solid Arrow Up</summary>
        ///<see href="https://fontawesome.com/icons/arrow-up?style=solid"/>
        [Description("Solid Arrow Up"), IconID("fas-arrow-up"), IconUnicodeGlyph(0xf062)]
        SolidArrowUp = 826,
        ///<summary>Solid Chess King</summary>
        ///<see href="https://fontawesome.com/icons/chess-king?style=solid"/>
        [Description("Solid Chess King"), IconID("fas-chess-king"), IconUnicodeGlyph(0xf43f)]
        SolidChessKing = 827,
        ///<summary>Solid Arrows Alt H</summary>
        ///<see href="https://fontawesome.com/icons/arrows-alt-h?style=solid"/>
        [Description("Solid Arrows Alt H"), IconID("fas-arrows-alt-h"), IconUnicodeGlyph(0xf337)]
        SolidArrowsAltH = 828,
        ///<summary>Solid Clinic Medical</summary>
        ///<see href="https://fontawesome.com/icons/clinic-medical?style=solid"/>
        [Description("Solid Clinic Medical"), IconID("fas-clinic-medical"), IconUnicodeGlyph(0xf7f2)]
        SolidClinicMedical = 829,
        ///<summary>Solid List Ul</summary>
        ///<see href="https://fontawesome.com/icons/list-ul?style=solid"/>
        [Description("Solid List Ul"), IconID("fas-list-ul"), IconUnicodeGlyph(0xf0ca)]
        SolidListUl = 830,
        ///<summary>Solid Skull Crossbones</summary>
        ///<see href="https://fontawesome.com/icons/skull-crossbones?style=solid"/>
        [Description("Solid Skull Crossbones"), IconID("fas-skull-crossbones"), IconUnicodeGlyph(0xf714)]
        SolidSkullCrossbones = 831,
        ///<summary>Solid Sync Alt</summary>
        ///<see href="https://fontawesome.com/icons/sync-alt?style=solid"/>
        [Description("Solid Sync Alt"), IconID("fas-sync-alt"), IconUnicodeGlyph(0xf2f1)]
        SolidSyncAlt = 832,
        ///<summary>Solid Battery Full</summary>
        ///<see href="https://fontawesome.com/icons/battery-full?style=solid"/>
        [Description("Solid Battery Full"), IconID("fas-battery-full"), IconUnicodeGlyph(0xf240)]
        SolidBatteryFull = 833,
        ///<summary>Solid Chevron Down</summary>
        ///<see href="https://fontawesome.com/icons/chevron-down?style=solid"/>
        [Description("Solid Chevron Down"), IconID("fas-chevron-down"), IconUnicodeGlyph(0xf078)]
        SolidChevronDown = 834,
        ///<summary>Solid Suitcase Rolling</summary>
        ///<see href="https://fontawesome.com/icons/suitcase-rolling?style=solid"/>
        [Description("Solid Suitcase Rolling"), IconID("fas-suitcase-rolling"), IconUnicodeGlyph(0xf5c1)]
        SolidSuitcaseRolling = 835,
        ///<summary>Solid Receipt</summary>
        ///<see href="https://fontawesome.com/icons/receipt?style=solid"/>
        [Description("Solid Receipt"), IconID("fas-receipt"), IconUnicodeGlyph(0xf543)]
        SolidReceipt = 836,
        ///<summary>Solid Cart Arrow Down</summary>
        ///<see href="https://fontawesome.com/icons/cart-arrow-down?style=solid"/>
        [Description("Solid Cart Arrow Down"), IconID("fas-cart-arrow-down"), IconUnicodeGlyph(0xf218)]
        SolidCartArrowDown = 837,
        ///<summary>Solid Tint</summary>
        ///<see href="https://fontawesome.com/icons/tint?style=solid"/>
        [Description("Solid Tint"), IconID("fas-tint"), IconUnicodeGlyph(0xf043)]
        SolidTint = 838,
        ///<summary>Solid Golf Ball</summary>
        ///<see href="https://fontawesome.com/icons/golf-ball?style=solid"/>
        [Description("Solid Golf Ball"), IconID("fas-golf-ball"), IconUnicodeGlyph(0xf450)]
        SolidGolfBall = 839,
        ///<summary>Solid Laugh Squint</summary>
        ///<see href="https://fontawesome.com/icons/laugh-squint?style=solid"/>
        [Description("Solid Laugh Squint"), IconID("fas-laugh-squint"), IconUnicodeGlyph(0xf59b)]
        SolidLaughSquint = 840,
        ///<summary>Solid Hospital Symbol</summary>
        ///<see href="https://fontawesome.com/icons/hospital-symbol?style=solid"/>
        [Description("Solid Hospital Symbol"), IconID("fas-hospital-symbol"), IconUnicodeGlyph(0xf47e)]
        SolidHospitalSymbol = 841,
        ///<summary>Solid Step Forward</summary>
        ///<see href="https://fontawesome.com/icons/step-forward?style=solid"/>
        [Description("Solid Step Forward"), IconID("fas-step-forward"), IconUnicodeGlyph(0xf051)]
        SolidStepForward = 842,
        ///<summary>Solid Low Vision</summary>
        ///<see href="https://fontawesome.com/icons/low-vision?style=solid"/>
        [Description("Solid Low Vision"), IconID("fas-low-vision"), IconUnicodeGlyph(0xf2a8)]
        SolidLowVision = 843,
        ///<summary>Solid Stop Circle</summary>
        ///<see href="https://fontawesome.com/icons/stop-circle?style=solid"/>
        [Description("Solid Stop Circle"), IconID("fas-stop-circle"), IconUnicodeGlyph(0xf28d)]
        SolidStopCircle = 844,
        ///<summary>Solid Poll H</summary>
        ///<see href="https://fontawesome.com/icons/poll-h?style=solid"/>
        [Description("Solid Poll H"), IconID("fas-poll-h"), IconUnicodeGlyph(0xf682)]
        SolidPollH = 845,
        ///<summary>Solid Allergies</summary>
        ///<see href="https://fontawesome.com/icons/allergies?style=solid"/>
        [Description("Solid Allergies"), IconID("fas-allergies"), IconUnicodeGlyph(0xf461)]
        SolidAllergies = 846,
        ///<summary>Solid Font</summary>
        ///<see href="https://fontawesome.com/icons/font?style=solid"/>
        [Description("Solid Font"), IconID("fas-font"), IconUnicodeGlyph(0xf031)]
        SolidFont = 847,
        ///<summary>Solid Play</summary>
        ///<see href="https://fontawesome.com/icons/play?style=solid"/>
        [Description("Solid Play"), IconID("fas-play"), IconUnicodeGlyph(0xf04b)]
        SolidPlay = 848,
        ///<summary>Solid File Download</summary>
        ///<see href="https://fontawesome.com/icons/file-download?style=solid"/>
        [Description("Solid File Download"), IconID("fas-file-download"), IconUnicodeGlyph(0xf56d)]
        SolidFileDownload = 849,
        ///<summary>Solid Link</summary>
        ///<see href="https://fontawesome.com/icons/link?style=solid"/>
        [Description("Solid Link"), IconID("fas-link"), IconUnicodeGlyph(0xf0c1)]
        SolidLink = 850,
        ///<summary>Solid Star Half</summary>
        ///<see href="https://fontawesome.com/icons/star-half?style=solid"/>
        [Description("Solid Star Half"), IconID("fas-star-half"), IconUnicodeGlyph(0xf089)]
        SolidStarHalf = 851,
        ///<summary>Solid Hryvnia</summary>
        ///<see href="https://fontawesome.com/icons/hryvnia?style=solid"/>
        [Description("Solid Hryvnia"), IconID("fas-hryvnia"), IconUnicodeGlyph(0xf6f2)]
        SolidHryvnia = 852,
        ///<summary>Solid Paragraph</summary>
        ///<see href="https://fontawesome.com/icons/paragraph?style=solid"/>
        [Description("Solid Paragraph"), IconID("fas-paragraph"), IconUnicodeGlyph(0xf1dd)]
        SolidParagraph = 853,
        ///<summary>Solid Fax</summary>
        ///<see href="https://fontawesome.com/icons/fax?style=solid"/>
        [Description("Solid Fax"), IconID("fas-fax"), IconUnicodeGlyph(0xf1ac)]
        SolidFax = 854,
        ///<summary>Solid Ice Cream</summary>
        ///<see href="https://fontawesome.com/icons/ice-cream?style=solid"/>
        [Description("Solid Ice Cream"), IconID("fas-ice-cream"), IconUnicodeGlyph(0xf810)]
        SolidIceCream = 855,
        ///<summary>Solid Drum</summary>
        ///<see href="https://fontawesome.com/icons/drum?style=solid"/>
        [Description("Solid Drum"), IconID("fas-drum"), IconUnicodeGlyph(0xf569)]
        SolidDrum = 856,
        ///<summary>Solid Trash Alt</summary>
        ///<see href="https://fontawesome.com/icons/trash-alt?style=solid"/>
        [Description("Solid Trash Alt"), IconID("fas-trash-alt"), IconUnicodeGlyph(0xf2ed)]
        SolidTrashAlt = 857,
        ///<summary>Solid Font Awesome Logo Full</summary>
        ///<see href="https://fontawesome.com/icons/font-awesome-logo-full?style=solid"/>
        [Description("Solid Font Awesome Logo Full"), IconID("fas-font-awesome-logo-full"), IconUnicodeGlyph(0xf4e6)]
        SolidFontAwesomeLogoFull = 858,
        ///<summary>Solid Hotdog</summary>
        ///<see href="https://fontawesome.com/icons/hotdog?style=solid"/>
        [Description("Solid Hotdog"), IconID("fas-hotdog"), IconUnicodeGlyph(0xf80f)]
        SolidHotdog = 859,
        ///<summary>Solid Dharmachakra</summary>
        ///<see href="https://fontawesome.com/icons/dharmachakra?style=solid"/>
        [Description("Solid Dharmachakra"), IconID("fas-dharmachakra"), IconUnicodeGlyph(0xf655)]
        SolidDharmachakra = 860,
        ///<summary>Solid Coffee</summary>
        ///<see href="https://fontawesome.com/icons/coffee?style=solid"/>
        [Description("Solid Coffee"), IconID("fas-coffee"), IconUnicodeGlyph(0xf0f4)]
        SolidCoffee = 861,
        ///<summary>Solid Chess Rook</summary>
        ///<see href="https://fontawesome.com/icons/chess-rook?style=solid"/>
        [Description("Solid Chess Rook"), IconID("fas-chess-rook"), IconUnicodeGlyph(0xf447)]
        SolidChessRook = 862,
        ///<summary>Solid Wine Bottle</summary>
        ///<see href="https://fontawesome.com/icons/wine-bottle?style=solid"/>
        [Description("Solid Wine Bottle"), IconID("fas-wine-bottle"), IconUnicodeGlyph(0xf72f)]
        SolidWineBottle = 863,
        ///<summary>Solid Hospital</summary>
        ///<see href="https://fontawesome.com/icons/hospital?style=solid"/>
        [Description("Solid Hospital"), IconID("fas-hospital"), IconUnicodeGlyph(0xf0f8)]
        SolidHospital = 864,
        ///<summary>Solid Envelope Open Text</summary>
        ///<see href="https://fontawesome.com/icons/envelope-open-text?style=solid"/>
        [Description("Solid Envelope Open Text"), IconID("fas-envelope-open-text"), IconUnicodeGlyph(0xf658)]
        SolidEnvelopeOpenText = 865,
        ///<summary>Solid Inbox</summary>
        ///<see href="https://fontawesome.com/icons/inbox?style=solid"/>
        [Description("Solid Inbox"), IconID("fas-inbox"), IconUnicodeGlyph(0xf01c)]
        SolidInbox = 866,
        ///<summary>Solid Socks</summary>
        ///<see href="https://fontawesome.com/icons/socks?style=solid"/>
        [Description("Solid Socks"), IconID("fas-socks"), IconUnicodeGlyph(0xf696)]
        SolidSocks = 867,
        ///<summary>Solid Battery Empty</summary>
        ///<see href="https://fontawesome.com/icons/battery-empty?style=solid"/>
        [Description("Solid Battery Empty"), IconID("fas-battery-empty"), IconUnicodeGlyph(0xf244)]
        SolidBatteryEmpty = 868,
        ///<summary>Solid Dove</summary>
        ///<see href="https://fontawesome.com/icons/dove?style=solid"/>
        [Description("Solid Dove"), IconID("fas-dove"), IconUnicodeGlyph(0xf4ba)]
        SolidDove = 869,
        ///<summary>Solid Eraser</summary>
        ///<see href="https://fontawesome.com/icons/eraser?style=solid"/>
        [Description("Solid Eraser"), IconID("fas-eraser"), IconUnicodeGlyph(0xf12d)]
        SolidEraser = 870,
        ///<summary>Solid Arrow Down</summary>
        ///<see href="https://fontawesome.com/icons/arrow-down?style=solid"/>
        [Description("Solid Arrow Down"), IconID("fas-arrow-down"), IconUnicodeGlyph(0xf063)]
        SolidArrowDown = 871,
        ///<summary>Solid Greater Than</summary>
        ///<see href="https://fontawesome.com/icons/greater-than?style=solid"/>
        [Description("Solid Greater Than"), IconID("fas-greater-than"), IconUnicodeGlyph(0xf531)]
        SolidGreaterThan = 872,
        ///<summary>Solid File</summary>
        ///<see href="https://fontawesome.com/icons/file?style=solid"/>
        [Description("Solid File"), IconID("fas-file"), IconUnicodeGlyph(0xf15b)]
        SolidFile = 873,
        ///<summary>Solid Blind</summary>
        ///<see href="https://fontawesome.com/icons/blind?style=solid"/>
        [Description("Solid Blind"), IconID("fas-blind"), IconUnicodeGlyph(0xf29d)]
        SolidBlind = 874,
        ///<summary>Solid Paint Roller</summary>
        ///<see href="https://fontawesome.com/icons/paint-roller?style=solid"/>
        [Description("Solid Paint Roller"), IconID("fas-paint-roller"), IconUnicodeGlyph(0xf5aa)]
        SolidPaintRoller = 875,
        ///<summary>Solid Phone Slash</summary>
        ///<see href="https://fontawesome.com/icons/phone-slash?style=solid"/>
        [Description("Solid Phone Slash"), IconID("fas-phone-slash"), IconUnicodeGlyph(0xf3dd)]
        SolidPhoneSlash = 876,
        ///<summary>Solid Star Of Life</summary>
        ///<see href="https://fontawesome.com/icons/star-of-life?style=solid"/>
        [Description("Solid Star Of Life"), IconID("fas-star-of-life"), IconUnicodeGlyph(0xf621)]
        SolidStarOfLife = 877,
        ///<summary>Solid Superscript</summary>
        ///<see href="https://fontawesome.com/icons/superscript?style=solid"/>
        [Description("Solid Superscript"), IconID("fas-superscript"), IconUnicodeGlyph(0xf12b)]
        SolidSuperscript = 878,
        ///<summary>Solid Bell</summary>
        ///<see href="https://fontawesome.com/icons/bell?style=solid"/>
        [Description("Solid Bell"), IconID("fas-bell"), IconUnicodeGlyph(0xf0f3)]
        SolidBell = 879,
        ///<summary>Solid Podcast</summary>
        ///<see href="https://fontawesome.com/icons/podcast?style=solid"/>
        [Description("Solid Podcast"), IconID("fas-podcast"), IconUnicodeGlyph(0xf2ce)]
        SolidPodcast = 880,
        ///<summary>Solid Bed</summary>
        ///<see href="https://fontawesome.com/icons/bed?style=solid"/>
        [Description("Solid Bed"), IconID("fas-bed"), IconUnicodeGlyph(0xf236)]
        SolidBed = 881,
        ///<summary>Solid Medal</summary>
        ///<see href="https://fontawesome.com/icons/medal?style=solid"/>
        [Description("Solid Medal"), IconID("fas-medal"), IconUnicodeGlyph(0xf5a2)]
        SolidMedal = 882,
        ///<summary>Solid H Square</summary>
        ///<see href="https://fontawesome.com/icons/h-square?style=solid"/>
        [Description("Solid H Square"), IconID("fas-h-square"), IconUnicodeGlyph(0xf0fd)]
        SolidHSquare = 883,
        ///<summary>Solid Dice D20</summary>
        ///<see href="https://fontawesome.com/icons/dice-d20?style=solid"/>
        [Description("Solid Dice D20"), IconID("fas-dice-d20"), IconUnicodeGlyph(0xf6cf)]
        SolidDiceD20 = 884,
        ///<summary>Solid Deaf</summary>
        ///<see href="https://fontawesome.com/icons/deaf?style=solid"/>
        [Description("Solid Deaf"), IconID("fas-deaf"), IconUnicodeGlyph(0xf2a4)]
        SolidDeaf = 885,
        ///<summary>Solid Sign</summary>
        ///<see href="https://fontawesome.com/icons/sign?style=solid"/>
        [Description("Solid Sign"), IconID("fas-sign"), IconUnicodeGlyph(0xf4d9)]
        SolidSign = 886,
        ///<summary>Solid Car</summary>
        ///<see href="https://fontawesome.com/icons/car?style=solid"/>
        [Description("Solid Car"), IconID("fas-car"), IconUnicodeGlyph(0xf1b9)]
        SolidCar = 887,
        ///<summary>Solid Credit Card</summary>
        ///<see href="https://fontawesome.com/icons/credit-card?style=solid"/>
        [Description("Solid Credit Card"), IconID("fas-credit-card"), IconUnicodeGlyph(0xf09d)]
        SolidCreditCard = 888,
        ///<summary>Solid Bug</summary>
        ///<see href="https://fontawesome.com/icons/bug?style=solid"/>
        [Description("Solid Bug"), IconID("fas-bug"), IconUnicodeGlyph(0xf188)]
        SolidBug = 889,
        ///<summary>Solid Car Alt</summary>
        ///<see href="https://fontawesome.com/icons/car-alt?style=solid"/>
        [Description("Solid Car Alt"), IconID("fas-car-alt"), IconUnicodeGlyph(0xf5de)]
        SolidCarAlt = 890,
        ///<summary>Solid Toolbox</summary>
        ///<see href="https://fontawesome.com/icons/toolbox?style=solid"/>
        [Description("Solid Toolbox"), IconID("fas-toolbox"), IconUnicodeGlyph(0xf552)]
        SolidToolbox = 891,
        ///<summary>Solid Chess Pawn</summary>
        ///<see href="https://fontawesome.com/icons/chess-pawn?style=solid"/>
        [Description("Solid Chess Pawn"), IconID("fas-chess-pawn"), IconUnicodeGlyph(0xf443)]
        SolidChessPawn = 892,
        ///<summary>Solid Sort Alpha Up Alt</summary>
        ///<see href="https://fontawesome.com/icons/sort-alpha-up-alt?style=solid"/>
        [Description("Solid Sort Alpha Up Alt"), IconID("fas-sort-alpha-up-alt"), IconUnicodeGlyph(0xf882)]
        SolidSortAlphaUpAlt = 893,
        ///<summary>Solid Mobile Alt</summary>
        ///<see href="https://fontawesome.com/icons/mobile-alt?style=solid"/>
        [Description("Solid Mobile Alt"), IconID("fas-mobile-alt"), IconUnicodeGlyph(0xf3cd)]
        SolidMobileAlt = 894,
        ///<summary>Solid Thermometer Quarter</summary>
        ///<see href="https://fontawesome.com/icons/thermometer-quarter?style=solid"/>
        [Description("Solid Thermometer Quarter"), IconID("fas-thermometer-quarter"), IconUnicodeGlyph(0xf2ca)]
        SolidThermometerQuarter = 895,
        ///<summary>Solid User Lock</summary>
        ///<see href="https://fontawesome.com/icons/user-lock?style=solid"/>
        [Description("Solid User Lock"), IconID("fas-user-lock"), IconUnicodeGlyph(0xf502)]
        SolidUserLock = 896,
        ///<summary>Solid Thumbs Down</summary>
        ///<see href="https://fontawesome.com/icons/thumbs-down?style=solid"/>
        [Description("Solid Thumbs Down"), IconID("fas-thumbs-down"), IconUnicodeGlyph(0xf165)]
        SolidThumbsDown = 897,
        ///<summary>Solid Grip Lines</summary>
        ///<see href="https://fontawesome.com/icons/grip-lines?style=solid"/>
        [Description("Solid Grip Lines"), IconID("fas-grip-lines"), IconUnicodeGlyph(0xf7a4)]
        SolidGripLines = 898,
        ///<summary>Solid Head Side Cough</summary>
        ///<see href="https://fontawesome.com/icons/head-side-cough?style=solid"/>
        [Description("Solid Head Side Cough"), IconID("fas-head-side-cough"), IconUnicodeGlyph(0xe061)]
        SolidHeadSideCough = 899,
        ///<summary>Solid Angle Down</summary>
        ///<see href="https://fontawesome.com/icons/angle-down?style=solid"/>
        [Description("Solid Angle Down"), IconID("fas-angle-down"), IconUnicodeGlyph(0xf107)]
        SolidAngleDown = 900,
        ///<summary>Solid Less Than</summary>
        ///<see href="https://fontawesome.com/icons/less-than?style=solid"/>
        [Description("Solid Less Than"), IconID("fas-less-than"), IconUnicodeGlyph(0xf536)]
        SolidLessThan = 901,
        ///<summary>Solid Info Circle</summary>
        ///<see href="https://fontawesome.com/icons/info-circle?style=solid"/>
        [Description("Solid Info Circle"), IconID("fas-info-circle"), IconUnicodeGlyph(0xf05a)]
        SolidInfoCircle = 902,
        ///<summary>Solid Industry</summary>
        ///<see href="https://fontawesome.com/icons/industry?style=solid"/>
        [Description("Solid Industry"), IconID("fas-industry"), IconUnicodeGlyph(0xf275)]
        SolidIndustry = 903,
        ///<summary>Solid Horse Head</summary>
        ///<see href="https://fontawesome.com/icons/horse-head?style=solid"/>
        [Description("Solid Horse Head"), IconID("fas-horse-head"), IconUnicodeGlyph(0xf7ab)]
        SolidHorseHead = 904,
        ///<summary>Solid Guitar</summary>
        ///<see href="https://fontawesome.com/icons/guitar?style=solid"/>
        [Description("Solid Guitar"), IconID("fas-guitar"), IconUnicodeGlyph(0xf7a6)]
        SolidGuitar = 905,
        ///<summary>Solid Sun</summary>
        ///<see href="https://fontawesome.com/icons/sun?style=solid"/>
        [Description("Solid Sun"), IconID("fas-sun"), IconUnicodeGlyph(0xf185)]
        SolidSun = 906,
        ///<summary>Solid Ruble Sign</summary>
        ///<see href="https://fontawesome.com/icons/ruble-sign?style=solid"/>
        [Description("Solid Ruble Sign"), IconID("fas-ruble-sign"), IconUnicodeGlyph(0xf158)]
        SolidRubleSign = 907,
        ///<summary>Solid Yen Sign</summary>
        ///<see href="https://fontawesome.com/icons/yen-sign?style=solid"/>
        [Description("Solid Yen Sign"), IconID("fas-yen-sign"), IconUnicodeGlyph(0xf157)]
        SolidYenSign = 908,
        ///<summary>Solid Toilet</summary>
        ///<see href="https://fontawesome.com/icons/toilet?style=solid"/>
        [Description("Solid Toilet"), IconID("fas-toilet"), IconUnicodeGlyph(0xf7d8)]
        SolidToilet = 909,
        ///<summary>Solid Mars</summary>
        ///<see href="https://fontawesome.com/icons/mars?style=solid"/>
        [Description("Solid Mars"), IconID("fas-mars"), IconUnicodeGlyph(0xf222)]
        SolidMars = 910,
        ///<summary>Solid Th</summary>
        ///<see href="https://fontawesome.com/icons/th?style=solid"/>
        [Description("Solid Th"), IconID("fas-th"), IconUnicodeGlyph(0xf00a)]
        SolidTh = 911,
        ///<summary>Solid Bolt</summary>
        ///<see href="https://fontawesome.com/icons/bolt?style=solid"/>
        [Description("Solid Bolt"), IconID("fas-bolt"), IconUnicodeGlyph(0xf0e7)]
        SolidBolt = 912,
        ///<summary>Solid Envelope Square</summary>
        ///<see href="https://fontawesome.com/icons/envelope-square?style=solid"/>
        [Description("Solid Envelope Square"), IconID("fas-envelope-square"), IconUnicodeGlyph(0xf199)]
        SolidEnvelopeSquare = 913,
        ///<summary>Solid Caravan</summary>
        ///<see href="https://fontawesome.com/icons/caravan?style=solid"/>
        [Description("Solid Caravan"), IconID("fas-caravan"), IconUnicodeGlyph(0xf8ff)]
        SolidCaravan = 914,
        ///<summary>Solid Compact Disc</summary>
        ///<see href="https://fontawesome.com/icons/compact-disc?style=solid"/>
        [Description("Solid Compact Disc"), IconID("fas-compact-disc"), IconUnicodeGlyph(0xf51f)]
        SolidCompactDisc = 915,
        ///<summary>Solid Expand Alt</summary>
        ///<see href="https://fontawesome.com/icons/expand-alt?style=solid"/>
        [Description("Solid Expand Alt"), IconID("fas-expand-alt"), IconUnicodeGlyph(0xf424)]
        SolidExpandAlt = 916,
        ///<summary>Solid Upload</summary>
        ///<see href="https://fontawesome.com/icons/upload?style=solid"/>
        [Description("Solid Upload"), IconID("fas-upload"), IconUnicodeGlyph(0xf093)]
        SolidUpload = 917,
        ///<summary>Solid Stop</summary>
        ///<see href="https://fontawesome.com/icons/stop?style=solid"/>
        [Description("Solid Stop"), IconID("fas-stop"), IconUnicodeGlyph(0xf04d)]
        SolidStop = 918,
        ///<summary>Solid Truck Pickup</summary>
        ///<see href="https://fontawesome.com/icons/truck-pickup?style=solid"/>
        [Description("Solid Truck Pickup"), IconID("fas-truck-pickup"), IconUnicodeGlyph(0xf63c)]
        SolidTruckPickup = 919,
        ///<summary>Solid Sort Amount Down</summary>
        ///<see href="https://fontawesome.com/icons/sort-amount-down?style=solid"/>
        [Description("Solid Sort Amount Down"), IconID("fas-sort-amount-down"), IconUnicodeGlyph(0xf160)]
        SolidSortAmountDown = 920,
        ///<summary>Solid Pen Alt</summary>
        ///<see href="https://fontawesome.com/icons/pen-alt?style=solid"/>
        [Description("Solid Pen Alt"), IconID("fas-pen-alt"), IconUnicodeGlyph(0xf305)]
        SolidPenAlt = 921,
        ///<summary>Solid Skull</summary>
        ///<see href="https://fontawesome.com/icons/skull?style=solid"/>
        [Description("Solid Skull"), IconID("fas-skull"), IconUnicodeGlyph(0xf54c)]
        SolidSkull = 922,
        ///<summary>Solid University</summary>
        ///<see href="https://fontawesome.com/icons/university?style=solid"/>
        [Description("Solid University"), IconID("fas-university"), IconUnicodeGlyph(0xf19c)]
        SolidUniversity = 923,
        ///<summary>Solid Times</summary>
        ///<see href="https://fontawesome.com/icons/times?style=solid"/>
        [Description("Solid Times"), IconID("fas-times"), IconUnicodeGlyph(0xf00d)]
        SolidTimes = 924,
        ///<summary>Solid Utensils</summary>
        ///<see href="https://fontawesome.com/icons/utensils?style=solid"/>
        [Description("Solid Utensils"), IconID("fas-utensils"), IconUnicodeGlyph(0xf2e7)]
        SolidUtensils = 925,
        ///<summary>Solid Kiwi Bird</summary>
        ///<see href="https://fontawesome.com/icons/kiwi-bird?style=solid"/>
        [Description("Solid Kiwi Bird"), IconID("fas-kiwi-bird"), IconUnicodeGlyph(0xf535)]
        SolidKiwiBird = 926,
        ///<summary>Solid Sign In Alt</summary>
        ///<see href="https://fontawesome.com/icons/sign-in-alt?style=solid"/>
        [Description("Solid Sign In Alt"), IconID("fas-sign-in-alt"), IconUnicodeGlyph(0xf2f6)]
        SolidSignInAlt = 927,
        ///<summary>Solid Dice One</summary>
        ///<see href="https://fontawesome.com/icons/dice-one?style=solid"/>
        [Description("Solid Dice One"), IconID("fas-dice-one"), IconUnicodeGlyph(0xf525)]
        SolidDiceOne = 928,
        ///<summary>Solid File Medical</summary>
        ///<see href="https://fontawesome.com/icons/file-medical?style=solid"/>
        [Description("Solid File Medical"), IconID("fas-file-medical"), IconUnicodeGlyph(0xf477)]
        SolidFileMedical = 929,
        ///<summary>Solid Laptop Medical</summary>
        ///<see href="https://fontawesome.com/icons/laptop-medical?style=solid"/>
        [Description("Solid Laptop Medical"), IconID("fas-laptop-medical"), IconUnicodeGlyph(0xf812)]
        SolidLaptopMedical = 930,
        ///<summary>Solid Calendar Week</summary>
        ///<see href="https://fontawesome.com/icons/calendar-week?style=solid"/>
        [Description("Solid Calendar Week"), IconID("fas-calendar-week"), IconUnicodeGlyph(0xf784)]
        SolidCalendarWeek = 931,
        ///<summary>Solid Outdent</summary>
        ///<see href="https://fontawesome.com/icons/outdent?style=solid"/>
        [Description("Solid Outdent"), IconID("fas-outdent"), IconUnicodeGlyph(0xf03b)]
        SolidOutdent = 932,
        ///<summary>Solid Id Card</summary>
        ///<see href="https://fontawesome.com/icons/id-card?style=solid"/>
        [Description("Solid Id Card"), IconID("fas-id-card"), IconUnicodeGlyph(0xf2c2)]
        SolidIdCard = 933,
        ///<summary>Solid Align Center</summary>
        ///<see href="https://fontawesome.com/icons/align-center?style=solid"/>
        [Description("Solid Align Center"), IconID("fas-align-center"), IconUnicodeGlyph(0xf037)]
        SolidAlignCenter = 934,
        ///<summary>Solid Mobile</summary>
        ///<see href="https://fontawesome.com/icons/mobile?style=solid"/>
        [Description("Solid Mobile"), IconID("fas-mobile"), IconUnicodeGlyph(0xf10b)]
        SolidMobile = 935,
        ///<summary>Solid Forward</summary>
        ///<see href="https://fontawesome.com/icons/forward?style=solid"/>
        [Description("Solid Forward"), IconID("fas-forward"), IconUnicodeGlyph(0xf04e)]
        SolidForward = 936,
        ///<summary>Solid Eye Dropper</summary>
        ///<see href="https://fontawesome.com/icons/eye-dropper?style=solid"/>
        [Description("Solid Eye Dropper"), IconID("fas-eye-dropper"), IconUnicodeGlyph(0xf1fb)]
        SolidEyeDropper = 937,
        ///<summary>Solid Download</summary>
        ///<see href="https://fontawesome.com/icons/download?style=solid"/>
        [Description("Solid Download"), IconID("fas-download"), IconUnicodeGlyph(0xf019)]
        SolidDownload = 938,
        ///<summary>Solid Ship</summary>
        ///<see href="https://fontawesome.com/icons/ship?style=solid"/>
        [Description("Solid Ship"), IconID("fas-ship"), IconUnicodeGlyph(0xf21a)]
        SolidShip = 939,
        ///<summary>Solid People Carry</summary>
        ///<see href="https://fontawesome.com/icons/people-carry?style=solid"/>
        [Description("Solid People Carry"), IconID("fas-people-carry"), IconUnicodeGlyph(0xf4ce)]
        SolidPeopleCarry = 940,
        ///<summary>Solid Quran</summary>
        ///<see href="https://fontawesome.com/icons/quran?style=solid"/>
        [Description("Solid Quran"), IconID("fas-quran"), IconUnicodeGlyph(0xf687)]
        SolidQuran = 941,
        ///<summary>Solid Cloud Rain</summary>
        ///<see href="https://fontawesome.com/icons/cloud-rain?style=solid"/>
        [Description("Solid Cloud Rain"), IconID("fas-cloud-rain"), IconUnicodeGlyph(0xf73d)]
        SolidCloudRain = 942,
        ///<summary>Solid Smile Wink</summary>
        ///<see href="https://fontawesome.com/icons/smile-wink?style=solid"/>
        [Description("Solid Smile Wink"), IconID("fas-smile-wink"), IconUnicodeGlyph(0xf4da)]
        SolidSmileWink = 943,
        ///<summary>Solid Calculator</summary>
        ///<see href="https://fontawesome.com/icons/calculator?style=solid"/>
        [Description("Solid Calculator"), IconID("fas-calculator"), IconUnicodeGlyph(0xf1ec)]
        SolidCalculator = 944,
        ///<summary>Solid Images</summary>
        ///<see href="https://fontawesome.com/icons/images?style=solid"/>
        [Description("Solid Images"), IconID("fas-images"), IconUnicodeGlyph(0xf302)]
        SolidImages = 945,
        ///<summary>Solid Venus Double</summary>
        ///<see href="https://fontawesome.com/icons/venus-double?style=solid"/>
        [Description("Solid Venus Double"), IconID("fas-venus-double"), IconUnicodeGlyph(0xf226)]
        SolidVenusDouble = 946,
        ///<summary>Solid Arrows Alt</summary>
        ///<see href="https://fontawesome.com/icons/arrows-alt?style=solid"/>
        [Description("Solid Arrows Alt"), IconID("fas-arrows-alt"), IconUnicodeGlyph(0xf0b2)]
        SolidArrowsAlt = 947,
        ///<summary>Solid Closed Captioning</summary>
        ///<see href="https://fontawesome.com/icons/closed-captioning?style=solid"/>
        [Description("Solid Closed Captioning"), IconID("fas-closed-captioning"), IconUnicodeGlyph(0xf20a)]
        SolidClosedCaptioning = 948,
        ///<summary>Solid Tty</summary>
        ///<see href="https://fontawesome.com/icons/tty?style=solid"/>
        [Description("Solid Tty"), IconID("fas-tty"), IconUnicodeGlyph(0xf1e4)]
        SolidTty = 949,
        ///<summary>Solid Flag Usa</summary>
        ///<see href="https://fontawesome.com/icons/flag-usa?style=solid"/>
        [Description("Solid Flag Usa"), IconID("fas-flag-usa"), IconUnicodeGlyph(0xf74d)]
        SolidFlagUsa = 950,
        ///<summary>Solid Sort Amount Up</summary>
        ///<see href="https://fontawesome.com/icons/sort-amount-up?style=solid"/>
        [Description("Solid Sort Amount Up"), IconID("fas-sort-amount-up"), IconUnicodeGlyph(0xf161)]
        SolidSortAmountUp = 951,
        ///<summary>Solid Power Off</summary>
        ///<see href="https://fontawesome.com/icons/power-off?style=solid"/>
        [Description("Solid Power Off"), IconID("fas-power-off"), IconUnicodeGlyph(0xf011)]
        SolidPowerOff = 952,
        ///<summary>Solid Flask</summary>
        ///<see href="https://fontawesome.com/icons/flask?style=solid"/>
        [Description("Solid Flask"), IconID("fas-flask"), IconUnicodeGlyph(0xf0c3)]
        SolidFlask = 953,
        ///<summary>Solid Hamsa</summary>
        ///<see href="https://fontawesome.com/icons/hamsa?style=solid"/>
        [Description("Solid Hamsa"), IconID("fas-hamsa"), IconUnicodeGlyph(0xf665)]
        SolidHamsa = 954,
        ///<summary>Solid Map Pin</summary>
        ///<see href="https://fontawesome.com/icons/map-pin?style=solid"/>
        [Description("Solid Map Pin"), IconID("fas-map-pin"), IconUnicodeGlyph(0xf276)]
        SolidMapPin = 955,
        ///<summary>Solid Search</summary>
        ///<see href="https://fontawesome.com/icons/search?style=solid"/>
        [Description("Solid Search"), IconID("fas-search"), IconUnicodeGlyph(0xf002)]
        SolidSearch = 956,
        ///<summary>Solid Edit</summary>
        ///<see href="https://fontawesome.com/icons/edit?style=solid"/>
        [Description("Solid Edit"), IconID("fas-edit"), IconUnicodeGlyph(0xf044)]
        SolidEdit = 957,
        ///<summary>Solid Network Wired</summary>
        ///<see href="https://fontawesome.com/icons/network-wired?style=solid"/>
        [Description("Solid Network Wired"), IconID("fas-network-wired"), IconUnicodeGlyph(0xf6ff)]
        SolidNetworkWired = 958,
        ///<summary>Solid Microphone Alt</summary>
        ///<see href="https://fontawesome.com/icons/microphone-alt?style=solid"/>
        [Description("Solid Microphone Alt"), IconID("fas-microphone-alt"), IconUnicodeGlyph(0xf3c9)]
        SolidMicrophoneAlt = 959,
        ///<summary>Solid Khanda</summary>
        ///<see href="https://fontawesome.com/icons/khanda?style=solid"/>
        [Description("Solid Khanda"), IconID("fas-khanda"), IconUnicodeGlyph(0xf66d)]
        SolidKhanda = 960,
        ///<summary>Solid Home</summary>
        ///<see href="https://fontawesome.com/icons/home?style=solid"/>
        [Description("Solid Home"), IconID("fas-home"), IconUnicodeGlyph(0xf015)]
        SolidHome = 961,
        ///<summary>Solid Coins</summary>
        ///<see href="https://fontawesome.com/icons/coins?style=solid"/>
        [Description("Solid Coins"), IconID("fas-coins"), IconUnicodeGlyph(0xf51e)]
        SolidCoins = 962,
        ///<summary>Solid Battery Half</summary>
        ///<see href="https://fontawesome.com/icons/battery-half?style=solid"/>
        [Description("Solid Battery Half"), IconID("fas-battery-half"), IconUnicodeGlyph(0xf242)]
        SolidBatteryHalf = 963,
        ///<summary>Solid Piggy Bank</summary>
        ///<see href="https://fontawesome.com/icons/piggy-bank?style=solid"/>
        [Description("Solid Piggy Bank"), IconID("fas-piggy-bank"), IconUnicodeGlyph(0xf4d3)]
        SolidPiggyBank = 964,
        ///<summary>Solid Grin Stars</summary>
        ///<see href="https://fontawesome.com/icons/grin-stars?style=solid"/>
        [Description("Solid Grin Stars"), IconID("fas-grin-stars"), IconUnicodeGlyph(0xf587)]
        SolidGrinStars = 965,
        ///<summary>Solid Caret Down</summary>
        ///<see href="https://fontawesome.com/icons/caret-down?style=solid"/>
        [Description("Solid Caret Down"), IconID("fas-caret-down"), IconUnicodeGlyph(0xf0d7)]
        SolidCaretDown = 966,
        ///<summary>Solid User Friends</summary>
        ///<see href="https://fontawesome.com/icons/user-friends?style=solid"/>
        [Description("Solid User Friends"), IconID("fas-user-friends"), IconUnicodeGlyph(0xf500)]
        SolidUserFriends = 967,
        ///<summary>Solid Transgender Alt</summary>
        ///<see href="https://fontawesome.com/icons/transgender-alt?style=solid"/>
        [Description("Solid Transgender Alt"), IconID("fas-transgender-alt"), IconUnicodeGlyph(0xf225)]
        SolidTransgenderAlt = 968,
        ///<summary>Solid Keyboard</summary>
        ///<see href="https://fontawesome.com/icons/keyboard?style=solid"/>
        [Description("Solid Keyboard"), IconID("fas-keyboard"), IconUnicodeGlyph(0xf11c)]
        SolidKeyboard = 969,
        ///<summary>Solid Faucet</summary>
        ///<see href="https://fontawesome.com/icons/faucet?style=solid"/>
        [Description("Solid Faucet"), IconID("fas-faucet"), IconUnicodeGlyph(0xe005)]
        SolidFaucet = 970,
        ///<summary>Solid Pallet</summary>
        ///<see href="https://fontawesome.com/icons/pallet?style=solid"/>
        [Description("Solid Pallet"), IconID("fas-pallet"), IconUnicodeGlyph(0xf482)]
        SolidPallet = 971,
        ///<summary>Solid Clock</summary>
        ///<see href="https://fontawesome.com/icons/clock?style=solid"/>
        [Description("Solid Clock"), IconID("fas-clock"), IconUnicodeGlyph(0xf017)]
        SolidClock = 972,
        ///<summary>Solid Map Signs</summary>
        ///<see href="https://fontawesome.com/icons/map-signs?style=solid"/>
        [Description("Solid Map Signs"), IconID("fas-map-signs"), IconUnicodeGlyph(0xf277)]
        SolidMapSigns = 973,
        ///<summary>Solid Question Circle</summary>
        ///<see href="https://fontawesome.com/icons/question-circle?style=solid"/>
        [Description("Solid Question Circle"), IconID("fas-question-circle"), IconUnicodeGlyph(0xf059)]
        SolidQuestionCircle = 974,
        ///<summary>Solid Grip Vertical</summary>
        ///<see href="https://fontawesome.com/icons/grip-vertical?style=solid"/>
        [Description("Solid Grip Vertical"), IconID("fas-grip-vertical"), IconUnicodeGlyph(0xf58e)]
        SolidGripVertical = 975,
        ///<summary>Solid Trash Restore</summary>
        ///<see href="https://fontawesome.com/icons/trash-restore?style=solid"/>
        [Description("Solid Trash Restore"), IconID("fas-trash-restore"), IconUnicodeGlyph(0xf829)]
        SolidTrashRestore = 976,
        ///<summary>Solid Sort Amount Up Alt</summary>
        ///<see href="https://fontawesome.com/icons/sort-amount-up-alt?style=solid"/>
        [Description("Solid Sort Amount Up Alt"), IconID("fas-sort-amount-up-alt"), IconUnicodeGlyph(0xf885)]
        SolidSortAmountUpAlt = 977,
        ///<summary>Solid Glass Martini</summary>
        ///<see href="https://fontawesome.com/icons/glass-martini?style=solid"/>
        [Description("Solid Glass Martini"), IconID("fas-glass-martini"), IconUnicodeGlyph(0xf000)]
        SolidGlassMartini = 978,
        ///<summary>Solid Cog</summary>
        ///<see href="https://fontawesome.com/icons/cog?style=solid"/>
        [Description("Solid Cog"), IconID("fas-cog"), IconUnicodeGlyph(0xf013)]
        SolidCog = 979,
        ///<summary>Solid Place Of Worship</summary>
        ///<see href="https://fontawesome.com/icons/place-of-worship?style=solid"/>
        [Description("Solid Place Of Worship"), IconID("fas-place-of-worship"), IconUnicodeGlyph(0xf67f)]
        SolidPlaceOfWorship = 980,
        ///<summary>Solid Procedures</summary>
        ///<see href="https://fontawesome.com/icons/procedures?style=solid"/>
        [Description("Solid Procedures"), IconID("fas-procedures"), IconUnicodeGlyph(0xf487)]
        SolidProcedures = 981,
        ///<summary>Solid Globe Africa</summary>
        ///<see href="https://fontawesome.com/icons/globe-africa?style=solid"/>
        [Description("Solid Globe Africa"), IconID("fas-globe-africa"), IconUnicodeGlyph(0xf57c)]
        SolidGlobeAfrica = 982,
        ///<summary>Solid Vials</summary>
        ///<see href="https://fontawesome.com/icons/vials?style=solid"/>
        [Description("Solid Vials"), IconID("fas-vials"), IconUnicodeGlyph(0xf493)]
        SolidVials = 983,
        ///<summary>Solid Sms</summary>
        ///<see href="https://fontawesome.com/icons/sms?style=solid"/>
        [Description("Solid Sms"), IconID("fas-sms"), IconUnicodeGlyph(0xf7cd)]
        SolidSms = 984,
        ///<summary>Solid Arrow Circle Left</summary>
        ///<see href="https://fontawesome.com/icons/arrow-circle-left?style=solid"/>
        [Description("Solid Arrow Circle Left"), IconID("fas-arrow-circle-left"), IconUnicodeGlyph(0xf0a8)]
        SolidArrowCircleLeft = 985,
        ///<summary>Solid Star Of David</summary>
        ///<see href="https://fontawesome.com/icons/star-of-david?style=solid"/>
        [Description("Solid Star Of David"), IconID("fas-star-of-david"), IconUnicodeGlyph(0xf69a)]
        SolidStarOfDavid = 986,
        ///<summary>Solid Mosque</summary>
        ///<see href="https://fontawesome.com/icons/mosque?style=solid"/>
        [Description("Solid Mosque"), IconID("fas-mosque"), IconUnicodeGlyph(0xf678)]
        SolidMosque = 987,
        ///<summary>Solid Bus Alt</summary>
        ///<see href="https://fontawesome.com/icons/bus-alt?style=solid"/>
        [Description("Solid Bus Alt"), IconID("fas-bus-alt"), IconUnicodeGlyph(0xf55e)]
        SolidBusAlt = 988,
        ///<summary>Solid Volume Off</summary>
        ///<see href="https://fontawesome.com/icons/volume-off?style=solid"/>
        [Description("Solid Volume Off"), IconID("fas-volume-off"), IconUnicodeGlyph(0xf026)]
        SolidVolumeOff = 989,
        ///<summary>Solid Street View</summary>
        ///<see href="https://fontawesome.com/icons/street-view?style=solid"/>
        [Description("Solid Street View"), IconID("fas-street-view"), IconUnicodeGlyph(0xf21d)]
        SolidStreetView = 990,
        ///<summary>Solid Chess</summary>
        ///<see href="https://fontawesome.com/icons/chess?style=solid"/>
        [Description("Solid Chess"), IconID("fas-chess"), IconUnicodeGlyph(0xf439)]
        SolidChess = 991,
        ///<summary>Solid Minus</summary>
        ///<see href="https://fontawesome.com/icons/minus?style=solid"/>
        [Description("Solid Minus"), IconID("fas-minus"), IconUnicodeGlyph(0xf068)]
        SolidMinus = 992,
        ///<summary>Solid Map Marker</summary>
        ///<see href="https://fontawesome.com/icons/map-marker?style=solid"/>
        [Description("Solid Map Marker"), IconID("fas-map-marker"), IconUnicodeGlyph(0xf041)]
        SolidMapMarker = 993,
        ///<summary>Solid Virus Slash</summary>
        ///<see href="https://fontawesome.com/icons/virus-slash?style=solid"/>
        [Description("Solid Virus Slash"), IconID("fas-virus-slash"), IconUnicodeGlyph(0xe075)]
        SolidVirusSlash = 994,
        ///<summary>Solid Dna</summary>
        ///<see href="https://fontawesome.com/icons/dna?style=solid"/>
        [Description("Solid Dna"), IconID("fas-dna"), IconUnicodeGlyph(0xf471)]
        SolidDna = 995,
        ///<summary>Solid Plane Arrival</summary>
        ///<see href="https://fontawesome.com/icons/plane-arrival?style=solid"/>
        [Description("Solid Plane Arrival"), IconID("fas-plane-arrival"), IconUnicodeGlyph(0xf5af)]
        SolidPlaneArrival = 996,
        ///<summary>Solid Calendar Plus</summary>
        ///<see href="https://fontawesome.com/icons/calendar-plus?style=solid"/>
        [Description("Solid Calendar Plus"), IconID("fas-calendar-plus"), IconUnicodeGlyph(0xf271)]
        SolidCalendarPlus = 997,
        ///<summary>Solid Dumbbell</summary>
        ///<see href="https://fontawesome.com/icons/dumbbell?style=solid"/>
        [Description("Solid Dumbbell"), IconID("fas-dumbbell"), IconUnicodeGlyph(0xf44b)]
        SolidDumbbell = 998,
        ///<summary>Solid Cookie</summary>
        ///<see href="https://fontawesome.com/icons/cookie?style=solid"/>
        [Description("Solid Cookie"), IconID("fas-cookie"), IconUnicodeGlyph(0xf563)]
        SolidCookie = 999,
        ///<summary>Solid Volume Mute</summary>
        ///<see href="https://fontawesome.com/icons/volume-mute?style=solid"/>
        [Description("Solid Volume Mute"), IconID("fas-volume-mute"), IconUnicodeGlyph(0xf6a9)]
        SolidVolumeMute = 1000,
        ///<summary>Solid Check Double</summary>
        ///<see href="https://fontawesome.com/icons/check-double?style=solid"/>
        [Description("Solid Check Double"), IconID("fas-check-double"), IconUnicodeGlyph(0xf560)]
        SolidCheckDouble = 1001,
        ///<summary>Solid Vest Patches</summary>
        ///<see href="https://fontawesome.com/icons/vest-patches?style=solid"/>
        [Description("Solid Vest Patches"), IconID("fas-vest-patches"), IconUnicodeGlyph(0xe086)]
        SolidVestPatches = 1002,
        ///<summary>Solid Crosshairs</summary>
        ///<see href="https://fontawesome.com/icons/crosshairs?style=solid"/>
        [Description("Solid Crosshairs"), IconID("fas-crosshairs"), IconUnicodeGlyph(0xf05b)]
        SolidCrosshairs = 1003,
        ///<summary>Solid Truck</summary>
        ///<see href="https://fontawesome.com/icons/truck?style=solid"/>
        [Description("Solid Truck"), IconID("fas-truck"), IconUnicodeGlyph(0xf0d1)]
        SolidTruck = 1004,
        ///<summary>Solid Landmark</summary>
        ///<see href="https://fontawesome.com/icons/landmark?style=solid"/>
        [Description("Solid Landmark"), IconID("fas-landmark"), IconUnicodeGlyph(0xf66f)]
        SolidLandmark = 1005,
        ///<summary>Solid Tired</summary>
        ///<see href="https://fontawesome.com/icons/tired?style=solid"/>
        [Description("Solid Tired"), IconID("fas-tired"), IconUnicodeGlyph(0xf5c8)]
        SolidTired = 1006,
        ///<summary>Solid Braille</summary>
        ///<see href="https://fontawesome.com/icons/braille?style=solid"/>
        [Description("Solid Braille"), IconID("fas-braille"), IconUnicodeGlyph(0xf2a1)]
        SolidBraille = 1007,
        ///<summary>Solid Apple Alt</summary>
        ///<see href="https://fontawesome.com/icons/apple-alt?style=solid"/>
        [Description("Solid Apple Alt"), IconID("fas-apple-alt"), IconUnicodeGlyph(0xf5d1)]
        SolidAppleAlt = 1008,
        ///<summary>Solid Calendar Check</summary>
        ///<see href="https://fontawesome.com/icons/calendar-check?style=solid"/>
        [Description("Solid Calendar Check"), IconID("fas-calendar-check"), IconUnicodeGlyph(0xf274)]
        SolidCalendarCheck = 1009,
        ///<summary>Solid Water</summary>
        ///<see href="https://fontawesome.com/icons/water?style=solid"/>
        [Description("Solid Water"), IconID("fas-water"), IconUnicodeGlyph(0xf773)]
        SolidWater = 1010,
        ///<summary>Solid Hand Paper</summary>
        ///<see href="https://fontawesome.com/icons/hand-paper?style=solid"/>
        [Description("Solid Hand Paper"), IconID("fas-hand-paper"), IconUnicodeGlyph(0xf256)]
        SolidHandPaper = 1011,
        ///<summary>Solid Laugh Beam</summary>
        ///<see href="https://fontawesome.com/icons/laugh-beam?style=solid"/>
        [Description("Solid Laugh Beam"), IconID("fas-laugh-beam"), IconUnicodeGlyph(0xf59a)]
        SolidLaughBeam = 1012,
        ///<summary>Solid Sleigh</summary>
        ///<see href="https://fontawesome.com/icons/sleigh?style=solid"/>
        [Description("Solid Sleigh"), IconID("fas-sleigh"), IconUnicodeGlyph(0xf7cc)]
        SolidSleigh = 1013,
        ///<summary>Solid Meteor</summary>
        ///<see href="https://fontawesome.com/icons/meteor?style=solid"/>
        [Description("Solid Meteor"), IconID("fas-meteor"), IconUnicodeGlyph(0xf753)]
        SolidMeteor = 1014,
        ///<summary>Solid Cocktail</summary>
        ///<see href="https://fontawesome.com/icons/cocktail?style=solid"/>
        [Description("Solid Cocktail"), IconID("fas-cocktail"), IconUnicodeGlyph(0xf561)]
        SolidCocktail = 1015,
        ///<summary>Solid Camera</summary>
        ///<see href="https://fontawesome.com/icons/camera?style=solid"/>
        [Description("Solid Camera"), IconID("fas-camera"), IconUnicodeGlyph(0xf030)]
        SolidCamera = 1016,
        ///<summary>Solid Cloud Meatball</summary>
        ///<see href="https://fontawesome.com/icons/cloud-meatball?style=solid"/>
        [Description("Solid Cloud Meatball"), IconID("fas-cloud-meatball"), IconUnicodeGlyph(0xf73b)]
        SolidCloudMeatball = 1017,
        ///<summary>Solid Undo Alt</summary>
        ///<see href="https://fontawesome.com/icons/undo-alt?style=solid"/>
        [Description("Solid Undo Alt"), IconID("fas-undo-alt"), IconUnicodeGlyph(0xf2ea)]
        SolidUndoAlt = 1018,
        ///<summary>Solid Glass Whiskey</summary>
        ///<see href="https://fontawesome.com/icons/glass-whiskey?style=solid"/>
        [Description("Solid Glass Whiskey"), IconID("fas-glass-whiskey"), IconUnicodeGlyph(0xf7a0)]
        SolidGlassWhiskey = 1019,
        ///<summary>Solid Mountain</summary>
        ///<see href="https://fontawesome.com/icons/mountain?style=solid"/>
        [Description("Solid Mountain"), IconID("fas-mountain"), IconUnicodeGlyph(0xf6fc)]
        SolidMountain = 1020,
        ///<summary>Solid Hourglass</summary>
        ///<see href="https://fontawesome.com/icons/hourglass?style=solid"/>
        [Description("Solid Hourglass"), IconID("fas-hourglass"), IconUnicodeGlyph(0xf254)]
        SolidHourglass = 1021,
        ///<summary>Solid Laptop House</summary>
        ///<see href="https://fontawesome.com/icons/laptop-house?style=solid"/>
        [Description("Solid Laptop House"), IconID("fas-laptop-house"), IconUnicodeGlyph(0xe066)]
        SolidLaptopHouse = 1022,
        ///<summary>Solid Indent</summary>
        ///<see href="https://fontawesome.com/icons/indent?style=solid"/>
        [Description("Solid Indent"), IconID("fas-indent"), IconUnicodeGlyph(0xf03c)]
        SolidIndent = 1023,
        ///<summary>Solid Parachute Box</summary>
        ///<see href="https://fontawesome.com/icons/parachute-box?style=solid"/>
        [Description("Solid Parachute Box"), IconID("fas-parachute-box"), IconUnicodeGlyph(0xf4cd)]
        SolidParachuteBox = 1024,
        ///<summary>Solid Border None</summary>
        ///<see href="https://fontawesome.com/icons/border-none?style=solid"/>
        [Description("Solid Border None"), IconID("fas-border-none"), IconUnicodeGlyph(0xf850)]
        SolidBorderNone = 1025,
        ///<summary>Solid Share Alt</summary>
        ///<see href="https://fontawesome.com/icons/share-alt?style=solid"/>
        [Description("Solid Share Alt"), IconID("fas-share-alt"), IconUnicodeGlyph(0xf1e0)]
        SolidShareAlt = 1026,
        ///<summary>Solid Lungs</summary>
        ///<see href="https://fontawesome.com/icons/lungs?style=solid"/>
        [Description("Solid Lungs"), IconID("fas-lungs"), IconUnicodeGlyph(0xf604)]
        SolidLungs = 1027,
        ///<summary>Solid Ribbon</summary>
        ///<see href="https://fontawesome.com/icons/ribbon?style=solid"/>
        [Description("Solid Ribbon"), IconID("fas-ribbon"), IconUnicodeGlyph(0xf4d6)]
        SolidRibbon = 1028,
        ///<summary>Solid Paperclip</summary>
        ///<see href="https://fontawesome.com/icons/paperclip?style=solid"/>
        [Description("Solid Paperclip"), IconID("fas-paperclip"), IconUnicodeGlyph(0xf0c6)]
        SolidPaperclip = 1029,
        ///<summary>Solid Grin Squint Tears</summary>
        ///<see href="https://fontawesome.com/icons/grin-squint-tears?style=solid"/>
        [Description("Solid Grin Squint Tears"), IconID("fas-grin-squint-tears"), IconUnicodeGlyph(0xf586)]
        SolidGrinSquintTears = 1030,
        ///<summary>Solid Envelope</summary>
        ///<see href="https://fontawesome.com/icons/envelope?style=solid"/>
        [Description("Solid Envelope"), IconID("fas-envelope"), IconUnicodeGlyph(0xf0e0)]
        SolidEnvelope = 1031,
        ///<summary>Solid Comment</summary>
        ///<see href="https://fontawesome.com/icons/comment?style=solid"/>
        [Description("Solid Comment"), IconID("fas-comment"), IconUnicodeGlyph(0xf075)]
        SolidComment = 1032,
        ///<summary>Solid Portrait</summary>
        ///<see href="https://fontawesome.com/icons/portrait?style=solid"/>
        [Description("Solid Portrait"), IconID("fas-portrait"), IconUnicodeGlyph(0xf3e0)]
        SolidPortrait = 1033,
        ///<summary>Solid Volume Down</summary>
        ///<see href="https://fontawesome.com/icons/volume-down?style=solid"/>
        [Description("Solid Volume Down"), IconID("fas-volume-down"), IconUnicodeGlyph(0xf027)]
        SolidVolumeDown = 1034,
        ///<summary>Solid Tag</summary>
        ///<see href="https://fontawesome.com/icons/tag?style=solid"/>
        [Description("Solid Tag"), IconID("fas-tag"), IconUnicodeGlyph(0xf02b)]
        SolidTag = 1035,
        ///<summary>Solid Satellite</summary>
        ///<see href="https://fontawesome.com/icons/satellite?style=solid"/>
        [Description("Solid Satellite"), IconID("fas-satellite"), IconUnicodeGlyph(0xf7bf)]
        SolidSatellite = 1036,
        ///<summary>Solid Angry</summary>
        ///<see href="https://fontawesome.com/icons/angry?style=solid"/>
        [Description("Solid Angry"), IconID("fas-angry"), IconUnicodeGlyph(0xf556)]
        SolidAngry = 1037,
        ///<summary>Solid Lira Sign</summary>
        ///<see href="https://fontawesome.com/icons/lira-sign?style=solid"/>
        [Description("Solid Lira Sign"), IconID("fas-lira-sign"), IconUnicodeGlyph(0xf195)]
        SolidLiraSign = 1038,
        ///<summary>Solid Child</summary>
        ///<see href="https://fontawesome.com/icons/child?style=solid"/>
        [Description("Solid Child"), IconID("fas-child"), IconUnicodeGlyph(0xf1ae)]
        SolidChild = 1039,
        ///<summary>Solid Hat Cowboy Side</summary>
        ///<see href="https://fontawesome.com/icons/hat-cowboy-side?style=solid"/>
        [Description("Solid Hat Cowboy Side"), IconID("fas-hat-cowboy-side"), IconUnicodeGlyph(0xf8c1)]
        SolidHatCowboySide = 1040,
        ///<summary>Solid Phone Volume</summary>
        ///<see href="https://fontawesome.com/icons/phone-volume?style=solid"/>
        [Description("Solid Phone Volume"), IconID("fas-phone-volume"), IconUnicodeGlyph(0xf2a0)]
        SolidPhoneVolume = 1041,
        ///<summary>Solid Business Time</summary>
        ///<see href="https://fontawesome.com/icons/business-time?style=solid"/>
        [Description("Solid Business Time"), IconID("fas-business-time"), IconUnicodeGlyph(0xf64a)]
        SolidBusinessTime = 1042,
        ///<summary>Solid Comment Dollar</summary>
        ///<see href="https://fontawesome.com/icons/comment-dollar?style=solid"/>
        [Description("Solid Comment Dollar"), IconID("fas-comment-dollar"), IconUnicodeGlyph(0xf651)]
        SolidCommentDollar = 1043,
        ///<summary>Solid Otter</summary>
        ///<see href="https://fontawesome.com/icons/otter?style=solid"/>
        [Description("Solid Otter"), IconID("fas-otter"), IconUnicodeGlyph(0xf700)]
        SolidOtter = 1044,
        ///<summary>Solid User Secret</summary>
        ///<see href="https://fontawesome.com/icons/user-secret?style=solid"/>
        [Description("Solid User Secret"), IconID("fas-user-secret"), IconUnicodeGlyph(0xf21b)]
        SolidUserSecret = 1045,
        ///<summary>Solid File Pdf</summary>
        ///<see href="https://fontawesome.com/icons/file-pdf?style=solid"/>
        [Description("Solid File Pdf"), IconID("fas-file-pdf"), IconUnicodeGlyph(0xf1c1)]
        SolidFilePdf = 1046,
        ///<summary>Solid File Video</summary>
        ///<see href="https://fontawesome.com/icons/file-video?style=solid"/>
        [Description("Solid File Video"), IconID("fas-file-video"), IconUnicodeGlyph(0xf1c8)]
        SolidFileVideo = 1047,
        ///<summary>Solid Restroom</summary>
        ///<see href="https://fontawesome.com/icons/restroom?style=solid"/>
        [Description("Solid Restroom"), IconID("fas-restroom"), IconUnicodeGlyph(0xf7bd)]
        SolidRestroom = 1048,
        ///<summary>Solid Dice D6</summary>
        ///<see href="https://fontawesome.com/icons/dice-d6?style=solid"/>
        [Description("Solid Dice D6"), IconID("fas-dice-d6"), IconUnicodeGlyph(0xf6d1)]
        SolidDiceD6 = 1049,
        ///<summary>Solid Align Left</summary>
        ///<see href="https://fontawesome.com/icons/align-left?style=solid"/>
        [Description("Solid Align Left"), IconID("fas-align-left"), IconUnicodeGlyph(0xf036)]
        SolidAlignLeft = 1050,
        ///<summary>Solid Ruler</summary>
        ///<see href="https://fontawesome.com/icons/ruler?style=solid"/>
        [Description("Solid Ruler"), IconID("fas-ruler"), IconUnicodeGlyph(0xf545)]
        SolidRuler = 1051,
        ///<summary>Solid Arrow Left</summary>
        ///<see href="https://fontawesome.com/icons/arrow-left?style=solid"/>
        [Description("Solid Arrow Left"), IconID("fas-arrow-left"), IconUnicodeGlyph(0xf060)]
        SolidArrowLeft = 1052,
        ///<summary>Solid Republican</summary>
        ///<see href="https://fontawesome.com/icons/republican?style=solid"/>
        [Description("Solid Republican"), IconID("fas-republican"), IconUnicodeGlyph(0xf75e)]
        SolidRepublican = 1053,
        ///<summary>Solid Shield Alt</summary>
        ///<see href="https://fontawesome.com/icons/shield-alt?style=solid"/>
        [Description("Solid Shield Alt"), IconID("fas-shield-alt"), IconUnicodeGlyph(0xf3ed)]
        SolidShieldAlt = 1054,
        ///<summary>Solid Volume Up</summary>
        ///<see href="https://fontawesome.com/icons/volume-up?style=solid"/>
        [Description("Solid Volume Up"), IconID("fas-volume-up"), IconUnicodeGlyph(0xf028)]
        SolidVolumeUp = 1055,
        ///<summary>Solid Headphones</summary>
        ///<see href="https://fontawesome.com/icons/headphones?style=solid"/>
        [Description("Solid Headphones"), IconID("fas-headphones"), IconUnicodeGlyph(0xf025)]
        SolidHeadphones = 1056,
        ///<summary>Solid Divide</summary>
        ///<see href="https://fontawesome.com/icons/divide?style=solid"/>
        [Description("Solid Divide"), IconID("fas-divide"), IconUnicodeGlyph(0xf529)]
        SolidDivide = 1057,
        ///<summary>Solid Cubes</summary>
        ///<see href="https://fontawesome.com/icons/cubes?style=solid"/>
        [Description("Solid Cubes"), IconID("fas-cubes"), IconUnicodeGlyph(0xf1b3)]
        SolidCubes = 1058,
        ///<summary>Solid Quote Right</summary>
        ///<see href="https://fontawesome.com/icons/quote-right?style=solid"/>
        [Description("Solid Quote Right"), IconID("fas-quote-right"), IconUnicodeGlyph(0xf10e)]
        SolidQuoteRight = 1059,
        ///<summary>Solid Poo</summary>
        ///<see href="https://fontawesome.com/icons/poo?style=solid"/>
        [Description("Solid Poo"), IconID("fas-poo"), IconUnicodeGlyph(0xf2fe)]
        SolidPoo = 1060,
        ///<summary>Solid Book Medical</summary>
        ///<see href="https://fontawesome.com/icons/book-medical?style=solid"/>
        [Description("Solid Book Medical"), IconID("fas-book-medical"), IconUnicodeGlyph(0xf7e6)]
        SolidBookMedical = 1061,
        ///<summary>Solid Trash</summary>
        ///<see href="https://fontawesome.com/icons/trash?style=solid"/>
        [Description("Solid Trash"), IconID("fas-trash"), IconUnicodeGlyph(0xf1f8)]
        SolidTrash = 1062,
        ///<summary>Solid Id Card Alt</summary>
        ///<see href="https://fontawesome.com/icons/id-card-alt?style=solid"/>
        [Description("Solid Id Card Alt"), IconID("fas-id-card-alt"), IconUnicodeGlyph(0xf47f)]
        SolidIdCardAlt = 1063,
        ///<summary>Solid Pen Fancy</summary>
        ///<see href="https://fontawesome.com/icons/pen-fancy?style=solid"/>
        [Description("Solid Pen Fancy"), IconID("fas-pen-fancy"), IconUnicodeGlyph(0xf5ac)]
        SolidPenFancy = 1064,
        ///<summary>Solid Hat Wizard</summary>
        ///<see href="https://fontawesome.com/icons/hat-wizard?style=solid"/>
        [Description("Solid Hat Wizard"), IconID("fas-hat-wizard"), IconUnicodeGlyph(0xf6e8)]
        SolidHatWizard = 1065,
        ///<summary>Solid Text Width</summary>
        ///<see href="https://fontawesome.com/icons/text-width?style=solid"/>
        [Description("Solid Text Width"), IconID("fas-text-width"), IconUnicodeGlyph(0xf035)]
        SolidTextWidth = 1066,
        ///<summary>Solid Person Booth</summary>
        ///<see href="https://fontawesome.com/icons/person-booth?style=solid"/>
        [Description("Solid Person Booth"), IconID("fas-person-booth"), IconUnicodeGlyph(0xf756)]
        SolidPersonBooth = 1067,
        ///<summary>Solid Sort Alpha Down Alt</summary>
        ///<see href="https://fontawesome.com/icons/sort-alpha-down-alt?style=solid"/>
        [Description("Solid Sort Alpha Down Alt"), IconID("fas-sort-alpha-down-alt"), IconUnicodeGlyph(0xf881)]
        SolidSortAlphaDownAlt = 1068,
        ///<summary>Solid Pause Circle</summary>
        ///<see href="https://fontawesome.com/icons/pause-circle?style=solid"/>
        [Description("Solid Pause Circle"), IconID("fas-pause-circle"), IconUnicodeGlyph(0xf28b)]
        SolidPauseCircle = 1069,
        ///<summary>Solid Arrow Circle Down</summary>
        ///<see href="https://fontawesome.com/icons/arrow-circle-down?style=solid"/>
        [Description("Solid Arrow Circle Down"), IconID("fas-arrow-circle-down"), IconUnicodeGlyph(0xf0ab)]
        SolidArrowCircleDown = 1070,
        ///<summary>Solid Share Square</summary>
        ///<see href="https://fontawesome.com/icons/share-square?style=solid"/>
        [Description("Solid Share Square"), IconID("fas-share-square"), IconUnicodeGlyph(0xf14d)]
        SolidShareSquare = 1071,
        ///<summary>Solid Dice Six</summary>
        ///<see href="https://fontawesome.com/icons/dice-six?style=solid"/>
        [Description("Solid Dice Six"), IconID("fas-dice-six"), IconUnicodeGlyph(0xf526)]
        SolidDiceSix = 1072,
        ///<summary>Solid Shield Virus</summary>
        ///<see href="https://fontawesome.com/icons/shield-virus?style=solid"/>
        [Description("Solid Shield Virus"), IconID("fas-shield-virus"), IconUnicodeGlyph(0xe06c)]
        SolidShieldVirus = 1073,
        ///<summary>Solid Globe Americas</summary>
        ///<see href="https://fontawesome.com/icons/globe-americas?style=solid"/>
        [Description("Solid Globe Americas"), IconID("fas-globe-americas"), IconUnicodeGlyph(0xf57d)]
        SolidGlobeAmericas = 1074,
        ///<summary>Solid Door Closed</summary>
        ///<see href="https://fontawesome.com/icons/door-closed?style=solid"/>
        [Description("Solid Door Closed"), IconID("fas-door-closed"), IconUnicodeGlyph(0xf52a)]
        SolidDoorClosed = 1075,
        ///<summary>Solid Fire Alt</summary>
        ///<see href="https://fontawesome.com/icons/fire-alt?style=solid"/>
        [Description("Solid Fire Alt"), IconID("fas-fire-alt"), IconUnicodeGlyph(0xf7e4)]
        SolidFireAlt = 1076,
        ///<summary>Solid Head Side Virus</summary>
        ///<see href="https://fontawesome.com/icons/head-side-virus?style=solid"/>
        [Description("Solid Head Side Virus"), IconID("fas-head-side-virus"), IconUnicodeGlyph(0xe064)]
        SolidHeadSideVirus = 1077,
        ///<summary>Solid Headphones Alt</summary>
        ///<see href="https://fontawesome.com/icons/headphones-alt?style=solid"/>
        [Description("Solid Headphones Alt"), IconID("fas-headphones-alt"), IconUnicodeGlyph(0xf58f)]
        SolidHeadphonesAlt = 1078,
        ///<summary>Solid Hiking</summary>
        ///<see href="https://fontawesome.com/icons/hiking?style=solid"/>
        [Description("Solid Hiking"), IconID("fas-hiking"), IconUnicodeGlyph(0xf6ec)]
        SolidHiking = 1079,
        ///<summary>Solid Arrow Circle Right</summary>
        ///<see href="https://fontawesome.com/icons/arrow-circle-right?style=solid"/>
        [Description("Solid Arrow Circle Right"), IconID("fas-arrow-circle-right"), IconUnicodeGlyph(0xf0a9)]
        SolidArrowCircleRight = 1080,
        ///<summary>Solid Phone</summary>
        ///<see href="https://fontawesome.com/icons/phone?style=solid"/>
        [Description("Solid Phone"), IconID("fas-phone"), IconUnicodeGlyph(0xf095)]
        SolidPhone = 1081,
        ///<summary>Solid Grin Tongue</summary>
        ///<see href="https://fontawesome.com/icons/grin-tongue?style=solid"/>
        [Description("Solid Grin Tongue"), IconID("fas-grin-tongue"), IconUnicodeGlyph(0xf589)]
        SolidGrinTongue = 1082,
        ///<summary>Solid Lungs Virus</summary>
        ///<see href="https://fontawesome.com/icons/lungs-virus?style=solid"/>
        [Description("Solid Lungs Virus"), IconID("fas-lungs-virus"), IconUnicodeGlyph(0xe067)]
        SolidLungsVirus = 1083,
        ///<summary>Solid Mars Double</summary>
        ///<see href="https://fontawesome.com/icons/mars-double?style=solid"/>
        [Description("Solid Mars Double"), IconID("fas-mars-double"), IconUnicodeGlyph(0xf227)]
        SolidMarsDouble = 1084,
        ///<summary>Solid Th Large</summary>
        ///<see href="https://fontawesome.com/icons/th-large?style=solid"/>
        [Description("Solid Th Large"), IconID("fas-th-large"), IconUnicodeGlyph(0xf009)]
        SolidThLarge = 1085,
        ///<summary>Solid Biohazard</summary>
        ///<see href="https://fontawesome.com/icons/biohazard?style=solid"/>
        [Description("Solid Biohazard"), IconID("fas-biohazard"), IconUnicodeGlyph(0xf780)]
        SolidBiohazard = 1086,
        ///<summary>Solid Pencil Alt</summary>
        ///<see href="https://fontawesome.com/icons/pencil-alt?style=solid"/>
        [Description("Solid Pencil Alt"), IconID("fas-pencil-alt"), IconUnicodeGlyph(0xf303)]
        SolidPencilAlt = 1087,
        ///<summary>Solid Hand Scissors</summary>
        ///<see href="https://fontawesome.com/icons/hand-scissors?style=solid"/>
        [Description("Solid Hand Scissors"), IconID("fas-hand-scissors"), IconUnicodeGlyph(0xf257)]
        SolidHandScissors = 1088,
        ///<summary>Solid Thermometer Full</summary>
        ///<see href="https://fontawesome.com/icons/thermometer-full?style=solid"/>
        [Description("Solid Thermometer Full"), IconID("fas-thermometer-full"), IconUnicodeGlyph(0xf2c7)]
        SolidThermometerFull = 1089,
        ///<summary>Solid Drum Steelpan</summary>
        ///<see href="https://fontawesome.com/icons/drum-steelpan?style=solid"/>
        [Description("Solid Drum Steelpan"), IconID("fas-drum-steelpan"), IconUnicodeGlyph(0xf56a)]
        SolidDrumSteelpan = 1090,
        ///<summary>Solid Hand Pointer</summary>
        ///<see href="https://fontawesome.com/icons/hand-pointer?style=solid"/>
        [Description("Solid Hand Pointer"), IconID("fas-hand-pointer"), IconUnicodeGlyph(0xf25a)]
        SolidHandPointer = 1091,
        ///<summary>Solid Bacterium</summary>
        ///<see href="https://fontawesome.com/icons/bacterium?style=solid"/>
        [Description("Solid Bacterium"), IconID("fas-bacterium"), IconUnicodeGlyph(0xe05a)]
        SolidBacterium = 1092,
        ///<summary>Solid Comment Dots</summary>
        ///<see href="https://fontawesome.com/icons/comment-dots?style=solid"/>
        [Description("Solid Comment Dots"), IconID("fas-comment-dots"), IconUnicodeGlyph(0xf4ad)]
        SolidCommentDots = 1093,
        ///<summary>Solid Sort Up</summary>
        ///<see href="https://fontawesome.com/icons/sort-up?style=solid"/>
        [Description("Solid Sort Up"), IconID("fas-sort-up"), IconUnicodeGlyph(0xf0de)]
        SolidSortUp = 1094,
        ///<summary>Solid Vihara</summary>
        ///<see href="https://fontawesome.com/icons/vihara?style=solid"/>
        [Description("Solid Vihara"), IconID("fas-vihara"), IconUnicodeGlyph(0xf6a7)]
        SolidVihara = 1095,
        ///<summary>Solid Prescription</summary>
        ///<see href="https://fontawesome.com/icons/prescription?style=solid"/>
        [Description("Solid Prescription"), IconID("fas-prescription"), IconUnicodeGlyph(0xf5b1)]
        SolidPrescription = 1096,
        ///<summary>Solid Window Maximize</summary>
        ///<see href="https://fontawesome.com/icons/window-maximize?style=solid"/>
        [Description("Solid Window Maximize"), IconID("fas-window-maximize"), IconUnicodeGlyph(0xf2d0)]
        SolidWindowMaximize = 1097,
        ///<summary>Solid Bus</summary>
        ///<see href="https://fontawesome.com/icons/bus?style=solid"/>
        [Description("Solid Bus"), IconID("fas-bus"), IconUnicodeGlyph(0xf207)]
        SolidBus = 1098,
        ///<summary>Solid Beer</summary>
        ///<see href="https://fontawesome.com/icons/beer?style=solid"/>
        [Description("Solid Beer"), IconID("fas-beer"), IconUnicodeGlyph(0xf0fc)]
        SolidBeer = 1099,
        ///<summary>Solid Signal</summary>
        ///<see href="https://fontawesome.com/icons/signal?style=solid"/>
        [Description("Solid Signal"), IconID("fas-signal"), IconUnicodeGlyph(0xf012)]
        SolidSignal = 1100,
        ///<summary>Solid File Code</summary>
        ///<see href="https://fontawesome.com/icons/file-code?style=solid"/>
        [Description("Solid File Code"), IconID("fas-file-code"), IconUnicodeGlyph(0xf1c9)]
        SolidFileCode = 1101,
        ///<summary>Solid File Archive</summary>
        ///<see href="https://fontawesome.com/icons/file-archive?style=solid"/>
        [Description("Solid File Archive"), IconID("fas-file-archive"), IconUnicodeGlyph(0xf1c6)]
        SolidFileArchive = 1102,
        ///<summary>Solid Pen</summary>
        ///<see href="https://fontawesome.com/icons/pen?style=solid"/>
        [Description("Solid Pen"), IconID("fas-pen"), IconUnicodeGlyph(0xf304)]
        SolidPen = 1103,
        ///<summary>Solid User Slash</summary>
        ///<see href="https://fontawesome.com/icons/user-slash?style=solid"/>
        [Description("Solid User Slash"), IconID("fas-user-slash"), IconUnicodeGlyph(0xf506)]
        SolidUserSlash = 1104,
        ///<summary>Solid Audio Description</summary>
        ///<see href="https://fontawesome.com/icons/audio-description?style=solid"/>
        [Description("Solid Audio Description"), IconID("fas-audio-description"), IconUnicodeGlyph(0xf29e)]
        SolidAudioDescription = 1105,
        ///<summary>Solid Eye</summary>
        ///<see href="https://fontawesome.com/icons/eye?style=solid"/>
        [Description("Solid Eye"), IconID("fas-eye"), IconUnicodeGlyph(0xf06e)]
        SolidEye = 1106,
        ///<summary>Solid Tape</summary>
        ///<see href="https://fontawesome.com/icons/tape?style=solid"/>
        [Description("Solid Tape"), IconID("fas-tape"), IconUnicodeGlyph(0xf4db)]
        SolidTape = 1107,
        ///<summary>Solid Chalkboard Teacher</summary>
        ///<see href="https://fontawesome.com/icons/chalkboard-teacher?style=solid"/>
        [Description("Solid Chalkboard Teacher"), IconID("fas-chalkboard-teacher"), IconUnicodeGlyph(0xf51c)]
        SolidChalkboardTeacher = 1108,
        ///<summary>Solid Glass Cheers</summary>
        ///<see href="https://fontawesome.com/icons/glass-cheers?style=solid"/>
        [Description("Solid Glass Cheers"), IconID("fas-glass-cheers"), IconUnicodeGlyph(0xf79f)]
        SolidGlassCheers = 1109,
        ///<summary>Solid Terminal</summary>
        ///<see href="https://fontawesome.com/icons/terminal?style=solid"/>
        [Description("Solid Terminal"), IconID("fas-terminal"), IconUnicodeGlyph(0xf120)]
        SolidTerminal = 1110,
        ///<summary>Solid Sort Alpha Down</summary>
        ///<see href="https://fontawesome.com/icons/sort-alpha-down?style=solid"/>
        [Description("Solid Sort Alpha Down"), IconID("fas-sort-alpha-down"), IconUnicodeGlyph(0xf15d)]
        SolidSortAlphaDown = 1111,
        ///<summary>Solid Tachometer Alt</summary>
        ///<see href="https://fontawesome.com/icons/tachometer-alt?style=solid"/>
        [Description("Solid Tachometer Alt"), IconID("fas-tachometer-alt"), IconUnicodeGlyph(0xf3fd)]
        SolidTachometerAlt = 1112,
        ///<summary>Solid Wine Glass</summary>
        ///<see href="https://fontawesome.com/icons/wine-glass?style=solid"/>
        [Description("Solid Wine Glass"), IconID("fas-wine-glass"), IconUnicodeGlyph(0xf4e3)]
        SolidWineGlass = 1113,
        ///<summary>Solid Tags</summary>
        ///<see href="https://fontawesome.com/icons/tags?style=solid"/>
        [Description("Solid Tags"), IconID("fas-tags"), IconUnicodeGlyph(0xf02c)]
        SolidTags = 1114,
        ///<summary>Solid Caret Square Down</summary>
        ///<see href="https://fontawesome.com/icons/caret-square-down?style=solid"/>
        [Description("Solid Caret Square Down"), IconID("fas-caret-square-down"), IconUnicodeGlyph(0xf150)]
        SolidCaretSquareDown = 1115,
        ///<summary>Solid Teeth Open</summary>
        ///<see href="https://fontawesome.com/icons/teeth-open?style=solid"/>
        [Description("Solid Teeth Open"), IconID("fas-teeth-open"), IconUnicodeGlyph(0xf62f)]
        SolidTeethOpen = 1116,
        ///<summary>Solid Comment Medical</summary>
        ///<see href="https://fontawesome.com/icons/comment-medical?style=solid"/>
        [Description("Solid Comment Medical"), IconID("fas-comment-medical"), IconUnicodeGlyph(0xf7f5)]
        SolidCommentMedical = 1117,
        ///<summary>Solid Route</summary>
        ///<see href="https://fontawesome.com/icons/route?style=solid"/>
        [Description("Solid Route"), IconID("fas-route"), IconUnicodeGlyph(0xf4d7)]
        SolidRoute = 1118,
        ///<summary>Solid Band Aid</summary>
        ///<see href="https://fontawesome.com/icons/band-aid?style=solid"/>
        [Description("Solid Band Aid"), IconID("fas-band-aid"), IconUnicodeGlyph(0xf462)]
        SolidBandAid = 1119,
        ///<summary>Solid Cat</summary>
        ///<see href="https://fontawesome.com/icons/cat?style=solid"/>
        [Description("Solid Cat"), IconID("fas-cat"), IconUnicodeGlyph(0xf6be)]
        SolidCat = 1120,
        ///<summary>Solid Hat Cowboy</summary>
        ///<see href="https://fontawesome.com/icons/hat-cowboy?style=solid"/>
        [Description("Solid Hat Cowboy"), IconID("fas-hat-cowboy"), IconUnicodeGlyph(0xf8c0)]
        SolidHatCowboy = 1121,
        ///<summary>Solid Code Branch</summary>
        ///<see href="https://fontawesome.com/icons/code-branch?style=solid"/>
        [Description("Solid Code Branch"), IconID("fas-code-branch"), IconUnicodeGlyph(0xf126)]
        SolidCodeBranch = 1122,
        ///<summary>Solid Parking</summary>
        ///<see href="https://fontawesome.com/icons/parking?style=solid"/>
        [Description("Solid Parking"), IconID("fas-parking"), IconUnicodeGlyph(0xf540)]
        SolidParking = 1123,
        ///<summary>Solid Directions</summary>
        ///<see href="https://fontawesome.com/icons/directions?style=solid"/>
        [Description("Solid Directions"), IconID("fas-directions"), IconUnicodeGlyph(0xf5eb)]
        SolidDirections = 1124,
        ///<summary>Solid Handshake Slash</summary>
        ///<see href="https://fontawesome.com/icons/handshake-slash?style=solid"/>
        [Description("Solid Handshake Slash"), IconID("fas-handshake-slash"), IconUnicodeGlyph(0xe060)]
        SolidHandshakeSlash = 1125,
        ///<summary>Solid Plane Departure</summary>
        ///<see href="https://fontawesome.com/icons/plane-departure?style=solid"/>
        [Description("Solid Plane Departure"), IconID("fas-plane-departure"), IconUnicodeGlyph(0xf5b0)]
        SolidPlaneDeparture = 1126,
        ///<summary>Solid Tasks</summary>
        ///<see href="https://fontawesome.com/icons/tasks?style=solid"/>
        [Description("Solid Tasks"), IconID("fas-tasks"), IconUnicodeGlyph(0xf0ae)]
        SolidTasks = 1127,
        ///<summary>Solid File Image</summary>
        ///<see href="https://fontawesome.com/icons/file-image?style=solid"/>
        [Description("Solid File Image"), IconID("fas-file-image"), IconUnicodeGlyph(0xf1c5)]
        SolidFileImage = 1128,
        ///<summary>Solid Rupee Sign</summary>
        ///<see href="https://fontawesome.com/icons/rupee-sign?style=solid"/>
        [Description("Solid Rupee Sign"), IconID("fas-rupee-sign"), IconUnicodeGlyph(0xf156)]
        SolidRupeeSign = 1129,
        ///<summary>Solid Truck Loading</summary>
        ///<see href="https://fontawesome.com/icons/truck-loading?style=solid"/>
        [Description("Solid Truck Loading"), IconID("fas-truck-loading"), IconUnicodeGlyph(0xf4de)]
        SolidTruckLoading = 1130,
        ///<summary>Solid Wrench</summary>
        ///<see href="https://fontawesome.com/icons/wrench?style=solid"/>
        [Description("Solid Wrench"), IconID("fas-wrench"), IconUnicodeGlyph(0xf0ad)]
        SolidWrench = 1131,
        ///<summary>Solid Long Arrow Alt Up</summary>
        ///<see href="https://fontawesome.com/icons/long-arrow-alt-up?style=solid"/>
        [Description("Solid Long Arrow Alt Up"), IconID("fas-long-arrow-alt-up"), IconUnicodeGlyph(0xf30c)]
        SolidLongArrowAltUp = 1132,
        ///<summary>Solid Cloud Upload Alt</summary>
        ///<see href="https://fontawesome.com/icons/cloud-upload-alt?style=solid"/>
        [Description("Solid Cloud Upload Alt"), IconID("fas-cloud-upload-alt"), IconUnicodeGlyph(0xf382)]
        SolidCloudUploadAlt = 1133,
        ///<summary>Solid Luggage Cart</summary>
        ///<see href="https://fontawesome.com/icons/luggage-cart?style=solid"/>
        [Description("Solid Luggage Cart"), IconID("fas-luggage-cart"), IconUnicodeGlyph(0xf59d)]
        SolidLuggageCart = 1134,
        ///<summary>Solid File Audio</summary>
        ///<see href="https://fontawesome.com/icons/file-audio?style=solid"/>
        [Description("Solid File Audio"), IconID("fas-file-audio"), IconUnicodeGlyph(0xf1c7)]
        SolidFileAudio = 1135,
        ///<summary>Solid Clipboard Check</summary>
        ///<see href="https://fontawesome.com/icons/clipboard-check?style=solid"/>
        [Description("Solid Clipboard Check"), IconID("fas-clipboard-check"), IconUnicodeGlyph(0xf46c)]
        SolidClipboardCheck = 1136,
        ///<summary>Solid Wallet</summary>
        ///<see href="https://fontawesome.com/icons/wallet?style=solid"/>
        [Description("Solid Wallet"), IconID("fas-wallet"), IconUnicodeGlyph(0xf555)]
        SolidWallet = 1137,
        ///<summary>Solid Ellipsis H</summary>
        ///<see href="https://fontawesome.com/icons/ellipsis-h?style=solid"/>
        [Description("Solid Ellipsis H"), IconID("fas-ellipsis-h"), IconUnicodeGlyph(0xf141)]
        SolidEllipsisH = 1138,
        ///<summary>Solid Satellite Dish</summary>
        ///<see href="https://fontawesome.com/icons/satellite-dish?style=solid"/>
        [Description("Solid Satellite Dish"), IconID("fas-satellite-dish"), IconUnicodeGlyph(0xf7c0)]
        SolidSatelliteDish = 1139,
        ///<summary>Solid Trademark</summary>
        ///<see href="https://fontawesome.com/icons/trademark?style=solid"/>
        [Description("Solid Trademark"), IconID("fas-trademark"), IconUnicodeGlyph(0xf25c)]
        SolidTrademark = 1140,
        ///<summary>Solid Plane Slash</summary>
        ///<see href="https://fontawesome.com/icons/plane-slash?style=solid"/>
        [Description("Solid Plane Slash"), IconID("fas-plane-slash"), IconUnicodeGlyph(0xe069)]
        SolidPlaneSlash = 1141,
        ///<summary>Solid User Astronaut</summary>
        ///<see href="https://fontawesome.com/icons/user-astronaut?style=solid"/>
        [Description("Solid User Astronaut"), IconID("fas-user-astronaut"), IconUnicodeGlyph(0xf4fb)]
        SolidUserAstronaut = 1142,
        ///<summary>Solid Recycle</summary>
        ///<see href="https://fontawesome.com/icons/recycle?style=solid"/>
        [Description("Solid Recycle"), IconID("fas-recycle"), IconUnicodeGlyph(0xf1b8)]
        SolidRecycle = 1143,
        ///<summary>Solid User Edit</summary>
        ///<see href="https://fontawesome.com/icons/user-edit?style=solid"/>
        [Description("Solid User Edit"), IconID("fas-user-edit"), IconUnicodeGlyph(0xf4ff)]
        SolidUserEdit = 1144,
        ///<summary>Solid Circle</summary>
        ///<see href="https://fontawesome.com/icons/circle?style=solid"/>
        [Description("Solid Circle"), IconID("fas-circle"), IconUnicodeGlyph(0xf111)]
        SolidCircle = 1145,
        ///<summary>Solid Utensil Spoon</summary>
        ///<see href="https://fontawesome.com/icons/utensil-spoon?style=solid"/>
        [Description("Solid Utensil Spoon"), IconID("fas-utensil-spoon"), IconUnicodeGlyph(0xf2e5)]
        SolidUtensilSpoon = 1146,
        ///<summary>Solid Hands Helping</summary>
        ///<see href="https://fontawesome.com/icons/hands-helping?style=solid"/>
        [Description("Solid Hands Helping"), IconID("fas-hands-helping"), IconUnicodeGlyph(0xf4c4)]
        SolidHandsHelping = 1147,
        ///<summary>Solid Lock Open</summary>
        ///<see href="https://fontawesome.com/icons/lock-open?style=solid"/>
        [Description("Solid Lock Open"), IconID("fas-lock-open"), IconUnicodeGlyph(0xf3c1)]
        SolidLockOpen = 1148,
        ///<summary>Solid Solar Panel</summary>
        ///<see href="https://fontawesome.com/icons/solar-panel?style=solid"/>
        [Description("Solid Solar Panel"), IconID("fas-solar-panel"), IconUnicodeGlyph(0xf5ba)]
        SolidSolarPanel = 1149,
        ///<summary>Solid Cube</summary>
        ///<see href="https://fontawesome.com/icons/cube?style=solid"/>
        [Description("Solid Cube"), IconID("fas-cube"), IconUnicodeGlyph(0xf1b2)]
        SolidCube = 1150,
        ///<summary>Solid Female</summary>
        ///<see href="https://fontawesome.com/icons/female?style=solid"/>
        [Description("Solid Female"), IconID("fas-female"), IconUnicodeGlyph(0xf182)]
        SolidFemale = 1151,
        ///<summary>Solid Toilet Paper Slash</summary>
        ///<see href="https://fontawesome.com/icons/toilet-paper-slash?style=solid"/>
        [Description("Solid Toilet Paper Slash"), IconID("fas-toilet-paper-slash"), IconUnicodeGlyph(0xe072)]
        SolidToiletPaperSlash = 1152,
        ///<summary>Solid Dumpster Fire</summary>
        ///<see href="https://fontawesome.com/icons/dumpster-fire?style=solid"/>
        [Description("Solid Dumpster Fire"), IconID("fas-dumpster-fire"), IconUnicodeGlyph(0xf794)]
        SolidDumpsterFire = 1153,
        ///<summary>Solid House User</summary>
        ///<see href="https://fontawesome.com/icons/house-user?style=solid"/>
        [Description("Solid House User"), IconID("fas-house-user"), IconUnicodeGlyph(0xe065)]
        SolidHouseUser = 1154,
        ///<summary>Solid Heart</summary>
        ///<see href="https://fontawesome.com/icons/heart?style=solid"/>
        [Description("Solid Heart"), IconID("fas-heart"), IconUnicodeGlyph(0xf004)]
        SolidHeart = 1155,
        ///<summary>Solid Hand Rock</summary>
        ///<see href="https://fontawesome.com/icons/hand-rock?style=solid"/>
        [Description("Solid Hand Rock"), IconID("fas-hand-rock"), IconUnicodeGlyph(0xf255)]
        SolidHandRock = 1156,
        ///<summary>Solid User Cog</summary>
        ///<see href="https://fontawesome.com/icons/user-cog?style=solid"/>
        [Description("Solid User Cog"), IconID("fas-user-cog"), IconUnicodeGlyph(0xf4fe)]
        SolidUserCog = 1157,
        ///<summary>Solid Globe Asia</summary>
        ///<see href="https://fontawesome.com/icons/globe-asia?style=solid"/>
        [Description("Solid Globe Asia"), IconID("fas-globe-asia"), IconUnicodeGlyph(0xf57e)]
        SolidGlobeAsia = 1158,
        ///<summary>Solid Cash Register</summary>
        ///<see href="https://fontawesome.com/icons/cash-register?style=solid"/>
        [Description("Solid Cash Register"), IconID("fas-cash-register"), IconUnicodeGlyph(0xf788)]
        SolidCashRegister = 1159,
        ///<summary>Solid Arrow Right</summary>
        ///<see href="https://fontawesome.com/icons/arrow-right?style=solid"/>
        [Description("Solid Arrow Right"), IconID("fas-arrow-right"), IconUnicodeGlyph(0xf061)]
        SolidArrowRight = 1160,
        ///<summary>Solid Chart Line</summary>
        ///<see href="https://fontawesome.com/icons/chart-line?style=solid"/>
        [Description("Solid Chart Line"), IconID("fas-chart-line"), IconUnicodeGlyph(0xf201)]
        SolidChartLine = 1161,
        ///<summary>Solid Object Group</summary>
        ///<see href="https://fontawesome.com/icons/object-group?style=solid"/>
        [Description("Solid Object Group"), IconID("fas-object-group"), IconUnicodeGlyph(0xf247)]
        SolidObjectGroup = 1162,
        ///<summary>Solid Eject</summary>
        ///<see href="https://fontawesome.com/icons/eject?style=solid"/>
        [Description("Solid Eject"), IconID("fas-eject"), IconUnicodeGlyph(0xf052)]
        SolidEject = 1163,
        ///<summary>Solid Dolly Flatbed</summary>
        ///<see href="https://fontawesome.com/icons/dolly-flatbed?style=solid"/>
        [Description("Solid Dolly Flatbed"), IconID("fas-dolly-flatbed"), IconUnicodeGlyph(0xf474)]
        SolidDollyFlatbed = 1164,
        ///<summary>Solid Toilet Paper</summary>
        ///<see href="https://fontawesome.com/icons/toilet-paper?style=solid"/>
        [Description("Solid Toilet Paper"), IconID("fas-toilet-paper"), IconUnicodeGlyph(0xf71e)]
        SolidToiletPaper = 1165,
        ///<summary>Solid Kaaba</summary>
        ///<see href="https://fontawesome.com/icons/kaaba?style=solid"/>
        [Description("Solid Kaaba"), IconID("fas-kaaba"), IconUnicodeGlyph(0xf66b)]
        SolidKaaba = 1166,
        ///<summary>Solid Poop</summary>
        ///<see href="https://fontawesome.com/icons/poop?style=solid"/>
        [Description("Solid Poop"), IconID("fas-poop"), IconUnicodeGlyph(0xf619)]
        SolidPoop = 1167,
        ///<summary>Solid Object Ungroup</summary>
        ///<see href="https://fontawesome.com/icons/object-ungroup?style=solid"/>
        [Description("Solid Object Ungroup"), IconID("fas-object-ungroup"), IconUnicodeGlyph(0xf248)]
        SolidObjectUngroup = 1168,
        ///<summary>Solid File Contract</summary>
        ///<see href="https://fontawesome.com/icons/file-contract?style=solid"/>
        [Description("Solid File Contract"), IconID("fas-file-contract"), IconUnicodeGlyph(0xf56c)]
        SolidFileContract = 1169,
        ///<summary>Solid File Excel</summary>
        ///<see href="https://fontawesome.com/icons/file-excel?style=solid"/>
        [Description("Solid File Excel"), IconID("fas-file-excel"), IconUnicodeGlyph(0xf1c3)]
        SolidFileExcel = 1170,
        ///<summary>Solid Shopping Bag</summary>
        ///<see href="https://fontawesome.com/icons/shopping-bag?style=solid"/>
        [Description("Solid Shopping Bag"), IconID("fas-shopping-bag"), IconUnicodeGlyph(0xf290)]
        SolidShoppingBag = 1171,
        ///<summary>Solid File Upload</summary>
        ///<see href="https://fontawesome.com/icons/file-upload?style=solid"/>
        [Description("Solid File Upload"), IconID("fas-file-upload"), IconUnicodeGlyph(0xf574)]
        SolidFileUpload = 1172,
        ///<summary>Solid Radiation Alt</summary>
        ///<see href="https://fontawesome.com/icons/radiation-alt?style=solid"/>
        [Description("Solid Radiation Alt"), IconID("fas-radiation-alt"), IconUnicodeGlyph(0xf7ba)]
        SolidRadiationAlt = 1173,
        ///<summary>Solid Chart Pie</summary>
        ///<see href="https://fontawesome.com/icons/chart-pie?style=solid"/>
        [Description("Solid Chart Pie"), IconID("fas-chart-pie"), IconUnicodeGlyph(0xf200)]
        SolidChartPie = 1174,
        ///<summary>Solid Taxi</summary>
        ///<see href="https://fontawesome.com/icons/taxi?style=solid"/>
        [Description("Solid Taxi"), IconID("fas-taxi"), IconUnicodeGlyph(0xf1ba)]
        SolidTaxi = 1175,
        ///<summary>Solid Road</summary>
        ///<see href="https://fontawesome.com/icons/road?style=solid"/>
        [Description("Solid Road"), IconID("fas-road"), IconUnicodeGlyph(0xf018)]
        SolidRoad = 1176,
        ///<summary>Solid Leaf</summary>
        ///<see href="https://fontawesome.com/icons/leaf?style=solid"/>
        [Description("Solid Leaf"), IconID("fas-leaf"), IconUnicodeGlyph(0xf06c)]
        SolidLeaf = 1177,
        ///<summary>Solid Table Tennis</summary>
        ///<see href="https://fontawesome.com/icons/table-tennis?style=solid"/>
        [Description("Solid Table Tennis"), IconID("fas-table-tennis"), IconUnicodeGlyph(0xf45d)]
        SolidTableTennis = 1178,
        ///<summary>Solid Sliders H</summary>
        ///<see href="https://fontawesome.com/icons/sliders-h?style=solid"/>
        [Description("Solid Sliders H"), IconID("fas-sliders-h"), IconUnicodeGlyph(0xf1de)]
        SolidSlidersH = 1179,
        ///<summary>Solid Won Sign</summary>
        ///<see href="https://fontawesome.com/icons/won-sign?style=solid"/>
        [Description("Solid Won Sign"), IconID("fas-won-sign"), IconUnicodeGlyph(0xf159)]
        SolidWonSign = 1180,
        ///<summary>Solid Code</summary>
        ///<see href="https://fontawesome.com/icons/code?style=solid"/>
        [Description("Solid Code"), IconID("fas-code"), IconUnicodeGlyph(0xf121)]
        SolidCode = 1181,
        ///<summary>Solid Money Check</summary>
        ///<see href="https://fontawesome.com/icons/money-check?style=solid"/>
        [Description("Solid Money Check"), IconID("fas-money-check"), IconUnicodeGlyph(0xf53c)]
        SolidMoneyCheck = 1182,
        ///<summary>Solid Puzzle Piece</summary>
        ///<see href="https://fontawesome.com/icons/puzzle-piece?style=solid"/>
        [Description("Solid Puzzle Piece"), IconID("fas-puzzle-piece"), IconUnicodeGlyph(0xf12e)]
        SolidPuzzlePiece = 1183,
        ///<summary>Solid Hand Holding Heart</summary>
        ///<see href="https://fontawesome.com/icons/hand-holding-heart?style=solid"/>
        [Description("Solid Hand Holding Heart"), IconID("fas-hand-holding-heart"), IconUnicodeGlyph(0xf4be)]
        SolidHandHoldingHeart = 1184,
        ///<summary>Solid Torah</summary>
        ///<see href="https://fontawesome.com/icons/torah?style=solid"/>
        [Description("Solid Torah"), IconID("fas-torah"), IconUnicodeGlyph(0xf6a0)]
        SolidTorah = 1185,
        ///<summary>Solid File Medical Alt</summary>
        ///<see href="https://fontawesome.com/icons/file-medical-alt?style=solid"/>
        [Description("Solid File Medical Alt"), IconID("fas-file-medical-alt"), IconUnicodeGlyph(0xf478)]
        SolidFileMedicalAlt = 1186,
        ///<summary>Solid File Signature</summary>
        ///<see href="https://fontawesome.com/icons/file-signature?style=solid"/>
        [Description("Solid File Signature"), IconID("fas-file-signature"), IconUnicodeGlyph(0xf573)]
        SolidFileSignature = 1187,
        ///<summary>Solid Question</summary>
        ///<see href="https://fontawesome.com/icons/question?style=solid"/>
        [Description("Solid Question"), IconID("fas-question"), IconUnicodeGlyph(0xf128)]
        SolidQuestion = 1188,
        ///<summary>Solid Filter</summary>
        ///<see href="https://fontawesome.com/icons/filter?style=solid"/>
        [Description("Solid Filter"), IconID("fas-filter"), IconUnicodeGlyph(0xf0b0)]
        SolidFilter = 1189,
        ///<summary>Solid Language</summary>
        ///<see href="https://fontawesome.com/icons/language?style=solid"/>
        [Description("Solid Language"), IconID("fas-language"), IconUnicodeGlyph(0xf1ab)]
        SolidLanguage = 1190,
        ///<summary>Solid Bread Slice</summary>
        ///<see href="https://fontawesome.com/icons/bread-slice?style=solid"/>
        [Description("Solid Bread Slice"), IconID("fas-bread-slice"), IconUnicodeGlyph(0xf7ec)]
        SolidBreadSlice = 1191,
        ///<summary>Solid Vector Square</summary>
        ///<see href="https://fontawesome.com/icons/vector-square?style=solid"/>
        [Description("Solid Vector Square"), IconID("fas-vector-square"), IconUnicodeGlyph(0xf5cb)]
        SolidVectorSquare = 1192,
        ///<summary>Solid List Ol</summary>
        ///<see href="https://fontawesome.com/icons/list-ol?style=solid"/>
        [Description("Solid List Ol"), IconID("fas-list-ol"), IconUnicodeGlyph(0xf0cb)]
        SolidListOl = 1193,
        ///<summary>Solid Sort</summary>
        ///<see href="https://fontawesome.com/icons/sort?style=solid"/>
        [Description("Solid Sort"), IconID("fas-sort"), IconUnicodeGlyph(0xf0dc)]
        SolidSort = 1194,
        ///<summary>Solid Car Crash</summary>
        ///<see href="https://fontawesome.com/icons/car-crash?style=solid"/>
        [Description("Solid Car Crash"), IconID("fas-car-crash"), IconUnicodeGlyph(0xf5e1)]
        SolidCarCrash = 1195,
        ///<summary>Solid Grin Squint</summary>
        ///<see href="https://fontawesome.com/icons/grin-squint?style=solid"/>
        [Description("Solid Grin Squint"), IconID("fas-grin-squint"), IconUnicodeGlyph(0xf585)]
        SolidGrinSquint = 1196,
        ///<summary>Solid Newspaper</summary>
        ///<see href="https://fontawesome.com/icons/newspaper?style=solid"/>
        [Description("Solid Newspaper"), IconID("fas-newspaper"), IconUnicodeGlyph(0xf1ea)]
        SolidNewspaper = 1197,
        ///<summary>Solid List Alt</summary>
        ///<see href="https://fontawesome.com/icons/list-alt?style=solid"/>
        [Description("Solid List Alt"), IconID("fas-list-alt"), IconUnicodeGlyph(0xf022)]
        SolidListAlt = 1198,
        ///<summary>Solid Snowflake</summary>
        ///<see href="https://fontawesome.com/icons/snowflake?style=solid"/>
        [Description("Solid Snowflake"), IconID("fas-snowflake"), IconUnicodeGlyph(0xf2dc)]
        SolidSnowflake = 1199,
        ///<summary>Solid Democrat</summary>
        ///<see href="https://fontawesome.com/icons/democrat?style=solid"/>
        [Description("Solid Democrat"), IconID("fas-democrat"), IconUnicodeGlyph(0xf747)]
        SolidDemocrat = 1200,
        ///<summary>Solid Comments Dollar</summary>
        ///<see href="https://fontawesome.com/icons/comments-dollar?style=solid"/>
        [Description("Solid Comments Dollar"), IconID("fas-comments-dollar"), IconUnicodeGlyph(0xf653)]
        SolidCommentsDollar = 1201,
        ///<summary>Solid Church</summary>
        ///<see href="https://fontawesome.com/icons/church?style=solid"/>
        [Description("Solid Church"), IconID("fas-church"), IconUnicodeGlyph(0xf51d)]
        SolidChurch = 1202,
        ///<summary>Solid Italic</summary>
        ///<see href="https://fontawesome.com/icons/italic?style=solid"/>
        [Description("Solid Italic"), IconID("fas-italic"), IconUnicodeGlyph(0xf033)]
        SolidItalic = 1203,
        ///<summary>Solid Couch</summary>
        ///<see href="https://fontawesome.com/icons/couch?style=solid"/>
        [Description("Solid Couch"), IconID("fas-couch"), IconUnicodeGlyph(0xf4b8)]
        SolidCouch = 1204,
        ///<summary>Solid Tools</summary>
        ///<see href="https://fontawesome.com/icons/tools?style=solid"/>
        [Description("Solid Tools"), IconID("fas-tools"), IconUnicodeGlyph(0xf7d9)]
        SolidTools = 1205,
        ///<summary>Solid Angle Double Left</summary>
        ///<see href="https://fontawesome.com/icons/angle-double-left?style=solid"/>
        [Description("Solid Angle Double Left"), IconID("fas-angle-double-left"), IconUnicodeGlyph(0xf100)]
        SolidAngleDoubleLeft = 1206,
        ///<summary>Solid Save</summary>
        ///<see href="https://fontawesome.com/icons/save?style=solid"/>
        [Description("Solid Save"), IconID("fas-save"), IconUnicodeGlyph(0xf0c7)]
        SolidSave = 1207,
        ///<summary>Solid Square</summary>
        ///<see href="https://fontawesome.com/icons/square?style=solid"/>
        [Description("Solid Square"), IconID("fas-square"), IconUnicodeGlyph(0xf0c8)]
        SolidSquare = 1208,
        ///<summary>Solid Archway</summary>
        ///<see href="https://fontawesome.com/icons/archway?style=solid"/>
        [Description("Solid Archway"), IconID("fas-archway"), IconUnicodeGlyph(0xf557)]
        SolidArchway = 1209,
        ///<summary>Solid Layer Group</summary>
        ///<see href="https://fontawesome.com/icons/layer-group?style=solid"/>
        [Description("Solid Layer Group"), IconID("fas-layer-group"), IconUnicodeGlyph(0xf5fd)]
        SolidLayerGroup = 1210,
        ///<summary>Solid Book Dead</summary>
        ///<see href="https://fontawesome.com/icons/book-dead?style=solid"/>
        [Description("Solid Book Dead"), IconID("fas-book-dead"), IconUnicodeGlyph(0xf6b7)]
        SolidBookDead = 1211,
        ///<summary>Solid Virus</summary>
        ///<see href="https://fontawesome.com/icons/virus?style=solid"/>
        [Description("Solid Virus"), IconID("fas-virus"), IconUnicodeGlyph(0xe074)]
        SolidVirus = 1212,
        ///<summary>Solid Greater Than Equal</summary>
        ///<see href="https://fontawesome.com/icons/greater-than-equal?style=solid"/>
        [Description("Solid Greater Than Equal"), IconID("fas-greater-than-equal"), IconUnicodeGlyph(0xf532)]
        SolidGreaterThanEqual = 1213,
        ///<summary>Solid Biking</summary>
        ///<see href="https://fontawesome.com/icons/biking?style=solid"/>
        [Description("Solid Biking"), IconID("fas-biking"), IconUnicodeGlyph(0xf84a)]
        SolidBiking = 1214,
        ///<summary>Solid Fire Extinguisher</summary>
        ///<see href="https://fontawesome.com/icons/fire-extinguisher?style=solid"/>
        [Description("Solid Fire Extinguisher"), IconID("fas-fire-extinguisher"), IconUnicodeGlyph(0xf134)]
        SolidFireExtinguisher = 1215,
        ///<summary>Solid Long Arrow Alt Right</summary>
        ///<see href="https://fontawesome.com/icons/long-arrow-alt-right?style=solid"/>
        [Description("Solid Long Arrow Alt Right"), IconID("fas-long-arrow-alt-right"), IconUnicodeGlyph(0xf30b)]
        SolidLongArrowAltRight = 1216,
        ///<summary>Solid Envelope Open</summary>
        ///<see href="https://fontawesome.com/icons/envelope-open?style=solid"/>
        [Description("Solid Envelope Open"), IconID("fas-envelope-open"), IconUnicodeGlyph(0xf2b6)]
        SolidEnvelopeOpen = 1217,
        ///<summary>Solid Chalkboard</summary>
        ///<see href="https://fontawesome.com/icons/chalkboard?style=solid"/>
        [Description("Solid Chalkboard"), IconID("fas-chalkboard"), IconUnicodeGlyph(0xf51b)]
        SolidChalkboard = 1218,
        ///<summary>Solid File Powerpoint</summary>
        ///<see href="https://fontawesome.com/icons/file-powerpoint?style=solid"/>
        [Description("Solid File Powerpoint"), IconID("fas-file-powerpoint"), IconUnicodeGlyph(0xf1c4)]
        SolidFilePowerpoint = 1219,
        ///<summary>Solid File Word</summary>
        ///<see href="https://fontawesome.com/icons/file-word?style=solid"/>
        [Description("Solid File Word"), IconID("fas-file-word"), IconUnicodeGlyph(0xf1c2)]
        SolidFileWord = 1220,
        ///<summary>Solid Th List</summary>
        ///<see href="https://fontawesome.com/icons/th-list?style=solid"/>
        [Description("Solid Th List"), IconID("fas-th-list"), IconUnicodeGlyph(0xf00b)]
        SolidThList = 1221,
        ///<summary>Solid Candy Cane</summary>
        ///<see href="https://fontawesome.com/icons/candy-cane?style=solid"/>
        [Description("Solid Candy Cane"), IconID("fas-candy-cane"), IconUnicodeGlyph(0xf786)]
        SolidCandyCane = 1222,
        ///<summary>Solid File Alt</summary>
        ///<see href="https://fontawesome.com/icons/file-alt?style=solid"/>
        [Description("Solid File Alt"), IconID("fas-file-alt"), IconUnicodeGlyph(0xf15c)]
        SolidFileAlt = 1223,
        ///<summary>Solid Check Circle</summary>
        ///<see href="https://fontawesome.com/icons/check-circle?style=solid"/>
        [Description("Solid Check Circle"), IconID("fas-check-circle"), IconUnicodeGlyph(0xf058)]
        SolidCheckCircle = 1224,
        ///<summary>Solid Seedling</summary>
        ///<see href="https://fontawesome.com/icons/seedling?style=solid"/>
        [Description("Solid Seedling"), IconID("fas-seedling"), IconUnicodeGlyph(0xf4d8)]
        SolidSeedling = 1225,
        ///<summary>Solid Vest</summary>
        ///<see href="https://fontawesome.com/icons/vest?style=solid"/>
        [Description("Solid Vest"), IconID("fas-vest"), IconUnicodeGlyph(0xe085)]
        SolidVest = 1226,
        ///<summary>Solid Palette</summary>
        ///<see href="https://fontawesome.com/icons/palette?style=solid"/>
        [Description("Solid Palette"), IconID("fas-palette"), IconUnicodeGlyph(0xf53f)]
        SolidPalette = 1227,
        ///<summary>Solid Grip Horizontal</summary>
        ///<see href="https://fontawesome.com/icons/grip-horizontal?style=solid"/>
        [Description("Solid Grip Horizontal"), IconID("fas-grip-horizontal"), IconUnicodeGlyph(0xf58d)]
        SolidGripHorizontal = 1228,
        ///<summary>Solid Crutch</summary>
        ///<see href="https://fontawesome.com/icons/crutch?style=solid"/>
        [Description("Solid Crutch"), IconID("fas-crutch"), IconUnicodeGlyph(0xf7f7)]
        SolidCrutch = 1229,
        ///<summary>Solid Balance Scale Left</summary>
        ///<see href="https://fontawesome.com/icons/balance-scale-left?style=solid"/>
        [Description("Solid Balance Scale Left"), IconID("fas-balance-scale-left"), IconUnicodeGlyph(0xf515)]
        SolidBalanceScaleLeft = 1230,
        ///<summary>Solid Smog</summary>
        ///<see href="https://fontawesome.com/icons/smog?style=solid"/>
        [Description("Solid Smog"), IconID("fas-smog"), IconUnicodeGlyph(0xf75f)]
        SolidSmog = 1231,
        ///<summary>Solid Subscript</summary>
        ///<see href="https://fontawesome.com/icons/subscript?style=solid"/>
        [Description("Solid Subscript"), IconID("fas-subscript"), IconUnicodeGlyph(0xf12c)]
        SolidSubscript = 1232,
        ///<summary>Solid Address Card</summary>
        ///<see href="https://fontawesome.com/icons/address-card?style=solid"/>
        [Description("Solid Address Card"), IconID("fas-address-card"), IconUnicodeGlyph(0xf2bb)]
        SolidAddressCard = 1233,
        ///<summary>Solid Registered</summary>
        ///<see href="https://fontawesome.com/icons/registered?style=solid"/>
        [Description("Solid Registered"), IconID("fas-registered"), IconUnicodeGlyph(0xf25d)]
        SolidRegistered = 1234,
        ///<summary>Solid Bomb</summary>
        ///<see href="https://fontawesome.com/icons/bomb?style=solid"/>
        [Description("Solid Bomb"), IconID("fas-bomb"), IconUnicodeGlyph(0xf1e2)]
        SolidBomb = 1235,
        ///<summary>Solid Money Check Alt</summary>
        ///<see href="https://fontawesome.com/icons/money-check-alt?style=solid"/>
        [Description("Solid Money Check Alt"), IconID("fas-money-check-alt"), IconUnicodeGlyph(0xf53d)]
        SolidMoneyCheckAlt = 1236,
        ///<summary>Solid Pause</summary>
        ///<see href="https://fontawesome.com/icons/pause?style=solid"/>
        [Description("Solid Pause"), IconID("fas-pause"), IconUnicodeGlyph(0xf04c)]
        SolidPause = 1237,
        ///<summary>Solid Spa</summary>
        ///<see href="https://fontawesome.com/icons/spa?style=solid"/>
        [Description("Solid Spa"), IconID("fas-spa"), IconUnicodeGlyph(0xf5bb)]
        SolidSpa = 1238,
        ///<summary>Solid Scroll</summary>
        ///<see href="https://fontawesome.com/icons/scroll?style=solid"/>
        [Description("Solid Scroll"), IconID("fas-scroll"), IconUnicodeGlyph(0xf70e)]
        SolidScroll = 1239,
        ///<summary>Solid Box Open</summary>
        ///<see href="https://fontawesome.com/icons/box-open?style=solid"/>
        [Description("Solid Box Open"), IconID("fas-box-open"), IconUnicodeGlyph(0xf49e)]
        SolidBoxOpen = 1240,
        ///<summary>Solid Ellipsis V</summary>
        ///<see href="https://fontawesome.com/icons/ellipsis-v?style=solid"/>
        [Description("Solid Ellipsis V"), IconID("fas-ellipsis-v"), IconUnicodeGlyph(0xf142)]
        SolidEllipsisV = 1241,
        ///<summary>Solid Grin Tongue Wink</summary>
        ///<see href="https://fontawesome.com/icons/grin-tongue-wink?style=solid"/>
        [Description("Solid Grin Tongue Wink"), IconID("fas-grin-tongue-wink"), IconUnicodeGlyph(0xf58b)]
        SolidGrinTongueWink = 1242,
        ///<summary>Solid File Import</summary>
        ///<see href="https://fontawesome.com/icons/file-import?style=solid"/>
        [Description("Solid File Import"), IconID("fas-file-import"), IconUnicodeGlyph(0xf56f)]
        SolidFileImport = 1243,
        ///<summary>Solid Arrow Alt Circle Left</summary>
        ///<see href="https://fontawesome.com/icons/arrow-alt-circle-left?style=solid"/>
        [Description("Solid Arrow Alt Circle Left"), IconID("fas-arrow-alt-circle-left"), IconUnicodeGlyph(0xf359)]
        SolidArrowAltCircleLeft = 1244,
        ///<summary>Solid Camera Retro</summary>
        ///<see href="https://fontawesome.com/icons/camera-retro?style=solid"/>
        [Description("Solid Camera Retro"), IconID("fas-camera-retro"), IconUnicodeGlyph(0xf083)]
        SolidCameraRetro = 1245,
        ///<summary>Solid Suitcase</summary>
        ///<see href="https://fontawesome.com/icons/suitcase?style=solid"/>
        [Description("Solid Suitcase"), IconID("fas-suitcase"), IconUnicodeGlyph(0xf0f2)]
        SolidSuitcase = 1246,
        ///<summary>Solid Reply All</summary>
        ///<see href="https://fontawesome.com/icons/reply-all?style=solid"/>
        [Description("Solid Reply All"), IconID("fas-reply-all"), IconUnicodeGlyph(0xf122)]
        SolidReplyAll = 1247,
        ///<summary>Solid Certificate</summary>
        ///<see href="https://fontawesome.com/icons/certificate?style=solid"/>
        [Description("Solid Certificate"), IconID("fas-certificate"), IconUnicodeGlyph(0xf0a3)]
        SolidCertificate = 1248,
        ///<summary>Solid User Tie</summary>
        ///<see href="https://fontawesome.com/icons/user-tie?style=solid"/>
        [Description("Solid User Tie"), IconID("fas-user-tie"), IconUnicodeGlyph(0xf508)]
        SolidUserTie = 1249,
        ///<summary>Solid Map Marked</summary>
        ///<see href="https://fontawesome.com/icons/map-marked?style=solid"/>
        [Description("Solid Map Marked"), IconID("fas-map-marked"), IconUnicodeGlyph(0xf59f)]
        SolidMapMarked = 1250,
        ///<summary>Solid Viruses</summary>
        ///<see href="https://fontawesome.com/icons/viruses?style=solid"/>
        [Description("Solid Viruses"), IconID("fas-viruses"), IconUnicodeGlyph(0xe076)]
        SolidViruses = 1251,
        ///<summary>Solid Angle Double Up</summary>
        ///<see href="https://fontawesome.com/icons/angle-double-up?style=solid"/>
        [Description("Solid Angle Double Up"), IconID("fas-angle-double-up"), IconUnicodeGlyph(0xf102)]
        SolidAngleDoubleUp = 1252,
        ///<summary>Solid Universal Access</summary>
        ///<see href="https://fontawesome.com/icons/universal-access?style=solid"/>
        [Description("Solid Universal Access"), IconID("fas-universal-access"), IconUnicodeGlyph(0xf29a)]
        SolidUniversalAccess = 1253,
        ///<summary>Solid Search Dollar</summary>
        ///<see href="https://fontawesome.com/icons/search-dollar?style=solid"/>
        [Description("Solid Search Dollar"), IconID("fas-search-dollar"), IconUnicodeGlyph(0xf688)]
        SolidSearchDollar = 1254,
        ///<summary>Solid Marker</summary>
        ///<see href="https://fontawesome.com/icons/marker?style=solid"/>
        [Description("Solid Marker"), IconID("fas-marker"), IconUnicodeGlyph(0xf5a1)]
        SolidMarker = 1255,
        ///<summary>Solid Id Badge</summary>
        ///<see href="https://fontawesome.com/icons/id-badge?style=solid"/>
        [Description("Solid Id Badge"), IconID("fas-id-badge"), IconUnicodeGlyph(0xf2c1)]
        SolidIdBadge = 1256,
        ///<summary>Solid Neuter</summary>
        ///<see href="https://fontawesome.com/icons/neuter?style=solid"/>
        [Description("Solid Neuter"), IconID("fas-neuter"), IconUnicodeGlyph(0xf22c)]
        SolidNeuter = 1257,
        ///<summary>Solid Icicles</summary>
        ///<see href="https://fontawesome.com/icons/icicles?style=solid"/>
        [Description("Solid Icicles"), IconID("fas-icicles"), IconUnicodeGlyph(0xf7ad)]
        SolidIcicles = 1258,
        ///<summary>Solid Expand Arrows Alt</summary>
        ///<see href="https://fontawesome.com/icons/expand-arrows-alt?style=solid"/>
        [Description("Solid Expand Arrows Alt"), IconID("fas-expand-arrows-alt"), IconUnicodeGlyph(0xf31e)]
        SolidExpandArrowsAlt = 1259,
        ///<summary>Solid Chair</summary>
        ///<see href="https://fontawesome.com/icons/chair?style=solid"/>
        [Description("Solid Chair"), IconID("fas-chair"), IconUnicodeGlyph(0xf6c0)]
        SolidChair = 1260,
        ///<summary>Solid Euro Sign</summary>
        ///<see href="https://fontawesome.com/icons/euro-sign?style=solid"/>
        [Description("Solid Euro Sign"), IconID("fas-euro-sign"), IconUnicodeGlyph(0xf153)]
        SolidEuroSign = 1261,
        ///<summary>Solid Ethernet</summary>
        ///<see href="https://fontawesome.com/icons/ethernet?style=solid"/>
        [Description("Solid Ethernet"), IconID("fas-ethernet"), IconUnicodeGlyph(0xf796)]
        SolidEthernet = 1262,
        ///<summary>Solid Tablets</summary>
        ///<see href="https://fontawesome.com/icons/tablets?style=solid"/>
        [Description("Solid Tablets"), IconID("fas-tablets"), IconUnicodeGlyph(0xf490)]
        SolidTablets = 1263,
        ///<summary>Solid Cannabis</summary>
        ///<see href="https://fontawesome.com/icons/cannabis?style=solid"/>
        [Description("Solid Cannabis"), IconID("fas-cannabis"), IconUnicodeGlyph(0xf55f)]
        SolidCannabis = 1264,
        ///<summary>Solid Snowplow</summary>
        ///<see href="https://fontawesome.com/icons/snowplow?style=solid"/>
        [Description("Solid Snowplow"), IconID("fas-snowplow"), IconUnicodeGlyph(0xf7d2)]
        SolidSnowplow = 1265,
        ///<summary>Solid Monument</summary>
        ///<see href="https://fontawesome.com/icons/monument?style=solid"/>
        [Description("Solid Monument"), IconID("fas-monument"), IconUnicodeGlyph(0xf5a6)]
        SolidMonument = 1266,
        ///<summary>Solid Smoking</summary>
        ///<see href="https://fontawesome.com/icons/smoking?style=solid"/>
        [Description("Solid Smoking"), IconID("fas-smoking"), IconUnicodeGlyph(0xf48d)]
        SolidSmoking = 1267,
        ///<summary>Solid Dolly</summary>
        ///<see href="https://fontawesome.com/icons/dolly?style=solid"/>
        [Description("Solid Dolly"), IconID("fas-dolly"), IconUnicodeGlyph(0xf472)]
        SolidDolly = 1268,
        ///<summary>Solid Gem</summary>
        ///<see href="https://fontawesome.com/icons/gem?style=solid"/>
        [Description("Solid Gem"), IconID("fas-gem"), IconUnicodeGlyph(0xf3a5)]
        SolidGem = 1269,
        ///<summary>Solid Handshake</summary>
        ///<see href="https://fontawesome.com/icons/handshake?style=solid"/>
        [Description("Solid Handshake"), IconID("fas-handshake"), IconUnicodeGlyph(0xf2b5)]
        SolidHandshake = 1270,
        ///<summary>Solid Head Side Mask</summary>
        ///<see href="https://fontawesome.com/icons/head-side-mask?style=solid"/>
        [Description("Solid Head Side Mask"), IconID("fas-head-side-mask"), IconUnicodeGlyph(0xe063)]
        SolidHeadSideMask = 1271,
        ///<summary>Solid Thermometer Half</summary>
        ///<see href="https://fontawesome.com/icons/thermometer-half?style=solid"/>
        [Description("Solid Thermometer Half"), IconID("fas-thermometer-half"), IconUnicodeGlyph(0xf2c9)]
        SolidThermometerHalf = 1272,
        ///<summary>Solid Lemon</summary>
        ///<see href="https://fontawesome.com/icons/lemon?style=solid"/>
        [Description("Solid Lemon"), IconID("fas-lemon"), IconUnicodeGlyph(0xf094)]
        SolidLemon = 1273,
        ///<summary>Solid Screwdriver</summary>
        ///<see href="https://fontawesome.com/icons/screwdriver?style=solid"/>
        [Description("Solid Screwdriver"), IconID("fas-screwdriver"), IconUnicodeGlyph(0xf54a)]
        SolidScrewdriver = 1274,
        ///<summary>Solid Ticket Alt</summary>
        ///<see href="https://fontawesome.com/icons/ticket-alt?style=solid"/>
        [Description("Solid Ticket Alt"), IconID("fas-ticket-alt"), IconUnicodeGlyph(0xf3ff)]
        SolidTicketAlt = 1275,
        ///<summary>Solid Caret Up</summary>
        ///<see href="https://fontawesome.com/icons/caret-up?style=solid"/>
        [Description("Solid Caret Up"), IconID("fas-caret-up"), IconUnicodeGlyph(0xf0d8)]
        SolidCaretUp = 1276,
        ///<summary>Solid Sign Out Alt</summary>
        ///<see href="https://fontawesome.com/icons/sign-out-alt?style=solid"/>
        [Description("Solid Sign Out Alt"), IconID("fas-sign-out-alt"), IconUnicodeGlyph(0xf2f5)]
        SolidSignOutAlt = 1277,
        ///<summary>Solid Microphone</summary>
        ///<see href="https://fontawesome.com/icons/microphone?style=solid"/>
        [Description("Solid Microphone"), IconID("fas-microphone"), IconUnicodeGlyph(0xf130)]
        SolidMicrophone = 1278,
        ///<summary>Solid Image</summary>
        ///<see href="https://fontawesome.com/icons/image?style=solid"/>
        [Description("Solid Image"), IconID("fas-image"), IconUnicodeGlyph(0xf03e)]
        SolidImage = 1279,
        ///<summary>Solid Frog</summary>
        ///<see href="https://fontawesome.com/icons/frog?style=solid"/>
        [Description("Solid Frog"), IconID("fas-frog"), IconUnicodeGlyph(0xf52e)]
        SolidFrog = 1280,
        ///<summary>Solid Torii Gate</summary>
        ///<see href="https://fontawesome.com/icons/torii-gate?style=solid"/>
        [Description("Solid Torii Gate"), IconID("fas-torii-gate"), IconUnicodeGlyph(0xf6a1)]
        SolidToriiGate = 1281,
        ///<summary>Solid Window Restore</summary>
        ///<see href="https://fontawesome.com/icons/window-restore?style=solid"/>
        [Description("Solid Window Restore"), IconID("fas-window-restore"), IconUnicodeGlyph(0xf2d2)]
        SolidWindowRestore = 1282,
        ///<summary>Solid Minus Circle</summary>
        ///<see href="https://fontawesome.com/icons/minus-circle?style=solid"/>
        [Description("Solid Minus Circle"), IconID("fas-minus-circle"), IconUnicodeGlyph(0xf056)]
        SolidMinusCircle = 1283,
        ///<summary>Solid Book Reader</summary>
        ///<see href="https://fontawesome.com/icons/book-reader?style=solid"/>
        [Description("Solid Book Reader"), IconID("fas-book-reader"), IconUnicodeGlyph(0xf5da)]
        SolidBookReader = 1284,
        ///<summary>Solid Boxes</summary>
        ///<see href="https://fontawesome.com/icons/boxes?style=solid"/>
        [Description("Solid Boxes"), IconID("fas-boxes"), IconUnicodeGlyph(0xf468)]
        SolidBoxes = 1285,
        ///<summary>Solid Crow</summary>
        ///<see href="https://fontawesome.com/icons/crow?style=solid"/>
        [Description("Solid Crow"), IconID("fas-crow"), IconUnicodeGlyph(0xf520)]
        SolidCrow = 1286,
        ///<summary>Solid Unlink</summary>
        ///<see href="https://fontawesome.com/icons/unlink?style=solid"/>
        [Description("Solid Unlink"), IconID("fas-unlink"), IconUnicodeGlyph(0xf127)]
        SolidUnlink = 1287,
        ///<summary>Solid Train</summary>
        ///<see href="https://fontawesome.com/icons/train?style=solid"/>
        [Description("Solid Train"), IconID("fas-train"), IconUnicodeGlyph(0xf238)]
        SolidTrain = 1288,
        ///<summary>Solid Less Than Equal</summary>
        ///<see href="https://fontawesome.com/icons/less-than-equal?style=solid"/>
        [Description("Solid Less Than Equal"), IconID("fas-less-than-equal"), IconUnicodeGlyph(0xf537)]
        SolidLessThanEqual = 1289,
        ///<summary>Solid Chart Bar</summary>
        ///<see href="https://fontawesome.com/icons/chart-bar?style=solid"/>
        [Description("Solid Chart Bar"), IconID("fas-chart-bar"), IconUnicodeGlyph(0xf080)]
        SolidChartBar = 1290,
        ///<summary>Solid Laugh Wink</summary>
        ///<see href="https://fontawesome.com/icons/laugh-wink?style=solid"/>
        [Description("Solid Laugh Wink"), IconID("fas-laugh-wink"), IconUnicodeGlyph(0xf59c)]
        SolidLaughWink = 1291,
        ///<summary>Solid Chess Board</summary>
        ///<see href="https://fontawesome.com/icons/chess-board?style=solid"/>
        [Description("Solid Chess Board"), IconID("fas-chess-board"), IconUnicodeGlyph(0xf43c)]
        SolidChessBoard = 1292,
        ///<summary>Solid Glasses</summary>
        ///<see href="https://fontawesome.com/icons/glasses?style=solid"/>
        [Description("Solid Glasses"), IconID("fas-glasses"), IconUnicodeGlyph(0xf530)]
        SolidGlasses = 1293,
        ///<summary>Solid Sort Alpha Up</summary>
        ///<see href="https://fontawesome.com/icons/sort-alpha-up?style=solid"/>
        [Description("Solid Sort Alpha Up"), IconID("fas-sort-alpha-up"), IconUnicodeGlyph(0xf15e)]
        SolidSortAlphaUp = 1294,
        ///<summary>Solid Chess Queen</summary>
        ///<see href="https://fontawesome.com/icons/chess-queen?style=solid"/>
        [Description("Solid Chess Queen"), IconID("fas-chess-queen"), IconUnicodeGlyph(0xf445)]
        SolidChessQueen = 1295,
        ///<summary>Solid Dice Two</summary>
        ///<see href="https://fontawesome.com/icons/dice-two?style=solid"/>
        [Description("Solid Dice Two"), IconID("fas-dice-two"), IconUnicodeGlyph(0xf528)]
        SolidDiceTwo = 1296,
        ///<summary>Solid Gift</summary>
        ///<see href="https://fontawesome.com/icons/gift?style=solid"/>
        [Description("Solid Gift"), IconID("fas-gift"), IconUnicodeGlyph(0xf06b)]
        SolidGift = 1297,
        ///<summary>Solid Volleyball Ball</summary>
        ///<see href="https://fontawesome.com/icons/volleyball-ball?style=solid"/>
        [Description("Solid Volleyball Ball"), IconID("fas-volleyball-ball"), IconUnicodeGlyph(0xf45f)]
        SolidVolleyballBall = 1298,
        ///<summary>Solid Car Battery</summary>
        ///<see href="https://fontawesome.com/icons/car-battery?style=solid"/>
        [Description("Solid Car Battery"), IconID("fas-car-battery"), IconUnicodeGlyph(0xf5df)]
        SolidCarBattery = 1299,
        ///<summary>Solid Square Root Alt</summary>
        ///<see href="https://fontawesome.com/icons/square-root-alt?style=solid"/>
        [Description("Solid Square Root Alt"), IconID("fas-square-root-alt"), IconUnicodeGlyph(0xf698)]
        SolidSquareRootAlt = 1300,
        ///<summary>Solid Mug Hot</summary>
        ///<see href="https://fontawesome.com/icons/mug-hot?style=solid"/>
        [Description("Solid Mug Hot"), IconID("fas-mug-hot"), IconUnicodeGlyph(0xf7b6)]
        SolidMugHot = 1301,
        ///<summary>Solid Level Down Alt</summary>
        ///<see href="https://fontawesome.com/icons/level-down-alt?style=solid"/>
        [Description("Solid Level Down Alt"), IconID("fas-level-down-alt"), IconUnicodeGlyph(0xf3be)]
        SolidLevelDownAlt = 1302,
        ///<summary>Solid Jedi</summary>
        ///<see href="https://fontawesome.com/icons/jedi?style=solid"/>
        [Description("Solid Jedi"), IconID("fas-jedi"), IconUnicodeGlyph(0xf669)]
        SolidJedi = 1303,
        ///<summary>Solid User Md</summary>
        ///<see href="https://fontawesome.com/icons/user-md?style=solid"/>
        [Description("Solid User Md"), IconID("fas-user-md"), IconUnicodeGlyph(0xf0f0)]
        SolidUserMd = 1304,
        ///<summary>Solid Flushed</summary>
        ///<see href="https://fontawesome.com/icons/flushed?style=solid"/>
        [Description("Solid Flushed"), IconID("fas-flushed"), IconUnicodeGlyph(0xf579)]
        SolidFlushed = 1305,
        ///<summary>Solid Not Equal</summary>
        ///<see href="https://fontawesome.com/icons/not-equal?style=solid"/>
        [Description("Solid Not Equal"), IconID("fas-not-equal"), IconUnicodeGlyph(0xf53e)]
        SolidNotEqual = 1306,
        ///<summary>Solid Mouse Pointer</summary>
        ///<see href="https://fontawesome.com/icons/mouse-pointer?style=solid"/>
        [Description("Solid Mouse Pointer"), IconID("fas-mouse-pointer"), IconUnicodeGlyph(0xf245)]
        SolidMousePointer = 1307,
        ///<summary>Solid Hdd</summary>
        ///<see href="https://fontawesome.com/icons/hdd?style=solid"/>
        [Description("Solid Hdd"), IconID("fas-hdd"), IconUnicodeGlyph(0xf0a0)]
        SolidHdd = 1308,
        ///<summary>Solid Bold</summary>
        ///<see href="https://fontawesome.com/icons/bold?style=solid"/>
        [Description("Solid Bold"), IconID("fas-bold"), IconUnicodeGlyph(0xf032)]
        SolidBold = 1309,
        ///<summary>Solid Atlas</summary>
        ///<see href="https://fontawesome.com/icons/atlas?style=solid"/>
        [Description("Solid Atlas"), IconID("fas-atlas"), IconUnicodeGlyph(0xf558)]
        SolidAtlas = 1310,
        ///<summary>Solid Stroopwafel</summary>
        ///<see href="https://fontawesome.com/icons/stroopwafel?style=solid"/>
        [Description("Solid Stroopwafel"), IconID("fas-stroopwafel"), IconUnicodeGlyph(0xf551)]
        SolidStroopwafel = 1311,
        ///<summary>Solid Signature</summary>
        ///<see href="https://fontawesome.com/icons/signature?style=solid"/>
        [Description("Solid Signature"), IconID("fas-signature"), IconUnicodeGlyph(0xf5b7)]
        SolidSignature = 1312,
        ///<summary>Solid Angle Double Down</summary>
        ///<see href="https://fontawesome.com/icons/angle-double-down?style=solid"/>
        [Description("Solid Angle Double Down"), IconID("fas-angle-double-down"), IconUnicodeGlyph(0xf103)]
        SolidAngleDoubleDown = 1313,
        ///<summary>Solid Air Freshener</summary>
        ///<see href="https://fontawesome.com/icons/air-freshener?style=solid"/>
        [Description("Solid Air Freshener"), IconID("fas-air-freshener"), IconUnicodeGlyph(0xf5d0)]
        SolidAirFreshener = 1314,
        ///<summary>Solid Cut</summary>
        ///<see href="https://fontawesome.com/icons/cut?style=solid"/>
        [Description("Solid Cut"), IconID("fas-cut"), IconUnicodeGlyph(0xf0c4)]
        SolidCut = 1315,
        ///<summary>Solid Underline</summary>
        ///<see href="https://fontawesome.com/icons/underline?style=solid"/>
        [Description("Solid Underline"), IconID("fas-underline"), IconUnicodeGlyph(0xf0cd)]
        SolidUnderline = 1316,
        ///<summary>Solid Bath</summary>
        ///<see href="https://fontawesome.com/icons/bath?style=solid"/>
        [Description("Solid Bath"), IconID("fas-bath"), IconUnicodeGlyph(0xf2cd)]
        SolidBath = 1317,
        ///<summary>Solid Wifi</summary>
        ///<see href="https://fontawesome.com/icons/wifi?style=solid"/>
        [Description("Solid Wifi"), IconID("fas-wifi"), IconUnicodeGlyph(0xf1eb)]
        SolidWifi = 1318,
        ///<summary>Solid Laugh</summary>
        ///<see href="https://fontawesome.com/icons/laugh?style=solid"/>
        [Description("Solid Laugh"), IconID("fas-laugh"), IconUnicodeGlyph(0xf599)]
        SolidLaugh = 1319,
        ///<summary>Solid Meh Rolling Eyes</summary>
        ///<see href="https://fontawesome.com/icons/meh-rolling-eyes?style=solid"/>
        [Description("Solid Meh Rolling Eyes"), IconID("fas-meh-rolling-eyes"), IconUnicodeGlyph(0xf5a5)]
        SolidMehRollingEyes = 1320,
        ///<summary>Solid Clipboard</summary>
        ///<see href="https://fontawesome.com/icons/clipboard?style=solid"/>
        [Description("Solid Clipboard"), IconID("fas-clipboard"), IconUnicodeGlyph(0xf328)]
        SolidClipboard = 1321,
        ///<summary>Solid Redo Alt</summary>
        ///<see href="https://fontawesome.com/icons/redo-alt?style=solid"/>
        [Description("Solid Redo Alt"), IconID("fas-redo-alt"), IconUnicodeGlyph(0xf2f9)]
        SolidRedoAlt = 1322,
        ///<summary>Solid User Minus</summary>
        ///<see href="https://fontawesome.com/icons/user-minus?style=solid"/>
        [Description("Solid User Minus"), IconID("fas-user-minus"), IconUnicodeGlyph(0xf503)]
        SolidUserMinus = 1323,
        ///<summary>Solid Store Slash</summary>
        ///<see href="https://fontawesome.com/icons/store-slash?style=solid"/>
        [Description("Solid Store Slash"), IconID("fas-store-slash"), IconUnicodeGlyph(0xe071)]
        SolidStoreSlash = 1324,
        ///<summary>Solid External Link Alt</summary>
        ///<see href="https://fontawesome.com/icons/external-link-alt?style=solid"/>
        [Description("Solid External Link Alt"), IconID("fas-external-link-alt"), IconUnicodeGlyph(0xf35d)]
        SolidExternalLinkAlt = 1325,
        ///<summary>Solid Skiing Nordic</summary>
        ///<see href="https://fontawesome.com/icons/skiing-nordic?style=solid"/>
        [Description("Solid Skiing Nordic"), IconID("fas-skiing-nordic"), IconUnicodeGlyph(0xf7ca)]
        SolidSkiingNordic = 1326,
        ///<summary>Solid Headset</summary>
        ///<see href="https://fontawesome.com/icons/headset?style=solid"/>
        [Description("Solid Headset"), IconID("fas-headset"), IconUnicodeGlyph(0xf590)]
        SolidHeadset = 1327,
        ///<summary>Solid Running</summary>
        ///<see href="https://fontawesome.com/icons/running?style=solid"/>
        [Description("Solid Running"), IconID("fas-running"), IconUnicodeGlyph(0xf70c)]
        SolidRunning = 1328,
        ///<summary>Solid Unlock</summary>
        ///<see href="https://fontawesome.com/icons/unlock?style=solid"/>
        [Description("Solid Unlock"), IconID("fas-unlock"), IconUnicodeGlyph(0xf09c)]
        SolidUnlock = 1329,
        ///<summary>Solid Pepper Hot</summary>
        ///<see href="https://fontawesome.com/icons/pepper-hot?style=solid"/>
        [Description("Solid Pepper Hot"), IconID("fas-pepper-hot"), IconUnicodeGlyph(0xf816)]
        SolidPepperHot = 1330,
        ///<summary>Solid Thermometer Three Quarters</summary>
        ///<see href="https://fontawesome.com/icons/thermometer-three-quarters?style=solid"/>
        [Description("Solid Thermometer Three Quarters"), IconID("fas-thermometer-three-quarters"), IconUnicodeGlyph(0xf2c8)]
        SolidThermometerThreeQuarters = 1331,
        ///<summary>Solid City</summary>
        ///<see href="https://fontawesome.com/icons/city?style=solid"/>
        [Description("Solid City"), IconID("fas-city"), IconUnicodeGlyph(0xf64f)]
        SolidCity = 1332,
        ///<summary>Solid Chevron Circle Left</summary>
        ///<see href="https://fontawesome.com/icons/chevron-circle-left?style=solid"/>
        [Description("Solid Chevron Circle Left"), IconID("fas-chevron-circle-left"), IconUnicodeGlyph(0xf137)]
        SolidChevronCircleLeft = 1333,
        ///<summary>Solid Folder Open</summary>
        ///<see href="https://fontawesome.com/icons/folder-open?style=solid"/>
        [Description("Solid Folder Open"), IconID("fas-folder-open"), IconUnicodeGlyph(0xf07c)]
        SolidFolderOpen = 1334,
        ///<summary>Solid Minus Square</summary>
        ///<see href="https://fontawesome.com/icons/minus-square?style=solid"/>
        [Description("Solid Minus Square"), IconID("fas-minus-square"), IconUnicodeGlyph(0xf146)]
        SolidMinusSquare = 1335,
        ///<summary>Solid Fire</summary>
        ///<see href="https://fontawesome.com/icons/fire?style=solid"/>
        [Description("Solid Fire"), IconID("fas-fire"), IconUnicodeGlyph(0xf06d)]
        SolidFire = 1336,
        ///<summary>Solid Feather Alt</summary>
        ///<see href="https://fontawesome.com/icons/feather-alt?style=solid"/>
        [Description("Solid Feather Alt"), IconID("fas-feather-alt"), IconUnicodeGlyph(0xf56b)]
        SolidFeatherAlt = 1337,
        ///<summary>Solid Tint Slash</summary>
        ///<see href="https://fontawesome.com/icons/tint-slash?style=solid"/>
        [Description("Solid Tint Slash"), IconID("fas-tint-slash"), IconUnicodeGlyph(0xf5c7)]
        SolidTintSlash = 1338,
        ///<summary>Solid Window Close</summary>
        ///<see href="https://fontawesome.com/icons/window-close?style=solid"/>
        [Description("Solid Window Close"), IconID("fas-window-close"), IconUnicodeGlyph(0xf410)]
        SolidWindowClose = 1339,
        ///<summary>Solid Phone Square Alt</summary>
        ///<see href="https://fontawesome.com/icons/phone-square-alt?style=solid"/>
        [Description("Solid Phone Square Alt"), IconID("fas-phone-square-alt"), IconUnicodeGlyph(0xf87b)]
        SolidPhoneSquareAlt = 1340,
        ///<summary>Solid Toggle On</summary>
        ///<see href="https://fontawesome.com/icons/toggle-on?style=solid"/>
        [Description("Solid Toggle On"), IconID("fas-toggle-on"), IconUnicodeGlyph(0xf205)]
        SolidToggleOn = 1341,
        ///<summary>Solid Skating</summary>
        ///<see href="https://fontawesome.com/icons/skating?style=solid"/>
        [Description("Solid Skating"), IconID("fas-skating"), IconUnicodeGlyph(0xf7c5)]
        SolidSkating = 1342,
        ///<summary>Solid Wheelchair</summary>
        ///<see href="https://fontawesome.com/icons/wheelchair?style=solid"/>
        [Description("Solid Wheelchair"), IconID("fas-wheelchair"), IconUnicodeGlyph(0xf193)]
        SolidWheelchair = 1343,
        ///<summary>Solid Grin</summary>
        ///<see href="https://fontawesome.com/icons/grin?style=solid"/>
        [Description("Solid Grin"), IconID("fas-grin"), IconUnicodeGlyph(0xf580)]
        SolidGrin = 1344,
        ///<summary>Solid Chess Knight</summary>
        ///<see href="https://fontawesome.com/icons/chess-knight?style=solid"/>
        [Description("Solid Chess Knight"), IconID("fas-chess-knight"), IconUnicodeGlyph(0xf441)]
        SolidChessKnight = 1345,
        ///<summary>Solid Fast Backward</summary>
        ///<see href="https://fontawesome.com/icons/fast-backward?style=solid"/>
        [Description("Solid Fast Backward"), IconID("fas-fast-backward"), IconUnicodeGlyph(0xf049)]
        SolidFastBackward = 1346,
        ///<summary>Solid File Prescription</summary>
        ///<see href="https://fontawesome.com/icons/file-prescription?style=solid"/>
        [Description("Solid File Prescription"), IconID("fas-file-prescription"), IconUnicodeGlyph(0xf572)]
        SolidFilePrescription = 1347,
        ///<summary>Solid Meh Blank</summary>
        ///<see href="https://fontawesome.com/icons/meh-blank?style=solid"/>
        [Description("Solid Meh Blank"), IconID("fas-meh-blank"), IconUnicodeGlyph(0xf5a4)]
        SolidMehBlank = 1348,
        ///<summary>Solid Weight Hanging</summary>
        ///<see href="https://fontawesome.com/icons/weight-hanging?style=solid"/>
        [Description("Solid Weight Hanging"), IconID("fas-weight-hanging"), IconUnicodeGlyph(0xf5cd)]
        SolidWeightHanging = 1349,
        ///<summary>Solid Crown</summary>
        ///<see href="https://fontawesome.com/icons/crown?style=solid"/>
        [Description("Solid Crown"), IconID("fas-crown"), IconUnicodeGlyph(0xf521)]
        SolidCrown = 1350,
        ///<summary>Solid Microchip</summary>
        ///<see href="https://fontawesome.com/icons/microchip?style=solid"/>
        [Description("Solid Microchip"), IconID("fas-microchip"), IconUnicodeGlyph(0xf2db)]
        SolidMicrochip = 1351,
        ///<summary>Solid Temperature High</summary>
        ///<see href="https://fontawesome.com/icons/temperature-high?style=solid"/>
        [Description("Solid Temperature High"), IconID("fas-temperature-high"), IconUnicodeGlyph(0xf769)]
        SolidTemperatureHigh = 1352,
        ///<summary>Solid Passport</summary>
        ///<see href="https://fontawesome.com/icons/passport?style=solid"/>
        [Description("Solid Passport"), IconID("fas-passport"), IconUnicodeGlyph(0xf5ab)]
        SolidPassport = 1353,
        ///<summary>Solid Venus</summary>
        ///<see href="https://fontawesome.com/icons/venus?style=solid"/>
        [Description("Solid Venus"), IconID("fas-venus"), IconUnicodeGlyph(0xf221)]
        SolidVenus = 1354,
        ///<summary>Solid Play Circle</summary>
        ///<see href="https://fontawesome.com/icons/play-circle?style=solid"/>
        [Description("Solid Play Circle"), IconID("fas-play-circle"), IconUnicodeGlyph(0xf144)]
        SolidPlayCircle = 1355,
        ///<summary>Solid Blender Phone</summary>
        ///<see href="https://fontawesome.com/icons/blender-phone?style=solid"/>
        [Description("Solid Blender Phone"), IconID("fas-blender-phone"), IconUnicodeGlyph(0xf6b6)]
        SolidBlenderPhone = 1356,
        ///<summary>Solid Hourglass Start</summary>
        ///<see href="https://fontawesome.com/icons/hourglass-start?style=solid"/>
        [Description("Solid Hourglass Start"), IconID("fas-hourglass-start"), IconUnicodeGlyph(0xf251)]
        SolidHourglassStart = 1357,
        ///<summary>Solid Server</summary>
        ///<see href="https://fontawesome.com/icons/server?style=solid"/>
        [Description("Solid Server"), IconID("fas-server"), IconUnicodeGlyph(0xf233)]
        SolidServer = 1358,
        ///<summary>Solid Fighter Jet</summary>
        ///<see href="https://fontawesome.com/icons/fighter-jet?style=solid"/>
        [Description("Solid Fighter Jet"), IconID("fas-fighter-jet"), IconUnicodeGlyph(0xf0fb)]
        SolidFighterJet = 1359,
        ///<summary>Solid Project Diagram</summary>
        ///<see href="https://fontawesome.com/icons/project-diagram?style=solid"/>
        [Description("Solid Project Diagram"), IconID("fas-project-diagram"), IconUnicodeGlyph(0xf542)]
        SolidProjectDiagram = 1360,
        ///<summary>Solid Pen Square</summary>
        ///<see href="https://fontawesome.com/icons/pen-square?style=solid"/>
        [Description("Solid Pen Square"), IconID("fas-pen-square"), IconUnicodeGlyph(0xf14b)]
        SolidPenSquare = 1361,
        ///<summary>Solid Burn</summary>
        ///<see href="https://fontawesome.com/icons/burn?style=solid"/>
        [Description("Solid Burn"), IconID("fas-burn"), IconUnicodeGlyph(0xf46a)]
        SolidBurn = 1362,
        ///<summary>Solid Slash</summary>
        ///<see href="https://fontawesome.com/icons/slash?style=solid"/>
        [Description("Solid Slash"), IconID("fas-slash"), IconUnicodeGlyph(0xf715)]
        SolidSlash = 1363,
        ///<summary>Solid Exclamation Triangle</summary>
        ///<see href="https://fontawesome.com/icons/exclamation-triangle?style=solid"/>
        [Description("Solid Exclamation Triangle"), IconID("fas-exclamation-triangle"), IconUnicodeGlyph(0xf071)]
        SolidExclamationTriangle = 1364,
        ///<summary>Solid Spell Check</summary>
        ///<see href="https://fontawesome.com/icons/spell-check?style=solid"/>
        [Description("Solid Spell Check"), IconID("fas-spell-check"), IconUnicodeGlyph(0xf891)]
        SolidSpellCheck = 1365,
        ///<summary>Solid X Ray</summary>
        ///<see href="https://fontawesome.com/icons/x-ray?style=solid"/>
        [Description("Solid X Ray"), IconID("fas-x-ray"), IconUnicodeGlyph(0xf497)]
        SolidXRay = 1366,
        ///<summary>Solid Unlock Alt</summary>
        ///<see href="https://fontawesome.com/icons/unlock-alt?style=solid"/>
        [Description("Solid Unlock Alt"), IconID("fas-unlock-alt"), IconUnicodeGlyph(0xf13e)]
        SolidUnlockAlt = 1367,
        ///<summary>Solid File Invoice Dollar</summary>
        ///<see href="https://fontawesome.com/icons/file-invoice-dollar?style=solid"/>
        [Description("Solid File Invoice Dollar"), IconID("fas-file-invoice-dollar"), IconUnicodeGlyph(0xf571)]
        SolidFileInvoiceDollar = 1368,
        ///<summary>Solid Spider</summary>
        ///<see href="https://fontawesome.com/icons/spider?style=solid"/>
        [Description("Solid Spider"), IconID("fas-spider"), IconUnicodeGlyph(0xf717)]
        SolidSpider = 1369,
        ///<summary>Solid Grip Lines Vertical</summary>
        ///<see href="https://fontawesome.com/icons/grip-lines-vertical?style=solid"/>
        [Description("Solid Grip Lines Vertical"), IconID("fas-grip-lines-vertical"), IconUnicodeGlyph(0xf7a5)]
        SolidGripLinesVertical = 1370,
        ///<summary>Solid Meh</summary>
        ///<see href="https://fontawesome.com/icons/meh?style=solid"/>
        [Description("Solid Meh"), IconID("fas-meh"), IconUnicodeGlyph(0xf11a)]
        SolidMeh = 1371,
        ///<summary>Solid Shapes</summary>
        ///<see href="https://fontawesome.com/icons/shapes?style=solid"/>
        [Description("Solid Shapes"), IconID("fas-shapes"), IconUnicodeGlyph(0xf61f)]
        SolidShapes = 1372,
        ///<summary>Solid Charging Station</summary>
        ///<see href="https://fontawesome.com/icons/charging-station?style=solid"/>
        [Description("Solid Charging Station"), IconID("fas-charging-station"), IconUnicodeGlyph(0xf5e7)]
        SolidChargingStation = 1373,
        ///<summary>Solid Money Bill Wave Alt</summary>
        ///<see href="https://fontawesome.com/icons/money-bill-wave-alt?style=solid"/>
        [Description("Solid Money Bill Wave Alt"), IconID("fas-money-bill-wave-alt"), IconUnicodeGlyph(0xf53b)]
        SolidMoneyBillWaveAlt = 1374,
        ///<summary>Solid Compress Alt</summary>
        ///<see href="https://fontawesome.com/icons/compress-alt?style=solid"/>
        [Description("Solid Compress Alt"), IconID("fas-compress-alt"), IconUnicodeGlyph(0xf422)]
        SolidCompressAlt = 1375,
        ///<summary>Solid Venus Mars</summary>
        ///<see href="https://fontawesome.com/icons/venus-mars?style=solid"/>
        [Description("Solid Venus Mars"), IconID("fas-venus-mars"), IconUnicodeGlyph(0xf228)]
        SolidVenusMars = 1376,
        ///<summary>Solid Box</summary>
        ///<see href="https://fontawesome.com/icons/box?style=solid"/>
        [Description("Solid Box"), IconID("fas-box"), IconUnicodeGlyph(0xf466)]
        SolidBox = 1377,
        ///<summary>Solid Cross</summary>
        ///<see href="https://fontawesome.com/icons/cross?style=solid"/>
        [Description("Solid Cross"), IconID("fas-cross"), IconUnicodeGlyph(0xf654)]
        SolidCross = 1378,
        ///<summary>Solid Star</summary>
        ///<see href="https://fontawesome.com/icons/star?style=solid"/>
        [Description("Solid Star"), IconID("fas-star"), IconUnicodeGlyph(0xf005)]
        SolidStar = 1379,
        ///<summary>Solid Pound Sign</summary>
        ///<see href="https://fontawesome.com/icons/pound-sign?style=solid"/>
        [Description("Solid Pound Sign"), IconID("fas-pound-sign"), IconUnicodeGlyph(0xf154)]
        SolidPoundSign = 1380,
        ///<summary>Solid Hamburger</summary>
        ///<see href="https://fontawesome.com/icons/hamburger?style=solid"/>
        [Description("Solid Hamburger"), IconID("fas-hamburger"), IconUnicodeGlyph(0xf805)]
        SolidHamburger = 1381,
        ///<summary>Solid Ban</summary>
        ///<see href="https://fontawesome.com/icons/ban?style=solid"/>
        [Description("Solid Ban"), IconID("fas-ban"), IconUnicodeGlyph(0xf05e)]
        SolidBan = 1382,
        ///<summary>Solid Chart Area</summary>
        ///<see href="https://fontawesome.com/icons/chart-area?style=solid"/>
        [Description("Solid Chart Area"), IconID("fas-chart-area"), IconUnicodeGlyph(0xf1fe)]
        SolidChartArea = 1383,
        ///<summary>Solid Money Bill Wave</summary>
        ///<see href="https://fontawesome.com/icons/money-bill-wave?style=solid"/>
        [Description("Solid Money Bill Wave"), IconID("fas-money-bill-wave"), IconUnicodeGlyph(0xf53a)]
        SolidMoneyBillWave = 1384,
        ///<summary>Solid Pizza Slice</summary>
        ///<see href="https://fontawesome.com/icons/pizza-slice?style=solid"/>
        [Description("Solid Pizza Slice"), IconID("fas-pizza-slice"), IconUnicodeGlyph(0xf818)]
        SolidPizzaSlice = 1385,
        ///<summary>Solid Heartbeat</summary>
        ///<see href="https://fontawesome.com/icons/heartbeat?style=solid"/>
        [Description("Solid Heartbeat"), IconID("fas-heartbeat"), IconUnicodeGlyph(0xf21e)]
        SolidHeartbeat = 1386,
        ///<summary>Solid Location Arrow</summary>
        ///<see href="https://fontawesome.com/icons/location-arrow?style=solid"/>
        [Description("Solid Location Arrow"), IconID("fas-location-arrow"), IconUnicodeGlyph(0xf124)]
        SolidLocationArrow = 1387,
        ///<summary>Solid Grin Wink</summary>
        ///<see href="https://fontawesome.com/icons/grin-wink?style=solid"/>
        [Description("Solid Grin Wink"), IconID("fas-grin-wink"), IconUnicodeGlyph(0xf58c)]
        SolidGrinWink = 1388,
        ///<summary>Solid Synagogue</summary>
        ///<see href="https://fontawesome.com/icons/synagogue?style=solid"/>
        [Description("Solid Synagogue"), IconID("fas-synagogue"), IconUnicodeGlyph(0xf69b)]
        SolidSynagogue = 1389,
        ///<summary>Solid Globe</summary>
        ///<see href="https://fontawesome.com/icons/globe?style=solid"/>
        [Description("Solid Globe"), IconID("fas-globe"), IconUnicodeGlyph(0xf0ac)]
        SolidGlobe = 1390,
        ///<summary>Solid Bullhorn</summary>
        ///<see href="https://fontawesome.com/icons/bullhorn?style=solid"/>
        [Description("Solid Bullhorn"), IconID("fas-bullhorn"), IconUnicodeGlyph(0xf0a1)]
        SolidBullhorn = 1391,
        ///<summary>Solid Key</summary>
        ///<see href="https://fontawesome.com/icons/key?style=solid"/>
        [Description("Solid Key"), IconID("fas-key"), IconUnicodeGlyph(0xf084)]
        SolidKey = 1392,
        ///<summary>Solid Highlighter</summary>
        ///<see href="https://fontawesome.com/icons/highlighter?style=solid"/>
        [Description("Solid Highlighter"), IconID("fas-highlighter"), IconUnicodeGlyph(0xf591)]
        SolidHighlighter = 1393,
        ///<summary>Solid Dumpster</summary>
        ///<see href="https://fontawesome.com/icons/dumpster?style=solid"/>
        [Description("Solid Dumpster"), IconID("fas-dumpster"), IconUnicodeGlyph(0xf793)]
        SolidDumpster = 1394,
        ///<summary>Solid User</summary>
        ///<see href="https://fontawesome.com/icons/user?style=solid"/>
        [Description("Solid User"), IconID("fas-user"), IconUnicodeGlyph(0xf007)]
        SolidUser = 1395,
        ///<summary>Solid Vial</summary>
        ///<see href="https://fontawesome.com/icons/vial?style=solid"/>
        [Description("Solid Vial"), IconID("fas-vial"), IconUnicodeGlyph(0xf492)]
        SolidVial = 1396,
        ///<summary>Solid Exclamation Circle</summary>
        ///<see href="https://fontawesome.com/icons/exclamation-circle?style=solid"/>
        [Description("Solid Exclamation Circle"), IconID("fas-exclamation-circle"), IconUnicodeGlyph(0xf06a)]
        SolidExclamationCircle = 1397,
        ///<summary>Solid Thermometer Empty</summary>
        ///<see href="https://fontawesome.com/icons/thermometer-empty?style=solid"/>
        [Description("Solid Thermometer Empty"), IconID("fas-thermometer-empty"), IconUnicodeGlyph(0xf2cb)]
        SolidThermometerEmpty = 1398,
        ///<summary>Solid Mars Stroke</summary>
        ///<see href="https://fontawesome.com/icons/mars-stroke?style=solid"/>
        [Description("Solid Mars Stroke"), IconID("fas-mars-stroke"), IconUnicodeGlyph(0xf229)]
        SolidMarsStroke = 1399,
        ///<summary>Solid Radiation</summary>
        ///<see href="https://fontawesome.com/icons/radiation?style=solid"/>
        [Description("Solid Radiation"), IconID("fas-radiation"), IconUnicodeGlyph(0xf7b9)]
        SolidRadiation = 1400,
        ///<summary>Solid Globe Europe</summary>
        ///<see href="https://fontawesome.com/icons/globe-europe?style=solid"/>
        [Description("Solid Globe Europe"), IconID("fas-globe-europe"), IconUnicodeGlyph(0xf7a2)]
        SolidGlobeEurope = 1401,
        ///<summary>Solid Folder</summary>
        ///<see href="https://fontawesome.com/icons/folder?style=solid"/>
        [Description("Solid Folder"), IconID("fas-folder"), IconUnicodeGlyph(0xf07b)]
        SolidFolder = 1402,
        ///<summary>Solid Magic</summary>
        ///<see href="https://fontawesome.com/icons/magic?style=solid"/>
        [Description("Solid Magic"), IconID("fas-magic"), IconUnicodeGlyph(0xf0d0)]
        SolidMagic = 1403,
        ///<summary>Solid Hand Point Down</summary>
        ///<see href="https://fontawesome.com/icons/hand-point-down?style=solid"/>
        [Description("Solid Hand Point Down"), IconID("fas-hand-point-down"), IconUnicodeGlyph(0xf0a7)]
        SolidHandPointDown = 1404,
        ///<summary>Solid Bacon</summary>
        ///<see href="https://fontawesome.com/icons/bacon?style=solid"/>
        [Description("Solid Bacon"), IconID("fas-bacon"), IconUnicodeGlyph(0xf7e5)]
        SolidBacon = 1405,
        ///<summary>Solid Calendar Times</summary>
        ///<see href="https://fontawesome.com/icons/calendar-times?style=solid"/>
        [Description("Solid Calendar Times"), IconID("fas-calendar-times"), IconUnicodeGlyph(0xf273)]
        SolidCalendarTimes = 1406,
        ///<summary>Solid Bullseye</summary>
        ///<see href="https://fontawesome.com/icons/bullseye?style=solid"/>
        [Description("Solid Bullseye"), IconID("fas-bullseye"), IconUnicodeGlyph(0xf140)]
        SolidBullseye = 1407,
        ///<summary>Solid Umbrella Beach</summary>
        ///<see href="https://fontawesome.com/icons/umbrella-beach?style=solid"/>
        [Description("Solid Umbrella Beach"), IconID("fas-umbrella-beach"), IconUnicodeGlyph(0xf5ca)]
        SolidUmbrellaBeach = 1408,
        ///<summary>Solid Smoking Ban</summary>
        ///<see href="https://fontawesome.com/icons/smoking-ban?style=solid"/>
        [Description("Solid Smoking Ban"), IconID("fas-smoking-ban"), IconUnicodeGlyph(0xf54d)]
        SolidSmokingBan = 1409,
        ///<summary>Solid Medkit</summary>
        ///<see href="https://fontawesome.com/icons/medkit?style=solid"/>
        [Description("Solid Medkit"), IconID("fas-medkit"), IconUnicodeGlyph(0xf0fa)]
        SolidMedkit = 1410,
        ///<summary>Solid Align Justify</summary>
        ///<see href="https://fontawesome.com/icons/align-justify?style=solid"/>
        [Description("Solid Align Justify"), IconID("fas-align-justify"), IconUnicodeGlyph(0xf039)]
        SolidAlignJustify = 1411,
        ///<summary>Solid Bookmark</summary>
        ///<see href="https://fontawesome.com/icons/bookmark?style=solid"/>
        [Description("Solid Bookmark"), IconID("fas-bookmark"), IconUnicodeGlyph(0xf02e)]
        SolidBookmark = 1412,
        ///<summary>Solid Photo Video</summary>
        ///<see href="https://fontawesome.com/icons/photo-video?style=solid"/>
        [Description("Solid Photo Video"), IconID("fas-photo-video"), IconUnicodeGlyph(0xf87c)]
        SolidPhotoVideo = 1413,
        ///<summary>Solid Money Bill</summary>
        ///<see href="https://fontawesome.com/icons/money-bill?style=solid"/>
        [Description("Solid Money Bill"), IconID("fas-money-bill"), IconUnicodeGlyph(0xf0d6)]
        SolidMoneyBill = 1414,
        ///<summary>Solid Hand Point Up</summary>
        ///<see href="https://fontawesome.com/icons/hand-point-up?style=solid"/>
        [Description("Solid Hand Point Up"), IconID("fas-hand-point-up"), IconUnicodeGlyph(0xf0a6)]
        SolidHandPointUp = 1415,
        ///<summary>Solid Mail Bulk</summary>
        ///<see href="https://fontawesome.com/icons/mail-bulk?style=solid"/>
        [Description("Solid Mail Bulk"), IconID("fas-mail-bulk"), IconUnicodeGlyph(0xf674)]
        SolidMailBulk = 1416,
        ///<summary>Solid Check Square</summary>
        ///<see href="https://fontawesome.com/icons/check-square?style=solid"/>
        [Description("Solid Check Square"), IconID("fas-check-square"), IconUnicodeGlyph(0xf14a)]
        SolidCheckSquare = 1417,
        ///<summary>Solid Skiing</summary>
        ///<see href="https://fontawesome.com/icons/skiing?style=solid"/>
        [Description("Solid Skiing"), IconID("fas-skiing"), IconUnicodeGlyph(0xf7c9)]
        SolidSkiing = 1418,
        ///<summary>Solid Poo Storm</summary>
        ///<see href="https://fontawesome.com/icons/poo-storm?style=solid"/>
        [Description("Solid Poo Storm"), IconID("fas-poo-storm"), IconUnicodeGlyph(0xf75a)]
        SolidPooStorm = 1419,
        ///<summary>Solid Capsules</summary>
        ///<see href="https://fontawesome.com/icons/capsules?style=solid"/>
        [Description("Solid Capsules"), IconID("fas-capsules"), IconUnicodeGlyph(0xf46b)]
        SolidCapsules = 1420,
        ///<summary>Solid Phone Square</summary>
        ///<see href="https://fontawesome.com/icons/phone-square?style=solid"/>
        [Description("Solid Phone Square"), IconID("fas-phone-square"), IconUnicodeGlyph(0xf098)]
        SolidPhoneSquare = 1421,
        ///<summary>Solid Microphone Alt Slash</summary>
        ///<see href="https://fontawesome.com/icons/microphone-alt-slash?style=solid"/>
        [Description("Solid Microphone Alt Slash"), IconID("fas-microphone-alt-slash"), IconUnicodeGlyph(0xf539)]
        SolidMicrophoneAltSlash = 1422,
        ///<summary>Solid Notes Medical</summary>
        ///<see href="https://fontawesome.com/icons/notes-medical?style=solid"/>
        [Description("Solid Notes Medical"), IconID("fas-notes-medical"), IconUnicodeGlyph(0xf481)]
        SolidNotesMedical = 1423,
        ///<summary>Solid Grin Alt</summary>
        ///<see href="https://fontawesome.com/icons/grin-alt?style=solid"/>
        [Description("Solid Grin Alt"), IconID("fas-grin-alt"), IconUnicodeGlyph(0xf581)]
        SolidGrinAlt = 1424,
        ///<summary>Solid Horse</summary>
        ///<see href="https://fontawesome.com/icons/horse?style=solid"/>
        [Description("Solid Horse"), IconID("fas-horse"), IconUnicodeGlyph(0xf6f0)]
        SolidHorse = 1425,
        ///<summary>Solid Angle Right</summary>
        ///<see href="https://fontawesome.com/icons/angle-right?style=solid"/>
        [Description("Solid Angle Right"), IconID("fas-angle-right"), IconUnicodeGlyph(0xf105)]
        SolidAngleRight = 1426,
        ///<summary>Solid Caret Square Up</summary>
        ///<see href="https://fontawesome.com/icons/caret-square-up?style=solid"/>
        [Description("Solid Caret Square Up"), IconID("fas-caret-square-up"), IconUnicodeGlyph(0xf151)]
        SolidCaretSquareUp = 1427,
        ///<summary>Solid Joint</summary>
        ///<see href="https://fontawesome.com/icons/joint?style=solid"/>
        [Description("Solid Joint"), IconID("fas-joint"), IconUnicodeGlyph(0xf595)]
        SolidJoint = 1428,
        ///<summary>Solid Archive</summary>
        ///<see href="https://fontawesome.com/icons/archive?style=solid"/>
        [Description("Solid Archive"), IconID("fas-archive"), IconUnicodeGlyph(0xf187)]
        SolidArchive = 1429,
        ///<summary>Solid Igloo</summary>
        ///<see href="https://fontawesome.com/icons/igloo?style=solid"/>
        [Description("Solid Igloo"), IconID("fas-igloo"), IconUnicodeGlyph(0xf7ae)]
        SolidIgloo = 1430,
        ///<summary>Solid School</summary>
        ///<see href="https://fontawesome.com/icons/school?style=solid"/>
        [Description("Solid School"), IconID("fas-school"), IconUnicodeGlyph(0xf549)]
        SolidSchool = 1431,
        ///<summary>Solid Mortar Pestle</summary>
        ///<see href="https://fontawesome.com/icons/mortar-pestle?style=solid"/>
        [Description("Solid Mortar Pestle"), IconID("fas-mortar-pestle"), IconUnicodeGlyph(0xf5a7)]
        SolidMortarPestle = 1432,
        ///<summary>Solid Shuttle Van</summary>
        ///<see href="https://fontawesome.com/icons/shuttle-van?style=solid"/>
        [Description("Solid Shuttle Van"), IconID("fas-shuttle-van"), IconUnicodeGlyph(0xf5b6)]
        SolidShuttleVan = 1433,
        ///<summary>Solid Snowman</summary>
        ///<see href="https://fontawesome.com/icons/snowman?style=solid"/>
        [Description("Solid Snowman"), IconID("fas-snowman"), IconUnicodeGlyph(0xf7d0)]
        SolidSnowman = 1434,
        ///<summary>Solid Head Side Cough Slash</summary>
        ///<see href="https://fontawesome.com/icons/head-side-cough-slash?style=solid"/>
        [Description("Solid Head Side Cough Slash"), IconID("fas-head-side-cough-slash"), IconUnicodeGlyph(0xe062)]
        SolidHeadSideCoughSlash = 1435,
        ///<summary>Solid Bicycle</summary>
        ///<see href="https://fontawesome.com/icons/bicycle?style=solid"/>
        [Description("Solid Bicycle"), IconID("fas-bicycle"), IconUnicodeGlyph(0xf206)]
        SolidBicycle = 1436,
        ///<summary>Solid Tenge</summary>
        ///<see href="https://fontawesome.com/icons/tenge?style=solid"/>
        [Description("Solid Tenge"), IconID("fas-tenge"), IconUnicodeGlyph(0xf7d7)]
        SolidTenge = 1437,
        ///<summary>Solid Plus Square</summary>
        ///<see href="https://fontawesome.com/icons/plus-square?style=solid"/>
        [Description("Solid Plus Square"), IconID("fas-plus-square"), IconUnicodeGlyph(0xf0fe)]
        SolidPlusSquare = 1438,
        ///<summary>Solid Tooth</summary>
        ///<see href="https://fontawesome.com/icons/tooth?style=solid"/>
        [Description("Solid Tooth"), IconID("fas-tooth"), IconUnicodeGlyph(0xf5c9)]
        SolidTooth = 1439,
        ///<summary>Solid Pills</summary>
        ///<see href="https://fontawesome.com/icons/pills?style=solid"/>
        [Description("Solid Pills"), IconID("fas-pills"), IconUnicodeGlyph(0xf484)]
        SolidPills = 1440,
        ///<summary>Solid Arrow Alt Circle Right</summary>
        ///<see href="https://fontawesome.com/icons/arrow-alt-circle-right?style=solid"/>
        [Description("Solid Arrow Alt Circle Right"), IconID("fas-arrow-alt-circle-right"), IconUnicodeGlyph(0xf35a)]
        SolidArrowAltCircleRight = 1441,
        ///<summary>Solid Plus Circle</summary>
        ///<see href="https://fontawesome.com/icons/plus-circle?style=solid"/>
        [Description("Solid Plus Circle"), IconID("fas-plus-circle"), IconUnicodeGlyph(0xf055)]
        SolidPlusCircle = 1442,
        ///<summary>Solid Stamp</summary>
        ///<see href="https://fontawesome.com/icons/stamp?style=solid"/>
        [Description("Solid Stamp"), IconID("fas-stamp"), IconUnicodeGlyph(0xf5bf)]
        SolidStamp = 1443,
        ///<summary>Solid Arrow Alt Circle Up</summary>
        ///<see href="https://fontawesome.com/icons/arrow-alt-circle-up?style=solid"/>
        [Description("Solid Arrow Alt Circle Up"), IconID("fas-arrow-alt-circle-up"), IconUnicodeGlyph(0xf35b)]
        SolidArrowAltCircleUp = 1444,
        ///<summary>Solid I Cursor</summary>
        ///<see href="https://fontawesome.com/icons/i-cursor?style=solid"/>
        [Description("Solid I Cursor"), IconID("fas-i-cursor"), IconUnicodeGlyph(0xf246)]
        SolidICursor = 1445,
        ///<summary>Solid Arrow Alt Circle Down</summary>
        ///<see href="https://fontawesome.com/icons/arrow-alt-circle-down?style=solid"/>
        [Description("Solid Arrow Alt Circle Down"), IconID("fas-arrow-alt-circle-down"), IconUnicodeGlyph(0xf358)]
        SolidArrowAltCircleDown = 1446,
        ///<summary>Solid Dice Five</summary>
        ///<see href="https://fontawesome.com/icons/dice-five?style=solid"/>
        [Description("Solid Dice Five"), IconID("fas-dice-five"), IconUnicodeGlyph(0xf523)]
        SolidDiceFive = 1447,
        ///<summary>Solid Caret Square Left</summary>
        ///<see href="https://fontawesome.com/icons/caret-square-left?style=solid"/>
        [Description("Solid Caret Square Left"), IconID("fas-caret-square-left"), IconUnicodeGlyph(0xf191)]
        SolidCaretSquareLeft = 1448,
        ///<summary>Solid Chess Bishop</summary>
        ///<see href="https://fontawesome.com/icons/chess-bishop?style=solid"/>
        [Description("Solid Chess Bishop"), IconID("fas-chess-bishop"), IconUnicodeGlyph(0xf43a)]
        SolidChessBishop = 1449,
        ///<summary>Solid Sort Numeric Up Alt</summary>
        ///<see href="https://fontawesome.com/icons/sort-numeric-up-alt?style=solid"/>
        [Description("Solid Sort Numeric Up Alt"), IconID("fas-sort-numeric-up-alt"), IconUnicodeGlyph(0xf887)]
        SolidSortNumericUpAlt = 1450,
        ///<summary>Solid History</summary>
        ///<see href="https://fontawesome.com/icons/history?style=solid"/>
        [Description("Solid History"), IconID("fas-history"), IconUnicodeGlyph(0xf1da)]
        SolidHistory = 1451,
        ///<summary>Solid Star Half Alt</summary>
        ///<see href="https://fontawesome.com/icons/star-half-alt?style=solid"/>
        [Description("Solid Star Half Alt"), IconID("fas-star-half-alt"), IconUnicodeGlyph(0xf5c0)]
        SolidStarHalfAlt = 1452,
        ///<summary>Solid Weight</summary>
        ///<see href="https://fontawesome.com/icons/weight?style=solid"/>
        [Description("Solid Weight"), IconID("fas-weight"), IconUnicodeGlyph(0xf496)]
        SolidWeight = 1453,
        ///<summary>Solid Percentage</summary>
        ///<see href="https://fontawesome.com/icons/percentage?style=solid"/>
        [Description("Solid Percentage"), IconID("fas-percentage"), IconUnicodeGlyph(0xf541)]
        SolidPercentage = 1454,
        ///<summary>Solid Pencil Ruler</summary>
        ///<see href="https://fontawesome.com/icons/pencil-ruler?style=solid"/>
        [Description("Solid Pencil Ruler"), IconID("fas-pencil-ruler"), IconUnicodeGlyph(0xf5ae)]
        SolidPencilRuler = 1455,
        ///<summary>Solid Stopwatch</summary>
        ///<see href="https://fontawesome.com/icons/stopwatch?style=solid"/>
        [Description("Solid Stopwatch"), IconID("fas-stopwatch"), IconUnicodeGlyph(0xf2f2)]
        SolidStopwatch = 1456,
        ///<summary>Solid Smile Beam</summary>
        ///<see href="https://fontawesome.com/icons/smile-beam?style=solid"/>
        [Description("Solid Smile Beam"), IconID("fas-smile-beam"), IconUnicodeGlyph(0xf5b8)]
        SolidSmileBeam = 1457,
        ///<summary>Solid Hand Spock</summary>
        ///<see href="https://fontawesome.com/icons/hand-spock?style=solid"/>
        [Description("Solid Hand Spock"), IconID("fas-hand-spock"), IconUnicodeGlyph(0xf259)]
        SolidHandSpock = 1458,
        ///<summary>Solid Chevron Up</summary>
        ///<see href="https://fontawesome.com/icons/chevron-up?style=solid"/>
        [Description("Solid Chevron Up"), IconID("fas-chevron-up"), IconUnicodeGlyph(0xf077)]
        SolidChevronUp = 1459,
        ///<summary>Solid Exchange Alt</summary>
        ///<see href="https://fontawesome.com/icons/exchange-alt?style=solid"/>
        [Description("Solid Exchange Alt"), IconID("fas-exchange-alt"), IconUnicodeGlyph(0xf362)]
        SolidExchangeAlt = 1460,
        ///<summary>Solid Hospital Alt</summary>
        ///<see href="https://fontawesome.com/icons/hospital-alt?style=solid"/>
        [Description("Solid Hospital Alt"), IconID("fas-hospital-alt"), IconUnicodeGlyph(0xf47d)]
        SolidHospitalAlt = 1461,
        ///<summary>Solid Grin Beam Sweat</summary>
        ///<see href="https://fontawesome.com/icons/grin-beam-sweat?style=solid"/>
        [Description("Solid Grin Beam Sweat"), IconID("fas-grin-beam-sweat"), IconUnicodeGlyph(0xf583)]
        SolidGrinBeamSweat = 1462,
        ///<summary>Solid Plug</summary>
        ///<see href="https://fontawesome.com/icons/plug?style=solid"/>
        [Description("Solid Plug"), IconID("fas-plug"), IconUnicodeGlyph(0xf1e6)]
        SolidPlug = 1463,
        ///<summary>Solid Long Arrow Alt Left</summary>
        ///<see href="https://fontawesome.com/icons/long-arrow-alt-left?style=solid"/>
        [Description("Solid Long Arrow Alt Left"), IconID("fas-long-arrow-alt-left"), IconUnicodeGlyph(0xf30a)]
        SolidLongArrowAltLeft = 1464,
        ///<summary>Solid Om</summary>
        ///<see href="https://fontawesome.com/icons/om?style=solid"/>
        [Description("Solid Om"), IconID("fas-om"), IconUnicodeGlyph(0xf679)]
        SolidOm = 1465,
        ///<summary>Solid Surprise</summary>
        ///<see href="https://fontawesome.com/icons/surprise?style=solid"/>
        [Description("Solid Surprise"), IconID("fas-surprise"), IconUnicodeGlyph(0xf5c2)]
        SolidSurprise = 1466,
        ///<summary>Solid Caret Square Right</summary>
        ///<see href="https://fontawesome.com/icons/caret-square-right?style=solid"/>
        [Description("Solid Caret Square Right"), IconID("fas-caret-square-right"), IconUnicodeGlyph(0xf152)]
        SolidCaretSquareRight = 1467,
        ///<summary>Solid Random</summary>
        ///<see href="https://fontawesome.com/icons/random?style=solid"/>
        [Description("Solid Random"), IconID("fas-random"), IconUnicodeGlyph(0xf074)]
        SolidRandom = 1468,
        ///<summary>Solid Eye Slash</summary>
        ///<see href="https://fontawesome.com/icons/eye-slash?style=solid"/>
        [Description("Solid Eye Slash"), IconID("fas-eye-slash"), IconUnicodeGlyph(0xf070)]
        SolidEyeSlash = 1469,
        ///<summary>Solid Users</summary>
        ///<see href="https://fontawesome.com/icons/users?style=solid"/>
        [Description("Solid Users"), IconID("fas-users"), IconUnicodeGlyph(0xf0c0)]
        SolidUsers = 1470,
        ///<summary>Solid Mitten</summary>
        ///<see href="https://fontawesome.com/icons/mitten?style=solid"/>
        [Description("Solid Mitten"), IconID("fas-mitten"), IconUnicodeGlyph(0xf7b5)]
        SolidMitten = 1471,
        ///<summary>Solid Stream</summary>
        ///<see href="https://fontawesome.com/icons/stream?style=solid"/>
        [Description("Solid Stream"), IconID("fas-stream"), IconUnicodeGlyph(0xf550)]
        SolidStream = 1472,
        ///<summary>Solid Sink</summary>
        ///<see href="https://fontawesome.com/icons/sink?style=solid"/>
        [Description("Solid Sink"), IconID("fas-sink"), IconUnicodeGlyph(0xe06d)]
        SolidSink = 1473,
        ///<summary>Solid Microscope</summary>
        ///<see href="https://fontawesome.com/icons/microscope?style=solid"/>
        [Description("Solid Microscope"), IconID("fas-microscope"), IconUnicodeGlyph(0xf610)]
        SolidMicroscope = 1474,
        ///<summary>Solid Hourglass Half</summary>
        ///<see href="https://fontawesome.com/icons/hourglass-half?style=solid"/>
        [Description("Solid Hourglass Half"), IconID("fas-hourglass-half"), IconUnicodeGlyph(0xf252)]
        SolidHourglassHalf = 1475,
        ///<summary>Solid Car Side</summary>
        ///<see href="https://fontawesome.com/icons/car-side?style=solid"/>
        [Description("Solid Car Side"), IconID("fas-car-side"), IconUnicodeGlyph(0xf5e4)]
        SolidCarSide = 1476,
        ///<summary>Solid Arrows Alt V</summary>
        ///<see href="https://fontawesome.com/icons/arrows-alt-v?style=solid"/>
        [Description("Solid Arrows Alt V"), IconID("fas-arrows-alt-v"), IconUnicodeGlyph(0xf338)]
        SolidArrowsAltV = 1477,
        ///<summary>Solid Fist Raised</summary>
        ///<see href="https://fontawesome.com/icons/fist-raised?style=solid"/>
        [Description("Solid Fist Raised"), IconID("fas-fist-raised"), IconUnicodeGlyph(0xf6de)]
        SolidFistRaised = 1478,
        ///<summary>Solid Tree</summary>
        ///<see href="https://fontawesome.com/icons/tree?style=solid"/>
        [Description("Solid Tree"), IconID("fas-tree"), IconUnicodeGlyph(0xf1bb)]
        SolidTree = 1479,
        ///<summary>Solid Paint Brush</summary>
        ///<see href="https://fontawesome.com/icons/paint-brush?style=solid"/>
        [Description("Solid Paint Brush"), IconID("fas-paint-brush"), IconUnicodeGlyph(0xf1fc)]
        SolidPaintBrush = 1480,
        ///<summary>Solid Gas Pump</summary>
        ///<see href="https://fontawesome.com/icons/gas-pump?style=solid"/>
        [Description("Solid Gas Pump"), IconID("fas-gas-pump"), IconUnicodeGlyph(0xf52f)]
        SolidGasPump = 1481,
        ///<summary>Solid Frown Open</summary>
        ///<see href="https://fontawesome.com/icons/frown-open?style=solid"/>
        [Description("Solid Frown Open"), IconID("fas-frown-open"), IconUnicodeGlyph(0xf57a)]
        SolidFrownOpen = 1482,
        ///<summary>Solid Lock</summary>
        ///<see href="https://fontawesome.com/icons/lock?style=solid"/>
        [Description("Solid Lock"), IconID("fas-lock"), IconUnicodeGlyph(0xf023)]
        SolidLock = 1483,
        ///<summary>Solid Futbol</summary>
        ///<see href="https://fontawesome.com/icons/futbol?style=solid"/>
        [Description("Solid Futbol"), IconID("fas-futbol"), IconUnicodeGlyph(0xf1e3)]
        SolidFutbol = 1484,
        ///<summary>Solid Folder Plus</summary>
        ///<see href="https://fontawesome.com/icons/folder-plus?style=solid"/>
        [Description("Solid Folder Plus"), IconID("fas-folder-plus"), IconUnicodeGlyph(0xf65e)]
        SolidFolderPlus = 1485,
        ///<summary>Solid Campground</summary>
        ///<see href="https://fontawesome.com/icons/campground?style=solid"/>
        [Description("Solid Campground"), IconID("fas-campground"), IconUnicodeGlyph(0xf6bb)]
        SolidCampground = 1486,
        ///<summary>Solid Egg</summary>
        ///<see href="https://fontawesome.com/icons/egg?style=solid"/>
        [Description("Solid Egg"), IconID("fas-egg"), IconUnicodeGlyph(0xf7fb)]
        SolidEgg = 1487,
        ///<summary>Solid Gamepad</summary>
        ///<see href="https://fontawesome.com/icons/gamepad?style=solid"/>
        [Description("Solid Gamepad"), IconID("fas-gamepad"), IconUnicodeGlyph(0xf11b)]
        SolidGamepad = 1488,
        ///<summary>Solid Cart Plus</summary>
        ///<see href="https://fontawesome.com/icons/cart-plus?style=solid"/>
        [Description("Solid Cart Plus"), IconID("fas-cart-plus"), IconUnicodeGlyph(0xf217)]
        SolidCartPlus = 1489,
        ///<summary>Solid List</summary>
        ///<see href="https://fontawesome.com/icons/list?style=solid"/>
        [Description("Solid List"), IconID("fas-list"), IconUnicodeGlyph(0xf03a)]
        SolidList = 1490,
        ///<summary>Solid Ghost</summary>
        ///<see href="https://fontawesome.com/icons/ghost?style=solid"/>
        [Description("Solid Ghost"), IconID("fas-ghost"), IconUnicodeGlyph(0xf6e2)]
        SolidGhost = 1491,
        ///<summary>Solid Heading</summary>
        ///<see href="https://fontawesome.com/icons/heading?style=solid"/>
        [Description("Solid Heading"), IconID("fas-heading"), IconUnicodeGlyph(0xf1dc)]
        SolidHeading = 1492,
        ///<summary>Solid Kiss Wink Heart</summary>
        ///<see href="https://fontawesome.com/icons/kiss-wink-heart?style=solid"/>
        [Description("Solid Kiss Wink Heart"), IconID("fas-kiss-wink-heart"), IconUnicodeGlyph(0xf598)]
        SolidKissWinkHeart = 1493,
        ///<summary>Solid Mars Stroke H</summary>
        ///<see href="https://fontawesome.com/icons/mars-stroke-h?style=solid"/>
        [Description("Solid Mars Stroke H"), IconID("fas-mars-stroke-h"), IconUnicodeGlyph(0xf22b)]
        SolidMarsStrokeH = 1494,
        ///<summary>Solid Level Up Alt</summary>
        ///<see href="https://fontawesome.com/icons/level-up-alt?style=solid"/>
        [Description("Solid Level Up Alt"), IconID("fas-level-up-alt"), IconUnicodeGlyph(0xf3bf)]
        SolidLevelUpAlt = 1495,
        ///<summary>Solid Asterisk</summary>
        ///<see href="https://fontawesome.com/icons/asterisk?style=solid"/>
        [Description("Solid Asterisk"), IconID("fas-asterisk"), IconUnicodeGlyph(0xf069)]
        SolidAsterisk = 1496,
        ///<summary>Solid Ankh</summary>
        ///<see href="https://fontawesome.com/icons/ankh?style=solid"/>
        [Description("Solid Ankh"), IconID("fas-ankh"), IconUnicodeGlyph(0xf644)]
        SolidAnkh = 1497,
        ///<summary>Solid Compress</summary>
        ///<see href="https://fontawesome.com/icons/compress?style=solid"/>
        [Description("Solid Compress"), IconID("fas-compress"), IconUnicodeGlyph(0xf066)]
        SolidCompress = 1498,
        ///<summary>Solid Cloud Sun Rain</summary>
        ///<see href="https://fontawesome.com/icons/cloud-sun-rain?style=solid"/>
        [Description("Solid Cloud Sun Rain"), IconID("fas-cloud-sun-rain"), IconUnicodeGlyph(0xf743)]
        SolidCloudSunRain = 1499,
        ///<summary>Solid Digital Tachograph</summary>
        ///<see href="https://fontawesome.com/icons/digital-tachograph?style=solid"/>
        [Description("Solid Digital Tachograph"), IconID("fas-digital-tachograph"), IconUnicodeGlyph(0xf566)]
        SolidDigitalTachograph = 1500,
        ///<summary>Solid Comment Slash</summary>
        ///<see href="https://fontawesome.com/icons/comment-slash?style=solid"/>
        [Description("Solid Comment Slash"), IconID("fas-comment-slash"), IconUnicodeGlyph(0xf4b3)]
        SolidCommentSlash = 1501,
        ///<summary>Solid Feather</summary>
        ///<see href="https://fontawesome.com/icons/feather?style=solid"/>
        [Description("Solid Feather"), IconID("fas-feather"), IconUnicodeGlyph(0xf52d)]
        SolidFeather = 1502,
        ///<summary>Solid Shopping Cart</summary>
        ///<see href="https://fontawesome.com/icons/shopping-cart?style=solid"/>
        [Description("Solid Shopping Cart"), IconID("fas-shopping-cart"), IconUnicodeGlyph(0xf07a)]
        SolidShoppingCart = 1503,
        ///<summary>Solid Hanukiah</summary>
        ///<see href="https://fontawesome.com/icons/hanukiah?style=solid"/>
        [Description("Solid Hanukiah"), IconID("fas-hanukiah"), IconUnicodeGlyph(0xf6e6)]
        SolidHanukiah = 1504,
        ///<summary>Solid Flag</summary>
        ///<see href="https://fontawesome.com/icons/flag?style=solid"/>
        [Description("Solid Flag"), IconID("fas-flag"), IconUnicodeGlyph(0xf024)]
        SolidFlag = 1505,
        ///<summary>Solid Memory</summary>
        ///<see href="https://fontawesome.com/icons/memory?style=solid"/>
        [Description("Solid Memory"), IconID("fas-memory"), IconUnicodeGlyph(0xf538)]
        SolidMemory = 1506,
        ///<summary>Solid Sitemap</summary>
        ///<see href="https://fontawesome.com/icons/sitemap?style=solid"/>
        [Description("Solid Sitemap"), IconID("fas-sitemap"), IconUnicodeGlyph(0xf0e8)]
        SolidSitemap = 1507,
        ///<summary>Solid Cloud Showers Heavy</summary>
        ///<see href="https://fontawesome.com/icons/cloud-showers-heavy?style=solid"/>
        [Description("Solid Cloud Showers Heavy"), IconID("fas-cloud-showers-heavy"), IconUnicodeGlyph(0xf740)]
        SolidCloudShowersHeavy = 1508,
        ///<summary>Solid Caret Left</summary>
        ///<see href="https://fontawesome.com/icons/caret-left?style=solid"/>
        [Description("Solid Caret Left"), IconID("fas-caret-left"), IconUnicodeGlyph(0xf0d9)]
        SolidCaretLeft = 1509,
        ///<summary>Solid Lightbulb</summary>
        ///<see href="https://fontawesome.com/icons/lightbulb?style=solid"/>
        [Description("Solid Lightbulb"), IconID("fas-lightbulb"), IconUnicodeGlyph(0xf0eb)]
        SolidLightbulb = 1510,
        ///<summary>Solid Fast Forward</summary>
        ///<see href="https://fontawesome.com/icons/fast-forward?style=solid"/>
        [Description("Solid Fast Forward"), IconID("fas-fast-forward"), IconUnicodeGlyph(0xf050)]
        SolidFastForward = 1511,
        ///<summary>Solid Ruler Horizontal</summary>
        ///<see href="https://fontawesome.com/icons/ruler-horizontal?style=solid"/>
        [Description("Solid Ruler Horizontal"), IconID("fas-ruler-horizontal"), IconUnicodeGlyph(0xf547)]
        SolidRulerHorizontal = 1512,
        ///<summary>Solid Film</summary>
        ///<see href="https://fontawesome.com/icons/film?style=solid"/>
        [Description("Solid Film"), IconID("fas-film"), IconUnicodeGlyph(0xf008)]
        SolidFilm = 1513,
        ///<summary>Solid Grin Tears</summary>
        ///<see href="https://fontawesome.com/icons/grin-tears?style=solid"/>
        [Description("Solid Grin Tears"), IconID("fas-grin-tears"), IconUnicodeGlyph(0xf588)]
        SolidGrinTears = 1514,
        ///<summary>Solid Hourglass End</summary>
        ///<see href="https://fontawesome.com/icons/hourglass-end?style=solid"/>
        [Description("Solid Hourglass End"), IconID("fas-hourglass-end"), IconUnicodeGlyph(0xf253)]
        SolidHourglassEnd = 1515,
        ///<summary>Solid Bars</summary>
        ///<see href="https://fontawesome.com/icons/bars?style=solid"/>
        [Description("Solid Bars"), IconID("fas-bars"), IconUnicodeGlyph(0xf0c9)]
        SolidBars = 1516,
        ///<summary>Solid Prescription Bottle</summary>
        ///<see href="https://fontawesome.com/icons/prescription-bottle?style=solid"/>
        [Description("Solid Prescription Bottle"), IconID("fas-prescription-bottle"), IconUnicodeGlyph(0xf485)]
        SolidPrescriptionBottle = 1517,
        ///<summary>Solid Swatchbook</summary>
        ///<see href="https://fontawesome.com/icons/swatchbook?style=solid"/>
        [Description("Solid Swatchbook"), IconID("fas-swatchbook"), IconUnicodeGlyph(0xf5c3)]
        SolidSwatchbook = 1518,
        ///<summary>Solid Laptop Code</summary>
        ///<see href="https://fontawesome.com/icons/laptop-code?style=solid"/>
        [Description("Solid Laptop Code"), IconID("fas-laptop-code"), IconUnicodeGlyph(0xf5fc)]
        SolidLaptopCode = 1519,
        ///<summary>Solid Compass</summary>
        ///<see href="https://fontawesome.com/icons/compass?style=solid"/>
        [Description("Solid Compass"), IconID("fas-compass"), IconUnicodeGlyph(0xf14e)]
        SolidCompass = 1520,
        ///<summary>Solid Male</summary>
        ///<see href="https://fontawesome.com/icons/male?style=solid"/>
        [Description("Solid Male"), IconID("fas-male"), IconUnicodeGlyph(0xf183)]
        SolidMale = 1521,
        ///<summary>Solid Helicopter</summary>
        ///<see href="https://fontawesome.com/icons/helicopter?style=solid"/>
        [Description("Solid Helicopter"), IconID("fas-helicopter"), IconUnicodeGlyph(0xf533)]
        SolidHelicopter = 1522,
        ///<summary>Solid Sort Numeric Up</summary>
        ///<see href="https://fontawesome.com/icons/sort-numeric-up?style=solid"/>
        [Description("Solid Sort Numeric Up"), IconID("fas-sort-numeric-up"), IconUnicodeGlyph(0xf163)]
        SolidSortNumericUp = 1523,
        ///<summary>Solid Star And Crescent</summary>
        ///<see href="https://fontawesome.com/icons/star-and-crescent?style=solid"/>
        [Description("Solid Star And Crescent"), IconID("fas-star-and-crescent"), IconUnicodeGlyph(0xf699)]
        SolidStarAndCrescent = 1524,
        ///<summary>Solid House Damage</summary>
        ///<see href="https://fontawesome.com/icons/house-damage?style=solid"/>
        [Description("Solid House Damage"), IconID("fas-house-damage"), IconUnicodeGlyph(0xf6f1)]
        SolidHouseDamage = 1525,
        ///<summary>Solid Reply</summary>
        ///<see href="https://fontawesome.com/icons/reply?style=solid"/>
        [Description("Solid Reply"), IconID("fas-reply"), IconUnicodeGlyph(0xf3e5)]
        SolidReply = 1526,
        ///<summary>Solid Users Slash</summary>
        ///<see href="https://fontawesome.com/icons/users-slash?style=solid"/>
        [Description("Solid Users Slash"), IconID("fas-users-slash"), IconUnicodeGlyph(0xe073)]
        SolidUsersSlash = 1527,
        ///<summary>Solid Shipping Fast</summary>
        ///<see href="https://fontawesome.com/icons/shipping-fast?style=solid"/>
        [Description("Solid Shipping Fast"), IconID("fas-shipping-fast"), IconUnicodeGlyph(0xf48b)]
        SolidShippingFast = 1528,
        ///<summary>Solid User Alt</summary>
        ///<see href="https://fontawesome.com/icons/user-alt?style=solid"/>
        [Description("Solid User Alt"), IconID("fas-user-alt"), IconUnicodeGlyph(0xf406)]
        SolidUserAlt = 1529,
        ///<summary>Solid Table</summary>
        ///<see href="https://fontawesome.com/icons/table?style=solid"/>
        [Description("Solid Table"), IconID("fas-table"), IconUnicodeGlyph(0xf0ce)]
        SolidTable = 1530,
        ///<summary>Solid Sad Cry</summary>
        ///<see href="https://fontawesome.com/icons/sad-cry?style=solid"/>
        [Description("Solid Sad Cry"), IconID("fas-sad-cry"), IconUnicodeGlyph(0xf5b3)]
        SolidSadCry = 1531,
        ///<summary>Solid Hockey Puck</summary>
        ///<see href="https://fontawesome.com/icons/hockey-puck?style=solid"/>
        [Description("Solid Hockey Puck"), IconID("fas-hockey-puck"), IconUnicodeGlyph(0xf453)]
        SolidHockeyPuck = 1532,
        ///<summary>Solid Step Backward</summary>
        ///<see href="https://fontawesome.com/icons/step-backward?style=solid"/>
        [Description("Solid Step Backward"), IconID("fas-step-backward"), IconUnicodeGlyph(0xf048)]
        SolidStepBackward = 1533,
        ///<summary>Solid Dot Circle</summary>
        ///<see href="https://fontawesome.com/icons/dot-circle?style=solid"/>
        [Description("Solid Dot Circle"), IconID("fas-dot-circle"), IconUnicodeGlyph(0xf192)]
        SolidDotCircle = 1534,
        ///<summary>Solid People Arrows</summary>
        ///<see href="https://fontawesome.com/icons/people-arrows?style=solid"/>
        [Description("Solid People Arrows"), IconID("fas-people-arrows"), IconUnicodeGlyph(0xe068)]
        SolidPeopleArrows = 1535,
        ///<summary>Solid Subway</summary>
        ///<see href="https://fontawesome.com/icons/subway?style=solid"/>
        [Description("Solid Subway"), IconID("fas-subway"), IconUnicodeGlyph(0xf239)]
        SolidSubway = 1536,
        ///<summary>Solid Motorcycle</summary>
        ///<see href="https://fontawesome.com/icons/motorcycle?style=solid"/>
        [Description("Solid Motorcycle"), IconID("fas-motorcycle"), IconUnicodeGlyph(0xf21c)]
        SolidMotorcycle = 1537,
        ///<summary>Solid Grin Beam</summary>
        ///<see href="https://fontawesome.com/icons/grin-beam?style=solid"/>
        [Description("Solid Grin Beam"), IconID("fas-grin-beam"), IconUnicodeGlyph(0xf582)]
        SolidGrinBeam = 1538,
        ///<summary>Solid Box Tissue</summary>
        ///<see href="https://fontawesome.com/icons/box-tissue?style=solid"/>
        [Description("Solid Box Tissue"), IconID("fas-box-tissue"), IconUnicodeGlyph(0xe05b)]
        SolidBoxTissue = 1539,
        ///<summary>Solid First Aid</summary>
        ///<see href="https://fontawesome.com/icons/first-aid?style=solid"/>
        [Description("Solid First Aid"), IconID("fas-first-aid"), IconUnicodeGlyph(0xf479)]
        SolidFirstAid = 1540,
        ///<summary>Solid Microphone Slash</summary>
        ///<see href="https://fontawesome.com/icons/microphone-slash?style=solid"/>
        [Description("Solid Microphone Slash"), IconID("fas-microphone-slash"), IconUnicodeGlyph(0xf131)]
        SolidMicrophoneSlash = 1541,
        ///<summary>Solid Binoculars</summary>
        ///<see href="https://fontawesome.com/icons/binoculars?style=solid"/>
        [Description("Solid Binoculars"), IconID("fas-binoculars"), IconUnicodeGlyph(0xf1e5)]
        SolidBinoculars = 1542,
        ///<summary>Solid User Circle</summary>
        ///<see href="https://fontawesome.com/icons/user-circle?style=solid"/>
        [Description("Solid User Circle"), IconID("fas-user-circle"), IconUnicodeGlyph(0xf2bd)]
        SolidUserCircle = 1543,
        ///<summary>Solid Gavel</summary>
        ///<see href="https://fontawesome.com/icons/gavel?style=solid"/>
        [Description("Solid Gavel"), IconID("fas-gavel"), IconUnicodeGlyph(0xf0e3)]
        SolidGavel = 1544,
        ///<summary>Solid Concierge Bell</summary>
        ///<see href="https://fontawesome.com/icons/concierge-bell?style=solid"/>
        [Description("Solid Concierge Bell"), IconID("fas-concierge-bell"), IconUnicodeGlyph(0xf562)]
        SolidConciergeBell = 1545,
        ///<summary>Solid Hospital User</summary>
        ///<see href="https://fontawesome.com/icons/hospital-user?style=solid"/>
        [Description("Solid Hospital User"), IconID("fas-hospital-user"), IconUnicodeGlyph(0xf80d)]
        SolidHospitalUser = 1546,
        ///<summary>Solid Cloud Download Alt</summary>
        ///<see href="https://fontawesome.com/icons/cloud-download-alt?style=solid"/>
        [Description("Solid Cloud Download Alt"), IconID("fas-cloud-download-alt"), IconUnicodeGlyph(0xf381)]
        SolidCloudDownloadAlt = 1547,
        ///<summary>Solid Shopping Basket</summary>
        ///<see href="https://fontawesome.com/icons/shopping-basket?style=solid"/>
        [Description("Solid Shopping Basket"), IconID("fas-shopping-basket"), IconUnicodeGlyph(0xf291)]
        SolidShoppingBasket = 1548,
        ///<summary>Solid Cloud</summary>
        ///<see href="https://fontawesome.com/icons/cloud?style=solid"/>
        [Description("Solid Cloud"), IconID("fas-cloud"), IconUnicodeGlyph(0xf0c2)]
        SolidCloud = 1549,
        ///<summary>Solid Paw</summary>
        ///<see href="https://fontawesome.com/icons/paw?style=solid"/>
        [Description("Solid Paw"), IconID("fas-paw"), IconUnicodeGlyph(0xf1b0)]
        SolidPaw = 1550,
        ///<summary>Solid Circle Notch</summary>
        ///<see href="https://fontawesome.com/icons/circle-notch?style=solid"/>
        [Description("Solid Circle Notch"), IconID("fas-circle-notch"), IconUnicodeGlyph(0xf1ce)]
        SolidCircleNotch = 1551,
        ///<summary>Solid Rainbow</summary>
        ///<see href="https://fontawesome.com/icons/rainbow?style=solid"/>
        [Description("Solid Rainbow"), IconID("fas-rainbow"), IconUnicodeGlyph(0xf75b)]
        SolidRainbow = 1552,
        ///<summary>Solid Truck Monster</summary>
        ///<see href="https://fontawesome.com/icons/truck-monster?style=solid"/>
        [Description("Solid Truck Monster"), IconID("fas-truck-monster"), IconUnicodeGlyph(0xf63b)]
        SolidTruckMonster = 1553,
        ///<summary>Solid Swimming Pool</summary>
        ///<see href="https://fontawesome.com/icons/swimming-pool?style=solid"/>
        [Description("Solid Swimming Pool"), IconID("fas-swimming-pool"), IconUnicodeGlyph(0xf5c5)]
        SolidSwimmingPool = 1554,
        ///<summary>Solid Spray Can</summary>
        ///<see href="https://fontawesome.com/icons/spray-can?style=solid"/>
        [Description("Solid Spray Can"), IconID("fas-spray-can"), IconUnicodeGlyph(0xf5bd)]
        SolidSprayCan = 1555,
        ///<summary>Solid Toggle Off</summary>
        ///<see href="https://fontawesome.com/icons/toggle-off?style=solid"/>
        [Description("Solid Toggle Off"), IconID("fas-toggle-off"), IconUnicodeGlyph(0xf204)]
        SolidToggleOff = 1556,
        ///<summary>Solid Sort Numeric Down</summary>
        ///<see href="https://fontawesome.com/icons/sort-numeric-down?style=solid"/>
        [Description("Solid Sort Numeric Down"), IconID("fas-sort-numeric-down"), IconUnicodeGlyph(0xf162)]
        SolidSortNumericDown = 1557,
        ///<summary>Solid Bible</summary>
        ///<see href="https://fontawesome.com/icons/bible?style=solid"/>
        [Description("Solid Bible"), IconID("fas-bible"), IconUnicodeGlyph(0xf647)]
        SolidBible = 1558,
        ///<summary>Solid User Ninja</summary>
        ///<see href="https://fontawesome.com/icons/user-ninja?style=solid"/>
        [Description("Solid User Ninja"), IconID("fas-user-ninja"), IconUnicodeGlyph(0xf504)]
        SolidUserNinja = 1559,
        ///<summary>Solid Blog</summary>
        ///<see href="https://fontawesome.com/icons/blog?style=solid"/>
        [Description("Solid Blog"), IconID("fas-blog"), IconUnicodeGlyph(0xf781)]
        SolidBlog = 1560,
        ///<summary>Solid External Link Square Alt</summary>
        ///<see href="https://fontawesome.com/icons/external-link-square-alt?style=solid"/>
        [Description("Solid External Link Square Alt"), IconID("fas-external-link-square-alt"), IconUnicodeGlyph(0xf360)]
        SolidExternalLinkSquareAlt = 1561,
        ///<summary>Solid User Check</summary>
        ///<see href="https://fontawesome.com/icons/user-check?style=solid"/>
        [Description("Solid User Check"), IconID("fas-user-check"), IconUnicodeGlyph(0xf4fc)]
        SolidUserCheck = 1562,
        ///<summary>Solid Clipboard List</summary>
        ///<see href="https://fontawesome.com/icons/clipboard-list?style=solid"/>
        [Description("Solid Clipboard List"), IconID("fas-clipboard-list"), IconUnicodeGlyph(0xf46d)]
        SolidClipboardList = 1563,
        ///<summary>Solid Paste</summary>
        ///<see href="https://fontawesome.com/icons/paste?style=solid"/>
        [Description("Solid Paste"), IconID("fas-paste"), IconUnicodeGlyph(0xf0ea)]
        SolidPaste = 1564,
        ///<summary>Solid Comments</summary>
        ///<see href="https://fontawesome.com/icons/comments?style=solid"/>
        [Description("Solid Comments"), IconID("fas-comments"), IconUnicodeGlyph(0xf086)]
        SolidComments = 1565,
        ///<summary>Solid Caret Right</summary>
        ///<see href="https://fontawesome.com/icons/caret-right?style=solid"/>
        [Description("Solid Caret Right"), IconID("fas-caret-right"), IconUnicodeGlyph(0xf0da)]
        SolidCaretRight = 1566,
        ///<summary>Solid Backward</summary>
        ///<see href="https://fontawesome.com/icons/backward?style=solid"/>
        [Description("Solid Backward"), IconID("fas-backward"), IconUnicodeGlyph(0xf04a)]
        SolidBackward = 1567,
        ///<summary>Solid User Times</summary>
        ///<see href="https://fontawesome.com/icons/user-times?style=solid"/>
        [Description("Solid User Times"), IconID("fas-user-times"), IconUnicodeGlyph(0xf235)]
        SolidUserTimes = 1568,
        ///<summary>Solid Strikethrough</summary>
        ///<see href="https://fontawesome.com/icons/strikethrough?style=solid"/>
        [Description("Solid Strikethrough"), IconID("fas-strikethrough"), IconUnicodeGlyph(0xf0cc)]
        SolidStrikethrough = 1569,
        ///<summary>Solid Chevron Circle Up</summary>
        ///<see href="https://fontawesome.com/icons/chevron-circle-up?style=solid"/>
        [Description("Solid Chevron Circle Up"), IconID("fas-chevron-circle-up"), IconUnicodeGlyph(0xf139)]
        SolidChevronCircleUp = 1570,
        ///<summary>Solid Address Book</summary>
        ///<see href="https://fontawesome.com/icons/address-book?style=solid"/>
        [Description("Solid Address Book"), IconID("fas-address-book"), IconUnicodeGlyph(0xf2b9)]
        SolidAddressBook = 1571,
        ///<summary>Solid Pager</summary>
        ///<see href="https://fontawesome.com/icons/pager?style=solid"/>
        [Description("Solid Pager"), IconID("fas-pager"), IconUnicodeGlyph(0xf815)]
        SolidPager = 1572,
        ///<summary>Solid Long Arrow Alt Down</summary>
        ///<see href="https://fontawesome.com/icons/long-arrow-alt-down?style=solid"/>
        [Description("Solid Long Arrow Alt Down"), IconID("fas-long-arrow-alt-down"), IconUnicodeGlyph(0xf309)]
        SolidLongArrowAltDown = 1573,
        ///<summary>Solid Cogs</summary>
        ///<see href="https://fontawesome.com/icons/cogs?style=solid"/>
        [Description("Solid Cogs"), IconID("fas-cogs"), IconUnicodeGlyph(0xf085)]
        SolidCogs = 1574,
        ///<summary>Solid Bong</summary>
        ///<see href="https://fontawesome.com/icons/bong?style=solid"/>
        [Description("Solid Bong"), IconID("fas-bong"), IconUnicodeGlyph(0xf55c)]
        SolidBong = 1575,
        ///<summary>Solid Record Vinyl</summary>
        ///<see href="https://fontawesome.com/icons/record-vinyl?style=solid"/>
        [Description("Solid Record Vinyl"), IconID("fas-record-vinyl"), IconUnicodeGlyph(0xf8d9)]
        SolidRecordVinyl = 1576,
        ///<summary>Solid Menorah</summary>
        ///<see href="https://fontawesome.com/icons/menorah?style=solid"/>
        [Description("Solid Menorah"), IconID("fas-menorah"), IconUnicodeGlyph(0xf676)]
        SolidMenorah = 1577,
        ///<summary>Solid File Csv</summary>
        ///<see href="https://fontawesome.com/icons/file-csv?style=solid"/>
        [Description("Solid File Csv"), IconID("fas-file-csv"), IconUnicodeGlyph(0xf6dd)]
        SolidFileCsv = 1578,
        ///<summary>Solid Laptop</summary>
        ///<see href="https://fontawesome.com/icons/laptop?style=solid"/>
        [Description("Solid Laptop"), IconID("fas-laptop"), IconUnicodeGlyph(0xf109)]
        SolidLaptop = 1579,
        ///<summary>Solid Ad</summary>
        ///<see href="https://fontawesome.com/icons/ad?style=solid"/>
        [Description("Solid Ad"), IconID("fas-ad"), IconUnicodeGlyph(0xf641)]
        SolidAd = 1580,
        ///<summary>Solid Times Circle</summary>
        ///<see href="https://fontawesome.com/icons/times-circle?style=solid"/>
        [Description("Solid Times Circle"), IconID("fas-times-circle"), IconUnicodeGlyph(0xf057)]
        SolidTimesCircle = 1581,
        ///<summary>Solid Crop</summary>
        ///<see href="https://fontawesome.com/icons/crop?style=solid"/>
        [Description("Solid Crop"), IconID("fas-crop"), IconUnicodeGlyph(0xf125)]
        SolidCrop = 1582,
        ///<summary>Solid Pastafarianism</summary>
        ///<see href="https://fontawesome.com/icons/pastafarianism?style=solid"/>
        [Description("Solid Pastafarianism"), IconID("fas-pastafarianism"), IconUnicodeGlyph(0xf67b)]
        SolidPastafarianism = 1583,
        ///<summary>Solid Flag Checkered</summary>
        ///<see href="https://fontawesome.com/icons/flag-checkered?style=solid"/>
        [Description("Solid Flag Checkered"), IconID("fas-flag-checkered"), IconUnicodeGlyph(0xf11e)]
        SolidFlagCheckered = 1584,
        ///<summary>Solid Journal Whills</summary>
        ///<see href="https://fontawesome.com/icons/journal-whills?style=solid"/>
        [Description("Solid Journal Whills"), IconID("fas-journal-whills"), IconUnicodeGlyph(0xf66a)]
        SolidJournalWhills = 1585,
        ///<summary>Solid Hand Point Right</summary>
        ///<see href="https://fontawesome.com/icons/hand-point-right?style=solid"/>
        [Description("Solid Hand Point Right"), IconID("fas-hand-point-right"), IconUnicodeGlyph(0xf0a4)]
        SolidHandPointRight = 1586,
        ///<summary>Solid Pray</summary>
        ///<see href="https://fontawesome.com/icons/pray?style=solid"/>
        [Description("Solid Pray"), IconID("fas-pray"), IconUnicodeGlyph(0xf683)]
        SolidPray = 1587,
        ///<summary>Solid Adjust</summary>
        ///<see href="https://fontawesome.com/icons/adjust?style=solid"/>
        [Description("Solid Adjust"), IconID("fas-adjust"), IconUnicodeGlyph(0xf042)]
        SolidAdjust = 1588,
        ///<summary>Solid Fingerprint</summary>
        ///<see href="https://fontawesome.com/icons/fingerprint?style=solid"/>
        [Description("Solid Fingerprint"), IconID("fas-fingerprint"), IconUnicodeGlyph(0xf577)]
        SolidFingerprint = 1589,
        ///<summary>Solid Pump Medical</summary>
        ///<see href="https://fontawesome.com/icons/pump-medical?style=solid"/>
        [Description("Solid Pump Medical"), IconID("fas-pump-medical"), IconUnicodeGlyph(0xe06a)]
        SolidPumpMedical = 1590,
        ///<summary>Solid Icons</summary>
        ///<see href="https://fontawesome.com/icons/icons?style=solid"/>
        [Description("Solid Icons"), IconID("fas-icons"), IconUnicodeGlyph(0xf86d)]
        SolidIcons = 1591,
        ///<summary>Solid Soap</summary>
        ///<see href="https://fontawesome.com/icons/soap?style=solid"/>
        [Description("Solid Soap"), IconID("fas-soap"), IconUnicodeGlyph(0xe06e)]
        SolidSoap = 1592,
        ///<summary>Solid Atom</summary>
        ///<see href="https://fontawesome.com/icons/atom?style=solid"/>
        [Description("Solid Atom"), IconID("fas-atom"), IconUnicodeGlyph(0xf5d2)]
        SolidAtom = 1593,
        ///<summary>Solid Phone Alt</summary>
        ///<see href="https://fontawesome.com/icons/phone-alt?style=solid"/>
        [Description("Solid Phone Alt"), IconID("fas-phone-alt"), IconUnicodeGlyph(0xf879)]
        SolidPhoneAlt = 1594,
        ///<summary>Solid Door Open</summary>
        ///<see href="https://fontawesome.com/icons/door-open?style=solid"/>
        [Description("Solid Door Open"), IconID("fas-door-open"), IconUnicodeGlyph(0xf52b)]
        SolidDoorOpen = 1595,
        ///<summary>Solid Sort Down</summary>
        ///<see href="https://fontawesome.com/icons/sort-down?style=solid"/>
        [Description("Solid Sort Down"), IconID("fas-sort-down"), IconUnicodeGlyph(0xf0dd)]
        SolidSortDown = 1596,
        ///<summary>Solid Border Style</summary>
        ///<see href="https://fontawesome.com/icons/border-style?style=solid"/>
        [Description("Solid Border Style"), IconID("fas-border-style"), IconUnicodeGlyph(0xf853)]
        SolidBorderStyle = 1597,
        ///<summary>Solid Dice Three</summary>
        ///<see href="https://fontawesome.com/icons/dice-three?style=solid"/>
        [Description("Solid Dice Three"), IconID("fas-dice-three"), IconUnicodeGlyph(0xf527)]
        SolidDiceThree = 1598,
        ///<summary>Solid Ring</summary>
        ///<see href="https://fontawesome.com/icons/ring?style=solid"/>
        [Description("Solid Ring"), IconID("fas-ring"), IconUnicodeGlyph(0xf70b)]
        SolidRing = 1599,
        ///<summary>Solid Wave Square</summary>
        ///<see href="https://fontawesome.com/icons/wave-square?style=solid"/>
        [Description("Solid Wave Square"), IconID("fas-wave-square"), IconUnicodeGlyph(0xf83e)]
        SolidWaveSquare = 1600,
        ///<summary>Solid Baseball Ball</summary>
        ///<see href="https://fontawesome.com/icons/baseball-ball?style=solid"/>
        [Description("Solid Baseball Ball"), IconID("fas-baseball-ball"), IconUnicodeGlyph(0xf433)]
        SolidBaseballBall = 1601,
        ///<summary>Solid Compress Arrows Alt</summary>
        ///<see href="https://fontawesome.com/icons/compress-arrows-alt?style=solid"/>
        [Description("Solid Compress Arrows Alt"), IconID("fas-compress-arrows-alt"), IconUnicodeGlyph(0xf78c)]
        SolidCompressArrowsAlt = 1602,
        ///<summary>Solid Snowboarding</summary>
        ///<see href="https://fontawesome.com/icons/snowboarding?style=solid"/>
        [Description("Solid Snowboarding"), IconID("fas-snowboarding"), IconUnicodeGlyph(0xf7ce)]
        SolidSnowboarding = 1603,
        ///<summary>Solid Grin Hearts</summary>
        ///<see href="https://fontawesome.com/icons/grin-hearts?style=solid"/>
        [Description("Solid Grin Hearts"), IconID("fas-grin-hearts"), IconUnicodeGlyph(0xf584)]
        SolidGrinHearts = 1604,
        ///<summary>Solid Info</summary>
        ///<see href="https://fontawesome.com/icons/info?style=solid"/>
        [Description("Solid Info"), IconID("fas-info"), IconUnicodeGlyph(0xf129)]
        SolidInfo = 1605,
        ///<summary>Solid Stethoscope</summary>
        ///<see href="https://fontawesome.com/icons/stethoscope?style=solid"/>
        [Description("Solid Stethoscope"), IconID("fas-stethoscope"), IconUnicodeGlyph(0xf0f1)]
        SolidStethoscope = 1606,
        ///<summary>Solid Text Height</summary>
        ///<see href="https://fontawesome.com/icons/text-height?style=solid"/>
        [Description("Solid Text Height"), IconID("fas-text-height"), IconUnicodeGlyph(0xf034)]
        SolidTextHeight = 1607,
        ///<summary>Solid At</summary>
        ///<see href="https://fontawesome.com/icons/at?style=solid"/>
        [Description("Solid At"), IconID("fas-at"), IconUnicodeGlyph(0xf1fa)]
        SolidAt = 1608,
        ///<summary>Solid Undo</summary>
        ///<see href="https://fontawesome.com/icons/undo?style=solid"/>
        [Description("Solid Undo"), IconID("fas-undo"), IconUnicodeGlyph(0xf0e2)]
        SolidUndo = 1609,
        ///<summary>Solid Fill Drip</summary>
        ///<see href="https://fontawesome.com/icons/fill-drip?style=solid"/>
        [Description("Solid Fill Drip"), IconID("fas-fill-drip"), IconUnicodeGlyph(0xf576)]
        SolidFillDrip = 1610
    }
}
