using UnityEngine;

namespace Game
{
    public class CharacterAnimator : MonoBehaviour
    {
        private static readonly int IsMovingKey = Animator.StringToHash("IsMoving");
        
        [SerializeField]
        private Animator animator;

        [SerializeField]
        private Character character; 
        
        private void LateUpdate()
        {
            //animator.SetBool(IsMovingKey, this.character.IsMoving());
        }
    }
}