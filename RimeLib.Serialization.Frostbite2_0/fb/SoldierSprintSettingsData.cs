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
	[ContainerType(4, 40)]
	public class SoldierSprintSettingsData :
		DataContainer
	{
		[ContainerField(8), LayoutImmutable, Blittable, JsonProperty(Order = 8)]
		public float Fov { get; set; }

		[ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		public float FovInDelay { get; set; }

		[ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		public float FovInTime { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		public float FovOutDelay { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		public float FovOutTime { get; set; }

		[ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		public float RecoverTime { get; set; }

		[ContainerField(32), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		public float SprintToProneRecoverTime { get; set; }

		[ContainerField(36), JsonProperty(Order = 36)]
		public List<EntryInputActionEnum> InterruptingActions { get; set; } = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(Fov);
			p_Writer.Write(FovInDelay);
			p_Writer.Write(FovInTime);
			p_Writer.Write(FovOutDelay);
			p_Writer.Write(FovOutTime);
			p_Writer.Write(RecoverTime);
			p_Writer.Write(SprintToProneRecoverTime);
			(RimeWriter Writer, uint ArrayIndex) s_InterruptingActions = p_EbxWriter.GetArrayWriter(InterruptingActions.GetType(), InterruptingActions.Count);
			p_Writer.Write(s_InterruptingActions.ArrayIndex);
			foreach (var s_Entry in InterruptingActions)
			{
				s_InterruptingActions.Writer.Write((int) s_Entry);
			}
		}
	}
}
