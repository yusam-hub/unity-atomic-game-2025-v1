/**
* Code generation. Don't modify! 
**/

using Atomic.Entities;
using System.Runtime.CompilerServices;
using System;
using UnityEngine;
using Atomic.Entities;
using Atomic.Elements;

namespace AtomicGame
{
	public static class AgCommonEntityApi
	{


		///Values
		public const int Transform = -180157682; // Transform
		public const int Transforms = -62676721; // Transform[]
		public const int CharacterController = -270069640; // CharacterController
		public const int MoveSpeed = 526065662; // IValue<float>
		public const int MoveAction = 1225226561; // IAction<Vector3, float>
		public const int IsMoving = 120489994; // IValue<bool>
		public const int IsGrounded = 507951781; // IValue<bool>
		public const int RotateSpeed = -1838353354; // IValue<float>
		public const int RotateAction = -600505304; // IAction<Vector3, float>
		public const int JumpAction = -2046675773; // IAction
		public const int KeyPressAction = -418488485; // IAction<KeyCode>
		public const int KeyDownAction = -124030595; // IAction<KeyCode>
		public const int KeyUpAction = -181628813; // IAction<KeyCode>
		public const int Animator = -1714818978; // Animator
		public const int AnimatorCurrentState = 1457520650; // IValue<int>
		public const int ChangeCrossFadeEvent = 364688039; // IEvent<int>
		public const int AgCollisionDispatcher = -1086234326; // AgCollisionDispatcher
		public const int AgTriggerDispatcher = 817328212; // AgTriggerDispatcher
		public const int AgControllerColliderHitDispatcher = -53023836; // AgControllerColliderHitDispatcher


		///Value Extensions

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Transform GetTransform(this IEntity obj) => obj.GetValue<Transform>(Transform);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetTransform(this IEntity obj, out Transform value) => obj.TryGetValue(Transform, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddTransform(this IEntity obj, Transform value) => obj.AddValue(Transform, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasTransform(this IEntity obj) => obj.HasValue(Transform);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelTransform(this IEntity obj) => obj.DelValue(Transform);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetTransform(this IEntity obj, Transform value) => obj.SetValue(Transform, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Transform[] GetTransforms(this IEntity obj) => obj.GetValue<Transform[]>(Transforms);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetTransforms(this IEntity obj, out Transform[] value) => obj.TryGetValue(Transforms, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddTransforms(this IEntity obj, Transform[] value) => obj.AddValue(Transforms, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasTransforms(this IEntity obj) => obj.HasValue(Transforms);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelTransforms(this IEntity obj) => obj.DelValue(Transforms);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetTransforms(this IEntity obj, Transform[] value) => obj.SetValue(Transforms, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static CharacterController GetCharacterController(this IEntity obj) => obj.GetValue<CharacterController>(CharacterController);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetCharacterController(this IEntity obj, out CharacterController value) => obj.TryGetValue(CharacterController, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddCharacterController(this IEntity obj, CharacterController value) => obj.AddValue(CharacterController, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasCharacterController(this IEntity obj) => obj.HasValue(CharacterController);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelCharacterController(this IEntity obj) => obj.DelValue(CharacterController);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetCharacterController(this IEntity obj, CharacterController value) => obj.SetValue(CharacterController, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IValue<float> GetMoveSpeed(this IEntity obj) => obj.GetValue<IValue<float>>(MoveSpeed);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetMoveSpeed(this IEntity obj, out IValue<float> value) => obj.TryGetValue(MoveSpeed, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddMoveSpeed(this IEntity obj, IValue<float> value) => obj.AddValue(MoveSpeed, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasMoveSpeed(this IEntity obj) => obj.HasValue(MoveSpeed);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelMoveSpeed(this IEntity obj) => obj.DelValue(MoveSpeed);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetMoveSpeed(this IEntity obj, IValue<float> value) => obj.SetValue(MoveSpeed, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IAction<Vector3, float> GetMoveAction(this IEntity obj) => obj.GetValue<IAction<Vector3, float>>(MoveAction);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetMoveAction(this IEntity obj, out IAction<Vector3, float> value) => obj.TryGetValue(MoveAction, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddMoveAction(this IEntity obj, IAction<Vector3, float> value) => obj.AddValue(MoveAction, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasMoveAction(this IEntity obj) => obj.HasValue(MoveAction);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelMoveAction(this IEntity obj) => obj.DelValue(MoveAction);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetMoveAction(this IEntity obj, IAction<Vector3, float> value) => obj.SetValue(MoveAction, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IValue<bool> GetIsMoving(this IEntity obj) => obj.GetValue<IValue<bool>>(IsMoving);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetIsMoving(this IEntity obj, out IValue<bool> value) => obj.TryGetValue(IsMoving, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddIsMoving(this IEntity obj, IValue<bool> value) => obj.AddValue(IsMoving, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasIsMoving(this IEntity obj) => obj.HasValue(IsMoving);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelIsMoving(this IEntity obj) => obj.DelValue(IsMoving);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetIsMoving(this IEntity obj, IValue<bool> value) => obj.SetValue(IsMoving, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IValue<bool> GetIsGrounded(this IEntity obj) => obj.GetValue<IValue<bool>>(IsGrounded);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetIsGrounded(this IEntity obj, out IValue<bool> value) => obj.TryGetValue(IsGrounded, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddIsGrounded(this IEntity obj, IValue<bool> value) => obj.AddValue(IsGrounded, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasIsGrounded(this IEntity obj) => obj.HasValue(IsGrounded);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelIsGrounded(this IEntity obj) => obj.DelValue(IsGrounded);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetIsGrounded(this IEntity obj, IValue<bool> value) => obj.SetValue(IsGrounded, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IValue<float> GetRotateSpeed(this IEntity obj) => obj.GetValue<IValue<float>>(RotateSpeed);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetRotateSpeed(this IEntity obj, out IValue<float> value) => obj.TryGetValue(RotateSpeed, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddRotateSpeed(this IEntity obj, IValue<float> value) => obj.AddValue(RotateSpeed, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasRotateSpeed(this IEntity obj) => obj.HasValue(RotateSpeed);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelRotateSpeed(this IEntity obj) => obj.DelValue(RotateSpeed);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetRotateSpeed(this IEntity obj, IValue<float> value) => obj.SetValue(RotateSpeed, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IAction<Vector3, float> GetRotateAction(this IEntity obj) => obj.GetValue<IAction<Vector3, float>>(RotateAction);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetRotateAction(this IEntity obj, out IAction<Vector3, float> value) => obj.TryGetValue(RotateAction, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddRotateAction(this IEntity obj, IAction<Vector3, float> value) => obj.AddValue(RotateAction, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasRotateAction(this IEntity obj) => obj.HasValue(RotateAction);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelRotateAction(this IEntity obj) => obj.DelValue(RotateAction);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetRotateAction(this IEntity obj, IAction<Vector3, float> value) => obj.SetValue(RotateAction, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IAction GetJumpAction(this IEntity obj) => obj.GetValue<IAction>(JumpAction);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetJumpAction(this IEntity obj, out IAction value) => obj.TryGetValue(JumpAction, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddJumpAction(this IEntity obj, IAction value) => obj.AddValue(JumpAction, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasJumpAction(this IEntity obj) => obj.HasValue(JumpAction);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelJumpAction(this IEntity obj) => obj.DelValue(JumpAction);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetJumpAction(this IEntity obj, IAction value) => obj.SetValue(JumpAction, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IAction<KeyCode> GetKeyPressAction(this IEntity obj) => obj.GetValue<IAction<KeyCode>>(KeyPressAction);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetKeyPressAction(this IEntity obj, out IAction<KeyCode> value) => obj.TryGetValue(KeyPressAction, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddKeyPressAction(this IEntity obj, IAction<KeyCode> value) => obj.AddValue(KeyPressAction, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasKeyPressAction(this IEntity obj) => obj.HasValue(KeyPressAction);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelKeyPressAction(this IEntity obj) => obj.DelValue(KeyPressAction);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetKeyPressAction(this IEntity obj, IAction<KeyCode> value) => obj.SetValue(KeyPressAction, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IAction<KeyCode> GetKeyDownAction(this IEntity obj) => obj.GetValue<IAction<KeyCode>>(KeyDownAction);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetKeyDownAction(this IEntity obj, out IAction<KeyCode> value) => obj.TryGetValue(KeyDownAction, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddKeyDownAction(this IEntity obj, IAction<KeyCode> value) => obj.AddValue(KeyDownAction, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasKeyDownAction(this IEntity obj) => obj.HasValue(KeyDownAction);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelKeyDownAction(this IEntity obj) => obj.DelValue(KeyDownAction);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetKeyDownAction(this IEntity obj, IAction<KeyCode> value) => obj.SetValue(KeyDownAction, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IAction<KeyCode> GetKeyUpAction(this IEntity obj) => obj.GetValue<IAction<KeyCode>>(KeyUpAction);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetKeyUpAction(this IEntity obj, out IAction<KeyCode> value) => obj.TryGetValue(KeyUpAction, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddKeyUpAction(this IEntity obj, IAction<KeyCode> value) => obj.AddValue(KeyUpAction, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasKeyUpAction(this IEntity obj) => obj.HasValue(KeyUpAction);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelKeyUpAction(this IEntity obj) => obj.DelValue(KeyUpAction);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetKeyUpAction(this IEntity obj, IAction<KeyCode> value) => obj.SetValue(KeyUpAction, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Animator GetAnimator(this IEntity obj) => obj.GetValue<Animator>(Animator);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetAnimator(this IEntity obj, out Animator value) => obj.TryGetValue(Animator, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddAnimator(this IEntity obj, Animator value) => obj.AddValue(Animator, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasAnimator(this IEntity obj) => obj.HasValue(Animator);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelAnimator(this IEntity obj) => obj.DelValue(Animator);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetAnimator(this IEntity obj, Animator value) => obj.SetValue(Animator, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IValue<int> GetAnimatorCurrentState(this IEntity obj) => obj.GetValue<IValue<int>>(AnimatorCurrentState);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetAnimatorCurrentState(this IEntity obj, out IValue<int> value) => obj.TryGetValue(AnimatorCurrentState, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddAnimatorCurrentState(this IEntity obj, IValue<int> value) => obj.AddValue(AnimatorCurrentState, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasAnimatorCurrentState(this IEntity obj) => obj.HasValue(AnimatorCurrentState);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelAnimatorCurrentState(this IEntity obj) => obj.DelValue(AnimatorCurrentState);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetAnimatorCurrentState(this IEntity obj, IValue<int> value) => obj.SetValue(AnimatorCurrentState, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IEvent<int> GetChangeCrossFadeEvent(this IEntity obj) => obj.GetValue<IEvent<int>>(ChangeCrossFadeEvent);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetChangeCrossFadeEvent(this IEntity obj, out IEvent<int> value) => obj.TryGetValue(ChangeCrossFadeEvent, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddChangeCrossFadeEvent(this IEntity obj, IEvent<int> value) => obj.AddValue(ChangeCrossFadeEvent, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasChangeCrossFadeEvent(this IEntity obj) => obj.HasValue(ChangeCrossFadeEvent);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelChangeCrossFadeEvent(this IEntity obj) => obj.DelValue(ChangeCrossFadeEvent);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetChangeCrossFadeEvent(this IEntity obj, IEvent<int> value) => obj.SetValue(ChangeCrossFadeEvent, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static AgCollisionDispatcher GetAgCollisionDispatcher(this IEntity obj) => obj.GetValue<AgCollisionDispatcher>(AgCollisionDispatcher);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetAgCollisionDispatcher(this IEntity obj, out AgCollisionDispatcher value) => obj.TryGetValue(AgCollisionDispatcher, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddAgCollisionDispatcher(this IEntity obj, AgCollisionDispatcher value) => obj.AddValue(AgCollisionDispatcher, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasAgCollisionDispatcher(this IEntity obj) => obj.HasValue(AgCollisionDispatcher);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelAgCollisionDispatcher(this IEntity obj) => obj.DelValue(AgCollisionDispatcher);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetAgCollisionDispatcher(this IEntity obj, AgCollisionDispatcher value) => obj.SetValue(AgCollisionDispatcher, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static AgTriggerDispatcher GetAgTriggerDispatcher(this IEntity obj) => obj.GetValue<AgTriggerDispatcher>(AgTriggerDispatcher);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetAgTriggerDispatcher(this IEntity obj, out AgTriggerDispatcher value) => obj.TryGetValue(AgTriggerDispatcher, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddAgTriggerDispatcher(this IEntity obj, AgTriggerDispatcher value) => obj.AddValue(AgTriggerDispatcher, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasAgTriggerDispatcher(this IEntity obj) => obj.HasValue(AgTriggerDispatcher);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelAgTriggerDispatcher(this IEntity obj) => obj.DelValue(AgTriggerDispatcher);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetAgTriggerDispatcher(this IEntity obj, AgTriggerDispatcher value) => obj.SetValue(AgTriggerDispatcher, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static AgControllerColliderHitDispatcher GetAgControllerColliderHitDispatcher(this IEntity obj) => obj.GetValue<AgControllerColliderHitDispatcher>(AgControllerColliderHitDispatcher);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetAgControllerColliderHitDispatcher(this IEntity obj, out AgControllerColliderHitDispatcher value) => obj.TryGetValue(AgControllerColliderHitDispatcher, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddAgControllerColliderHitDispatcher(this IEntity obj, AgControllerColliderHitDispatcher value) => obj.AddValue(AgControllerColliderHitDispatcher, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasAgControllerColliderHitDispatcher(this IEntity obj) => obj.HasValue(AgControllerColliderHitDispatcher);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelAgControllerColliderHitDispatcher(this IEntity obj) => obj.DelValue(AgControllerColliderHitDispatcher);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetAgControllerColliderHitDispatcher(this IEntity obj, AgControllerColliderHitDispatcher value) => obj.SetValue(AgControllerColliderHitDispatcher, value);
    }
}
