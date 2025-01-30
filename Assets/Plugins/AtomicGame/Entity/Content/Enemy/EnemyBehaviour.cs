using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace AtomicGame
{
    public class EnemyBehaviour : IEntityInit, IEntityUpdate
    {
        private Transform[] _patrolPoints;
        private Transform _transform;
        private IReactiveVariable<float> _moveSpeed;
        private IReactiveVariable<Vector3> _moveDirection;
        private int _indexPoint;
        
        public void Init(in IEntity entity)
        {
            _transform = entity.GetTransform();
            _patrolPoints = entity.GetTransforms();
            _moveSpeed = entity.GetMoveSpeed();
            _moveDirection = entity.GetMoveDirection();
            _indexPoint = -1;
            if (_patrolPoints.Length > 0)
            {
                _indexPoint = 0;
            }
        }

        public void OnUpdate(in IEntity entity, in float deltaTime)
        {
            if (!HealthUseCase.IsAlive(entity)) return;
            
            var nextPoint = _patrolPoints[_indexPoint].position;
            
            _moveDirection.Value = (nextPoint - _transform.position).normalized;
            
            float speed = _moveSpeed.Value * deltaTime;
            _transform.position += _moveDirection.Value * speed;
            
            entity.TransformRotateByDirection(_moveDirection.Value, deltaTime);
            
            if (Vector3.Distance(_transform.position, nextPoint) <= 0.1)
            {
                _indexPoint++;
                if (_indexPoint >= _patrolPoints.Length)
                {
                    _indexPoint = 0;
                }
            }
        }
    }
}