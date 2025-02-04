using System;
using System.Collections;
using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace AtomicGame
{
    public class SceneRestartComponent : AbstractSceneComponent
    {
        public override string GetSceneName()
        {
            return SceneManager.GetActiveScene().name;
        }
    }
}