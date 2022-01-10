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
	public class MaterialContainerAsset : 
		Asset
	{
		[ContainerField(12)]
		public List<CtrRef<MaterialContainerPair>> MaterialPairs { get; set; } = new();

		[ContainerField(16)]
		public List<string> MaterialNames { get; set; } = new();

		public static void Deserialize(MaterialContainerAsset p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.MaterialPairs.Clear();
			(RimeReader Reader, uint Count) s_MaterialPairs = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_MaterialPairs.Count; ++i)
			{
				var s_CtrRef = new CtrRef<MaterialContainerPair>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_MaterialPairs.Reader.ReadUInt32()));
				p_Instance.MaterialPairs.Add(s_CtrRef);
			}
			
			s_MaterialPairs.Reader.Dispose();
			p_Instance.MaterialNames.Clear();
			(RimeReader Reader, uint Count) s_MaterialNames = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_MaterialNames.Count; ++i)
			{
				var s_Value = p_Parser.GetStringAtOffset(s_MaterialNames.Reader.ReadUInt32());
				p_Instance.MaterialNames.Add(s_Value);
			}
			
			s_MaterialNames.Reader.Dispose();
		}

	}
}
