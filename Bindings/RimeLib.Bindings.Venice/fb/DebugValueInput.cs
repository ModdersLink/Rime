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
	public class DebugValueInput : 
		AudioGraphNodePortGroup
	{
		[ContainerField(8)]
		public AudioGraphNodePort V { get; set; } = new();

		[ContainerField(16), LayoutImmutable]
		public string Name { get; set; } = string.Empty;

		[ContainerField(20)]
		public DebugRenderType RenderType { get; set; } = new();

		[ContainerField(24), LayoutImmutable, Blittable]
		public float Min { get; set; }

		[ContainerField(28), LayoutImmutable, Blittable]
		public float Max { get; set; }

		public static void Deserialize(DebugValueInput p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.AudioGraphNodePort.Deserialize(p_Instance.V, p_Reader, p_Parser);
			p_Instance.Name = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.RenderType = (DebugRenderType) p_Reader.ReadInt32();
			p_Instance.Min = p_Reader.ReadSingle();
			p_Instance.Max = p_Reader.ReadSingle();
		}

	}
}
