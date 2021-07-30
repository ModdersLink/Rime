using System;
using System.Linq;

namespace RimeLib.Extensions
{
    public static class TypeExtensions
    {
        public static bool IsGenericAssignableFrom(this Type p_GenericType, Type p_GivenType)
        {
            var s_InterfaceTypes = p_GivenType.GetInterfaces();

            if (s_InterfaceTypes.Any(p_Type => p_Type.IsGenericType && p_Type.GetGenericTypeDefinition() == p_GenericType))
                return true;

            if (p_GivenType.IsGenericType && p_GivenType.GetGenericTypeDefinition() == p_GenericType)
                return true;

            var s_BaseType = p_GivenType.BaseType;

            return s_BaseType != null && IsGenericAssignableFrom(s_BaseType, p_GenericType);
        }
    }
}
