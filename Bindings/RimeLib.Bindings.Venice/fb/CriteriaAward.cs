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
	public class CriteriaAward
	{
		[ContainerField(0)]
		public CtrRef<AwardData> Award { get; set; } = new();
		
		[ContainerField(4), LayoutImmutable, Blittable]
		public uint Count { get; set; }
		
		[ContainerField(8), LayoutImmutable]
		public string Sid { get; set; } = string.Empty;
		
		public static void Deserialize(CriteriaAward p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Award.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.Count = p_Reader.ReadUInt32();
			p_Instance.Sid = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
		}
	}
}
