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
	public class ValueUnlockAsset : 
		UnlockAssetBase
	{
		[ContainerField(40)]
		public List<CtrRef<UnlockValuePair>> UnlockValues { get; set; } = new();

		public static void Deserialize(ValueUnlockAsset p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.UnlockValues.Clear();
			(RimeReader Reader, uint Count) s_UnlockValues = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_UnlockValues.Count; ++i)
			{
				var s_CtrRef = new CtrRef<UnlockValuePair>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_UnlockValues.Reader.ReadUInt32()));
				p_Instance.UnlockValues.Add(s_CtrRef);
			}
			
			s_UnlockValues.Reader.Dispose();
		}

	}
}
