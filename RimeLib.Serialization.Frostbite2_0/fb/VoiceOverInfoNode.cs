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
	public class VoiceOverInfoNode :
		VoiceOverExpressionNode
	{
		[ContainerField(8), JsonProperty(Order = 8)]
		public CtrRef<VoiceOverValueConnection> Object { get; set; } = new();

		[ContainerField(12), JsonProperty(Order = 12)]
		public CtrRef<VoiceOverValue> Value { get; set; } = new();

		[ContainerField(16), JsonProperty(Order = 16)]
		public CtrRef<VoiceOverNamedValue> Field { get; set; } = new();

		[ContainerField(20), JsonProperty(Order = 20)]
		public CtrRef<VoiceOverObject> ExpectedType { get; set; } = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteImport(Object));
			p_Writer.Write(p_EbxWriter.WriteImport(Value));
			p_Writer.Write(p_EbxWriter.WriteImport(Field));
			p_Writer.Write(p_EbxWriter.WriteImport(ExpectedType));
		}
	}
}
