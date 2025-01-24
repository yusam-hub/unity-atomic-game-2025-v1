using UnityEngine;

namespace Game
{
    public sealed class GroundRaycaster : IGroundRaycaster
    {
        public bool Raycast(Vector2 screenPosition, out Vector3 groundPosition)
        {
            groundPosition = default;
            
            Ray ray = Camera.main!.ScreenPointToRay(screenPosition);
            
            if (!Physics.Raycast(ray, out RaycastHit hit))
            {
                return false;  
            }
     

            if (!hit.transform.CompareTag("Ground"))
            {
                return false;
            }

            groundPosition = hit.point;
            return true;
        }
    }
}