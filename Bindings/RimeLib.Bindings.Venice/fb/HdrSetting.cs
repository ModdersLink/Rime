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
	public class HdrSetting : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable, Blittable]
		public float WindowMinTop { get; set; } // 0x8 (8)
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public float WindowMinBottom { get; set; } // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public float WindowTopMinReleaseTime { get; set; } // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public float WindowTopMaxReleaseTime { get; set; } // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public float WindowTopAttackTime { get; set; } // 0x18 (24)
		
		[ContainerField(28), LayoutImmutable, Blittable]
		public float WindowBottomReleaseTime { get; set; } // 0x1C (28)
		
		[ContainerField(32)]
		public AudioCurve WindowTopReleaseTimeCurve { get; set; } = new AudioCurve(); // 0x20 (32)
		
		[ContainerField(40), LayoutImmutable, Blittable]
		public float DischargeFactor { get; set; } // 0x28 (40)
		
		[ContainerField(44), LayoutImmutable, Blittable]
		public float MaxAllowedEnergy { get; set; } // 0x2C (44)
		
		[ContainerField(48), LayoutImmutable, Blittable]
		public float WindowBottomAttackTime { get; set; } // 0x30 (48)
		
		[ContainerField(52), LayoutImmutable, Blittable]
		public float WindowSize { get; set; } // 0x34 (52)
		
		[ContainerField(56), LayoutImmutable, Blittable]
		public float CompressFactor { get; set; } // 0x38 (56)
		
		[ContainerField(60), LayoutImmutable, Blittable]
		public float Headroom { get; set; } // 0x3C (60)
		
		[ContainerField(64), LayoutImmutable, Blittable]
		public float AllowedOvershoot { get; set; } // 0x40 (64)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 4075961896:
					WindowMinTop = (float) p_Value;
					break;

				case 1280335404:
					WindowMinBottom = (float) p_Value;
					break;

				case 3101523828:
					WindowTopMinReleaseTime = (float) p_Value;
					break;

				case 980586794:
					WindowTopMaxReleaseTime = (float) p_Value;
					break;

				case 4009242335:
					WindowTopAttackTime = (float) p_Value;
					break;

				case 2031081370:
					WindowBottomReleaseTime = (float) p_Value;
					break;

				case 3335723049:
					WindowTopReleaseTimeCurve = (AudioCurve) p_Value;
					break;

				case 3485908236:
					DischargeFactor = (float) p_Value;
					break;

				case 2165069867:
					MaxAllowedEnergy = (float) p_Value;
					break;

				case 1069365659:
					WindowBottomAttackTime = (float) p_Value;
					break;

				case 1881978028:
					WindowSize = (float) p_Value;
					break;

				case 2404074926:
					CompressFactor = (float) p_Value;
					break;

				case 1877971122:
					Headroom = (float) p_Value;
					break;

				case 730342460:
					AllowedOvershoot = (float) p_Value;
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
				case 4075961896:
					return WindowMinTop;

				case 1280335404:
					return WindowMinBottom;

				case 3101523828:
					return WindowTopMinReleaseTime;

				case 980586794:
					return WindowTopMaxReleaseTime;

				case 4009242335:
					return WindowTopAttackTime;

				case 2031081370:
					return WindowBottomReleaseTime;

				case 3335723049:
					return WindowTopReleaseTimeCurve;

				case 3485908236:
					return DischargeFactor;

				case 2165069867:
					return MaxAllowedEnergy;

				case 1069365659:
					return WindowBottomAttackTime;

				case 1881978028:
					return WindowSize;

				case 2404074926:
					return CompressFactor;

				case 1877971122:
					return Headroom;

				case 730342460:
					return AllowedOvershoot;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 4075961896:
					return typeof(HdrSetting).GetProperty(nameof(WindowMinTop));

				case 1280335404:
					return typeof(HdrSetting).GetProperty(nameof(WindowMinBottom));

				case 3101523828:
					return typeof(HdrSetting).GetProperty(nameof(WindowTopMinReleaseTime));

				case 980586794:
					return typeof(HdrSetting).GetProperty(nameof(WindowTopMaxReleaseTime));

				case 4009242335:
					return typeof(HdrSetting).GetProperty(nameof(WindowTopAttackTime));

				case 2031081370:
					return typeof(HdrSetting).GetProperty(nameof(WindowBottomReleaseTime));

				case 3335723049:
					return typeof(HdrSetting).GetProperty(nameof(WindowTopReleaseTimeCurve));

				case 3485908236:
					return typeof(HdrSetting).GetProperty(nameof(DischargeFactor));

				case 2165069867:
					return typeof(HdrSetting).GetProperty(nameof(MaxAllowedEnergy));

				case 1069365659:
					return typeof(HdrSetting).GetProperty(nameof(WindowBottomAttackTime));

				case 1881978028:
					return typeof(HdrSetting).GetProperty(nameof(WindowSize));

				case 2404074926:
					return typeof(HdrSetting).GetProperty(nameof(CompressFactor));

				case 1877971122:
					return typeof(HdrSetting).GetProperty(nameof(Headroom));

				case 730342460:
					return typeof(HdrSetting).GetProperty(nameof(AllowedOvershoot));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
