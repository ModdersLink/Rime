using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Commands.Common;

namespace RimeLib.Cmd
{
    public abstract class ExecutionContext
    {
        public abstract string GetShortDescription();
        public abstract string GetLongDescription();

        public ExecutionContext? Parent { get; protected set; }
        
        protected readonly Dictionary<string, Type> m_RegisteredCommands = new Dictionary<string, Type>
        {
            { "help", typeof(HelpCommand) },
            { "exit", typeof(ExitCommand) },
        };

        public List<string> GetSuggestions(string p_Input)
        {
            var s_Suggestions = new List<string>();

            // First handle command auto-completion.
            if (!p_Input.Contains(" "))
            {
                var s_Input = p_Input.ToLowerInvariant();

                foreach (var s_Command in m_RegisteredCommands)
                {
                    if (s_Command.Key.StartsWith(s_Input))
                        s_Suggestions.Add(s_Command.Key.Substring(s_Input.Length));
                }

                return s_Suggestions;
            }

            // First check that the command the user has entered exists.
            var s_InputArguments = CommandUtils.ParseArguments(p_Input).ToArray();
            var s_CommandName = s_InputArguments[0].ToLowerInvariant();

            if (!m_RegisteredCommands.TryGetValue(s_CommandName, out var s_CommandType))
                return s_Suggestions;

            // Special handling for the "help" command.
            if (s_CommandName == "help" && s_InputArguments.Length == 2)
            {
                var s_Input = s_InputArguments[1].ToLowerInvariant();

                foreach (var s_Command in m_RegisteredCommands)
                {
                    if (s_Command.Key.StartsWith(s_Input))
                        s_Suggestions.Add(s_Command.Key.Substring(s_Input.Length));
                }

                return s_Suggestions;
            }

            // Now we're entering tricky territory. We need to handle argument-specific auto-completion.
            // Currently, this is only supported for paths and enums.

            // Get the command arguments.
            var s_CommandArguments = CommandUtils.GetCommandArguments(s_CommandType).ToArray();

            // Make sure we're within bounds.
            if (s_InputArguments.Length - 1 > s_CommandArguments.Length)
                return s_Suggestions;

            // Get the argument that we're trying to get auto-completion data for.
            var s_Argument = s_CommandArguments[s_InputArguments.Length - 2];
            var s_ArgumentValue = s_InputArguments[^1];

            // Check if it's something we can autocomplete for.
            var s_PropertyType = s_Argument.Item1.PropertyType;

            try
            {
                if (s_PropertyType.IsEnum)
                    return CommandUtils.AutoCompleteEnum(s_PropertyType, s_ArgumentValue);

                if (s_PropertyType.IsClass && s_PropertyType == typeof(DirectoryInfo))
                    return CommandUtils.AutoCompleteDirectory(s_ArgumentValue);

                if (s_PropertyType.IsClass && s_PropertyType == typeof(FileInfo))
                    return CommandUtils.AutoCompleteFile(s_ArgumentValue);
            }
            catch
            {
                // Ignored.
            }

            return s_Suggestions;
        }

        public bool ProcessCommand(string p_Input, TextWriter p_Writer, out ExecutionContext? p_Context)
        {
            p_Context = this;

            // Empty command. Do nothing.
            if (string.IsNullOrWhiteSpace(p_Input))
                return true;

            var s_Arguments = CommandUtils.ParseArguments(p_Input).ToArray();

            var s_CommandName = s_Arguments[0].ToLowerInvariant();
            
            if (!m_RegisteredCommands.TryGetValue(s_CommandName, out var s_CommandType))
            {
                p_Writer.WriteLine("Command not found. Use the 'help' command to see all available commands.");
                return false;
            }

            // Create an instance of this command.
            var s_Command = (Command) Activator.CreateInstance(s_CommandType);

            // Populate its arguments.
            try
            {
                CommandUtils.PopulateCommandArguments(s_Command, s_Arguments);
            }
            catch (Exception s_Exception)
            {
                p_Writer.WriteLine("Invalid input: " + s_Exception.Message);
                p_Writer.WriteLine();
                p_Writer.WriteLine(GetCommandHelp(s_CommandType));

                return false;
            }

            // Execute the command!
            return s_Command.Execute(ref p_Context, p_Writer);
        }

        public string GetHelp()
        {
            var s_HelpText = GetLongDescription();
            s_HelpText += "\n\nAvailable commands:\n";

            foreach (var s_Command in m_RegisteredCommands)
            {
                var s_Name = s_Command.Key;
                var s_Type = s_Command.Value;

                s_HelpText += $"\n{s_Name}";

                var s_CommandArguments = CommandUtils.GetCommandArguments(s_Type);

                foreach (var s_Argument in s_CommandArguments)
                {
                    if (s_Argument.Item2.Optional)
                        s_HelpText += $" [{CommandUtils.PascalCaseToSnakeCase(s_Argument.Item1.Name)}]";
                    else
                        s_HelpText += $" <{CommandUtils.PascalCaseToSnakeCase(s_Argument.Item1.Name)}>";
                }

                try
                {
                    var s_DescriptionAttr = s_Type.GetCustomAttribute<CommandDescriptionAttribute>();
                    s_HelpText += " - " + s_DescriptionAttr.Description;
                }
                catch
                {
                    // Ignored.
                }
            }

            return s_HelpText;
        }

        public bool GetCommandHelp(string p_Command, out string p_HelpText)
        {
            p_HelpText = "";

            var s_Command = p_Command.ToLowerInvariant();

            if (!m_RegisteredCommands.TryGetValue(s_Command, out var s_CommandType))
                return false;

            p_HelpText = GetCommandHelp(s_CommandType);
            return true;
        }

        protected string GetCommandHelp(Type p_CommandType)
        {
            var s_HelpText = "Usage: " + CommandUtils.GetCommandName(p_CommandType);

            var s_ArgumentText = "";

            foreach (var s_Argument in CommandUtils.GetCommandArguments(p_CommandType))
            {
                var s_ArgumentName = CommandUtils.PascalCaseToSnakeCase(s_Argument.Item1.Name);

                if (s_Argument.Item2.Optional)
                    s_HelpText += $" [{s_ArgumentName}]";
                else
                    s_HelpText += $" <{s_ArgumentName}>";

                s_ArgumentText += $"\n- {s_ArgumentName}";

                if (s_Argument.Item2.Optional)
                    s_ArgumentText += " (optional)";

                if (!string.IsNullOrWhiteSpace(s_Argument.Item2.Description))
                    s_ArgumentText += ": " + s_Argument.Item2.Description;

                if (s_Argument.Item1.PropertyType.IsEnum)
                {
                    if (string.IsNullOrWhiteSpace(s_Argument.Item2.Description))
                        s_ArgumentText += ":";

                    s_ArgumentText += " Accepted values: ";
                    s_ArgumentText += string.Join(", ", Enum.GetNames(s_Argument.Item1.PropertyType));
                }
            }

            try
            {
                var s_DescriptionAttr = p_CommandType.GetCustomAttribute<CommandDescriptionAttribute>();

                s_HelpText += "\n\n";
                s_HelpText += s_DescriptionAttr.Description;
            }
            catch
            {
                // Ignored.
            }

            if (string.IsNullOrWhiteSpace(s_ArgumentText))
                return s_HelpText;

            return s_HelpText + "\n\nArguments:\n" + s_ArgumentText;
        }

        protected void RegisterCommand<T>() where T : Command
        {
            var s_Type = typeof(T);

            if (s_Type.GetConstructor(Type.EmptyTypes) == null)
                throw new Exception("Tried registering a command without a default constructor.");

            // Check if we have any optional arguments defined before required ones
            // and that all the arguments have supported types.
            var s_HasOptional = false;

            foreach (var s_Argument in CommandUtils.GetCommandArguments(s_Type))
            {
                var (s_Property, s_Attribute) = s_Argument;

                if (s_HasOptional && !s_Attribute.Optional)
                    throw new Exception($"Found a required argument property '{s_Property.Name}' defined after an optional argument. Optional arguments must be defined last.");

                if (s_Attribute.Optional)
                    s_HasOptional = true;

                if (!CommandUtils.IsPropertySupported(s_Property))
                    throw new Exception($"Found command argument property '{s_Property.Name}' of unsupported type '{s_Property.PropertyType.Name}'.");
            }

            // Register the command.
            m_RegisteredCommands[CommandUtils.GetCommandName<T>()] = s_Type;
        }
    }
}
