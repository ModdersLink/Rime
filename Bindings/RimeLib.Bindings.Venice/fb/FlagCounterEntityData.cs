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
	[ContainerType(16, 128)]
	public class FlagCounterEntityData : 
		GameEntityData
	{
		[ContainerField(96)]
		public TeamId TeamId { get; set; } = new();

		[ContainerField(100), LayoutImmutable, Blittable]
		public float EnemyFlagProgress { get; set; }

		[ContainerField(104), LayoutImmutable, Blittable]
		public float RoundTime { get; set; }

		[ContainerField(108), LayoutImmutable, Blittable]
		public int ObjectiveFlagCount { get; set; }

		[ContainerField(112), LayoutImmutable, Blittable]
		public bool VisibleInMinimap { get; set; }

		public static void Deserialize(FlagCounterEntityData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.TeamId = (TeamId) p_Reader.ReadInt32();
			p_Instance.EnemyFlagProgress = p_Reader.ReadSingle();
			p_Instance.RoundTime = p_Reader.ReadSingle();
			p_Instance.ObjectiveFlagCount = p_Reader.ReadInt32();
			p_Instance.VisibleInMinimap = p_Reader.ReadBool();
			p_Reader.Seek(15, SeekOrigin.Current);
		}

	}
}
