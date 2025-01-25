using System;
using Atomic.Entities;
using AtomicGame.Common;
using UnityEngine;

namespace AtomicGame.Common
{
    public class AgKeyDownController : MonoBehaviour
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
            if (Input.GetKeyDown(_keyCode))
            {
                foreach (var sceneEntity in _sceneEntities)
                {
                    sceneEntity.GetKeyDownAction().Invoke(_keyCode);
                } 
            } 
        }
    }
}