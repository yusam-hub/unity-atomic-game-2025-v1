using UnityEngine;

namespace AtomicGame
{
    public class AnimatorDispatcher : MonoBehaviour
    {
        [SerializeField] 
        private Animator animator;

        public Animator GetAnimator()
        {
            return animator;
        }
    }
}