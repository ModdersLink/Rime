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

using fb.Core;
using fb.Entity;

namespace fb.Physics;

[ContainerType(8, 112)]
public class CharacterPhysicsData
	: fb.Core.Asset
{
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public RefArray<CharacterPoseData> Poses { get; set; } = new();
	
	[ContainerField(0x20), JsonProperty(Order = 32)]
	public RefArray<CharacterStateData> States { get; set; } = new();
	
	[ContainerField(0x28), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
	public CharacterStateType DefaultState { get; set; } = CharacterStateType.CharacterStateType_OnGround;
	
	[ContainerField(0x30), JsonProperty(Order = 48)]
	public CtrRef<CharacterSprintData> Sprint { get; set; } = new();
	
	[ContainerField(0x38), JsonProperty(Order = 56)]
	public MaterialDecl MaterialPair { get; set; } = new();
	
	[ContainerField(0x3c), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
	public int PushableObjectWeight { get; set; } = 100;
	
	[ContainerField(0x40), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
	public float Mass { get; set; } = 100.000f;
	
	[ContainerField(0x44), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
	public float MaxAscendAngle { get; set; } = 60.000f;
	
	[ContainerField(0x48), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
	public float PhysicalRadius { get; set; } = 0.300f;
	
	[ContainerField(0x4c), LayoutImmutable, Blittable, JsonProperty(Order = 76)]
	public float EnterSwimStateDepth { get; set; } = 1.000f;
	
	[ContainerField(0x50), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
	public float ExitSwimStateDepth { get; set; } = 0.800f;
	
	[ContainerField(0x54), LayoutImmutable, Blittable, JsonProperty(Order = 84)]
	public float InputAcceleration { get; set; } = 3.000f;
	
	[ContainerField(0x58), LayoutImmutable, Blittable, JsonProperty(Order = 88)]
	public float LadderAcceptAngle { get; set; } = 30.000f;
	
	[ContainerField(0x5c), LayoutImmutable, Blittable, JsonProperty(Order = 92)]
	public float LadderAcceptAnglePitch { get; set; } = -15.000f;
	
	[ContainerField(0x60), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
	public float JumpPenaltyTime { get; set; } = 2.000f;
	
	[ContainerField(0x64), LayoutImmutable, Blittable, JsonProperty(Order = 100)]
	public float JumpPenaltyFactor { get; set; } = 0.300f;
	
	[ContainerField(0x68), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
	public float RadiusToPredictCollisionOnCharacters { get; set; } = 0.000f;
	
	[ContainerField(0x6c), LayoutImmutable, Blittable, JsonProperty(Order = 108)]
	public bool AllowPoseChangeDuringTransition { get; set; } = true;
	
	[ContainerField(0x6d), LayoutImmutable, Blittable, JsonProperty(Order = 109)]
	public bool AutoPushAwayFromWallsInProne { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		(RimeWriter Writer, uint ArrayIndex) s_Poses = p_EbxWriter.GetArrayWriter(Poses.GetType(), Poses.Count);
		p_Writer.Write(s_Poses.ArrayIndex);
		foreach (var s_Entry in Poses)
		{
			s_Poses.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_States = p_EbxWriter.GetArrayWriter(States.GetType(), States.Count);
		p_Writer.Write(s_States.ArrayIndex);
		foreach (var s_Entry in States)
		{
			s_States.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write((int) DefaultState);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(Sprint));
		p_Writer.WriteNullBytes(4);
		MaterialPair.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(PushableObjectWeight);
		p_Writer.Write(Mass);
		p_Writer.Write(MaxAscendAngle);
		p_Writer.Write(PhysicalRadius);
		p_Writer.Write(EnterSwimStateDepth);
		p_Writer.Write(ExitSwimStateDepth);
		p_Writer.Write(InputAcceleration);
		p_Writer.Write(LadderAcceptAngle);
		p_Writer.Write(LadderAcceptAnglePitch);
		p_Writer.Write(JumpPenaltyTime);
		p_Writer.Write(JumpPenaltyFactor);
		p_Writer.Write(RadiusToPredictCollisionOnCharacters);
		p_Writer.Write(AllowPoseChangeDuringTransition);
		p_Writer.Write(AutoPushAwayFromWallsInProne);
		p_Writer.WriteNullBytes(2);
	}
}

