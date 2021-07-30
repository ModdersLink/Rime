using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using FBCC.Containers;
using FBCC.Managers;

namespace FBCC.Generators
{
    class BindingGenerator : IGenerator
    {
        private static readonly List<string> m_ReservedLuaKeywords = new List<string>()
        {
            "and", "break", "do", "else", "elseif", 
            "end", "false", "for", "function", "goto", "if",
            "in", "local", "nil", "not", "or",
            "repeat", "return", "then", "true", "until",
            "while"
        }; 

        public string Name => "VeniceEXT/Classes/Generated";
        
        private StringWriter m_HeaderWriter;
        private StringWriter m_SourceWriter;

        private FrostbiteContainer m_Container;

        private string m_Indent;

        public Dictionary<string, string> Generate(FrostbiteContainer p_Container)
        {
            var s_GeneratedFiles = new Dictionary<string, string>();

            if (p_Container.Definitions.Count == 0)
                return s_GeneratedFiles;

            m_Container = p_Container;

            m_HeaderWriter = new StringWriter();
            m_SourceWriter = new StringWriter();

            WriteDisclaimer(m_HeaderWriter);
            WriteDisclaimer(m_SourceWriter);

            WriteHeader();
            WriteSource();

            m_HeaderWriter.Flush();
            s_GeneratedFiles.Add(p_Container.Name + ".h", m_HeaderWriter.ToString());
            s_GeneratedFiles.Add(p_Container.Name + ".cpp", m_SourceWriter.ToString());

            m_HeaderWriter.Dispose();
            m_SourceWriter.Dispose();
            m_Container = null;

            return s_GeneratedFiles;
        }

        private bool OnlyEnums()
        {
            return m_Container.Definitions.All(p_Definition => p_Definition.DefinitionType == ContainerDefinitionType.Enum);
        }

        private static void WriteDisclaimer(TextWriter p_Writer)
        {
            p_Writer.WriteLine("///////////////////////////////////////////////////////////////");
            p_Writer.WriteLine("//                                                           //");
            p_Writer.WriteLine("// This is an automatically generated file.                  //");
            p_Writer.WriteLine("// Do *NOT* modify unless you really know what you're doing. //");
            p_Writer.WriteLine("//                                                           //");
            p_Writer.WriteLine("///////////////////////////////////////////////////////////////");
            p_Writer.WriteLine();
        }

        private void WriteHeader()
        {
            m_Indent = "";

            m_HeaderWriter.WriteLine(m_Indent + "#pragma once");
            m_HeaderWriter.WriteLine();

            // Write the base includes along with built-in types.
            m_HeaderWriter.WriteLine(m_Indent + "#include <StdAfx.h>");
            m_HeaderWriter.WriteLine(m_Indent + "#include <aligned_allocator.h>");
            m_HeaderWriter.WriteLine();

            var s_PreDefinitions = new HashSet<string>();
            var s_NativeIncludes = new HashSet<string>();

            // Only include these if we have at least one class or struct definition.
            if (!OnlyEnums())
            {
                m_HeaderWriter.WriteLine(m_Indent + "#include <VeniceEXT/Classes/Shared/DataContainer.h>");
                m_HeaderWriter.WriteLine();

                // Collect includes.
                var s_Includes = new HashSet<string>();
                var s_FrostbiteIncludes = new HashSet<ContainerNamespace>();
                var s_DataClasses = new HashSet<string>();
                var s_DataStructs = new HashSet<string>();
                var s_PreDefinedStructs = new HashSet<string>();

                var s_HasArray = false;
                var s_HasRefArray = false;
                var s_HasString = false;

                foreach (var s_Definition in m_Container.Definitions)
                {
                    if (s_Definition.DefinitionType == ContainerDefinitionType.Class)
                    {
                        var s_Class = (ContainerClass) s_Definition;

                        s_DataClasses.Add(s_Class.Name);

                        foreach (var s_InheritedClass in s_Class.InheritedClasses)
                            if (s_InheritedClass.Components[s_InheritedClass.Components.Count - 1] != "DataContainer")
                                s_Includes.Add(s_InheritedClass.Components[s_InheritedClass.Components.Count - 1]);

                        s_NativeIncludes.Add("Guid");

                        foreach (var s_Member in s_Class.Members)
                        {
                            if (s_Member.Array)
                            {
                                if (s_Member.MemberType == ContainerMemberType.Container && ContainerManager.HasClass(s_Member.ContainerType))
                                {
                                    s_HasRefArray = true;
                                    s_PreDefinitions.Add(s_Member.ContainerType.Components.Last());
                                }
                                else
                                {
                                    s_HasArray = true;

                                    if (s_Member.MemberType == ContainerMemberType.Container)
                                        s_DataStructs.Add(s_Member.ContainerType.Components.Last());
                                    else if (s_Member.MemberType == ContainerMemberType.String)
                                        s_DataStructs.Add("String");
                                    else if (s_Member.MemberType == ContainerMemberType.GUID)
                                        s_DataStructs.Add("Guid");
                                }

                                continue;
                            }

                            if (s_Member.MemberType == ContainerMemberType.GUID)
                                s_NativeIncludes.Add("Guid");

                            if (s_Member.MemberType == ContainerMemberType.String)
                                s_HasString = true;

                            if (s_Member.MemberType != ContainerMemberType.Container)
                                continue;

                            if (IsBuiltInType(s_Member))
                            {
                                s_NativeIncludes.Add(s_Member.ContainerType.Components[s_Member.ContainerType.Components.Count - 1]);
                                continue;
                            }

                            if (ContainerManager.HasStruct(s_Member.ContainerType))
                            {
                                 s_PreDefinitions.Add(s_Member.ContainerType.Components[s_Member.ContainerType.Components.Count - 1]);
                            }
                            else if (ContainerManager.HasEnum(s_Member.ContainerType))
                            {
                                s_FrostbiteIncludes.Add(s_Member.ContainerType);
                            }
                            else
                            {
                                s_PreDefinitions.Add(s_Member.ContainerType.Components[s_Member.ContainerType.Components.Count - 1]);
                            }
                        }

                        continue;
                    }

                    if (s_Definition.DefinitionType == ContainerDefinitionType.Struct)
                    {
                        var s_Struct = (ContainerStruct) s_Definition;

                        s_DataStructs.Add(s_Struct.Name);

                        foreach (var s_Member in s_Struct.Members)
                        {
                            if (s_Member.Array)
                            {
                                if (s_Member.MemberType == ContainerMemberType.Container &&
                                    ContainerManager.HasClass(s_Member.ContainerType))
                                {
                                    s_HasRefArray = true;
                                    s_PreDefinitions.Add(s_Member.ContainerType.Components.Last());
                                }
                                else
                                {
                                    s_HasArray = true;

                                    if (s_Member.MemberType == ContainerMemberType.Container)
                                        s_DataStructs.Add(s_Member.ContainerType.Components.Last());
                                    else if (s_Member.MemberType == ContainerMemberType.String)
                                        s_DataStructs.Add("String");
                                    else if (s_Member.MemberType == ContainerMemberType.GUID)
                                        s_DataStructs.Add("Guid");
                                }

                                continue;
                            }

                            if (s_Member.MemberType == ContainerMemberType.GUID)
                                s_NativeIncludes.Add("Guid");

                            if (s_Member.MemberType == ContainerMemberType.String)
                                s_HasString = true;

                            if (s_Member.MemberType != ContainerMemberType.Container)
                                continue;

                            if (IsBuiltInType(s_Member))
                            {
                                s_NativeIncludes.Add(s_Member.ContainerType.Components[s_Member.ContainerType.Components.Count - 1]);
                                continue;
                            }

                            if (ContainerManager.HasStruct(s_Member.ContainerType))
                            {
                                s_PreDefinitions.Add(s_Member.ContainerType.Components[s_Member.ContainerType.Components.Count - 1]);
                            }
                            else if (ContainerManager.HasEnum(s_Member.ContainerType))
                            {
                                s_FrostbiteIncludes.Add(s_Member.ContainerType);
                            }
                            else
                            {
                                s_PreDefinitions.Add(s_Member.ContainerType.Components[s_Member.ContainerType.Components.Count - 1]);
                            }
                        }
                    }
                }

                // Write the includes.
                foreach (var s_Include in s_Includes)
                    m_HeaderWriter.WriteLine(m_Indent + "#include \"{0}.h\"", s_Include);

                if (s_Includes.Count > 0)
                    m_HeaderWriter.WriteLine();

                // Write Frostbite includes.
                foreach (var s_Include in s_FrostbiteIncludes)
                    m_HeaderWriter.WriteLine(m_Indent + "#include <{0}.h>",
                        string.Join("/", m_Container.Namespace.Components.Concat(s_Include.Components)));

                if (s_HasArray)
                    m_HeaderWriter.WriteLine(m_Indent + "#include <fb/Array.h>");

                if (s_HasRefArray)
                    m_HeaderWriter.WriteLine(m_Indent + "#include <fb/RefArray.h>");
                
                foreach (var s_Struct in s_DataStructs)
                    m_HeaderWriter.WriteLine(m_Indent + "#include <fb/{0}.h>", s_Struct);

                if (s_HasArray || s_HasRefArray)
                    m_HeaderWriter.WriteLine(m_Indent + "#include <readonly_array.h>");

                if (s_HasArray || s_HasRefArray || s_DataStructs.Count > 0)
                    m_HeaderWriter.WriteLine();

                // Write class/struct pre-definitions.
                // TODO: Change assumption that classes are always in the fb namespace.
                if (s_DataClasses.Count > 0 || s_HasString || s_PreDefinedStructs.Count > 0 || s_PreDefinitions.Count > 0)
                {
                    m_HeaderWriter.WriteLine(m_Indent + "namespace fb");
                    m_HeaderWriter.WriteLine(m_Indent + "{");
                    m_Indent += "\t";

                    foreach (var s_Class in s_DataClasses)
                        m_HeaderWriter.WriteLine(m_Indent + "class {0};", s_Class);

                    foreach (var s_Class in s_PreDefinedStructs)
                        m_HeaderWriter.WriteLine(m_Indent + "struct {0};", s_Class);

                    if (s_HasString)
                        m_HeaderWriter.WriteLine(m_Indent + "class String;");

                    foreach (var s_PreDefinition in s_PreDefinitions)
                    {
                        if (ContainerManager.HasStruct(s_PreDefinition))
                            m_HeaderWriter.WriteLine(m_Indent + "struct " + s_PreDefinition + ";");
                        else
                            m_HeaderWriter.WriteLine(m_Indent + "class " + s_PreDefinition + ";");
                    }

                    m_Indent = m_Indent.Substring(0, m_Indent.Length - 1);
                    m_HeaderWriter.WriteLine(m_Indent + "}");
                    m_HeaderWriter.WriteLine();
                }
            }

            m_HeaderWriter.WriteLine(m_Indent + "namespace sol");
            m_HeaderWriter.WriteLine(m_Indent + "{");
            m_HeaderWriter.WriteLine(m_Indent + "\tclass state_view; ");
            m_HeaderWriter.WriteLine(m_Indent + "\tstruct this_state; ");
            m_HeaderWriter.WriteLine();
            m_HeaderWriter.WriteLine(m_Indent + "\ttemplate <bool b>");
            m_HeaderWriter.WriteLine(m_Indent + "\tclass basic_reference;");
            m_HeaderWriter.WriteLine();
            m_HeaderWriter.WriteLine(m_Indent + "\tusing reference = basic_reference<false>;");
            m_HeaderWriter.WriteLine();
            m_HeaderWriter.WriteLine(m_Indent + "\ttemplate <typename base_t>");
            m_HeaderWriter.WriteLine(m_Indent + "\tclass basic_object;");
            m_HeaderWriter.WriteLine();
            m_HeaderWriter.WriteLine(m_Indent + "\tusing object = basic_object<reference>;");
            m_HeaderWriter.WriteLine(m_Indent + "}");
            m_HeaderWriter.WriteLine();
            m_HeaderWriter.WriteLine(m_Indent + "namespace VeniceEXT { namespace Classes { namespace Shared {");

            m_HeaderWriter.WriteLine(m_Indent + "\tclass TypeInformation;");

            foreach (var s_Include in s_NativeIncludes)
                m_HeaderWriter.WriteLine(m_Indent + "\tclass {0};", s_Include);

            m_HeaderWriter.WriteLine(m_Indent + "}}}");
            m_HeaderWriter.WriteLine();

            // Write the pre-definitions.
            foreach (var s_PreDefinition in s_PreDefinitions)
                m_HeaderWriter.WriteLine(m_Indent + "class " + s_PreDefinition + ";");

            if (s_PreDefinitions.Count > 0)
                m_HeaderWriter.WriteLine();

            // Write definitions.
            foreach (var s_Definition in m_Container.Definitions)
            {
                switch (s_Definition.DefinitionType)
                {
                    case ContainerDefinitionType.Class:
                        WriteHeaderClass((ContainerClass)s_Definition);
                        break;

                    case ContainerDefinitionType.Struct:
                        WriteHeaderStruct((ContainerStruct)s_Definition);
                        break;

                    default:
                        WriteHeaderEnum((ContainerEnum)s_Definition);
                        break;
                }
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
                            ((ContainerClass) p_Definition).Name == s_ClassName));

                var s_Definition = s_Container?.Definitions.FirstOrDefault(p_Definition =>
                    p_Definition.DefinitionType == ContainerDefinitionType.Class &&
                    ((ContainerClass) p_Definition).Name == s_ClassName);

                if (s_Definition == null)
                    continue;

                GetSuperClasses((ContainerClass) s_Definition, p_Classes);
            }
        }

        private void WriteHeaderClass(ContainerClass p_Class)
        {
            var s_NamespacedName = "::" + string.Join("::", m_Container.Namespace.Components.Concat(new[] { p_Class.Name }));
            
            // Write static lua binding registrar.
            m_HeaderWriter.WriteLine(m_Indent + "void Register{0}(::sol::state_view* p_State);", p_Class.Name);
            m_HeaderWriter.WriteLine();

            m_HeaderWriter.Write(m_Indent + "class {0}", p_Class.Name);

            m_HeaderWriter.Write(" :");
            m_HeaderWriter.WriteLine();

            // Write inherited classes.
            for (var i = 0; i < p_Class.InheritedClasses.Count; ++i)
            {
                if (p_Class.InheritedClasses[i].ToString() == "DataContainer")
                    m_HeaderWriter.WriteLine(m_Indent + "\tpublic ::VeniceEXT::Classes::Shared::DataContainer{0}", i < p_Class.InheritedClasses.Count - 1 ? "," : "");
                else
                    m_HeaderWriter.WriteLine(m_Indent + "\tpublic ::{0}{1}", p_Class.InheritedClasses[i], i < p_Class.InheritedClasses.Count - 1 ? "," : "");
            }

            // Write class body start.
            m_HeaderWriter.WriteLine(m_Indent + "{");
            m_HeaderWriter.WriteLine(m_Indent + "public:");
            m_Indent += "\t";

            // Write type information getter.
            m_HeaderWriter.WriteLine(m_Indent + "static ::std::unique_ptr<::VeniceEXT::Classes::Shared::TypeInformation> GetTypeInfo();");
            m_HeaderWriter.WriteLine();
            m_HeaderWriter.WriteLine(m_Indent + "static ::std::unique_ptr<::{0}> Create();", p_Class.Name);
            m_HeaderWriter.WriteLine(m_Indent + "static ::std::unique_ptr<::{0}> CreateCopy(const ::{0}& p_Other);", p_Class.Name);

            var s_SuperClasses = new HashSet<string>();
            GetSuperClasses(p_Class, s_SuperClasses);

            foreach (var s_SuperClass in s_SuperClasses)
            {
                if (s_SuperClass == p_Class.Name)
                    continue;

                if (s_SuperClass == "DataContainer")
                    m_HeaderWriter.WriteLine(m_Indent + "static ::std::unique_ptr<::{0}> CreateFromDataContainer(const ::VeniceEXT::Classes::Shared::DataContainer& p_Other);", p_Class.Name);
                else
                    m_HeaderWriter.WriteLine(m_Indent + "static ::std::unique_ptr<::{0}> CreateFrom{1}(const ::{1}& p_Other);", p_Class.Name, s_SuperClass);
            }

            m_HeaderWriter.WriteLine();

            // Write constructors & destructor.
            m_HeaderWriter.WriteLine(m_Indent + "{0}();", p_Class.Name);
            m_HeaderWriter.WriteLine(m_Indent + "{0}(const ::{0}& p_Other);", p_Class.Name);
            m_HeaderWriter.WriteLine(m_Indent + "{0}(const ::fb::CtrRefBase& p_Ref);", p_Class.Name);
            m_HeaderWriter.WriteLine();

            m_HeaderWriter.WriteLine(m_Indent + "::std::unique_ptr<::{0}> Clone();", p_Class.Name);
            m_HeaderWriter.WriteLine(m_Indent + "::std::unique_ptr<::{0}> CloneWithGuid(const ::VeniceEXT::Classes::Shared::Guid& p_Guid);", p_Class.Name);

            // Write members.
            foreach (var s_Member in p_Class.Members)
            {
                var s_Pointer = s_Member.MemberType == ContainerMemberType.Container && ContainerManager.HasClass(s_Member.ContainerType);
                var s_WrapData = !IsNativeType(s_Member) && !ContainerManager.HasEnum(s_Member.ContainerType);

                var s_Type = GetMemberType(s_Member);

                if (string.IsNullOrWhiteSpace(s_Type))
                    continue;

                m_HeaderWriter.WriteLine();

                if (!s_Member.Array)
                {
                    // Write the getter type.
                    m_HeaderWriter.Write(m_Indent + (s_WrapData ? "::std::unique_ptr<::{0}> " : "{0} "), s_Type);

                    // Write the getter.
                    m_HeaderWriter.WriteLine(s_Member.Name == "YValue" ? "Get{0}_() const;" : "Get{0}() const;", s_Member.Name);

                    // Write the setter.
                    if (s_Pointer)
                        m_HeaderWriter.WriteLine(m_Indent + "void Set{0}({1}* p_Data);", s_Member.Name, s_Type);
                    else
                        m_HeaderWriter.WriteLine(m_Indent + "void Set{0}(const {1}& p_Data);", s_Member.Name, s_Type);
                }
                else
                {
                    if (s_Member.Name == "YValue")
                        m_HeaderWriter.WriteLine(m_Indent + "::sol::object Get{0}_(::sol::this_state p_State) const;", s_Member.Name);
                    else
                        m_HeaderWriter.WriteLine(m_Indent + "::sol::object Get{0}(::sol::this_state p_State) const;", s_Member.Name);
                }
            }
            
            // Write class body end.
            m_Indent = m_Indent.Substring(0, m_Indent.Length - 1);
            m_HeaderWriter.WriteLine(m_Indent + "};");
            m_HeaderWriter.WriteLine();

            // Write the type customization/conversion traits.
            m_HeaderWriter.WriteLine(m_Indent + "namespace sol");
            m_HeaderWriter.WriteLine(m_Indent + "{");
            m_HeaderWriter.WriteLine(m_Indent + "\ttemplate <>");
            m_HeaderWriter.WriteLine(m_Indent + "\tstruct lua_size<{0}*> : ::std::integral_constant<int, 1> {{}};", s_NamespacedName);
            m_HeaderWriter.WriteLine(m_Indent + "");
            m_HeaderWriter.WriteLine(m_Indent + "\ttemplate <>");
            m_HeaderWriter.WriteLine(m_Indent + "\tstruct lua_type_of<{0}*> : ::std::integral_constant<::sol::type, ::sol::type::userdata> {{}};", s_NamespacedName);
            m_HeaderWriter.WriteLine(m_Indent + "");
            m_HeaderWriter.WriteLine(m_Indent + "\tnamespace stack");
            m_HeaderWriter.WriteLine(m_Indent + "\t{");
            m_HeaderWriter.WriteLine(m_Indent + "\t\ttemplate <>");
            m_HeaderWriter.WriteLine(m_Indent + "\t\tstruct pusher<{0}*>", s_NamespacedName);
            m_HeaderWriter.WriteLine(m_Indent + "\t\t{");
            m_HeaderWriter.WriteLine(m_Indent + "\t\t\tstatic int push(::lua_State* L, {0}* p_Data)", s_NamespacedName);
            m_HeaderWriter.WriteLine(m_Indent + "\t\t\t{");
            m_HeaderWriter.WriteLine(m_Indent + "\t\t\t\treturn stack::push(L, ::std::make_unique<{0}>((::fb::DataContainer*) p_Data));", p_Class.Name);
            m_HeaderWriter.WriteLine(m_Indent + "\t\t\t}");
            m_HeaderWriter.WriteLine(m_Indent + "\t\t};");
            m_HeaderWriter.WriteLine(m_Indent + "");
            m_HeaderWriter.WriteLine(m_Indent + "\t\ttemplate <>");
            m_HeaderWriter.WriteLine(m_Indent + "\t\tstruct getter<{0}*>", s_NamespacedName);
            m_HeaderWriter.WriteLine(m_Indent + "\t\t{");
            m_HeaderWriter.WriteLine(m_Indent + "\t\t\tstatic {0}* get(::lua_State* L, int index, record& tracking)", s_NamespacedName);
            m_HeaderWriter.WriteLine(m_Indent + "\t\t\t{");
            m_HeaderWriter.WriteLine(m_Indent + "\t\t\t\tint absolute_index = ::lua_absindex(L, index);");
            m_HeaderWriter.WriteLine(m_Indent + "\t\t\t\tauto data = stack::get<::{0}>(L, absolute_index);", p_Class.Name);
            m_HeaderWriter.WriteLine(m_Indent + "\t\t\t\ttracking.use(1);");
            m_HeaderWriter.WriteLine(m_Indent + "\t\t\t\treturn data.Get().as<{0}>();", s_NamespacedName);
            m_HeaderWriter.WriteLine(m_Indent + "\t\t\t}");
            m_HeaderWriter.WriteLine(m_Indent + "\t\t};");
            m_HeaderWriter.WriteLine(m_Indent + "\t}");
            m_HeaderWriter.WriteLine(m_Indent + "}");
            m_HeaderWriter.WriteLine();
        }

        private void WriteHeaderStruct(ContainerStruct p_Struct)
        {
            var s_NamespacedName = "::" + string.Join("::", m_Container.Namespace.Components.Concat(new[] { p_Struct.Name }));

            // Write static lua binding registrar.
            m_HeaderWriter.WriteLine(m_Indent + "void Register{0}(::sol::state_view* p_State);", p_Struct.Name);
            m_HeaderWriter.WriteLine();

            m_HeaderWriter.WriteLine(m_Indent + "class {0}", p_Struct.Name);
            
            // Write class body start.
            m_HeaderWriter.WriteLine(m_Indent + "{");
            m_HeaderWriter.WriteLine(m_Indent + "public:");
            m_Indent += "\t";

            // Write type information getter.
            m_HeaderWriter.WriteLine(m_Indent + "static ::std::unique_ptr<::VeniceEXT::Classes::Shared::TypeInformation> GetTypeInfo();");
            m_HeaderWriter.WriteLine();

        
            // Write constructors & destructor.
            m_HeaderWriter.WriteLine(m_Indent + "{0}();", p_Struct.Name);
            m_HeaderWriter.WriteLine(m_Indent + "{0}(const ::{0}& p_Other);", p_Struct.Name);
            m_HeaderWriter.WriteLine(m_Indent + "{0}(const {1}& p_Data);", p_Struct.Name, s_NamespacedName);
            m_HeaderWriter.WriteLine(m_Indent + "{0}({1}* p_Data);", p_Struct.Name, s_NamespacedName);
            m_HeaderWriter.WriteLine();

            m_HeaderWriter.WriteLine(m_Indent + "::std::unique_ptr<::{0}> Clone();", p_Struct.Name);
            m_HeaderWriter.WriteLine();

            // Write members.
            foreach (var s_Member in p_Struct.Members)
            {
                var s_Pointer = s_Member.MemberType == ContainerMemberType.Container && ContainerManager.HasClass(s_Member.ContainerType);
                var s_WrapData = !IsNativeType(s_Member) && !ContainerManager.HasEnum(s_Member.ContainerType);

                var s_Type = GetMemberType(s_Member);

                if (string.IsNullOrWhiteSpace(s_Type))
                    continue;

                if (!s_Member.Array)
                {
                    // Write the getter type.
                    m_HeaderWriter.Write(m_Indent + (s_WrapData ? "::std::unique_ptr<::{0}> " : "{0} "), s_Type);

                    // Write the getter.
                    m_HeaderWriter.WriteLine(s_Member.Name == "YValue" ? "Get{0}_() const;" : "Get{0}() const;", s_Member.Name);

                    // Write the setter.
                    if (s_Pointer)
                        m_HeaderWriter.WriteLine(m_Indent + "void Set{0}({1}* p_Data);", s_Member.Name, s_Type);
                    else
                        m_HeaderWriter.WriteLine(m_Indent + "void Set{0}(const {1}& p_Data);", s_Member.Name, s_Type);
                }
                else
                {
                    if (s_Member.Name == "YValue")
                        m_HeaderWriter.WriteLine(m_Indent + "::sol::object Get{0}_(::sol::this_state p_State) const;", s_Member.Name);
                    else
                        m_HeaderWriter.WriteLine(m_Indent + "::sol::object Get{0}(::sol::this_state p_State) const;", s_Member.Name);
                }

                m_HeaderWriter.WriteLine();
            }

            // Write the data getter.
            m_HeaderWriter.WriteLine(m_Indent + "inline {0}* Get() const {{ return m_Data.get(); }}", s_NamespacedName);
            m_HeaderWriter.WriteLine();

            // Write the data member.
            m_HeaderWriter.WriteLine(m_Indent.Substring(0, m_Indent.Length - 1) + "protected:");
            m_HeaderWriter.WriteLine(m_Indent + "::std::shared_ptr<{0}> m_Data;", s_NamespacedName);

            // Write class body end.
            m_Indent = m_Indent.Substring(0, m_Indent.Length - 1);
            m_HeaderWriter.WriteLine(m_Indent + "};");
            m_HeaderWriter.WriteLine();

            // Write the type customization/conversion traits.
            m_HeaderWriter.WriteLine(m_Indent + "namespace sol");
            m_HeaderWriter.WriteLine(m_Indent + "{");
            m_HeaderWriter.WriteLine(m_Indent + "\ttemplate <>");
            m_HeaderWriter.WriteLine(m_Indent + "\tstruct lua_size<{0}> : ::std::integral_constant<int, 1> {{}};", s_NamespacedName);
            m_HeaderWriter.WriteLine(m_Indent + "");
            m_HeaderWriter.WriteLine(m_Indent + "\ttemplate <>");
            m_HeaderWriter.WriteLine(m_Indent + "\tstruct lua_type_of<{0}> : ::std::integral_constant<::sol::type, ::sol::type::userdata> {{}};", s_NamespacedName);
            m_HeaderWriter.WriteLine(m_Indent + "");
            m_HeaderWriter.WriteLine(m_Indent + "\tnamespace stack");
            m_HeaderWriter.WriteLine(m_Indent + "\t{");
            m_HeaderWriter.WriteLine(m_Indent + "\t\ttemplate <>");
            m_HeaderWriter.WriteLine(m_Indent + "\t\tstruct pusher<{0}>", s_NamespacedName);
            m_HeaderWriter.WriteLine(m_Indent + "\t\t{");
            m_HeaderWriter.WriteLine(m_Indent + "\t\t\tstatic int push(::lua_State* L, {0}& p_Data)", s_NamespacedName);
            m_HeaderWriter.WriteLine(m_Indent + "\t\t\t{");
            m_HeaderWriter.WriteLine(m_Indent + "\t\t\t\treturn stack::push(L, ::std::make_unique<::{0}>(&p_Data));", p_Struct.Name);
            m_HeaderWriter.WriteLine(m_Indent + "\t\t\t}");
            m_HeaderWriter.WriteLine(m_Indent + "\t\t};");
            m_HeaderWriter.WriteLine(m_Indent + "");
            m_HeaderWriter.WriteLine(m_Indent + "\t\ttemplate <>");
            m_HeaderWriter.WriteLine(m_Indent + "\t\tstruct getter<{0}>", s_NamespacedName);
            m_HeaderWriter.WriteLine(m_Indent + "\t\t{");
            m_HeaderWriter.WriteLine(m_Indent + "\t\t\tstatic {0} get(::lua_State* L, int index, record& tracking)", s_NamespacedName);
            m_HeaderWriter.WriteLine(m_Indent + "\t\t\t{");
            m_HeaderWriter.WriteLine(m_Indent + "\t\t\t\tint absolute_index = ::lua_absindex(L, index);");
            m_HeaderWriter.WriteLine(m_Indent + "\t\t\t\tauto data = stack::get<::{0}>(L, absolute_index);", p_Struct.Name);
            m_HeaderWriter.WriteLine(m_Indent + "\t\t\t\ttracking.use(1);");
            m_HeaderWriter.WriteLine(m_Indent + "\t\t\t\treturn *data.Get();");
            m_HeaderWriter.WriteLine(m_Indent + "\t\t\t}");
            m_HeaderWriter.WriteLine(m_Indent + "\t\t};");
            m_HeaderWriter.WriteLine(m_Indent + "\t}");
            m_HeaderWriter.WriteLine(m_Indent + "}");
            m_HeaderWriter.WriteLine();
        }

        private void WriteHeaderEnum(ContainerEnum p_Enum)
        {
            m_HeaderWriter.WriteLine(m_Indent + "void Register{0}(sol::state_view* p_State);", p_Enum.Name);
            m_HeaderWriter.WriteLine();
        }

        private void WriteSource()
        {
            m_Indent = "";

            m_SourceWriter.WriteLine("#include \"{0}.h\"", m_Container.Name);
            m_SourceWriter.WriteLine();

            m_SourceWriter.WriteLine("#include <sol.hpp>");
            m_SourceWriter.WriteLine();

            // Collect pre-definitions.
            var s_Includes = new HashSet<string>();
            var s_FrostbiteIncludes = new HashSet<string>();
            var s_NativeIncludes = new HashSet<string>();

            foreach (var s_Definition in m_Container.Definitions)
            {
                if (s_Definition.DefinitionType == ContainerDefinitionType.Class)
                {
                    var s_Class = (ContainerClass)s_Definition;

                    s_FrostbiteIncludes.Add(s_Class.Name);

                    foreach (var s_InheritedClass in s_Class.InheritedClasses)
                        if (s_InheritedClass.Components.Last() != "DataContainer")
                            s_Includes.Add(s_InheritedClass.Components.Last());

                    foreach (var s_Member in s_Class.Members)
                    {
                        if (s_Member.Array)
                        {
                            if (s_Member.MemberType == ContainerMemberType.String)
                            {
                                s_NativeIncludes.Add("String");
                                continue;
                            }

                            if (s_Member.MemberType == ContainerMemberType.Container ||
                                s_Member.MemberType == ContainerMemberType.GUID)
                            {
                                if (IsBuiltInType(s_Member))
                                    s_NativeIncludes.Add(s_Member.ContainerType.Components.Last());
                                else
                                    s_Includes.Add(s_Member.ContainerType.Components.Last());

                                s_FrostbiteIncludes.Add(s_Member.ContainerType.Components.Last());
                            }

                            continue;
                        }

                        if (s_Member.MemberType == ContainerMemberType.GUID)
                            s_NativeIncludes.Add("Guid");

                        if (s_Member.MemberType != ContainerMemberType.Container)
                            continue;

                        if (IsBuiltInType(s_Member))
                        {
                            s_NativeIncludes.Add(s_Member.ContainerType.Components.Last());
                            continue;
                        }
                        
                        if (ContainerManager.HasEnum(s_Member.ContainerType))
                        {
                            s_FrostbiteIncludes.Add(s_Member.ContainerType.Components.Last());
                        }
                        else
                        {
                            s_Includes.Add(s_Member.ContainerType.Components.Last());
                        }
                    }

                    continue;
                }

                if (s_Definition.DefinitionType == ContainerDefinitionType.Struct)
                {
                    var s_Struct = (ContainerStruct)s_Definition;

                    s_FrostbiteIncludes.Add(s_Struct.Name);

                    foreach (var s_Member in s_Struct.Members)
                    {
                        if (s_Member.Array)
                        {
                            if (s_Member.MemberType == ContainerMemberType.String)
                            {
                                s_NativeIncludes.Add("String");
                                continue;
                            }

                            if (s_Member.MemberType == ContainerMemberType.Container ||
                                s_Member.MemberType == ContainerMemberType.GUID)
                            {
                                if (IsBuiltInType(s_Member))
                                    s_NativeIncludes.Add(s_Member.ContainerType.Components.Last());
                                else
                                    s_Includes.Add(s_Member.ContainerType.Components.Last());

                                s_FrostbiteIncludes.Add(s_Member.ContainerType.Components.Last());
                            }

                            continue;
                        }

                        if (s_Member.MemberType == ContainerMemberType.GUID)
                            s_NativeIncludes.Add("Guid");

                        if (s_Member.MemberType != ContainerMemberType.Container)
                            continue;

                        if (IsBuiltInType(s_Member))
                        {
                            s_NativeIncludes.Add(s_Member.ContainerType.Components.Last());
                            continue;
                        }
                        
                        if (ContainerManager.HasEnum(s_Member.ContainerType))
                        {
                            s_FrostbiteIncludes.Add(s_Member.ContainerType.Components.Last());
                        }
                        else
                        {
                            s_Includes.Add(s_Member.ContainerType.Components.Last());
                        }
                    }

                    continue;
                }

                if (s_Definition.DefinitionType == ContainerDefinitionType.Enum)
                {
                    var s_Enum = (ContainerEnum) s_Definition;
                    s_FrostbiteIncludes.Add(s_Enum.Name);
                }
            }

            // Write pre-definition includes.
            foreach (var s_Inclde in s_Includes)
                m_SourceWriter.WriteLine("#include \"{0}.h\"", s_Inclde);

            if (s_Includes.Count > 0)
                m_SourceWriter.WriteLine();
            
            foreach (var s_Include in s_FrostbiteIncludes)
                m_SourceWriter.WriteLine(m_Indent + "#include <fb/{0}.h>", s_Include);

            m_SourceWriter.WriteLine(m_Indent + "#include <fb/TypeInfoManager.h>");
            m_SourceWriter.WriteLine();
            m_SourceWriter.WriteLine(m_Indent + "#include <VeniceEXT/Classes/Shared/TypeInformation.h>");

            foreach (var s_Include in s_NativeIncludes)
                m_SourceWriter.WriteLine(m_Indent + "#include <VeniceEXT/Classes/Shared/{0}.h>", s_Include);

            m_SourceWriter.WriteLine();
            
            // Write definitions.
            foreach (var s_Definition in m_Container.Definitions)
            {
                switch (s_Definition.DefinitionType)
                {
                    case ContainerDefinitionType.Class:
                        WriteSourceClass((ContainerClass) s_Definition);
                        break;

                    case ContainerDefinitionType.Struct:
                        WriteSourceStruct((ContainerStruct) s_Definition);
                        break;

                    default:
                        WriteSourceEnum((ContainerEnum) s_Definition);
                        break;
                }
            }
        }

        private void WriteSourceClass(ContainerClass p_Class)
        {
            var s_NamespacedName = "::" + string.Join("::", m_Container.Namespace.Components.Concat(new[] { p_Class.Name }));

            // Write the registration function.
            m_SourceWriter.WriteLine(m_Indent + "void Register{0}(::sol::state_view* p_State)", p_Class.Name);
            m_SourceWriter.WriteLine(m_Indent + "{");
            m_Indent += "\t";
            
            m_SourceWriter.WriteLine(m_Indent + "::sol::simple_usertype<::{0}> s_Usertype = p_State->create_simple_usertype<::{0}>(", p_Class.Name); ;
            m_Indent += "\t";

            // Write lua constructors.
            m_SourceWriter.WriteLine(m_Indent + "::sol::call_constructor, ::sol::factories(");
            m_Indent += "\t";

            m_SourceWriter.WriteLine(m_Indent + "&::{0}::Create,", p_Class.Name);
            m_SourceWriter.Write(m_Indent + "&::{0}::CreateCopy", p_Class.Name);

            var s_SuperClasses = new HashSet<string>();
            GetSuperClasses(p_Class, s_SuperClasses);
            
            foreach (var s_SuperClass in s_SuperClasses)
            {
                if (s_SuperClass == p_Class.Name)
                    continue;

                m_SourceWriter.WriteLine(",");
                m_SourceWriter.Write(m_Indent + "&::{0}::CreateFrom{1}", p_Class.Name, s_SuperClass);
            }

            m_SourceWriter.WriteLine();

            m_Indent = m_Indent.Substring(0, m_Indent.Length - 1);
            m_SourceWriter.WriteLine(m_Indent + "),");

            m_SourceWriter.WriteLine();

            // Write base classes.
            m_SourceWriter.Write(m_Indent + "::sol::base_classes, ::sol::bases<");

            var s_HasFirst = false;
            foreach (var s_SuperClass in s_SuperClasses)
            {
                var s_RealSuperClass = s_SuperClass;

                if (s_RealSuperClass == p_Class.Name)
                    continue;

                if (s_RealSuperClass == "DataContainer")
                    s_RealSuperClass = "VeniceEXT::Classes::Shared::DataContainer";

                if (!s_HasFirst)
                {
                    s_HasFirst = true;
                    m_SourceWriter.Write("::{0}", s_RealSuperClass);
                    continue;
                }

                m_SourceWriter.Write(", ::{0}", s_RealSuperClass);
            }

            m_SourceWriter.WriteLine(">()");

            m_Indent = m_Indent.Substring(0, m_Indent.Length - 1);
            m_SourceWriter.WriteLine(m_Indent + ");");
            m_SourceWriter.WriteLine();

            // Write lua member getters and setters.
            foreach (var s_Member in p_Class.Members)
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

                if (!s_Member.Array)
                {
                    if (s_Member.Name == "YValue")
                        m_SourceWriter.WriteLine(m_Indent + "s_Usertype.set(\"{0}\", ::sol::property(&::{1}::Get{2}_, &::{1}::Set{2}));", s_MemberName, p_Class.Name, s_Member.Name);
                    else
                        m_SourceWriter.WriteLine(m_Indent + "s_Usertype.set(\"{0}\", ::sol::property(&::{1}::Get{2}, &::{1}::Set{2}));", s_MemberName, p_Class.Name, s_Member.Name);

                    continue;
                }
                
                if (s_Member.Name == "YValue")
                    m_SourceWriter.WriteLine(m_Indent + "s_Usertype.set(\"{0}\", ::sol::property(&::{2}::Get{1}_));", s_MemberName, s_Member.Name, p_Class.Name);
                else
                    m_SourceWriter.WriteLine(m_Indent + "s_Usertype.set(\"{0}\", ::sol::property(&::{2}::Get{1}));", s_MemberName, s_Member.Name, p_Class.Name);
            }

            m_SourceWriter.WriteLine(m_Indent + "s_Usertype.set(\"typeInfo\", ::sol::property(&::{0}::GetTypeInfo));", p_Class.Name);
            m_SourceWriter.WriteLine();
            m_SourceWriter.WriteLine(m_Indent + "s_Usertype.set(\"Clone\", ::sol::overload(&::{0}::Clone, &::{0}::CloneWithGuid));", p_Class.Name);
            m_SourceWriter.WriteLine();
            m_SourceWriter.WriteLine(m_Indent + "p_State->set_usertype(\"{0}\", s_Usertype);", p_Class.Name);

            m_Indent = m_Indent.Substring(0, m_Indent.Length - 1);
            m_SourceWriter.WriteLine(m_Indent + "}");
            m_SourceWriter.WriteLine();

            // Write type information getter.
            m_SourceWriter.WriteLine(m_Indent + "::std::unique_ptr<::VeniceEXT::Classes::Shared::TypeInformation> {0}::GetTypeInfo()", p_Class.Name);
            m_SourceWriter.WriteLine(m_Indent + "{");
            m_Indent += "\t";

            m_SourceWriter.WriteLine(m_Indent + "return ::std::make_unique<::VeniceEXT::Classes::Shared::TypeInformation>(::fb::TypeInfoManager::GetClassTypeInfo(\"{0}\"));", p_Class.Name);

            m_Indent = m_Indent.Substring(0, m_Indent.Length - 1);
            m_SourceWriter.WriteLine(m_Indent + "}");
            m_SourceWriter.WriteLine();

            // Write cloning functions.
            m_SourceWriter.WriteLine(m_Indent + "::std::unique_ptr<::{0}> {0}::Clone()", p_Class.Name);
            m_SourceWriter.WriteLine(m_Indent + "{");
            m_SourceWriter.WriteLine(m_Indent + "\treturn ::std::make_unique<{0}>(({1}*) m_Ptr->clone(m_Ptr, fb::s_globalHeapArena, nullptr, true));", p_Class.Name, s_NamespacedName);
            m_SourceWriter.WriteLine(m_Indent + "}");
            m_SourceWriter.WriteLine();
            m_SourceWriter.WriteLine(m_Indent + "::std::unique_ptr<::{0}> {0}::CloneWithGuid(const ::VeniceEXT::Classes::Shared::Guid& p_Guid)", p_Class.Name);
            m_SourceWriter.WriteLine(m_Indent + "{");
            m_SourceWriter.WriteLine(m_Indent + "\treturn ::std::make_unique<{0}>(({1}*) m_Ptr->clone(m_Ptr, fb::s_globalHeapArena, p_Guid.Get(), true));", p_Class.Name, s_NamespacedName);
            m_SourceWriter.WriteLine(m_Indent + "}");
            m_SourceWriter.WriteLine();

            // Write creators.
            m_SourceWriter.WriteLine(m_Indent + "::std::unique_ptr<::{0}> {0}::Create()", p_Class.Name);
            m_SourceWriter.WriteLine(m_Indent + "{");
            m_SourceWriter.WriteLine(m_Indent + "\treturn ::std::make_unique<{0}>();", p_Class.Name);
            m_SourceWriter.WriteLine(m_Indent + "}");
            m_SourceWriter.WriteLine();
            m_SourceWriter.WriteLine(m_Indent + "::std::unique_ptr<::{0}> {0}::CreateCopy(const ::{0}& p_Other)", p_Class.Name);
            m_SourceWriter.WriteLine(m_Indent + "{");
            m_SourceWriter.WriteLine(m_Indent + "\treturn ::std::make_unique<{0}>(p_Other);", p_Class.Name);
            m_SourceWriter.WriteLine(m_Indent + "}");
            m_SourceWriter.WriteLine();

            foreach (var s_SuperClass in s_SuperClasses)
            {
                if (s_SuperClass == p_Class.Name)
                    continue;

                if (s_SuperClass == "DataContainer")
                    m_SourceWriter.WriteLine(m_Indent + "::std::unique_ptr<::{0}> {0}::CreateFromDataContainer(const ::VeniceEXT::Classes::Shared::DataContainer& p_Other)", p_Class.Name);
                else
                    m_SourceWriter.WriteLine(m_Indent + "::std::unique_ptr<::{0}> {0}::CreateFrom{1}(const ::{1}& p_Other)", p_Class.Name, s_SuperClass);

                m_SourceWriter.WriteLine(m_Indent + "{");
                m_SourceWriter.WriteLine(m_Indent + "\tif (!p_Other.Is(\"{0}\"))", p_Class.Name);
                m_SourceWriter.WriteLine(m_Indent + "\t\treturn nullptr;", p_Class.Name);
                m_SourceWriter.WriteLine();
                m_SourceWriter.WriteLine(m_Indent + "\treturn ::std::make_unique<{0}>(p_Other.Get());", p_Class.Name);
                m_SourceWriter.WriteLine(m_Indent + "}");
                m_SourceWriter.WriteLine();
            }

            // Write constructors.
            m_SourceWriter.WriteLine(m_Indent + "{0}::{0}()", p_Class.Name);
            m_SourceWriter.WriteLine(m_Indent + "{");
            m_SourceWriter.WriteLine(m_Indent + "\tm_Ptr = {0}::CreateInstance(fb::s_globalHeapArena);", s_NamespacedName);
            m_SourceWriter.WriteLine(m_Indent + "}");
            m_SourceWriter.WriteLine();
            m_SourceWriter.WriteLine(m_Indent + "{0}::{0}(const ::{0}& p_Other)", p_Class.Name);
            m_SourceWriter.WriteLine(m_Indent + "{");
            m_SourceWriter.WriteLine(m_Indent + "\tm_Ptr = p_Other.m_Ptr;", s_NamespacedName);
            m_SourceWriter.WriteLine(m_Indent + "}");
            m_SourceWriter.WriteLine();
            m_SourceWriter.WriteLine(m_Indent + "{0}::{0}(const ::fb::CtrRefBase& p_Ref)", p_Class.Name);
            m_SourceWriter.WriteLine(m_Indent + "{");
            m_SourceWriter.WriteLine(m_Indent + "\tm_Ptr = p_Ref;", s_NamespacedName);
            m_SourceWriter.WriteLine(m_Indent + "}");
            m_SourceWriter.WriteLine();
            
            // Write members.
            foreach (var s_Member in p_Class.Members)
            {
                var s_Type = GetMemberType(s_Member);

                if (string.IsNullOrWhiteSpace(s_Type))
                    continue;

                var s_Pointer = s_Member.MemberType == ContainerMemberType.Container && ContainerManager.HasClass(s_Member.ContainerType);
                var s_WrapData = !IsNativeType(s_Member) && !ContainerManager.HasEnum(s_Member.ContainerType);
                var s_String = s_Member.MemberType == ContainerMemberType.String;

                if (!s_Member.Array)
                {
                    // Write the getter type.
                    m_SourceWriter.Write(m_Indent + (s_WrapData ? "::std::unique_ptr<::{0}> " : "{0} "), s_Type);

                    // Write the getter.
                    m_SourceWriter.WriteLine(s_Member.Name == "YValue" ? "{1}::Get{0}_() const" : "{1}::Get{0}() const", s_Member.Name, p_Class.Name);
                    m_SourceWriter.WriteLine(m_Indent + "{");

                    m_Indent += "\t";

                    m_SourceWriter.WriteLine(m_Indent + "if (m_Ptr.isNull())");

                    if (s_WrapData)
                    {
                        if (s_Pointer)
                            m_SourceWriter.WriteLine(m_Indent + "\treturn nullptr;");
                        else
                            m_SourceWriter.WriteLine(m_Indent + "\treturn std::make_unique<{0}>();", s_Type);
                    }
                    else
                    {
                        m_SourceWriter.WriteLine(m_Indent + "\treturn {0};", GetDefaultValue(s_Member));
                    }

                    m_SourceWriter.WriteLine();

                    if (s_Pointer)
                    {
                        m_SourceWriter.WriteLine(m_Indent + "if (!As<{0}>()->m_{1})", s_NamespacedName, s_Member.Name);
                        m_SourceWriter.WriteLine(m_Indent + "\treturn nullptr;");
                        m_SourceWriter.WriteLine();
                    }

                    if (s_WrapData)
                    {
                        if (s_Pointer)
                        {
                            m_SourceWriter.WriteLine(m_Indent + "return ::std::make_unique<::{0}>(As<{1}>()->m_{2});", s_Type, s_NamespacedName, s_Member.Name);
                        }
                        else
                        {
                            
                            m_SourceWriter.WriteLine(m_Indent + "if (IsReadOnly())", s_Type, s_NamespacedName, s_Member.Name);
                            m_SourceWriter.WriteLine(m_Indent + "\treturn ::std::make_unique<::{0}>(As<{1}>()->m_{2});", s_Type, s_NamespacedName, s_Member.Name);
                            m_SourceWriter.WriteLine();
                            m_SourceWriter.WriteLine(m_Indent + "return ::std::make_unique<::{0}>(&As<{1}>()->m_{2});", s_Type, s_NamespacedName, s_Member.Name);
                        }
                    }
                    else
                    {
                        m_SourceWriter.WriteLine(m_Indent + "return As<{0}>()->m_{1}{2};", s_NamespacedName, s_Member.Name, s_String ? ".c_str()" : "");
                    }

                    m_Indent = m_Indent.Substring(1);

                    m_SourceWriter.WriteLine(m_Indent + "}");
                    m_SourceWriter.WriteLine();

                    if (s_Pointer)
                    {
                        m_SourceWriter.WriteLine(m_Indent + "void ::{2}::Set{0}(::{1}* p_Data)", s_Member.Name, s_Type, p_Class.Name);
                    }
                    else
                    {
                        if (s_WrapData)
                            m_SourceWriter.WriteLine(m_Indent + "void ::{2}::Set{0}(const ::{1}& p_Data)", s_Member.Name, s_Type, p_Class.Name);
                        else
                            m_SourceWriter.WriteLine(m_Indent + "void ::{2}::Set{0}(const {1}& p_Data)", s_Member.Name, s_Type, p_Class.Name);
                    }

                    m_SourceWriter.WriteLine(m_Indent + "{");

                    m_Indent += "\t";

                    m_SourceWriter.WriteLine(m_Indent + "if (m_Ptr.isNull() || IsReadOnly())");
                    m_SourceWriter.WriteLine(m_Indent + "\treturn;");
                    m_SourceWriter.WriteLine();

                    if (s_Pointer)
                    {
                        m_SourceWriter.WriteLine(m_Indent + "As<{0}>()->m_{1}.replace(p_Data ? p_Data->Get() : nullptr);", s_NamespacedName, s_Member.Name);
                    }
                    else
                    {
                        if (s_WrapData)
                            m_SourceWriter.WriteLine(m_Indent + "As<{0}>()->m_{1} = *p_Data.Get();", s_NamespacedName, s_Member.Name);
                        else
                            m_SourceWriter.WriteLine(m_Indent + "As<{0}>()->m_{1} = p_Data;", s_NamespacedName, s_Member.Name);
                    }

                    m_Indent = m_Indent.Substring(1);

                    m_SourceWriter.WriteLine(m_Indent + "}");
                }
                else
                {
                    m_SourceWriter.WriteLine(m_Indent + "::sol::object {0}::Get{1}(::sol::this_state p_State) const", p_Class.Name, s_Member.Name);
                    m_SourceWriter.WriteLine(m_Indent + "{");

                    m_Indent += "\t";

                    m_SourceWriter.WriteLine(m_Indent + "if (m_Ptr.isNull())");
                    m_SourceWriter.WriteLine(m_Indent + "\treturn ::sol::make_object(p_State, nullptr);");
                    m_SourceWriter.WriteLine();
                    m_SourceWriter.WriteLine(m_Indent + "if (IsReadOnly())");
                    m_SourceWriter.WriteLine(m_Indent + "\treturn ::sol::make_object(p_State, ::readonly_array_creator::create(&As<{0}>()->m_{1}));", s_NamespacedName, s_Member.Name);
                    m_SourceWriter.WriteLine();
                    m_SourceWriter.WriteLine(m_Indent + "return ::sol::make_object(p_State, std::ref(As<{0}>()->m_{1}));", s_NamespacedName, s_Member.Name);

                    m_Indent = m_Indent.Substring(1);

                    m_SourceWriter.WriteLine(m_Indent + "}");
                    m_SourceWriter.WriteLine();
                }

                m_SourceWriter.WriteLine();
            }
        }

        private void WriteSourceStruct(ContainerStruct p_Struct)
        {
            var s_NamespacedName = "::" + string.Join("::", m_Container.Namespace.Components.Concat(new[] { p_Struct.Name }));

            // Write the registration function.
            m_SourceWriter.WriteLine(m_Indent + "void Register{0}(::sol::state_view* p_State)", p_Struct.Name);
            m_SourceWriter.WriteLine(m_Indent + "{");
            m_Indent += "\t";

            m_SourceWriter.WriteLine(m_Indent + "::sol::simple_usertype<::{0}> s_Usertype = p_State->create_simple_usertype<::{0}>(", p_Struct.Name); ;
            m_Indent += "\t";

            // Write lua constructors.
            m_SourceWriter.WriteLine(m_Indent + "::sol::call_constructor, ::sol::constructors<::sol::types<>, ::sol::types<const ::{0}&>>()", p_Struct.Name);


            m_Indent = m_Indent.Substring(0, m_Indent.Length - 1);
            m_SourceWriter.WriteLine(m_Indent + ");");
            m_SourceWriter.WriteLine();

            // Write lua member getters and setters.
            foreach (var s_Member in p_Struct.Members)
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

                if (!s_Member.Array)
                {
                    if (s_Member.Name == "YValue")
                        m_SourceWriter.WriteLine(m_Indent + "s_Usertype.set(\"{0}\", ::sol::property(&::{1}::Get{2}_, &::{1}::Set{2}));", s_MemberName, p_Struct.Name, s_Member.Name);
                    else
                        m_SourceWriter.WriteLine(m_Indent + "s_Usertype.set(\"{0}\", ::sol::property(&::{1}::Get{2}, &::{1}::Set{2}));", s_MemberName, p_Struct.Name, s_Member.Name);

                    continue;
                }

                if (s_Member.Name == "YValue")
                    m_SourceWriter.WriteLine(m_Indent + "s_Usertype.set(\"{0}\", ::sol::property(&::{2}::Get{1}_));", s_MemberName, s_Member.Name, p_Struct.Name);
                else
                    m_SourceWriter.WriteLine(m_Indent + "s_Usertype.set(\"{0}\", ::sol::property(&::{2}::Get{1}));", s_MemberName, s_Member.Name, p_Struct.Name);
            }

            m_SourceWriter.WriteLine(m_Indent + "s_Usertype.set(\"typeInfo\", ::sol::property(&::{0}::GetTypeInfo));", p_Struct.Name);
            m_SourceWriter.WriteLine();
            m_SourceWriter.WriteLine(m_Indent + "s_Usertype.set(\"Clone\", &::{0}::Clone);", p_Struct.Name);
            m_SourceWriter.WriteLine();
            m_SourceWriter.WriteLine(m_Indent + "p_State->set_usertype(\"{0}\", s_Usertype);", p_Struct.Name);

            m_Indent = m_Indent.Substring(0, m_Indent.Length - 1);
            m_SourceWriter.WriteLine(m_Indent + "}");
            m_SourceWriter.WriteLine();

            // Write type information getter.
            m_SourceWriter.WriteLine(m_Indent + "::std::unique_ptr<::VeniceEXT::Classes::Shared::TypeInformation> {0}::GetTypeInfo()", p_Struct.Name);
            m_SourceWriter.WriteLine(m_Indent + "{");
            m_Indent += "\t";

            m_SourceWriter.WriteLine(m_Indent + "return ::std::make_unique<::VeniceEXT::Classes::Shared::TypeInformation>(::fb::TypeInfoManager::GetValueTypeInfo(\"{0}\"));", p_Struct.Name);

            m_Indent = m_Indent.Substring(0, m_Indent.Length - 1);
            m_SourceWriter.WriteLine(m_Indent + "}");
            m_SourceWriter.WriteLine();

            // Write cloning functions.
            m_SourceWriter.WriteLine(m_Indent + "::std::unique_ptr<::{0}> {0}::Clone()", p_Struct.Name);
            m_SourceWriter.WriteLine(m_Indent + "{");
            m_SourceWriter.WriteLine(m_Indent + "\treturn ::std::make_unique<{0}>(*m_Data);", p_Struct.Name);
            m_SourceWriter.WriteLine(m_Indent + "}");
            m_SourceWriter.WriteLine();

            // Write constructors.
            m_SourceWriter.WriteLine(m_Indent + "{0}::{0}()", p_Struct.Name);
            m_SourceWriter.WriteLine(m_Indent + "{");
            m_SourceWriter.WriteLine(m_Indent + "\tm_Data = ::allocate_aligned<{0}>();", s_NamespacedName);
            m_SourceWriter.WriteLine(m_Indent + "}");
            m_SourceWriter.WriteLine();
            m_SourceWriter.WriteLine(m_Indent + "{0}::{0}(const ::{0}& p_Other)", p_Struct.Name);
            m_SourceWriter.WriteLine(m_Indent + "{");
            m_SourceWriter.WriteLine(m_Indent + "\tm_Data = p_Other.m_Data;");
            m_SourceWriter.WriteLine(m_Indent + "}");
            m_SourceWriter.WriteLine();
            m_SourceWriter.WriteLine(m_Indent + "{0}::{0}({1}* p_Data)", p_Struct.Name, s_NamespacedName);
            m_SourceWriter.WriteLine(m_Indent + "{");
            m_SourceWriter.WriteLine(m_Indent + "\tm_Data = ::std::shared_ptr<{0}>(p_Data, &::NullDeleter<{0}>);", s_NamespacedName);
            m_SourceWriter.WriteLine(m_Indent + "}");
            m_SourceWriter.WriteLine();
            m_SourceWriter.WriteLine(m_Indent + "{0}::{0}(const {1}& p_Data)", p_Struct.Name, s_NamespacedName);
            m_SourceWriter.WriteLine(m_Indent + "{");
            m_SourceWriter.WriteLine(m_Indent + "\tm_Data = ::allocate_aligned<{0}>(p_Data);", s_NamespacedName);
            m_SourceWriter.WriteLine(m_Indent + "}");
            m_SourceWriter.WriteLine();

            // Write members.
            foreach (var s_Member in p_Struct.Members)
            {
                var s_Type = GetMemberType(s_Member);

                if (string.IsNullOrWhiteSpace(s_Type))
                    continue;

                var s_Pointer = s_Member.MemberType == ContainerMemberType.Container && ContainerManager.HasClass(s_Member.ContainerType);
                var s_WrapData = !IsNativeType(s_Member) && !ContainerManager.HasEnum(s_Member.ContainerType);
                var s_String = s_Member.MemberType == ContainerMemberType.String;

                if (!s_Member.Array)
                {
                    // Write the getter type.
                    m_SourceWriter.Write(m_Indent + (s_WrapData ? "::std::unique_ptr<::{0}> " : "{0} "), s_Type);

                    // Write the getter.
                    m_SourceWriter.WriteLine(s_Member.Name == "YValue" ? "{1}::Get{0}_() const" : "{1}::Get{0}() const", s_Member.Name, p_Struct.Name);
                    m_SourceWriter.WriteLine(m_Indent + "{");

                    m_Indent += "\t";
                    
                    if (s_Pointer)
                    {
                        m_SourceWriter.WriteLine(m_Indent + "if (!m_Data->{0})", s_Member.Name);
                        m_SourceWriter.WriteLine(m_Indent + "\treturn nullptr;");
                        m_SourceWriter.WriteLine();
                    }

                    if (s_WrapData)
                    {
                        if (s_Pointer)
                            m_SourceWriter.WriteLine(m_Indent + "return ::std::make_unique<::{0}>(m_Data->{1});", s_Type, s_Member.Name);
                        else
                            m_SourceWriter.WriteLine(m_Indent + "return ::std::make_unique<::{0}>(&m_Data->{1});", s_Type, s_Member.Name);
                    }
                    else
                    {
                        m_SourceWriter.WriteLine(m_Indent + "return m_Data->{0}{1};", s_Member.Name, s_String ? ".c_str()" : "");
                    }

                    m_Indent = m_Indent.Substring(1);

                    m_SourceWriter.WriteLine(m_Indent + "}");
                    m_SourceWriter.WriteLine();

                    if (s_Pointer)
                    {
                        m_SourceWriter.WriteLine(m_Indent + "void {2}::Set{0}(::{1}* p_Data)", s_Member.Name, s_Type, p_Struct.Name);
                    }
                    else
                    {
                        if (s_WrapData)
                            m_SourceWriter.WriteLine(m_Indent + "void {2}::Set{0}(const ::{1}& p_Data)", s_Member.Name, s_Type, p_Struct.Name);
                        else
                            m_SourceWriter.WriteLine(m_Indent + "void {2}::Set{0}(const {1}& p_Data)", s_Member.Name, s_Type, p_Struct.Name);
                    }

                    m_SourceWriter.WriteLine(m_Indent + "{");

                    m_Indent += "\t";
                    
                    if (s_Pointer)
                    {
                        m_SourceWriter.WriteLine(m_Indent + "m_Data->{0}.replace(p_Data ? p_Data->Get() : nullptr);", s_Member.Name);
                    }
                    else
                    {
                        if (s_WrapData)
                            m_SourceWriter.WriteLine(m_Indent + "m_Data->{0} = *p_Data.Get();", s_Member.Name);
                        else
                            m_SourceWriter.WriteLine(m_Indent + "m_Data->{0} = p_Data;", s_Member.Name);
                    }

                    m_Indent = m_Indent.Substring(1);

                    m_SourceWriter.WriteLine(m_Indent + "}");
                }
                else
                {
                    m_SourceWriter.WriteLine(m_Indent + "::sol::object {0}::Get{1}(::sol::this_state p_State) const", p_Struct.Name, s_Member.Name);
                    m_SourceWriter.WriteLine(m_Indent + "{");

                    m_Indent += "\t";
                    
                    m_SourceWriter.WriteLine(m_Indent + "return ::sol::make_object(p_State, std::ref(m_Data->{0}));", s_Member.Name);

                    m_Indent = m_Indent.Substring(1);

                    m_SourceWriter.WriteLine(m_Indent + "}");
                    m_SourceWriter.WriteLine();
                }

                m_SourceWriter.WriteLine();
            }
        }

        private void WriteSourceEnum(ContainerEnum p_Enum)
        {
            // Write the registration function.
            m_SourceWriter.WriteLine(m_Indent + "void Register{0}(sol::state_view* p_State)", p_Enum.Name);
            m_SourceWriter.WriteLine(m_Indent + "{");
            m_Indent += "\t";

            if (p_Enum.Values.Count > 0)
            {
                m_SourceWriter.WriteLine(m_Indent + "sol::table s_Table = p_State->create_named_table(\"{0}\");", p_Enum.Name);
                m_SourceWriter.WriteLine();

                for (var i = 0; i < p_Enum.Values.Count; ++i)
                {
                    var s_Value = p_Enum.Values[i];
                    m_SourceWriter.WriteLine(m_Indent + "s_Table[\"{0}\"] = {1};", s_Value.Name, s_Value.Value);
                }
            }

            m_Indent = m_Indent.Substring(0, m_Indent.Length - 1);
            m_SourceWriter.WriteLine(m_Indent + "}");
            m_SourceWriter.WriteLine();
        }

        private string GetMemberType(ContainerMember p_Member)
        {
            switch (p_Member.MemberType)
            {
                case ContainerMemberType.Float:
                    return "float";

                case ContainerMemberType.Double:
                    return "double";

                case ContainerMemberType.Bool:
                    return "bool";

                case ContainerMemberType.String:
                    return "std::string";

                case ContainerMemberType.GUID:
                    return "VeniceEXT::Classes::Shared::Guid";

                case ContainerMemberType.SHA1:
                    return "VeniceEXT::Classes::Shared::SHA1";

                case ContainerMemberType.Int64:
                    return "int64_t";

                case ContainerMemberType.UInt64:
                    return "uint64_t";

                case ContainerMemberType.Int32:
                    return "int32_t";

                case ContainerMemberType.UInt32:
                    return "uint32_t";

                case ContainerMemberType.Int16:
                    return "int16_t";

                case ContainerMemberType.UInt16:
                    return "uint16_t";

                case ContainerMemberType.Int8:
                    return "int8_t";

                case ContainerMemberType.UInt8:
                    return "uint8_t";

                case ContainerMemberType.Container:
                    if (ContainerManager.HasEnum(p_Member.ContainerType))
                        return string.Join("::", m_Container.Namespace.Components.Concat(p_Member.ContainerType.Components));

                    if (IsBuiltInType(p_Member))
                        return "VeniceEXT::Classes::Shared::" + p_Member.ContainerType;

                    return p_Member.ContainerType.ToString();

                default:
                    return null;
            }
        }

        private string GetDefaultValue(ContainerMember p_Member)
        {
            switch (p_Member.MemberType)
            {
                case ContainerMemberType.Float:
                    return "0.f";

                case ContainerMemberType.Double:
                    return "0.0";

                case ContainerMemberType.Bool:
                    return "false";

                case ContainerMemberType.String:
                    return "\"\"";

                case ContainerMemberType.Container:
                     return "(::" + string.Join("::", m_Container.Namespace.Components.Concat(p_Member.ContainerType.Components)) + ") 0";

                default:
                    return "0";
            }
        }

        private string GetMemberNativeType(ContainerMember p_Member)
        {
            switch (p_Member.MemberType)
            {
                case ContainerMemberType.Float:
                    return "float";

                case ContainerMemberType.Double:
                    return "double";

                case ContainerMemberType.Bool:
                    return "bool";

                case ContainerMemberType.String:
                    return "::fb::String";

                case ContainerMemberType.GUID:
                    return "::fb::Guid";

                case ContainerMemberType.SHA1:
                    return "::fb::SHA1";

                case ContainerMemberType.Int64:
                    return "int64_t";

                case ContainerMemberType.UInt64:
                    return "uint64_t";

                case ContainerMemberType.Int32:
                    return "int32_t";

                case ContainerMemberType.UInt32:
                    return "uint32_t";

                case ContainerMemberType.Int16:
                    return "int16_t";

                case ContainerMemberType.UInt16:
                    return "uint16_t";

                case ContainerMemberType.Int8:
                    return "int8_t";

                case ContainerMemberType.UInt8:
                    return "uint8_t";

                case ContainerMemberType.Container:
                    return "::" + string.Join("::", m_Container.Namespace.Components.Concat(p_Member.ContainerType.Components));

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

        private static bool IsNativeType(ContainerMember p_Member)
        {
            // HACKHACK: Adding a fake ContainerType for the Guid class.
            if (p_Member.MemberType == ContainerMemberType.GUID)
                p_Member.ContainerType = new ContainerNamespace("Guid");

            switch (p_Member.MemberType)
            {
                case ContainerMemberType.Float:
                case ContainerMemberType.Double:
                case ContainerMemberType.Bool:
                case ContainerMemberType.String:
                case ContainerMemberType.Int64:
                case ContainerMemberType.UInt64:
                case ContainerMemberType.Int32:
                case ContainerMemberType.UInt32:
                case ContainerMemberType.Int16:
                case ContainerMemberType.UInt16:
                case ContainerMemberType.Int8:
                case ContainerMemberType.UInt8:
                    return true;

                default:
                    return false;
            }
        }
    }
}
