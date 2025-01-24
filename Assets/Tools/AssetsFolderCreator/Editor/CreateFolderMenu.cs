using System.Collections.Generic;
using UnityEditor;

namespace AssetsFolderCreator.Editor
{
    public static class CreateFolderMenu
    {
        private const string AssetsFolderName = "Assets";
        const string AssetsRootMenu = AssetsFolderName + "/Tools/";
        const int MenuPriority = 0;
        
        private static readonly Dictionary<string, string[]> GameFolders = new Dictionary<string, string[]>()
        {
            {"Content", new[]{"Animations","Configs","Materials","Prefabs","Scenes","Scripts","Shaders","Sprites"}},
            {"Engine",new[]{"Prefabs","Resources","Scripts","Sprites"}},
            {"UI",new[]{"Animations","Fonts","Prefabs","Resources","Scripts","Sprites"}},
        };
        
        private static readonly Dictionary<string, string[]> Folders = new Dictionary<string, string[]>()
        {
            {"_Tmp", new[]{"_"}},
            {"AssetPacks", new[]{"_"}},
            {"Game",new[]{"Content","Engine","UI"}},
            {"Plugins",new[]{"_"}},
            {"Tools",new[]{"_"}},
        };
        
        [MenuItem(AssetsRootMenu + "Create Default Folders", false, MenuPriority)]
        public static void CreateDefaultFolders(MenuCommand menuCommand)
        {
            foreach (var kvp in Folders)
            {
                string currentRootFolderPath = AssetsFolderName + "/" + kvp.Key;
                if (!AssetDatabase.IsValidFolder(currentRootFolderPath))
                {
                    AssetDatabase.CreateFolder(AssetsFolderName, kvp.Key);
                }
                foreach (var subFolderName in kvp.Value)
                {
                    if (subFolderName != "_" && !AssetDatabase.IsValidFolder($"{currentRootFolderPath}/{subFolderName}"))
                    {
                        AssetDatabase.CreateFolder(currentRootFolderPath, subFolderName);
                    }

                    if (kvp.Key.Equals("Game") && GameFolders.TryGetValue(subFolderName, out string[] subNames))
                    {
                        foreach (var subName in subNames)
                        {
                            if (subName != "_" && !AssetDatabase.IsValidFolder($"{currentRootFolderPath}/{subFolderName}/{subName}"))
                            {
                                AssetDatabase.CreateFolder($"{currentRootFolderPath}/{subFolderName}", subName);
                            }
                        }
                    }
                }
            }
        }
    }
}

