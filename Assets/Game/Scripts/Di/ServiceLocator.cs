using System;
using System.Collections.Generic;
using UnityEngine;

namespace Game
{
    public static class ServiceLocator
    {
        public static string SL_CAMERA = "camera";
        public static string SL_CHARACTER = "character";
        public static string SL_DIRECTION_VECTOR3 = "direction_vector3";
        
        private static readonly List<object> _listServices = new();
        private static readonly Dictionary<Type,object> _typeServices = new();
        private static readonly Dictionary<string,object> _idServices = new();
        public static void ListAddService(object service)
        {
            _listServices.Add(service);
        }
        
        public static T ListGetService<T>()
        {
            foreach (object service in _listServices)
            {
                if (service is T tService)
                {
                    return tService;
                }
            }

            throw new Exception($"Service of type {typeof(T).Name} is not found!");
        }
        
        public static void TypeAddService<T>(object service)
        {
            _typeServices.Add(typeof(T), service);
        }
        
        public static T TypeGetService<T>()
        {
            return (T)_typeServices[typeof(T)];
        }
        
        public static void IdAddService(string id, object service)
        {
            _idServices.Add(id, service);
        }
        
        public static T IdGetService<T>(string id)
        {
            return (T)_idServices[id];
        }
    }
}