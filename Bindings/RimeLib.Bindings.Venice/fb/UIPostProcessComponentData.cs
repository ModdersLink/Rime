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
	[ContainerType(4, 72)]
	public class UIPostProcessComponentData : 
		UIComponentData
	{
		[ContainerField(28), LayoutImmutable, Blittable]
		public float HighlightThreshold { get; set; }

		[ContainerField(32), LayoutImmutable, Blittable]
		public float XPower { get; set; }

		[ContainerField(36), LayoutImmutable, Blittable]
		public float YPower { get; set; }

		[ContainerField(40), LayoutImmutable, Blittable]
		public float Distort { get; set; }

		[ContainerField(44), LayoutImmutable, Blittable]
		public float TimeScale { get; set; }

		[ContainerField(48)]
		public CtrRef<TextureAsset> NoiseTexture { get; set; } = new();

		[ContainerField(52), LayoutImmutable, Blittable]
		public float Highlight { get; set; }

		[ContainerField(56), LayoutImmutable, Blittable]
		public float RShift { get; set; }

		[ContainerField(60), LayoutImmutable, Blittable]
		public float GShift { get; set; }

		[ContainerField(64), LayoutImmutable, Blittable]
		public float BShift { get; set; }

		[ContainerField(68), LayoutImmutable, Blittable]
		public bool TweakMode { get; set; }

		[ContainerField(69), LayoutImmutable, Blittable]
		public bool Enabled { get; set; }

		public static void Deserialize(UIPostProcessComponentData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.HighlightThreshold = p_Reader.ReadSingle();
			p_Instance.XPower = p_Reader.ReadSingle();
			p_Instance.YPower = p_Reader.ReadSingle();
			p_Instance.Distort = p_Reader.ReadSingle();
			p_Instance.TimeScale = p_Reader.ReadSingle();
			p_Instance.NoiseTexture.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.Highlight = p_Reader.ReadSingle();
			p_Instance.RShift = p_Reader.ReadSingle();
			p_Instance.GShift = p_Reader.ReadSingle();
			p_Instance.BShift = p_Reader.ReadSingle();
			p_Instance.TweakMode = p_Reader.ReadBool();
			p_Instance.Enabled = p_Reader.ReadBool();
			p_Reader.Seek(2, SeekOrigin.Current);
		}

	}
}
