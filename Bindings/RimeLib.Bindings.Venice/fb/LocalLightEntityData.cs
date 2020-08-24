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
	[ContainerType(16), MemberInfoFlag(53), ContainerClass]
	public class LocalLightEntityData : 
		SpatialEntityData
	{
		protected Vec3 m_Color = new Vec3();
		[ContainerField(80), Homogeneous, LayoutImmutable, Blittable, MemberInfoFlag(53289), ContainerFieldNameHash(212387320)]
		public Vec3 Color { get { return m_Color; } set { if (OnPropertyChanging("LocalLightEntityData." + nameof(Color), this, m_Color, value)) m_Color = value; } } // 0x50 (80)
		
		protected Vec3 m_ParticleColorScale = new Vec3();
		[ContainerField(96), Homogeneous, LayoutImmutable, Blittable, MemberInfoFlag(53289), ContainerFieldNameHash(2597022356)]
		public Vec3 ParticleColorScale { get { return m_ParticleColorScale; } set { if (OnPropertyChanging("LocalLightEntityData." + nameof(ParticleColorScale), this, m_ParticleColorScale, value)) m_ParticleColorScale = value; } } // 0x60 (96)
		
		protected Vec3 m_EnlightenColorScale = new Vec3();
		[ContainerField(112), Homogeneous, LayoutImmutable, Blittable, MemberInfoFlag(53289), ContainerFieldNameHash(2430608254)]
		public Vec3 EnlightenColorScale { get { return m_EnlightenColorScale; } set { if (OnPropertyChanging("LocalLightEntityData." + nameof(EnlightenColorScale), this, m_EnlightenColorScale, value)) m_EnlightenColorScale = value; } } // 0x70 (112)
		
		protected float m_Radius = new float();
		[ContainerField(128), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3298407133)]
		public float Radius { get { return m_Radius; } set { if (OnPropertyChanging("LocalLightEntityData." + nameof(Radius), this, m_Radius, value)) m_Radius = value; } } // 0x80 (128)
		
		protected float m_Intensity = new float();
		[ContainerField(132), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3836394730)]
		public float Intensity { get { return m_Intensity; } set { if (OnPropertyChanging("LocalLightEntityData." + nameof(Intensity), this, m_Intensity, value)) m_Intensity = value; } } // 0x84 (132)
		
		protected float m_AttenuationOffset = new float();
		[ContainerField(136), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(1890669738)]
		public float AttenuationOffset { get { return m_AttenuationOffset; } set { if (OnPropertyChanging("LocalLightEntityData." + nameof(AttenuationOffset), this, m_AttenuationOffset, value)) m_AttenuationOffset = value; } } // 0x88 (136)
		
		protected EnlightenColorMode m_EnlightenColorMode = new EnlightenColorMode();
		[ContainerField(140), MemberInfoFlag(137), ContainerFieldNameHash(2676157573)]
		public EnlightenColorMode EnlightenColorMode { get { return m_EnlightenColorMode; } set { if (OnPropertyChanging("LocalLightEntityData." + nameof(EnlightenColorMode), this, m_EnlightenColorMode, value)) m_EnlightenColorMode = value; } } // 0x8C (140)
		
		protected bool m_EnlightenEnable = new bool();
		[ContainerField(144), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(4137078682)]
		public bool EnlightenEnable { get { return m_EnlightenEnable; } set { if (OnPropertyChanging("LocalLightEntityData." + nameof(EnlightenEnable), this, m_EnlightenEnable, value)) m_EnlightenEnable = value; } } // 0x90 (144)
		
		protected bool m_Visible = new bool();
		[ContainerField(145), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(901540267)]
		public bool Visible { get { return m_Visible; } set { if (OnPropertyChanging("LocalLightEntityData." + nameof(Visible), this, m_Visible, value)) m_Visible = value; } } // 0x91 (145)
		
		protected bool m_SpecularEnable = new bool();
		[ContainerField(146), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2335981451)]
		public bool SpecularEnable { get { return m_SpecularEnable; } set { if (OnPropertyChanging("LocalLightEntityData." + nameof(SpecularEnable), this, m_SpecularEnable, value)) m_SpecularEnable = value; } } // 0x92 (146)
		
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
