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
	[ContainerType(16, 160)]
	public class AntAnimatableComponentData : 
		ComponentData
	{
		[ContainerField(96)]
		public Realm Realm { get; set; } = new();

		[ContainerField(100)]
		public SubRealm SubRealm { get; set; } = new();

		[ContainerField(104)]
		public AntAnimationHandlerData AnimationData { get; set; } = new();

		[ContainerField(152)]
		public CtrRef<SkinnedMeshAsset> Mesh { get; set; } = new();

		[ContainerField(156), LayoutImmutable, Blittable]
		public bool AutoActivate { get; set; }

		[ContainerField(157), LayoutImmutable, Blittable]
		public bool AnimationControlledFromStart { get; set; }

		[ContainerField(158), LayoutImmutable, Blittable]
		public bool ForceDisableCulling { get; set; }

		public static void Deserialize(AntAnimatableComponentData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Realm = (Realm) p_Reader.ReadInt32();
			p_Instance.SubRealm = (SubRealm) p_Reader.ReadInt32();
			fb.AntAnimationHandlerData.Deserialize(p_Instance.AnimationData, p_Reader, p_Parser);
			p_Instance.Mesh.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.AutoActivate = p_Reader.ReadBool();
			p_Instance.AnimationControlledFromStart = p_Reader.ReadBool();
			p_Instance.ForceDisableCulling = p_Reader.ReadBool();
			p_Reader.Seek(1, SeekOrigin.Current);
		}

	}
}
