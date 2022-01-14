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
using RimeLib.Serialization.Ebx;
using RimeLib.Serialization.Frostbite2_0.Ebx;

namespace fb
{
	[ContainerType(4, 24)]
	public class LevelSetup :
		EbxSerializable
	{
		[ContainerField(0), LayoutImmutable, JsonProperty(Order = 0)]
		public string Name { get; set; } = string.Empty;
		
		[ContainerField(4), JsonProperty(Order = 4)]
		public List<LevelSetupOption> InclusionOptions { get; set; } = new();
		
		[ContainerField(8), LayoutImmutable, Blittable, JsonProperty(Order = 8)]
		public uint DifficultyIndex { get; set; }
		
		[ContainerField(12), JsonProperty(Order = 12)]
		public List<string> SubLevelNames { get; set; } = new();
		
		[ContainerField(16), JsonProperty(Order = 16)]
		public List<int> SubLevelStates { get; set; } = new();
		
		[ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		public bool IsSaveGame { get; set; }
		
		[ContainerField(21), LayoutImmutable, Blittable, JsonProperty(Order = 21)]
		public bool ForceReloadResources { get; set; }
		
		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteString(Name));
			(RimeWriter Writer, uint ArrayIndex) s_InclusionOptions = p_EbxWriter.GetArrayWriter(InclusionOptions.GetType(), InclusionOptions.Count);
			p_Writer.Write(s_InclusionOptions.ArrayIndex);
			foreach (var s_Entry in InclusionOptions)
			{
				s_Entry.Serialize(s_InclusionOptions.Writer, p_EbxWriter);
			}
			p_Writer.Write(DifficultyIndex);
			(RimeWriter Writer, uint ArrayIndex) s_SubLevelNames = p_EbxWriter.GetArrayWriter(SubLevelNames.GetType(), SubLevelNames.Count);
			p_Writer.Write(s_SubLevelNames.ArrayIndex);
			foreach (var s_Entry in SubLevelNames)
			{
				s_SubLevelNames.Writer.Write(p_EbxWriter.WriteString(s_Entry));
			}
			(RimeWriter Writer, uint ArrayIndex) s_SubLevelStates = p_EbxWriter.GetArrayWriter(SubLevelStates.GetType(), SubLevelStates.Count);
			p_Writer.Write(s_SubLevelStates.ArrayIndex);
			foreach (var s_Entry in SubLevelStates)
			{
				s_SubLevelStates.Writer.Write(s_Entry);
			}
			p_Writer.Write(IsSaveGame);
			p_Writer.Write(ForceReloadResources);
			p_Writer.WriteNullBytes(2);
		}
	}
}
