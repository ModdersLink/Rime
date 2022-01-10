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
	[ContainerType(4, 8)]
	public class UIntRange
	{
		[ContainerField(0), LayoutImmutable, Blittable]
		public uint Min { get; set; }
		
		[ContainerField(4), LayoutImmutable, Blittable]
		public uint Max { get; set; }
		
		public static void Deserialize(UIntRange p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Min = p_Reader.ReadUInt32();
			p_Instance.Max = p_Reader.ReadUInt32();
		}
	}
}
