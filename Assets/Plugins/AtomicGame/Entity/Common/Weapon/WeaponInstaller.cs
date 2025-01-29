using System;
using Atomic.Entities;
using UnityEngine;

namespace AtomicGame
{
    [Serializable]
    public sealed class WeaponInstaller : IEntityInstaller
    {
        [SerializeField]
        private SceneEntity _bulletPrefab;

        [SerializeField]
        private Transform _firePoint;

        public void Install(IEntity entity)
        {
            entity.AddBulletPrefab(_bulletPrefab);
            entity.AddFirePoint(_firePoint);
        }
    }
}