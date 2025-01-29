using System;
using Atomic.Entities;
using Sirenix.OdinInspector;
using UnityEngine;

namespace AtomicGame
{
    public sealed class WeaponSceneEntityInstaller : SceneEntityInstaller
    {
        [SerializeField]
        private WeaponInstaller _weaponInstaller;
        public override void Install(IEntity entity)
        {
            _weaponInstaller.Install(entity);
        }

        [Button]
        public void SpawnTest(IEntity entity)
        {
            BulletUseCase.SpawnBullet(entity);
        }
    }
}