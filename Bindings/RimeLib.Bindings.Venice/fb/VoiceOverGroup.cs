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
	[ContainerType(4), MemberInfoFlag(53), ContainerSize(16), ContainerClass]
	public class VoiceOverGroup : 
		DataContainer
	{
		protected string m_Name = string.Empty;
		[ContainerField(8), LayoutImmutable, MemberInfoFlag(16509), ContainerFieldNameHash(2088949890)]
		public string Name { get { return m_Name; } set { if (OnPropertyChanging("VoiceOverGroup." + nameof(Name), this, m_Name, value)) m_Name = value; } } // 0x8 (8)
		
		protected int m_Priority = new int();
		[ContainerField(12), LayoutImmutable, Blittable, MemberInfoFlag(49405), ContainerFieldNameHash(3062102871)]
		public int Priority { get { return m_Priority; } set { if (OnPropertyChanging("VoiceOverGroup." + nameof(Priority), this, m_Priority, value)) m_Priority = value; } } // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2088949890:
					Name = (string) p_Value;
					break;

				case 3062102871:
					Priority = (int) p_Value;
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

				case 3062102871:
					return Priority;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2088949890:
					return typeof(VoiceOverGroup).GetProperty(nameof(Name));

				case 3062102871:
					return typeof(VoiceOverGroup).GetProperty(nameof(Priority));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
