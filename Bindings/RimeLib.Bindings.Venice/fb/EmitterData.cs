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
	[ContainerType(16, 64)]
	public class EmitterData : 
		ProcessorData
	{
		[ContainerField(48)]
		public List<CtrRef<EmitterDocument>> EmitterAssets { get; set; } = new();

		public static void Deserialize(EmitterData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.EmitterAssets.Clear();
			(RimeReader Reader, uint Count) s_EmitterAssets = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_EmitterAssets.Count; ++i)
			{
				var s_CtrRef = new CtrRef<EmitterDocument>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_EmitterAssets.Reader.ReadUInt32()));
				p_Instance.EmitterAssets.Add(s_CtrRef);
			}
			
			s_EmitterAssets.Reader.Dispose();
			p_Reader.Seek(12, SeekOrigin.Current);
		}

	}
}
