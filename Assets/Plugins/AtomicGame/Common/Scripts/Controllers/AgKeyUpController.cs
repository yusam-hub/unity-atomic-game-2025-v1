using System;
using Atomic.Entities;
using AtomicGame.Common;
using UnityEngine;

namespace AtomicGame.Common
{
    public class AgKeyUpController : MonoBehaviour
    {
        [SerializeField] 
        private SceneEntity[] _sceneEntities;

        [SerializeField] 
        private KeyCode _keyCode = KeyCode.Space;
        
        private void Update()
        {
            HandleKeyboard();
        }
        
        private void HandleKeyboard()
        {
            if (Input.GetKeyUp(_keyCode))
            {
                foreach (var sceneEntity in _sceneEntities)
                {
                    sceneEntity.GetKeyUpAction().Invoke(_keyCode);
                } 
            } 
        }
    }
}