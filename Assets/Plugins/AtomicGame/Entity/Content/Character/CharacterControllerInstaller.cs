using System;
using System.Collections;
using Atomic.Elements;
using Atomic.Entities;
using AtomicGame;
using Sirenix.OdinInspector;
using UnityEngine;

namespace AtomicGame
{
    [RequireComponent(typeof(CharacterController))]
    public class CharacterControllerInstaller : SceneEntityInstaller
    {
        [SerializeField]
        private InteractInstaller _interactInstaller;

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

        private ReactiveVariable<Vector3> _moveDirection = new();
        
        private CharacterController _characterController;
        
        [SerializeField, ReadOnly]
        private ReactiveVariable<Quaternion> _planarRotation = new ();
        public override void Install(IEntity entity)
        {
            _characterController = GetComponent<CharacterController>();
            
            _interactInstaller.Install(entity);
            
            entity.AddEffects(new ReactiveDictionary<string, EffectInstance>());
            entity.AddPlanarRotation(_planarRotation);
            
            entity.AddTransform(_characterController.transform);
            entity.AddCharacterController(_characterController);    
            
            entity.AddMoveSpeed(_moveSpeed);
            entity.AddMoveAction(new BaseAction<Vector3, float>((direction, deltaTime) =>
            {
                var newDir = _planarRotation.Value * direction;
                _isMoving.Value = newDir.x != 0 || newDir.z != 0;
                entity.GetRotateAction().Invoke(newDir, deltaTime);
                _moveDirection.Value = newDir;
            }));
            
            entity.AddIsMoving(_isMoving);
            entity.AddIsGrounded(new BaseFunction<bool>(() => _characterController.isGrounded));
            
            entity.AddRotateSpeed(_rotateSpeed);
            entity.AddRotateAction(new BaseAction<Vector3, float>((direction, deltaTime) =>
            {
                entity.TransformRotateByDirection(direction, deltaTime);
            }));

            entity.AddBehaviour(
                new CharacterControllerBehaviour(
                    _characterController, 
                    _currentSpeed,
                    _moveSpeed,
                    _moveDirection
                )
            );
        }

        private IEnumerator WaitForLanding()
        {
            yield return new WaitUntil(() => !_characterController.isGrounded);
            yield return new WaitUntil(() =>_characterController.isGrounded);

            //_numberOfJumps = 0;
        }
    }
}