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
	[ContainerType(4, 40)]
	public partial class InspectViewPointData :
		EbxSerializable
	{
		[ObservableProperty]
		[property: ContainerField(0), LayoutImmutable, JsonProperty(Order = 0)]
		private string _ViewPointID = string.Empty;
		
		[ObservableProperty]
		[property: ContainerField(4), JsonProperty(Order = 4)]
		private List<InspectAnimationTriggerData> _AnimationTriggers = new();
		
		[ObservableProperty]
		[property: ContainerField(8), JsonProperty(Order = 8)]
		private List<AntRef> _ContinuousAnimationSignal = new();
		
		[ObservableProperty]
		[property: ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		private float _LookAtHeight;
		
		[ObservableProperty]
		[property: ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		private float _Yaw;
		
		[ObservableProperty]
		[property: ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		private float _Pitch;
		
		[ObservableProperty]
		[property: ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		private float _Distance;
		
		[ObservableProperty]
		[property: ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		private float _FovOffset;
		
		[ObservableProperty]
		[property: ContainerField(32), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		private float _AdjustmentYaw;
		
		[ObservableProperty]
		[property: ContainerField(36), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
		private bool _Fixed;
		
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
