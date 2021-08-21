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
	[ContainerType(Alignment: 4,  Flags: 41, Size: 16)]
	public class HealerData : FrostbiteContainer
	{
		[ContainerField(Name: "Radius", Offset: 0, NameHash: 3298407133, Flags: 49469), LayoutImmutable, Blittable]
		public float Radius { get; set; } // 0x0 (0)
		
		[ContainerField(Name: "Health", Offset: 4, NameHash: 3054337113, Flags: 49469), LayoutImmutable, Blittable]
		public float Health { get; set; } // 0x4 (4)
		
		[ContainerField(Name: "HealingTime", Offset: 8, NameHash: 2185013264, Flags: 49469), LayoutImmutable, Blittable]
		public float HealingTime { get; set; } // 0x8 (8)
		
		[ContainerField(Name: "PickUpDelay", Offset: 12, NameHash: 4199077092, Flags: 49469), LayoutImmutable, Blittable]
		public float PickUpDelay { get; set; } // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3298407133:
					Radius = (float) p_Value;
					break;

				case 3054337113:
					Health = (float) p_Value;
					break;

				case 2185013264:
					HealingTime = (float) p_Value;
					break;

				case 4199077092:
					PickUpDelay = (float) p_Value;
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
				case 3298407133:
					return Radius;

				case 3054337113:
					return Health;

				case 2185013264:
					return HealingTime;

				case 4199077092:
					return PickUpDelay;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3298407133:
					return typeof(HealerData).GetProperty(nameof(Radius));

				case 3054337113:
					return typeof(HealerData).GetProperty(nameof(Health));

				case 2185013264:
					return typeof(HealerData).GetProperty(nameof(HealingTime));

				case 4199077092:
					return typeof(HealerData).GetProperty(nameof(PickUpDelay));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
