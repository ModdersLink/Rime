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
	[ContainerType(Alignment: 4,  Flags: 41, Size: 24)]
	public class BlurEffectData : FrostbiteContainer
	{
		[ContainerField(Name: "DispersionStrength", Offset: 0, NameHash: 267790946, Flags: 49469), LayoutImmutable, Blittable]
		public float DispersionStrength { get; set; } // 0x0 (0)
		
		[ContainerField(Name: "DispersionThreshhold", Offset: 4, NameHash: 2849266168, Flags: 49469), LayoutImmutable, Blittable]
		public float DispersionThreshhold { get; set; } // 0x4 (4)
		
		[ContainerField(Name: "ExplosionStrength", Offset: 8, NameHash: 146990261, Flags: 49469), LayoutImmutable, Blittable]
		public float ExplosionStrength { get; set; } // 0x8 (8)
		
		[ContainerField(Name: "BulletStrength", Offset: 12, NameHash: 1725135046, Flags: 49469), LayoutImmutable, Blittable]
		public float BulletStrength { get; set; } // 0xC (12)
		
		[ContainerField(Name: "ExplosionFalloffSpeed", Offset: 16, NameHash: 676135103, Flags: 49469), LayoutImmutable, Blittable]
		public float ExplosionFalloffSpeed { get; set; } // 0x10 (16)
		
		[ContainerField(Name: "BulletFalloffSpeed", Offset: 20, NameHash: 252733900, Flags: 49469), LayoutImmutable, Blittable]
		public float BulletFalloffSpeed { get; set; } // 0x14 (20)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 267790946:
					DispersionStrength = (float) p_Value;
					break;

				case 2849266168:
					DispersionThreshhold = (float) p_Value;
					break;

				case 146990261:
					ExplosionStrength = (float) p_Value;
					break;

				case 1725135046:
					BulletStrength = (float) p_Value;
					break;

				case 676135103:
					ExplosionFalloffSpeed = (float) p_Value;
					break;

				case 252733900:
					BulletFalloffSpeed = (float) p_Value;
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
				case 267790946:
					return DispersionStrength;

				case 2849266168:
					return DispersionThreshhold;

				case 146990261:
					return ExplosionStrength;

				case 1725135046:
					return BulletStrength;

				case 676135103:
					return ExplosionFalloffSpeed;

				case 252733900:
					return BulletFalloffSpeed;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 267790946:
					return typeof(BlurEffectData).GetProperty(nameof(DispersionStrength));

				case 2849266168:
					return typeof(BlurEffectData).GetProperty(nameof(DispersionThreshhold));

				case 146990261:
					return typeof(BlurEffectData).GetProperty(nameof(ExplosionStrength));

				case 1725135046:
					return typeof(BlurEffectData).GetProperty(nameof(BulletStrength));

				case 676135103:
					return typeof(BlurEffectData).GetProperty(nameof(ExplosionFalloffSpeed));

				case 252733900:
					return typeof(BlurEffectData).GetProperty(nameof(BulletFalloffSpeed));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
