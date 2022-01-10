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
	public class ScreenEffectComponentData : 
		ComponentData
	{
		[ContainerField(96), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 ScreenEffectParams { get; set; } = new();

		[ContainerField(112)]
		public ScreenEffectFrameType FrameType { get; set; } = new();

		[ContainerField(116)]
		public CtrRef<SurfaceShaderBaseAsset> Shader { get; set; } = new();

		[ContainerField(120), LayoutImmutable, Blittable]
		public float FrameWidth { get; set; }

		[ContainerField(124), LayoutImmutable, Blittable]
		public float OuterFrameOpacity { get; set; }

		[ContainerField(128), LayoutImmutable, Blittable]
		public float InnerFrameOpacity { get; set; }

		[ContainerField(132), LayoutImmutable, Blittable]
		public float Angle { get; set; }

		[ContainerField(136)]
		public Realm Realm { get; set; } = new();

		public static void Deserialize(ScreenEffectComponentData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.Vec4.Deserialize(p_Instance.ScreenEffectParams, p_Reader, p_Parser);
			p_Instance.FrameType = (ScreenEffectFrameType) p_Reader.ReadInt32();
			p_Instance.Shader.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.FrameWidth = p_Reader.ReadSingle();
			p_Instance.OuterFrameOpacity = p_Reader.ReadSingle();
			p_Instance.InnerFrameOpacity = p_Reader.ReadSingle();
			p_Instance.Angle = p_Reader.ReadSingle();
			p_Instance.Realm = (Realm) p_Reader.ReadInt32();
			p_Reader.Seek(4, SeekOrigin.Current);
		}

	}
}
