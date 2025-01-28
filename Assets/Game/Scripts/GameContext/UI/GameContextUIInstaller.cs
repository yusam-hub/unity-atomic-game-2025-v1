using Atomic.Contexts;
using Atomic.Elements;
using Game.Scripts.GameContext.Audio;
using UnityEngine;

namespace AtomicGame
{
    public sealed class GameContextUIInstaller : SceneContextInstaller<IGameContext>
    {
        private GameContextScorePresenter _scorePresenter;
       
        [SerializeField] 
        private AudioClip _scoreAudioClipChanged;

        protected override void Install(IGameContext context)
        {
            _scorePresenter = FindObjectOfType<GameContextScorePresenter>();
            
            IReactiveVariable<int> score = context.GetScore();
            
            score.Subscribe((value) =>
            {
                if (_scorePresenter) {
                    _scorePresenter.score.text = value.ToString();
                }
                AudioManager.PlayOneShot(_scoreAudioClipChanged);       
            });
        }
    }
}