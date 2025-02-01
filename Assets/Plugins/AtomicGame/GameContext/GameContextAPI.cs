/**
* Code generation. Don't modify! 
**/

using Atomic.Contexts;
using System.Runtime.CompilerServices;
using UnityEngine;
using Atomic.Contexts;
using Atomic.Entities;
using Atomic.Elements;
using System.Collections.Generic;

namespace AtomicGame
{
	public static class GameContextAPI
	{


		///Values
		public const int BulletSceneEntityPool = 1173791206; // GenericSceneEntityPool
		public const int CoinScore = 293015855; // IReactiveVariable<int>
		public const int KeyScore = -787689007; // IReactiveVariable<int>
		public const int PumpkinScore = -2008409474; // IReactiveVariable<int>
		public const int GameContextConfig = 559908192; // GameContextConfig
		public const int AudioVolume = -805304480; // IReactiveVariable<float>
		public const int AudioMusic = 1364878041; // IReactiveVariable<float>
		public const int AudioEffect = -537240756; // IReactiveVariable<float>
		public const int GameState = 1452499819; // IReactiveVariable<GameContextState>
		public const int GameOverBeginEvent = -725482832; // IEvent
		public const int GameOverEndEvent = 1143324027; // IEvent
		public const int GameWinAction = 592407949; // IAction


		///Value Extensions

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static GenericSceneEntityPool GetBulletSceneEntityPool(this IGameContext obj) => obj.GetValue<GenericSceneEntityPool>(BulletSceneEntityPool);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetBulletSceneEntityPool(this IGameContext obj, out GenericSceneEntityPool value) => obj.TryGetValue(BulletSceneEntityPool, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddBulletSceneEntityPool(this IGameContext obj, GenericSceneEntityPool value) => obj.AddValue(BulletSceneEntityPool, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasBulletSceneEntityPool(this IGameContext obj) => obj.HasValue(BulletSceneEntityPool);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelBulletSceneEntityPool(this IGameContext obj) => obj.DelValue(BulletSceneEntityPool);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetBulletSceneEntityPool(this IGameContext obj, GenericSceneEntityPool value) => obj.SetValue(BulletSceneEntityPool, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IReactiveVariable<int> GetCoinScore(this IGameContext obj) => obj.GetValue<IReactiveVariable<int>>(CoinScore);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetCoinScore(this IGameContext obj, out IReactiveVariable<int> value) => obj.TryGetValue(CoinScore, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddCoinScore(this IGameContext obj, IReactiveVariable<int> value) => obj.AddValue(CoinScore, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasCoinScore(this IGameContext obj) => obj.HasValue(CoinScore);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelCoinScore(this IGameContext obj) => obj.DelValue(CoinScore);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetCoinScore(this IGameContext obj, IReactiveVariable<int> value) => obj.SetValue(CoinScore, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IReactiveVariable<int> GetKeyScore(this IGameContext obj) => obj.GetValue<IReactiveVariable<int>>(KeyScore);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetKeyScore(this IGameContext obj, out IReactiveVariable<int> value) => obj.TryGetValue(KeyScore, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddKeyScore(this IGameContext obj, IReactiveVariable<int> value) => obj.AddValue(KeyScore, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasKeyScore(this IGameContext obj) => obj.HasValue(KeyScore);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelKeyScore(this IGameContext obj) => obj.DelValue(KeyScore);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetKeyScore(this IGameContext obj, IReactiveVariable<int> value) => obj.SetValue(KeyScore, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IReactiveVariable<int> GetPumpkinScore(this IGameContext obj) => obj.GetValue<IReactiveVariable<int>>(PumpkinScore);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetPumpkinScore(this IGameContext obj, out IReactiveVariable<int> value) => obj.TryGetValue(PumpkinScore, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddPumpkinScore(this IGameContext obj, IReactiveVariable<int> value) => obj.AddValue(PumpkinScore, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasPumpkinScore(this IGameContext obj) => obj.HasValue(PumpkinScore);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelPumpkinScore(this IGameContext obj) => obj.DelValue(PumpkinScore);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetPumpkinScore(this IGameContext obj, IReactiveVariable<int> value) => obj.SetValue(PumpkinScore, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static GameContextConfig GetGameContextConfig(this IGameContext obj) => obj.GetValue<GameContextConfig>(GameContextConfig);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetGameContextConfig(this IGameContext obj, out GameContextConfig value) => obj.TryGetValue(GameContextConfig, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddGameContextConfig(this IGameContext obj, GameContextConfig value) => obj.AddValue(GameContextConfig, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasGameContextConfig(this IGameContext obj) => obj.HasValue(GameContextConfig);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelGameContextConfig(this IGameContext obj) => obj.DelValue(GameContextConfig);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetGameContextConfig(this IGameContext obj, GameContextConfig value) => obj.SetValue(GameContextConfig, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IReactiveVariable<float> GetAudioVolume(this IGameContext obj) => obj.GetValue<IReactiveVariable<float>>(AudioVolume);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetAudioVolume(this IGameContext obj, out IReactiveVariable<float> value) => obj.TryGetValue(AudioVolume, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddAudioVolume(this IGameContext obj, IReactiveVariable<float> value) => obj.AddValue(AudioVolume, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasAudioVolume(this IGameContext obj) => obj.HasValue(AudioVolume);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelAudioVolume(this IGameContext obj) => obj.DelValue(AudioVolume);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetAudioVolume(this IGameContext obj, IReactiveVariable<float> value) => obj.SetValue(AudioVolume, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IReactiveVariable<float> GetAudioMusic(this IGameContext obj) => obj.GetValue<IReactiveVariable<float>>(AudioMusic);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetAudioMusic(this IGameContext obj, out IReactiveVariable<float> value) => obj.TryGetValue(AudioMusic, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddAudioMusic(this IGameContext obj, IReactiveVariable<float> value) => obj.AddValue(AudioMusic, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasAudioMusic(this IGameContext obj) => obj.HasValue(AudioMusic);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelAudioMusic(this IGameContext obj) => obj.DelValue(AudioMusic);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetAudioMusic(this IGameContext obj, IReactiveVariable<float> value) => obj.SetValue(AudioMusic, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IReactiveVariable<float> GetAudioEffect(this IGameContext obj) => obj.GetValue<IReactiveVariable<float>>(AudioEffect);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetAudioEffect(this IGameContext obj, out IReactiveVariable<float> value) => obj.TryGetValue(AudioEffect, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddAudioEffect(this IGameContext obj, IReactiveVariable<float> value) => obj.AddValue(AudioEffect, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasAudioEffect(this IGameContext obj) => obj.HasValue(AudioEffect);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelAudioEffect(this IGameContext obj) => obj.DelValue(AudioEffect);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetAudioEffect(this IGameContext obj, IReactiveVariable<float> value) => obj.SetValue(AudioEffect, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IReactiveVariable<GameContextState> GetGameState(this IGameContext obj) => obj.GetValue<IReactiveVariable<GameContextState>>(GameState);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetGameState(this IGameContext obj, out IReactiveVariable<GameContextState> value) => obj.TryGetValue(GameState, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddGameState(this IGameContext obj, IReactiveVariable<GameContextState> value) => obj.AddValue(GameState, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasGameState(this IGameContext obj) => obj.HasValue(GameState);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelGameState(this IGameContext obj) => obj.DelValue(GameState);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetGameState(this IGameContext obj, IReactiveVariable<GameContextState> value) => obj.SetValue(GameState, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IEvent GetGameOverBeginEvent(this IGameContext obj) => obj.GetValue<IEvent>(GameOverBeginEvent);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetGameOverBeginEvent(this IGameContext obj, out IEvent value) => obj.TryGetValue(GameOverBeginEvent, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddGameOverBeginEvent(this IGameContext obj, IEvent value) => obj.AddValue(GameOverBeginEvent, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasGameOverBeginEvent(this IGameContext obj) => obj.HasValue(GameOverBeginEvent);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelGameOverBeginEvent(this IGameContext obj) => obj.DelValue(GameOverBeginEvent);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetGameOverBeginEvent(this IGameContext obj, IEvent value) => obj.SetValue(GameOverBeginEvent, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IEvent GetGameOverEndEvent(this IGameContext obj) => obj.GetValue<IEvent>(GameOverEndEvent);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetGameOverEndEvent(this IGameContext obj, out IEvent value) => obj.TryGetValue(GameOverEndEvent, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddGameOverEndEvent(this IGameContext obj, IEvent value) => obj.AddValue(GameOverEndEvent, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasGameOverEndEvent(this IGameContext obj) => obj.HasValue(GameOverEndEvent);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelGameOverEndEvent(this IGameContext obj) => obj.DelValue(GameOverEndEvent);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetGameOverEndEvent(this IGameContext obj, IEvent value) => obj.SetValue(GameOverEndEvent, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IAction GetGameWinAction(this IGameContext obj) => obj.GetValue<IAction>(GameWinAction);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetGameWinAction(this IGameContext obj, out IAction value) => obj.TryGetValue(GameWinAction, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddGameWinAction(this IGameContext obj, IAction value) => obj.AddValue(GameWinAction, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasGameWinAction(this IGameContext obj) => obj.HasValue(GameWinAction);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelGameWinAction(this IGameContext obj) => obj.DelValue(GameWinAction);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetGameWinAction(this IGameContext obj, IAction value) => obj.SetValue(GameWinAction, value);
    }
}
