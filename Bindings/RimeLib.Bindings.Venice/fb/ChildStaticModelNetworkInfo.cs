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
	[ContainerType(4, 20)]
	public class ChildStaticModelNetworkInfo
	{
		[ContainerField(0)]
		public IndexRange NetworkRange { get; set; } = new();
		
		[ContainerField(8), LayoutImmutable, Blittable]
		public uint ParentPartComponentIndex { get; set; }
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public uint ParentHealthStateIndex { get; set; }
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public uint InstanceIndex { get; set; }
		
		public static void Deserialize(ChildStaticModelNetworkInfo p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.IndexRange.Deserialize(p_Instance.NetworkRange, p_Reader, p_Parser);
			p_Instance.ParentPartComponentIndex = p_Reader.ReadUInt32();
			p_Instance.ParentHealthStateIndex = p_Reader.ReadUInt32();
			p_Instance.InstanceIndex = p_Reader.ReadUInt32();
		}
	}
}
