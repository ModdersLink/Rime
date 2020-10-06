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
	[ContainerType(4), MemberInfoFlag(41), ContainerSize(16), ContainerStruct]
	public class UITaggedVehicleCrosshair : FrostbiteContainer
	{
		[ContainerField(0), LayoutImmutable, Blittable, MemberInfoFlag(49469)]
		public float MinDistance { get; set; } // 0x0 (0)
		
		[ContainerField(4), LayoutImmutable, Blittable, MemberInfoFlag(49469)]
		public float MaxDistance { get; set; } // 0x4 (4)
		
		[ContainerField(8), LayoutImmutable, Blittable, MemberInfoFlag(49405)]
		public int MinSize { get; set; } // 0x8 (8)
		
		[ContainerField(12), LayoutImmutable, Blittable, MemberInfoFlag(49405)]
		public int MaxSize { get; set; } // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1885855628:
					MinDistance = (float) p_Value;
					break;

				case 3520454034:
					MaxDistance = (float) p_Value;
					break;

				case 1013127370:
					MinSize = (int) p_Value;
					break;

				case 1313502420:
					MaxSize = (int) p_Value;
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
				case 1885855628:
					return MinDistance;

				case 3520454034:
					return MaxDistance;

				case 1013127370:
					return MinSize;

				case 1313502420:
					return MaxSize;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1885855628:
					return typeof(UITaggedVehicleCrosshair).GetProperty(nameof(MinDistance));

				case 3520454034:
					return typeof(UITaggedVehicleCrosshair).GetProperty(nameof(MaxDistance));

				case 1013127370:
					return typeof(UITaggedVehicleCrosshair).GetProperty(nameof(MinSize));

				case 1313502420:
					return typeof(UITaggedVehicleCrosshair).GetProperty(nameof(MaxSize));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
