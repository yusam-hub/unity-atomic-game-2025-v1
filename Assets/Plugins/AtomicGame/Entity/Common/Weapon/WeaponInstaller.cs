using System;
using Atomic.Elements;
using Atomic.Entities;
using Sirenix.OdinInspector;
using UnityEngine;

namespace AtomicGame
{
    [Serializable]
    public sealed class WeaponInstaller : IEntityInstaller
    {
        [SerializeField]
        private SceneEntity _bulletPrefab;

        [SerializeField]
        private Transform _weaponFirePoint;

        public void Install(IEntity entity)
        {
            entity.AddBulletPrefab(_bulletPrefab);
            entity.AddWeaponFirePoint(_weaponFirePoint);
            entity.AddWeaponFireEvent(new BaseEvent());
            entity.AddWeaponFireAction(new BaseAction(() =>
            {
                BulletUseCase.SpawnBullet(entity);
                entity.GetWeaponFireEvent().Invoke();
            }));
        }

        [Button]
        public void FireActionTest(IEntity entity)
        {
            entity.GetWeaponFireAction().Invoke();
        }
    }
}