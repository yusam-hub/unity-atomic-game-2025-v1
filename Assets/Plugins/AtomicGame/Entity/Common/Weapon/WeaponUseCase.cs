using Atomic.Entities;
using UnityEngine;

namespace AtomicGame
{
    public static class WeaponUseCase
    {
        public static IEntity FireBullet(this IEntity entity)
        {
            SceneEntity bulletPrefab = entity.GetBulletPrefab();
            Transform firePoint = entity.GetFirePoint();
            return SceneEntity.Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        }
    }
}