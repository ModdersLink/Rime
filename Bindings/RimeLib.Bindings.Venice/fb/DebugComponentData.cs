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
	public class DebugComponentData : 
		ComponentData
	{
		[ContainerField(96)]
		public Realm Realm { get; set; } = new();

		[ContainerField(100)]
		public CtrRef<TextureAsset> DebugTexture { get; set; } = new();

		[ContainerField(104), LayoutImmutable, Blittable]
		public bool Fullscreen { get; set; }

		[ContainerField(105), LayoutImmutable, Blittable]
		public bool Enable { get; set; }

		public static void Deserialize(DebugComponentData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Realm = (Realm) p_Reader.ReadInt32();
			p_Instance.DebugTexture.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.Fullscreen = p_Reader.ReadBool();
			p_Instance.Enable = p_Reader.ReadBool();
			p_Reader.Seek(6, SeekOrigin.Current);
		}

	}
}
