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
	public class SoundTestSuite :
		DataContainer
	{
		[ContainerField(8), LayoutImmutable, JsonProperty(Order = 8)]
		public string Name { get; set; } = string.Empty;

		[ContainerField(12), JsonProperty(Order = 12)]
		public RefArray<SoundAsset> Assets { get; set; } = new();

		[ContainerField(16), JsonProperty(Order = 16)]
		public RefArray<SoundTestSpec> Tests { get; set; } = new();

		[ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		public bool ProfileTests { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteString(Name));
			(RimeWriter Writer, uint ArrayIndex) s_Assets = p_EbxWriter.GetArrayWriter(Assets.GetType(), Assets.Count);
			p_Writer.Write(s_Assets.ArrayIndex);
			foreach (var s_Entry in Assets)
			{
				s_Assets.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
			(RimeWriter Writer, uint ArrayIndex) s_Tests = p_EbxWriter.GetArrayWriter(Tests.GetType(), Tests.Count);
			p_Writer.Write(s_Tests.ArrayIndex);
			foreach (var s_Entry in Tests)
			{
				s_Tests.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
			p_Writer.Write(ProfileTests);
			p_Writer.WriteNullBytes(3);
		}
	}
}
