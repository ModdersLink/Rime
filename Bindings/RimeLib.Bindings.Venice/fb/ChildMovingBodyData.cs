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
	[ContainerType(16, 112)]
	public class ChildMovingBodyData : 
		LinearMovingBodyData
	{
		[ContainerField(80), LayoutImmutable, Blittable]
		public float InputDelay { get; set; }

		[ContainerField(84), LayoutImmutable, Blittable]
		public float Speed { get; set; }

		[ContainerField(88)]
		public EntryInputActionEnum InputAction { get; set; } = new();

		[ContainerField(92), LayoutImmutable, Blittable]
		public float TriggerImpulse { get; set; }

		[ContainerField(96), LayoutImmutable, Blittable]
		public bool IsOneShotInput { get; set; }

		public static void Deserialize(ChildMovingBodyData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.InputDelay = p_Reader.ReadSingle();
			p_Instance.Speed = p_Reader.ReadSingle();
			p_Instance.InputAction = (EntryInputActionEnum) p_Reader.ReadInt32();
			p_Instance.TriggerImpulse = p_Reader.ReadSingle();
			p_Instance.IsOneShotInput = p_Reader.ReadBool();
			p_Reader.Seek(15, SeekOrigin.Current);
		}

	}
}
