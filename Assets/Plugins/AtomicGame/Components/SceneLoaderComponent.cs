using System;
using System.Collections;
using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace AtomicGame
{
    public class SceneLoaderComponent : SceneRestartComponent
    {
        [SerializeField] 
        private string sceneName;

        public override string GetSceneName()
        {
            return sceneName;
        }
    }
}