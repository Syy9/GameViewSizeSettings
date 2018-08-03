using System.Collections.Generic;
using UnityEditor;
using Kyusyukeigo.Helper;

namespace Syy.GameViewSizeControl
{
    public static class GameViewSizePreset
    {
        private static Dictionary<GameViewSizeGroupType,GameViewSizeHelper.GameViewSize[]> presets = new Dictionary<GameViewSizeGroupType, GameViewSizeHelper.GameViewSize[]>(){
            {
                GameViewSizeGroupType.Standalone,new GameViewSizeHelper.GameViewSize[] {
                    // some preset
                }
            },
            {
                GameViewSizeGroupType.iOS,new GameViewSizeHelper.GameViewSize[] {
                    // iPhone
                    new GameViewSizeHelper.GameViewSize(){ baseText = "【↑】 iPhone 5 5s 5c SE",  width = 640, height = 1136, type = GameViewSizeHelper.GameViewSizeType.AspectRatio },
                    new GameViewSizeHelper.GameViewSize(){ baseText = "【→】 iPhone 5 5s 5c SE",  width = 1136, height = 640, type = GameViewSizeHelper.GameViewSizeType.AspectRatio },
                    new GameViewSizeHelper.GameViewSize(){ baseText = "【↑】 iPhone 6 6s 7 8",    width = 750, height = 1334, type = GameViewSizeHelper.GameViewSizeType.AspectRatio },
                    new GameViewSizeHelper.GameViewSize(){ baseText = "【→】 iPhone 6 6s 7 8",    width = 1334, height = 750, type = GameViewSizeHelper.GameViewSizeType.AspectRatio },
                    new GameViewSizeHelper.GameViewSize(){ baseText = "【↑】 iPhone 6Plus 6sPlus 7Plus 8Plus",    width = 1242, height = 2208, type = GameViewSizeHelper.GameViewSizeType.AspectRatio },
                    new GameViewSizeHelper.GameViewSize(){ baseText = "【→】 iPhone 6Plus 6sPlus 7Plus 8Plus",    width = 2208, height = 1242, type = GameViewSizeHelper.GameViewSizeType.AspectRatio },
                    new GameViewSizeHelper.GameViewSize(){ baseText = "【↑】 iPhone X",    width = 1125, height = 2436, type = GameViewSizeHelper.GameViewSizeType.AspectRatio },
                    new GameViewSizeHelper.GameViewSize(){ baseText = "【→】 iPhone X",    width = 2436, height = 1125, type = GameViewSizeHelper.GameViewSizeType.AspectRatio },
                    // iPad
                    new GameViewSizeHelper.GameViewSize(){ baseText = "【↑】 iPad Mini",    width = 768, height = 1024, type = GameViewSizeHelper.GameViewSizeType.AspectRatio },
                    new GameViewSizeHelper.GameViewSize(){ baseText = "【→】 iPad Mini",    width = 1024, height = 768, type = GameViewSizeHelper.GameViewSizeType.AspectRatio },
                    new GameViewSizeHelper.GameViewSize(){ baseText = "【↑】 iPad Mini 2 3 4",    width = 1536, height = 2048, type = GameViewSizeHelper.GameViewSizeType.AspectRatio },
                    new GameViewSizeHelper.GameViewSize(){ baseText = "【→】 iPad Mini 2 3 4",    width = 2048, height = 1536, type = GameViewSizeHelper.GameViewSizeType.AspectRatio },
                    new GameViewSizeHelper.GameViewSize(){ baseText = "【↑】 iPad iPad2",    width = 768, height = 1024, type = GameViewSizeHelper.GameViewSizeType.AspectRatio },
                    new GameViewSizeHelper.GameViewSize(){ baseText = "【→】 iPad iPad2",    width = 1024, height = 768, type = GameViewSizeHelper.GameViewSizeType.AspectRatio },
                    new GameViewSizeHelper.GameViewSize(){ baseText = "【↑】 iPad 3 4,Air Air2,Pro9",    width = 1536, height = 2048, type = GameViewSizeHelper.GameViewSizeType.AspectRatio },
                    new GameViewSizeHelper.GameViewSize(){ baseText = "【→】 iPad 3 4,Air Air2,Pro9",    width = 2048, height = 1536, type = GameViewSizeHelper.GameViewSizeType.AspectRatio },
                    new GameViewSizeHelper.GameViewSize(){ baseText = "【↑】 iPad Pro10.5",    width = 1668, height = 2224, type = GameViewSizeHelper.GameViewSizeType.AspectRatio },
                    new GameViewSizeHelper.GameViewSize(){ baseText = "【→】 iPad Pro10.5",    width = 2224, height = 1668, type = GameViewSizeHelper.GameViewSizeType.AspectRatio },
                    new GameViewSizeHelper.GameViewSize(){ baseText = "【↑】 iPad Pro12.9",    width = 2048, height = 2732, type = GameViewSizeHelper.GameViewSizeType.AspectRatio },
                    new GameViewSizeHelper.GameViewSize(){ baseText = "【→】 iPad Pro12.9",    width = 2732, height = 2048, type = GameViewSizeHelper.GameViewSizeType.AspectRatio },
                }
            },
            {
                GameViewSizeGroupType.Android,new GameViewSizeHelper.GameViewSize[] {
                    // some preset
                    new GameViewSizeHelper.GameViewSize(){ baseText = "【↑】 Nexus 5X", width = 1080, height = 1920, type = GameViewSizeHelper.GameViewSizeType.FixedResolution },
                    new GameViewSizeHelper.GameViewSize(){ baseText = "【→】 Nexus 5X", width = 1920, height = 1080, type = GameViewSizeHelper.GameViewSizeType.FixedResolution },
                    new GameViewSizeHelper.GameViewSize(){ baseText = "【↑】 Galaxy S4 S5 Note3", width = 1080, height = 1920, type = GameViewSizeHelper.GameViewSizeType.FixedResolution },
                    new GameViewSizeHelper.GameViewSize(){ baseText = "【→】 Galaxy S4 S5 Note3", width = 1920, height = 1080, type = GameViewSizeHelper.GameViewSizeType.FixedResolution },
                    new GameViewSizeHelper.GameViewSize(){ baseText = "【↑】 Galaxy S6 S7", width = 1440, height = 2560, type = GameViewSizeHelper.GameViewSizeType.FixedResolution },
                    new GameViewSizeHelper.GameViewSize(){ baseText = "【→】 Galaxy S6 S7", width = 2560, height = 1440, type = GameViewSizeHelper.GameViewSizeType.FixedResolution },
                    new GameViewSizeHelper.GameViewSize(){ baseText = "【↑】 Galaxy S8", width = 1440, height = 2960, type = GameViewSizeHelper.GameViewSizeType.FixedResolution },
                    new GameViewSizeHelper.GameViewSize(){ baseText = "【→】 Galaxy S8", width = 2960, height = 1440, type = GameViewSizeHelper.GameViewSizeType.FixedResolution },
                    new GameViewSizeHelper.GameViewSize(){ baseText = "【↑】 Xperia XZ Z1 Z2 Z3", width = 1080, height = 1920, type = GameViewSizeHelper.GameViewSizeType.FixedResolution },
                    new GameViewSizeHelper.GameViewSize(){ baseText = "【→】 Xperia XZ Z1 Z2 Z3", width = 1920, height = 1080, type = GameViewSizeHelper.GameViewSizeType.FixedResolution },
                }
            },
            {
                GameViewSizeGroupType.N3DS,new GameViewSizeHelper.GameViewSize[] {
                    // some preset
                }
            },
            {
                GameViewSizeGroupType.HMD,new GameViewSizeHelper.GameViewSize[] {
                    // some preset
                }
            }
        };
        public static GameViewSizeHelper.GameViewSize[] GetPresets(GameViewSizeGroupType groupType)
        {
            if(presets.ContainsKey(groupType))
            {
                return presets[groupType];
            }
            return new GameViewSizeHelper.GameViewSize[0];
        }
    }
}
