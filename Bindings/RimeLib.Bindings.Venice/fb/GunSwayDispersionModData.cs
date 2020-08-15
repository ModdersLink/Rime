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
	public class GunSwayDispersionModData : FrostbiteContainer
	{
		[ContainerField(0), LayoutImmutable, Blittable]
		public float MinAngleModifier { get; set; } // 0x0 (0)
		
		[ContainerField(4), LayoutImmutable, Blittable]
		public float MaxAngleModifier { get; set; } // 0x4 (4)
		
		[ContainerField(8), LayoutImmutable, Blittable]
		public float IncreasePerShotModifier { get; set; } // 0x8 (8)
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public float DecreasePerSecondModifier { get; set; } // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2979224985:
					MinAngleModifier = (float) p_Value;
					break;

				case 2879661127:
					MaxAngleModifier = (float) p_Value;
					break;

				case 1804994481:
					IncreasePerShotModifier = (float) p_Value;
					break;

				case 3869929031:
					DecreasePerSecondModifier = (float) p_Value;
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
				case 2979224985:
					return MinAngleModifier;

				case 2879661127:
					return MaxAngleModifier;

				case 1804994481:
					return IncreasePerShotModifier;

				case 3869929031:
					return DecreasePerSecondModifier;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2979224985:
					return typeof(GunSwayDispersionModData).GetProperty(nameof(MinAngleModifier));

				case 2879661127:
					return typeof(GunSwayDispersionModData).GetProperty(nameof(MaxAngleModifier));

				case 1804994481:
					return typeof(GunSwayDispersionModData).GetProperty(nameof(IncreasePerShotModifier));

				case 3869929031:
					return typeof(GunSwayDispersionModData).GetProperty(nameof(DecreasePerSecondModifier));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
