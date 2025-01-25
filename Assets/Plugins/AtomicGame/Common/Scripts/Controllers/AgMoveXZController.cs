using System;
using Atomic.Entities;
using AtomicGame.Common;
using UnityEngine;

namespace AtomicGame.Common
{
    public class AgMoveXZController : MonoBehaviour
    {
        [SerializeField] 
        private SceneEntity[] _sceneEntities;

        [SerializeField] 
        private KeyCode _moveUp = KeyCode.W;
        [SerializeField] 
        private KeyCode _moveLeft = KeyCode.A;
        [SerializeField] 
        private KeyCode _moveDown = KeyCode.S;
        [SerializeField] 
        private KeyCode _moveRight = KeyCode.D;
        private void Update()
        {
            HandleKeyboard();
        }
        
        private void HandleKeyboard()
        {
            Vector3 direction = Vector3.zero;
            
            if (Input.GetKey(_moveUp))
            {
                direction.z = 1;
            }
            else if (Input.GetKey(_moveDown))
            {
                direction.z = -1;
            }
            
            if (Input.GetKey(_moveLeft))
            {
                direction.x = -1;
            }
            else if (Input.GetKey(_moveRight))
            {
                direction.x = 1;
            }

            Move(direction); 
        }

        private void Move(Vector3 direction)
        {
            float deltaTime = Time.deltaTime;
            
            foreach (var sceneEntity in _sceneEntities)
            {
                sceneEntity.GetMoveAction().Invoke(direction, deltaTime);
            } 
        }
    }
}