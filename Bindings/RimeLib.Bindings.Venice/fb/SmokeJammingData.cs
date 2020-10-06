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
	[ContainerType(4), MemberInfoFlag(41), ContainerSize(20), ContainerStruct]
	public class SmokeJammingData : FrostbiteContainer
	{
		[ContainerField(0), LayoutImmutable, Blittable, MemberInfoFlag(49469)]
		public float JammingTime { get; set; } // 0x0 (0)
		
		[ContainerField(4), LayoutImmutable, Blittable, MemberInfoFlag(49469)]
		public float MaxRadius { get; set; } // 0x4 (4)
		
		[ContainerField(8), LayoutImmutable, Blittable, MemberInfoFlag(49469)]
		public float MinRadius { get; set; } // 0x8 (8)
		
		[ContainerField(12), LayoutImmutable, Blittable, MemberInfoFlag(49469)]
		public float TargetUpdateTime { get; set; } // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable, MemberInfoFlag(49325)]
		public bool EnableSmokeJamming { get; set; } // 0x10 (16)
		
		[ContainerField(17), LayoutImmutable, Blittable, MemberInfoFlag(49325)]
		public bool JammingPositionIsLocationDependent { get; set; } // 0x11 (17)
		
		[ContainerField(18), LayoutImmutable, Blittable, MemberInfoFlag(49325)]
		public bool ReportJammedBasedOnStartPosition { get; set; } // 0x12 (18)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 46309755:
					JammingTime = (float) p_Value;
					break;

				case 439602313:
					MaxRadius = (float) p_Value;
					break;

				case 4053568023:
					MinRadius = (float) p_Value;
					break;

				case 18960400:
					TargetUpdateTime = (float) p_Value;
					break;

				case 3034547280:
					EnableSmokeJamming = (bool) p_Value;
					break;

				case 3550251569:
					JammingPositionIsLocationDependent = (bool) p_Value;
					break;

				case 2195169576:
					ReportJammedBasedOnStartPosition = (bool) p_Value;
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
				case 46309755:
					return JammingTime;

				case 439602313:
					return MaxRadius;

				case 4053568023:
					return MinRadius;

				case 18960400:
					return TargetUpdateTime;

				case 3034547280:
					return EnableSmokeJamming;

				case 3550251569:
					return JammingPositionIsLocationDependent;

				case 2195169576:
					return ReportJammedBasedOnStartPosition;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 46309755:
					return typeof(SmokeJammingData).GetProperty(nameof(JammingTime));

				case 439602313:
					return typeof(SmokeJammingData).GetProperty(nameof(MaxRadius));

				case 4053568023:
					return typeof(SmokeJammingData).GetProperty(nameof(MinRadius));

				case 18960400:
					return typeof(SmokeJammingData).GetProperty(nameof(TargetUpdateTime));

				case 3034547280:
					return typeof(SmokeJammingData).GetProperty(nameof(EnableSmokeJamming));

				case 3550251569:
					return typeof(SmokeJammingData).GetProperty(nameof(JammingPositionIsLocationDependent));

				case 2195169576:
					return typeof(SmokeJammingData).GetProperty(nameof(ReportJammedBasedOnStartPosition));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
