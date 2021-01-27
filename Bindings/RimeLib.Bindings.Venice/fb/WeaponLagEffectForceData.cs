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
	[ContainerType(Alignment: 16,  Flags: 41, Size: 32)]
	public class WeaponLagEffectForceData : FrostbiteContainer
	{
		[ContainerField(Name: "OffsetForce", Offset: 0, NameHash: 1062756213, Flags: 53289), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 OffsetForce { get; set; } = new Vec3(); // 0x0 (0)
		
		[ContainerField(Name: "RotationForce", Offset: 16, NameHash: 833522092, Flags: 53289), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 RotationForce { get; set; } = new Vec3(); // 0x10 (16)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1062756213:
					OffsetForce = (Vec3) p_Value;
					break;

				case 833522092:
					RotationForce = (Vec3) p_Value;
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
				case 1062756213:
					return OffsetForce;

				case 833522092:
					return RotationForce;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1062756213:
					return typeof(WeaponLagEffectForceData).GetProperty(nameof(OffsetForce));

				case 833522092:
					return typeof(WeaponLagEffectForceData).GetProperty(nameof(RotationForce));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
