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
	[ContainerType(4, 16)]
	public class SoundPrimeEntityData : 
		EntityData
	{
		[ContainerField(12)]
		public List<CtrRef<SoundDataAsset>> DataAssets { get; set; } = new();

		public static void Deserialize(SoundPrimeEntityData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.DataAssets.Clear();
			(RimeReader Reader, uint Count) s_DataAssets = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_DataAssets.Count; ++i)
			{
				var s_CtrRef = new CtrRef<SoundDataAsset>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_DataAssets.Reader.ReadUInt32()));
				p_Instance.DataAssets.Add(s_CtrRef);
			}
			
			s_DataAssets.Reader.Dispose();
		}

	}
}
