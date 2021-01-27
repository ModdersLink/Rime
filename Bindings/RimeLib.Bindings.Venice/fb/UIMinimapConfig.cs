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
	[ContainerType(Alignment: 4,  Flags: 41, Size: 36)]
	public class UIMinimapConfig : FrostbiteContainer
	{
		[ContainerField(Name: "CombatAreaCameraDelay", Offset: 0, NameHash: 77672872, Flags: 49469), LayoutImmutable, Blittable]
		public float CombatAreaCameraDelay { get; set; } // 0x0 (0)
		
		[ContainerField(Name: "CameraInterpolationTime", Offset: 4, NameHash: 2739454499, Flags: 49469), LayoutImmutable, Blittable]
		public float CameraInterpolationTime { get; set; } // 0x4 (4)
		
		[ContainerField(Name: "CombatAreaFadeSpeed", Offset: 8, NameHash: 23124261, Flags: 49469), LayoutImmutable, Blittable]
		public float CombatAreaFadeSpeed { get; set; } // 0x8 (8)
		
		[ContainerField(Name: "ZoomStates", Offset: 12, NameHash: 3179811734, Flags: 65)]
		public List<UIMinimapZoomConfig> ZoomStates { get; set; } = new List<UIMinimapZoomConfig>(); // 0xC (12)
		
		[ContainerField(Name: "CameraPanSensitivity", Offset: 16, NameHash: 3636190702, Flags: 49469), LayoutImmutable, Blittable]
		public float CameraPanSensitivity { get; set; } // 0x10 (16)
		
		[ContainerField(Name: "MinVelocity", Offset: 20, NameHash: 1013895128, Flags: 49469), LayoutImmutable, Blittable]
		public float MinVelocity { get; set; } // 0x14 (20)
		
		[ContainerField(Name: "MaxVelocity", Offset: 24, NameHash: 81127366, Flags: 49469), LayoutImmutable, Blittable]
		public float MaxVelocity { get; set; } // 0x18 (24)
		
		[ContainerField(Name: "VelocityModifier", Offset: 28, NameHash: 278805925, Flags: 49469), LayoutImmutable, Blittable]
		public float VelocityModifier { get; set; } // 0x1C (28)
		
		[ContainerField(Name: "DisableDefaultState", Offset: 32, NameHash: 3302098829, Flags: 49325), LayoutImmutable, Blittable]
		public bool DisableDefaultState { get; set; } // 0x20 (32)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 77672872:
					CombatAreaCameraDelay = (float) p_Value;
					break;

				case 2739454499:
					CameraInterpolationTime = (float) p_Value;
					break;

				case 23124261:
					CombatAreaFadeSpeed = (float) p_Value;
					break;

				case 3179811734:
					ZoomStates = (List<UIMinimapZoomConfig>) p_Value;
					break;

				case 3636190702:
					CameraPanSensitivity = (float) p_Value;
					break;

				case 1013895128:
					MinVelocity = (float) p_Value;
					break;

				case 81127366:
					MaxVelocity = (float) p_Value;
					break;

				case 278805925:
					VelocityModifier = (float) p_Value;
					break;

				case 3302098829:
					DisableDefaultState = (bool) p_Value;
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
				case 77672872:
					return CombatAreaCameraDelay;

				case 2739454499:
					return CameraInterpolationTime;

				case 23124261:
					return CombatAreaFadeSpeed;

				case 3179811734:
					return ZoomStates;

				case 3636190702:
					return CameraPanSensitivity;

				case 1013895128:
					return MinVelocity;

				case 81127366:
					return MaxVelocity;

				case 278805925:
					return VelocityModifier;

				case 3302098829:
					return DisableDefaultState;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 77672872:
					return typeof(UIMinimapConfig).GetProperty(nameof(CombatAreaCameraDelay));

				case 2739454499:
					return typeof(UIMinimapConfig).GetProperty(nameof(CameraInterpolationTime));

				case 23124261:
					return typeof(UIMinimapConfig).GetProperty(nameof(CombatAreaFadeSpeed));

				case 3179811734:
					return typeof(UIMinimapConfig).GetProperty(nameof(ZoomStates));

				case 3636190702:
					return typeof(UIMinimapConfig).GetProperty(nameof(CameraPanSensitivity));

				case 1013895128:
					return typeof(UIMinimapConfig).GetProperty(nameof(MinVelocity));

				case 81127366:
					return typeof(UIMinimapConfig).GetProperty(nameof(MaxVelocity));

				case 278805925:
					return typeof(UIMinimapConfig).GetProperty(nameof(VelocityModifier));

				case 3302098829:
					return typeof(UIMinimapConfig).GetProperty(nameof(DisableDefaultState));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
