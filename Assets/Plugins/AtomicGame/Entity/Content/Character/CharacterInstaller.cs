using System;
using Atomic.Elements;
using Atomic.Entities;
using AtomicGame;
using Sirenix.OdinInspector;
using UnityEngine;

namespace AtomicGame
{
    [RequireComponent(typeof(Rigidbody), typeof(CapsuleCollider))]
    public class CharacterInstaller : SceneEntityInstaller
    {
        [SerializeField] 
        private  ReactiveVariable<float> _moveSpeed = new(3.5f);

        [SerializeField] 
        private ReactiveVariable<float> _rotateSpeed = new(15f);
        
        [SerializeField] 
        private ReactiveVariable<Vector3> _checkGroundOffset = new(new Vector3(0,-0.1f,0));
        
        [SerializeField] 
        private ReactiveVariable<float> _checkGroundDistance = new(0.4f);
        
        [SerializeField]
        private ReactiveVariable<float> _jumpForce = new(15f);
        
        [SerializeField] 
        private ReactiveVariable<float> _gravityScale = new(5f);
        
        [SerializeField, ReadOnly]
        private ReactiveVariable<bool> _isMoving = new (false);
        
        [SerializeField, ReadOnly]
        private ReactiveVariable<bool> _isGrounded = new (false);
        
        public override void Install(IEntity entity)
        {
            entity.AddTransform(transform);
            
            entity.AddMoveSpeed(_moveSpeed);
            entity.AddMoveAction(new BaseAction<Vector3, float>((direction, deltaTime) =>
            {
                _isMoving.Value = direction != Vector3.zero;
                entity.AgTransformMoveByDirection(direction, deltaTime);
                entity.GetRotateAction().Invoke(direction, deltaTime);
            }));
            entity.AddIsMoving(_isMoving);
            entity.AddIsGrounded(_isGrounded);
            
            entity.AddRotateSpeed(_rotateSpeed);
            entity.AddRotateAction(new BaseAction<Vector3, float>((direction, deltaTime) =>
            {
                entity.AgTransformRotateByDirection(direction, deltaTime);
            }));
            
            entity.AddBehaviour(
                new CharacterGroundCheckJumpBehaviour(
                _checkGroundOffset ,
                _checkGroundDistance, 
                _isGrounded,
                _jumpForce,
                _gravityScale
                )
                );
        }
    }
}