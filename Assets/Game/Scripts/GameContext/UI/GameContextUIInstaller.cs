using Atomic.Contexts;
using Atomic.Elements;
using UnityEngine;

namespace AtomicGame
{
    public sealed class GameContextUIInstaller : SceneContextInstaller<IGameContext>
    {
        private GameContextScoreKeyPresenter _scoreKeyPresenter;
        private GameContextScoreCoinPresenter _scoreCoinPresenter;
        private GameContextPumpkinPresenter _scorePumpkinPresenter;

        protected override void Install(IGameContext context)
        {
            _scoreCoinPresenter = FindObjectOfType<GameContextScoreCoinPresenter>();
            _scoreKeyPresenter = FindObjectOfType<GameContextScoreKeyPresenter>();
            _scorePumpkinPresenter = FindObjectOfType<GameContextPumpkinPresenter>();
            
            IReactiveVariable<int> coinScore = context.GetCoinScore();
            
            coinScore.Subscribe((value) =>
            {
                if (_scoreCoinPresenter) {
                    _scoreCoinPresenter.score.text = value.ToString();
                }
                AudioManager.PlayOneShot(context.GetGameContextConfig().audioClipConfig.addScoreCoin);       
            });
            
            IReactiveVariable<int> keyScore = context.GetKeyScore();
            
            keyScore.Subscribe((value) =>
            {
                if (_scoreKeyPresenter) {
                    _scoreKeyPresenter.score.text = value.ToString();
                }
                AudioManager.PlayOneShot(context.GetGameContextConfig().audioClipConfig.addScoreKey);       
            });
            
            IReactiveVariable<int> pumpkinScore = context.GetPumpkinScore();
            
            pumpkinScore.Subscribe((value) =>
            {
                if (_scorePumpkinPresenter) {
                    _scorePumpkinPresenter.pumpkin.text = value.ToString();
                }
                AudioManager.PlayOneShot(context.GetGameContextConfig().audioClipConfig.addScorePumpkin);       
            });
        }
    }
}