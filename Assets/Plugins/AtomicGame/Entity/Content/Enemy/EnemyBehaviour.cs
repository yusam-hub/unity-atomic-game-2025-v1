using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace AtomicGame
{
    public class EnemyBehaviour : IEntityInit, IEntityUpdate
    {
        private IReactiveVariable<IEntity> _targetAttackable;
        private Transform[] _transforms;
        private Transform _transform;
        private IReactiveVariable<float> _moveSpeed;
        private IReactiveVariable<Vector3> _moveDirection;
        private int _indexOfTransforms;
        
        public void Init(in IEntity entity)
        {
            _transform = entity.GetTransform();
            _transforms = entity.GetTransforms();
            _moveSpeed = entity.GetMoveSpeed();
            _moveDirection = entity.GetMoveDirection();
            _targetAttackable = entity.GetTargetAttackable();
            _indexOfTransforms = -1;
            if (_transforms.Length > 0)
            {
                _indexOfTransforms = 0;
            }
        }

        public void OnUpdate(in IEntity entity, in float deltaTime)
        {
            if (_indexOfTransforms == -1) return;
            if (!HealthUseCase.IsAlive(entity)) return;
            if (_targetAttackable.Value != null) return;
            
            var nextPosition = _transforms[_indexOfTransforms].position;
            
            _moveDirection.Value = (nextPosition - _transform.position).normalized;
            
            float speed = _moveSpeed.Value * deltaTime;
            _transform.position += _moveDirection.Value * speed;
            
            entity.TransformRotateByDirection(_moveDirection.Value, deltaTime);
            
            if (Vector3.Distance(_transform.position, nextPosition) <= 0.1)
            {
                _indexOfTransforms++;
                if (_indexOfTransforms >= _transforms.Length)
                {
                    _indexOfTransforms = 0;
                }
            }
        }
    }
}