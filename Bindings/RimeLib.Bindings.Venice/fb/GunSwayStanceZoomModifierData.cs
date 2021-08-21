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
	[ContainerType(Alignment: 4,  Flags: 41, Size: 32)]
	public class GunSwayStanceZoomModifierData : FrostbiteContainer
	{
		[ContainerField(Name: "DispersionMod", Offset: 0, NameHash: 3711909665, Flags: 41)]
		public GunSwayDispersionModData DispersionMod { get; set; } = new GunSwayDispersionModData(); // 0x0 (0)
		
		[ContainerField(Name: "RecoilMagnitudeMod", Offset: 16, NameHash: 370335921, Flags: 49469), LayoutImmutable, Blittable]
		public float RecoilMagnitudeMod { get; set; } // 0x10 (16)
		
		[ContainerField(Name: "RecoilAngleMod", Offset: 20, NameHash: 1763796860, Flags: 49469), LayoutImmutable, Blittable]
		public float RecoilAngleMod { get; set; } // 0x14 (20)
		
		[ContainerField(Name: "LagYawMod", Offset: 24, NameHash: 1085031462, Flags: 49469), LayoutImmutable, Blittable]
		public float LagYawMod { get; set; } // 0x18 (24)
		
		[ContainerField(Name: "LagPitchMod", Offset: 28, NameHash: 1481914735, Flags: 49469), LayoutImmutable, Blittable]
		public float LagPitchMod { get; set; } // 0x1C (28)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3711909665:
					DispersionMod = (GunSwayDispersionModData) p_Value;
					break;

				case 370335921:
					RecoilMagnitudeMod = (float) p_Value;
					break;

				case 1763796860:
					RecoilAngleMod = (float) p_Value;
					break;

				case 1085031462:
					LagYawMod = (float) p_Value;
					break;

				case 1481914735:
					LagPitchMod = (float) p_Value;
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
				case 3711909665:
					return DispersionMod;

				case 370335921:
					return RecoilMagnitudeMod;

				case 1763796860:
					return RecoilAngleMod;

				case 1085031462:
					return LagYawMod;

				case 1481914735:
					return LagPitchMod;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3711909665:
					return typeof(GunSwayStanceZoomModifierData).GetProperty(nameof(DispersionMod));

				case 370335921:
					return typeof(GunSwayStanceZoomModifierData).GetProperty(nameof(RecoilMagnitudeMod));

				case 1763796860:
					return typeof(GunSwayStanceZoomModifierData).GetProperty(nameof(RecoilAngleMod));

				case 1085031462:
					return typeof(GunSwayStanceZoomModifierData).GetProperty(nameof(LagYawMod));

				case 1481914735:
					return typeof(GunSwayStanceZoomModifierData).GetProperty(nameof(LagPitchMod));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
