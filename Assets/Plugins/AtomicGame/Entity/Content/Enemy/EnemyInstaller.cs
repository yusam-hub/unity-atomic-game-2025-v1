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
        private EnemyAttackInstaller _enemyAttackInstaller;

        [SerializeField]
        private WeaponInstaller _weaponInstaller;
        
        [SerializeField] 
        private ReactiveVariable<float> _moveSpeed = new(2f);
    
        [SerializeField] 
        private ReactiveVariable<float> _rotateSpeed = new(15f);

        [SerializeField, ReadOnly] 
        private ReactiveVariable<Vector3> _moveDirection = new();

        private GameContextPumpkinPresenter _pumpkinPresenter;
        public override void Install(IEntity entity)
        {
     
            entity.AddEnemyTag();
            entity.AddTransform(transform);
            entity.AddMoveSpeed(_moveSpeed);
            entity.AddRotateSpeed(_rotateSpeed);
            entity.AddMoveDirection(_moveDirection);
            entity.AddBehaviour(new EnemyMovingThrowTransformsBehaviour());

            _healthInstaller.Install(entity);
            _weaponInstaller.Install(entity);
            
            entity.GetDeathEvent().Subscribe(() =>
            {
                IReactiveVariable<int> pumpkinScore = GameContext.Instance.GetPumpkinScore();
                pumpkinScore.Value += 1;
                transform.gameObject.SetActive(false);
            });

            _enemyAttackInstaller.Install(entity);
        }
    }
}