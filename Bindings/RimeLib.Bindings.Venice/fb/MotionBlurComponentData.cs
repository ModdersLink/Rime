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
	public class MotionBlurComponentData : 
		ComponentData
	{
		[ContainerField(96)]
		public Realm Realm { get; set; } = new();

		[ContainerField(100), LayoutImmutable, Blittable]
		public float CutoffGradientScale { get; set; }

		[ContainerField(104), LayoutImmutable, Blittable]
		public float MotionBlurCutoffRadius { get; set; }

		[ContainerField(108), LayoutImmutable, Blittable]
		public bool MotionBlurEnable { get; set; }

		public static void Deserialize(MotionBlurComponentData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Realm = (Realm) p_Reader.ReadInt32();
			p_Instance.CutoffGradientScale = p_Reader.ReadSingle();
			p_Instance.MotionBlurCutoffRadius = p_Reader.ReadSingle();
			p_Instance.MotionBlurEnable = p_Reader.ReadBool();
			p_Reader.Seek(3, SeekOrigin.Current);
		}

	}
}
