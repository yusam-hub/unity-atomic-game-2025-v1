using Atomic.Entities;
using UnityEngine;

namespace AtomicGame
{
    public static class BulletUseCase
    {
        public static IEntity SpawnBullet(in IEntity entity)
        {
            if (!entity.HasBulletPrefab())
            {
                return null;
            }
            if (!entity.HasFirePoint())
            {
                return null;
            }

            GameContext gameContext = GameContext.Instance;
            
            SceneEntity bulletPrefab = entity.GetBulletPrefab();
            Transform firePoint = entity.GetFirePoint();
 
            SceneEntity bullet = gameContext.GetBulletSceneEntityPool()
                .Rent(bulletPrefab, firePoint.position, firePoint.rotation);
            
            bullet.GetLifetime().Reset();
            bullet.GetMoveDirection().Value = firePoint.forward;

            return bullet;
        }

        public static void UnSpawnBullet(in IEntity entity)
        {
            GameContext gameContext = GameContext.Instance;
            gameContext.GetBulletSceneEntityPool().Return(entity);
        }
    }
}