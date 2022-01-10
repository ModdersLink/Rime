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
	public class OnGroundStateData : 
		CharacterStateData
	{
		[ContainerField(12), LayoutImmutable, Blittable]
		public float JumpDelay { get; set; }

		[ContainerField(16), LayoutImmutable, Blittable]
		public float JumpStaminaPenalty { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable]
		public float AllowedDistanceFromGround { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable]
		public bool GroundHugging { get; set; }

		[ContainerField(25), LayoutImmutable, Blittable]
		public bool LimitDownwardVelocity { get; set; }

		public static void Deserialize(OnGroundStateData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.JumpDelay = p_Reader.ReadSingle();
			p_Instance.JumpStaminaPenalty = p_Reader.ReadSingle();
			p_Instance.AllowedDistanceFromGround = p_Reader.ReadSingle();
			p_Instance.GroundHugging = p_Reader.ReadBool();
			p_Instance.LimitDownwardVelocity = p_Reader.ReadBool();
			p_Reader.Seek(2, SeekOrigin.Current);
		}

	}
}
