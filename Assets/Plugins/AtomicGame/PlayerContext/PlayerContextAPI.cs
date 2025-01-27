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
	public static class PlayerContextAPI
	{


		///Values
		public const int Character = 294335127; // IEntity
		public const int InputMap = 43340267; // InputMap
		public const int Camera = 1018227507; // Camera
		public const int CameraFollowOffset = -132420912; // IValue<Vector3>
		public const int CameraPlanarRotation = 1317883087; // IReactiveVariable<Quaternion>


		///Value Extensions

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IEntity GetCharacter(this IPlayerContext obj) => obj.GetValue<IEntity>(Character);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetCharacter(this IPlayerContext obj, out IEntity value) => obj.TryGetValue(Character, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddCharacter(this IPlayerContext obj, IEntity value) => obj.AddValue(Character, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasCharacter(this IPlayerContext obj) => obj.HasValue(Character);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelCharacter(this IPlayerContext obj) => obj.DelValue(Character);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetCharacter(this IPlayerContext obj, IEntity value) => obj.SetValue(Character, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static InputMap GetInputMap(this IPlayerContext obj) => obj.GetValue<InputMap>(InputMap);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetInputMap(this IPlayerContext obj, out InputMap value) => obj.TryGetValue(InputMap, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddInputMap(this IPlayerContext obj, InputMap value) => obj.AddValue(InputMap, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasInputMap(this IPlayerContext obj) => obj.HasValue(InputMap);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelInputMap(this IPlayerContext obj) => obj.DelValue(InputMap);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetInputMap(this IPlayerContext obj, InputMap value) => obj.SetValue(InputMap, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Camera GetCamera(this IPlayerContext obj) => obj.GetValue<Camera>(Camera);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetCamera(this IPlayerContext obj, out Camera value) => obj.TryGetValue(Camera, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddCamera(this IPlayerContext obj, Camera value) => obj.AddValue(Camera, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasCamera(this IPlayerContext obj) => obj.HasValue(Camera);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelCamera(this IPlayerContext obj) => obj.DelValue(Camera);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetCamera(this IPlayerContext obj, Camera value) => obj.SetValue(Camera, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IValue<Vector3> GetCameraFollowOffset(this IPlayerContext obj) => obj.GetValue<IValue<Vector3>>(CameraFollowOffset);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetCameraFollowOffset(this IPlayerContext obj, out IValue<Vector3> value) => obj.TryGetValue(CameraFollowOffset, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddCameraFollowOffset(this IPlayerContext obj, IValue<Vector3> value) => obj.AddValue(CameraFollowOffset, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasCameraFollowOffset(this IPlayerContext obj) => obj.HasValue(CameraFollowOffset);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelCameraFollowOffset(this IPlayerContext obj) => obj.DelValue(CameraFollowOffset);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetCameraFollowOffset(this IPlayerContext obj, IValue<Vector3> value) => obj.SetValue(CameraFollowOffset, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IReactiveVariable<Quaternion> GetCameraPlanarRotation(this IPlayerContext obj) => obj.GetValue<IReactiveVariable<Quaternion>>(CameraPlanarRotation);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetCameraPlanarRotation(this IPlayerContext obj, out IReactiveVariable<Quaternion> value) => obj.TryGetValue(CameraPlanarRotation, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddCameraPlanarRotation(this IPlayerContext obj, IReactiveVariable<Quaternion> value) => obj.AddValue(CameraPlanarRotation, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasCameraPlanarRotation(this IPlayerContext obj) => obj.HasValue(CameraPlanarRotation);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelCameraPlanarRotation(this IPlayerContext obj) => obj.DelValue(CameraPlanarRotation);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetCameraPlanarRotation(this IPlayerContext obj, IReactiveVariable<Quaternion> value) => obj.SetValue(CameraPlanarRotation, value);
    }
}
