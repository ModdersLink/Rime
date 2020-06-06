using RimeLib.Frostbite.Core;
using RimeLib.Utils;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RimeLib.Serialization.Containers
{
    /// <summary>
    /// The container registry holds all of the specific types for each Frostbite type.
    /// These types are used in the binding process in order to bind fb specific types to C#
    /// </summary>
    public static class ContainerRegistry
    {
        private static readonly Dictionary<uint, Type> m_RegisteredTypes;

        /// <summary>
        /// Default constructor for the container registry
        /// </summary>
        static ContainerRegistry()
        {
            m_RegisteredTypes = new Dictionary<uint, Type>();

            // Register our built-ins.
            RegisterType(typeof(Vec2));
            RegisterType(typeof(Vec3));
            RegisterType(typeof(Vec4));
            RegisterType(typeof(LinearTransform));
            RegisterType(typeof(DataContainer));
            RegisterType(typeof(AxisAlignedBox));
        }

        /// <summary>
        /// Gets a container by the name hash of the type
        /// </summary>
        /// <param name="p_TypeNameHash">Type name hash</param>
        /// <returns>Type object</returns>
        public static Type GetContainerType(uint p_TypeNameHash)
        {
            Type s_Type;

            if (!m_RegisteredTypes.TryGetValue(p_TypeNameHash, out s_Type))
                return Type.EmptyTypes.FirstOrDefault();

            return s_Type;
        }

        /// <summary>
        /// Gets the container type by string
        /// </summary>
        /// <param name="p_TypeName">Type name string (ex. "Vec3")</param>
        /// <returns>Type object</returns>
        public static Type GetContainerType(string p_TypeName)
        {
            Type s_Type;

            if (!m_RegisteredTypes.TryGetValue(FbUtils.HashQuick(p_TypeName), out s_Type))
                return Type.EmptyTypes.FirstOrDefault();

            return s_Type;
        }

        /// <summary>
        /// Registers a type to be used for binding
        /// </summary>
        /// <param name="p_Type">Type object</param>
        public static void RegisterType(Type p_Type)
        {
            var s_TypeNameHash = FbUtils.HashQuick(p_Type.Name);

            if (m_RegisteredTypes.ContainsKey(s_TypeNameHash))
                m_RegisteredTypes[s_TypeNameHash] = p_Type;
            else
                m_RegisteredTypes.Add(s_TypeNameHash, p_Type);
        }

        /// <summary>
        /// Clears out all registry entries and adds the default Frostbite objects
        /// </summary>
        public static void ClearRegistry()
        {
            m_RegisteredTypes.Clear();

            // Register our built-ins.
            RegisterType(typeof(Vec2));
            RegisterType(typeof(Vec3));
            RegisterType(typeof(Vec4));
            RegisterType(typeof(LinearTransform));
            RegisterType(typeof(DataContainer));
            RegisterType(typeof(AxisAlignedBox));
        }
    }
}
