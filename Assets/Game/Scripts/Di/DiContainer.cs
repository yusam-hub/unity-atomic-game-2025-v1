using System;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

namespace Game
{
    public sealed class DiContainer : MonoBehaviour, IDiContainer
    {
        public static DiContainer Instance { get; private set; }
        
        private readonly Dictionary<Type, object> _services = new();

        [SerializeField]
        private Installer[] installers;

        public void AddService<TContract>(object service)
        {
            _services.Add(typeof(TContract), service);
        }
    
        public object GetService(Type type)
        {
            return _services[type];
        }
        
        public TContract GetService<TContract>()
        {
            return (TContract) _services[typeof(TContract)];
        }

        public T InstantiatePrefab<T>(T prefab, Vector3 position, Quaternion rotation, Transform parent) where T : Component
        {
            T component = Instantiate(prefab, position, rotation, parent);
            this.Inject(component);
            return component;
        }

        private void Awake()
        {
            Instance = this;
            this.Install();
            this.Resolve();
        }

        private void Resolve()
        {
            MonoBehaviour[] monoBehaviours = FindObjectsOfType<MonoBehaviour>();
            foreach (MonoBehaviour behaviour in monoBehaviours)
            {
                this.Inject(behaviour);
            }
        }

        private void Install()
        {
            foreach (Installer installer in this.installers)
            {
                installer.Install(this);
            }
        }

        private void Inject(object target)
        {
            Type type = target.GetType();
            MethodInfo[] methods = type.GetMethods(
                BindingFlags.Instance |
                BindingFlags.Public |
                BindingFlags.FlattenHierarchy
            );

            foreach (MethodInfo method in methods)
            {
                if (method.IsDefined(typeof(InjectAttribute)))
                {
                    this.InjectToMethod(method, target);
                }
            }
        }

        private void InjectToMethod(MethodInfo method, object target)
        {
            ParameterInfo[] parameters = method.GetParameters();
            int length = parameters.Length;
            object[] args = new object[length];

            for (int i = 0; i < length; i++)
            {
                ParameterInfo parameter = parameters[i];
                Type parameterType = parameter.ParameterType;
                object service = _services[parameterType];
                args[i] = service;
            }

            method.Invoke(target, args);
        }
    }
}