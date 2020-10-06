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
	[ContainerType(4), MemberInfoFlag(41), ContainerSize(36), ContainerStruct]
	public class UIMinimapConfig : FrostbiteContainer
	{
		[ContainerField(0), LayoutImmutable, Blittable, MemberInfoFlag(49469)]
		public float CombatAreaCameraDelay { get; set; } // 0x0 (0)
		
		[ContainerField(4), LayoutImmutable, Blittable, MemberInfoFlag(49469)]
		public float CameraInterpolationTime { get; set; } // 0x4 (4)
		
		[ContainerField(8), LayoutImmutable, Blittable, MemberInfoFlag(49469)]
		public float CombatAreaFadeSpeed { get; set; } // 0x8 (8)
		
		[ContainerField(12), MemberInfoFlag(65), ContainerArray]
		public List<UIMinimapZoomConfig> ZoomStates { get; set; } = new List<UIMinimapZoomConfig>(); // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable, MemberInfoFlag(49469)]
		public float CameraPanSensitivity { get; set; } // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable, MemberInfoFlag(49469)]
		public float MinVelocity { get; set; } // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable, Blittable, MemberInfoFlag(49469)]
		public float MaxVelocity { get; set; } // 0x18 (24)
		
		[ContainerField(28), LayoutImmutable, Blittable, MemberInfoFlag(49469)]
		public float VelocityModifier { get; set; } // 0x1C (28)
		
		[ContainerField(32), LayoutImmutable, Blittable, MemberInfoFlag(49325)]
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
