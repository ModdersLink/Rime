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
	[ContainerType(4, 28)]
	public class TargetEvaluationConstantData : 
		Asset
	{
		[ContainerField(12), LayoutImmutable, Blittable]
		public float MaxBattleStrength { get; set; }

		[ContainerField(16), LayoutImmutable, Blittable]
		public float DefaultHumanTargetPreference { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable]
		public float OtherSquadAttackerFactorUsage { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable]
		public float TargetFlipFactorUsage { get; set; }

		public static void Deserialize(TargetEvaluationConstantData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.MaxBattleStrength = p_Reader.ReadSingle();
			p_Instance.DefaultHumanTargetPreference = p_Reader.ReadSingle();
			p_Instance.OtherSquadAttackerFactorUsage = p_Reader.ReadSingle();
			p_Instance.TargetFlipFactorUsage = p_Reader.ReadSingle();
		}

	}
}
