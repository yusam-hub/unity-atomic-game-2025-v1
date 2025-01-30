using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace AtomicGame
{
    public class EnemyInstaller: SceneEntityInstaller
    {
        [SerializeField]
        private Transform[] _patrolPoints;
        
        [SerializeField] 
        private ReactiveVariable<float> _moveSpeed = new(2f);
    
        [SerializeField] 
        private ReactiveVariable<float> _rotateSpeed = new(15f);

        [SerializeField] 
        private HealthInstaller _healthInstaller;
        
        public override void Install(IEntity entity)
        {
            _healthInstaller.Install(entity);
            
            entity.AddTransform(transform);
            entity.AddTransforms(_patrolPoints);
            entity.AddMoveSpeed(_moveSpeed);
            entity.AddRotateSpeed(_rotateSpeed);
            entity.AddMoveDirection(new ReactiveVariable<Vector3>());
            entity.AddBehaviour(new EnemyBehaviour());
        }
    }
}