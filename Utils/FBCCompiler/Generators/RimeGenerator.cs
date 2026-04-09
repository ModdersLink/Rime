using System;
using System.Collections.Generic;
using FBCC.Containers;
using System.IO;
using FBCC.Managers;
using Antlr4.Runtime.Misc;
using System.Linq;

namespace FBCC.Generators
{
    class RimeGenerator : IGenerator
    {
        public string Name => "fb";

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

            s_GeneratedFiles.Add(p_Container.Name + ".cs", m_Writer.ToString());

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

            m_Writer.WriteLine("using System;");
            m_Writer.WriteLine("using System.IO;");
            m_Writer.WriteLine("using System.Collections.Generic;");
            m_Writer.WriteLine("using Newtonsoft.Json;");
            m_Writer.WriteLine("using RimeLib.IO;");
            m_Writer.WriteLine("using RimeLib.Frostbite.Core;");
            m_Writer.WriteLine("using RimeLib.Serialization.Attributes;");
            m_Writer.WriteLine("using RimeLib.Serialization;");
            m_Writer.WriteLine("using RimeLib.Serialization.Frostbite2_0.Ebx;");
            m_Writer.WriteLine("using CommunityToolkit.Mvvm.ComponentModel;");

            m_Writer.WriteLine(m_Indent);

            // Write namespace start
            foreach (var s_Namespace in m_Container.Namespace.Components)
            {
                m_Writer.WriteLine(m_Indent + "namespace {0}", s_Namespace);
                m_Writer.WriteLine(m_Indent + "{");
                m_Indent += "\t";
            }
			
            // Write definitions
            foreach (var s_Definition in m_Container.Definitions)
            {
                switch (s_Definition.DefinitionType)
                {
                    case ContainerDefinitionType.Class:
                        WriteClass((ContainerClass)s_Definition);
                        break;
						
                    case ContainerDefinitionType.Struct:
                        WriteStruct((ContainerStruct)s_Definition);
                        break;

                    case ContainerDefinitionType.Enum:
                        WriteEnum((ContainerEnum)s_Definition);
                        break;
                }
            }

            // Write namespace end
            foreach (var s_Namespace in m_Container.Namespace.Components)
            {
                m_Indent = m_Indent.Substring(0, m_Indent.Length - 1);
                m_Writer.WriteLine(m_Indent + "}");
            }
        }

        private static uint fb_hashQuick(string p_String)
        {
            const uint FNV_OFFSET_BASIS = 0x1505;
            const uint FNV_PRIME = 0x21;

            var s_Hash = FNV_OFFSET_BASIS;

            for (int i = 0; i < p_String.Length; ++i)
                s_Hash = (s_Hash * FNV_PRIME) ^ p_String[i];

            return s_Hash;
        }

        //private static int FNVHash(string p_String)
        //{
        //    const int FNV_OFFSET_BASIS = 0x1505;
        //    const int FNV_PRIME = 0x21;

        //    var s_Hash = FNV_OFFSET_BASIS;

        //    for (int i = 0; i < p_String.Length; ++i)
        //        s_Hash = (s_Hash * FNV_PRIME) ^ p_String[i];

        //    return s_Hash;
        //}

        private ulong GetSizeOfContainerType(string p_Name)
        {
            switch (p_Name)
            {
                case "GUID":
                    return 16;
                case "Vec2":
                    return 8;
                case "Vec3":
                case "Vec4":
                    return 16;
                case "DataContainer":
                    return 0;
                case "AxisAlignedBox":
                    return 32;
                case "FileRef":
                    return 4;
                case "LinearTransform":
                    return 64;
            }

            var s_LastInheritedClass = ContainerManager.GetContainerByName(p_Name);

            if (s_LastInheritedClass.GetEnums().Any())
                return 4;

            var s_Attributes = s_LastInheritedClass.GetClasses().Any() ? s_LastInheritedClass.GetClasses().First().Attributes : s_LastInheritedClass.GetStructs().First().Attributes;

            var s_SizeAttribute = s_Attributes.FirstOrDefault(p_Attribute => p_Attribute.Attribute == "ContainerSize");
            return ulong.Parse(s_SizeAttribute.Parameters[0].ToString());
        }

        private bool HasMembers(IEnumerable<string> p_ClassNames, string p_MemberName)
        {
            return p_ClassNames.Any(p_ClassName => HasMember(p_ClassName, p_MemberName));
        }

        private bool HasMember(string p_ClassName, string p_MemberName)
        {
            var s_Container = ContainerManager.GetContainerByName(p_ClassName);

            if (s_Container == null)
                return false;

            var s_Class = s_Container.GetClasses().FirstOrDefault(p_Class => p_Class.Name == p_ClassName);

            if (s_Class != null)
            {
                foreach (var s_InheritedClass in s_Class.InheritedClasses)
                    if (HasMember(s_InheritedClass.Components.Last(), p_MemberName))
                        return true;
                
                return s_Class.Members.Any(p_Member => p_Member.Name == p_MemberName);
            }

            return false;
        }
        
        private void WriteClass(ContainerClass p_Class)
        {
            var s_SizeAttribute = p_Class.Attributes.FirstOrDefault(p_Attribute => p_Attribute.Attribute == "ContainerSize");
            var s_ClassFlags = p_Class.Attributes.FirstOrDefault(p_Attribute => p_Attribute.Attribute == "MemberInfoFlag");

            if (s_SizeAttribute == null || s_ClassFlags == null)
            {
                // Invalid
                throw new System.Exception("Why is this happening");
            }

            if (s_ClassFlags.Parameters.Count < 1)
                throw new System.Exception("Not enough member info flag parameters.");

            if (s_SizeAttribute.Parameters.Count < 1)
                throw new System.Exception("not enough size parameters.");

            var s_ClassAttributes = string.Join(", ", p_Class.Attributes.Except(new[] { s_SizeAttribute, s_ClassFlags }));

            m_Writer.WriteLine(m_Indent + "[ContainerType({0}, {1}){2}]",
                p_Class.Alignment, s_SizeAttribute.Parameters[0],
                s_ClassAttributes.Length > 0 ? ", " + s_ClassAttributes : "");

            if (p_Class.Name == "DataContainer")
                m_Writer.Write(m_Indent + "public abstract partial class {0}", p_Class.Name);
            else
                m_Writer.Write(m_Indent + "public partial class {0}", p_Class.Name);

            if (p_Class.Name == "DataContainer")
            {
                if (p_Class.InheritedClasses.Count > 0)
                    throw new Exception("DataContainer class definition has inherited types. This is unsupported.");

                m_Writer.WriteLine(" :");
                m_Writer.WriteLine($"{m_Indent}\tEbxSerializable");
            }
            else
            {
                if (p_Class.InheritedClasses.Count > 0)
                    m_Writer.Write(" :");

                m_Writer.WriteLine();

                // Write inherited classes
                for (var i = 0; i < p_Class.InheritedClasses.Count; ++i)
                    m_Writer.WriteLine(m_Indent + "\t{0}{1}", p_Class.InheritedClasses[i], i < p_Class.InheritedClasses.Count - 1 ? "," : "");
            }

            // Write class body start
            m_Writer.WriteLine(m_Indent + "{");
            m_Indent += "\t";

            if (p_Class.Name == "DataContainer")
            {
                m_Writer.WriteLine($"{m_Indent}[JsonProperty(\"$type\", Order = -2)]");
                m_Writer.WriteLine($"{m_Indent}public string TypeName => GetType().Name;");
            }

            // Write members
            foreach (var s_Member in p_Class.Members)
            {
                var s_Pointer = s_Member.MemberType == ContainerMemberType.Container &&
                                ContainerManager.HasClass(s_Member.ContainerType);

                var s_Type = GetMemberType(s_Member);

                if (string.IsNullOrWhiteSpace(s_Type))
                    continue;

                //var s_NameHashAttribute = s_Member.Attributes.FirstOrDefault(p_Attribute => p_Attribute.Attribute == "ContainerFieldNameHash");
                var s_MemberFlagsAttribute = s_Member.Attributes.FirstOrDefault(p_Attribute => p_Attribute.Attribute == "MemberInfoFlag");

                if (s_MemberFlagsAttribute == null)
                {
                    // Invalid
                    throw new System.Exception("Why is this happening");
                }

                if (s_MemberFlagsAttribute.Parameters.Count < 1)
                    throw new System.Exception("Not enough member info flag parameters.");
                
                var s_FieldAttributes = string.Join(", ", s_Member.Attributes.Except(new[] { s_MemberFlagsAttribute }));
                
                var s_MemberName = s_Member.Name;

                // Check if a child class has a member with the same name.
                var s_InheritedClasses = p_Class.InheritedClasses.Select(p_Namespace => p_Namespace.Components.Last()).ToList();

                while (HasMembers(s_InheritedClasses, s_MemberName))
                    s_MemberName += "_";

                var s_CustomNameProperty = "";

                if (s_MemberName != s_Member.Name)
                {
                    s_CustomNameProperty = $", Name = \"{s_Member.Name}\"";
                }
                
                m_Writer.WriteLine($"{m_Indent}[ObservableProperty]");
                m_Writer.WriteLine($"{m_Indent}[property: ContainerField({s_Member.Offset}{s_CustomNameProperty}){(s_FieldAttributes.Length > 0 ? ", " + s_FieldAttributes : "")}, JsonProperty(Order = {s_Member.Offset})]");

                if (s_Pointer && s_Member.Array)
                {
                    m_Writer.WriteLine($"{m_Indent}private RefArray<{s_Type}> _{s_MemberName} = new();");
                }
                else if (s_Pointer && !s_Member.Array)
                {
                    m_Writer.WriteLine($"{m_Indent}private CtrRef<{s_Type}> _{s_MemberName} = new();");
                }
                else if (!s_Pointer && !s_Member.Array)
                {
                    if (IsPrimitive(s_Member))
                    {
                        switch (s_Type)
                        {
                            case "string":
                                m_Writer.WriteLine($"{m_Indent}private {s_Type} _{s_MemberName} = string.Empty;");
                                break;
                            case "GUID":
                                m_Writer.WriteLine($"{m_Indent}private {s_Type} _{s_MemberName} = GUID.Empty;");
                                break;
                            default:
                                m_Writer.WriteLine($"{m_Indent}private {s_Type} _{s_MemberName};");
                                break;
                        }
                    }
                    else
                    {
                        m_Writer.WriteLine($"{m_Indent}private {s_Type} _{s_MemberName} = new();");
                    }
                }
                else if (!s_Pointer && s_Member.Array)
                {
                    m_Writer.WriteLine($"{m_Indent}private List<{s_Type}> _{s_MemberName} = new();");
                }

                m_Writer.WriteLine();
            }
            
            var s_StartOffset = p_Class.InheritedClasses.Any() ? GetSizeOfContainerType(p_Class.InheritedClasses[0].ToString()) : 0;
            WriteSerializer(s_StartOffset, p_Class.Members, GetSizeOfContainerType(p_Class.Name), p_Class);

            // Write class body end
            m_Indent = m_Indent.Substring(0, m_Indent.Length - 1);
            m_Writer.WriteLine(m_Indent + "}");
        }

        private void WriteSerializer(ulong p_StartOffset, List<ContainerMember> p_Members, ulong p_ClassSize, ContainerClass? p_Class)
        {
            m_Writer.WriteLine($"{m_Indent}public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)");
            m_Writer.WriteLine($"{m_Indent}{{");
            m_Indent += "\t";
            m_Writer.WriteLine($"{m_Indent}base.Serialize(p_Writer, p_EbxWriter);");

            var s_CurrentOffset = p_StartOffset;

            foreach (var s_Member in p_Members)
            {
                var s_Pointer = s_Member.MemberType == ContainerMemberType.Container &&
                                ContainerManager.HasClass(s_Member.ContainerType);

                var s_Type = GetMemberType(s_Member);

                if (string.IsNullOrWhiteSpace(s_Type))
                    continue;

                var s_MemberName = s_Member.Name;
                
                // Check if a child class has a member with the same name.
                var s_InheritedClasses = p_Class == null ? new List<string>() : p_Class.InheritedClasses.Select(p_Namespace => p_Namespace.Components.Last()).ToList();

                while (HasMembers(s_InheritedClasses, s_MemberName))
                    s_MemberName += "_";
                
                if (s_CurrentOffset > s_Member.Offset)
                    throw new Exception("Offset is off. Bad fbc probably.");

                var s_BytesToSkip = s_Member.Offset - s_CurrentOffset;

                if (s_BytesToSkip > 0)
                {
                    m_Writer.WriteLine($"{m_Indent}p_Writer.WriteNullBytes({s_BytesToSkip});");
                    s_CurrentOffset += s_BytesToSkip;
                }
                
                if (s_Pointer && s_Member.Array)
                {
                    m_Writer.WriteLine($"{m_Indent}(RimeWriter Writer, uint ArrayIndex) s_{s_MemberName} = p_EbxWriter.GetArrayWriter({s_MemberName}.GetType(), {s_MemberName}.Count);");
                    m_Writer.WriteLine($"{m_Indent}p_Writer.Write(s_{s_MemberName}.ArrayIndex);");

                    m_Writer.WriteLine($"{m_Indent}foreach (var s_Entry in {s_MemberName})");
                    m_Writer.WriteLine($"{m_Indent}{{");

                    m_Indent += "\t";

                    m_Writer.WriteLine($"{m_Indent}s_{s_MemberName}.Writer.Write(p_EbxWriter.WriteImport(s_Entry));");

                    m_Indent = m_Indent.Substring(0, m_Indent.Length - 1);
                    m_Writer.WriteLine($"{m_Indent}}}");

                    s_CurrentOffset += 4;
                }
                else if (s_Pointer && !s_Member.Array)
                {
                    // CtrRef
                    m_Writer.WriteLine($"{m_Indent}p_Writer.Write(p_EbxWriter.WriteImport({s_MemberName}));");
                    s_CurrentOffset += 4;
                }
                else if (!s_Pointer && !s_Member.Array)
                {
                    switch (s_Member.MemberType)
                    {
                        case ContainerMemberType.String:
                            m_Writer.WriteLine($"{m_Indent}p_Writer.Write(p_EbxWriter.WriteString({s_MemberName}));");
                            s_CurrentOffset += 4;
                            break;
                        case ContainerMemberType.Float:
                            m_Writer.WriteLine($"{m_Indent}p_Writer.Write({s_MemberName});");
                            s_CurrentOffset += 4;
                            break;
                        case ContainerMemberType.Double:
                            m_Writer.WriteLine($"{m_Indent}p_Writer.Write({s_MemberName});");
                            s_CurrentOffset += 8;
                            break;
                        case ContainerMemberType.Bool:
                            m_Writer.WriteLine($"{m_Indent}p_Writer.Write({s_MemberName});");
                            s_CurrentOffset += 1;
                            break;
                        case ContainerMemberType.Int64:
                            m_Writer.WriteLine($"{m_Indent}p_Writer.Write({s_MemberName});");
                            s_CurrentOffset += 8;
                            break;
                        case ContainerMemberType.UInt64:
                            m_Writer.WriteLine($"{m_Indent}p_Writer.Write({s_MemberName});");
                            s_CurrentOffset += 8;
                            break;
                        case ContainerMemberType.Int32:
                            m_Writer.WriteLine($"{m_Indent}p_Writer.Write({s_MemberName});");
                            s_CurrentOffset += 4;
                            break;
                        case ContainerMemberType.UInt32:
                            m_Writer.WriteLine($"{m_Indent}p_Writer.Write({s_MemberName});");
                            s_CurrentOffset += 4;
                            break;
                        case ContainerMemberType.Int16:
                            m_Writer.WriteLine($"{m_Indent}p_Writer.Write({s_MemberName});");
                            s_CurrentOffset += 2;
                            break;
                        case ContainerMemberType.UInt16:
                            m_Writer.WriteLine($"{m_Indent}p_Writer.Write({s_MemberName});");
                            s_CurrentOffset += 2;
                            break;
                        case ContainerMemberType.Int8:
                            m_Writer.WriteLine($"{m_Indent}p_Writer.Write({s_MemberName});");
                            s_CurrentOffset += 1;
                            break;
                        case ContainerMemberType.UInt8:
                            m_Writer.WriteLine($"{m_Indent}p_Writer.Write({s_MemberName});");
                            s_CurrentOffset += 1;
                            break;
                        case ContainerMemberType.GUID:
                            m_Writer.WriteLine($"{m_Indent}{s_MemberName}.Serialize(p_Writer);");
                            s_CurrentOffset += 16;
                            break;
                        default:
                            if (ContainerManager.HasEnum(s_Type))
                            {
                                m_Writer.WriteLine($"{m_Indent}p_Writer.Write((int) {s_MemberName});");
                                s_CurrentOffset += 4;
                            }
                            else
                            {
                                m_Writer.WriteLine($"{m_Indent}{s_MemberName}.Serialize(p_Writer, p_EbxWriter);");
                                s_CurrentOffset += GetSizeOfContainerType(s_Type);
                            }

                            break;
                    }
                }
                else
                {
                    // Array of values.
                    m_Writer.WriteLine($"{m_Indent}(RimeWriter Writer, uint ArrayIndex) s_{s_MemberName} = p_EbxWriter.GetArrayWriter({s_MemberName}.GetType(), {s_MemberName}.Count);");
                    m_Writer.WriteLine($"{m_Indent}p_Writer.Write(s_{s_MemberName}.ArrayIndex);");

                    m_Writer.WriteLine($"{m_Indent}foreach (var s_Entry in {s_MemberName})");
                    m_Writer.WriteLine($"{m_Indent}{{");

                    m_Indent += "\t";

                    switch (s_Member.MemberType)
                    {
                        case ContainerMemberType.String:
                            m_Writer.WriteLine($"{m_Indent}s_{s_MemberName}.Writer.Write(p_EbxWriter.WriteString(s_Entry));");
                            break;
                        case ContainerMemberType.Float:
                        case ContainerMemberType.Double:
                        case ContainerMemberType.Bool:
                        case ContainerMemberType.Int64:
                        case ContainerMemberType.UInt64:
                        case ContainerMemberType.Int32:
                        case ContainerMemberType.UInt32:
                        case ContainerMemberType.Int16:
                        case ContainerMemberType.UInt16:
                        case ContainerMemberType.Int8:
                        case ContainerMemberType.UInt8:
                            m_Writer.WriteLine($"{m_Indent}s_{s_MemberName}.Writer.Write(s_Entry);");
                            break;
                        case ContainerMemberType.GUID:
                            m_Writer.WriteLine($"{m_Indent}s_Entry.Serialize(s_{s_MemberName}.Writer);");
                            break;
                        default:
                            if (ContainerManager.HasEnum(s_Type))
                                m_Writer.WriteLine($"{m_Indent}s_{s_MemberName}.Writer.Write((int) s_Entry);");
                            else
                                m_Writer.WriteLine($"{m_Indent}s_Entry.Serialize(s_{s_MemberName}.Writer, p_EbxWriter);");

                            break;
                    }
                    
                    m_Indent = m_Indent.Substring(0, m_Indent.Length - 1);
                    m_Writer.WriteLine($"{m_Indent}}}");

                    s_CurrentOffset += 4;
                }
            }

            var s_LeftClassBytes = p_ClassSize - s_CurrentOffset;

            if (s_LeftClassBytes > 0)
                m_Writer.WriteLine($"{m_Indent}p_Writer.WriteNullBytes({s_LeftClassBytes});");

            m_Indent = m_Indent.Substring(0, m_Indent.Length - 1);
            m_Writer.WriteLine(m_Indent + "}");
        }

        private void WriteStruct(ContainerStruct p_Struct)
		{
            var s_SizeAttribute = p_Struct.Attributes.FirstOrDefault(p_Attribute => p_Attribute.Attribute == "ContainerSize");
            var s_MemberInfoFlagsAttribute = p_Struct.Attributes.FirstOrDefault(p_Attribute => p_Attribute.Attribute == "MemberInfoFlag");

            if (s_SizeAttribute == null || s_MemberInfoFlagsAttribute == null)
            {
                // Invalid
                throw new System.Exception("Why is this happening");
            }

            if (s_MemberInfoFlagsAttribute.Parameters.Count < 1)
                throw new System.Exception("Not enough member info flag parameters.");

            if (s_SizeAttribute.Parameters.Count < 1)
                throw new System.Exception("not enough size parameters.");
            
            var s_StructAttributes = string.Join(", ", p_Struct.Attributes.Except(new[] { s_SizeAttribute, s_MemberInfoFlagsAttribute }));

            m_Writer.WriteLine($"{m_Indent}[ContainerType({p_Struct.Alignment}, {s_SizeAttribute.Parameters[0]}){(s_StructAttributes.Length > 0 ? ", " + s_StructAttributes : "")}]");

            m_Writer.Write(m_Indent + "public partial class {0}", p_Struct.Name);
            m_Writer.WriteLine(" :");
            m_Writer.WriteLine($"{m_Indent}\tEbxSerializable");

            // Write class body start
            m_Writer.WriteLine(m_Indent + "{");
            m_Indent += "\t";

            // Write members
            foreach (var s_Member in p_Struct.Members)
            {
                var s_Pointer = s_Member.MemberType == ContainerMemberType.Container &&
                                ContainerManager.HasClass(s_Member.ContainerType);


                var s_Type = GetMemberType(s_Member);

                if (string.IsNullOrWhiteSpace(s_Type))
                    continue;

                //var s_NameHashAttribute = s_Member.Attributes.FirstOrDefault(p_Attribute => p_Attribute.Attribute == "ContainerFieldNameHash");
                var s_MemberFlagsAttribute = s_Member.Attributes.FirstOrDefault(p_Attribute => p_Attribute.Attribute == "MemberInfoFlag");

                if (s_MemberFlagsAttribute == null)
                {
                    // Invalid
                    throw new System.Exception("Why is this happening");
                }

                if (s_MemberFlagsAttribute.Parameters.Count < 1)
                    throw new System.Exception("not enough size parameters.");

                var s_FieldAttributes = string.Join(", ", s_Member.Attributes.Except(new [] {s_MemberFlagsAttribute }));
                m_Writer.WriteLine($"{m_Indent}[ObservableProperty]");
                m_Writer.WriteLine($"{m_Indent}[property: ContainerField({s_Member.Offset}){(s_FieldAttributes.Length > 0 ? ", " + s_FieldAttributes : "")}, JsonProperty(Order = {s_Member.Offset})]");


                /*m_Writer.Write(m_Indent + "[ContainerField({0})", s_Member.Offset);

				//if (s_Member.MemberType == ContainerMemberType.Container && ContainerManager.HasStruct(s_Member.ContainerType) && !s_Member.Array)
					//m_Writer.Write(", ExpandableObject");

                m_Writer.Write(s_FieldAttributes.Length > 0 ? ", " + s_FieldAttributes : "");
				m_Writer.WriteLine("]");*/

                if (s_Pointer && s_Member.Array)
                {
                    m_Writer.WriteLine(m_Indent + "private RefArray<{2}> _{0} = new();", s_Member.Name, s_Member.Offset, s_Type);
                }
                else if (s_Pointer && !s_Member.Array)
                {
                    m_Writer.WriteLine(m_Indent + "private CtrRef<{2}> _{0} = new();", s_Member.Name, s_Member.Offset, s_Type);
                }
                else if (!s_Pointer && !s_Member.Array)
                {
                    if (IsPrimitive(s_Member))
                    {
                        switch (s_Type)
                        {
                            case "string":
                                m_Writer.WriteLine($"{m_Indent}private {s_Type} _{s_Member.Name} = string.Empty;");
                                break;
                            case "GUID":
                                m_Writer.WriteLine($"{m_Indent}private {s_Type} _{s_Member.Name} = GUID.Empty;");
                                break;
                            default:
                                m_Writer.WriteLine($"{m_Indent}private {s_Type} _{s_Member.Name};");
                                break;
                        }
                    }
                    else
                    {
                        m_Writer.WriteLine(m_Indent + "private {0} _{1} = new();", s_Type, s_Member.Name, s_Member.Offset);
                    }
                }
                else if (!s_Pointer && s_Member.Array)
                {
                    m_Writer.WriteLine(m_Indent + "private List<{0}> _{1} = new();", s_Type, s_Member.Name, s_Member.Offset);
                }

                m_Writer.WriteLine(m_Indent);
            }

            WriteSerializer(0, p_Struct.Members, GetSizeOfContainerType(p_Struct.Name), null);

            // Write class body end
            m_Indent = m_Indent.Substring(0, m_Indent.Length - 1);
            m_Writer.WriteLine(m_Indent + "}");
        }

        private void WriteEnum(ContainerEnum p_Enum)
        {
            var s_Type = GetEnumType(p_Enum);

            var s_SizeAttribute = p_Enum.Attributes.FirstOrDefault(p_Attribute => p_Attribute.Attribute == "ContainerSize");
            var s_MemberInfoFlagsAttribute = p_Enum.Attributes.FirstOrDefault(p_Attribute => p_Attribute.Attribute == "MemberInfoFlag");

            if (s_SizeAttribute == null || s_MemberInfoFlagsAttribute == null)
            {
                // Invalid
                throw new System.Exception("Why is this happening");
            }

            if (s_MemberInfoFlagsAttribute.Parameters.Count < 1)
                throw new System.Exception("Not enough member info flag parameters.");

            if (s_SizeAttribute.Parameters.Count < 1)
                throw new System.Exception("not enough size parameters.");

            p_Enum.Attributes.Remove(s_SizeAttribute);
            p_Enum.Attributes.Remove(s_MemberInfoFlagsAttribute);

            var s_EnumAttributes = string.Join(", ", p_Enum.Attributes);

            m_Writer.WriteLine($"{m_Indent}[ContainerType(4, 4){(s_EnumAttributes.Length > 0 ? ", " + s_EnumAttributes : "")}]");


            m_Writer.WriteLine(m_Indent + "public enum {0} : {1}", p_Enum.Name, s_Type);

            // Write enum body start.
            m_Writer.WriteLine(m_Indent + "{");
            m_Indent += "\t";

            // Write values.
            for (var i = 0; i < p_Enum.Values.Count; i++)
            {
                var s_Value = p_Enum.Values[i];

				var s_ValueAttributes = string.Join(", ", s_Value.Attributes);

	            if (s_ValueAttributes.Length > 0)
	            {
		            if (i != 0)
			            m_Writer.WriteLine();

					m_Writer.WriteLine(m_Indent + "[" + s_ValueAttributes + "]");
	            }

				m_Writer.WriteLine(m_Indent + "{0} = {1}{2}", s_Value.Name, s_Value.Value, i < p_Enum.Values.Count - 1 ? "," : "");
            }

            // Write enum body end.
            m_Indent = m_Indent.Substring(0, m_Indent.Length - 1);
            m_Writer.WriteLine(m_Indent + "}");
            m_Writer.WriteLine();

        }

        private static bool IsPrimitive(ContainerMember p_Member)
        {
            switch (p_Member.MemberType)
            {
                case ContainerMemberType.Float:
                case ContainerMemberType.Double:
                case ContainerMemberType.Bool:
                case ContainerMemberType.String:
                case ContainerMemberType.GUID:
                case ContainerMemberType.SHA1:
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
                    return "string";

                case ContainerMemberType.GUID:
                    return "GUID";

                case ContainerMemberType.SHA1:
                    return "Sha1";

                case ContainerMemberType.Int64:
                    return "long";

                case ContainerMemberType.UInt64:
                    return "ulong";

                case ContainerMemberType.Int32:
                    return "int";

                case ContainerMemberType.UInt32:
                    return "uint";

                case ContainerMemberType.Int16:
                    return "short";

                case ContainerMemberType.UInt16:
                    return "ushort";

                case ContainerMemberType.Int8:
                    return "sbyte";

                case ContainerMemberType.UInt8:
                    return "byte";

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
                    return "long";

                case ContainerEnumType.UInt64:
                    return "ulong";

                case ContainerEnumType.Int32:
                    return "int";

                case ContainerEnumType.UInt32:
                    return "uint";

                case ContainerEnumType.Int16:
                    return "short";

                case ContainerEnumType.UInt16:
                    return "ushort";

                case ContainerEnumType.Int8:
                    return "sbyte";

                case ContainerEnumType.UInt8:
                    return "byte";

                default:
                    return null;
            }
        }
    }
}
