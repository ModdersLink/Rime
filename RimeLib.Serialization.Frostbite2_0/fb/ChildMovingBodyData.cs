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
	[ContainerType(16, 112)]
	public class ChildMovingBodyData :
		LinearMovingBodyData
	{
		[ContainerField(80), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
		public float InputDelay { get; set; }

		[ContainerField(84), LayoutImmutable, Blittable, JsonProperty(Order = 84)]
		public float Speed { get; set; }

		[ContainerField(88), JsonProperty(Order = 88)]
		public EntryInputActionEnum InputAction { get; set; } = new();

		[ContainerField(92), LayoutImmutable, Blittable, JsonProperty(Order = 92)]
		public float TriggerImpulse { get; set; }

		[ContainerField(96), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
		public bool IsOneShotInput { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(InputDelay);
			p_Writer.Write(Speed);
			p_Writer.Write((int) InputAction);
			p_Writer.Write(TriggerImpulse);
			p_Writer.Write(IsOneShotInput);
			p_Writer.WriteNullBytes(15);
		}
	}
}
