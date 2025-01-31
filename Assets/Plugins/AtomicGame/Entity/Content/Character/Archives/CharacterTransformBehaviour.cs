using System.Collections;
using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;
using UnityEngine.Android;

namespace AtomicGame
{
    public sealed class CharacterTransformBehaviour : IEntityInit, IEntityUpdate
    {
        private readonly float _gravity = -9.81f;
        
        private readonly IReactiveVariable<Vector3> _posOffset;
        private readonly IReactiveVariable<float> _distanceToCheck;
        private readonly IReactiveVariable<bool> _isGrounded;
        private readonly IReactiveVariable<float> _jumpForce;
        private readonly IReactiveVariable<float> _gravityScale;
        private readonly IReactiveVariable<LayerMask> _layerMask;

        private RaycastHit _hit;

        private float _velocityY;

        private Transform _oldGroundTransform;
        private Transform _transform;

        private int _numberOfJumps;
        private readonly int _maxNumberOfJumps = 2;


        public CharacterTransformBehaviour(
            IReactiveVariable<Vector3> posOffset, 
            IReactiveVariable<float> distanceToCheck, 
            IReactiveVariable<bool> isGrounded,
            IReactiveVariable<float> jumpForce,
            IReactiveVariable<float> gravityScale,
            IReactiveVariable<LayerMask> layerMask
            )
        {
            _posOffset = posOffset;
            _distanceToCheck = distanceToCheck;
            _isGrounded = isGrounded;
            _jumpForce = jumpForce;
            _gravityScale = gravityScale;
            _layerMask = layerMask;
        }
        
        public void Init(in IEntity entity)
        {
            _transform = entity.GetTransform();
            
            entity.AddJumpAction(new BaseAction(() =>
            {
                if (_numberOfJumps >= _maxNumberOfJumps) return;

                _numberOfJumps++;
                _velocityY = _jumpForce.Value;
            }));
        }
        
        public void OnUpdate(in IEntity entity, in float deltaTime)
        {
            var pos = _transform.position - _posOffset.Value;
            
            Ray ray = new Ray(pos, Vector3.down);
            
            Debug.DrawRay(pos, Vector3.down * _distanceToCheck.Value, Color.red);
            var oldIsGrounded = _isGrounded.Value;
            
            _isGrounded.Value = Physics.Raycast(ray, out _hit, _distanceToCheck.Value);
            //_isGrounded.Value = Physics.CheckSphere(_transform.position, _distanceToCheck.Value, _layerMask.Value);
            
            _velocityY += _gravity * _gravityScale.Value * deltaTime;
            
            if (_isGrounded.Value && _velocityY <= 0)
            {
                
                _velocityY = 0;
                _numberOfJumps = 0;
                
                if (oldIsGrounded != _isGrounded.Value)
                {
                    if (_isGrounded.Value)
                    {
                        Vector3 closestPoint = _hit.collider.ClosestPoint(_transform.position);
                        Vector3 snappedPosition = new Vector3(_transform.position.x, closestPoint.y, _transform.position.z);
                        _transform.position = snappedPosition;
                    }
                } 
            }
            
            if (
                oldIsGrounded != _isGrounded.Value 
                || 
                (_isGrounded.Value && _oldGroundTransform != _hit.transform)
                )
            {
                _transform.SetParent(_isGrounded.Value ? _hit.transform : null);
            } 
            
            _oldGroundTransform = _isGrounded.Value ? _hit.transform : null;
            
            _transform.Translate(new Vector3(0, _velocityY, 0) * deltaTime);
        }
    }
}