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
	public class ClientPlayerInputPlaybackEntityData : 
		EntityData
	{
		[ContainerField(12)]
		public Realm Realm { get; set; } = new Realm(); // 0xC (12)
		
		[ContainerField(16), LayoutImmutable]
		public string FileName { get; set; } // 0x10 (16)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 229961746:
					Realm = (Realm) Enum.ToObject(typeof(Realm), p_Value);
					break;

				case 1134474212:
					FileName = (string) p_Value;
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

				case 1134474212:
					return FileName;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 229961746:
					return typeof(ClientPlayerInputPlaybackEntityData).GetProperty(nameof(Realm));

				case 1134474212:
					return typeof(ClientPlayerInputPlaybackEntityData).GetProperty(nameof(FileName));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
