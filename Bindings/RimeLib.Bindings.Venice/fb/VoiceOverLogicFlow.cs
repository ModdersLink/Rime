///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using RimeLib.IO;
using RimeLib.Frostbite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Reflection;
using RimeLib.Serialization.Attributes;
using RimeLib.Frostbite.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(Alignment: 4,  Flags: 53, Size: 24)]
	public class VoiceOverLogicFlow : 
		DataContainer
	{
		protected string m_Name = string.Empty;
		[ContainerField(Name: "Name", Offset: 8, NameHash: 2088949890, Flags: 16509), LayoutImmutable]
		public string Name { get { return m_Name; } set { if (OnPropertyChanging("VoiceOverLogicFlow." + nameof(Name), this, m_Name, value)) m_Name = value; } } // 0x8 (8)
		
		protected CtrRef<VoiceOverGroup> m_Group = new CtrRef<VoiceOverGroup>();
		[ContainerField(Name: "Group", Offset: 12, NameHash: 208130522, Flags: 53)]
		public CtrRef<VoiceOverGroup> Group { get { return m_Group; } set { if (OnPropertyChanging("VoiceOverLogicFlow." + nameof(Group), this, m_Group, value)) m_Group = value; } } // 0xC (12)
		
		protected RefArray<VoiceOverValue> m_Locals = new RefArray<VoiceOverValue>();
		[ContainerField(Name: "Locals", Offset: 16, NameHash: 2904565275, Flags: 65)]
		public RefArray<VoiceOverValue> Locals { get { return m_Locals; } set { if (OnPropertyChanging("VoiceOverLogicFlow." + nameof(Locals), this, m_Locals, value)) m_Locals = value; } } // 0x10 (16)
		
		protected RefArray<VoiceOverEventNode> m_Roots = new RefArray<VoiceOverEventNode>();
		[ContainerField(Name: "Roots", Offset: 20, NameHash: 230317904, Flags: 65)]
		public RefArray<VoiceOverEventNode> Roots { get { return m_Roots; } set { if (OnPropertyChanging("VoiceOverLogicFlow." + nameof(Roots), this, m_Roots, value)) m_Roots = value; } } // 0x14 (20)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2088949890:
					Name = (string) p_Value;
					break;

				case 208130522:
					Group = (CtrRef<VoiceOverGroup>) p_Value;
					break;

				case 2904565275:
					Locals = (RefArray<VoiceOverValue>) p_Value;
					break;

				case 230317904:
					Roots = (RefArray<VoiceOverEventNode>) p_Value;
					break;

				default:
					base.Bind(p_Descriptor, p_Value);
					break;
			}
		}

		public override object GetFieldValueByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2088949890:
					return Name;

				case 208130522:
					return Group;

				case 2904565275:
					return Locals;

				case 230317904:
					return Roots;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2088949890:
					return typeof(VoiceOverLogicFlow).GetProperty(nameof(Name));

				case 208130522:
					return typeof(VoiceOverLogicFlow).GetProperty(nameof(Group));

				case 2904565275:
					return typeof(VoiceOverLogicFlow).GetProperty(nameof(Locals));

				case 230317904:
					return typeof(VoiceOverLogicFlow).GetProperty(nameof(Roots));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
