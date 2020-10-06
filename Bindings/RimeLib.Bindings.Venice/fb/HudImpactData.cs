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
	[ContainerType(4), MemberInfoFlag(41), ContainerSize(20), ContainerStruct]
	public class HudImpactData : FrostbiteContainer
	{
		[ContainerField(0), LayoutImmutable, Blittable, MemberInfoFlag(49469)]
		public float MaxHealth { get; set; } // 0x0 (0)
		
		[ContainerField(4), LayoutImmutable, Blittable, MemberInfoFlag(49469)]
		public float MinHealth { get; set; } // 0x4 (4)
		
		[ContainerField(8), LayoutImmutable, Blittable, MemberInfoFlag(49469)]
		public float MaxTimeVisible { get; set; } // 0x8 (8)
		
		[ContainerField(12), LayoutImmutable, Blittable, MemberInfoFlag(49469)]
		public float MinTimeVisible { get; set; } // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable, MemberInfoFlag(49325)]
		public bool Enable { get; set; } // 0x10 (16)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1153188365:
					MaxHealth = (float) p_Value;
					break;

				case 3036033555:
					MinHealth = (float) p_Value;
					break;

				case 3813767306:
					MaxTimeVisible = (float) p_Value;
					break;

				case 3316010964:
					MinTimeVisible = (float) p_Value;
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
				case 1153188365:
					return MaxHealth;

				case 3036033555:
					return MinHealth;

				case 3813767306:
					return MaxTimeVisible;

				case 3316010964:
					return MinTimeVisible;

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
				case 1153188365:
					return typeof(HudImpactData).GetProperty(nameof(MaxHealth));

				case 3036033555:
					return typeof(HudImpactData).GetProperty(nameof(MinHealth));

				case 3813767306:
					return typeof(HudImpactData).GetProperty(nameof(MaxTimeVisible));

				case 3316010964:
					return typeof(HudImpactData).GetProperty(nameof(MinTimeVisible));

				case 2342790116:
					return typeof(HudImpactData).GetProperty(nameof(Enable));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
