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
	public class Strengths : FrostbiteContainer
	{
		[ContainerField(0), LayoutImmutable, Blittable]
		public float Infantry { get; set; } // 0x0 (0)
		
		[ContainerField(4), LayoutImmutable, Blittable]
		public float LightArmour { get; set; } // 0x4 (4)
		
		[ContainerField(8), LayoutImmutable, Blittable]
		public float HeavyArmour { get; set; } // 0x8 (8)
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public float Helicopter { get; set; } // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3732923988:
					Infantry = (float) p_Value;
					break;

				case 539448013:
					LightArmour = (float) p_Value;
					break;

				case 779698192:
					HeavyArmour = (float) p_Value;
					break;

				case 3980345330:
					Helicopter = (float) p_Value;
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
				case 3732923988:
					return Infantry;

				case 539448013:
					return LightArmour;

				case 779698192:
					return HeavyArmour;

				case 3980345330:
					return Helicopter;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3732923988:
					return typeof(Strengths).GetProperty(nameof(Infantry));

				case 539448013:
					return typeof(Strengths).GetProperty(nameof(LightArmour));

				case 779698192:
					return typeof(Strengths).GetProperty(nameof(HeavyArmour));

				case 3980345330:
					return typeof(Strengths).GetProperty(nameof(Helicopter));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
