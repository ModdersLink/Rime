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
using RimeLib.Frostbite.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(Alignment: 4,  Flags: 41, Size: 16)]
	public class UITaggedVehicleCrosshair : FrostbiteContainer
	{
		[ContainerField(Name: "MinDistance", Offset: 0, NameHash: 1885855628, Flags: 49469), LayoutImmutable, Blittable]
		public float MinDistance { get; set; } // 0x0 (0)
		
		[ContainerField(Name: "MaxDistance", Offset: 4, NameHash: 3520454034, Flags: 49469), LayoutImmutable, Blittable]
		public float MaxDistance { get; set; } // 0x4 (4)
		
		[ContainerField(Name: "MinSize", Offset: 8, NameHash: 1013127370, Flags: 49405), LayoutImmutable, Blittable]
		public int MinSize { get; set; } // 0x8 (8)
		
		[ContainerField(Name: "MaxSize", Offset: 12, NameHash: 1313502420, Flags: 49405), LayoutImmutable, Blittable]
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
