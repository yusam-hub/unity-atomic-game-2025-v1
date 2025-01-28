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
		public const int EntityPool = 1931115573; // GenericEntityPool
		public const int Score = -212330411; // IReactiveVariable<int>


		///Value Extensions

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static GenericEntityPool GetEntityPool(this IGameContext obj) => obj.GetValue<GenericEntityPool>(EntityPool);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetEntityPool(this IGameContext obj, out GenericEntityPool value) => obj.TryGetValue(EntityPool, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddEntityPool(this IGameContext obj, GenericEntityPool value) => obj.AddValue(EntityPool, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasEntityPool(this IGameContext obj) => obj.HasValue(EntityPool);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelEntityPool(this IGameContext obj) => obj.DelValue(EntityPool);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetEntityPool(this IGameContext obj, GenericEntityPool value) => obj.SetValue(EntityPool, value);

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
