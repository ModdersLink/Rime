using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using FBCC.Containers;
using FBCC.Managers;

namespace FBCC.Generators
{
    class BindingDocGenerator : IGenerator
    {
        private static readonly List<string> m_ReservedLuaKeywords = new List<string>()
        {
            "and", "break", "do", "else", "elseif", 
            "end", "false", "for", "function", "goto", "if",
            "in", "local", "nil", "not", "or",
            "repeat", "return", "then", "true", "until",
            "while"
        }; 

        public string Name => "BindingDoc";
        
        public Dictionary<string, string> Generate(FrostbiteContainer p_Container)
        {
            var s_GeneratedFiles = new Dictionary<string, string>();
            
            foreach (var s_Definition in p_Container.Definitions)
            {
                if (s_Definition is ContainerClass)
                    GenerateClassDoc(s_GeneratedFiles, s_Definition as ContainerClass);
                else if (s_Definition is ContainerStruct)
                    GenerateStructDoc(s_GeneratedFiles, s_Definition as ContainerStruct);
                else if (s_Definition is ContainerEnum)
                    GenerateEnumDoc(s_GeneratedFiles, s_Definition as ContainerEnum);
            }
           
            return s_GeneratedFiles;
        }

        private void GenerateClassDoc(Dictionary<string, string> p_Files, ContainerClass p_Class)
        {
            var s_Writer = new StringWriter();

            s_Writer.WriteLine("====== {0} (Frostbite Container) ======", p_Class.Name);

            if (p_Class.InheritedClasses.Count > 0)
            {
                s_Writer.WriteLine("==== Base Classes ====");
                s_Writer.WriteLine(string.Join(", ", p_Class.InheritedClasses.Select(p_Name =>
                {
                    var s_Name = p_Name.Components.Last();

                    if (s_Name == "DataContainer")
                        return "[[vext:ref:vu:cls:shr:datacontainer|DataContainer]]";

                    return "[[" + s_Name + "]]";
                })));
            }

            s_Writer.WriteLine();
            s_Writer.WriteLine("===== Description ======");
            s_Writer.WriteLine("A container type representing a Frostbite instance entry.");
            s_Writer.WriteLine();
            s_Writer.WriteLine("===== Constructors ======");
            s_Writer.WriteLine("^ Constructor ^ Description ^");
            s_Writer.WriteLine("^ {0}() | Create a new instance of this container type. |", p_Class.Name);
            s_Writer.WriteLine("^ {0}({0} other) | Create a reference copy of an instance of the same type. |", p_Class.Name);

            var s_SuperClasses = new HashSet<string>();
            GetSuperClasses(p_Class, s_SuperClasses);
            
            foreach (var s_Name in s_SuperClasses)
            {
                if (s_Name == "DataContainer")
                    s_Writer.WriteLine("^ {0}([[vext:ref:vu:cls:shr:datacontainer|{1}]] other) | Upcast an instance of type [[vext:ref:vu:cls:shr:datacontainer|{1}]] to [[{0}]]. |", p_Class.Name, s_Name);
                else
                    s_Writer.WriteLine("^ {0}([[{1}]] other) | Upcast an instance of type [[{1}]] to [[{0}]]. |", p_Class.Name, s_Name);
            }
            s_Writer.WriteLine();

            // Generate member info.
            WriteMembers(s_Writer, p_Class.Members);

            // Add output file.
            s_Writer.Flush();
            p_Files.Add(p_Class.Name.ToLowerInvariant() + ".txt", s_Writer.ToString());
            s_Writer.Close();
        }

        private void GenerateStructDoc(Dictionary<string, string> p_Files, ContainerStruct p_Struct)
        {
            var s_Writer = new StringWriter();

            s_Writer.WriteLine("====== {0} (Frostbite Structure) ======", p_Struct.Name);
            s_Writer.WriteLine();
            s_Writer.WriteLine("===== Description ======");
            s_Writer.WriteLine("A structure type representing a Frostbite data type.");
            s_Writer.WriteLine();
            s_Writer.WriteLine("===== Constructors ======");
            s_Writer.WriteLine("^ Constructor ^ Description ^");
            s_Writer.WriteLine("^ {0}() | Create a new instance of this structure type. |", p_Struct.Name);
            s_Writer.WriteLine("^ {0}({0} other) | Create a reference copy of a structure of the same type. |", p_Struct.Name);

            s_Writer.WriteLine();

            // Generate member info.
            WriteMembers(s_Writer, p_Struct.Members);

            // Add output file.
            s_Writer.Flush();
            p_Files.Add(p_Struct.Name.ToLowerInvariant() + ".txt", s_Writer.ToString());
            s_Writer.Close();
        }

        private void GenerateEnumDoc(Dictionary<string, string> p_Files, ContainerEnum p_Enum)
        {
            var s_Writer = new StringWriter();

            s_Writer.WriteLine("====== {0} (Frostbite Enum) ======", p_Enum.Name);
            s_Writer.WriteLine();
            s_Writer.WriteLine("===== Description ======");
            s_Writer.WriteLine("A Frostbite enumeration.");
            s_Writer.WriteLine();
            s_Writer.WriteLine("===== Values ======");
            s_Writer.WriteLine("^ Name ^ Value ^ Description ^");

            foreach (var s_Value in p_Enum.Values)
                s_Writer.WriteLine("^ {0} | {1} |  |", s_Value.Name, s_Value.Value);

            s_Writer.WriteLine();

            // Add output file.
            s_Writer.Flush();
            p_Files.Add(p_Enum.Name.ToLowerInvariant() + ".txt", s_Writer.ToString());
            s_Writer.Close();
        }

        private void WriteMembers(StringWriter p_Writer, IEnumerable<ContainerMember> p_Members)
        {
            var s_Members = p_Members.ToList();

            if (s_Members.Count == 0)
                return;

            p_Writer.WriteLine("===== Properties =====");
            p_Writer.WriteLine("^ Name ^ Type ^ Description ^");

            foreach (var s_Member in s_Members)
            {
                var s_Type = GetMemberType(s_Member);

                if (string.IsNullOrWhiteSpace(s_Type))
                    continue;

                var s_MemberName = "";

                var s_FoundLower = false;

                for (var i = 0; i < s_Member.Name.Length; ++i)
                {
                    if (s_FoundLower)
                    {
                        s_MemberName += s_Member.Name[i];
                        continue;
                    }

                    if (i < s_Member.Name.Length - 1 && (char.IsLower(s_Member.Name[i + 1]) || char.IsDigit(s_Member.Name[i + 1])))
                    {
                        s_FoundLower = true;

                        if (i > 0)
                        {
                            s_MemberName += s_Member.Name[i];
                            continue;
                        }
                    }

                    s_MemberName += s_Member.Name.Substring(i, 1).ToLowerInvariant();
                }

                if (m_ReservedLuaKeywords.Contains(s_MemberName.ToLowerInvariant()))
                    s_MemberName += "Value";

                p_Writer.WriteLine("^ {0} | {1}{2} |  |", s_MemberName, s_Type, s_Member.Array ? "[]" : "");
            }
        }
        public static void GetSuperClasses(ContainerClass p_Class, HashSet<string> p_Classes)
        {
            if (p_Class?.InheritedClasses == null)
                return;

            foreach (var s_Class in p_Class.InheritedClasses)
            {
                var s_ClassName = s_Class.Components[s_Class.Components.Count - 1];

                p_Classes.Add(s_ClassName);

                var s_Container = ContainerManager.GetContainers().FirstOrDefault(p_Container =>
                    p_Container.Definitions.Any(p_Definition =>
                        p_Definition.DefinitionType == ContainerDefinitionType.Class &&
                        ((ContainerClass)p_Definition).Name == s_ClassName));

                var s_Definition = s_Container?.Definitions.FirstOrDefault(p_Definition =>
                    p_Definition.DefinitionType == ContainerDefinitionType.Class &&
                    ((ContainerClass)p_Definition).Name == s_ClassName);

                if (s_Definition == null)
                    continue;

                GetSuperClasses((ContainerClass)s_Definition, p_Classes);
            }
        }

        private string GetMemberType(ContainerMember p_Member)
        {
            switch (p_Member.MemberType)
            {
                case ContainerMemberType.Float:
                case ContainerMemberType.Double:
                case ContainerMemberType.Int64:
                case ContainerMemberType.UInt64:
                case ContainerMemberType.Int32:
                case ContainerMemberType.UInt32:
                case ContainerMemberType.Int16:
                case ContainerMemberType.UInt16:
                case ContainerMemberType.Int8:
                case ContainerMemberType.UInt8:
                    return "number";

                case ContainerMemberType.Bool:
                    return "bool";

                case ContainerMemberType.String:
                    return "string";

                case ContainerMemberType.GUID:
                    return "[[vext:ref:vu:cls:shr:Guid|Guid]]";

                case ContainerMemberType.SHA1:
                    return "[[vext:ref:vu:cls:shr:SHA1|SHA1]]";
                    
                case ContainerMemberType.Container:
                    if (IsBuiltInType(p_Member))
                        return "[[vext:ref:vu:cls:shr:" + p_Member.ContainerType.Components.Last() + "|" + p_Member.ContainerType.Components.Last() + "]]";

                    return "[[" + p_Member.ContainerType.Components.Last() + "]]";

                default:
                    return null;
            }
        }
        
        private static bool IsBuiltInType(ContainerMember p_Member)
        {
            if (p_Member.MemberType != ContainerMemberType.Container)
            {
                return p_Member.MemberType == ContainerMemberType.GUID ||
                       p_Member.MemberType == ContainerMemberType.SHA1;
            }

            var s_Type = p_Member.ContainerType.ToString();

            return s_Type == "DataContainer" ||
                   s_Type == "Vec2" ||
                   s_Type == "Vec3" ||
                   s_Type == "Vec4" ||
                   s_Type == "Mat4" ||
                   s_Type == "ResourceRef" ||
                   s_Type == "LinearTransform" ||
                   s_Type == "AxisAlignedBox";
        }
    }
}
