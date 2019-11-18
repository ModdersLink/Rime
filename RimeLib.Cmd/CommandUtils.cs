using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using RimeLib.Cmd.Attributes;

namespace RimeLib.Cmd
{
    public static class CommandUtils
    {
        public static IEnumerable<string> ParseArguments(string p_Input)
        {
            var s_Input = p_Input.Trim();

            if (string.IsNullOrWhiteSpace(s_Input))
                yield break;

            var s_CurrentArg = "";
            var s_InQuotedArg = false;

            foreach (var s_Char in s_Input)
            {
                // We found a space.
                if (s_Char == ' ')
                {
                    if (!s_InQuotedArg)
                    {
                        // If we're not parsing a quoted string then return the currently parsed argument
                        // unless it's empty. This will happen when there's consecutive spaces between arguments.
                        if (string.IsNullOrWhiteSpace(s_CurrentArg))
                            continue;

                        yield return s_CurrentArg;
                        s_CurrentArg = "";
                        
                        continue;
                    }
                    else
                    {
                        // Otherwise just add the space to the current argument.
                        s_CurrentArg += s_Char;
                        continue;
                    }
                }

                // We found a double quote character.
                if (s_Char == '"')
                {
                    // If the last character was the escape character then remove the escape character and
                    // add the double quotes to the parsed argument.
                    if (s_CurrentArg.Length > 0 && s_CurrentArg[s_CurrentArg.Length - 1] == '\\')
                    {
                        s_CurrentArg = s_CurrentArg.Substring(0, s_CurrentArg.Length - 1);
                        s_CurrentArg += s_Char;

                        continue;
                    }

                    // If we are parsing a quoted argument then we're done with it.
                    if (s_InQuotedArg)
                    {
                        // Return it and reset our state.
                        yield return s_CurrentArg;
                        s_CurrentArg = "";
                        s_InQuotedArg = false;

                        continue;
                    }

                    // Otherwise, if this is the first quote we're seeing we may have to return any previous pending argument.
                    if (!string.IsNullOrWhiteSpace(s_CurrentArg))
                        yield return s_CurrentArg;
                    
                    // Then update our state to reflect we're now parsing a quoted argument.
                    s_CurrentArg = "";
                    s_InQuotedArg = true;

                    continue;
                }

                // If we did not encounter any special character simply append it to the parsed argument.
                s_CurrentArg += s_Char;
            }

            // We're done going through the input string. If we have anything pending then return it.
            if (!string.IsNullOrWhiteSpace(s_CurrentArg))
                yield return s_CurrentArg;
        }

        public static string PascalCaseToSnakeCase(string p_String)
        {
            var s_Command = "";

            foreach (var s_Char in p_String)
            {
                if (!char.IsUpper(s_Char))
                {
                    s_Command += s_Char;
                    continue;
                }

                if (s_Command.Length > 0)
                    s_Command += "_";

                s_Command += char.ToLowerInvariant(s_Char);
            }

            return s_Command;
        }

        public static string GetCommandName<T>() where T : Command
        {
            return GetCommandName(typeof(T));
        }

        public static string GetCommandName(Type p_CommandType)
        {
            var s_Name = p_CommandType.Name;

            // Trim "Command" suffix.
            if (s_Name.EndsWith("Command"))
                s_Name = s_Name.Substring(0, s_Name.Length - "Command".Length);

            // If the string is now empty it means that the class name was "Command", so just return that.
            if (string.IsNullOrWhiteSpace(s_Name))
                return "command";

            return PascalCaseToSnakeCase(s_Name);
        }

        public static IEnumerable<Tuple<PropertyInfo, CommandArgumentAttribute>> GetCommandArguments(Type p_Type)
        {
            // Get only properties that have the argument attribute defined
            // and sort them by their order.
            var s_Properties = from s_Property in p_Type.GetProperties()
                where Attribute.IsDefined(s_Property, typeof(CommandArgumentAttribute))
                orderby s_Property.GetCustomAttribute<CommandArgumentAttribute>().Order
                select s_Property;

            foreach (var s_Property in s_Properties)
            {
                var s_Attribute = s_Property.GetCustomAttribute<CommandArgumentAttribute>();
                yield return new Tuple<PropertyInfo, CommandArgumentAttribute>(s_Property, s_Attribute);
            }
        }

        public static void PopulateCommandArguments(Command p_Command, string[] p_Arguments)
        {
            if (p_Arguments.Length == 1)
                return;

            var s_Properties = GetCommandArguments(p_Command.GetType()).ToArray();

            for (var i = 0; i < s_Properties.Length; ++i)
            {
                var (s_Property, s_Attribute) = s_Properties[i];

                // Check if we're out of arguments while expecting to find one.
                if (i + 1 >= p_Arguments.Length)
                {
                    if (s_Attribute.Optional)
                        return;

                    throw new Exception($"Missing value for required argument '{PascalCaseToSnakeCase(s_Property.Name)}'.");
                }

                var s_Argument = p_Arguments[i + 1];

                // Parse this argument.
                var s_Value = ParseArgument(s_Argument, s_Property);
                s_Property.SetValue(p_Command, s_Value);
            }
        }

        public static bool IsPropertySupported(PropertyInfo p_Property)
        {
            if (p_Property.PropertyType.IsArray)
                return false;
            
            // For class types we only support FileInfo, DirectoryInfo, and String.
            if (p_Property.PropertyType.IsClass)
            {
                if (p_Property.PropertyType == typeof(DirectoryInfo))
                    return true;

                if (p_Property.PropertyType == typeof(FileInfo))
                    return true;

                if (p_Property.PropertyType == typeof(string))
                    return true;

                return false;
            }

            // We support enums.
            if (p_Property.PropertyType.IsEnum)
                return true;

            // Other than the above, we only support primitives.
            return p_Property.PropertyType.IsPrimitive;
        }

        private static object ParseArgument(string p_Value, PropertyInfo p_Property)
        {
            if (p_Property.PropertyType.IsArray)
                throw new Exception("Array properties are not supported.");

            // For class types we only support FileInfo, DirectoryInfo, and String.
            if (p_Property.PropertyType.IsClass)
            {
                if (p_Property.PropertyType == typeof(DirectoryInfo))
                    return new DirectoryInfo(p_Value);

                if (p_Property.PropertyType == typeof(FileInfo))
                    return new FileInfo(p_Value);

                if (p_Property.PropertyType == typeof(string))
                    return p_Value;

                throw new Exception($"Tried parsing command argument '{PascalCaseToSnakeCase(p_Property.Name)}' of unsupported type '{p_Property.PropertyType.Name}'.");
            }

            // Handle enums.
            if (p_Property.PropertyType.IsEnum)
                return Enum.Parse(p_Property.PropertyType, p_Value, true);

            // Other than the above, we only support primitives.
            if (!p_Property.PropertyType.IsPrimitive)
                throw new Exception($"Tried parsing command argument '{PascalCaseToSnakeCase(p_Property.Name)}' of unsupported type '{p_Property.PropertyType.Name}'.");

            return Convert.ChangeType(p_Value, p_Property.PropertyType);
        }
    }
}
