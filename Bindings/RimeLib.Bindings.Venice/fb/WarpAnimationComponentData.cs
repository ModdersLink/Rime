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
	[ContainerType(16, 240)]
	public class WarpAnimationComponentData : 
		ComponentData
	{
		[ContainerField(96), Homogeneous, LayoutImmutable, Blittable]
		public LinearTransform ConnectTransform { get; set; } = new();

		[ContainerField(160)]
		public CannedAnimationBinding CannedAnimBinding { get; set; } = new();

		[ContainerField(200), LayoutImmutable, Blittable]
		public int AnimationEntitySpacePriority { get; set; }

		[ContainerField(204)]
		public WarpAnimationBinding WarpBinding { get; set; } = new();

		[ContainerField(224)]
		public GameplayBones BoneToAlign { get; set; } = new();

		[ContainerField(228), LayoutImmutable, Blittable]
		public bool RequireAnimationWeight { get; set; }

		[ContainerField(229), LayoutImmutable, Blittable]
		public bool ForceAnimationTransform { get; set; }

		[ContainerField(230), LayoutImmutable, Blittable]
		public bool ExternalConnectTransform { get; set; }

		public static void Deserialize(WarpAnimationComponentData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.LinearTransform.Deserialize(p_Instance.ConnectTransform, p_Reader, p_Parser);
			fb.CannedAnimationBinding.Deserialize(p_Instance.CannedAnimBinding, p_Reader, p_Parser);
			p_Instance.AnimationEntitySpacePriority = p_Reader.ReadInt32();
			fb.WarpAnimationBinding.Deserialize(p_Instance.WarpBinding, p_Reader, p_Parser);
			p_Instance.BoneToAlign = (GameplayBones) p_Reader.ReadInt32();
			p_Instance.RequireAnimationWeight = p_Reader.ReadBool();
			p_Instance.ForceAnimationTransform = p_Reader.ReadBool();
			p_Instance.ExternalConnectTransform = p_Reader.ReadBool();
			p_Reader.Seek(9, SeekOrigin.Current);
		}

	}
}
