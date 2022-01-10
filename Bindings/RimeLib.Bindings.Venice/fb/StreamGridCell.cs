///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(4, 12)]
	public class StreamGridCell
	{
		[ContainerField(0)]
		public CtrRef<ReferenceObjectData> ReferenceData { get; set; } = new();
		
		[ContainerField(4), LayoutImmutable, Blittable]
		public int X { get; set; }
		
		[ContainerField(8), LayoutImmutable, Blittable]
		public int Z { get; set; }
		
		public static void Deserialize(StreamGridCell p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.ReferenceData.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.X = p_Reader.ReadInt32();
			p_Instance.Z = p_Reader.ReadInt32();
		}
	}
}
