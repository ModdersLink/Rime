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
	public class CustomizationUnlockParts : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable]
		public string UICategorySid { get; set; } = string.Empty;

		[ContainerField(12)]
		public List<CtrRef<UnlockAssetBase>> SelectableUnlocks { get; set; } = new();

		public static void Deserialize(CustomizationUnlockParts p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.UICategorySid = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.SelectableUnlocks.Clear();
			(RimeReader Reader, uint Count) s_SelectableUnlocks = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_SelectableUnlocks.Count; ++i)
			{
				var s_CtrRef = new CtrRef<UnlockAssetBase>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_SelectableUnlocks.Reader.ReadUInt32()));
				p_Instance.SelectableUnlocks.Add(s_CtrRef);
			}
			
			s_SelectableUnlocks.Reader.Dispose();
		}

	}
}
