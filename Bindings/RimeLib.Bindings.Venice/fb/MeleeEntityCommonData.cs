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
	[ContainerType(4, 100)]
	public class MeleeEntityCommonData : 
		Asset
	{
		[ContainerField(12)]
		public CharacterMeleeBinding MeleeBinding { get; set; } = new();

		[ContainerField(28)]
		public CharacterMeleeCommonBinding MeleeCommonBinding { get; set; } = new();

		[ContainerField(56), LayoutImmutable, Blittable]
		public float TriggerDelay { get; set; }

		[ContainerField(60), LayoutImmutable, Blittable]
		public float DefendWindow { get; set; }

		[ContainerField(64), LayoutImmutable, Blittable]
		public float KillDelay { get; set; }

		[ContainerField(68), LayoutImmutable, Blittable]
		public float MeleeEndDelay { get; set; }

		[ContainerField(72), LayoutImmutable, Blittable]
		public float InvalidMeleeAttackZone { get; set; }

		[ContainerField(76), LayoutImmutable, Blittable]
		public float MeleeAttackDistance { get; set; }

		[ContainerField(80), LayoutImmutable, Blittable]
		public float MaxAttackHeightDifference { get; set; }

		[ContainerField(84), LayoutImmutable, Blittable]
		public float KillDamage { get; set; }

		[ContainerField(88)]
		public CtrRef<AntEnumeration> ProneAttackType { get; set; } = new();

		[ContainerField(92)]
		public CtrRef<AntEnumeration> CrouchAttackType { get; set; } = new();

		[ContainerField(96), LayoutImmutable, Blittable]
		public bool EnableAbortPossibility { get; set; }

		public static void Deserialize(MeleeEntityCommonData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.CharacterMeleeBinding.Deserialize(p_Instance.MeleeBinding, p_Reader, p_Parser);
			fb.CharacterMeleeCommonBinding.Deserialize(p_Instance.MeleeCommonBinding, p_Reader, p_Parser);
			p_Instance.TriggerDelay = p_Reader.ReadSingle();
			p_Instance.DefendWindow = p_Reader.ReadSingle();
			p_Instance.KillDelay = p_Reader.ReadSingle();
			p_Instance.MeleeEndDelay = p_Reader.ReadSingle();
			p_Instance.InvalidMeleeAttackZone = p_Reader.ReadSingle();
			p_Instance.MeleeAttackDistance = p_Reader.ReadSingle();
			p_Instance.MaxAttackHeightDifference = p_Reader.ReadSingle();
			p_Instance.KillDamage = p_Reader.ReadSingle();
			p_Instance.ProneAttackType.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.CrouchAttackType.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.EnableAbortPossibility = p_Reader.ReadBool();
			p_Reader.Seek(3, SeekOrigin.Current);
		}

	}
}
