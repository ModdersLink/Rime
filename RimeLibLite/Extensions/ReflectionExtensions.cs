using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace RimeLib.Extensions
{
    public static class ReflectionExtensions
    {
        public static bool IsNullable(this PropertyInfo p_Info)
        {
            // First of all, check if this is a nullable type.
            var s_UnderlyingType = Nullable.GetUnderlyingType(p_Info.PropertyType);

            if (s_UnderlyingType != null)
                return true;

            // If it's not, then check for the generated Nullable attribute.
            // HACKHACK: This might change in future compiler updates.
            var s_Attribute = p_Info.CustomAttributes.FirstOrDefault(p_Attribute =>
                p_Attribute.AttributeType.FullName == "System.Runtime.CompilerServices.NullableAttribute"
            );

            if (s_Attribute == null)
                return false;

            if (s_Attribute.ConstructorArguments is null)
                return false;

            // We found the attribute, check its parameters.
            if (s_Attribute.ConstructorArguments.Count != 1)
                throw new NotImplementedException("Nullability checks are currently not supported on complex nullable types.");

            // Simple type!
            if (s_Attribute.ConstructorArguments == null)
                throw new NullReferenceException(nameof(s_Attribute.ConstructorArguments));

            byte? s_Value = s_Attribute.ConstructorArguments[0].Value as byte?;

            if (s_Attribute.ConstructorArguments[0].Value is byte?)
                return (s_Attribute.ConstructorArguments[0].Value as byte? ?? 0xFF) == 2; // C# 9, assumption here that this is never true

            // Primitive array type.
            var s_Args = s_Attribute.ConstructorArguments[0].Value as IList<CustomAttributeTypedArgument>;
            return s_Args?.ElementAt(0).Value as byte? == 2;
        }
    }
}
