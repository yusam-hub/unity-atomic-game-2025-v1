using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace AtomicGame
{
    public class BulletInstaller : SceneEntityInstaller
    {
        [SerializeField]
        private float _moveSpeed = 3;

        [SerializeField]
        private int _damage;
        
        [SerializeField]
        private TriggerDispatcher _triggerDispatcher;
        public override void Install(IEntity entity)
        {
            entity.AddTransform(transform);
            entity.AddDamage(new Const<int>(_damage));
            
            entity.AddMoveSpeed(new ReactiveVariable<float>(_moveSpeed));
            entity.AddMoveDirection(new ReactiveVariable<Vector3>(transform.forward));
            entity.AddTriggerDispatcher(_triggerDispatcher);
            
            entity.WhenFixedUpdate(entity.TransformMoveSelf);
            entity.AddBehaviour<BulletCollisionBehaviour>();
        }
    }
}