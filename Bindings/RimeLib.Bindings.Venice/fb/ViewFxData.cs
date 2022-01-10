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
	public class ViewFxData : 
		DataContainer
	{
		[ContainerField(8)]
		public PoissonRadialBlurData PoissonRadialBlur { get; set; } = new();

		[ContainerField(32)]
		public ColorTintData ColorTint { get; set; } = new();

		[ContainerField(96), LayoutImmutable, Blittable]
		public float BlurAdd { get; set; }

		[ContainerField(100), LayoutImmutable, Blittable]
		public bool ColorTintEnable { get; set; }

		[ContainerField(101), LayoutImmutable, Blittable]
		public bool PoissonRadialBlurEnable { get; set; }

		public static void Deserialize(ViewFxData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.PoissonRadialBlurData.Deserialize(p_Instance.PoissonRadialBlur, p_Reader, p_Parser);
			p_Reader.Seek(4, SeekOrigin.Current);
			fb.ColorTintData.Deserialize(p_Instance.ColorTint, p_Reader, p_Parser);
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.BlurAdd = p_Reader.ReadSingle();
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.ColorTintEnable = p_Reader.ReadBool();
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.PoissonRadialBlurEnable = p_Reader.ReadBool();
			p_Reader.Seek(14, SeekOrigin.Current);
		}

	}
}
