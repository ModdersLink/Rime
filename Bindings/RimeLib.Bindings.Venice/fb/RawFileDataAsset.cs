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
	public class RawFileDataAsset : 
		RawFileAsset
	{
		[ContainerField(12)]
		public List<byte> RawData { get; set; } = new();

		[ContainerField(16), LayoutImmutable, Blittable]
		public uint Size { get; set; }

		public static void Deserialize(RawFileDataAsset p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.RawData.Clear();
			(RimeReader Reader, uint Count) s_RawData = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_RawData.Count; ++i)
			{
				var s_Value = s_RawData.Reader.ReadUByte();
				p_Instance.RawData.Add(s_Value);
			}
			
			s_RawData.Reader.Dispose();
			p_Instance.Size = p_Reader.ReadUInt32();
		}

	}
}
