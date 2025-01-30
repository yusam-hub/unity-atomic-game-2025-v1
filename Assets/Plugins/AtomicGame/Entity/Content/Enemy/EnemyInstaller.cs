using Atomic.Elements;
using Atomic.Entities;
using Sirenix.OdinInspector;
using UnityEngine;

namespace AtomicGame
{
    public class EnemyInstaller: SceneEntityInstaller
    {
        [SerializeField] 
        private HealthInstaller _healthInstaller;
        
        [SerializeField] 
        private ReactiveVariable<float> _moveSpeed = new(2f);
    
        [SerializeField] 
        private ReactiveVariable<float> _rotateSpeed = new(15f);

        [SerializeField, ReadOnly] 
        private ReactiveVariable<Vector3> _moveDirection = new();
        
        public override void Install(IEntity entity)
        {
            _healthInstaller.Install(entity);
            
            entity.AddTransform(transform);
            entity.AddMoveSpeed(_moveSpeed);
            entity.AddRotateSpeed(_rotateSpeed);
            entity.AddMoveDirection(_moveDirection);
            entity.AddBehaviour(new EnemyBehaviour());

            entity.GetDeathEvent().Subscribe(() =>
            {
                transform.gameObject.SetActive(false);
            });
        }
    }
}