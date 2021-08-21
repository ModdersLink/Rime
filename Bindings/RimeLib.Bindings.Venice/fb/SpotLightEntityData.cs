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
	[ContainerType(Alignment: 16,  Flags: 53, Size: 208)]
	public class SpotLightEntityData : 
		LocalLightEntityData
	{
		protected SpotLightShape m_Shape = new SpotLightShape();
		[ContainerField(Name: "Shape", Offset: 160, NameHash: 231753450, Flags: 137)]
		public SpotLightShape Shape { get { return m_Shape; } set { if (OnPropertyChanging("SpotLightEntityData." + nameof(Shape), this, m_Shape, value)) m_Shape = value; } } // 0xA0 (160)
		
		protected float m_ConeInnerAngle = new float();
		[ContainerField(Name: "ConeInnerAngle", Offset: 164, NameHash: 3810873469, Flags: 49469), LayoutImmutable, Blittable]
		public float ConeInnerAngle { get { return m_ConeInnerAngle; } set { if (OnPropertyChanging("SpotLightEntityData." + nameof(ConeInnerAngle), this, m_ConeInnerAngle, value)) m_ConeInnerAngle = value; } } // 0xA4 (164)
		
		protected float m_ConeOuterAngle = new float();
		[ContainerField(Name: "ConeOuterAngle", Offset: 168, NameHash: 3019106938, Flags: 49469), LayoutImmutable, Blittable]
		public float ConeOuterAngle { get { return m_ConeOuterAngle; } set { if (OnPropertyChanging("SpotLightEntityData." + nameof(ConeOuterAngle), this, m_ConeOuterAngle, value)) m_ConeOuterAngle = value; } } // 0xA8 (168)
		
		protected float m_FrustumFov = new float();
		[ContainerField(Name: "FrustumFov", Offset: 172, NameHash: 3985893604, Flags: 49469), LayoutImmutable, Blittable]
		public float FrustumFov { get { return m_FrustumFov; } set { if (OnPropertyChanging("SpotLightEntityData." + nameof(FrustumFov), this, m_FrustumFov, value)) m_FrustumFov = value; } } // 0xAC (172)
		
		protected float m_FrustumAspect = new float();
		[ContainerField(Name: "FrustumAspect", Offset: 176, NameHash: 3695152459, Flags: 49469), LayoutImmutable, Blittable]
		public float FrustumAspect { get { return m_FrustumAspect; } set { if (OnPropertyChanging("SpotLightEntityData." + nameof(FrustumAspect), this, m_FrustumAspect, value)) m_FrustumAspect = value; } } // 0xB0 (176)
		
		protected float m_OrthoWidth = new float();
		[ContainerField(Name: "OrthoWidth", Offset: 180, NameHash: 2723884589, Flags: 49469), LayoutImmutable, Blittable]
		public float OrthoWidth { get { return m_OrthoWidth; } set { if (OnPropertyChanging("SpotLightEntityData." + nameof(OrthoWidth), this, m_OrthoWidth, value)) m_OrthoWidth = value; } } // 0xB4 (180)
		
		protected float m_OrthoHeight = new float();
		[ContainerField(Name: "OrthoHeight", Offset: 184, NameHash: 3103292980, Flags: 49469), LayoutImmutable, Blittable]
		public float OrthoHeight { get { return m_OrthoHeight; } set { if (OnPropertyChanging("SpotLightEntityData." + nameof(OrthoHeight), this, m_OrthoHeight, value)) m_OrthoHeight = value; } } // 0xB8 (184)
		
		protected CtrRef<TextureAsset> m_Texture = new CtrRef<TextureAsset>();
		[ContainerField(Name: "Texture", Offset: 188, NameHash: 3185041626, Flags: 53)]
		public CtrRef<TextureAsset> Texture { get { return m_Texture; } set { if (OnPropertyChanging("SpotLightEntityData." + nameof(Texture), this, m_Texture, value)) m_Texture = value; } } // 0xBC (188)
		
		protected QualityLevel m_CastShadowsMinLevel = new QualityLevel();
		[ContainerField(Name: "CastShadowsMinLevel", Offset: 192, NameHash: 1169958953, Flags: 137)]
		public QualityLevel CastShadowsMinLevel { get { return m_CastShadowsMinLevel; } set { if (OnPropertyChanging("SpotLightEntityData." + nameof(CastShadowsMinLevel), this, m_CastShadowsMinLevel, value)) m_CastShadowsMinLevel = value; } } // 0xC0 (192)
		
		protected bool m_CastShadowsEnable = new bool();
		[ContainerField(Name: "CastShadowsEnable", Offset: 196, NameHash: 3967009076, Flags: 49325), LayoutImmutable, Blittable]
		public bool CastShadowsEnable { get { return m_CastShadowsEnable; } set { if (OnPropertyChanging("SpotLightEntityData." + nameof(CastShadowsEnable), this, m_CastShadowsEnable, value)) m_CastShadowsEnable = value; } } // 0xC4 (196)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 231753450:
					Shape = (SpotLightShape) Enum.ToObject(typeof(SpotLightShape), p_Value);
					break;

				case 3810873469:
					ConeInnerAngle = (float) p_Value;
					break;

				case 3019106938:
					ConeOuterAngle = (float) p_Value;
					break;

				case 3985893604:
					FrustumFov = (float) p_Value;
					break;

				case 3695152459:
					FrustumAspect = (float) p_Value;
					break;

				case 2723884589:
					OrthoWidth = (float) p_Value;
					break;

				case 3103292980:
					OrthoHeight = (float) p_Value;
					break;

				case 3185041626:
					Texture = (CtrRef<TextureAsset>) p_Value;
					break;

				case 1169958953:
					CastShadowsMinLevel = (QualityLevel) Enum.ToObject(typeof(QualityLevel), p_Value);
					break;

				case 3967009076:
					CastShadowsEnable = (bool) p_Value;
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
				case 231753450:
					return Shape;

				case 3810873469:
					return ConeInnerAngle;

				case 3019106938:
					return ConeOuterAngle;

				case 3985893604:
					return FrustumFov;

				case 3695152459:
					return FrustumAspect;

				case 2723884589:
					return OrthoWidth;

				case 3103292980:
					return OrthoHeight;

				case 3185041626:
					return Texture;

				case 1169958953:
					return CastShadowsMinLevel;

				case 3967009076:
					return CastShadowsEnable;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 231753450:
					return typeof(SpotLightEntityData).GetProperty(nameof(Shape));

				case 3810873469:
					return typeof(SpotLightEntityData).GetProperty(nameof(ConeInnerAngle));

				case 3019106938:
					return typeof(SpotLightEntityData).GetProperty(nameof(ConeOuterAngle));

				case 3985893604:
					return typeof(SpotLightEntityData).GetProperty(nameof(FrustumFov));

				case 3695152459:
					return typeof(SpotLightEntityData).GetProperty(nameof(FrustumAspect));

				case 2723884589:
					return typeof(SpotLightEntityData).GetProperty(nameof(OrthoWidth));

				case 3103292980:
					return typeof(SpotLightEntityData).GetProperty(nameof(OrthoHeight));

				case 3185041626:
					return typeof(SpotLightEntityData).GetProperty(nameof(Texture));

				case 1169958953:
					return typeof(SpotLightEntityData).GetProperty(nameof(CastShadowsMinLevel));

				case 3967009076:
					return typeof(SpotLightEntityData).GetProperty(nameof(CastShadowsEnable));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
