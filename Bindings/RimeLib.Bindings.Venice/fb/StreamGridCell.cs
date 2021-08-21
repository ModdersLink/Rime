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
	[ContainerType(Alignment: 4,  Flags: 41, Size: 12)]
	public class StreamGridCell : FrostbiteContainer
	{
		[ContainerField(Name: "ReferenceData", Offset: 0, NameHash: 1934350878, Flags: 53)]
		public CtrRef<ReferenceObjectData> ReferenceData { get; set; } = new CtrRef<ReferenceObjectData>(); // 0x0 (0)
		
		[ContainerField(Name: "X", Offset: 4, NameHash: 177661, Flags: 49405), LayoutImmutable, Blittable]
		public int X { get; set; } // 0x4 (4)
		
		[ContainerField(Name: "Z", Offset: 8, NameHash: 177663, Flags: 49405), LayoutImmutable, Blittable]
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
