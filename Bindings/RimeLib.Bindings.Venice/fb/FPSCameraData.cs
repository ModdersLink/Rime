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
	[ContainerType(16, 224)]
	public class FPSCameraData : 
		TargetCameraData
	{
		[ContainerField(160)]
		public TurnEffectData TurnEffectSettings { get; set; } = new();

		[ContainerField(192)]
		public BlurEffectData BlurEffectSettings { get; set; } = new();

		[ContainerField(216), LayoutImmutable, Blittable]
		public float FOV { get; set; }

		public static void Deserialize(FPSCameraData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.TurnEffectData.Deserialize(p_Instance.TurnEffectSettings, p_Reader, p_Parser);
			fb.BlurEffectData.Deserialize(p_Instance.BlurEffectSettings, p_Reader, p_Parser);
			p_Instance.FOV = p_Reader.ReadSingle();
			p_Reader.Seek(4, SeekOrigin.Current);
		}

	}
}
