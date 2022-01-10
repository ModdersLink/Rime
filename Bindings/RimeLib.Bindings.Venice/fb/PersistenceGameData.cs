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
	public class PersistenceGameData : 
		Asset
	{
		[ContainerField(12)]
		public List<CtrRef<Asset>> Assets { get; set; } = new();

		public static void Deserialize(PersistenceGameData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Assets.Clear();
			(RimeReader Reader, uint Count) s_Assets = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Assets.Count; ++i)
			{
				var s_CtrRef = new CtrRef<Asset>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_Assets.Reader.ReadUInt32()));
				p_Instance.Assets.Add(s_CtrRef);
			}
			
			s_Assets.Reader.Dispose();
		}

	}
}
