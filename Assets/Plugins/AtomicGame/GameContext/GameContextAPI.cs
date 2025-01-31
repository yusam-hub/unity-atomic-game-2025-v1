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
    }
}
