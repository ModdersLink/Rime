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
	[ContainerType(Alignment: 16,  Flags: 41, Size: 64)]
	public class SkyCloudLayer : FrostbiteContainer
	{
		[ContainerField(Name: "Color", Offset: 0, NameHash: 212387320, Flags: 53289), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 Color { get; set; } = new Vec3(); // 0x0 (0)
		
		[ContainerField(Name: "TileFactor", Offset: 16, NameHash: 2579682268, Flags: 49469), LayoutImmutable, Blittable]
		public float TileFactor { get; set; } // 0x10 (16)
		
		[ContainerField(Name: "Rotation", Offset: 20, NameHash: 48673745, Flags: 49469), LayoutImmutable, Blittable]
		public float Rotation { get; set; } // 0x14 (20)
		
		[ContainerField(Name: "Altitude", Offset: 24, NameHash: 4249664917, Flags: 49469), LayoutImmutable, Blittable]
		public float Altitude { get; set; } // 0x18 (24)
		
		[ContainerField(Name: "Speed", Offset: 28, NameHash: 230887042, Flags: 49469), LayoutImmutable, Blittable]
		public float Speed { get; set; } // 0x1C (28)
		
		[ContainerField(Name: "SunLightPower", Offset: 32, NameHash: 4090337004, Flags: 49469), LayoutImmutable, Blittable]
		public float SunLightPower { get; set; } // 0x20 (32)
		
		[ContainerField(Name: "AmbientLightIntensity", Offset: 36, NameHash: 1203735884, Flags: 49469), LayoutImmutable, Blittable]
		public float AmbientLightIntensity { get; set; } // 0x24 (36)
		
		[ContainerField(Name: "SunLightIntensity", Offset: 40, NameHash: 2700596092, Flags: 49469), LayoutImmutable, Blittable]
		public float SunLightIntensity { get; set; } // 0x28 (40)
		
		[ContainerField(Name: "AlphaMul", Offset: 44, NameHash: 4095152933, Flags: 49469), LayoutImmutable, Blittable]
		public float AlphaMul { get; set; } // 0x2C (44)
		
		[ContainerField(Name: "Texture", Offset: 48, NameHash: 3185041626, Flags: 53)]
		public CtrRef<TextureAsset> Texture { get; set; } = new CtrRef<TextureAsset>(); // 0x30 (48)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 212387320:
					Color = (Vec3) p_Value;
					break;

				case 2579682268:
					TileFactor = (float) p_Value;
					break;

				case 48673745:
					Rotation = (float) p_Value;
					break;

				case 4249664917:
					Altitude = (float) p_Value;
					break;

				case 230887042:
					Speed = (float) p_Value;
					break;

				case 4090337004:
					SunLightPower = (float) p_Value;
					break;

				case 1203735884:
					AmbientLightIntensity = (float) p_Value;
					break;

				case 2700596092:
					SunLightIntensity = (float) p_Value;
					break;

				case 4095152933:
					AlphaMul = (float) p_Value;
					break;

				case 3185041626:
					Texture = (CtrRef<TextureAsset>) p_Value;
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
				case 212387320:
					return Color;

				case 2579682268:
					return TileFactor;

				case 48673745:
					return Rotation;

				case 4249664917:
					return Altitude;

				case 230887042:
					return Speed;

				case 4090337004:
					return SunLightPower;

				case 1203735884:
					return AmbientLightIntensity;

				case 2700596092:
					return SunLightIntensity;

				case 4095152933:
					return AlphaMul;

				case 3185041626:
					return Texture;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 212387320:
					return typeof(SkyCloudLayer).GetProperty(nameof(Color));

				case 2579682268:
					return typeof(SkyCloudLayer).GetProperty(nameof(TileFactor));

				case 48673745:
					return typeof(SkyCloudLayer).GetProperty(nameof(Rotation));

				case 4249664917:
					return typeof(SkyCloudLayer).GetProperty(nameof(Altitude));

				case 230887042:
					return typeof(SkyCloudLayer).GetProperty(nameof(Speed));

				case 4090337004:
					return typeof(SkyCloudLayer).GetProperty(nameof(SunLightPower));

				case 1203735884:
					return typeof(SkyCloudLayer).GetProperty(nameof(AmbientLightIntensity));

				case 2700596092:
					return typeof(SkyCloudLayer).GetProperty(nameof(SunLightIntensity));

				case 4095152933:
					return typeof(SkyCloudLayer).GetProperty(nameof(AlphaMul));

				case 3185041626:
					return typeof(SkyCloudLayer).GetProperty(nameof(Texture));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
