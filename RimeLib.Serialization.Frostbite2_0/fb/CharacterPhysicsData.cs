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
	[ContainerType(4, 80)]
	public partial class CharacterPhysicsData :
		Asset
	{
		[ObservableProperty]
		[property: ContainerField(12), JsonProperty(Order = 12)]
		private RefArray<CharacterPoseData> _Poses = new();

		[ObservableProperty]
		[property: ContainerField(16), JsonProperty(Order = 16)]
		private RefArray<CharacterStateData> _States = new();

		[ObservableProperty]
		[property: ContainerField(20), JsonProperty(Order = 20)]
		private CharacterStateType _DefaultState = new();

		[ObservableProperty]
		[property: ContainerField(24), JsonProperty(Order = 24)]
		private CtrRef<CharacterSprintData> _Sprint = new();

		[ObservableProperty]
		[property: ContainerField(28), JsonProperty(Order = 28)]
		private CtrRef<MaterialContainerPair> _MaterialPair = new();

		[ObservableProperty]
		[property: ContainerField(32), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		private int _PushableObjectWeight;

		[ObservableProperty]
		[property: ContainerField(36), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
		private float _Mass;

		[ObservableProperty]
		[property: ContainerField(40), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
		private float _MaxAscendAngle;

		[ObservableProperty]
		[property: ContainerField(44), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
		private float _PhysicalRadius;

		[ObservableProperty]
		[property: ContainerField(48), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		private float _WaterDepthLimit;

		[ObservableProperty]
		[property: ContainerField(52), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
		private float _InputAcceleration;

		[ObservableProperty]
		[property: ContainerField(56), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
		private float _LadderAcceptAngle;

		[ObservableProperty]
		[property: ContainerField(60), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
		private float _LadderAcceptAnglePitch;

		[ObservableProperty]
		[property: ContainerField(64), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
		private float _JumpPenaltyTime;

		[ObservableProperty]
		[property: ContainerField(68), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
		private float _JumpPenaltyFactor;

		[ObservableProperty]
		[property: ContainerField(72), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
		private float _RadiusToPredictCollisionOnCharacters;

		[ObservableProperty]
		[property: ContainerField(76), LayoutImmutable, Blittable, JsonProperty(Order = 76)]
		private bool _AllowPoseChangeDuringTransition;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			(RimeWriter Writer, uint ArrayIndex) s_Poses = p_EbxWriter.GetArrayWriter(Poses.GetType(), Poses.Count);
			p_Writer.Write(s_Poses.ArrayIndex);
			foreach (var s_Entry in Poses)
			{
				s_Poses.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
			(RimeWriter Writer, uint ArrayIndex) s_States = p_EbxWriter.GetArrayWriter(States.GetType(), States.Count);
			p_Writer.Write(s_States.ArrayIndex);
			foreach (var s_Entry in States)
			{
				s_States.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
			p_Writer.Write((int) DefaultState);
			p_Writer.Write(p_EbxWriter.WriteImport(Sprint));
			p_Writer.Write(p_EbxWriter.WriteImport(MaterialPair));
			p_Writer.Write(PushableObjectWeight);
			p_Writer.Write(Mass);
			p_Writer.Write(MaxAscendAngle);
			p_Writer.Write(PhysicalRadius);
			p_Writer.Write(WaterDepthLimit);
			p_Writer.Write(InputAcceleration);
			p_Writer.Write(LadderAcceptAngle);
			p_Writer.Write(LadderAcceptAnglePitch);
			p_Writer.Write(JumpPenaltyTime);
			p_Writer.Write(JumpPenaltyFactor);
			p_Writer.Write(RadiusToPredictCollisionOnCharacters);
			p_Writer.Write(AllowPoseChangeDuringTransition);
			p_Writer.WriteNullBytes(3);
		}
	}
}
