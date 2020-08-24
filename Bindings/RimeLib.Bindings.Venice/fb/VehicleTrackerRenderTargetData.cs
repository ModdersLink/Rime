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
	public class VehicleTrackerRenderTargetData : FrostbiteContainer
	{
		[ContainerField(0), Homogeneous, LayoutImmutable, Blittable, MemberInfoFlag(53289)]
		public Vec2 PositionOffset { get; set; } = new Vec2(); // 0x0 (0)
		
		[ContainerField(8), LayoutImmutable, Blittable, MemberInfoFlag(49405)]
		public int RenderTargetIndex { get; set; } // 0x8 (8)
		
		[ContainerField(12), LayoutImmutable, Blittable, MemberInfoFlag(49469)]
		public float RenderTargetApectRatio { get; set; } // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable, MemberInfoFlag(49469)]
		public float ScaleSize { get; set; } // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable, MemberInfoFlag(49325)]
		public bool UseRenderTarget { get; set; } // 0x14 (20)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3901577617:
					PositionOffset = (Vec2) p_Value;
					break;

				case 3545373920:
					RenderTargetIndex = (int) p_Value;
					break;

				case 984520476:
					RenderTargetApectRatio = (float) p_Value;
					break;

				case 563381912:
					ScaleSize = (float) p_Value;
					break;

				case 3192099997:
					UseRenderTarget = (bool) p_Value;
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
				case 3901577617:
					return PositionOffset;

				case 3545373920:
					return RenderTargetIndex;

				case 984520476:
					return RenderTargetApectRatio;

				case 563381912:
					return ScaleSize;

				case 3192099997:
					return UseRenderTarget;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3901577617:
					return typeof(VehicleTrackerRenderTargetData).GetProperty(nameof(PositionOffset));

				case 3545373920:
					return typeof(VehicleTrackerRenderTargetData).GetProperty(nameof(RenderTargetIndex));

				case 984520476:
					return typeof(VehicleTrackerRenderTargetData).GetProperty(nameof(RenderTargetApectRatio));

				case 563381912:
					return typeof(VehicleTrackerRenderTargetData).GetProperty(nameof(ScaleSize));

				case 3192099997:
					return typeof(VehicleTrackerRenderTargetData).GetProperty(nameof(UseRenderTarget));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
