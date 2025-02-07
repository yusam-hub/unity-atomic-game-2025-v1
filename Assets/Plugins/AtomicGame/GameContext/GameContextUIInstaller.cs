using Atomic.Contexts;
using Atomic.Elements;
using UnityEngine;

namespace AtomicGame
{
    public sealed class GameContextUIInstaller : SceneContextInstaller<IGameContext>
    {
        [SerializeField]
        private string _mixerMasterVolumeExposedName = "GameContextMasterVolume";

        [SerializeField]
        private GameContextAudioManager gameContextAudioManager;
        
        private GameContextScoreKeyPresenter _scoreKeyPresenter;
        private GameContextScoreCoinPresenter _scoreCoinPresenter;
        private GameContextPumpkinPresenter _scorePumpkinPresenter;
        private GameContextLevelPresenter _levelPresenter;
        private SceneNextLevelComponent _sceneNextLevelComponent;
        
        protected override void Install(IGameContext context)
        {
            _scoreCoinPresenter = FindObjectOfType<GameContextScoreCoinPresenter>();
            _scoreKeyPresenter = FindObjectOfType<GameContextScoreKeyPresenter>();
            _scorePumpkinPresenter = FindObjectOfType<GameContextPumpkinPresenter>();
            _levelPresenter = FindObjectOfType<GameContextLevelPresenter>();
            _sceneNextLevelComponent = FindObjectOfType<SceneNextLevelComponent>();

            _levelPresenter.level.text = _sceneNextLevelComponent.GetCurrentLevelId();

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

            context.GetAudioVolume().Value = PlayerPrefsHelper.GetParameter("GetAudioVolume", 0f);
            context.GetAudioMusic().Value = PlayerPrefsHelper.GetParameter("GetAudioMusic", 1f);
            context.GetAudioEffect().Value = PlayerPrefsHelper.GetParameter("GetAudioEffect", 1f);
      
            gameContextAudioManager.mainMixer.SetFloat(_mixerMasterVolumeExposedName, context.GetAudioVolume().Value);
            gameContextAudioManager.musicSource.volume = context.GetAudioMusic().Value;
            gameContextAudioManager.effectSource.volume = context.GetAudioEffect().Value; 
            
            context.GetAudioVolume().Subscribe((value) =>
            {
                var v = Mathf.Clamp(value, -80f, 0f);
                gameContextAudioManager.mainMixer.SetFloat(_mixerMasterVolumeExposedName, v);
                PlayerPrefsHelper.SetParameter("GetAudioVolume", v);
            });
            
            context.GetAudioMusic().Subscribe((value) =>
            {
                gameContextAudioManager.musicSource.volume = value;
                PlayerPrefsHelper.SetParameter("GetAudioMusic", value);
            });
            
            context.GetAudioEffect().Subscribe((value) =>
            {
                gameContextAudioManager.effectSource.volume = value; 
                PlayerPrefsHelper.SetParameter("GetAudioEffect", value);
            });
        }
    }
}