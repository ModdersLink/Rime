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
	[ContainerType(4, 164)]
	public class VeniceSoldierHealthModuleData : 
		SoldierHealthModuleData
	{
		[ContainerField(8), LayoutImmutable, Blittable]
		public float TimeForCorpse { get; set; }

		[ContainerField(12), LayoutImmutable, Blittable]
		public float PostReviveResponseTime { get; set; }

		[ContainerField(16), LayoutImmutable, Blittable]
		public float InteractiveManDownThreshold { get; set; }

		[ContainerField(20)]
		public PoseConstraintsData InteractiveManDownPoseConstraints { get; set; } = new();

		[ContainerField(24), LayoutImmutable, Blittable]
		public float ManDownStateTime { get; set; }

		[ContainerField(28), LayoutImmutable, Blittable]
		public float ManDownStateHealthPoints { get; set; }

		[ContainerField(32), LayoutImmutable, Blittable]
		public float ImmortalTimeAfterSpawn { get; set; }

		[ContainerField(36)]
		public List<EntryInputActionEnum> AbortSpawnImmortalityInputs { get; set; } = new();

		[ContainerField(40), LayoutImmutable, Blittable]
		public float PostReviveHealth { get; set; }

		[ContainerField(44), LayoutImmutable, Blittable]
		public float CriticalFakeImmortalTime { get; set; }

		[ContainerField(48), LayoutImmutable, Blittable]
		public float RegenerationDelay { get; set; }

		[ContainerField(52), LayoutImmutable, Blittable]
		public float RegenerationRate { get; set; }

		[ContainerField(56)]
		public SoldierHealthModuleBinding Binding { get; set; } = new();

		[ContainerField(148), LayoutImmutable, Blittable]
		public float SprintDisabledWhenDamagedTime { get; set; }

		[ContainerField(152), LayoutImmutable, Blittable]
		public float SprintDisabledDamageThreshold { get; set; }

		[ContainerField(156)]
		public RotateToHitData ManDownRotate { get; set; } = new();

		[ContainerField(160), LayoutImmutable, Blittable]
		public bool InteractiveManDown { get; set; }

		public static void Deserialize(VeniceSoldierHealthModuleData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.TimeForCorpse = p_Reader.ReadSingle();
			p_Instance.PostReviveResponseTime = p_Reader.ReadSingle();
			p_Instance.InteractiveManDownThreshold = p_Reader.ReadSingle();
			fb.PoseConstraintsData.Deserialize(p_Instance.InteractiveManDownPoseConstraints, p_Reader, p_Parser);
			p_Reader.Seek(1, SeekOrigin.Current);
			p_Instance.ManDownStateTime = p_Reader.ReadSingle();
			p_Reader.Seek(1, SeekOrigin.Current);
			p_Instance.ManDownStateHealthPoints = p_Reader.ReadSingle();
			p_Reader.Seek(1, SeekOrigin.Current);
			p_Instance.ImmortalTimeAfterSpawn = p_Reader.ReadSingle();
			p_Reader.Seek(1, SeekOrigin.Current);
			p_Instance.AbortSpawnImmortalityInputs.Clear();
			(RimeReader Reader, uint Count) s_AbortSpawnImmortalityInputs = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_AbortSpawnImmortalityInputs.Count; ++i)
			{
				var s_Value = (EntryInputActionEnum) s_AbortSpawnImmortalityInputs.Reader.ReadInt32();
				p_Instance.AbortSpawnImmortalityInputs.Add(s_Value);
			}
			
			s_AbortSpawnImmortalityInputs.Reader.Dispose();
			p_Reader.Seek(1, SeekOrigin.Current);
			p_Instance.PostReviveHealth = p_Reader.ReadSingle();
			p_Reader.Seek(1, SeekOrigin.Current);
			p_Instance.CriticalFakeImmortalTime = p_Reader.ReadSingle();
			p_Reader.Seek(1, SeekOrigin.Current);
			p_Instance.RegenerationDelay = p_Reader.ReadSingle();
			p_Reader.Seek(1, SeekOrigin.Current);
			p_Instance.RegenerationRate = p_Reader.ReadSingle();
			p_Reader.Seek(1, SeekOrigin.Current);
			fb.SoldierHealthModuleBinding.Deserialize(p_Instance.Binding, p_Reader, p_Parser);
			p_Reader.Seek(1, SeekOrigin.Current);
			p_Instance.SprintDisabledWhenDamagedTime = p_Reader.ReadSingle();
			p_Reader.Seek(1, SeekOrigin.Current);
			p_Instance.SprintDisabledDamageThreshold = p_Reader.ReadSingle();
			p_Reader.Seek(1, SeekOrigin.Current);
			fb.RotateToHitData.Deserialize(p_Instance.ManDownRotate, p_Reader, p_Parser);
			p_Reader.Seek(1, SeekOrigin.Current);
			p_Instance.InteractiveManDown = p_Reader.ReadBool();
			p_Reader.Seek(4, SeekOrigin.Current);
		}

	}
}
