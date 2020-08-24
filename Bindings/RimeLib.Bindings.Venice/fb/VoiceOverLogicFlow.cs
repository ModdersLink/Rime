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
using RimeLib.Serialization.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(4), MemberInfoFlag(53), ContainerClass]
	public class VoiceOverLogicFlow : 
		DataContainer
	{
		protected string m_Name = string.Empty;
		[ContainerField(8), LayoutImmutable, MemberInfoFlag(16509), ContainerFieldNameHash(2088949890)]
		public string Name { get { return m_Name; } set { if (OnPropertyChanging("VoiceOverLogicFlow." + nameof(Name), this, m_Name, value)) m_Name = value; } } // 0x8 (8)
		
		protected CtrRef<VoiceOverGroup> m_Group = new CtrRef<VoiceOverGroup>();
		[ContainerField(12), MemberInfoFlag(53), ContainerFieldNameHash(208130522), ContainerCtrRef]
		public CtrRef<VoiceOverGroup> Group { get { return m_Group; } set { if (OnPropertyChanging("VoiceOverLogicFlow." + nameof(Group), this, m_Group, value)) m_Group = value; } } // 0xC (12)
		
		protected RefArray<VoiceOverValue> m_Locals = new RefArray<VoiceOverValue>();
		[ContainerField(16), MemberInfoFlag(65), ContainerFieldNameHash(2904565275), ContainerRefArray]
		public RefArray<VoiceOverValue> Locals { get { return m_Locals; } set { if (OnPropertyChanging("VoiceOverLogicFlow." + nameof(Locals), this, m_Locals, value)) m_Locals = value; } } // 0x10 (16)
		
		protected RefArray<VoiceOverEventNode> m_Roots = new RefArray<VoiceOverEventNode>();
		[ContainerField(20), MemberInfoFlag(65), ContainerFieldNameHash(230317904), ContainerRefArray]
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
