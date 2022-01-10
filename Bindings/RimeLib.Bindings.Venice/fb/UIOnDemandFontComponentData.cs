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
	[ContainerType(4, 32)]
	public class UIOnDemandFontComponentData : 
		UIComponentData
	{
		[ContainerField(28)]
		public List<CtrRef<UIFontCollection>> FontCollections { get; set; } = new();

		public static void Deserialize(UIOnDemandFontComponentData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.FontCollections.Clear();
			(RimeReader Reader, uint Count) s_FontCollections = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_FontCollections.Count; ++i)
			{
				var s_CtrRef = new CtrRef<UIFontCollection>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_FontCollections.Reader.ReadUInt32()));
				p_Instance.FontCollections.Add(s_CtrRef);
			}
			
			s_FontCollections.Reader.Dispose();
		}

	}
}
