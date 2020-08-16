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
	public class ProfileEntityData : 
		EntityData
	{
		protected Realm m_Realm = new Realm();
		[ContainerField(12), ContainerFieldNameHash(229961746)]
		public Realm Realm { get { return m_Realm; } set { if (OnPropertyChanging("ProfileEntityData." + nameof(Realm), this, m_Realm, value)) m_Realm = value; } } // 0xC (12)
		
		protected string m_ProfileName = string.Empty;
		[ContainerField(16), LayoutImmutable, ContainerFieldNameHash(1665193641)]
		public string ProfileName { get { return m_ProfileName; } set { if (OnPropertyChanging("ProfileEntityData." + nameof(ProfileName), this, m_ProfileName, value)) m_ProfileName = value; } } // 0x10 (16)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 229961746:
					Realm = (Realm) Enum.ToObject(typeof(Realm), p_Value);
					break;

				case 1665193641:
					ProfileName = (string) p_Value;
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
				case 229961746:
					return Realm;

				case 1665193641:
					return ProfileName;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 229961746:
					return typeof(ProfileEntityData).GetProperty(nameof(Realm));

				case 1665193641:
					return typeof(ProfileEntityData).GetProperty(nameof(ProfileName));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
