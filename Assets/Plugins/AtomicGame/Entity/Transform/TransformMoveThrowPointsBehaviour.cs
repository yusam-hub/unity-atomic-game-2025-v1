using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace AtomicGame
{
    public sealed class TransformMoveThrowPointsBehaviour : IEntityInit, IEntityUpdate
    {
        private Transform _transform;
        private int _indexPoint;
        private Transform[] _points;
        private Vector3 _rotateDirection;
        
        private IReactiveVariable<float> _angleRotate;


        public TransformMoveThrowPointsBehaviour(IReactiveVariable<float> angleRotate, Vector3 rotateDirection)
        {
            _angleRotate = angleRotate;
            _rotateDirection = rotateDirection;
        }

        public void Init(in IEntity entity)
        {
            _transform = entity.GetTransform();
            _points = entity.GetTransforms();
            _indexPoint = -1;
            if (_points.Length > 0)
            {
                _indexPoint = 0;
            }
        }

        public void OnUpdate(in IEntity entity, in float deltaTime)
        {
            var nextPoint = _points[_indexPoint].position;
            var direction = (nextPoint - _transform.position).normalized;
            IValue<float> moveSpeed = entity.GetMoveSpeed();
            IValue<float> rotateSpeed = entity.GetRotateSpeed();
            _transform.position += direction * (moveSpeed.Invoke() * deltaTime);
            if (Vector3.Distance(_transform.position, nextPoint) <= 0.1)
            {
                _indexPoint++;
                if (_indexPoint >= _points.Length)
                {
                    _indexPoint = 0;
                }
            }

            if (_angleRotate.Invoke() > 0)
            {
                _transform.Rotate(_rotateDirection, _angleRotate.Invoke() * (rotateSpeed.Invoke() * deltaTime));
            }
        }
    }
}