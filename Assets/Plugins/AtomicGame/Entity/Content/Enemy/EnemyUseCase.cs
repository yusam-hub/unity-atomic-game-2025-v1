using System.Buffers;
using Atomic.Entities;
using UnityEngine;

namespace AtomicGame
{
    public static class EnemyUseCase
    {
        private const int COLLIDER_BUFFER_SIZE = 32;

        public static bool FindClosest(
            in Vector3 center,
            in float radius,
            in LayerMask layerMask,
            in QueryTriggerInteraction triggerInteraction,
            out IEntity attackable
        )
        {
            ArrayPool<Collider> arrayPool = ArrayPool<Collider>.Shared;
            Collider[] colliders = arrayPool.Rent(COLLIDER_BUFFER_SIZE);

            int count = Physics.OverlapSphereNonAlloc(center, radius, colliders, layerMask, triggerInteraction);

            float minDistance = float.MaxValue;
            attackable = null;

            for (int i = 0; i < count; i++)
            {
                Collider collider = colliders[i];
                if (!collider.TryGetEntity(out IEntity other) || !other.HasPlayerTag())
                    continue;

                Vector3 position = other.GetTransform().position;
                float distance = Vector3.SqrMagnitude(position - center);
                if (distance >= minDistance)
                    continue;

                attackable = other;
                minDistance = distance;
            }

            arrayPool.Return(colliders);
            return attackable != null;
        }
    }
}