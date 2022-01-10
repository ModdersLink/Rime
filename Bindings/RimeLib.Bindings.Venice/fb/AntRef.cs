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
	[ContainerType(4, 4)]
	public class AntRef
	{
		[ContainerField(0), LayoutImmutable, Blittable]
		public int AssetId { get; set; }
		
		public static void Deserialize(AntRef p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.AssetId = p_Reader.ReadInt32();
		}
	}
}
