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
	[ContainerType(16, 112)]
	public class SoldierBodyComponentData : 
		ComponentData
	{
		[ContainerField(96), LayoutImmutable, Blittable]
		public float SprintMultiplier { get; set; }

		[ContainerField(100), LayoutImmutable, Blittable]
		public float OverrideGravityValue { get; set; }

		[ContainerField(104), LayoutImmutable, Blittable]
		public float OverrideVelocityY { get; set; }

		[ContainerField(108), LayoutImmutable, Blittable]
		public bool OverrideVelocity { get; set; }

		[ContainerField(109), LayoutImmutable, Blittable]
		public bool OverrideGravity { get; set; }

		public static void Deserialize(SoldierBodyComponentData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.SprintMultiplier = p_Reader.ReadSingle();
			p_Instance.OverrideGravityValue = p_Reader.ReadSingle();
			p_Instance.OverrideVelocityY = p_Reader.ReadSingle();
			p_Instance.OverrideVelocity = p_Reader.ReadBool();
			p_Instance.OverrideGravity = p_Reader.ReadBool();
			p_Reader.Seek(2, SeekOrigin.Current);
		}

	}
}
