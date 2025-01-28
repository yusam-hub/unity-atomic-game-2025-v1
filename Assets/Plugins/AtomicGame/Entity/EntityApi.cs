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
	public static class EntityApi
	{
		///Tags
		public const int Interactible = -2055148603;


		///Values
		public const int Transform = -180157682; // Transform
		public const int Transforms = -62676721; // Transform[]
		public const int CharacterController = -270069640; // CharacterController
		public const int MoveSpeed = 526065662; // IReactiveVariable<float>
		public const int MoveAction = 1225226561; // IAction<Vector3, float>
		public const int IsMoving = 120489994; // IReactiveVariable<bool>
		public const int IsGrounded = 507951781; // IReactiveVariable<bool>
		public const int RotateSpeed = -1838353354; // IValue<float>
		public const int RotateAction = -600505304; // IAction<Vector3, float>
		public const int JumpAction = -2046675773; // IAction
		public const int JumpEvent = -1811156839; // IEvent
		public const int Effects = -2018114250; // IReactiveDictionary<string, EffectInstance>
		public const int PlanarRotation = -2030768779; // IReactiveVariable<Quaternion>
		public const int InteractAction = -1026843572; // IAction<IEntity>
		public const int TargetInteractible = 21081601; // IReactiveVariable<IEntity>
		public const int KeyPressAction = -418488485; // IAction<KeyCode>
		public const int KeyDownAction = -124030595; // IAction<KeyCode>
		public const int KeyUpAction = -181628813; // IAction<KeyCode>
		public const int Animator = -1714818978; // Animator
		public const int AnimatorCurrentState = 1457520650; // IValue<int>
		public const int ChangeCrossFadeEvent = 364688039; // IEvent<int>
		public const int CollisionDispatcher = -2127104721; // CollisionDispatcher
		public const int TriggerDispatcher = -1084234046; // TriggerDispatcher
		public const int ControllerColliderHitDispatcher = -2253885; // ControllerColliderHitDispatcher


		///Tag Extensions

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasInteractibleTag(this IEntity obj) => obj.HasTag(Interactible);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddInteractibleTag(this IEntity obj) => obj.AddTag(Interactible);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelInteractibleTag(this IEntity obj) => obj.DelTag(Interactible);


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
		public static IReactiveVariable<float> GetMoveSpeed(this IEntity obj) => obj.GetValue<IReactiveVariable<float>>(MoveSpeed);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetMoveSpeed(this IEntity obj, out IReactiveVariable<float> value) => obj.TryGetValue(MoveSpeed, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddMoveSpeed(this IEntity obj, IReactiveVariable<float> value) => obj.AddValue(MoveSpeed, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasMoveSpeed(this IEntity obj) => obj.HasValue(MoveSpeed);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelMoveSpeed(this IEntity obj) => obj.DelValue(MoveSpeed);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetMoveSpeed(this IEntity obj, IReactiveVariable<float> value) => obj.SetValue(MoveSpeed, value);

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
		public static IReactiveVariable<bool> GetIsMoving(this IEntity obj) => obj.GetValue<IReactiveVariable<bool>>(IsMoving);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetIsMoving(this IEntity obj, out IReactiveVariable<bool> value) => obj.TryGetValue(IsMoving, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddIsMoving(this IEntity obj, IReactiveVariable<bool> value) => obj.AddValue(IsMoving, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasIsMoving(this IEntity obj) => obj.HasValue(IsMoving);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelIsMoving(this IEntity obj) => obj.DelValue(IsMoving);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetIsMoving(this IEntity obj, IReactiveVariable<bool> value) => obj.SetValue(IsMoving, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IReactiveVariable<bool> GetIsGrounded(this IEntity obj) => obj.GetValue<IReactiveVariable<bool>>(IsGrounded);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetIsGrounded(this IEntity obj, out IReactiveVariable<bool> value) => obj.TryGetValue(IsGrounded, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddIsGrounded(this IEntity obj, IReactiveVariable<bool> value) => obj.AddValue(IsGrounded, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasIsGrounded(this IEntity obj) => obj.HasValue(IsGrounded);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelIsGrounded(this IEntity obj) => obj.DelValue(IsGrounded);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetIsGrounded(this IEntity obj, IReactiveVariable<bool> value) => obj.SetValue(IsGrounded, value);

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
		public static IEvent GetJumpEvent(this IEntity obj) => obj.GetValue<IEvent>(JumpEvent);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetJumpEvent(this IEntity obj, out IEvent value) => obj.TryGetValue(JumpEvent, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddJumpEvent(this IEntity obj, IEvent value) => obj.AddValue(JumpEvent, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasJumpEvent(this IEntity obj) => obj.HasValue(JumpEvent);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelJumpEvent(this IEntity obj) => obj.DelValue(JumpEvent);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetJumpEvent(this IEntity obj, IEvent value) => obj.SetValue(JumpEvent, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IReactiveDictionary<string, EffectInstance> GetEffects(this IEntity obj) => obj.GetValue<IReactiveDictionary<string, EffectInstance>>(Effects);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetEffects(this IEntity obj, out IReactiveDictionary<string, EffectInstance> value) => obj.TryGetValue(Effects, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddEffects(this IEntity obj, IReactiveDictionary<string, EffectInstance> value) => obj.AddValue(Effects, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasEffects(this IEntity obj) => obj.HasValue(Effects);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelEffects(this IEntity obj) => obj.DelValue(Effects);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetEffects(this IEntity obj, IReactiveDictionary<string, EffectInstance> value) => obj.SetValue(Effects, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IReactiveVariable<Quaternion> GetPlanarRotation(this IEntity obj) => obj.GetValue<IReactiveVariable<Quaternion>>(PlanarRotation);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetPlanarRotation(this IEntity obj, out IReactiveVariable<Quaternion> value) => obj.TryGetValue(PlanarRotation, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddPlanarRotation(this IEntity obj, IReactiveVariable<Quaternion> value) => obj.AddValue(PlanarRotation, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasPlanarRotation(this IEntity obj) => obj.HasValue(PlanarRotation);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelPlanarRotation(this IEntity obj) => obj.DelValue(PlanarRotation);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetPlanarRotation(this IEntity obj, IReactiveVariable<Quaternion> value) => obj.SetValue(PlanarRotation, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IAction<IEntity> GetInteractAction(this IEntity obj) => obj.GetValue<IAction<IEntity>>(InteractAction);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetInteractAction(this IEntity obj, out IAction<IEntity> value) => obj.TryGetValue(InteractAction, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddInteractAction(this IEntity obj, IAction<IEntity> value) => obj.AddValue(InteractAction, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasInteractAction(this IEntity obj) => obj.HasValue(InteractAction);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelInteractAction(this IEntity obj) => obj.DelValue(InteractAction);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetInteractAction(this IEntity obj, IAction<IEntity> value) => obj.SetValue(InteractAction, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IReactiveVariable<IEntity> GetTargetInteractible(this IEntity obj) => obj.GetValue<IReactiveVariable<IEntity>>(TargetInteractible);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetTargetInteractible(this IEntity obj, out IReactiveVariable<IEntity> value) => obj.TryGetValue(TargetInteractible, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddTargetInteractible(this IEntity obj, IReactiveVariable<IEntity> value) => obj.AddValue(TargetInteractible, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasTargetInteractible(this IEntity obj) => obj.HasValue(TargetInteractible);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelTargetInteractible(this IEntity obj) => obj.DelValue(TargetInteractible);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetTargetInteractible(this IEntity obj, IReactiveVariable<IEntity> value) => obj.SetValue(TargetInteractible, value);

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
		public static CollisionDispatcher GetCollisionDispatcher(this IEntity obj) => obj.GetValue<CollisionDispatcher>(CollisionDispatcher);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetCollisionDispatcher(this IEntity obj, out CollisionDispatcher value) => obj.TryGetValue(CollisionDispatcher, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddCollisionDispatcher(this IEntity obj, CollisionDispatcher value) => obj.AddValue(CollisionDispatcher, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasCollisionDispatcher(this IEntity obj) => obj.HasValue(CollisionDispatcher);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelCollisionDispatcher(this IEntity obj) => obj.DelValue(CollisionDispatcher);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetCollisionDispatcher(this IEntity obj, CollisionDispatcher value) => obj.SetValue(CollisionDispatcher, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static TriggerDispatcher GetTriggerDispatcher(this IEntity obj) => obj.GetValue<TriggerDispatcher>(TriggerDispatcher);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetTriggerDispatcher(this IEntity obj, out TriggerDispatcher value) => obj.TryGetValue(TriggerDispatcher, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddTriggerDispatcher(this IEntity obj, TriggerDispatcher value) => obj.AddValue(TriggerDispatcher, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasTriggerDispatcher(this IEntity obj) => obj.HasValue(TriggerDispatcher);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelTriggerDispatcher(this IEntity obj) => obj.DelValue(TriggerDispatcher);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetTriggerDispatcher(this IEntity obj, TriggerDispatcher value) => obj.SetValue(TriggerDispatcher, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ControllerColliderHitDispatcher GetControllerColliderHitDispatcher(this IEntity obj) => obj.GetValue<ControllerColliderHitDispatcher>(ControllerColliderHitDispatcher);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetControllerColliderHitDispatcher(this IEntity obj, out ControllerColliderHitDispatcher value) => obj.TryGetValue(ControllerColliderHitDispatcher, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddControllerColliderHitDispatcher(this IEntity obj, ControllerColliderHitDispatcher value) => obj.AddValue(ControllerColliderHitDispatcher, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasControllerColliderHitDispatcher(this IEntity obj) => obj.HasValue(ControllerColliderHitDispatcher);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelControllerColliderHitDispatcher(this IEntity obj) => obj.DelValue(ControllerColliderHitDispatcher);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetControllerColliderHitDispatcher(this IEntity obj, ControllerColliderHitDispatcher value) => obj.SetValue(ControllerColliderHitDispatcher, value);
    }
}
