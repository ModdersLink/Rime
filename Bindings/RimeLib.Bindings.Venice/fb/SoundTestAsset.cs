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
	[ContainerType(4, 24)]
	public class SoundTestAsset : 
		Asset
	{
		[ContainerField(12)]
		public List<CtrRef<SoundTestTaskSpec>> TaskSpecs { get; set; } = new();

		[ContainerField(16)]
		public List<CtrRef<SoundTestSpec>> TestSpecs { get; set; } = new();

		[ContainerField(20)]
		public List<CtrRef<SoundTestSuite>> Suites { get; set; } = new();

		public static void Deserialize(SoundTestAsset p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.TaskSpecs.Clear();
			(RimeReader Reader, uint Count) s_TaskSpecs = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_TaskSpecs.Count; ++i)
			{
				var s_CtrRef = new CtrRef<SoundTestTaskSpec>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_TaskSpecs.Reader.ReadUInt32()));
				p_Instance.TaskSpecs.Add(s_CtrRef);
			}
			
			s_TaskSpecs.Reader.Dispose();
			p_Instance.TestSpecs.Clear();
			(RimeReader Reader, uint Count) s_TestSpecs = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_TestSpecs.Count; ++i)
			{
				var s_CtrRef = new CtrRef<SoundTestSpec>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_TestSpecs.Reader.ReadUInt32()));
				p_Instance.TestSpecs.Add(s_CtrRef);
			}
			
			s_TestSpecs.Reader.Dispose();
			p_Instance.Suites.Clear();
			(RimeReader Reader, uint Count) s_Suites = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Suites.Count; ++i)
			{
				var s_CtrRef = new CtrRef<SoundTestSuite>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_Suites.Reader.ReadUInt32()));
				p_Instance.Suites.Add(s_CtrRef);
			}
			
			s_Suites.Reader.Dispose();
		}

	}
}
