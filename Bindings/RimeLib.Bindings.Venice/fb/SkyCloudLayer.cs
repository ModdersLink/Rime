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
	[ContainerType(16), MemberInfoFlag(41), ContainerSize(64), ContainerStruct]
	public class SkyCloudLayer : FrostbiteContainer
	{
		[ContainerField(0), Homogeneous, LayoutImmutable, Blittable, MemberInfoFlag(53289)]
		public Vec3 Color { get; set; } = new Vec3(); // 0x0 (0)
		
		[ContainerField(16), LayoutImmutable, Blittable, MemberInfoFlag(49469)]
		public float TileFactor { get; set; } // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable, MemberInfoFlag(49469)]
		public float Rotation { get; set; } // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable, Blittable, MemberInfoFlag(49469)]
		public float Altitude { get; set; } // 0x18 (24)
		
		[ContainerField(28), LayoutImmutable, Blittable, MemberInfoFlag(49469)]
		public float Speed { get; set; } // 0x1C (28)
		
		[ContainerField(32), LayoutImmutable, Blittable, MemberInfoFlag(49469)]
		public float SunLightPower { get; set; } // 0x20 (32)
		
		[ContainerField(36), LayoutImmutable, Blittable, MemberInfoFlag(49469)]
		public float AmbientLightIntensity { get; set; } // 0x24 (36)
		
		[ContainerField(40), LayoutImmutable, Blittable, MemberInfoFlag(49469)]
		public float SunLightIntensity { get; set; } // 0x28 (40)
		
		[ContainerField(44), LayoutImmutable, Blittable, MemberInfoFlag(49469)]
		public float AlphaMul { get; set; } // 0x2C (44)
		
		[ContainerField(48), MemberInfoFlag(53), ContainerCtrRef]
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
