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
	[ContainerType(4, 24)]
	public class EntitySettings : 
		SystemSettings
	{
		[ContainerField(12), LayoutImmutable, Blittable]
		public uint OutOfEntityBusNetworkIdThreshold { get; set; }

		[ContainerField(16)]
		public ExecutionModeType ExecutionMode { get; set; } = new();

		[ContainerField(20), LayoutImmutable, Blittable]
		public bool SpawnSubLevelsFromLogic { get; set; }

		[ContainerField(21), LayoutImmutable, Blittable]
		public bool EditorGameViewEnable { get; set; }

		public static void Deserialize(EntitySettings p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.OutOfEntityBusNetworkIdThreshold = p_Reader.ReadUInt32();
			p_Instance.ExecutionMode = (ExecutionModeType) p_Reader.ReadInt32();
			p_Instance.SpawnSubLevelsFromLogic = p_Reader.ReadBool();
			p_Instance.EditorGameViewEnable = p_Reader.ReadBool();
			p_Reader.Seek(2, SeekOrigin.Current);
		}

	}
}
