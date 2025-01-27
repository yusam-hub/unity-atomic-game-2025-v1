using System.Collections;
using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;
using UnityEngine.Android;

namespace AtomicGame
{
    public sealed class CharacterControllerBehaviour : IEntityInit, IEntityUpdate
    {
        private CharacterController _characterController;
        private IReactiveVariable<float> _currentSpeed;
        private IReactiveVariable<float> _moveSpeed;
        private IReactiveVariable<Vector3> _moveDirection;
        
        private float _gravity = -9.81f;
        private float gravityMultiplier = 2.0f;
        private float _velocity;
        
        private float jumpPower = 7;
        private int _numberOfJumps;
        private readonly int _maxNumberOfJumps = 2;

        public CharacterControllerBehaviour(
            CharacterController characterController, 
            IReactiveVariable<float> currentSpeed, 
            IReactiveVariable<float> moveSpeed, 
            IReactiveVariable<Vector3> moveDirection
            )
        {
            _characterController = characterController;
            _currentSpeed = currentSpeed;
            _moveSpeed = moveSpeed;
            _moveDirection = moveDirection;
        }


        public void Init(in IEntity entity)
        {
            entity.AddJumpAction(new BaseAction(() =>
            {
                if (_numberOfJumps >= _maxNumberOfJumps) return;
                _numberOfJumps++;
                _velocity = jumpPower;
            }));
        }
        
        public void OnUpdate(in IEntity entity, in float deltaTime)
        {
            var newDir = _moveDirection.Value;
            
            if (_characterController.isGrounded && _velocity < 0.0f)
            {
                _velocity = -1.0f;
                _numberOfJumps = 0;
            }
            else
            {
                _velocity += _gravity * gravityMultiplier * deltaTime;
            }

            newDir.y = _velocity;
                
            float acceleration = 2;
            
            _currentSpeed.Value = Mathf.MoveTowards(_currentSpeed.Value, _moveSpeed.Value, acceleration * deltaTime);
            
            _characterController.Move(newDir * _currentSpeed.Value * deltaTime);

            _moveDirection.Value = newDir;
        }
    }
}