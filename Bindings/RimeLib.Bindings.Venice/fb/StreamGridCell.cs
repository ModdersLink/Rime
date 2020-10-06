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
	[ContainerType(4), MemberInfoFlag(41), ContainerSize(12), ContainerStruct]
	public class StreamGridCell : FrostbiteContainer
	{
		[ContainerField(0), MemberInfoFlag(53), ContainerCtrRef]
		public CtrRef<ReferenceObjectData> ReferenceData { get; set; } = new CtrRef<ReferenceObjectData>(); // 0x0 (0)
		
		[ContainerField(4), LayoutImmutable, Blittable, MemberInfoFlag(49405)]
		public int X { get; set; } // 0x4 (4)
		
		[ContainerField(8), LayoutImmutable, Blittable, MemberInfoFlag(49405)]
		public int Z { get; set; } // 0x8 (8)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1934350878:
					ReferenceData = (CtrRef<ReferenceObjectData>) p_Value;
					break;

				case 177661:
					X = (int) p_Value;
					break;

				case 177663:
					Z = (int) p_Value;
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
				case 1934350878:
					return ReferenceData;

				case 177661:
					return X;

				case 177663:
					return Z;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1934350878:
					return typeof(StreamGridCell).GetProperty(nameof(ReferenceData));

				case 177661:
					return typeof(StreamGridCell).GetProperty(nameof(X));

				case 177663:
					return typeof(StreamGridCell).GetProperty(nameof(Z));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
