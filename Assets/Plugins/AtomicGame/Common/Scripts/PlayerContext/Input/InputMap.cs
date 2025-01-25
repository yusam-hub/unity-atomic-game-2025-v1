using UnityEngine;

namespace AtomicGame.Common
{
    [CreateAssetMenu(
        fileName = "InputMap",
        menuName = "Ag/New InputMap"
    )]
    public sealed class InputMap : ScriptableObject
    {
        [field: SerializeField]
        public KeyCode MoveLeft { get; private set; } = KeyCode.A;

        [field: SerializeField]
        public KeyCode MoveRight { get; private set; } = KeyCode.D;

        [field: SerializeField]
        public KeyCode MoveForward { get; private set; } = KeyCode.W;

        [field: SerializeField]
        public KeyCode MoveBack { get; private set; } = KeyCode.S;

        [field: SerializeField]
        public KeyCode Jump { get; private set; } = KeyCode.Space;
    }
}