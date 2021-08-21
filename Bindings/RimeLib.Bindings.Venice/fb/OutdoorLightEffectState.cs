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
	[ContainerType(Alignment: 16,  Flags: 53, Size: 112)]
	public class OutdoorLightEffectState : 
		DataContainer
	{
		protected Vec3 m_SkyColor = new Vec3();
		[ContainerField(Name: "SkyColor", Offset: 16, NameHash: 3778322649, Flags: 53289), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 SkyColor { get { return m_SkyColor; } set { if (OnPropertyChanging("OutdoorLightEffectState." + nameof(SkyColor), this, m_SkyColor, value)) m_SkyColor = value; } } // 0x10 (16)
		
		protected Vec3 m_GroundColor = new Vec3();
		[ContainerField(Name: "GroundColor", Offset: 32, NameHash: 1770880637, Flags: 53289), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 GroundColor { get { return m_GroundColor; } set { if (OnPropertyChanging("OutdoorLightEffectState." + nameof(GroundColor), this, m_GroundColor, value)) m_GroundColor = value; } } // 0x20 (32)
		
		protected Vec3 m_SunColor = new Vec3();
		[ContainerField(Name: "SunColor", Offset: 48, NameHash: 2189837744, Flags: 53289), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 SunColor { get { return m_SunColor; } set { if (OnPropertyChanging("OutdoorLightEffectState." + nameof(SunColor), this, m_SunColor, value)) m_SunColor = value; } } // 0x30 (48)
		
		protected Vec2 m_CloudShadowSpeed = new Vec2();
		[ContainerField(Name: "CloudShadowSpeed", Offset: 64, NameHash: 4285381109, Flags: 53289), Homogeneous, LayoutImmutable, Blittable]
		public Vec2 CloudShadowSpeed { get { return m_CloudShadowSpeed; } set { if (OnPropertyChanging("OutdoorLightEffectState." + nameof(CloudShadowSpeed), this, m_CloudShadowSpeed, value)) m_CloudShadowSpeed = value; } } // 0x40 (64)
		
		protected float m_SunRotationX = new float();
		[ContainerField(Name: "SunRotationX", Offset: 72, NameHash: 2283294049, Flags: 49469), LayoutImmutable, Blittable]
		public float SunRotationX { get { return m_SunRotationX; } set { if (OnPropertyChanging("OutdoorLightEffectState." + nameof(SunRotationX), this, m_SunRotationX, value)) m_SunRotationX = value; } } // 0x48 (72)
		
		protected float m_SunRotationY = new float();
		[ContainerField(Name: "SunRotationY", Offset: 76, NameHash: 2283294048, Flags: 49469), LayoutImmutable, Blittable]
		public float SunRotationY { get { return m_SunRotationY; } set { if (OnPropertyChanging("OutdoorLightEffectState." + nameof(SunRotationY), this, m_SunRotationY, value)) m_SunRotationY = value; } } // 0x4C (76)
		
		protected float m_SkyLightAngleFactor = new float();
		[ContainerField(Name: "SkyLightAngleFactor", Offset: 80, NameHash: 4138591318, Flags: 49469), LayoutImmutable, Blittable]
		public float SkyLightAngleFactor { get { return m_SkyLightAngleFactor; } set { if (OnPropertyChanging("OutdoorLightEffectState." + nameof(SkyLightAngleFactor), this, m_SkyLightAngleFactor, value)) m_SkyLightAngleFactor = value; } } // 0x50 (80)
		
		protected float m_SunShadowHeightScale = new float();
		[ContainerField(Name: "SunShadowHeightScale", Offset: 84, NameHash: 2049987628, Flags: 49469), LayoutImmutable, Blittable]
		public float SunShadowHeightScale { get { return m_SunShadowHeightScale; } set { if (OnPropertyChanging("OutdoorLightEffectState." + nameof(SunShadowHeightScale), this, m_SunShadowHeightScale, value)) m_SunShadowHeightScale = value; } } // 0x54 (84)
		
		protected CtrRef<TextureAsset> m_CloudShadowTexture = new CtrRef<TextureAsset>();
		[ContainerField(Name: "CloudShadowTexture", Offset: 88, NameHash: 1607365037, Flags: 53)]
		public CtrRef<TextureAsset> CloudShadowTexture { get { return m_CloudShadowTexture; } set { if (OnPropertyChanging("OutdoorLightEffectState." + nameof(CloudShadowTexture), this, m_CloudShadowTexture, value)) m_CloudShadowTexture = value; } } // 0x58 (88)
		
		protected float m_CloudShadowSize = new float();
		[ContainerField(Name: "CloudShadowSize", Offset: 92, NameHash: 2732862871, Flags: 49469), LayoutImmutable, Blittable]
		public float CloudShadowSize { get { return m_CloudShadowSize; } set { if (OnPropertyChanging("OutdoorLightEffectState." + nameof(CloudShadowSize), this, m_CloudShadowSize, value)) m_CloudShadowSize = value; } } // 0x5C (92)
		
		protected float m_CloudShadowExponent = new float();
		[ContainerField(Name: "CloudShadowExponent", Offset: 96, NameHash: 1934044673, Flags: 49469), LayoutImmutable, Blittable]
		public float CloudShadowExponent { get { return m_CloudShadowExponent; } set { if (OnPropertyChanging("OutdoorLightEffectState." + nameof(CloudShadowExponent), this, m_CloudShadowExponent, value)) m_CloudShadowExponent = value; } } // 0x60 (96)
		
		protected float m_CloudShadowCoverage = new float();
		[ContainerField(Name: "CloudShadowCoverage", Offset: 100, NameHash: 535106300, Flags: 49469), LayoutImmutable, Blittable]
		public float CloudShadowCoverage { get { return m_CloudShadowCoverage; } set { if (OnPropertyChanging("OutdoorLightEffectState." + nameof(CloudShadowCoverage), this, m_CloudShadowCoverage, value)) m_CloudShadowCoverage = value; } } // 0x64 (100)
		
		protected bool m_CloudShadowEnable = new bool();
		[ContainerField(Name: "CloudShadowEnable", Offset: 104, NameHash: 380549299, Flags: 49325), LayoutImmutable, Blittable]
		public bool CloudShadowEnable { get { return m_CloudShadowEnable; } set { if (OnPropertyChanging("OutdoorLightEffectState." + nameof(CloudShadowEnable), this, m_CloudShadowEnable, value)) m_CloudShadowEnable = value; } } // 0x68 (104)
		
		protected bool m_Enable = new bool();
		[ContainerField(Name: "Enable", Offset: 105, NameHash: 2342790116, Flags: 49325), LayoutImmutable, Blittable]
		public bool Enable { get { return m_Enable; } set { if (OnPropertyChanging("OutdoorLightEffectState." + nameof(Enable), this, m_Enable, value)) m_Enable = value; } } // 0x69 (105)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3778322649:
					SkyColor = (Vec3) p_Value;
					break;

				case 1770880637:
					GroundColor = (Vec3) p_Value;
					break;

				case 2189837744:
					SunColor = (Vec3) p_Value;
					break;

				case 4285381109:
					CloudShadowSpeed = (Vec2) p_Value;
					break;

				case 2283294049:
					SunRotationX = (float) p_Value;
					break;

				case 2283294048:
					SunRotationY = (float) p_Value;
					break;

				case 4138591318:
					SkyLightAngleFactor = (float) p_Value;
					break;

				case 2049987628:
					SunShadowHeightScale = (float) p_Value;
					break;

				case 1607365037:
					CloudShadowTexture = (CtrRef<TextureAsset>) p_Value;
					break;

				case 2732862871:
					CloudShadowSize = (float) p_Value;
					break;

				case 1934044673:
					CloudShadowExponent = (float) p_Value;
					break;

				case 535106300:
					CloudShadowCoverage = (float) p_Value;
					break;

				case 380549299:
					CloudShadowEnable = (bool) p_Value;
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
				case 3778322649:
					return SkyColor;

				case 1770880637:
					return GroundColor;

				case 2189837744:
					return SunColor;

				case 4285381109:
					return CloudShadowSpeed;

				case 2283294049:
					return SunRotationX;

				case 2283294048:
					return SunRotationY;

				case 4138591318:
					return SkyLightAngleFactor;

				case 2049987628:
					return SunShadowHeightScale;

				case 1607365037:
					return CloudShadowTexture;

				case 2732862871:
					return CloudShadowSize;

				case 1934044673:
					return CloudShadowExponent;

				case 535106300:
					return CloudShadowCoverage;

				case 380549299:
					return CloudShadowEnable;

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
				case 3778322649:
					return typeof(OutdoorLightEffectState).GetProperty(nameof(SkyColor));

				case 1770880637:
					return typeof(OutdoorLightEffectState).GetProperty(nameof(GroundColor));

				case 2189837744:
					return typeof(OutdoorLightEffectState).GetProperty(nameof(SunColor));

				case 4285381109:
					return typeof(OutdoorLightEffectState).GetProperty(nameof(CloudShadowSpeed));

				case 2283294049:
					return typeof(OutdoorLightEffectState).GetProperty(nameof(SunRotationX));

				case 2283294048:
					return typeof(OutdoorLightEffectState).GetProperty(nameof(SunRotationY));

				case 4138591318:
					return typeof(OutdoorLightEffectState).GetProperty(nameof(SkyLightAngleFactor));

				case 2049987628:
					return typeof(OutdoorLightEffectState).GetProperty(nameof(SunShadowHeightScale));

				case 1607365037:
					return typeof(OutdoorLightEffectState).GetProperty(nameof(CloudShadowTexture));

				case 2732862871:
					return typeof(OutdoorLightEffectState).GetProperty(nameof(CloudShadowSize));

				case 1934044673:
					return typeof(OutdoorLightEffectState).GetProperty(nameof(CloudShadowExponent));

				case 535106300:
					return typeof(OutdoorLightEffectState).GetProperty(nameof(CloudShadowCoverage));

				case 380549299:
					return typeof(OutdoorLightEffectState).GetProperty(nameof(CloudShadowEnable));

				case 2342790116:
					return typeof(OutdoorLightEffectState).GetProperty(nameof(Enable));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
