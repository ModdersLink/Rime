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
	public class ClimbLadderComponentData : 
		ComponentData
	{
		[ContainerField(96), LayoutImmutable, Blittable]
		public int ClimbPhase { get; set; }

		[ContainerField(100), LayoutImmutable, Blittable]
		public int ConnectPhase { get; set; }

		[ContainerField(104), LayoutImmutable, Blittable]
		public float ConnectJointDisplacement { get; set; }

		[ContainerField(108)]
		public ClimbLadderBinding Binding { get; set; } = new();

		public static void Deserialize(ClimbLadderComponentData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.ClimbPhase = p_Reader.ReadInt32();
			p_Instance.ConnectPhase = p_Reader.ReadInt32();
			p_Instance.ConnectJointDisplacement = p_Reader.ReadSingle();
			fb.ClimbLadderBinding.Deserialize(p_Instance.Binding, p_Reader, p_Parser);
			p_Reader.Seek(12, SeekOrigin.Current);
		}

	}
}
