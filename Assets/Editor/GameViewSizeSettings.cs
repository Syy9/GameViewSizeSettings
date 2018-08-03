using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using Kyusyukeigo.Helper;

namespace Syy.GameViewSizeControl
{
    public class GameViewSizeSettings : EditorWindow
    {
        [MenuItem("Window/GameViewSize Settings")]
        public static void Open()
        {
            var window = GetWindow<GameViewSizeSettings>("GameViewSize Settings");
            var position = window.position;
            position.width = 710;
            position.height = 400;
            window.position = position;
        }

        Dictionary<GameViewSizeGroupType,GameViewSizeHelper.GameViewSize[]> gameViewSizeMap = new Dictionary<GameViewSizeGroupType, GameViewSizeHelper.GameViewSize[]>();
        GameViewSizeGroupType selectedTab;
        string[] tabNames = new string[0];
        Vector2 scrollPosition;
        void OnEnable()
        {
#if UNITY_IPHONE
            selectedTab = GameViewSizeGroupType.iOS;
#elif UNITY_ANDROID
            selectedTab = GameViewSizeGroupType.Android;
#else
            selectedTab = GameViewSizeGroupType.Standalone;
#endif
            tabNames = Enum.GetNames(typeof(GameViewSizeGroupType));

            foreach (var type in Enum.GetValues(typeof(GameViewSizeGroupType)))
            {
                var groupType = (GameViewSizeGroupType) type;
                gameViewSizeMap[groupType] = GameViewSizeHelper.GetAllCustomGameViewSize((GameViewSizeGroupType)groupType);
            }
        }

        void OnGUI()
        {
            var removeTargets = new List<GameViewSizeHelper.GameViewSize>();
            var addTargets = new List<GameViewSizeHelper.GameViewSize>();

            selectedTab = (GameViewSizeGroupType)GUILayout.Toolbar((int)selectedTab, tabNames);
            var presets = GameViewSizePreset.GetPresets(selectedTab);
            var customSizes = gameViewSizeMap[selectedTab];

            using (var scroll = new EditorGUILayout.ScrollViewScope(scrollPosition))
            {
                scrollPosition = scroll.scrollPosition;
                EditorGUILayout.Space();
                using (new EditorGUILayout.HorizontalScope())
                {
                    EditorGUILayout.LabelField("■■■PRESET■■■■■■■■■■■■■■■■■■■■■■■■", EditorStyles.boldLabel);
                    if (GUILayout.Button("Add all preset", GUILayout.Width(140)))
                    {
                        addTargets.AddRange(presets);
                    }
                    if (GUILayout.Button("Remove all preset", GUILayout.Width(140)))
                    {
                        removeTargets.AddRange(presets);
                    }
                }
                EditorGUILayout.Space();
                if (presets.Length == 0)
                {
                    EditorGUILayout.LabelField("Nothing preset GameViewSize. Please request https://github.com/Syy12345-Unity/GameViewSizeController");
                }
                foreach (var gameViewSize in presets)
                {
                    bool contains = customSizes.Any(data => GameViewSizeEqual(data,gameViewSize));
                    using (new EditorGUILayout.VerticalScope("ShurikenModuleTitle"))
                    {
                        using (new EditorGUILayout.HorizontalScope())
                        {
                            if (contains)
                            {
                                if (GUILayout.Button("", EditorStyles.label, GUILayout.Width(55)))
                                {
                                }
                            }
                            else
                            {
                                if (GUILayout.Button("Add", EditorStyles.miniButton, GUILayout.Width(55)))
                                {
                                    addTargets.Add(gameViewSize);
                                }
                            }
                            EditorGUILayout.LabelField(gameViewSize.baseText, GUILayout.Width(300));
                            EditorGUILayout.LabelField(string.Format("{0} × {1}", gameViewSize.width, gameViewSize.height));
                        }
                    }
                }

                EditorGUILayout.Space();
                EditorGUILayout.Space();
                EditorGUILayout.Space();
                EditorGUILayout.LabelField("■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■", EditorStyles.boldLabel);
                EditorGUILayout.LabelField("■■■REGISTERED■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■", EditorStyles.boldLabel);
                EditorGUILayout.LabelField("■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■", EditorStyles.boldLabel);
                EditorGUILayout.LabelField("Quick change GameViewSize by click title", EditorStyles.boldLabel);
                EditorGUILayout.Space();
                if(customSizes.Length == 0)
                {
                    EditorGUILayout.LabelField("Nothing registered custom GameViewSize");
                } 
                foreach (var gameViewSize in customSizes)
                {
                    using (new EditorGUILayout.VerticalScope("ShurikenModuleTitle"))
                    {
                        using (new EditorGUILayout.HorizontalScope())
                        {
                            if (GUILayout.Button("Remove", EditorStyles.miniButton, GUILayout.Width(55)))
                            {
                                removeTargets.Add(gameViewSize);
                            }
                            if(GUILayout.Button(gameViewSize.baseText, EditorStyles.label, GUILayout.Width(300)))
                            {
                                GameViewSizeHelper.ChangeGameViewSize(selectedTab, gameViewSize);
                            }
                            // EditorGUILayout.LabelField(gameViewSize.baseText);
                            EditorGUILayout.LabelField(string.Format("{0} × {1}", gameViewSize.width, gameViewSize.height));
                        }
                    }
                }

                if (removeTargets.Count != 0)
                {
                    var list = customSizes.ToList();
                    foreach (var target in removeTargets)
                    {
                        GameViewSizeHelper.RemoveCustomSize(selectedTab, target);
                        var findObj = list.FirstOrDefault(data => GameViewSizeEqual(data,target));
                        if(findObj != null)
                        {
                            list.Remove(findObj);
                        }
                    }
                    gameViewSizeMap[selectedTab] = list.ToArray();
                }

                if (addTargets.Count != 0)
                {
                    var list = customSizes.ToList();
                    foreach (var target in addTargets)
                    {
                        var findObj = list.FirstOrDefault(data => GameViewSizeEqual(data, target));
                        if(findObj == null)
                        {
                            GameViewSizeHelper.AddCustomSize(selectedTab, target);
                            list.Add(target);
                        }
                    }
                    gameViewSizeMap[selectedTab] = list.ToArray();
                }
                EditorGUILayout.Space();
            }
            EditorGUILayout.Space();
        }

        private bool GameViewSizeEqual(GameViewSizeHelper.GameViewSize a, GameViewSizeHelper.GameViewSize b)
        {
            return a.baseText == b.baseText && a.width == b.width && a.height == b.height && a.type == b.type;
        }
    }
}
