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
            m_Writer.WriteLine("using RimeLib.Serialization.Ebx;");

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
            }

            var s_LastInheritedClass = ContainerManager.GetContainerByName(p_Name);

            if (s_LastInheritedClass.GetEnums().Any())
                return 4;

            var s_Attributes = s_LastInheritedClass.GetClasses().Any() ? s_LastInheritedClass.GetClasses().First().Attributes : s_LastInheritedClass.GetStructs().First().Attributes;

            var s_SizeAttribute = s_Attributes.FirstOrDefault(p_Attribute => p_Attribute.Attribute == "ContainerSize");
            return ulong.Parse(s_SizeAttribute.Parameters[0].ToString());
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
                m_Writer.Write(m_Indent + "public abstract class {0}", p_Class.Name);
            else
                m_Writer.Write(m_Indent + "public class {0}", p_Class.Name);

            if (p_Class.InheritedClasses.Count > 0)
                m_Writer.Write(" : ");

            m_Writer.WriteLine();

            // Write inherited classes
            for (var i = 0; i < p_Class.InheritedClasses.Count; ++i)
                m_Writer.WriteLine(m_Indent + "\t{0}{1}", p_Class.InheritedClasses[i], i < p_Class.InheritedClasses.Count - 1 ? "," : "");

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

                m_Writer.WriteLine($"{m_Indent}[ContainerField({s_Member.Offset}){(s_FieldAttributes.Length > 0 ? ", " + s_FieldAttributes : "")}, JsonProperty(Order = {s_Member.Offset})]");

                if (s_Pointer && s_Member.Array)
                {
                    m_Writer.WriteLine($"{m_Indent}public RefArray<{s_Type}> {s_Member.Name} {{ get; set; }} = new();");
                }
                else if (s_Pointer && !s_Member.Array)
                {

                    m_Writer.WriteLine($"{m_Indent}public CtrRef<{s_Type}> {s_Member.Name} {{ get; set; }} = new();");
                }
                else if (!s_Pointer && !s_Member.Array)
                {
                    if (IsPrimitive(s_Member))
                    {
                        switch (s_Type)
                        {
                            case "string":
                                m_Writer.WriteLine($"{m_Indent}public {s_Type} {s_Member.Name} {{ get; set; }} = string.Empty;");
                                break;
                            default:
                                m_Writer.WriteLine($"{m_Indent}public {s_Type} {s_Member.Name} {{ get; set; }}");
                                break;
                        }
                    }
                    else
                    {
                        m_Writer.WriteLine($"{m_Indent}public {s_Type} {s_Member.Name} {{ get; set; }} = new();");
                    }
                }
                else if (!s_Pointer && s_Member.Array)
                {
                    m_Writer.WriteLine($"{m_Indent}public List<{s_Type}> {s_Member.Name} {{ get; set; }} = new();");
                }

                m_Writer.WriteLine();
            }
            
            /*var s_StartOffset = p_Class.InheritedClasses.Any() ? GetSizeOfContainerType(p_Class.InheritedClasses[0].ToString()) : 0;
            WriteDeserializer(p_Class.Name, s_StartOffset, p_Class.Members, GetSizeOfContainerType(p_Class.Name), p_Class.InheritedClasses.Any() ? p_Class.InheritedClasses[0].ToString() : "");*/

            //m_Writer.WriteLine();

            // Write Bind
            /*m_Writer.WriteLine(m_Indent + "public override void Bind(FieldDescriptor p_Descriptor, object p_Value)");
            m_Writer.WriteLine(m_Indent + "{");
            m_Indent += "\t";

            m_Writer.WriteLine(m_Indent + "switch (p_Descriptor.NameHash)");
            m_Writer.WriteLine(m_Indent + "{");
            m_Indent += "\t";

	        bool s_HasMembers = false;

	        for (int i = 0; i < p_Class.Members.Count; i++)
	        {
		        var s_Member = p_Class.Members[i];

		        var s_Type = GetMemberType(s_Member);

		        if (string.IsNullOrWhiteSpace(s_Type))
			        continue;

				if (i != 0)
					m_Writer.WriteLine();

				m_Writer.WriteLine(m_Indent + "case {0}:", fb_hashQuick(s_Member.Name));
				m_Indent += "\t";

				var s_Pointer = s_Member.MemberType == ContainerMemberType.Container &&
								ContainerManager.HasClass(s_Member.ContainerType);
				
				s_HasMembers = true;

		        if (s_Pointer && s_Member.Array)
			        m_Writer.WriteLine(m_Indent + "{0} = (RefArray<{1}>) p_Value;", s_Member.Name, s_Type);
		        else if (s_Pointer && !s_Member.Array)
			        m_Writer.WriteLine(m_Indent + "{0} = (CtrRef<{1}>) p_Value;", s_Member.Name, s_Type);
		        else if (!s_Pointer && !s_Member.Array)
		        {
			        if (ContainerManager.HasEnum(s_Type))
				        m_Writer.WriteLine(m_Indent + "{0} = ({1}) Enum.ToObject(typeof({1}), p_Value);", s_Member.Name, s_Type);
			        else
				        m_Writer.WriteLine(m_Indent + "{0} = ({1}) p_Value;", s_Member.Name, s_Type);
		        }
		        else if (!s_Pointer && s_Member.Array)
		        {
			        /*
                    if (p_Value.GetType() == typeof (List<uint>))
			            AccumulateModes = ((List<uint>) p_Value).Select(x => (MixerValueAccumulateMode) ((int) x)).ToList();
			        else
					    AccumulateModes = (List<MixerValueAccumulateMode>) p_Value;#1#
			        if (ContainerManager.HasEnum(s_Type))
			        {
				        m_Writer.WriteLine(m_Indent + "if (p_Value.GetType() == typeof (List<uint>))");
				        m_Writer.WriteLine(
					        m_Indent + "\t{0} = ((List<uint>) p_Value).Select(x => ({1}) Enum.ToObject(typeof({1}), x)).ToList();",
					        s_Member.Name, s_Type);
				        m_Writer.WriteLine(m_Indent + "else");
				        m_Writer.WriteLine(m_Indent + "\t{0} = (List<{1}>) p_Value;", s_Member.Name, s_Type);
			        }
			        else
			        {
				        m_Writer.WriteLine(m_Indent + "{0} = (List<{1}>) p_Value;", s_Member.Name, s_Type);
			        }
		        }

		        m_Writer.WriteLine(m_Indent + "break;");

		        m_Indent = m_Indent.Substring(0, m_Indent.Length - 1);
	        }

			// Write the default case
	        if (s_HasMembers)
		        m_Writer.WriteLine();

			m_Writer.WriteLine(m_Indent + "default:");
            m_Indent += "\t";
            m_Writer.WriteLine(m_Indent + "base.Bind(p_Descriptor, p_Value);");
            m_Writer.WriteLine(m_Indent + "break;");
            m_Indent = m_Indent.Substring(0, m_Indent.Length - 1);

            // Write end of switch
            m_Indent = m_Indent.Substring(0, m_Indent.Length - 1);
            m_Writer.WriteLine(m_Indent + "}");

            // Write end of bind
            m_Indent = m_Indent.Substring(0, m_Indent.Length - 1);
            m_Writer.WriteLine(m_Indent + "}");
            m_Writer.WriteLine();

            // Write field value lookup.
            m_Writer.WriteLine(m_Indent + "public override object GetFieldValueByHash(uint p_Hash)");
            m_Writer.WriteLine(m_Indent + "{");
            m_Indent += "\t";

            m_Writer.WriteLine(m_Indent + "switch (p_Hash)");
            m_Writer.WriteLine(m_Indent + "{");
            m_Indent += "\t";
            
	        for (int i = 0; i < p_Class.Members.Count; i++)
	        {
		        var s_Member = p_Class.Members[i];

		        var s_Type = GetMemberType(s_Member);

		        if (string.IsNullOrWhiteSpace(s_Type))
			        continue;

				if (i != 0)
					m_Writer.WriteLine();

				m_Writer.WriteLine(m_Indent + "case {0}:", fb_hashQuick(s_Member.Name));
				m_Indent += "\t";
                
		        m_Writer.WriteLine(m_Indent + "return {0};", s_Member.Name);

		        m_Indent = m_Indent.Substring(0, m_Indent.Length - 1);
	        }

			// Write the default case
	        if (s_HasMembers)
		        m_Writer.WriteLine();

			m_Writer.WriteLine(m_Indent + "default:");
            m_Indent += "\t";
            m_Writer.WriteLine(m_Indent + "return base.GetFieldValueByHash(p_Hash);");
            m_Indent = m_Indent.Substring(0, m_Indent.Length - 1);

            // Write end of switch
            m_Indent = m_Indent.Substring(0, m_Indent.Length - 1);
            m_Writer.WriteLine(m_Indent + "}");

            // Write end of field value lookup
            m_Indent = m_Indent.Substring(0, m_Indent.Length - 1);
            m_Writer.WriteLine(m_Indent + "}");
            m_Writer.WriteLine();

            // Write field info lookup.
            m_Writer.WriteLine(m_Indent + "public override PropertyInfo GetFieldInfoByHash(uint p_Hash)");
            m_Writer.WriteLine(m_Indent + "{");
            m_Indent += "\t";

            m_Writer.WriteLine(m_Indent + "switch (p_Hash)");
            m_Writer.WriteLine(m_Indent + "{");
            m_Indent += "\t";
            
	        for (int i = 0; i < p_Class.Members.Count; i++)
	        {
		        var s_Member = p_Class.Members[i];

		        var s_Type = GetMemberType(s_Member);

		        if (string.IsNullOrWhiteSpace(s_Type))
			        continue;

				if (i != 0)
					m_Writer.WriteLine();

				m_Writer.WriteLine(m_Indent + "case {0}:", fb_hashQuick(s_Member.Name));
				m_Indent += "\t";
                
		        m_Writer.WriteLine(m_Indent + "return typeof({0}).GetProperty(nameof({1}));", p_Class.Name, s_Member.Name);

		        m_Indent = m_Indent.Substring(0, m_Indent.Length - 1);
	        }

			// Write the default case
	        if (s_HasMembers)
		        m_Writer.WriteLine();

			m_Writer.WriteLine(m_Indent + "default:");
            m_Indent += "\t";
            m_Writer.WriteLine(m_Indent + "return base.GetFieldInfoByHash(p_Hash);");
            m_Indent = m_Indent.Substring(0, m_Indent.Length - 1);

            // Write end of switch
            m_Indent = m_Indent.Substring(0, m_Indent.Length - 1);
            m_Writer.WriteLine(m_Indent + "}");

            // Write end of field info lookup
            m_Indent = m_Indent.Substring(0, m_Indent.Length - 1);
            m_Writer.WriteLine(m_Indent + "}");*/

            // Write class body end
            m_Indent = m_Indent.Substring(0, m_Indent.Length - 1);
            m_Writer.WriteLine(m_Indent + "}");
        }

        private void WriteDeserializer(string p_ClassName, ulong p_StartOffset, List<ContainerMember> p_Members, ulong p_ClassSize, string p_InheritedType)
        {
            m_Writer.WriteLine($"{m_Indent}public static void Deserialize({p_ClassName} p_Instance, RimeReader p_Reader, IEbxParser p_Parser)");
            m_Writer.WriteLine($"{m_Indent}{{");
            m_Indent += "\t";

            if (!string.IsNullOrEmpty(p_InheritedType))
            {
                m_Writer.WriteLine($"{m_Indent}{p_InheritedType}.Deserialize(p_Instance, p_Reader, p_Parser);");
            }

            var s_CurrentOffset = p_StartOffset;

            foreach (var s_Member in p_Members)
            {
                var s_Pointer = s_Member.MemberType == ContainerMemberType.Container &&
                                ContainerManager.HasClass(s_Member.ContainerType);

                var s_Type = GetMemberType(s_Member);

                if (string.IsNullOrWhiteSpace(s_Type))
                    continue;

                if (s_CurrentOffset > s_Member.Offset)
                    throw new Exception("Offset is off. Bad fbc probably.");

                var s_BytesToSkip = s_Member.Offset - s_CurrentOffset;

                if (s_BytesToSkip > 0)
                {
                    m_Writer.WriteLine($"{m_Indent}p_Reader.Seek({s_BytesToSkip}, SeekOrigin.Current);");
                    s_CurrentOffset += s_BytesToSkip;
                }
                
                if (s_Pointer && s_Member.Array)
                {
                    m_Writer.WriteLine($"{m_Indent}p_Instance.{s_Member.Name}.Clear();");
                    m_Writer.WriteLine($"{m_Indent}(RimeReader Reader, uint Count) s_{s_Member.Name} = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());");
                    m_Writer.WriteLine($"{m_Indent}for (uint i = 0; i < s_{s_Member.Name}.Count; ++i)");
                    m_Writer.WriteLine($"{m_Indent}{{");
                    m_Indent += "\t";
                    m_Writer.WriteLine($"{m_Indent}var s_CtrRef = new CtrRef<{s_Type}>();");
                    m_Writer.WriteLine($"{m_Indent}s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_{s_Member.Name}.Reader.ReadUInt32()));");
                    m_Writer.WriteLine($"{m_Indent}p_Instance.{s_Member.Name}.Add(s_CtrRef);");
                    m_Indent = m_Indent.Substring(0, m_Indent.Length - 1);
                    m_Writer.WriteLine($"{m_Indent}}}");
                    m_Writer.WriteLine($"{m_Indent}");
                    m_Writer.WriteLine($"{m_Indent}s_{s_Member.Name}.Reader.Dispose();");

                    s_CurrentOffset += 4;
                }
                else if (s_Pointer && !s_Member.Array)
                {
                    m_Writer.WriteLine($"{m_Indent}p_Instance.{s_Member.Name}.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));");
                    s_CurrentOffset += 4;
                }
                else if (!s_Pointer && !s_Member.Array)
                {
                    switch (s_Member.MemberType)
                    {
                        case ContainerMemberType.String:
                            m_Writer.WriteLine(
                                $"{m_Indent}p_Instance.{s_Member.Name} = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());"
                            );
                            s_CurrentOffset += 4;
                            break;
                        case ContainerMemberType.Float:
                            m_Writer.WriteLine($"{m_Indent}p_Instance.{s_Member.Name} = p_Reader.ReadSingle();");
                            s_CurrentOffset += 4;
                            break;
                        case ContainerMemberType.Double:
                            m_Writer.WriteLine($"{m_Indent}p_Instance.{s_Member.Name} = p_Reader.ReadDouble();");
                            s_CurrentOffset += 8;
                            break;
                        case ContainerMemberType.Bool:
                            m_Writer.WriteLine($"{m_Indent}p_Instance.{s_Member.Name} = p_Reader.ReadBool();");
                            s_CurrentOffset += 1;
                            break;
                        case ContainerMemberType.Int64:
                            m_Writer.WriteLine($"{m_Indent}p_Instance.{s_Member.Name} = p_Reader.ReadInt64();");
                            s_CurrentOffset += 8;
                            break;
                        case ContainerMemberType.UInt64:
                            m_Writer.WriteLine($"{m_Indent}p_Instance.{s_Member.Name} = p_Reader.ReadUInt64();");
                            s_CurrentOffset += 8;
                            break;
                        case ContainerMemberType.Int32:
                            m_Writer.WriteLine($"{m_Indent}p_Instance.{s_Member.Name} = p_Reader.ReadInt32();");
                            s_CurrentOffset += 4;
                            break;
                        case ContainerMemberType.UInt32:
                            m_Writer.WriteLine($"{m_Indent}p_Instance.{s_Member.Name} = p_Reader.ReadUInt32();");
                            s_CurrentOffset += 4;
                            break;
                        case ContainerMemberType.Int16:
                            m_Writer.WriteLine($"{m_Indent}p_Instance.{s_Member.Name} = p_Reader.ReadInt16();");
                            s_CurrentOffset += 2;
                            break;
                        case ContainerMemberType.UInt16:
                            m_Writer.WriteLine($"{m_Indent}p_Instance.{s_Member.Name} = p_Reader.ReadUInt16();");
                            s_CurrentOffset += 2;
                            break;
                        case ContainerMemberType.Int8:
                            m_Writer.WriteLine($"{m_Indent}p_Instance.{s_Member.Name} = p_Reader.ReadSByte();");
                            s_CurrentOffset += 1;
                            break;
                        case ContainerMemberType.UInt8:
                            m_Writer.WriteLine($"{m_Indent}p_Instance.{s_Member.Name} = p_Reader.ReadUByte();");
                            s_CurrentOffset += 1;
                            break;
                        case ContainerMemberType.GUID:
                            m_Writer.WriteLine($"{m_Indent}p_Instance.{s_Member.Name} = new GUID(p_Reader);");
                            s_CurrentOffset += 16;
                            break;
                        default:
                            if (ContainerManager.HasEnum(s_Type))
                            {
                                m_Writer.WriteLine($"{m_Indent}p_Instance.{s_Member.Name} = ({s_Type}) p_Reader.ReadInt32();");
                                s_CurrentOffset += 4;
                            }
                            else
                            {
                                m_Writer.WriteLine($"{m_Indent}fb.{s_Type}.Deserialize(p_Instance.{s_Member.Name}, p_Reader, p_Parser);");
                                s_CurrentOffset += GetSizeOfContainerType(s_Type);
                            }

                            break;
                    }
                }
                else
                {
                    m_Writer.WriteLine($"{m_Indent}p_Instance.{s_Member.Name}.Clear();");
                    m_Writer.WriteLine($"{m_Indent}(RimeReader Reader, uint Count) s_{s_Member.Name} = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());");
                    m_Writer.WriteLine($"{m_Indent}for (uint i = 0; i < s_{s_Member.Name}.Count; ++i)");
                    m_Writer.WriteLine($"{m_Indent}{{");

                    m_Indent += "\t";

                    switch (s_Member.MemberType)
                    {
                        case ContainerMemberType.String:
                            m_Writer.WriteLine(
                                $"{m_Indent}var s_Value = p_Parser.GetStringAtOffset(s_{s_Member.Name}.Reader.ReadUInt32());"
                            );
                            break;
                        case ContainerMemberType.Float:
                            m_Writer.WriteLine($"{m_Indent}var s_Value = s_{s_Member.Name}.Reader.ReadSingle();");
                            break;
                        case ContainerMemberType.Double:
                            m_Writer.WriteLine($"{m_Indent}var s_Value = s_{s_Member.Name}.Reader.ReadDouble();");
                            break;
                        case ContainerMemberType.Bool:
                            m_Writer.WriteLine($"{m_Indent}var s_Value = s_{s_Member.Name}.Reader.ReadBool();");
                            break;
                        case ContainerMemberType.Int64:
                            m_Writer.WriteLine($"{m_Indent}var s_Value = s_{s_Member.Name}.Reader.ReadInt64();");
                            break;
                        case ContainerMemberType.UInt64:
                            m_Writer.WriteLine($"{m_Indent}var s_Value = s_{s_Member.Name}.Reader.ReadUInt64();");
                            break;
                        case ContainerMemberType.Int32:
                            m_Writer.WriteLine($"{m_Indent}var s_Value = s_{s_Member.Name}.Reader.ReadInt32();");
                            break;
                        case ContainerMemberType.UInt32:
                            m_Writer.WriteLine($"{m_Indent}var s_Value = s_{s_Member.Name}.Reader.ReadUInt32();");
                            break;
                        case ContainerMemberType.Int16:
                            m_Writer.WriteLine($"{m_Indent}var s_Value = s_{s_Member.Name}.Reader.ReadInt16();");
                            break;
                        case ContainerMemberType.UInt16:
                            m_Writer.WriteLine($"{m_Indent}var s_Value = s_{s_Member.Name}.Reader.ReadUInt16();");
                            break;
                        case ContainerMemberType.Int8:
                            m_Writer.WriteLine($"{m_Indent}var s_Value = s_{s_Member.Name}.Reader.ReadSByte();");
                            break;
                        case ContainerMemberType.UInt8:
                            m_Writer.WriteLine($"{m_Indent}var s_Value = s_{s_Member.Name}.Reader.ReadUByte();");
                            break;
                        case ContainerMemberType.GUID:
                            m_Writer.WriteLine($"{m_Indent}var s_Value = new GUID(s_{s_Member.Name}.Reader);");
                            break;
                        default:
                            if (ContainerManager.HasEnum(s_Type))
                            {
                                m_Writer.WriteLine($"{m_Indent}var s_Value = ({s_Type}) s_{s_Member.Name}.Reader.ReadInt32();");
                            }
                            else
                            {
                                m_Writer.WriteLine($"{m_Indent}var s_Value = new {s_Type}();");
                                m_Writer.WriteLine($"{m_Indent}fb.{s_Type}.Deserialize(s_Value, s_{s_Member.Name}.Reader, p_Parser);");
                            }

                            break;
                    }

                    m_Writer.WriteLine($"{m_Indent}p_Instance.{s_Member.Name}.Add(s_Value);");
                    m_Indent = m_Indent.Substring(0, m_Indent.Length - 1);
                    m_Writer.WriteLine($"{m_Indent}}}");
                    m_Writer.WriteLine($"{m_Indent}");
                    m_Writer.WriteLine($"{m_Indent}s_{s_Member.Name}.Reader.Dispose();");

                    s_CurrentOffset += 4;
                }
            }

            var s_LeftClassBytes = p_ClassSize - s_CurrentOffset;

            if (s_LeftClassBytes > 0)
                m_Writer.WriteLine($"{m_Indent}p_Reader.Seek({s_LeftClassBytes}, SeekOrigin.Current);");

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

            m_Writer.Write(m_Indent + "public class {0}", p_Struct.Name);
            m_Writer.WriteLine();

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
                m_Writer.WriteLine($"{m_Indent}[ContainerField({s_Member.Offset}){(s_FieldAttributes.Length > 0 ? ", " + s_FieldAttributes : "")}, JsonProperty(Order = {s_Member.Offset})]");


                /*m_Writer.Write(m_Indent + "[ContainerField({0})", s_Member.Offset);

				//if (s_Member.MemberType == ContainerMemberType.Container && ContainerManager.HasStruct(s_Member.ContainerType) && !s_Member.Array)
					//m_Writer.Write(", ExpandableObject");

                m_Writer.Write(s_FieldAttributes.Length > 0 ? ", " + s_FieldAttributes : "");
				m_Writer.WriteLine("]");*/

                if (s_Pointer && s_Member.Array)
                {
                    m_Writer.WriteLine(m_Indent + "public RefArray<{2}> {0} {{ get; set; }} = new();", s_Member.Name, s_Member.Offset, s_Type);
                }
                else if (s_Pointer && !s_Member.Array)
                {
                    m_Writer.WriteLine(m_Indent + "public CtrRef<{2}> {0} {{ get; set; }} = new();", s_Member.Name, s_Member.Offset, s_Type);
                }
                else if (!s_Pointer && !s_Member.Array)
                {
                    if (IsPrimitive(s_Member))
                    {
                        switch (s_Type)
                        {
                            case "string":
                                m_Writer.WriteLine($"{m_Indent}public {s_Type} {s_Member.Name} {{ get; set; }} = string.Empty;");
                                break;
                            default:
                                m_Writer.WriteLine($"{m_Indent}public {s_Type} {s_Member.Name} {{ get; set; }}");
                                break;
                        }
                    }
                    else
                    {
                        m_Writer.WriteLine(m_Indent + "public {0} {1} {{ get; set; }} = new();", s_Type, s_Member.Name, s_Member.Offset);
                    }
                }
                else if (!s_Pointer && s_Member.Array)
                {
                    m_Writer.WriteLine(m_Indent + "public List<{0}> {1} {{ get; set; }} = new();", s_Type, s_Member.Name, s_Member.Offset);
                }

                m_Writer.WriteLine(m_Indent);
            }
            
            //WriteDeserializer(p_Struct.Name, 0, p_Struct.Members, GetSizeOfContainerType(p_Struct.Name), "");

            // Write Bind
            /*m_Writer.WriteLine(m_Indent + "public override void Bind(FieldDescriptor p_Descriptor, object p_Value)");
            m_Writer.WriteLine(m_Indent + "{");
            m_Indent += "\t";

            m_Writer.WriteLine(m_Indent + "switch (p_Descriptor.NameHash)");
            m_Writer.WriteLine(m_Indent + "{");
            m_Indent += "\t";

	        var s_HasMembers = false;

	        for (int i = 0; i < p_Struct.Members.Count; i++)
	        {
		        var s_Member = p_Struct.Members[i];
		        var s_Type = GetMemberType(s_Member);

		        if (string.IsNullOrWhiteSpace(s_Type))
			        continue;

		        s_HasMembers = true;

				if (i != 0)
					m_Writer.WriteLine();

				m_Writer.WriteLine(m_Indent + "case {0}:", fb_hashQuick(s_Member.Name));
				m_Indent += "\t";

				var s_Pointer = s_Member.MemberType == ContainerMemberType.Container &&
								ContainerManager.HasClass(s_Member.ContainerType);
				
				if (s_Pointer && s_Member.Array)
			        m_Writer.WriteLine(m_Indent + "{0} = (RefArray<{1}>) p_Value;", s_Member.Name, s_Type);
		        else if (s_Pointer && !s_Member.Array)
			        m_Writer.WriteLine(m_Indent + "{0} = (CtrRef<{1}>) p_Value;", s_Member.Name, s_Type);
		        else if (!s_Pointer && !s_Member.Array)
		        {
			        if (ContainerManager.HasEnum(s_Type))
				        m_Writer.WriteLine(m_Indent + "\t{0} = ({1}) Enum.ToObject(typeof({1}), p_Value);", s_Member.Name, s_Type);
			        else
				        m_Writer.WriteLine(m_Indent + "{0} = ({1}) p_Value;", s_Member.Name, s_Type);
		        }
		        else if (!s_Pointer && s_Member.Array)
		        {
			        /*
                    if (p_Value.GetType() == typeof (List<uint>))
			            AccumulateModes = ((List<uint>) p_Value).Select(x => (MixerValueAccumulateMode) ((int) x)).ToList();
			        else
					    AccumulateModes = (List<MixerValueAccumulateMode>) p_Value;#1#
			        if (ContainerManager.HasEnum(s_Type))
			        {
				        m_Writer.WriteLine(m_Indent + "if (p_Value.GetType() == typeof (List<uint>))");
				        m_Writer.WriteLine(
					        m_Indent + "\t{0} = ((List<uint>) p_Value).Select(x => ({1}) Enum.ToObject(typeof({1}), x)).ToList();",
					        s_Member.Name, s_Type);
				        m_Writer.WriteLine(m_Indent + "else");
				        m_Writer.WriteLine(m_Indent + "\t{0} = (List<{1}>) p_Value;", s_Member.Name, s_Type);
			        }
			        else
			        {
				        m_Writer.WriteLine(m_Indent + "{0} = (List<{1}>) p_Value;", s_Member.Name, s_Type);
			        }
		        }

		        m_Writer.WriteLine(m_Indent + "break;");

		        m_Indent = m_Indent.Substring(0, m_Indent.Length - 1);
	        }

	        // Write the default case
	        if (s_HasMembers)
		        m_Writer.WriteLine();

            m_Writer.WriteLine(m_Indent + "default:");
            m_Indent += "\t";
            m_Writer.WriteLine(m_Indent + "base.Bind(p_Descriptor, p_Value);");
            m_Writer.WriteLine(m_Indent + "break;");
            m_Indent = m_Indent.Substring(0, m_Indent.Length - 1);

            // Write end of switch
            m_Indent = m_Indent.Substring(0, m_Indent.Length - 1);
            m_Writer.WriteLine(m_Indent + "}");

            // Write end of bind
            m_Indent = m_Indent.Substring(0, m_Indent.Length - 1);
            m_Writer.WriteLine(m_Indent + "}");
            m_Writer.WriteLine();

            // Write field value lookup.
            m_Writer.WriteLine(m_Indent + "public override object GetFieldValueByHash(uint p_Hash)");
            m_Writer.WriteLine(m_Indent + "{");
            m_Indent += "\t";

            m_Writer.WriteLine(m_Indent + "switch (p_Hash)");
            m_Writer.WriteLine(m_Indent + "{");
            m_Indent += "\t";

            for (int i = 0; i < p_Struct.Members.Count; i++)
            {
                var s_Member = p_Struct.Members[i];

                var s_Type = GetMemberType(s_Member);

                if (string.IsNullOrWhiteSpace(s_Type))
                    continue;

                if (i != 0)
                    m_Writer.WriteLine();

                m_Writer.WriteLine(m_Indent + "case {0}:", fb_hashQuick(s_Member.Name));
                m_Indent += "\t";

                m_Writer.WriteLine(m_Indent + "return {0};", s_Member.Name);

                m_Indent = m_Indent.Substring(0, m_Indent.Length - 1);
            }

            // Write the default case
            if (s_HasMembers)
                m_Writer.WriteLine();

            m_Writer.WriteLine(m_Indent + "default:");
            m_Indent += "\t";
            m_Writer.WriteLine(m_Indent + "return base.GetFieldValueByHash(p_Hash);");
            m_Indent = m_Indent.Substring(0, m_Indent.Length - 1);

            // Write end of switch
            m_Indent = m_Indent.Substring(0, m_Indent.Length - 1);
            m_Writer.WriteLine(m_Indent + "}");

            // Write end of field value lookup
            m_Indent = m_Indent.Substring(0, m_Indent.Length - 1);
            m_Writer.WriteLine(m_Indent + "}");
            m_Writer.WriteLine();

            // Write field info lookup.
            m_Writer.WriteLine(m_Indent + "public override PropertyInfo GetFieldInfoByHash(uint p_Hash)");
            m_Writer.WriteLine(m_Indent + "{");
            m_Indent += "\t";

            m_Writer.WriteLine(m_Indent + "switch (p_Hash)");
            m_Writer.WriteLine(m_Indent + "{");
            m_Indent += "\t";

            for (int i = 0; i < p_Struct.Members.Count; i++)
            {
                var s_Member = p_Struct.Members[i];

                var s_Type = GetMemberType(s_Member);

                if (string.IsNullOrWhiteSpace(s_Type))
                    continue;

                if (i != 0)
                    m_Writer.WriteLine();

                m_Writer.WriteLine(m_Indent + "case {0}:", fb_hashQuick(s_Member.Name));
                m_Indent += "\t";

                m_Writer.WriteLine(m_Indent + "return typeof({0}).GetProperty(nameof({1}));", p_Struct.Name, s_Member.Name);

                m_Indent = m_Indent.Substring(0, m_Indent.Length - 1);
            }

            // Write the default case
            if (s_HasMembers)
                m_Writer.WriteLine();

            m_Writer.WriteLine(m_Indent + "default:");
            m_Indent += "\t";
            m_Writer.WriteLine(m_Indent + "return base.GetFieldInfoByHash(p_Hash);");
            m_Indent = m_Indent.Substring(0, m_Indent.Length - 1);

            // Write end of switch
            m_Indent = m_Indent.Substring(0, m_Indent.Length - 1);
            m_Writer.WriteLine(m_Indent + "}");

            // Write end of field info lookup
            m_Indent = m_Indent.Substring(0, m_Indent.Length - 1);
            m_Writer.WriteLine(m_Indent + "}");*/

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
