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
	public class CharacterAnimationSpaceEntityData : 
		EntityData
	{
		[ContainerField(12)]
		public Realm Realm { get; set; } = new();

		[ContainerField(16)]
		public AntRef SpacePositionGS { get; set; } = new();

		[ContainerField(20)]
		public AntRef SpaceRotationGS { get; set; } = new();

		[ContainerField(24), LayoutImmutable, Blittable]
		public float WarpAnimationBlendTime { get; set; }

		public static void Deserialize(CharacterAnimationSpaceEntityData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Realm = (Realm) p_Reader.ReadInt32();
			fb.AntRef.Deserialize(p_Instance.SpacePositionGS, p_Reader, p_Parser);
			fb.AntRef.Deserialize(p_Instance.SpaceRotationGS, p_Reader, p_Parser);
			p_Instance.WarpAnimationBlendTime = p_Reader.ReadSingle();
		}

	}
}
