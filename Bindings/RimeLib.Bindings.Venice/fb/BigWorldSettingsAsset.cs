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
	public class BigWorldSettingsAsset : 
		Asset
	{
		[ContainerField(12)]
		public List<CtrRef<BigWorldSetting>> Settings { get; set; } = new();

		public static void Deserialize(BigWorldSettingsAsset p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Settings.Clear();
			(RimeReader Reader, uint Count) s_Settings = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Settings.Count; ++i)
			{
				var s_CtrRef = new CtrRef<BigWorldSetting>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_Settings.Reader.ReadUInt32()));
				p_Instance.Settings.Add(s_CtrRef);
			}
			
			s_Settings.Reader.Dispose();
		}

	}
}
