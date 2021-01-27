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
	[ContainerType(Alignment: 4,  Flags: 41, Size: 12)]
	public class KillWeight : FrostbiteContainer
	{
		[ContainerField(Name: "LowIntenseWeight", Offset: 0, NameHash: 1300601567, Flags: 49469), LayoutImmutable, Blittable]
		public float LowIntenseWeight { get; set; } // 0x0 (0)
		
		[ContainerField(Name: "HighIntenseWeight", Offset: 4, NameHash: 3639379525, Flags: 49469), LayoutImmutable, Blittable]
		public float HighIntenseWeight { get; set; } // 0x4 (4)
		
		[ContainerField(Name: "CoolDownTime", Offset: 8, NameHash: 282296301, Flags: 49469), LayoutImmutable, Blittable]
		public float CoolDownTime { get; set; } // 0x8 (8)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1300601567:
					LowIntenseWeight = (float) p_Value;
					break;

				case 3639379525:
					HighIntenseWeight = (float) p_Value;
					break;

				case 282296301:
					CoolDownTime = (float) p_Value;
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
				case 1300601567:
					return LowIntenseWeight;

				case 3639379525:
					return HighIntenseWeight;

				case 282296301:
					return CoolDownTime;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1300601567:
					return typeof(KillWeight).GetProperty(nameof(LowIntenseWeight));

				case 3639379525:
					return typeof(KillWeight).GetProperty(nameof(HighIntenseWeight));

				case 282296301:
					return typeof(KillWeight).GetProperty(nameof(CoolDownTime));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
