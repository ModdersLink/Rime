using System.Collections.Generic;
using System.IO;
using System.Security.Policy;
using FBCC.Containers;
using FBCC.Managers;

namespace FBCC.Generators
{
#if DEBUG
    class NativeGenerator : IGenerator
    {
        public string Name { get { return "fb"; } }

        private StringWriter m_Writer;

        private FrostbiteContainer m_Container;

        private string m_Indent;

        public Dictionary<string, string> Generate(FrostbiteContainer p_Container)
        {
            var s_GeneratedFiles = new Dictionary<string, string>();

            if (p_Container.Definitions.Count == 0)
                return s_GeneratedFiles;

            m_Container = p_Container;

            m_Writer = new StringWriter();

            WriteDisclaimer();
            WriteHeader();

            m_Writer.Flush();
            s_GeneratedFiles.Add(p_Container.Name + ".h", m_Writer.ToString());

            m_Writer.Dispose();
            m_Container = null;

            return s_GeneratedFiles;
        }

        private void WriteDisclaimer()
        {
            m_Writer.WriteLine("///////////////////////////////////////////////////////////////");
            m_Writer.WriteLine("//                                                           //");
            m_Writer.WriteLine("// This is an automatically generated file.                  //");
            m_Writer.WriteLine("// Do *NOT* modify unless you really know what you're doing. //");
            m_Writer.WriteLine("//                                                           //");
            m_Writer.WriteLine("///////////////////////////////////////////////////////////////");
            m_Writer.WriteLine();
        }

        private void WriteHeader()
        {
            m_Indent = "";

            m_Writer.WriteLine("#pragma once");
            m_Writer.WriteLine();

            // Write the include for the TypeInfoManager and the builtin types.
            m_Writer.WriteLine("#include \"BuiltinTypes.h\"");
            m_Writer.WriteLine("#include \"TypeInfoManager.h\"");
            m_Writer.WriteLine();

            // Collect includes.
            var s_Includes = new HashSet<string>();
            var s_PreDefinitions = new HashSet<string>();

            foreach (var s_Definition in m_Container.Definitions)
            {
                if (s_Definition.DefinitionType == ContainerDefinitionType.Class)
                {
                    var s_Class = (ContainerClass)s_Definition;
                    
                    foreach (var s_InheritedClass in s_Class.InheritedClasses)
                        s_Includes.Add(s_InheritedClass.Components[s_InheritedClass.Components.Count - 1]);

                    foreach (var s_Member in s_Class.Members)
                    {
                        if (s_Member.MemberType != ContainerMemberType.Container)
                            continue;

                        if (ContainerManager.HasStruct(s_Member.ContainerType) || ContainerManager.HasEnum(s_Member.ContainerType))
                            s_Includes.Add(s_Member.ContainerType.Components[s_Member.ContainerType.Components.Count - 1]);
                        else
                            s_PreDefinitions.Add(s_Member.ContainerType.Components[s_Member.ContainerType.Components.Count - 1]);
                    }

                    continue;
                }

                if (s_Definition.DefinitionType == ContainerDefinitionType.Struct)
                {
                    var s_Struct = (ContainerStruct)s_Definition;
                    
                    foreach (var s_Member in s_Struct.Members)
                    {
                        if (s_Member.MemberType != ContainerMemberType.Container)
                            continue;

                        if (ContainerManager.HasStruct(s_Member.ContainerType) || ContainerManager.HasEnum(s_Member.ContainerType))
                            s_Includes.Add(s_Member.ContainerType.Components[s_Member.ContainerType.Components.Count - 1]);
                        else
                            s_PreDefinitions.Add(s_Member.ContainerType.Components[s_Member.ContainerType.Components.Count - 1]);
                    }

                    continue;
                }
            }

            // Write the includes.
            foreach (var s_Include in s_Includes)
                m_Writer.WriteLine("#include \"{0}.h\"", s_Include);

            if (s_Includes.Count > 0)
                m_Writer.WriteLine();
            
            // Write class/struct pre-definitions.
            // TODO: Change assumption that classes are always in the fb namespace.
            if (s_PreDefinitions.Count > 0)
            {
                m_Writer.WriteLine(m_Indent + "namespace fb");
                m_Writer.WriteLine(m_Indent + "{");
                m_Indent += "\t";

                foreach (var s_PreDefinition in s_PreDefinitions)
                    m_Writer.WriteLine(m_Indent + "class " + s_PreDefinition + ";");
                
                m_Indent = m_Indent.Substring(0, m_Indent.Length - 1);
                m_Writer.WriteLine(m_Indent + "}");
                m_Writer.WriteLine();
            }

            /*// Write the includes.
            foreach (var s_Include in m_Container.Includes)
                m_Writer.WriteLine("#include \"{0}.h\"", s_Include);

            m_Writer.WriteLine();*/

            // Write namespace start.
            foreach (var s_Namespace in m_Container.Namespace.Components)
            {
                m_Writer.WriteLine(m_Indent + "namespace {0}", s_Namespace);
                m_Writer.WriteLine(m_Indent + "{");
                m_Indent += "\t";
            }

            // Write definitions.
            foreach (var s_Definition in m_Container.Definitions)
            {
                switch (s_Definition.DefinitionType)
                {
                    case ContainerDefinitionType.Class:
                        WriteClass((ContainerClass) s_Definition);
                        break;

                    case ContainerDefinitionType.Struct:
                        WriteStruct((ContainerStruct) s_Definition);
                        break;

                    default:
                        WriteEnum((ContainerEnum) s_Definition);
                        break;
                }
            }

            // Write namespace end.
            foreach (var s_Namespace in m_Container.Namespace.Components)
            {
                m_Indent = m_Indent.Substring(0, m_Indent.Length - 1);
                m_Writer.WriteLine(m_Indent + "}");
            }
        }

        private void WriteClass(ContainerClass p_Class)
        {
            m_Writer.Write(m_Indent + "class alignas({0}) {1}", p_Class.Alignment, p_Class.Name);

            if (p_Class.InheritedClasses.Count > 0)
                m_Writer.Write(" :");

            m_Writer.WriteLine();

            // Write inherited classes.
            for (var i = 0; i < p_Class.InheritedClasses.Count; ++i)
                m_Writer.WriteLine(m_Indent + "\tpublic {0}{1}", p_Class.InheritedClasses[i], i < p_Class.InheritedClasses.Count - 1 ? "," : "");

            // Write class body start.
            m_Writer.WriteLine(m_Indent + "{");
            m_Writer.WriteLine(m_Indent + "public:");
            m_Indent += "\t";

            // Write virtual TypeInfo getter.

            m_Writer.WriteLine(m_Indent + "virtual ::fb::TypeInfo* getType() override {{ return (::fb::TypeInfo*) ::fb::TypeInfoManager::GetClassTypeInfo(\"{0}\"); }}", p_Class.Name);
            m_Writer.WriteLine();

            // Write the static instance creator.
            m_Writer.WriteLine(m_Indent + "static inline {0}* CreateInstance(::fb::MemoryArena* p_MemoryArena, bool p_MakeRoomForGUID = false)", p_Class.Name);
		    m_Writer.WriteLine(m_Indent + "{");

            m_Indent += "\t";

            m_Writer.WriteLine(m_Indent + "if (!p_MemoryArena)");
            m_Writer.WriteLine(m_Indent + "\treturn nullptr;");
            m_Writer.WriteLine();
            m_Writer.WriteLine(m_Indent + "::fb::ClassInfo* s_TypeInfo = ::fb::TypeInfoManager::GetClassTypeInfo(\"{0}\");", p_Class.Name);
			m_Writer.WriteLine();
			m_Writer.WriteLine(m_Indent + "if (!s_TypeInfo)");
			m_Writer.WriteLine(m_Indent + "\treturn nullptr;");
            m_Writer.WriteLine();
            m_Writer.WriteLine(m_Indent + "::fb::ClassInfo::TypeInfoData* s_Data = (::fb::ClassInfo::TypeInfoData*) s_TypeInfo->GetData();");
            m_Writer.WriteLine();
			m_Writer.WriteLine(m_Indent + "if (!s_Data || !s_Data->createFun)");
			m_Writer.WriteLine(m_Indent + "\treturn nullptr;");
            m_Writer.WriteLine();
			m_Writer.WriteLine(m_Indent + "void* s_Result = nullptr;");
            m_Writer.WriteLine(m_Indent + "return ({0}*) s_Data->createFun(s_Result, p_MemoryArena, p_MakeRoomForGUID);", p_Class.Name);

            m_Indent = m_Indent.Substring(0, m_Indent.Length - 1);

            m_Writer.WriteLine(m_Indent + "}");
            m_Writer.WriteLine();

            // Write members.
            m_Writer.WriteLine(m_Indent.Substring(0, m_Indent.Length - 1) + "public:");

            foreach (var s_Member in p_Class.Members)
            {
                var s_Pointer = s_Member.MemberType == ContainerMemberType.Container &&
                                ContainerManager.HasClass(s_Member.ContainerType);

                var s_Type = GetMemberType(s_Member);

                if (string.IsNullOrWhiteSpace(s_Type))
                    continue;

                // Write the type.
                if (s_Member.Array)
                {
                    m_Writer.Write(m_Indent + (s_Pointer ? "::fb::RefArray<{0}> " : "::fb::Array<{0}> "), s_Type);
                }
                else
                {
                    if (s_Type == "ResourceRef")
                        m_Writer.Write(m_Indent + "::fb::ResourceRef ");
                    else
                        m_Writer.Write(m_Indent + (s_Pointer ? "::fb::CtrRef<{0}> " : "{0} "), s_Type);
                }

                // Write the member name and offset.
                m_Writer.WriteLine("m_{0}; // 0x{1:X} ({1})", s_Member.Name, s_Member.Offset);
            }

            // Write class body end.
            m_Indent = m_Indent.Substring(0, m_Indent.Length - 1);
            m_Writer.WriteLine(m_Indent + "};");
            m_Writer.WriteLine();
        }


        private void WriteStruct(ContainerStruct p_Struct)
        {
            m_Writer.WriteLine(m_Indent + "struct alignas({0}) {1}", p_Struct.Alignment, p_Struct.Name);

            // Write struct body start.
            m_Writer.WriteLine(m_Indent + "{");
            m_Indent += "\t";

            // Write the new/delete operators.
            m_Writer.WriteLine(m_Indent + "void* operator new(size_t p_Size)");
            m_Writer.WriteLine(m_Indent + "{");
            m_Writer.WriteLine(m_Indent + "\treturn _aligned_malloc(p_Size, {0});", p_Struct.Alignment);
            m_Writer.WriteLine(m_Indent + "}");
            m_Writer.WriteLine();
            m_Writer.WriteLine(m_Indent + "void operator delete(void* p_Pointer)");
            m_Writer.WriteLine(m_Indent + "{");
            m_Writer.WriteLine(m_Indent + "\t_aligned_free(p_Pointer);");
            m_Writer.WriteLine(m_Indent + "}");
            m_Writer.WriteLine();
            m_Writer.WriteLine(m_Indent + "void* operator new(size_t p_Size, fb::MemoryArena& p_Arena)");
            m_Writer.WriteLine(m_Indent + "{");
            m_Writer.WriteLine(m_Indent + "\treturn fb::MemoryArena::alloc(&p_Arena, p_Size, {0});", p_Struct.Alignment);
            m_Writer.WriteLine(m_Indent + "}");
            m_Writer.WriteLine();
            m_Writer.WriteLine(m_Indent + "void operator delete(void* p_Pointer, fb::MemoryArena& p_Arena)");
            m_Writer.WriteLine(m_Indent + "{");
            m_Writer.WriteLine(m_Indent + "\tfb::MemoryArena::free(&p_Arena, p_Pointer);");
            m_Writer.WriteLine(m_Indent + "}");
            m_Writer.WriteLine();

            // Write members.
            foreach (var s_Member in p_Struct.Members)
            {
                var s_Pointer = s_Member.MemberType == ContainerMemberType.Container &&
                                ContainerManager.HasClass(s_Member.ContainerType);

                var s_Type = GetMemberType(s_Member);

                if (string.IsNullOrWhiteSpace(s_Type))
                    continue;

                // Write the type.
                if (s_Member.Array)
                {
                    m_Writer.Write(m_Indent + (s_Pointer ? "::fb::RefArray<{0}> " : "::fb::Array<{0}> "), s_Type);
                }
                else
                {
                    if (s_Type == "ResourceRef")
                        m_Writer.Write(m_Indent + "::fb::ResourceRef ");
                    else
                        m_Writer.Write(m_Indent + (s_Pointer ? "::fb::CtrRef<{0}> " : "{0} "), s_Type);
                }

                // Write the member name and offset.
                m_Writer.WriteLine("{0}; // 0x{1:X} ({1})", s_Member.Name, s_Member.Offset);
            }

            // Write struct body end.
            m_Indent = m_Indent.Substring(0, m_Indent.Length - 1);
            m_Writer.WriteLine(m_Indent + "};");
            m_Writer.WriteLine();
        }

        private void WriteEnum(ContainerEnum p_Enum)
        {
            var s_Type = GetEnumType(p_Enum);

            m_Writer.WriteLine(m_Indent + "enum {0} : {1}", p_Enum.Name, s_Type);

            // Write enum body start.
            m_Writer.WriteLine(m_Indent + "{");
            m_Indent += "\t";

            // Write values.
            for (var i = 0; i < p_Enum.Values.Count; i++)
            {
                var s_Value = p_Enum.Values[i];
                m_Writer.WriteLine(m_Indent + "{0} = {1}{2}", s_Value.Name, s_Value.Value, i < p_Enum.Values.Count - 1 ? "," : "");
            }

            // Write enum body end.
            m_Indent = m_Indent.Substring(0, m_Indent.Length - 1);
            m_Writer.WriteLine(m_Indent + "};");
            m_Writer.WriteLine();
        }

        private static string GetMemberType(ContainerMember p_Member)
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
                    return p_Member.ContainerType.ToString();

                default:
                    return null;
            }
        }

        private static string GetEnumType(ContainerEnum p_Enum)
        {
            switch (p_Enum.EnumType)
            {
                case ContainerEnumType.Int64:
                    return "int64_t";

                case ContainerEnumType.UInt64:
                    return "uint64_t";

                case ContainerEnumType.Int32:
                    return "int32_t";

                case ContainerEnumType.UInt32:
                    return "uint32_t";

                case ContainerEnumType.Int16:
                    return "int16_t";

                case ContainerEnumType.UInt16:
                    return "uint16_t";

                case ContainerEnumType.Int8:
                    return "int8_t";

                case ContainerEnumType.UInt8:
                    return "uint8_t";

                default:
                    return null;
            }
        }
    }
#endif
}
