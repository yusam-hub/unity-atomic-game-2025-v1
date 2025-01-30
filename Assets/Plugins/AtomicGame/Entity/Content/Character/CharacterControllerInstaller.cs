using System;
using System.Collections;
using Atomic.Elements;
using Atomic.Entities;
using AtomicGame;
using Sirenix.OdinInspector;
using UnityEngine;

namespace AtomicGame
{
    [RequireComponent(typeof(CharacterController), typeof(ControllerColliderHitDispatcher))]
    public class CharacterControllerInstaller : SceneEntityInstaller
    {
        [SerializeField]
        private InteractInstaller _interactInstaller;

        [SerializeField] 
        private HealthInstaller _healthInstaller;

        [SerializeField] 
        private TriggerDispatcher _damageTriggerDispatcher;
        
        [SerializeField] 
        private ReactiveVariable<float> _moveSpeed = new(3.5f);

        [SerializeField] 
        private ReactiveVariable<float> _rotateSpeed = new(15f);

        [SerializeField, ReadOnly]
        private ReactiveVariable<float> _currentSpeed = new(0);
        
        [SerializeField, ReadOnly]
        private ReactiveVariable<bool> _isMoving = new (false);
      
        [SerializeField, ReadOnly]
        private ReactiveVariable<bool> _isGrounded = new (false);
        
        [SerializeField, ReadOnly]
        private ReactiveVariable<Vector3> _moveDirection = new();

        
        private CharacterController _characterController;
        private ControllerColliderHitDispatcher _controllerColliderHitDispatcher;
        
        [SerializeField, ReadOnly]
        private ReactiveVariable<Quaternion> _planarRotation = new ();
        
        private IExpression<bool> _moveCondition = new AndExpression();
        private IExpression<bool> _jumpCondition = new AndExpression();
        public override void Install(IEntity entity)
        {
            _characterController = GetComponent<CharacterController>();
            _controllerColliderHitDispatcher = GetComponent<ControllerColliderHitDispatcher>();
            
            _interactInstaller.Install(entity);
            _healthInstaller.Install(entity);
            
            entity.AddPlayerTag();
            _moveCondition.Append(() => HealthUseCase.IsAlive(entity));
            entity.AddMoveCondition(_moveCondition);
            
            _jumpCondition.Append(() => HealthUseCase.IsAlive(entity));
            entity.AddJumpCondition(_jumpCondition);
            
            entity.AddEffects(new ReactiveDictionary<string, EffectInstance>());
            entity.AddPlanarRotation(_planarRotation);
            
            entity.AddTransform(_characterController.transform);
            entity.AddCharacterController(_characterController);    
            
            entity.AddMoveSpeed(_moveSpeed);
            entity.AddMoveAction(new BaseAction<Vector3, float>((direction, deltaTime) =>
            {
                if (_moveCondition.Invoke())
                {
                    var newDir = _planarRotation.Value * direction;
                    _moveDirection.Value = newDir;
                    entity.GetRotateAction().Invoke(_moveDirection.Value, deltaTime);
                }
            }));
            
            entity.AddIsMoving(_isMoving);
            entity.AddIsGrounded(_isGrounded);
            entity.AddJumpEvent(new BaseEvent());
            
            entity.AddRotateSpeed(_rotateSpeed);
            entity.AddRotateAction(new BaseAction<Vector3, float>((direction, deltaTime) =>
            {
                entity.TransformRotateByDirection(direction, deltaTime);
            }));

            entity.AddBehaviour(
                new CharacterControllerBehaviour(
                    _characterController, 
                    _controllerColliderHitDispatcher,
                    _currentSpeed,
                    _moveSpeed,
                    _moveDirection,
                    _isGrounded,
                    _isMoving
                )
            );

            entity.AddBehaviour(new CharacterControllerDamageTriggerBehaviour(_damageTriggerDispatcher));
        }
    }
}