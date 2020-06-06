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
	public class SpotLightEntityData : 
		LocalLightEntityData
	{
		[ContainerField(160)]
		public SpotLightShape Shape { get; set; } = new SpotLightShape(); // 0xA0 (160)
		
		[ContainerField(164), LayoutImmutable, Blittable]
		public float ConeInnerAngle { get; set; } // 0xA4 (164)
		
		[ContainerField(168), LayoutImmutable, Blittable]
		public float ConeOuterAngle { get; set; } // 0xA8 (168)
		
		[ContainerField(172), LayoutImmutable, Blittable]
		public float FrustumFov { get; set; } // 0xAC (172)
		
		[ContainerField(176), LayoutImmutable, Blittable]
		public float FrustumAspect { get; set; } // 0xB0 (176)
		
		[ContainerField(180), LayoutImmutable, Blittable]
		public float OrthoWidth { get; set; } // 0xB4 (180)
		
		[ContainerField(184), LayoutImmutable, Blittable]
		public float OrthoHeight { get; set; } // 0xB8 (184)
		
		[ContainerField(188)]
		public CtrRef<TextureAsset> Texture { get; set; } = new CtrRef<TextureAsset>(); // 0xBC (188)
		
		[ContainerField(192)]
		public QualityLevel CastShadowsMinLevel { get; set; } = new QualityLevel(); // 0xC0 (192)
		
		[ContainerField(196), LayoutImmutable, Blittable]
		public bool CastShadowsEnable { get; set; } // 0xC4 (196)
		
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
