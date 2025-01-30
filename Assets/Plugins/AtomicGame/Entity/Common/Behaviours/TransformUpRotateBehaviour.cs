using Atomic.Elements;
using Atomic.Entities;
using Atomic.Extensions;
using UnityEngine;

namespace AtomicGame
{
    public sealed class TransformUpRotateBehaviour : IEntityInit, IEntityUpdate
    {
        private Transform _transform;
        private readonly bool _isRotate;
        private readonly float _rotateSpeed;

        public TransformUpRotateBehaviour(bool isRotate, float rotateSpeed)
        {
            _isRotate = isRotate;
            _rotateSpeed = rotateSpeed;
        }

        public void Init(in IEntity entity)
        {
            _transform = entity.GetTransform();
        }

        public void OnUpdate(in IEntity entity, in float deltaTime)
        {
            if (_isRotate)
            {
                _transform.Rotate(Vector3.up, 1 * _rotateSpeed * deltaTime);
            }
        }
    }
}