///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(16)]
	public class LocalLightEntityData : 
		SpatialEntityData
	{
		[ContainerField(80), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 Color { get; set; } = new Vec3(); // 0x50 (80)
		
		[ContainerField(96), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 ParticleColorScale { get; set; } = new Vec3(); // 0x60 (96)
		
		[ContainerField(112), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 EnlightenColorScale { get; set; } = new Vec3(); // 0x70 (112)
		
		[ContainerField(128), LayoutImmutable, Blittable]
		public float Radius { get; set; } // 0x80 (128)
		
		[ContainerField(132), LayoutImmutable, Blittable]
		public float Intensity { get; set; } // 0x84 (132)
		
		[ContainerField(136), LayoutImmutable, Blittable]
		public float AttenuationOffset { get; set; } // 0x88 (136)
		
		[ContainerField(140)]
		public EnlightenColorMode EnlightenColorMode { get; set; } = new EnlightenColorMode(); // 0x8C (140)
		
		[ContainerField(144), LayoutImmutable, Blittable]
		public bool EnlightenEnable { get; set; } // 0x90 (144)
		
		[ContainerField(145), LayoutImmutable, Blittable]
		public bool Visible { get; set; } // 0x91 (145)
		
		[ContainerField(146), LayoutImmutable, Blittable]
		public bool SpecularEnable { get; set; } // 0x92 (146)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 212387320:
					Color = (Vec3) p_Value;
					break;

				case 2597022356:
					ParticleColorScale = (Vec3) p_Value;
					break;

				case 2430608254:
					EnlightenColorScale = (Vec3) p_Value;
					break;

				case 3298407133:
					Radius = (float) p_Value;
					break;

				case 3836394730:
					Intensity = (float) p_Value;
					break;

				case 1890669738:
					AttenuationOffset = (float) p_Value;
					break;

				case 2676157573:
					EnlightenColorMode = (EnlightenColorMode) Enum.ToObject(typeof(EnlightenColorMode), p_Value);
					break;

				case 4137078682:
					EnlightenEnable = (bool) p_Value;
					break;

				case 901540267:
					Visible = (bool) p_Value;
					break;

				case 2335981451:
					SpecularEnable = (bool) p_Value;
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

				case 2597022356:
					return ParticleColorScale;

				case 2430608254:
					return EnlightenColorScale;

				case 3298407133:
					return Radius;

				case 3836394730:
					return Intensity;

				case 1890669738:
					return AttenuationOffset;

				case 2676157573:
					return EnlightenColorMode;

				case 4137078682:
					return EnlightenEnable;

				case 901540267:
					return Visible;

				case 2335981451:
					return SpecularEnable;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 212387320:
					return typeof(LocalLightEntityData).GetProperty(nameof(Color));

				case 2597022356:
					return typeof(LocalLightEntityData).GetProperty(nameof(ParticleColorScale));

				case 2430608254:
					return typeof(LocalLightEntityData).GetProperty(nameof(EnlightenColorScale));

				case 3298407133:
					return typeof(LocalLightEntityData).GetProperty(nameof(Radius));

				case 3836394730:
					return typeof(LocalLightEntityData).GetProperty(nameof(Intensity));

				case 1890669738:
					return typeof(LocalLightEntityData).GetProperty(nameof(AttenuationOffset));

				case 2676157573:
					return typeof(LocalLightEntityData).GetProperty(nameof(EnlightenColorMode));

				case 4137078682:
					return typeof(LocalLightEntityData).GetProperty(nameof(EnlightenEnable));

				case 901540267:
					return typeof(LocalLightEntityData).GetProperty(nameof(Visible));

				case 2335981451:
					return typeof(LocalLightEntityData).GetProperty(nameof(SpecularEnable));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
