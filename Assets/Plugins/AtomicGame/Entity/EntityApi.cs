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
		public const int Interactable = 1077199658;
		public const int Damageable = 563499515;
		public const int Scoreable = -1523738390;
		public const int Player = -1615495341;
		public const int Enemy = 979269037;


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
		public const int MoveCondition = 1466174948; // IExpression<bool>
		public const int JumpCondition = -2140666110; // IExpression<bool>
		public const int JumpAction = -2046675773; // IAction
		public const int JumpEvent = -1811156839; // IEvent
		public const int Effects = -2018114250; // IReactiveDictionary<string, EffectInstance>
		public const int PlanarRotation = -2030768779; // IReactiveVariable<Quaternion>
		public const int Damage = 375673178; // IValue<int>
		public const int MoveDirection = -721923052; // IReactiveVariable<Vector3>
		public const int Health = -915003867; // IReactiveVariable<int>
		public const int DeathEvent = -1096613677; // IEvent
		public const int RestoreEvent = 745515910; // IEvent
		public const int Lifetime = -997109026; // Cooldown
		public const int DestroyAction = 85938956; // IAction
		public const int DamageAction = 1156185048; // IAction
		public const int WeaponFireAction = -19054336; // IAction
		public const int WeaponFireEvent = 1287098833; // IEvent
		public const int WeaponFirePoint = -1061394350; // Transform
		public const int BulletPrefab = -918778767; // SceneEntity
		public const int InteractAction = -1026843572; // IAction<IEntity>
		public const int TargetInteractable = -990542098; // IReactiveVariable<IEntity>
		public const int TargetAttackable = 145417146; // IReactiveVariable<IEntity>
		public const int KeyPressAction = -418488485; // IAction<KeyCode>
		public const int KeyDownAction = -124030595; // IAction<KeyCode>
		public const int KeyUpAction = -181628813; // IAction<KeyCode>
		public const int Animator = -1714818978; // Animator
		public const int AnimatorCurrentState = 1457520650; // IValue<int>
		public const int ChangeCrossFadeEvent = 364688039; // IEvent<int>
		public const int CollisionDispatcher = -2127104721; // CollisionDispatcher
		public const int TriggerDispatcher = -1084234046; // TriggerDispatcher
		public const int TriggerEnterAction = -1869765499; // IAction
		public const int ControllerColliderHitDispatcher = -2253885; // ControllerColliderHitDispatcher


		///Tag Extensions

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasInteractableTag(this IEntity obj) => obj.HasTag(Interactable);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddInteractableTag(this IEntity obj) => obj.AddTag(Interactable);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelInteractableTag(this IEntity obj) => obj.DelTag(Interactable);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasDamageableTag(this IEntity obj) => obj.HasTag(Damageable);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddDamageableTag(this IEntity obj) => obj.AddTag(Damageable);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelDamageableTag(this IEntity obj) => obj.DelTag(Damageable);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasScoreableTag(this IEntity obj) => obj.HasTag(Scoreable);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddScoreableTag(this IEntity obj) => obj.AddTag(Scoreable);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelScoreableTag(this IEntity obj) => obj.DelTag(Scoreable);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasPlayerTag(this IEntity obj) => obj.HasTag(Player);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddPlayerTag(this IEntity obj) => obj.AddTag(Player);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelPlayerTag(this IEntity obj) => obj.DelTag(Player);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasEnemyTag(this IEntity obj) => obj.HasTag(Enemy);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddEnemyTag(this IEntity obj) => obj.AddTag(Enemy);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelEnemyTag(this IEntity obj) => obj.DelTag(Enemy);


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
		public static IExpression<bool> GetMoveCondition(this IEntity obj) => obj.GetValue<IExpression<bool>>(MoveCondition);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetMoveCondition(this IEntity obj, out IExpression<bool> value) => obj.TryGetValue(MoveCondition, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddMoveCondition(this IEntity obj, IExpression<bool> value) => obj.AddValue(MoveCondition, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasMoveCondition(this IEntity obj) => obj.HasValue(MoveCondition);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelMoveCondition(this IEntity obj) => obj.DelValue(MoveCondition);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetMoveCondition(this IEntity obj, IExpression<bool> value) => obj.SetValue(MoveCondition, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IExpression<bool> GetJumpCondition(this IEntity obj) => obj.GetValue<IExpression<bool>>(JumpCondition);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetJumpCondition(this IEntity obj, out IExpression<bool> value) => obj.TryGetValue(JumpCondition, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddJumpCondition(this IEntity obj, IExpression<bool> value) => obj.AddValue(JumpCondition, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasJumpCondition(this IEntity obj) => obj.HasValue(JumpCondition);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelJumpCondition(this IEntity obj) => obj.DelValue(JumpCondition);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetJumpCondition(this IEntity obj, IExpression<bool> value) => obj.SetValue(JumpCondition, value);

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
		public static IValue<int> GetDamage(this IEntity obj) => obj.GetValue<IValue<int>>(Damage);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetDamage(this IEntity obj, out IValue<int> value) => obj.TryGetValue(Damage, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddDamage(this IEntity obj, IValue<int> value) => obj.AddValue(Damage, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasDamage(this IEntity obj) => obj.HasValue(Damage);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelDamage(this IEntity obj) => obj.DelValue(Damage);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetDamage(this IEntity obj, IValue<int> value) => obj.SetValue(Damage, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IReactiveVariable<Vector3> GetMoveDirection(this IEntity obj) => obj.GetValue<IReactiveVariable<Vector3>>(MoveDirection);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetMoveDirection(this IEntity obj, out IReactiveVariable<Vector3> value) => obj.TryGetValue(MoveDirection, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddMoveDirection(this IEntity obj, IReactiveVariable<Vector3> value) => obj.AddValue(MoveDirection, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasMoveDirection(this IEntity obj) => obj.HasValue(MoveDirection);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelMoveDirection(this IEntity obj) => obj.DelValue(MoveDirection);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetMoveDirection(this IEntity obj, IReactiveVariable<Vector3> value) => obj.SetValue(MoveDirection, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IReactiveVariable<int> GetHealth(this IEntity obj) => obj.GetValue<IReactiveVariable<int>>(Health);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetHealth(this IEntity obj, out IReactiveVariable<int> value) => obj.TryGetValue(Health, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddHealth(this IEntity obj, IReactiveVariable<int> value) => obj.AddValue(Health, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasHealth(this IEntity obj) => obj.HasValue(Health);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelHealth(this IEntity obj) => obj.DelValue(Health);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetHealth(this IEntity obj, IReactiveVariable<int> value) => obj.SetValue(Health, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IEvent GetDeathEvent(this IEntity obj) => obj.GetValue<IEvent>(DeathEvent);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetDeathEvent(this IEntity obj, out IEvent value) => obj.TryGetValue(DeathEvent, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddDeathEvent(this IEntity obj, IEvent value) => obj.AddValue(DeathEvent, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasDeathEvent(this IEntity obj) => obj.HasValue(DeathEvent);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelDeathEvent(this IEntity obj) => obj.DelValue(DeathEvent);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetDeathEvent(this IEntity obj, IEvent value) => obj.SetValue(DeathEvent, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IEvent GetRestoreEvent(this IEntity obj) => obj.GetValue<IEvent>(RestoreEvent);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetRestoreEvent(this IEntity obj, out IEvent value) => obj.TryGetValue(RestoreEvent, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddRestoreEvent(this IEntity obj, IEvent value) => obj.AddValue(RestoreEvent, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasRestoreEvent(this IEntity obj) => obj.HasValue(RestoreEvent);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelRestoreEvent(this IEntity obj) => obj.DelValue(RestoreEvent);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetRestoreEvent(this IEntity obj, IEvent value) => obj.SetValue(RestoreEvent, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Cooldown GetLifetime(this IEntity obj) => obj.GetValue<Cooldown>(Lifetime);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetLifetime(this IEntity obj, out Cooldown value) => obj.TryGetValue(Lifetime, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddLifetime(this IEntity obj, Cooldown value) => obj.AddValue(Lifetime, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasLifetime(this IEntity obj) => obj.HasValue(Lifetime);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelLifetime(this IEntity obj) => obj.DelValue(Lifetime);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetLifetime(this IEntity obj, Cooldown value) => obj.SetValue(Lifetime, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IAction GetDestroyAction(this IEntity obj) => obj.GetValue<IAction>(DestroyAction);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetDestroyAction(this IEntity obj, out IAction value) => obj.TryGetValue(DestroyAction, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddDestroyAction(this IEntity obj, IAction value) => obj.AddValue(DestroyAction, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasDestroyAction(this IEntity obj) => obj.HasValue(DestroyAction);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelDestroyAction(this IEntity obj) => obj.DelValue(DestroyAction);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetDestroyAction(this IEntity obj, IAction value) => obj.SetValue(DestroyAction, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IAction GetDamageAction(this IEntity obj) => obj.GetValue<IAction>(DamageAction);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetDamageAction(this IEntity obj, out IAction value) => obj.TryGetValue(DamageAction, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddDamageAction(this IEntity obj, IAction value) => obj.AddValue(DamageAction, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasDamageAction(this IEntity obj) => obj.HasValue(DamageAction);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelDamageAction(this IEntity obj) => obj.DelValue(DamageAction);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetDamageAction(this IEntity obj, IAction value) => obj.SetValue(DamageAction, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IAction GetWeaponFireAction(this IEntity obj) => obj.GetValue<IAction>(WeaponFireAction);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetWeaponFireAction(this IEntity obj, out IAction value) => obj.TryGetValue(WeaponFireAction, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddWeaponFireAction(this IEntity obj, IAction value) => obj.AddValue(WeaponFireAction, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasWeaponFireAction(this IEntity obj) => obj.HasValue(WeaponFireAction);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelWeaponFireAction(this IEntity obj) => obj.DelValue(WeaponFireAction);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetWeaponFireAction(this IEntity obj, IAction value) => obj.SetValue(WeaponFireAction, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IEvent GetWeaponFireEvent(this IEntity obj) => obj.GetValue<IEvent>(WeaponFireEvent);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetWeaponFireEvent(this IEntity obj, out IEvent value) => obj.TryGetValue(WeaponFireEvent, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddWeaponFireEvent(this IEntity obj, IEvent value) => obj.AddValue(WeaponFireEvent, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasWeaponFireEvent(this IEntity obj) => obj.HasValue(WeaponFireEvent);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelWeaponFireEvent(this IEntity obj) => obj.DelValue(WeaponFireEvent);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetWeaponFireEvent(this IEntity obj, IEvent value) => obj.SetValue(WeaponFireEvent, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Transform GetWeaponFirePoint(this IEntity obj) => obj.GetValue<Transform>(WeaponFirePoint);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetWeaponFirePoint(this IEntity obj, out Transform value) => obj.TryGetValue(WeaponFirePoint, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddWeaponFirePoint(this IEntity obj, Transform value) => obj.AddValue(WeaponFirePoint, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasWeaponFirePoint(this IEntity obj) => obj.HasValue(WeaponFirePoint);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelWeaponFirePoint(this IEntity obj) => obj.DelValue(WeaponFirePoint);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetWeaponFirePoint(this IEntity obj, Transform value) => obj.SetValue(WeaponFirePoint, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static SceneEntity GetBulletPrefab(this IEntity obj) => obj.GetValue<SceneEntity>(BulletPrefab);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetBulletPrefab(this IEntity obj, out SceneEntity value) => obj.TryGetValue(BulletPrefab, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddBulletPrefab(this IEntity obj, SceneEntity value) => obj.AddValue(BulletPrefab, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasBulletPrefab(this IEntity obj) => obj.HasValue(BulletPrefab);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelBulletPrefab(this IEntity obj) => obj.DelValue(BulletPrefab);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetBulletPrefab(this IEntity obj, SceneEntity value) => obj.SetValue(BulletPrefab, value);

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
		public static IReactiveVariable<IEntity> GetTargetInteractable(this IEntity obj) => obj.GetValue<IReactiveVariable<IEntity>>(TargetInteractable);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetTargetInteractable(this IEntity obj, out IReactiveVariable<IEntity> value) => obj.TryGetValue(TargetInteractable, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddTargetInteractable(this IEntity obj, IReactiveVariable<IEntity> value) => obj.AddValue(TargetInteractable, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasTargetInteractable(this IEntity obj) => obj.HasValue(TargetInteractable);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelTargetInteractable(this IEntity obj) => obj.DelValue(TargetInteractable);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetTargetInteractable(this IEntity obj, IReactiveVariable<IEntity> value) => obj.SetValue(TargetInteractable, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IReactiveVariable<IEntity> GetTargetAttackable(this IEntity obj) => obj.GetValue<IReactiveVariable<IEntity>>(TargetAttackable);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetTargetAttackable(this IEntity obj, out IReactiveVariable<IEntity> value) => obj.TryGetValue(TargetAttackable, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddTargetAttackable(this IEntity obj, IReactiveVariable<IEntity> value) => obj.AddValue(TargetAttackable, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasTargetAttackable(this IEntity obj) => obj.HasValue(TargetAttackable);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelTargetAttackable(this IEntity obj) => obj.DelValue(TargetAttackable);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetTargetAttackable(this IEntity obj, IReactiveVariable<IEntity> value) => obj.SetValue(TargetAttackable, value);

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
		public static IAction GetTriggerEnterAction(this IEntity obj) => obj.GetValue<IAction>(TriggerEnterAction);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetTriggerEnterAction(this IEntity obj, out IAction value) => obj.TryGetValue(TriggerEnterAction, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddTriggerEnterAction(this IEntity obj, IAction value) => obj.AddValue(TriggerEnterAction, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasTriggerEnterAction(this IEntity obj) => obj.HasValue(TriggerEnterAction);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelTriggerEnterAction(this IEntity obj) => obj.DelValue(TriggerEnterAction);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetTriggerEnterAction(this IEntity obj, IAction value) => obj.SetValue(TriggerEnterAction, value);

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
