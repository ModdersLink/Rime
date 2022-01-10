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
	public class WarpAnimationEntityData : 
		EntityData
	{
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable]
		public LinearTransform ConnectTransform { get; set; } = new();

		[ContainerField(80), LayoutImmutable, Blittable]
		public int AnimationEntitySpacePriority { get; set; }

		[ContainerField(84)]
		public WarpAnimationBinding WarpBinding { get; set; } = new();

		[ContainerField(104)]
		public GameplayBones BoneToAlign { get; set; } = new();

		[ContainerField(108), LayoutImmutable, Blittable]
		public bool ForceAnimationTransform { get; set; }

		[ContainerField(109), LayoutImmutable, Blittable]
		public bool RequireAnimationWeight { get; set; }

		[ContainerField(110), LayoutImmutable, Blittable]
		public bool ExternalConnectTransform { get; set; }

		public static void Deserialize(WarpAnimationEntityData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Reader.Seek(4, SeekOrigin.Current);
			fb.LinearTransform.Deserialize(p_Instance.ConnectTransform, p_Reader, p_Parser);
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.AnimationEntitySpacePriority = p_Reader.ReadInt32();
			p_Reader.Seek(4, SeekOrigin.Current);
			fb.WarpAnimationBinding.Deserialize(p_Instance.WarpBinding, p_Reader, p_Parser);
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.BoneToAlign = (GameplayBones) p_Reader.ReadInt32();
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.ForceAnimationTransform = p_Reader.ReadBool();
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.RequireAnimationWeight = p_Reader.ReadBool();
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.ExternalConnectTransform = p_Reader.ReadBool();
			p_Reader.Seek(5, SeekOrigin.Current);
		}

	}
}
