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
		public const int Score = -212330411; // IReactiveVariable<int>


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
		public static IReactiveVariable<int> GetScore(this IGameContext obj) => obj.GetValue<IReactiveVariable<int>>(Score);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetScore(this IGameContext obj, out IReactiveVariable<int> value) => obj.TryGetValue(Score, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddScore(this IGameContext obj, IReactiveVariable<int> value) => obj.AddValue(Score, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasScore(this IGameContext obj) => obj.HasValue(Score);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelScore(this IGameContext obj) => obj.DelValue(Score);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetScore(this IGameContext obj, IReactiveVariable<int> value) => obj.SetValue(Score, value);
    }
}
