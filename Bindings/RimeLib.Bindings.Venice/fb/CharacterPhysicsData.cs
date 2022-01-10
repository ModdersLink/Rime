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
	[ContainerType(4, 80)]
	public class CharacterPhysicsData : 
		Asset
	{
		[ContainerField(12)]
		public List<CtrRef<CharacterPoseData>> Poses { get; set; } = new();

		[ContainerField(16)]
		public List<CtrRef<CharacterStateData>> States { get; set; } = new();

		[ContainerField(20)]
		public CharacterStateType DefaultState { get; set; } = new();

		[ContainerField(24)]
		public CtrRef<CharacterSprintData> Sprint { get; set; } = new();

		[ContainerField(28)]
		public CtrRef<MaterialContainerPair> MaterialPair { get; set; } = new();

		[ContainerField(32), LayoutImmutable, Blittable]
		public int PushableObjectWeight { get; set; }

		[ContainerField(36), LayoutImmutable, Blittable]
		public float Mass { get; set; }

		[ContainerField(40), LayoutImmutable, Blittable]
		public float MaxAscendAngle { get; set; }

		[ContainerField(44), LayoutImmutable, Blittable]
		public float PhysicalRadius { get; set; }

		[ContainerField(48), LayoutImmutable, Blittable]
		public float WaterDepthLimit { get; set; }

		[ContainerField(52), LayoutImmutable, Blittable]
		public float InputAcceleration { get; set; }

		[ContainerField(56), LayoutImmutable, Blittable]
		public float LadderAcceptAngle { get; set; }

		[ContainerField(60), LayoutImmutable, Blittable]
		public float LadderAcceptAnglePitch { get; set; }

		[ContainerField(64), LayoutImmutable, Blittable]
		public float JumpPenaltyTime { get; set; }

		[ContainerField(68), LayoutImmutable, Blittable]
		public float JumpPenaltyFactor { get; set; }

		[ContainerField(72), LayoutImmutable, Blittable]
		public float RadiusToPredictCollisionOnCharacters { get; set; }

		[ContainerField(76), LayoutImmutable, Blittable]
		public bool AllowPoseChangeDuringTransition { get; set; }

		public static void Deserialize(CharacterPhysicsData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Poses.Clear();
			(RimeReader Reader, uint Count) s_Poses = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Poses.Count; ++i)
			{
				var s_CtrRef = new CtrRef<CharacterPoseData>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_Poses.Reader.ReadUInt32()));
				p_Instance.Poses.Add(s_CtrRef);
			}
			
			s_Poses.Reader.Dispose();
			p_Instance.States.Clear();
			(RimeReader Reader, uint Count) s_States = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_States.Count; ++i)
			{
				var s_CtrRef = new CtrRef<CharacterStateData>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_States.Reader.ReadUInt32()));
				p_Instance.States.Add(s_CtrRef);
			}
			
			s_States.Reader.Dispose();
			p_Instance.DefaultState = (CharacterStateType) p_Reader.ReadInt32();
			p_Instance.Sprint.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.MaterialPair.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.PushableObjectWeight = p_Reader.ReadInt32();
			p_Instance.Mass = p_Reader.ReadSingle();
			p_Instance.MaxAscendAngle = p_Reader.ReadSingle();
			p_Instance.PhysicalRadius = p_Reader.ReadSingle();
			p_Instance.WaterDepthLimit = p_Reader.ReadSingle();
			p_Instance.InputAcceleration = p_Reader.ReadSingle();
			p_Instance.LadderAcceptAngle = p_Reader.ReadSingle();
			p_Instance.LadderAcceptAnglePitch = p_Reader.ReadSingle();
			p_Instance.JumpPenaltyTime = p_Reader.ReadSingle();
			p_Instance.JumpPenaltyFactor = p_Reader.ReadSingle();
			p_Instance.RadiusToPredictCollisionOnCharacters = p_Reader.ReadSingle();
			p_Instance.AllowPoseChangeDuringTransition = p_Reader.ReadBool();
			p_Reader.Seek(3, SeekOrigin.Current);
		}

	}
}
