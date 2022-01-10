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
	[ContainerType(4, 32)]
	public class DebugConstantData : 
		Asset
	{
		[ContainerField(12), LayoutImmutable, Blittable]
		public float BotDebugDistance { get; set; }

		[ContainerField(16), LayoutImmutable, Blittable]
		public float InViewModeFOV { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable]
		public uint GraphDataBuffer { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable]
		public float MinDecisionTime { get; set; }

		[ContainerField(28), LayoutImmutable, Blittable]
		public bool InaccuracyEnabled { get; set; }

		public static void Deserialize(DebugConstantData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.BotDebugDistance = p_Reader.ReadSingle();
			p_Instance.InViewModeFOV = p_Reader.ReadSingle();
			p_Instance.GraphDataBuffer = p_Reader.ReadUInt32();
			p_Instance.MinDecisionTime = p_Reader.ReadSingle();
			p_Instance.InaccuracyEnabled = p_Reader.ReadBool();
			p_Reader.Seek(3, SeekOrigin.Current);
		}

	}
}
