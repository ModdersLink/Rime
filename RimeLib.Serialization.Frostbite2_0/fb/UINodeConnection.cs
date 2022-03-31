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
	[ContainerType(4, 28)]
	public class UINodeConnection :
		DataContainer
	{
		[ContainerField(8), JsonProperty(Order = 8)]
		public CtrRef<UINodeData> SourceNode { get; set; } = new();

		[ContainerField(12), JsonProperty(Order = 12)]
		public CtrRef<UINodeData> TargetNode { get; set; } = new();

		[ContainerField(16), JsonProperty(Order = 16)]
		public CtrRef<UINodePort> SourcePort { get; set; } = new();

		[ContainerField(20), JsonProperty(Order = 20)]
		public CtrRef<UINodePort> TargetPort { get; set; } = new();

		[ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		public int NumScreensToPop { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteImport(SourceNode));
			p_Writer.Write(p_EbxWriter.WriteImport(TargetNode));
			p_Writer.Write(p_EbxWriter.WriteImport(SourcePort));
			p_Writer.Write(p_EbxWriter.WriteImport(TargetPort));
			p_Writer.Write(NumScreensToPop);
		}
	}
}
