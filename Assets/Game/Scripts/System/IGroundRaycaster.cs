using UnityEngine;

namespace Game
{
    public interface IGroundRaycaster
    {
        bool Raycast(Vector2 screenPosition, out Vector3 groundPosition);
    }
}