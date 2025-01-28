using System.Collections;
using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;
using UnityEngine.Android;

namespace AtomicGame
{
    public sealed class CharacterControllerBehaviour : IEntityInit, IEntityDispose, IEntityUpdate
    {
        private CharacterController _characterController;
        private ControllerColliderHitDispatcher _controllerColliderHitDispatcher;
        private IReactiveVariable<float> _currentSpeed;
        private IReactiveVariable<float> _moveSpeed;
        private IReactiveVariable<Vector3> _moveDirection;
        private IReactiveVariable<bool> _isGrounded;
        private IReactiveVariable<bool> _isMoving;     
        
        private Vector3 _platformLastPosition;
        private Vector3 _platformMovement;
        
        private float _gravity = -9.81f;
        private float gravityMultiplier = 2.0f;
        private float _velocity;
        
        private float jumpPower = 7;
        private int _numberOfJumps;
        private readonly int _maxNumberOfJumps = 2;

        public CharacterControllerBehaviour(
            CharacterController characterController, 
            ControllerColliderHitDispatcher controllerColliderHitDispatcher,
            IReactiveVariable<float> currentSpeed, 
            IReactiveVariable<float> moveSpeed, 
            IReactiveVariable<Vector3> moveDirection,
            IReactiveVariable<bool> isGrounded,
            IReactiveVariable<bool> isMoving
            )
        {
            _characterController = characterController;
            _controllerColliderHitDispatcher = controllerColliderHitDispatcher;
            _currentSpeed = currentSpeed;
            _moveSpeed = moveSpeed;
            _moveDirection = moveDirection;
            _isGrounded = isGrounded;
            _isMoving = isMoving;
        }

        public void Init(in IEntity entity)
        {
            _controllerColliderHitDispatcher.OnHit += ControllerColliderHitDispatcherOnOnHit;
            
            IEvent jumpEvent = entity.GetJumpEvent();
            
            entity.AddJumpAction(new BaseAction(() =>
            {
                if (_numberOfJumps >= _maxNumberOfJumps) return;
                _numberOfJumps++;
                _velocity = jumpPower;
                jumpEvent.Invoke();
            }));
        }
        
        void ControllerColliderHitDispatcherOnOnHit(ControllerColliderHit hit)
        {

        }
        
        public void Dispose(in IEntity entity)
        {
            _controllerColliderHitDispatcher.OnHit -= ControllerColliderHitDispatcherOnOnHit;
        }
        
        public void OnUpdate(in IEntity entity, in float deltaTime)
        {
            _isGrounded.Value = _characterController.isGrounded;
            
            var newDir = _moveDirection.Value;
            
            if (_isGrounded.Value && _velocity < 0.0f)
            {
                _velocity = -1.0f;
                _numberOfJumps = 0;
                _isMoving.Value = newDir != Vector3.zero;
            }
            else
            {
                _velocity += _gravity * gravityMultiplier * deltaTime;
                _isMoving.Value = true;
            }

            newDir.y = _velocity;
                
            float acceleration = 2;
            
            _currentSpeed.Value = Mathf.MoveTowards(
                _currentSpeed.Value, 
                _moveSpeed.Value, 
                acceleration * deltaTime
                );

            newDir *= _currentSpeed.Value;

            _characterController.Move(newDir  * deltaTime);

            _moveDirection.Value = newDir;
        }


    }
}