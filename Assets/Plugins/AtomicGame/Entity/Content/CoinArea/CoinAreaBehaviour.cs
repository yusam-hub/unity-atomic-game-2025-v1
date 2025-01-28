using Atomic.Elements;
using Atomic.Entities;
using Atomic.Extensions;
using UnityEngine;

namespace AtomicGame
{
    public sealed class CoinAreaBehaviour : IEntityInit, IEntityDispose, IEntityUpdate
    {
        private GameContext _gameContext;
        private Transform _transform;
        private bool _isRotate;
        private float _rotateSpeed;
        
        private TriggerDispatcher _trigger;

        public CoinAreaBehaviour(bool isRotate, float rotateSpeed)
        {
            _isRotate = isRotate;
            _rotateSpeed = rotateSpeed;
        }

        public void Init(in IEntity entity)
        {
            _gameContext = GameContext.Instance;
            _transform = entity.GetTransform();
            _trigger = entity.GetTriggerDispatcher();
            _trigger.OnEnter += this.OnTriggerEnter;
        }

        public void Dispose(in IEntity entity)
        {
            _trigger.OnEnter -= this.OnTriggerEnter;
        }

        private void OnTriggerEnter(Collider collider)
        {
            IReactiveVariable<int> score = _gameContext.GetScore();
            score.Value += 1;
            _transform.gameObject.SetActive(false);
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