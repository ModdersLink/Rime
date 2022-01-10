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
	[ContainerType(4, 24)]
	public class PrecomputeCache
	{
		[ContainerField(0), LayoutImmutable, Blittable]
		public GUID Guid { get; set; }
		
		[ContainerField(16), LayoutImmutable]
		public string Key { get; set; } = string.Empty;
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public bool CachedDataEnable { get; set; }
		
		public static void Deserialize(PrecomputeCache p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Guid = new GUID(p_Reader);
			p_Instance.Key = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.CachedDataEnable = p_Reader.ReadBool();
			p_Reader.Seek(3, SeekOrigin.Current);
		}
	}
}
