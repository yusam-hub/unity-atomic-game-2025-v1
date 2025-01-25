using System.Collections;
using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;
using UnityEngine.Android;

namespace AtomicGame.Common
{
    public sealed class AgTransformGroundCheckJumpBehaviour : IEntityInit, IEntityUpdate
    {
        private readonly float _gravity = -9.81f;
        
        private readonly IReactiveVariable<Vector3> _posOffset;
        private readonly IReactiveVariable<float> _distanceToCheck;
        private readonly IReactiveVariable<bool> _isGrounded;
        private readonly IReactiveVariable<float> _jumpForce;
        private readonly IReactiveVariable<float> _gravityScale;
        
        private RaycastHit _hit;

        private float _velocityY;

        private Transform _oldGroundTransform;
        private Transform _transform;

        private int _numberOfJumps;
        private int maxNumberOfJumps = 2;
        

        public AgTransformGroundCheckJumpBehaviour(
            IReactiveVariable<Vector3> posOffset, 
            IReactiveVariable<float> distanceToCheck, 
            IReactiveVariable<bool> isGrounded,
            IReactiveVariable<float> jumpForce,
            IReactiveVariable<float> gravityScale
            )
        {
            _posOffset = posOffset;
            _distanceToCheck = distanceToCheck;
            _isGrounded = isGrounded;
            _jumpForce = jumpForce;
            _gravityScale = gravityScale;
        }
        
        public void Init(in IEntity entity)
        {
            _transform = entity.GetTransform();
            
            entity.AddJumpAction(new BaseAction(() =>
            {
                if (_numberOfJumps >= maxNumberOfJumps) return;

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

            /*float angle = 0;
            if (_isGrounded.Value)
            {
                angle = Vector3.Angle(_transform.up, _hit.normal);
                //todo - угол между персонажем и поверхностью - влияет на скорость - чем больше угол тем медленне скорость, передавать значение в множитель
                //          
            }*/
            
            if (oldIsGrounded != _isGrounded.Value || (_isGrounded.Value && _oldGroundTransform != _hit.transform))
            {
                _transform.SetParent(_isGrounded.Value ? _hit.transform : null);
            } 
            
            if (_isGrounded.Value)
            {
                _oldGroundTransform = _hit.transform;
            }
            else
            {
                _oldGroundTransform = null;
            }
            
            _transform.Translate(new Vector3(0, _velocityY, 0) * deltaTime);
        }
    }
}