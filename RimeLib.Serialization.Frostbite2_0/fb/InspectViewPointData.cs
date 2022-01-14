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
	[ContainerType(4, 40)]
	public class InspectViewPointData :
		EbxSerializable
	{
		[ContainerField(0), LayoutImmutable, JsonProperty(Order = 0)]
		public string ViewPointID { get; set; } = string.Empty;
		
		[ContainerField(4), JsonProperty(Order = 4)]
		public List<InspectAnimationTriggerData> AnimationTriggers { get; set; } = new();
		
		[ContainerField(8), JsonProperty(Order = 8)]
		public List<AntRef> ContinuousAnimationSignal { get; set; } = new();
		
		[ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		public float LookAtHeight { get; set; }
		
		[ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		public float Yaw { get; set; }
		
		[ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		public float Pitch { get; set; }
		
		[ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		public float Distance { get; set; }
		
		[ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		public float FovOffset { get; set; }
		
		[ContainerField(32), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		public float AdjustmentYaw { get; set; }
		
		[ContainerField(36), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
		public bool Fixed { get; set; }
		
		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteString(ViewPointID));
			(RimeWriter Writer, uint ArrayIndex) s_AnimationTriggers = p_EbxWriter.GetArrayWriter(AnimationTriggers.GetType(), AnimationTriggers.Count);
			p_Writer.Write(s_AnimationTriggers.ArrayIndex);
			foreach (var s_Entry in AnimationTriggers)
			{
				s_Entry.Serialize(s_AnimationTriggers.Writer, p_EbxWriter);
			}
			(RimeWriter Writer, uint ArrayIndex) s_ContinuousAnimationSignal = p_EbxWriter.GetArrayWriter(ContinuousAnimationSignal.GetType(), ContinuousAnimationSignal.Count);
			p_Writer.Write(s_ContinuousAnimationSignal.ArrayIndex);
			foreach (var s_Entry in ContinuousAnimationSignal)
			{
				s_Entry.Serialize(s_ContinuousAnimationSignal.Writer, p_EbxWriter);
			}
			p_Writer.Write(LookAtHeight);
			p_Writer.Write(Yaw);
			p_Writer.Write(Pitch);
			p_Writer.Write(Distance);
			p_Writer.Write(FovOffset);
			p_Writer.Write(AdjustmentYaw);
			p_Writer.Write(Fixed);
			p_Writer.WriteNullBytes(3);
		}
	}
}
