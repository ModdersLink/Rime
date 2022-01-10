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
	[ContainerType(16, 144)]
	public class ControllableEntityData : 
		GamePhysicsEntityData
	{
		[ContainerField(112), LayoutImmutable, Blittable]
		public float LowHealthThreshold { get; set; }

		[ContainerField(116)]
		public TeamId DefaultTeam { get; set; } = new();

		[ContainerField(120)]
		public CtrRef<MaterialContainerPair> MaterialPair { get; set; } = new();

		[ContainerField(124), LayoutImmutable, Blittable]
		public bool ResetTeamOnLastPlayerExits { get; set; }

		[ContainerField(125), LayoutImmutable, Blittable]
		public bool FakeImmortal { get; set; }

		[ContainerField(126), LayoutImmutable, Blittable]
		public bool UsePrediction { get; set; }

		[ContainerField(127), LayoutImmutable, Blittable]
		public bool Immortal { get; set; }

		[ContainerField(128), LayoutImmutable, Blittable]
		public bool ForceForegroundRendering { get; set; }

		public static void Deserialize(ControllableEntityData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.LowHealthThreshold = p_Reader.ReadSingle();
			p_Instance.DefaultTeam = (TeamId) p_Reader.ReadInt32();
			p_Instance.MaterialPair.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.ResetTeamOnLastPlayerExits = p_Reader.ReadBool();
			p_Instance.FakeImmortal = p_Reader.ReadBool();
			p_Instance.UsePrediction = p_Reader.ReadBool();
			p_Instance.Immortal = p_Reader.ReadBool();
			p_Instance.ForceForegroundRendering = p_Reader.ReadBool();
			p_Reader.Seek(15, SeekOrigin.Current);
		}

	}
}
