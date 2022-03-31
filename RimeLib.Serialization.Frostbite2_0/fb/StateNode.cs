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
	[ContainerType(4, 48)]
	public class StateNode :
		UINodeData
	{
		[ContainerField(20), JsonProperty(Order = 20)]
		public CtrRef<UIScreenAsset> Screen { get; set; } = new();

		[ContainerField(24), JsonProperty(Order = 24)]
		public CtrRef<UINodePort> In { get; set; } = new();

		[ContainerField(28), JsonProperty(Order = 28)]
		public CtrRef<UINodePort> Show { get; set; } = new();

		[ContainerField(32), JsonProperty(Order = 32)]
		public CtrRef<UINodePort> Hide { get; set; } = new();

		[ContainerField(36), JsonProperty(Order = 36)]
		public RefArray<UINodePort> Inputs { get; set; } = new();

		[ContainerField(40), JsonProperty(Order = 40)]
		public RefArray<UINodePort> Outputs { get; set; } = new();

		[ContainerField(44), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
		public bool RenderToTexture { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteImport(Screen));
			p_Writer.Write(p_EbxWriter.WriteImport(In));
			p_Writer.Write(p_EbxWriter.WriteImport(Show));
			p_Writer.Write(p_EbxWriter.WriteImport(Hide));
			(RimeWriter Writer, uint ArrayIndex) s_Inputs = p_EbxWriter.GetArrayWriter(Inputs.GetType(), Inputs.Count);
			p_Writer.Write(s_Inputs.ArrayIndex);
			foreach (var s_Entry in Inputs)
			{
				s_Inputs.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
			(RimeWriter Writer, uint ArrayIndex) s_Outputs = p_EbxWriter.GetArrayWriter(Outputs.GetType(), Outputs.Count);
			p_Writer.Write(s_Outputs.ArrayIndex);
			foreach (var s_Entry in Outputs)
			{
				s_Outputs.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
			p_Writer.Write(RenderToTexture);
			p_Writer.WriteNullBytes(3);
		}
	}
}
