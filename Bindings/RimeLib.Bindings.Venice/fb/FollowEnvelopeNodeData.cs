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
	[ContainerType(4, 36)]
	public class FollowEnvelopeNodeData : 
		AudioGraphNodeData
	{
		[ContainerField(8)]
		public AudioGraphNodePort X { get; set; } = new();

		[ContainerField(16)]
		public AudioGraphNodePort Y { get; set; } = new();

		[ContainerField(24), LayoutImmutable, Blittable]
		public float Base { get; set; }

		[ContainerField(28), LayoutImmutable, Blittable]
		public float Scale { get; set; }

		[ContainerField(32), LayoutImmutable, Blittable]
		public float Pivot { get; set; }

		public static void Deserialize(FollowEnvelopeNodeData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.AudioGraphNodePort.Deserialize(p_Instance.X, p_Reader, p_Parser);
			fb.AudioGraphNodePort.Deserialize(p_Instance.Y, p_Reader, p_Parser);
			p_Instance.Base = p_Reader.ReadSingle();
			p_Instance.Scale = p_Reader.ReadSingle();
			p_Instance.Pivot = p_Reader.ReadSingle();
		}

	}
}
