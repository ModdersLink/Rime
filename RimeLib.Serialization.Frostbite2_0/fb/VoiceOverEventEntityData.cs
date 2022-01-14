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
	[ContainerType(4, 36)]
	public class VoiceOverEventEntityData :
		EntityData
	{
		[ContainerField(12), JsonProperty(Order = 12)]
		public CtrRef<VoiceOverNamedValue> EventPlayer { get; set; } = new();

		[ContainerField(16), JsonProperty(Order = 16)]
		public CtrRef<VoiceOverEvent> VoEvent { get; set; } = new();

		[ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		public float FinishedDelay { get; set; }

		[ContainerField(24), JsonProperty(Order = 24)]
		public CtrRef<VoiceOverNamedValue> ExtraEventPlayer { get; set; } = new();

		[ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		public float TriggerDelay { get; set; }

		[ContainerField(32), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		public bool RunOnce { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteImport(EventPlayer));
			p_Writer.Write(p_EbxWriter.WriteImport(VoEvent));
			p_Writer.Write(FinishedDelay);
			p_Writer.Write(p_EbxWriter.WriteImport(ExtraEventPlayer));
			p_Writer.Write(TriggerDelay);
			p_Writer.Write(RunOnce);
			p_Writer.WriteNullBytes(3);
		}
	}
}
