using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace AtomicGame
{
    public sealed class EffectPickUpInstaller : SceneEntityInstaller
    {
        [SerializeField]
        private EffectConfig _effect;
        
        public override void Install(IEntity entity)
        {
            GameContext gameContext = GameContext.Instance;

            entity.AddTransform(transform);
            
            entity.AddInteractibleTag();
            entity.AddInteractAction(new BaseAction<IEntity>(character =>
            {
                if (EffectUseCase.CanApply(character, _effect))
                {
                    if (EffectUseCase.Apply(character, _effect))
                    {
                        //Debug.Log($"OK");
                        //gameContext.GetEntityPool().Return(entity);
                    }
                }
            }));
        }
    }
}