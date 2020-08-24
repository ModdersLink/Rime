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
	[ContainerType(4), MemberInfoFlag(41), ContainerStruct]
	public class AimingConstraintsData : FrostbiteContainer
	{
		[ContainerField(0), LayoutImmutable, Blittable, MemberInfoFlag(49469)]
		public float MinYaw { get; set; } // 0x0 (0)
		
		[ContainerField(4), LayoutImmutable, Blittable, MemberInfoFlag(49469)]
		public float MaxYaw { get; set; } // 0x4 (4)
		
		[ContainerField(8), LayoutImmutable, Blittable, MemberInfoFlag(49469)]
		public float MinPitch { get; set; } // 0x8 (8)
		
		[ContainerField(12), LayoutImmutable, Blittable, MemberInfoFlag(49469)]
		public float MaxPitch { get; set; } // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2633709248:
					MinYaw = (float) p_Value;
					break;

				case 2642824094:
					MaxYaw = (float) p_Value;
					break;

				case 3374061353:
					MinPitch = (float) p_Value;
					break;

				case 397101687:
					MaxPitch = (float) p_Value;
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
				case 2633709248:
					return MinYaw;

				case 2642824094:
					return MaxYaw;

				case 3374061353:
					return MinPitch;

				case 397101687:
					return MaxPitch;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2633709248:
					return typeof(AimingConstraintsData).GetProperty(nameof(MinYaw));

				case 2642824094:
					return typeof(AimingConstraintsData).GetProperty(nameof(MaxYaw));

				case 3374061353:
					return typeof(AimingConstraintsData).GetProperty(nameof(MinPitch));

				case 397101687:
					return typeof(AimingConstraintsData).GetProperty(nameof(MaxPitch));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
