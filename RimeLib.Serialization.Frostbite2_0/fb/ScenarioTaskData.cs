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
	[ContainerType(16, 80)]
	public class ScenarioTaskData :
		EbxSerializable
	{
		[ContainerField(0), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 0)]
		public Vec3 EndPointWorldOffset { get; set; } = new();
		
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		public Vec3 StartPoint { get; set; } = new();
		
		[ContainerField(32), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		public int ScenarioId { get; set; }
		
		[ContainerField(36), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
		public int ActorId { get; set; }
		
		[ContainerField(40), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
		public int PartId { get; set; }
		
		[ContainerField(44), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
		public int LevelId { get; set; }
		
		[ContainerField(48), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		public float WorldAngle { get; set; }
		
		[ContainerField(52), JsonProperty(Order = 52)]
		public List<LinearTransform> ConnectTransforms { get; set; } = new();
		
		[ContainerField(56), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
		public float StartTurnDistance { get; set; }
		
		[ContainerField(60), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
		public float StartTimerDistance { get; set; }
		
		[ContainerField(64), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
		public float TriggerScenarioDelay { get; set; }
		
		[ContainerField(68), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
		public bool TriggerScenario { get; set; }
		
		[ContainerField(69), LayoutImmutable, Blittable, JsonProperty(Order = 69)]
		public bool UseClientPosition { get; set; }
		
		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			EndPointWorldOffset.Serialize(p_Writer, p_EbxWriter);
			StartPoint.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(ScenarioId);
			p_Writer.Write(ActorId);
			p_Writer.Write(PartId);
			p_Writer.Write(LevelId);
			p_Writer.Write(WorldAngle);
			(RimeWriter Writer, uint ArrayIndex) s_ConnectTransforms = p_EbxWriter.GetArrayWriter(ConnectTransforms.GetType(), ConnectTransforms.Count);
			p_Writer.Write(s_ConnectTransforms.ArrayIndex);
			foreach (var s_Entry in ConnectTransforms)
			{
				s_Entry.Serialize(s_ConnectTransforms.Writer, p_EbxWriter);
			}
			p_Writer.Write(StartTurnDistance);
			p_Writer.Write(StartTimerDistance);
			p_Writer.Write(TriggerScenarioDelay);
			p_Writer.Write(TriggerScenario);
			p_Writer.Write(UseClientPosition);
			p_Writer.WriteNullBytes(10);
		}
	}
}
