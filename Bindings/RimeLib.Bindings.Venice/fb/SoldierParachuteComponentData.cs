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
	public class SoldierParachuteComponentData : 
		ComponentData
	{
		[ContainerField(96)]
		public SoldierParachuteBinding Binding { get; set; } = new();

		[ContainerField(116)]
		public AimingConstraintsData AimingConstraints { get; set; } = new();

		[ContainerField(132), LayoutImmutable, Blittable]
		public float UndeployTime { get; set; }

		public static void Deserialize(SoldierParachuteComponentData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.SoldierParachuteBinding.Deserialize(p_Instance.Binding, p_Reader, p_Parser);
			fb.AimingConstraintsData.Deserialize(p_Instance.AimingConstraints, p_Reader, p_Parser);
			p_Instance.UndeployTime = p_Reader.ReadSingle();
			p_Reader.Seek(8, SeekOrigin.Current);
		}

	}
}
