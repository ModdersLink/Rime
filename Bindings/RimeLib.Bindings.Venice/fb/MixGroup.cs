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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 16)]
	public class MixGroup : 
		DataContainer
	{
		protected string m_Name = string.Empty;
		[ContainerField(Name: "Name", Offset: 8, NameHash: 2088949890, Flags: 16509), LayoutImmutable]
		public string Name { get { return m_Name; } set { if (OnPropertyChanging("MixGroup." + nameof(Name), this, m_Name, value)) m_Name = value; } } // 0x8 (8)
		
		protected ushort m_GroupIndex = new ushort();
		[ContainerField(Name: "GroupIndex", Offset: 12, NameHash: 1804853668, Flags: 49389), LayoutImmutable, Blittable]
		public ushort GroupIndex { get { return m_GroupIndex; } set { if (OnPropertyChanging("MixGroup." + nameof(GroupIndex), this, m_GroupIndex, value)) m_GroupIndex = value; } } // 0xC (12)
		
		protected ushort m_ParentGroupIndex = new ushort();
		[ContainerField(Name: "ParentGroupIndex", Offset: 14, NameHash: 1896210840, Flags: 49389), LayoutImmutable, Blittable]
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
