using System;
using Atomic.Entities;
using AtomicGame.Common;
using UnityEngine;

namespace AtomicGame.Common
{
    public class AgKeyPressController : MonoBehaviour
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
            if (Input.GetKey(_keyCode))
            {
                foreach (var sceneEntity in _sceneEntities)
                {
                    sceneEntity.GetKeyPressAction().Invoke(_keyCode);
                } 
            } 
        }
    }
}