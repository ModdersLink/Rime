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
	[ContainerType(4, 56)]
	public class RotorParameters : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable, Blittable]
		public float CyclicInputScaleRoll { get; set; }

		[ContainerField(12), LayoutImmutable, Blittable]
		public float CyclicInputScalePitch { get; set; }

		[ContainerField(16), LayoutImmutable, Blittable]
		public float CollectiveThrottleInputScale { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable]
		public float CollectiveBrakeInputScale { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable]
		public float CollectiveInputIdle { get; set; }

		[ContainerField(28), LayoutImmutable, Blittable]
		public float HorizontalForceModifier { get; set; }

		[ContainerField(32)]
		public List<Vec2> AngleOfAttack { get; set; } = new();

		[ContainerField(36), LayoutImmutable, Blittable]
		public float CyclicFadeOutOffset { get; set; }

		[ContainerField(40), LayoutImmutable, Blittable]
		public float AdditionalGravityModifier { get; set; }

		[ContainerField(44), LayoutImmutable, Blittable]
		public float HorisontalMinEffectMod { get; set; }

		[ContainerField(48), LayoutImmutable, Blittable]
		public float HorisontalMinEffectVelocity { get; set; }

		[ContainerField(52), LayoutImmutable, Blittable]
		public bool EnableHorisontalMinEffect { get; set; }

		[ContainerField(53), LayoutImmutable, Blittable]
		public bool ReverseThrottle { get; set; }

		public static void Deserialize(RotorParameters p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.CyclicInputScaleRoll = p_Reader.ReadSingle();
			p_Instance.CyclicInputScalePitch = p_Reader.ReadSingle();
			p_Instance.CollectiveThrottleInputScale = p_Reader.ReadSingle();
			p_Instance.CollectiveBrakeInputScale = p_Reader.ReadSingle();
			p_Instance.CollectiveInputIdle = p_Reader.ReadSingle();
			p_Instance.HorizontalForceModifier = p_Reader.ReadSingle();
			p_Instance.AngleOfAttack.Clear();
			(RimeReader Reader, uint Count) s_AngleOfAttack = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_AngleOfAttack.Count; ++i)
			{
				var s_Value = new Vec2();
				fb.Vec2.Deserialize(s_Value, s_AngleOfAttack.Reader, p_Parser);
				p_Instance.AngleOfAttack.Add(s_Value);
			}
			
			s_AngleOfAttack.Reader.Dispose();
			p_Instance.CyclicFadeOutOffset = p_Reader.ReadSingle();
			p_Instance.AdditionalGravityModifier = p_Reader.ReadSingle();
			p_Instance.HorisontalMinEffectMod = p_Reader.ReadSingle();
			p_Instance.HorisontalMinEffectVelocity = p_Reader.ReadSingle();
			p_Instance.EnableHorisontalMinEffect = p_Reader.ReadBool();
			p_Instance.ReverseThrottle = p_Reader.ReadBool();
			p_Reader.Seek(2, SeekOrigin.Current);
		}

	}
}
