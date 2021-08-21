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
	[ContainerType(Alignment: 4,  Flags: 41, Size: 12)]
	public class SphereCollisionData : FrostbiteContainer
	{
		[ContainerField(Name: "ExtraRadius", Offset: 0, NameHash: 3555352615, Flags: 49469), LayoutImmutable, Blittable]
		public float ExtraRadius { get; set; } // 0x0 (0)
		
		[ContainerField(Name: "CounterNormalBrakeForceMod", Offset: 4, NameHash: 2290320390, Flags: 49469), LayoutImmutable, Blittable]
		public float CounterNormalBrakeForceMod { get; set; } // 0x4 (4)
		
		[ContainerField(Name: "Enabled", Offset: 8, NameHash: 2662400, Flags: 49325), LayoutImmutable, Blittable]
		public bool Enabled { get; set; } // 0x8 (8)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3555352615:
					ExtraRadius = (float) p_Value;
					break;

				case 2290320390:
					CounterNormalBrakeForceMod = (float) p_Value;
					break;

				case 2662400:
					Enabled = (bool) p_Value;
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
				case 3555352615:
					return ExtraRadius;

				case 2290320390:
					return CounterNormalBrakeForceMod;

				case 2662400:
					return Enabled;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3555352615:
					return typeof(SphereCollisionData).GetProperty(nameof(ExtraRadius));

				case 2290320390:
					return typeof(SphereCollisionData).GetProperty(nameof(CounterNormalBrakeForceMod));

				case 2662400:
					return typeof(SphereCollisionData).GetProperty(nameof(Enabled));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
