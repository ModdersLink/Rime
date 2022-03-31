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
	[ContainerType(4, 36)]
	public class EnlightenDatabaseAsset :
		Asset
	{
		[ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		public uint DataVersion { get; set; }

		[ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		public uint DebugMeshDataVersion { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		public uint OutputSizeX { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		public uint OutputSizeY { get; set; }

		[ContainerField(28), JsonProperty(Order = 28)]
		public List<EnlightenDbSystem> Systems { get; set; } = new();

		[ContainerField(32), JsonProperty(Order = 32)]
		public List<EnlightenLightProbeSet> LightProbeSets { get; set; } = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(DataVersion);
			p_Writer.Write(DebugMeshDataVersion);
			p_Writer.Write(OutputSizeX);
			p_Writer.Write(OutputSizeY);
			(RimeWriter Writer, uint ArrayIndex) s_Systems = p_EbxWriter.GetArrayWriter(Systems.GetType(), Systems.Count);
			p_Writer.Write(s_Systems.ArrayIndex);
			foreach (var s_Entry in Systems)
			{
				s_Entry.Serialize(s_Systems.Writer, p_EbxWriter);
			}
			(RimeWriter Writer, uint ArrayIndex) s_LightProbeSets = p_EbxWriter.GetArrayWriter(LightProbeSets.GetType(), LightProbeSets.Count);
			p_Writer.Write(s_LightProbeSets.ArrayIndex);
			foreach (var s_Entry in LightProbeSets)
			{
				s_Entry.Serialize(s_LightProbeSets.Writer, p_EbxWriter);
			}
		}
	}
}
