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
	public class VoiceOverDistanceNode :
		VoiceOverExpressionNode
	{
		[ContainerField(8), JsonProperty(Order = 8)]
		public CtrRef<VoiceOverValueConnection> A { get; set; } = new();

		[ContainerField(12), JsonProperty(Order = 12)]
		public CtrRef<VoiceOverValueConnection> B { get; set; } = new();

		[ContainerField(16), JsonProperty(Order = 16)]
		public CtrRef<VoiceOverValueConnection> Threshold { get; set; } = new();

		[ContainerField(20), JsonProperty(Order = 20)]
		public CtrRef<VoiceOverValue> Distance { get; set; } = new();

		[ContainerField(24), JsonProperty(Order = 24)]
		public CtrRef<VoiceOverValue> False { get; set; } = new();

		[ContainerField(28), JsonProperty(Order = 28)]
		public CtrRef<VoiceOverValue> True { get; set; } = new();

		[ContainerField(32), JsonProperty(Order = 32)]
		public VoiceOverCompareExpressionType Operation { get; set; } = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteImport(A));
			p_Writer.Write(p_EbxWriter.WriteImport(B));
			p_Writer.Write(p_EbxWriter.WriteImport(Threshold));
			p_Writer.Write(p_EbxWriter.WriteImport(Distance));
			p_Writer.Write(p_EbxWriter.WriteImport(False));
			p_Writer.Write(p_EbxWriter.WriteImport(True));
			p_Writer.Write((int) Operation);
		}
	}
}
