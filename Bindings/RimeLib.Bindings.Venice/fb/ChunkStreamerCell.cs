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
	[ContainerType(4), MemberInfoFlag(41), ContainerSize(8), ContainerStruct]
	public class ChunkStreamerCell : FrostbiteContainer
	{
		[ContainerField(0), MemberInfoFlag(65), ContainerArray]
		public List<Vec2> Shape { get; set; } = new List<Vec2>(); // 0x0 (0)
		
		[ContainerField(4), LayoutImmutable, MemberInfoFlag(16509)]
		public string BundleName { get; set; } // 0x4 (4)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 231753450:
					Shape = (List<Vec2>) p_Value;
					break;

				case 461157046:
					BundleName = (string) p_Value;
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
				case 231753450:
					return Shape;

				case 461157046:
					return BundleName;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 231753450:
					return typeof(ChunkStreamerCell).GetProperty(nameof(Shape));

				case 461157046:
					return typeof(ChunkStreamerCell).GetProperty(nameof(BundleName));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
