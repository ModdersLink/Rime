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
	[ContainerType(16, 64)]
	public class UpdateSizeData : 
		ProcessorData
	{
		[ContainerField(48), Homogeneous, LayoutImmutable, Blittable]
		public Vec2 Pivot { get; set; } = new();

		public static void Deserialize(UpdateSizeData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.Vec2.Deserialize(p_Instance.Pivot, p_Reader, p_Parser);
			p_Reader.Seek(8, SeekOrigin.Current);
		}

	}
}
