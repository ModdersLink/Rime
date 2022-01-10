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
	public class PlayerInputTriggerEntityData : 
		EntityData
	{
		[ContainerField(12)]
		public Realm Realm { get; set; } = new();

		[ContainerField(16)]
		public EntryInputActionEnum EntryInputActions { get; set; } = new();

		[ContainerField(20), LayoutImmutable, Blittable]
		public float ValueModifier { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable]
		public float TrailingValueAtStart { get; set; }

		[ContainerField(28), LayoutImmutable, Blittable]
		public float AccumulatedValueAtStart { get; set; }

		[ContainerField(32), LayoutImmutable, Blittable]
		public bool SendTriggerEvents { get; set; }

		[ContainerField(33), LayoutImmutable, Blittable]
		public bool EnabledFromStart { get; set; }

		public static void Deserialize(PlayerInputTriggerEntityData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Realm = (Realm) p_Reader.ReadInt32();
			p_Instance.EntryInputActions = (EntryInputActionEnum) p_Reader.ReadInt32();
			p_Instance.ValueModifier = p_Reader.ReadSingle();
			p_Instance.TrailingValueAtStart = p_Reader.ReadSingle();
			p_Instance.AccumulatedValueAtStart = p_Reader.ReadSingle();
			p_Instance.SendTriggerEvents = p_Reader.ReadBool();
			p_Instance.EnabledFromStart = p_Reader.ReadBool();
			p_Reader.Seek(2, SeekOrigin.Current);
		}

	}
}
