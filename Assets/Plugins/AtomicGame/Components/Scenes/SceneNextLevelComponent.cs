using System;
using System.Collections;
using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace AtomicGame
{
    public sealed class SceneNextLevelComponent : AbstractSceneComponent
    {
        [SerializeField] 
        private string scenePrefix = "GameLevel_";
        
        [SerializeField] 
        private string sceneReturnToMainMenu = "GameLauncher";

        public override string GetSceneName()
        {
            string newName = GetNextSceneName();
            
            if (SceneHelper.IsSceneExist(newName))
            {
                return newName;
            }

            return sceneReturnToMainMenu;
        }
        
        public string GetNextSceneName()
        {
            string idAsString = GetCurrentLevelId();
            if (!int.TryParse(idAsString, out var id))
            {
                return SceneManager.GetActiveScene().name;
            }
            id++;
            string newName = scenePrefix + id.ToString();
            return newName;
        }
        
        public string GetCurrentLevelId()
        {
            string currentName = SceneManager.GetActiveScene().name;
            return currentName.Replace(scenePrefix, "");
        }
    }
}