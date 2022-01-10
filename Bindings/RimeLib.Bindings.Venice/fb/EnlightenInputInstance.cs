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
	[ContainerType(16, 80)]
	public class EnlightenInputInstance
	{
		[ContainerField(0), Homogeneous, LayoutImmutable, Blittable]
		public LinearTransform Transform { get; set; } = new();
		
		[ContainerField(64), LayoutImmutable]
		public string Asset { get; set; } = string.Empty;
		
		[ContainerField(68), LayoutImmutable]
		public string ObjectVariation { get; set; } = string.Empty;
		
		[ContainerField(72), LayoutImmutable, Blittable]
		public int SystemId { get; set; }
		
		public static void Deserialize(EnlightenInputInstance p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.LinearTransform.Deserialize(p_Instance.Transform, p_Reader, p_Parser);
			p_Instance.Asset = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.ObjectVariation = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.SystemId = p_Reader.ReadInt32();
			p_Reader.Seek(4, SeekOrigin.Current);
		}
	}
}
