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
	public class FilmGrainComponentData : 
		ComponentData
	{
		[ContainerField(96), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 ColorScale { get; set; } = new();

		[ContainerField(112), Homogeneous, LayoutImmutable, Blittable]
		public Vec2 TextureScale { get; set; } = new();

		[ContainerField(120)]
		public Realm Realm { get; set; } = new();

		[ContainerField(124)]
		public CtrRef<TextureAsset> Texture { get; set; } = new();

		[ContainerField(128), LayoutImmutable, Blittable]
		public bool LinearFilteringEnable { get; set; }

		[ContainerField(129), LayoutImmutable, Blittable]
		public bool RandomEnable { get; set; }

		[ContainerField(130), LayoutImmutable, Blittable]
		public bool Enable { get; set; }

		public static void Deserialize(FilmGrainComponentData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.Vec3.Deserialize(p_Instance.ColorScale, p_Reader, p_Parser);
			fb.Vec2.Deserialize(p_Instance.TextureScale, p_Reader, p_Parser);
			p_Instance.Realm = (Realm) p_Reader.ReadInt32();
			p_Instance.Texture.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.LinearFilteringEnable = p_Reader.ReadBool();
			p_Instance.RandomEnable = p_Reader.ReadBool();
			p_Instance.Enable = p_Reader.ReadBool();
			p_Reader.Seek(13, SeekOrigin.Current);
		}

	}
}
