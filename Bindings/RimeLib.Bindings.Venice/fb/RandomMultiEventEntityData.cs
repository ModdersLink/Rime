///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class RandomMultiEventEntityData : 
		EntityData
	{
		[ContainerField(12)]
		public Realm Realm { get; set; } = new Realm(); // 0xC (12)
		
		[ContainerField(16)]
		public List<float> RandomEventWeight { get; set; } = new List<float>(); // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public bool UniformDistribution { get; set; } // 0x14 (20)
		
		[ContainerField(21), LayoutImmutable, Blittable]
		public bool ResetOutputsWhenAllHasTriggered { get; set; } // 0x15 (21)
		
		[ContainerField(22), LayoutImmutable, Blittable]
		public bool DisableOutputOnTrigger { get; set; } // 0x16 (22)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 229961746:
					Realm = (Realm) Enum.ToObject(typeof(Realm), p_Value);
					break;

				case 2700434098:
					RandomEventWeight = (List<float>) p_Value;
					break;

				case 3070004891:
					UniformDistribution = (bool) p_Value;
					break;

				case 386838442:
					ResetOutputsWhenAllHasTriggered = (bool) p_Value;
					break;

				case 1250184567:
					DisableOutputOnTrigger = (bool) p_Value;
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

				case 2700434098:
					return RandomEventWeight;

				case 3070004891:
					return UniformDistribution;

				case 386838442:
					return ResetOutputsWhenAllHasTriggered;

				case 1250184567:
					return DisableOutputOnTrigger;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 229961746:
					return typeof(RandomMultiEventEntityData).GetProperty(nameof(Realm));

				case 2700434098:
					return typeof(RandomMultiEventEntityData).GetProperty(nameof(RandomEventWeight));

				case 3070004891:
					return typeof(RandomMultiEventEntityData).GetProperty(nameof(UniformDistribution));

				case 386838442:
					return typeof(RandomMultiEventEntityData).GetProperty(nameof(ResetOutputsWhenAllHasTriggered));

				case 1250184567:
					return typeof(RandomMultiEventEntityData).GetProperty(nameof(DisableOutputOnTrigger));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
