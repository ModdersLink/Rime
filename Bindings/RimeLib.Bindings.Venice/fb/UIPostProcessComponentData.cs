///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class UIPostProcessComponentData : 
		UIComponentData
	{
		[ContainerField(28), LayoutImmutable, Blittable]
		public float HighlightThreshold { get; set; } // 0x1C (28)
		
		[ContainerField(32), LayoutImmutable, Blittable]
		public float XPower { get; set; } // 0x20 (32)
		
		[ContainerField(36), LayoutImmutable, Blittable]
		public float YPower { get; set; } // 0x24 (36)
		
		[ContainerField(40), LayoutImmutable, Blittable]
		public float Distort { get; set; } // 0x28 (40)
		
		[ContainerField(44), LayoutImmutable, Blittable]
		public float TimeScale { get; set; } // 0x2C (44)
		
		[ContainerField(48)]
		public CtrRef<TextureAsset> NoiseTexture { get; set; } = new CtrRef<TextureAsset>(); // 0x30 (48)
		
		[ContainerField(52), LayoutImmutable, Blittable]
		public float Highlight { get; set; } // 0x34 (52)
		
		[ContainerField(56), LayoutImmutable, Blittable]
		public float RShift { get; set; } // 0x38 (56)
		
		[ContainerField(60), LayoutImmutable, Blittable]
		public float GShift { get; set; } // 0x3C (60)
		
		[ContainerField(64), LayoutImmutable, Blittable]
		public float BShift { get; set; } // 0x40 (64)
		
		[ContainerField(68), LayoutImmutable, Blittable]
		public bool TweakMode { get; set; } // 0x44 (68)
		
		[ContainerField(69), LayoutImmutable, Blittable]
		public bool Enabled { get; set; } // 0x45 (69)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 95158690:
					HighlightThreshold = (float) p_Value;
					break;

				case 3629034434:
					XPower = (float) p_Value;
					break;

				case 3442840483:
					YPower = (float) p_Value;
					break;

				case 4177187398:
					Distort = (float) p_Value;
					break;

				case 169511528:
					TimeScale = (float) p_Value;
					break;

				case 3113175460:
					NoiseTexture = (CtrRef<TextureAsset>) p_Value;
					break;

				case 2206773:
					Highlight = (float) p_Value;
					break;

				case 3246353367:
					RShift = (float) p_Value;
					break;

				case 2616832162:
					GShift = (float) p_Value;
					break;

				case 2658136519:
					BShift = (float) p_Value;
					break;

				case 16411562:
					TweakMode = (bool) p_Value;
					break;

				case 2662400:
					Enabled = (bool) p_Value;
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
				case 95158690:
					return HighlightThreshold;

				case 3629034434:
					return XPower;

				case 3442840483:
					return YPower;

				case 4177187398:
					return Distort;

				case 169511528:
					return TimeScale;

				case 3113175460:
					return NoiseTexture;

				case 2206773:
					return Highlight;

				case 3246353367:
					return RShift;

				case 2616832162:
					return GShift;

				case 2658136519:
					return BShift;

				case 16411562:
					return TweakMode;

				case 2662400:
					return Enabled;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 95158690:
					return typeof(UIPostProcessComponentData).GetProperty(nameof(HighlightThreshold));

				case 3629034434:
					return typeof(UIPostProcessComponentData).GetProperty(nameof(XPower));

				case 3442840483:
					return typeof(UIPostProcessComponentData).GetProperty(nameof(YPower));

				case 4177187398:
					return typeof(UIPostProcessComponentData).GetProperty(nameof(Distort));

				case 169511528:
					return typeof(UIPostProcessComponentData).GetProperty(nameof(TimeScale));

				case 3113175460:
					return typeof(UIPostProcessComponentData).GetProperty(nameof(NoiseTexture));

				case 2206773:
					return typeof(UIPostProcessComponentData).GetProperty(nameof(Highlight));

				case 3246353367:
					return typeof(UIPostProcessComponentData).GetProperty(nameof(RShift));

				case 2616832162:
					return typeof(UIPostProcessComponentData).GetProperty(nameof(GShift));

				case 2658136519:
					return typeof(UIPostProcessComponentData).GetProperty(nameof(BShift));

				case 16411562:
					return typeof(UIPostProcessComponentData).GetProperty(nameof(TweakMode));

				case 2662400:
					return typeof(UIPostProcessComponentData).GetProperty(nameof(Enabled));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
