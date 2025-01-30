using UnityEngine;
using UnityEngine.Serialization;

namespace AtomicGame
{
    
    [CreateAssetMenu(
        fileName = "GameContextConfig",
        menuName = "Ag/Game Context/New GameContextConfig"
    )]
    public sealed class GameContextConfig : ScriptableObject
    {
        [SerializeField] 
        public AudioClipConfig audioClipConfig;

        [SerializeField] 
        public VfxPrefabConfig vfxPrefabConfig;
    }
}