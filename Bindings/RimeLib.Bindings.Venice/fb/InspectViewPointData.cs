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
	[ContainerType(4), MemberInfoFlag(41), ContainerStruct]
	public class InspectViewPointData : FrostbiteContainer
	{
		[ContainerField(0), LayoutImmutable, MemberInfoFlag(16509)]
		public string ViewPointID { get; set; } // 0x0 (0)
		
		[ContainerField(4), MemberInfoFlag(65), ContainerArray]
		public List<InspectAnimationTriggerData> AnimationTriggers { get; set; } = new List<InspectAnimationTriggerData>(); // 0x4 (4)
		
		[ContainerField(8), MemberInfoFlag(65), ContainerArray]
		public List<AntRef> ContinuousAnimationSignal { get; set; } = new List<AntRef>(); // 0x8 (8)
		
		[ContainerField(12), LayoutImmutable, Blittable, MemberInfoFlag(49469)]
		public float LookAtHeight { get; set; } // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable, MemberInfoFlag(49469)]
		public float Yaw { get; set; } // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable, MemberInfoFlag(49469)]
		public float Pitch { get; set; } // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable, Blittable, MemberInfoFlag(49469)]
		public float Distance { get; set; } // 0x18 (24)
		
		[ContainerField(28), LayoutImmutable, Blittable, MemberInfoFlag(49469)]
		public float FovOffset { get; set; } // 0x1C (28)
		
		[ContainerField(32), LayoutImmutable, Blittable, MemberInfoFlag(49469)]
		public float AdjustmentYaw { get; set; } // 0x20 (32)
		
		[ContainerField(36), LayoutImmutable, Blittable, MemberInfoFlag(49325)]
		public bool Fixed { get; set; } // 0x24 (36)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3058990665:
					ViewPointID = (string) p_Value;
					break;

				case 870786648:
					AnimationTriggers = (List<InspectAnimationTriggerData>) p_Value;
					break;

				case 2681825504:
					ContinuousAnimationSignal = (List<AntRef>) p_Value;
					break;

				case 11825096:
					LookAtHeight = (float) p_Value;
					break;

				case 193468618:
					Yaw = (float) p_Value;
					break;

				case 232604323:
					Pitch = (float) p_Value;
					break;

				case 408560070:
					Distance = (float) p_Value;
					break;

				case 1171027895:
					FovOffset = (float) p_Value;
					break;

				case 782014309:
					AdjustmentYaw = (float) p_Value;
					break;

				case 206684275:
					Fixed = (bool) p_Value;
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
				case 3058990665:
					return ViewPointID;

				case 870786648:
					return AnimationTriggers;

				case 2681825504:
					return ContinuousAnimationSignal;

				case 11825096:
					return LookAtHeight;

				case 193468618:
					return Yaw;

				case 232604323:
					return Pitch;

				case 408560070:
					return Distance;

				case 1171027895:
					return FovOffset;

				case 782014309:
					return AdjustmentYaw;

				case 206684275:
					return Fixed;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3058990665:
					return typeof(InspectViewPointData).GetProperty(nameof(ViewPointID));

				case 870786648:
					return typeof(InspectViewPointData).GetProperty(nameof(AnimationTriggers));

				case 2681825504:
					return typeof(InspectViewPointData).GetProperty(nameof(ContinuousAnimationSignal));

				case 11825096:
					return typeof(InspectViewPointData).GetProperty(nameof(LookAtHeight));

				case 193468618:
					return typeof(InspectViewPointData).GetProperty(nameof(Yaw));

				case 232604323:
					return typeof(InspectViewPointData).GetProperty(nameof(Pitch));

				case 408560070:
					return typeof(InspectViewPointData).GetProperty(nameof(Distance));

				case 1171027895:
					return typeof(InspectViewPointData).GetProperty(nameof(FovOffset));

				case 782014309:
					return typeof(InspectViewPointData).GetProperty(nameof(AdjustmentYaw));

				case 206684275:
					return typeof(InspectViewPointData).GetProperty(nameof(Fixed));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
