# GameViewSize Settings


Easily register, delete and change GameViewSize in Unity

## Description

It is troublesome to register, delete, or change GameViewSize using the default function of Unity. [GameViewSize Settings] is a tool that can do these easily. We prepare representative terminal sizes of iPhone and Android as presets. You can change GameViewSize with one button. If you want to easily incorporate the screen size necessary for development and debugging please try using this tool.

![](example1.png)
![](example2.png)

## Feature
* Register the screen size of a representative smartphone terminal in GameViewSize.
* Delete registered GameViewSize
* Change GameViewSize

## Usage
import GameViewSizeSettings.unitypackage

#### Open EditorWindow
1. MenuItem "Window/GameViewSize Settings"
2. Switch Tab
#### Add GameViewSize
1. Click the "Add" button of the required preset or click the "Add all preset" button
#### Remove GameViewSize
1. Click the "Remove" button of the required preset or click the "Remove all preset" button
#### Change GameViewSize
1. Click the title of each item displayed in the "REGISTERED" area

## Preset
#### iPhone
* 【↑】 iPhone 5 5s 5c SE  width = 640, height = 1136
* 【→】 iPhone 5 5s 5c SE  width = 1136, height = 640
* 【↑】 iPhone 6 6s 7 8    width = 750, height = 1334
* 【→】 iPhone 6 6s 7 8    width = 1334, height = 750
* 【↑】 iPhone 6Plus 6sPlus 7Plus 8Plus    width = 1242, height = 2208
* 【→】 iPhone 6Plus 6sPlus 7Plus 8Plus    width = 2208, height = 1242
* 【↑】 iPhone X    width = 1125, height = 2436
* 【→】 iPhone X    width = 2436, height = 1125

* 【↑】 iPad Mini    width = 768, height = 1024
* 【→】 iPad Mini    width = 1024, height = 768
* 【↑】 iPad Mini 2 3 4    width = 1536, height = 2048
* 【→】 iPad Mini 2 3 4    width = 2048, height = 1536
* 【↑】 iPad iPad2    width = 768, height = 1024
* 【→】 iPad iPad2    width = 1024, height = 768
* 【↑】 iPad 3 4,Air Air2,Pro9    width = 1536, height = 2048
* 【→】 iPad 3 4,Air Air2,Pro9    width = 2048, height = 1536
* 【↑】 iPad Pro10.5    width = 1668, height = 2224
* 【→】 iPad Pro10.5    width = 2224, height = 1668
* 【↑】 iPad Pro12.9    width = 2048, height = 2732
* 【→】 iPad Pro12.9    width = 2732, height = 2048

#### Android
* 【↑】 Nexus 5X width = 1080, height = 1920
* 【→】 Nexus 5X width = 1920, height = 1080
* 【↑】 Galaxy S4 S5 Note3 width = 1080, height = 1920
* 【→】 Galaxy S4 S5 Note3 width = 1920, height = 1080
* 【↑】 Galaxy S6 S7 width = 1440, height = 2560
* 【→】 Galaxy S6 S7 width = 2560, height = 1440
* 【↑】 Galaxy S8 width = 1440, height = 2960
* 【→】 Galaxy S8 width = 2960, height = 1440
* 【↑】 Xperia XZ Z1 Z2 Z3 width = 1080, height = 1920
* 【→】 Xperia XZ Z1 Z2 Z3 width = 1920, height = 1080

## Update Preset
Please rewrite "GameViewSizePreset.cs" or Make a issue [GameViewSizeSettings issue](https://github.com/Syy12345-Unity/GameViewSizeSettings/issues)

## Use Library
* [unity-GameViewSizeHelper](https://github.com/anchan828/unity-GameViewSizeHelper)

## Licence

[MIT](https://github.com/tcnksm/tool/blob/master/LICENCE)

## Author

[Syy9](https://github.com/Syy9)
