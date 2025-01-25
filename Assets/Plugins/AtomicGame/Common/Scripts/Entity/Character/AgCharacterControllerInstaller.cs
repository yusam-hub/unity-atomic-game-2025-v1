using System;
using System.Collections;
using Atomic.Elements;
using Atomic.Entities;
using AtomicGame.Common;
using Sirenix.OdinInspector;
using UnityEngine;

namespace AtomicGame.Common
{
    /*[RequireComponent(typeof(CharacterController))]
    public class AgCharacterControllerInstaller : SceneEntityInstaller
    {
        [SerializeField] 
        private CharacterController _characterController;

        [SerializeField] 
        private  ReactiveVariable<float> _moveSpeed = new(3.5f);

        [SerializeField, ReadOnly]
        private  ReactiveVariable<float> _currentSpeed = new(0);
        
        [SerializeField] 
        private ReactiveVariable<float> _rotateSpeed = new(15f);
        
        [SerializeField, ReadOnly]
        private ReactiveVariable<bool> _isMoving = new (false);
        
        [SerializeField, ReadOnly]
        private ReactiveVariable<bool> _isGrounded = new (false);
        
        private float _gravity = -9.81f;
        [SerializeField] private float gravityMultiplier = 3.0f;
        private float _velocity;
        
        [SerializeField] private float jumpPower = 5;
        private int _numberOfJumps;
        [SerializeField] private int maxNumberOfJumps = 2;
        
        private bool IsGrounded() => _characterController.isGrounded;
        
        public override void Install(IEntity entity)
        {
            entity.AddTransform(_characterController.transform);
            entity.AddCharacterController(_characterController);    
            
            entity.AddMoveSpeed(_moveSpeed);
            entity.AddMoveAction(new BaseAction<Vector3, float>((direction, deltaTime) =>
            {
                entity.GetRotateAction().Invoke(direction, deltaTime);
                
                if (IsGrounded() && _velocity < 0.0f)
                {
                    _velocity = -1.0f;
                }
                else
                {
                    _velocity += _gravity * gravityMultiplier * deltaTime;
                }

                _isMoving.Value = direction.x != 0 || direction.z != 0;
                
                direction.y = _velocity;
                
                float acceleration = 2;
                _currentSpeed.Value = Mathf.MoveTowards(_currentSpeed.Value, _moveSpeed.Value, acceleration * deltaTime);
                _characterController.Move(direction * _currentSpeed.Value * deltaTime);
            }));
            
            entity.AddIsMoving(_isMoving);
            entity.AddIsGrounded(new BaseFunction<bool>(IsGrounded));
            
            entity.AddRotateSpeed(_rotateSpeed);
            entity.AddRotateAction(new BaseAction<Vector3, float>((direction, deltaTime) =>
            {
                entity.AgTransformRotateByDirection(direction, deltaTime);
            }));
            
            entity.AddKeyDownAction(new BaseAction<KeyCode>((keyCode) =>
            {
                if (keyCode == KeyCode.Space)
                {
                    /*entity.GetJumpAction().Invoke();#1#
                    if (!IsGrounded() && _numberOfJumps >= maxNumberOfJumps) return;
                    if (_numberOfJumps == 0) StartCoroutine(WaitForLanding());
		
                    _numberOfJumps++;
                    _velocity = jumpPower;
                }
            }));
        }

        private IEnumerator WaitForLanding()
        {
            yield return new WaitUntil(() => !IsGrounded());
            yield return new WaitUntil(IsGrounded);

            _numberOfJumps = 0;
        }
    }*/
}