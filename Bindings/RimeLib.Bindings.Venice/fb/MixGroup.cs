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
	[ContainerType(4)]
	public class MixGroup : 
		DataContainer
	{
		protected string m_Name = string.Empty;
		[ContainerField(8), LayoutImmutable, ContainerFieldNameHash(2088949890)]
		public string Name { get { return m_Name; } set { if (OnPropertyChanging("MixGroup." + nameof(Name), this, m_Name, value)) m_Name = value; } } // 0x8 (8)
		
		protected ushort m_GroupIndex = new ushort();
		[ContainerField(12), LayoutImmutable, Blittable, ContainerFieldNameHash(1804853668)]
		public ushort GroupIndex { get { return m_GroupIndex; } set { if (OnPropertyChanging("MixGroup." + nameof(GroupIndex), this, m_GroupIndex, value)) m_GroupIndex = value; } } // 0xC (12)
		
		protected ushort m_ParentGroupIndex = new ushort();
		[ContainerField(14), LayoutImmutable, Blittable, ContainerFieldNameHash(1896210840)]
		public ushort ParentGroupIndex { get { return m_ParentGroupIndex; } set { if (OnPropertyChanging("MixGroup." + nameof(ParentGroupIndex), this, m_ParentGroupIndex, value)) m_ParentGroupIndex = value; } } // 0xE (14)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2088949890:
					Name = (string) p_Value;
					break;

				case 1804853668:
					GroupIndex = (ushort) p_Value;
					break;

				case 1896210840:
					ParentGroupIndex = (ushort) p_Value;
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

				case 1804853668:
					return GroupIndex;

				case 1896210840:
					return ParentGroupIndex;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2088949890:
					return typeof(MixGroup).GetProperty(nameof(Name));

				case 1804853668:
					return typeof(MixGroup).GetProperty(nameof(GroupIndex));

				case 1896210840:
					return typeof(MixGroup).GetProperty(nameof(ParentGroupIndex));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
