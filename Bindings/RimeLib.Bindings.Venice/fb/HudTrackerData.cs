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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 44)]
	public class HudTrackerData : 
		UIPartData
	{
		protected float m_MaxDistance = new float();
		[ContainerField(Name: "MaxDistance", Offset: 8, NameHash: 3520454034, Flags: 49469), LayoutImmutable, Blittable]
		public float MaxDistance { get { return m_MaxDistance; } set { if (OnPropertyChanging("HudTrackerData." + nameof(MaxDistance), this, m_MaxDistance, value)) m_MaxDistance = value; } } // 0x8 (8)
		
		protected float m_StartFadeDistance = new float();
		[ContainerField(Name: "StartFadeDistance", Offset: 12, NameHash: 3933898304, Flags: 49469), LayoutImmutable, Blittable]
		public float StartFadeDistance { get { return m_StartFadeDistance; } set { if (OnPropertyChanging("HudTrackerData." + nameof(StartFadeDistance), this, m_StartFadeDistance, value)) m_StartFadeDistance = value; } } // 0xC (12)
		
		protected float m_SecondFadeDistance = new float();
		[ContainerField(Name: "SecondFadeDistance", Offset: 16, NameHash: 3692182672, Flags: 49469), LayoutImmutable, Blittable]
		public float SecondFadeDistance { get { return m_SecondFadeDistance; } set { if (OnPropertyChanging("HudTrackerData." + nameof(SecondFadeDistance), this, m_SecondFadeDistance, value)) m_SecondFadeDistance = value; } } // 0x10 (16)
		
		protected float m_FadeMinAlpha = new float();
		[ContainerField(Name: "FadeMinAlpha", Offset: 20, NameHash: 1370953373, Flags: 49469), LayoutImmutable, Blittable]
		public float FadeMinAlpha { get { return m_FadeMinAlpha; } set { if (OnPropertyChanging("HudTrackerData." + nameof(FadeMinAlpha), this, m_FadeMinAlpha, value)) m_FadeMinAlpha = value; } } // 0x14 (20)
		
		protected float m_IconSize = new float();
		[ContainerField(Name: "IconSize", Offset: 24, NameHash: 269738667, Flags: 49469), LayoutImmutable, Blittable]
		public float IconSize { get { return m_IconSize; } set { if (OnPropertyChanging("HudTrackerData." + nameof(IconSize), this, m_IconSize, value)) m_IconSize = value; } } // 0x18 (24)
		
		protected float m_TrackerHudRadiusX = new float();
		[ContainerField(Name: "TrackerHudRadiusX", Offset: 28, NameHash: 494741604, Flags: 49469), LayoutImmutable, Blittable]
		public float TrackerHudRadiusX { get { return m_TrackerHudRadiusX; } set { if (OnPropertyChanging("HudTrackerData." + nameof(TrackerHudRadiusX), this, m_TrackerHudRadiusX, value)) m_TrackerHudRadiusX = value; } } // 0x1C (28)
		
		protected float m_TrackerHudRadiusY = new float();
		[ContainerField(Name: "TrackerHudRadiusY", Offset: 32, NameHash: 494741605, Flags: 49469), LayoutImmutable, Blittable]
		public float TrackerHudRadiusY { get { return m_TrackerHudRadiusY; } set { if (OnPropertyChanging("HudTrackerData." + nameof(TrackerHudRadiusY), this, m_TrackerHudRadiusY, value)) m_TrackerHudRadiusY = value; } } // 0x20 (32)
		
		protected float m_DistanceTextOffsetY = new float();
		[ContainerField(Name: "DistanceTextOffsetY", Offset: 36, NameHash: 1402020303, Flags: 49469), LayoutImmutable, Blittable]
		public float DistanceTextOffsetY { get { return m_DistanceTextOffsetY; } set { if (OnPropertyChanging("HudTrackerData." + nameof(DistanceTextOffsetY), this, m_DistanceTextOffsetY, value)) m_DistanceTextOffsetY = value; } } // 0x24 (36)
		
		protected bool m_ShowDistance = new bool();
		[ContainerField(Name: "ShowDistance", Offset: 40, NameHash: 3259763813, Flags: 49325), LayoutImmutable, Blittable]
		public bool ShowDistance { get { return m_ShowDistance; } set { if (OnPropertyChanging("HudTrackerData." + nameof(ShowDistance), this, m_ShowDistance, value)) m_ShowDistance = value; } } // 0x28 (40)
		
		protected bool m_DisplayExtraInfo = new bool();
		[ContainerField(Name: "DisplayExtraInfo", Offset: 41, NameHash: 2583928395, Flags: 49325), LayoutImmutable, Blittable]
		public bool DisplayExtraInfo { get { return m_DisplayExtraInfo; } set { if (OnPropertyChanging("HudTrackerData." + nameof(DisplayExtraInfo), this, m_DisplayExtraInfo, value)) m_DisplayExtraInfo = value; } } // 0x29 (41)
		
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
