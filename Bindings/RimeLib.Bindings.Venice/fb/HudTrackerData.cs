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
	public class HudTrackerData : 
		UIPartData
	{
		[ContainerField(8), LayoutImmutable, Blittable]
		public float MaxDistance { get; set; } // 0x8 (8)
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public float StartFadeDistance { get; set; } // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public float SecondFadeDistance { get; set; } // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public float FadeMinAlpha { get; set; } // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public float IconSize { get; set; } // 0x18 (24)
		
		[ContainerField(28), LayoutImmutable, Blittable]
		public float TrackerHudRadiusX { get; set; } // 0x1C (28)
		
		[ContainerField(32), LayoutImmutable, Blittable]
		public float TrackerHudRadiusY { get; set; } // 0x20 (32)
		
		[ContainerField(36), LayoutImmutable, Blittable]
		public float DistanceTextOffsetY { get; set; } // 0x24 (36)
		
		[ContainerField(40), LayoutImmutable, Blittable]
		public bool ShowDistance { get; set; } // 0x28 (40)
		
		[ContainerField(41), LayoutImmutable, Blittable]
		public bool DisplayExtraInfo { get; set; } // 0x29 (41)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3520454034:
					MaxDistance = (float) p_Value;
					break;

				case 3933898304:
					StartFadeDistance = (float) p_Value;
					break;

				case 3692182672:
					SecondFadeDistance = (float) p_Value;
					break;

				case 1370953373:
					FadeMinAlpha = (float) p_Value;
					break;

				case 269738667:
					IconSize = (float) p_Value;
					break;

				case 494741604:
					TrackerHudRadiusX = (float) p_Value;
					break;

				case 494741605:
					TrackerHudRadiusY = (float) p_Value;
					break;

				case 1402020303:
					DistanceTextOffsetY = (float) p_Value;
					break;

				case 3259763813:
					ShowDistance = (bool) p_Value;
					break;

				case 2583928395:
					DisplayExtraInfo = (bool) p_Value;
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
				case 3520454034:
					return MaxDistance;

				case 3933898304:
					return StartFadeDistance;

				case 3692182672:
					return SecondFadeDistance;

				case 1370953373:
					return FadeMinAlpha;

				case 269738667:
					return IconSize;

				case 494741604:
					return TrackerHudRadiusX;

				case 494741605:
					return TrackerHudRadiusY;

				case 1402020303:
					return DistanceTextOffsetY;

				case 3259763813:
					return ShowDistance;

				case 2583928395:
					return DisplayExtraInfo;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3520454034:
					return typeof(HudTrackerData).GetProperty(nameof(MaxDistance));

				case 3933898304:
					return typeof(HudTrackerData).GetProperty(nameof(StartFadeDistance));

				case 3692182672:
					return typeof(HudTrackerData).GetProperty(nameof(SecondFadeDistance));

				case 1370953373:
					return typeof(HudTrackerData).GetProperty(nameof(FadeMinAlpha));

				case 269738667:
					return typeof(HudTrackerData).GetProperty(nameof(IconSize));

				case 494741604:
					return typeof(HudTrackerData).GetProperty(nameof(TrackerHudRadiusX));

				case 494741605:
					return typeof(HudTrackerData).GetProperty(nameof(TrackerHudRadiusY));

				case 1402020303:
					return typeof(HudTrackerData).GetProperty(nameof(DistanceTextOffsetY));

				case 3259763813:
					return typeof(HudTrackerData).GetProperty(nameof(ShowDistance));

				case 2583928395:
					return typeof(HudTrackerData).GetProperty(nameof(DisplayExtraInfo));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
