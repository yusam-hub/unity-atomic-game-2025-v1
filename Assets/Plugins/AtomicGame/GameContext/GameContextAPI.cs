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
    }
}
