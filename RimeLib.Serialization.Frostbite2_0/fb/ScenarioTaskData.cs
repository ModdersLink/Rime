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
using CommunityToolkit.Mvvm.ComponentModel;

namespace fb
{
	[ContainerType(16, 80)]
	public partial class ScenarioTaskData :
		EbxSerializable
	{
		[ObservableProperty]
		[property: ContainerField(0), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 0)]
		private Vec3 _EndPointWorldOffset = new();
		
		[ObservableProperty]
		[property: ContainerField(16), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		private Vec3 _StartPoint = new();
		
		[ObservableProperty]
		[property: ContainerField(32), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		private int _ScenarioId;
		
		[ObservableProperty]
		[property: ContainerField(36), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
		private int _ActorId;
		
		[ObservableProperty]
		[property: ContainerField(40), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
		private int _PartId;
		
		[ObservableProperty]
		[property: ContainerField(44), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
		private int _LevelId;
		
		[ObservableProperty]
		[property: ContainerField(48), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		private float _WorldAngle;
		
		[ObservableProperty]
		[property: ContainerField(52), JsonProperty(Order = 52)]
		private List<LinearTransform> _ConnectTransforms = new();
		
		[ObservableProperty]
		[property: ContainerField(56), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
		private float _StartTurnDistance;
		
		[ObservableProperty]
		[property: ContainerField(60), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
		private float _StartTimerDistance;
		
		[ObservableProperty]
		[property: ContainerField(64), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
		private float _TriggerScenarioDelay;
		
		[ObservableProperty]
		[property: ContainerField(68), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
		private bool _TriggerScenario;
		
		[ObservableProperty]
		[property: ContainerField(69), LayoutImmutable, Blittable, JsonProperty(Order = 69)]
		private bool _UseClientPosition;
		
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
