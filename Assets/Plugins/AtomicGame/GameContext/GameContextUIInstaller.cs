using Atomic.Contexts;
using Atomic.Elements;
using UnityEngine;

namespace AtomicGame
{
    public sealed class GameContextUIInstaller : SceneContextInstaller<IGameContext>
    {
        [SerializeField]
        private string _mixerMasterVolumeExposedName = "GameContextMasterVolume";
        
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
                GameContextAudioManager.PlayOneShot(context.GetGameContextConfig().audioClipConfig.addScoreCoin);       
            });
            
            IReactiveVariable<int> keyScore = context.GetKeyScore();
            
            keyScore.Subscribe((value) =>
            {
                if (_scoreKeyPresenter) {
                    _scoreKeyPresenter.score.text = value.ToString();
                }
                GameContextAudioManager.PlayOneShot(context.GetGameContextConfig().audioClipConfig.addScoreKey);       
            });
            
            IReactiveVariable<int> pumpkinScore = context.GetPumpkinScore();
            
            pumpkinScore.Subscribe((value) =>
            {
                if (_scorePumpkinPresenter) {
                    _scorePumpkinPresenter.pumpkin.text = value.ToString();
                }
                GameContextAudioManager.PlayOneShot(context.GetGameContextConfig().audioClipConfig.addScorePumpkin);       
            });
            
            context.GetAudioVolume().Subscribe((value) =>
            {
                GameContextAudioManager.Instance.mainMixer.SetFloat(_mixerMasterVolumeExposedName, Mathf.Clamp(value, -80f, 0f));
            });
            
            context.GetAudioMusic().Subscribe((value) =>
            {
                GameContextAudioManager.Instance.musicSource.volume = value;
            });
            
            context.GetAudioEffect().Subscribe((value) =>
            {
                GameContextAudioManager.Instance.effectSource.volume = value;   
            });
        }
    }
}