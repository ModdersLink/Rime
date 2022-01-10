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
	[ContainerType(4, 28)]
	public class ReceiveEntry : 
		AudioGraphNodePortGroup
	{
		[ContainerField(8)]
		public AudioGraphNodePort Out { get; set; } = new();

		[ContainerField(16)]
		public CtrRef<AudioGraphParameter> Source { get; set; } = new();

		[ContainerField(20), LayoutImmutable, Blittable]
		public float Parameter { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable]
		public float SavedValue { get; set; }

		public static void Deserialize(ReceiveEntry p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.AudioGraphNodePort.Deserialize(p_Instance.Out, p_Reader, p_Parser);
			p_Instance.Source.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.Parameter = p_Reader.ReadSingle();
			p_Instance.SavedValue = p_Reader.ReadSingle();
		}

	}
}
