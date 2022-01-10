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
	[ContainerType(4, 40)]
	public class MultipleTargetPainterWeaponData : 
		WeaponData
	{
		[ContainerField(16)]
		public SpottingType SpottingBehavior { get; set; } = new();

		[ContainerField(20), LayoutImmutable, Blittable]
		public float TimeObjectIsPainted { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable]
		public float Angle { get; set; }

		[ContainerField(28), LayoutImmutable, Blittable]
		public float TimeObjectIsSpotted { get; set; }

		[ContainerField(32), LayoutImmutable, Blittable]
		public float Range { get; set; }

		[ContainerField(36), LayoutImmutable, Blittable]
		public bool UseSpotting { get; set; }

		[ContainerField(37), LayoutImmutable, Blittable]
		public bool UseLaserPainting { get; set; }

		public static void Deserialize(MultipleTargetPainterWeaponData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.SpottingBehavior = (SpottingType) p_Reader.ReadInt32();
			p_Instance.TimeObjectIsPainted = p_Reader.ReadSingle();
			p_Instance.Angle = p_Reader.ReadSingle();
			p_Instance.TimeObjectIsSpotted = p_Reader.ReadSingle();
			p_Instance.Range = p_Reader.ReadSingle();
			p_Instance.UseSpotting = p_Reader.ReadBool();
			p_Instance.UseLaserPainting = p_Reader.ReadBool();
			p_Reader.Seek(2, SeekOrigin.Current);
		}

	}
}
