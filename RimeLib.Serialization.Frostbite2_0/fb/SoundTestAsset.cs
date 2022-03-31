///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;
using RimeLib.Serialization.Frostbite2_0.Ebx;

namespace fb
{
	[ContainerType(4, 24)]
	public class SoundTestAsset :
		Asset
	{
		[ContainerField(12), JsonProperty(Order = 12)]
		public RefArray<SoundTestTaskSpec> TaskSpecs { get; set; } = new();

		[ContainerField(16), JsonProperty(Order = 16)]
		public RefArray<SoundTestSpec> TestSpecs { get; set; } = new();

		[ContainerField(20), JsonProperty(Order = 20)]
		public RefArray<SoundTestSuite> Suites { get; set; } = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			(RimeWriter Writer, uint ArrayIndex) s_TaskSpecs = p_EbxWriter.GetArrayWriter(TaskSpecs.GetType(), TaskSpecs.Count);
			p_Writer.Write(s_TaskSpecs.ArrayIndex);
			foreach (var s_Entry in TaskSpecs)
			{
				s_TaskSpecs.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
			(RimeWriter Writer, uint ArrayIndex) s_TestSpecs = p_EbxWriter.GetArrayWriter(TestSpecs.GetType(), TestSpecs.Count);
			p_Writer.Write(s_TestSpecs.ArrayIndex);
			foreach (var s_Entry in TestSpecs)
			{
				s_TestSpecs.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
			(RimeWriter Writer, uint ArrayIndex) s_Suites = p_EbxWriter.GetArrayWriter(Suites.GetType(), Suites.Count);
			p_Writer.Write(s_Suites.ArrayIndex);
			foreach (var s_Entry in Suites)
			{
				s_Suites.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
		}
	}
}
