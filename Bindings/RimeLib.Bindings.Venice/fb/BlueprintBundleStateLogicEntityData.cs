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
	[ContainerType(16, 112)]
	public class BlueprintBundleStateLogicEntityData : 
		GameEntityData
	{
		[ContainerField(96)]
		public List<string> BundleNames { get; set; } = new();

		public static void Deserialize(BlueprintBundleStateLogicEntityData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.BundleNames.Clear();
			(RimeReader Reader, uint Count) s_BundleNames = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_BundleNames.Count; ++i)
			{
				var s_Value = p_Parser.GetStringAtOffset(s_BundleNames.Reader.ReadUInt32());
				p_Instance.BundleNames.Add(s_Value);
			}
			
			s_BundleNames.Reader.Dispose();
			p_Reader.Seek(12, SeekOrigin.Current);
		}

	}
}
