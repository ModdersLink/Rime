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
	public class DebrisSystemAsset : 
		Asset
	{
		[ContainerField(12)]
		public List<DebrisHavokInfo> HavokMeshes { get; set; } = new();

		[ContainerField(16), LayoutImmutable, Blittable]
		public int HavokMeshCount { get; set; }

		public static void Deserialize(DebrisSystemAsset p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.HavokMeshes.Clear();
			(RimeReader Reader, uint Count) s_HavokMeshes = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_HavokMeshes.Count; ++i)
			{
				var s_Value = new DebrisHavokInfo();
				fb.DebrisHavokInfo.Deserialize(s_Value, s_HavokMeshes.Reader, p_Parser);
				p_Instance.HavokMeshes.Add(s_Value);
			}
			
			s_HavokMeshes.Reader.Dispose();
			p_Instance.HavokMeshCount = p_Reader.ReadInt32();
		}

	}
}
