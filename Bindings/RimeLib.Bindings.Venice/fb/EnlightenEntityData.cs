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
	public class EnlightenEntityData : 
		EntityData
	{
		[ContainerField(12), LayoutImmutable, Blittable]
		public int Priority { get; set; } // 0xC (12)
		
		[ContainerField(16)]
		public Realm Realm { get; set; } = new Realm(); // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public bool Enable { get; set; } // 0x14 (20)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3062102871:
					Priority = (int) p_Value;
					break;

				case 229961746:
					Realm = (Realm) Enum.ToObject(typeof(Realm), p_Value);
					break;

				case 2342790116:
					Enable = (bool) p_Value;
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
				case 3062102871:
					return Priority;

				case 229961746:
					return Realm;

				case 2342790116:
					return Enable;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3062102871:
					return typeof(EnlightenEntityData).GetProperty(nameof(Priority));

				case 229961746:
					return typeof(EnlightenEntityData).GetProperty(nameof(Realm));

				case 2342790116:
					return typeof(EnlightenEntityData).GetProperty(nameof(Enable));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
