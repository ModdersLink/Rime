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
using CommunityToolkit.Mvvm.ComponentModel;

namespace fb
{
	[ContainerType(4, 36)]
	public partial class EnlightenDatabaseAsset :
		Asset
	{
		[ObservableProperty]
		[property: ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		private uint _DataVersion;

		[ObservableProperty]
		[property: ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		private uint _DebugMeshDataVersion;

		[ObservableProperty]
		[property: ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		private uint _OutputSizeX;

		[ObservableProperty]
		[property: ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		private uint _OutputSizeY;

		[ObservableProperty]
		[property: ContainerField(28), JsonProperty(Order = 28)]
		private List<EnlightenDbSystem> _Systems = new();

		[ObservableProperty]
		[property: ContainerField(32), JsonProperty(Order = 32)]
		private List<EnlightenLightProbeSet> _LightProbeSets = new();

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
