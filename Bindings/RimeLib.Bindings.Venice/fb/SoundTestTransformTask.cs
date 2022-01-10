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
	[ContainerType(16, 48)]
	public class SoundTestTransformTask : 
		SoundTestTaskSpec
	{
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 InitialPosition { get; set; } = new();

		[ContainerField(32)]
		public SoundTestTransformBehavior Behavior { get; set; } = new();

		[ContainerField(36), LayoutImmutable, Blittable]
		public bool RelativeListener { get; set; }

		public static void Deserialize(SoundTestTransformTask p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.Vec3.Deserialize(p_Instance.InitialPosition, p_Reader, p_Parser);
			p_Instance.Behavior = (SoundTestTransformBehavior) p_Reader.ReadInt32();
			p_Instance.RelativeListener = p_Reader.ReadBool();
			p_Reader.Seek(11, SeekOrigin.Current);
		}

	}
}
