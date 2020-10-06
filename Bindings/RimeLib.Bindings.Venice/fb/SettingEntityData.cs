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
	[ContainerType(4), MemberInfoFlag(53), ContainerSize(28), ContainerClass]
	public class SettingEntityData : 
		EntityData
	{
		protected Realm m_Realm = new Realm();
		[ContainerField(12), MemberInfoFlag(137), ContainerFieldNameHash(229961746)]
		public Realm Realm { get { return m_Realm; } set { if (OnPropertyChanging("SettingEntityData." + nameof(Realm), this, m_Realm, value)) m_Realm = value; } } // 0xC (12)
		
		protected string m_BoolSettingName = string.Empty;
		[ContainerField(16), LayoutImmutable, MemberInfoFlag(16509), ContainerFieldNameHash(2857256474)]
		public string BoolSettingName { get { return m_BoolSettingName; } set { if (OnPropertyChanging("SettingEntityData." + nameof(BoolSettingName), this, m_BoolSettingName, value)) m_BoolSettingName = value; } } // 0x10 (16)
		
		protected string m_IntSettingName = string.Empty;
		[ContainerField(20), LayoutImmutable, MemberInfoFlag(16509), ContainerFieldNameHash(2665330183)]
		public string IntSettingName { get { return m_IntSettingName; } set { if (OnPropertyChanging("SettingEntityData." + nameof(IntSettingName), this, m_IntSettingName, value)) m_IntSettingName = value; } } // 0x14 (20)
		
		protected string m_FloatSettingName = string.Empty;
		[ContainerField(24), LayoutImmutable, MemberInfoFlag(16509), ContainerFieldNameHash(3117588292)]
		public string FloatSettingName { get { return m_FloatSettingName; } set { if (OnPropertyChanging("SettingEntityData." + nameof(FloatSettingName), this, m_FloatSettingName, value)) m_FloatSettingName = value; } } // 0x18 (24)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 229961746:
					Realm = (Realm) Enum.ToObject(typeof(Realm), p_Value);
					break;

				case 2857256474:
					BoolSettingName = (string) p_Value;
					break;

				case 2665330183:
					IntSettingName = (string) p_Value;
					break;

				case 3117588292:
					FloatSettingName = (string) p_Value;
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

				case 2857256474:
					return BoolSettingName;

				case 2665330183:
					return IntSettingName;

				case 3117588292:
					return FloatSettingName;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 229961746:
					return typeof(SettingEntityData).GetProperty(nameof(Realm));

				case 2857256474:
					return typeof(SettingEntityData).GetProperty(nameof(BoolSettingName));

				case 2665330183:
					return typeof(SettingEntityData).GetProperty(nameof(IntSettingName));

				case 3117588292:
					return typeof(SettingEntityData).GetProperty(nameof(FloatSettingName));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
