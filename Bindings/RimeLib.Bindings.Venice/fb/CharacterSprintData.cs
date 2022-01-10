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
	public class CharacterSprintData : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable, Blittable]
		public float SprintPowerDecreasePerSecond { get; set; }

		[ContainerField(12), LayoutImmutable, Blittable]
		public float SprintPowerIncreasePerSecond { get; set; }

		[ContainerField(16), LayoutImmutable, Blittable]
		public float SprintMinimumPower { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable]
		public bool AllowContinousSprinting { get; set; }

		public static void Deserialize(CharacterSprintData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.SprintPowerDecreasePerSecond = p_Reader.ReadSingle();
			p_Instance.SprintPowerIncreasePerSecond = p_Reader.ReadSingle();
			p_Instance.SprintMinimumPower = p_Reader.ReadSingle();
			p_Instance.AllowContinousSprinting = p_Reader.ReadBool();
			p_Reader.Seek(3, SeekOrigin.Current);
		}

	}
}
