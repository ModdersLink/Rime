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
    [ContainerType(16)]
	public class FlagComponentData : 
		ComponentData
	{
		[ContainerField(96)]
		public Realm Realm { get; set; } = new Realm(); // 0x60 (96)
		
		[ContainerField(100)]
		public CtrRef<ObjectBlueprint> Flag_Team1 { get; set; } = new CtrRef<ObjectBlueprint>(); // 0x64 (100)
		
		[ContainerField(104)]
		public CtrRef<ObjectBlueprint> Flag_Team2 { get; set; } = new CtrRef<ObjectBlueprint>(); // 0x68 (104)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 229961746:
					Realm = (Realm) Enum.ToObject(typeof(Realm), p_Value);
					break;

				case 1681649722:
					Flag_Team1 = (CtrRef<ObjectBlueprint>) p_Value;
					break;

				case 1681649721:
					Flag_Team2 = (CtrRef<ObjectBlueprint>) p_Value;
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

				case 1681649722:
					return Flag_Team1;

				case 1681649721:
					return Flag_Team2;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 229961746:
					return typeof(FlagComponentData).GetProperty(nameof(Realm));

				case 1681649722:
					return typeof(FlagComponentData).GetProperty(nameof(Flag_Team1));

				case 1681649721:
					return typeof(FlagComponentData).GetProperty(nameof(Flag_Team2));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
