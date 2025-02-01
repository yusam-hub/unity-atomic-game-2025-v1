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
        private IReactiveVariable<float> _flyVelocityForTakeDamage;
        private IReactiveVariable<float> _gravityMultiplier;
        private IReactiveVariable<float> _jumpPower;
        private IReactiveVariable<int> _maxNumberOfJumps;
        
        private Vector3 _platformLastPosition;
        private Vector3 _platformMovement;
        
        private float _gravity = -9.81f;
        private float _velocity;
        private int _numberOfJumps;

        public CharacterControllerBehaviour(
            CharacterController characterController, 
            ControllerColliderHitDispatcher controllerColliderHitDispatcher,
            IReactiveVariable<float> currentSpeed, 
            IReactiveVariable<float> moveSpeed, 
            IReactiveVariable<Vector3> moveDirection,
            IReactiveVariable<bool> isGrounded,
            IReactiveVariable<bool> isMoving,
            IReactiveVariable<float> flyVelocityForTakeDamage,
            IReactiveVariable<float> jumpPower,
            IReactiveVariable<int> maxNumberOfJumps,
            IReactiveVariable<float> gravityMultiplier
            )
        {
            _characterController = characterController;
            _controllerColliderHitDispatcher = controllerColliderHitDispatcher;
            _currentSpeed = currentSpeed;
            _moveSpeed = moveSpeed;
            _moveDirection = moveDirection;
            _isGrounded = isGrounded;
            _isMoving = isMoving;
            _flyVelocityForTakeDamage = flyVelocityForTakeDamage;
            _jumpPower = jumpPower;
            _maxNumberOfJumps = maxNumberOfJumps;
            _gravityMultiplier = gravityMultiplier;
        }

        public void Init(in IEntity entity)
        {
            _controllerColliderHitDispatcher.OnHit += ControllerColliderHitDispatcherOnOnHit;
            
            IEvent jumpEvent = entity.GetJumpEvent();
            IExpression<bool> jumpCondition = entity.GetJumpCondition();
            
            entity.AddJumpAction(new BaseAction(() =>
            {
                if (!jumpCondition.Invoke()) return;
                if (_numberOfJumps >= _maxNumberOfJumps.Value) return;
                _numberOfJumps++;
                _velocity = _jumpPower.Value;
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
            if (!HealthUseCase.IsAlive(entity)) return;
            
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
                _velocity += _gravity * _gravityMultiplier.Value * deltaTime;
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
            
            if (
                Mathf.Abs(_moveDirection.Value.y) > Mathf.Abs(_flyVelocityForTakeDamage.Value)
            )
            {
                entity.TakeDamage(100);
                //todo: крик падения звук!!!!
            }
        }
    }
}