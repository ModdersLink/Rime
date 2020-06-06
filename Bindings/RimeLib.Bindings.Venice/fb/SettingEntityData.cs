///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class SettingEntityData : 
		EntityData
	{
		[ContainerField(12)]
		public Realm Realm { get; set; } = new Realm(); // 0xC (12)
		
		[ContainerField(16), LayoutImmutable]
		public string BoolSettingName { get; set; } // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable]
		public string IntSettingName { get; set; } // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable]
		public string FloatSettingName { get; set; } // 0x18 (24)
		
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
