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
        
        [SerializeField]
        private float _lifetime = 10;

        [SerializeField]
        private GameObject _damageActionPrefab;
  
        public override void Install(IEntity entity)
        {
            entity.AddTransform(transform);
            entity.AddDamage(new Const<int>(_damage));
            
            entity.AddLifetime(new Cooldown(_lifetime, _lifetime));
            
            entity.AddDamageAction(new BaseAction(() =>
            {
                if (_damageActionPrefab)
                {
                    Destroy(Instantiate(_damageActionPrefab, transform.position, transform.rotation), 3);
                }
            }));
            
            entity.AddDestroyAction(new BaseAction(() =>
            {
                BulletUseCase.UnSpawnBullet(entity);
            }));
            
            entity.AddMoveSpeed(new ReactiveVariable<float>(_moveSpeed));
            entity.AddMoveDirection(new ReactiveVariable<Vector3>(transform.forward));
            entity.AddTriggerDispatcher(_triggerDispatcher);
            
            entity.WhenFixedUpdate(entity.TransformMoveSelf);
            entity.AddBehaviour<BulletCollisionBehaviour>();
            entity.AddBehaviour<BulletLifetimeBehaviour>();
        }
    }
}