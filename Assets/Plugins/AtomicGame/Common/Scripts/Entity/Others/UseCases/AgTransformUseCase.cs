using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace AtomicGame.Common
{
    public static class AgTransformUseCase
    {
        /*public static void AgMoveTowardsSelf(this IEntity entity, float deltaTime)
        {
            IReactiveVariable<Vector3> direction = entity.GetMoveDirection();
            entity.AgMoveTowards(direction.Value, deltaTime);
        }*/
        
        public static void AgTransformMoveByDirection(this IEntity entity, in Vector3 direction, in float deltaTime)
        {
            /*if (entity.TryGetMoveCondition(out IExpression<bool> condition) && !condition.Value)
            {
                return;           
            }*/
            if (!entity.HasTransform()) return;
            if (!entity.HasMoveSpeed()) return;
            Transform transform = entity.GetTransform();
            IValue<float> speed = entity.GetMoveSpeed();
            transform.position += direction * (speed.Invoke() * deltaTime);
        }
        
        public static void AgTransformRotateByDirection(this IEntity entity, in Vector3 direction, in float deltaTime)
        {
            if (direction == Vector3.zero)
            {
                return;
            }

            Quaternion targetRotation = Quaternion.LookRotation(direction, Vector3.up);
            AgTransformRotateByDirection(entity, targetRotation, deltaTime);
        }

        public static void AgTransformRotateByDirection(this IEntity entity, in Quaternion targetRotation, in float deltaTime)
        {
            if (!entity.HasTransform()) return;
            if (!entity.HasRotateSpeed()) return;
            
            float speed = entity.GetRotateSpeed().Value * deltaTime;
            Transform transform = entity.GetTransform();
            transform.rotation = AgTransformRotateByDirection(transform.rotation, targetRotation, speed);
        }
        
        public static Quaternion AgTransformRotateByDirection(in Quaternion currentRotation, in Quaternion targetRotation, in float speed)
        {
            return Quaternion.Lerp(currentRotation, targetRotation, speed);
        }
    }
}