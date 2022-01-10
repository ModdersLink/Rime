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
	[ContainerType(4, 4)]
	public class CustomizeVisual
	{
		[ContainerField(0)]
		public List<CtrRef<UnlockAsset>> Visual { get; set; } = new();
		
		public static void Deserialize(CustomizeVisual p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Visual.Clear();
			(RimeReader Reader, uint Count) s_Visual = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Visual.Count; ++i)
			{
				var s_CtrRef = new CtrRef<UnlockAsset>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_Visual.Reader.ReadUInt32()));
				p_Instance.Visual.Add(s_CtrRef);
			}
			
			s_Visual.Reader.Dispose();
		}
	}
}
