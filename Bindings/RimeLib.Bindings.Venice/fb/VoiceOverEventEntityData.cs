///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(4, 36)]
	public class VoiceOverEventEntityData : 
		EntityData
	{
		[ContainerField(12)]
		public CtrRef<VoiceOverNamedValue> EventPlayer { get; set; } = new();

		[ContainerField(16)]
		public CtrRef<VoiceOverEvent> VoEvent { get; set; } = new();

		[ContainerField(20), LayoutImmutable, Blittable]
		public float FinishedDelay { get; set; }

		[ContainerField(24)]
		public CtrRef<VoiceOverNamedValue> ExtraEventPlayer { get; set; } = new();

		[ContainerField(28), LayoutImmutable, Blittable]
		public float TriggerDelay { get; set; }

		[ContainerField(32), LayoutImmutable, Blittable]
		public bool RunOnce { get; set; }

		public static void Deserialize(VoiceOverEventEntityData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.EventPlayer.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.VoEvent.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.FinishedDelay = p_Reader.ReadSingle();
			p_Instance.ExtraEventPlayer.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.TriggerDelay = p_Reader.ReadSingle();
			p_Instance.RunOnce = p_Reader.ReadBool();
			p_Reader.Seek(3, SeekOrigin.Current);
		}

	}
}
