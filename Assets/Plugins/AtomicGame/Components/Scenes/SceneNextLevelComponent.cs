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
            string currentName = SceneManager.GetActiveScene().name;
            string idAsString = currentName.Replace(scenePrefix, "");
            int id = int.Parse(idAsString);
            id++;
            string newName = scenePrefix + id.ToString();
            return newName;
        }
    }
}