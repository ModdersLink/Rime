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
        public string Name => "rime";

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

            m_Writer.WriteLine("using RimeLib.IO;");
            m_Writer.WriteLine("using RimeLib.Frostbite.Core;");
            m_Writer.WriteLine("using System;");
            m_Writer.WriteLine("using System.Collections.Generic;");
            m_Writer.WriteLine("using System.Linq;");
			//m_Writer.WriteLine("using Xceed.Wpf.Toolkit.PropertyGrid.Attributes;");
			m_Writer.WriteLine("using System.ComponentModel;");
			m_Writer.WriteLine("using System.Reflection;");
            m_Writer.WriteLine("using RimeLib.Serialization.Attributes;");
            m_Writer.WriteLine("using RimeLib.Serialization.Containers;");
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

            p_Class.Attributes.Remove(s_SizeAttribute);
            p_Class.Attributes.Remove(s_ClassFlags);

            var s_ClassAttributes = string.Join(", ", p_Class.Attributes);

            m_Writer.WriteLine($"{m_Indent}[ContainerType({ (p_Class.Alignment == 0 ? "" : "Alignment: " + p_Class.Alignment + ", ") } Flags: {s_ClassFlags.Parameters.First()}, Size: {s_SizeAttribute.Parameters[0]}){(s_ClassAttributes.Length > 0 ? ", " + s_ClassAttributes : "")}]");

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

                s_Member.Attributes.Remove(s_MemberFlagsAttribute);

                var s_FieldAttributes = string.Join(", ", s_Member.Attributes);

                if (s_Pointer && s_Member.Array)
                {
                    m_Writer.WriteLine($"{m_Indent}protected RefArray<{s_Type}> m_{s_Member.Name} = new RefArray<{s_Type}>();");

                    m_Writer.WriteLine($"{m_Indent}[ContainerField(Name: \"{s_Member.Name}\", Offset: {s_Member.Offset}, NameHash: {fb_hashQuick(s_Member.Name)}, Flags: {s_MemberFlagsAttribute.Parameters[0]}){(s_FieldAttributes.Length > 0 ? ", " + s_FieldAttributes : "")}]");
                    /*m_Writer.Write(m_Indent + "[ContainerField({0})", s_Member.Offset);
                    m_Writer.Write(s_FieldAttributes.Length > 0 ? ", " + s_FieldAttributes : "");
                    m_Writer.WriteLine("]");*/

                    m_Writer.WriteLine(m_Indent + "public RefArray<{2}> {0} {{ get {{ return m_{0}; }} set {{ if (OnPropertyChanging(\"{3}.\" + nameof({0}), this, m_{0}, value)) m_{0} = value; }} }} // 0x{1:X} ({1})", s_Member.Name, s_Member.Offset, s_Type, p_Class.Name);
                }
                else if (s_Pointer && !s_Member.Array)
                {
                    m_Writer.WriteLine($"{m_Indent}protected CtrRef<{s_Type}> m_{s_Member.Name} = new CtrRef<{s_Type}>();");

                    m_Writer.WriteLine($"{m_Indent}[ContainerField(Name: \"{s_Member.Name}\", Offset: {s_Member.Offset}, NameHash: {fb_hashQuick(s_Member.Name)}, Flags: {s_MemberFlagsAttribute.Parameters[0]}){(s_FieldAttributes.Length > 0 ? ", " + s_FieldAttributes : "")}]");

                    /*m_Writer.Write(m_Indent + "[ContainerField({0})", s_Member.Offset);
                    m_Writer.Write(s_FieldAttributes.Length > 0 ? ", " + s_FieldAttributes : "");
                    m_Writer.WriteLine("]");*/
                    m_Writer.WriteLine(m_Indent + "public CtrRef<{2}> {0} {{ get {{ return m_{0}; }} set {{ if (OnPropertyChanging(\"{3}.\" + nameof({0}), this, m_{0}, value)) m_{0} = value; }} }} // 0x{1:X} ({1})", s_Member.Name, s_Member.Offset, s_Type, p_Class.Name);
                }
                else if (!s_Pointer && !s_Member.Array)
                {
                    if (IsPrimitive(s_Member))
                    {
                        switch (s_Type)
                        {
                            case "string":
                                m_Writer.WriteLine($"{m_Indent}protected {s_Type} m_{s_Member.Name} = string.Empty;");
                                break;
                            default:
                                m_Writer.WriteLine($"{m_Indent}protected {s_Type} m_{s_Member.Name} = new {s_Type}();");
                                break;
                        }



                        /*m_Writer.Write(m_Indent + "[ContainerField({0})", s_Member.Offset);
                        m_Writer.Write(s_FieldAttributes.Length > 0 ? ", " + s_FieldAttributes : "");
                        m_Writer.WriteLine("]");*/
                        m_Writer.WriteLine($"{m_Indent}[ContainerField(Name: \"{s_Member.Name}\", Offset: {s_Member.Offset}, NameHash: {fb_hashQuick(s_Member.Name)}, Flags: {s_MemberFlagsAttribute.Parameters[0]}){(s_FieldAttributes.Length > 0 ? ", " + s_FieldAttributes : "")}]");
                        m_Writer.WriteLine(m_Indent + "public {0} {1} {{ get {{ return m_{1}; }} set {{ if (OnPropertyChanging(\"{3}.\" + nameof({1}), this, m_{1}, value)) m_{1} = value; }} }} // 0x{2:X} ({2})", s_Type, s_Member.Name, s_Member.Offset, p_Class.Name);
                    }
                    else
                    {
                        m_Writer.WriteLine($"{m_Indent}protected {s_Type} m_{s_Member.Name} = new {s_Type}();");

                        /*m_Writer.Write(m_Indent + "[ContainerField({0})", s_Member.Offset);
                        m_Writer.Write(s_FieldAttributes.Length > 0 ? ", " + s_FieldAttributes : "");
                        m_Writer.WriteLine("]");*/
                        m_Writer.WriteLine($"{m_Indent}[ContainerField(Name: \"{s_Member.Name}\", Offset: {s_Member.Offset}, NameHash: {fb_hashQuick(s_Member.Name)}, Flags: {s_MemberFlagsAttribute.Parameters[0]}){(s_FieldAttributes.Length > 0 ? ", " + s_FieldAttributes : "")}]");

                        m_Writer.WriteLine(m_Indent + "public {0} {1} {{ get {{ return m_{1}; }} set {{ if (OnPropertyChanging(\"{3}.\" + nameof({1}), this, m_{1}, value)) m_{1} = value; }} }} // 0x{2:X} ({2})", s_Type, s_Member.Name, s_Member.Offset, p_Class.Name);
                    }
                }
                else if (!s_Pointer && s_Member.Array)
                {
                    m_Writer.WriteLine($"{m_Indent}protected List<{s_Type}> m_{s_Member.Name} = new List<{s_Type}>();");

                    /*m_Writer.Write(m_Indent + "[ContainerField({0})", s_Member.Offset);
                    m_Writer.Write(s_FieldAttributes.Length > 0 ? ", " + s_FieldAttributes : "");
                    m_Writer.WriteLine("]");*/
                    m_Writer.WriteLine($"{m_Indent}[ContainerField(Name: \"{s_Member.Name}\", Offset: {s_Member.Offset}, NameHash: {fb_hashQuick(s_Member.Name)}, Flags: {s_MemberFlagsAttribute.Parameters[0]}){(s_FieldAttributes.Length > 0 ? ", " + s_FieldAttributes : "")}]");

                    m_Writer.WriteLine(m_Indent + "public List<{0}> {1} {{ get {{ return m_{1}; }} set {{ if (OnPropertyChanging(\"{3}.\" + nameof({1}), this, m_{1}, value)) m_{1} = value; }} }} // 0x{2:X} ({2})", s_Type, s_Member.Name, s_Member.Offset, p_Class.Name);
                }

                m_Writer.WriteLine(m_Indent);
            }
            

            // Write Bind
            m_Writer.WriteLine(m_Indent + "public override void Bind(FieldDescriptor p_Descriptor, object p_Value)");
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
					    AccumulateModes = (List<MixerValueAccumulateMode>) p_Value;*/
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
            m_Writer.WriteLine(m_Indent + "}");

            // Write class body end
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

            p_Struct.Attributes.Remove(s_SizeAttribute);
            p_Struct.Attributes.Remove(s_MemberInfoFlagsAttribute);

            var s_StructAttributes = string.Join(", ", p_Struct.Attributes);

            m_Writer.WriteLine($"{m_Indent}[ContainerType({ (p_Struct.Alignment == 0 ? "" : "Alignment: " + p_Struct.Alignment + ", ") } Flags: {s_MemberInfoFlagsAttribute.Parameters.First()}, Size: {s_SizeAttribute.Parameters[0]}){(s_StructAttributes.Length > 0 ? ", " + s_StructAttributes : "")}]");

            m_Writer.Write(m_Indent + "public class {0} : FrostbiteContainer", p_Struct.Name);
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

                s_Member.Attributes.Remove(s_MemberFlagsAttribute);

                var s_FieldAttributes = string.Join(", ", s_Member.Attributes);
                m_Writer.WriteLine($"{m_Indent}[ContainerField(Name: \"{s_Member.Name}\", Offset: {s_Member.Offset}, NameHash: {fb_hashQuick(s_Member.Name)}, Flags: {s_MemberFlagsAttribute.Parameters[0]}){(s_FieldAttributes.Length > 0 ? ", " + s_FieldAttributes : "")}]");


                /*m_Writer.Write(m_Indent + "[ContainerField({0})", s_Member.Offset);

				//if (s_Member.MemberType == ContainerMemberType.Container && ContainerManager.HasStruct(s_Member.ContainerType) && !s_Member.Array)
					//m_Writer.Write(", ExpandableObject");

                m_Writer.Write(s_FieldAttributes.Length > 0 ? ", " + s_FieldAttributes : "");
				m_Writer.WriteLine("]");*/

                if (s_Pointer && s_Member.Array)
                {
                    m_Writer.WriteLine(m_Indent + "public RefArray<{2}> {0} {{ get; set; }} = new RefArray<{2}>(); // 0x{1:X} ({1})", s_Member.Name, s_Member.Offset, s_Type);
                }
                else if (s_Pointer && !s_Member.Array)
                {
                    m_Writer.WriteLine(m_Indent + "public CtrRef<{2}> {0} {{ get; set; }} = new CtrRef<{2}>(); // 0x{1:X} ({1})", s_Member.Name, s_Member.Offset, s_Type);
                }
                else if (!s_Pointer && !s_Member.Array)
                {
                    if (IsPrimitive(s_Member))
                        m_Writer.WriteLine(m_Indent + "public {0} {1} {{ get; set; }} // 0x{2:X} ({2})", s_Type, s_Member.Name, s_Member.Offset);
                    else
                        m_Writer.WriteLine(m_Indent + "public {0} {1} {{ get; set; }} = new {0}(); // 0x{2:X} ({2})", s_Type, s_Member.Name, s_Member.Offset);
                }
                else if (!s_Pointer && s_Member.Array)
                {
                    m_Writer.WriteLine(m_Indent + "public List<{0}> {1} {{ get; set; }} = new List<{0}>(); // 0x{2:X} ({2})", s_Type, s_Member.Name, s_Member.Offset);
                }

                m_Writer.WriteLine(m_Indent);
            }

            // Write Bind
            m_Writer.WriteLine(m_Indent + "public override void Bind(FieldDescriptor p_Descriptor, object p_Value)");
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
					    AccumulateModes = (List<MixerValueAccumulateMode>) p_Value;*/
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
            m_Writer.WriteLine(m_Indent + "}");

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

            m_Writer.WriteLine($"{m_Indent}[ContainerType(Flags: {s_MemberInfoFlagsAttribute.Parameters.First()}, Size: {s_SizeAttribute.Parameters[0]} { (p_Enum.Attributes.Count > 0 ? s_EnumAttributes : "") } )]");


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
