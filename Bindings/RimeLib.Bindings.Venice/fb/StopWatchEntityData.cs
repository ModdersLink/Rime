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
	public class StopWatchEntityData : 
		EntityData
	{
		[ContainerField(12)]
		public Realm Realm { get; set; } = new Realm(); // 0xC (12)
		
		[ContainerField(16)]
		public UpdatePass UpdatePass { get; set; } = new UpdatePass(); // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public float Multiplier { get; set; } // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public float TriggerOnTime { get; set; } // 0x18 (24)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 229961746:
					Realm = (Realm) Enum.ToObject(typeof(Realm), p_Value);
					break;

				case 2270785669:
					UpdatePass = (UpdatePass) Enum.ToObject(typeof(UpdatePass), p_Value);
					break;

				case 2037512782:
					Multiplier = (float) p_Value;
					break;

				case 2068878889:
					TriggerOnTime = (float) p_Value;
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

				case 2270785669:
					return UpdatePass;

				case 2037512782:
					return Multiplier;

				case 2068878889:
					return TriggerOnTime;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 229961746:
					return typeof(StopWatchEntityData).GetProperty(nameof(Realm));

				case 2270785669:
					return typeof(StopWatchEntityData).GetProperty(nameof(UpdatePass));

				case 2037512782:
					return typeof(StopWatchEntityData).GetProperty(nameof(Multiplier));

				case 2068878889:
					return typeof(StopWatchEntityData).GetProperty(nameof(TriggerOnTime));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
