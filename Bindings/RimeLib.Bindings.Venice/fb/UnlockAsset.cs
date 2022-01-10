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
	[ContainerType(4, 44)]
	public class UnlockAsset : 
		UnlockAssetBase
	{
		[ContainerField(40)]
		public List<CtrRef<Asset>> LinkedTo { get; set; } = new();

		public static void Deserialize(UnlockAsset p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.LinkedTo.Clear();
			(RimeReader Reader, uint Count) s_LinkedTo = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_LinkedTo.Count; ++i)
			{
				var s_CtrRef = new CtrRef<Asset>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_LinkedTo.Reader.ReadUInt32()));
				p_Instance.LinkedTo.Add(s_CtrRef);
			}
			
			s_LinkedTo.Reader.Dispose();
		}

	}
}
