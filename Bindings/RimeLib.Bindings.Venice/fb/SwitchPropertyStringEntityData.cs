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
	public class SwitchPropertyStringEntityData : 
		EntityData
	{
		protected List<string> m_StringProperties = new List<string>();
		[ContainerField(12), ContainerFieldNameHash(1548227025)]
		public List<string> StringProperties { get { return m_StringProperties; } set { if (OnPropertyChanging("SwitchPropertyStringEntityData." + nameof(StringProperties), this, m_StringProperties, value)) m_StringProperties = value; } } // 0xC (12)
		
		protected Realm m_Realm = new Realm();
		[ContainerField(16), ContainerFieldNameHash(229961746)]
		public Realm Realm { get { return m_Realm; } set { if (OnPropertyChanging("SwitchPropertyStringEntityData." + nameof(Realm), this, m_Realm, value)) m_Realm = value; } } // 0x10 (16)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1548227025:
					StringProperties = (List<string>) p_Value;
					break;

				case 229961746:
					Realm = (Realm) Enum.ToObject(typeof(Realm), p_Value);
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
				case 1548227025:
					return StringProperties;

				case 229961746:
					return Realm;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1548227025:
					return typeof(SwitchPropertyStringEntityData).GetProperty(nameof(StringProperties));

				case 229961746:
					return typeof(SwitchPropertyStringEntityData).GetProperty(nameof(Realm));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
