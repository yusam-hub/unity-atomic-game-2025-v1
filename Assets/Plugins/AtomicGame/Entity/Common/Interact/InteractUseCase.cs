using System.Buffers;
using Atomic.Entities;
using UnityEngine;

namespace AtomicGame
{
    public static class InteractUseCase
    {
        private const int COLLIDER_BUFFER_SIZE = 32;

        public static bool Interact(in IEntity character, in Collider collider)
        {
            return collider != null && collider.TryGetComponent(out IEntity other) && Interact(character, other);
        }

        public static bool Interact(in IEntity character, in IEntity interactible)
        {
            if (character == null)
            {
                return false;
            }
            
            if (interactible == null)
            {
                return false;
            }

            if (!interactible.HasInteractableTag())
            {
                return false;
            }
            
            interactible.GetInteractAction().Invoke(character);

            return true;
        }

        public static bool InteractAsCharacter(in IEntity character)
        {
            IEntity interactable = character.GetTargetInteractable().Value;
            return Interact(character, interactable);
        }

        public static bool FindClosest(
            in Vector3 center,
            in float radius,
            in LayerMask layerMask,
            in QueryTriggerInteraction triggerInteraction,
            out IEntity interactable
        )
        {
            ArrayPool<Collider> arrayPool = ArrayPool<Collider>.Shared;
            Collider[] colliders = arrayPool.Rent(COLLIDER_BUFFER_SIZE);

            int count = Physics.OverlapSphereNonAlloc(center, radius, colliders, layerMask, triggerInteraction);

            float minDistance = float.MaxValue;
            interactable = null;

            for (int i = 0; i < count; i++)
            {
                Collider collider = colliders[i];
                if (!collider.TryGetEntity(out IEntity other) || !other.HasInteractableTag())
                    continue;

                Vector3 position = other.GetTransform().position;
                float distance = Vector3.SqrMagnitude(position - center);
                if (distance >= minDistance)
                    continue;

                interactable = other;
                minDistance = distance;
            }

            arrayPool.Return(colliders);
            return interactable != null;
        }
    }
}