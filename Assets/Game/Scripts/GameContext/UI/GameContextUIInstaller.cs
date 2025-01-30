using Atomic.Contexts;
using Atomic.Elements;
using UnityEngine;

namespace AtomicGame
{
    public sealed class GameContextUIInstaller : SceneContextInstaller<IGameContext>
    {
        private GameContextScorePresenter _scorePresenter;
       
        [SerializeField] 
        private AudioClip _scoreCoinAudioClipChanged;
        [SerializeField] 
        private AudioClip _scoreKeyAudioClipChanged;

        protected override void Install(IGameContext context)
        {
            _scorePresenter = FindObjectOfType<GameContextScorePresenter>();
            
            IReactiveVariable<int> coinScore = context.GetCoinScore();
            
            coinScore.Subscribe((value) =>
            {
                if (_scorePresenter) {
                    _scorePresenter.score.text = value.ToString();
                }
                AudioManager.PlayOneShot(_scoreCoinAudioClipChanged);       
            });
            
            IReactiveVariable<int> keyScore = context.GetKeyScore();
            
            keyScore.Subscribe((value) =>
            {
                if (_scorePresenter) {
                    _scorePresenter.score.text = value.ToString();
                }
                AudioManager.PlayOneShot(_scoreKeyAudioClipChanged);       
            });
        }
    }
}