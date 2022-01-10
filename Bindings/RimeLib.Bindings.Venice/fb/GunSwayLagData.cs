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
	[ContainerType(4, 20)]
	public class GunSwayLagData
	{
		[ContainerField(0), LayoutImmutable, Blittable]
		public float MoveStrafeModifier { get; set; }
		
		[ContainerField(4), LayoutImmutable, Blittable]
		public float MoveForwardModifier { get; set; }
		
		[ContainerField(8), LayoutImmutable, Blittable]
		public float RotateYawModifier { get; set; }
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public float RotatePitchModifier { get; set; }
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public float ReleaseModifier { get; set; }
		
		public static void Deserialize(GunSwayLagData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.MoveStrafeModifier = p_Reader.ReadSingle();
			p_Instance.MoveForwardModifier = p_Reader.ReadSingle();
			p_Instance.RotateYawModifier = p_Reader.ReadSingle();
			p_Instance.RotatePitchModifier = p_Reader.ReadSingle();
			p_Instance.ReleaseModifier = p_Reader.ReadSingle();
		}
	}
}
