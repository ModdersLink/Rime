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
	public class CharacterAnimationEntityData : 
		EntityData
	{
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable]
		public LinearTransform EntitySpaceTransform { get; set; } = new();

		[ContainerField(80)]
		public AntRef Controller { get; set; } = new();

		[ContainerField(84), LayoutImmutable, Blittable]
		public float TrackLength { get; set; }

		[ContainerField(88), LayoutImmutable, Blittable]
		public float ExternalTime { get; set; }

		[ContainerField(92), LayoutImmutable, Blittable]
		public float WarpAnimationBlendTime { get; set; }

		[ContainerField(96), LayoutImmutable, Blittable]
		public bool RestoreControllerOnFinish { get; set; }

		public static void Deserialize(CharacterAnimationEntityData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Reader.Seek(4, SeekOrigin.Current);
			fb.LinearTransform.Deserialize(p_Instance.EntitySpaceTransform, p_Reader, p_Parser);
			p_Reader.Seek(4, SeekOrigin.Current);
			fb.AntRef.Deserialize(p_Instance.Controller, p_Reader, p_Parser);
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.TrackLength = p_Reader.ReadSingle();
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.ExternalTime = p_Reader.ReadSingle();
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.WarpAnimationBlendTime = p_Reader.ReadSingle();
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.RestoreControllerOnFinish = p_Reader.ReadBool();
			p_Reader.Seek(19, SeekOrigin.Current);
		}

	}
}
