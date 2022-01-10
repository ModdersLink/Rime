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
	public class UnlockableColorCollection : 
		DataContainer
	{
		[ContainerField(8)]
		public CtrRef<ColorReference> DefaultValue { get; set; } = new();

		[ContainerField(12)]
		public List<CtrRef<ColorUnlockPartData>> PossibleValues { get; set; } = new();

		public static void Deserialize(UnlockableColorCollection p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.DefaultValue.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.PossibleValues.Clear();
			(RimeReader Reader, uint Count) s_PossibleValues = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_PossibleValues.Count; ++i)
			{
				var s_CtrRef = new CtrRef<ColorUnlockPartData>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_PossibleValues.Reader.ReadUInt32()));
				p_Instance.PossibleValues.Add(s_CtrRef);
			}
			
			s_PossibleValues.Reader.Dispose();
		}

	}
}
