using Atomic.Contexts;
using Atomic.Elements;
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
            
            IReactiveVariable<int> coinScore = context.GetCoinScore();
            
            coinScore.Subscribe((value) =>
            {
                if (_scorePresenter) {
                    _scorePresenter.score.text = value.ToString();
                }
                AudioManager.PlayOneShot(_scoreAudioClipChanged);       
            });
        }
    }
}