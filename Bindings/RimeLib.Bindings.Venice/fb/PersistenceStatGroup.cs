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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 12)]
	public class PersistenceStatGroup : 
		DataContainer
	{
		protected string m_GroupName = string.Empty;
		[ContainerField(Name: "GroupName", Offset: 8, NameHash: 3178263901, Flags: 16509), LayoutImmutable]
		public string GroupName { get { return m_GroupName; } set { if (OnPropertyChanging("PersistenceStatGroup." + nameof(GroupName), this, m_GroupName, value)) m_GroupName = value; } } // 0x8 (8)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3178263901:
					GroupName = (string) p_Value;
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
				case 3178263901:
					return GroupName;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3178263901:
					return typeof(PersistenceStatGroup).GetProperty(nameof(GroupName));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
