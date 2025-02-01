using System;
using System.Collections;
using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace AtomicGame
{
    public class SceneNextLevelComponent : SceneRestartComponent
    {
        [SerializeField] 
        private string scenePrefix = "GameLevel_";
        
        [SerializeField] 
        private string sceneReturnToMainMenu = "GameLauncher";

        public override string GetSceneName()
        {
            string currentName = SceneManager.GetActiveScene().name;
            string idAsString = currentName.Replace(scenePrefix, "");
            int id = int.Parse(idAsString);
            id++;
            string newName = scenePrefix + id.ToString();
            
            if (SceneHelper.IsSceneExist(newName))
            {
                return newName;
            }

            return sceneReturnToMainMenu;
        }
    }
}