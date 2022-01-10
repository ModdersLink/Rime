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
	public class TurretData : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable, Blittable]
		public float PitchP { get; set; }

		[ContainerField(12), LayoutImmutable, Blittable]
		public float YawP { get; set; }

		[ContainerField(16), LayoutImmutable, Blittable]
		public float FakeShootSpaceMinDistance { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable]
		public float FakeShootSpaceMaxDistance { get; set; }

		[ContainerField(24)]
		public CtrRef<AIAimingConstraintsData> AimingConstraints { get; set; } = new();

		public static void Deserialize(TurretData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.PitchP = p_Reader.ReadSingle();
			p_Instance.YawP = p_Reader.ReadSingle();
			p_Instance.FakeShootSpaceMinDistance = p_Reader.ReadSingle();
			p_Instance.FakeShootSpaceMaxDistance = p_Reader.ReadSingle();
			p_Instance.AimingConstraints.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
		}

	}
}
