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
	public class HavokAsset : 
		Asset
	{
		[ContainerField(12), LayoutImmutable, Blittable]
		public float Scale { get; set; }

		[ContainerField(16)]
		public List<CtrRef<DataContainer>> ExternalAssets { get; set; } = new();

		public static void Deserialize(HavokAsset p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Scale = p_Reader.ReadSingle();
			p_Instance.ExternalAssets.Clear();
			(RimeReader Reader, uint Count) s_ExternalAssets = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_ExternalAssets.Count; ++i)
			{
				var s_CtrRef = new CtrRef<DataContainer>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_ExternalAssets.Reader.ReadUInt32()));
				p_Instance.ExternalAssets.Add(s_CtrRef);
			}
			
			s_ExternalAssets.Reader.Dispose();
		}

	}
}
