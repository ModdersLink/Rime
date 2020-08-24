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
	public class GroundHeightData : FrostbiteContainer
	{
		[ContainerField(0), Homogeneous, LayoutImmutable, Blittable, MemberInfoFlag(53289)]
		public Vec2 HeightSpan { get; set; } = new Vec2(); // 0x0 (0)
		
		[ContainerField(8), LayoutImmutable, Blittable, MemberInfoFlag(49469)]
		public float WorldSize { get; set; } // 0x8 (8)
		
		[ContainerField(12), MemberInfoFlag(65), ContainerArray]
		public List<ushort> Data { get; set; } = new List<ushort>(); // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3361614390:
					HeightSpan = (Vec2) p_Value;
					break;

				case 2492064770:
					WorldSize = (float) p_Value;
					break;

				case 2088730869:
					Data = (List<ushort>) p_Value;
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
				case 3361614390:
					return HeightSpan;

				case 2492064770:
					return WorldSize;

				case 2088730869:
					return Data;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3361614390:
					return typeof(GroundHeightData).GetProperty(nameof(HeightSpan));

				case 2492064770:
					return typeof(GroundHeightData).GetProperty(nameof(WorldSize));

				case 2088730869:
					return typeof(GroundHeightData).GetProperty(nameof(Data));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
